using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Commands;
using Rocket.Unturned.Player;
using SDG.Unturned;
using UnityEngine;
using Rocket.Unturned.Events;
using Rocket.Unturned.Effects;
using System;
using SDG.Framework.UI.Sleek2;
using Rocket.Unturned;
using Rocket.Unturned.Serialisation;
using Rocket.Unturned.Plugins;

namespace MyPlugin
{
    public class CommandUI : IRocketCommand
    {
        public string Name => "ui";

        public string Help => "Показывает вам вашу статистику";

        public string Syntax => "";


        public List<string> Aliases => new List<string>();

        public List<string> Permissions
        {
            get
            {
                return new List<string>() { "ui" };
            }
        }
        public AllowedCaller AllowedCaller => AllowedCaller.Player;


        public static UnturnedPlayer player2;
        public void Execute(IRocketPlayer caller, string[] command)
        {
            player2 = (UnturnedPlayer)caller;
            UnturnedChat.Say("ПРОВЕРКА ЖИВ ЛИ ПЛАГИН");
            player2.TriggerEffect(9730);
        }
    }
}
