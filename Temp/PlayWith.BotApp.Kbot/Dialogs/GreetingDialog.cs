using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace PlayWith.BotApp.Kbot.Dialogs
{
    [Serializable]
    public class GreetingDialog : IDialog<string>
    {
        public async Task StartAsync(IDialogContext context)
        {
            await context.PostAsync("Hi, what's your name?");
            context.Wait(MessageReceivedAsync);
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            await result;
            var userName = String.Empty;
            context.UserData.TryGetValue("Name", out userName); // todo: Why userName not getting a value?
            await context.PostAsync($"Hello, {userName}");
            context.Wait(MessageReceivedAsync);
        }
    }
}