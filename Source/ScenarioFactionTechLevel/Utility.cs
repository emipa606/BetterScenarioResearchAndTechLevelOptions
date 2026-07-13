using System;
using System.Collections.Generic;
using System.Linq;
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

    public static Dictionary<TechLevel, IEnumerable<string>> TechLevelUnlocks
    {
        get
        {
            if (field != null)
            {
                return field;
            }

            field = new Dictionary<TechLevel, IEnumerable<string>>();
            foreach (var techValue in Enum.GetValues(typeof(TechLevel)))
            {
                var researchProjects = DefDatabase<ResearchProjectDef>.AllDefsListForReading
                    .Where(def => def.techLevel == (TechLevel)techValue).Select(def => def.LabelCap.RawText);
                field.Add((TechLevel)techValue, researchProjects);
            }

            return field;
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