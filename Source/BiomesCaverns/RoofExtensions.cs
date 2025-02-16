﻿using System.Collections.Generic;
using RimWorld;
using Verse;
using Verse.AI;
using HarmonyLib;
using System.Reflection;

namespace BiomesCaverns
{
    public static class RoofGridExtensions
    {
        public static bool UnbreachableRoofed(this RoofGrid grid, RoofDef roof)
        {
            return roof != null && roof.UnbreachableRoofed();
        }

        public static bool UnbreachableRoofed(this RoofGrid grid, int index)
        {
            return grid.UnbreachableRoofed(grid.RoofAt(index));
        }

        public static bool UnbreachableRoofed(this RoofGrid grid, IntVec3 c)
        {
            return grid.UnbreachableRoofed(grid.RoofAt(c));
        }

        public static bool UnbreachableRoofed(this RoofGrid grid, int x, int z)
        {
            return grid.UnbreachableRoofed(grid.RoofAt(x, z));
        }
    }

    public static class IntVec3Extensions
    {
        public static bool UnbreachableRoofed(this IntVec3 c, Map map)
        {
            return map.roofGrid.UnbreachableRoofed(c);
        }
    }
    public static class RoofDefExtensions
    {
        public static bool UnbreachableRoofed(this RoofDef roof)
        {
            return roof.isThickRoof && roof != BiomesCavernsDefOf.BMT_RockRoofStable;
        }
    }
}
