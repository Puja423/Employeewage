using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace employeewage
{
    class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private int numOfCompany;
        private CompanyEmpwage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpwage[5];
        }
        public void addCompanyEmpWage(string company,int empRatePerHour,int numOfwWorkingDays,int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new companyEmpwage(company, empRatePerHour, maxHoursPerMonth, numOfwWorkingDays);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].Tostring[i]);
            }
        }
        private int  computeEmpWage(CompanyEmpWage companyEmpWage)
        {

            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:" + totalWorkingDays + "empHrs:" + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
    }
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder= new EmpWageBuilderaArray()
            EmpWageBuilderArray.addCompanyEmpWage("dMART", 20, 10, 15);
            EmpWageBuilderArray.addCompanyEmpWage("Reliance", 20, 10, 15);
            EmpWageBuilderArray empWageBuilder();
        }
    }
