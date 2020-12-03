using System;
using System.Drawing;

namespace Lab4
{
    public class Triangle
    {
        private Point A { get; set; }
        private Point B { get; set; }
        private Point C { get; set; }
        public Triangle() { }
        public Triangle(Point a, Point b, Point c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public void setCoord(Point a, Point b, Point c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public virtual void showCord()
        {
            Console.WriteLine($"Point A: {A.X} {A.Y}");
            Console.WriteLine($"Point B: {B.X} {B.Y}");
            Console.WriteLine($"Point C: {C.X} {C.Y}");
        }

        public virtual void Square()
        {
            double S = 0;
            S = 0.5 * Math.Abs((B.X - A.X) * (C.Y - A.Y) - (C.X - A.X) * (B.Y - A.Y));
            Console.WriteLine($"Площа трикутника: {(float)S}");
        }

    }
    public class Quadrangle : Triangle
    {
        private Point D { get; set; }
        private float S { get; set; }
        public Quadrangle() { S = 0; }
        public Quadrangle(Point a, Point b, Point c, Point d) : base(a, b, c)
        {
            this.D = d;
            S = Math.Abs((b.X - a.X) * (b.Y - a.Y));
        }
        public override void showCord()
        {
            base.showCord();
            Console.WriteLine($"Point D: {D.X} {D.Y}");
        }
        public void setCoord(Point a, Point b, Point c, Point d)
        {
            base.setCoord(a, b, c);
            this.D = d;
            S = Math.Abs((b.X - a.X) * (b.Y - a.Y));

        }
        public override void Square()
        {
            Console.WriteLine($"Площа чотирикутника: {S}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point();
            Point p3 = new Point();
            Point p4 = new Point();
            p1.X = 5; p1.Y = (-10);
            p2.X = 1; p2.Y = (-1);
            p3.X = 10; p3.Y = (-5);
            p4.X = 25; p4.Y = 10;
            Triangle triangle = new Triangle();
            triangle.setCoord(p1, p2, p3);
            triangle.showCord();
            triangle.Square();
            Quadrangle quadrangle = new Quadrangle();
            quadrangle.setCoord(p1, p2, p3, p4);
            quadrangle.showCord();
            quadrangle.Square();

        }
    }
}
