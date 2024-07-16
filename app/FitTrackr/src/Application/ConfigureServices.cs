

using FitTrackr.Application.Common.Behaviours;
using FitTrackr.Application.TodoItems.Commands;
using FitTrackr.WebUi.Shared.TodoLists;
using FluentValidation;
using FitTrackr.Application.TodoLists.Commands;
using FitTrackr.Application.ExerciseNotes.Commands;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<CreateTodoListRequestValidator>();
        services.AddValidatorsFromAssemblyContaining<CreateTodoListCommandValidator>();
        services.AddValidatorsFromAssemblyContaining<CreateExerciseNoteCommandValidator>();

        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssemblyContaining<CreateTodoItemCommand>();
            configuration.RegisterServicesFromAssemblyContaining<CreateExerciseNoteCommand>();
        });

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

        return services;
    }
}
