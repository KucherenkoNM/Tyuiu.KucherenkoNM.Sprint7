using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        private List<Computer> computers_KNM = new List<Computer>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void OpenFormInPanel(Form form)
        {
            panelContent_KNM.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContent_KNM.Controls.Add(form);
            form.Show();
        }

        private void LoadComputersFromCsv(string filePath)
        {
            var service = new ComputerService();
            computers_KNM = service.LoadFromCsv(filePath);
        }

        private void menuDataComputers_KNM_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormComputers());
        }

        private void menuDataManufacturers_KNM_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormManufacturers());
        }

        private void menuDataProcessors_KNM_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormProcessors());
        }

        private void menuDataRetailers_KNM_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormRetailers());
        }

        private void menuAnalyticsStatistics_KNM_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormStatistics());
        }

        private void menuAnalyticsCharts_KNM_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormCharts());
        }

        private void menuHelpOpen_KNM_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormHelp());
        }

        private void menuFileOpen_KNM_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadComputersFromCsv(openFileDialog.FileName);

                    MessageBox.Show(
                        "Данные успешно загружены",
                        "Информация",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }

        private void menuFileExit_KNM_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
