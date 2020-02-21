﻿using Discord.Commands;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TRIIITekBot.Modules.Core.General
{
    [Name("Info")]
    [Summary("Gives general info about the bot.")]
    public class MInfo : ModuleBase
    {
        [Command("info")]
        public Task Info()
        {
            return ReplyAsync(
                $"     **TRIIITek_Bot Version: [PLACEHOLDER]**" +
                $"*A Collaberation between TRIIIFLOX and CyberTek.*" +
                $"" +
                $"For help type `{Resources.Variables.Prefix}help`");
        }
    }
}
