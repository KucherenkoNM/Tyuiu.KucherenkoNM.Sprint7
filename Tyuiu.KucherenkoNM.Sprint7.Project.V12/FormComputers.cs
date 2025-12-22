#nullable disable
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    public partial class FormComputers : Form
    {
        private readonly BindingSource bindingSource = new BindingSource();
        private readonly List<Computer> computers_KNM;

        public FormComputers(List<Computer> computers)
        {
            InitializeComponent();

            computers_KNM = computers ?? new List<Computer>();

            bindingSource.DataSource = computers_KNM;
            dataGridViewComputers_KNM.DataSource = bindingSource;

            FillEvmTypes();

            dataGridViewComputers_KNM.CellFormatting += DataGridViewComputers_KNM_CellFormatting;
        }

        private void FillEvmTypes()
        {
            var types = computers_KNM
                .Where(c => !string.IsNullOrWhiteSpace(c.EvmType))
                .Select(c => c.EvmType)
                .Distinct()
                .ToList();

            comboBoxEvmType_KNM.DataSource = types;
            comboBoxEvmType_KNM.SelectedIndex = -1;
        }

        private void ApplyFilters()
        {
            IEnumerable<Computer> filtered = computers_KNM;

            string searchText = textBoxSearch_KNM.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                string text = searchText.ToLower();

                filtered = filtered.Where(c =>
                    c.ComputerId.ToString().Contains(text) ||
                    (!string.IsNullOrEmpty(c.EvmType) && c.EvmType.ToLower().Contains(text)) ||
                    c.ManufacturerId.ToString().Contains(text) ||
                    c.RetailerId.ToString().Contains(text) ||
                    c.ProcessorId.ToString().Contains(text) ||
                    (!string.IsNullOrEmpty(c.StorageType) && c.StorageType.ToLower().Contains(text)) ||
                    c.Price.ToString().Contains(text) ||
                    c.ReleaseDate.ToShortDateString().Contains(text)
                );
            }

            if (comboBoxEvmType_KNM.SelectedItem != null)
            {
                string type = comboBoxEvmType_KNM.SelectedItem.ToString();
                filtered = filtered.Where(c => c.EvmType == type);
            }

            if (decimal.TryParse(textBoxPriceFrom_KNM.Text, out decimal priceFrom))
                filtered = filtered.Where(c => c.Price >= priceFrom);

            if (decimal.TryParse(textBoxPriceTo_KNM.Text, out decimal priceTo))
                filtered = filtered.Where(c => c.Price <= priceTo);

            bindingSource.DataSource = filtered.ToList();
            dataGridViewComputers_KNM.ClearSelection();
        }

        private void buttonAddComputer_KNM_Click(object sender, EventArgs e)
        {
            bindingSource.Add(new Computer());
        }

        private void buttonDeleteComputer_KNM_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current != null)
                bindingSource.RemoveCurrent();
        }

        private void buttonResetFilters_KNM_Click(object sender, EventArgs e)
        {
            textBoxSearch_KNM.Clear();
            textBoxPriceFrom_KNM.Clear();
            textBoxPriceTo_KNM.Clear();
            comboBoxEvmType_KNM.SelectedIndex = -1;

            bindingSource.DataSource = computers_KNM;
        }

        private void textBoxSearch_KNM_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
            dataGridViewComputers_KNM.Refresh();
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

        private void DataGridViewComputers_KNM_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch_KNM.Text))
                return;

            if (e.Value == null)
                return;

            string cellText = e.Value.ToString();
            string search = textBoxSearch_KNM.Text;

            if (!string.IsNullOrEmpty(cellText) &&
                cellText.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                e.CellStyle.BackColor = Color.LightYellow;
                e.CellStyle.ForeColor = Color.Black;
            }
            else
            {
                e.CellStyle.BackColor = Color.White;
                e.CellStyle.ForeColor = Color.Black;
            }
        }
    }
}
