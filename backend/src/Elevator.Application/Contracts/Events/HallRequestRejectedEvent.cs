namespace Elevator.Application.Contracts.Events;

/// <summary>
/// Published when no eligible elevator could be assigned to a hall request.
/// </summary>
public record HallRequestRejectedEvent(
    Guid HallRequestId,
    int Floor,
    string Reason,
    DateTimeOffset OccurredAt
);

