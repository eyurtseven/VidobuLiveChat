using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace VidobuLiveChat.Hubs
{
    public class ChatHub : Hub
    {
        public Task SendMessage(string nick, string message)
        {
            return Clients.All.InvokeAsync("ReceiveMessage", nick, message);
        }
    }
}