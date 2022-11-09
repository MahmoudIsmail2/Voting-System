using Microsoft.AspNetCore.Mvc;

namespace Voting_System.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        public IActionResult List()
        {
            return View();
        }
    }
}
