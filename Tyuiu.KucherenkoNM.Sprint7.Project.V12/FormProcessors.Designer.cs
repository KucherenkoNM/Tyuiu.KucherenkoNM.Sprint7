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
            panelTop_KNM = new Panel();
            buttonDeleteProcessor_KNM = new Button();
            buttonEditProcessor_KNM = new Button();
            buttonAddProcessor_KNM = new Button();
            buttonResetFilters_KNM = new Button();
            textBoxFrequencyTo_KNM = new TextBox();
            textBoxFrequencyFrom_KNM = new TextBox();
            textBoxSearch_KNM = new TextBox();
            labelFrequencyTo_KNM = new Label();
            labelFrequencyFrom_KNM = new Label();
            labelManufacturer_KNM = new Label();
            labelSearch_KNM = new Label();
            labelFiltersTitle_KNM = new Label();
            panelFilter_KNM = new Panel();
            dataGridViewComputers_KNM = new DataGridView();
            textBoxManufacturer_KNM = new TextBox();
            panelTop_KNM.SuspendLayout();
            panelFilter_KNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComputers_KNM).BeginInit();
            SuspendLayout();
            // 
            // panelTop_KNM
            // 
            panelTop_KNM.Controls.Add(buttonDeleteProcessor_KNM);
            panelTop_KNM.Controls.Add(buttonEditProcessor_KNM);
            panelTop_KNM.Controls.Add(buttonAddProcessor_KNM);
            panelTop_KNM.Dock = DockStyle.Top;
            panelTop_KNM.Location = new Point(0, 0);
            panelTop_KNM.Name = "panelTop_KNM";
            panelTop_KNM.Size = new Size(800, 63);
            panelTop_KNM.TabIndex = 1;
            // 
            // buttonDeleteProcessor_KNM
            // 
            buttonDeleteProcessor_KNM.FlatStyle = FlatStyle.Flat;
            buttonDeleteProcessor_KNM.Image = Properties.Resources.drive_delete1;
            buttonDeleteProcessor_KNM.Location = new Point(94, 12);
            buttonDeleteProcessor_KNM.Name = "buttonDeleteProcessor_KNM";
            buttonDeleteProcessor_KNM.Size = new Size(35, 35);
            buttonDeleteProcessor_KNM.TabIndex = 2;
            toolTipMain_KNM.SetToolTip(buttonDeleteProcessor_KNM, "Удалить выбранный процессор");
            buttonDeleteProcessor_KNM.UseVisualStyleBackColor = true;
            // 
            // buttonEditProcessor_KNM
            // 
            buttonEditProcessor_KNM.FlatStyle = FlatStyle.Flat;
            buttonEditProcessor_KNM.Image = Properties.Resources.drive_edit;
            buttonEditProcessor_KNM.Location = new Point(53, 12);
            buttonEditProcessor_KNM.Name = "buttonEditProcessor_KNM";
            buttonEditProcessor_KNM.Size = new Size(35, 35);
            buttonEditProcessor_KNM.TabIndex = 1;
            toolTipMain_KNM.SetToolTip(buttonEditProcessor_KNM, "Изменить выбранный процессор");
            buttonEditProcessor_KNM.UseVisualStyleBackColor = true;
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
            // 
            // textBoxFrequencyTo_KNM
            // 
            textBoxFrequencyTo_KNM.Location = new Point(13, 261);
            textBoxFrequencyTo_KNM.Name = "textBoxFrequencyTo_KNM";
            textBoxFrequencyTo_KNM.Size = new Size(194, 27);
            textBoxFrequencyTo_KNM.TabIndex = 8;
            // 
            // textBoxFrequencyFrom_KNM
            // 
            textBoxFrequencyFrom_KNM.Location = new Point(12, 194);
            textBoxFrequencyFrom_KNM.Name = "textBoxFrequencyFrom_KNM";
            textBoxFrequencyFrom_KNM.Size = new Size(195, 27);
            textBoxFrequencyFrom_KNM.TabIndex = 7;
            // 
            // textBoxSearch_KNM
            // 
            textBoxSearch_KNM.Location = new Point(13, 67);
            textBoxSearch_KNM.Name = "textBoxSearch_KNM";
            textBoxSearch_KNM.Size = new Size(194, 27);
            textBoxSearch_KNM.TabIndex = 5;
            // 
            // labelFrequencyTo_KNM
            // 
            labelFrequencyTo_KNM.AutoSize = true;
            labelFrequencyTo_KNM.Location = new Point(53, 238);
            labelFrequencyTo_KNM.Name = "labelFrequencyTo_KNM";
            labelFrequencyTo_KNM.Size = new Size(121, 20);
            labelFrequencyTo_KNM.TabIndex = 4;
            labelFrequencyTo_KNM.Text = "Частота (ГГц) до";
            // 
            // labelFrequencyFrom_KNM
            // 
            labelFrequencyFrom_KNM.AutoSize = true;
            labelFrequencyFrom_KNM.Location = new Point(52, 171);
            labelFrequencyFrom_KNM.Name = "labelFrequencyFrom_KNM";
            labelFrequencyFrom_KNM.Size = new Size(119, 20);
            labelFrequencyFrom_KNM.TabIndex = 3;
            labelFrequencyFrom_KNM.Text = "Частота (ГГц) от";
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
            panelFilter_KNM.Controls.Add(buttonResetFilters_KNM);
            panelFilter_KNM.Controls.Add(textBoxFrequencyTo_KNM);
            panelFilter_KNM.Controls.Add(textBoxFrequencyFrom_KNM);
            panelFilter_KNM.Controls.Add(textBoxManufacturer_KNM);
            panelFilter_KNM.Controls.Add(textBoxSearch_KNM);
            panelFilter_KNM.Controls.Add(labelFrequencyTo_KNM);
            panelFilter_KNM.Controls.Add(labelFrequencyFrom_KNM);
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
            // dataGridViewComputers_KNM
            // 
            dataGridViewComputers_KNM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewComputers_KNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewComputers_KNM.Dock = DockStyle.Fill;
            dataGridViewComputers_KNM.Location = new Point(220, 63);
            dataGridViewComputers_KNM.MultiSelect = false;
            dataGridViewComputers_KNM.Name = "dataGridViewComputers_KNM";
            dataGridViewComputers_KNM.RowHeadersWidth = 51;
            dataGridViewComputers_KNM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewComputers_KNM.Size = new Size(580, 387);
            dataGridViewComputers_KNM.TabIndex = 3;
            // 
            // textBoxManufacturer_KNM
            // 
            textBoxManufacturer_KNM.Location = new Point(12, 131);
            textBoxManufacturer_KNM.Name = "textBoxManufacturer_KNM";
            textBoxManufacturer_KNM.Size = new Size(194, 27);
            textBoxManufacturer_KNM.TabIndex = 5;
            // 
            // FormProcessors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewComputers_KNM);
            Controls.Add(panelFilter_KNM);
            Controls.Add(panelTop_KNM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProcessors";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Процессоры";
            panelTop_KNM.ResumeLayout(false);
            panelFilter_KNM.ResumeLayout(false);
            panelFilter_KNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComputers_KNM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTipMain_KNM;
        private Panel panelTop_KNM;
        private Button buttonDeleteProcessor_KNM;
        private Button buttonEditProcessor_KNM;
        private Button buttonAddProcessor_KNM;
        private Button buttonResetFilters_KNM;
        private TextBox textBoxFrequencyTo_KNM;
        private TextBox textBoxFrequencyFrom_KNM;
        private ComboBox comboBoxEvmType_KNM;
        private TextBox textBoxSearch_KNM;
        private Label labelFrequencyTo_KNM;
        private Label labelFrequencyFrom_KNM;
        private Label labelManufacturer_KNM;
        private Label labelSearch_KNM;
        private Label labelFiltersTitle_KNM;
        private Panel panelFilter_KNM;
        private DataGridView dataGridViewComputers_KNM;
        private TextBox textBoxManufacturer_KNM;
    }
}