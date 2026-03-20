namespace Elevator.Domain.Enums;

public enum EventType
{
    RequestCreated,
    Assigned,
    Rejected,
    ElevatorMoved,
    DoorOpened,
    DoorClosed,
    Emergency,
    Maintenance,
    Timeout
}

