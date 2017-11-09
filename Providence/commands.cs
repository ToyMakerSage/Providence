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
        public async Task Roulette(CommandContext ctx)
        {
            Random rng = new Random();
            int rngEXP = rng.Next(1, 4);
            int rngD4 = rng.Next(1, (File.ReadAllLines("./commandresources/Dlist4.txt").Length));
            int rngD8 = rng.Next(1, (File.ReadAllLines("./commandresources/Dlist8.txt").Length));
            int rngD24 = rng.Next(1, (File.ReadAllLines("./commandresources/Dlist24.txt").Length));
            int rngMOD = rng.Next(1, 4);
            int rngSR = rng.Next(1, 6);
            await ctx.RespondAsync($"🎲 [RouletteRawOutput]: {rngEXP} {rngD4} {rngMOD} {rngSR}");
        }
    }
}
