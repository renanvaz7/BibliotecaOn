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
            txtDataLancamento.Text = "";
        }

        private void ibtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeLivro.Text != "" && txtNomeAutor.Text != "" && txtGenero.Text != "")
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
    }
}
