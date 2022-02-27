using System;

namespace UseCase_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Constants
            int is_FullTime = 1;
            int is_PartTime = 2;
            int emp_Rate_Per_Hr = 20;

            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //Computation
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case 1:
                    empHrs = 8;
                    break;
                case 2:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * emp_Rate_Per_Hr;
            Console.WriteLine("Emp Wage =" + empWage);
        }
    }
}

