using System.Collections.Concurrent;
using Elevator.Application.Contracts.Interfaces;
using Elevator.Domain.Entities;

namespace Elevator.Infrastructure.State;

/// <summary>
/// Thread-safe in-memory store for all simulation state.
/// Replaces any database for this in-memory scenario.
/// TODO: Add locking strategy or concurrent collections for high-frequency writes.
/// </summary>
public sealed class InMemorySystemStateStore : ISystemStateStore
{
    private readonly List<ElevatorCar> _elevators = [];
    private readonly List<HallRequest> _hallRequests = [];
    private readonly ConcurrentDictionary<Guid, PanelSession> _sessions = new();

    public IReadOnlyList<ElevatorCar> Elevators => _elevators.AsReadOnly();
    public IReadOnlyList<HallRequest> HallRequests => _hallRequests.AsReadOnly();
    public IReadOnlyList<PanelSession> PanelSessions => _sessions.Values.ToList().AsReadOnly();

    public ElevatorCar? GetElevator(Guid id) =>
        _elevators.FirstOrDefault(e => e.Id == id);

    public void UpdateElevator(ElevatorCar elevator)
    {
        // TODO: Replace existing entry by id
        throw new NotImplementedException();
    }

    public void AddHallRequest(HallRequest request) =>
        _hallRequests.Add(request);

    public void UpdateHallRequest(HallRequest request)
    {
        // TODO: Find and replace request by id
        throw new NotImplementedException();
    }

    public void AddPanelSession(PanelSession session) =>
        _sessions[session.Id] = session;

    public void RemovePanelSession(Guid sessionId) =>
        _sessions.TryRemove(sessionId, out _);

    public void Initialize(int elevatorCount = 5, int floorCount = 20)
    {
        _elevators.Clear();
        _hallRequests.Clear();
        _sessions.Clear();

        for (var i = 0; i < elevatorCount; i++)
            _elevators.Add(ElevatorCar.CreateNew()); // all start at floor 0
    }
}

