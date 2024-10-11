using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Shared.Requests.Auth;

namespace Achievements.API.Endpoints
{
    public static class UsersEndpoints
    {
        public static IEndpointRouteBuilder MapUsersEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapPost("register", Register);

            app.MapPost("login", Login);

            return app;
        }

        private static async Task<IResult> Register(RegisterUserRequest request,
            UserService userService, CancellationToken cancellationToken)
        {
            await userService.Register(request.UserName, request.Email, request.Password, cancellationToken);

            return Results.Ok();
        }

        private static async Task<IResult> Login(LoginUserRequest request, UserService userService,
            CancellationToken cancellationToken)
        {
            var token = userService.Login(request.Email, request.Password, cancellationToken);

            // сохранить токен в куки

            return Results.Ok(token);
        }
    }
}
