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
        public void OnRoundStarted()
        {
            Log.Info("Opening Doors with a {chance}% Chance.");
        }
    }
}
