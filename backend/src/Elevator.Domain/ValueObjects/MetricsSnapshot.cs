namespace Elevator.Domain.ValueObjects;

/// <summary>
/// Immutable snapshot of system-wide performance metrics at a point in time.
/// </summary>
public record MetricsSnapshot(
    int TotalRequests,
    int CompletedRequests,
    int PendingRequests,
    int ActiveElevators,
    double AverageWaitSeconds,
    DateTimeOffset CapturedAt
    // TODO: Add per-elevator stats, peak hours, floor heatmap
);

