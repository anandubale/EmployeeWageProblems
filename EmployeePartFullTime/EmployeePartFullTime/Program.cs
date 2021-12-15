using System;

namespace EmpWageHalfFull
{

    class Program
    {
        static void Main(string[] args)
        {
            int FullTime = 0;
            int HalfTime = 1;
            int EmpRatePerHour = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //computation
            int empCheck = random.Next(0, 3);
            if (empCheck == FullTime)
            {
                empHrs = 8;
                empWage = empHrs * EmpRatePerHour;
                Console.WriteLine("Employee full Time Wage is " + empWage);

            }
            else if (empCheck == HalfTime)
            {
                empHrs = 4;
                empWage = empHrs * EmpRatePerHour;
                Console.WriteLine("Employee Half Time Wage is " + empWage);
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Emplyee is Absent");

            }


        }
    }
}