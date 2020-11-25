using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaOnRenan.Model
{
    public class Livro
    {
        public int ID { get; set; }
        public string NomeLivro { get; set; }
        public string NomeAutor { get; set; }
        public string Genero { get; set; }
        public string Sinopse { get; set; }
        public DateTime DataLancamento { get; set; }

        public override string ToString()
        {
            return $"Produto: {this.ID}, {this.NomeLivro}, {this.NomeAutor}, {this.Genero}, {this.Sinopse}, {this.DataLancamento}";
        }
    }
}
