using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.DunaizevAO.Sprint7.Project.V2
{
    public partial class FormAddStr : Form
    {
        static string varTabl = FormMain.varTabl;
        public string NewStr { get; private set; }
        public FormAddStr(string tableType)
        {
            InitializeComponent();
            varTabl = tableType;

            if (varTabl == "Owner")
            {
                labelDown_DAO.Visible = false;
                textBoxDown_DAO.Visible = false;
                labelLeft_DAO.Text = "ФИО";
                labelCenter_DAO.Text = "Телефон";
                labelRight_DAO.Text = "Капитал";
            }
            else if (varTabl == "Shop")
            {
                labelDown_DAO.Visible = false;
                textBoxDown_DAO.Visible = false;
                labelLeft_DAO.Text = "Название";
                labelCenter_DAO.Text = "Адрес";
                labelRight_DAO.Text = "Телефон";
            }
            else if (varTabl == "Prov")
            {
                labelLeft_DAO.Text = "ФИО";
                labelCenter_DAO.Text = "Адрес";
                labelRight_DAO.Text = "Телефон";
                labelDown_DAO.Text = "Стоимость";
            }
        }

        private void buttonAddFinish_Click(object sender, EventArgs e)
        {
            if (varTabl == "Owner" || varTabl == "Shop")
            {
                NewStr = textBoxLeft_DAO.Text + ";" + textBoxCenter_DAO.Text + ";" + textBoxRight_DAO.Text;
            }
            else if (varTabl == "Prov")
            {
                NewStr = textBoxLeft_DAO.Text + ";" + textBoxCenter_DAO.Text + ";" + textBoxRight_DAO.Text + ";" + textBoxDown_DAO.Text;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_DAO_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
