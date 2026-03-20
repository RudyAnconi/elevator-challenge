namespace Elevator.Application.Contracts.Interfaces;

/// <summary>
/// Core simulation engine that advances elevator state on each tick.
/// </summary>
public interface IElevatorEngine
{
    /// <summary>Advance the simulation by one tick.</summary>
    Task TickAsync(CancellationToken cancellationToken);

    /// <summary>Request a specific floor be added to an elevator's queue.</summary>
    Task RequestFloorAsync(Guid elevatorId, int floor, CancellationToken cancellationToken);

    // TODO: OpenDoorsAsync, CloseDoorsAsync, GetQueueAsync
}

