using FitTrackr.Domain.Common;

namespace FitTrackr.Domain.Entities;

public sealed class BodyRegion : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public ICollection<Muscle> Muscles { get; set; } = new List<Muscle>();
}
