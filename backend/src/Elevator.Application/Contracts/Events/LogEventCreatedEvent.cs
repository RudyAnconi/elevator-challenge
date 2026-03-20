using Elevator.Domain.Enums;

namespace Elevator.Application.Contracts.Events;

/// <summary>
/// Published when a new SystemEvent is persisted to the in-memory log.
/// Feeds the live audit log panel in the Angular UI.
/// </summary>
public record LogEventCreatedEvent(
    Guid EventId,
    EventType Type,
    string Message,
    DateTimeOffset OccurredAt
);

