using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Commands;
using Rocket.Unturned.Player;
using SDG.Unturned;
using UnityEngine;
using Rocket.Unturned.Events;

namespace MyPlugin
{
    public class CommandAlive : IRocketCommand
    {
        public string Name => "alive";

        public string Help => "Показывает вам вашу статистику";

        public string Syntax => "";


        public List<string> Aliases => new List<string>() { "al" };

        public List<string> Permissions
        {
            get
            {
                return new List<string>() { "alive" };
            }
        }

        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public static UnturnedPlayer player2;
        public void Execute(IRocketPlayer caller, string[] command)
        {
            player2 = (UnturnedPlayer)caller;
            UnturnedChat.Say("ПРОВЕРКА ЖИВ ЛИ ПЛАГИН");
            object[] cont = MyPlugin.CheckConfig(player2);
            UnturnedChat.Say((string)cont[4]);
            if ((bool)cont[1])
                UnturnedChat.Say("Здоровье: " + player2.Health.ToString());
            if ((bool)cont[2])
                UnturnedChat.Say("Жажда: " + player2.Thirst.ToString());
            if ((bool)cont[3])
                UnturnedChat.Say("Голод: " + player2.Hunger.ToString());
            if (!(bool)cont[0])
                UnturnedChat.Say("Отображение статистики отключено");
        }
    }
}
