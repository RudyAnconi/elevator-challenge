using Elevator.Application.Contracts.Dtos;

namespace Elevator.Application.Contracts.Events;

public record LogEventCreatedEvent(
    SystemEventDto Event,
    DateTime OccurredAtUtc
);

