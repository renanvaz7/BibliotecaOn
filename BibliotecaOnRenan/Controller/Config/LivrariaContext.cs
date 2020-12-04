 using BibliotecaOnRenan.Controller.Mapping;
using BibliotecaOnRenan.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaOnRenan.Controller.Config
{
    class LivrariaContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public LivrariaContext(DbContextOptions<LivrariaContext> options) : base(options){}

        public LivrariaContext(){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=livraria;Uid=root;Pwd=root");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Livro>(new LivroMap().Configure);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
        }
    }
}
