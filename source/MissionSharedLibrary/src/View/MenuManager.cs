﻿using System;
using System.Collections.Generic;
using System.Text;
using MissionLibrary.View;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;
using TaleWorlds.MountAndBlade.View.Missions;

namespace MissionSharedLibrary.View
{
    public class MenuManager : AMenuManager
    {
        public override IMenuClassCollection MenuClassCollection { get; } = new MenuClassCollection();
        public override MissionView CreateMenuView()
        {
            return new OptionView(24, new Version(1, 0, 0));
        }

        public override void RequestToOpenMenu()
        {
            Mission.Current.GetMissionBehaviour<OptionView>()?.ActivateMenu();
        }

        public override void RequestToCloseMenu()
        {
            Mission.Current.GetMissionBehaviour<OptionView>()?.DeactivateMenu();
        }
    }
}
