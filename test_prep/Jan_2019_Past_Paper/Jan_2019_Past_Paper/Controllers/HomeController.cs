using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jan_2019_Past_Paper.DAL;
using Jan_2019_Past_Paper.ViewModels;

namespace Jan_2019_Past_Paper.Controllers
{
    public class HomeController : Controller
    {
        private TrafficContext db = new TrafficContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<OffenseTotalsGroup> data = from i in db.Fine
                                                  group i by i.Offense into offenseGroup
                                                  select new OffenseTotalsGroup()
                                                  {
                                                      Offense = offenseGroup.Key,
                                                      sumFines = offenseGroup.Sum(i => i.Amount)
                                                  };

            return View(data.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}