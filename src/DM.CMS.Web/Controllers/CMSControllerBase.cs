using Abp.AspNetCore.Mvc.Controllers;

namespace DM.CMS.Web.Controllers
{
    public abstract class CMSControllerBase: AbpController
    {
        protected CMSControllerBase()
        {
            LocalizationSourceName = CMSConsts.LocalizationSourceName;
        }
    }
}