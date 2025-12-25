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
    public partial class FormManufacturers : Form, IEditableData
    {
        private DataManager dataManager;
        private readonly BindingSource bindingSource = new BindingSource();

        public FormManufacturers()
        {
            InitializeComponent();
            KeyPreview = true;

            dataGridViewManufacturer_KNM.AutoGenerateColumns = true;
            dataGridViewManufacturer_KNM.AllowUserToAddRows = false;
            dataGridViewManufacturer_KNM.RowHeadersVisible = true;
            dataGridViewManufacturer_KNM.DataSource = bindingSource;

            dataGridViewManufacturer_KNM.CellFormatting += DataGridViewManufacturer_KNM_CellFormatting;
            textBoxSearch_KNM.TextChanged += textBoxSearch_KNM_TextChanged;
            comboBoxCountry_KNM.SelectedIndexChanged += comboBoxCountry_KNM_SelectedIndexChanged;
        }

        public void SetData(DataManager manager)
        {
            dataManager = manager;
            RefreshData();
            UpdateCountryFilter();
        }

        public void Load(string path)
        {
            dataManager.ManufacturersPath = path;
            dataManager.LoadManufacturers(path);
            RefreshData();
            UpdateCountryFilter();
            UiNotifier.ShowLoaded();
        }

        public void Save(string path)
        {
            dataManager.ManufacturersPath = path;
            dataManager.SaveManufacturers(path);
            UiNotifier.ShowSaved();
        }

        public void RefreshData()
        {
            bindingSource.DataSource = dataManager.Manufacturers.ToList();
            dataGridViewManufacturer_KNM.ClearSelection();
        }

        private void UpdateCountryFilter()
        {
            if (dataManager == null)
                return;

            var countries = dataManager.Manufacturers
                .Select(m => m.Country)
                .Where(c => !string.IsNullOrWhiteSpace(c))
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            countries.Insert(0, "Все");

            comboBoxCountry_KNM.DataSource = null;
            comboBoxCountry_KNM.DataSource = countries;
            comboBoxCountry_KNM.SelectedIndex = 0;
        }

        private void ApplyFilters()
        {
            if (dataManager == null)
                return;

            IEnumerable<Manufacturer> filtered = dataManager.Manufacturers;

            string search = textBoxSearch_KNM.Text;
            if (!string.IsNullOrWhiteSpace(search))
            {
                string s = search.ToLower();
                filtered = filtered.Where(m =>
                    m.Id.ToString().Contains(s) ||
                    m.Name?.ToLower().Contains(s) == true ||
                    m.Country?.ToLower().Contains(s) == true
                );
            }

            string country = comboBoxCountry_KNM.SelectedItem as string;
            if (!string.IsNullOrEmpty(country) && country != "Все")
                filtered = filtered.Where(m => m.Country == country);

            bindingSource.DataSource = filtered.ToList();
            dataGridViewManufacturer_KNM.ClearSelection();
        }

        private void buttonAddManufacturer_KNM_Click(object sender, EventArgs e)
        {
            var m = new Manufacturer
            {
                Id = dataManager.Manufacturers.Any()
                    ? dataManager.Manufacturers.Max(x => x.Id) + 1
                    : 1
            };

            dataManager.Manufacturers.Add(m);
            RefreshData();
            dataGridViewManufacturer_KNM.Rows[^1].Selected = true;
        }

        private void buttonDeleteManufacturer_KNM_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Manufacturer m)
            {
                dataManager.Manufacturers.Remove(m);
                ApplyFilters();
            }
        }

        private void buttonResetFilters_KNM_Click(object sender, EventArgs e)
        {
            textBoxSearch_KNM.Clear();
            comboBoxCountry_KNM.SelectedIndex = 0;
            RefreshData();
        }

        private void textBoxSearch_KNM_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void comboBoxCountry_KNM_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void DataGridViewManufacturer_KNM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
