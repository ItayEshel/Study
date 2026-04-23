using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Point
    {
        private double x;
        private double y;
       public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point() : this(0, 0)
        {

        }
        public double GetX()
        {
            return this.x;
        }
        public void SetX(double x)
        {
            this.x = x;
        }
        public double GetY()
        {
            return this.y;
        }
        public void SetY(double y)
        {
            this.y = y;
        }


        public double Distance(Point p)
        {
            return Math.Sqrt(Math.Pow(this.x - p.x,2) + Math.Pow(this.y - p.y,2));
        }

        public Point Middle(Point p)
        {
            return new Point((this.x + p.x) /2, (this.y + p.y) / 2);
        }

        public double Incline(Point p)
        {
            return (this.y - p.y) / (this.x - p.x);
        }

        public override string ToString()
        {
            return ($"({this.x},{this.y})");
        }

        public static void UnitTests()
        {
            Point cords;
            cords = new Point(12, 17);
            Console.WriteLine("cords: " + cords);
            cords.SetX(3);
            cords.SetY(4);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("new x: " + cords.GetX());
            Console.WriteLine("new y: " + cords.GetY());
            Console.WriteLine("new point: " + cords);
            Console.WriteLine("--------------------------------------------------");
            Point cords2 = new Point();
            Console.WriteLine("point 2 cords: " + cords2);
            Console.WriteLine("--------------------------------------------------"); 
            Console.WriteLine("distance between the points is: " + cords2.Distance(cords));
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("midddle point is: " + cords2.Middle(cords));
        }
    }
}

