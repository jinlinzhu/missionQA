using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project1__MissionQA.Models
{
    public class Missions

    {
        public Missions()
        {
            this.MissionQuestions = new HashSet<MissionQuestions>();
        }





        [Key]
        public int missionID { get; set; }
        public string missionName { get; set; }
        public string missionPresidentName { get; set; }
        public string missionAddress { get; set; }
        public string missionLanguage { get; set; }
        public string missionClimate { get; set; }
        public string missionDomReligion { get; set; }
        public string missionSymbol { get; set; }

        public virtual ICollection<MissionQuestions> MissionQuestions { get; set; }

    }
}