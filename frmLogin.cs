using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscola
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if( txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Digite um nome");
                return;
            }
            if (txtSenha.Text != "123456")
            {
                MessageBox.Show("Senha invalida");
                return;
            }

            Program.usuario = txtNome.Text;//variavel declarada na class Program 

            FrmPrincipal frm = new FrmPrincipal(); // estanciando ele pq eu quero abrir ele 
            frm.ShowDialog();

            this.Close();
        }
    }
}
