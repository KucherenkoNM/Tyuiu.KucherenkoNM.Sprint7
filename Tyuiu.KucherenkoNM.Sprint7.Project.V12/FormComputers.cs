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
    public partial class FormComputers : Form, IEditableData
    {
        private DataManager dataManager;
        private readonly BindingSource bindingSource = new BindingSource();

        public FormComputers()
        {
            InitializeComponent();
            KeyPreview = true;

            dataGridViewComputers_KNM.AutoGenerateColumns = true;
            dataGridViewComputers_KNM.AllowUserToAddRows = false;
            dataGridViewComputers_KNM.RowHeadersVisible = true;
            dataGridViewComputers_KNM.DataSource = bindingSource;

            dataGridViewComputers_KNM.CellFormatting += DataGridViewComputers_KNM_CellFormatting;
        }

        public void SetData(DataManager manager)
        {
            dataManager = manager;
            RefreshData();
            FillEvmTypes();
        }

        public void Load(string path)
        {
            dataManager.ComputersPath = path;
            dataManager.LoadAll();
            RefreshData();
            FillEvmTypes();
            UiNotifier.ShowLoaded();
        }

        public void Save(string path)
        {
            dataManager.ComputersPath = path;
            dataManager.SaveAll();
            UiNotifier.ShowSaved();
        }

        public void RefreshData()
        {
            bindingSource.DataSource = dataManager.Computers.ToList();
            dataGridViewComputers_KNM.ClearSelection();
        }

        private void FillEvmTypes()
        {
            var evmTypes = dataManager.Computers
                .Select(c => c.EvmType)
                .Where(t => !string.IsNullOrWhiteSpace(t))
                .Distinct()
                .OrderBy(t => t)
                .ToList();

            evmTypes.Insert(0, "Все");

            comboBoxEvmType_KNM.DataSource = null;
            comboBoxEvmType_KNM.DataSource = evmTypes;
            comboBoxEvmType_KNM.SelectedIndex = 0;
        }

        private void ApplyFilters()
        {
            IEnumerable<Computer> filtered = dataManager.Computers;

            string search = textBoxSearch_KNM.Text;
            if (!string.IsNullOrWhiteSpace(search))
            {
                string s = search.ToLower();
                filtered = filtered.Where(c =>
                    c.Id.ToString().Contains(s) ||
                    c.EvmType?.ToLower().Contains(s) == true ||
                    c.ManufacturerId.ToString().Contains(s) ||
                    c.RetailerId.ToString().Contains(s) ||
                    c.ProcessorId.ToString().Contains(s) ||
                    c.StorageType?.ToLower().Contains(s) == true ||
                    c.Price.ToString().Contains(s) ||
                    c.ReleaseDate.ToShortDateString().Contains(s)
                );
            }

            string evmType = comboBoxEvmType_KNM.SelectedItem as string;
            if (!string.IsNullOrEmpty(evmType) && evmType != "Все")
                filtered = filtered.Where(c => c.EvmType == evmType);

            if (decimal.TryParse(textBoxPriceFrom_KNM.Text, out decimal from))
                filtered = filtered.Where(c => c.Price >= from);

            if (decimal.TryParse(textBoxPriceTo_KNM.Text, out decimal to))
                filtered = filtered.Where(c => c.Price <= to);

            bindingSource.DataSource = filtered.ToList();
            dataGridViewComputers_KNM.ClearSelection();
        }

        private void buttonAddComputer_KNM_Click(object sender, EventArgs e)
        {
            var comp = new Computer
            {
                Id = dataManager.Computers.Any()
                    ? dataManager.Computers.Max(c => c.Id) + 1
                    : 1
            };

            dataManager.Computers.Add(comp);
            RefreshData();
            dataGridViewComputers_KNM.Rows[^1].Selected = true;
        }

        private void buttonDeleteComputer_KNM_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Computer c)
            {
                dataManager.Computers.Remove(c);
                ApplyFilters();
            }
        }

        private void buttonResetFilters_KNM_Click(object sender, EventArgs e)
        {
            textBoxSearch_KNM.Clear();
            textBoxPriceFrom_KNM.Clear();
            textBoxPriceTo_KNM.Clear();
            comboBoxEvmType_KNM.SelectedIndex = 0;
            RefreshData();
        }

        private void textBoxSearch_KNM_TextChanged(object sender, EventArgs e) => ApplyFilters();
        private void comboBoxEvmType_KNM_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void textBoxPriceFrom_KNM_TextChanged(object sender, EventArgs e) => ApplyFilters();
        private void textBoxPriceTo_KNM_TextChanged(object sender, EventArgs e) => ApplyFilters();

        private void DataGridViewComputers_KNM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
                return;

            bool highlight =
                !string.IsNullOrWhiteSpace(textBoxSearch_KNM.Text) &&
                e.Value.ToString().IndexOf(textBoxSearch_KNM.Text, StringComparison.OrdinalIgnoreCase) >= 0;

            e.CellStyle.BackColor = highlight ? Color.LightYellow : Color.White;
            e.CellStyle.ForeColor = Color.Black;
        }
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
