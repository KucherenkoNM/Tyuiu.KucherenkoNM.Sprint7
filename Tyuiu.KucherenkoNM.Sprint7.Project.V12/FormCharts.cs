using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    public partial class FormCharts : Form, IEditableData
    {
        private DataManager dataManager;

        public FormCharts()
        {
            InitializeComponent();

            comboBoxChartType_KNM.Items.AddRange(new[]
            {
                "Столбчатая",
                "Круговая"
            });

            comboBoxParametr_KNM.Items.AddRange(new[]
            {
                "Количество по типу ЭВМ",
                "Средняя цена по типу ЭВМ"
            });

            comboBoxChartType_KNM.SelectedIndex = 0;
            comboBoxParametr_KNM.SelectedIndex = 0;

            comboBoxChartType_KNM.SelectedIndexChanged += ComboChanged;
            comboBoxParametr_KNM.SelectedIndexChanged += ComboChanged;
        }

        public void SetData(DataManager manager)
        {
            dataManager = manager;
            BuildChart();
        }

        public void Load(string path) { }
        public void Save(string path) { }
        public void RefreshData() => BuildChart();

        private void ComboChanged(object sender, EventArgs e)
        {
            BuildChart();
        }

        private void BuildChart()
        {
            if (dataManager == null)
                return;

            if (comboBoxChartType_KNM.SelectedItem == null ||
                comboBoxParametr_KNM.SelectedItem == null)
                return;

            chartMain_KNM.Series.Clear();
            chartMain_KNM.ChartAreas.Clear();
            chartMain_KNM.Legends.Clear();

            var area = new ChartArea("Main");
            area.AxisX.Interval = 1;
            chartMain_KNM.ChartAreas.Add(area);

            chartMain_KNM.Legends.Add(new Legend());

            var chartType = comboBoxChartType_KNM.SelectedItem.ToString();
            var param = comboBoxParametr_KNM.SelectedItem.ToString();

            var groups = dataManager.Computers
                .GroupBy(c => c.EvmType)
                .Select(g => new
                {
                    Name = g.Key,
                    Count = g.Count(),
                    AvgPrice = (double)g.Average(x => x.Price)
                })
                .ToList();

            if (!groups.Any())
                return;

            if (chartType == "Круговая")
            {
                var series = new Series
                {
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true
                };

                foreach (var g in groups)
                {
                    double value = param.StartsWith("Количество")
                        ? g.Count
                        : g.AvgPrice;

                    var p = series.Points.Add(value);
                    p.LegendText = g.Name;
                    p.Label = value.ToString("0.##");
                }

                chartMain_KNM.Series.Add(series);
                return;
            }

            foreach (var g in groups)
            {
                double value = param.StartsWith("Количество")
                    ? g.Count
                    : g.AvgPrice;

                var series = new Series(g.Name)
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true
                };

                int index = series.Points.AddXY(param, value);
                series.Points[index].Label = value.ToString("0.##");

                chartMain_KNM.Series.Add(series);
            }
        }

    }
}
