using Elevator.Domain.Entities;

namespace Elevator.Application.Contracts.Interfaces;

/// <summary>
/// Assigns hall requests to the most suitable elevator.
/// Implement the dispatch algorithm (SCAN, SSTF, etc.) here.
/// </summary>
public interface IDispatchService
{
    /// <summary>
    /// Evaluate all pending hall requests and assign each to an available elevator.
    /// Returns the number of requests dispatched.
    /// </summary>
    Task<int> DispatchPendingRequestsAsync(CancellationToken cancellationToken);

    /// <summary>Creates and enqueues a new hall request from a floor button press.</summary>
    Task<HallRequest> CreateHallRequestAsync(int floor, Domain.Enums.Direction direction, CancellationToken cancellationToken);

    // TODO: CancelRequestAsync, GetPendingAsync
}

