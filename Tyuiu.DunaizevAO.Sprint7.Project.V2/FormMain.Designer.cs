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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelName_DAO = new Panel();
            textBoxName_DAO = new TextBox();
            panelButtons_DAO = new Panel();
            buttonProvider_DAO = new Button();
            buttonOwner_DAO = new Button();
            buttonShop_DAO = new Button();
            buttonSortDesc_DAO = new Button();
            buttonSortAsc_DAO = new Button();
            panelTable_DAO = new Panel();
            dataGridViewResult_DAO = new DataGridView();
            groupBoxSort_DAO = new GroupBox();
            buttonAddStr_DAO = new Button();
            buttonChart_DAO = new Button();
            buttonSearch_DAO = new Button();
            textBoxSearch_DAO = new TextBox();
            groupBoxFile_DAO = new GroupBox();
            buttonAddFile_DAO = new Button();
            buttonSaveFile_DAO = new Button();
            openFileDialog_DAO = new OpenFileDialog();
            saveFileDialog_DAO = new SaveFileDialog();
            toolTipButton_DAO = new ToolTip(components);
            panelName_DAO.SuspendLayout();
            panelButtons_DAO.SuspendLayout();
            panelTable_DAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DAO).BeginInit();
            groupBoxSort_DAO.SuspendLayout();
            groupBoxFile_DAO.SuspendLayout();
            SuspendLayout();
            // 
            // panelName_DAO
            // 
            panelName_DAO.Controls.Add(textBoxName_DAO);
            panelName_DAO.Dock = DockStyle.Top;
            panelName_DAO.Location = new Point(0, 0);
            panelName_DAO.Name = "panelName_DAO";
            panelName_DAO.Size = new Size(1254, 78);
            panelName_DAO.TabIndex = 0;
            // 
            // textBoxName_DAO
            // 
            textBoxName_DAO.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName_DAO.BackColor = SystemColors.Menu;
            textBoxName_DAO.BorderStyle = BorderStyle.None;
            textBoxName_DAO.Font = new Font("Segoe UI", 25F);
            textBoxName_DAO.Location = new Point(8, 9);
            textBoxName_DAO.Name = "textBoxName_DAO";
            textBoxName_DAO.ReadOnly = true;
            textBoxName_DAO.Size = new Size(1237, 45);
            textBoxName_DAO.TabIndex = 0;
            textBoxName_DAO.Text = "База данных сети магазинов Dunai\r\n";
            textBoxName_DAO.TextAlign = HorizontalAlignment.Center;
            // 
            // panelButtons_DAO
            // 
            panelButtons_DAO.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelButtons_DAO.BackColor = SystemColors.Control;
            panelButtons_DAO.Controls.Add(buttonProvider_DAO);
            panelButtons_DAO.Controls.Add(buttonOwner_DAO);
            panelButtons_DAO.Controls.Add(buttonShop_DAO);
            panelButtons_DAO.Location = new Point(0, 78);
            panelButtons_DAO.Name = "panelButtons_DAO";
            panelButtons_DAO.Size = new Size(1254, 121);
            panelButtons_DAO.TabIndex = 1;
            // 
            // buttonProvider_DAO
            // 
            buttonProvider_DAO.Cursor = Cursors.Hand;
            buttonProvider_DAO.Image = (Image)resources.GetObject("buttonProvider_DAO.Image");
            buttonProvider_DAO.Location = new Point(368, 6);
            buttonProvider_DAO.Name = "buttonProvider_DAO";
            buttonProvider_DAO.Size = new Size(123, 94);
            buttonProvider_DAO.TabIndex = 2;
            toolTipButton_DAO.SetToolTip(buttonProvider_DAO, "Открыть таблицу поставщиков (номер, ФИО, адрес, телефон поставщика, стоимость поставки)");
            buttonProvider_DAO.UseVisualStyleBackColor = true;
            buttonProvider_DAO.Click += buttonProvider_DAO_Click;
            buttonProvider_DAO.MouseEnter += buttonProvider_DAO_MouseEnter;
            // 
            // buttonOwner_DAO
            // 
            buttonOwner_DAO.Cursor = Cursors.Hand;
            buttonOwner_DAO.Image = (Image)resources.GetObject("buttonOwner_DAO.Image");
            buttonOwner_DAO.Location = new Point(21, 6);
            buttonOwner_DAO.Name = "buttonOwner_DAO";
            buttonOwner_DAO.Size = new Size(123, 94);
            buttonOwner_DAO.TabIndex = 0;
            toolTipButton_DAO.SetToolTip(buttonOwner_DAO, "Открыть таблицу владельцев (номер, ФИО, телефон и капитал владельцев магазинов)");
            buttonOwner_DAO.UseVisualStyleBackColor = true;
            buttonOwner_DAO.Click += buttonOwner_DAO_Click;
            buttonOwner_DAO.MouseEnter += buttonOwner_DAO_MouseEnter;
            // 
            // buttonShop_DAO
            // 
            buttonShop_DAO.Cursor = Cursors.Hand;
            buttonShop_DAO.Image = (Image)resources.GetObject("buttonShop_DAO.Image");
            buttonShop_DAO.Location = new Point(195, 6);
            buttonShop_DAO.Name = "buttonShop_DAO";
            buttonShop_DAO.Size = new Size(123, 94);
            buttonShop_DAO.TabIndex = 2;
            toolTipButton_DAO.SetToolTip(buttonShop_DAO, "Открыть таблицу филиалов (номер, название, адрес и телефон магазина)");
            buttonShop_DAO.UseVisualStyleBackColor = true;
            buttonShop_DAO.Click += buttonShop_DAO_Click;
            buttonShop_DAO.MouseEnter += buttonShop_DAO_MouseEnter;
            // 
            // buttonSortDesc_DAO
            // 
            buttonSortDesc_DAO.Location = new Point(535, 29);
            buttonSortDesc_DAO.Name = "buttonSortDesc_DAO";
            buttonSortDesc_DAO.Size = new Size(43, 45);
            buttonSortDesc_DAO.TabIndex = 4;
            buttonSortDesc_DAO.Text = "▼";
            buttonSortDesc_DAO.UseVisualStyleBackColor = true;
            buttonSortDesc_DAO.Visible = false;
            buttonSortDesc_DAO.Click += buttonSortDesc_DAO_Click;
            // 
            // buttonSortAsc_DAO
            // 
            buttonSortAsc_DAO.Location = new Point(486, 29);
            buttonSortAsc_DAO.Name = "buttonSortAsc_DAO";
            buttonSortAsc_DAO.Size = new Size(43, 45);
            buttonSortAsc_DAO.TabIndex = 3;
            buttonSortAsc_DAO.Text = "▲";
            buttonSortAsc_DAO.UseVisualStyleBackColor = true;
            buttonSortAsc_DAO.Visible = false;
            buttonSortAsc_DAO.Click += buttonSortAsc_DAO_Click;
            // 
            // panelTable_DAO
            // 
            panelTable_DAO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTable_DAO.BackColor = SystemColors.ButtonFace;
            panelTable_DAO.Controls.Add(dataGridViewResult_DAO);
            panelTable_DAO.Controls.Add(groupBoxSort_DAO);
            panelTable_DAO.Controls.Add(groupBoxFile_DAO);
            panelTable_DAO.Location = new Point(0, 205);
            panelTable_DAO.Name = "panelTable_DAO";
            panelTable_DAO.Size = new Size(1254, 652);
            panelTable_DAO.TabIndex = 2;
            // 
            // dataGridViewResult_DAO
            // 
            dataGridViewResult_DAO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewResult_DAO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_DAO.Location = new Point(8, 110);
            dataGridViewResult_DAO.Name = "dataGridViewResult_DAO";
            dataGridViewResult_DAO.Size = new Size(1239, 527);
            dataGridViewResult_DAO.TabIndex = 6;
            // 
            // groupBoxSort_DAO
            // 
            groupBoxSort_DAO.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSort_DAO.Controls.Add(buttonSortDesc_DAO);
            groupBoxSort_DAO.Controls.Add(buttonAddStr_DAO);
            groupBoxSort_DAO.Controls.Add(buttonSortAsc_DAO);
            groupBoxSort_DAO.Controls.Add(buttonChart_DAO);
            groupBoxSort_DAO.Controls.Add(buttonSearch_DAO);
            groupBoxSort_DAO.Controls.Add(textBoxSearch_DAO);
            groupBoxSort_DAO.Location = new Point(259, 3);
            groupBoxSort_DAO.Name = "groupBoxSort_DAO";
            groupBoxSort_DAO.Size = new Size(988, 100);
            groupBoxSort_DAO.TabIndex = 5;
            groupBoxSort_DAO.TabStop = false;
            groupBoxSort_DAO.Text = "Сортировка";
            // 
            // buttonAddStr_DAO
            // 
            buttonAddStr_DAO.Cursor = Cursors.Hand;
            buttonAddStr_DAO.Enabled = false;
            buttonAddStr_DAO.Image = (Image)resources.GetObject("buttonAddStr_DAO.Image");
            buttonAddStr_DAO.Location = new Point(406, 29);
            buttonAddStr_DAO.Name = "buttonAddStr_DAO";
            buttonAddStr_DAO.Size = new Size(43, 45);
            buttonAddStr_DAO.TabIndex = 10;
            toolTipButton_DAO.SetToolTip(buttonAddStr_DAO, "Добавить новую строчку в таблицу");
            buttonAddStr_DAO.UseVisualStyleBackColor = true;
            buttonAddStr_DAO.Click += buttonAddStr_DAO_Click;
            buttonAddStr_DAO.MouseEnter += buttonAddStr_DAO_MouseEnter;
            // 
            // buttonChart_DAO
            // 
            buttonChart_DAO.Cursor = Cursors.Hand;
            buttonChart_DAO.Image = (Image)resources.GetObject("buttonChart_DAO.Image");
            buttonChart_DAO.Location = new Point(618, 29);
            buttonChart_DAO.Name = "buttonChart_DAO";
            buttonChart_DAO.Size = new Size(43, 45);
            buttonChart_DAO.TabIndex = 6;
            toolTipButton_DAO.SetToolTip(buttonChart_DAO, "Открыть диаграмму по таблице");
            buttonChart_DAO.UseVisualStyleBackColor = true;
            buttonChart_DAO.Visible = false;
            buttonChart_DAO.Click += buttonChart_DAO_Click;
            buttonChart_DAO.MouseEnter += buttonChart_DAO_MouseEnter;
            // 
            // buttonSearch_DAO
            // 
            buttonSearch_DAO.Cursor = Cursors.Hand;
            buttonSearch_DAO.Enabled = false;
            buttonSearch_DAO.Image = (Image)resources.GetObject("buttonSearch_DAO.Image");
            buttonSearch_DAO.Location = new Point(15, 29);
            buttonSearch_DAO.Name = "buttonSearch_DAO";
            buttonSearch_DAO.Size = new Size(43, 45);
            buttonSearch_DAO.TabIndex = 0;
            toolTipButton_DAO.SetToolTip(buttonSearch_DAO, "Поиск по таблице");
            buttonSearch_DAO.UseVisualStyleBackColor = true;
            buttonSearch_DAO.Click += buttonSearch_DAO_Click;
            buttonSearch_DAO.MouseEnter += buttonSearch_DAO_MouseEnter;
            // 
            // textBoxSearch_DAO
            // 
            textBoxSearch_DAO.Enabled = false;
            textBoxSearch_DAO.Location = new Point(64, 29);
            textBoxSearch_DAO.Multiline = true;
            textBoxSearch_DAO.Name = "textBoxSearch_DAO";
            textBoxSearch_DAO.Size = new Size(307, 45);
            textBoxSearch_DAO.TabIndex = 1;
            // 
            // groupBoxFile_DAO
            // 
            groupBoxFile_DAO.Controls.Add(buttonAddFile_DAO);
            groupBoxFile_DAO.Controls.Add(buttonSaveFile_DAO);
            groupBoxFile_DAO.Location = new Point(8, 3);
            groupBoxFile_DAO.Name = "groupBoxFile_DAO";
            groupBoxFile_DAO.Size = new Size(245, 100);
            groupBoxFile_DAO.TabIndex = 4;
            groupBoxFile_DAO.TabStop = false;
            groupBoxFile_DAO.Text = "Файл";
            // 
            // buttonAddFile_DAO
            // 
            buttonAddFile_DAO.Image = (Image)resources.GetObject("buttonAddFile_DAO.Image");
            buttonAddFile_DAO.Location = new Point(6, 22);
            buttonAddFile_DAO.Name = "buttonAddFile_DAO";
            buttonAddFile_DAO.Size = new Size(97, 59);
            buttonAddFile_DAO.TabIndex = 2;
            toolTipButton_DAO.SetToolTip(buttonAddFile_DAO, "Открыть файл с таблицей");
            buttonAddFile_DAO.UseVisualStyleBackColor = true;
            buttonAddFile_DAO.Click += buttonAddFile_DAO_Click;
            buttonAddFile_DAO.MouseEnter += buttonAddFile_DAO_MouseEnter;
            // 
            // buttonSaveFile_DAO
            // 
            buttonSaveFile_DAO.Image = (Image)resources.GetObject("buttonSaveFile_DAO.Image");
            buttonSaveFile_DAO.Location = new Point(136, 22);
            buttonSaveFile_DAO.Name = "buttonSaveFile_DAO";
            buttonSaveFile_DAO.Size = new Size(97, 59);
            buttonSaveFile_DAO.TabIndex = 3;
            toolTipButton_DAO.SetToolTip(buttonSaveFile_DAO, "Сохранить файл с таблицей");
            buttonSaveFile_DAO.UseVisualStyleBackColor = true;
            buttonSaveFile_DAO.Click += buttonSaveFile_DAO_Click;
            buttonSaveFile_DAO.MouseEnter += buttonSaveFile_DAO_MouseEnter;
            // 
            // openFileDialog_DAO
            // 
            openFileDialog_DAO.FileName = "openFileDialog1";
            // 
            // toolTipButton_DAO
            // 
            toolTipButton_DAO.IsBalloon = true;
            toolTipButton_DAO.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton_DAO.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 854);
            Controls.Add(panelTable_DAO);
            Controls.Add(panelButtons_DAO);
            Controls.Add(panelName_DAO);
            Name = "FormMain";
            Text = "Сеть магазинов Dunai";
            panelName_DAO.ResumeLayout(false);
            panelName_DAO.PerformLayout();
            panelButtons_DAO.ResumeLayout(false);
            panelTable_DAO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DAO).EndInit();
            groupBoxSort_DAO.ResumeLayout(false);
            groupBoxSort_DAO.PerformLayout();
            groupBoxFile_DAO.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelName_DAO;
        private TextBox textBoxName_DAO;
        private Panel panelButtons_DAO;
        private Button buttonProvider_DAO;
        private Button buttonOwner_DAO;
        private Button buttonShop_DAO;
        private Panel panelTable_DAO;
        private TextBox textBoxSearch_DAO;
        private Button buttonSearch_DAO;
        private Button buttonAddFile_DAO;
        private Button buttonSaveFile_DAO;
        private GroupBox groupBoxFile_DAO;
        private GroupBox groupBoxSort_DAO;
        private Button buttonChart_DAO;
        private DataGridView dataGridViewResult_DAO;
        private OpenFileDialog openFileDialog_DAO;
        private SaveFileDialog saveFileDialog_DAO;
        private ToolTip toolTipButton_DAO;
        private Button buttonAddStr_DAO;
        private Button buttonSortDesc_DAO;
        private Button buttonSortAsc_DAO;
    }
}