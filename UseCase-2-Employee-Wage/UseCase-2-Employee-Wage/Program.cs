using System;

namespace CalculateDailyWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constants
            int is_Present = 1;
            int emp_Rate_Per_Hr = 20;

            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == is_Present)
            {
                empHrs = 8;


            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * emp_Rate_Per_Hr;
            Console.WriteLine("Emp Wage =" + empWage);
        }
    }
}
