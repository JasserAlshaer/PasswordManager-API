using PasswordManager_API.Context;
using PasswordManager_API.DTOs;
using PasswordManager_API.Entities;
using PasswordManager_API.Helpers;
using PasswordManager_API.Interfaces;
using System;

namespace PasswordManager_API.Services
{
    public class AuthnticationAppService : IUserAuthanticationInterface
    {
        private readonly PasswordManagerDbContext _context;
        public AuthnticationAppService(PasswordManagerDbContext context)
        {
            _context = context;
        }
        public async Task<bool> ResetPersonPassword(ResetPersonPasswordInputDTO input)
        {
            var user = _context.Users.Where(u => u.Email == input.Email && u.OTPCode == input.OTP
            && u.IsLoggedIn == false && u.OTPExipry > DateTime.Now).SingleOrDefault();
            if (user == null)
            {
                return false;
            }
            if (input.Password != input.ConfirmPassword)
            {
                return false;
            }
            user.Password = input.ConfirmPassword;
            user.OTPCode = null;
            user.OTPExipry = null;

            _context.Update(user);
            _context.SaveChanges();

            return true;
        }

        public async Task<bool> SendOTP(string email)
        {
            var user = _context.Users.Where(u => u.Email == email && u.IsLoggedIn == false).SingleOrDefault();
            if (user == null)
            {
                return false;
            }
            Random otp = new Random();
            user.OTPCode = otp.Next(11111, 99999).ToString();
            user.OTPExipry = DateTime.Now.AddMinutes(3);
            await MailingHelper.SendEmail(email,user.OTPCode,"Reset Password OTP","Complete Reset Password");

            _context.Update(user);
            _context.SaveChanges();

            return true;
        }

        public async Task<string> SignIn(SignInInputDTO input)
        {
            var orignialUserName = input.Username;
            input.Username = HashingHelper.HashValueWith384(input.Username);
            var user = _context.Users.Where(u => (u.Email == input.Username || u.UserName == input.Username) && u.Password == input.Password && u.IsLoggedIn == false).SingleOrDefault();
            if (user == null)
            {
                return "User not found";
            }

            Random random = new Random();
            var otp = random.Next(11111, 99999);
            user.OTPCode = otp.ToString();

            user.OTPExipry = DateTime.Now.AddMinutes(5);
            await MailingHelper.SendEmail(orignialUserName, user.OTPCode, "Sign In  OTP", "Complete Sign in Operation");
            _context.Update(user);
            _context.SaveChanges();

            return "Check your emnail OTP has been sent!";
        }
        public async Task<bool> SignOut(int userId)
        {
            var user = _context.Users.Where(u => u.Id == userId && u.IsLoggedIn == true).SingleOrDefault();
            if (user == null)
            {
                return false;
            }

            user.LastLoginTime = DateTime.Now;
            user.IsLoggedIn = false;

            _context.Update(user);
            _context.SaveChanges();

            return true;
        }

        public async Task<string> SignUp(SignUpInputDTO input)
        {
            User person = new User();
            //hashing
            person.Email = HashingHelper.HashValueWith384(input.Email);
            person.Password = HashingHelper.HashValueWith384(input.Password);
            person.UserName = HashingHelper.HashValueWith384(input.Username);
            person.CreatedBy = "System";
            person.RoleId = 1;
            person.CreationDate = DateTime.Now;
            Random random = new Random();
            var otp = random.Next(11111, 99999);
            person.OTPCode = otp.ToString();
            person.OTPExipry = DateTime.Now.AddMinutes(5);
            await MailingHelper.SendEmail(input.Email, person.OTPCode, "Sign Up  OTP", "Complete Sign Up Operation");
            _context.Users.Add(person);
            _context.SaveChanges();


            //need to create profile for this user
            
            return "Verifuing Your email using otp";
        }


        public async Task<string> Verification(VerificationInputDTO input)
        {
            input.Email = HashingHelper.HashValueWith384(input.Email);
            var user = _context.Users.Where(u => (u.Email == input.Email || u.UserName == input.Email) && u.OTPCode == input.OTPCode
            && u.IsLoggedIn == false && u.OTPExipry > DateTime.Now).SingleOrDefault();
            if (user == null)
            {
                return "User not found";
            }

            if (input.IsSignup)
            {
                user.IsVerfied = true;
                user.OTPExipry = null;
                user.OTPCode = null;
                _context.Update(user);
                _context.SaveChanges();
                return "Your Account Is Verifyed";
            }
            else
            {
                user.LastLoginTime = DateTime.Now;
                user.IsLoggedIn = true;
                user.OTPExipry = null;
                user.OTPCode = null;

                _context.Update(user);
                _context.SaveChanges();
                
                //return jwt token for this user
                return "";
            }


        }
    }
}
