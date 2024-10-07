using HarmonyLib;
using InventorySystem.Items.Jailbird;

namespace JailbirdChargeWarner
{
    [HarmonyPatch(typeof(JailbirdItem), "ServerProcessCmd")]
    public static class JailbirdChargeBlocker
    {
        public static bool Prefix()
        {
            return false;
        }
    }
}
