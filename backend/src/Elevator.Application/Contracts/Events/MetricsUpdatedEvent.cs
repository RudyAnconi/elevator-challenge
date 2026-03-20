using Elevator.Domain.ValueObjects;

namespace Elevator.Application.Contracts.Events;

/// <summary>
/// Published on each metrics tick so the Angular dashboard can refresh stats.
/// </summary>
public record MetricsUpdatedEvent(
    MetricsSnapshot Snapshot,
    DateTimeOffset OccurredAt
);

