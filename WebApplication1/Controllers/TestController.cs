using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        public string GetString()
        {
            return "Hello world is old now. It's time for wassup bro :) ";
        }

        public ActionResult GetView()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee> employees = employeeBusinessLayer.GetEmployees();

            List<EmployeeViewModel> employeeViewModels = new List<EmployeeViewModel>();

            foreach (Employee emp in employees)
            {
                EmployeeViewModel employeeViewModel = new EmployeeViewModel();
                employeeViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                employeeViewModel.Salary = emp.Salary.ToString("C");
                if (emp.Salary > 15000)
                {
                    employeeViewModel.SalaryColor = "yellow";
                }
                else
                {
                    employeeViewModel.SalaryColor = "green";
                }

                employeeViewModels.Add(employeeViewModel);
            }
            employeeListViewModel.Employees = employeeViewModels;
            employeeListViewModel.Username = "Admin";
            return View("MyView", employeeListViewModel);

        }
    }
}