using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Models;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        private Form currentForm_KNM;
        private List<Computer> computers_KNM = new();


        public FormMain()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void OpenFormInPanel(Form form)
        {
            panelContent_KNM.Controls.Clear();
            currentForm_KNM = form;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelContent_KNM.Controls.Add(form);
            form.Show();
        }

        public void SetComputers(List<Computer> computers)
        {
            computers_KNM = computers;
        }

        private void menuDataComputers_KNM_Click(object sender, EventArgs e)
        {
            var form = new FormComputers();
            OpenFormInPanel(form);
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
            var form = new FormStatistics();
            form.SetData(computers_KNM);
            OpenFormInPanel(form);
        }

        private void menuAnalyticsCharts_KNM_Click(object sender, EventArgs e)
        {
            var form = new FormCharts(computers_KNM);
;
            OpenFormInPanel(form);
        }

        private void menuHelpOpen_KNM_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormHelp());
        }

        private void menuFileOpen_KNM_Click(object sender, EventArgs e)
        {
            if (currentForm_KNM == null)
            {
                MessageBox.Show("Сначала откройте форму", "Ошибка");
                return;
            }

            if (currentForm_KNM is not ICsvOpenable csvForm)
            {
                MessageBox.Show("Эта форма не поддерживает загрузку CSV", "Ошибка");
                return;
            }

            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV files (*.csv)|*.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                csvForm.OpenFromCsv(dialog.FileName);

                if (currentForm_KNM is FormComputers fc)
                    computers_KNM = fc.GetComputers();

                MessageBox.Show("Данные успешно загружены", "Информация");
            }
        }

        private void menuFileExit_KNM_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
