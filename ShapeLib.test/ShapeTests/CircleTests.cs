using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShapeLib.test.ShapeTests
{
	public class CircleTests
	{
		[Theory]
		[InlineData(0, 0)]
		[InlineData(-5, 0)]
		[InlineData(3, 28.274)]
		[InlineData(5.624542, 99.386)]
		public void Circle_Area_ReturnDouble(double radius, double expected)
		{
			// Arrange
			var circle = ShapeContainer.GetNewCircle(radius);

			// Act
			double result = circle.Area;

			// Assert
			double expectedRounded = Math.Round(expected, 3);
			double resultRounded = Math.Round(result, 3);

			resultRounded.Should().Be(expectedRounded);
		}
	}
}
