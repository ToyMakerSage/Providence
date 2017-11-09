using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.IO;

namespace Providence
{
    public class commands
    {
        [Command("roulette-debug")]
        public async Task Roulette(CommandContext ctx, int size)
        {
            Random rng = new Random();
            string x = "./commandresources/Dlist" + size + ".txt";
            await ctx.RespondAsync("🎲 [RouletteRawOutput]: "+rng.Next(1, 4)+"\n"+rng.Next(1, (File.ReadAllLines(x).Length))+"\n"+rng.Next(1, 4)+"\n"+rng.Next(1, 6)+"");
        }
    }
}
