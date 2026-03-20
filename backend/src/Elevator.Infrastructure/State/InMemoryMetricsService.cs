using Elevator.Application.Contracts.Interfaces;
using Elevator.Domain.ValueObjects;

namespace Elevator.Infrastructure.State;

/// <summary>
/// Computes metrics from the in-memory state store on demand.
/// TODO: Cache the last snapshot, compute averages from completed request timestamps.
/// </summary>
public sealed class InMemoryMetricsService(ISystemStateStore store) : IMetricsService
{
    // TODO: Cache last computed snapshot here once RefreshAsync is implemented

    public Task<MetricsSnapshot> GetSnapshotAsync(CancellationToken cancellationToken)
    {
        // TODO: Return cached snapshot or compute inline
        throw new NotImplementedException();
    }

    public Task RefreshAsync(CancellationToken cancellationToken)
    {
        // TODO: Compute from store.HallRequests, store.Elevators, publish MetricsUpdatedEvent
        throw new NotImplementedException();
    }
}

