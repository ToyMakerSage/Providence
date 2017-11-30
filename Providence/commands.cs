using System;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace Providence
{
    public class commands
    {
        Random rng = new Random();
        string[,] Dlist4 = new string[56, 2] { { "Sastasha", "https://i.imgur.com/PTIiFOQ.png" }, { "The Tam-Tara Deepcroft", "https://i.imgur.com/UTRDaDJ.png" }, { "Copperbell Mines", "https://i.imgur.com/DzQhWR8.png" }, { "Halatali", "https://i.imgur.com/RNRPcM7.png" }, { "The Thousand Maws of Toto-Rak", "https://i.imgur.com/c4C2L27.png" }, { "Haukke Manor", "https://i.imgur.com/M5Y5Y81.png" }, { "Brayflox's Longstop", "https://i.imgur.com/kGy1ZDW.png" }, { "The Sunken Temple of Qarn", "https://i.imgur.com/3029NSN.png" }, { "Cutter's Cry", "https://i.imgur.com/IiM11xY.png" }, { "The Stone Vigil", "https://i.imgur.com/oETrmhS.png" }, { "Dzemael Darkhold", "https://i.imgur.com/PeC3DD5.png" }, { "The Aurum Vale", "https://i.imgur.com/3vXu5dB.png" }, { "The Wanderer's Palace", "https://i.imgur.com/0cRsYEp.png" }, { "Amdapor Keep", "https://i.imgur.com/ARBWLrW.png" }, { "Pharos Sirius", "https://i.imgur.com/8G6SKDr.png" }, { "Copperbell Mines (Hard)", "https://i.imgur.com/A0vKVxX.png" }, { "Haukke Manor (Hard)", "https://i.imgur.com/t06bymg.png" }, { "The Lost City of Amdapor", "https://i.imgur.com/zz7V8kB.png" }, { "Halatali (Hard)", "https://i.imgur.com/d5ldzQn.png" }, { "Brayflox's Longstop (Hard)", "https://i.imgur.com/ArSKzbj.png" }, { "Hullbreaker Isle", "https://i.imgur.com/jFVqLbp.png" }, { "The Stone Vigil (Hard)", "https://i.imgur.com/esCHnLj.png" }, { "Tam-Tara Deepcroft (Hard)", "https://i.imgur.com/cm8US1g.png" }, { "Snowcloak", "https://i.imgur.com/lvuwShu.png" }, { "Sastasha (Hard)", "https://i.imgur.com/FMlo95m.png" }, { "The Sunken Temple of Qarn (Hard)", "https://i.imgur.com/aUPMAB2.png" }, { "The Keeper of the Lake", "https://i.imgur.com/4iJ7S5F.png" }, { "The Wanderer's Palace (Hard)", "https://i.imgur.com/qJ8j2eR.png" }, { "Amdapor Keep (Hard)", "https://i.imgur.com/JycTz6a.png" }, { "The Dusk Vigil", "https://i.imgur.com/pUqD9yN.png" }, { "Sohm Al", "https://i.imgur.com/rYnF3DN.png" }, { "The Aery", "https://i.imgur.com/B3aCWIR.png" }, { "The Vault", "https://i.imgur.com/LQg4HOm.png" }, { "The Great Gubal Library", "https://i.imgur.com/jlnm2rL.png" }, { "The Aetherochemical Research Facility", "https://i.imgur.com/R1CLg19.png" }, { "Neverreap", "https://i.imgur.com/u3te2XY.png" }, { "The Fractal Continuum", "https://i.imgur.com/unkFg26.png" }, { "Saint Mocianne's Arboretum", "https://i.imgur.com/Z7wjxzn.png" }, { "Pharos Sirius (Hard)", "https://i.imgur.com/pgYv5Ai.png" }, { "The Antitower", "https://i.imgur.com/GEjXEOP.png" }, { "The Lost City of Amdapor (Hard)", "https://i.imgur.com/RdY4noy.png" }, { "Sohr Khai", "https://i.imgur.com/L8Jd7Wm.png" }, { "Hullbreaker Isle (Hard)", "https://i.imgur.com/m3vw7NG.png" }, { "Xelphatol", "https://i.imgur.com/kvWwlDk.png" }, { "The Great Gubal Library (Hard)", "https://i.imgur.com/EusbjU8.png" }, { "Baelsar's Wall", "https://i.imgur.com/dUaG3gc.png" }, { "Sohm Al (Hard)", "https://i.imgur.com/AIFHdkc.png" }, { "The Sirensong Sea", "https://i.imgur.com/dc5m1UF.png" }, { "Shisui of the Violet Tides", "https://i.imgur.com/ib6zmvW.png" }, { "Bardam's Mettle", "https://i.imgur.com/L9CyfC0.png" }, { "Doma Castle", "https://i.imgur.com/7bm6aKj.png" }, { "Castrum Abania", "https://i.imgur.com/qpl40uY.png" }, { "Ala Mhigo", "https://i.imgur.com/Sxw3irH.png" }, { "Kugane Castle", "https://i.imgur.com/g22wgum.png" }, { "The Temple of the Fist", "https://i.imgur.com/gaAwE84.png" }, { "The Drowned City of Skalla", "https://i.imgur.com/9mwEPRn.png" } };
        string[] Dlist24 = new string[] { "Labyrinth of the Ancients", "Sycrus Tower", "The Void Ark", "The Weeping City of Mhach", "Dun Scaith", "The Royal City of Rabanastre" };
        string[,] Dlist8 = new string[38, 2] { { "Castrum Meridianum", "https://i.imgur.com/5qtRwUv.png" }, { "The Praetorium", "https://i.imgur.com/irbV8RY.png" }, { "Cape Westwind", "https://i.imgur.com/X45Hw05.png" }, { "The Chrysalis", "https://i.imgur.com/XXuA4u7.png" }, { "The Steps of Faith", "https://i.imgur.com/EkOvzAz.png" }, { "A Relic Reborn: The Chimera", "https://i.imgur.com/NjijBF0.png" }, { "A Relic Reborn: The Hydra", "https://i.imgur.com/bf7r76f.png" }, { "Battle on the Big Bridge", "https://i.imgur.com/QfNqgb9.png" }, { "The Dragon's Neck", "https://i.imgur.com/QpQX8O7.png" }, { "Battle in the Big Keep", "https://i.imgur.com/Cj5Ly6j.png" }, { "The Bowl of Embers (Hard)", "https://i.imgur.com/cxovrtl.png" }, { "The Howling Eye (Hard)", "https://i.imgur.com/7Rgy1KA.png" }, { "The Navel (Hard)", "https://i.imgur.com/NbxOMj1.png" }, { "Thornmarch (Hard)", "https://i.imgur.com/3gfpPEm.png" }, { "The Whorleater (Hard)", "https://i.imgur.com/pyB5q60.png" }, { "The Striking Tree (Hard)", "https://i.imgur.com/wFBzy0t.png" }, { "Akh Afah Amphitheatre (Hard)", "https://i.imgur.com/LWw7UnI.png" }, { "Urth's Fount", "https://i.imgur.com/yZiehIn.png" }, { "Thok ast Thok (Hard)", "https://i.imgur.com/7Tjg5rI.png" }, { "The Limitless Blue (Hard)", "https://i.imgur.com/qCAOeWd.png" }, { "The Singularity Reactor", "https://i.imgur.com/Nc7JKJc.png" }, { "The Final Steps of Faith", "https://i.imgur.com/DNa2f3Q.png" }, { "Containment Bay S1T7", "https://i.imgur.com/2BFfx4s.png" }, { "Containment Bay P1T6", "https://i.imgur.com/6WWyCi2.png" }, { "Containment Bay Z1T9", "https://i.imgur.com/EK85R1y.png" }, { "The Pool of Tribute", "https://i.imgur.com/8Qx5aPv.png" }, { "Emanation", "https://i.imgur.com/E424ahe.png" }, { "The Royal Menagerie", "https://i.imgur.com/njlVOqp.png" }, { "StoryRaid", "https://i.imgur.com/GmC1Lfw.png" }, { "StoryRaid", "https://i.imgur.com/GmC1Lfw.png" }, { "StoryRaid", "https://i.imgur.com/GmC1Lfw.png" }, { "StoryRaid", "https://i.imgur.com/GmC1Lfw.png" }, { "StoryRaid", "https://i.imgur.com/GmC1Lfw.png" }, { "StoryRaid", "https://i.imgur.com/GmC1Lfw.png" }, { "EX", "https://i.imgur.com/x7KAuiP.png" }, { "EX", "https://i.imgur.com/x7KAuiP.png" }, { "EX", "https://i.imgur.com/x7KAuiP.png" }, { "Savage", "https://i.imgur.com/464FzEI.png" } };
        string[,] DlistEX = new string[18, 2] { { "The Minstrel's Ballad: Ultima's Bane", "https://i.imgur.com/VR2rF0t.png" }, { "The Howling Eye (Extreme)", "https://i.imgur.com/0SCZ4HD.png" }, { "The Navel (Extreme)", "https://i.imgur.com/SXaU2qM.png" }, { "The Bowl of Embers (Extreme)", "https://i.imgur.com/x7KAuiP.png" }, { "Thornmarch (Extreme)", "https://i.imgur.com/Tyjd12h.png" }, { "The Whorleater (Extreme)", "https://i.imgur.com/JuE5FXS.png" }, { "The Striking Tree (Extreme)", "https://i.imgur.com/3LARl7r.png" }, { "Akh Afah Amphitheatre (Extreme)", "https://i.imgur.com/8kaVtvz.png" }, { "The Limitless Blue (Extreme)", "https://i.imgur.com/IZyPAAp.png" }, { "Thok ast Thok (Extreme)", "https://i.imgur.com/GowzbZr.png" }, { "The Minstrel's Ballad: Thordan's Reign", "https://i.imgur.com/77fAuCN.png" }, { "The Minstrel's Ballad: Nidhogg's Rage", "https://i.imgur.com/0YJoV2q.png" }, { "Containment Bay S1T7 (Extreme)", "https://i.imgur.com/8o70cTz.png" }, { "Containment Bay P1T6 (Extreme)", "https://i.imgur.com/JRYnzAM.png" }, { "Containment Bay Z1T9 (Extreme)", "https://i.imgur.com/CzCBxzq.png" }, { "Emanation (Extreme)", "https://i.imgur.com/SQvRPSC.png" }, { "The Pool of Tribute (Extreme)", "https://i.imgur.com/Mnwthjt.png" }, { "The Minstrel's Ballad: Shinryu's Domain", "https://i.imgur.com/aWuLUxr.png" } };
        string[,] DlistSavage = new string[26, 2] { { "The Binding Coil of Bahamut Turn 1", "https://i.imgur.com/ACmXBBb.png" }, { "The Binding Coil of Bahamut Turn 2", "https://i.imgur.com/YhqvdB4.png" }, { "The Binding Coil of Bahamut Turn 3", "https://i.imgur.com/eHIz3EL.png" }, { "The Binding Coil of Bahamut Turn 4", "https://i.imgur.com/RXoPlTx.png" }, { "The Binding Coil of Bahamut Turn 5", "https://i.imgur.com/vxxQ3io.png" }, { "The Second Binding Coil of Bahamut Turn 1", "https://i.imgur.com/rgy2Fvj.png" }, { "The Second Binding Coil of Bahamut Turn 2", "https://i.imgur.com/wScgIRR.png" }, { "The Second Binding Coil of Bahamut Turn 3", "https://i.imgur.com/x1EIaco.png" }, { "The Second Binding Coil of Bahamut Turn 4", "https://i.imgur.com/464FzEI.png" }, { "The Final Binding Coil of Bahamut Turn 1", "https://i.imgur.com/mqiEIEl.png" }, { "The Final Binding Coil of Bahamut Turn 2", "https://i.imgur.com/LwbKkPY.png" }, { "The Final Binding Coil of Bahamut Turn 3", "https://i.imgur.com/cDLI6Aj.png" }, { "The Final Binding Coil of Bahamut Turn 4", "https://i.imgur.com/dDDfpiT.png" }, { "Alexander Gordias - The Fist of the Father (Savage)", "https://i.imgur.com/GmC1Lfw.png" }, { "Alexander Gordias - The Cuff of the Father (Savage)", "https://i.imgur.com/4LLIHc9.png" }, { "Alexander Gordias - The Arm of the Father (Savage)", "https://i.imgur.com/oUU39rh.png" }, { "Alexander Gordias - The Burden of the Father (Savage)", "https://i.imgur.com/7hQa7NW.png" }, { "Alexander Midas - The Fist of the Son (Savage)", "https://i.imgur.com/5dweyJS.png" }, { "Alexander Midas - The Cuff of the Son (Savage)", "https://i.imgur.com/ejbWr1s.png" }, { "Alexander Midas - The Arm of the Son (Savage)", "https://i.imgur.com/DH8nRSF.png" }, { "Alexander Midas - The Burden of the Son (Savage)", "https://i.imgur.com/ck1uvA8.png" }, { "Alexander Creator - The Eyes of the Creator (Savage)", "https://i.imgur.com/en0YGyQ.png" }, { "Alexander Creator - The Breath of the Creator (Savage)", "https://i.imgur.com/Gs1s9Dy.png" }, { "Alexander Creator - The Heart of the Creator (Savage)", "https://i.imgur.com/RpvdZej.png" }, { "Alexander Creator - The Soul of the Creator (Savage)", "https://i.imgur.com/x2Y4iym.png" }, { "The Second Binding Coil of Bahamut (Savage)", "https://i.imgur.com/rgy2Fvj.png" } };
        string[,] DlistStoryRaid = new string[16, 2] { { "Alexander Gordias - The Fist of the Father", "https://i.imgur.com/GmC1Lfw.png" }, { "Alexander Gordias - The Cuff of the Father", "https://i.imgur.com/4LLIHc9.png" }, { "Alexander Gordias - The Arm of the Father", "https://i.imgur.com/oUU39rh.png" }, { "Alexander Gordias - The Burden of the Father", "https://i.imgur.com/7hQa7NW.png" }, { "Alexander Midas - The Fist of the Son", "https://i.imgur.com/5dweyJS.png" }, { "Alexander Midas - The Cuff of the Son", "https://i.imgur.com/ejbWr1s.png" }, { "Alexander Midas - The Arm of the Son", "https://i.imgur.com/DH8nRSF.png" }, { "Alexander Midas - The Burden of the Son", "https://i.imgur.com/ck1uvA8.png" }, { "Alexander Creator - The Eyes of the Creator", "https://i.imgur.com/en0YGyQ.png" }, { "Alexander Creator - The Breath of the Creator", "https://i.imgur.com/Gs1s9Dy.png" }, { "Alexander Creator - The Heart of the Creator", "https://i.imgur.com/RpvdZej.png" }, { "Alexander Creator - The Soul of the Creator", "https://i.imgur.com/x2Y4iym.png" }, { "Omega Deltascape - V1.0", "https://i.imgur.com/GxaAC4l.png" }, { "Omega Deltascape - V2.0", "https://i.imgur.com/zpYUgwH.png" }, { "Omega Deltascape - V3.0", "https://i.imgur.com/AHAU9VB.png" }, { "Omega Deltascape - V4.0", "https://i.imgur.com/IvTxIYn.png" } };
        string[] SpecialRules = new string[] { "Minimum Item Level" , "M A N M O D E", "All DPS Must be Casters", "All DPS Must be Ranged Physical", "All DPS Must be Melee", "All DPS slots must be filled with Healers", "All DPS slots must be filled with Tanks", "Speed Run" };
        string[,] DlistC = new string[4, 2] { { "Ala Mhigo", "https://i.imgur.com/Sxw3irH.png" }, { "Kugane Castle", "https://i.imgur.com/g22wgum.png" }, { "The Temple of the Fist", "https://i.imgur.com/gaAwE84.png" }, { "The Drowned City of Skalla", "https://i.imgur.com/9mwEPRn.png" } };
        string[] SpecialRulesC = new string[] { "Minimum Item Level", "All DPS Must be Ranged Physical", "All DPS Must be Melee", "All DPS Must be Casters", "Speed Run", "No soulstones", "Healers: Regens only", "Healers: Shields only", "Role actions are forbidden", "Diversion and Provoke are forbidden", "Don't stop pulling", "Healers: Cures only", "AoE Threat Generators are Forbidden", "M A N M O D E","Curse" };

        [Command("creation"), Description("A Pseudo Duty Roulette")]
        public async Task Roulette(CommandContext ctx)
        {
            int randomIndex = rng.Next(DlistC.GetLength(0));
            int randomIndexSR = rng.Next(SpecialRulesC.Length);
            string text = DlistC[randomIndex, 0];
            string text2 = DlistC[randomIndex, 1];
            string text3 = SpecialRulesC[randomIndexSR];
            if (text3 == "Curse")
            {
                text3 = "Minimum Item Level and " + SpecialRulesC[rng.Next(2, SpecialRulesC.Length - 1)];
            }
            var embed = new DiscordEmbedBuilder();
            embed.WithTitle("Providence Roulette: Creation Grind").WithDescription("*Your next dungeon has been prepared.*").WithImageUrl(text2).WithColor(new DiscordColor(172, 225, 175));
            embed.AddField("**Duty**", "*" + text + "*", true);
            embed.AddField("**Type**", "*Expert Dungeon*", true);
            embed.AddField("**Special Rules**", "*" + text3 + "*", false);
            await ctx.RespondAsync("", embed: embed);
        }
        [Command("roulette"), Description("A Pseudo Duty Roulette")]
        public async Task Roulette(CommandContext ctx, int size)
        {
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
                string text = Dlist4[randomIndex, 0];
                string text2 = Dlist4[randomIndex, 1];
                string text3 = SpecialRules[randomIndexSR];
                var embed = new DiscordEmbedBuilder();
                embed.WithTitle("Providence Roulette").WithDescription("*I have prepared your challenge.*").WithImageUrl(text2).WithColor(new DiscordColor(0, 216, 255));
                embed.AddField("**Duty**", "*" + text + "*", true);
                embed.AddField("**Type**", "*4-man Dungeon*", true);
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
                int randomIndex = rng.Next(Dlist8.GetLength(0));
                int randomIndexSR = rng.Next(SpecialRules.Length -1);
                int bonusSRcheck = rng.Next(1, 100);
                string text = Dlist8[randomIndex, 0];
                string text2 = Dlist8[randomIndex, 1];
                string text3 = SpecialRules[randomIndexSR];
                string text4 = "*Watch your step, adventurers.*";
                string text5 = "";
                if (text != "StoryRaid" && text != "EX" && text != "Savage")
                {
                    if (bonusSRcheck < 51)
                    {
                        text4 = "*Let's keep this interesting, shall we?*";
                        text3 = "Minimum Item Level";
                        if (bonusSRcheck < 21)
                        {
                            text4 = "*Amuse me.*";
                            text5 = SpecialRules[rng.Next(2, 5)];
                            if (bonusSRcheck < 11)
                            {
                                text4 = "*Feed me.*";
                                text5 = SpecialRules[rng.Next(2, SpecialRules.Length -1)];
                            }
                        }
                    }
                    var embed = new DiscordEmbedBuilder();
                    embed.WithTitle("Providence Roulette").WithDescription(text4).WithImageUrl(text2).WithColor(new DiscordColor(255, 239, 0));
                    embed.AddField("**Duty**", "*" + text + "*", true);
                    embed.AddField("**Type**", "*8-Man Content*", true);
                    if (bonusSRcheck > 20)
                    {
                        embed.AddField("**Special Rules**", "*" + text3 + "*", false);
                    }
                    else
                    {
                        embed.AddField("**Special Rules**", "*" + text3 + " and " + text5 + "*", false);
                    }
                    await ctx.RespondAsync("", embed: embed);

                }
                else if (text == "Savage")
                {
                    randomIndex = rng.Next(DlistSavage.GetLength(0));
                    text = DlistSavage[randomIndex, 0];
                    text2 = DlistSavage[randomIndex, 1];
                    if (text != "The Second Binding Coil of Bahamut (Savage)")
                    {
                        text4 = "*Suffer.*";
                        if (bonusSRcheck < 11)
                        {
                            text4 = "*Despair.*";
                            text3 = "Minimum Item Level";
                        }
                        var embed = new DiscordEmbedBuilder();
                        embed.WithTitle("Providence Roulette").WithDescription(text4).WithImageUrl(text2).WithColor(new DiscordColor(240, 84, 74));
                        embed.AddField("**Duty**", "*" + text + "*", true);
                        embed.AddField("**Type**", "*8-Man Savage*", true);
                        if (bonusSRcheck < 11)
                        {
                            embed.AddField("**Special Rules**", "*" + text3 + "*", false);
                        }
                        await ctx.RespondAsync("", embed: embed);
                    }
                    else
                    {
                        if (bonusSRcheck > 2)
                        {
                            var embed = new DiscordEmbedBuilder();
                            embed.WithTitle("Providence Roulette").WithDescription("*Die.*").WithImageUrl(text2).WithColor(new DiscordColor(255, 0, 0));
                            embed.AddField("**Duty**", "*" + text + "*", true);
                            embed.AddField("**Type**", "*8-Man Graveyard*", true);
                            await ctx.RespondAsync("", embed: embed);
                        }
                        else
                        {
                            var embed = new DiscordEmbedBuilder();
                            embed.WithTitle("Providence Roulette").WithDescription("*AHAHAHAHAHA.*").WithImageUrl(text2).WithColor(new DiscordColor(255, 0, 0));
                            embed.AddField("**AHAHAHAHAHA**", "*" + text + "*", true);
                            embed.AddField("**AHAHAHAHAHA**", "*AHAHAHAHAHA*", true);
                            embed.AddField("**AHAHAHAHAHA**", "*" + "Minimum Item Level" + "*", false);
                            await ctx.RespondAsync("", embed: embed);
                        }
                    }
                }
                else if (text == "StoryRaid")
                {
                    randomIndex = rng.Next(DlistStoryRaid.GetLength(0));
                    text = DlistStoryRaid[randomIndex, 0];
                    text2 = DlistStoryRaid[randomIndex, 1];
                    if (bonusSRcheck < 76)
                    {
                        text4 = "*Let's keep this interesting, shall we?*";
                        text3 = "Minimum Item Level";
                        if (bonusSRcheck < 25)
                        {
                            text4 = "*Amuse me.*";
                            text5 = SpecialRules[rng.Next(2, 5)];
                        }
                    }
                    var embed = new DiscordEmbedBuilder();
                    embed.WithTitle("Providence Roulette").WithDescription(text4).WithImageUrl(text2).WithColor(new DiscordColor(254, 223, 0));
                    embed.AddField("**Duty**", "*" + text + "*", true);
                    embed.AddField("**Type**", "*8-Man Raid*", true);
                    if (bonusSRcheck > 24)
                    {
                        embed.AddField("**Special Rules**", "*" + text3 + "*", false);
                    }
                    else
                    {
                        embed.AddField("**Special Rules**", "*" + text3 + " and " + text5 + "*", false);
                    }
                    await ctx.RespondAsync("", embed: embed);
                }
                else if (text == "EX")
                {
                    randomIndex = rng.Next(DlistEX.GetLength(0));
                    text = DlistEX[randomIndex, 0];
                    text2 = DlistEX[randomIndex, 1];
                    if (bonusSRcheck < 76)
                    {
                        text4 = "*Amuse me.*";
                        text3 = "Minimum Item Level";
                        if (bonusSRcheck < 25)
                        {
                            text4 = "*Feed me.*";
                            text5 = SpecialRules[rng.Next(2, 5)];
                        }
                    }
                    var embed = new DiscordEmbedBuilder();
                    embed.WithTitle("Providence Roulette").WithDescription(text4).WithImageUrl(text2).WithColor(new DiscordColor(255, 165, 0));
                    embed.AddField("**Duty**", "*" + text + "*", true);
                    embed.AddField("**Type**", "*8-Man Extreme*", true);
                    if (bonusSRcheck > 24)
                    {
                        embed.AddField("**Special Rules**", "*" + text3 + "*", false);
                    }
                    else
                    {
                        embed.AddField("**Special Rules**", "*" + text3 + " and " + text5 + "*", false);
                    }
                    await ctx.RespondAsync("", embed: embed);
                }
            }
        }
    }
}