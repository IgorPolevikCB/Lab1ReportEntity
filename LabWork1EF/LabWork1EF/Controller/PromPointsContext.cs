using LabWork1EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1EF.Controller
{
    class PromPointsContext : DbContext
    {

        public PromPointsContext() : base("Автобусные_маршрутыEntities") { }
        public DbSet<Промежуточные_пункты> PromPoints1 { get; set; }

    }
}
