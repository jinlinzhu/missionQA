using Project1__MissionQA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1__MissionQA.Controllers
{
    public class MissionController : Controller
    {
        public List<string> listNames = new List<string> { "Brazil Florianópolis", "Puerto Rico San Juan", "New York New York" };

        public int MissionNumber { get; set; }

        // GET: Mission
        public ActionResult Missions()
        {
            ViewBag.missions = listNames;
            return View();
        }

        //POST: Mission
        [HttpPost]
        public ActionResult YourMission(Mission mission)
        {
            if (mission.Name == "Brazil Florianópolis")
            {
                mission.President = "Ramilfo Silva";
                mission.Address = "Santa Catarina";
                mission.Language = "Portuguese";
                mission.Climate = "Local steppe";
                mission.DominantReligion = "Catholicism";
                mission.Symbol = "file-location-of-the-flag-image";

                return View(mission);
            }
            else if (mission.Name == "Puerto Rico San Juan")
            {
                mission.President = "President Boucher";
                mission.Address = "Puerto Rico";
                mission.Language = "Spanish";
                mission.Climate = "Tropical";
                mission.DominantReligion = "Catholicism";
                mission.Symbol = "file-location-of-the-flag-image";

                return View(mission);
            }
            else
            {
                mission.President = "Nelson";
                mission.Address = "New York";
                mission.Language = "Multiple";
                mission.Climate = "Humid subtropical";
                mission.DominantReligion = "Protestantism";
                mission.Symbol = "file-location-of-the-big-apple";

                return View(mission);
            }
        }
    }
}