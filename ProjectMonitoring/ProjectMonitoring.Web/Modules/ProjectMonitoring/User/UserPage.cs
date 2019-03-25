
namespace ProjectMonitoring.ProjectMonitoring.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("ProjectMonitoring/User"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.UserRow))]
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/ProjectMonitoring/User/UserIndex.cshtml");
        }
    }
}