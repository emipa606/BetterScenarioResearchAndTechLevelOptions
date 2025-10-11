using RimWorld;
using Verse;

namespace ScenarioFactionTechLevel;

public class GameComponent_ScenarioFactionTechLevel : GameComponent
{
    private Game game;

    private TechLevel techLevel = TechLevel.Undefined;

    public GameComponent_ScenarioFactionTechLevel()
    {
    }

    public GameComponent_ScenarioFactionTechLevel(Game game)
    {
        this.game = game;
    }

    private TechLevel TechLevel => techLevel;

    public void SetTechLevel(TechLevel localTechLevel)
    {
        techLevel = localTechLevel;
    }

    public override void LoadedGame()
    {
        Utility.EraseChanges();
        if (techLevel != TechLevel.Undefined)
        {
            Find.FactionManager.OfPlayer.def.techLevel = TechLevel;
        }
    }

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref techLevel, "techLevel");
    }
}