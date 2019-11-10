using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_Computational_Practicum
{
    interface NumericalMethod
    {
        List<Tuple<double, double>> solve(double X0, double Y0, double UPPER_BOUND, int num_segments);
    }
}