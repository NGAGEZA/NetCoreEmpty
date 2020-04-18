using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CPSProject.Models.db
{
    public class ShipPacking : DbContext
    {
        public ShipPacking(DbContextOptions<ShipPacking> options) : base(options)
        {

        }
        public DbSet<tblSkill> tblSkills { get; set; }
        public DbSet<tblEmployee> tblEmployees { get; set; }


        public DateTime Shipdate { get; set; }
        public DateTime Time { get; set; }
        public string Lotno { get; set; }
        public string Model { get; set; }
        public int Qty { get; set; }
        public string Package { get; set; }
        public int Tomson { get; set; }
        public string ProductCode { get; set; }
    }
}
