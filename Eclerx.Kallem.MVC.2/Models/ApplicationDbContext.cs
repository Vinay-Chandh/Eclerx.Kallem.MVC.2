using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Eclerx.Kallem.MVC._2.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("EclerxMVC")
        {

        }

        public DbSet<Books> Book { get; set; }
    }
}