using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok3.Models.Entity;


namespace MvcStok3.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        MvcDbStokEntities db = new MvcDbStokEntities();
        public ActionResult Index()
        {
            var deger = db.tbl_musteri.ToList();
            return View(deger);
        }

        [HttpGet]
        public ActionResult yenimus()
        {
            return View();
        }

    [HttpPost]
    public ActionResult yenimus(tbl_musteri p1)
    {
            db.tbl_musteri.Add(p1);
            db.SaveChanges();
            return View();
    }
    }
}