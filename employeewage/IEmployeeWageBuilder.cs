using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesWageProgram
{
    class Program
    {




        static void Main(string[] args)
        {
            Console.WriteLine("################# Welcome to Employee Wage System ###########");
            Console.Write("Enter the company name to display the total wage : ");
            var name = Console.ReadLine();
            var wageBuilder = new EmployeeWageBuilder();
            wageBuilder.AddWageDetails("Walmart", 20, 21, 120);
            wageBuilder.AddWageDetails("Dtech", 25, 27, 150);
            wageBuilder.ComputeWageForAll();
            if (wageBuilder.companyWageMap.ContainsKey(name))
                Console.WriteLine("Wage for {0} is {1}", name, wageBuilder.companyWageMap[name]);
            else
                Console.WriteLine("No Record(s) found.");

        }

    }
}
