using System.Collections.Generic;
using eService.Portal.Roles.Dto;

namespace eService.Portal.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
