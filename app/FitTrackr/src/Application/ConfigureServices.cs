

using FitTrackr.Application.Common.Behaviours;
using FitTrackr.Application.TodoItems.Commands;
using FitTrackr.WebUi.Shared.TodoLists;
using FluentValidation;
using FitTrackr.Application.TodoLists.Commands;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<CreateTodoListRequestValidator>();
        services.AddValidatorsFromAssemblyContaining<CreateTodoListCommandValidator>();

        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssemblyContaining<CreateTodoItemCommand>();
        });

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

        return services;
    }
}
