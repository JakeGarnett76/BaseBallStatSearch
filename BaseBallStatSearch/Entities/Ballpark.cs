using System;
using System.Collections.Generic;

namespace BaseBallStatSearch.Entities;

public partial class Ballpark
{
    public string ParkId { get; set; } = null!;

    public string? Name { get; set; }

    public string? Aka { get; set; }

    public string City { get; set; } = null!;

    public string? State { get; set; }

    public DateOnly? Start { get; set; }

    public DateOnly? End { get; set; }

    public string? League { get; set; }

    public string? Notes { get; set; }
}
