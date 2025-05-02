using Microsoft.EntityFrameworkCore;
using PasswordManager_API.Context;
using PasswordManager_API.DTOs.Providers;
using PasswordManager_API.Entities;
using PasswordManager_API.Interfaces;

namespace PasswordManager_API.Services
{
    public class ProviderAppService : IProviderInterface
    {
        private readonly PasswordManagerDbContext _context;
        public ProviderAppService(PasswordManagerDbContext context)
        {
            _context = context;
        }
        public async Task<string> CreateUpdateProvider(CreateUpdateProviderDTO input)
        {
            if(input.Id != null)
            {
                //update
                var item = await _context.Providers.FirstOrDefaultAsync(x => x.Id == input.Id);
                if (item != null)
                {
                    if(input.SiteURL != null)
                    {
                        item.SiteURL = input.SiteURL;
                    }
                    if (input.Name != null)
                    {
                        item.Name = input.Name;
                    }
                    if (input.Image != null)
                    {
                        item.Image = input.Image;
                    }
                    _context.Update(item);
                    _context.SaveChanges();
                         return "Provider Has Been Updated";
                }
                return "Not Founded Provider";
            }
            else
            {
                //create
                Provider provider = new Provider();
                provider.SiteURL = input.SiteURL;
                provider.Name = input.Name;
                provider.Image = input.Image;

                _context.Add(provider);
                _context.SaveChanges();

                return "New Provierd Has Been Added";
            }
        }

        public async Task<ProviderDetailsDTO> GetProviderDetails(int Id)
        {
            var query = _context.Providers.Where(p => p.Id == Id).Select(p => new ProviderDetailsDTO
            {
                Id = p.Id,
                CreationDate = p.CreationDate.ToShortDateString(),
                Image = p.Image,
                Name = p.Name,
                SiteURL = p.SiteURL
            }).FirstOrDefault();
            return query;
        }

        public async Task<List<ProviderDTO>> GetProviders()
        {
            var query = from p in _context.Providers
                        select new ProviderDTO
                        {
                            Id = p.Id,
                            Name = p.Name,
                            Image = p.Image
                        };
            return await query.ToListAsync();
        }
    }
}
