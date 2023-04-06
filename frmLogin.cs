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
            if (txtSenha.Text != "123")
            {
                MessageBox.Show("Digite a senha");
                return;
            }

            Program.usuario = txtNome.Text;

            FrmPrincipal frm = new FrmPrincipal(); // estancindo ele pq eu quero abrir ele 
            frm.ShowDialog();

            this.Close();
        }
    }
}
