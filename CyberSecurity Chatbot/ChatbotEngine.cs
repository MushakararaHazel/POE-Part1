using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CyberSecurity_Chatbot
{
   public  class ChatbotEngine(Audio audio, UserInterface userInterface, Responses response)
    {
        private readonly Audio _audio = audio;
        private readonly UserInterface _ui = userInterface;
        private readonly Responses _response = response;

        public void Run ()
        {
            Console.Title = "Cybersecurity Awareness Assistant";
            Console.Clear();

            // Play welcome sound
            _audio.PlayWelcomeSound();
            _ui.TypingEffect("Initializing Cybersecurity Awareness Assistant...", ConsoleColor.Blue);
            Thread.Sleep(2000);


            // Show header
            _ui.DisplayayHeader();

            // Get user name
            string userName = _ui.GetUserName();
            // Main interaction loop
            bool continueChat = true;
            while (continueChat)
            {
                _ui.DisplayMenu(userName);
                continueChat = ProcessUserChoice(userName);
            }

            // Farewell
            _ui.DisplayFarewell(userName);

        }
        //the user menu for selection 
        private bool ProcessUserChoice(string userName)
        {

            string input = Console.ReadLine();
        Console.WriteLine();
            // selection to choose right response according to the input 
            switch (input)
            {
                case "1":
                    _response.ShowPhishingInfo();
                    return true;
                case "2":
                    _response.ShowPasswordTips();
                    return true;

                    case "3":
                        _response.ShowSuspiciousLinksInfo();
                    return true;

                    case "4":
                        _response.ShowTwoFactorAuthInfo();
                    return true;

                    case "5":
                        _response.ShowPersonalInfoProtection(); 
                    return true;
               
                case "6":
                    return false;
                default:
                    _ui.TypingEffect("Please choose a valid option (1-6)", ConsoleColor.Red);
                    return true;
            }
}
}
}