using Domain.Models;
using Service.Data;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class EmployeeService : IEmployeeService
    {
      

        public List<Employee> GetAllEmployees()
        {
            return AppDbContext.Employees();
        }

        public List<Employee> GetBySalaryAndBirthday(double salary, DateTime startDate, DateTime endDate)
        {
            return AppDbContext.Employees().Where(m => m.Birthday > startDate && m.Birthday < endDate && m.Salary == salary).ToList();
        }
    }
}
