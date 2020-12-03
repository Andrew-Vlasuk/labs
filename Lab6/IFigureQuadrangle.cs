using System;
using System.Drawing;

namespace Lab6
{
    public abstract class IFigureQuadrangle
    {
        abstract public Point A { get; set; }
        abstract public Point B { get; set; }
        abstract public Point C { get; set; }
        abstract public Point D { get; set; }
        abstract public void setCoord(Point a, Point b, Point c, Point d);
        abstract public void showCord();
        abstract public void Square();
    }
}
