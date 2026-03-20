using Elevator.Domain.Enums;

namespace Elevator.Application.Contracts.Dtos;

/// <summary>
/// Read-only projection of an ElevatorCar, sent to Angular via SignalR.
/// </summary>
public record ElevatorDto(
    Guid Id,
    int CurrentFloor,
    ElevatorState State,
    Direction Direction,
    int? TargetFloor
);

