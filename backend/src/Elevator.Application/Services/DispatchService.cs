using Elevator.Application.Contracts.Interfaces;
using Elevator.Domain.Entities;
using Elevator.Domain.Enums;

namespace Elevator.Application.Services;

/// <summary>
/// Placeholder — implements the elevator dispatch algorithm.
/// TODO: Implement SCAN / SSTF / nearest-car dispatch strategy.
/// </summary>
public sealed class DispatchService(ISystemStateStore store) : IDispatchService
{
    public Task<int> DispatchPendingRequestsAsync(CancellationToken cancellationToken)
    {
        // TODO: Fetch pending requests, score available elevators, assign best match
        throw new NotImplementedException();
    }

    public Task<HallRequest> CreateHallRequestAsync(int floor, Direction direction, CancellationToken cancellationToken)
    {
        // TODO: Validate floor 0-19, deduplicate, store, publish HallRequestCreated
        throw new NotImplementedException();
    }
}

