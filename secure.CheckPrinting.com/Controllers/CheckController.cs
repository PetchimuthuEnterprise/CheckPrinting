using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace secure.CheckPrinting.com.Controllers
{
    public class CheckController : Controller
    {
        #region Index
        // GET: Check
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region Add New Check Templete
        /// <summary>
        /// Add New Check Templete
        /// </summary>
        /// <returns></returns>
        public ActionResult AddNewCheckTemplete(long id)
        {
            return View();
        }
        #endregion

    }
}