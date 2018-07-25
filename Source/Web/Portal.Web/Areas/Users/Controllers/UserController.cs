using Microsoft.AspNetCore.Mvc;

namespace Portal.Web.Areas.Users.Controllers
{
    [Area("Users")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}