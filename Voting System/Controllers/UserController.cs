using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Voting_System.Models;
using Domains;
using Bl;

namespace Voting_System.Controllers
{
    public class UserController : Controller
    {
        IClsUsers clsusers;
        public UserController(IClsUsers _clsusers)
        {
            clsusers = _clsusers;
        }               
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(UserModel user)
        {
            if (ModelState.IsValid)
            {
                TbUsers us=new TbUsers()
                {
                    UserName=user.UserName,
                    UserEmail=user.UserEmail,
                    UserAge=user.UserAge,
                    UserExperience=user.UserExperience,
                    UserJob=user.UserJob,   
                    UserPassword=user.UserPassword,
                };
                var r=clsusers.AddUser(us);
                if(r==true)
                {
                    return Redirect("~/Vote/VoteOptions");
                }
                return View("Register");
            }
            else
            {
                return View("Register", user);
            }

        }

       
    }
}
