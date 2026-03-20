namespace Elevator.Application.Contracts.Commands;

/// <summary>
/// Explicitly cancels an active panel session before it times out.
/// </summary>
public record CancelPanelSessionCommand(
    Guid SessionId,
    string? CancelledBy
    // TODO: Add cancellation reason enum
);

