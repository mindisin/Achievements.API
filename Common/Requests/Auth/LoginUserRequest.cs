using System.ComponentModel.DataAnnotations;

namespace Common.Requests.Auth
{
    public record LoginUserRequest(
        [Required]
        string Email,

        [Required]
        string Password);
}
