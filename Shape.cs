using System;

namespace WhileLoops
{
    public class Shape
    {
       public double CircleArea(double radius, double pi)
    {

        double aCircle = 0;
        aCircle = pi * Math.Pow(radius, 2) ;
        return aCircle;
    }

    public double SquareArea(double length)
    {

        double aSquare = 0;
        aSquare = Math.Pow(length, 2);
        return aSquare;
    }
    
    public double TriangleArea(double h, double b)
    {
        double hieght = h;
        double bases = b;
        double aTriangle = 0;

        aTriangle = (bases * hieght)/2;
   
        return aTriangle;
    }

    public double RectangleArea(double l, double b)
    {
        double length = l;
        double breadth = b;
        double aRectangle = 0;

        aRectangle = length * breadth;

        return aRectangle;
    }
 
    }
}