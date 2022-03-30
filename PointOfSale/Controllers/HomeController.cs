using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using PointOfSale.fonts.Helper;
using PointOfSale.Models;

namespace PointOfSale.Controllers
{
    public class HomeController : Controller    
    {
        [AuthorizationFilter]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {

            return View();
        }   

        [HttpPost]
        public JsonResult CheckLogin(string username, string password)
        {
            POSDBEntities db = new POSDBEntities();
            var dataItem = db.Users.Where(x => x.Username == username && x.Password == password).SingleOrDefault();
            bool isLogged = true;
            if (dataItem != null)
            {
                Session["Username"] = dataItem.Username;
                isLogged = true;
                
            }
            else
            {
                isLogged = false;
            }
            return Json(isLogged, JsonRequestBehavior.AllowGet);
        }

    }
}