using System;



namespace Lab4
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y) { X = x; Y = y; }
    }
    public class Triangle
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Triangle() { }
        public Triangle(Point a, Point b, Point c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public virtual void Init()
        {
            Console.WriteLine("Enter: A.X: ");
            int aX = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter: A.Y: ");
            int aY = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter: B.X: ");
            int bX = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter: B.Y: ");
            int bY = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter: C.X: ");
            int cX = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter: C.X: ");
            int cY = int.Parse(Console.ReadLine());

            Point p1 = new Point(aX, aY);
            Point p2 = new Point(bX, bY);
            Point p3 = new Point(cX, cY);

            new Triangle(p1, p2, p3);
        }
        public virtual void ShowCord()
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
        public override void ShowCord()
        {
            base.ShowCord();
            Console.WriteLine($"Point D: {D.X} {D.Y}");
        }
        public override void Init()
        {
            base.Init();

            Console.WriteLine("Enter: D.X: ");
            int dX = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter: D.Y: ");
            int dY = int.Parse(Console.ReadLine());

            Point p4 = new Point(dX, dY);

            this.D = p4;
        }
        public override void Square()
        {
            S = Math.Abs((this.B.X - this.A.X) * (this.B.Y - this.A.Y));
            Console.WriteLine($"Площа чотирикутника: {S}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point();
            //Point p2 = new Point();
            //Point p3 = new Point();
            //Point p4 = new Point();
            //p1.X = 5; p1.Y = (-10);
            //p2.X = 1; p2.Y = (-1);
            //p3.X = 10; p3.Y = (-5);
            //p4.X = 25; p4.Y = 10;
            //Triangle triangle = new Triangle();
            //triangle.setCoord(p1, p2, p3);
            //triangle.showCord();
            //triangle.Square();
            //Quadrangle quadrangle = new Quadrangle();
            //quadrangle.setCoord(p1, p2, p3, p4);
            //quadrangle.showCord();
            //quadrangle.Square();
            int userSelect;
            Triangle baseobj = new Triangle();
            do
            {
                Console.WriteLine("Enter '0' if you want to work with Triangle and '1' - with Quadrangle");
                userSelect = Convert.ToInt32(Console.ReadLine());

                if (userSelect == 0)
                {
                    baseobj = new Triangle();
                    baseobj.Init();
                }

                else if (userSelect == 1)
                    baseobj = new Quadrangle();

                else
                    return;

                baseobj.Init();
                baseobj.ShowCord();
                baseobj.Square();
            } while (true);
        }

    }

}
