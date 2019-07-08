using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Practice.Models
{
    public class DatabaseContext
    {
        public DbSet<Client> Clients { get; set; }
    }
}