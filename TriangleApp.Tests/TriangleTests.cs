using TriangleApp.Interfaces;
using TriangleApp.Models;
using Xunit;

public class TriangleTests
{
    [Fact]
    public void EquilateralTriangle_ReturnsEquilateral()
    {
        ITriangle triangle = new Triangle(3, 3, 3);
        TriangleType type = triangle.GetTriangleType();
        Assert.Equal(TriangleType.Equilateral, type);

    }
  
    public void IsoscelesTriangle_ReturnsIsosceles()
    {
        ITriangle triangle = new Triangle(3, 3, 2);
        TriangleType type = triangle.GetTriangleType();
        Assert.Equal(TriangleType.Isosceles, type);
    }

    public void ScaleneTriangle_ReturnsScalene()
    {
        ITriangle triangle = new Triangle(3, 4, 5);
        TriangleType type = triangle.GetTriangleType();
        Assert.Equal(TriangleType.Scalene, type);
    }

    public void ScaleneTriangle_ReturnsInvalid()
    {
        ITriangle triangle = new Triangle(2, 3, 10);
        TriangleType type = triangle.GetTriangleType();
        Assert.Equal(TriangleType.Invalid, type);
    }
}
