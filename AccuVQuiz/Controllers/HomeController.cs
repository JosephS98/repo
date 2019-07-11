using AccuVQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;

namespace AccuVQuiz.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Admin()
        {
            return View();

        }
        public ActionResult addQuestion()
        {
            return View();
        }
        public ActionResult Index()
        {

            return View();
        }

    
        public ActionResult Index1()
        {
            QuestionTrackerEntities1 DB = new QuestionTrackerEntities1();

            List<Question> question = DB.Questions.Where(x => x.CompanyID == 1).ToList();

            var final = new Question()
            {

                Question1 = question[0].Question1,
                Option1 = question[0].Option1,
                Option2 = question[0].Option2,
                Option3 = question[0].Option3,
                Option4 = question[0].Option4,
                Option5 = question[0].Option5
            };


            return View(final);

   
        }
        public ActionResult Index2()
        {

            QuestionTrackerEntities1 DB = new QuestionTrackerEntities1();

            List<Question> question = DB.Questions.Where(x => x.CompanyID == 1).ToList();



            var final = new Question()
            {
                Question1 = question[1].Question1,
                Option1 = question[1].Option1,
                Option2 = question[1].Option2,
                Option3 = question[1].Option3,
                Option4 = question[1].Option4,
                Option5 = question[1].Option5
            };

            return View(final);
        }
        public ActionResult Index3()
        {
            return View();
        }

        public ActionResult Index5()
        {

            return View();
        }

        public ActionResult Index4()
        {
            return View();
        }
        public ActionResult quizStart()
        {
            return View();
        }
       
    }
}
