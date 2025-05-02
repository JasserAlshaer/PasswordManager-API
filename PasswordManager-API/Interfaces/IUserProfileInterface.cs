using PasswordManager_API.DTOs;

namespace PasswordManager_API.Interfaces
{
    public interface IUserProfileInterface
    {
        Task<UserProfileDTO> GetProfileDTO(int userId);
        Task UpdateUserProfile(UpdateUserProfileInputDTO input);
        Task UpdateUserImage(int userId, string url);
    }
}
