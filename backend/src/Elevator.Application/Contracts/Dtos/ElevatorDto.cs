namespace Elevator.Application.Contracts.Dtos;

public record ElevatorDto(
    Guid Id,
    int CurrentFloor,
    int? NextDestinationFloor,
    string Direction,
    string State,
    bool IsInMaintenance,
    bool IsEmergencyStopped,
    int CurrentPassengers,
    List<int> UpQueue,
    List<int> DownQueue,
    List<int> PriorityQueue
);

