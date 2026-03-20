using Elevator.Domain.Enums;

namespace Elevator.Application.Contracts.Events;

/// <summary>
/// Published whenever an elevator transitions to a new state.
/// Broadcasted to Angular clients via SignalR.
/// </summary>
public record ElevatorStateChangedEvent(
    Guid ElevatorId,
    int CurrentFloor,
    ElevatorState OldState,
    ElevatorState NewState,
    Direction Direction,
    DateTimeOffset OccurredAt
);

