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
    public partial class FormComputers : Form, ICsvOpenable
    {
        private readonly BindingSource bindingSourceComputers_KNM = new BindingSource();
        private List<Computer> computers_KNM = new();

        public FormComputers()
        {
            InitializeComponent();

            dataGridViewComputers_KNM.AutoGenerateColumns = true;
            dataGridViewComputers_KNM.AllowUserToAddRows = false;
            dataGridViewComputers_KNM.DataSource = bindingSourceComputers_KNM;

            dataGridViewComputers_KNM.CellFormatting += DataGridViewComputers_KNM_CellFormatting;
        }

        public void OpenFromCsv(string filePath)
        {
            var service = new ComputerService();
            computers_KNM = service.LoadFromCsv(filePath);

            bindingSourceComputers_KNM.DataSource = computers_KNM;
            bindingSourceComputers_KNM.ResetBindings(false);

            FillEvmTypes();
        }

        private void FillEvmTypes()
        {
            comboBoxEvmType_KNM.Items.Clear();
            comboBoxEvmType_KNM.Items.Add("Все");

            var types = computers_KNM
                .Where(c => !string.IsNullOrWhiteSpace(c.EvmType))
                .Select(c => c.EvmType)
                .Distinct();

            foreach (var t in types)
                comboBoxEvmType_KNM.Items.Add(t);

            comboBoxEvmType_KNM.SelectedIndex = 0;
        }

        private void ApplyFilters()
        {
            IEnumerable<Computer> filtered = computers_KNM;

            string searchText = textBoxSearch_KNM.Text;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                filtered = filtered.Where(c =>
                    c.ComputerId.ToString().Contains(searchText) ||
                    (!string.IsNullOrEmpty(c.EvmType) && c.EvmType.Contains(searchText, StringComparison.OrdinalIgnoreCase)) ||
                    c.ManufacturerId.ToString().Contains(searchText) ||
                    c.RetailerId.ToString().Contains(searchText) ||
                    c.ProcessorId.ToString().Contains(searchText) ||
                    (!string.IsNullOrEmpty(c.StorageType) && c.StorageType.Contains(searchText, StringComparison.OrdinalIgnoreCase)) ||
                    c.Price.ToString().Contains(searchText) ||
                    c.ReleaseDate.ToShortDateString().Contains(searchText)
                );
            }

            if (comboBoxEvmType_KNM.SelectedIndex > 0)
            {
                string type = comboBoxEvmType_KNM.SelectedItem.ToString();
                filtered = filtered.Where(c => c.EvmType == type);
            }

            if (decimal.TryParse(textBoxPriceFrom_KNM.Text, out decimal priceFrom))
                filtered = filtered.Where(c => c.Price >= priceFrom);

            if (decimal.TryParse(textBoxPriceTo_KNM.Text, out decimal priceTo))
                filtered = filtered.Where(c => c.Price <= priceTo);

            bindingSourceComputers_KNM.DataSource = filtered.ToList();
            bindingSourceComputers_KNM.ResetBindings(false);
        }

        private void textBoxSearch_KNM_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void textBoxPriceFrom_KNM_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void textBoxPriceTo_KNM_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void comboBoxEvmType_KNM_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void buttonAddComputer_KNM_Click(object sender, EventArgs e)
        {
            bindingSourceComputers_KNM.Add(new Computer());
        }

        private void buttonDeleteComputer_KNM_Click(object sender, EventArgs e)
        {
            if (bindingSourceComputers_KNM.Current != null)
                bindingSourceComputers_KNM.RemoveCurrent();
        }

        private void buttonResetFilters_KNM_Click(object sender, EventArgs e)
        {
            textBoxSearch_KNM.Clear();
            textBoxPriceFrom_KNM.Clear();
            textBoxPriceTo_KNM.Clear();
            comboBoxEvmType_KNM.SelectedIndex = 0;

            bindingSourceComputers_KNM.DataSource = computers_KNM;
            bindingSourceComputers_KNM.ResetBindings(false);
        }

        private void DataGridViewComputers_KNM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null)
                return;

            var row = dataGridViewComputers_KNM.Rows[e.RowIndex];
            var item = row.DataBoundItem as Computer;
            if (item == null)
                return;

            bool highlight = false;

            if (!string.IsNullOrWhiteSpace(textBoxSearch_KNM.Text))
                highlight |= e.Value.ToString()
                    .IndexOf(textBoxSearch_KNM.Text, StringComparison.OrdinalIgnoreCase) >= 0;

            if (comboBoxEvmType_KNM.SelectedItem != null)
                highlight |= item.EvmType == comboBoxEvmType_KNM.SelectedItem.ToString();

            if (highlight)
            {
                row.DefaultCellStyle.BackColor = Color.LightYellow;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
        }
    }
}
