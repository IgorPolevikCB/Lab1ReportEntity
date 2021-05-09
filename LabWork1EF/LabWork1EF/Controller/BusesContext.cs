using LabWork1EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1EF.Controller
{
    class BusesContext : DbContext
    {
        
        public BusesContext() : base("Автобусные_маршрутыEntities") { }
        public DbSet<Автобусы> Buses1 { get; set; }

    }

}

