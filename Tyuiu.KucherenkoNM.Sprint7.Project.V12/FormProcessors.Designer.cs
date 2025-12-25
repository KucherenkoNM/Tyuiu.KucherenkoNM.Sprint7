namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    partial class FormProcessors
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
            toolTipMain_KNM = new ToolTip(components);
            buttonDeleteProcessor_KNM = new Button();
            buttonAddProcessor_KNM = new Button();
            panelTop_KNM = new Panel();
            buttonResetFilters_KNM = new Button();
            textBoxCoresTo_KNM = new TextBox();
            textBoxCoresFrom_KNM = new TextBox();
            textBoxSearch_KNM = new TextBox();
            labelCoresTo_KNM = new Label();
            labelCoresFrom_KNM = new Label();
            labelManufacturer_KNM = new Label();
            labelSearch_KNM = new Label();
            labelFiltersTitle_KNM = new Label();
            panelFilter_KNM = new Panel();
            comboBoxManufacturer_KNM = new ComboBox();
            dataGridViewProcessors_KNM = new DataGridView();
            labelProcessors_KNM = new Label();
            panelTop_KNM.SuspendLayout();
            panelFilter_KNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcessors_KNM).BeginInit();
            SuspendLayout();
            // 
            // buttonDeleteProcessor_KNM
            // 
            buttonDeleteProcessor_KNM.FlatStyle = FlatStyle.Flat;
            buttonDeleteProcessor_KNM.Image = Properties.Resources.drive_delete1;
            buttonDeleteProcessor_KNM.Location = new Point(53, 12);
            buttonDeleteProcessor_KNM.Name = "buttonDeleteProcessor_KNM";
            buttonDeleteProcessor_KNM.Size = new Size(35, 35);
            buttonDeleteProcessor_KNM.TabIndex = 2;
            toolTipMain_KNM.SetToolTip(buttonDeleteProcessor_KNM, "Удалить выбранный процессор");
            buttonDeleteProcessor_KNM.UseVisualStyleBackColor = true;
            buttonDeleteProcessor_KNM.Click += buttonDeleteProcessor_KNM_Click;
            // 
            // buttonAddProcessor_KNM
            // 
            buttonAddProcessor_KNM.FlatStyle = FlatStyle.Flat;
            buttonAddProcessor_KNM.Image = Properties.Resources.drive_add;
            buttonAddProcessor_KNM.Location = new Point(12, 12);
            buttonAddProcessor_KNM.Name = "buttonAddProcessor_KNM";
            buttonAddProcessor_KNM.Size = new Size(35, 35);
            buttonAddProcessor_KNM.TabIndex = 0;
            toolTipMain_KNM.SetToolTip(buttonAddProcessor_KNM, "Добавить процессор");
            buttonAddProcessor_KNM.UseVisualStyleBackColor = true;
            buttonAddProcessor_KNM.Click += buttonAddProcessor_KNM_Click;
            // 
            // panelTop_KNM
            // 
            panelTop_KNM.Controls.Add(labelProcessors_KNM);
            panelTop_KNM.Controls.Add(buttonDeleteProcessor_KNM);
            panelTop_KNM.Controls.Add(buttonAddProcessor_KNM);
            panelTop_KNM.Dock = DockStyle.Top;
            panelTop_KNM.Location = new Point(0, 0);
            panelTop_KNM.Name = "panelTop_KNM";
            panelTop_KNM.Size = new Size(800, 63);
            panelTop_KNM.TabIndex = 1;
            // 
            // buttonResetFilters_KNM
            // 
            buttonResetFilters_KNM.FlatStyle = FlatStyle.Flat;
            buttonResetFilters_KNM.Location = new Point(35, 325);
            buttonResetFilters_KNM.Name = "buttonResetFilters_KNM";
            buttonResetFilters_KNM.Size = new Size(155, 29);
            buttonResetFilters_KNM.TabIndex = 9;
            buttonResetFilters_KNM.Text = "Сброс фильтров";
            buttonResetFilters_KNM.UseVisualStyleBackColor = true;
            buttonResetFilters_KNM.Click += buttonResetFilters_KNM_Click;
            // 
            // textBoxCoresTo_KNM
            // 
            textBoxCoresTo_KNM.Location = new Point(13, 261);
            textBoxCoresTo_KNM.Name = "textBoxCoresTo_KNM";
            textBoxCoresTo_KNM.Size = new Size(194, 27);
            textBoxCoresTo_KNM.TabIndex = 8;
            // 
            // textBoxCoresFrom_KNM
            // 
            textBoxCoresFrom_KNM.Location = new Point(12, 194);
            textBoxCoresFrom_KNM.Name = "textBoxCoresFrom_KNM";
            textBoxCoresFrom_KNM.Size = new Size(195, 27);
            textBoxCoresFrom_KNM.TabIndex = 7;
            // 
            // textBoxSearch_KNM
            // 
            textBoxSearch_KNM.Location = new Point(13, 67);
            textBoxSearch_KNM.Name = "textBoxSearch_KNM";
            textBoxSearch_KNM.Size = new Size(194, 27);
            textBoxSearch_KNM.TabIndex = 5;
            textBoxSearch_KNM.TextChanged += textBoxSearch_KNM_TextChanged;
            // 
            // labelCoresTo_KNM
            // 
            labelCoresTo_KNM.AutoSize = true;
            labelCoresTo_KNM.Location = new Point(42, 238);
            labelCoresTo_KNM.Name = "labelCoresTo_KNM";
            labelCoresTo_KNM.Size = new Size(148, 20);
            labelCoresTo_KNM.TabIndex = 4;
            labelCoresTo_KNM.Text = "Количество ядер до";
            // 
            // labelCoresFrom_KNM
            // 
            labelCoresFrom_KNM.AutoSize = true;
            labelCoresFrom_KNM.Location = new Point(35, 171);
            labelCoresFrom_KNM.Name = "labelCoresFrom_KNM";
            labelCoresFrom_KNM.Size = new Size(146, 20);
            labelCoresFrom_KNM.TabIndex = 3;
            labelCoresFrom_KNM.Text = "Количество ядер от";
            // 
            // labelManufacturer_KNM
            // 
            labelManufacturer_KNM.AutoSize = true;
            labelManufacturer_KNM.Location = new Point(53, 108);
            labelManufacturer_KNM.Name = "labelManufacturer_KNM";
            labelManufacturer_KNM.Size = new Size(118, 20);
            labelManufacturer_KNM.TabIndex = 2;
            labelManufacturer_KNM.Text = "Производитель";
            // 
            // labelSearch_KNM
            // 
            labelSearch_KNM.AutoSize = true;
            labelSearch_KNM.Location = new Point(87, 44);
            labelSearch_KNM.Name = "labelSearch_KNM";
            labelSearch_KNM.Size = new Size(52, 20);
            labelSearch_KNM.TabIndex = 1;
            labelSearch_KNM.Text = "Поиск";
            // 
            // labelFiltersTitle_KNM
            // 
            labelFiltersTitle_KNM.AutoSize = true;
            labelFiltersTitle_KNM.Font = new Font("Segoe UI", 12F);
            labelFiltersTitle_KNM.Location = new Point(69, 10);
            labelFiltersTitle_KNM.Name = "labelFiltersTitle_KNM";
            labelFiltersTitle_KNM.Size = new Size(94, 28);
            labelFiltersTitle_KNM.TabIndex = 0;
            labelFiltersTitle_KNM.Text = "Фильтры";
            // 
            // panelFilter_KNM
            // 
            panelFilter_KNM.BackColor = SystemColors.ControlLight;
            panelFilter_KNM.Controls.Add(comboBoxManufacturer_KNM);
            panelFilter_KNM.Controls.Add(buttonResetFilters_KNM);
            panelFilter_KNM.Controls.Add(textBoxCoresTo_KNM);
            panelFilter_KNM.Controls.Add(textBoxCoresFrom_KNM);
            panelFilter_KNM.Controls.Add(textBoxSearch_KNM);
            panelFilter_KNM.Controls.Add(labelCoresTo_KNM);
            panelFilter_KNM.Controls.Add(labelCoresFrom_KNM);
            panelFilter_KNM.Controls.Add(labelManufacturer_KNM);
            panelFilter_KNM.Controls.Add(labelSearch_KNM);
            panelFilter_KNM.Controls.Add(labelFiltersTitle_KNM);
            panelFilter_KNM.Dock = DockStyle.Left;
            panelFilter_KNM.Location = new Point(0, 63);
            panelFilter_KNM.Name = "panelFilter_KNM";
            panelFilter_KNM.Padding = new Padding(10);
            panelFilter_KNM.Size = new Size(220, 387);
            panelFilter_KNM.TabIndex = 2;
            // 
            // comboBoxManufacturer_KNM
            // 
            comboBoxManufacturer_KNM.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxManufacturer_KNM.FormattingEnabled = true;
            comboBoxManufacturer_KNM.Location = new Point(13, 131);
            comboBoxManufacturer_KNM.Name = "comboBoxManufacturer_KNM";
            comboBoxManufacturer_KNM.Size = new Size(194, 28);
            comboBoxManufacturer_KNM.TabIndex = 10;
            comboBoxManufacturer_KNM.SelectedIndexChanged += comboBoxManufacturer_KNM_SelectedIndexChanged;
            // 
            // dataGridViewProcessors_KNM
            // 
            dataGridViewProcessors_KNM.AllowUserToAddRows = false;
            dataGridViewProcessors_KNM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProcessors_KNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProcessors_KNM.Dock = DockStyle.Fill;
            dataGridViewProcessors_KNM.Location = new Point(220, 63);
            dataGridViewProcessors_KNM.MultiSelect = false;
            dataGridViewProcessors_KNM.Name = "dataGridViewProcessors_KNM";
            dataGridViewProcessors_KNM.RowHeadersWidth = 51;
            dataGridViewProcessors_KNM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProcessors_KNM.Size = new Size(580, 387);
            dataGridViewProcessors_KNM.TabIndex = 3;
            // 
            // labelProcessors_KNM
            // 
            labelProcessors_KNM.Anchor = AnchorStyles.Right;
            labelProcessors_KNM.AutoSize = true;
            labelProcessors_KNM.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelProcessors_KNM.Location = new Point(612, 12);
            labelProcessors_KNM.Name = "labelProcessors_KNM";
            labelProcessors_KNM.Size = new Size(176, 35);
            labelProcessors_KNM.TabIndex = 3;
            labelProcessors_KNM.Text = "Процессоры";
            // 
            // FormProcessors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewProcessors_KNM);
            Controls.Add(panelFilter_KNM);
            Controls.Add(panelTop_KNM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProcessors";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Процессоры";
            panelTop_KNM.ResumeLayout(false);
            panelTop_KNM.PerformLayout();
            panelFilter_KNM.ResumeLayout(false);
            panelFilter_KNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcessors_KNM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTipMain_KNM;
        private Panel panelTop_KNM;
        private Button buttonDeleteProcessor_KNM;
        private Button buttonAddProcessor_KNM;
        private Button buttonResetFilters_KNM;
        private TextBox textBoxCoresTo_KNM;
        private TextBox textBoxCoresFrom_KNM;
        private TextBox textBoxSearch_KNM;
        private Label labelCoresTo_KNM;
        private Label labelCoresFrom_KNM;
        private Label labelManufacturer_KNM;
        private Label labelSearch_KNM;
        private Label labelFiltersTitle_KNM;
        private Panel panelFilter_KNM;
        private DataGridView dataGridViewProcessors_KNM;
        private ComboBox comboBoxManufacturer_KNM;
        private Label labelProcessors_KNM;
    }
}