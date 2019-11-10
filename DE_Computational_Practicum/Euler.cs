using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_Computational_Practicum
{
    class Euler : NumericalMethod
    {
        MyEquation myEq = new MyEquation();

        public List<Tuple<double, double>> solve(double X0, double Y0, double UPPER_BOUND, int num_segments)
        {
            List<Tuple<double, double>> Points = new List<Tuple<double, double>>();

            double step = (UPPER_BOUND - X0) / num_segments;
            double x_curr = X0;
            double y_curr = Y0;

            Points.Add(Tuple.Create(X0, Y0));

            for (int i = 0; i < num_segments; i++)
            {
                y_curr = y_curr + step * myEq.equation(x_curr, y_curr);
                x_curr = x_curr + step;
                Points.Add(Tuple.Create(X0 + (i + 1) * step, y_curr));
            }

            return Points;
        }
    }
}
