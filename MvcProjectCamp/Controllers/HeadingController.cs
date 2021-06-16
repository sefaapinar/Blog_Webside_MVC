using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.concrete;

namespace MvcProjectCamp.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager hm = new HeadingManager(new EFHeadingDal());
        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        WriterManager wm = new WriterManager(new EFWriterDal());

        public ActionResult Index()
        {
            var headingvalues = hm.getList();
            return View(headingvalues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valuecategory = (from x in cm.getList()
                select new SelectListItem()
                {
                    Text = x.CategoryName,Value = x.CategoryID.ToString()
                }).ToList();

            List<SelectListItem>valuewriter=(from x in wm.getList() select new SelectListItem()
            {
                Text = x.WriterName + " " +x.WriterSurName,Value = x.WriterID.ToString()

            }).ToList();

            ViewBag.vlw = valuewriter;

            ViewBag.vlc = valuecategory;
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }
    }
}