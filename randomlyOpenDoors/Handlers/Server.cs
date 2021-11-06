using Exiled.API.Features;

namespace randomlyOpenDoors.Handlers
{
    class Server
    {
        public void OnRoundStarted()
        {
            int chance = randomlyOpenDoors.Instance.Config.Chance;
            Log.Info("Opening Doors with a " + chance + "% Chance.");

            randomlyOpenDoors.OpenDoors();
        }
    }
}
