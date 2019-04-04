using Abp.Authorization;
using Exceed.Authorization.Roles;
using Exceed.Authorization.Users;

namespace Exceed.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
