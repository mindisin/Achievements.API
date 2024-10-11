using System.ComponentModel.DataAnnotations;

namespace Common.Requests.Auth
{
    public record RegisterUserRequest(
        [Required]
        string UserName,

        [Required]
        string Password,

        [Required]
        string Email);
}
