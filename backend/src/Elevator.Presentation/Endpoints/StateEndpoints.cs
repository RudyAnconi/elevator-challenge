using Elevator.Application.Contracts.Dtos;
using Elevator.Application.Contracts.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Elevator.Presentation.Endpoints;

/// <summary>
/// Minimal API endpoints for polling / REST fallback.
/// Angular can call these for initial page load before SignalR sync.
/// </summary>
public static class StateEndpoints
{
    public static IEndpointRouteBuilder MapStateEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/state").WithTags("State");

        // GET /api/state/elevators
        group.MapGet("/elevators", (ISystemStateStore store) =>
        {
            // TODO: Map ElevatorCar → ElevatorDto
            return Results.Ok(Array.Empty<ElevatorDto>());
        }).WithName("GetElevators");

        // GET /api/state/hall-requests
        group.MapGet("/hall-requests", (ISystemStateStore store) =>
        {
            // TODO: Map HallRequest → HallRequestDto, optional status filter
            return Results.Ok(Array.Empty<HallRequestDto>());
        }).WithName("GetHallRequests");

        // GET /api/state/metrics
        group.MapGet("/metrics", async (IMetricsService metrics, CancellationToken ct) =>
        {
            // TODO: Map MetricsSnapshot → MetricsSnapshotDto
            await Task.CompletedTask;
            return Results.Ok(default(MetricsSnapshotDto));
        }).WithName("GetMetrics");

        // GET /api/state/events
        group.MapGet("/events", async (IEventLogService log, CancellationToken ct) =>
        {
            // TODO: Return last N events as SystemEventDto
            await Task.CompletedTask;
            return Results.Ok(Array.Empty<SystemEventDto>());
        }).WithName("GetEvents");

        return app;
    }
}

