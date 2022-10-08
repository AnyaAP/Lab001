using System;

namespace Lab001
{
    //2
    public class Rectangle
    {
        private double side1, side2;
        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA;
            side2 = sideB;
        }
        public double AreaCalculator()
        {
            return (side1 * side2);
        }
        public double PerimeterCalculator()
        {
            return (2 * (side1 + side2));
        }

        double Area
        {
            get => AreaCalculator();
        }

        double Perimeter
        {
            get =>PerimeterCalculator();
        }
    }

    //3
    public class Point
    {
        private int x, y;
        public int get_x
        {
            get => x;
        }

        public int get_y
        {
            get => y;
        }

        public Point(int x0, int y0)
        {
            x = x0;
            y = y0;
        }
    }

    public class Figure
    {
        Point A = new Point(0, 0), B = new Point(0, 0),
            C = new Point(0, 0), D = new Point(0, 0),
            E = new Point(0, 0);
        public string name
        {
            get;
            set;
        }
        public Figure(Point p1, Point p2, Point p3)
        {
            name = "Triangle";
            A = p1;
            B = p2;
            C = p3;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4):this(p1,p2,p3)
        {
            name = "Rectangle";
            D = p4;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            name = "Pentagon";
            A = p1;
            B = p2;
            C = p3;
            D = p4;
            E = p5;
        }
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.get_x - A.get_x, 2) + Math.Pow(B.get_y - A.get_y, 2));
        }
        public double PerimeterCalculator()
        {
            if (this.name == "Triangle")
                return (this.LengthSide(A, B) + this.LengthSide(B, C) 
                    + this.LengthSide(C, A));
            else if (this.name == "Rectangle")
                return (this.LengthSide(A, B) + this.LengthSide(B, C) 
                    + this.LengthSide(C, D) + this.LengthSide(D, A));
            else return (this.LengthSide(A, B) + this.LengthSide(B, C)
                    + this.LengthSide(C, D) + this.LengthSide(D, E) 
                    + this.LengthSide(E, A));
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {

            // 1
            Console.WriteLine("1 task.");
            Console.WriteLine("sbyte: " + sbyte.MinValue + "; " + sbyte.MaxValue);
            Console.WriteLine("short: " + short.MinValue + "; " + short.MaxValue);
            Console.WriteLine("int: " + int.MinValue + "; " + int.MaxValue);
            Console.WriteLine("long: " + long.MinValue + "; " + long.MaxValue);
            Console.WriteLine("byte: " + byte.MinValue + "; " + byte.MaxValue);
            Console.WriteLine("ushort: " + ushort.MinValue + "; " + ushort.MaxValue);
            Console.WriteLine("uint: " + uint.MinValue + "; " + uint.MaxValue);
            Console.WriteLine("ulong: " + ulong.MinValue + "; " + ulong.MaxValue);
            Console.WriteLine("float: " + float.MinValue + "; " + float.MaxValue);
            Console.WriteLine("double: " + double.MinValue + "; " + double.MaxValue);
            Console.WriteLine("bool: " + bool.FalseString + "; " + bool.TrueString);
            Console.WriteLine("char: " + char.MinValue + "; " + char.MaxValue);
            Console.WriteLine("decimal: " + decimal.MinValue + "; " + decimal.MaxValue);

            //2
            Console.WriteLine("\n2 task.");
            Console.WriteLine("Side 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Side 2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rec = new Rectangle(side1, side2);
            Console.WriteLine("Area:" + rec.AreaCalculator());
            Console.WriteLine("Perimeter:" + rec.PerimeterCalculator());

            //3
            Console.WriteLine("\n3 task.");
            Point p1 = new Point(1, 5);
            Point p2 = new Point(2, 3);
            Point p3 = new Point(3, 2);
            Point p4 = new Point(4, 2);
            Point p5 = new Point(5, 6);
            Figure f1 = new Figure(p1, p2, p3);
            Figure f2 = new Figure(p1, p2, p3, p4);
            Figure f3 = new Figure(p1, p2, p3, p4, p5);
            Console.WriteLine(f1.name + " Perimeter:" + f1.PerimeterCalculator());
            Console.WriteLine(f2.name + " Perimeter:" + f2.PerimeterCalculator());
            Console.WriteLine(f3.name + " Perimeter:" + f3.PerimeterCalculator());
        }
    }
}
