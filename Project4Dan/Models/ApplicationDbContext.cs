using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Project4Dan.Models
{
    //Out database dbset settings
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Topic> Topics { get; set; }
    }
}