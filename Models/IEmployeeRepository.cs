using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDashboard.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployees(); //https://stackoverflow.com/questions/41460167/using-ienumerator-to-iterate-through-a-list
        //Exposes an enumerator, which supports a simple iteration over a non-generic collection.


    }
}
