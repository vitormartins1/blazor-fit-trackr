using FitTrackr.Domain.Entities;

namespace FitTrackr.Application.Common.Services.Data;

public interface IApplicationDbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    
    DbSet<TodoList> TodoLists { get; }
    
    DbSet<TodoItem> TodoItems { get; }

    DbSet<TrainingPlan> TrainingPlans { get; }
    DbSet<TrainingPhase> TrainingPhases { get; }
    DbSet<TrainingSession> TrainingSessions { get; }
    DbSet<BodyRegion> BodyRegions { get; }
    DbSet<Muscle> Muscles { get; }
    DbSet<PrimaryFunction> PrimaryFunctions { get; }
    DbSet<Equipment> Equipments { get; }
    DbSet<ExerciseType> ExerciseTypes { get; }
    DbSet<IntensityLevel> IntensityLevels { get; }
    DbSet<ExerciseNote> ExerciseNotes { get; }
    DbSet<Exercise> Exercises { get; }
    DbSet<ExerciseSession> ExerciseSessions { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
