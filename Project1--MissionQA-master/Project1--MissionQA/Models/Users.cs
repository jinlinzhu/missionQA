using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project1__MissionQA.Models
{
    public class Users

    {
        public Users()
        {
            this.MissionQuestions = new HashSet<MissionQuestions>();
        }
        [Key]
        public int userID { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        public string userFirstName { get; set; }
        public string userLastName { get; set; }

        public virtual ICollection<MissionQuestions> MissionQuestions { get; set; }


    }
}