
namespace ProjectMonitoring.ProjectMonitoring.Pages
{
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("ProjectMonitoring/SCMTypes"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.SCMTypesRow))]
    public class SCMTypesController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/ProjectMonitoring/SCMTypes/SCMTypesIndex.cshtml");
        }
    }
}