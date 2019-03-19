
namespace ProjectMonitoring.ProjectMonitoring.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("ProjectMonitoring/Subjects"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.SubjectsRow))]
    public class SubjectsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/ProjectMonitoring/Subjects/SubjectsIndex.cshtml");
        }
    }
}