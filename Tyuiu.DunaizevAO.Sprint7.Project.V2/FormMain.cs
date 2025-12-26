using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DunaizevAO.Sprint7.Project.V2.Lib;
using static System.Windows.Forms.LinkLabel;

namespace Tyuiu.DunaizevAO.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_DAO.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_DAO.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static string openFilePath;
        public static string varTabl;
        static int rows;
        static int columns;
        static string[] MinMaxStr;
        static int MinMaxCol;
        DataService ds = new DataService();

        private void buttonOwner_DAO_Click(object sender, EventArgs e)
        {
            dataGridViewResult_DAO.DataSource = null;
            dataGridViewResult_DAO.Rows.Clear();
            dataGridViewResult_DAO.Columns.Clear();

            buttonSearchMin_DAO.Visible = true;
            buttonSearchMax_DAO.Enabled = false;
            buttonSearchMax_DAO.Visible = true;
            buttonSearchMin_DAO.Enabled = false;
            textBoxSearchMinMax_DAO.Visible = true;
            textBoxSearchMinMax_DAO.Enabled = false;
            buttonChart_DAO.Visible = true;
            buttonChart_DAO.Enabled = false;
            buttonSearch_DAO.Enabled = false;
            textBoxSearch_DAO.Enabled = false;
            buttonAddStr_DAO.Enabled = false;

            varTabl = "Owner";

            MinMaxCol = 3;
        }

        private void buttonShop_DAO_Click(object sender, EventArgs e)
        {
            dataGridViewResult_DAO.DataSource = null;
            dataGridViewResult_DAO.Rows.Clear();
            dataGridViewResult_DAO.Columns.Clear();

            buttonSearchMin_DAO.Visible = false;
            buttonSearchMax_DAO.Enabled = false;
            buttonSearchMax_DAO.Visible = false;
            buttonSearchMin_DAO.Enabled = false;
            textBoxSearchMinMax_DAO.Visible = false;
            textBoxSearchMinMax_DAO.Enabled = false;
            buttonChart_DAO.Visible = false;
            buttonChart_DAO.Enabled = false;
            buttonSearch_DAO.Enabled = false;
            textBoxSearch_DAO.Enabled = false;
            buttonAddStr_DAO.Enabled = false;

            varTabl = "Shop";

            MinMaxCol = 1;
        }

        private void buttonProvider_DAO_Click(object sender, EventArgs e)
        {
            dataGridViewResult_DAO.DataSource = null;
            dataGridViewResult_DAO.Rows.Clear();
            dataGridViewResult_DAO.Columns.Clear();

            buttonSearchMin_DAO.Visible = true;
            buttonSearchMax_DAO.Enabled = false;
            buttonSearchMax_DAO.Visible = true;
            buttonSearchMin_DAO.Enabled = false;
            textBoxSearchMinMax_DAO.Visible = true;
            textBoxSearchMinMax_DAO.Enabled = false;
            buttonChart_DAO.Visible = false;
            buttonChart_DAO.Enabled = false;
            buttonSearch_DAO.Enabled = false;
            textBoxSearch_DAO.Enabled = false;
            buttonAddStr_DAO.Enabled = false;

            varTabl = "Prov";

            MinMaxCol = 4;
        }

        private void buttonOwner_DAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAO.ToolTipTitle = "Владельцы";
        }

        private void buttonShop_DAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAO.ToolTipTitle = "Филиалы";
        }

        private void buttonProvider_DAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAO.ToolTipTitle = "Поставщики";
        }

        private void buttonAddFile_DAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAO.ToolTipTitle = "Открыть файл";
        }

        private void buttonSaveFile_DAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAO.ToolTipTitle = "Сохранить файл";
        }

        private void buttonSearch_DAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAO.ToolTipTitle = "Найти";
        }

        private void buttonSearchMin_DAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAO.ToolTipTitle = "Минимум";
        }

        private void buttonSearchMax_DAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAO.ToolTipTitle = "Максимум";
        }

        private void buttonChart_DAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAO.ToolTipTitle = "Диаграмма";
        }

        private void buttonAddStr_DAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAO.ToolTipTitle = "Новая строка";
        }

        private void buttonAddFile_DAO_Click(object sender, EventArgs e)
        {
            openFileDialog_DAO.ShowDialog();
            openFilePath = openFileDialog_DAO.FileName;
            try
            {
                buttonSearchMax_DAO.Enabled = true;
                buttonSearchMin_DAO.Enabled = true;
                textBoxSearchMinMax_DAO.Enabled = true;
                buttonChart_DAO.Enabled = true;
                buttonSearch_DAO.Enabled = true;
                textBoxSearch_DAO.Enabled = true;
                buttonAddStr_DAO.Enabled = true;


                string[,] Matrix = ds.LoadFile(openFilePath);

                rows = Matrix.GetLength(0);
                columns = Matrix.GetLength(1);

                dataGridViewResult_DAO.DataSource = null;
                dataGridViewResult_DAO.Rows.Clear();
                dataGridViewResult_DAO.Columns.Clear();
                // Открыть таблицу владельцев (номер, ФИО, телефон и капитал владельцев магазинов)
                // Открыть таблицу филиалов (номер, название, адрес и телефон магазина)
                // Открыть таблицу поставщиков (номер, ФИО, адрес, телефон поставщика, стоимость поставки)
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewResult_DAO.Columns.Add($"Column{c}", $"Column{c}");
                }
                if (varTabl == "Owner")
                {
                    dataGridViewResult_DAO.Columns[0].Width = 50;
                    dataGridViewResult_DAO.Columns[0].HeaderText = "№";

                    dataGridViewResult_DAO.Columns[1].Width = 250;
                    dataGridViewResult_DAO.Columns[1].HeaderText = "ФИО";

                    dataGridViewResult_DAO.Columns[2].Width = 250;
                    dataGridViewResult_DAO.Columns[2].HeaderText = "Телефон";

                    dataGridViewResult_DAO.Columns[3].Width = 250;
                    dataGridViewResult_DAO.Columns[3].HeaderText = "Капитал";

                }
                else if (varTabl == "Shop")
                {
                    dataGridViewResult_DAO.Columns[0].Width = 50;
                    dataGridViewResult_DAO.Columns[0].HeaderText = "№";

                    dataGridViewResult_DAO.Columns[1].Width = 250;
                    dataGridViewResult_DAO.Columns[1].HeaderText = "Название";

                    dataGridViewResult_DAO.Columns[2].Width = 250;
                    dataGridViewResult_DAO.Columns[2].HeaderText = "Адрес";

                    dataGridViewResult_DAO.Columns[3].Width = 250;
                    dataGridViewResult_DAO.Columns[3].HeaderText = "Телефон";
                }
                else if (varTabl == "Prov")
                {
                    dataGridViewResult_DAO.Columns[0].Width = 50;
                    dataGridViewResult_DAO.Columns[0].HeaderText = "№";

                    dataGridViewResult_DAO.Columns[1].Width = 250;
                    dataGridViewResult_DAO.Columns[1].HeaderText = "ФИО";

                    dataGridViewResult_DAO.Columns[2].Width = 250;
                    dataGridViewResult_DAO.Columns[2].HeaderText = "Адрес";

                    dataGridViewResult_DAO.Columns[3].Width = 250;
                    dataGridViewResult_DAO.Columns[3].HeaderText = "Телефон";

                    dataGridViewResult_DAO.Columns[4].Width = 250;
                    dataGridViewResult_DAO.Columns[4].HeaderText = "Стоимость";
                }
                for (int r = 0; r < rows; r++)
                {
                    int rowIndex = dataGridViewResult_DAO.Rows.Add();
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewResult_DAO.Rows[rowIndex].Cells[c].Value = Matrix[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_DAO_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewResult_DAO.RowCount; i++)
            {
                dataGridViewResult_DAO.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewResult_DAO.ColumnCount; j++)
                    if (dataGridViewResult_DAO.Rows[i].Cells[j].Value != null)
                        if (dataGridViewResult_DAO.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch_DAO.Text))
                        {
                            dataGridViewResult_DAO.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void buttonSearchMax_DAO_Click(object sender, EventArgs e)
        {
            int columnIndex = MinMaxCol;

            if (dataGridViewResult_DAO.RowCount == 0)
            {
                textBoxSearchMinMax_DAO.Text = "Таблица пуста";
                return;
            }

            if (columnIndex >= dataGridViewResult_DAO.ColumnCount)
            {
                textBoxSearchMinMax_DAO.Text = $"Столбец {columnIndex + 1} не существует";
                return;
            }

            double maxValue = double.MinValue;
            int maxRowIndex = -1;

            for (int i = 0; i < dataGridViewResult_DAO.RowCount; i++)
            {
                if (dataGridViewResult_DAO.Rows[i].Cells[columnIndex].Value != null)
                {
                    string cellValue = dataGridViewResult_DAO.Rows[i].Cells[columnIndex].Value.ToString();
                    if (double.TryParse(cellValue, out double currentValue))
                    {
                        if (currentValue > maxValue)
                        {
                            maxValue = currentValue;
                            maxRowIndex = i;
                        }
                    }
                }
            }

            if (maxRowIndex != -1)
            {

                dataGridViewResult_DAO.ClearSelection();
                dataGridViewResult_DAO.Rows[maxRowIndex].Selected = true;
                dataGridViewResult_DAO.FirstDisplayedScrollingRowIndex = maxRowIndex;


                textBoxSearchMinMax_DAO.Text = $"Макс: {maxValue} (строка {maxRowIndex + 1})";
            }
            else
            {
                textBoxSearchMinMax_DAO.Text = "Числовые данные не найдены";
            }
        }

        private void buttonSearchMin_DAO_Click(object sender, EventArgs e)
        {
            int columnIndex = MinMaxCol;

            if (dataGridViewResult_DAO.RowCount == 0)
            {
                textBoxSearchMinMax_DAO.Text = "Таблица пуста";
                return;
            }

            if (columnIndex >= dataGridViewResult_DAO.ColumnCount)
            {
                textBoxSearchMinMax_DAO.Text = $"Столбец {columnIndex + 1} не существует";
                return;
            }

            double minValue = double.MaxValue;
            int minRowIndex = -1;

            for (int i = 0; i < dataGridViewResult_DAO.RowCount; i++)
            {
                if (dataGridViewResult_DAO.Rows[i].Cells[columnIndex].Value != null)
                {
                    string cellValue = dataGridViewResult_DAO.Rows[i].Cells[columnIndex].Value.ToString();
                    if (double.TryParse(cellValue, out double currentValue))
                    {
                        if (currentValue < minValue)
                        {
                            minValue = currentValue;
                            minRowIndex = i;
                        }
                    }
                }
            }

            if (minRowIndex != -1)
            {
                dataGridViewResult_DAO.ClearSelection();
                dataGridViewResult_DAO.Rows[minRowIndex].Selected = true;
                dataGridViewResult_DAO.FirstDisplayedScrollingRowIndex = minRowIndex;

                textBoxSearchMinMax_DAO.Text = $"Мин: {minValue} (строка {minRowIndex + 1})";
            }
            else
            {
                textBoxSearchMinMax_DAO.Text = "Числовые данные не найдены";
            }
        }

        private void buttonChart_DAO_Click(object sender, EventArgs e)
        {
            FormChart chartForm = new FormChart();
            chartForm.LoadChartData(dataGridViewResult_DAO);
            chartForm.Show();
        }

        private void buttonSaveFile_DAO_Click(object sender, EventArgs e)
        {
            try
            {
                if (varTabl == "Owner")
                {
                    saveFileDialog_DAO.FileName = "OwnerData.csv";
                }
                if (varTabl == "Shop")
                {
                    saveFileDialog_DAO.FileName = "ShopData.csv";
                }
                if (varTabl == "Prov")
                {
                    saveFileDialog_DAO.FileName = "ProvData.csv";
                }
                saveFileDialog_DAO.InitialDirectory = @"C:\";
                if (saveFileDialog_DAO.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialog_DAO.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridViewResult_DAO.RowCount;
                    int columns = dataGridViewResult_DAO.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        if (dataGridViewResult_DAO.Rows[i].IsNewRow)
                            continue;

                        for (int j = 0; j < columns; j++)
                        {
                            string cellValue = dataGridViewResult_DAO.Rows[i].Cells[j].Value?.ToString() ?? "";

                            strBuilder.Append(cellValue);

                            if (j != columns - 1) strBuilder.Append(";");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.UTF8);
                    MessageBox.Show("Файл сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddStr_DAO_Click(object sender, EventArgs e)
        {
            FormAddStr formAddStr = new FormAddStr(varTabl);

            if (formAddStr.ShowDialog() == DialogResult.OK)
            {
                string newStr = formAddStr.NewStr;

                if (!string.IsNullOrEmpty(newStr))
                {
                    string[] values = newStr.Split(';');

                    int newRowIndex = dataGridViewResult_DAO.Rows.Add();

                    int autoNumber = dataGridViewResult_DAO.Rows.Count;
                    dataGridViewResult_DAO.Rows[newRowIndex].Cells[0].Value = autoNumber.ToString();

                    for (int i = 1; i < Math.Min(values.Length + 1, dataGridViewResult_DAO.Columns.Count); i++)
                    {
                        if (i - 1 < values.Length)
                        {
                            dataGridViewResult_DAO.Rows[newRowIndex].Cells[i].Value = values[i - 1];
                        }
                    }
                }
            }
        }

    }
}
