using System;

namespace EmpWageProbblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int IsFullTime = 1;

            //variables
            Random random = new Random();

            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IsFullTime)
            {
                Console.WriteLine("Employee is Present ");
            }
            else
            {
                Console.WriteLine("Employee is Absent ");
            }



        }
    }
}