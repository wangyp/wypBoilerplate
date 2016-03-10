using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace wyp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : wypControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}