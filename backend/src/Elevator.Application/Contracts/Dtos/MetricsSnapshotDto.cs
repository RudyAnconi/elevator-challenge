namespace Elevator.Application.Contracts.Dtos;

public record MetricsSnapshotDto(
    int TotalRequests,
    int CompletedRequests,
    int RejectedRequests,
    double AverageWaitTimeSeconds,
    int ActiveElevators,
    int PendingRequests
);

