using FitTrackr.Domain.Common;

namespace FitTrackr.Domain.Entities;

public sealed class TrainingPhase : BaseAuditableEntity
{
    public int TrainingPlanId { get; set; }
    public int PhaseNumber { get; set; }
    public ICollection<DayOfWeek> TrainingDays { get; set; } = new List<DayOfWeek>();
    public int WeekCount { get; private set; }
    public ICollection<TrainingSession> TrainingSessions { get; set; } = new List<TrainingSession>();
}
