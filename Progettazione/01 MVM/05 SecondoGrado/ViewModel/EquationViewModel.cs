using _05_SecondoGrado.Model;
using MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace _05_SecondoGrado.ViewModel
{
    public class EquationViewModel : BindableBase
    {
        #region =================== costanti =========
        public const double XMIN = -4.0;
        public const double XMAX = 4.0;

        public const double YMIN = -20.0;
        public const double YMAX = 20.0;

        public const double STEP = 0.5;

        private const int SLEEPTIME = 20;
        #endregion
        #region =================== membri & proprietà =========
        private Equation model;
        private DispatcherTimer timer;
        private double x;
        public double A
        {
            get { return model.A; }
            set
            {
                if (model.A == value)
                {
                    return;
                }
                model.A = value;
                OnPropertyChanged(() => A);
                OnPropertyChanged(() => Root1);
                OnPropertyChanged(() => Root2);
                OnPropertyChanged(() => Vertex);
            }
        }

        public double B
        {
            get { return model.B; }
            set
            {
                if (model.B == value)
                {
                    return;
                }
                model.B = value;
                OnPropertyChanged(() => B);
                OnPropertyChanged(() => Root1);
                OnPropertyChanged(() => Root2);
                OnPropertyChanged(() => Vertex);
            }
        }

        public double C
        {
            get { return model.C; }
            set
            {
                if (model.C == value)
                {
                    return;
                }
                model.C = value;
                OnPropertyChanged(() => C);
                OnPropertyChanged(() => Root1);
                OnPropertyChanged(() => Root2);
                OnPropertyChanged(() => Vertex);
            }
        }

        public double Root1
        {
            get { return model.Root1; }
        }

        public double Root2
        {
            get { return model.Root2; }
        }

        public Point2D Vertex
        {
            get { return model.Vertex(); }
        }

        public ObservableCollection<Point2D> Points { get; private set; }


        public IDelegateCommand DrawCommand { get; private set; }
        #endregion

        #region =================== costruttori ================
        public EquationViewModel()
        {
            model = new Equation();
            A = 1;
            B = 2;
            C = -8;


            Points = new ObservableCollection<Point2D>();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(SLEEPTIME);
            timer.Tick += Timer_Tick;

            DrawCommand = new DelegateCommand(OnDraw);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (x > XMAX)
            {
                timer.Stop();
            }

            double y = model.Y(x);

            Point2D coordinate = new Point2D(x, y);
            Point2D normalized = Normalize(coordinate);

            Points.Add(normalized);

            x += STEP;

        }
        #endregion

        #region =================== metodi aiuto ===============
        private void OnDraw(object obj)
        {
            Points.Clear();
            x = XMIN;
            timer.Start();
        }

        /// <summary>
        /// Transforms a point obtained from the function into its graphical rappresentation in pixels
        /// </summary>
        /// <param name="point">The point calculated with the function</param>
        /// <returns>Point to represent in a canvas</returns>
        private Point2D Normalize(Point2D point)
        {
            double canvasWidth = 200;
            double canvasHeight = 200;
            Point2D result = new Point2D()
            {
                X = canvasWidth * (point.X - XMIN) / (XMAX - XMIN),
                Y = canvasHeight - canvasHeight * (point.Y - YMIN) / (YMAX - YMIN)
            };
            return result;
        }
        #endregion

    }
}
