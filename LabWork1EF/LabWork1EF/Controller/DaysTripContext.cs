using LabWork1EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1EF.Controller
{
    class DaysTripContext : DbContext
    {

        public DaysTripContext() : base("Автобусные_маршрутыEntities") { }
        public DbSet<Дни_движения> DaysTrip1 { get; set; }

    }
}
