using Elevator.Domain.Enums;

namespace Elevator.Domain.Entities;

/// <summary>
/// Represents a call from a floor hallway panel (up/down button press).
/// </summary>
public class HallRequest
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public int Floor { get; init; }
    public Direction Direction { get; init; }
    public RequestStatus Status { get; set; } = RequestStatus.Pending;
    public Guid? AssignedElevatorId { get; set; }
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;

    // TODO: Add retry count, priority, passenger weight estimate
}

