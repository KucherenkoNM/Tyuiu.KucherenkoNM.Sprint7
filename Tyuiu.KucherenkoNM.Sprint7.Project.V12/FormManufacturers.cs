using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    public partial class FormManufacturers : Form, ICsvOpenable
    {
        private readonly ManufacturerService manufacturerService_KNM = new();
        private readonly BindingSource bindingSourceManufacturer_KNM = new();
        private List<Manufacturer> manufacturers_KNM = new();

        public FormManufacturers()
        {
            InitializeComponent();

            dataGridViewManufacturer_KNM.AutoGenerateColumns = true;
            dataGridViewManufacturer_KNM.AllowUserToAddRows = false;
            dataGridViewManufacturer_KNM.RowHeadersVisible = true;
            dataGridViewManufacturer_KNM.DataSource = bindingSourceManufacturer_KNM;

            dataGridViewManufacturer_KNM.CellFormatting += DataGridViewManufacturer_KNM_CellFormatting;
        }

        public void OpenFromCsv(string filePath)
        {
            manufacturers_KNM = manufacturerService_KNM.LoadFromCsv(filePath);
            bindingSourceManufacturer_KNM.DataSource = manufacturers_KNM;

            comboBoxCountry_KNM.Items.Clear();
            comboBoxCountry_KNM.Items.Add("Все");

            foreach (var c in manufacturers_KNM.Select(m => m.Country).Distinct())
                comboBoxCountry_KNM.Items.Add(c);

            comboBoxCountry_KNM.SelectedIndex = 0;
        }

        private void buttonAddManufacturer_KNM_Click(object sender, EventArgs e)
        {
            bindingSourceManufacturer_KNM.Add(new Manufacturer());
        }

        private void buttonDeleteManufacturer_KNM_Click(object sender, EventArgs e)
        {
            if (bindingSourceManufacturer_KNM.Current != null)
                bindingSourceManufacturer_KNM.RemoveCurrent();
        }

        private void textBoxSearch_KNM_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void comboBoxCountry_KNM_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void buttonResetFilters_KNM_Click(object sender, EventArgs e)
        {
            textBoxSearch_KNM.Clear();
            comboBoxCountry_KNM.SelectedIndex = 0;
            bindingSourceManufacturer_KNM.DataSource = manufacturers_KNM;
        }

        private void ApplyFilters()
        {
            IEnumerable<Manufacturer> filtered = manufacturers_KNM;

            if (!string.IsNullOrWhiteSpace(textBoxSearch_KNM.Text))
            {
                var t = textBoxSearch_KNM.Text.ToLower();
                filtered = filtered.Where(m =>
                    m.ManufacturerId.ToString().Contains(t) ||
                    m.Name.ToLower().Contains(t) ||
                    m.Country.ToLower().Contains(t));
            }

            if (comboBoxCountry_KNM.SelectedIndex > 0)
            {
                var c = comboBoxCountry_KNM.SelectedItem.ToString();
                filtered = filtered.Where(m => m.Country == c);
            }

            bindingSourceManufacturer_KNM.DataSource = filtered.ToList();
            dataGridViewManufacturer_KNM.ClearSelection();
        }

        private void DataGridViewManufacturer_KNM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
                return;

            var value = e.Value.ToString() ?? "";

            if (!string.IsNullOrWhiteSpace(textBoxSearch_KNM.Text) &&
                value.Contains(textBoxSearch_KNM.Text, StringComparison.OrdinalIgnoreCase))
            {
                e.CellStyle.BackColor = Color.LightYellow;
            }
            else if (comboBoxCountry_KNM.SelectedIndex > 0 &&
                     value.Contains(comboBoxCountry_KNM.SelectedItem.ToString(),
                         StringComparison.OrdinalIgnoreCase))
            {
                e.CellStyle.BackColor = Color.LightYellow;
            }
            else
            {
                e.CellStyle.BackColor = Color.White;
            }
        }
    }
}
