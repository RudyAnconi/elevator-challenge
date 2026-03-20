namespace Elevator.Application.Contracts.Dtos;

public record HallRequestDto(
    Guid Id,
    int OriginFloor,
    int DestinationFloor,
    string Direction,
    string Status,
    string AccessLevel,
    bool IsVip,
    Guid? AssignedElevatorId,
    DateTime CreatedAtUtc
);

