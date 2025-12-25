namespace Tyuiu.DunaizevAO.Sprint7.Project.V2
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout_DAO formAbout = new FormAbout_DAO();
            formAbout.ShowDialog();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp_DAO formHelp = new FormHelp_DAO();
            formHelp.ShowDialog();
        }

        private void buttonStart_DAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAO.ToolTipTitle = "Главное окно";
        }

        private void buttonAbout_DAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAO.ToolTipTitle = "Справка";
        }

        private void buttonHelp_DAO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAO.ToolTipTitle = "Краткое руководство пользователя";
        }
    }
}
