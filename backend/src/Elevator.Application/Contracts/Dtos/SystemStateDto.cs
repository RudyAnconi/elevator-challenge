namespace Elevator.Application.Contracts.Dtos;

public record SystemStateDto(
	List<ElevatorDto> Elevators,
	List<HallRequestDto> HallRequests,
	List<PanelSessionDto> PanelSessions,
	List<SystemEventDto> RecentEvents,
	MetricsSnapshotDto Metrics,
	DateTime GeneratedAtUtc
);

