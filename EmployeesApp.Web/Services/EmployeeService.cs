using EmployeesApp.Web.Models;
using EmployeesApp.Web.Views.Employees;
using static EmployeesApp.Web.Views.Employees.IndexVM;

namespace EmployeesApp.Web.Services
{
    public class EmployeeService
    {
        List<Employee> employees =
        [
            new Employee()
            {
                Id = 562,
                Name = "Anders Hejlsberg",
                Email = "admin.h@outlook.com",
            },
            new Employee()
            {
                Id = 62,
                Name = "Kathleen Dollard",
                Email = "k.d@outlook.com",
            },
            new Employee()
            {
                Id = 15662,
                Name = "Mads Torgersen",
                Email = "m.t@outlook.com",
            },
            new Employee()
            {
                Id = 52,
                Name = "Scott Hanselman",
                Email = "s.h@outlook.com",
            },
            new Employee()
            {
                Id = 563,
                Name = "Jon Skeet",
                Email = "j.s@outlook.com",
            },
        ];

        public void Add(Employee employee)
        {
            employee.Id = employees.Count < 0 ? 1 : employees.Max(e => e.Id) + 1;
            employees.Add(employee);
        }

        public IndexVM[] GetIndexVM()
        {
            var model = employees.Select(x => new IndexVM()
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                ShowAsHighlighted = x.Email.StartsWith("admin")
            }).ToArray();
            //var model = new IndexVM()
            //{
            //    EmployeeDatas = employees.Select(e =>
            //    new EmployeeDataVM()
            //    {
            //        Id = e.Id,
            //        Name = e.Name,
            //        Email = e.Email,
            //        ShowAsHighlighted = e.Email.StartsWith("admin")
            //    }).ToArray()
            //};

            return model;
        }
        public DetailsVM GetById(int id)
        {
            var employee = employees.Single(e => e.Id == id);
            return new DetailsVM() { Id = id, Name = employee.Name, Email = employee.Email };
        } 
    }
}