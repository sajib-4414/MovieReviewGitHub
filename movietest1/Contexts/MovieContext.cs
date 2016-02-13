using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace movietest1.Contexts
{
    public class MovieContext : DbContext
    {
        public DbSet<movietest1.Models.Account> Accounts { get; set; }
    }
}