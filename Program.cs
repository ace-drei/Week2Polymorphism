using System;


namespace Poly;

public class Vertex
{
    public int X { get; set; }
    public int Y { get; set; }

    public Vertex(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class Shape
{
    public String Color { get; set; }

    public Shape(String color)
    {
        this.Color = color;
    }

    public virtual string ToString()
    {
        return $"Colour: {Color}";
    }

    public virtual void Translate(Vertex translation)
    {

    }
}

public class Line : Shape
{

    private readonly Vertex v1, v2;

    public Line(int x1, int y1, int x2, int y2, string color) : base(color)
    {
        v1 = new Vertex(x1, y1);
        v2 = new Vertex(x2, y2);
    }


    public int X1 
    {
        get { return v1.X; }
        set { v1.X = value; }
    }

    public int X2 
    {
        get { return v2.X; }
        set { v2.X = value; }
    }

    public int Y1 
    { 
        get { return v1.Y; }
        set { v1.Y = value; }
    }

    public int Y2 
    { 
        get { return v2.Y; } 
        set { v2.Y = value; }
    }


    public override string ToString()
    {
        return $" x1= {X1} \n x2 = {X2}\n y1= {Y1} \n y2 = {Y2} \n Color = {Color}\n\n";
    }

    public override void Translate(Vertex translation)
    {
        v1.X += translation.X;
        v2.X += translation.X;
        v1.Y += translation.Y;
        v2.Y += translation.Y; 
    }
}

public class Circle : Shape
{
    public double Radius { get; }
    public Vertex origin;

    public Circle(int x, int y, double radius, string color): base(color)
    {
        this.Radius = radius;
        this.Color = color;
        origin = new Vertex(x, y);
    }

    public override string ToString()
    {
        return $" Radius {Radius}\n Color {Color} \n Origin {origin}\n\n";
    }


    public override void Translate(Vertex translation)
    {
        origin.X += translation.X;
        origin.Y += translation.Y;
    }

    public double Area()
    {
        return Math.PI * this.Radius* this.Radius ;
    }

}

