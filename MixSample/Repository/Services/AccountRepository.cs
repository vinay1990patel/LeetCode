using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using MixSample.Model;
using MixSample.Repository.Interface;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MixSample.Repository.Services
{
    public class AccountRepository : IAccountRepository
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration) { 
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }
        public async Task< IdentityResult> SinUpAsync(SinupModel sinupModel)
        {
            var user = new ApplicationUser()
            {
                FirstName = sinupModel.FirstName,
                LastName = sinupModel.LastName,
                Email = sinupModel.Email,
                UserName = sinupModel.Email

            };
           return await _userManager.CreateAsync(user, sinupModel.Password);
        }

       

        public async Task<string> LoginAsync(SignModel signModel)
        {
            var result = await _signInManager.PasswordSignInAsync(signModel.Email, signModel.Password, false, false);
            if (!result.Succeeded)
            {
                return null;
            }

            var authClaim = new List<Claim>
            {
                new Claim(ClaimTypes.Name, signModel.Email),
                new Claim(Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var authSinginKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["jwt:Secret"]));
            var token = new JwtSecurityToken(

                  issuer: _configuration["jwt:ValidIssure"],
                   audience: _configuration["jwt:Validaudience"],
                   expires: DateTime.Now.AddDays(1),
                   claims: authClaim,
                   signingCredentials: new SigningCredentials(authSinginKey, SecurityAlgorithms.HmacSha256Signature)
                );

          return  new JwtSecurityTokenHandler().WriteToken(token); 
           

        }
    }
}
