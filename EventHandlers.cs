using Exiled.API.Enums;
using Exiled.Events.EventArgs.Player;

namespace JailbirdChargeBlocker
{
    public class EventHandlers
    {
        public void OnPlayerHurting(HurtingEventArgs ev)
        {
            if (ev.DamageHandler.Type != DamageType.Jailbird || !Plugin.Instance.Config.OverrideDamage)
                return;

            ev.Amount = Plugin.Instance.Config.Damage;
        }
    }
}
