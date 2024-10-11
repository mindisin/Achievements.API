using Application.Interfaces;
using Common.Requests.Auth;
using Microsoft.AspNetCore.Mvc;

namespace Achievements.API.Endpoints
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthEndpoint : ControllerBase
    {
        private readonly IUserService _userService;
        public AuthEndpoint(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost("register")]
         public async Task<IResult> Register([FromBody] RegisterUserRequest request, CancellationToken cancellationToken)
        {
            await _userService.Register(request.UserName, request.Email, request.Password, cancellationToken);

            return Results.Ok();
        }

        [HttpPost("login")]
        public async Task<IResult> Login([FromBody]LoginUserRequest request,
            CancellationToken cancellationToken)
        {
            var token = await _userService.Login(request.Email, request.Password, cancellationToken);

            // сохранить токен в куки

            return Results.Ok(token);
        }
    }
}
