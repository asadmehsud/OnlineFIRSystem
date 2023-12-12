using OnlineFIRSystemP.Models;
using OnlineFIRSystemProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineFIRSystemP.Controllers
{
    public class AdminProvinceController : Controller
    {
        // GET: AdminProvince
        TblProvince province = new TblProvince();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SaveProvince(TblProvince obj)
        {
          
            province.Insert(obj);
            return View("Index");
        }
        public ActionResult LoadData()
        {
            IEnumerable<TblProvince> list = province.GetTblProvince();
            return PartialView("_LoadData", list);
        }
    }
}