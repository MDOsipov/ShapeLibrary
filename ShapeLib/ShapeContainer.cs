using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLib.Figures;

namespace ShapeLib
{
    public static class ShapeContainer
	{
		public static Circle GetNewCircle(double radius)
		{
			return new Circle(radius);
		}

		public static Triangle GetNewTriangle(double sizeA, double sizeB, double sizeC)
		{
			return new Triangle(sizeA, sizeB, sizeC);
		}
	}
}
