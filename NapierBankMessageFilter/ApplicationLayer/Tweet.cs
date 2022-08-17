﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;

namespace NapierBankMessageFilter.ApplicationLayer
{
    public class Tweet : Message
    {

        public Tweet(string header,string type, string body, string sender): base(header, type, body, sender) { }

        public Tweet() { }

        public void ValidateTweeter(string msg)
        {
            int pFrom = msg.IndexOf("Sender: ") + "Sender: ".Length;
            int pTo = msg.LastIndexOf("\nMessage Text: ");
            string tweeter = msg.Substring(pFrom, pTo - pFrom);

            Regex reg = new Regex(@"^(@){1}[1-9a-zA-Z]{15}");


            if (!string.IsNullOrEmpty(tweeter))
            {
                if (reg.IsMatch(tweeter))
                {
                    if (tweeter.Length > 20)
                    {
                        MessageBox.Show("There are too many characters in the sender of the tweet, please change the subject to fit the character limit of 15 (not including @)");
                    }
                }
            }
            else
            {
                throw new ArgumentNullException("A Null value was passed to the function, please change the parameter");
            }
        }

    }
}
