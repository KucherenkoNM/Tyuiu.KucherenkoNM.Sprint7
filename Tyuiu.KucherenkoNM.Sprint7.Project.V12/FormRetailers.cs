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
    public partial class FormRetailers : Form, IEditableData
    {
        private DataManager dataManager;
        private readonly BindingSource bindingSource = new BindingSource();

        public FormRetailers()
        {
            InitializeComponent();
            KeyPreview = true;

            dataGridViewRetailer_KNM.AutoGenerateColumns = true;
            dataGridViewRetailer_KNM.AllowUserToAddRows = false;
            dataGridViewRetailer_KNM.RowHeadersVisible = true;
            dataGridViewRetailer_KNM.DataSource = bindingSource;

            dataGridViewRetailer_KNM.CellFormatting += DataGridViewRetailer_KNM_CellFormatting;
        }

        public void SetData(DataManager manager)
        {
            dataManager = manager;
            RefreshData();
            UpdateCityFilter();
        }

        public void Load(string path)
        {
            dataManager.RetailersPath = path;
            dataManager.LoadRetailers(path);
            RefreshData();
            UpdateCityFilter();
            UiNotifier.ShowLoaded();
        }

        public void Save(string path)
        {
            dataManager.RetailersPath = path;
            dataManager.SaveRetailers(path);
            UiNotifier.ShowSaved();
        }

        public void RefreshData()
        {
            bindingSource.DataSource = dataManager.Retailers.ToList();
            dataGridViewRetailer_KNM.ClearSelection();
        }

        private void UpdateCityFilter()
        {
            var cities = dataManager.Retailers
                .Select(r => ExtractCity(r.Address))
                .Where(c => !string.IsNullOrWhiteSpace(c))
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            cities.Insert(0, "Все");

            comboBoxCity_KNM.DataSource = null;
            comboBoxCity_KNM.DataSource = cities;
            comboBoxCity_KNM.SelectedIndex = 0;
        }

        private string ExtractCity(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
                return null;

            int start = address.IndexOf("г.");
            if (start == -1)
                return null;

            start += 2;
            int end = address.IndexOf(",", start);
            if (end == -1)
                return address.Substring(start).Trim();

            return address.Substring(start, end - start).Trim();
        }

        private void ApplyFilters()
        {
            IEnumerable<Retailer> filtered = dataManager.Retailers;

            if (!string.IsNullOrWhiteSpace(textBoxSearch_KNM.Text))
            {
                string t = textBoxSearch_KNM.Text.ToLower();
                filtered = filtered.Where(r =>
                    r.Id.ToString().Contains(t) ||
                    r.Name?.ToLower().Contains(t) == true ||
                    r.Address?.ToLower().Contains(t) == true ||
                    r.Phone?.ToLower().Contains(t) == true
                );
            }

            var selectedCity = comboBoxCity_KNM.SelectedItem as string;
            if (!string.IsNullOrWhiteSpace(selectedCity) && selectedCity != "Все")
            {
                filtered = filtered.Where(r => ExtractCity(r.Address) == selectedCity);
            }

            bindingSource.DataSource = filtered.ToList();
            dataGridViewRetailer_KNM.ClearSelection();
        }

        private void buttonAddRetailer_KNM_Click(object sender, EventArgs e)
        {
            var r = new Retailer
            {
                Id = dataManager.Retailers.Any()
                    ? dataManager.Retailers.Max(x => x.Id) + 1
                    : 1
            };

            dataManager.Retailers.Add(r);
            RefreshData();
            UpdateCityFilter();
            dataGridViewRetailer_KNM.Rows[^1].Selected = true;
        }

        private void buttonDeleteRetailer_KNM_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Retailer r)
            {
                dataManager.Retailers.Remove(r);
                ApplyFilters();
                UpdateCityFilter();
            }
        }

        private void buttonResetFilters_KNM_Click(object sender, EventArgs e)
        {
            textBoxSearch_KNM.Clear();
            comboBoxCity_KNM.SelectedIndex = 0;
            RefreshData();
        }

        private void textBoxSearch_KNM_TextChanged(object sender, EventArgs e) => ApplyFilters();
        private void comboBoxCity_KNM_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();

        private void DataGridViewRetailer_KNM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
