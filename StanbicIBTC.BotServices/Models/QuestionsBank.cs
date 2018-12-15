using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StanbicIBTC.BotServices.Models
{
    public class QuestionsBank
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public bool? Answer { get; set; }
        public bool? IsAnswer { get; set; }
        public bool? IsPublished { get; set; }
        public bool? Published { get; set; }
        public DateTime DateCreated { get; set; }

        public QuestionsBank()
        {
            DateCreated = DateTime.Now;
        }
    }
}