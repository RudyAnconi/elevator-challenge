namespace Elevator.Application.Contracts.Commands;

public record EmergencyStopCommand(
    Guid ElevatorId,
    int CurrentFloor,
    DateTime TimestampUtc
);

