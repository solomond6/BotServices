using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Web.Http;
using StanbicIBTC.BotServices.Models;
using StanbicIBTC.BotServices.Utility;

namespace StanbicIBTC.BotServices.Controllers
{
    public class BalanceEnquiryController : ApiController
    {
        public IHttpActionResult BalanceEnquiry([FromBody]BalanceEnquiry balanceEnquiry)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                string balanceEnquiryReq = App.GetRedboxBalanceEnquiryPayload(balanceEnquiry);

                string balanceEnquiryRes = App.CallRedbox(balanceEnquiryReq);

                LogWorker logworker = new LogWorker("BalanceEnquiryController", "BalanceEnquiry", "Ok");

                return Ok(balanceEnquiryRes);
            }
            catch (Exception ex)
            {
                LogWorker logworker = new LogWorker("BalanceEnquiryController", "BalanceEnquiry", ex.ToString());
                return InternalServerError();
            }
        }

    }
}
