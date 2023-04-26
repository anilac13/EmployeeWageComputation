using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeCheck
    {
        public static void CheckAttendance()
        {
            int WAGE_PER_HOUR = 20;
            int IS_FULL_TIME = 1;
            int empHour = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(3);
            if (empCheck == IS_FULL_TIME)
            {
                empHour = 8;
            }
            else
            {
                empHour = 0;
            }
            empWage = empHour * WAGE_PER_HOUR;
            Console.WriteLine("Employee Wage is: {0}", empWage);
        }
    }
}
