using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Employee.Logic;

namespace CS_Employee.Models
{
    public class Employee:EmployeeLogic
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public decimal BasicSalary { get; set; }
    }
}
