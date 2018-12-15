using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StanbicIBTC.BotServices.Models;
using StanbicIBTC.BotServices.Context;
using StanbicIBTC.BotServices.Utility;

namespace StanbicIBTC.BotServices.Controllers
{
    public class QuestionsBankController : ApiController
    {
        public IHttpActionResult PostQuestion([FromBody]QuestionsBank questionsBank)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                using (var botContext = new BotDBContext())
                {
                    botContext.QuestionsBank.Add(new QuestionsBank()
                    {
                        Question = questionsBank.Question
                    });

                    botContext.SaveChanges();
                }

                return Ok("Success");
            }
            catch(Exception ex)
            {
                LogWorker logworker = new LogWorker("QuestionsBankController", "PostQuestion", ex.ToString());
                return InternalServerError();
            }
            
        }

    }
}
