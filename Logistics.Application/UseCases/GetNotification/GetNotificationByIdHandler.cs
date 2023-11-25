using MediatR;
using AutoMapper;


public sealed class GetNotificationByIdHandler : IRequestHandler<GetNotificationByIdRequest, GetNotificationByIdResponse>
{
    private readonly INotificationBuyRepository _NotificacaoRepository;
    private readonly IMapper _mapper;

    public GetNotificationByIdHandler(INotificationBuyRepository NotificationRepository, IMapper mapper)
    {
        _NotificacaoRepository = NotificationRepository;
        _mapper = mapper;
    }

    public async Task<GetNotificacaoByIdResponse> Handle(GetNotificacaoByIdRequest request, CancellationToken cancellationToken)
    {
        var notificacoes = await _NotificacaoRepository.Get(request.Id, cancellationToken);
        return _mapper.Map<GetNotificacaoByIdResponse>(notificacoes);
    }
}