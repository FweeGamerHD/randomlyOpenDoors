using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events;
using System;

using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;

namespace randomlyOpenDoors
{
    public class randomlyOpenDoors : Plugin<Config>
    {
        private static readonly Lazy<randomlyOpenDoors> LazyInstance = new Lazy<randomlyOpenDoors>(() => new randomlyOpenDoors());
        public randomlyOpenDoors Instance => LazyInstance.Value;

        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        private Handlers.Player player;
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
            player = new Handlers.Player();
            server = new Handlers.Server();

            Server.WaitingForPlayers += server.OnWaitingForPlayers;
            Server.RoundStarted += server.OnRoundStarted;

            Player.Left += player.OnLeft;
            Player.Joined += player.OnJoined;
            Player.InteractingDoor += player.OnInteractingDoor;
        }

        public void UnRegisterEvents()
        {
            Server.WaitingForPlayers -= server.OnWaitingForPlayers;
            Server.RoundStarted -= server.OnRoundStarted;

            Player.Left -= player.OnLeft;
            Player.Joined -= player.OnJoined;
            Player.InteractingDoor -= player.OnInteractingDoor;

            player = null;
            server = null;
        }
    }
}
