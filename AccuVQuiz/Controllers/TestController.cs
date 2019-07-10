using AccuVQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccuVQuiz.Controllers
{
    public class AdminController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {

            QuestionTrackerEntities1 DB = new QuestionTrackerEntities1();

            List<AdminChange> admin = DB.AdminChanges.ToList();
            return View(admin);
        }
    }
}