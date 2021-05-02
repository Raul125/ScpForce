using System;
using Exiled.API.Features;
using Exiled.API.Enums;
using ScpForce.Handlers;

namespace ScpForce
{
    public class ScpForce : Plugin<Config>
    {
        public EventHandlers EventHandlers;
        public override Version RequiredExiledVersion { get; } = new Version("2.10.0");
        public override PluginPriority Priority { get; } = PluginPriority.Default;
        public override string Author { get; } = "Raul125";
        public override string Name { get; } = "ScpForce";
        public override Version Version { get; } = new Version("1.0.0");

        public override void OnEnabled()
        {
            EventHandlers = new EventHandlers(this);
            Exiled.Events.Handlers.Server.RoundEnded += EventHandlers.OnRoundEnded;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundEnded -= EventHandlers.OnRoundEnded;
            EventHandlers = null;
            base.OnDisabled();
        }
    }
}
