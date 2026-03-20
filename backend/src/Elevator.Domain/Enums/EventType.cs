namespace Elevator.Domain.Enums;

public enum EventType
{
    ElevatorStateChanged,
    HallRequestCreated,
    HallRequestAssigned,
    HallRequestRejected,
    PanelSessionStarted,
    PanelSessionTimedOut,
    PanelSessionCancelled,
    EmergencyStop,
    MaintenanceMode,
    MetricsUpdated
}

