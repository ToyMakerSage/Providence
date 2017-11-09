using System;
using DSharpPlus;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;

namespace Providence
{
    class Program
    {
        static DiscordClient discord;
        static CommandsNextModule commands;
        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        static async Task MainAsync(string[] args)
        {
            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = "Place Holder",
                TokenType = TokenType.Bot,
                UseInternalLogHandler = true,
                LogLevel = LogLevel.Debug


            });
            commands = discord.UseCommandsNext(new CommandsNextConfiguration
            {
                StringPrefix = ">"
            });
            discord.MessageCreated += async e =>
            {
                if (e.Message.Content.ToLower().StartsWith("ping"))
                {
                    await e.Message.RespondAsync("pong!");
                }
            };
            commands.RegisterCommands<commands>();
            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}