using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            //EmployeeOperation employee = new EmployeeOperation();
            //employee.Operation();

            EmpWageBuilderArray empWage = new EmpWageBuilderArray();
            empWage.AddCompanyEmpWage("Infosys", 20, 4, 15);
            empWage.AddCompanyEmpWage("TCS", 30, 2, 10);
            empWage.AddCompanyEmpWage("CapGemini", 25, 3, 20);
            empWage.AddCompanyEmpWage("Bosch", 15, 2, 10);
            empWage.AddCompanyEmpWage("Virtusa", 40, 4, 20);
            empWage.ComputeEmpWage();
        }
    }
}