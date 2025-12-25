namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    partial class FormRetailers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelTop_KNM = new Panel();
            labelRetailer_KNM = new Label();
            buttonDeleteRetailer_KNM = new Button();
            buttonAddRetailer_KNM = new Button();
            panelFilter_KNM = new Panel();
            comboBoxCity_KNM = new ComboBox();
            buttonResetFilters_KNM = new Button();
            textBoxSearch_KNM = new TextBox();
            labelCity_KNM = new Label();
            labelSearch_KNM = new Label();
            labelFiltersTitle_KNM = new Label();
            dataGridViewRetailer_KNM = new DataGridView();
            toolTipMain_KNM = new ToolTip(components);
            panelTop_KNM.SuspendLayout();
            panelFilter_KNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRetailer_KNM).BeginInit();
            SuspendLayout();
            // 
            // panelTop_KNM
            // 
            panelTop_KNM.Controls.Add(labelRetailer_KNM);
            panelTop_KNM.Controls.Add(buttonDeleteRetailer_KNM);
            panelTop_KNM.Controls.Add(buttonAddRetailer_KNM);
            panelTop_KNM.Dock = DockStyle.Top;
            panelTop_KNM.Location = new Point(0, 0);
            panelTop_KNM.Name = "panelTop_KNM";
            panelTop_KNM.Size = new Size(800, 63);
            panelTop_KNM.TabIndex = 1;
            // 
            // labelRetailer_KNM
            // 
            labelRetailer_KNM.Anchor = AnchorStyles.Right;
            labelRetailer_KNM.AutoSize = true;
            labelRetailer_KNM.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRetailer_KNM.Location = new Point(603, 12);
            labelRetailer_KNM.Name = "labelRetailer_KNM";
            labelRetailer_KNM.Size = new Size(185, 35);
            labelRetailer_KNM.TabIndex = 1;
            labelRetailer_KNM.Text = "Реализаторы";
            // 
            // buttonDeleteRetailer_KNM
            // 
            buttonDeleteRetailer_KNM.FlatStyle = FlatStyle.Flat;
            buttonDeleteRetailer_KNM.Image = Properties.Resources.application_delete;
            buttonDeleteRetailer_KNM.Location = new Point(53, 12);
            buttonDeleteRetailer_KNM.Name = "buttonDeleteRetailer_KNM";
            buttonDeleteRetailer_KNM.Size = new Size(35, 35);
            buttonDeleteRetailer_KNM.TabIndex = 0;
            toolTipMain_KNM.SetToolTip(buttonDeleteRetailer_KNM, "Удалить фирму-реализатора");
            buttonDeleteRetailer_KNM.UseVisualStyleBackColor = true;
            buttonDeleteRetailer_KNM.Click += buttonDeleteRetailer_KNM_Click;
            // 
            // buttonAddRetailer_KNM
            // 
            buttonAddRetailer_KNM.FlatStyle = FlatStyle.Flat;
            buttonAddRetailer_KNM.Image = Properties.Resources.application_add;
            buttonAddRetailer_KNM.Location = new Point(12, 12);
            buttonAddRetailer_KNM.Name = "buttonAddRetailer_KNM";
            buttonAddRetailer_KNM.Size = new Size(35, 35);
            buttonAddRetailer_KNM.TabIndex = 0;
            toolTipMain_KNM.SetToolTip(buttonAddRetailer_KNM, "Добавить фирму-реализатора");
            buttonAddRetailer_KNM.UseVisualStyleBackColor = true;
            buttonAddRetailer_KNM.Click += buttonAddRetailer_KNM_Click;
            // 
            // panelFilter_KNM
            // 
            panelFilter_KNM.BackColor = SystemColors.ControlLight;
            panelFilter_KNM.Controls.Add(comboBoxCity_KNM);
            panelFilter_KNM.Controls.Add(buttonResetFilters_KNM);
            panelFilter_KNM.Controls.Add(textBoxSearch_KNM);
            panelFilter_KNM.Controls.Add(labelCity_KNM);
            panelFilter_KNM.Controls.Add(labelSearch_KNM);
            panelFilter_KNM.Controls.Add(labelFiltersTitle_KNM);
            panelFilter_KNM.Dock = DockStyle.Left;
            panelFilter_KNM.Location = new Point(0, 63);
            panelFilter_KNM.Name = "panelFilter_KNM";
            panelFilter_KNM.Padding = new Padding(10);
            panelFilter_KNM.Size = new Size(220, 387);
            panelFilter_KNM.TabIndex = 3;
            // 
            // comboBoxCity_KNM
            // 
            comboBoxCity_KNM.FormattingEnabled = true;
            comboBoxCity_KNM.Location = new Point(12, 167);
            comboBoxCity_KNM.Name = "comboBoxCity_KNM";
            comboBoxCity_KNM.Size = new Size(195, 28);
            comboBoxCity_KNM.TabIndex = 10;
            comboBoxCity_KNM.SelectedIndexChanged += comboBoxCity_KNM_SelectedIndexChanged;
            // 
            // buttonResetFilters_KNM
            // 
            buttonResetFilters_KNM.FlatStyle = FlatStyle.Flat;
            buttonResetFilters_KNM.Location = new Point(33, 313);
            buttonResetFilters_KNM.Name = "buttonResetFilters_KNM";
            buttonResetFilters_KNM.Size = new Size(155, 29);
            buttonResetFilters_KNM.TabIndex = 9;
            buttonResetFilters_KNM.Text = "Сброс фильтров";
            buttonResetFilters_KNM.UseVisualStyleBackColor = true;
            buttonResetFilters_KNM.Click += buttonResetFilters_KNM_Click;
            // 
            // textBoxSearch_KNM
            // 
            textBoxSearch_KNM.Location = new Point(13, 80);
            textBoxSearch_KNM.Name = "textBoxSearch_KNM";
            textBoxSearch_KNM.Size = new Size(194, 27);
            textBoxSearch_KNM.TabIndex = 5;
            textBoxSearch_KNM.TextChanged += textBoxSearch_KNM_TextChanged;
            // 
            // labelCity_KNM
            // 
            labelCity_KNM.AutoSize = true;
            labelCity_KNM.Location = new Point(83, 133);
            labelCity_KNM.Name = "labelCity_KNM";
            labelCity_KNM.Size = new Size(51, 20);
            labelCity_KNM.TabIndex = 2;
            labelCity_KNM.Text = "Город";
            // 
            // labelSearch_KNM
            // 
            labelSearch_KNM.AutoSize = true;
            labelSearch_KNM.Location = new Point(83, 57);
            labelSearch_KNM.Name = "labelSearch_KNM";
            labelSearch_KNM.Size = new Size(52, 20);
            labelSearch_KNM.TabIndex = 1;
            labelSearch_KNM.Text = "Поиск";
            // 
            // labelFiltersTitle_KNM
            // 
            labelFiltersTitle_KNM.AutoSize = true;
            labelFiltersTitle_KNM.Font = new Font("Segoe UI", 12F);
            labelFiltersTitle_KNM.Location = new Point(68, 10);
            labelFiltersTitle_KNM.Name = "labelFiltersTitle_KNM";
            labelFiltersTitle_KNM.Size = new Size(94, 28);
            labelFiltersTitle_KNM.TabIndex = 0;
            labelFiltersTitle_KNM.Text = "Фильтры";
            // 
            // dataGridViewRetailer_KNM
            // 
            dataGridViewRetailer_KNM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRetailer_KNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRetailer_KNM.Dock = DockStyle.Fill;
            dataGridViewRetailer_KNM.Location = new Point(220, 63);
            dataGridViewRetailer_KNM.MultiSelect = false;
            dataGridViewRetailer_KNM.Name = "dataGridViewRetailer_KNM";
            dataGridViewRetailer_KNM.RowHeadersWidth = 51;
            dataGridViewRetailer_KNM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRetailer_KNM.Size = new Size(580, 387);
            dataGridViewRetailer_KNM.TabIndex = 4;
            // 
            // FormRetailers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewRetailer_KNM);
            Controls.Add(panelFilter_KNM);
            Controls.Add(panelTop_KNM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRetailers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Фирмы-реализаторы";
            panelTop_KNM.ResumeLayout(false);
            panelTop_KNM.PerformLayout();
            panelFilter_KNM.ResumeLayout(false);
            panelFilter_KNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRetailer_KNM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KNM;
        private Button buttonDeleteRetailer_KNM;
        private Button buttonAddRetailer_KNM;
        private Panel panelFilter_KNM;
        private Button buttonResetFilters_KNM;
        private TextBox textBoxSearch_KNM;
        private Label labelCity_KNM;
        private Label labelSearch_KNM;
        private Label labelFiltersTitle_KNM;
        private ToolTip toolTipMain_KNM;
        private DataGridView dataGridViewRetailer_KNM;
        private Label labelRetailer_KNM;
        private ComboBox comboBoxCity_KNM;
    }
}