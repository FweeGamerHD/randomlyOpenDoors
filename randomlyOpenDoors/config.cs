﻿using Exiled.API.Interfaces;
using System.ComponentModel;

namespace randomlyOpenDoors
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}
