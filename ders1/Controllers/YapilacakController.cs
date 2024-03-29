﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using ders1.Models.Siniflar;

namespace ders1.Controllers
{
    public class YapilacakController : Controller
    {
        Context c = new Context();
        // GET: Yapilacak
        public ActionResult Index()
        {
            var deger1 = c.Carilers.Count().ToString();
            ViewBag.d1 = deger1;

            var deger2 = c.Uruns.Count().ToString();
            ViewBag.d2 = deger2;

            var deger3 = c.Kategoris.Count().ToString();
            ViewBag.d3 = deger3;

            var deger4 = c.Carilers.GroupBy(x => x.CariSehir).Count().ToString();
            ViewBag.d4 = deger4;

            var yapicaklar = c.Yapilacaks.ToList();
            return View(yapicaklar);
        }
    }
}