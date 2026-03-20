using System.Collections.Concurrent;
using Elevator.Domain.Entities;

namespace Elevator.Infrastructure.Queues;

/// <summary>
/// Thread-safe FIFO queue for incoming hall requests before dispatch.
/// TODO: Consider priority queue by floor proximity or request age.
/// </summary>
public sealed class InMemoryRequestQueue
{
    private readonly ConcurrentQueue<HallRequest> _queue = new();

    public void Enqueue(HallRequest request) => _queue.Enqueue(request);

    public bool TryDequeue(out HallRequest? request) => _queue.TryDequeue(out request);

    public int Count => _queue.Count;

    public IReadOnlyList<HallRequest> Peek() => _queue.ToList().AsReadOnly();
}

