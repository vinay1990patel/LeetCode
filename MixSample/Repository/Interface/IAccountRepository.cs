using Microsoft.AspNetCore.Identity;
using MixSample.Model;

namespace MixSample.Repository.Interface
{
    public interface IAccountRepository
    {
         Task<IdentityResult> SinUpAsync(SinupModel sinupModel);
         Task<string> LoginAsync(SignModel signModel);
       
    }

    
}
