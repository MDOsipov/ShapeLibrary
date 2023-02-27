using ShapeLib;
using ShapeLib.Figures;

// Фигуры создаются через класс ShapeContainer, импортируемый из библиотеки (ShapeLib)
Triangle triangle = ShapeContainer.GetNewTriangle(-3, 4, 5);
Circle circle = ShapeContainer.GetNewCircle(5);

// У двух фигур есть свойство Area - площадь
Console.WriteLine($"Triangle area = {triangle.Area}");
Console.WriteLine($"Circle area = {circle.Area}");

// У треугольника есть свойство IsRectangular - флаг, показывающий, является ли треугольник прямоугольным
if (triangle.IsRectangular)
	Console.WriteLine("Rectangular");
else
	Console.WriteLine("Not rectangular");


