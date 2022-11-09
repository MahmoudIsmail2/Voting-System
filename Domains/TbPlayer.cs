using System;
using System.Collections.Generic;

namespace Domains;

public partial class TbPlayer
{
    public TbPlayer()
    {
        VoteOptions = new HashSet<TbVoteOption>();
    }
    public int Playerid { get; set; }

    public string Playername { get; set; } = null!;
    public ICollection<TbVoteOption> VoteOptions { get; set; }
}
