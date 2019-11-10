using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DE_Computational_Practicum
{
    class MyEquation
    {
        int MAX_NUM_STEPS = 1000;

        public double equation(double X, double Y)
        {
            return Math.Exp(Y) - 2 / X;
        }

        public double exactSolution(double X)
        {
            return (-1) * Math.Log((Math.Exp(2) - 1) * X * X + X);
        }

        public List<Tuple<double, double>> exactSolutionPoints(double X0, double Y0, double UPPER_BOUND)
        {
            List<Tuple<double, double>> Points = new List<Tuple<double, double>>();

            double step = (UPPER_BOUND - X0) / MAX_NUM_STEPS;
            double x_curr = X0;
            double y_curr = Y0;

            Points.Add(Tuple.Create(X0, Y0));

            for (int i = 0; i < MAX_NUM_STEPS; i++)
            {
                y_curr = exactSolution(x_curr);
                x_curr = x_curr + step;
                Points.Add(Tuple.Create(X0 + (i + 1) * step, y_curr));
            }

            return Points;
        }
    }
}