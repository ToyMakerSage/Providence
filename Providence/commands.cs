using System;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.ModernEmbedBuilder;
using DSharpPlus.Entities;

namespace Providence
{
    public class commands
    {
        Random rng = new Random();
        string[,] Dlist4 = new string[56, 2] { { "Sastasha", "https://i.imgur.com/PTIiFOQ.png" }, { "The Tam-Tara Deepcroft", "https://i.imgur.com/UTRDaDJ.png" }, { "Copperbell Mines", "https://i.imgur.com/DzQhWR8.png" }, { "Halatali", "https://i.imgur.com/RNRPcM7.png" }, { "The Thousand Maws of Toto-Rak", "https://i.imgur.com/c4C2L27.png" }, { "Haukke Manor", "https://i.imgur.com/M5Y5Y81.png" }, { "Brayflox's Longstop", "https://i.imgur.com/kGy1ZDW.png" }, { "The Sunken Temple of Qarn", "https://i.imgur.com/3029NSN.png" }, { "Cutter's Cry", "https://i.imgur.com/IiM11xY.png" }, { "The Stone Vigil", "https://i.imgur.com/oETrmhS.png" }, { "Dzemael Darkhold", "https://i.imgur.com/PeC3DD5.png" }, { "The Aurum Vale", "https://i.imgur.com/3vXu5dB.png" }, { "The Wanderer's Palace", "https://i.imgur.com/0cRsYEp.png" }, { "Amdapor Keep", "https://i.imgur.com/ARBWLrW.png" }, { "Pharos Sirius", "https://i.imgur.com/8G6SKDr.png" }, { "Copperbell Mines (Hard)", "https://i.imgur.com/A0vKVxX.png" }, { "Haukke Manor (Hard)", "https://i.imgur.com/t06bymg.png" }, { "The Lost City of Amdapor", "https://i.imgur.com/zz7V8kB.png" }, { "Halatali (Hard)", "https://i.imgur.com/d5ldzQn.png" }, { "Brayflox's Longstop (Hard)", "https://i.imgur.com/ArSKzbj.png" }, { "Hullbreaker Isle", "https://i.imgur.com/jFVqLbp.png" }, { "The Stone Vigil (Hard)", "https://i.imgur.com/esCHnLj.png" }, { "Tam-Tara Deepcroft (Hard)", "https://i.imgur.com/cm8US1g.png" }, { "Snowcloak", "https://i.imgur.com/lvuwShu.png" }, { "Sastasha (Hard)", "https://i.imgur.com/FMlo95m.png" }, { "The Sunken Temple of Qarn (Hard)", "https://i.imgur.com/aUPMAB2.png" }, { "The Keeper of the Lake", "https://i.imgur.com/4iJ7S5F.png" }, { "The Wanderer's Palace (Hard)", "https://i.imgur.com/qJ8j2eR.png" }, { "Amdapor Keep (Hard)", "https://i.imgur.com/JycTz6a.png" }, { "The Dusk Vigil", "https://i.imgur.com/pUqD9yN.png" }, { "Sohm Al", "https://i.imgur.com/rYnF3DN.png" }, { "The Aery", "https://i.imgur.com/B3aCWIR.png" }, { "The Vault", "https://i.imgur.com/LQg4HOm.png" }, { "The Great Gubal Library", "https://i.imgur.com/jlnm2rL.png" }, { "The Aetherochemical Research Facility", "https://i.imgur.com/R1CLg19.png" }, { "Neverreap", "https://i.imgur.com/u3te2XY.png" }, { "The Fractal Continuum", "https://i.imgur.com/unkFg26.png" }, { "Saint Mocianne's Arboretum", "https://i.imgur.com/Z7wjxzn.png" }, { "Pharos Sirius (Hard)", "https://i.imgur.com/pgYv5Ai.png" }, { "The Antitower", "https://i.imgur.com/GEjXEOP.png" }, { "The Lost City of Amdapor (Hard)", "https://i.imgur.com/RdY4noy.png" }, { "Sohr Khai", "https://i.imgur.com/L8Jd7Wm.png" }, { "Hullbreaker Isle (Hard)", "https://i.imgur.com/m3vw7NG.png" }, { "Xelphatol", "https://i.imgur.com/kvWwlDk.png" }, { "The Great Gubal Library (Hard)", "https://i.imgur.com/EusbjU8.png" }, { "Baelsar's Wall", "https://i.imgur.com/dUaG3gc.png" }, { "Sohm Al (Hard)", "https://i.imgur.com/AIFHdkc.png" }, { "The Sirensong Sea", "https://i.imgur.com/dc5m1UF.png" }, { "Shisui of the Violet Tides", "https://i.imgur.com/ib6zmvW.png" }, { "Bardam's Mettle", "https://i.imgur.com/L9CyfC0.png" }, { "Doma Castle", "https://i.imgur.com/7bm6aKj.png" }, { "Castrum Abania", "https://i.imgur.com/qpl40uY.png" }, { "Ala Mhigo", "https://i.imgur.com/Sxw3irH.png" }, { "Kugane Castle", "https://i.imgur.com/g22wgum.png" }, { "The Temple of the Fist", "https://i.imgur.com/gaAwE84.png" }, { "The Drowned City of Skalla", "https://i.imgur.com/9mwEPRn.png" } };
        string[] Dlist24 = new string[] { "Labyrinth of the Ancients", "Sycrus Tower", "The Void Ark", "The Weeping City of Mhach", "Dun Scaith", "The Royal City of Rabanastre" };
        string[] Dlist8 = new string[] { "Castrum Meridianum", "The Praetorium", "Cape Westwind", "The Chrysalis", "The Steps of Faith", "A Relic Reborn: The Chimera", "A Relic Reborn: The Hydra", "Battle on the Big Bridge", "The Dragon's Neck", "Battle in the Big Keep", "The Bowl of Embers (Hard)", "The Howling Eye (Hard)", "The Navel (Hard)", "Thornmarch (Hard)", "The Whorleater (Hard)", "The Striking Tree (Hard)", "Akh Afah Amphitheatre (Hard)", "Urth's Fount", "Thok ast Thok (Hard)", "The Limitless Blue (Hard)", "The Singularity Reactor", "Containment Bay S1T7", "Containment Bay P1T6", "Containment Bay Z1T9", "The Pool of Tribute", "Emanation", "The Royal Menagerie", "StoryRaid", "StoryRaid", "StoryRaid", "StoryRaid", "StoryRaid", "StoryRaid", "EX", "EX", "EX", "Savage" };
        string[] DlistEX = new string[] { "The Minstrel's Ballad: Ultima's Bane", "The Howling Eye (Extreme)", "The Navel (Extreme)", "The Bowl of Embers (Extreme)", "Thornmarch (Extreme)", "The Whorleater (Extreme)", "The Striking Tree (Extreme)", "Akh Afah Amphitheatre (Extreme)", "The Limitless Blue (Extreme)", "Thok ast Thok (Extreme)", "The Minstrel's Ballad: Thordan's Reign", "The Minstrel's Ballad: Nidhogg's Rage", "Containment Bay S1T7 (Extreme)", "Containment Bay P1T6 (Extreme)", "Containment Bay Z1T9 (Extreme)", "Emanation (Extreme)", "The Pool of Tribute (Extreme)", "The Minstrel's Ballad: Shinryu's Domain" };
        string[] DlistSavage = new string[] { "The Binding Coil of Bahamut Turn 1", "The Binding Coil of Bahamut Turn 2", "The Binding Coil of Bahamut Turn 3", "The Binding Coil of Bahamut Turn 4", "The Binding Coil of Bahamut Turn 5", "The Second Binding Coil of Bahamut Turn 1", "The Second Binding Coil of Bahamut Turn 2", "The Second Binding Coil of Bahamut Turn 3", "The Second Binding Coil of Bahamut Turn 4", "The Final Binding Coil of Bahamut Turn 1", "The Final Binding Coil of Bahamut Turn 2", "The Final Binding Coil of Bahamut Turn 3", "The Final Binding Coil of Bahamut Turn 4", "Alexander Gordias - The Fist of the Father (Savage)", "Alexander Gordias - The Cuff of the Father (Savage)", "Alexander Gordias - The Arm of the Father (Savage)", "Alexander Gordias - The Burden of the Father (Savage)", "Alexander Midas - The Fist of the Son (Savage)", "Alexander Midas - The Cuff of the Son (Savage)", "Alexander Midas - The Arm of the Son (Savage)", "Alexander Midas - The Burden of the Son (Savage)", "Alexander Creator - The Eyes of the Creator (Savage)", "Alexander Creator - The Breath of the Creator (Savage)", "Alexander Creator - The Heart of the Creator (Savage)", "Alexander Creator - The Soul of the Creator (Savage)", "The Second Binding Coil of Bahamut (Savage)" };
        string[] DlistStoryRaid = new string[] { "Alexander Gordias - The Fist of the Father", "Alexander Gordias - The Cuff of the Father", "Alexander Gordias - The Arm of the Father", "Alexander Gordias - The Burden of the Father", "Alexander Midas - The Fist of the Son", "Alexander Midas - The Cuff of the Son", "Alexander Midas - The Arm of the Son", "Alexander Midas - The Burden of the Son", "Alexander Creator - The Eyes of the Creator", "Alexander Creator - The Breath of the Creator", "Alexander Creator - The Heart of the Creator", "Alexander Creator - The Soul of the Creator", "Omega Deltascape - V1.0", "Omega Deltascape - V2.0", "Omega Deltascape - V3.0", "Omega Deltascape - V4.0" };
        string[] SpecialRules = new string[] { "Minimum Item Level", "Speed Run", "Over-Optimise", "M A N M O D E", "All DPS Must be Casters", "All DPS Must be Ranged Physical", "All DPS Must be Melee", "All DPS slots must be filled with Healers", "All DPS slots must be filled with Tanks" };
        [Command("roulette"), Description("A Pseudo Duty Roulette")]
        public async Task Roulette(CommandContext ctx, int size)
        {
            Console.WriteLine("Command Executed");
            if (!(size == 4 || size == 8 || size == 24))
            {
                var emoji = DiscordEmoji.FromName(ctx.Client, ":warning:");
                var embed = new DiscordEmbedBuilder
                {
                    Title = "Providence Roulette",
                    Description = $"{emoji} **Roulette Generation Failed**\n\t\t*Invalid Group Size*\n\t\t*Please specify a group size of 4, 8 or 24*",
                    Color = new DiscordColor(0xFF0000)
                };
                await ctx.RespondAsync("", embed: embed);
            }
            else if (size == 4)
            {
                int randomIndex = rng.Next(Dlist4.GetLength(0));
                int randomIndexSR = rng.Next(SpecialRules.Length);
                string text = Dlist4[randomIndex,0];
                string text2 = Dlist4[randomIndex,1];
                string text3 = SpecialRules[randomIndexSR];
                var embed = new DiscordEmbedBuilder();
                embed.WithTitle("Providence Roulette").WithDescription("*I have prepared your challenge.*").WithImageUrl(text2).WithColor(new DiscordColor(0, 216, 255));
                embed.AddField("**Duty**","*" + text + "*",true);
                embed.AddField("**Type**","*4-man Dungeon*",true);
                embed.AddField("**Special Rules**", "*" + text3 + "*", false);
                await ctx.RespondAsync("", embed: embed);
            }
            else if (size == 24)
            {
                int randomIndex = rng.Next(Dlist24.Length);
                string text = Dlist24[randomIndex];
                await ctx.RespondAsync($"🎲 [RouletteDutyOutput]: {text}");
            }
            else if (size == 8)
            {
                int randomIndex = rng.Next(Dlist8.Length);
                string text = Dlist8[randomIndex];
                if (text == "StoryRaid")
                {
                    randomIndex = rng.Next(DlistStoryRaid.Length);
                    text = DlistStoryRaid[randomIndex];
                }
                if (text == "EX")
                {
                    randomIndex = rng.Next(DlistEX.Length);
                    text = DlistEX[randomIndex];
                }
                if (text == "Savage")
                {
                    randomIndex = rng.Next(DlistSavage.Length);
                    text = DlistSavage[randomIndex];
                }
                await ctx.RespondAsync($"🎲 [RouletteDutyOutput]: {text}");
            }
        }
    }
}