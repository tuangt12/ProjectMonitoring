
namespace ProjectMonitoring.ProjectMonitoring.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("ProjectMonitoring/Classes"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ClassesRow))]
    public class ClassesController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/ProjectMonitoring/Classes/ClassesIndex.cshtml");
        }
    }
}