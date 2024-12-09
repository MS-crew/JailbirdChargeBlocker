using Mirror;
using HarmonyLib;
using InventorySystem.GUI;
using InventorySystem.Drawers;
using InventorySystem.Items.Jailbird;

namespace JailbirdChargeWarner
{
    [HarmonyPatch(typeof(JailbirdDeteriorationTracker), nameof(JailbirdDeteriorationTracker.RecheckUsage))]
    public static class UnbreakableJailbird
    {
        public static bool Prefix()
        {
            if(Plugin.Instance.Config.UnbreakebleJail)
                return false;
            return true;
        }
    }

    [HarmonyPatch(typeof(JailbirdItem), "ServerProcessCmd")]
    public static class JailbirdChargeBlocker
    {
        public static bool Prefix(JailbirdItem __instance,NetworkReader reader)
        {
            JailbirdMessageType header = (JailbirdMessageType)reader.ReadByte();
            if (header == JailbirdMessageType.ChargeStarted || header == JailbirdMessageType.ChargeLoadTriggered || header == JailbirdMessageType.AttackPerformed)
            {
                if (__instance._deterioration.IsBroken || !__instance.IsEquipped)
                    return false;

                switch (header)
                {
                    case JailbirdMessageType.AttackPerformed:
                        if (!Plugin.Instance.Config.AttackDamage)
                            break;
                        return true;

                    default:
                        break;
                }
                return false;
            }
            return true;
        }
    }
}
