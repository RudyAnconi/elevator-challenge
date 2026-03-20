using Elevator.Domain.Enums;

namespace Elevator.Application.Contracts.Dtos;

/// <summary>
/// Read-only projection of a SystemEvent for the audit log panel.
/// </summary>
public record SystemEventDto(
    Guid Id,
    EventType Type,
    string Message,
    string? Payload,
    DateTimeOffset OccurredAt
);

