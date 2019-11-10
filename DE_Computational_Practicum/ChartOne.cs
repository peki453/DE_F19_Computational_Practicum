using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace DE_Computational_Practicum
{
    class ChartOne : Plotting
    {
        public void drawPlot(Chart chart1, double X0, double Y0, double UPPER_BOUND, int num_segments, int method)
        {
            List<Tuple<double, double>> ExactSolutionPoints = new List<Tuple<double, double>>();
            List<Tuple<double, double>> ApproxSolutionPoints1 = new List<Tuple<double, double>>();
            List<Tuple<double, double>> ApproxSolutionPoints2 = new List<Tuple<double, double>>();
            List<Tuple<double, double>> ApproxSolutionPoints3 = new List<Tuple<double, double>>();

            MyEquation equation = new MyEquation();
            ExactSolutionPoints = equation.exactSolutionPoints(X0, Y0, UPPER_BOUND);

            Euler euler = new Euler();
            ImprovedEuler improved_euler = new ImprovedEuler();
            RungeKutta runge_kutta = new RungeKutta();

            if (method == 1)
            {
                ApproxSolutionPoints1 = euler.solve(X0, Y0, UPPER_BOUND, num_segments);

                for (int i = 0; i <= 1000; i++)
                    chart1.Series[0].Points.AddXY(ExactSolutionPoints.ElementAt(i).Item1, ExactSolutionPoints.ElementAt(i).Item2);

                for (int i = 0; i <= num_segments; i++)
                    chart1.Series[1].Points.AddXY(ApproxSolutionPoints1.ElementAt(i).Item1, ApproxSolutionPoints1.ElementAt(i).Item2);

                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[1].Name = "Euler's\nmethod";
            }
            else if (method == 2)
            {
                ApproxSolutionPoints1 = improved_euler.solve(X0, Y0, UPPER_BOUND, num_segments);

                for (int i = 0; i <= 1000; i++)
                    chart1.Series[0].Points.AddXY(ExactSolutionPoints.ElementAt(i).Item1, ExactSolutionPoints.ElementAt(i).Item2);

                for (int i = 0; i <= num_segments; i++)
                    chart1.Series[1].Points.AddXY(ApproxSolutionPoints1.ElementAt(i).Item1, ApproxSolutionPoints1.ElementAt(i).Item2);

                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[1].Name = "Improved Euler's\nmethod";
            }
            else if (method == 3)
            {
                ApproxSolutionPoints1 = runge_kutta.solve(X0, Y0, UPPER_BOUND, num_segments);

                for (int i = 0; i <= 1000; i++)
                    chart1.Series[0].Points.AddXY(ExactSolutionPoints.ElementAt(i).Item1, ExactSolutionPoints.ElementAt(i).Item2);

                for (int i = 0; i <= num_segments; i++)
                    chart1.Series[1].Points.AddXY(ApproxSolutionPoints1.ElementAt(i).Item1, ApproxSolutionPoints1.ElementAt(i).Item2);

                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[1].Name = "Runge-Kutta\nmethod";
            }
            else
            {
                ApproxSolutionPoints1 = euler.solve(X0, Y0, UPPER_BOUND, num_segments);
                ApproxSolutionPoints2 = improved_euler.solve(X0, Y0, UPPER_BOUND, num_segments);
                ApproxSolutionPoints3 = runge_kutta.solve(X0, Y0, UPPER_BOUND, num_segments);

                for (int i = 0; i <= 1000; i++)
                    chart1.Series[0].Points.AddXY(ExactSolutionPoints.ElementAt(i).Item1, ExactSolutionPoints.ElementAt(i).Item2);

                for (int i = 0; i <= num_segments; i++)
                    chart1.Series[1].Points.AddXY(ApproxSolutionPoints1.ElementAt(i).Item1, ApproxSolutionPoints1.ElementAt(i).Item2);

                for (int i = 0; i <= num_segments; i++)
                    chart1.Series[2].Points.AddXY(ApproxSolutionPoints2.ElementAt(i).Item1, ApproxSolutionPoints2.ElementAt(i).Item2);

                for (int i = 0; i <= num_segments; i++)
                    chart1.Series[3].Points.AddXY(ApproxSolutionPoints3.ElementAt(i).Item1, ApproxSolutionPoints3.ElementAt(i).Item2);

                chart1.Series[1].IsVisibleInLegend = true;
                chart1.Series[2].IsVisibleInLegend = true;
                chart1.Series[3].IsVisibleInLegend = true;

                chart1.Series[1].Name = "Euler's\nmethod";
                chart1.Series[2].Name = "Improved Euler's\nmethod";
                chart1.Series[3].Name = "Runge-Kutta\nmethod";
            }

            // Design of charts

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.0";
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";

            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            /*chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Interval = 1;*/
        }

        public void updateGraphs(Chart chart1, double X0, double Y0, double UPPER_BOUND, int num_segments, int method)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();

            chart1.Series[1].IsVisibleInLegend = false;
            chart1.Series[2].IsVisibleInLegend = false;
            chart1.Series[3].IsVisibleInLegend = false;

            chart1.Series[1].Name = "s1";
            chart1.Series[2].Name = "s2";
            chart1.Series[3].Name = "s3";

            if (method == 1) chart1.Titles[0].Text = "Exact solution and numerical solution: Euler's method";
            if (method == 2) chart1.Titles[0].Text = "Exact solution and numerical solution: Improved Euler's method";
            if (method == 3) chart1.Titles[0].Text = "Exact solution and numerical solution: Runge-Kutta method";
            if (method == 4) chart1.Titles[0].Text = "Exact solution and numerical solution: All methods";

            drawPlot(chart1, X0, Y0, UPPER_BOUND, num_segments, method);
        }
    }
}
