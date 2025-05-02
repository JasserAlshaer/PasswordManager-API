using Microsoft.EntityFrameworkCore;
using PasswordManager_API.Context;
using PasswordManager_API.DTOs.Accounts;
using PasswordManager_API.Entities;
using PasswordManager_API.Interfaces;
using System.Text;

namespace PasswordManager_API.Services
{
    public class AccountAppService : IAccountInterface
    {
        private readonly PasswordManagerDbContext _context;
        public AccountAppService(PasswordManagerDbContext context)
        {
            _context = context;
        }
        public async Task<string> CopyAccountOrignizalPassword(int Id)
        {
            var query = from a in _context.Accounts
                        where a.Id == Id
                        select new
                        {

                        };
            //Decypt 
            return "";
        }

        public async Task<string> CreateUpdateAccount(CreateUpdateAccountInputDTO input)
        {
            // Validate input
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (string.IsNullOrWhiteSpace(input.Username))
                throw new ArgumentException("Username is required.");

            if (string.IsNullOrWhiteSpace(input.Password))
                throw new ArgumentException("Password is required.");
            Account account;
            if (input.Id.HasValue)
            {
                // Update existing account
                account = await _context.Accounts.FindAsync(input.Id.Value);
                if (account == null)
                    throw new InvalidOperationException($"Account with ID {input.Id} not found.");

                // Update fields
                account.Title = input.Title ?? account.Title;
                account.Description = input.Description ?? account.Description;
              
                account.UsernameTypeId = input.UsernameTypeId ?? account.UsernameTypeId;
                account.UserId = input.UserId ?? account.UserId;
                account.Username = input.Username ?? account.Username; // encryption
                account.Password = input.Password ?? account.Password;// encryption
                account.CategoryId = input.CategoryId ?? account.CategoryId;
                account.ProviderId = input.ProviderId ?? account.ProviderId;

                _context.Accounts.Update(account);
            }
            else
            {
                // Create new account
                account = new Account
                {
                    Title = input.Title,
                    Description = input.Description,
                    Username = input.Username,// encryption
                    Password = input.Password,// encryption
                    UsernameTypeId = input.UsernameTypeId ?? throw new ArgumentException("UsernameTypeId is required."),
                    UserId = input.UserId ?? throw new ArgumentException("UserId is required."),
                    CategoryId = input.CategoryId ?? throw new ArgumentException("CategoryId is required."),
                    ProviderId = input.ProviderId
                };

                await _context.Accounts.AddAsync(account);
            }

            // Save changes to the database
            await _context.SaveChangesAsync();

            return input.Id.HasValue ? "Account updated successfully." : "Account created successfully.";
        }

        public async Task<string> GenerateStrongPassword(int length)
        {
            if (length < 6)
                throw new ArgumentException("Password length should be at least 6 characters.");

            const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string specialChars = "!@#$%^&*()_+-=[]{}|;:,.<>?";

            Random random = new Random();

            // Ensure at least one character from each category
            var password = new StringBuilder()
                .Append(upperChars[random.Next(upperChars.Length)])
                .Append(lowerChars[random.Next(lowerChars.Length)])
                .Append(digits[random.Next(digits.Length)])
                .Append(specialChars[random.Next(specialChars.Length)]);

            // Fill the remaining length with a mix of all characters
            string allChars = upperChars + lowerChars + digits + specialChars;
            for (int i = password.Length; i < length; i++)
            {
                password.Append(allChars[random.Next(allChars.Length)]);
            }

            // Shuffle the password to randomize character order
            return new string(password.ToString().OrderBy(_ => random.Next()).ToArray());
        }

        public async Task<AccountDetailDTO> GetDetailDTO(int Id)
        {
            var query = await _context.Accounts.Where(a => a.Id == Id).Select(x => new AccountDetailDTO
            {
                Id = x.Id,
                Category = _context.LookupItems.Any(l => l.Id == x.CategoryId) ? _context.LookupItems.FirstOrDefault(l => l.Id == x.CategoryId).Name : "No Category",
                Description = x.Description,
                Title = x.Title,
                Username = x.Username,
                Password = x.Password,
                CreationDate = x.CreationDate.ToShortDateString(),
                ProviderImage = _context.Providers.Any(l => l.Id == x.ProviderId) ? _context.Providers.FirstOrDefault(l => l.Id == x.ProviderId).Image : "",
                ProviderName = _context.Providers.Any(l => l.Id == x.ProviderId) ? _context.Providers.FirstOrDefault(l => l.Id == x.ProviderId).Name : "",
                UpdateDate = x.UpdatedDate == null ? "" : ((DateTime)x.UpdatedDate).ToShortDateString(),
                UserNameType = _context.LookupItems.Any(l => l.Id == x.UsernameTypeId) ? _context.LookupItems.FirstOrDefault(l => l.Id == x.UsernameTypeId).Name : "No Username Type",
            }).FirstOrDefaultAsync();

            return query;
        }

        public async Task<List<AccountDTO>> GetMyAccounts(int userId)
        {
            var query = from a in _context.Accounts
                        join p in _context.Providers on a.ProviderId equals p.Id
                        join c in _context.LookupItems on a.CategoryId equals c.Id
                        join ut in _context.LookupItems on a.UsernameTypeId equals ut.Id
                        where a.UserId == userId
                        select new AccountDTO
                        {
                            Id = a.Id,
                            ProviderName = p.Name,
                            Category = c.Name,
                            UserNameType = ut.Name,
                            ProviderImage = p.Image,
                            CreationDate = a.CreationDate.ToShortDateString(),
                            Title = a.Title,
                            Username = a.Title,
                        };
            return await query.ToListAsync();
        }

        public async Task<List<AccountDTO>> SearchAccount(AccountSearchInputDTO input)
        {
            var query = from a in _context.Accounts
                        join p in _context.Providers on a.ProviderId equals p.Id
                        join c in _context.LookupItems on a.CategoryId equals c.Id
                        join ut in _context.LookupItems on a.UsernameTypeId equals ut.Id
                        where a.UserId == input.UserId
                        && (
                        (input.Name == null || a.Title.Contains(input.Name)) ||
                        (input.ProviderName == null || c.Name.Contains(input.ProviderName)) ||
                        (input.Category == null || p.Name.Contains(input.Category))
                        )
                        select new AccountDTO
                        {
                            Id = a.Id,
                            ProviderName = p.Name,
                            Category = c.Name,
                            UserNameType = ut.Name,
                            ProviderImage = p.Image,
                            CreationDate = a.CreationDate.ToShortDateString(),
                            Title = a.Title,
                            Username = a.Title,
                        };
            return await query.ToListAsync();
        }
    }
}
