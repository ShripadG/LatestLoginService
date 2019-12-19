using System.ComponentModel.DataAnnotations;

namespace loginservice.Models
{
    public class ValidateLoginUsersAddRequest
    {
        public string Username { get; set; }
        
        public string Password { get; set; }
 
    }
}