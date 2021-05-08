using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace Parcial2JavierSinani.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("DefaultConecction")
        {

        }

        public System.Data.Entity.DbSet<Parcial2JavierSinani.Models.Currency> Currencies { get; set; }

        public System.Data.Entity.DbSet<Parcial2JavierSinani.Models.Country> Countries { get; set; }
    }
}