using Exiled.API.Interfaces;

namespace JailbirdChargeWarner
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
    }
}
