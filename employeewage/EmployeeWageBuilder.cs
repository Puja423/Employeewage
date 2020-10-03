using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesWageProgram
{
    class EmployeeWageBuilder
    {
        public const int IS_Part_Time = 1;
        public const int IS_Full_Time = 2;

        private int _numberOfCompanies = 0;
        public CompanyEmployeeWage[] companyWageArray;


        public EmployeeWageBuilder()
        {
            this.companyWageArray = new CompanyEmployeeWage[5];
        }

        public void AddWageDetails(string companyName, int wagePerHour, int workingDays, int maxHoursPerMonth)
        {
            this.companyWageArray[_numberOfCompanies] = new CompanyEmployeeWage(companyName, wagePerHour, workingDays, maxHoursPerMonth);
            _numberOfCompanies++;
        }

        public void ComputeWageForAll()
        {
            for (int i = 0; i < _numberOfCompanies; i++)
            {
                CalculateMonthlyWage(companyWageArray[i]);
                Console.WriteLine(companyWageArray[i].ToString());
            }
        }
        public void CalculateMonthlyWage(CompanyEmployeeWage companyEmployeeWage)
        {


            var wageHour = 0;
            var totalHours = 0;
            var totalWorkingDays = 0;
            var totalEmployeeWage = 0;
            while (totalHours <= companyEmployeeWage.maxHoursPerMonth && totalWorkingDays <= companyEmployeeWage.workingDays)
            {
                totalWorkingDays++;
                var empCheck = new Random().Next(0, 3);
                switch (empCheck)
                {
                    case IS_Part_Time:
                        wageHour = 4;
                        break;
                    case IS_Full_Time:
                        wageHour = 8;
                        break;
                    default:
                        wageHour = 0;
                        break;
                }
                totalHours += wageHour;
            }
            totalEmployeeWage = totalHours * companyEmployeeWage.wagePerHour;
            companyEmployeeWage.totalEmployeeWage = totalEmployeeWage;
            //Console.WriteLine("Total Employee Wage for " + companyEmployeeWage.companyName + " is " + totalEmployeeWage);
        }




    }
}