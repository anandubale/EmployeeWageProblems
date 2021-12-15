using System;

namespace EmpWageProbblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //constant
            int IsFullTime = 1;
            int EmpRatePerHr = 200;

            //variables
            int EmpHr = 0;
            int EmpWage = 0;
            Random random = new Random();

            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IsFullTime)
            {
                EmpHr = 0;

            }
            else
            {
                EmpHr = 1;
            }

            EmpWage = EmpHr * EmpRatePerHr;
            Console.WriteLine("Employee Wage is "+ EmpWage);
            //just comment to check evrything ok mic check mic check

        }
    }
}