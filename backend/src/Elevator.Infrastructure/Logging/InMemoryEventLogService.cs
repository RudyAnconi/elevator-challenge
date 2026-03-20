using System.Collections.Concurrent;
using Elevator.Application.Contracts.Interfaces;
using Elevator.Domain.Entities;
using Elevator.Domain.Enums;

namespace Elevator.Infrastructure.Logging;

/// <summary>
/// Bounded in-memory ring buffer for system events.
/// TODO: Make capacity configurable, add optional structured payload serialisation.
/// </summary>
public sealed class InMemoryEventLogService : IEventLogService
{
    private const int MaxCapacity = 500;
    private readonly ConcurrentQueue<SystemEvent> _log = new();

    public Task LogAsync(SystemEvent @event, CancellationToken cancellationToken)
    {
        _log.Enqueue(@event);

        // Keep within capacity — drop oldest
        while (_log.Count > MaxCapacity)
            _log.TryDequeue(out _);

        return Task.CompletedTask;
    }

    public Task<IReadOnlyList<SystemEvent>> GetRecentAsync(int count, CancellationToken cancellationToken)
    {
        var result = _log.TakeLast(count).ToList().AsReadOnly();
        return Task.FromResult<IReadOnlyList<SystemEvent>>(result);
    }

    public Task<IReadOnlyList<SystemEvent>> GetByTypeAsync(EventType type, CancellationToken cancellationToken)
    {
        var result = _log.Where(e => e.Type == type).ToList().AsReadOnly();
        return Task.FromResult<IReadOnlyList<SystemEvent>>(result);
    }
}

