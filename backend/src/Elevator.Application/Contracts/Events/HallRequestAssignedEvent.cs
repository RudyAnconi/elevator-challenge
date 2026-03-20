namespace Elevator.Application.Contracts.Events;

/// <summary>
/// Published when the dispatch algorithm assigns an elevator to a hall request.
/// </summary>
public record HallRequestAssignedEvent(
    Guid HallRequestId,
    Guid ElevatorId,
    int Floor,
    DateTimeOffset OccurredAt
);

