using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Employee.Models;


namespace CS_Employee.Logic
{
    public class EmployeeLogic
    {
        List<Employee> employees = new List<Employee>();

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public List<Employee> AddEmployee(Employee employee)
        {
            employees.Add(employee);
            return employees;
        }

        public void UpdateEmployee(int empno, string empName) //updating name here
        {
            foreach (Employee emp in employees)
            {
                if(emp.EmpNo == empno)
                {
                    emp.EmpName = empName;
                    break;
                }
            }
        }

        public void DeleteEmployee(int empno)
        {
            for(int i=0;i<employees.Count; i++)
            {
                if (employees[i].EmpNo== empno)
                {
                    employees.RemoveAt(i);
                }
            }
        }

        public List<Employee> SearchEmployee(string dname)
        {
            List<Employee> result = new List<Employee>();
            foreach(Employee emp in employees)
            {
                if(emp.DeptName== dname)
                {
                    result.Add(emp);
                }
            }
            return result;
        }

        public void showAll()
        {
            foreach(Employee emp in employees)
            {
                Console.WriteLine($"EmpId- {emp.EmpNo} AND Emp Name- {emp.EmpName}");
            }
        }

    }
}
