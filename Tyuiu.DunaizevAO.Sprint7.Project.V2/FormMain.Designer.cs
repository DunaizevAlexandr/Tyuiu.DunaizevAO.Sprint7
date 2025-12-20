namespace Tyuiu.DunaizevAO.Sprint7.Project.V2
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelName = new Panel();
            textBoxName = new TextBox();
            panelButtons = new Panel();
            buttonProvider = new Button();
            buttonOwner = new Button();
            buttonShop = new Button();
            panelTable = new Panel();
            panelName.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelName
            // 
            panelName.Controls.Add(textBoxName);
            panelName.Dock = DockStyle.Top;
            panelName.Location = new Point(0, 0);
            panelName.Name = "panelName";
            panelName.Size = new Size(1327, 78);
            panelName.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.BackColor = SystemColors.Menu;
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Segoe UI", 25F);
            textBoxName.Location = new Point(8, 9);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(1310, 45);
            textBoxName.TabIndex = 0;
            textBoxName.Text = "База данных сети магазинов Dunai\r\n";
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // panelButtons
            // 
            panelButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelButtons.BackColor = SystemColors.Control;
            panelButtons.Controls.Add(buttonProvider);
            panelButtons.Controls.Add(buttonOwner);
            panelButtons.Controls.Add(buttonShop);
            panelButtons.Location = new Point(0, 78);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(1327, 121);
            panelButtons.TabIndex = 1;
            // 
            // buttonProvider
            // 
            buttonProvider.Image = (Image)resources.GetObject("buttonProvider.Image");
            buttonProvider.Location = new Point(368, 6);
            buttonProvider.Name = "buttonProvider";
            buttonProvider.Size = new Size(123, 94);
            buttonProvider.TabIndex = 2;
            buttonProvider.UseVisualStyleBackColor = true;
            // 
            // buttonOwner
            // 
            buttonOwner.Image = (Image)resources.GetObject("buttonOwner.Image");
            buttonOwner.Location = new Point(21, 6);
            buttonOwner.Name = "buttonOwner";
            buttonOwner.Size = new Size(123, 94);
            buttonOwner.TabIndex = 0;
            buttonOwner.UseVisualStyleBackColor = true;
            buttonOwner.Click += button1_Click;
            // 
            // buttonShop
            // 
            buttonShop.Image = (Image)resources.GetObject("buttonShop.Image");
            buttonShop.Location = new Point(195, 6);
            buttonShop.Name = "buttonShop";
            buttonShop.Size = new Size(123, 94);
            buttonShop.TabIndex = 2;
            buttonShop.UseVisualStyleBackColor = true;
            buttonShop.Click += button2_Click;
            // 
            // panelTable
            // 
            panelTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTable.BackColor = SystemColors.ActiveCaption;
            panelTable.Location = new Point(0, 205);
            panelTable.Name = "panelTable";
            panelTable.Size = new Size(1327, 652);
            panelTable.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 854);
            Controls.Add(panelTable);
            Controls.Add(panelButtons);
            Controls.Add(panelName);
            Name = "FormMain";
            Text = "Сеть магазинов Dunai";
            panelName.ResumeLayout(false);
            panelName.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelName;
        private TextBox textBoxName;
        private Panel panelButtons;
        private Button buttonProvider;
        private Button buttonOwner;
        private Button buttonShop;
        private Panel panelTable;
    }
}