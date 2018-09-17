using System;
using System.Collections.Generic;
using System.Text;

namespace Monte_Carlo_Method
{
    struct Coordinate
    {
        private double x, y;
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public Coordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Coordinate(Random random)
        {
            x = random.NextDouble();
            y = random.NextDouble();
        }
        public double Hypotenuse()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(Y, 2));
        }
    }

}
