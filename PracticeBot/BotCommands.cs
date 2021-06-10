using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using PracticeBot.Models;

namespace PracticeBot
{
    public class BotCommands : ModuleBase<SocketCommandContext>
    {
        [Command("test")]
        public async Task TestCommandAsync()
        {
            using (var db = new User())
            {

            }
            await ReplyAsync("", false, new EmbedBuilder().WithTitle("Success").WithDescription("yay").Build());
        }

        


    }
}
