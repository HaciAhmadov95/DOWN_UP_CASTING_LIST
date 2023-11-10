using Service.Service;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_HomeTask.Controller
{
    internal class EmployeeController
    {
        private readonly IEmployeeService _service;

        public EmployeeController()
        {
            _service = new EmployeeService();
        }
        public void GetBySalaryAndBirtday()
        {
            
            var datas = _service.GetAllEmployees();
            DateTime startdate = new DateTime(2000, 01, 01);
            DateTime enddate = new DateTime(2022, 02, 02);

            int count = 0;  
            foreach (var data in datas)
            {
                if(data.Salary > 2000 && data.Birthday > startdate && data.Birthday < enddate)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
