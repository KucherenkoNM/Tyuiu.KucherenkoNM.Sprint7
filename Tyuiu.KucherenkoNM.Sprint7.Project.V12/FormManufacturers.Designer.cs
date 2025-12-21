namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    partial class FormManufacturers
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
            buttonDeleteManufacturer_KNM = new Button();
            buttonEditManufacturer_KNM = new Button();
            buttonAddManufacturer_KNM = new Button();
            toolTipMain_KNM = new ToolTip(components);
            panelFilter_KNM = new Panel();
            buttonResetFilters_KNM = new Button();
            textBoxCountry_KNM = new TextBox();
            textBoxSearch_KNM = new TextBox();
            labelCountry_KNM = new Label();
            labelSearch_KNM = new Label();
            labelFiltersTitle_KNM = new Label();
            dataGridViewManufacturer_KNM = new DataGridView();
            panelTop_KNM.SuspendLayout();
            panelFilter_KNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManufacturer_KNM).BeginInit();
            SuspendLayout();
            // 
            // panelTop_KNM
            // 
            panelTop_KNM.Controls.Add(buttonDeleteManufacturer_KNM);
            panelTop_KNM.Controls.Add(buttonEditManufacturer_KNM);
            panelTop_KNM.Controls.Add(buttonAddManufacturer_KNM);
            panelTop_KNM.Dock = DockStyle.Top;
            panelTop_KNM.Location = new Point(0, 0);
            panelTop_KNM.Name = "panelTop_KNM";
            panelTop_KNM.Size = new Size(800, 63);
            panelTop_KNM.TabIndex = 0;
            // 
            // buttonDeleteManufacturer_KNM
            // 
            buttonDeleteManufacturer_KNM.FlatStyle = FlatStyle.Flat;
            buttonDeleteManufacturer_KNM.Image = Properties.Resources.application_delete;
            buttonDeleteManufacturer_KNM.Location = new Point(94, 12);
            buttonDeleteManufacturer_KNM.Name = "buttonDeleteManufacturer_KNM";
            buttonDeleteManufacturer_KNM.Size = new Size(35, 35);
            buttonDeleteManufacturer_KNM.TabIndex = 0;
            toolTipMain_KNM.SetToolTip(buttonDeleteManufacturer_KNM, "Удалить выбранную фирму-изготовителя");
            buttonDeleteManufacturer_KNM.UseVisualStyleBackColor = true;
            // 
            // buttonEditManufacturer_KNM
            // 
            buttonEditManufacturer_KNM.FlatStyle = FlatStyle.Flat;
            buttonEditManufacturer_KNM.Image = Properties.Resources.application_edit;
            buttonEditManufacturer_KNM.Location = new Point(53, 12);
            buttonEditManufacturer_KNM.Name = "buttonEditManufacturer_KNM";
            buttonEditManufacturer_KNM.Size = new Size(35, 35);
            buttonEditManufacturer_KNM.TabIndex = 0;
            toolTipMain_KNM.SetToolTip(buttonEditManufacturer_KNM, "Изменить выбранную фирму-изготовителя");
            buttonEditManufacturer_KNM.UseVisualStyleBackColor = true;
            // 
            // buttonAddManufacturer_KNM
            // 
            buttonAddManufacturer_KNM.FlatStyle = FlatStyle.Flat;
            buttonAddManufacturer_KNM.Image = Properties.Resources.application_add;
            buttonAddManufacturer_KNM.Location = new Point(12, 12);
            buttonAddManufacturer_KNM.Name = "buttonAddManufacturer_KNM";
            buttonAddManufacturer_KNM.Size = new Size(35, 35);
            buttonAddManufacturer_KNM.TabIndex = 0;
            toolTipMain_KNM.SetToolTip(buttonAddManufacturer_KNM, "Добавить фирму-изготовителя");
            buttonAddManufacturer_KNM.UseVisualStyleBackColor = true;
            // 
            // panelFilter_KNM
            // 
            panelFilter_KNM.BackColor = SystemColors.ControlLight;
            panelFilter_KNM.Controls.Add(buttonResetFilters_KNM);
            panelFilter_KNM.Controls.Add(textBoxCountry_KNM);
            panelFilter_KNM.Controls.Add(textBoxSearch_KNM);
            panelFilter_KNM.Controls.Add(labelCountry_KNM);
            panelFilter_KNM.Controls.Add(labelSearch_KNM);
            panelFilter_KNM.Controls.Add(labelFiltersTitle_KNM);
            panelFilter_KNM.Dock = DockStyle.Left;
            panelFilter_KNM.Location = new Point(0, 63);
            panelFilter_KNM.Name = "panelFilter_KNM";
            panelFilter_KNM.Padding = new Padding(10);
            panelFilter_KNM.Size = new Size(220, 387);
            panelFilter_KNM.TabIndex = 2;
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
            // textBoxCountry_KNM
            // 
            textBoxCountry_KNM.Location = new Point(13, 156);
            textBoxCountry_KNM.Name = "textBoxCountry_KNM";
            textBoxCountry_KNM.Size = new Size(194, 27);
            textBoxCountry_KNM.TabIndex = 5;
            // 
            // textBoxSearch_KNM
            // 
            textBoxSearch_KNM.Location = new Point(13, 80);
            textBoxSearch_KNM.Name = "textBoxSearch_KNM";
            textBoxSearch_KNM.Size = new Size(194, 27);
            textBoxSearch_KNM.TabIndex = 5;
            // 
            // labelCountry_KNM
            // 
            labelCountry_KNM.AutoSize = true;
            labelCountry_KNM.Location = new Point(79, 133);
            labelCountry_KNM.Name = "labelCountry_KNM";
            labelCountry_KNM.Size = new Size(58, 20);
            labelCountry_KNM.TabIndex = 2;
            labelCountry_KNM.Text = "Страна";
            // 
            // labelSearch_KNM
            // 
            labelSearch_KNM.AutoSize = true;
            labelSearch_KNM.Location = new Point(79, 57);
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
            // dataGridViewManufacturer_KNM
            // 
            dataGridViewManufacturer_KNM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewManufacturer_KNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewManufacturer_KNM.Dock = DockStyle.Fill;
            dataGridViewManufacturer_KNM.Location = new Point(220, 63);
            dataGridViewManufacturer_KNM.MultiSelect = false;
            dataGridViewManufacturer_KNM.Name = "dataGridViewManufacturer_KNM";
            dataGridViewManufacturer_KNM.RowHeadersWidth = 51;
            dataGridViewManufacturer_KNM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewManufacturer_KNM.Size = new Size(580, 387);
            dataGridViewManufacturer_KNM.TabIndex = 3;
            // 
            // FormManufacturers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewManufacturer_KNM);
            Controls.Add(panelFilter_KNM);
            Controls.Add(panelTop_KNM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormManufacturers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Фирмы-изготовители";
            panelTop_KNM.ResumeLayout(false);
            panelFilter_KNM.ResumeLayout(false);
            panelFilter_KNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManufacturer_KNM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KNM;
        private Button buttonAddManufacturer_KNM;
        private Button buttonDeleteManufacturer_KNM;
        private Button buttonEditManufacturer_KNM;
        private ToolTip toolTipMain_KNM;
        private Panel panelFilter_KNM;
        private Button buttonResetFilters_KNM;
        private TextBox textBoxSearch_KNM;
        private Label labelCountry_KNM;
        private Label labelSearch_KNM;
        private Label labelFiltersTitle_KNM;
        private DataGridView dataGridViewManufacturer_KNM;
        private TextBox textBoxCountry_KNM;
    }
}