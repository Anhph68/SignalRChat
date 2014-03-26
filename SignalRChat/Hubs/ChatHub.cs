using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMsg(string name, string msg)
        {
            Clients.All.SendAll(name, msg);
        }
    }
}