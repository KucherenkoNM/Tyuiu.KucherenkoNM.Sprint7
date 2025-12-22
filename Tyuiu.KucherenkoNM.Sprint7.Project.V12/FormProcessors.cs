using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    public partial class FormProcessors : Form, ICsvOpenable
    {
        private readonly ProcessorService processorService_KNM = new ProcessorService();
        private List<Processor> processors_KNM = new List<Processor>();

        public FormProcessors()
        {
            InitializeComponent();
        }

        public void OpenFromCsv(string filePath)
        {
            processors_KNM = processorService_KNM.LoadFromCsv(filePath);
            dataGridViewProcessors_KNM.DataSource = processors_KNM;

            comboBoxManufacturer_KNM.Items.Clear();
            comboBoxManufacturer_KNM.Items.Add("");

            foreach (var m in processors_KNM.Select(p => p.Manufacturer).Distinct())
                comboBoxManufacturer_KNM.Items.Add(m);
        }

        private void textBoxSearch_KNM_TextChanged(object sender, System.EventArgs e)
        {
            ApplyFilters();
        }

        private void comboBoxManufacturer_KNM_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ApplyFilters();
        }

        private void textBoxFrequencyFrom_KNM_TextChanged(object sender, System.EventArgs e)
        {
            ApplyFilters();
        }

        private void textBoxFrequencyTo_KNM_TextChanged(object sender, System.EventArgs e)
        {
            ApplyFilters();
        }

        private void buttonResetFilters_KNM_Click(object sender, System.EventArgs e)
        {
            textBoxSearch_KNM.Clear();
            comboBoxManufacturer_KNM.SelectedIndex = -1;
            textBoxFrequencyFrom_KNM.Clear();
            textBoxFrequencyTo_KNM.Clear();
            dataGridViewProcessors_KNM.DataSource = processors_KNM;
        }

        private void ApplyFilters()
        {
            decimal? from = null;
            decimal? to = null;

            if (decimal.TryParse(textBoxFrequencyFrom_KNM.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out var f))
                from = f;

            if (decimal.TryParse(textBoxFrequencyTo_KNM.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out var t))
                to = t;

            dataGridViewProcessors_KNM.DataSource =
                processorService_KNM.Filter(
                    processors_KNM,
                    textBoxSearch_KNM.Text,
                    comboBoxManufacturer_KNM.Text,
                    from,
                    to);
        }
    }
}
