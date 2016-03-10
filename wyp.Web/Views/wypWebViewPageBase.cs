using Abp.Web.Mvc.Views;

namespace wyp.Web.Views
{
    public abstract class wypWebViewPageBase : wypWebViewPageBase<dynamic>
    {

    }

    public abstract class wypWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected wypWebViewPageBase()
        {
            LocalizationSourceName = wypConsts.LocalizationSourceName;
        }
    }
}