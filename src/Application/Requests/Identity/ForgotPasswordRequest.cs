using System.ComponentModel.DataAnnotations;

namespace Eventinars.Application.Requests.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}