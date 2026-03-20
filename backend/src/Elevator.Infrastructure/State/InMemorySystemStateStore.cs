using Elevator.Application.Contracts.Interfaces;
using Elevator.Domain.Entities;
using Elevator.Domain.Enums;

namespace Elevator.Infrastructure.State;

/// <summary>
/// In-memory store for all simulation state.
/// Replaces any database for this in-memory scenario.
/// TODO: Add locking strategy or concurrent collections for high-frequency writes.
/// </summary>
public sealed class InMemorySystemStateStore : ISystemStateStore
{
    private const int DefaultElevatorCount = 5;
    private const int DefaultMinFloor = 0;
    private const int DefaultMaxFloor = 20;

    private readonly List<ElevatorCar> _elevators = [];
    private readonly List<HallRequest> _hallRequests = [];
    private readonly List<PanelSession> _panelSessions = [];
    private readonly List<SystemEvent> _systemEvents = [];

    public int MinSupportedFloor => DefaultMinFloor;
    public int MaxSupportedFloor => DefaultMaxFloor;

    public IReadOnlyList<ElevatorCar> Elevators => _elevators.AsReadOnly();
    public IReadOnlyList<HallRequest> HallRequests => _hallRequests.AsReadOnly();
    public IReadOnlyList<PanelSession> PanelSessions => _panelSessions.AsReadOnly();
    public IReadOnlyList<SystemEvent> SystemEvents => _systemEvents.AsReadOnly();

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
        _panelSessions.Add(session);

    public void RemovePanelSession(Guid sessionId) =>
        _panelSessions.RemoveAll(session => session.Id == sessionId);

    public void AddSystemEvent(SystemEvent systemEvent) =>
        _systemEvents.Add(systemEvent);

    public void Initialize(int elevatorCount = 5, int floorCount = 20)
    {
        _ = elevatorCount;
        _ = floorCount;

        _elevators.Clear();
        _hallRequests.Clear();
        _panelSessions.Clear();
        _systemEvents.Clear();

        for (var i = 0; i < DefaultElevatorCount; i++)
        {
            _elevators.Add(new ElevatorCar
            {
                CurrentFloor = DefaultMinFloor,
                Direction = Direction.None,
                State = ElevatorState.Idle,
                UpQueue = [],
                DownQueue = [],
                PriorityQueue = [],
                CurrentPassengers = 0,
                IsInMaintenance = false,
                IsEmergencyStopped = false,
                NextDestinationFloor = null
            });
        }
    }
}

