using Elevator.Domain.Enums;

namespace Elevator.Domain.Entities;

public class SystemEvent
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public EventType Type { get; set; }
    public DateTime TimestampUtc { get; set; } = DateTime.UtcNow;
    public string Description { get; set; } = string.Empty;
    public Guid? RelatedEntityId { get; set; }
}

