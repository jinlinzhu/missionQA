using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project1__MissionQA.Models
{
    public class Mission
    {
        [Display(Name = "Mission Name")]
        public string Name { get; set; }

        public string President { get; set; }

        public string Address { get; set; }

        public string Language { get; set; }

        public string Climate { get; set; }

        public string DominantReligion { get; set; }

        public string Symbol { get; set; }

    }
}