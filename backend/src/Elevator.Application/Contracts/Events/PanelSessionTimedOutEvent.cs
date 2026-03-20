namespace Elevator.Application.Contracts.Events;

public record PanelSessionTimedOutEvent(
    Guid PanelSessionId,
    int Floor,
    string Reason,
    DateTime OccurredAtUtc
);

