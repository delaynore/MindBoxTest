using MindBox.Geometry.Interfaces;

namespace MindBox.Geometry.Shapes;

public class Circle : Shape, ICircle
{

	public Circle(double radius)
	{
		ArgumentOutOfRangeException.ThrowIfNegativeOrZero(radius, nameof(radius));

		Radius = radius;
	}

	public double Radius { get; }

	public override double GetArea()
	{
		return Math.PI * Radius * Radius;
	}
}
