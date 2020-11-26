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
    public partial class frmListar : Form
    {
        int Id = 0;
        Livro l = new Livro();

        public frmListar()
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
    }
}
