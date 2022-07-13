using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Employee_Extended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gateway gateway = new Gateway();

            Console.WriteLine("Using Inheritence");
            Manager manager = new Manager(1, "Harsh", 100050, "Pro Dev", 1500, 2000);
            Console.WriteLine($"Salary for Manager = {manager.GetSalary()}");
            Console.WriteLine("Gateway operation to calculate gross salary as per designation");
            gateway.GrossSalary(manager);
       


            Console.ReadLine();
            Engineer engineer = new Engineer(2, "I am engineer ", 576456, "Eng Dept", 3, 4);
            Console.WriteLine($"Salary for Engineer = {engineer.GetSalary()}");
            Console.WriteLine("Gateway operation to calculate gross salary as per designation");
            gateway.GrossSalary(engineer);

            Console.ReadLine();
            SalesManager salesManager = new SalesManager(3, "I am sales manager", 1054000, "sales Dept", 1000, 2000, 2000,1000);
            Console.WriteLine($"Salarr for Sales Manager = {salesManager.GetSalary()}");
            Console.WriteLine("Gateway operation to calculate gross salary as per designation");
            gateway.GrossSalary(salesManager);

            Console.ReadLine();
            
        


            
        }
    }
}
