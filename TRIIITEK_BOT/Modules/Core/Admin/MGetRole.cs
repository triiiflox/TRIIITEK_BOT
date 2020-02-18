using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Discord.Commands;
using System.Threading.Tasks;

namespace TRIIITekBot.Modules.Core.Admin {
    public class MGetRole : ModuleBase<SocketCommandContext> {
        [Command("GetUserRoles")]
        public Task GetUserRoles(SocketGuildUser user) {
            List<SocketRole> roles = user.Roles.ToList();
            var s = "";
            foreach (var x in roles) {
                s = s + "\n" + x;
            }
            return ReplyAsync(s);
        }

        [Command("GetServerRoles")]
        public Task GetServerRoles()
        {
            List<IRole> roles = (Context.User as IGuildUser).Guild.Roles.ToList();
            var s = "";
            foreach (var x in roles)
            {
                s = s + "\n" + x;
            }
            return ReplyAsync(s);
        }
    }
}