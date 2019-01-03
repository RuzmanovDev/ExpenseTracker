using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.WebApi.DtoModels
{
    public partial class UsersController
    {
        public class LoginDto
        {
            [Required]
            public string Email { get; set; }

            [Required]
            public string Password { get; set; }

        }
    }
}
