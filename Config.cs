using Exiled.API.Interfaces;

namespace JailbirdChargeBlocker
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public bool OverrideDamage { get; set; } = false;
        public float Damage { get; set; } = 20;
        public bool UnbreakebleJail { get; set; } = true;
    }
}
