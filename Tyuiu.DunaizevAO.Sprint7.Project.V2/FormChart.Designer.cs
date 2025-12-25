namespace Tyuiu.DunaizevAO.Sprint7.Project.V2
{
    partial class FormChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartOwner_DAO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonOK_DAO = new Button();
            ((System.ComponentModel.ISupportInitialize)chartOwner_DAO).BeginInit();
            SuspendLayout();
            // 
            // chartOwner_DAO
            // 
            chartOwner_DAO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartOwner_DAO.ChartAreas.Add(chartArea1);
            chartOwner_DAO.Location = new Point(12, 12);
            chartOwner_DAO.Name = "chartOwner_DAO";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chartOwner_DAO.Series.Add(series1);
            chartOwner_DAO.Size = new Size(776, 382);
            chartOwner_DAO.TabIndex = 0;
            chartOwner_DAO.Text = "chart1";
            // 
            // buttonOK_DAO
            // 
            buttonOK_DAO.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK_DAO.Location = new Point(713, 402);
            buttonOK_DAO.Name = "buttonOK_DAO";
            buttonOK_DAO.Size = new Size(75, 36);
            buttonOK_DAO.TabIndex = 1;
            buttonOK_DAO.Text = "OK";
            buttonOK_DAO.UseVisualStyleBackColor = true;
            buttonOK_DAO.Click += buttonOK_DAO_Click;
            // 
            // FormChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 450);
            Controls.Add(buttonOK_DAO);
            Controls.Add(chartOwner_DAO);
            Name = "FormChart";
            Text = "Статистика капитала владельцев";
            ((System.ComponentModel.ISupportInitialize)chartOwner_DAO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartOwner_DAO;
        private Button buttonOK_DAO;
    }
}