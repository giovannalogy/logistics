using AutoMapper;
using MediatR;

public sealed class GetNotificationMapper : Profile
{
    public GetNotificationMapper() { 
        CreateMap<NotificationBuy, GetNotificacaoResponse>();
    }
}
