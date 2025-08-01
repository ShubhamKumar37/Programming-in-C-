using JwtAuthDemo.Data;
using JwtAuthDemo.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;


namespace JwtAuthDemo.Services
{
    public class TokenService
    {
        private readonly IConfiguration _configrration;
        private readonly AppDbContext _context;

        public TokenService(IConfiguration configuration, AppDbContext context)
        {
            _configrration = configuration;
            _context = context;
        }

        public string GenerateAccessToken(User user)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, user.Role)
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configrration["JwtSetting:SecretKey"]));
            var creds =new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.UtcNow.AddMinutes(Convert.ToDouble(_configrration["JwtSetting:AccessTokenExpiration"]));

            var newToken = new JwtSecurityToken(
                issuer: _configrration["JwtSetting:Issuer"],
                audience: _configrration["JwtSetting:Audience"],
                claims: claims,
                expires: expires,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(newToken);
        }

        public string GenerateRefreshToken(int userId)
        {
            var tokenId = Guid.NewGuid().ToString() ;
            var refreshToken = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));

            var expiryDays = Convert.ToInt32(_configrration["JwtSetting:RefreshTokenExpiration"]);
            var expiryDate = DateTime.UtcNow.AddDays(expiryDays);

            var token = new RefreshToken
            {
                UserId = userId,
                TokenId = tokenId,
                RefreshUserToken = refreshToken
            };  

            _context.RefreshTokens.Add(token);
            _context.SaveChanges();

            return refreshToken;
        }

        public RefreshToken? GetRefreshToken(string refreshToken)
        {
            return _context.RefreshTokens.FirstOrDefault(rt => rt.RefreshUserToken == refreshToken);
        }

        public void RevokeRefreshToken(string refreshToken)
        {
            var token = _context.RefreshTokens.FirstOrDefault(rt => rt.RefreshUserToken == refreshToken);
            if (token != null)
            {
                _context.RefreshTokens.Remove(token);
                _context.SaveChanges();
            }
        }
    }
}
