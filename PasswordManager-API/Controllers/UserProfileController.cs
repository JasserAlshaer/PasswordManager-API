using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PasswordManager_API.DTOs;
using PasswordManager_API.Interfaces;
using System;

namespace PasswordManager_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly IUserProfileInterface _appService;

        public UserProfileController(IUserProfileInterface appService)
        {
            _appService = appService;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetProfile(int userId)
        {
            try
            {
                var response = await _appService.GetProfileDTO(userId);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateUserImage(int userId, string url)
        {
            try
            {
                await _appService.UpdateUserImage(userId,url);
                return Ok("Updated Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateUserProfile(UpdateUserProfileInputDTO input)
        {
            try
            {
                await _appService.UpdateUserProfile(input);
                return Ok("Updated Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
