using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TestPlugin_EXILED8.Events;

namespace Scp939MaxHealth_Exiled880
{
    public class Scp939MaxHealth : Plugin<Config>
    {
        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.ChangingRole += PlayerHandler.OnChangingRole;
            Exiled.Events.Handlers.Player.Spawned += PlayerHandler.Spawned;
        }

        // This method will be called when your plugin is disabled
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.ChangingRole -= PlayerHandler.OnChangingRole;
            Exiled.Events.Handlers.Player.Spawned -= PlayerHandler.Spawned;
        }
    }
}
