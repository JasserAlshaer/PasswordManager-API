﻿namespace PasswordManager_API.DTOs
{
    public class UserProfileDTO
    {
        public int ProfileId { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }
    }
}
