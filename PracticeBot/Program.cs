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
        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();
            _client.Log += Log;
            var token = "NzQ2MTkwMzc5NTE0MzMxMTU2.Xz8t8g.UOsfki68hDae9MHTJ_ARHj_IAyA";
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
            await Task.Delay(-1);

            
        }
        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}
