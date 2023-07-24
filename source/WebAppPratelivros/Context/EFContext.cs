using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;

namespace WebAppPratelivros.Models
{
    internal class EFContext : DbContext
    {
        public EFContext() : base("Asp_Net_MVC_CS") 
        {
            Database.SetInitializer<EFContext>(new DropCreateDatabaseIfModelChanges<EFContext>());
        }
        public DbSet<Leitor> Leitor { get; set; }
        public DbSet<Livro> Livros { get; set; }
    }
}