namespace Elevator.Application.Contracts.Commands;

/// <summary>
/// Puts an elevator into or out of maintenance mode.
/// Maintenance mode prevents new hall requests from being assigned.
/// </summary>
public record SetMaintenanceCommand(
    Guid ElevatorId,
    bool Enable,
    string? Note
    // TODO: Add scheduled window, technician id
);

