using FitTrackr.Domain.Common;

namespace FitTrackr.Domain.Entities;

public sealed class TrainingSession : BaseAuditableEntity
{
    public int TrainingPhaseId { get; set; }
    public TrainingPhase TrainingPhase { get; set; } = null!;
    public int WeekNumber { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public ICollection<ExerciseSession> ExerciseSessions { get; set; } = new List<ExerciseSession>();
}
