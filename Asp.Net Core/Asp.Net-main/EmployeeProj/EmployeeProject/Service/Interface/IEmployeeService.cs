using System.Collections.Generic;
using EmployeeProject.Models;

namespace EmployeeProject.Service.Interface
{
    public interface IEmployeeService
    {
        // CREATE
        void CreateEmployee(EmployeeModel employee);
        
        // READ
        IEnumerable<EmployeeModel> GetEmployees();

        // READ WRT ID
        EmployeeModel GetEmployee(int id);

        //UPDATE
        void UpdateEmployee(EmployeeModel employee);

        //DELETE
        bool DeleteEmployee(int id);
    }
}
