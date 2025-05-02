using PasswordManager_API.DTOs.Accounts;

namespace PasswordManager_API.Interfaces
{
    public interface IAccountInterface
    {
        Task<List<AccountDTO>> GetMyAccounts(int userId);
        Task<AccountDetailDTO> GetDetailDTO(int Id);
        Task<List<AccountDTO>> SearchAccount(AccountSearchInputDTO input);
        Task<string> CopyAccountOrignizalPassword(int Id);
        Task<string> GenerateStrongPassword(int length);
        Task<string> CreateUpdateAccount(CreateUpdateAccountInputDTO input);
    }
}
