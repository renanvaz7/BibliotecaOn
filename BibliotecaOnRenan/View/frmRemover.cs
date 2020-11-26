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
    public partial class frmRemover : Form
    {
        int id = 0;
        Livro l = new Livro();

        public frmRemover()
        {
            InitializeComponent();
            Dados();
        }

        void Dados()
        {
            using (var context = new LivroController())
            {
                var livros = context.AllLivros();
                dgDados.DataSource = livros;
            }
        }

        private void ClearDados()
        {
            txtID.Text = "";
            txtNomeLivro.Text = "";
            txtNomeAutor.Text = "";
            txtGenero.Text = "";
            txtSinopse.Text = "";
        }

        private void ibtnExcluir_Click(object sender, EventArgs e)
        {

            if (txtID.Text != "" && txtNomeLivro.Text != "" && txtNomeAutor.Text != "" && txtGenero.Text != "" && txtSinopse.Text != "")
            {
                using (var context = new LivroController())
                {
                    context.Buscar(id);
                    l.ID = id;
                    context.Remover(l);
                    ClearDados();
                    MessageBox.Show("Produto removido com sucesso");
                }
            }
            else
            {
                MessageBox.Show("Você não informou um produto para excluir");
            }            
        }        

        private void txtID_Enter(object sender, EventArgs e)
        {
            string textoID = txtID.Text;
            TxtEnter(txtID, textoID);
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            string textoID = txtID.Text;
            TxtLeave(txtID, textoID);
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

        private void SelecionarDados(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dgDados.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtID.Text = dgDados.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeLivro.Text = dgDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNomeAutor.Text = dgDados.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtGenero.Text = dgDados.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSinopse.Text = dgDados.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDataLancamento.Text = dgDados.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
