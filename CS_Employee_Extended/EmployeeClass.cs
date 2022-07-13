using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Employee_Extended
{
    public class Employee
    {
        private int _EmpNo;
        private string _EmpName;
        private decimal _Salary;
        private string _DeptName;

        public Employee(int empNo, string empName, decimal salary, string deptName)
        {
            _EmpNo = empNo;
            _EmpName = empName;
            _Salary = salary;
            _DeptName = deptName;

        }

        public decimal CalculateSalary()
        {
            return _Salary;
        }

        public decimal Tax(decimal grossS)
        {
            decimal tax = 0;
            
            if (grossS < 100000)
            {
                tax = 0;
            }
            else if (grossS >= 100000 && grossS < 500000)
            {
                tax = grossS * (decimal)(0.2);
            }
            else if (grossS >= 500000 && grossS < 1000000)
            {
                tax = grossS * (decimal)(0.3);
            }
            else
            {
                tax = grossS * (decimal)(0.4);
            }
            return tax;
        }

        public string decimalSalaryInwords(decimal netSal)
        {
            int netS = Decimal.ToInt32(netSal);
            Dictionary<int , string> dict= new Dictionary<int , string>();
            dict.Add(0, "zero"); dict.Add(1, "one"); dict.Add(2, "two"); dict.Add(3, "three");
            dict.Add(4, "four"); dict.Add(5, "five"); dict.Add(6, "six"); dict.Add(7, "seven"); dict.Add(8, "eight");
            dict.Add(9, "nine");
            string str = String.Empty;
            while (netS>0)
            {
                int ld = netS % 10;
                str += dict[ld];
                str += netS / 10 != 0 ? " " : null;
                netS /= 10;
            }
            string[] words = str.Split(' ');
            string netSstring = String.Empty;
            for (int i = words.Length-1; i>=0;i--)
            {
                netSstring += words[i] + " ";
            }
            return netSstring;

        }

        public virtual decimal GetSalary()
        {
            Console.Write("Salary calculation");
            return 0;
        }

    }

    
    public class Manager : Employee
    {
        decimal travelAllowance;
        decimal projectAllowance;
        public Manager(int eno, string ename, decimal sal, string dname, decimal travelAllowance, decimal projectAllowance) : base(eno, ename, sal, dname)
        {
            this.travelAllowance = travelAllowance;
            this.projectAllowance = projectAllowance;
        }
        public override decimal GetSalary()
        {
           return CalculateSalary() + travelAllowance + projectAllowance;
        }
    }

    public class SalesManager : Manager
    {
        decimal customerAllowance = 0;
        decimal travelAllowance = 0;
        decimal hotelAllowance = 0;

        public SalesManager(int eno, string ename, decimal sal, string dname, decimal travelAllowance,
            decimal projectAllowance ,decimal customerAllowance, decimal hotelAllowance)
            : base(eno, ename, sal, dname, travelAllowance, projectAllowance)
        {
            this.customerAllowance = customerAllowance;
            this.hotelAllowance = hotelAllowance;
            this.travelAllowance = travelAllowance;
        }
        public override decimal GetSalary()
        {
            return base.GetSalary() + this.customerAllowance + this.hotelAllowance;
        }
    }

    public class Engineer : Employee
    {
        decimal OverTime;
        decimal OverTimeHours;
        public Engineer(int eno, string ename, decimal sal, string dname, decimal overT, decimal overTHrs)
            : base(eno, ename, sal, dname)
        {
            OverTime = overT;
            OverTimeHours = overTHrs;
        }
        public override decimal GetSalary()
        {
            return CalculateSalary() + 300* (OverTime+OverTimeHours);  //own formula
        }
    }

    public class Gateway
    {
        public void GrossSalary(Employee emp)
        {
            decimal grossS = emp.GetSalary(), netS=0;
            Console.WriteLine($"Gross salary is {emp.GetSalary()}");
            Console.WriteLine($"Tax for employee is {emp.Tax(grossS)}");
            Console.WriteLine($"Net salary for employee is {netS= emp.GetSalary() - emp.Tax(grossS)}");
            Console.WriteLine($"Net salary for employee in words is {emp.decimalSalaryInwords(netS)}");
        }
    }
    
    
}
