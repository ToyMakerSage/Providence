using System;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace Providence
{
    public class commands
    {
        Random rng = new Random();
        string[] Dlist4 = new string[] { "Sastasha", "The Tam-Tara Deepcroft", "Copperbell Mines", "Halatali", "The Thousand Maws of Toto-Rak", "Haukke Manor", "Brayflox's Longstop", "The Sunken Temple of Qarn", "Cutter's Cry", "The Stone Vigil", "Dzemael Darkhold", "The Aurum Vale", "The Wanderer's Palace", "Amdapor Keep", "Pharos Sirius", "Copperbell Mines (Hard)", "Haukke Manor (Hard)", "The Lost City of Amdapor", "Halatali (Hard)", "Brayflox's Longstop (Hard)", "Hullbreaker Isle", "The Stone Vigil (Hard)", "Tam-Tara Deepcroft (Hard)", "Snowcloak", "Sastasha (Hard)", "The Sunken Temple of Qarn (Hard)", "The Keeper of the Lake", "The Wanderer's Palace (Hard)", "Amdapor Keep (Hard)", "The Dusk Vigil", "Sohm Al", "The Aery", "The Vault", "The Great Gubal Library", "The Aetherochemical Research Facility", "Neverreap", "The Fractal Continuum", "Saint Mocianne's Arboretum", "Pharos Sirius (Hard)", "The Antitower", "The Lost City of Amdapor (Hard)", "Sohr Khai", "Hullbreaker Isle (Hard)", "Xelphatol", "The Great Gubal Library (Hard)", "Baelsar's Wall", "Sohm Al (Hard)", "The Sirensong Sea", "Shisui of the Violet Tides", "Bardam's Mettle", "Doma Castle", "Castrum Abania", "Ala Mhigo", "Kugane Castle", "The Temple of the Fist", "The Drowned City of Skalla" };
        string[] Dlist24 = new string[] { "Labyrinth of the Ancients", "Sycrus Tower", "The Void Ark", "The Weeping City of Mhach", "Dun Scaith", "The Royal City of Rabanastre" };
        string[] Dlist8 = new string[] { "Castrum Meridianum", "The Praetorium", "Cape Westwind", "The Chrysalis", "The Steps of Faith", "A Relic Reborn: The Chimera", "A Relic Reborn: The Hydra", "Battle on the Big Bridge", "The Dragon's Neck", "Battle in the Big Keep", "The Bowl of Embers (Hard)", "The Howling Eye (Hard)", "The Navel (Hard)", "Thornmarch (Hard)", "The Whorleater (Hard)", "The Striking Tree (Hard)", "Akh Afah Amphitheatre (Hard)", "Urth's Fount", "Thok ast Thok (Hard)", "The Limitless Blue (Hard)", "The Singularity Reactor", "Containment Bay S1T7", "Containment Bay P1T6", "Containment Bay Z1T9", "The Pool of Tribute", "Emanation", "The Royal Menagerie", "StoryRaid", "StoryRaid", "StoryRaid", "StoryRaid", "StoryRaid", "StoryRaid", "EX", "EX", "EX", "Savage" };
        string[] DlistEX = new string[] { "The Minstrel's Ballad: Ultima's Bane", "The Howling Eye (Extreme)", "The Navel (Extreme)", "The Bowl of Embers (Extreme)", "Thornmarch (Extreme)", "The Whorleater (Extreme)", "The Striking Tree (Extreme)", "Akh Afah Amphitheatre (Extreme)", "The Limitless Blue (Extreme)", "Thok ast Thok (Extreme)", "The Minstrel's Ballad: Thordan's Reign", "The Minstrel's Ballad: Nidhogg's Rage", "Containment Bay S1T7 (Extreme)", "Containment Bay P1T6 (Extreme)", "Containment Bay Z1T9 (Extreme)", "Emanation (Extreme)", "The Pool of Tribute (Extreme)", "The Minstrel's Ballad: Shinryu's Domain" };
        string[] DlistSavage = new string[] { "The Binding Coil of Bahamut Turn 1", "The Binding Coil of Bahamut Turn 2", "The Binding Coil of Bahamut Turn 3", "The Binding Coil of Bahamut Turn 4", "The Binding Coil of Bahamut Turn 5", "The Second Binding Coil of Bahamut Turn 1", "The Second Binding Coil of Bahamut Turn 2", "The Second Binding Coil of Bahamut Turn 3", "The Second Binding Coil of Bahamut Turn 4", "The Final Binding Coil of Bahamut Turn 1", "The Final Binding Coil of Bahamut Turn 2", "The Final Binding Coil of Bahamut Turn 3", "The Final Binding Coil of Bahamut Turn 4", "Alexander Gordias - The Fist of the Father (Savage)", "Alexander Gordias - The Cuff of the Father (Savage)", "Alexander Gordias - The Arm of the Father (Savage)", "Alexander Gordias - The Burden of the Father (Savage)", "Alexander Midas - The Fist of the Son (Savage)", "Alexander Midas - The Cuff of the Son (Savage)", "Alexander Midas - The Arm of the Son (Savage)", "Alexander Midas - The Burden of the Son (Savage)", "Alexander Creator - The Eyes of the Creator (Savage)", "Alexander Creator - The Breath of the Creator (Savage)", "Alexander Creator - The Heart of the Creator (Savage)", "Alexander Creator - The Soul of the Creator (Savage)", "The Second Binding Coil of Bahamut (Savage)" };
        string[] DlistStoryRaid = new string[] { "Alexander Gordias - The Fist of the Father", "Alexander Gordias - The Cuff of the Father", "Alexander Gordias - The Arm of the Father", "Alexander Gordias - The Burden of the Father", "Alexander Midas - The Fist of the Son", "Alexander Midas - The Cuff of the Son", "Alexander Midas - The Arm of the Son", "Alexander Midas - The Burden of the Son", "Alexander Creator - The Eyes of the Creator", "Alexander Creator - The Breath of the Creator", "Alexander Creator - The Heart of the Creator", "Alexander Creator - The Soul of the Creator", "Omega Deltascape - V1.0", "Omega Deltascape - V2.0", "Omega Deltascape - V3.0", "Omega Deltascape - V4.0" };
        [Command("roulette")]
        public async Task Roulette(CommandContext ctx, int size)
        {
            Console.WriteLine("Command Executed");
            if (!(size == 4||size == 8||size == 24))
            {
                await ctx.RespondAsync($"🎲 [RouletteDutyOutput]:\nThe choices are 4, 8 or 24.\n That's it.\nNothing else you obtuse fuck.\nFuck you.");
            }
            else if (size == 4)
            {
                int randomIndex = rng.Next(Dlist4.Length);
                string text = Dlist4[randomIndex];
                await ctx.RespondAsync($"🎲 [RouletteDutyOutput]: {text}");
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
                if (text =="StoryRaid")
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