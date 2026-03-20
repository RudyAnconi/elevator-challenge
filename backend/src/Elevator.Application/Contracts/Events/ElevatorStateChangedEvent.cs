namespace Elevator.Application.Contracts.Events;

public record ElevatorStateChangedEvent(
    Guid ElevatorId,
    int CurrentFloor,
    int? NextDestinationFloor,
    string Direction,
    string State,
    DateTime OccurredAtUtc
);

