namespace DoubleT.GUI
{
    partial class fStatictical
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
            FastReport.DataVisualization.Charting.ChartArea chartArea1 = new FastReport.DataVisualization.Charting.ChartArea();
            FastReport.DataVisualization.Charting.Series series1 = new FastReport.DataVisualization.Charting.Series();
            FastReport.DataVisualization.Charting.Title title1 = new FastReport.DataVisualization.Charting.Title();
            FastReport.DataVisualization.Charting.ChartArea chartArea2 = new FastReport.DataVisualization.Charting.ChartArea();
            FastReport.DataVisualization.Charting.Series series2 = new FastReport.DataVisualization.Charting.Series();
            labelFrom = new Label();
            labelTo = new Label();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            panel1 = new Panel();
            labelTotal = new Label();
            textBoxTotal = new TextBox();
            btnStatic = new Button();
            chart_report = new FastReport.DataVisualization.Charting.Chart();
            chart_car = new FastReport.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_report).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_car).BeginInit();
            SuspendLayout();
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.Location = new Point(40, 37);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(33, 20);
            labelFrom.TabIndex = 0;
            labelFrom.Text = "Từ :";
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.Location = new Point(40, 140);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(43, 20);
            labelTo.TabIndex = 1;
            labelTo.Text = "Đến :";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(40, 64);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(250, 27);
            dtpFrom.TabIndex = 2;
            dtpFrom.Value = new DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(40, 163);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(250, 27);
            dtpTo.TabIndex = 3;
            dtpTo.Value = new DateTime(2100, 1, 1, 0, 0, 0, 0);
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTotal);
            panel1.Controls.Add(textBoxTotal);
            panel1.Controls.Add(btnStatic);
            panel1.Controls.Add(labelFrom);
            panel1.Controls.Add(dtpTo);
            panel1.Controls.Add(dtpFrom);
            panel1.Controls.Add(labelTo);
            panel1.Location = new Point(33, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 410);
            panel1.TabIndex = 4;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(40, 220);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(50, 20);
            labelTotal.TabIndex = 6;
            labelTotal.Text = "Tổng :";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(40, 243);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(250, 27);
            textBoxTotal.TabIndex = 5;
            // 
            // btnStatic
            // 
            btnStatic.Location = new Point(316, 361);
            btnStatic.Name = "btnStatic";
            btnStatic.Size = new Size(94, 29);
            btnStatic.TabIndex = 4;
            btnStatic.Text = "Static";
            btnStatic.UseVisualStyleBackColor = true;
            btnStatic.Click += btnStatic_Click;
            // 
            // chart_report
            // 
            chartArea1.Name = "Date";
            chart_report.ChartAreas.Add(chartArea1);
            chart_report.Location = new Point(496, 35);
            chart_report.Name = "chart_report";
            series1.ChartArea = "Date";
            series1.ChartType = FastReport.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = Color.FromArgb(0, 0, 192);
            series1.Name = "Turnover";
            series1.XValueMember = "Date";
            series1.YValueMembers = "Turnover";
            chart_report.Series.Add(series1);
            chart_report.Size = new Size(634, 273);
            chart_report.TabIndex = 5;
            chart_report.Text = "chart1";
            title1.Name = "Turnover by time period";
            chart_report.Titles.Add(title1);
            // 
            // chart_car
            // 
            chartArea2.Name = "Amount";
            chart_car.ChartAreas.Add(chartArea2);
            chart_car.Location = new Point(496, 327);
            chart_car.Name = "chart_car";
            series2.ChartArea = "Amount";
            series2.LabelForeColor = Color.FromArgb(0, 0, 192);
            series2.Name = "Car";
            series2.XValueMember = "Car";
            series2.YValueMembers = "Amount";
            chart_car.Series.Add(series2);
            chart_car.Size = new Size(634, 315);
            chart_car.TabIndex = 6;
            chart_car.Text = "chart1";
            // 
            // fStatictical
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 678);
            Controls.Add(chart_car);
            Controls.Add(chart_report);
            Controls.Add(panel1);
            Name = "fStatictical";
            Text = "fStatictical";
            Load += fStatictical_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_report).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_car).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelFrom;
        private Label labelTo;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Panel panel1;
        private Button btnStatic;
        private Label labelTotal;
        private TextBox textBoxTotal;
        private FastReport.DataVisualization.Charting.Chart chart_report;
        private FastReport.DataVisualization.Charting.Chart chart_turnover;
        private FastReport.DataVisualization.Charting.Chart chart_car;
    }
}