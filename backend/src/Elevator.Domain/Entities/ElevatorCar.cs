using Elevator.Domain.Enums;

namespace Elevator.Domain.Entities;

/// <summary>
/// Represents a physical elevator car in the simulation.
/// 5 instances will be seeded at startup, all starting at floor 0.
/// </summary>
public class ElevatorCar
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public int CurrentFloor { get; set; } = 0;
    public ElevatorState State { get; set; } = ElevatorState.Idle;
    public Direction Direction { get; set; } = Direction.None;
    public int? TargetFloor { get; set; }

    // TODO: Add floor queue, load sensor, door state, speed

    public static ElevatorCar CreateNew() => new();
}

