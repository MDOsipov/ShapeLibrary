using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib.Figures
{
    public class Triangle : Shape
    {
        private double sideA = 0;
        private double sideB = 0;
        private double sideC = 0;
        private List<double> sideList => new List<double>() { sideA, sideB, sideC };
        private double MaxSideSize => sideList.Max();

        public double SideA
        {
            get { return sideA; }
            set
            {
                if (ValidatePositiveValue(value))
                    sideA = value;
                else
                    Console.WriteLine("Triangle side can't be a negative number");
            }
        }

        public double SideB
        {
            get { return sideB; }
            set
            {
                if (ValidatePositiveValue(value))
                    sideB = value;
                else
                    Console.WriteLine("Triangle side can't be a negative number");
            }
        }

        public double SideC
        {
            get { return sideC; }
            set
            {
                if (ValidatePositiveValue(value))
                    sideC = value;
                else
                    Console.WriteLine("Triangle side can't be a negative number");
            }
        }

        internal Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        private double HalfPerimeter => (sideA + sideB + sideC) / 2;
        public bool IsRectangular => Area.Equals(0) ? false : Math.Pow(MaxSideSize, 2) == sideList.Where(elem => elem != MaxSideSize).Select(elem => Math.Pow(elem, 2)).Sum();

		public override double Area => sideA.Equals(0) || sideB.Equals(0) || sideC.Equals(0) ? 0 : Math.Sqrt(HalfPerimeter * (HalfPerimeter - sideA) * (HalfPerimeter - sideB) * (HalfPerimeter - sideC));
    }
}
