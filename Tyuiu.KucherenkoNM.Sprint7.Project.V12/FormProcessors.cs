#nullable disable
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    public partial class FormProcessors : Form, ICsvOpenable
    {
        private readonly ProcessorService processorService = new ProcessorService();
        private readonly BindingSource bindingSource = new BindingSource();
        private List<Processor> processors = new();

        public FormProcessors()
        {
            InitializeComponent();

            dataGridViewProcessors_KNM.AutoGenerateColumns = true;
            dataGridViewProcessors_KNM.AllowUserToAddRows = false;
            dataGridViewProcessors_KNM.DataSource = bindingSource;

            dataGridViewProcessors_KNM.CellFormatting += DataGridViewProcessors_KNM_CellFormatting;
        }

        public void OpenFromCsv(string filePath)
        {
            processors = processorService.LoadFromCsv(filePath);

            bindingSource.DataSource = processors;

            FillManufacturers();
        }

        private void FillManufacturers()
        {
            var manufacturers = processors
                .Select(p => p.Manufacturer)
                .Where(m => !string.IsNullOrWhiteSpace(m))
                .Distinct()
                .ToList();

            manufacturers.Insert(0, "Все");

            comboBoxManufacturer_KNM.DataSource = manufacturers;
            comboBoxManufacturer_KNM.SelectedIndex = 0;
        }

        private void ApplyFilters()
        {
            IEnumerable<Processor> filtered = processors;

            string searchText = textBoxSearch_KNM.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                string text = searchText.ToLower();

                filtered = filtered.Where(p =>
                    p.Id.ToString().Contains(text) ||
                    p.Name.ToLower().Contains(text) ||
                    p.Manufacturer.ToLower().Contains(text) ||
                    p.Cores.ToString().Contains(text)
                );
            }

            if (comboBoxManufacturer_KNM.SelectedItem != null &&
                comboBoxManufacturer_KNM.SelectedItem.ToString() != "Все")
            {
                string manufacturer = comboBoxManufacturer_KNM.SelectedItem.ToString();
                filtered = filtered.Where(p => p.Manufacturer == manufacturer);
            }

            if (int.TryParse(textBoxCoresFrom_KNM.Text, out int from))
                filtered = filtered.Where(p => p.Cores >= from);

            if (int.TryParse(textBoxCoresTo_KNM.Text, out int to))
                filtered = filtered.Where(p => p.Cores <= to);

            bindingSource.DataSource = filtered.ToList();
            dataGridViewProcessors_KNM.ClearSelection();
        }

        private void textBoxSearch_KNM_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void comboBoxManufacturer_KNM_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void textBoxCoresFrom_KNM_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void textBoxCoresTo_KNM_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void buttonResetFilters_KNM_Click(object sender, EventArgs e)
        {
            textBoxSearch_KNM.Clear();
            textBoxCoresFrom_KNM.Clear();
            textBoxCoresTo_KNM.Clear();
            comboBoxManufacturer_KNM.SelectedIndex = 0;

            bindingSource.DataSource = processors;
        }

        private void DataGridViewProcessors_KNM_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
                return;

            bool highlight = false;

            if (!string.IsNullOrWhiteSpace(textBoxSearch_KNM.Text))
            {
                highlight = e.Value.ToString()
                    .IndexOf(textBoxSearch_KNM.Text, StringComparison.OrdinalIgnoreCase) >= 0;
            }

            if (comboBoxManufacturer_KNM.SelectedItem != null &&
                comboBoxManufacturer_KNM.SelectedItem.ToString() != "Все" &&
                e.Value.ToString()
                    .Equals(comboBoxManufacturer_KNM.SelectedItem.ToString(),
                        StringComparison.OrdinalIgnoreCase))
            {
                highlight = true;
            }

            e.CellStyle.BackColor = highlight ? Color.LightYellow : Color.White;
            e.CellStyle.ForeColor = Color.Black;
        }
        private void buttonAddProcessor_KNM_Click(object sender, EventArgs e)
        {
            var p = new Processor();
            processors.Add(p);
            ApplyFilters();
            bindingSource.Position = bindingSource.IndexOf(p);
        }

        private void buttonDeleteProcessor_KNM_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Processor p)
            {
                processors.Remove(p);
                ApplyFilters();
            }
        }

    }
}
