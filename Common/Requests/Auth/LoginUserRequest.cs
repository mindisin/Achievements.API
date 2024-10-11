using System.ComponentModel.DataAnnotations;

namespace Shared.Requests.Auth
{
    public record LoginUserRequest(
        [Required]
        string Email,

        [Required]
        string Password);
}
