using AccuVQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccuVQuiz.Controllers
{
    public class HomeController : Controller
    {
        QuestionTrackerEntities1 DB = new QuestionTrackerEntities1();
        ViewModel VM = new ViewModel();
        int i = 1;
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

        public ActionResult Index1(int companyID=1, int questionNum=1)
        {


            Question question = DB.Questions.Where(x => x.CompanyID == companyID && x.questionNum == questionNum).FirstOrDefault();
           
            
            return View(question);
        }


        public PartialViewResult GetNextQuestion( int companyID, int questionNum)
        {
            
            Question question = DB.Questions.Where(x => x.CompanyID == companyID && x.questionNum == questionNum).FirstOrDefault();
            

            return PartialView("_QuestionPartial", question);
        }

        [HttpPost]
        public ActionResult SaveData(int companyID, int questionID,string option1, string option2,string option3,string option4,string option5)
        {
            SurveyData SurveyData = new SurveyData
            {
                option1 = option1,
                option2 = option2,
                option3 = option3,
                option4 = option4,
                option5 = option5,
                questionID = questionID,
                companyID = companyID,

            };
           try
             {
              if (ModelState.IsValid)
             {


         DB.SurveyDatas.Add(SurveyData);
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

        public ActionResult Index2()
        {

            return View();

        }

        public ActionResult quizStart(int companyID=1)
        {

            Company companyName = DB.Companies.Where(x => x.CompanyID == companyID).First();


            return View(companyName);
       }

    }
}
