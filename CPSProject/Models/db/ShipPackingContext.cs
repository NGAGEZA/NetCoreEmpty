using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CPSProject.Models.db
{
    public class ShipPackingContext : DbContext
    {
        public ShipPackingContext(DbContextOptions<ShipPackingContext> options) : base(options)
        {

        }
        public DbSet<V_SHIP_BLUE_BOX_WITH_INCMG> V_SHIP_BLUE_BOX_WITH_INCMG { get; set; }
        //public DbSet<tblEmployee> tblEmployees { get; set; }


    }
}
