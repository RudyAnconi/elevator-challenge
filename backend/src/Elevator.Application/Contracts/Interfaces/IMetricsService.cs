using Elevator.Domain.ValueObjects;

namespace Elevator.Application.Contracts.Interfaces;

/// <summary>
/// Computes and caches system-wide performance metrics.
/// </summary>
public interface IMetricsService
{
    Task<MetricsSnapshot> GetSnapshotAsync(CancellationToken cancellationToken);

    /// <summary>Recomputes metrics from current system state.</summary>
    Task RefreshAsync(CancellationToken cancellationToken);

    // TODO: GetHistoryAsync, ResetAsync
}

