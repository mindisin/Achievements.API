using System.ComponentModel.DataAnnotations;

namespace Common.Requests.Auth
{
    public class RegisterUserRequest
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
