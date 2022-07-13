using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Employee.Models;
using CS_Employee.Logic;

//Task (2-a)
namespace CS_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Employee e1 = new Employee();
            e1.EmpNo = 1;
            e1.EmpName = "name1";
            e1.DeptName = "d1";
            e1.BasicSalary = 10000;
            Employee e2 = new Employee();
            e2.EmpNo = 2;
            e2.EmpName = "name2";
            e2.DeptName = "d2";
            e2.BasicSalary = 20000;
            Employee e3 = new Employee();
            e3.EmpNo = 3;
            e3.EmpName = "name3";
            e3.DeptName = "d3";
            e3.BasicSalary = 30000;
            EmployeeLogic employeeLogic = new EmployeeLogic();
            employeeLogic.AddEmployee(e1);
            employeeLogic.AddEmployee(e2);
            employeeLogic.AddEmployee(e3);

            Console.WriteLine("Displaying ALl employees after adding");
            employeeLogic.showAll();

            Console.ReadLine();
            Console.WriteLine("Updating name");
            employeeLogic.UpdateEmployee(2, "name 2 updated");
            employeeLogic.showAll();

            Console.ReadLine();
            Console.WriteLine("Delete emp with ID 2");
            employeeLogic.DeleteEmployee(2);
            employeeLogic.showAll();

            Console.ReadLine();
            Console.WriteLine("Search Emp with name 'name1'");
            List<Employee> e = employeeLogic.SearchEmployee("d1");
            foreach(Employee eItem in e)
            {
                Console.WriteLine($"ENo is {eItem.EmpNo} and Ename is {eItem.EmpName}");
            } 
            

            



        }
    }
}
