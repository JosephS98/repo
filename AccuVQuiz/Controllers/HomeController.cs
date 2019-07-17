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
        QuestionTrackerEntities1 DB = new QuestionTrackerEntities1();

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
        
        public PartialViewResult GetNextQuestion(int questionID)
        {
            
            List<Question> question = DB.Questions.Where(x => x.CompanyID == questionID).ToList();

            var nextQuestion = new Question()
            {
                Question1 = question[questionID].Question1,
                Option1 = question[questionID].Option1,
                Option2 = question[questionID].Option2,
                Option3 = question[questionID].Option3,
                Option4 = question[questionID].Option4,
                Option5 = question[questionID].Option5
            };

            return PartialView("_QuestionPartial", nextQuestion);
        }
        [HttpPost]
        public ActionResult SaveData(string getOptions)
        {
            dataInsertion dataInsertion = new dataInsertion
            {               
               options = getOptions,
            };
           try
             {
              if (ModelState.IsValid)
             {


         DB.dataInsertions.Add(dataInsertion);
         DB.SaveChanges();
       // RedirectToAction("Home");
                }
             }
           catch (Exception e)
           {
             Console.WriteLine("error" + e);
          }
         return Json(new { sucess = "true" });


        }




        public ActionResult quizStart()
        {
            return View();
       }
       
    }
}
