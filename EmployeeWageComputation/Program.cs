using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmployeeOperation employee = new EmployeeOperation();
            employee.Operation();
        }
    }
}