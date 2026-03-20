using Elevator.Domain.Entities;

namespace Elevator.Application.Contracts.Interfaces;

/// <summary>
/// Manages in-cab panel sessions (card swipe → destination entry → timeout).
/// </summary>
public interface IPanelSessionService
{
    Task<PanelSession> StartSessionAsync(Guid elevatorId, string cardToken, CancellationToken cancellationToken);
    Task EndSessionAsync(Guid sessionId, CancellationToken cancellationToken);
    Task<PanelSession?> GetActiveSessionAsync(Guid elevatorId, CancellationToken cancellationToken);

    /// <summary>Scans all sessions and expires those past their deadline.</summary>
    Task ExpireTimedOutSessionsAsync(CancellationToken cancellationToken);

    // TODO: ExtendSessionAsync, ValidateCardAsync
}

