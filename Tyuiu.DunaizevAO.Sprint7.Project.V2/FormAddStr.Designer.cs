namespace Tyuiu.DunaizevAO.Sprint7.Project.V2
{
    partial class FormAddStr
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
            labelTitle_DAO = new Label();
            textBoxRight_DAO = new TextBox();
            textBoxCenter_DAO = new TextBox();
            textBoxLeft_DAO = new TextBox();
            textBoxDown_DAO = new TextBox();
            buttonAddFinish_DAO = new Button();
            labelLeft_DAO = new Label();
            labelCenter_DAO = new Label();
            labelRight_DAO = new Label();
            labelDown_DAO = new Label();
            buttonCancel_DAO = new Button();
            SuspendLayout();
            // 
            // labelTitle_DAO
            // 
            labelTitle_DAO.AutoSize = true;
            labelTitle_DAO.Font = new Font("Segoe UI", 20F);
            labelTitle_DAO.Location = new Point(210, 9);
            labelTitle_DAO.Name = "labelTitle_DAO";
            labelTitle_DAO.Size = new Size(443, 37);
            labelTitle_DAO.TabIndex = 0;
            labelTitle_DAO.Text = "Введите данные для новой строки";
            // 
            // textBoxRight_DAO
            // 
            textBoxRight_DAO.BorderStyle = BorderStyle.FixedSingle;
            textBoxRight_DAO.Location = new Point(607, 143);
            textBoxRight_DAO.Multiline = true;
            textBoxRight_DAO.Name = "textBoxRight_DAO";
            textBoxRight_DAO.Size = new Size(232, 46);
            textBoxRight_DAO.TabIndex = 3;
            // 
            // textBoxCenter_DAO
            // 
            textBoxCenter_DAO.BorderStyle = BorderStyle.FixedSingle;
            textBoxCenter_DAO.Location = new Point(323, 143);
            textBoxCenter_DAO.Multiline = true;
            textBoxCenter_DAO.Name = "textBoxCenter_DAO";
            textBoxCenter_DAO.Size = new Size(232, 46);
            textBoxCenter_DAO.TabIndex = 4;
            // 
            // textBoxLeft_DAO
            // 
            textBoxLeft_DAO.BorderStyle = BorderStyle.FixedSingle;
            textBoxLeft_DAO.Location = new Point(32, 143);
            textBoxLeft_DAO.Multiline = true;
            textBoxLeft_DAO.Name = "textBoxLeft_DAO";
            textBoxLeft_DAO.Size = new Size(232, 46);
            textBoxLeft_DAO.TabIndex = 5;
            // 
            // textBoxDown_DAO
            // 
            textBoxDown_DAO.BorderStyle = BorderStyle.FixedSingle;
            textBoxDown_DAO.Location = new Point(323, 264);
            textBoxDown_DAO.Multiline = true;
            textBoxDown_DAO.Name = "textBoxDown_DAO";
            textBoxDown_DAO.Size = new Size(232, 46);
            textBoxDown_DAO.TabIndex = 7;
            // 
            // buttonAddFinish_DAO
            // 
            buttonAddFinish_DAO.Font = new Font("Segoe UI", 13F);
            buttonAddFinish_DAO.Location = new Point(736, 366);
            buttonAddFinish_DAO.Name = "buttonAddFinish_DAO";
            buttonAddFinish_DAO.Size = new Size(125, 47);
            buttonAddFinish_DAO.TabIndex = 8;
            buttonAddFinish_DAO.Text = "Добавить";
            buttonAddFinish_DAO.UseVisualStyleBackColor = true;
            buttonAddFinish_DAO.Click += buttonAddFinish_Click;
            // 
            // labelLeft_DAO
            // 
            labelLeft_DAO.AutoSize = true;
            labelLeft_DAO.Font = new Font("Segoe UI", 15F);
            labelLeft_DAO.Location = new Point(32, 112);
            labelLeft_DAO.Name = "labelLeft_DAO";
            labelLeft_DAO.Size = new Size(23, 28);
            labelLeft_DAO.TabIndex = 9;
            labelLeft_DAO.Text = "1";
            // 
            // labelCenter_DAO
            // 
            labelCenter_DAO.AutoSize = true;
            labelCenter_DAO.Font = new Font("Segoe UI", 15F);
            labelCenter_DAO.Location = new Point(323, 112);
            labelCenter_DAO.Name = "labelCenter_DAO";
            labelCenter_DAO.Size = new Size(23, 28);
            labelCenter_DAO.TabIndex = 10;
            labelCenter_DAO.Text = "2";
            // 
            // labelRight_DAO
            // 
            labelRight_DAO.AutoSize = true;
            labelRight_DAO.Font = new Font("Segoe UI", 15F);
            labelRight_DAO.Location = new Point(607, 112);
            labelRight_DAO.Name = "labelRight_DAO";
            labelRight_DAO.Size = new Size(23, 28);
            labelRight_DAO.TabIndex = 11;
            labelRight_DAO.Text = "3";
            // 
            // labelDown_DAO
            // 
            labelDown_DAO.AutoSize = true;
            labelDown_DAO.Font = new Font("Segoe UI", 15F);
            labelDown_DAO.Location = new Point(323, 233);
            labelDown_DAO.Name = "labelDown_DAO";
            labelDown_DAO.Size = new Size(23, 28);
            labelDown_DAO.TabIndex = 12;
            labelDown_DAO.Text = "4";
            // 
            // buttonCancel_DAO
            // 
            buttonCancel_DAO.Font = new Font("Segoe UI", 13F);
            buttonCancel_DAO.Location = new Point(595, 366);
            buttonCancel_DAO.Name = "buttonCancel_DAO";
            buttonCancel_DAO.Size = new Size(125, 47);
            buttonCancel_DAO.TabIndex = 13;
            buttonCancel_DAO.Text = "Отмена";
            buttonCancel_DAO.UseVisualStyleBackColor = true;
            buttonCancel_DAO.Click += buttonCancel_DAO_Click;
            // 
            // FormAddStr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 425);
            Controls.Add(buttonCancel_DAO);
            Controls.Add(labelDown_DAO);
            Controls.Add(labelRight_DAO);
            Controls.Add(labelCenter_DAO);
            Controls.Add(labelLeft_DAO);
            Controls.Add(buttonAddFinish_DAO);
            Controls.Add(textBoxDown_DAO);
            Controls.Add(textBoxLeft_DAO);
            Controls.Add(textBoxCenter_DAO);
            Controls.Add(textBoxRight_DAO);
            Controls.Add(labelTitle_DAO);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAddStr";
            Text = "FormAddStr";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle_DAO;
        private TextBox textBoxRight_DAO;
        private TextBox textBoxCenter_DAO;
        private TextBox textBoxLeft_DAO;
        private TextBox textBoxDownLeft;
        private TextBox textBoxDown_DAO;
        private Button buttonAddFinish_DAO;
        private Label labelLeft_DAO;
        private Label labelCenter_DAO;
        private Label labelRight_DAO;
        private Label labelDown_DAO;
        private Label labelDownLeft;
        private Button buttonCancel_DAO;
    }
}