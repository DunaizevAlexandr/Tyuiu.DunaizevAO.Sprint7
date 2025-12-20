namespace Tyuiu.DunaizevAO.Sprint7.Project.V2
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
            labelName = new Label();
            panelName = new Panel();
            panelText = new Panel();
            buttonOK = new Button();
            textBoxText = new TextBox();
            panelName.SuspendLayout();
            panelText.SuspendLayout();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 15F);
            labelName.Location = new Point(12, 8);
            labelName.Name = "labelName";
            labelName.Size = new Size(485, 28);
            labelName.TabIndex = 0;
            labelName.Text = "Корпоративное приложение сети магазинов Dunai";
            // 
            // panelName
            // 
            panelName.Controls.Add(labelName);
            panelName.Dock = DockStyle.Top;
            panelName.Location = new Point(0, 0);
            panelName.Name = "panelName";
            panelName.Size = new Size(544, 54);
            panelName.TabIndex = 1;
            // 
            // panelText
            // 
            panelText.BackColor = SystemColors.Control;
            panelText.Controls.Add(buttonOK);
            panelText.Controls.Add(textBoxText);
            panelText.Dock = DockStyle.Fill;
            panelText.Location = new Point(0, 54);
            panelText.Name = "panelText";
            panelText.Size = new Size(544, 380);
            panelText.TabIndex = 2;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK.Location = new Point(472, 345);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(60, 23);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // textBoxText
            // 
            textBoxText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxText.BackColor = SystemColors.ControlLight;
            textBoxText.BorderStyle = BorderStyle.FixedSingle;
            textBoxText.Location = new Point(0, 0);
            textBoxText.Multiline = true;
            textBoxText.Name = "textBoxText";
            textBoxText.ReadOnly = true;
            textBoxText.ScrollBars = ScrollBars.Vertical;
            textBoxText.Size = new Size(532, 339);
            textBoxText.TabIndex = 0;
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 434);
            Controls.Add(panelText);
            Controls.Add(panelName);
            MaximizeBox = false;
            Name = "FormHelp";
            Text = "Краткое руководство пользователя";
            panelName.ResumeLayout(false);
            panelName.PerformLayout();
            panelText.ResumeLayout(false);
            panelText.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelName;
        private Panel panelName;
        private Panel panelText;
        private TextBox textBoxText;
        private Button buttonOK;
    }
}