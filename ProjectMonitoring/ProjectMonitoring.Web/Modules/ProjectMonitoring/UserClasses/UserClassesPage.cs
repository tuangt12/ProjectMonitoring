
namespace ProjectMonitoring.ProjectMonitoring.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("ProjectMonitoring/UserClasses"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.UserClassesRow))]
    public class UserClassesController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/ProjectMonitoring/UserClasses/UserClassesIndex.cshtml");
        }
    }
}