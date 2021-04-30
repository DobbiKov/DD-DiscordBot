using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DobbiKovDiscordBot.Commands
{
    public class GetMyIdCommand : ModuleBase<SocketCommandContext>
    {
        [Command("getmyid")]
        public async Task GetMyIdAsync()
        {
            var user = Context.User;
            await ReplyAsync($"{user.Username}, ваш ID: {user.Id}");
        }
    }
}
