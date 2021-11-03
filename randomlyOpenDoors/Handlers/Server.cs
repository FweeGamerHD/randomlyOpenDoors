using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomlyOpenDoors.Handlers
{
    class Server
    {
        public void OnWaitingForPlayers()
        {
            Log.Info("Waiting for Players...");
        }

        public void OnRoundStarted()
        {
            Map.Broadcast(6, randomlyOpenDoors.Instance.Config.RoundStartedMessage);
        }
    }
}
