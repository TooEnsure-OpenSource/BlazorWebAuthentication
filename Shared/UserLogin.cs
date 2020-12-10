using System.ComponentModel.DataAnnotations;

namespace root.Shared
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Must enter Username.")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Must enter Password")]
        public string Password { get; set; }
    }
}