using System;
using Exiled.API.Features;
using PlayerEvent = Exiled.Events.Handlers.Player;
using ServerEvent = Exiled.Events.Handlers.Server;

namespace HighPingDetector
{

    public class HighPingDetector : Plugin<Config>
    {

        private EventHandler EventHandler;
        public static HighPingDetector Singleton;

        public override string Name { get; } = "HighPingDetector";
        public override string Author { get; } = "Denty";
        public override string Prefix { get; } = "HighPingDetector";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(4, 0, 0);


        public override void OnEnabled()
        {
            Singleton = this;
            EventHandler = new EventHandler();

            Log.Info("HighPingDetector has been enabled.");
            base.OnEnabled();
        }


        public override void OnDisabled()
        {
            Log.Info("HighPingDetector is disabled.");

            EventHandler = null;
            base.OnDisabled();
        }
    }
}