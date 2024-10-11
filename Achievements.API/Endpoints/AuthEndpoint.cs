using Application.Interfaces;
using Common.Requests.Auth;
using Microsoft.AspNetCore.Mvc;

namespace Achievements.API.Endpoints
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthEndpoint
    {
        /*
        public IEndpointRouteBuilder MapUsersEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapPost("register", Register);

            app.MapPost("login", Login);

            return app;
        }
        */

        [HttpPost("register")]
        private async Task<IResult> Register(RegisterUserRequest request,
            IUserService userService, CancellationToken cancellationToken)
        {
            await userService.Register(request.UserName, request.Email, request.Password, cancellationToken);

            return Results.Ok();
        }

        [HttpPost("login")]
        private async Task<IResult> Login(LoginUserRequest request, IUserService userService,
            CancellationToken cancellationToken)
        {
            var token = await userService.Login(request.Email, request.Password, cancellationToken);

            // сохранить токен в куки

            return Results.Ok(token);
        }
    }
}
