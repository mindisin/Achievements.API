using System.ComponentModel.DataAnnotations;

namespace Shared.Requests.Auth
{
    public record RegisterUserRequest(
        [Required]
        string UserName,

        [Required]
        string Password,

        [Required]
        string Email);
}
