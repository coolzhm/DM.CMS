using System.Threading.Tasks;
using DM.CMS.Web.Controllers;
using Shouldly;
using Xunit;

namespace DM.CMS.Web.Tests.Controllers
{
    public class HomeController_Tests: CMSWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
