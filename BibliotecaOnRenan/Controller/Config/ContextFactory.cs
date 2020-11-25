using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaOnRenan.Controller.Config
{
    class ContextFactory : IDesignTimeDbContextFactory<LivrariaContext>
    {
        public LivrariaContext CreateDbContext(string[] args)
        {
            var connectString = "Server=localhost;Port=3306;Database=livraria;Uid=root;Pwd=root";
            var optionsBuilder = new DbContextOptionsBuilder<LivrariaContext>();
            optionsBuilder.UseMySql(connectString);
            return new LivrariaContext(optionsBuilder.Options);
        }
    }
}
