using System;

namespace UseCase_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Constants
            int is_FullTime = 1;
            int is_PartTime = 2;
            int emp_Rate_Per_Hr = 20;
            int no_of_Working_Days = 20;

            //Variables
            int empHrs = 0;
            int empWage_per_day = 0;
            int empWage_per_Month = 0;
            Random random = new Random();

            //Computation

            int empCheck = random.Next(0, 3);
            if (empCheck == is_FullTime)
            {
                empHrs = 8;

            }
            else if (empCheck == is_PartTime)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage_per_day = empHrs * emp_Rate_Per_Hr;
            Console.WriteLine("Wage Per Day=" + empWage_per_day);
            empWage_per_Month = empWage_per_day * no_of_Working_Days;
            Console.WriteLine("Wage PEr Month=" + empWage_per_Month);
        }
    }
}
