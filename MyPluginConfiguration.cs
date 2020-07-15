using System.Collections.Generic;
using Rocket.API;
using SDG.Unturned;

namespace MyPlugin
{
    public class MyPluginConfiguration : IRocketPluginConfiguration
    {
        public bool ShowHunger;
        public bool ShowThristy;
        public bool ShowHealth;
        public string Msg;

        public void LoadDefaults()
        {
            ShowHealth = true;
            ShowThristy = true;
            ShowHunger = true;
            Msg = "Ваше состояние:";
        }
    }
}