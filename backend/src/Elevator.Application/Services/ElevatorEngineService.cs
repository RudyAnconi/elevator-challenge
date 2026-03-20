using Elevator.Application.Contracts.Interfaces;

namespace Elevator.Application.Services;

/// <summary>
/// Placeholder — advances elevator physics each simulation tick.
/// TODO: Implement SCAN-like movement, door cycle, load logic.
/// </summary>
public sealed class ElevatorEngineService(ISystemStateStore store) : IElevatorEngine
{
    public Task TickAsync(CancellationToken cancellationToken)
    {
        // TODO: For each elevator, compute next floor, update state, raise events
        throw new NotImplementedException();
    }

    public Task RequestFloorAsync(Guid elevatorId, int floor, CancellationToken cancellationToken)
    {
        // TODO: Validate floor range (0-19), add to elevator queue
        throw new NotImplementedException();
    }
}

