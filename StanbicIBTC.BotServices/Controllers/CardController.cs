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
    public class CardController : ApiController
    {
        public IHttpActionResult Card([FromBody]Card card)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                string cardReq = App.GetRedboxRequestCardPayload(card);

                string cardRes = App.CallRedbox(cardReq);

                LogWorker logworker = new LogWorker("CardController", "Card", "Ok");

                return Ok(cardRes);

            }
            catch (Exception ex)
            {
                LogWorker logworker = new LogWorker("CardController", "Card", ex.ToString());
                return InternalServerError();
            }
            
        }
    }
}
