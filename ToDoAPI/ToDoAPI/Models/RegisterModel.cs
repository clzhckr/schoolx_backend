using System.ComponentModel.DataAnnotations;

namespace ToDoAPI.Models
{
    public class RegisterModel
    {

        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        
        [RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
           + "@"
           + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$",
           ErrorMessage = "You have entered an invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        
        
    }
}