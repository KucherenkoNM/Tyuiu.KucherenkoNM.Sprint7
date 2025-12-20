namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
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

        private void menuAnalytics_KNM_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormCharts());
        }

        private void menuHelpOpen_KNM_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormHelp());
        }
    }
}
