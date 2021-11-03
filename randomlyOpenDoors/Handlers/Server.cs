using Exiled.API.Features;

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
