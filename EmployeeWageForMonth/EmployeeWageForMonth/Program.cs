using System;

namespace EmployeeWageForMonth
{
    class Program
    {
        //constant
        public const int EmpRatePerHour = 20;
        public const int FullTime = 1;
        public const int HalfTIme = 2;
        public const int NumberOfWorkingDays = 2;

        static void Main(string[] args)
        {
            
            //variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            //computation
            for (int day = 0; day < NumberOfWorkingDays; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(1, 4);
                switch (empCheck)
                {
                    case FullTime:

                        empHrs = 8;
                        break;

                    case HalfTIme:

                        empHrs = 4;
                        break;
                    default:

                        empHrs = 0;
                        break;

                }
                empWage = empHrs * EmpRatePerHour;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage : " + empWage);
            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);

        }
    }

}
