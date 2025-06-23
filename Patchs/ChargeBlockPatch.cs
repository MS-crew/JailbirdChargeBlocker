using Mirror;
using HarmonyLib;
using InventorySystem.Items.Jailbird;

namespace JailbirdChargeBlocker.Patchs
{
    [HarmonyPatch(typeof(JailbirdItem), nameof(JailbirdItem.ServerProcessCmd))]
    public static class ChargeBlockPatch
    {
        public static bool Prefix(JailbirdItem __instance, NetworkReader reader)
        {
            int originalPosition = reader.Position;
            JailbirdMessageType header = (JailbirdMessageType)reader.ReadByte();

            if (header == JailbirdMessageType.ChargeStarted || header == JailbirdMessageType.ChargeLoadTriggered)
                return false;

            reader.Position = originalPosition;
            return true;
        }
    }
}
