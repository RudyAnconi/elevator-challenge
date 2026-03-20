using Elevator.Application.Contracts.Interfaces;
using Elevator.Infrastructure.Timers;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Elevator.Workers;

/// <summary>
/// Hosted background service that drives the simulation loop.
/// Fires every <see cref="SimulationTimer.DefaultInterval"/> and advances
/// elevator state, dispatches requests, expires sessions, and refreshes metrics.
///
/// TODO: Implement each simulation step in order:
///   1. engine.TickAsync        — move elevators
///   2. dispatch.DispatchPendingRequestsAsync — assign new calls
///   3. panelSession.ExpireTimedOutSessionsAsync
///   4. metrics.RefreshAsync
///   5. Broadcast updated state via IHubContext&lt;ElevatorHub&gt;
/// </summary>
public sealed class ElevatorSimulationWorker(
    IElevatorEngine engine,
    IDispatchService dispatch,
    IPanelSessionService panelSession,
    IMetricsService metrics,
    ISystemStateStore store,
    ILogger<ElevatorSimulationWorker> logger
) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        store.Initialize(elevatorCount: 5, floorCount: 20);
        logger.LogInformation("Elevator simulation started — 5 elevators, 20 floors.");

        await using var timer = new SimulationTimer(SimulationTimer.DefaultInterval);

        while (await timer.WaitForNextTickAsync(stoppingToken))
        {
            try
            {
                // TODO: Uncomment and implement each step:
                // await engine.TickAsync(stoppingToken);
                // await dispatch.DispatchPendingRequestsAsync(stoppingToken);
                // await panelSession.ExpireTimedOutSessionsAsync(stoppingToken);
                // await metrics.RefreshAsync(stoppingToken);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error during simulation tick.");
            }
        }

        logger.LogInformation("Elevator simulation stopped.");
    }
}

