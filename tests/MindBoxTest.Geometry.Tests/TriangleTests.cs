using MindBox.Geometry.Shapes;

namespace MindBox.Geometry.Tests;

public class TriangleTests
{
	[Theory]
	[InlineData(0, 1, 1)]
	[InlineData(1, 0, 1)]
	[InlineData(1, 1, 0)]
	[InlineData(-1, 1, 1)]
	[InlineData(1, -1, 1)]
	[InlineData(1, 1, -1)]
	public void Constructor_Throws_ArgumentException_For_Invalid_Triangle_Sides(double sideA, double sideB, double sideC)
	{
		Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
	}

	[Fact]
	public void GetArea_Returns_Correct_Value()
	{
		var sideA = 3;
		var sideB = 4;
		var sideC = 5;
		var triangle = new Triangle(sideA, sideB, sideC);

		var area = triangle.GetArea();

		Assert.Equal(6, area);
	}
}
