using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public interface IClsVoteLists
    {
        public List<TbPlayer> GetAllPlayers();
        public List<TbClub> GetAllClubs();
        public List<TbCoch> GetAllCochs();
        public List<TbGk> GetAllGks();
    }
    public class ClsVoteLists:IClsVoteLists
    {
        SystemVotingContext context;
        public ClsVoteLists(SystemVotingContext _context)
        {
            context = _context; 
        }
        public List<TbPlayer> GetAllPlayers()
        {
            try
            {
                var Result = context.TbPlayers.ToList();
                return Result;

            }
            catch
            {
                return new List<TbPlayer>();
            }
        }

        public List<TbClub> GetAllClubs()
        {
            try
            {
                var Result = context.TbClubs.ToList();
                return Result;

            }
            catch
            {
                return new List<TbClub>();
            }
        }

        public List<TbCoch> GetAllCochs()
        {
            try
            {
                var Result = context.TbCochs.ToList();
                return Result;

            }
            catch
            {
                return new List<TbCoch>();
            }
        }
        public List<TbGk> GetAllGks()
        {
            try
            {
                var Result = context.TbGks.ToList();
                return Result;

            }
            catch
            {
                return new List<TbGk>();
            }
        }
    }
}
