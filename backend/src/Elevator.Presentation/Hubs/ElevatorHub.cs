using Elevator.Application.Contracts.Commands;
using Elevator.Application.Contracts.Events;
using Elevator.Application.Contracts.Interfaces;
using Microsoft.AspNetCore.SignalR;

namespace Elevator.Presentation.Hubs;

/// <summary>
/// SignalR hub — Angular clients connect here to receive real-time state updates
/// and send commands (hall calls, card swipes, emergency stop).
///
/// Client methods pushed from server:
///   - "ElevatorStateChanged"  → ElevatorStateChangedEvent
///   - "HallRequestAssigned"   → HallRequestAssignedEvent
///   - "HallRequestRejected"   → HallRequestRejectedEvent
///   - "MetricsUpdated"        → MetricsUpdatedEvent
///   - "LogEventCreated"       → LogEventCreatedEvent
///   - "PanelSessionTimedOut"  → PanelSessionTimedOutEvent
/// </summary>
public sealed class ElevatorHub(
    IDispatchService dispatch,
    IPanelSessionService panelSession,
    ISystemStateStore store
) : Hub
{
    // ── Client → Server ────────────────────────────────────────────────────

    /// <summary>Hall button pressed on a floor.</summary>
    public async Task CallElevator(int floor, string direction)
    {
        // TODO: Parse direction, call dispatch.CreateHallRequestAsync
        throw new NotImplementedException();
    }

    /// <summary>Passenger swipes card on in-cab panel.</summary>
    public async Task SwipeCard(SwipeCardCommand command)
    {
        // TODO: panelSession.StartSessionAsync, push session started event
        throw new NotImplementedException();
    }

    /// <summary>Passenger selects destination floor inside elevator.</summary>
    public async Task EnterDestination(EnterDestinationCommand command)
    {
        // TODO: Validate active session, call engine.RequestFloorAsync
        throw new NotImplementedException();
    }

    /// <summary>Operator triggers emergency stop.</summary>
    public async Task EmergencyStop(EmergencyStopCommand command)
    {
        // TODO: Update elevator state, broadcast to all clients
        throw new NotImplementedException();
    }

    // ── Connection lifecycle ───────────────────────────────────────────────

    public override async Task OnConnectedAsync()
    {
        // TODO: Push current state snapshot to the newly connected client
        await base.OnConnectedAsync();
    }
}

