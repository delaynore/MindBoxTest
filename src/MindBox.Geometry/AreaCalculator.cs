using MindBox.Geometry.Interfaces;

namespace MindBox.Geometry
{
	public static class AreaCalculator
	{
		public static double Calculate(IShape shape)
		{
			return shape.GetArea();
		}
	}
}
