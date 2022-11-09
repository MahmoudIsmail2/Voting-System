using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbUsers
    {
        public TbUsers()
        {
           // VoteOption=new TbVoteOption();
        }
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; } = "";
        public int UserAge { get; set; }
        public string UserJob { get; set; } = "";
        public string UserExperience { get; set; } = "";
        public string UserPassword { get; set; } = "";
        public string UserEmail { get; set; } = "";
        //public TbVoteOption VoteOption { get; set; }

    }
}
