using Elevator.Domain.Enums;

namespace Elevator.Application.Contracts.Dtos;

/// <summary>
/// Read-only projection of a PanelSession.
/// </summary>
public record PanelSessionDto(
    Guid Id,
    Guid ElevatorId,
    AccessLevel AccessLevel,
    DateTimeOffset StartedAt,
    DateTimeOffset? ExpiresAt,
    bool IsExpired
);

