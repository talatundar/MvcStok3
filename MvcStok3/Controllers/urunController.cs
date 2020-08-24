using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok3.Models.Entity;
using MvcStok3.Controllers;

namespace MvcStok3.Controllers
{
    public class urunController : Controller
    {
        // GET: urun
        MvcDbStokEntities db = new MvcDbStokEntities();
        public ActionResult Index()
        {
            var deger = db.tbl_urunler.ToList();
            return View(deger);
        }





        [HttpGet]
        public ActionResult yeniurun()
        {
            List<SelectListItem> degerler = (from i in db.tbl_kat.ToList()
                                             select new SelectListItem()
                                             {
                                                 Text = i.kat_ad,
                                                 Value=i.kat_id.ToString(),
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }

        [HttpPost]
        public ActionResult yeniurun(tbl_urunler p1)
        {
            var ktg = db.tbl_kat.Where(m => m.kat_id == p1.tbl_kat.kat_id).FirstOrDefault();
            p1.tbl_kat = ktg;

            db.tbl_urunler.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult sil(int id)
        {
            var urun = db.tbl_urunler.Find(id);
            db.tbl_urunler.Remove(urun);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}