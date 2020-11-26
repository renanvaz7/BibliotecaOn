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
    public partial class frmAdicionar : Form
    {
        int Id = 0;
        Livro l = new Livro();

        public frmAdicionar()
        {
            InitializeComponent();           
        }

        private void ClearDados()
        {
            Id = 0;
            txtNomeLivro.Text = "";
            txtNomeAutor.Text = "";
            txtGenero.Text = "";
            txtSinopse.Text = "";
        }

        private void ibtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeLivro.Text != "" && txtNomeAutor.Text != "" && txtGenero.Text != "" && txtSinopse.Text != "")
            {
                l.ID = Id;
                l.NomeLivro = txtNomeLivro.Text;
                l.NomeAutor = txtNomeAutor.Text;
                l.Genero = txtGenero.Text;
                l.Sinopse = txtSinopse.Text;
                l.DataLancamento = DateTime.Parse(txtDataLancamento.Text);

                using (var context = new LivroController())
                {
                    context.Adicionar(l);
                    MessageBox.Show("Produtos inseridos com sucesso");
                    ClearDados();
                }
            }
            else
            {
                MessageBox.Show("Insira os produtos!!!");
            }
        }

        private void txtNomeLivro_Enter(object sender, EventArgs e)
        {
            string textoLivro = "Nome do livro";
            TxtEnter(txtNomeLivro, textoLivro);
        }

        private void txtNomeLivro_Leave(object sender, EventArgs e)
        {
            string textoLivro = "Nome do livro";
            TxtLeave(txtNomeLivro, textoLivro);
        }

        private void txtNomeAutor_Enter(object sender, EventArgs e)
        {
            string textoAutor = "Nome do autor";
            TxtEnter(txtNomeAutor, textoAutor);
        }

        private void txtNomeAutor_Leave(object sender, EventArgs e)
        {
            string textoAutor = "Nome do autor";
            TxtLeave(txtNomeAutor, textoAutor);
        }

        private void txtDataLancamento_Enter(object sender, EventArgs e)
        {
            string textoData = "Data de lançamento";
            TxtEnter(txtDataLancamento, textoData);
        }

        private void txtDataLancamento_Leave(object sender, EventArgs e)
        {
            string textoData = "Data de lançamento";
            TxtLeave(txtDataLancamento, textoData);
        }

        private void txtGenero_Enter(object sender, EventArgs e)
        {
            string textoGenero = "Gênero";
            TxtEnter(txtGenero, textoGenero);
        }

        private void txtGenero_Leave(object sender, EventArgs e)
        {
            string textoGenero = "Gênero";
            TxtLeave(txtGenero, textoGenero);
        }

        private void txtSinopse_Enter(object sender, EventArgs e)
        {
            string textoSinopse = "Sinopse";
            TxtEnter(txtSinopse, textoSinopse);
        }

        private void txtSinopse_Leave(object sender, EventArgs e)
        {
            string textoSinopse = "Sinopse";
            TxtLeave(txtSinopse, textoSinopse);
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
    }
}
