#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    public partial class FormStatistics : Form
    {
        private List<Computer> computers_KNM = new();

        public FormStatistics()
        {
            InitializeComponent();
        }

        public void SetData(List<Computer> computers)
        {
            computers_KNM = computers;
            FillEvmTypes();
            UpdateStatistics();
        }

        private void FillEvmTypes()
        {
            comboBoxEvmType_KNM.Items.Clear();
            comboBoxEvmType_KNM.Items.Add("Все");

            var types = computers_KNM
                .Where(c => !string.IsNullOrWhiteSpace(c.EvmType))
                .Select(c => c.EvmType)
                .Distinct()
                .ToList();

            foreach (var t in types)
                comboBoxEvmType_KNM.Items.Add(t);

            comboBoxEvmType_KNM.SelectedIndex = 0;
        }

        private void comboBoxEvmType_KNM_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            var filtered = computers_KNM.AsEnumerable();

            if (comboBoxEvmType_KNM.SelectedIndex > 0)
            {
                string type = comboBoxEvmType_KNM.SelectedItem.ToString();
                filtered = filtered.Where(c => c.EvmType == type);
            }

            var list = filtered.ToList();

            labelCountValue_KNM.Text = StatisticsService.Count(list).ToString();
            labelMinValue_KNM.Text = list.Any() ? StatisticsService.MinPrice(list).ToString("0.00") : "0";
            labelMaxValue_KNM.Text = list.Any() ? StatisticsService.MaxPrice(list).ToString("0.00") : "0";
            labelAverageValue_KNM.Text = list.Any() ? StatisticsService.AveragePrice(list).ToString("0.00") : "0";
            labelSumValue_KNM.Text = list.Any() ? StatisticsService.SumPrice(list).ToString("0.00") : "0";
        }
    }
}
