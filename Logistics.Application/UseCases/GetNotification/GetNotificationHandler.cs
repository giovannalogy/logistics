using MediatR;
using AutoMapper;


public sealed class GetNotificacaoHandler : IRequestHandler<GetNotificationRequest, List<GetNotificationResponse>>
{
    private readonly INotificationBuyRepository _NotificacaoRepository;
    private readonly IMapper _mapper;

    public GetNotificacaoHandler(INotificationBuyRepository NotificationRepository, IMapper mapper)
    {
        _NotificationRepository = NotificationRepository;
        _mapper = mapper;
    }

    public async Task<List<GetNotificacaoResponse>> Handle(GetNotificationRequest request, CancellationToken cancellationToken)
    {
        var notificacoes = await _NotificationRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetNotificationResponse>>(notifications);
    }
}

