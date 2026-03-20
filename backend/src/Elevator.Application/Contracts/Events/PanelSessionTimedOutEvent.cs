namespace Elevator.Application.Contracts.Events;

/// <summary>
/// Published when a panel session expires without being explicitly cancelled.
/// </summary>
public record PanelSessionTimedOutEvent(
    Guid SessionId,
    Guid ElevatorId,
    DateTimeOffset ExpiredAt
);

