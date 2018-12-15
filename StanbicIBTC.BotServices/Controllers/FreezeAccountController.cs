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
    public class FreezeAccountController : ApiController
    {
        public IHttpActionResult FreezeAccount([FromBody]FreezeAccount freezeAccount)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                string freezeAccountReq = App.GetRedboxFreezeAccountPayload(freezeAccount);

                string freezeAccountRes = App.CallRedbox(freezeAccountReq);

                LogWorker logworker = new LogWorker("FreezeAccountController", "FreezeAccount", "Ok");

                return Ok(freezeAccountRes);
            }
            catch (Exception ex)
            {
                LogWorker logworker = new LogWorker("FreezeAccountController", "FreezeAccount", ex.ToString());
                return InternalServerError();
            }
            
        }
    }
}
