using System;
using System.Collections.Generic;

namespace BaseBallStatSearch.Entities;

public partial class Biofile2025
{
    public string Id { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? UseName { get; set; }

    public string FullName { get; set; } = null!;

    public int? BirthDate { get; set; }

    public string? BirthCity { get; set; }

    public string? BirthState { get; set; }

    public string? BirthCountry { get; set; }

    public string? DeathDate { get; set; }

    public string? DeathCity { get; set; }

    public string? DeathState { get; set; }

    public string? DeathCountry { get; set; }

    public string? Cemetery { get; set; }

    public string? CemeteryCity { get; set; }

    public string? CemeteryState { get; set; }

    public string? CemeteryCtry { get; set; }

    public string? CemeteryNote { get; set; }

    public string? BirthName { get; set; }

    public string? AltName { get; set; }

    public DateOnly? DebutPlay { get; set; }

    public DateOnly? LastPlay { get; set; }

    public DateOnly? DebutCoach { get; set; }

    public DateOnly? LastCoach { get; set; }

    public DateOnly? DebutManager { get; set; }

    public DateOnly? LastManager { get; set; }

    public DateOnly? DebutUmp { get; set; }

    public DateOnly? LastUmp { get; set; }

    public string? Bats { get; set; }

    public string? Throws { get; set; }

    public double? Height { get; set; }

    public decimal? Weight { get; set; }

    public string? Hof { get; set; }
}
