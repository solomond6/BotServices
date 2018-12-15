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
    public class ChequeBookController : ApiController
    {
        public IHttpActionResult RequestChequeBook([FromBody]ChequeBook chequebook)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                string chequeBookReq = App.GetRedboxRequestChequeBookPayload(chequebook);

                string chequeBookRes = App.CallRedbox(chequeBookReq);

                LogWorker logworker = new LogWorker("ChequeBookController", "RequestChequeBook", "Ok");

                return Ok(chequeBookRes);
            }
            catch (Exception ex)
            {
                LogWorker logworker = new LogWorker("ChequeBookController", "RequestChequeBook", ex.ToString());
                return InternalServerError();
            }
            
        }

        public IHttpActionResult StopChequeBook([FromBody]ChequeBook chequebook)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                string stopChequeBookReq = App.GetRedboxStopChequeBookPayload(chequebook);

                string stopChequeBookRes = App.CallRedbox(stopChequeBookReq);

                LogWorker logworker = new LogWorker("ChequeBookController", "StopChequeBook", "Ok");

                return Ok(stopChequeBookRes);
            }
            catch (Exception ex)
            {
                LogWorker logworker = new LogWorker("ChequeBookController", "StopChequeBook", ex.ToString());
                return InternalServerError();
            }
            
        }
    }
}
