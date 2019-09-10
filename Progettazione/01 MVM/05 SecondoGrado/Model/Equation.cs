using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SecondoGrado.Model
{
    public class Equation
    {
        #region =================== membri & proprietà =========
        private double a;

        public double A
        {
            get { return a; }
            set
            {
                a = value;
                Roots();
            }
        }

        private double b;

        public double B
        {
            get { return b; }
            set
            {
                b = value;
                Roots();
            }
        }

        private double c;

        public double C
        {
            get { return c; }
            set
            {
                c = value;
                Roots();
            }
        }

        public double Delta { get; set; }

        public double Root1 { get; set; }

        public double Root2 { get; set; }

        #endregion

        #region =================== costruttori ================
        public Equation() : this(0.0, 0.0, 0.0)
        {

        }

        public Equation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        #endregion

        #region =================== metodi aiuto ===============
        private void Roots()
        {
            Delta = Math.Pow(B, 2) - 4 * A * C;
            if (Delta < 0)
            {
                Root1 = double.NaN;
                Root2 = double.NaN;
            }
            else if (Delta == 0)
            {
                Root1 = -B / (2 * A);
                Root2 = double.NaN;
            }
            else
            {
                Root1 = (-B + Math.Sqrt(Delta)) / (2 * A);
                Root2 = (-B - Math.Sqrt(Delta)) / (2 * A);
            }
        }
        #endregion

        #region =================== metodi generali ============
        public Point2D Vertex()
        {
            return new Point2D(-B / (2 * A), -Delta / (4 * A));
        }

        public double Y(double x)
        {
            return A * Math.Pow(x, 2) + B * x + C;
        }
        #endregion
    }
}
