using HarmonyLib;
using InventorySystem.Items;
using InventorySystem.Items.Jailbird;
using Mirror;

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
            if (__instance._deterioration.IsBroken || !__instance.IsEquipped)
                return false;
            JailbirdMessageType header = (JailbirdMessageType)reader.ReadByte();
            bool flag1 = !__instance.Owner.HasBlock(BlockedInteraction.ItemPrimaryAction);
            bool flag2 = !__instance.Owner.HasBlock(BlockedInteraction.ItemUsage);
            switch (header)
            {
                case JailbirdMessageType.AttackTriggered:
                    if (__instance._attackTriggered || !__instance._serverAttackCooldown.TolerantIsReady)
                        break;
                    __instance._attackTriggered = true;
                    __instance._serverAttackCooldown.Trigger((double)__instance._meleeCooldown);
                    __instance.SendRpc(JailbirdMessageType.AttackTriggered);
                    break;

                case JailbirdMessageType.AttackPerformed:
                    if (!Plugin.Instance.Config.Damage)
                        break;
                    if (__instance._charging)
                    {
                        __instance.ServerAttack(reader);
                        break;
                    }
                    if (!__instance._attackTriggered || !flag1)
                        break;
                    __instance._attackTriggered = false;
                    __instance.ServerAttack(reader);
                    break;

                case JailbirdMessageType.Inspect:
                    if (!flag2)
                        break;
                    __instance.SendRpc(header);
                    break;
                default:
                    break;
            }
            return false;
        }
    }
}
