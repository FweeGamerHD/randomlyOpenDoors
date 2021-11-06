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

        public static randomlyOpenDoors Instance;

        public override PluginPriority Priority { get; } = PluginPriority.Medium;
        public randomlyOpenDoors Singleton { get; private set; }

        private Handlers.Server server;

        public randomlyOpenDoors()
        {
        }

        public override void OnEnabled()
        {
            Singleton = this;
            RegisterEvents();
            base.OnEnabled();

            Instance = this;
        }

        public override void OnDisabled()
        {
            Singleton = null;
            UnRegisterEvents();
            base.OnDisabled();
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


        // Old Tinybrain Code, isn't used anymore :)
        /*public static void FindDoors()
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
        }*/

        public static void OpenDoors()
        {
            foreach (var room in Map.Rooms)
            {
                switch ((room.Type))
                {
                    case RoomType.LczArmory:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.LczCurve:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.LczStraight:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.Lcz012:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.Lcz914:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.LczCrossing:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.LczTCross:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.LczCafe:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.LczPlants:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.LczToilets:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.LczAirlock:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.Lcz173:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.LczClassDSpawn:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.LczChkpB:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.LczGlassBox:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.LczChkpA:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.Hcz079:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.HczEzCheckpoint:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.HczArmory:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.Hcz939:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.HczHid:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.Hcz049:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.HczChkpA:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.HczCrossing:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.Hcz106:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.HczNuke:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.HczTesla:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.HczServers:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.HczChkpB:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.HczTCross:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.HczCurve:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.Hcz096:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.EzVent:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.EzIntercom:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.EzGateA:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.EzDownstairsPcs:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.EzCurve:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.EzPcs:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.EzCrossing:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.EzCollapsedTunnel:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.EzConference:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.EzStraight:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.EzCafeteria:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.EzUpstairsPcs:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.EzGateB:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.EzShelter:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                    case RoomType.Surface:
                        foreach (var door in room.Doors)
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);

                            if (number <= randomlyOpenDoors.Instance.Config.Chance)
                            {
                                door.IsOpen = true;
                            }
                        }
                        break;
                }               
            }
        }
    }
}
