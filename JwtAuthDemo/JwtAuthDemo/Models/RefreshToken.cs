﻿namespace JwtAuthDemo.Models
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string TokenId { get; set; } 
        public string RefreshUserToken { get; set; }
        public User UserNavigation { get; set; } // Navigation property to User
    }
}
