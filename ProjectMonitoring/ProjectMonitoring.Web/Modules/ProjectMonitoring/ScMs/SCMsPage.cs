
namespace ProjectMonitoring.ProjectMonitoring.Pages
{
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("ProjectMonitoring/SCMs"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.SCMsRow))]
    public class SCMsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/ProjectMonitoring/SCMs/SCMsIndex.cshtml");
        }
    }
}