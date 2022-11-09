using Bl;
using Domains;
using Microsoft.AspNetCore.Mvc;

namespace Voting_System.Controllers
{
    public class VoteController : Controller
    {
        IClsVoteLists vote;
        IClsVotes clsvote;
        public VoteController(IClsVoteLists _vote,IClsVotes _clsvote)
        {
            vote = _vote;  
            clsvote = _clsvote;
        }
        public IActionResult VoteOptions()
        {
            ViewBag.Players=vote.GetAllPlayers();
            ViewBag.Gks=vote.GetAllGks();
            ViewBag.Clubs=vote.GetAllClubs();
            ViewBag.Cochs = vote.GetAllCochs();

            return View();
        }
        [HttpPost]
        public IActionResult Save(TbVoteOption vote,int id)
        {

            vote.Userid = id;
            var result = clsvote.AddVote(vote);
            if (result == true)
            {
                return Redirect("~/");
            }
            else
            {

            }
            return RedirectToAction("VoteOptions");
        }
    }
}
