using FitTrackr.Domain.Common;

namespace FitTrackr.Domain.Entities;

public sealed class ExerciseNote : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ICollection<ExerciseSession> ExerciseSessions { get; set; } = new List<ExerciseSession>();
}
