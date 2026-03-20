namespace Elevator.Infrastructure.Timers;

/// <summary>
/// Wraps a PeriodicTimer for the simulation loop.
/// Injected into ElevatorSimulationWorker to allow tick-rate configuration.
/// TODO: Make interval configurable from appsettings.
/// </summary>
public sealed class SimulationTimer(TimeSpan interval) : IAsyncDisposable
{
    public static readonly TimeSpan DefaultInterval = TimeSpan.FromMilliseconds(500);

    private readonly PeriodicTimer _timer = new(interval);

    public ValueTask<bool> WaitForNextTickAsync(CancellationToken cancellationToken) =>
        _timer.WaitForNextTickAsync(cancellationToken);

    public ValueTask DisposeAsync()
    {
        _timer.Dispose();
        return ValueTask.CompletedTask;
    }
}

