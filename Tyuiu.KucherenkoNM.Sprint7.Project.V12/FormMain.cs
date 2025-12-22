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
        private List<Processor> processors_KNM = new List<Processor>();

        public FormMain()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;
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

        private void menuDataComputers_KNM_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormComputers(computers_KNM));
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
            if (panelContent_KNM.Controls.Count == 0)
            {
                MessageBox.Show("Сначала откройте форму", "Ошибка");
                return;
            }

            if (panelContent_KNM.Controls[0] is not ICsvOpenable csvForm)
            {
                MessageBox.Show("Эта форма не поддерживает загрузку CSV", "Ошибка");
                return;
            }

            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                csvForm.OpenFromCsv(openFileDialog.FileName);

                MessageBox.Show(
                    "Данные успешно загружены",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void menuFileExit_KNM_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
