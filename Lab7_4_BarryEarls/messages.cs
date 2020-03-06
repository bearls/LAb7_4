using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_4_BarryEarls
{

    class messages
    {
        public DatingProfile sender;
        public string messageTitle;
        public string messageData;
        private bool isRead;

        public Messages(DatingProfile sender, string messageTitle, string messageData)
        {
            this.sender = sender;
            this.messageTitle = messageTitle;
            this.messageData = messageData;
            isRead = false;
        }

    }

}