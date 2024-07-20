using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FitTrackr.WebUi.Client.Handlers.Interfaces;
using FitTrackr.WebUi.Client.Handlers.ServerImplementation;
using FitTrackr.WebUi.Client.Handlers.WasmImplementation;

namespace FitTrackr.WebUi.Client;

public static class AppServices
{
    public static WebAssemblyHostBuilder AddApplicationWebAssemblyServices(this WebAssemblyHostBuilder builder)
    {
        builder.Services.AddHttpClient("FitTrackr.WebUi", client =>
            client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
        
        builder.Services.AddScoped(sp => 
            sp.GetRequiredService<IHttpClientFactory>().CreateClient("FitTrackr.WebUi"));

        builder.Services.Scan(scan => scan
            .FromAssemblyOf<ITodoListsClient>()
            .FromAssemblyOf<IExerciseNotesClient>()
            .AddClasses()
            .AsImplementedInterfaces()
            .WithScopedLifetime());

        builder.Services.AddScoped<IExerciseNoteHandler, ExerciseNotesApiHandler>();

        return builder;
    }
    
    public static IServiceCollection AddApplicationServerServices(this IServiceCollection services)
    {
        services.AddScoped<IUserHandler, UserServerHandler>();
        services.AddScoped<ITodoListHandler, TodoListServerHandler>();
        services.AddScoped<ITodoItemsHandler, TodoItemsServerHandler>();
        services.AddScoped<IExerciseNoteHandler, ExerciseNotesServerHandler>();

        return services;
    }
}
