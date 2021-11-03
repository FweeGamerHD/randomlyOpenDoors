using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomlyOpenDoors.Handlers
{
    class Player
    {
        public void OnLeft(LeftEventArgs ev)
        {
            Map.Broadcast(6, $"{ev.Player} has left the server.");
        }

        public void OnJoined(JoinedEventArgs ev)
        {
            Map.Broadcast(6, $"{ev.Player} has joined the server.");
        }

        public void OnInteractingDoor(InteractingDoorEventArgs ev)
        {
            if (ev.IsAllowed == false)
            {
                ev.Player.Broadcast(3, "You walked into my trap!");
                ev.Player.Kill(DamageTypes.Lure);
            }
        }
    }
}
