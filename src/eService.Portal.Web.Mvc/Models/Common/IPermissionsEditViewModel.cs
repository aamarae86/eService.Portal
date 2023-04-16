using System.Collections.Generic;
using eService.Portal.Roles.Dto;

namespace eService.Portal.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}