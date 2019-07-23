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

   

            return View(question);
        }
        
        public PartialViewResult GetNextQuestion(int companyID)
        {
            
            List<Question> question = DB.Questions.Where(x => x.CompanyID == 1).ToList();
         
            /*
            var nextQuestion = new Question()
            {
                Question1 = question[questionID].Question1,
                Option1 = question[questionID].Option1,
                Option2 = question[questionID].Option2,
                Option3 = question[questionID].Option3,
                Option4 = question[questionID].Option4,
                Option5 = question[questionID].Option5
            };
            */
            return PartialView("_QuestionPartial", question);
        }
        [HttpPost]
        public ActionResult SaveData(/*int getQuestion, int getCompany,*/string option1, string option2,string option3,string option4,string option5 )
        {
            dataInsertion dataInsertion = new dataInsertion
            {
                option1 = option1,
                option2 = option2,
                option3 = option3,
                option4 = option4,
                option5 = option5,
                //questionID = getQuestion,
                //companyID = getCompany,

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
