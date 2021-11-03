using Exiled.API.Interfaces;
using System.ComponentModel;

namespace randomlyOpenDoors
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("Sets the message for when someone joins the server. {player} will be replaced with the players name.")]
        public string JoinedMessage { get; set; } = "{player} has joined the server.";

        [Description("Sets the message for when someone leaves the server. {player} will be replaced with the players name.")]
        public string LeftMessage { get; set; } = "{player} has left the server.";

        [Description("Sets the message for when the round starts")]
        public string RoundStartedMessage { get; set; } = "Get ready to rumble!";

        [Description("Sets your message for when someone triggers a trap.")]
        public string BoobyTrapMessage { get; set; } = "You have actived my trap card!";
    }
}
