namespace Elevator.Domain.ValueObjects;

public class MetricsSnapshot
{
    public int TotalRequests { get; set; }
    public int CompletedRequests { get; set; }
    public int RejectedRequests { get; set; }
    public double AverageWaitTimeSeconds { get; set; }
    public int ActiveElevators { get; set; }
    public int PendingRequests { get; set; }
}

