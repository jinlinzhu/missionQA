using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project1__MissionQA.Models
{
    public class MissionQuestions
    {   [Key]
        public int  questionID { get; set; }
        public int missionID { get; set; }
        public int userID { get; set; }
        public string question { get; set; }
        public string answer { get; set; }

      public virtual Users Users { get; set; }
        public virtual Missions Missions { get; set; }

    }
}