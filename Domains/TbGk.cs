using System;
using System.Collections.Generic;

namespace Domains;

public partial class TbGk
{
    public TbGk()
    {
        VoteOptions=new HashSet<TbVoteOption>();
    }
    public int Gkid { get; set; }

    public string Gkname { get; set; } = null!;

    public ICollection<TbVoteOption> VoteOptions { get; set; }
}
