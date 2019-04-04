using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Exceed.Controllers
{
    public abstract class ExceedControllerBase: AbpController
    {
        protected ExceedControllerBase()
        {
            LocalizationSourceName = ExceedConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
