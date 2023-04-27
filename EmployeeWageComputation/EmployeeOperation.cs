using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeOperation
    {
        public const int IS_FULL_TIME = 1, WAGE_PER_HOUR = 20, IS_PART_TIME = 2, WORKING_DAYS = 20;
        public static void Operation()
        {
            int empHour = 0;
            int empWage = 0, totalEmpWage = 0;
            Random random = new Random();
            int empCheck = random.Next(3);
            for (int day=1; day<=WORKING_DAYS; day++)
            {
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHour = 8;
                        break;
                    case IS_PART_TIME:
                        empHour = 4;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                empWage = empHour * WAGE_PER_HOUR;
                Console.WriteLine("Employee Wage is: {0}", empWage);
                totalEmpWage += empWage;
            }
            Console.WriteLine("Employee wage for month: {0}", totalEmpWage);
        }
    }
}
