using BibliotecaOnRenan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaOnRenan.Controller.Interface
{
    interface ILivro
    {
        void Adicionar(Livro l);

        void Editar(Livro l);

        void Remover(Livro l);

        Livro Buscar(int id);

        IList<Livro> AllLivros();
    }
}
