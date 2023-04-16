using Abp.Authorization;
using eService.Portal.Authorization.Roles;
using eService.Portal.Authorization.Users;

namespace eService.Portal.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
