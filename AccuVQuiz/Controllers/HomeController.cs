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

        public ActionResult Index1(int questionNum =1)
        {
            

            Question question = DB.Questions.Where(x => x.CompanyID == 1 && x.questionNum == questionNum).FirstOrDefault();


            return View(question);
        }
      
        [HttpPost]
        public ActionResult SaveData(int companyID, int questionID, string option1, string option2,string option3,string option4,string option5 )
        {
            SurveyData dataInsertion = new dataInsertion
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
