using HarmonyLib;
using InventorySystem.Items.Jailbird;

namespace JailbirdChargeBlocker.Patchs
{
    [HarmonyPatch(typeof(JailbirdDeteriorationTracker), nameof(JailbirdDeteriorationTracker.RecheckUsage))]
    public static class ChargePatch
    {
        public static bool Prefix()
        {
            if (Plugin.Instance.Config.UnbreakebleJail)
                return false;

            return true;
        }
    }
}
