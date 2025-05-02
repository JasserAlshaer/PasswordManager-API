namespace PasswordManager_API.Entities
{
    public class User : ParentEntity
    {
        public string UserName { get; set; } //hashed
        public string Password { get; set; } //hased 
        public string Email { get; set; } //hashed
        public string? OTPCode { get; set; }
        public DateTime? OTPExipry { get; set; }
        public int RoleId { get; set; }
        public bool IsVerfied { get; set; } = false;
        public bool? IsLoggedIn { get; set; } 
        public DateTime? LastLoginTime { get; set; }
    }
}
