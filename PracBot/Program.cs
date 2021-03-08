using Discord;
using Discord.WebSocket;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace PracBot
{
    public class Program
    {
        static void Main(string[] args)
        => new Program().MainAsync().GetAwaiter().GetResult();
        private DiscordSocketClient _client;
        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();
            _client.Log += Log;
            var token = "";
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
