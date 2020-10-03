using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesWageProgram
{
    class CompanyEmployeeWage
    {
        public string companyName;
        public int wagePerHour;
        public int workingDays;
        public int maxHoursPerMonth;
        public List<int> DailyWage;
        public int totalEmployeeWage;

        public CompanyEmployeeWage(string companyName, int wagePerHour, int workingDays, int maxHoursPerMonth)
        {
            this.companyName = companyName;
            this.wagePerHour = wagePerHour;
            this.workingDays = workingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.DailyWage = new List<int>();
        }
        public override string ToString()
        {
            return "Total Employee Wage for " + companyName + " is " + totalEmployeeWage;
        }
    }
}
