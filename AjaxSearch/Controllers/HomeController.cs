using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxSearch.Models;

namespace AjaxSearch.Controllers
{
    public class HomeController : Controller
    {
        List<Student> db = new List<Student>()
             {
                new Student (){  FullName ="سعید بالکانی"},
                new Student (){  FullName ="سروش صحت"},
                new Student (){  FullName ="مهران مدیری"},
                new Student (){  FullName ="افشین هاشمی"},
                new Student (){  FullName ="فرهاد اصلانی"},
                new Student (){  FullName ="علی صادقی"},
                new Student (){  FullName ="گوهر خیراندیش"},
                new Student (){  FullName ="حمید لولایی"},
                new Student (){  FullName ="آزاده صمدی"},
                new Student (){  FullName ="مریم امیر جلالی"}

            };
        public ActionResult Index()
        {
            return View(db.ToList());
        }

        [HttpPost]
        public JsonResult search(string SearchValue)
        {
            var findStd = db.Where(a => a.FullName.Contains(SearchValue));
            return Json(findStd, JsonRequestBehavior.AllowGet);
        }





        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}