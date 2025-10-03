using Asp.Versioning;
using IDP.Api.Controllers.BaseController;
using IDP.Application.Command.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IDP.Api.Controllers.V1
{
    
    [ApiController]
    [ApiVersion(1)]
    [Route("api/v{v:apiVersion}/user")]
    public class UserController : IBaseController
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// درج کاربر
        /// </summary>
        /// <param name="userCommand"></param>
        /// <returns></returns>
        [MapToApiVersion(1)]
        [HttpPost("Insert")]
        public async Task<IActionResult> InsertAsync([FromBody] UserCommand userCommand)
        {
            var res = await _mediator.Send(userCommand);

            return Ok(res);
        }

    }
}
