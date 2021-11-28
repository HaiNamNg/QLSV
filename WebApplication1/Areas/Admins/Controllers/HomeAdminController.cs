using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Areas.Admin.Controllers
{
    [Authorize (Roles = "Admin")]
    public class HomeAdminController : Controller
    {
        // GET: Admin/HomeAdmin
        
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult About()
        {
            return View();
        }
    }
}