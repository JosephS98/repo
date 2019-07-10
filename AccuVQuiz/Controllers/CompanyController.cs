using AccuVQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccuVQuiz.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index1()
        {
            QuestionTrackerEntities1 DB = new QuestionTrackerEntities1();

            List<Company> company = DB.Companies.ToList();
            return View(company);
        }
    }
}