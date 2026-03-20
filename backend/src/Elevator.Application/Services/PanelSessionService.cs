using Elevator.Application.Contracts.Interfaces;
using Elevator.Domain.Entities;

namespace Elevator.Application.Services;

/// <summary>
/// Placeholder — manages lifecycle of in-cab panel sessions.
/// TODO: Implement card validation, session expiry timer, event publishing.
/// </summary>
public sealed class PanelSessionService(ISystemStateStore store) : IPanelSessionService
{
    private static readonly TimeSpan DefaultSessionTimeout = TimeSpan.FromSeconds(30);

    public Task<PanelSession> StartSessionAsync(Guid elevatorId, string cardToken, CancellationToken cancellationToken)
    {
        // TODO: Validate card token, resolve access level, set expiry, store session
        throw new NotImplementedException();
    }

    public Task EndSessionAsync(Guid sessionId, CancellationToken cancellationToken)
    {
        // TODO: Remove session from store, publish PanelSessionCancelled
        throw new NotImplementedException();
    }

    public Task<PanelSession?> GetActiveSessionAsync(Guid elevatorId, CancellationToken cancellationToken)
    {
        // TODO: Return non-expired session for elevator
        throw new NotImplementedException();
    }

    public Task ExpireTimedOutSessionsAsync(CancellationToken cancellationToken)
    {
        // TODO: Find expired sessions, remove, publish PanelSessionTimedOutEvent
        throw new NotImplementedException();
    }
}

