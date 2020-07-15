using System;
using System.Collections.Generic;
using System.Security.Policy;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Framework.UI.Sleek2;
using SDG.Unturned;
using UnityEngine;

namespace MyPlugin
{
    public class MyPlugin : RocketPlugin<MyPluginConfiguration>
    {
        public static MyPlugin Instance;
        
        protected override void Load()
        {
            Instance = this;
    }
        protected override void Unload()
        {
        }

        public void onEffectButtonClicked(Player player, string buttonName)
        {
            if (buttonName == "Button_0")
            {
                CommandUI.player2.Suicide();
            }

        }
            public static object[] CheckConfig(UnturnedPlayer player)
        {   bool hunger = Instance.Configuration.Instance.ShowHunger;
            bool health = Instance.Configuration.Instance.ShowHealth;
            bool thristy = Instance.Configuration.Instance.ShowThristy;
            string msg = Instance.Configuration.Instance.Msg;
            object[] returnv2 = { true, health, thristy, hunger, msg};
            return returnv2;
        }
        uPlayer.Player.setPluginWidgetFlag(EPluginWidgetFlags.Modal, true);   
    }

}
