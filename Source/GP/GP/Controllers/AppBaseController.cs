using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GP.DAO;
using GP.Models;
using Microsoft.AspNetCore.Mvc;

namespace GP.Controllers
{
    public class AppBaseController : Controller
    {

        ModuleItemDao daoModuleItem = new ModuleItemDao();

        public bool IsAllowed(int moduleItemId, int roleId)
        {
            List<ModuleItem> lst = daoModuleItem.GetModuleItemByRoleId(roleId).Where(x => x.Id == moduleItemId && x.Allowed).ToList();
            if (lst.Count == 1)
            {
                return true;
            }
            return false;
        }

        public ActionResult NoPermission()
        {
            //if (Session["AppUser"] == null)
            //{
            //    return RedirectToAction("Index", "Home");
            //}
            //User appUser = (User)Session["AppUser"];

            //ViewBag.PageName = Session["PageName"];
            //ViewBag.UserName = appUser.UserName;
            //Session.Remove("PageName");
            return View();
        }
    }
}