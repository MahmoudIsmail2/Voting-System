using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domains;

namespace Bl
{
    public interface IClsImgs
    {
        public List<TbImg> GetAll();

    }
    public class ClsImgs : IClsImgs
    {
         SystemVotingContext _context;
        public ClsImgs(SystemVotingContext context)
        {
            _context = context;
        }
        public List<TbImg> GetAll()
        {
            try
            {
                var lstimgs = _context.TbImgs.ToList();
                return lstimgs;
            }
            catch(Exception ex)
            {
                return new List<TbImg>();
            }

        }
    }
}

