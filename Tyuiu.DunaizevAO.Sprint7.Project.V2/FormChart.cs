using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.DunaizevAO.Sprint7.Project.V2
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }


        public void LoadChartData(DataGridView dgv)
        {
            chartOwner_DAO.Series[0].Points.Clear();

            // Над каждым столбцом отображаем цифры
            chartOwner_DAO.Series[0].IsValueShownAsLabel = true;

            chartOwner_DAO.ChartAreas[0].AxisX.Title = "Номер владельца";
            chartOwner_DAO.ChartAreas[0].AxisY.Title = "Капитал";

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (!dgv.Rows[i].IsNewRow)
                {
                    var num = dgv.Rows[i].Cells[0];
                    var cap = dgv.Rows[i].Cells[3];

                    if (num.Value != null && cap.Value != null)
                    {
                        if (int.TryParse(num.Value.ToString(), out int number))
                        {
                            if (double.TryParse(cap.Value.ToString(), out double capital))
                            {
                                chartOwner_DAO.Series[0].Points.AddXY(number, capital);
                            }
                        }
                    }
                }
            }
        }

        private void buttonOK_DAO_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}