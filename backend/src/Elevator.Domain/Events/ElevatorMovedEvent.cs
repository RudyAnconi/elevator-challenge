using Elevator.Domain.Enums;
using Elevator.Domain.Events;

namespace Elevator.Domain.Events;

/// <summary>
/// Raised when an elevator transitions between floors or states.
/// </summary>
public record ElevatorMovedEvent(
    Guid Id,
    Guid ElevatorId,
    int FromFloor,
    int ToFloor,
    Direction Direction,
    DateTimeOffset OccurredAt
) : IDomainEvent;

