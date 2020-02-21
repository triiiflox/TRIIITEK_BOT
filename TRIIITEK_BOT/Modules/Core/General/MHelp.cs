using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TRIIITekBot.Modules.Core.General
{
    [Name("Help")]
    [Summary("Gives a list of all available commands.")]
    public class MHelp : ModuleBase
    {
        [Command("help")]
        public async Task Help()
        {
            var commands = Resources.Variables.Commands.Modules;
            var s = " \n";
            foreach (var i in commands)
            {
                s += $"\n`{Resources.Variables.Prefix}{i.Name}` | *{i.Summary}*";
            }
            await ReplyAsync(s);
        }
    }
}
