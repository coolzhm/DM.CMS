using Abp.AspNetCore.Mvc.Views;

namespace DM.CMS.Web.Views
{
    public abstract class CMSRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected CMSRazorPage()
        {
            LocalizationSourceName = CMSConsts.LocalizationSourceName;
        }
    }
}
