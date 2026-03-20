namespace Elevator.Application.Contracts.Dtos;

public record PanelSessionDto(
    Guid Id,
    int Floor,
    string AccessLevel,
    int? EnteredDestination,
    bool IsExpired,
    DateTime CreatedAtUtc,
    DateTime LastInteractionAtUtc
);

