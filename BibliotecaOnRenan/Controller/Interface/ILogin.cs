using BibliotecaOnRenan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaOnRenan.Controller.Interface
{
    interface ILogin
    {
        void AdicionarUsuario(Usuario u);
        bool Login(string login, string email, string senha);
        Usuario BuscarID(int id);
        IList<Usuario> AllUsuarios();
    }
}
