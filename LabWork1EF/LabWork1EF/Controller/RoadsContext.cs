using LabWork1EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1EF.Controller
{
    class RoadsContext : DbContext
    {

        public RoadsContext() : base("Автобусные_маршрутыEntities") { }
        public DbSet<Рейсы> Roads1 { get; set; }


    }
}
