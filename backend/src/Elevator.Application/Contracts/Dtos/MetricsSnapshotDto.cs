namespace Elevator.Application.Contracts.Dtos;

/// <summary>
/// Read-only metrics snapshot DTO sent to the Angular dashboard.
/// </summary>
public record MetricsSnapshotDto(
    int TotalRequests,
    int CompletedRequests,
    int PendingRequests,
    int ActiveElevators,
    double AverageWaitSeconds,
    DateTimeOffset CapturedAt
);

