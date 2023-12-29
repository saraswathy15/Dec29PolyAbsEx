using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec29PolyAbsEx
{
    public abstract class Shape { public abstract void CalArea(); public void Fun1() { } }
    public class Circle : Shape
    {
        public override void CalArea()
        {
            double radius = 3.5; double area = 3.14 * radius * radius;
            Console.WriteLine("The Area of Circle is {0} ", area);
        }
    }//end of circle
    public class Square : Shape
    {
        public override void CalArea()
        {
            double side = 4.5; double area = side * side;//a2
            Console.WriteLine("The area of Square is {0}", area);
        }
    }//end of square 
    public class Rectangle : Shape
    {
        public override void CalArea()
        {
            double len, bre; len = 3.5; bre = 4.5; double area = len * bre;
            Console.WriteLine("The area of Rectangle  {0}", area);
        }// write Main () in any child class 
         //static void Main(string[] args)
         //{
         //    Shape s1, s2, s3; //s1 = new Shape();
         //    s1 = new Circle(); s1.CalArea();
         //    s2 = new Square(); s2.CalArea();
         //    s3 = new Rectangle(); s3.CalArea();

        //}
    }//end of square

    class Test
    {
        static void Main(string[] args)
        {
            Shape s1, s2, s3; //s1 = new Shape();
            s1 = new Circle(); s1.CalArea();
            s2 = new Square(); s2.CalArea();
            s3 = new Rectangle(); s3.CalArea();

        }
    }
}


