using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CyberSecurity_Chatbot
{
    public class Responses
    {
        private readonly UserInterface _ui;
        public Responses(UserInterface ui)
        {
            _ui = ui;
        }
        //phishing information response
        public void ShowPhishingInfo()
        {
            _ui.TypingEffect("Phishing is a cyber attack that uses disguised email as a weapon.", ConsoleColor.Green);
            Thread.Sleep(500);
            _ui.TypingEffect("The goal is to trick the recipient into believing the message is legitimate.", ConsoleColor.Green);

            Console.WriteLine();
            _ui.TypingEffect("Protection Tips:", ConsoleColor.Green);
            Console.WriteLine();
            _ui.TypingEffect("- Check sender's email address carefully", ConsoleColor.Green);
            _ui.TypingEffect("- Look for spelling/grammar mistakes", ConsoleColor.Green);
            _ui.TypingEffect("- Hover over links before clicking", ConsoleColor.Green);
        }
        //information on password tips
        public void ShowPasswordTips()
        {
            _ui.TypingEffect("Strong password guidelines:", ConsoleColor.Green);
            Console.WriteLine();
            _ui.TypingEffect("- Use at least 12 characters", ConsoleColor.Green);
            _ui.TypingEffect("- Mix uppercase, lowercase, numbers, symbols", ConsoleColor.Green);
            _ui.TypingEffect("- Avoid common words or personal info", ConsoleColor.Green);
            _ui.TypingEffect("- Don't reuse passwords across sites", ConsoleColor.Green);
        }
        //information on suspicious links 
        public void ShowSuspiciousLinksInfo()
        {
            _ui.TypingEffect("How to recognize suspicious links:", ConsoleColor.Green);
            Thread.Sleep(300);
            _ui.TypingEffect("1. Check the URL carefully for misspellings (like 'g00gle.com')", ConsoleColor.Green);
            Thread.Sleep(300);
            _ui.TypingEffect("2. Hover over links to see the actual destination before clicking", ConsoleColor.Green);
            Thread.Sleep(300);
            _ui.TypingEffect("3. Look for HTTPS and padlock icon in the address bar", ConsoleColor.Green);
            Thread.Sleep(300);
            _ui.TypingEffect("4. Be cautious with shortened URLs (bit.ly, goo.gl, etc.)", ConsoleColor.Green);
            Thread.Sleep(300);
            _ui.TypingEffect("5. Don't click links in unexpected emails or messages", ConsoleColor.Green);

        } 
      //info on two factor auth
        public void ShowTwoFactorAuthInfo()
        {
            _ui.TypingEffect("Two-Factor Authentication (2FA) adds an extra security layer:", ConsoleColor.Green);
            Thread.Sleep(300);
            _ui.TypingEffect("1. After entering your password, you provide a second verification", ConsoleColor.Green);
            Thread.Sleep(300);
            _ui.TypingEffect("2. This can be a code from an app (Google Authenticator, Authy)", ConsoleColor.Green);
            Thread.Sleep(300);
            _ui.TypingEffect("3. Or a code sent via SMS to your phone", ConsoleColor.Green);
            Thread.Sleep(300);
            _ui.TypingEffect("4. Some services use biometrics (fingerprint, face ID)", ConsoleColor.Green);
            Thread.Sleep(300);
            _ui.TypingEffect("5. Always enable 2FA for important accounts (email, banking)", ConsoleColor.Green);
        }
        public void ShowPersonalInfoProtection()
        {
            _ui.TypingEffect("Protecting your personal information online:", ConsoleColor.Green);
            Thread.Sleep(300);
            _ui.TypingEffect("1. Be careful what you share on social media", ConsoleColor.Green);
            Thread.Sleep(300);
            _ui.TypingEffect("2. Review privacy settings on all your accounts", ConsoleColor.Green);
            Thread.Sleep(300);
            _ui.TypingEffect("3. Use unique passwords for different services", ConsoleColor.Green);
            Thread.Sleep(300);
            _ui.TypingEffect("4. Be wary of requests for personal information", ConsoleColor.Green);
            Thread.Sleep(300);
            _ui.TypingEffect("5. Use a VPN on public Wi-Fi networks", ConsoleColor.Green);
        }

    }
}