namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    partial class FormStatistics
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
            comboBoxEvmType_KNM = new ComboBox();
            panelFilters_KNM = new Panel();
            labelEvmType_KNM = new Label();
            labelFiltersTitle_KNM = new Label();
            panelStatistics_KNM = new Panel();
            labelSumValue_KNM = new Label();
            labelAverageValue_KNM = new Label();
            labelMaxValue_KNM = new Label();
            labelMinValue_KNM = new Label();
            labelCountValue_KNM = new Label();
            labelSumTitle_KNM = new Label();
            labelAverageTitle_KNM = new Label();
            labelMaxTitle_KNM = new Label();
            labelMinTitle_KNM = new Label();
            labelCountTitle_KNM = new Label();
            panelFilters_KNM.SuspendLayout();
            panelStatistics_KNM.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxEvmType_KNM
            // 
            comboBoxEvmType_KNM.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEvmType_KNM.FormattingEnabled = true;
            comboBoxEvmType_KNM.Location = new Point(26, 102);
            comboBoxEvmType_KNM.Name = "comboBoxEvmType_KNM";
            comboBoxEvmType_KNM.Size = new Size(211, 28);
            comboBoxEvmType_KNM.TabIndex = 2;
            toolTipMain_KNM.SetToolTip(comboBoxEvmType_KNM, "Фильтрация по типу ЭВМ");
            // 
            // panelFilters_KNM
            // 
            panelFilters_KNM.Controls.Add(comboBoxEvmType_KNM);
            panelFilters_KNM.Controls.Add(labelEvmType_KNM);
            panelFilters_KNM.Controls.Add(labelFiltersTitle_KNM);
            panelFilters_KNM.Dock = DockStyle.Left;
            panelFilters_KNM.Location = new Point(0, 0);
            panelFilters_KNM.Name = "panelFilters_KNM";
            panelFilters_KNM.Size = new Size(260, 450);
            panelFilters_KNM.TabIndex = 0;
            // 
            // labelEvmType_KNM
            // 
            labelEvmType_KNM.AutoSize = true;
            labelEvmType_KNM.Location = new Point(86, 59);
            labelEvmType_KNM.Margin = new Padding(5);
            labelEvmType_KNM.Name = "labelEvmType_KNM";
            labelEvmType_KNM.Size = new Size(70, 20);
            labelEvmType_KNM.TabIndex = 1;
            labelEvmType_KNM.Text = "Тип ЭВМ";
            // 
            // labelFiltersTitle_KNM
            // 
            labelFiltersTitle_KNM.AutoSize = true;
            labelFiltersTitle_KNM.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelFiltersTitle_KNM.Location = new Point(26, 10);
            labelFiltersTitle_KNM.Name = "labelFiltersTitle_KNM";
            labelFiltersTitle_KNM.Size = new Size(211, 28);
            labelFiltersTitle_KNM.TabIndex = 0;
            labelFiltersTitle_KNM.Text = "Параметры анализа";
            // 
            // panelStatistics_KNM
            // 
            panelStatistics_KNM.Controls.Add(labelSumValue_KNM);
            panelStatistics_KNM.Controls.Add(labelAverageValue_KNM);
            panelStatistics_KNM.Controls.Add(labelMaxValue_KNM);
            panelStatistics_KNM.Controls.Add(labelMinValue_KNM);
            panelStatistics_KNM.Controls.Add(labelCountValue_KNM);
            panelStatistics_KNM.Controls.Add(labelSumTitle_KNM);
            panelStatistics_KNM.Controls.Add(labelAverageTitle_KNM);
            panelStatistics_KNM.Controls.Add(labelMaxTitle_KNM);
            panelStatistics_KNM.Controls.Add(labelMinTitle_KNM);
            panelStatistics_KNM.Controls.Add(labelCountTitle_KNM);
            panelStatistics_KNM.Dock = DockStyle.Fill;
            panelStatistics_KNM.Location = new Point(260, 0);
            panelStatistics_KNM.Name = "panelStatistics_KNM";
            panelStatistics_KNM.Padding = new Padding(20);
            panelStatistics_KNM.Size = new Size(540, 450);
            panelStatistics_KNM.TabIndex = 1;
            // 
            // labelSumValue_KNM
            // 
            labelSumValue_KNM.AutoSize = true;
            labelSumValue_KNM.Font = new Font("Segoe UI", 12F);
            labelSumValue_KNM.Location = new Point(296, 307);
            labelSumValue_KNM.Name = "labelSumValue_KNM";
            labelSumValue_KNM.Size = new Size(23, 28);
            labelSumValue_KNM.TabIndex = 1;
            labelSumValue_KNM.Text = "0";
            // 
            // labelAverageValue_KNM
            // 
            labelAverageValue_KNM.AutoSize = true;
            labelAverageValue_KNM.Font = new Font("Segoe UI", 12F);
            labelAverageValue_KNM.Location = new Point(296, 252);
            labelAverageValue_KNM.Name = "labelAverageValue_KNM";
            labelAverageValue_KNM.Size = new Size(23, 28);
            labelAverageValue_KNM.TabIndex = 1;
            labelAverageValue_KNM.Text = "0";
            // 
            // labelMaxValue_KNM
            // 
            labelMaxValue_KNM.AutoSize = true;
            labelMaxValue_KNM.Font = new Font("Segoe UI", 12F);
            labelMaxValue_KNM.Location = new Point(296, 197);
            labelMaxValue_KNM.Name = "labelMaxValue_KNM";
            labelMaxValue_KNM.Size = new Size(23, 28);
            labelMaxValue_KNM.TabIndex = 1;
            labelMaxValue_KNM.Text = "0";
            // 
            // labelMinValue_KNM
            // 
            labelMinValue_KNM.AutoSize = true;
            labelMinValue_KNM.Font = new Font("Segoe UI", 12F);
            labelMinValue_KNM.Location = new Point(296, 146);
            labelMinValue_KNM.Name = "labelMinValue_KNM";
            labelMinValue_KNM.Size = new Size(23, 28);
            labelMinValue_KNM.TabIndex = 1;
            labelMinValue_KNM.Text = "0";
            // 
            // labelCountValue_KNM
            // 
            labelCountValue_KNM.AutoSize = true;
            labelCountValue_KNM.Font = new Font("Segoe UI", 12F);
            labelCountValue_KNM.Location = new Point(296, 98);
            labelCountValue_KNM.Name = "labelCountValue_KNM";
            labelCountValue_KNM.Size = new Size(23, 28);
            labelCountValue_KNM.TabIndex = 1;
            labelCountValue_KNM.Text = "0";
            // 
            // labelSumTitle_KNM
            // 
            labelSumTitle_KNM.AutoSize = true;
            labelSumTitle_KNM.Font = new Font("Segoe UI", 12F);
            labelSumTitle_KNM.Location = new Point(74, 304);
            labelSumTitle_KNM.Name = "labelSumTitle_KNM";
            labelSumTitle_KNM.Size = new Size(81, 28);
            labelSumTitle_KNM.TabIndex = 0;
            labelSumTitle_KNM.Text = "Сумма: ";
            // 
            // labelAverageTitle_KNM
            // 
            labelAverageTitle_KNM.AutoSize = true;
            labelAverageTitle_KNM.Font = new Font("Segoe UI", 12F);
            labelAverageTitle_KNM.Location = new Point(74, 249);
            labelAverageTitle_KNM.Name = "labelAverageTitle_KNM";
            labelAverageTitle_KNM.Size = new Size(93, 28);
            labelAverageTitle_KNM.TabIndex = 0;
            labelAverageTitle_KNM.Text = "Среднее:";
            // 
            // labelMaxTitle_KNM
            // 
            labelMaxTitle_KNM.AutoSize = true;
            labelMaxTitle_KNM.Font = new Font("Segoe UI", 12F);
            labelMaxTitle_KNM.Location = new Point(74, 194);
            labelMaxTitle_KNM.Name = "labelMaxTitle_KNM";
            labelMaxTitle_KNM.Size = new Size(113, 28);
            labelMaxTitle_KNM.TabIndex = 0;
            labelMaxTitle_KNM.Text = "Максимум:";
            // 
            // labelMinTitle_KNM
            // 
            labelMinTitle_KNM.AutoSize = true;
            labelMinTitle_KNM.Font = new Font("Segoe UI", 12F);
            labelMinTitle_KNM.Location = new Point(74, 143);
            labelMinTitle_KNM.Name = "labelMinTitle_KNM";
            labelMinTitle_KNM.Size = new Size(113, 28);
            labelMinTitle_KNM.TabIndex = 0;
            labelMinTitle_KNM.Text = "Минимум: ";
            // 
            // labelCountTitle_KNM
            // 
            labelCountTitle_KNM.AutoSize = true;
            labelCountTitle_KNM.Font = new Font("Segoe UI", 12F);
            labelCountTitle_KNM.Location = new Point(74, 95);
            labelCountTitle_KNM.Name = "labelCountTitle_KNM";
            labelCountTitle_KNM.Size = new Size(129, 28);
            labelCountTitle_KNM.TabIndex = 0;
            labelCountTitle_KNM.Text = "Количество: ";
            // 
            // FormStatistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelStatistics_KNM);
            Controls.Add(panelFilters_KNM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormStatistics";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Статистика";
            panelFilters_KNM.ResumeLayout(false);
            panelFilters_KNM.PerformLayout();
            panelStatistics_KNM.ResumeLayout(false);
            panelStatistics_KNM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTipMain_KNM;
        private Panel panelFilters_KNM;
        private Label labelFiltersTitle_KNM;
        private ComboBox comboBoxEvmType_KNM;
        private Label labelEvmType_KNM;
        private Panel panelStatistics_KNM;
        private Label labelCountValue_KNM;
        private Label labelCountTitle_KNM;
        private Label labelSumValue_KNM;
        private Label labelAverageValue_KNM;
        private Label labelMaxValue_KNM;
        private Label labelMinValue_KNM;
        private Label labelSumTitle_KNM;
        private Label labelAverageTitle_KNM;
        private Label labelMaxTitle_KNM;
        private Label labelMinTitle_KNM;
    }
}