using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MixSample.Model;
using MixSample.Repository.Interface;

namespace MixSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountRepository _accountRepository;
        public AccountController(IAccountRepository accountRepository) { 

            _accountRepository = accountRepository;
        }
        [HttpPost("SinUp")]
        public async Task<IActionResult> SinUp([FromBody] SinupModel sinupModel)
        {
            var result = await _accountRepository.SinUpAsync(sinupModel);
            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody]  SignModel signModel)
        {
            var result = await _accountRepository.LoginAsync(signModel);
            if (string.IsNullOrEmpty(result))
            {
              return  Unauthorized();
            }
            return Ok(result);
        }
    }
}
