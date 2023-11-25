using MediatR;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class NotificationController : ControllerBase
{
    IMediator _mediator;
    public NotificationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateNotificationRequest request)
    {
        try
        {
            var notification = await _mediator.Send(request);
            return Ok(notification);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpGet]
    public async Task<ActionResult<List<GetNotificationResponse>>> GetAll(CancellationToken cancellationToken)
    {
        {
            try
            {
                var notifications = await _mediator.Send(new GetNotificationRequest(), cancellationToken);
                return Ok(notifications);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetNotificationByIdResponse>> Get(Guid id, CancellationToken cancellationToken)
    {
        {
            try
            {
                var notification = await _mediator.Send(id, cancellationToken);
                return Ok(notification);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
