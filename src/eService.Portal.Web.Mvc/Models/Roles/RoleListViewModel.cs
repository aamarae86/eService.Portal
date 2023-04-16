using System.Collections.Generic;
using eService.Portal.Roles.Dto;

namespace eService.Portal.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
