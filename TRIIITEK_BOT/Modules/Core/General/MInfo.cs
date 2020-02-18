using Discord.Commands;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TRIIITekBot.Modules.Core.General
{
    class MInfo : ModuleBase
    {
        private IConfiguration _Config = new TRIIITekBot.Program()._config;
        [Command("info")]
        public Task Info()
        {
            return ReplyAsync(
                $"     **TRIIITek_Bot Version: [PLACEHOLDER]**" +
                $"*A Collaberation between TRIIIFLOX and CyberTek.*" +
                $"" +
                $"For help type `{_Config["Prefix"]}help`");
        }
    }
}
