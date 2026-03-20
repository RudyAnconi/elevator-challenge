namespace Elevator.Application.Contracts.Commands;

/// <summary>
/// Sent when a user swipes an access card on the in-cab panel.
/// Initiates a PanelSession for the given elevator.
/// </summary>
public record SwipeCardCommand(
    Guid ElevatorId,
    string CardToken
    // TODO: Add reader zone, timestamp
);

