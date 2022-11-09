using System;
using System.Collections.Generic;

namespace Domains;

public partial class TbClub
{
    public TbClub()
    {
        VoteOptions=new HashSet<TbVoteOption>();
    }
    public int Clubid { get; set; }

    public string Clubname { get; set; } = null!;
    public ICollection<TbVoteOption> VoteOptions { get; set; }
}
