using BibliotecaOnRenan.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaOnRenan.Controller.Mapping
{
    class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("livros");
            builder.HasKey(l => l.ID);
            builder.Property(l => l.NomeLivro).HasMaxLength(100);
            builder.Property(l => l.NomeAutor).HasMaxLength(60);
            builder.Property(l => l.Genero).HasMaxLength(40);
            builder.Property(l => l.Sinopse).HasMaxLength(500);
            builder.Property(l => l.DataLancamento);
        }
    }
}
