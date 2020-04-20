using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CPSProject.Models;
using CPSProject.Models.db;

namespace CPSProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ShipPackingContext _dbContext;
        public HomeController(ShipPackingContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
           // var shipinglst = _dbContext.V_SHIP_BLUE_BOX_WITH_INCMG.Where(x => x.LotNo == "2012A2249V").ToListNoLock();

            return View();
           
        }


       
        [HttpPost]
        public IActionResult SearchResult(DateTime dtfrom)
        {
            //if (DateTime.(lotno))
            //{
            //    return RedirectToAction("Index");
            //}
            var shipinglst = _dbContext.V_SHIP_BLUE_BOX_WITH_INCMG.Where(x => x.Date1 == dtfrom).OrderBy(o => o.Date1).ThenBy(o => o.Time1).ToListNoLock();

            if (shipinglst.Count != 0)
            {
                return View(shipinglst);
            }
            else
            {
                return RedirectToAction("Index");
            }

            
            //ViewBag.Name = string.Format("Name: {0} {1}", firstName, lastName);
            //return View();
        }
    }
}