namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStripMain_KNM = new MenuStrip();
            menuFile_KNM = new ToolStripMenuItem();
            menuFileOpen_KNM = new ToolStripMenuItem();
            menuFileSave_KNM = new ToolStripMenuItem();
            menuFileExit_KNM = new ToolStripMenuItem();
            menuData_KNM = new ToolStripMenuItem();
            menuDataComputers_KNM = new ToolStripMenuItem();
            menuDataManufacturers_KNM = new ToolStripMenuItem();
            menuDataProcessors_KNM = new ToolStripMenuItem();
            menuDataRetailers_KNM = new ToolStripMenuItem();
            аналитикаToolStripMenuItem = new ToolStripMenuItem();
            menuAnalyticsStatistics_KNM = new ToolStripMenuItem();
            menuAnalytics_KNM = new ToolStripMenuItem();
            menuHelp_KNM = new ToolStripMenuItem();
            menuHelpOpen_KNM = new ToolStripMenuItem();
            toolStripMail_KNM = new ToolStrip();
            toolStripButtonOpen_KNM = new ToolStripButton();
            toolStripButtonSave_KNM = new ToolStripButton();
            toolStripButtonRefresh_KNM = new ToolStripButton();
            toolTip_KNM = new ToolTip(components);
            panelContent_KNM = new Panel();
            labelWelcome_KNM = new Label();
            menuStripMain_KNM.SuspendLayout();
            toolStripMail_KNM.SuspendLayout();
            panelContent_KNM.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain_KNM
            // 
            menuStripMain_KNM.ImageScalingSize = new Size(20, 20);
            menuStripMain_KNM.Items.AddRange(new ToolStripItem[] { menuFile_KNM, menuData_KNM, аналитикаToolStripMenuItem, menuHelp_KNM });
            menuStripMain_KNM.Location = new Point(0, 0);
            menuStripMain_KNM.Name = "menuStripMain_KNM";
            menuStripMain_KNM.Size = new Size(1026, 31);
            menuStripMain_KNM.TabIndex = 0;
            menuStripMain_KNM.Text = "menuStrip1";
            // 
            // menuFile_KNM
            // 
            menuFile_KNM.DropDownItems.AddRange(new ToolStripItem[] { menuFileOpen_KNM, menuFileSave_KNM, menuFileExit_KNM });
            menuFile_KNM.Font = new Font("Segoe UI", 10F);
            menuFile_KNM.Name = "menuFile_KNM";
            menuFile_KNM.Size = new Size(64, 27);
            menuFile_KNM.Text = "Файл";
            // 
            // menuFileOpen_KNM
            // 
            menuFileOpen_KNM.Name = "menuFileOpen_KNM";
            menuFileOpen_KNM.Size = new Size(178, 28);
            menuFileOpen_KNM.Text = "Открыть";
            menuFileOpen_KNM.Click += menuFileOpen_KNM_Click;
            // 
            // menuFileSave_KNM
            // 
            menuFileSave_KNM.Name = "menuFileSave_KNM";
            menuFileSave_KNM.Size = new Size(178, 28);
            menuFileSave_KNM.Text = "Сохранить";
            // 
            // menuFileExit_KNM
            // 
            menuFileExit_KNM.Name = "menuFileExit_KNM";
            menuFileExit_KNM.Size = new Size(178, 28);
            menuFileExit_KNM.Text = "Выход";
            menuFileExit_KNM.Click += menuFileExit_KNM_Click;
            // 
            // menuData_KNM
            // 
            menuData_KNM.DropDownItems.AddRange(new ToolStripItem[] { menuDataComputers_KNM, menuDataManufacturers_KNM, menuDataProcessors_KNM, menuDataRetailers_KNM });
            menuData_KNM.Font = new Font("Segoe UI", 10F);
            menuData_KNM.Name = "menuData_KNM";
            menuData_KNM.Size = new Size(86, 27);
            menuData_KNM.Text = "Данные";
            // 
            // menuDataComputers_KNM
            // 
            menuDataComputers_KNM.Name = "menuDataComputers_KNM";
            menuDataComputers_KNM.Size = new Size(217, 28);
            menuDataComputers_KNM.Text = "Компьютеры";
            menuDataComputers_KNM.Click += menuDataComputers_KNM_Click;
            // 
            // menuDataManufacturers_KNM
            // 
            menuDataManufacturers_KNM.Name = "menuDataManufacturers_KNM";
            menuDataManufacturers_KNM.Size = new Size(217, 28);
            menuDataManufacturers_KNM.Text = "Производители";
            menuDataManufacturers_KNM.Click += menuDataManufacturers_KNM_Click;
            // 
            // menuDataProcessors_KNM
            // 
            menuDataProcessors_KNM.Name = "menuDataProcessors_KNM";
            menuDataProcessors_KNM.Size = new Size(217, 28);
            menuDataProcessors_KNM.Text = "Процессоры";
            menuDataProcessors_KNM.Click += menuDataProcessors_KNM_Click;
            // 
            // menuDataRetailers_KNM
            // 
            menuDataRetailers_KNM.Name = "menuDataRetailers_KNM";
            menuDataRetailers_KNM.Size = new Size(217, 28);
            menuDataRetailers_KNM.Text = "Реализаторы";
            menuDataRetailers_KNM.Click += menuDataRetailers_KNM_Click;
            // 
            // аналитикаToolStripMenuItem
            // 
            аналитикаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuAnalyticsStatistics_KNM, menuAnalytics_KNM });
            аналитикаToolStripMenuItem.Font = new Font("Segoe UI", 10F);
            аналитикаToolStripMenuItem.Name = "аналитикаToolStripMenuItem";
            аналитикаToolStripMenuItem.Size = new Size(107, 27);
            аналитикаToolStripMenuItem.Text = "Аналитика";
            // 
            // menuAnalyticsStatistics_KNM
            // 
            menuAnalyticsStatistics_KNM.Name = "menuAnalyticsStatistics_KNM";
            menuAnalyticsStatistics_KNM.Size = new Size(180, 28);
            menuAnalyticsStatistics_KNM.Text = "Статистика";
            menuAnalyticsStatistics_KNM.Click += menuAnalyticsStatistics_KNM_Click;
            // 
            // menuAnalytics_KNM
            // 
            menuAnalytics_KNM.Name = "menuAnalytics_KNM";
            menuAnalytics_KNM.Size = new Size(180, 28);
            menuAnalytics_KNM.Text = "Графики";
            menuAnalytics_KNM.Click += menuAnalyticsCharts_KNM_Click;
            // 
            // menuHelp_KNM
            // 
            menuHelp_KNM.DropDownItems.AddRange(new ToolStripItem[] { menuHelpOpen_KNM });
            menuHelp_KNM.Font = new Font("Segoe UI", 10F);
            menuHelp_KNM.Name = "menuHelp_KNM";
            menuHelp_KNM.Size = new Size(90, 27);
            menuHelp_KNM.Text = "Справка";
            // 
            // menuHelpOpen_KNM
            // 
            menuHelpOpen_KNM.Name = "menuHelpOpen_KNM";
            menuHelpOpen_KNM.Size = new Size(227, 28);
            menuHelpOpen_KNM.Text = "Открыть справку";
            menuHelpOpen_KNM.Click += menuHelpOpen_KNM_Click;
            // 
            // toolStripMail_KNM
            // 
            toolStripMail_KNM.ImageScalingSize = new Size(40, 40);
            toolStripMail_KNM.Items.AddRange(new ToolStripItem[] { toolStripButtonOpen_KNM, toolStripButtonSave_KNM, toolStripButtonRefresh_KNM });
            toolStripMail_KNM.Location = new Point(0, 31);
            toolStripMail_KNM.Name = "toolStripMail_KNM";
            toolStripMail_KNM.Size = new Size(1026, 47);
            toolStripMail_KNM.TabIndex = 1;
            toolStripMail_KNM.Text = "toolStrip1";
            // 
            // toolStripButtonOpen_KNM
            // 
            toolStripButtonOpen_KNM.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonOpen_KNM.Image = (Image)resources.GetObject("toolStripButtonOpen_KNM.Image");
            toolStripButtonOpen_KNM.ImageTransparentColor = Color.Magenta;
            toolStripButtonOpen_KNM.Name = "toolStripButtonOpen_KNM";
            toolStripButtonOpen_KNM.Size = new Size(44, 44);
            toolStripButtonOpen_KNM.Text = "toolStripButton1";
            toolStripButtonOpen_KNM.ToolTipText = "Открыть CSV файл";
            // 
            // toolStripButtonSave_KNM
            // 
            toolStripButtonSave_KNM.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave_KNM.Image = (Image)resources.GetObject("toolStripButtonSave_KNM.Image");
            toolStripButtonSave_KNM.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave_KNM.Name = "toolStripButtonSave_KNM";
            toolStripButtonSave_KNM.Size = new Size(44, 44);
            toolStripButtonSave_KNM.Text = "toolStripButton2";
            toolStripButtonSave_KNM.ToolTipText = "Сохранить CSV файл";
            // 
            // toolStripButtonRefresh_KNM
            // 
            toolStripButtonRefresh_KNM.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRefresh_KNM.Image = (Image)resources.GetObject("toolStripButtonRefresh_KNM.Image");
            toolStripButtonRefresh_KNM.ImageTransparentColor = Color.Magenta;
            toolStripButtonRefresh_KNM.Name = "toolStripButtonRefresh_KNM";
            toolStripButtonRefresh_KNM.Size = new Size(44, 44);
            toolStripButtonRefresh_KNM.Text = "toolStripButton3";
            toolStripButtonRefresh_KNM.ToolTipText = "Обновить данные";
            // 
            // panelContent_KNM
            // 
            panelContent_KNM.BorderStyle = BorderStyle.FixedSingle;
            panelContent_KNM.Controls.Add(labelWelcome_KNM);
            panelContent_KNM.Dock = DockStyle.Fill;
            panelContent_KNM.Location = new Point(0, 78);
            panelContent_KNM.Name = "panelContent_KNM";
            panelContent_KNM.Size = new Size(1026, 540);
            panelContent_KNM.TabIndex = 2;
            // 
            // labelWelcome_KNM
            // 
            labelWelcome_KNM.Anchor = AnchorStyles.None;
            labelWelcome_KNM.AutoSize = true;
            labelWelcome_KNM.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelWelcome_KNM.ForeColor = SystemColors.GrayText;
            labelWelcome_KNM.Location = new Point(419, 260);
            labelWelcome_KNM.Name = "labelWelcome_KNM";
            labelWelcome_KNM.Size = new Size(327, 35);
            labelWelcome_KNM.TabIndex = 0;
            labelWelcome_KNM.Text = "Выберите раздел в меню";
            labelWelcome_KNM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 618);
            Controls.Add(panelContent_KNM);
            Controls.Add(toolStripMail_KNM);
            Controls.Add(menuStripMain_KNM);
            MainMenuStrip = menuStripMain_KNM;
            MinimumSize = new Size(1031, 621);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Персональные ЭВМ — главное окно";
            WindowState = FormWindowState.Maximized;
            menuStripMain_KNM.ResumeLayout(false);
            menuStripMain_KNM.PerformLayout();
            toolStripMail_KNM.ResumeLayout(false);
            toolStripMail_KNM.PerformLayout();
            panelContent_KNM.ResumeLayout(false);
            panelContent_KNM.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain_KNM;
        private ToolStripMenuItem menuFile_KNM;
        private ToolStripMenuItem menuFileOpen_KNM;
        private ToolStripMenuItem menuData_KNM;
        private ToolStripMenuItem аналитикаToolStripMenuItem;
        private ToolStripMenuItem menuHelp_KNM;
        private ToolStripMenuItem menuFileSave_KNM;
        private ToolStripMenuItem menuFileExit_KNM;
        private ToolStripMenuItem menuDataComputers_KNM;
        private ToolStripMenuItem menuDataManufacturers_KNM;
        private ToolStripMenuItem menuDataProcessors_KNM;
        private ToolStripMenuItem menuDataRetailers_KNM;
        private ToolStripMenuItem menuAnalyticsStatistics_KNM;
        private ToolStripMenuItem menuAnalytics_KNM;
        private ToolStripMenuItem menuHelpOpen_KNM;
        private ToolStrip toolStripMail_KNM;
        private ToolStripButton toolStripButtonOpen_KNM;
        private ToolStripButton toolStripButtonSave_KNM;
        private ToolStripButton toolStripButtonRefresh_KNM;
        private ToolTip toolTip_KNM;
        private Panel panelContent_KNM;
        private Label labelWelcome_KNM;
    }
}
