using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace telegramAchivements
{
    class Program
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("337821452:AAGCMlPr5RoTzxRW9p7xFYhMcBBGm38UMbc");

        static void Main(string[] args)
        {
            Bot.OnMessage += BotOnMessageReceived;
            Bot.OnMessageEdited += BotOnMessageReceived;

            Bot.StartReceiving();
            Console.ReadKey();
            Bot.StopReceiving();
        }

        private static void BotOnMessageReceived(object sender, MessageEventArgs messageEventArgs)
        {
            var message = messageEventArgs.Message;
            var chatName = messageEventArgs.Message.Chat.Title;
            var chatId = messageEventArgs.Message.Chat.Id;

            Console.WriteLine($"{message.From.FirstName} {message.From.LastName} from chat {chatId}:{chatName} said: {message.Text}");
        }
    }
}
