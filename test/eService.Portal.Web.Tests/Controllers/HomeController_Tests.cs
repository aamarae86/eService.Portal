using System.Threading.Tasks;
using eService.Portal.Models.TokenAuth;
using eService.Portal.Web.Controllers;
using Shouldly;
using Xunit;

namespace eService.Portal.Web.Tests.Controllers
{
    public class HomeController_Tests: PortalWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}