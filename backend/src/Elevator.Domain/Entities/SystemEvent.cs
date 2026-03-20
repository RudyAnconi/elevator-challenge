using Elevator.Domain.Enums;

namespace Elevator.Domain.Entities;

/// <summary>
/// An immutable record of something that occurred in the system.
/// Used for audit log and frontend log panel.
/// </summary>
public class SystemEvent
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public EventType Type { get; init; }
    public string Message { get; init; } = string.Empty;
    public string? Payload { get; init; }
    public DateTimeOffset OccurredAt { get; init; } = DateTimeOffset.UtcNow;

    // TODO: Add severity, source elevator id, correlation id
}

