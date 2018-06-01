using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalR_LiveGraph
{
    public class GraphHub : Hub
    {
        public Task SendValue(int value)
        {
            return Clients.All.SendAsync("ReceiveValue", value);
        }
    }
}