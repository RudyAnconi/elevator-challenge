namespace Elevator.Application.Contracts.Commands;

public record SetMaintenanceCommand(
    Guid ElevatorId,
    bool Enabled,
    int CurrentFloor,
    DateTime TimestampUtc
);

