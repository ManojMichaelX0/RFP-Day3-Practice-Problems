using System;

namespace UseCase_1_LineComparision
{
    public class Program
    {   //variables
        double length_Of_Line;

        //method for calculation
        public void Calc(double x1, double y1, double x2, double y2)
        {
            double X = Math.Pow(x2 - x1, 2.0);
            double Y = Math.Pow(y2 - y1, 2.0);
            length_Of_Line = Math.Sqrt(X + Y);
        }
        public static void Main(String[] args)
        {   //line 1 object creating and reading input from user
            Program p1 = new Program();
            Console.WriteLine("enter x1,y1,x2,y2 values\n");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            p1.Calc(a, b, c, d);
            Console.WriteLine("Line Length is = " + p1.length_Of_Line);
            
            //line 2 object creating and reading input from user
            Console.WriteLine("Enter Sencond line values x1,y1,x2,y2\n");
            double e = Convert.ToDouble(Console.ReadLine());
            double f = Convert.ToDouble(Console.ReadLine());
            double g = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            Program p2 = new Program();
            p2.Calc(e, f, g, h);
            Console.WriteLine("Line 2 Length is = " + p2.length_Of_Line);
            //compairing by both line values using Equals method
            Console.WriteLine("Checking lines are equal the answer is");
            Console.WriteLine((p1.length_Of_Line).Equals(p2.length_Of_Line));
        }

    }
}


