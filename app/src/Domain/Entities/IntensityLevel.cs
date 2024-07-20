using FitTrackr.Domain.Common;

namespace FitTrackr.Domain.Entities;

public sealed class IntensityLevel : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
}
