using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Views.Employees
{
    public class CreateVM
    {
        [Required]
        public required string Name { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        [Range(4, 4)]
        public required int BotCheck { get; set; }
    }
}
