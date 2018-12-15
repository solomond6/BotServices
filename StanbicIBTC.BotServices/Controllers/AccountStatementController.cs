using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StanbicIBTC.BotServices.Models;
using StanbicIBTC.BotServices.Utility;

namespace StanbicIBTC.BotServices.Controllers
{
    public class AccountStatementController : ApiController
    {
        public IHttpActionResult AccountStatement([FromBody]AccountStatement accountStatement)
        {
            try
            {
                //accountStatement.startDate = new DateTime.Now();
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                string accountStatementReq = App.GetRedboxAccountStatementPayload(accountStatement);

                string accountStatementRes = App.CallRedbox(accountStatementReq);

                LogWorker logworker = new LogWorker("AccountStatementController", "AccountStatement", "Ok");

                return Ok(accountStatementRes);
            }
            catch (Exception ex)
            {
                LogWorker logworker = new LogWorker("AccountStatementController", "AccountStatement", ex.ToString());
                return InternalServerError();
            }

        }
    }
}
