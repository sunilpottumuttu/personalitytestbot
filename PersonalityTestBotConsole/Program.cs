using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildABot.Core;
using BuildABot.Util;
using BuildABot.Core.MessageHandlers;

namespace PersonalityTestBotConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot bot = new Bot();
            bot.Replied += Bot_Replied;

            string userMessage = Console.ReadLine();
            while (userMessage != "exit")
            {
                bot.ProcessMessage(userMessage);
                userMessage = Console.ReadLine();
            }
        }

        private static void Bot_Replied(object sender, ReplyEventArgs e)
        {
            foreach (ReplyMessage replyMessage in e.Reply.Messages)
            {
                Console.WriteLine("Bot says: " + replyMessage.Content);
            }
        }
    }
}
