using System;
using System.Collections.Generic;

namespace BaseBallStatSearch.Entities;

public partial class Team
{
    public string Team1 { get; set; } = null!;

    public string? League { get; set; }

    public string City { get; set; } = null!;

    public string Nickname { get; set; } = null!;

    public short First { get; set; }

    public short Last { get; set; }
}
