using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleApp.Interfaces;

namespace TriangleApp.Models
{
    public class Triangle : ITriangle
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public TriangleType GetTriangleType()
        {
            if (!IsValidTriangle())
            {
                return TriangleType.Invalid;  // Invalid triangle
            }

            if (SideA == SideB && SideB == SideC)
            {
                return TriangleType.Equilateral;  // Equilateral triangle
            }

            else if (SideA == SideB || SideB == SideC || SideA == SideC)
            {
                return TriangleType.Isosceles;  // Isosceles triangle
            }

            return TriangleType.Scalene;  // Variegated triangle
        }

        private bool IsValidTriangle()
        {
            //  Triangle inequality check
            return (SideA + SideB > SideC) && (SideA + SideC > SideB) && (SideB + SideC > SideA);
        }
    }
}
