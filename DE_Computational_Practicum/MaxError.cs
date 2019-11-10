using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_Computational_Practicum
{
    class MaxError
    {
        MyEquation myEq = new MyEquation();
        Euler euler = new Euler();
        ImprovedEuler improved_euler = new ImprovedEuler();
        RungeKutta runge_kutta = new RungeKutta();

        public List<Tuple<double, double>> getMaxError(double X0, double Y0, double UPPER_BOUND, int num_segments, int method)
        {
            List<Tuple<double, double>> Points = new List<Tuple<double, double>>();

            for (int i = 1; i <= num_segments; i++)
            {
                List<Tuple<double, double>> PointsOfMethod = new List<Tuple<double, double>>();
                List<Tuple<double, double>> Solution = new List<Tuple<double, double>>();

                if (method == 1) PointsOfMethod = euler.solve(X0, Y0, UPPER_BOUND, i);
                else if (method == 2) PointsOfMethod = improved_euler.solve(X0, Y0, UPPER_BOUND, i);
                else PointsOfMethod = runge_kutta.solve(X0, Y0, UPPER_BOUND, i);

                Points.Add(Tuple.Create((double)i, getMax(PointsOfMethod)));
            }

            return Points;
        }

        double getMax(List<Tuple<double, double>> array)
        {
            double ans = 0;
            for (int i = 0; i < array.Count; i++)
                ans = Math.Max(ans, Math.Abs(array[i].Item2 - myEq.exactSolution(array[i].Item1)));

            return ans;
        }
    }
}
