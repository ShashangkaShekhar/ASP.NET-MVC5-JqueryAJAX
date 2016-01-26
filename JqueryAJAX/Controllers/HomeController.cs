using JqueryAJAX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryAJAX.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/JqAJAX
        [HttpPost]
        public ActionResult JqAJAX(Student st)
        {
            try
            {
                return Json(new
                {
                    msg = "Successfully added " + st.Name
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: Home/JqAJAX
        [HttpPost]
        public ActionResult JqAJAX_Array(string[] values)
        {
            try
            {
                return Json(new
                {
                    msg = String.Format("Fist Name: {0}", values[0])
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}