using Elevator.Domain.Entities;

namespace Elevator.Application.Contracts.Interfaces;

/// <summary>
/// Single source of truth for all in-memory state: elevators, hall requests, sessions, and events.
/// All reads and writes go through this store — no direct collection access elsewhere.
/// </summary>
public interface ISystemStateStore
{
    int MinSupportedFloor { get; }
    int MaxSupportedFloor { get; }

    // ── Elevators ──────────────────────────────────────────────────────────
    IReadOnlyList<ElevatorCar> Elevators { get; }
    ElevatorCar? GetElevator(Guid id);
    void UpdateElevator(ElevatorCar elevator);

    // ── Hall Requests ──────────────────────────────────────────────────────
    IReadOnlyList<HallRequest> HallRequests { get; }
    void AddHallRequest(HallRequest request);
    void UpdateHallRequest(HallRequest request);

    // ── Panel Sessions ─────────────────────────────────────────────────────
    IReadOnlyList<PanelSession> PanelSessions { get; }
    void AddPanelSession(PanelSession session);
    void RemovePanelSession(Guid sessionId);

    // ── System Events ──────────────────────────────────────────────────────
    IReadOnlyList<SystemEvent> SystemEvents { get; }
    void AddSystemEvent(SystemEvent systemEvent);

    /// <summary>Seeds 5 elevators at floor 0 and clears all in-memory collections.</summary>
    void Initialize(int elevatorCount = 5, int floorCount = 20);

    // TODO: Snapshot / restore for replay, concurrent access guards
}

