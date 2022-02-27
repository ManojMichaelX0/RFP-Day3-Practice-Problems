using System;

namespace UseCase_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Constants
            int is_PartTime = 1;
            int is_FullTime = 2;
            int emp_Rate_Per_Hr = 20;

            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            //Computation
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
            empWage = empHrs * emp_Rate_Per_Hr;
            Console.WriteLine(" wage= " + empWage);
        }
    }
}
