using System;
using System.Collections.Generic;

namespace Domains;

public partial class TbCoch
{
    public TbCoch()
    {
        VoteOptions=new HashSet<TbVoteOption>();
    }
    public int Cochid { get; set; }

    public string Cochname { get; set; } = null!;

    public ICollection<TbVoteOption> VoteOptions { get; set; }
}
