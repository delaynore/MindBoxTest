using MindBox.Geometry.Shapes;

namespace MindBox.Geometry.Tests;

public class CircleTests
{
	[Theory]
	[InlineData(0)]
	[InlineData(-1)]
	[InlineData(-2)]
	[InlineData(-3)]
	public void Constructor_Throws_ArgumentOutOfRangeException_For_Negative_Radius(double radius)
	{
		Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
	}


	[Theory]
	[InlineData(1)]
	[InlineData(2)]
	[InlineData(3.1)]
	[InlineData(0.1)]
	public void GetArea_Returns_Correct_Value(double radius)
	{
		var circle = new Circle(radius);

		var area = circle.GetArea();

		Assert.Equal(Math.PI * radius * radius, area);
	}
}
