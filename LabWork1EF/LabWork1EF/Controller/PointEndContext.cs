using LabWork1EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1EF.Controller
{
    class PointEndContext : DbContext
    {

        public PointEndContext() : base("Автобусные_маршрутыEntities") { }
        public DbSet<Пункт_назначения> PointEnd1 { get; set; }

    }

}

