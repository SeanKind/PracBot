using Discord;
using Discord.WebSocket;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace PracticeBot
{
    public class Program
    {
        public static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;
        private CommandHandler _commandHandler;
        private CommandService _commands;
        public async Task MainAsync()
        {

            _client = new DiscordSocketClient();
            _commands = new CommandService();
            _commandHandler = new CommandHandler(_client, _commands);
            _client.Log += Log;
            var token = "";
            await _commandHandler.InstallCommandsAsync();
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
            await Task.Delay(-1);


        }
        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

        private async Task HandleReactionAddedAsync(Cacheable<IUserMessage, ulong> cachedMessage, ISocketMessageChannel originChannel, SocketReaction reaction)
        {
            if (reaction.Emote.Name.Equals("💯"))
            {
                await reaction.User.Value.SendMessageAsync("", false, new EmbedBuilder().WithTitle("Success").WithDescription("yay").Build());
                var channel = (SocketGuildChannel)originChannel;
                return;

            }
        }
    }
}
