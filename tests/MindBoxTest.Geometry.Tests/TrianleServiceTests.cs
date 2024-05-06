using MindBox.Geometry;
using MindBox.Geometry.Shapes;

namespace MindBoxTest.Geometry.Tests
{
	public class TrianleServiceTests
	{
		[Theory]
		[InlineData(3, 4, 5)]
		[InlineData(5, 12, 13)]
		[InlineData(6, 8, 10)]
		public void IsRightAngled_Returns_True_For_Right_Angled_Triangle(double sideA, double sideB, double sideC)
		{
			var triangle = new Triangle(sideA, sideB, sideC);

			var isRightAngled = TriangleService.IsRightAngled(triangle);

			Assert.True(isRightAngled);
		}

		[Theory]
		[InlineData(3, 4, 6)]
		[InlineData(5, 13, 13)]
		[InlineData(6, 9, 10)]
		[InlineData(11, 11, 11)]
		public void IsRightAngled_Returns_False_For_Non_Right_Angled_Triangle(double sideA, double sideB, double sideC)
		{
			var triangle = new Triangle(sideA, sideB, sideC);

			var isRightAngled = TriangleService.IsRightAngled(triangle);

			Assert.False(isRightAngled);
		}
	}
}
