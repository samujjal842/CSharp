using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOPAssignment
{
    public class Employee_details
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public double HRA;
        public double TA;
        public double DA { get; set; }
        public double PF { get; set; }
        public double TDS { get; set; }
        public double NetSalary = 0;
        public double GrossSalary = 0;

        public Employee_details(int emp_No, string emp_Name, double salary)
        {
            EmpNo = emp_No;
            EmpName = emp_Name;
            Salary = salary;

        }
        public void SalaryComponents()
        {
            if (Salary < 5000)
            {

                HRA = 0.1 * Salary;
                TA = 0.05 * Salary;
                DA = 0.15 * Salary;
            }
            else if (Salary < 10000)
            {

                HRA = 0.15 * Salary;
                TA = 0.1 * Salary;
                DA = 0.2 * Salary;
            }
            else if (Salary < 15000)
            {

                HRA = 0.2 * Salary;
                TA = 0.15 * Salary;
                DA = 0.25 * Salary;
            }
            else if (Salary < 20000)
            {

                HRA = 0.25 * Salary;
                TA = 0.2 * Salary;
                DA = 0.30 * Salary;
            }
            else if (Salary >= 20000)
            {

                HRA = 0.3 * Salary;
                TA = 0.25 * Salary;
                DA = 0.35 * Salary;
            }

            GrossSalary = Salary + HRA + TA + DA;

        }
        public void CalculateSalary()
        {
            PF = 0.1 * GrossSalary;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF + TDS);
            Console.WriteLine("Net Salary : {0}", NetSalary);
        }

        class Employee
        {
            public static void Main()
            {
                Console.WriteLine("Enter employee no. :");
                int EmpNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter employee name :");
                string EmpName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter employee salary :");
                double Salary = Convert.ToInt32(Console.ReadLine());
                Employee_details e = new Employee_details(EmpNo, EmpName, Salary);
                e.SalaryComponents();
                e.CalculateSalary();

            }
        }

    }
}

