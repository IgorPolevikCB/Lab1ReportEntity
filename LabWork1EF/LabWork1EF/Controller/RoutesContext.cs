using LabWork1EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1EF.Controller
{
    class RoutesContext : DbContext
    {
        
        public RoutesContext(): base("Автобусные_маршрутыEntities") { }

        public DbSet<Маршруты> Routes1 { get; set; }

    }
}
