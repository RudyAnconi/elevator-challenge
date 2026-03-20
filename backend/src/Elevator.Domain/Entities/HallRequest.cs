using Elevator.Domain.Enums;

namespace Elevator.Domain.Entities;

public class HallRequest
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public int OriginFloor { get; set; }
    public int DestinationFloor { get; set; }
    public Direction Direction { get; set; } = Direction.None;
    public RequestStatus Status { get; set; } = RequestStatus.Pending;
    public AccessLevel AccessLevel { get; set; } = AccessLevel.None;
    public bool IsVip { get; set; } = false;
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public Guid? AssignedElevatorId { get; set; }
}

