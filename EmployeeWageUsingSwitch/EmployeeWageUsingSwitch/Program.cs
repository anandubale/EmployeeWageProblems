using System;

namespace EmpWageUsingSwitch
{
    /*switch(expression) 
    {
      case x:
        // code block
        break;
      case y:
        // code block
        break;
      default:
        // code block
        break;
    }
     
     */
    class Program
    {
        static void Main(string[] args)
        {

            //constant
            int EmpRatePerHour = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //computation
            int empCheck = random.Next(1, 4);
            switch (empCheck)
            {
                case 1:

                    empHrs = 8;
                    empWage = empHrs * EmpRatePerHour;
                    Console.WriteLine("Employee full Time Wage is " + empWage);
                    break;

                case 2:

                    empHrs = 4;
                    empWage = empHrs * EmpRatePerHour;
                    Console.WriteLine("Employee Half Time Wage is " + empWage);
                    break;
                default:

                    empHrs = 0;
                    Console.WriteLine("Emplyee is Absent");
                    break;

            }
        }

    }
}