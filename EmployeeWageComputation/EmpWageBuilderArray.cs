using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 2, IS_FULL_TIME = 1;
        private int numOfCompany = 0;
        private CompanyEmployeeWage[] companyEmpWageArray;
        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmployeeWage[5];
        }
        public void AddCompanyEmpWage(string company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmployeeWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].SetTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].ToString());
            }
        }
        public int ComputeEmpWage(CompanyEmployeeWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs<=companyEmpWage.maxHoursPerMonth && totalWorkingDays<companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day " + totalWorkingDays + " Emp Hrs: " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }
}