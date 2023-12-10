using Microsoft.AspNetCore.SignalR;
using WebApiSignalR.Helpers;

namespace WebApiSignalR.Hubs
{
    public class MessageHub:Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.Others.SendAsync("ReceiveConnectInfo", "User Connected");
        }

        public async Task SendMessage(string message)
        {
            await Clients.Others.SendAsync("ReceiveMessage",message+"'s Offer : ",FileHelper.Read());
        }

        public async Task SendWinnerMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveInfo", message, FileHelper.Read());
        }
        public async Task JoinRoom(string room,string user)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId,room);
            await Clients.OthersInGroup(room).SendAsync("ReceiveJoinInfo", user);
        }
    }
}
