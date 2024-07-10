using FitTrackr.Domain.Common;

namespace FitTrackr.Domain.Entities;

public sealed class PrimaryFunction : BaseAuditableEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public ICollection<Muscle> Muscles { get; private set; } = new List<Muscle>();
}
