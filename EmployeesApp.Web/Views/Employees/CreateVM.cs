using System.ComponentModel.DataAnnotations;
using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Views.Employees
{
    public class CreateVM
    {
        [Required(ErrorMessage = "You must specify a name")]
        [SuspiciousPerson("Pontus Wittenmark", ErrorMessage = "Suspicious person detected!")]
        public required string Name { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Invalid e-mail address")]
        [Required(ErrorMessage = "You must specify an e-mail address")]
        public required string Email { get; set; }
        [Required]
        [Range(4, 4)]
        public required int BotCheck { get; set; }
    }
}
