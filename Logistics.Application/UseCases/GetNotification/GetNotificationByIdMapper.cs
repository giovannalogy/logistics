using AutoMapper;

public sealed class GetNotificationByIdMapper : Profile
{
    public GetNotificationByIdMapper()
    {
        CreateMap<NotificationBuy, GetNotificationByIdResponse>();
    }
}
