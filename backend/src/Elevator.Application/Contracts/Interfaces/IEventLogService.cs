using Elevator.Domain.Entities;

namespace Elevator.Application.Contracts.Interfaces;

/// <summary>
/// Persists SystemEvents to the in-memory audit log.
/// </summary>
public interface IEventLogService
{
    Task LogAsync(SystemEvent @event, CancellationToken cancellationToken);
    Task<IReadOnlyList<SystemEvent>> GetRecentAsync(int count, CancellationToken cancellationToken);
    Task<IReadOnlyList<SystemEvent>> GetByTypeAsync(Domain.Enums.EventType type, CancellationToken cancellationToken);

    // TODO: Clear, filter by time range
}

