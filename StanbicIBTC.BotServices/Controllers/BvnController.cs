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
    public class BvnController : ApiController
    {
        public IHttpActionResult FetchBvn([FromBody]FetchBvn fetchBvn)
        {
            try {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                string bvnReq = App.GetRedboxFetchBvnPayload(fetchBvn);

                string bvnRes = App.CallRedbox(bvnReq);

                LogWorker logworker = new LogWorker("BvnController", "FetchBvn", "OK");

                return Ok(bvnRes);
            }
            catch(Exception ex)
            {
                LogWorker logworker = new LogWorker("BvnController", "FetchBvn", ex.ToString());
                return InternalServerError();
            }
        }
    }
}
