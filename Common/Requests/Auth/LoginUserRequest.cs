using System.ComponentModel.DataAnnotations;

namespace Common.Requests.Auth
{
    public class LoginUserRequest
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
        
}
