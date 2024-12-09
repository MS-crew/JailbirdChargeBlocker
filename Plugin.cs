using System;
using HarmonyLib;
using Exiled.API.Features;

namespace JailbirdChargeWarner
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; private set; }

        public override string Author => "ZurnaSever";

        public override string Name => "JailbirdChargeBlocker";

        public override string Prefix => "JailbirdChargeBlocker";

        public override Version RequiredExiledVersion { get; } = new Version(9, 0, 0);

        public override Version Version { get; } = new Version(1, 1, 2);
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
            harmony.UnpatchAll(harmonyID: "jailbirdchargeblocker");
            base.OnDisabled();
        }
    }
}
