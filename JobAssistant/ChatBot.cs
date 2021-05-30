using AIMLbot;
using System;

namespace JobAssistant
{
    public class ChatBot
    {
        private const string UserID = "1";
        private Bot AimlBot;
        private User myUser;

        public ChatBot()
        {
            AimlBot = new Bot();
            myUser = new User(UserID, AimlBot);
            Initialize();
        }

        public void Initialize()
        {
            AimlBot.loadSettings();
            AimlBot.isAcceptingUserInput = false;
            AimlBot.loadAIMLFromFiles();
            AimlBot.isAcceptingUserInput = true;
        }

        public String getOutput(String input)
        {
            Request request = new Request(input, myUser, AimlBot);
            Result result = AimlBot.Chat(request);
            return (result.Output);
        }
    }
}