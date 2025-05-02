namespace PasswordManager_API.DTOs
{
    public class UpdateUserProfileInputDTO
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string? Image { get; set; }
        public int Id { get; set; }
    }
}
