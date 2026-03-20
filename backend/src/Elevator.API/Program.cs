using Elevator.Extensions;
using Elevator.Presentation.Endpoints;
using Elevator.Presentation.Hubs;

var builder = WebApplication.CreateBuilder(args);
// ── Infrastructure ─────────────────────────────────────────────────────────
builder.Services.AddElevatorInfrastructure();
// ── Application services ───────────────────────────────────────────────────
builder.Services.AddElevatorApplication();
// ── Background worker ──────────────────────────────────────────────────────
builder.Services.AddElevatorWorkers();
// ── SignalR ────────────────────────────────────────────────────────────────
builder.Services.AddSignalR();
// ── OpenAPI (dev only) ─────────────────────────────────────────────────────
builder.Services.AddOpenApi();
// ── CORS — allow Angular dev server ───────────────────────────────────────
builder.Services.AddCors(options =>
    options.AddDefaultPolicy(policy =>
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials())); // required for SignalR

// ──────────────────────────────────────────────────────────────────────────
var app = builder.Build();
if (app.Environment.IsDevelopment())
    app.MapOpenApi();
app.UseCors();
// ── Minimal API endpoints ──────────────────────────────────────────────────
app.MapStateEndpoints();
// ── SignalR hub ────────────────────────────────────────────────────────────
app.MapHub<ElevatorHub>("/hubs/elevator");
app.Run();
