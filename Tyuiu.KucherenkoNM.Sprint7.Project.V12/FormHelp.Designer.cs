namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            tabControlHelp_KNM = new TabControl();
            tabPageUserGuide_KNM = new TabPage();
            richTextBoxUserGuide_KNM = new RichTextBox();
            tabPageAboutDeveloper_KNM = new TabPage();
            labelDeveloperInfo_KNM = new Label();
            pictureBoxDeveloper_KNM = new PictureBox();
            tabControlHelp_KNM.SuspendLayout();
            tabPageUserGuide_KNM.SuspendLayout();
            tabPageAboutDeveloper_KNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeveloper_KNM).BeginInit();
            SuspendLayout();
            // 
            // tabControlHelp_KNM
            // 
            tabControlHelp_KNM.Controls.Add(tabPageUserGuide_KNM);
            tabControlHelp_KNM.Controls.Add(tabPageAboutDeveloper_KNM);
            tabControlHelp_KNM.Dock = DockStyle.Fill;
            tabControlHelp_KNM.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tabControlHelp_KNM.Location = new Point(0, 0);
            tabControlHelp_KNM.Margin = new Padding(4);
            tabControlHelp_KNM.Name = "tabControlHelp_KNM";
            tabControlHelp_KNM.SelectedIndex = 0;
            tabControlHelp_KNM.Size = new Size(1000, 562);
            tabControlHelp_KNM.TabIndex = 0;
            // 
            // tabPageUserGuide_KNM
            // 
            tabPageUserGuide_KNM.Controls.Add(richTextBoxUserGuide_KNM);
            tabPageUserGuide_KNM.Location = new Point(4, 37);
            tabPageUserGuide_KNM.Margin = new Padding(4);
            tabPageUserGuide_KNM.Name = "tabPageUserGuide_KNM";
            tabPageUserGuide_KNM.Padding = new Padding(4);
            tabPageUserGuide_KNM.Size = new Size(992, 521);
            tabPageUserGuide_KNM.TabIndex = 0;
            tabPageUserGuide_KNM.Text = "Руководство пользователя";
            tabPageUserGuide_KNM.UseVisualStyleBackColor = true;
            // 
            // richTextBoxUserGuide_KNM
            // 
            richTextBoxUserGuide_KNM.BorderStyle = BorderStyle.None;
            richTextBoxUserGuide_KNM.Dock = DockStyle.Fill;
            richTextBoxUserGuide_KNM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxUserGuide_KNM.Location = new Point(4, 4);
            richTextBoxUserGuide_KNM.Margin = new Padding(4);
            richTextBoxUserGuide_KNM.Name = "richTextBoxUserGuide_KNM";
            richTextBoxUserGuide_KNM.ReadOnly = true;
            richTextBoxUserGuide_KNM.Size = new Size(984, 513);
            richTextBoxUserGuide_KNM.TabIndex = 0;
            richTextBoxUserGuide_KNM.Text = resources.GetString("richTextBoxUserGuide_KNM.Text");
            // 
            // tabPageAboutDeveloper_KNM
            // 
            tabPageAboutDeveloper_KNM.Controls.Add(labelDeveloperInfo_KNM);
            tabPageAboutDeveloper_KNM.Controls.Add(pictureBoxDeveloper_KNM);
            tabPageAboutDeveloper_KNM.Location = new Point(4, 37);
            tabPageAboutDeveloper_KNM.Margin = new Padding(4);
            tabPageAboutDeveloper_KNM.Name = "tabPageAboutDeveloper_KNM";
            tabPageAboutDeveloper_KNM.Padding = new Padding(4);
            tabPageAboutDeveloper_KNM.Size = new Size(992, 521);
            tabPageAboutDeveloper_KNM.TabIndex = 1;
            tabPageAboutDeveloper_KNM.Text = "О разработчике";
            tabPageAboutDeveloper_KNM.UseVisualStyleBackColor = true;
            // 
            // labelDeveloperInfo_KNM
            // 
            labelDeveloperInfo_KNM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDeveloperInfo_KNM.Location = new Point(264, 137);
            labelDeveloperInfo_KNM.Name = "labelDeveloperInfo_KNM";
            labelDeveloperInfo_KNM.Size = new Size(507, 278);
            labelDeveloperInfo_KNM.TabIndex = 1;
            labelDeveloperInfo_KNM.Text = "Разработчик: Кучеренко Надежда Михайловна\r\nГруппа: ИИПб-25-1\r\n\r\nПрограмма разработана в рамках изучения языка C#\r\n\r\nТюменский Индустриальный Университет\r\nВысшая школа цифровых технологий\r\n\r\n2025 год\r\n";
            labelDeveloperInfo_KNM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxDeveloper_KNM
            // 
            pictureBoxDeveloper_KNM.Image = (Image)resources.GetObject("pictureBoxDeveloper_KNM.Image");
            pictureBoxDeveloper_KNM.Location = new Point(77, 137);
            pictureBoxDeveloper_KNM.Name = "pictureBoxDeveloper_KNM";
            pictureBoxDeveloper_KNM.Size = new Size(146, 188);
            pictureBoxDeveloper_KNM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDeveloper_KNM.TabIndex = 0;
            pictureBoxDeveloper_KNM.TabStop = false;
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(tabControlHelp_KNM);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormHelp";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Справка";
            tabControlHelp_KNM.ResumeLayout(false);
            tabPageUserGuide_KNM.ResumeLayout(false);
            tabPageAboutDeveloper_KNM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeveloper_KNM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlHelp_KNM;
        private TabPage tabPageUserGuide_KNM;
        private TabPage tabPageAboutDeveloper_KNM;
        private RichTextBox richTextBoxUserGuide_KNM;
        private Label labelDeveloperInfo_KNM;
        private PictureBox pictureBoxDeveloper_KNM;
    }
}