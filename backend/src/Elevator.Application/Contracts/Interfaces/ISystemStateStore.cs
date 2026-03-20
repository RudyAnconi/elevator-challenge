using Elevator.Domain.Entities;

namespace Elevator.Application.Contracts.Interfaces;

/// <summary>
/// Single source of truth for all in-memory state: elevators, hall requests, sessions.
/// All reads and writes go through this store — no direct collection access elsewhere.
/// </summary>
public interface ISystemStateStore
{
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

    /// <summary>Seeds 5 elevators at floor 0 and clears all requests/sessions.</summary>
    void Initialize(int elevatorCount = 5, int floorCount = 20);

    // TODO: Snapshot / restore for replay, concurrent access guards
}

