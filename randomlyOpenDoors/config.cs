using Exiled.API.Interfaces;

namespace randomlyOpenDoors
{
    public sealed class config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}
