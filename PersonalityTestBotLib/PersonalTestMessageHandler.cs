using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using BuildABot.Core.MessageHandlers;


namespace PersonalityTestBotLib
{
    [Export(typeof(MessageHandler))]
    public class PersonalTestMessageHandler:SingleStateMessageHandler
    {
        public PersonalTestMessageHandler() :base("time","Please wait while I get the current time...", true)
        {
        }



        //public override MessageHandlingResponse CanHandle(Message message)
        //{
        //    MessageHandlingResponse response = new MessageHandlingResponse();
        //    if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday
        //        || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
        //    {
        //        response.Confidence = 0;
        //    }
        //    else
        //    {
        //        // We could have implemented more complex/specific
        //        // logic for handling the message here.
        //        response = base.CanHandle(message);
        //    }

        //    return response;
        //}

        //protected override string GetInitialHandlingText()
        //{
        //    string bugId = this.GetBugId();
        //    string bugDatabase = this.GetBugDatabase();
        //    int numberOfRequests = this.GetNumberOfRequests();
        //    System.DateTime expectedReplyTime = DateTime.Now.AddSeconds(numberOfRequests * averageResponseTime);

        //    string initialHandlingText = String.Format(
        //        "Sure, retrieving details of bug #{0} in the {1} bug database. "
        //        + "I'm handling {2} requests right now so I expect you will get this response at {3}...",
        //        bugId, bugDatabase, numberOfRequests, expectedReplyTime);

        //    return initialHandlingText;
        //}

        public override Reply Handle(Message message)
        {
            Reply reply = new Reply();
            reply.Add("The current time is: " + DateTime.Now.ToShortTimeString());
            reply.Add("The current date is: " + DateTime.Now.ToShortDateString());
            return reply;
        }
    }
}
