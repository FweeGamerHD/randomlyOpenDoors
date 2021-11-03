using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events;
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
    }
}
