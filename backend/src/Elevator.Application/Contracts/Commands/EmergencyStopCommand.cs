namespace Elevator.Application.Contracts.Commands;

/// <summary>
/// Triggers an emergency stop for a specific elevator or all elevators.
/// Sets state to EmergencyStopped and cancels all pending requests.
/// </summary>
public record EmergencyStopCommand(
    Guid? ElevatorId,    // null = all elevators
    string Reason
    // TODO: Add operator id, severity level
);

