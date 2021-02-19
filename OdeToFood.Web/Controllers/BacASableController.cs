using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class BacASableController : Controller
    {
        private readonly IStudentData db;

        public BacASableController(IStudentData db)
        {
            this.db = db;
        }

        // GET: BacASable
        public ActionResult Index()
        {
            var model = db.GetAllStudents();
            return View(model);
        }
    }
}