using System;
using HarmonyLib;
using Exiled.API.Features;

namespace JailbirdChargeBlocker
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; private set; }

        public static EventHandlers EventHandlers;

        public override string Author => "ZurnaSever";

        public override string Name => "JailbirdChargeBlocker";

        public override string Prefix => "JailbirdChargeBlocker";

        public override Version RequiredExiledVersion { get; } = new Version(9, 0, 0);

        public override Version Version { get; } = new Version(1, 2, 0);
        private Harmony harmony;
        public override void OnEnabled()
        {
            Instance = this;
            EventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Player.Hurting += EventHandlers.OnPlayerHurting;

            harmony = new Harmony("zurnasever.jailbirdchargeblocker" + DateTime.Now.Ticks);
            harmony.PatchAll();

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Hurting -= EventHandlers.OnPlayerHurting;

            harmony.UnpatchAll();

            EventHandlers = null;
            Instance = null;
            base.OnDisabled();
        }
    }
}
