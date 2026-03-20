namespace Elevator.Application.Contracts.Events;

public record HallRequestAssignedEvent(
    Guid RequestId,
    Guid ElevatorId,
    int OriginFloor,
    int DestinationFloor,
    bool IsVip,
    DateTime OccurredAtUtc
);

