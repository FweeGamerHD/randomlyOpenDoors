using Exiled.API.Enums;
using Exiled.API.Features;
using Interactables.Interobjects.DoorUtils;
using System;

using Server = Exiled.Events.Handlers.Server;

namespace randomlyOpenDoors
{
    public class randomlyOpenDoors : Plugin<Config>
    {
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
            System.Collections.IList list = Map.Doors;
            for (int i = 0; i < list.Count; i++)
            {
                DoorVariant door = (DoorVariant)list[i];


                Random rnd = new Random();
                int random = rnd.Next(1, 100);

                int chance = randomlyOpenDoors.Instance.Config.Chance;
                if (random <= chance)
                {
                    door.NetworkTargetState = false;
                    door.IsConsideredOpen();
                }
            }
        }
    }
}
