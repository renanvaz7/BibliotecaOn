using BibliotecaOnRenan.Controller.Config;
using BibliotecaOnRenan.Controller.Interface;
using BibliotecaOnRenan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaOnRenan.Controller
{
    class LivroController : ILivro, IDisposable
    {
        private LivrariaContext context;
        public LivroController()
        {
            this.context = new LivrariaContext();
        }

        public void Adicionar(Livro l)
        {
            context.Livros.Add(l);
            context.SaveChanges();
        }

        public IList<Livro> AllLivros()
        {
            return context.Livros.ToList();
        }

        public Livro Buscar(int id)
        {
            return context.Livros.Find(id);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public void Editar(Livro l)
        {
            var original = this.Buscar(l.ID);
            this.context.Entry(original).CurrentValues.SetValues(l);
            context.SaveChanges();
        }

        public void Remover(Livro l)
        {
            var original = this.Buscar(l.ID);
            this.context.Remove(original); 
            context.SaveChanges();
        }
    }
}
