using CommandSystem;
using System;
using RemoteAdmin;

namespace randomlyOpenDoors.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class HelloWorld : ICommand
    {
        public string Command { get; } = "hello";

        public string[] Aliases { get; } = { "helloworld" };

        public string Description { get; } = "A command that responds with hello world";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender player)
            {
                response = $"Hello {player.Nickname}";
                return false;
            }
            else
            {
                response = "World!";
                return true;
            }
        }
    }
}
