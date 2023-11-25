using MediatR;

public sealed record GetNotificationByIdRequest(Guid Id) : IRequest<GetNotificationByIdResponse>;