using Microsoft.AspNetCore.SignalR;

namespace ChatApp.Models
{
    public class ChatHub:Hub
    {
        public async Task sendMessage(string message,string name)
        {
            await Clients.All.SendAsync("messageTosend",message,name);


        }
    }
}
