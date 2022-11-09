using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Voting_System.Models;

using Domains;
using Bl;

namespace Voting_System.Controllers
{
    public class HomeController : Controller
    {
        IClsImgs _imgs;
        public HomeController(IClsImgs imgs)
        {
            _imgs = imgs;   
        }
        
        public IActionResult Index()
        {
            var lstimgs=_imgs.GetAll();           
            return View(lstimgs);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}