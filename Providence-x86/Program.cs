using DSharpPlus;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System;

namespace Providence
{
    public class Program
    {
        static DiscordClient discord;
        static CommandsNextModule commands;
        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        static async Task MainAsync(string[] args)
        {
            var json = "";
            using (var fs = File.OpenRead("config.json"))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
                json = await sr.ReadToEndAsync();
            var cfgjson = JsonConvert.DeserializeObject<ConfigJson>(json);
            var cfg = new DiscordConfiguration
            {
                Token = cfgjson.Token,
                TokenType = TokenType.Bot,
                AutoReconnect = true,
                LogLevel = LogLevel.Debug,
                UseInternalLogHandler = true
            };
            if(cfgjson.Token != "Replace Me!")
            {
                discord = new DiscordClient(cfg);
                var cfgcmd = new CommandsNextConfiguration
                {
                    StringPrefix = cfgjson.StringPrefix
                };
                commands = discord.UseCommandsNext(cfgcmd);
                discord.MessageCreated += async e =>
                {
                    if (e.Message.Content.ToLower().StartsWith("ping"))
                    {
                        await e.Message.RespondAsync("pong!");
                    }
                };
                commands.RegisterCommands<commands>();
                await discord.ConnectAsync();
            }
            else
            {
                Console.WriteLine("ERROR: User has not replace default token. Replace 'Replace Me!' in config.json");
            }
            await Task.Delay(-1);
        }
    }

    public struct ConfigJson
    {
        [JsonProperty("token")]
        public string Token { get; private set; }

        [JsonProperty("prefix")]
        public string StringPrefix { get; private set; }

    }
}