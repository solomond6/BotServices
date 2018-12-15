using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StanbicIBTC.BotServices.Models
{
    public class FreezeAccount
    {
        public string CustomerId { get; set; }
        public string CustomerIdType { get; set; }
        public  string SubmissionTime { get; set; }
        public string PassId { get; set; }
        public string PassIdType { get; set; }
        public string PassCodeType { get; set; }
        public string PassCode { get; set; }

        public FreezeAccount()
        {
            DateTime time = DateTime.Now;
            string format = "d-MMM-yy d.MM.yy";
            SubmissionTime = time.ToString(format);
        }
    }
}