using Microsoft.EntityFrameworkCore;
using PasswordManager_API.Context;
using PasswordManager_API.DTOs;
using PasswordManager_API.Entities;
using PasswordManager_API.Interfaces;

namespace PasswordManager_API.Services
{
    public class UserProfileAppService : IUserProfileInterface
    {
        private readonly PasswordManagerDbContext _context;
        public UserProfileAppService(PasswordManagerDbContext context)
        {
            _context = context;
        }
        public async Task<UserProfileDTO> GetProfileDTO(int userId)
        {
            var profile = await _context.Profiles.Where(x => x.UserId == userId)
                 .Select(x => new UserProfileDTO
                 {
                     ProfileId = x.Id,
                     Email = x.Email,
                     FullName = x.FirstName + " " + x.LastName,
                     Image = x.Image != null ? x.Image : "https://static-00.iconduck.com/assets.00/thinking-person-3-illustration-1131x2048-bhm4syl4.png",
                     Phone = x.Phone
                 }).FirstOrDefaultAsync();

            return profile;
        }

        public async Task UpdateUserImage(int userId, string url)
        {
            var profile = await _context.Profiles.Where(x => x.UserId == userId).FirstOrDefaultAsync();
            if (profile == null)
            {
                throw new Exception("No User Found With The Given Id");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(url))
                {
                    profile.Image = url;
                }
                _context.Update(profile);
                _context.SaveChanges();
            }
        }

        public async Task UpdateUserProfile(UpdateUserProfileInputDTO input)
        {
            var profile = await _context.Profiles.Where(x => x.Id == input.Id).FirstOrDefaultAsync();
            if (profile == null)
            {
                throw new Exception("No User Found With The Given Id");
            }
            else
            {
                if (input.Email != null)
                {
                    profile.Email = input.Email;
                }
                if (input.FirstName != null)
                {
                    profile.FirstName = input.FirstName;
                }
                if (input.LastName != null)
                {
                    profile.LastName = input.LastName;
                }
                if (!string.IsNullOrWhiteSpace(input.Image))
                { profile.Image = input.Image; }
                if (!string.IsNullOrWhiteSpace(input.Phone))
                { profile.Phone = input.Phone; }

                _context.Update(profile);
                _context.SaveChanges();
            }
        }
    }
}
