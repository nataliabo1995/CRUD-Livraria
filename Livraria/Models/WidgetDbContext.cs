using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Livraria.Models
{
    public class WidgetDbContext: DbContext
    {
        public DbSet<livro> Livros { get; set; }
    }
}