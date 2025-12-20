namespace Tyuiu.DunaizevAO.Sprint7.Project.V2
{
    partial class FormStart
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
            textBoxName = new TextBox();
            buttonHelp = new Button();
            buttonStart = new Button();
            buttonAbout = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.Menu;
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Segoe UI", 25F);
            textBoxName.Location = new Point(12, 37);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(639, 45);
            textBoxName.TabIndex = 0;
            textBoxName.Text = "Сеть Магазинов Dunai";
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonHelp
            // 
            buttonHelp.Font = new Font("Segoe UI", 11F);
            buttonHelp.Location = new Point(71, 202);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(138, 86);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Руководство пользователя";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Segoe UI", 11F);
            buttonStart.Location = new Point(262, 202);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(138, 86);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Главное меню";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.Font = new Font("Segoe UI", 11F);
            buttonAbout.Location = new Point(453, 202);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(138, 86);
            buttonAbout.TabIndex = 3;
            buttonAbout.Text = "Справка";
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 339);
            Controls.Add(buttonAbout);
            Controls.Add(buttonStart);
            Controls.Add(buttonHelp);
            Controls.Add(textBoxName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Проект | Дунайцев А.О.";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Button buttonHelp;
        private Button buttonStart;
        private Button buttonAbout;
    }
}
