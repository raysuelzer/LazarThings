using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Equilateral Polygon Calculator");
        Console.WriteLine();

        // Get user input for the number of sides (3 to 6)
        Console.Write("Enter the number of sides (3 to 6): ");
        int sides = int.Parse(Console.ReadLine());

        if (sides < 3 || sides > 6)
        {
            Console.WriteLine("Invalid number of sides. Please enter a value between 3 and 6.");
            return;
        }

        // Get user input for the X coordinate of the center
        Console.Write("Enter the X coordinate of the center: ");
        double centerX = double.Parse(Console.ReadLine());

        // Get user input for the Y coordinate of the center
        Console.Write("Enter the Y coordinate of the center: ");
        double centerY = double.Parse(Console.ReadLine());

        // Get user input for the radius
        Console.Write("Enter the radius: ");
        double radius = double.Parse(Console.ReadLine());

        // Calculate the angle between vertices
        double angle = 2 * Math.PI / sides;

        // Calculate the coordinates of the vertices
        double[] xCoordinates = new double[sides];
        double[] yCoordinates = new double[sides];

        for (int i = 0; i < sides; i++)
        {
            double x = centerX + radius * Math.Cos(i * angle);
            double y = centerY + radius * Math.Sin(i * angle);
            xCoordinates[i] = x;
            yCoordinates[i] = y;
        }

        // Display the coordinates
        Console.WriteLine();
        Console.WriteLine("Polygon Coordinates:");
        for (int i = 0; i < sides; i++)
        {
            Console.WriteLine($"Vertex {i + 1}: ({xCoordinates[i]}, {yCoordinates[i]})");
        }
    }
}