namespace EmployeesApp.Web.Views.Employees
{
    public class IndexVM
    {
        public required EmployeeDataVM[] EmployeeDatas {  get; set; }
        public class EmployeeDataVM
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public bool ShowAsHighlighted { get; set; }
        }
    }
}
