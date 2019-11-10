using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DE_Computational_Practicum
{
    public partial class Form1 : Form
    {
        int X0_VALUE = 1;
        int Y0_VALUE = -2;
        int UPPER_BOUND_VALUE = 7;
        int NUM_SEGMENTS_VALUE = 10;
        int METHOD = 1;

        ChartOne draw1 = new ChartOne();
        ChartTwo draw2 = new ChartTwo();
        ChartThree draw3 = new ChartThree();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            draw1.updateGraphs(chart1, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
            draw2.updateGraphs(chart2, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
            draw3.updateGraphs(chart3, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
            clearButtons();
            btnEuler.BackColor = Color.ForestGreen;
        }

        private void clearButtons()
        {
            btnEuler.BackColor = Color.FromArgb(64, 64, 64);
            btnImprovedEuler.BackColor = Color.FromArgb(64, 64, 64);
            btnRungeKutta.BackColor = Color.FromArgb(64, 64, 64);
            btnAllMethods.BackColor = Color.FromArgb(64, 64, 64);
        }

        /* Action functions */

        private void BtnEuler_Click(object sender, EventArgs e)
        {
            clearButtons();
            btnEuler.BackColor = Color.ForestGreen;
            METHOD = 1;
            draw1.updateGraphs(chart1, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
            draw2.updateGraphs(chart2, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
            draw3.updateGraphs(chart3, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
        }

        private void BtnImprovedEuler_Click(object sender, EventArgs e)
        {
            clearButtons();
            btnImprovedEuler.BackColor = Color.ForestGreen;
            METHOD = 2;
            draw1.updateGraphs(chart1, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
            draw2.updateGraphs(chart2, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
            draw3.updateGraphs(chart3, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
        }

        private void BtnRungeKutta_Click(object sender, EventArgs e)
        {
            clearButtons();
            btnRungeKutta.BackColor = Color.ForestGreen;
            METHOD = 3;
            draw1.updateGraphs(chart1, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
            draw2.updateGraphs(chart2, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
            draw3.updateGraphs(chart3, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
        }

        private void BtnAllMethods_Click(object sender, EventArgs e)
        {
            clearButtons();
            btnAllMethods.BackColor = Color.ForestGreen;
            METHOD = 4;
            draw1.updateGraphs(chart1, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
            draw2.updateGraphs(chart2, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
            draw3.updateGraphs(chart3, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(txtX0.Text, out n);

            if (isNumeric == true)
            {
                if (n < UPPER_BOUND_VALUE && n > 0)
                {
                    X0_VALUE = n;
                    draw1.updateGraphs(chart1, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
                    draw2.updateGraphs(chart2, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
                    draw3.updateGraphs(chart3, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
                }
            }
        }

        private void TxtY0_TextChanged(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(txtY0.Text, out n);

            if (isNumeric == true)
            {
                if (n <= 0)
                {
                    Y0_VALUE = n;
                    draw1.updateGraphs(chart1, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
                    draw2.updateGraphs(chart2, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
                    draw3.updateGraphs(chart3, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
                }
            }
        }

        private void TxtX_TextChanged(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(txtX.Text, out n);

            if (isNumeric == true)
            {
                if (n > X0_VALUE)
                {
                    UPPER_BOUND_VALUE = n;
                    draw1.updateGraphs(chart1, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
                    draw2.updateGraphs(chart2, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
                    draw3.updateGraphs(chart3, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
                }
            }
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            NUM_SEGMENTS_VALUE = trcNumSteps.Value;
            draw1.updateGraphs(chart1, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
            draw2.updateGraphs(chart2, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
            draw3.updateGraphs(chart3, X0_VALUE, Y0_VALUE, UPPER_BOUND_VALUE, NUM_SEGMENTS_VALUE, METHOD);
            txtNumSteps.Text = "Number of grid steps: " + Convert.ToString(trcNumSteps.Value);
        }

        private void TxtX0_Leave(object sender, EventArgs e)
        {
            txtX0.Text = Convert.ToString(X0_VALUE);
        }

        private void TxtY0_Leave(object sender, EventArgs e)
        {
            txtY0.Text = Convert.ToString(Y0_VALUE);
        }

        private void TxtX_Leave(object sender, EventArgs e)
        {
            txtX.Text = Convert.ToString(UPPER_BOUND_VALUE);
        }
    }
}
