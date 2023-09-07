using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Frm_ValidaCPF : Form
    {
        public Frm_ValidaCPF()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = string.Empty;
            Msk_CPF.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ValidaCPF = false;
            ValidaCPF = Cls_Uteis.Valida(Msk_CPF.Text);
            if (ValidaCPF == true)
            {
                Lbl_Resultado.Text = "CPF VALIDO";
                Lbl_Resultado.ForeColor = Color.Green;
            }
            else
            {
                Lbl_Resultado.Text = "CPF INVALIDO";
                Lbl_Resultado.ForeColor = Color.Red;
            }
        }

        private void Frm_ValidaCPF_Load(object sender, EventArgs e)
        {

        }
    }
}
