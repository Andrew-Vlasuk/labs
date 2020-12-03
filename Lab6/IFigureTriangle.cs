using System.Drawing;

namespace Lab6
{
    public abstract class IFigureTriangle
    {
        abstract public Point A { get; set; }
        abstract public Point B { get; set; }
        abstract public Point C { get; set; }
        abstract public void setCoord(Point a, Point b, Point c);
        abstract public void showCord();
        abstract public void Square();
    }
}
