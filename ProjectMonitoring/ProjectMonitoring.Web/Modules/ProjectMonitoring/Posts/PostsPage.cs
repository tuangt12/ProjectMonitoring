
namespace ProjectMonitoring.ProjectMonitoring.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("ProjectMonitoring/Posts"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PostsRow))]
    public class PostsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/ProjectMonitoring/Posts/PostsIndex.cshtml");
        }
    }
}