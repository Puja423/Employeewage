using System;

namespace employeewage
{
    class Program
    {
        public class EmpWageBuilder
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;
            private string company;
            private int empRatePerHour;
            private int numOfWorkingDays;
            private int maxHoursPerMonth;
            private int totalEmpWage;

            public EmpWageBuilder(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth, int totalEmpWage)
            {
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMonth;
                this.totalEmpWage = totalEmpWage;

            }
            public void computeWage()
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
                totalEmpWage = totalEmpHrs * this.empRatePerHour;
                Console.WriteLine("total empWage for Ccompany:" + company + "is:" + totalEmpWage);
            }
            public string toString()
            {
                return ("total empWage for Ccompany:" + company + "is:" + totalEmpWage);
            }
            class program1
            {
                static void Main(string[] args)
                {
                    EmpWageBuilder dMART = new EmpWageBuilder("DMART", 10, 20, 30, 5);
                    EmpWageBuilder reliance = new EmpWageBuilder("Reliance", 20, 10, 15, 1);
                    dMART.computeWage();
                    Console.WriteLine(dMART.ToString());
                    reliance.computeWage();
                    Console.WriteLine(reliance.ToString());
                }


            }
        }
    }
}