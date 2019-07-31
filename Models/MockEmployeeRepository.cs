using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDashboard.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employeeList;
        public MockEmployeeRepository()
        {
        // adding three employees (dummy data) objects to list,
        //NOTE: we will get employee data from DB
            employeeList = new List<Employee>() {
                new Employee(){ Id= 1, Name= "robi", Email= "robi@gmail.com", Department= "HR" },
                new Employee(){ Id= 2, Name= "gul", Email= "gul@gmail.com", Department= "IT" },
                new Employee(){ Id= 3, Name= "abu", Email= "abu@gmail.com", Department= "IT" }

            };

        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return employeeList.Find(employee => employee.Id == Id); // lambda expression to search quickly.
        }
    }
}
