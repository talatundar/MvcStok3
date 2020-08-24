    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok3.Models.Entity;

namespace MvcStok3.Controllers
{
    public class kategoriController : Controller
    {
        // GET: kategori
        MvcDbStokEntities db = new MvcDbStokEntities();
        public ActionResult Index()
        {
            var degerler = db.tbl_kat.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult yenikat()
        {
            return View();
        }

        [HttpPost]
        public ActionResult yenikat(tbl_kat p1)
        {
            db.tbl_kat.Add(p1);
            db.SaveChanges();
            return View();
            
        }

        public ActionResult sil(int id)
        {
            var kategori = db.tbl_kat.Find(id);
            db.tbl_kat.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}