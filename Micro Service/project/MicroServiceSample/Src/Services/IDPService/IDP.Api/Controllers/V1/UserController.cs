using IDP.Api.Controllers.BaseController;
using IDP.Application.Command.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IDP.Api.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : IBaseController
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost("Insert")]
        public async Task<IActionResult> InsertAsync([FromBody] UserCommand userCommand)
        {
            var res = await _mediator.Send(userCommand);

            return Ok(res);
        }

    }
}
