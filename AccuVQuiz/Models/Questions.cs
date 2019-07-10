using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AccuVQuiz.Models
{
    public class Questions
    {

        public int ID { get; set; }
        public int CompanyID { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Option5 { get; set; }

    }

    /*
    public class Companydb
    {


        public int CompanyID { get; set; }

        public string CompanyName { get; set; }


    }
    public class Userdb
    {


        public int UserID { get; set; }

        public string UserName { get; set; }


    }
    public class Admindb
    {


        public int AdminID { get; set; }

        public string AdminLogin { get; set; }
        public string AdminPassword { get; set; }
    }
    */
}