namespace WinFormsApp1
{
    public partial class Frm_HelloWorld : Form
    {
        public Frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            Lbl_Titulo.Text = Txt_ConteudoLabel.Text;
        }
    }
}