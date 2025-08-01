using JwtAuthDemo.Data;
using JwtAuthDemo.Models;
using JwtAuthDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly AppDbContext _context;
        private readonly TokenService _tokenService;
        public AuthorizeController(IConfiguration configuration, AppDbContext context, TokenService tokenService)
        {
            _configuration = configuration;
            _context = context;
            _tokenService = tokenService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            // if (user == null || string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password)) return BadRequest("Invalid user data.");
            var existingUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == user.UserName);
            
            if (existingUser != null) return Conflict("User already exists.");
            user.Id = 0;
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok("User registered successfully.");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] User user)
        {
            if (user == null || string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password)) return BadRequest("Invalid login data.");
            
            var existingUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == user.UserName);
            if (existingUser == null || existingUser.Password != user.Password) return Unauthorized("Invalid username or password.");
            
            var tokenService = new TokenService(_configuration, _context);
            var accessToken = tokenService.GenerateAccessToken(existingUser);
            var refreshToken = tokenService.GenerateRefreshToken(existingUser.Id);
            
            return Ok(new { AccessToken = accessToken, RefreshToken = refreshToken });
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh([FromBody] TokenModel model)
        {
            var refreshToken = _tokenService.GetRefreshToken(model.RefreshToken);
            if(refreshToken == null) return Unauthorized("Invalid refresh token.");

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == refreshToken.UserId);
            if(user == null) return Unauthorized("User not found.");

            var newAccessToken = _tokenService.GenerateAccessToken(user);
            var newRefreshToken = _tokenService.GenerateRefreshToken(user.Id);

            _tokenService.RevokeRefreshToken(refreshToken.RefreshUserToken);

            return Ok(new 
            { 
                AccessToken = newAccessToken, 
                RefreshToken = newRefreshToken 
            });
        }
    }
}
