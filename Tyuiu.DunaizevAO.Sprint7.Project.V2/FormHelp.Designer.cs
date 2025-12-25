namespace Tyuiu.DunaizevAO.Sprint7.Project.V2
{
    partial class FormHelp_DAO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp_DAO));
            labelName_DAO = new Label();
            panelName_DAO = new Panel();
            panelText_DAO = new Panel();
            buttonOK_DAO = new Button();
            textBoxText_DAO = new TextBox();
            panelName_DAO.SuspendLayout();
            panelText_DAO.SuspendLayout();
            SuspendLayout();
            // 
            // labelName_DAO
            // 
            labelName_DAO.AutoSize = true;
            labelName_DAO.Font = new Font("Segoe UI", 15F);
            labelName_DAO.Location = new Point(12, 8);
            labelName_DAO.Name = "labelName_DAO";
            labelName_DAO.Size = new Size(485, 28);
            labelName_DAO.TabIndex = 0;
            labelName_DAO.Text = "Корпоративное приложение сети магазинов Dunai";
            // 
            // panelName_DAO
            // 
            panelName_DAO.Controls.Add(labelName_DAO);
            panelName_DAO.Dock = DockStyle.Top;
            panelName_DAO.Location = new Point(0, 0);
            panelName_DAO.Name = "panelName_DAO";
            panelName_DAO.Size = new Size(544, 54);
            panelName_DAO.TabIndex = 1;
            // 
            // panelText_DAO
            // 
            panelText_DAO.BackColor = SystemColors.Control;
            panelText_DAO.Controls.Add(buttonOK_DAO);
            panelText_DAO.Controls.Add(textBoxText_DAO);
            panelText_DAO.Dock = DockStyle.Fill;
            panelText_DAO.Location = new Point(0, 54);
            panelText_DAO.Name = "panelText_DAO";
            panelText_DAO.Size = new Size(544, 380);
            panelText_DAO.TabIndex = 2;
            // 
            // buttonOK_DAO
            // 
            buttonOK_DAO.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK_DAO.Location = new Point(472, 345);
            buttonOK_DAO.Name = "buttonOK_DAO";
            buttonOK_DAO.Size = new Size(60, 23);
            buttonOK_DAO.TabIndex = 1;
            buttonOK_DAO.Text = "OK";
            buttonOK_DAO.UseVisualStyleBackColor = true;
            buttonOK_DAO.Click += buttonOK_Click;
            // 
            // textBoxText_DAO
            // 
            textBoxText_DAO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxText_DAO.BackColor = SystemColors.ControlLight;
            textBoxText_DAO.BorderStyle = BorderStyle.FixedSingle;
            textBoxText_DAO.Location = new Point(0, 0);
            textBoxText_DAO.Multiline = true;
            textBoxText_DAO.Name = "textBoxText_DAO";
            textBoxText_DAO.ReadOnly = true;
            textBoxText_DAO.ScrollBars = ScrollBars.Vertical;
            textBoxText_DAO.Size = new Size(532, 339);
            textBoxText_DAO.TabIndex = 0;
            textBoxText_DAO.Text = resources.GetString("textBoxText_DAO.Text");
            // 
            // FormHelp_DAO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 434);
            Controls.Add(panelText_DAO);
            Controls.Add(panelName_DAO);
            Name = "FormHelp_DAO";
            Text = "Краткое руководство пользователя";
            panelName_DAO.ResumeLayout(false);
            panelName_DAO.PerformLayout();
            panelText_DAO.ResumeLayout(false);
            panelText_DAO.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelName_DAO;
        private Panel panelName_DAO;
        private Panel panelText_DAO;
        private TextBox textBoxText_DAO;
        private Button buttonOK_DAO;
    }
}