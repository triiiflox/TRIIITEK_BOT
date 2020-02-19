using Discord.Commands;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TRIIITekBot.Resources
{
    public static class Variables
    {
        public static CommandService Commands { get; set; }
        public static string Prefix { get; set; }
        public static DateTime StartupTime { get; set; }
    }
    
}
