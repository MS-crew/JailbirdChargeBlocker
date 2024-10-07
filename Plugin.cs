using Exiled.API.Features;
using Exiled.Events.EventArgs.Item;
using HarmonyLib;
using System;

namespace JailbirdChargeWarner
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; private set; }

        public override string Author => "ZurnaSever";

        public override string Name => "JailbirdChargeBlocker";

        public override string Prefix => "JailbirdChargeBlocker";

        public override Version RequiredExiledVersion { get; } = new Version(8, 12, 0);

        public override Version Version { get; } = new Version(1, 0, 0);
        private Harmony harmony;
        public override void OnEnabled()
        {
            Instance = this;
            harmony = new Harmony("jailbirdchargeblocker");
            harmony.PatchAll();
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Instance = null;
            harmony.UnpatchAll();
            base.OnDisabled();
        }
    }
}
