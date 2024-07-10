using FitTrackr.Domain.Common;

namespace FitTrackr.Domain.Entities;

public sealed class Muscle : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public int BodyRegionId { get; set; }
    public BodyRegion BodyRegion { get; set; } = null!;
    public int PrimaryFunctionId { get; set; }
    public PrimaryFunction PrimaryFunction { get; set; } = null!;
    public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
}
