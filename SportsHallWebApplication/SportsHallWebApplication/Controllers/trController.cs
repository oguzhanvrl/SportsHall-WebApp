using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsHallWebApplication.Controllers
{
    public class trController : Controller
    {
        /*
         * Renk Paleti
        mavi :           #00549A
        kırmızı :        #DA214D
        açık mavi :      #8490ff
        gri :            #777777
        açıkgri :        #8a8a8a
        blogmavi :       #8490ff

        */

        // GET: tr
        public ActionResult Anasayfa()
        {
            return View();
        }

        public ActionResult KayitOl()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Hakkimizda()
        {
            return View();
        }

        public ActionResult Galeri()
        {
            return View();
        }

        public ActionResult Iletisim()
        {
            return View();
        }

        public ActionResult Panel()
        {
            return View();
        }
    }
}