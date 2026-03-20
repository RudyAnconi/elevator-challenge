using Elevator.Application.Contracts.Interfaces;
using Elevator.Application.Services;
using Elevator.Infrastructure.Logging;
using Elevator.Infrastructure.Queues;
using Elevator.Infrastructure.State;
using Elevator.Workers;

namespace Elevator.Extensions;

/// <summary>
/// Centralises all service registrations so Program.cs stays clean.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>Registers domain services and application service placeholders.</summary>
    public static IServiceCollection AddElevatorApplication(this IServiceCollection services)
    {
        services.AddSingleton<IElevatorEngine, ElevatorEngineService>();
        services.AddSingleton<IDispatchService, DispatchService>();
        services.AddSingleton<IPanelSessionService, PanelSessionService>();

        return services;
    }

    /// <summary>Registers in-memory infrastructure implementations.</summary>
    public static IServiceCollection AddElevatorInfrastructure(this IServiceCollection services)
    {
        // Core state store — singleton so all services share the same in-memory state
        services.AddSingleton<ISystemStateStore, InMemorySystemStateStore>();

        // Metrics
        services.AddSingleton<IMetricsService, InMemoryMetricsService>();

        // Event / audit log
        services.AddSingleton<IEventLogService, InMemoryEventLogService>();

        // Request queue (used internally by DispatchService)
        services.AddSingleton<InMemoryRequestQueue>();

        return services;
    }

    /// <summary>Registers the simulation background worker.</summary>
    public static IServiceCollection AddElevatorWorkers(this IServiceCollection services)
    {
        services.AddHostedService<ElevatorSimulationWorker>();
        return services;
    }
}

