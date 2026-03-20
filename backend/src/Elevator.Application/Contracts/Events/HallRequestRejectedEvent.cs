namespace Elevator.Application.Contracts.Events;

public record HallRequestRejectedEvent(
    Guid RequestId,
    int OriginFloor,
    int DestinationFloor,
    string Reason,
    DateTime OccurredAtUtc
);

