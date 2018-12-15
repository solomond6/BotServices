using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StanbicIBTC.BotServices.Models
{
    public class AccountStatement
    {
        public string CustomerId { get; set; }
        public string CustomerIdType { get; set; }
        public  string SubmissionTime { get; set; }
        public  string SessionId { get; set; }
        public string AccountNumber { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string PassId { get; set; }
        public string PassIdType { get; set; }
        public string PassCodeType { get; set; }
        public string PassCode { get; set; }
        public string FileType { get; set; }

        public AccountStatement()
        {
            DateTime time = DateTime.Now;
            string format = "d-MMM-yy d.MM.yy";
            SubmissionTime = time.ToString(format);
        }
    }
}