using FitTrackr.Domain.Common;

namespace FitTrackr.Domain.Entities;

public sealed class TrainingPlan : BaseAuditableEntity
{
    public ICollection<TrainingPhase> TrainingPhases { get; set; } = new List<TrainingPhase>();
}
