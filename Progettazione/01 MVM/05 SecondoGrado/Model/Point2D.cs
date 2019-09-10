using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SecondoGrado.Model
{
    public class Point2D
    {
        #region =================== membri & proprietà =========
        public double X { get; set; }

        public double Y { get; set; }
        #endregion

        #region =================== costruttori ================
        public Point2D() : this(0.0, 0.0)
        {

        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region =================== metodi generali ============
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", X, Y);
        }
        #endregion
    }
}
