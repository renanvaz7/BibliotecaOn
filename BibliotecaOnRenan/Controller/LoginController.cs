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
    class LoginController : ILogin, IDisposable
    {
        private LivrariaContext context;

        public LoginController()
        {
            this.context = new LivrariaContext();
        }

        public void AdicionarUsuario(Usuario u)
        {
            context.Usuarios.Add(u);
            context.SaveChanges();
        }

        public IList<Usuario> AllUsuarios()
        {
            return context.Usuarios.ToList();
        }

        public Usuario BuscarID(int id)
        {
            return context.Usuarios.Find(id);
        }

        public Usuario BuscarLogin(Usuario registro)
        {
            return context.Usuarios.FirstOrDefault(u => u.NomeUsuario == registro.NomeUsuario && u.Email == registro.Email && u.Senha == registro.Senha);
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
