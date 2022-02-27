using System;

namespace UseCase_1_LineComparision
{
    public class Program
    {  
        //variables
        double length_Of_Line;
       
        //method for calculation
        public void Calc(double x1,double y1,double x2,double y2)
        {
            double X=Math.Pow(x2 - x1, 2.0);
            double Y = Math.Pow(y2 - y1, 2.0);
            length_Of_Line=Math.Sqrt(X+Y);
        }
        public static void Main(String[] args)
        {   
            Program p=new Program();
            Console.WriteLine("enter x1,y1,x2,y2 values\n");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            p.Calc(a, b, c, d);
            Console.WriteLine("Line Length is = " + p.length_Of_Line);
        }

    }
}


