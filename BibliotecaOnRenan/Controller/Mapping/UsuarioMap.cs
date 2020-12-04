using BibliotecaOnRenan.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaOnRenan.Controller.Mapping
{
    class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("login");
            builder.HasKey(l => l.IdUsuario);
            builder.Property(l => l.NomeUsuario).HasMaxLength(60);
            builder.Property(l => l.Email).HasMaxLength(60);
            builder.Property(l => l.Senha).HasMaxLength(12);
            builder.Property(l => l.Telefone).HasMaxLength(30);
        }
    }
}
