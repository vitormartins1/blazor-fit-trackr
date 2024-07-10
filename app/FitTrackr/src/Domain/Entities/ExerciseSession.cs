using FitTrackr.Domain.Common;

namespace FitTrackr.Domain.Entities;

public sealed class ExerciseSession : BaseAuditableEntity
{
    public int TrainingSessionId { get; set; }
    public int ExerciseId { get; set; }
    public int OrderPriority { get; set; }
    public Exercise Exercise { get; set; } = null!;
    public RepetitionSet RepetitionSet { get; set; } = null!;
    public ICollection<ExerciseNote> Notes { get; set; } = new List<ExerciseNote>();
}
