using Microsoft.Practices.Prism.PubSubEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregation.Infrastructure
{
    public class MessageSentEvent: PubSubEvent<Message>
    {
    }
    public class Message
    {
        public string SentTo { get; set; }
        public MessageType type { get; set; }
        public object MessageBody { get; set; }
    }
    public enum MessageType
    {
        OPEN_MODULE_VIEW,
        SNAP
    }
}
