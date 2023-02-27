using FluentAssertions;
using Xunit;

namespace ShapeLib.test.ShapeTests
{
	public class TriangleTests
	{

		[Theory]
		[InlineData(3, 4, 5, true)]
		[InlineData(3, 4, 0, false)]
		[InlineData(-3, 4, 5, false)]
		[InlineData(5, 5, 5, false)]
		[InlineData(9, 12, 15, true)]
		[InlineData(1.5, 2, 2.5, true)]
		public void Triangle_IsRectangular_ReturnBool(double sizeA, double sizeB, double sizeC, bool expected)
		{
			// Arrange
			var triangle = ShapeContainer.GetNewTriangle(sizeA, sizeB, sizeC);

			// Act
			bool result = triangle.IsRectangular;

			// Assert
			result.Should().Be(expected);	
		}

		[Theory]
		[InlineData(3, 4, 5, 6)]
		[InlineData(-3, 4, 5, 0)]
		[InlineData(0, 4, 5, 0)]
		[InlineData(5.2, 4.3, 2.7, 5.796)]
		[InlineData(1, 1, 1, 0.433)]
		public void Triangle_Area_ReturnDouble(double sizeA, double sizeB, double sizeC, double expected)
		{
			// Arrange
			var triangle = ShapeContainer.GetNewTriangle(sizeA, sizeB, sizeC);

			// Act
			double result = triangle.Area;

			// Assert
			double expectedRounded = Math.Round(expected, 3);
			double resultRounded = Math.Round(result, 3);

			resultRounded.Should().Be(expectedRounded);
		}
	}
}
