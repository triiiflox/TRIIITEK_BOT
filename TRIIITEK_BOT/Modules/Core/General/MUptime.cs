using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TRIIITekBot.Modules.Core.General
{
    [Name("Uptime")]
    [Summary("Gives the uptime of the bot.")]
    public class MUptime : ModuleBase
    {
        [Command("Uptime")]
        public Task Uptime()
        {
            TimeSpan t = DateTime.Now - Resources.Variables.StartupTime;
            return ReplyAsync($"The current uptime is: `{t.Hours}:{t.Minutes}:{t.Seconds}`.");
        }
    }
}
