using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Point2D
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public Point2D Center { get; }

        public Point2D(double x, double y)
        {
            Validator.AssertOnPositiveValue(x);
            Validator.AssertOnPositiveValue(y);
            X = x;
            Y = y;
            Center = new Point2D(x / 2, y / 2);
        }
    }
}
