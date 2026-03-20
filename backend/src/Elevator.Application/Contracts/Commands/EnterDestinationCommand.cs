namespace Elevator.Application.Contracts.Commands;

/// <summary>
/// Sent when a passenger selects a destination floor from the in-cab panel.
/// Requires an active PanelSession for the elevator.
/// </summary>
public record EnterDestinationCommand(
    Guid ElevatorId,
    Guid SessionId,
    int DestinationFloor
    // TODO: Add passenger count, load override
);

