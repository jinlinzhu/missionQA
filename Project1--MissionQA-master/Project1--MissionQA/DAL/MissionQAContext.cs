using Project1__MissionQA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project1__MissionQA.DAL
{
    public class MissionQAContext :DbContext
    {
        public MissionQAContext() : base("MissionQAContext")
        {

        }

        public DbSet<MissionQuestions> missionQuestions { get; set; }
        public DbSet<Missions> missions { get; set; }
        public DbSet<Users> users { get; set; }

    }
}