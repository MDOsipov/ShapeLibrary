using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib.Figures
{
    public class Circle : Shape
    {
        private double radius = 0;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (ValidatePositiveValue(value))
                    radius = value;
                else
                    Console.WriteLine("Circle radius can't be a negative number");
            }
        }
        internal Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area => Math.PI * Math.Pow(Radius, 2);
    }
}
