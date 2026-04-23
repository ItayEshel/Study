using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Line
    {
        private double m;
        private double b;

        public Line(double m, double b)
        {
            this.m = m;
            this.b = b;
        }
        public Line() : this(0, 0) { }

        public Line(double m, Point p)
        {
            this.m = m;
            this.b = p.GetY() - m * p.GetX();
        }

        public Line(Point p1, Point p2)
        {
            this.m = p1.Incline(p2);
            this.b = p1.GetY() - this.m * p1.GetX();
        }

        public Line(Line line) : this(line.m, line.b) { }

        public double GetM()
        {
            return this.m;
        }

        public void SetM(double m)
        {
            this.m = m;
        }

        public double GetB()
        {
            return this.b;
        }

        public void SetB(double b)
        {
            this.b = b;
        }

        public Point Yintercept()
        {
            return new Point(0, this.b);
        }

        public Point Xintercept()
        {
            if (this.m == 0)
            {
                return null;
            }

            return new Point(-this.b / this.m, 0);
        }

        public double GetY(double x)
        {
            return this.m * x + this.b;
        }

        public bool IsOnLine(Point p)
        {
            return this.m * p.GetX() + this.b == p.GetY();
        }

        public int LineStatus(Line line)
        {
            if (this.m == line.m && this.b != line.b)
                return 0;

            else if (this.m != line.m)
                return 1;

            return -1;
        }

        public Point LineIntercept(Line line)
        {
            Line line2 = new Line(this.m, this.b);
            if (line.LineStatus(line2) != 1)
            {
                return null;
            }

            double x = (double)(line.b - line2.b) / (line2.m - line.m);
            double y = line.m * x + line.b;

            return new Point(x, y);
        }

        public Line Perpendicular(Point p)
        {
            if (this.m == 0)
            {
                return null;
            }

            double mPerp = -1 / this.m;
            double bPerp = p.GetY() - mPerp * p.GetX();

            return new Line(mPerp, bPerp);
        }

        public double DistanceFromPoint(Point p)
        {
            Line perp = this.Perpendicular(p);
            if (perp == null)
                return -1;

            Point closestPoint = this.LineIntercept(perp);
            if (closestPoint == null)
                return -1;

            return p.Distance(closestPoint);
        }

        public double AreaWithX(Line line)
        {
            if (this.m == 0 || line.m == 0 || this.LineStatus(line) == -1 || this.LineStatus(line) == 0)
            {
                return 0;
            }
            Point Y = this.LineIntercept(line);
            double y = Y.GetY();

            Point X1 = line.Xintercept();
            double x1 = X1.GetX();
            Point X2 = this.Xintercept();
            double x2 = X2.GetX();

            return Math.Abs((y * (x1 - x2)) / 2);
        }

        public double[] TriangleAnglesWithX(Line line)
        {
            if (this.m == 0 || line.m == 0 || this.LineStatus(line) == -1 || this.LineStatus(line) == 0)
            {
                double[] arr0 = { 0 };
                return arr0;
            }

            Point point1 = this.LineIntercept(line);
            double x1 = point1.GetX();
            double y1 = point1.GetY();
            Point point2 = line.Xintercept();
            double x2 = point1.GetX();
            double y2 = point1.GetY();
            Point point3 = this.Xintercept();
            double x3 = point1.GetX();
            double y3 = point1.GetY();

            double tzela1 = Math.Abs(x3 - x2);
            double tzela2 = point1.Distance(point2);
            double tzela3 = point1.Distance(point3);

            double[] angles = new double[3];
            angles[0] = Math.Acos((tzela2 * tzela2 + tzela3 * tzela3 - tzela1 * tzela1) / (2 * tzela2 * tzela3));
            angles[1] = Math.Acos((tzela1 * tzela1 + tzela3 * tzela3 - tzela2 * tzela2) / (2 * tzela1 * tzela3));
            angles[2] = Math.Acos((tzela1 * tzela1 + tzela2 * tzela2 - tzela3 * tzela3) / (2 * tzela1 * tzela2));

            return angles;


        }

        public override string ToString()
        {
            if (b >= 0)
            {
                return $"f(x) = <{m}>x + {b}";
            }

            return $"f(x) = <{m}>x - {b}";
        }
        public static void UnitTests()
        {
            Line l1 = new Line(2, 3);
            Console.WriteLine(l1.GetY(2));

            Line l2 = new Line();
            Console.WriteLine(l2.GetY(5));

            Point p = new Point(2, 7);
            Line l3 = new Line(2, p);
            Console.WriteLine(l3.GetY(2));

            Point p1 = new Point(1, 3);
            Point p2 = new Point(2, 5);
            Line l4 = new Line(p1, p2);
            Console.WriteLine(l4.GetY(2));

            Point y = l1.Yintercept();
            Console.WriteLine(y.GetX() + ", " + y.GetY());

            Line l5 = new Line(2, -4);
            Point x = l5.Xintercept();
            if (x != null)
                Console.WriteLine(x.GetX() + ", " + x.GetY());

            Line l6 = new Line(0, 5);
            if (l6.Xintercept() == null)
                Console.WriteLine("there is not intercept with X");

            Line l7 = new Line(l1);
            Console.WriteLine(l7.GetY(2));

            Line l8 = new Line(2, 3);
            Line l99 = new Line(2, 5);

            Console.WriteLine(l8.LineStatus(l99));


            Line l9 = new Line(2, 3);
            Line l44 = new Line(3, 1);

            Console.WriteLine(l9.LineStatus(l44));

            Line l10 = new Line(2, 3);
            Line l66 = new Line(2, 3);

            Console.WriteLine(l10.LineStatus(l66));

            Point p4 = new Point(1, 5);
            Line l11 = new Line(2, p);

            Console.WriteLine(l10.LineStatus(l11));


            Line l88 = new Line(4, -2);
            Line l12 = new Line(4, 10);

            Console.WriteLine(l88.LineStatus(l12));


            Line l101 = new Line(-1, 0);
            Line l13 = new Line(5, 2);

            Console.WriteLine(l101.LineStatus(l13));

            Line li1 = new Line(1, 0);
            Line li2 = new Line(-1, 4);

            double[] angles1 = li1.TriangleAnglesWithX(li2);
            Console.WriteLine("Test 1:");
            Console.WriteLine(string.Join(", ", angles1));

            Line li3 = new Line(1, 0);
            Line li4 = new Line(1, 2);

            double[] angles2 = li3.TriangleAnglesWithX(li4);
            Console.WriteLine("Test 2:");
            Console.WriteLine(angles2.Length == 1 && angles2[0] == 0);

            Line li5 = new Line(0, 3);
            Line li6 = new Line(1, 0);

            double[] angles3 = li5.TriangleAnglesWithX(li6);
            Console.WriteLine("Test 3:");
            Console.WriteLine(string.Join(", ", angles3));

            Line li7 = new Line(2, 1);
            Line li8 = new Line(2, 1);

            double[] angles4 = li7.TriangleAnglesWithX(li8);
            Console.WriteLine("Test 4:");
            Console.WriteLine(string.Join(", ", angles4));

            Line li9 = new Line(2, 0);
            Line li10 = new Line(-1, 3);

            double[] angles5 = li9.TriangleAnglesWithX(li10);
            double sum = 0;
            foreach (double a in angles5)
                sum += a;

            Console.WriteLine("Test 5:");
            Console.WriteLine(sum);


        }
    }
}

