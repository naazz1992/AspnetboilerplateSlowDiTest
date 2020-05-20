using Abp.Authorization;
using SlowDI.Authorization.Roles;
using SlowDI.Authorization.Users;

namespace SlowDI.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
