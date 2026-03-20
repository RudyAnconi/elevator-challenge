namespace Elevator.Application.Contracts.Commands;

/// <summary>
/// Retries a hall request that was rejected or has stalled in Pending state.
/// </summary>
public record RetryRequestCommand(
    Guid HallRequestId
    // TODO: Add retry reason, max retry policy
);

