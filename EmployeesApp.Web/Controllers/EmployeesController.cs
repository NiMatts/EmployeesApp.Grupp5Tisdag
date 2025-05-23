﻿using EmployeesApp.Web.Models;
using EmployeesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;
using EmployeesApp.Web.Views.Employees;

namespace EmployeesApp.Web.Controllers
{
    public class EmployeesController : Controller
    {
        static EmployeeService service = new EmployeeService();

        [HttpGet("")]
        public IActionResult Index()
        {
            var model = service.GetIndexVM();
            return View(model);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(CreateVM createVM)
        {
            if (!ModelState.IsValid)
                return View();

            var employee = new Employee()
            {
                Id = service.GetIndexVM().Max(x => x.Id + 1),
                Name = createVM.Name,
                Email = createVM.Email
            };
            service.Add(employee);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            var model = service.GetById(id);
            return View(model);
        }
    }
}
