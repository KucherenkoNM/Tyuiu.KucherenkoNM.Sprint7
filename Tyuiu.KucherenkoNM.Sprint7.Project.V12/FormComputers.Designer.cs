namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    partial class FormComputers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComputers));
            panelTop_KNM = new Panel();
            labelComputer_KNM = new Label();
            buttonDeleteComputer_KNM = new Button();
            buttonAddComputer_KNM = new Button();
            panelFilter_KNM = new Panel();
            buttonResetFilters_KNM = new Button();
            textBoxPriceTo_KNM = new TextBox();
            textBoxPriceFrom_KNM = new TextBox();
            comboBoxEvmType_KNM = new ComboBox();
            textBoxSearch_KNM = new TextBox();
            labelPriceTo_KNM = new Label();
            labelPriceFrom_KNM = new Label();
            labelEvmType_KNM = new Label();
            labelSearch_KNM = new Label();
            labelFiltersTitle_KNM = new Label();
            dataGridViewComputers_KNM = new DataGridView();
            toolTipMain_KNM = new ToolTip(components);
            panelTop_KNM.SuspendLayout();
            panelFilter_KNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComputers_KNM).BeginInit();
            SuspendLayout();
            // 
            // panelTop_KNM
            // 
            panelTop_KNM.Controls.Add(labelComputer_KNM);
            panelTop_KNM.Controls.Add(buttonDeleteComputer_KNM);
            panelTop_KNM.Controls.Add(buttonAddComputer_KNM);
            panelTop_KNM.Dock = DockStyle.Top;
            panelTop_KNM.Location = new Point(0, 0);
            panelTop_KNM.Name = "panelTop_KNM";
            panelTop_KNM.Size = new Size(800, 63);
            panelTop_KNM.TabIndex = 0;
            // 
            // labelComputer_KNM
            // 
            labelComputer_KNM.Anchor = AnchorStyles.Right;
            labelComputer_KNM.AutoSize = true;
            labelComputer_KNM.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelComputer_KNM.Location = new Point(602, 12);
            labelComputer_KNM.Name = "labelComputer_KNM";
            labelComputer_KNM.Size = new Size(186, 35);
            labelComputer_KNM.TabIndex = 3;
            labelComputer_KNM.Text = "Компьютеры";
            // 
            // buttonDeleteComputer_KNM
            // 
            buttonDeleteComputer_KNM.FlatStyle = FlatStyle.Flat;
            buttonDeleteComputer_KNM.Image = (Image)resources.GetObject("buttonDeleteComputer_KNM.Image");
            buttonDeleteComputer_KNM.Location = new Point(53, 12);
            buttonDeleteComputer_KNM.Name = "buttonDeleteComputer_KNM";
            buttonDeleteComputer_KNM.Size = new Size(35, 35);
            buttonDeleteComputer_KNM.TabIndex = 2;
            toolTipMain_KNM.SetToolTip(buttonDeleteComputer_KNM, "Удалить выбранный компьютер");
            buttonDeleteComputer_KNM.UseVisualStyleBackColor = true;
            buttonDeleteComputer_KNM.Click += buttonDeleteComputer_KNM_Click;
            // 
            // buttonAddComputer_KNM
            // 
            buttonAddComputer_KNM.FlatStyle = FlatStyle.Flat;
            buttonAddComputer_KNM.Image = (Image)resources.GetObject("buttonAddComputer_KNM.Image");
            buttonAddComputer_KNM.Location = new Point(12, 12);
            buttonAddComputer_KNM.Name = "buttonAddComputer_KNM";
            buttonAddComputer_KNM.Size = new Size(35, 35);
            buttonAddComputer_KNM.TabIndex = 0;
            toolTipMain_KNM.SetToolTip(buttonAddComputer_KNM, "Добавить компьютер");
            buttonAddComputer_KNM.UseVisualStyleBackColor = true;
            buttonAddComputer_KNM.Click += buttonAddComputer_KNM_Click;
            // 
            // panelFilter_KNM
            // 
            panelFilter_KNM.BackColor = SystemColors.ControlLight;
            panelFilter_KNM.Controls.Add(buttonResetFilters_KNM);
            panelFilter_KNM.Controls.Add(textBoxPriceTo_KNM);
            panelFilter_KNM.Controls.Add(textBoxPriceFrom_KNM);
            panelFilter_KNM.Controls.Add(comboBoxEvmType_KNM);
            panelFilter_KNM.Controls.Add(textBoxSearch_KNM);
            panelFilter_KNM.Controls.Add(labelPriceTo_KNM);
            panelFilter_KNM.Controls.Add(labelPriceFrom_KNM);
            panelFilter_KNM.Controls.Add(labelEvmType_KNM);
            panelFilter_KNM.Controls.Add(labelSearch_KNM);
            panelFilter_KNM.Controls.Add(labelFiltersTitle_KNM);
            panelFilter_KNM.Dock = DockStyle.Left;
            panelFilter_KNM.Location = new Point(0, 63);
            panelFilter_KNM.Name = "panelFilter_KNM";
            panelFilter_KNM.Padding = new Padding(10);
            panelFilter_KNM.Size = new Size(220, 387);
            panelFilter_KNM.TabIndex = 1;
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
            // textBoxPriceTo_KNM
            // 
            textBoxPriceTo_KNM.Location = new Point(13, 261);
            textBoxPriceTo_KNM.Name = "textBoxPriceTo_KNM";
            textBoxPriceTo_KNM.Size = new Size(194, 27);
            textBoxPriceTo_KNM.TabIndex = 8;
            textBoxPriceTo_KNM.TextChanged += textBoxPriceTo_KNM_TextChanged;
            // 
            // textBoxPriceFrom_KNM
            // 
            textBoxPriceFrom_KNM.Location = new Point(12, 194);
            textBoxPriceFrom_KNM.Name = "textBoxPriceFrom_KNM";
            textBoxPriceFrom_KNM.Size = new Size(195, 27);
            textBoxPriceFrom_KNM.TabIndex = 7;
            textBoxPriceFrom_KNM.TextChanged += textBoxPriceFrom_KNM_TextChanged;
            // 
            // comboBoxEvmType_KNM
            // 
            comboBoxEvmType_KNM.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEvmType_KNM.FormattingEnabled = true;
            comboBoxEvmType_KNM.Location = new Point(12, 131);
            comboBoxEvmType_KNM.Name = "comboBoxEvmType_KNM";
            comboBoxEvmType_KNM.Size = new Size(195, 28);
            comboBoxEvmType_KNM.TabIndex = 6;
            comboBoxEvmType_KNM.SelectedIndexChanged += comboBoxEvmType_KNM_SelectedIndexChanged;
            // 
            // textBoxSearch_KNM
            // 
            textBoxSearch_KNM.Location = new Point(13, 67);
            textBoxSearch_KNM.Name = "textBoxSearch_KNM";
            textBoxSearch_KNM.Size = new Size(194, 27);
            textBoxSearch_KNM.TabIndex = 5;
            textBoxSearch_KNM.TextChanged += textBoxSearch_KNM_TextChanged;
            // 
            // labelPriceTo_KNM
            // 
            labelPriceTo_KNM.AutoSize = true;
            labelPriceTo_KNM.Location = new Point(75, 238);
            labelPriceTo_KNM.Name = "labelPriceTo_KNM";
            labelPriceTo_KNM.Size = new Size(66, 20);
            labelPriceTo_KNM.TabIndex = 4;
            labelPriceTo_KNM.Text = "Цена до";
            // 
            // labelPriceFrom_KNM
            // 
            labelPriceFrom_KNM.AutoSize = true;
            labelPriceFrom_KNM.Location = new Point(77, 171);
            labelPriceFrom_KNM.Name = "labelPriceFrom_KNM";
            labelPriceFrom_KNM.Size = new Size(64, 20);
            labelPriceFrom_KNM.TabIndex = 3;
            labelPriceFrom_KNM.Text = "Цена от";
            // 
            // labelEvmType_KNM
            // 
            labelEvmType_KNM.AutoSize = true;
            labelEvmType_KNM.Location = new Point(71, 108);
            labelEvmType_KNM.Name = "labelEvmType_KNM";
            labelEvmType_KNM.Size = new Size(70, 20);
            labelEvmType_KNM.TabIndex = 2;
            labelEvmType_KNM.Text = "Тип ЭВМ";
            // 
            // labelSearch_KNM
            // 
            labelSearch_KNM.AutoSize = true;
            labelSearch_KNM.Location = new Point(81, 44);
            labelSearch_KNM.Name = "labelSearch_KNM";
            labelSearch_KNM.Size = new Size(52, 20);
            labelSearch_KNM.TabIndex = 1;
            labelSearch_KNM.Text = "Поиск";
            // 
            // labelFiltersTitle_KNM
            // 
            labelFiltersTitle_KNM.AutoSize = true;
            labelFiltersTitle_KNM.Font = new Font("Segoe UI", 12F);
            labelFiltersTitle_KNM.Location = new Point(63, 10);
            labelFiltersTitle_KNM.Name = "labelFiltersTitle_KNM";
            labelFiltersTitle_KNM.Size = new Size(94, 28);
            labelFiltersTitle_KNM.TabIndex = 0;
            labelFiltersTitle_KNM.Text = "Фильтры";
            // 
            // dataGridViewComputers_KNM
            // 
            dataGridViewComputers_KNM.AllowUserToAddRows = false;
            dataGridViewComputers_KNM.AllowUserToDeleteRows = false;
            dataGridViewComputers_KNM.AllowUserToResizeRows = false;
            dataGridViewComputers_KNM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewComputers_KNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewComputers_KNM.Dock = DockStyle.Fill;
            dataGridViewComputers_KNM.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewComputers_KNM.Location = new Point(220, 63);
            dataGridViewComputers_KNM.MultiSelect = false;
            dataGridViewComputers_KNM.Name = "dataGridViewComputers_KNM";
            dataGridViewComputers_KNM.RowHeadersWidth = 51;
            dataGridViewComputers_KNM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewComputers_KNM.Size = new Size(580, 387);
            dataGridViewComputers_KNM.TabIndex = 2;
            // 
            // FormComputers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewComputers_KNM);
            Controls.Add(panelFilter_KNM);
            Controls.Add(panelTop_KNM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormComputers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Компьютеры";
            panelTop_KNM.ResumeLayout(false);
            panelTop_KNM.PerformLayout();
            panelFilter_KNM.ResumeLayout(false);
            panelFilter_KNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComputers_KNM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KNM;
        private Button buttonDeleteComputer_KNM;
        private Button buttonAddComputer_KNM;
        private Panel panelFilter_KNM;
        private DataGridView dataGridViewComputers_KNM;
        private ToolTip toolTipMain_KNM;
        private Label labelPriceTo_KNM;
        private Label labelPriceFrom_KNM;
        private Label labelEvmType_KNM;
        private Label labelSearch_KNM;
        private Label labelFiltersTitle_KNM;
        private TextBox textBoxSearch_KNM;
        private ComboBox comboBoxEvmType_KNM;
        private TextBox textBoxPriceFrom_KNM;
        private Button buttonResetFilters_KNM;
        private TextBox textBoxPriceTo_KNM;
        private Label labelComputer_KNM;
    }
}