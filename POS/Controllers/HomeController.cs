using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using POS.Data;
using POS.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace POS.Controllers
{
    public class HomeController : Controller
    {


        private readonly POSEntities _posEntities;
        public HomeController(POSEntities POSEntities)
        {
            _posEntities = POSEntities;
        }
        //[AuthorizationFilter]
        public ActionResult Index()
        {
            return View();
        }   
      
        public ActionResult Login()
        {

            return View();
        }
        
        public JsonResult CheckLogin(string username, string password)
        {
            
            var dataItem = _posEntities.Users.Where(x => x.Username == username && x.Password == password).SingleOrDefault();
            bool isLogged = true;
            if (dataItem != null)
            {
                //Session["Username"] = dataItem.Username;
                isLogged = true;
            }
            else
            {
                isLogged = false;
            }
            
            return Json(isLogged);
           
        }
    }
}
