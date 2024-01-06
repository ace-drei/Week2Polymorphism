using System;
using Poly;

class Test
{
    static void Main()
    {
        Line line = new Line(5, 1, 2, 3, "red");
        Circle circle = new Circle(5, 5, 3, "Blue");

        // Display information about the Line and Circle
        Console.WriteLine("Initial Information:");
        Console.WriteLine(line.ToString());
        Console.WriteLine(circle.ToString());

        // Translate the Line and Circle
        Vertex translation = new Vertex(2, 4);
        line.Translate(translation);
        circle.Translate(translation);

        // Display information after translation
        Console.WriteLine("\nInformation After Translation:");
        Console.WriteLine(line.ToString());
        Console.WriteLine(circle.ToString());

        // Calculate and display the area of the Circle
        Console.WriteLine("\nCircle Area:");
        Console.WriteLine(circle.Area());


    }
}