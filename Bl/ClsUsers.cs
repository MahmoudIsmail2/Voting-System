using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
     public interface IClsUsers
    {
        public bool AddUser(TbUsers user);
    }
    public class ClsUsers:IClsUsers
    {
        SystemVotingContext context;
        public ClsUsers(SystemVotingContext _context)
        {
            context = _context;
        }
        public bool AddUser(TbUsers user)
        {
            try
            {
                context.TbUsers.Add(user);
                context.SaveChanges();  
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
         

    }
}
