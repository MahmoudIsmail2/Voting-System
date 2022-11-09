using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public interface IClsVotes
    {
        public bool AddVote(TbVoteOption vote);
    }
    public class ClsVotes : IClsVotes
    {
        SystemVotingContext context;
        public ClsVotes(SystemVotingContext _context)
        {
            context = _context;
        }
        public bool AddVote(TbVoteOption vote)
        {
            try
            {
                
                context.TbVoteOptions.Add(vote);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
