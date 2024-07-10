using FitTrackr.Domain.Common;

namespace FitTrackr.Domain.Entities;

public sealed class Exercise : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int ExerciseTypeId { get; set; }
    public ExerciseType ExerciseType { get; set; } = null!; 
    public int? IntensityLevelId { get; set; }
    public IntensityLevel? IntensityLevel { get; set; }
    public ICollection<Muscle> MusclesTargeted { get; set; } = new List<Muscle>();
    public ICollection<Equipment>? Equipments { get; set; } = new List<Equipment>();
}
