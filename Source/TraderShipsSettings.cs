﻿using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace TraderShips
{
    public class TraderShipsSettings : ModSettings
    {
        public bool disableOrbital = true;
        public bool colors = true;
        public bool requireCommsConsole = false;
        public bool enableQuests = true;

        override public void ExposeData()
        {
            Scribe_Values.Look(ref disableOrbital, "disableOrbital");
            Scribe_Values.Look(ref colors, "colors");
            Scribe_Values.Look(ref requireCommsConsole, "requireCommsConsole");
            Scribe_Values.Look(ref enableQuests, "enableQuests");
        }

        public void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listing_Standard = new Listing_Standard();
            listing_Standard.Begin(inRect);
            listing_Standard.CheckboxLabeled("TraderShipsDisableOrbitalName".Translate(), ref disableOrbital, "TraderShipsDisableOrbitalDesc".Translate());
            listing_Standard.CheckboxLabeled("TraderShipsColorsName".Translate(), ref colors, "TraderShipsColorsDesc".Translate());
            listing_Standard.CheckboxLabeled("TraderShipsRequireCommssConsoleName".Translate(), ref requireCommsConsole, "TraderShipsRequireCommssConsoleDesc".Translate());
            listing_Standard.CheckboxLabeled("TraderShipsEnableQuestsName".Translate(), ref enableQuests, "TraderShipsEnableQuestsDesc".Translate());
            listing_Standard.End();
        }
    }
}
