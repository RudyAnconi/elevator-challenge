using Elevator.Domain.Enums;

namespace Elevator.Application.Contracts.Dtos;

/// <summary>
/// Read-only projection of a HallRequest.
/// </summary>
public record HallRequestDto(
    Guid Id,
    int Floor,
    Direction Direction,
    RequestStatus Status,
    Guid? AssignedElevatorId,
    DateTimeOffset CreatedAt
);

