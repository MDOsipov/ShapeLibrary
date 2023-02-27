using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
	public abstract class Shape
	{
		protected bool ValidatePositiveValue(double sizeValue) => sizeValue >= 0 ? true : false;
		public abstract double Area { get; }
	}
}
