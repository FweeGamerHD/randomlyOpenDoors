using CommandSystem;
using System;
using RemoteAdmin;

namespace randomlyOpenDoors.Commands
{
    class Deny : ICommand
    {
        public string Command { get; } = "deny";

        public string[] Aliases { get; } = { };

        public string Description { get; } = "A command that is denied";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "The command was not a success!";
            return false;
        }
    }
}
