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
        public const int MaxHoursInmonth = 10;

        static void Main(string[] args)
        {

            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            //computation
            while(totalEmpHrs <= MaxHoursInmonth && totalWorkingDays <NumberOfWorkingDays )
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:" + totalWorkingDays + " EmpHrs :" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EmpRatePerHour;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);

        }
    }

}