using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using StanbicIBTC.BotServices.Models;

namespace StanbicIBTC.BotServices.Context
{
    public class BotDBContext : DbContext
    {
        public DbSet<QuestionsBank> QuestionsBank { get; set; }
    }
}