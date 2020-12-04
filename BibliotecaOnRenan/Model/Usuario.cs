using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaOnRenan.Model
{
    class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public override string ToString()
        {
            return $"Login: {this.IdUsuario}, {this.NomeUsuario}, {this.Senha}, {this.Email}, {this.Telefone}";
        }
    }
}
