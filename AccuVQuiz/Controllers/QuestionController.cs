using AccuVQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccuVQuiz.Controllers
{
    public class QuestionController : Controller
    {
        // GET: Question
        public ActionResult Index2()
        {
            QuestionTrackerEntities1 DB = new QuestionTrackerEntities1();

            List<Question> question = DB.Questions.ToList();
            return View(question);

          
        }
    }
}