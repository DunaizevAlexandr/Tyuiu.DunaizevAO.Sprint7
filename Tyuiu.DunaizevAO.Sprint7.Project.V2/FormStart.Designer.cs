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
            components = new System.ComponentModel.Container();
            textBoxName_DAO = new TextBox();
            buttonHelp_DAO = new Button();
            buttonStart_DAO = new Button();
            buttonAbout_DAO = new Button();
            toolTipButton_DAO = new ToolTip(components);
            SuspendLayout();
            // 
            // textBoxName_DAO
            // 
            textBoxName_DAO.BackColor = SystemColors.Menu;
            textBoxName_DAO.BorderStyle = BorderStyle.None;
            textBoxName_DAO.Font = new Font("Segoe UI", 25F);
            textBoxName_DAO.Location = new Point(12, 37);
            textBoxName_DAO.Name = "textBoxName_DAO";
            textBoxName_DAO.ReadOnly = true;
            textBoxName_DAO.Size = new Size(639, 45);
            textBoxName_DAO.TabIndex = 0;
            textBoxName_DAO.Text = "Сеть Магазинов Dunai";
            textBoxName_DAO.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonHelp_DAO
            // 
            buttonHelp_DAO.Cursor = Cursors.Hand;
            buttonHelp_DAO.Font = new Font("Segoe UI", 11F);
            buttonHelp_DAO.Location = new Point(71, 202);
            buttonHelp_DAO.Name = "buttonHelp_DAO";
            buttonHelp_DAO.Size = new Size(138, 86);
            buttonHelp_DAO.TabIndex = 1;
            buttonHelp_DAO.Text = "Руководство пользователя";
            toolTipButton_DAO.SetToolTip(buttonHelp_DAO, "Открыть окно с краткой вспомогательной информацией\r\n");
            buttonHelp_DAO.UseVisualStyleBackColor = true;
            buttonHelp_DAO.Click += buttonHelp_Click;
            buttonHelp_DAO.MouseEnter += buttonHelp_DAO_MouseEnter;
            // 
            // buttonStart_DAO
            // 
            buttonStart_DAO.Cursor = Cursors.Hand;
            buttonStart_DAO.Font = new Font("Segoe UI", 11F);
            buttonStart_DAO.Location = new Point(262, 202);
            buttonStart_DAO.Name = "buttonStart_DAO";
            buttonStart_DAO.Size = new Size(138, 86);
            buttonStart_DAO.TabIndex = 2;
            buttonStart_DAO.Text = "Главное меню";
            toolTipButton_DAO.SetToolTip(buttonStart_DAO, "Открыть главное окно с таблицей");
            buttonStart_DAO.UseVisualStyleBackColor = true;
            buttonStart_DAO.Click += buttonStart_Click;
            buttonStart_DAO.MouseEnter += buttonStart_DAO_MouseEnter;
            // 
            // buttonAbout_DAO
            // 
            buttonAbout_DAO.Cursor = Cursors.Hand;
            buttonAbout_DAO.Font = new Font("Segoe UI", 11F);
            buttonAbout_DAO.Location = new Point(453, 202);
            buttonAbout_DAO.Name = "buttonAbout_DAO";
            buttonAbout_DAO.Size = new Size(138, 86);
            buttonAbout_DAO.TabIndex = 3;
            buttonAbout_DAO.Text = "Справка";
            toolTipButton_DAO.SetToolTip(buttonAbout_DAO, "Открыть окно с информацией о программе");
            buttonAbout_DAO.UseVisualStyleBackColor = true;
            buttonAbout_DAO.Click += buttonAbout_Click;
            buttonAbout_DAO.MouseEnter += buttonAbout_DAO_MouseEnter;
            // 
            // toolTipButton_DAO
            // 
            toolTipButton_DAO.IsBalloon = true;
            toolTipButton_DAO.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton_DAO.ToolTipTitle = "Подсказка";
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 339);
            Controls.Add(buttonAbout_DAO);
            Controls.Add(buttonStart_DAO);
            Controls.Add(buttonHelp_DAO);
            Controls.Add(textBoxName_DAO);
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

        private TextBox textBoxName_DAO;
        private Button buttonHelp_DAO;
        private Button buttonStart_DAO;
        private Button buttonAbout_DAO;
        private ToolTip toolTipButton_DAO;
    }
}
