namespace PasswordManager_API.DTOs.Accounts
{
    public class AccountSearchInputDTO
    {
        public int UserId   { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public string? ProviderName { get; set; }
    }
}
