
using System;

namespace CyberSecurity_Chatbot
{
  class Program
    {
        static void Main(string[] args)
        {
            // Initialize components
            var audio = new Audio();
            var userInterface = new UserInterface();
            var responses = new Responses(userInterface);
            var chatbot = new ChatbotEngine(audio, userInterface, responses);

            // Start the chatbot
            chatbot.Run();
        }
    }
}
