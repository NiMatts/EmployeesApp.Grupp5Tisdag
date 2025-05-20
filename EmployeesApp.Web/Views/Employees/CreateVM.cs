namespace EmployeesApp.Web.Views.Employees
{
    public class CreateVM
    {
        public required string Name { get; set; }

        public required string Email { get; set; }
        
        public required int BotCheck { get; set; }
    }
}
