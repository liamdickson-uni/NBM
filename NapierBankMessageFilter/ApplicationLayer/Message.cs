﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBankMessageFilter.ApplicationLayer
{
    public class Message
    {
        private string _header;
        private string _type;
        private string _body;
        private string _sender;

        public string Header { get => _header; set => _header = value; }
        public string Type { get => _type; set => _type = value; }
        public string Body { get => _body; set => _body = value; }
        public string Sender { get => _sender; set => _sender = value; }
        
        public Message (string header, string type, string body, string sender)
        {
            Header = header;
            Type = type;
            Body = body;
            Sender = sender;
        }
       
        public Message () { }

    }
}
