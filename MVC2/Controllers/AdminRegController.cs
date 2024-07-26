using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC2.Models;

namespace MVC2.Controllers
{
    public class AdminRegController : Controller
    {
        // GET: AdminReg
        MVCEntities3 dbobj = new MVCEntities3();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Insertadmin_Pageload()
        {
            return View();
        }

        public ActionResult Insertadmin_click(AdminInsertcs clsobj)
        {
            var getmaxid = dbobj.sp_maxIdLogin().FirstOrDefault();
            int mid = Convert.ToInt32(getmaxid);

            int regid = 0;

            if (mid == 0)
            {
                regid = 1;
            }
            else
            {
                regid = mid + 1;
            }

            dbobj.sp_adminReg(regid, clsobj.name, clsobj.address, clsobj.phone, clsobj.email);
            dbobj.sp_login_insert(regid, clsobj.username, clsobj.pass, "admin");
             

                return View("Insertadmin_Pageload");
        }
    }
}