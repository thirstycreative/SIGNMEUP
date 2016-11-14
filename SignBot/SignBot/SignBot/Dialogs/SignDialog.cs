using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using SignBot.Models;
using Microsoft.Bot.Connector;

namespace SignBot.Dialogs
{
    [Serializable]
    public class SignDialog : IDialog<string>
    {
        private const string HeroCard = "Hero card";
        private const string ThumbnailCard = "Thumbnail card";
        private const string ReceiptCard = "Receipt card";
        private const string SigninCard = "Sign-in card";

        private IEnumerable<string> options = new List<string> { HeroCard, ThumbnailCard, ReceiptCard, SigninCard };

        public async Task StartAsync(IDialogContext context)
        {
            
            context.Wait(this.MessageReceivedAsync);
            

        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var res = await result;
            Activity activity = res as Activity;

            if (null != activity)
            {
                string word = activity.Text;
                string url = Words.UrlForWord(word);
                if (null != url && url.Length>0)
                {
                    
                    var message = context.MakeMessage();

                    var attachment = GetVideoCard(url);
                    //Attachment a = new Attachment("video/mp4", url);
                    //message.Attachments.Add(a);
                    message.AddHeroCard<VideoCard>("", new List<VideoCard>() { attachment }, null);
                    await context.PostAsync(message);
                }
            }

            context.Done("");
            //PromptDialog.Choice<string>(
            //    context,
            //    this.DisplaySelectedCard,
            //    this.options,
            //    "What card would like to test?",
            //    "Ooops, what you wrote is not a valid option, please try again",
            //    3,
            //    PromptStyle.PerLine);
        }

        private static VideoCard GetVideoCard(string url)
        {
            var vCard = new VideoCard
            {
                Title = "SignBot Video Card",
                Subtitle = "Speaking your language",
                Text = "Build and connect intelligent bots to interact with your users naturally wherever they are, from text/sms to Skype, Slack, Office 365 mail and other popular services.",
                Media = new List<MediaUrl> { new MediaUrl(url) },

                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Watch", value: url) }
            };

            return vCard;
            //return  new Attachment("video/mp4", vCard.Media[0].Url); ;//.ToAttachmenet();//.ToAttachment();
        }

        public async Task DisplaySelectedCard(IDialogContext context, IAwaitable<string> result)
        {
            var selectedCard = await result;

            var message =  context.MakeMessage();

            var attachment = GetSelectedCard(selectedCard);
            message.Attachments.Add(attachment);
            await context.PostAsync(message);

            context.Wait(this.MessageReceivedAsync);
        }

        private static Attachment GetSelectedCard(string selectedCard)
        {
            switch (selectedCard)
            {
                case HeroCard:
                    //return GetHeroCard();
                case ThumbnailCard:
                   // return GetThumbnailCard();
                case ReceiptCard:
                    //return GetReceiptCard();
                case SigninCard:
                    //return GetSigninCard();

                default:
                    return GetVideoCard();
            }
        }

        private static Attachment GetHeroCard()
        {
            var heroCard = new HeroCard
            {
                Title = "BotFramework Hero Card",
                Subtitle = "Your bots — wherever your users are talking",
                Text = "Build and connect intelligent bots to interact with your users naturally wherever they are, from text/sms to Skype, Slack, Office 365 mail and other popular services.",
                Images = new List<CardImage> { new CardImage("https://sec.ch9.ms/ch9/7ff5/e07cfef0-aa3b-40bb-9baa-7c9ef8ff7ff5/buildreactionbotframework_960.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Get Started", value: "https://docs.botframework.com/en-us/") }
            };

            return heroCard.ToAttachment();
        }

        private static Attachment GetVideoCard()
        {
            var vCard = new VideoCard
            {
                Title = "SignBot Video Card",
                Subtitle = "Your bots — wherever your users are talking",
                Text = "Build and connect intelligent bots to interact with your users naturally wherever they are, from text/sms to Skype, Slack, Office 365 mail and other popular services.",
                Media = new List<MediaUrl> { new MediaUrl("http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475410603/yse5x1qpldluz4cw3ss1.mp4") },
                
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Get Started", value: "https://docs.botframework.com/en-us/") }
            };

            return new Attachment("video/mp4", vCard.Media[0].Url); ;//.ToAttachmenet();//.ToAttachment();
        }


        //Command cmd;
        //if (context.PrivateConversationData.TryGetValue(Command.NAME, out cmd))
        //{
        //    if (cmd.CommandType == CommandType.Message)
        //    {
        //        //get the message text and return the video clips 
        //        string text = cmd.Message;
        //        if (text != null && text.Length > 0)
        //        {

        //        }
        //        //IMessageActivity msg = context.MakeMessage();
        //        //msg.add
        //        VideoCard vCard = new VideoCard();

        //        //CardAction cAction = new CardAction();

        //    }
        //    else
        //    {
        //        context.Done($"I thought you wanted to translate a message, now I am not so sure. What do you want to do?");
        //    }
        //}
        //else
        //{
        //    context.Done($"Ok something isn't working out. What do you want to do?");
        //}
    }
}