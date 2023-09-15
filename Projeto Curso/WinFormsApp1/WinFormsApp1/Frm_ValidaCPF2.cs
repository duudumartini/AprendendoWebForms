using CursoWindowsFormsBiblioteca;
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
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Frm_ValidaCPF2_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = string.Empty;
            Msk_CPF.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Msk_CPF.Text == "   .   .   -")
            {
                MessageBox.Show("DIGITE UM CPF", "Menssagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Você deseja validar o CPF ?", "Confirmar CPF", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool ValidaCPF = false;
                    ValidaCPF = Cls_Uteis.Valida(Msk_CPF.Text);
                    if (ValidaCPF == true)
                    {
                        MessageBox.Show("CPF VÁLIDO", "Menssagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CPF INVÁLIDO", "Menssagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }


        }
    }
}
