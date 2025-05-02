using PasswordManager_API.DTOs.Providers;
using PasswordManager_API.Entities;

namespace PasswordManager_API.Interfaces
{
    public interface IProviderInterface
    {
        Task<ProviderDetailsDTO> GetProviderDetails(int Id);
        Task<List<ProviderDTO>> GetProviders();
        Task<string> CreateUpdateProvider(CreateUpdateProviderDTO input);
    }
}
