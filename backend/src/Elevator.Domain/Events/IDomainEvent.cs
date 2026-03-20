namespace Elevator.Domain.Events;

/// <summary>
/// Marker interface for all domain events raised within the Elevator domain.
/// </summary>
public interface IDomainEvent
{
    Guid Id { get; }
    DateTimeOffset OccurredAt { get; }
}

