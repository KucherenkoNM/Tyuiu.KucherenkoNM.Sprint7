namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    partial class FormCharts
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
            panelFilters_KNM = new Panel();
            comboBoxParametr_KNM = new ComboBox();
            labelParametr_KNM = new Label();
            comboBoxChartType_KNM = new ComboBox();
            labelChartType_KNM = new Label();
            labelFiltersTitle_KNM = new Label();
            panelChart_KNM = new Panel();
            chartMain_KNM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelFilters_KNM.SuspendLayout();
            panelChart_KNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartMain_KNM).BeginInit();
            SuspendLayout();
            // 
            // panelFilters_KNM
            // 
            panelFilters_KNM.Controls.Add(comboBoxParametr_KNM);
            panelFilters_KNM.Controls.Add(labelParametr_KNM);
            panelFilters_KNM.Controls.Add(comboBoxChartType_KNM);
            panelFilters_KNM.Controls.Add(labelChartType_KNM);
            panelFilters_KNM.Controls.Add(labelFiltersTitle_KNM);
            panelFilters_KNM.Dock = DockStyle.Left;
            panelFilters_KNM.Location = new Point(0, 0);
            panelFilters_KNM.Name = "panelFilters_KNM";
            panelFilters_KNM.Size = new Size(280, 450);
            panelFilters_KNM.TabIndex = 0;
            // 
            // comboBoxParametr_KNM
            // 
            comboBoxParametr_KNM.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxParametr_KNM.FormattingEnabled = true;
            comboBoxParametr_KNM.Location = new Point(24, 169);
            comboBoxParametr_KNM.Name = "comboBoxParametr_KNM";
            comboBoxParametr_KNM.Size = new Size(234, 28);
            comboBoxParametr_KNM.TabIndex = 2;
            // 
            // labelParametr_KNM
            // 
            labelParametr_KNM.AutoSize = true;
            labelParametr_KNM.Location = new Point(96, 146);
            labelParametr_KNM.Name = "labelParametr_KNM";
            labelParametr_KNM.Size = new Size(79, 20);
            labelParametr_KNM.TabIndex = 1;
            labelParametr_KNM.Text = "Параметр";
            // 
            // comboBoxChartType_KNM
            // 
            comboBoxChartType_KNM.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChartType_KNM.FormattingEnabled = true;
            comboBoxChartType_KNM.Location = new Point(24, 75);
            comboBoxChartType_KNM.Name = "comboBoxChartType_KNM";
            comboBoxChartType_KNM.Size = new Size(234, 28);
            comboBoxChartType_KNM.TabIndex = 2;
            // 
            // labelChartType_KNM
            // 
            labelChartType_KNM.AutoSize = true;
            labelChartType_KNM.Location = new Point(76, 52);
            labelChartType_KNM.Name = "labelChartType_KNM";
            labelChartType_KNM.Size = new Size(120, 20);
            labelChartType_KNM.TabIndex = 1;
            labelChartType_KNM.Text = "Тип диаграммы";
            // 
            // labelFiltersTitle_KNM
            // 
            labelFiltersTitle_KNM.AutoSize = true;
            labelFiltersTitle_KNM.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelFiltersTitle_KNM.Location = new Point(12, 9);
            labelFiltersTitle_KNM.Name = "labelFiltersTitle_KNM";
            labelFiltersTitle_KNM.Size = new Size(246, 28);
            labelFiltersTitle_KNM.TabIndex = 0;
            labelFiltersTitle_KNM.Text = "Параметры диаграммы";
            // 
            // panelChart_KNM
            // 
            panelChart_KNM.Controls.Add(chartMain_KNM);
            panelChart_KNM.Dock = DockStyle.Fill;
            panelChart_KNM.Location = new Point(280, 0);
            panelChart_KNM.Name = "panelChart_KNM";
            panelChart_KNM.Size = new Size(520, 450);
            panelChart_KNM.TabIndex = 1;
            // 
            // chartMain_KNM
            // 
            chartArea1.Name = "ChartArea1";
            chartMain_KNM.ChartAreas.Add(chartArea1);
            chartMain_KNM.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartMain_KNM.Legends.Add(legend1);
            chartMain_KNM.Location = new Point(0, 0);
            chartMain_KNM.Name = "chartMain_KNM";
            chartMain_KNM.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartMain_KNM.Series.Add(series1);
            chartMain_KNM.Size = new Size(520, 450);
            chartMain_KNM.TabIndex = 0;
            chartMain_KNM.Text = "chart1";
            // 
            // FormCharts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelChart_KNM);
            Controls.Add(panelFilters_KNM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCharts";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Диаграммы";
            panelFilters_KNM.ResumeLayout(false);
            panelFilters_KNM.PerformLayout();
            panelChart_KNM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartMain_KNM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFilters_KNM;
        private Panel panelChart_KNM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain_KNM;
        private ComboBox comboBoxChartType_KNM;
        private Label labelChartType_KNM;
        private Label labelFiltersTitle_KNM;
        private ComboBox comboBoxParametr_KNM;
        private Label labelParametr_KNM;
    }
}