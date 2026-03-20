using Elevator.Domain.Enums;

namespace Elevator.Domain.Entities;

public class PanelSession
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public int Floor { get; set; }
    public AccessLevel AccessLevel { get; set; } = AccessLevel.None;
    public int? EnteredDestination { get; set; }
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime LastInteractionAtUtc { get; set; } = DateTime.UtcNow;
    public bool IsExpired { get; set; } = false;
}

