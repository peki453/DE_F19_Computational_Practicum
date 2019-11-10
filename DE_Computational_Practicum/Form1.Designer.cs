namespace DE_Computational_Practicum
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEuler = new System.Windows.Forms.Button();
            this.btnImprovedEuler = new System.Windows.Forms.Button();
            this.btnRungeKutta = new System.Windows.Forms.Button();
            this.btnAllMethods = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumSteps = new System.Windows.Forms.Label();
            this.trcNumSteps = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcNumSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.Title = "Value of x";
            chartArea1.AxisY.Title = "Value of y";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(630, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Exact solution";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Method 1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Method 2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Method 3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(600, 380);
            this.chart1.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "Title1";
            title1.Text = "Exact solution and approximate solution";
            this.chart1.Titles.Add(title1);
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.Title = "Number of grid steps";
            chartArea2.AxisY.Title = "Total Error";
            chartArea2.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart3.Legends.Add(legend2);
            this.chart3.Location = new System.Drawing.Point(630, 410);
            this.chart3.Name = "chart3";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Series3";
            this.chart3.Series.Add(series5);
            this.chart3.Series.Add(series6);
            this.chart3.Series.Add(series7);
            this.chart3.Size = new System.Drawing.Size(600, 380);
            this.chart3.TabIndex = 1;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title2.Name = "Title1";
            title2.Text = "Global error";
            this.chart3.Titles.Add(title2);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.AxisX.Title = "Value of x";
            chartArea3.AxisY.Title = "Local Error";
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(12, 410);
            this.chart2.Name = "chart2";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Series2";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Series3";
            this.chart2.Series.Add(series8);
            this.chart2.Series.Add(series9);
            this.chart2.Series.Add(series10);
            this.chart2.Size = new System.Drawing.Size(600, 380);
            this.chart2.TabIndex = 2;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title3.Name = "Title1";
            title3.Text = "Local errors";
            this.chart2.Titles.Add(title3);
            // 
            // btnEuler
            // 
            this.btnEuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEuler.ForeColor = System.Drawing.Color.White;
            this.btnEuler.Location = new System.Drawing.Point(12, 266);
            this.btnEuler.Name = "btnEuler";
            this.btnEuler.Size = new System.Drawing.Size(297, 60);
            this.btnEuler.TabIndex = 3;
            this.btnEuler.Text = "Euler\'s method";
            this.btnEuler.UseVisualStyleBackColor = false;
            this.btnEuler.Click += new System.EventHandler(this.BtnEuler_Click);
            // 
            // btnImprovedEuler
            // 
            this.btnImprovedEuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImprovedEuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprovedEuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnImprovedEuler.ForeColor = System.Drawing.Color.White;
            this.btnImprovedEuler.Location = new System.Drawing.Point(315, 266);
            this.btnImprovedEuler.Name = "btnImprovedEuler";
            this.btnImprovedEuler.Size = new System.Drawing.Size(297, 60);
            this.btnImprovedEuler.TabIndex = 4;
            this.btnImprovedEuler.Text = "Improved Euler\'s method";
            this.btnImprovedEuler.UseVisualStyleBackColor = false;
            this.btnImprovedEuler.Click += new System.EventHandler(this.BtnImprovedEuler_Click);
            // 
            // btnRungeKutta
            // 
            this.btnRungeKutta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRungeKutta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRungeKutta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRungeKutta.ForeColor = System.Drawing.Color.White;
            this.btnRungeKutta.Location = new System.Drawing.Point(12, 332);
            this.btnRungeKutta.Name = "btnRungeKutta";
            this.btnRungeKutta.Size = new System.Drawing.Size(297, 60);
            this.btnRungeKutta.TabIndex = 5;
            this.btnRungeKutta.Text = "Runge-Kutta method";
            this.btnRungeKutta.UseVisualStyleBackColor = false;
            this.btnRungeKutta.Click += new System.EventHandler(this.BtnRungeKutta_Click);
            // 
            // btnAllMethods
            // 
            this.btnAllMethods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAllMethods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAllMethods.ForeColor = System.Drawing.Color.White;
            this.btnAllMethods.Location = new System.Drawing.Point(315, 332);
            this.btnAllMethods.Name = "btnAllMethods";
            this.btnAllMethods.Size = new System.Drawing.Size(297, 60);
            this.btnAllMethods.TabIndex = 6;
            this.btnAllMethods.Text = "All methods";
            this.btnAllMethods.UseVisualStyleBackColor = false;
            this.btnAllMethods.Click += new System.EventHandler(this.BtnAllMethods_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "X0";
            // 
            // txtX0
            // 
            this.txtX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtX0.Location = new System.Drawing.Point(63, 207);
            this.txtX0.MaxLength = 6;
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(80, 35);
            this.txtX0.TabIndex = 8;
            this.txtX0.Text = "1";
            this.txtX0.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.txtX0.Leave += new System.EventHandler(this.TxtX0_Leave);
            // 
            // txtY0
            // 
            this.txtY0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtY0.Location = new System.Drawing.Point(229, 207);
            this.txtY0.MaxLength = 6;
            this.txtY0.Name = "txtY0";
            this.txtY0.Size = new System.Drawing.Size(80, 35);
            this.txtY0.TabIndex = 10;
            this.txtY0.Text = "-2";
            this.txtY0.TextChanged += new System.EventHandler(this.TxtY0_TextChanged);
            this.txtY0.Leave += new System.EventHandler(this.TxtY0_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(181, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y0";
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtX.Location = new System.Drawing.Point(532, 207);
            this.txtX.MaxLength = 6;
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(80, 35);
            this.txtX.TabIndex = 12;
            this.txtX.Text = "7";
            this.txtX.TextChanged += new System.EventHandler(this.TxtX_TextChanged);
            this.txtX.Leave += new System.EventHandler(this.TxtX_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(338, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "UPPER BOUND";
            // 
            // txtNumSteps
            // 
            this.txtNumSteps.AutoSize = true;
            this.txtNumSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNumSteps.Location = new System.Drawing.Point(14, 121);
            this.txtNumSteps.Name = "txtNumSteps";
            this.txtNumSteps.Size = new System.Drawing.Size(276, 29);
            this.txtNumSteps.TabIndex = 13;
            this.txtNumSteps.Text = "Number of grid steps: 10\r\n";
            // 
            // trcNumSteps
            // 
            this.trcNumSteps.Location = new System.Drawing.Point(12, 159);
            this.trcNumSteps.Maximum = 100;
            this.trcNumSteps.Name = "trcNumSteps";
            this.trcNumSteps.Size = new System.Drawing.Size(600, 45);
            this.trcNumSteps.TabIndex = 16;
            this.trcNumSteps.Value = 10;
            this.trcNumSteps.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(14, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 58);
            this.label4.TabIndex = 17;
            this.label4.Text = "Differential Equations\r\nCOMPUTATIONAL PRACTICUM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "25";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(446, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "75";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(12, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Equation: y\'=e^y-2/x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1242, 802);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trcNumSteps);
            this.Controls.Add(this.txtNumSteps);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtY0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAllMethods);
            this.Controls.Add(this.btnRungeKutta);
            this.Controls.Add(this.btnImprovedEuler);
            this.Controls.Add(this.btnEuler);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart1);
            this.MaximumSize = new System.Drawing.Size(1258, 840);
            this.MinimumSize = new System.Drawing.Size(1258, 580);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcNumSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button btnEuler;
        private System.Windows.Forms.Button btnImprovedEuler;
        private System.Windows.Forms.Button btnRungeKutta;
        private System.Windows.Forms.Button btnAllMethods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.TextBox txtY0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtNumSteps;
        private System.Windows.Forms.TrackBar trcNumSteps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

