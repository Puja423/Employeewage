using System;

namespace EmployeesWageProgram
{
    class Program
    {




        static void Main(string[] args)
        {
            Console.WriteLine("################# Welcome to Employee Wage System ###########");

            var wageBuilder = new EmployeeWageBuilder();
            wageBuilder.AddWageDetails("Walmart", 20, 21, 120);
            wageBuilder.AddWageDetails("Dtech", 25, 27, 150);
            wageBuilder.ComputeWageForAll();

        }

    }
}