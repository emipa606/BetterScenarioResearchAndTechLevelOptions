using System.Collections.Generic;
using RimWorld;
using Verse;

namespace ScenarioFactionTechLevel;

[StaticConstructorOnStartup]
public static class Utility
{
    static Utility()
    {
        FactionTechDict = new Dictionary<FactionDef, TechLevel>();
        foreach (var item in DefDatabase<FactionDef>.AllDefsListForReading)
        {
            if (item.isPlayer)
            {
                FactionTechDict.Add(item, item.techLevel);
            }
        }
    }

    private static Dictionary<FactionDef, TechLevel> FactionTechDict { get; }

    public static void EraseChanges(FactionDef exceptFaction = null)
    {
        foreach (var item in DefDatabase<FactionDef>.AllDefsListForReading)
        {
            if (item.isPlayer && item != exceptFaction)
            {
                item.techLevel = FactionTechDict.TryGetValue(item);
            }
        }
    }
}