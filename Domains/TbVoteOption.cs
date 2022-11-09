using Microsoft.Identity.Client.Extensibility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domains;

public partial class TbVoteOption
{
    [Key]
    public int voteid { get; set; }

    public int Playerid { get; set; }

    public int Cochid { get; set; }

    public int Clubid { get; set; }

    public int Gkid { get; set; }

    public int Userid { get; set; }

    //public TbUsers users { get; set; }
    public TbPlayer player { get; set; }
    public TbCoch coch { get; set; }
    public TbClub club { get; set; }    
    public TbGk gk { get; set; }
}
