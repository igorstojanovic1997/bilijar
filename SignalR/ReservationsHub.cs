using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace bilijar.SignalR
{
    [HubName("reservations")]
    public class ReservationsHub : Hub
    {
        public void UpdateReservations()
        {
            Clients.All.UpdateRecords();
        }
    }
}