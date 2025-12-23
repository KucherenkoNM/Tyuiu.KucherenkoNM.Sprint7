using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    public partial class FormRetailers : Form, ICsvOpenable
    {
        private readonly RetailerService retailerService_KNM = new();
        private readonly BindingSource bindingSourceRetailers_KNM = new();
        private List<Retailer> retailers_KNM = new();

        public FormRetailers()
        {
            InitializeComponent();

            dataGridViewRetailer_KNM.AutoGenerateColumns = true;
            dataGridViewRetailer_KNM.AllowUserToAddRows = false;
            dataGridViewRetailer_KNM.RowHeadersVisible = true;
            dataGridViewRetailer_KNM.DataSource = bindingSourceRetailers_KNM;

            dataGridViewRetailer_KNM.CellFormatting += DataGridViewRetailer_KNM_CellFormatting;
        }

        public void OpenFromCsv(string filePath)
        {
            retailers_KNM = retailerService_KNM.LoadFromCsv(filePath);
            bindingSourceRetailers_KNM.DataSource = retailers_KNM;
        }

        private void buttonAddRetailer_KNM_Click(object sender, EventArgs e)
        {
            bindingSourceRetailers_KNM.Add(new Retailer());
        }

        private void buttonDeleteRetailer_KNM_Click(object sender, EventArgs e)
        {
            if (bindingSourceRetailers_KNM.Current != null)
                bindingSourceRetailers_KNM.RemoveCurrent();
        }

        private void textBoxSearch_KNM_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void textBoxCity_KNM_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void buttonResetFilters_KNM_Click(object sender, EventArgs e)
        {
            textBoxSearch_KNM.Clear();
            textBoxCity_KNM.Clear();
            bindingSourceRetailers_KNM.DataSource = retailers_KNM;
        }

        private void ApplyFilters()
        {
            IEnumerable<Retailer> filtered = retailers_KNM;

            if (!string.IsNullOrWhiteSpace(textBoxSearch_KNM.Text))
            {
                var t = textBoxSearch_KNM.Text.ToLower();
                filtered = filtered.Where(r =>
                    r.RetailerId.ToString().Contains(t) ||
                    r.Name.ToLower().Contains(t) ||
                    r.Address.ToLower().Contains(t) ||
                    r.Phone.ToLower().Contains(t));
            }

            if (!string.IsNullOrWhiteSpace(textBoxCity_KNM.Text))
            {
                var c = textBoxCity_KNM.Text.ToLower();
                filtered = filtered.Where(r => r.Address.ToLower().Contains(c));
            }

            bindingSourceRetailers_KNM.DataSource = filtered.ToList();
            dataGridViewRetailer_KNM.ClearSelection();
        }

        private void DataGridViewRetailer_KNM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
                return;

            var value = e.Value.ToString() ?? "";

            if (!string.IsNullOrWhiteSpace(textBoxSearch_KNM.Text) &&
                value.Contains(textBoxSearch_KNM.Text, StringComparison.OrdinalIgnoreCase))
            {
                e.CellStyle.BackColor = Color.LightYellow;
            }
            else if (!string.IsNullOrWhiteSpace(textBoxCity_KNM.Text) &&
                     value.Contains(textBoxCity_KNM.Text, StringComparison.OrdinalIgnoreCase))
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
