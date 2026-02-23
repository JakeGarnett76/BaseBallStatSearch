using System;
using System.Collections.Generic;

namespace BaseBallStatSearch.Entities;

public partial class Coaches2025
{
    public string Id { get; set; } = null!;

    public short Year { get; set; }

    public string Team { get; set; } = null!;

    public string Role { get; set; } = null!;

    public DateOnly Start { get; set; }

    public DateOnly End { get; set; }
}
