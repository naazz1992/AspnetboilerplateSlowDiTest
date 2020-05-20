using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SlowDI.Controllers
{
    public abstract class SlowDIControllerBase: AbpController
    {
        protected SlowDIControllerBase()
        {
            LocalizationSourceName = SlowDIConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
