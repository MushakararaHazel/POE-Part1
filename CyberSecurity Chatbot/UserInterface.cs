using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CyberSecurity_Chatbot
{
    public class UserInterface
    { // colour contants for consistent UI theming
        private const ConsoleColor TitleColor = ConsoleColor.Cyan;
        private const ConsoleColor BotColor = ConsoleColor.Green;
        private const ConsoleColor UserColor = ConsoleColor.Yellow;
        private const ConsoleColor WarningColor = ConsoleColor.Red;
        private const ConsoleColor InfoColor = ConsoleColor.Blue;

        //will display the ASCII ART HEADER 
        public void DisplayayHeader()
        {
            Console.ForegroundColor = TitleColor;
            Console.WriteLine(@"  ____      _                                        _ _         
 / ___|   _| |__   ___ _ __ ___  ___  ___ _   _ _ __(_) |_ _   _ 
| |  | | | | '_ \ / _ \ '__/ __|/ _ \/ __| | | | '__| | __| | | |
| |__| |_| | |_) |  __/ |  \__ \  __/ (__| |_| | |  | | |_| |_| |
 \____\__, |_.__/ \___|_|  |___/\___|\___|\__,_|_|  |_|\__|\__, |
  ____|___/        _   _           _                       |___/ 
 / ___| |__   __ _| |_| |__   ___ | |_                           
| |   | '_ \ / _` | __| '_ \ / _ \| __|                          
| |___| | | | (_| | |_| |_) | (_) | |_                           
 \____|_| |_|\__,_|\__|_.__/ \___/ \__|                             ");

            Console.ResetColor();
            Console.WriteLine(new string('=', Console.WindowWidth - 1));

        }
        public string GetUserName()
        {//gets the users name

            TypingEffect("Hello! Before we begin, may I have your name?", BotColor);
            Console.ForegroundColor = UserColor;
            Console.Write(">> Your name: ");
            Console.ResetColor();


            string name;
            while (string.IsNullOrWhiteSpace(name = Console.ReadLine()))
            {
                Console.ForegroundColor = WarningColor;
                Console.WriteLine("Please enter a valid name.");
                Console.ResetColor();
                Console.ForegroundColor = UserColor;
                Console.Write(">> Your name: ");
                Console.ResetColor();
            }

            return name.Trim();
        }


       //displays the main menu options
        public void DisplayMenu(string userName)
        {
            Console.WriteLine();
            Console.ForegroundColor = TitleColor;
            Console.WriteLine($"How can I help you today, {userName}?");
            Console.ResetColor();


            Console.ForegroundColor = InfoColor;
            Console.WriteLine("1. What is phishing?");
            Console.WriteLine("2. How can I create a strong password?");
            Console.WriteLine("3. How do I recognize suspicious links?");
            Console.WriteLine("4. What is two-factor authentication?");
            Console.WriteLine("5. How can I protect my personal information online?");
            Console.WriteLine("6. Exit");
            Console.ResetColor();
            Console.ForegroundColor= UserColor;
            Console.Write(">> Choose an option (1-6):");
            Console.ResetColor();
        }

        public void TypingEffect(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
        //display exit message 
        public void DisplayFarewell(string userName)
        {
            Console.WriteLine();
            TypingEffect($"Thank you for using the cybersecurity awareness assistant,{userName} !", BotColor);
            TypingEffect("Remember: Staying safe online is an ongoing process. Stay vigilant!", BotColor);
            Console.WriteLine();
            TypingEffect("Press any key to exit...", BotColor);
            Console.ReadKey();
        }
    }

}
