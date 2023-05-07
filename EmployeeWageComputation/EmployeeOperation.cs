using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeOperation
    {
        public const int IS_FULL_TIME = 1, WAGE_PER_HOUR = 20, IS_PART_TIME = 2, WORKING_DAYS = 20, TOTAL_WORKING_HRS = 100;
        public void Operation()
        {
            int empHour = 0;
            int totalEmpHrs = 0, totalWorkingDays = 0;
            while(totalEmpHrs < TOTAL_WORKING_HRS && totalWorkingDays < WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(3);
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
                totalEmpHrs += empHour;
                Console.WriteLine("Day " + totalWorkingDays + "===> EmpHrs: " + empHour);
            }
            Console.WriteLine("Total working Hours: " + totalEmpHrs);
            Console.WriteLine("Total working days: " + totalWorkingDays);
            int totalEmpWage = totalEmpHrs * WORKING_DAYS;
            Console.WriteLine("Employee wage is: {0}", totalEmpWage);
        }
    }
}