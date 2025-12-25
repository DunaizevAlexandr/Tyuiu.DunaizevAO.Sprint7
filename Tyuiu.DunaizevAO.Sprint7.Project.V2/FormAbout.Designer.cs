namespace Tyuiu.DunaizevAO.Sprint7.Project.V2
{
    partial class FormAbout_DAO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_DAO));
            pictureBoxLogo_DAO = new PictureBox();
            textBoxInfo_DAO = new TextBox();
            buttonOK_DAO = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_DAO).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo_DAO
            // 
            pictureBoxLogo_DAO.Image = (Image)resources.GetObject("pictureBoxLogo_DAO.Image");
            pictureBoxLogo_DAO.Location = new Point(12, 12);
            pictureBoxLogo_DAO.Name = "pictureBoxLogo_DAO";
            pictureBoxLogo_DAO.Size = new Size(210, 211);
            pictureBoxLogo_DAO.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo_DAO.TabIndex = 0;
            pictureBoxLogo_DAO.TabStop = false;
            // 
            // textBoxInfo_DAO
            // 
            textBoxInfo_DAO.BackColor = SystemColors.Menu;
            textBoxInfo_DAO.BorderStyle = BorderStyle.None;
            textBoxInfo_DAO.Location = new Point(233, 12);
            textBoxInfo_DAO.Multiline = true;
            textBoxInfo_DAO.Name = "textBoxInfo_DAO";
            textBoxInfo_DAO.ReadOnly = true;
            textBoxInfo_DAO.Size = new Size(289, 211);
            textBoxInfo_DAO.TabIndex = 1;
            textBoxInfo_DAO.TabStop = false;
            textBoxInfo_DAO.Text = resources.GetString("textBoxInfo_DAO.Text");
            // 
            // buttonOK_DAO
            // 
            buttonOK_DAO.Location = new Point(439, 228);
            buttonOK_DAO.Name = "buttonOK_DAO";
            buttonOK_DAO.Size = new Size(62, 23);
            buttonOK_DAO.TabIndex = 2;
            buttonOK_DAO.Text = "OK";
            buttonOK_DAO.UseVisualStyleBackColor = true;
            buttonOK_DAO.Click += buttonOK_Click;
            // 
            // FormAbout_DAO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 264);
            Controls.Add(buttonOK_DAO);
            Controls.Add(textBoxInfo_DAO);
            Controls.Add(pictureBoxLogo_DAO);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAbout_DAO";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_DAO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo_DAO;
        private TextBox textBoxInfo_DAO;
        private Button buttonOK_DAO;
    }
}