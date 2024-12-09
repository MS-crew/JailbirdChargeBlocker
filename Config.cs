using Exiled.API.Interfaces;

namespace JailbirdChargeWarner
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public bool AttackDamage { get; set; } = true;
        public bool UnbreakebleJail { get; set; } = true;
    }
}
