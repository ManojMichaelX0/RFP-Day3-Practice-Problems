using System;

namespace UseCase1_Employee_Wage_Calculation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            //Constants
            int Is_Full_Time = 1;
            Random random = new Random();
            //Computation
            int empcheck = random.Next(0, 2);
            if (empcheck == Is_Full_Time)
            {
                Console.WriteLine("employee is Present");
            }
            else
            {
                Console.WriteLine("employee is Absent");
            }
        }
    }
}
