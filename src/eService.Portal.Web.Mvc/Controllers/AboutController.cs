using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using eService.Portal.Controllers;

namespace eService.Portal.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : PortalControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
