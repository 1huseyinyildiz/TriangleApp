// Program.cs
using System;
using TriangleApp.Interfaces;
using TriangleApp.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ConstValues.EnterMessage);

        try
        {
            double sideA = Convert.ToDouble(Console.ReadLine());
            double sideB = Convert.ToDouble(Console.ReadLine());
            double sideC = Convert.ToDouble(Console.ReadLine());

            ITriangle triangle = new Triangle(sideA, sideB, sideC);
            TriangleType type = triangle.GetTriangleType();

            if (type == TriangleType.Invalid)
            {
                Console.WriteLine(ConstValues.InvalidTriangleErrorMessage);
            }
            else
            {
                Console.WriteLine($"{ConstValues.TriangleType} { type}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine(ConstValues.InvalidInputErrorMessage);
        }
    }
}
