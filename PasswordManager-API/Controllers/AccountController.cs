using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PasswordManager_API.DTOs.Accounts;
using PasswordManager_API.Interfaces;

namespace PasswordManager_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountInterface _appService;

        public AccountController(IAccountInterface appService)
        {
            _appService = appService;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetDetailDTO(int Id)
        {
            try
            {
                var response = await _appService.GetDetailDTO(Id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetMyAccounts(int userId)
        {
            try
            {
                var response = await _appService.GetMyAccounts(userId);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> SearchAccount(AccountSearchInputDTO input)
        {
            try
            {
                var response = await _appService.SearchAccount(input);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CopyAccountOrignizalPassword(int Id)
        {
            try
            {
                var response = await _appService.CopyAccountOrignizalPassword(Id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateUpdateAccount(CreateUpdateAccountInputDTO input)
        {
            try
            {
                var response = await _appService.CreateUpdateAccount(input);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GenerateStrongPassword(int length)
        {
            try
            {
                var response = await _appService.GenerateStrongPassword(length);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }   
    }
}
