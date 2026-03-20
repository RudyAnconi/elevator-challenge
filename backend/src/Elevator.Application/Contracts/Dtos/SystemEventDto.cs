namespace Elevator.Application.Contracts.Dtos;

public record SystemEventDto(
    Guid Id,
    string Type,
    string Description,
    Guid? RelatedEntityId,
    DateTime TimestampUtc
);

