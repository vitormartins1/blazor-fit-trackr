using MediatR;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FitTrackr.Application.Common.Services.Data;
using FitTrackr.Domain.Entities;
using FitTrackr.Infrastructure.Common;
using FitTrackr.Infrastructure.Data.Interceptors;
using FitTrackr.Infrastructure.Identity;
using System.Reflection;

namespace FitTrackr.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>, IApplicationDbContext
{
    private readonly IMediator _mediator;
    private readonly AuditableEntitySaveChangesInterceptor _auditableEntitySaveChangesInterceptor;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
        IMediator mediator,
        AuditableEntitySaveChangesInterceptor auditableEntitySaveChangesInterceptor)
        : base(options)
    {
        _mediator = mediator;
        _auditableEntitySaveChangesInterceptor = auditableEntitySaveChangesInterceptor;
    }

    public DbSet<TodoList> TodoLists => Set<TodoList>();
    public DbSet<TodoItem> TodoItems => Set<TodoItem>();

    public DbSet<TrainingPlan> TrainingPlans => Set<TrainingPlan>();
    public DbSet<TrainingPhase> TrainingPhases => Set<TrainingPhase>();
    public DbSet<TrainingSession> TrainingSessions => Set<TrainingSession>();
    public DbSet<BodyRegion> BodyRegions => Set<BodyRegion>();
    public DbSet<Muscle> Muscles => Set<Muscle>();
    public DbSet<PrimaryFunction> PrimaryFunctions => Set<PrimaryFunction>();
    public DbSet<Equipment> Equipments => Set<Equipment>();
    public DbSet<ExerciseType> ExerciseTypes => Set<ExerciseType>();
    public DbSet<IntensityLevel> IntensityLevels => Set<IntensityLevel>();
    public DbSet<ExerciseNote> ExerciseNotes => Set<ExerciseNote>();
    public DbSet<Exercise> Exercises => Set<Exercise>();
    public DbSet<ExerciseSession> ExerciseSessions => Set<ExerciseSession>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.AddInterceptors(_auditableEntitySaveChangesInterceptor);
        
        
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await _mediator.DispatchDomainEvent(this);
        return await base.SaveChangesAsync(cancellationToken);
    }
}
