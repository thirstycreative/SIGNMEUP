using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using SignBot.Models;

namespace SignBot.Dialogs
{
    [Serializable]
    public class SignDialog : IDialog<string>
    {
        public async Task StartAsync(IDialogContext context)
        {
            Command cmd;
            if (context.PrivateConversationData.TryGetValue(Command.NAME, out cmd))
            {
                if (cmd.CommandType == CommandType.Message)
                {
                    //get the message text and return the video clips 

                    //Microsoft.Bot.Connector.VideoCard msg;
                    
                    //context.PostAsync(msg);
                }
                else
                {
                    context.Done($"I thought you wanted to translate a message, now I am not so sure. What do you want to do?");
                }
            }
            else
            {
                context.Done($"Ok something isn't working out. What do you want to do?");
            }

        }
    }
}