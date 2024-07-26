using MVC2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC2.Models;

namespace MVC2.Controllers
{
    public class DBInsertController : Controller
    {
        MVCEntities dbobj = new MVCEntities();
        MVCEntities2 dbobj2 = new MVCEntities2();
        MVCEntities3 dbobj3 = new MVCEntities3();
        // GET: DBInsert

        public List<CheckBoxListHelper> getQualificationData()
        {
            List<CheckBoxListHelper> sts = new List<CheckBoxListHelper>()
            {
                new CheckBoxListHelper{Value="SSLC",Text="SSLC",IsChecked=true},
                new CheckBoxListHelper{Value="PLUS TWO",Text="PLUS TWO",IsChecked=false},
                new CheckBoxListHelper{Value="BCA",Text="BCA",IsChecked=false},
                new CheckBoxListHelper{Value="MCA",Text="MCA",IsChecked=false},
                new CheckBoxListHelper{Value="BTECH",Text="BTECH",IsChecked=false},
            };
            return sts;
        }
        public ActionResult Insert_PageLoad()
        {

            List<stclass> stList = new List<stclass>
            {
                new stclass{SId=1,Sname="Kerala"},
                new stclass{SId=2,Sname="Karnataka"},
                new stclass{SId=3,Sname="TamilNadu"},
            };
            ViewBag.Selstates = new SelectList(stList, "SId", "Sname");
            UserInsert user = new UserInsert();
            user.MyFavoriteQual = getQualificationData();

            return View(user);
        }

      

        public ActionResult Insert_click(UserInsert clsobj, HttpPostedFileBase file,FormCollection form)
        {
            if (ModelState.IsValid)
            {
                if (file.ContentLength > 0)
                {
                    string fname = Path.GetFileName(file.FileName);
                    var s = Server.MapPath("~/PHS");
                    string pa = Path.Combine(s, fname);
                    file.SaveAs(pa);

                    var fullpath = Path.Combine("~\\PHS", fname);
                    clsobj.Photo = fullpath;
                }

                List<stclass> stList = new List<stclass>
            {
                new stclass{SId=1,Sname="Kerala"},
                new stclass{SId=2,Sname="Karnataka"},
                new stclass{SId=3,Sname="TamilNadu"},
            };
                int selectedId = Convert.ToInt32(form["Selstates"]);
                stclass selectedItem = stList.FirstOrDefault(c => c.SId == selectedId);
                clsobj.sId = selectedItem.SId;
                clsobj.sName = selectedItem.Sname;
                //clsobj.sName = "gg";
                //clsobj.Age = 18;
                ViewBag.Selstates = new SelectList(stList, "SId", "Sname");

                //Console.Write(ViewBag);
                //Console.Write(clsobj.selectedQual);

                var quid = string.Join(",", clsobj.selectedQual);
                clsobj.Qual = quid;
                clsobj.MyFavoriteQual = getQualificationData();


                dbobj3.sp_DBinsert(clsobj.Name, clsobj.Age, clsobj.Address, clsobj.Email, clsobj.Photo, clsobj.Gender, clsobj.sName, clsobj.Qual, clsobj.Username, clsobj.Pwd);


                return View("Insert_Pageload", clsobj);
            }
            else
            {
                List<stclass> stList = new List<stclass>
            {
                new stclass{SId=1,Sname="Kerala"},
                new stclass{SId=2,Sname="Karnataka"},
                new stclass{SId=3,Sname="TamilNadu"},
            };

                ViewBag.Selstates = new SelectList(stList, "SId", "Sname");
                clsobj.MyFavoriteQual = getQualificationData();

            }
            return View("Insert_Pageload", clsobj);
        


        }
    }
}