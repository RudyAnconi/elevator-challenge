using Elevator.Domain.Enums;

namespace Elevator.Domain.Entities;

/// <summary>
/// Represents an active in-cab panel session started by a card swipe.
/// Sessions expire after a configurable timeout.
/// </summary>
public class PanelSession
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public Guid ElevatorId { get; init; }
    public AccessLevel AccessLevel { get; set; } = AccessLevel.Public;
    public DateTimeOffset StartedAt { get; init; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? ExpiresAt { get; set; }
    public bool IsExpired => ExpiresAt.HasValue && DateTimeOffset.UtcNow > ExpiresAt.Value;

    // TODO: Add card token, destination floor selections, audit trail
}

