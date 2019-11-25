using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}