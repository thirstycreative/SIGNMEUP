using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignBot.Models
{
    public enum CommandType
    {
        None,
        Message
    }

    [Serializable]
    public class Command
    {
        internal const string NAME = "COMMAND";
        public CommandType CommandType;
        public DateTime DateTime;
        public string Date;
        public string Message;
    }
}