using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace DE_Computational_Practicum
{
    interface Plotting
    {
        void drawPlot(Chart chart1, double X0, double Y0, double UPPER_BOUND, int num_segments, int method);
        void updateGraphs(Chart chart1, double X0, double Y0, double UPPER_BOUND, int num_segments, int method);
    }
}
