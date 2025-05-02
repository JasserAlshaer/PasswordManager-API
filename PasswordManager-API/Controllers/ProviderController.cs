using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PasswordManager_API.DTOs.Providers;
using PasswordManager_API.Entities;
using PasswordManager_API.Interfaces;

namespace PasswordManager_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly IProviderInterface _appService;

        public ProviderController(IProviderInterface appService)
        {
            _appService = appService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetProviderDetails(int Id)
        {
            try
            {
                var response = await _appService.GetProviderDetails(Id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetProviders()
        {
            try
            {
                var response = await _appService.GetProviders();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateUpdateProvider(CreateUpdateProviderDTO input)
        {
            try
            {
                var response = await _appService.CreateUpdateProvider(input);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
