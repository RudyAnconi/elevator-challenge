namespace Elevator.Application.Contracts.Commands;

public record RetryRequestCommand(
    Guid RequestId,
    DateTime TimestampUtc
);

