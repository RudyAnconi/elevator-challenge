namespace Elevator.Application.Contracts.Commands;

public record SwipeCardCommand(
    Guid PanelSessionId,
    int Floor,
    string CardCode,
    DateTime TimestampUtc
);

