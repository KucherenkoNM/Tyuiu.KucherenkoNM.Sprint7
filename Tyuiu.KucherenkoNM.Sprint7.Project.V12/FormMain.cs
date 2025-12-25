#nullable disable
using System;
using System.Windows.Forms;
using Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        private Form currentForm;
        private readonly DataManager dataManager = new DataManager();

        public FormMain()
        {
            InitializeComponent();
            KeyPreview = true;
            dataManager.LoadAll();
        }

        private void OpenFormInPanel(Form form)
        {
            CloseCurrentForm();

            labelWelcome_KNM.Visible = false;

            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContent_KNM.Controls.Add(form);

            if (form is IEditableData editable)
                editable.SetData(dataManager);

            form.Show();
        }

        private void CloseCurrentForm()
        {
            if (currentForm != null)
            {
                panelContent_KNM.Controls.Remove(currentForm);
                currentForm.Close();
                currentForm.Dispose();
                currentForm = null;

                labelWelcome_KNM.Visible = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape && currentForm != null)
            {
                CloseCurrentForm();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
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
            var form = new FormStatistics();
            OpenFormInPanel(form);
        }

        private void menuAnalyticsCharts_KNM_Click(object sender, EventArgs e)
        {
            var form = new FormCharts();
            OpenFormInPanel(form);
        }

        private void menuHelpOpen_KNM_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormHelp());
        }

        private void menuFileOpen_KNM_Click(object sender, EventArgs e)
        {
            toolStripButtonOpen_KNM.PerformClick();
        }

        private void menuFileSave_KNM_Click(object sender, EventArgs e)
        {
            toolStripButtonSave_KNM.PerformClick();
        }

        private void menuFileExit_KNM_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButtonOpen_KNM_Click(object sender, EventArgs e)
        {
            if (currentForm is not IEditableData editable)
                return;

            using OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
                editable.Load(dialog.FileName);
        }

        private void toolStripButtonSave_KNM_Click(object sender, EventArgs e)
        {
            if (currentForm is not IEditableData editable)
                return;

            using SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                editable.Save(dialog.FileName);
                dataManager.SaveAll();
            }
        }

        private void toolStripButtonRefresh_KNM_Click(object sender, EventArgs e)
        {
            dataManager.LoadAll();

            if (currentForm is IEditableData editable)
            {
                editable.RefreshData();
                UiNotifier.ShowRefreshed();
            }
        }
    }
}
