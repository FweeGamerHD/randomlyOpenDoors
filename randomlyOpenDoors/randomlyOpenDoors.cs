using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using Interactables.Interobjects.DoorUtils;

using Server = Exiled.Events.Handlers.Server;

namespace randomlyOpenDoors
{
    public class randomlyOpenDoors : Plugin<Config>
    {
        public override string Author => "FreeGamer";
        public override string Name => "randomlyOpenDoors";
        public override string Prefix => "rOD";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(3, 4, 0);

        private static readonly Lazy<randomlyOpenDoors> LazyInstance = new Lazy<randomlyOpenDoors>(() => new randomlyOpenDoors());
        public static randomlyOpenDoors Instance => LazyInstance.Value;

        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        private Handlers.Server server;

        private randomlyOpenDoors()
        {
        }

        public override void OnEnabled()
        {
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            UnRegisterEvents();
        }

        public void RegisterEvents()
        {
            server = new Handlers.Server();

            Server.RoundStarted += server.OnRoundStarted;

        }

        public void UnRegisterEvents()
        {
            Server.RoundStarted -= server.OnRoundStarted;

            server = null;
        }

        public static void findDoors()
        {
            foreach (Room r in Map.Rooms)
            {
                foreach (Door d in r.Doors)
                {
                    Random rnd = new Random();
                    int number = rnd.Next(1, 100);

                    if (number <= randomlyOpenDoors.Instance.Config.Chance)
                    {
                        d.IsOpen = true;
                    }
                }
            }
        }

    }
}
