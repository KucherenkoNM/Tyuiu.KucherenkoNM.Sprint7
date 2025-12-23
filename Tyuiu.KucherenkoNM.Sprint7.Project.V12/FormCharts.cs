using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;



namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    public partial class FormCharts : Form
    {
        private List<Computer> computers;

        public FormCharts(List<Computer> data)
        {
            InitializeComponent();
            computers = data;

            comboBoxChartType_KNM.Items.AddRange(new[] { "Столбчатая", "Круговая" });
            comboBoxParametr_KNM.Items.AddRange(new[] { "Средняя цена", "Количество" });

            comboBoxChartType_KNM.SelectedIndex = 0;
            comboBoxParametr_KNM.SelectedIndex = 0;
        }

        private void comboBoxChartType_KNM_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void comboBoxParametr_KNM_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }
        public Dictionary<string, int> CountByEvmType(List<Computer> computers)
        {
            return computers
                .GroupBy(c => c.EvmType)
                .ToDictionary(g => g.Key, g => g.Count());
        }


        private void UpdateChart()
        {
            if (comboBoxChartType_KNM.SelectedItem == null ||
                comboBoxParametr_KNM.SelectedItem == null)
                return;

            chartMain_KNM.Series.Clear();
            chartMain_KNM.ChartAreas.Clear();
            chartMain_KNM.Legends.Clear();

            var chartArea = new ChartArea();
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartMain_KNM.ChartAreas.Add(chartArea);

            var legend = new Legend();
            chartMain_KNM.Legends.Add(legend);

            string param = comboBoxParametr_KNM.SelectedItem.ToString();
            string chartType = comboBoxChartType_KNM.SelectedItem.ToString();

            var groups = computers
                .GroupBy(c => c.EvmType)
                .Select(g => new
                {
                    Type = g.Key,
                    Count = g.Count(),
                    AvgPrice = Math.Round((double)g.Average(x => x.Price), 2)
                })
                .ToList();

            if (chartType == "Круговая")
            {
                var series = new Series(param);
                series.ChartType = SeriesChartType.Pie;
                series.IsValueShownAsLabel = true;

                foreach (var g in groups)
                {
                    double value = param == "Средняя цена"
     ? g.AvgPrice
     : (double)g.Count;

                    series.Points.AddXY(g.Type, value);
                }

                chartMain_KNM.Series.Add(series);
            }
            else
            {
                foreach (var g in groups)
                {
                    var series = new Series(g.Type);
                    series.ChartType = SeriesChartType.Column;
                    series.IsValueShownAsLabel = true;

                    double value = param == "Средняя цена" ? g.AvgPrice : g.Count;
                    series.Points.AddXY(g.Type, value);

                    chartMain_KNM.Series.Add(series);
                }
            }
        }

    }
}

