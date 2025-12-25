#nullable disable
using System;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    public partial class FormStatistics : Form, IEditableData
    {
        private DataManager dataManager;

        public FormStatistics()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        public void SetData(DataManager manager)
        {
            dataManager = manager;

            comboBoxEvmType_KNM.Items.Clear();
            comboBoxEvmType_KNM.Items.Add("Все");

            foreach (var t in dataManager.Computers.Select(c => c.EvmType).Distinct())
                comboBoxEvmType_KNM.Items.Add(t);

            comboBoxEvmType_KNM.SelectedIndex = 0;
            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            if (dataManager == null)
                return;

            var computers = dataManager.Computers.AsEnumerable();

            if (comboBoxEvmType_KNM.SelectedItem != null &&
                comboBoxEvmType_KNM.SelectedItem.ToString() != "Все")
            {
                computers = computers.Where(c =>
                    c.EvmType == comboBoxEvmType_KNM.SelectedItem.ToString());
            }

            var list = computers.ToList();

            labelCountValue_KNM.Text = list.Count.ToString();
            labelAverageValue_KNM.Text = StatisticsService.AveragePrice(list).ToString("0.00");
            labelMaxValue_KNM.Text = StatisticsService.MaxPrice(list).ToString("0.00");
            labelMinValue_KNM.Text = StatisticsService.MinPrice(list).ToString("0.00");
            labelSumValue_KNM.Text = StatisticsService.SumPrice(list).ToString("0.00");
        }

        private void comboBoxEvmType_KNM_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        public void Load(string path) { }
        public void Save(string path) { }
        public void RefreshData() => UpdateStatistics();
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
