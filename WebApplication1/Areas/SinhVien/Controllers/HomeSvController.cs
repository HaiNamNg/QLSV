using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Areas.SinhVien.Controllers
{
    public class HomeSvController : Controller
    {
        // GET: SinhVien/HomeSv
        [Authorize(Roles ="Sv")]
        public ActionResult Index()
        {
            return View();
        }
    }
}