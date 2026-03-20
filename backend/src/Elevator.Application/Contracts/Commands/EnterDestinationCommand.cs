namespace Elevator.Application.Contracts.Commands;

public record EnterDestinationCommand(
    Guid PanelSessionId,
    int Floor,
    int DestinationFloor,
    DateTime TimestampUtc
);

