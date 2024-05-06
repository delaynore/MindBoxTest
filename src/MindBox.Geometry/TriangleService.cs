using MindBox.Geometry.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Geometry
{
	public static class TriangleService
	{

		public static bool IsRightAngled(ITriangle triangle)
		{
			double[] sides = [triangle.SideA, triangle.SideB, triangle.SideC];
			Array.Sort(sides);

			return Math.Pow(sides[2], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2);
		}

		public static bool IsValidSides(double sideA, double sideB, double sideC)
		{
			return sideA + sideB > sideC
				&& sideA + sideC > sideB
				&& sideB + sideC > sideA;
		}
	}
}
