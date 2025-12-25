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
    public partial class FormProcessors : Form, IEditableData
    {
        private DataManager dataManager;
        private readonly BindingSource bindingSource = new BindingSource();

        public FormProcessors()
        {
            InitializeComponent();
            KeyPreview = true;

            dataGridViewProcessors_KNM.AutoGenerateColumns = true;
            dataGridViewProcessors_KNM.AllowUserToAddRows = false;
            dataGridViewProcessors_KNM.RowHeadersVisible = true;
            dataGridViewProcessors_KNM.DataSource = bindingSource;

            dataGridViewProcessors_KNM.CellFormatting += DataGridViewProcessors_KNM_CellFormatting;

            textBoxCoresFrom_KNM.TextChanged += (_, __) => ApplyFilters();
            textBoxCoresTo_KNM.TextChanged += (_, __) => ApplyFilters();
        }

        public void SetData(DataManager manager)
        {
            dataManager = manager;
            RefreshData();
            UpdateManufacturerFilter();
        }

        public void Load(string path)
        {
            dataManager.ProcessorsPath = path;
            dataManager.LoadProcessors(path);
            RefreshData();
            UpdateManufacturerFilter();
            UiNotifier.ShowLoaded();
        }

        public void Save(string path)
        {
            dataManager.ProcessorsPath = path;
            dataManager.SaveProcessors(path);
            UiNotifier.ShowSaved();
        }

        public void RefreshData()
        {
            bindingSource.DataSource = dataManager.Processors.ToList();
            dataGridViewProcessors_KNM.ClearSelection();
        }

        private void UpdateManufacturerFilter()
        {
            var manufacturers = dataManager.Processors
                .Where(p => !string.IsNullOrWhiteSpace(p.Manufacturer))
                .Select(p => p.Manufacturer)
                .Distinct()
                .OrderBy(m => m)
                .ToList();

            manufacturers.Insert(0, "Все");

            comboBoxManufacturer_KNM.DataSource = null;
            comboBoxManufacturer_KNM.DataSource = manufacturers;
            comboBoxManufacturer_KNM.SelectedIndex = 0;
        }

        private void ApplyFilters()
        {
            IEnumerable<Processor> filtered = dataManager.Processors;

            string search = textBoxSearch_KNM.Text;
            if (!string.IsNullOrWhiteSpace(search))
            {
                string s = search.ToLower();
                filtered = filtered.Where(p =>
                    p.Id.ToString().Contains(s) ||
                    p.Name?.ToLower().Contains(s) == true ||
                    p.Manufacturer?.ToLower().Contains(s) == true ||
                    p.Cores.ToString().Contains(s)
                );
            }

            string manufacturer = comboBoxManufacturer_KNM.SelectedItem as string;
            if (!string.IsNullOrEmpty(manufacturer) && manufacturer != "Все")
                filtered = filtered.Where(p => p.Manufacturer == manufacturer);

            if (int.TryParse(textBoxCoresFrom_KNM.Text, out int from))
                filtered = filtered.Where(p => p.Cores >= from);

            if (int.TryParse(textBoxCoresTo_KNM.Text, out int to))
                filtered = filtered.Where(p => p.Cores <= to);

            bindingSource.DataSource = filtered.ToList();
            dataGridViewProcessors_KNM.ClearSelection();
        }

        private void buttonAddProcessor_KNM_Click(object sender, EventArgs e)
        {
            var p = new Processor
            {
                Id = dataManager.Processors.Any()
                    ? dataManager.Processors.Max(x => x.Id) + 1
                    : 1
            };

            dataManager.Processors.Add(p);
            RefreshData();
            dataGridViewProcessors_KNM.Rows[^1].Selected = true;
        }

        private void buttonDeleteProcessor_KNM_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Processor p)
            {
                dataManager.Processors.Remove(p);
                ApplyFilters();
            }
        }

        private void buttonResetFilters_KNM_Click(object sender, EventArgs e)
        {
            textBoxSearch_KNM.Clear();
            comboBoxManufacturer_KNM.SelectedIndex = 0;
            textBoxCoresFrom_KNM.Clear();
            textBoxCoresTo_KNM.Clear();
            RefreshData();
        }

        private void textBoxSearch_KNM_TextChanged(object sender, EventArgs e) => ApplyFilters();
        private void comboBoxManufacturer_KNM_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();

        private void DataGridViewProcessors_KNM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
