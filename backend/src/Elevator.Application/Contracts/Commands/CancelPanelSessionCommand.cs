namespace Elevator.Application.Contracts.Commands;

public record CancelPanelSessionCommand(
    Guid PanelSessionId,
    string Reason,
    DateTime TimestampUtc
);

