using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ModelDemo.Models
{
    public class ModelDemoContext : DbContext
    {   
        public ModelDemoContext() : base("name=ModelDemoContext")
        {
        }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Genre> Genres { get; set; }
    }
}
