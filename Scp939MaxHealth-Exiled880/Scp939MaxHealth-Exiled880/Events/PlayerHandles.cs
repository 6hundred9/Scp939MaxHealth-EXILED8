using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Scp106;
using Exiled.Events.EventArgs.Scp914;
using Exiled.Events.Handlers;
using PlayerRoles;

namespace TestPlugin_EXILED8.Events
{
    public class PlayerHandler
    {
        public static void OnChangingRole(ChangingRoleEventArgs ev)
        {
            Log.Info($"{ev.Player.Nickname} ({ev.Player.Role}) is changing his role! The new role will be {ev.NewRole}!");

            if (ev.NewRole == RoleTypeId.ClassD)
            {
                ev.Items.Add(ItemType.KeycardJanitor);
                ev.Items.Add(ItemType.Flashlight);
                ev.Items.Add(ItemType.Coin);
            } 
            
        }
        public static void Spawned(SpawnedEventArgs ev)
        {
            if (ev.Player.Role == RoleTypeId.Scp939)
            {
                ev.Player.MaxHealth = 3200;
                ev.Player.Health = 3200;
                ev.Player.HumeShield = 700;
                
            }
        }

    }
}