using BibliotecaOnRenan.Controller;
using BibliotecaOnRenan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaOnRenan.View
{
    public partial class frmLogin : Form
    {
        Usuario u = new Usuario();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            string textoSenha = "Senha";
            TxtEnter(txtSenha, textoSenha);
            txtSenha.UseSystemPasswordChar = true;
            ibtnMostrar.Visible = true;
            ibtnEsconder.Visible = false;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            string textoSenha = "Senha";
            TxtLeave(txtSenha, textoSenha);
            txtSenha.UseSystemPasswordChar = false;
            ibtnMostrar.Visible = false;
            ibtnEsconder.Visible = true;
        }

        private void txtNomeUsuario_Enter(object sender, EventArgs e)
        {
            string textoNomeUsuario = "Nome de usuário ou Email";
            TxtEnter(txtNomeUsuario, textoNomeUsuario);
            txtSenha.UseSystemPasswordChar = true;
        }

        private void txtNomeUsuario_Leave(object sender, EventArgs e)
        {
            string textoNomeUsuario = "Nome de usuário ou Email";
            TxtLeave(txtNomeUsuario, textoNomeUsuario);
        }

        private void TxtEnter(TextBox txtTexto, string texto)
        {
            if (txtTexto.Text == texto)
            {
                txtTexto.Text = "";
            }
            else if (txtTexto.Text == "")
            {
                txtTexto.Text = texto;
            }
        }

        private void TxtLeave(TextBox txtTexto, string texto)
        {
            if (txtTexto.Text == "")
            {
                txtTexto.Text = texto;
            }
            else if (txtTexto.Text == texto)
            {
                txtTexto.Text = "";
            }
        }

        private void ibtnMostrar_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
            ibtnMostrar.Visible = false;
            ibtnEsconder.Visible = true;
        }

        private void ibtnEsconder_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            ibtnMostrar.Visible = true;
            ibtnEsconder.Visible = false;
        }

        private void ValidarUsuario()
        {
            if (txtNomeUsuario.Text != "" && txtSenha.Text != "")
            {
                u.NomeUsuario = txtNomeUsuario.Text;
                u.Senha = txtSenha.Text;

                using (var context = new LoginController())
                {
                    context.BuscarLogin(u);                    
                    this.Hide();
                    MessageBox.Show("Login Efetuado com sucesso");
                    Form form = new frmPrincipal();
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Informe os dados");
            }
        }

        private void ibtnLogar_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
        }

        private void llblEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form form = new frmRecuperarSenha();
            form.ShowDialog();
        }
    }
}
