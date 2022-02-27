using System;

namespace UseCase_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Constants
            int is_FullTime = 1;
            int is_PartTime = 2;
            int emp_Rate_Per_Hr = 20;
            int total_Working_Hrs = 99;
            int total_Work_Days_In_Month = 20;


            //Variables
            int empHrs = 0;
            int empTotalWage = 0;
            int total_Worked_DAys = 0;
            int total_Worked_Hrs = 0;

            //Computation
            while (total_Worked_DAys <= total_Work_Days_In_Month || total_Worked_Hrs <= total_Working_Hrs)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                total_Worked_DAys++;
                total_Worked_Hrs++;
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

            }
            total_Worked_Hrs = total_Worked_Hrs + empHrs;
            Console.WriteLine("Total Worked Hr =" + total_Worked_Hrs);
            empTotalWage = total_Worked_Hrs * emp_Rate_Per_Hr;
            Console.WriteLine("emp Total Wage =" + empTotalWage);

        }
    }
}
