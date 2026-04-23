using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Parabula
    {
        private double a;
        private double b;
        private double c;

        public Parabula(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Parabula(double p, double k)
        {
            this.a = 1;
            this.b = -2 * p;
            this.c = p * p + k;
        }

        public Point Yintercept()
        {
            return new Point(0, this.c);
        }

        public Point[] Xintercept()
        {
            double delta = this.b * this.b - 4 * this.a * this.c;

            if (delta == 0)
            {

                Point x1 = new Point(-this.b / 2 * this.a, 0);

                return new Point[] { x1 };

            }

            if (delta > 0)
            {
                Point X1interecpts = new Point(-this.b / 2 * this.a, 0);
                Point X2intercepts = new Point(this.b / 2 * this.a, 0);

                return new Point[] { X1interecpts, X2intercepts };
            }

            else
            {
                return null;
            }

        }

        public double GetY(double x)
        {
            return this.a * (x * x) + this.b * x + this.c;
        }

        public bool IsOnParbula(Point p)
        {
            return this.a * (p.GetX() * p.GetX()) + this.b * p.GetX() + this.c == p.GetY();
        }

        public Point Extreme()
        {
            double x = -this.b / (2 * this.a);
            double y = this.a * (x * x) + this.b * x + this.c;

            return new Point(x, y);
        }

        public Line Tangent(double x)
        {
            double incline = 2 * this.a * x + this.b;
            Point p = new Point(x, this.GetY(x));
            return new Line(incline, p.GetY() - incline * x);
        }

        public Point[] InterceptLine(Line ln)
        {
            double n = ln.GetM();
            double m = ln.GetB();

            Parabula p = new Parabula(this.a, this.b - m, this.c - n);
            Point[] prr = p.Xintercept();

            for (int i = 0; i == 2; i++)
            {
                if (prr != null)
                    prr[i].SetY(this.GetY(prr[i].GetX()));
            }

            return prr;
        }

        public Line PerpendicularFromPoint(Point p, double Xcord)
        {
            Line tangent = this.Tangent(Xcord);
            return tangent.Perpendicular(p);
        }

        public Point[] InterceptParabola(Parabula par)
        {
            Parabula pa = new Parabula(this.a - par.a, this.b - par.b, this.c - par.c);
            Point[] prr = pa.Xintercept();
            if (prr[0] == null && prr[1] == null)
            {
                return new Point[] { null, null };
            }
            else if (prr[1] == null)
            {
                prr[0].SetY(par.GetY(prr[0].GetX()));
                return prr;
            }
            else
            {
                prr[0].SetY(par.GetY(prr[0].GetX()));
                prr[1].SetY(par.GetY(prr[1].GetX()));
                return prr;
            }
        }

        public double ExtremeArea()
        {
            Point[] roots = this.Xintercept();

            if (roots == null || roots.Length < 2 || roots[0] == null || roots[1] == null)
                return 0;

            Point p1 = roots[0];
            Point p2 = roots[1];

            Point vertex = this.Extreme();

            return Math.Abs(p1.GetX() * (p2.GetY() - vertex.GetY()) + p2.GetX() * (vertex.GetY() - p1.GetY()) + vertex.GetX() * (p1.GetY() - p2.GetY())) / 2;

        }

        public double ExtremeArea(Line ln)
        {
            Point[] p = this.InterceptLine(ln);
            Point extreme = this.Extreme();

            double a = p[0].Distance(extreme);
            double b = p[1].Distance(extreme);
            double c = p[0].Distance(p[1]);

            double s = (a + b + c) / 2;

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }


        public override string ToString()
        {
            if (this.b < 0 && this.c > 0)
            {
                return $"{this.a}x^2 {this.b}x + {this.c}";
            }

            if (this.b < 0 && this.c < 0)
            {
                return $"{this.a}x^2 {this.b}x {this.c}";
            }

            if (this.b > 0 && this.c < 0)
            {
                return $"{this.a}x^2 + {this.b}x {this.c}";
            }

            else
            {
                return $"{this.a}x^2 + {this.b}x + {this.c}";
            }
        }

        public static void UnitTests()
        {
            Parabula p1 = new Parabula(5, 8);
            Console.WriteLine(p1);
            Parabula p2 = new Parabula(0, 0);
            Console.WriteLine(p2);
            Parabula p3 = new Parabula(-2, 7, -5);
            Console.WriteLine(p3);
            Parabula p4 = new Parabula(1, 0, 9);
            Console.WriteLine(p4);

            Console.WriteLine("=========Y INTERCEPT==========");

            Point Yinterecepts = p1.Yintercept();
            Console.WriteLine(Yinterecepts);
            Point Yinterecepts2 = p2.Yintercept();
            Console.WriteLine(Yinterecepts2);
            Point Yinterecepts3 = p3.Yintercept();
            Console.WriteLine(Yinterecepts3);

            Console.WriteLine("=========X INTERCEPT==========");

            Point[] Xinterecepts = p1.Xintercept();
            Console.WriteLine(PrintArray.PrintArrays(Xinterecepts));
            Point[] Xinterecepts2 = p2.Xintercept();
            if (Xinterecepts2 == null)
            {
                Console.WriteLine("null");
            }
            else
                Console.WriteLine(Xinterecepts2);
            Point[] Xinterecepts3 = p4.Xintercept();
            Console.WriteLine(PrintArray.PrintArrays(Xinterecepts3));

            Console.WriteLine("===========Get Y=============");

            Console.WriteLine("new y1 = " + p1.GetY(4));
            Console.WriteLine("new y2 = " + p2.GetY(8));
            Console.WriteLine("new y = " + p3.GetY(-6));
            Console.WriteLine("new y = " + p1.GetY(-13));

            Console.WriteLine("=========Is On Parabule=========");

            Point po1 = new Point(4, 9);
            Point po2 = new Point(2, -68);
            Point po3 = new Point(22, 56);
            Point po4 = new Point(0, 9);
            Console.WriteLine(p1.IsOnParbula(po1));
            Console.WriteLine(p2.IsOnParbula(po2));
            Console.WriteLine(p3.IsOnParbula(po3));
            Console.WriteLine(p4.IsOnParbula(po4));

            Console.WriteLine("========Extreme=========");

            Console.WriteLine(p1.Extreme());
            Console.WriteLine(p2.Extreme());
            Console.WriteLine(p3.Extreme());
            Console.WriteLine(p4.Extreme());

            Console.WriteLine("=======Tangent===========");
            Console.WriteLine(p1.Tangent(-1));
            Console.WriteLine(p2.Tangent(7));
            Console.WriteLine(p3.Tangent(5));
            Console.WriteLine(p4.Tangent(2));

            Console.WriteLine("=======InterceptLine======");

            Line l1 = new Line(2, 3);
            Line l2 = new Line(6, 8);
            Line l3 = new Line(70000, 50000);
            Line l4 = new Line(-8, -19);
            Console.WriteLine(PrintArray.PrintArrays(p1.InterceptLine(l1)));
            Console.WriteLine(PrintArray.PrintArrays(p2.InterceptLine(l2)));
            Console.WriteLine(PrintArray.PrintArrays(p3.InterceptLine(l3)));
            Console.WriteLine(PrintArray.PrintArrays(p4.InterceptLine(l4)));

            Console.WriteLine("========PerpendicularFromPoint=======");

            Line l5 = p1.PerpendicularFromPoint(po1, 3);
            Line l6 = p2.PerpendicularFromPoint(po2, -6);
            Line l7 = p3.PerpendicularFromPoint(po3, 8);
            Line l8 = p4.PerpendicularFromPoint(po4, -17);
            Console.WriteLine(l5);
            Console.WriteLine(l6);
            Console.WriteLine(l7);
            Console.WriteLine(l8);

            Console.WriteLine("========InterceptParabula==========");

            Console.WriteLine(p1.InterceptParabola(p2));
            Console.WriteLine(p2.InterceptParabola(p3));
            Console.WriteLine(p3.InterceptParabola(p4));


            Console.WriteLine("========ExtremeArea=======");

            Console.WriteLine(p1.ExtremeArea());
            Console.WriteLine(p2.ExtremeArea());
            Console.WriteLine(p3.ExtremeArea());
            Console.WriteLine(p4.ExtremeArea());

            Console.WriteLine("=======ExtremeArea(ln)=======");

            Console.WriteLine(p1.ExtremeArea(l1));
            Console.WriteLine(p1.ExtremeArea(l2));
            Console.WriteLine(p1.ExtremeArea(l3));
            Console.WriteLine(p1.ExtremeArea(l4));
        }



    }
}
