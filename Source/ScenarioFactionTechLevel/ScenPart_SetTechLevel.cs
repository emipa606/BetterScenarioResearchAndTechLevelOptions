using System;
using System.Linq;
using RimWorld;
using Verse;

namespace ScenarioFactionTechLevel;

public class ScenPart_SetTechLevel : ScenPart
{
    private TechLevel techLevel = TechLevel.Neolithic;

    private static GameComponent_ScenarioFactionTechLevel GameComponentScenarioFactionTechLevel =>
        Current.Game.GetComponent<GameComponent_ScenarioFactionTechLevel>();

    public override void PostGameStart()
    {
        if (techLevel == TechLevel.Undefined)
        {
            return;
        }

        Find.FactionManager.OfPlayer.def.techLevel = techLevel;
        GameComponentScenarioFactionTechLevel.SetTechLevel(techLevel);
        foreach (var researchProjectDef in DefDatabase<ResearchProjectDef>.AllDefsListForReading)
        {
            if (researchProjectDef.tab == ResearchTabDefOf.Anomaly)
            {
                continue;
            }

            if (ModsConfig.AnomalyActive && researchProjectDef.knowledgeCost > 0)
            {
                continue;
            }

            if (techLevel == TechLevel.Archotech || (int)researchProjectDef.techLevel < (int)techLevel)
            {
                Find.ResearchManager.FinishProject(researchProjectDef);
            }
        }
    }

    public override void DoEditInterface(Listing_ScenEdit listing)
    {
        var buttonRect = listing.GetScenPartRect(this, RowHeight);
        var unlockedTech =
            Utility.TechLevelUnlocks.Where(pair => pair.Key <= techLevel && pair.Key != TechLevel.Undefined);
        TooltipHandler.TipRegion(buttonRect,
            "ScenarioFactionTechLevel.TechTooltip".Translate(unlockedTech.SelectMany(pair => pair.Value).OrderBy(x => x)
                .ToCommaList()));
        if (!Widgets.ButtonText(buttonRect, techLevel.ToString()))
        {
            return;
        }

        FloatMenuUtility.MakeMenu(from TechLevel x in Enum.GetValues(typeof(TechLevel))
            where x != TechLevel.Undefined
            select x, d => d.ToString(), d => delegate { techLevel = d; });
    }

    public override string Summary(Scenario scen)
    {
        return "ScenarioFactionTechLevel.ScenPart_SetTechLevel".Translate(techLevel.ToString());
    }

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref techLevel, "techLevel");
        if (Scribe.mode == LoadSaveMode.PostLoadInit && techLevel == TechLevel.Undefined)
        {
            techLevel = TechLevel.Neolithic;
        }
    }
}