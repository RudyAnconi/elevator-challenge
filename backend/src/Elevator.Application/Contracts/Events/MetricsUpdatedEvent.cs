using Elevator.Application.Contracts.Dtos;

namespace Elevator.Application.Contracts.Events;

public record MetricsUpdatedEvent(
    MetricsSnapshotDto Metrics,
    DateTime OccurredAtUtc
);

