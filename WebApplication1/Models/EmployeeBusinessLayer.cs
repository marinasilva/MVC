using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp = new Employee();
            emp.FirstName = "Johnson";
            emp.LastName = "Fernandes";
            emp.Salary = 14000;
            employees.Add(emp);
            Employee emp2 = new Employee();
            emp2.FirstName = "Michael";
            emp2.LastName = "Jackson";
            emp2.Salary = 16000;
            employees.Add(emp2);
            Employee emp3 = new Employee();
            emp3.FirstName = "Robert";
            emp3.LastName = "Pattison";
            emp3.Salary = 20000;
            employees.Add(emp3);
            return employees;
        } 
    }
}