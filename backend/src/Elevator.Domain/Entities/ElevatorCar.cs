using Elevator.Domain.Enums;

namespace Elevator.Domain.Entities;

public class ElevatorCar
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public int CurrentFloor { get; set; } = 0;
    public Direction Direction { get; set; } = Direction.None;
    public ElevatorState State { get; set; } = ElevatorState.Idle;
    public List<int> UpQueue { get; set; } = [];
    public List<int> DownQueue { get; set; } = [];
    public List<int> PriorityQueue { get; set; } = [];
    public int CurrentPassengers { get; set; } = 0;
    public bool IsInMaintenance { get; set; } = false;
    public bool IsEmergencyStopped { get; set; } = false;
    public int? NextDestinationFloor { get; set; }
}

