using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace ScpForce.Handlers
{
    public class EventHandlers
    {
        private readonly Plugin<Config> plugin;

        public EventHandlers(Plugin<Config> plugin)
        {
            this.plugin = plugin;
        }

        public Random rand = new Random();

        public void OnRoundEnded(RoundEndedEventArgs ev)
        {
            foreach (var ply in Player.List)
            {
                if (ply.IsAlive)
                {
                    ply.SetRole(plugin.Config.Roles[rand.Next(0, plugin.Config.Roles.Count)], true);
                }
                else
                {
                    ply.Role = plugin.Config.Roles[rand.Next(0, plugin.Config.Roles.Count)];
                }
            }
        }
    }
}
