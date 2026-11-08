
using System.Linq;
using robotManager.Helpful;
using wManager.Wow.Class;
using wManager.Wow.Enums;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;
using System.Collections.Generic;
using System.Threading;
using wManager.Wow.Bot.Tasks;


public sealed class ThroughtheDarkPortal : QuestClass
{
    public ThroughtheDarkPortal()
    {
        Name = "Through the Dark Portal";

        QuestId.AddRange(new[] { 10119 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RunToTheDarkPortalBurningSide : QuestFollowPathClass
{
    public RunToTheDarkPortalBurningSide()
    {
        Name = "Run To The Dark Portal (Burning Side)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-11830.31 , -3205.209 , -30.71687 , "None"));
Path.Add(new Vector3(-11852.01 , -3205.288 , -28.0905 , "None"));
Path.Add(new Vector3(-11857.84 , -3204.644 , -25.71851 , "None"));
Path.Add(new Vector3(-11868.76 , -3204.466 , -21.48443 , "None"));
Path.Add(new Vector3(-11879.3 , -3206.084 , -17.88251 , "None"));
Path.Add(new Vector3(-11889.93 , -3207.244 , -14.95382 , "None"));
Path.Add(new Vector3(-11899.35 , -3208.444 , -14.72965 , "None"));
Path.Add(new Vector3(-11902.54 , -3208.946 , -14.80254 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class ArrivalinOutland : QuestClass
{
    public ArrivalinOutland()
    {
        Name = "Arrival in Outland";

        QuestId.AddRange(new[] { 10288 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10119;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class JourneytoHonorHold : QuestClass
{
    public JourneytoHonorHold()
    {
        Name = "Journey to Honor Hold";

        QuestId.AddRange(new[] { 10140 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10288;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ForceCommanderDanath : QuestClass
{
    public ForceCommanderDanath()
    {
        Name = "Force Commander Danath";

        QuestId.AddRange(new[] { 10254 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10140;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheLegionReborn : QuestClass
{
    public TheLegionReborn()
    {
        Name = "The Legion Reborn";

        QuestId.AddRange(new[] { 10141 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KnowyourEnemy : QuestClass
{
    public KnowyourEnemy()
    {
        Name = "Know your Enemy";

        QuestId.AddRange(new[] { 10160 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThePathofGlory : QuestGathererClass
{
    public ThePathofGlory()
    {
        Name = "The Path of Glory";

        QuestId.AddRange(new[] { 10047 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(182789);
HotSpots.Add(new Vector3(-231.1671 , 2231.263 , 66.41027 , "None"));
HotSpots.Add(new Vector3(-229.2642 , 2327.204 , 45.45333 , "None"));
HotSpots.Add(new Vector3(-193.7729 , 2129.635 , 84.52404 , "None"));
HotSpots.Add(new Vector3(-224.2851 , 2044.556 , 97.71466 , "None"));
HotSpots.Add(new Vector3(-196.409 , 1971.183 , 96.78437 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheTempleofTelhamat : QuestClass
{
    public TheTempleofTelhamat()
    {
        Name = "The Temple of Telhamat";

        QuestId.AddRange(new[] { 10093 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10047;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AnOldGift : QuestGathererClass
{
    public AnOldGift()
    {
        Name = "An Old Gift";

        QuestId.AddRange(new[] { 10058 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(182804);
HotSpots.Add(new Vector3(-1507.251 , 2701.249 , -61.92904 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheLongbeards : QuestClass
{
    public TheLongbeards()
    {
        Name = "The Longbeards";

        QuestId.AddRange(new[] { 9558 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThePathofAnguish : QuestGrinderClass
{
    public ThePathofAnguish()
    {
        Name = "The Path of Anguish";

        QuestId.AddRange(new[] { 10142 });

        Step = new List<int> { 6, 1, 4, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10141;

        EntryTarget.Add(19261);
EntryTarget.Add(19434);
EntryTarget.Add(19136);
EntryTarget.Add(18978);
HotSpots.Add(new Vector3(-473.4178 , 2185.136 , 66.44135 , "None"));
HotSpots.Add(new Vector3(-388.0605 , 2117.903 , 87.28266 , "None"));
HotSpots.Add(new Vector3(-399.6082 , 2026.697 , 97.97441 , "None"));
HotSpots.Add(new Vector3(-469.7632 , 1967.503 , 89.9841 , "None"));
HotSpots.Add(new Vector3(-543.3731 , 1949.496 , 81.41999 , "None"));
HotSpots.Add(new Vector3(-592.8606 , 2026.067 , 83.87611 , "None"));
HotSpots.Add(new Vector3(-556.8946 , 2078.366 , 95.65154 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ExpeditionPoint : QuestClass
{
    public ExpeditionPoint()
    {
        Name = "Expedition Point";

        QuestId.AddRange(new[] { 10143 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WasteNotWantNot : QuestGathererClass
{
    public WasteNotWantNot()
    {
        Name = "Waste Not, Want Not";

        QuestId.AddRange(new[] { 10055 });

        Step = new List<int> { 8, 8, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(182799);
EntryIdObjects.Add(182797);
EntryIdObjects.Add(182798);
HotSpots.Add(new Vector3(-371.0156 , 2323.229 , 47.3136 , "None"));
HotSpots.Add(new Vector3(-284.9121 , 2368.447 , 49.87971 , "None"));
HotSpots.Add(new Vector3(-356.591 , 2582.485 , 48.0346 , "None"));
HotSpots.Add(new Vector3(-385.7167 , 2717.126 , 35.30324 , "None"));
HotSpots.Add(new Vector3(-336.6542 , 2404.879 , 43.3392 , "None"));
HotSpots.Add(new Vector3(-295.095 , 2332.419 , 51.7738 , "None"));
HotSpots.Add(new Vector3(-285.2002 , 2258.608 , 62.48992 , "None"));
HotSpots.Add(new Vector3(-512.1525 , 2987.244 , 11.64616 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class FelOrcScavengers : QuestGrinderClass
{
    public FelOrcScavengers()
    {
        Name = "Fel Orc Scavengers";

        QuestId.AddRange(new[] { 10482 });

        Step = new List<int> { 20, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10160;

        EntryTarget.Add(18952);
EntryTarget.Add(19701);
EntryTarget.Add(16925);
EntryTarget.Add(16876);
HotSpots.Add(new Vector3(-302.7954 , 2355.928 , 49.37281 , "None"));
HotSpots.Add(new Vector3(-338.7756 , 2437.563 , 42.15549 , "None"));
HotSpots.Add(new Vector3(-329.052 , 2513.825 , 39.22271 , "None"));
HotSpots.Add(new Vector3(-358.6989 , 2593.296 , 47.97632 , "None"));
HotSpots.Add(new Vector3(-382.1044 , 2679.111 , 42.43295 , "None"));
HotSpots.Add(new Vector3(-371.3253 , 2812.205 , 11.30864 , "None"));
HotSpots.Add(new Vector3(-407.9822 , 2902.087 , 15.57204 , "None"));
HotSpots.Add(new Vector3(-458.33 , 2945.182 , 17.06189 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class UnyieldingSouls : QuestGrinderClass
{
    public UnyieldingSouls()
    {
        Name = "Unyielding Souls";

        QuestId.AddRange(new[] { 10050 });

        Step = new List<int> { 12, 10, 5, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(16905);
EntryTarget.Add(16904);
EntryTarget.Add(16906);
HotSpots.Add(new Vector3(-1179.596 , 2863.326 , -8.49554 , "None"));
HotSpots.Add(new Vector3(-1386.421 , 2824.969 , -40.41945 , "None"));
HotSpots.Add(new Vector3(-1479.9 , 2774.378 , -65.23174 , "None"));
HotSpots.Add(new Vector3(-1371.833 , 2731.177 , -28.81101 , "None"));
HotSpots.Add(new Vector3(-1343.482 , 2686.056 , -11.78415 , "None"));
HotSpots.Add(new Vector3(-1311.497 , 2697.84 , -10.49408 , "None"));
HotSpots.Add(new Vector3(-1214.261 , 2722.698 , -9.283126 , "None"));
HotSpots.Add(new Vector3(-1132.041 , 2651.903 , 11.45161 , "None"));
HotSpots.Add(new Vector3(-1252.346 , 2676.342 , 2.325417 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AJobforanIntelligentMan : QuestGrinderClass
{
    public AJobforanIntelligentMan()
    {
        Name = "A Job for an Intelligent Man";

        QuestId.AddRange(new[] { 9355 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10142;

        EntryTarget.Add(16857);
HotSpots.Add(new Vector3(-754.3995 , 3021.867 , 11.48495 , "None"));
HotSpots.Add(new Vector3(-660.0076 , 3111.25 , -1.066423 , "None"));
HotSpots.Add(new Vector3(-732.2603 , 3174.453 , -20.7731 , "None"));
HotSpots.Add(new Vector3(-833.7344 , 3164.751 , 11.43511 , "None"));
HotSpots.Add(new Vector3(-843.1646 , 3248.57 , 25.19109 , "None"));
HotSpots.Add(new Vector3(-924.4678 , 3025.864 , 14.01053 , "None"));
HotSpots.Add(new Vector3(-871.0748 , 2964.776 , 9.401422 , "None"));
HotSpots.Add(new Vector3(-792.4886 , 2990.241 , 11.64482 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WhenThisMinesaRockin : QuestGrinderClass
{
    public WhenThisMinesaRockin()
    {
        Name = "When This Mine's a-Rockin'";

        QuestId.AddRange(new[] { 10079 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18827);
HotSpots.Add(new Vector3(-669.256 , 2826.518 , 49.83219 , "None"));
HotSpots.Add(new Vector3(-674.3148 , 2757.082 , 40.7907 , "None"));
HotSpots.Add(new Vector3(-650.6439 , 2680.148 , -0.4770646 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheMastermind : QuestGrinderClass
{
    public TheMastermind()
    {
        Name = "The Mastermind";

        QuestId.AddRange(new[] { 10099 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18974);
HotSpots.Add(new Vector3(-641.4509 , 2658.881 , -1.522238 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LayingWastetotheUnwanted : QuestUseItemOnClass
{
    public LayingWastetotheUnwanted()
    {
        Name = "Laying Waste to the Unwanted";

        QuestId.AddRange(new[] { 10078 });

        Step = new List<int> { 1, 1, 1, 1, 0 };

        StepAutoDetect = new[] { true, true, true, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10055;

        EntryIdTarget.Add(183123);
HotSpots.Add(new Vector3(-167.4375 , 2825.538 , 28.05375 , "None"));
HotSpots.Add(new Vector3(-154.5045 , 2778.416 , 38.66146 , "None"));
HotSpots.Add(new Vector3(-138.3268 , 2666.787 , 46.94903 , "None"));
HotSpots.Add(new Vector3(-141.6899 , 2521.714 , 45.04202 , "None"));
ItemId = 26002;
Range = 17.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class IllOmens : QuestGrinderClass
{
    public IllOmens()
    {
        Name = "Ill Omens";

        QuestId.AddRange(new[] { 10483 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10482;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DisruptTheirReinforcements : QuestInteractWithClass
{
    public DisruptTheirReinforcements()
    {
        Name = "Disrupt Their Reinforcements";

        QuestId.AddRange(new[] { 10144 });

        Step = new List<int> { 1, 1, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10143;

        EntryIdTarget.Add(184415);
HotSpots.Add(new Vector3(-549.4279 , 1783.687 , 58.79287 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "";
IgnoreIfDead = true;
Range = 3.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DisruptTheirReinforcementsGetrunestones : QuestGrinderClass
{
    public DisruptTheirReinforcementsGetrunestones()
    {
        Name = "Disrupt Their Reinforcements - Get runestones";

        QuestId.AddRange(new[] { 10144 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18975);
EntryTarget.Add(18679);
EntryTarget.Add(18981);
EntryTarget.Add(19190);
EntryTarget.Add(16950);
HotSpots.Add(new Vector3(-562.8212 , 1833.536 , 68.97812 , "None"));
HotSpots.Add(new Vector3(-493.5614 , 1826.77 , 64.63651 , "None"));
HotSpots.Add(new Vector3(-365.1192 , 1836.957 , 83.10861 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(28513) >= 4;
}



public override bool HasQuest() { return true; }


}


public sealed class DisruptTheirReinforcementsObject2 : QuestInteractWithClass
{
    public DisruptTheirReinforcementsObject2()
    {
        Name = "Disrupt Their Reinforcements - Object 2";

        QuestId.AddRange(new[] { 10144 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(184414);
HotSpots.Add(new Vector3(-417.9812 , 1848.145 , 81.09365 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "";
IgnoreIfDead = true;
Range = 10.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class EnterObject1far : QuestFollowPathClass
{
    public EnterObject1far()
    {
        Name = "Enter Object 1 (far)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-485.7093 , 1887.561 , 83.48495 , "None"));
Path.Add(new Vector3(-481.056 , 1886.975 , 83.14371 , "None"));
Path.Add(new Vector3(-469.3733 , 1887.389 , 81.24934 , "None"));
Path.Add(new Vector3(-461.534 , 1885.018 , 84.46871 , "None"));
Path.Add(new Vector3(-451.9956 , 1880.628 , 85.25359 , "None"));
Path.Add(new Vector3(-441.8098 , 1875.203 , 85.65929 , "None"));
Path.Add(new Vector3(-435.6401 , 1871.766 , 85.78875 , "None"));
Path.Add(new Vector3(-425.4032 , 1869.671 , 86.94395 , "None"));
Path.Add(new Vector3(-422.1945 , 1867.729 , 86.79067 , "None"));
Path.Add(new Vector3(-420.1161 , 1860.379 , 84.5571 , "None"));
Path.Add(new Vector3(-419.6738 , 1854.454 , 82.51921 , "None"));
Path.Add(new Vector3(-419.0616 , 1848.864 , 81.09367 , "None"));
Path.Add(new Vector3(-418.6711 , 1846.46 , 81.09367 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class ExitObject1far : QuestFollowPathClass
{
    public ExitObject1far()
    {
        Name = "Exit Object 1 (far)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-418.6711 , 1846.46 , 81.09367 , "None"));
Path.Add(new Vector3(-418.6711 , 1850.898 , 81.37121 , "None"));
Path.Add(new Vector3(-418.6711 , 1854.51 , 82.6581 , "None"));
Path.Add(new Vector3(-418.5928 , 1858.008 , 83.93659 , "None"));
Path.Add(new Vector3(-418.5159 , 1861.624 , 85.20751 , "None"));
Path.Add(new Vector3(-419.1299 , 1865.066 , 86.32357 , "None"));
Path.Add(new Vector3(-420.3643 , 1868.461 , 87.34758 , "None"));
Path.Add(new Vector3(-424.7041 , 1874.289 , 88.58708 , "None"));
Path.Add(new Vector3(-432.9954 , 1880.671 , 88.89237 , "None"));
Path.Add(new Vector3(-442.6885 , 1885.455 , 88.17435 , "None"));
Path.Add(new Vector3(-452.6741 , 1888.683 , 87.37066 , "None"));
Path.Add(new Vector3(-462.9653 , 1890.685 , 86.1016 , "None"));
Path.Add(new Vector3(-467.8695 , 1890.911 , 84.05478 , "None"));
Path.Add(new Vector3(-474.8366 , 1890.366 , 82.27825 , "None"));
Path.Add(new Vector3(-481.0116 , 1889.234 , 83.88255 , "None"));
Path.Add(new Vector3(-485.7455 , 1887.997 , 83.58792 , "None"));
Path.Add(new Vector3(-488.9433 , 1885.828 , 83.16176 , "None"));
Path.Add(new Vector3(-493.851 , 1883.963 , 82.53156 , "None"));
Path.Add(new Vector3(-499.502 , 1880.538 , 81.16062 , "None"));
Path.Add(new Vector3(-507.8001 , 1874.15 , 78.45789 , "None"));
Path.Add(new Vector3(-514.698 , 1868.194 , 76.02281 , "None"));
Path.Add(new Vector3(-519.0233 , 1865.906 , 75.03364 , "None"));
Path.Add(new Vector3(-530.9828 , 1858.628 , 72.50932 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class EnterObject2close : QuestFollowPathClass
{
    public EnterObject2close()
    {
        Name = "Enter Object 2 (close)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-567.5969 , 1821.512 , 68.09724 , "None"));
Path.Add(new Vector3(-569.4498 , 1815.257 , 67.6281 , "None"));
Path.Add(new Vector3(-572.3263 , 1809.244 , 67.31616 , "None"));
Path.Add(new Vector3(-572.3942 , 1805.654 , 66.82476 , "None"));
Path.Add(new Vector3(-571.2867 , 1802.339 , 66.11557 , "None"));
Path.Add(new Vector3(-569.2993 , 1799.349 , 65.2481 , "None"));
Path.Add(new Vector3(-566.5708 , 1797.157 , 64.32793 , "None"));
Path.Add(new Vector3(-563.697 , 1794.958 , 63.35581 , "None"));
Path.Add(new Vector3(-560.9978 , 1792.732 , 62.39061 , "None"));
Path.Add(new Vector3(-558.3286 , 1790.298 , 61.24507 , "None"));
Path.Add(new Vector3(-555.6186 , 1788.087 , 60.06154 , "None"));
Path.Add(new Vector3(-552.6037 , 1786.09 , 58.8836 , "None"));
Path.Add(new Vector3(-549.5057 , 1784.462 , 58.79275 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class ExitObject2Close : QuestFollowPathClass
{
    public ExitObject2Close()
    {
        Name = "Exit Object 2 (Close)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-547.7561 , 1783.533 , 58.79275 , "None"));
Path.Add(new Vector3(-550.9978 , 1785.38 , 58.79275 , "None"));
Path.Add(new Vector3(-554.0922 , 1787.244 , 59.48619 , "None"));
Path.Add(new Vector3(-557.0583 , 1789.102 , 60.65368 , "None"));
Path.Add(new Vector3(-559.9896 , 1791.015 , 61.80753 , "None"));
Path.Add(new Vector3(-562.9189 , 1793.127 , 62.86659 , "None"));
Path.Add(new Vector3(-568.4459 , 1798.645 , 64.95848 , "None"));
Path.Add(new Vector3(-574.1356 , 1807.467 , 67.42106 , "None"));
Path.Add(new Vector3(-579.7606 , 1816.331 , 69.52948 , "None"));
Path.Add(new Vector3(-585.2329 , 1825.708 , 71.16833 , "None"));
Path.Add(new Vector3(-590.6525 , 1834.341 , 72.21689 , "None"));
Path.Add(new Vector3(-598.2283 , 1842.112 , 72.27637 , "None"));
Path.Add(new Vector3(-606.9153 , 1847.984 , 72.53835 , "None"));
Path.Add(new Vector3(-616.6293 , 1851.891 , 72.42358 , "None"));
Path.Add(new Vector3(-627.0204 , 1854.566 , 72.23711 , "None"));
Path.Add(new Vector3(-637.4951 , 1857.413 , 71.56174 , "None"));
Path.Add(new Vector3(-646.6411 , 1859.777 , 70.86507 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class ZethGorMustBurn : QuestUseItemOnClass
{
    public ZethGorMustBurn()
    {
        Name = "Zeth'Gor Must Burn!";

        QuestId.AddRange(new[] { 10895 });

        Step = new List<int> { 1, 1, 1, 1, 0 };

        StepAutoDetect = new[] { true, true, true, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 5;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(300120);
HotSpots.Add(new Vector3(-821.8984 , 2029.305 , 39.27995 , "None"));
HotSpots.Add(new Vector3(-896.8146 , 1920.338 , 66.93637 , "None"));
HotSpots.Add(new Vector3(-976.2818 , 1879.014 , 94.78981 , "None"));
HotSpots.Add(new Vector3(-1153.135 , 2108.268 , 68.08882 , "None"));
ItemId = 31739;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNTOWER1 : QuestFollowPathClass
{
    public RUNTOWER1()
    {
        Name = "RUN TOWER 1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-797.6597 , 2002.125 , 38.62097 , "None"));
Path.Add(new Vector3(-807.9536 , 2013.295 , 38.83888 , "None"));
Path.Add(new Vector3(-814.9151 , 2021.155 , 39.13639 , "None"));
Path.Add(new Vector3(-814.8157 , 2020.514 , 39.12423 , "None"));
Path.Add(new Vector3(-819.5256 , 2024.94 , 39.22202 , "None"));
Path.Add(new Vector3(-822.4481 , 2026.893 , 39.23249 , "None"));
Path.Add(new Vector3(-825.5152 , 2027.625 , 39.2501 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNtoTOWER2 : QuestFollowPathClass
{
    public RUNtoTOWER2()
    {
        Name = "RUN to TOWER 2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-814.0214 , 2019.003 , 39.07511 , "None"));
Path.Add(new Vector3(-811.7831 , 2012.515 , 38.86338 , "None"));
Path.Add(new Vector3(-816.2888 , 2003.578 , 38.83656 , "None"));
Path.Add(new Vector3(-818.9964 , 1990.81 , 38.86344 , "None"));
Path.Add(new Vector3(-819.2675 , 1980.677 , 39.58142 , "None"));
Path.Add(new Vector3(-818.9067 , 1970.047 , 41.38149 , "None"));
Path.Add(new Vector3(-819.2598 , 1959.238 , 44.60573 , "None"));
Path.Add(new Vector3(-820.6417 , 1948.502 , 48.09361 , "None"));
Path.Add(new Vector3(-825.5115 , 1939.806 , 50.27458 , "None"));
Path.Add(new Vector3(-831.7715 , 1930.413 , 54.08397 , "None"));
Path.Add(new Vector3(-839.6308 , 1923.316 , 56.48151 , "None"));
Path.Add(new Vector3(-846.7814 , 1915.877 , 59.00991 , "None"));
Path.Add(new Vector3(-853.6465 , 1907.851 , 61.1069 , "None"));
Path.Add(new Vector3(-862.6824 , 1902.104 , 64.54683 , "None"));
Path.Add(new Vector3(-873.1124 , 1903.724 , 67.21841 , "None"));
Path.Add(new Vector3(-885.879 , 1909.127 , 66.97757 , "None"));
Path.Add(new Vector3(-893.3477 , 1917.093 , 66.87913 , "None"));
Path.Add(new Vector3(-897.5269 , 1921.018 , 66.93748 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNToTower3 : QuestFollowPathClass
{
    public RUNToTower3()
    {
        Name = "RUN To Tower 3";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-898.1758 , 1919.537 , 66.94669 , "None"));
Path.Add(new Vector3(-903.735 , 1909.535 , 67.55862 , "None"));
Path.Add(new Vector3(-907.8094 , 1904.656 , 68.71436 , "None"));
Path.Add(new Vector3(-910.8319 , 1901.502 , 69.96027 , "None"));
Path.Add(new Vector3(-922.0175 , 1900.933 , 71.68894 , "None"));
Path.Add(new Vector3(-932.8325 , 1901.952 , 72.39031 , "None"));
Path.Add(new Vector3(-943.2427 , 1900.29 , 74.25277 , "None"));
Path.Add(new Vector3(-953.5015 , 1897.444 , 77.97311 , "None"));
Path.Add(new Vector3(-958.5477 , 1894.955 , 80.9799 , "None"));
Path.Add(new Vector3(-963.0507 , 1891.049 , 85.44508 , "None"));
Path.Add(new Vector3(-966.9325 , 1891.635 , 87.40545 , "None"));
Path.Add(new Vector3(-970.2433 , 1887.89 , 92.43316 , "None"));
Path.Add(new Vector3(-974.5342 , 1883.962 , 94.46507 , "None"));
Path.Add(new Vector3(-976.8474 , 1880.331 , 94.77077 , "None"));
Path.Add(new Vector3(-977.426 , 1879.405 , 94.79507 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNTower4 : QuestFollowPathClass
{
    public RUNTower4()
    {
        Name = "RUN Tower 4";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-977.426 , 1879.405 , 94.79507 , "None"));
Path.Add(new Vector3(-976.6808 , 1888.836 , 93.63553 , "None"));
Path.Add(new Vector3(-982.733 , 1897.299 , 91.77883 , "None"));
Path.Add(new Vector3(-987.0391 , 1902.966 , 88.66519 , "None"));
Path.Add(new Vector3(-991.3799 , 1908.337 , 85.62766 , "None"));
Path.Add(new Vector3(-1000.17 , 1913.5 , 84.37651 , "None"));
Path.Add(new Vector3(-1002.979 , 1923.617 , 83.41153 , "None"));
Path.Add(new Vector3(-1004.643 , 1930.325 , 79.21468 , "None"));
Path.Add(new Vector3(-1007.178 , 1936.823 , 74.92944 , "None"));
Path.Add(new Vector3(-1012.292 , 1946.126 , 73.2801 , "None"));
Path.Add(new Vector3(-1017.353 , 1955.546 , 71.61436 , "None"));
Path.Add(new Vector3(-1025.379 , 1961.867 , 72.55318 , "None"));
Path.Add(new Vector3(-1032.363 , 1962.126 , 76.40645 , "None"));
Path.Add(new Vector3(-1041.411 , 1967.454 , 74.10525 , "None"));
Path.Add(new Vector3(-1049.505 , 1973.714 , 72.55202 , "None"));
Path.Add(new Vector3(-1059.674 , 1976.58 , 73.60316 , "None"));
Path.Add(new Vector3(-1070.331 , 1977.302 , 73.37856 , "None"));
Path.Add(new Vector3(-1080.291 , 1980.826 , 71.40162 , "None"));
Path.Add(new Vector3(-1084.222 , 1987.489 , 68.76907 , "None"));
Path.Add(new Vector3(-1084.55 , 1999.928 , 67.48868 , "None"));
Path.Add(new Vector3(-1084.695 , 2010.322 , 67.74331 , "None"));
Path.Add(new Vector3(-1085.052 , 2021.718 , 67.24883 , "None"));
Path.Add(new Vector3(-1086.29 , 2031.742 , 66.94061 , "None"));
Path.Add(new Vector3(-1087.764 , 2042.308 , 67.07351 , "None"));
Path.Add(new Vector3(-1089.577 , 2052.564 , 66.94073 , "None"));
Path.Add(new Vector3(-1091.53 , 2063.03 , 66.94941 , "None"));
Path.Add(new Vector3(-1093.7 , 2073.754 , 67.05408 , "None"));
Path.Add(new Vector3(-1095.778 , 2084.025 , 66.13234 , "None"));
Path.Add(new Vector3(-1097.945 , 2094.732 , 66.10252 , "None"));
Path.Add(new Vector3(-1100.671 , 2104.737 , 66.11135 , "None"));
Path.Add(new Vector3(-1105.405 , 2114.311 , 66.7904 , "None"));
Path.Add(new Vector3(-1111.834 , 2122.746 , 67.19263 , "None"));
Path.Add(new Vector3(-1119.086 , 2130.364 , 67.01925 , "None"));
Path.Add(new Vector3(-1128.655 , 2136.463 , 66.8831 , "None"));
Path.Add(new Vector3(-1136.359 , 2129.219 , 67.02706 , "None"));
Path.Add(new Vector3(-1139.24 , 2120.958 , 67.5519 , "None"));
Path.Add(new Vector3(-1141.216 , 2113.031 , 67.64832 , "None"));
Path.Add(new Vector3(-1141.836 , 2110.523 , 67.57517 , "None"));
Path.Add(new Vector3(-1144.406 , 2110.268 , 67.67844 , "None"));
Path.Add(new Vector3(-1147.755 , 2109.158 , 67.80037 , "None"));
Path.Add(new Vector3(-1151.53 , 2108.435 , 67.99471 , "None"));
Path.Add(new Vector3(-1153.432 , 2108.553 , 68.11411 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class QuestFinishedRuntoTurninAvoidMobs : QuestFollowPathClass
{
    public QuestFinishedRuntoTurninAvoidMobs()
    {
        Name = "Quest Finished, Run to Turnin (Avoid Mobs)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-1133.921 , 2114.493 , 67.40621 , "None"));
Path.Add(new Vector3(-1124.213 , 2121.005 , 67.03958 , "None"));
Path.Add(new Vector3(-1110.963 , 2127.93 , 67.67325 , "None"));
Path.Add(new Vector3(-1106.858 , 2123.918 , 67.53658 , "None"));
Path.Add(new Vector3(-1104.43 , 2106.516 , 66.51932 , "None"));
Path.Add(new Vector3(-1102.634 , 2083.839 , 66.77831 , "None"));
Path.Add(new Vector3(-1100.642 , 2069.418 , 67.70306 , "None"));
Path.Add(new Vector3(-1099.387 , 2048.324 , 66.98817 , "None"));
Path.Add(new Vector3(-1098.869 , 2043.522 , 66.95364 , "None"));
Path.Add(new Vector3(-1096.451 , 2036.986 , 66.93978 , "None"));
Path.Add(new Vector3(-1092.227 , 2027.007 , 66.98058 , "None"));
Path.Add(new Vector3(-1091.471 , 2017.273 , 67.9227 , "None"));
Path.Add(new Vector3(-1096.992 , 2009.008 , 67.69672 , "None"));
Path.Add(new Vector3(-1094.164 , 1999.17 , 67.23414 , "None"));
Path.Add(new Vector3(-1091.534 , 1988.901 , 67.80994 , "None"));
Path.Add(new Vector3(-1084.413 , 1981.579 , 70.6515 , "None"));
Path.Add(new Vector3(-1074.193 , 1978.663 , 72.67587 , "None"));
Path.Add(new Vector3(-1066.949 , 1978.207 , 72.33291 , "None"));
Path.Add(new Vector3(-1061.049 , 1978.243 , 72.1726 , "None"));
Path.Add(new Vector3(-1057.525 , 1978.152 , 71.77488 , "None"));
Path.Add(new Vector3(-1053.864 , 1977.197 , 71.25773 , "None"));
Path.Add(new Vector3(-1047.725 , 1974.085 , 71.73647 , "None"));
Path.Add(new Vector3(-1044.547 , 1972.13 , 72.22361 , "None"));
Path.Add(new Vector3(-1040.079 , 1969.043 , 72.9677 , "None"));
Path.Add(new Vector3(-1035.146 , 1964.743 , 75.05911 , "None"));
Path.Add(new Vector3(-1031.967 , 1963.214 , 75.58041 , "None"));
Path.Add(new Vector3(-1028.682 , 1962.517 , 73.90643 , "None"));
Path.Add(new Vector3(-1025.036 , 1961.847 , 72.53252 , "None"));
Path.Add(new Vector3(-1020.503 , 1959.467 , 71.89964 , "None"));
Path.Add(new Vector3(-1017.173 , 1954.625 , 72.00199 , "None"));
Path.Add(new Vector3(-1017.01 , 1951.145 , 73.47509 , "None"));
Path.Add(new Vector3(-1014.479 , 1947.258 , 73.87818 , "None"));
Path.Add(new Vector3(-1010.901 , 1947.316 , 72.26696 , "None"));
Path.Add(new Vector3(-1007.393 , 1947.228 , 71.35945 , "None"));
Path.Add(new Vector3(-1000.121 , 1946.907 , 70.76506 , "None"));
Path.Add(new Vector3(-994.0612 , 1948.947 , 70.64581 , "None"));
Path.Add(new Vector3(-984.72 , 1954.683 , 70.02715 , "None"));
Path.Add(new Vector3(-975.7565 , 1960.503 , 69.0696 , "None"));
Path.Add(new Vector3(-968.5682 , 1965.431 , 68.49893 , "None"));
Path.Add(new Vector3(-964.147 , 1964.93 , 68.0181 , "None"));
Path.Add(new Vector3(-967.1867 , 1960.564 , 68.00389 , "None"));
Path.Add(new Vector3(-975.5049 , 1955.129 , 69.07937 , "None"));
Path.Add(new Vector3(-979.4377 , 1950.197 , 69.82774 , "None"));
Path.Add(new Vector3(-983.7733 , 1947.778 , 70.48377 , "None"));
Path.Add(new Vector3(-990.7911 , 1939.979 , 71.83878 , "None"));
Path.Add(new Vector3(-992.988 , 1929.783 , 74.95884 , "None"));
Path.Add(new Vector3(-990.79 , 1920.23 , 78.94489 , "None"));
Path.Add(new Vector3(-986.9825 , 1915.589 , 80.95779 , "None"));
Path.Add(new Vector3(-982.751 , 1912.891 , 81.63146 , "None"));
Path.Add(new Vector3(-978.1857 , 1910.072 , 81.81847 , "None"));
Path.Add(new Vector3(-973.692 , 1907.297 , 81.47033 , "None"));
Path.Add(new Vector3(-970.0927 , 1904.641 , 81.19178 , "None"));
Path.Add(new Vector3(-964.16 , 1900.783 , 80.33229 , "None"));
Path.Add(new Vector3(-961.2313 , 1898.893 , 79.98454 , "None"));
Path.Add(new Vector3(-954.2121 , 1894.846 , 79.59728 , "None"));
Path.Add(new Vector3(-946.9596 , 1895.416 , 77.58015 , "None"));
Path.Add(new Vector3(-936.9604 , 1899.563 , 73.83813 , "None"));
Path.Add(new Vector3(-927.8344 , 1904.878 , 70.7504 , "None"));
Path.Add(new Vector3(-917.8984 , 1909.117 , 68.71598 , "None"));
Path.Add(new Vector3(-907.1606 , 1909.333 , 67.80823 , "None"));
Path.Add(new Vector3(-897.2436 , 1906.855 , 67.37026 , "None"));
Path.Add(new Vector3(-887.2051 , 1903.998 , 67.13696 , "None"));
Path.Add(new Vector3(-876.2994 , 1902.071 , 67.03522 , "None"));
Path.Add(new Vector3(-866.8617 , 1902.864 , 66.45743 , "None"));
Path.Add(new Vector3(-862.368 , 1904.54 , 64.86797 , "None"));
Path.Add(new Vector3(-859.3978 , 1906.675 , 64.04798 , "None"));
Path.Add(new Vector3(-856.5604 , 1908.725 , 62.63297 , "None"));
Path.Add(new Vector3(-853.6123 , 1910.519 , 61.00364 , "None"));
Path.Add(new Vector3(-850.3011 , 1912.029 , 59.88672 , "None"));
Path.Add(new Vector3(-843.6626 , 1913.415 , 58.52855 , "None"));
Path.Add(new Vector3(-842.3583 , 1917.111 , 57.79679 , "None"));
Path.Add(new Vector3(-838.4895 , 1917.788 , 56.66828 , "None"));
Path.Add(new Vector3(-835.9768 , 1920.365 , 55.64656 , "None"));
Path.Add(new Vector3(-833.4424 , 1922.987 , 54.69838 , "None"));
Path.Add(new Vector3(-832.0328 , 1926.271 , 53.8454 , "None"));
Path.Add(new Vector3(-829.4874 , 1928.601 , 52.93892 , "None"));
Path.Add(new Vector3(-826.9098 , 1930.937 , 52.1206 , "None"));
Path.Add(new Vector3(-821.6067 , 1935.791 , 50.58906 , "None"));
Path.Add(new Vector3(-818.2976 , 1939.03 , 49.69349 , "None"));
Path.Add(new Vector3(-796.9882 , 1959.965 , 45.22849 , "None"));
Path.Add(new Vector3(-751.3376 , 1953.872 , 48.04995 , "None"));
Path.Add(new Vector3(-723.0225 , 1927.436 , 52.43267 , "None"));
Path.Add(new Vector3(-698.0875 , 1910.635 , 58.37801 , "None"));
Path.Add(new Vector3(-686.2465 , 1897.278 , 61.43178 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class CursedTalismans : QuestGrinderClass
{
    public CursedTalismans()
    {
        Name = "Cursed Talismans";

        QuestId.AddRange(new[] { 10484 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10483;

        EntryTarget.Add(16907);
EntryTarget.Add(16871);
EntryTarget.Add(19422);
EntryTarget.Add(16873);
EntryTarget.Add(19440);
EntryTarget.Add(19424);
HotSpots.Add(new Vector3(-818.0804 , 1983.891 , 39.21632 , "None"));
HotSpots.Add(new Vector3(-883.778 , 1879.38 , 74.05884 , "None"));
HotSpots.Add(new Vector3(-945.2496 , 1910.617 , 70.0302 , "None"));
HotSpots.Add(new Vector3(-1003.586 , 1951.484 , 70.19114 , "None"));
HotSpots.Add(new Vector3(-957.3873 , 1987.906 , 68.81964 , "None"));
HotSpots.Add(new Vector3(-914.4553 , 2045.038 , 51.39914 , "None"));
HotSpots.Add(new Vector3(-911.8269 , 2103.796 , 23.09313 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WarlordoftheBleedingHollow : QuestGrinderClass
{
    public WarlordoftheBleedingHollow()
    {
        Name = "Warlord of the Bleeding Hollow";

        QuestId.AddRange(new[] { 10485 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10484;

        EntryTarget.Add(16964);
HotSpots.Add(new Vector3(-1151.696 , 1906.55 , 81.37794 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNBleedingHollowQuest : QuestFollowPathClass
{
    public RUNBleedingHollowQuest()
    {
        Name = "RUN: Bleeding Hollow Quest";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-713.6483 , 1876.936 , 62.29903 , "None"));
Path.Add(new Vector3(-755.8586 , 1873.309 , 67.36066 , "None"));
Path.Add(new Vector3(-772.5996 , 1869.936 , 65.31539 , "None"));
Path.Add(new Vector3(-807.7128 , 1859.523 , 72.53029 , "None"));
Path.Add(new Vector3(-828.1911 , 1867.497 , 66.25677 , "None"));
Path.Add(new Vector3(-853.0248 , 1891.256 , 65.13997 , "None"));
Path.Add(new Vector3(-867.3442 , 1899.591 , 65.68344 , "None"));
Path.Add(new Vector3(-885.0571 , 1909.067 , 67.01324 , "None"));
Path.Add(new Vector3(-900.3878 , 1908.958 , 67.39784 , "None"));
Path.Add(new Vector3(-928.8516 , 1904.55 , 70.9459 , "None"));
Path.Add(new Vector3(-950.1541 , 1897.834 , 76.88842 , "None"));
Path.Add(new Vector3(-967.8177 , 1898.623 , 83.30898 , "None"));
Path.Add(new Vector3(-987.8679 , 1913.672 , 82.11604 , "None"));
Path.Add(new Vector3(-1005.692 , 1941.349 , 72.39275 , "None"));
Path.Add(new Vector3(-1017.739 , 1955.169 , 71.94045 , "None"));
Path.Add(new Vector3(-1031.165 , 1963.593 , 74.93501 , "None"));
Path.Add(new Vector3(-1046.955 , 1971.216 , 74.04544 , "None"));
Path.Add(new Vector3(-1063.255 , 1975.727 , 74.16458 , "None"));
Path.Add(new Vector3(-1079.504 , 1977.557 , 73.04968 , "None"));
Path.Add(new Vector3(-1092.226 , 1985.957 , 68.229 , "None"));
Path.Add(new Vector3(-1100.461 , 2000.162 , 67.22462 , "None"));
Path.Add(new Vector3(-1103.752 , 2001.638 , 67.18239 , "None"));
Path.Add(new Vector3(-1106.239 , 1992.916 , 67.90478 , "None"));
Path.Add(new Vector3(-1106.429 , 1988.109 , 68.62932 , "None"));
Path.Add(new Vector3(-1107.28 , 1986.056 , 69.19949 , "None"));
Path.Add(new Vector3(-1109.195 , 1985.059 , 69.74442 , "None"));
Path.Add(new Vector3(-1111.679 , 1984.846 , 70.16615 , "None"));
Path.Add(new Vector3(-1115.133 , 1984.401 , 70.63667 , "None"));
Path.Add(new Vector3(-1118.314 , 1983.228 , 71.24175 , "None"));
Path.Add(new Vector3(-1119.175 , 1980.085 , 72.0619 , "None"));
Path.Add(new Vector3(-1121.216 , 1977.182 , 72.77415 , "None"));
Path.Add(new Vector3(-1123.341 , 1974.27 , 73.30629 , "None"));
Path.Add(new Vector3(-1126 , 1972.525 , 73.48925 , "None"));
Path.Add(new Vector3(-1128.885 , 1970.263 , 73.54506 , "None"));
Path.Add(new Vector3(-1131.433 , 1967.977 , 74.40883 , "None"));
Path.Add(new Vector3(-1132.948 , 1966.374 , 74.5549 , "None"));
Path.Add(new Vector3(-1135.225 , 1963.808 , 76.08003 , "None"));
Path.Add(new Vector3(-1137.648 , 1961.064 , 77.78986 , "None"));
Path.Add(new Vector3(-1140.017 , 1958.384 , 78.98904 , "None"));
Path.Add(new Vector3(-1142.437 , 1955.808 , 79.96355 , "None"));
Path.Add(new Vector3(-1144.692 , 1953.188 , 81.09731 , "None"));
Path.Add(new Vector3(-1146.765 , 1950.309 , 81.40189 , "None"));
Path.Add(new Vector3(-1148.384 , 1947.083 , 81.4305 , "None"));
Path.Add(new Vector3(-1149.379 , 1943.714 , 81.41946 , "None"));
Path.Add(new Vector3(-1150.822 , 1941.127 , 81.4094 , "None"));
Path.Add(new Vector3(-1148.894 , 1938.808 , 81.40427 , "None"));
Path.Add(new Vector3(-1145.334 , 1934.809 , 81.40304 , "None"));
Path.Add(new Vector3(-1142.848 , 1930.827 , 81.40496 , "None"));
Path.Add(new Vector3(-1140.49 , 1928.153 , 81.40763 , "None"));
Path.Add(new Vector3(-1139.889 , 1924.89 , 81.36617 , "None"));
Path.Add(new Vector3(-1139.232 , 1921.634 , 81.16888 , "None"));
Path.Add(new Vector3(-1137.936 , 1918.31 , 81.37253 , "None"));
Path.Add(new Vector3(-1135.176 , 1916.23 , 81.36977 , "None"));
Path.Add(new Vector3(-1134.108 , 1914.4 , 81.40144 , "None"));
Path.Add(new Vector3(-1134.866 , 1911.533 , 81.39781 , "None"));
Path.Add(new Vector3(-1135.36 , 1909.291 , 81.39627 , "None"));
Path.Add(new Vector3(-1135.978 , 1906.993 , 81.39627 , "None"));
Path.Add(new Vector3(-1135.067 , 1905.09 , 81.40192 , "None"));
Path.Add(new Vector3(-1136.126 , 1903.11 , 81.37215 , "None"));
Path.Add(new Vector3(-1136.302 , 1900.593 , 81.36819 , "None"));
Path.Add(new Vector3(-1139.982 , 1900.782 , 81.35806 , "None"));
Path.Add(new Vector3(-1142.102 , 1901.209 , 81.37146 , "None"));
Path.Add(new Vector3(-1144.078 , 1901.893 , 81.36651 , "None"));
Path.Add(new Vector3(-1145.946 , 1902.866 , 81.38121 , "None"));
Path.Add(new Vector3(-1149.186 , 1904.784 , 81.38166 , "None"));
Path.Add(new Vector3(-1151.044 , 1906.115 , 81.3703 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNBleedingHollowRUNOUTbacktoQGiver : QuestFollowPathClass
{
    public RUNBleedingHollowRUNOUTbacktoQGiver()
    {
        Name = "RUN: Bleeding Hollow - RUN OUT back to QGiver";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-1140.657 , 1900.467 , 81.36232 , "None"));
Path.Add(new Vector3(-1137.972 , 1902.755 , 81.35463 , "None"));
Path.Add(new Vector3(-1136.102 , 1905.855 , 81.39513 , "None"));
Path.Add(new Vector3(-1135.581 , 1909.184 , 81.39528 , "None"));
Path.Add(new Vector3(-1136.161 , 1912.659 , 81.39207 , "None"));
Path.Add(new Vector3(-1137.425 , 1916.217 , 81.37057 , "None"));
Path.Add(new Vector3(-1138.634 , 1919.499 , 81.35662 , "None"));
Path.Add(new Vector3(-1138.701 , 1922.908 , 81.13902 , "None"));
Path.Add(new Vector3(-1138.899 , 1926.528 , 81.37513 , "None"));
Path.Add(new Vector3(-1140.284 , 1929.701 , 81.4113 , "None"));
Path.Add(new Vector3(-1141.844 , 1932.841 , 81.40976 , "None"));
Path.Add(new Vector3(-1144.003 , 1935.592 , 81.40976 , "None"));
Path.Add(new Vector3(-1146.95 , 1937.75 , 81.40643 , "None"));
Path.Add(new Vector3(-1149.838 , 1939.64 , 81.40501 , "None"));
Path.Add(new Vector3(-1152.299 , 1941.713 , 81.40593 , "None"));
Path.Add(new Vector3(-1149.454 , 1945.469 , 81.42957 , "None"));
Path.Add(new Vector3(-1147.023 , 1948.205 , 81.42957 , "None"));
Path.Add(new Vector3(-1144.796 , 1950.887 , 81.354 , "None"));
Path.Add(new Vector3(-1142.34 , 1953.589 , 80.79771 , "None"));
Path.Add(new Vector3(-1139.414 , 1955.622 , 79.50656 , "None"));
Path.Add(new Vector3(-1137.431 , 1957.241 , 78.89087 , "None"));
Path.Add(new Vector3(-1135.924 , 1960.181 , 78.00232 , "None"));
Path.Add(new Vector3(-1134.323 , 1962.824 , 76.26445 , "None"));
Path.Add(new Vector3(-1132.311 , 1965.766 , 74.90637 , "None"));
Path.Add(new Vector3(-1130.052 , 1967.622 , 74.42984 , "None"));
Path.Add(new Vector3(-1126.488 , 1969.397 , 73.54454 , "None"));
Path.Add(new Vector3(-1123.485 , 1971.192 , 73.56084 , "None"));
Path.Add(new Vector3(-1120.825 , 1973.396 , 73.35487 , "None"));
Path.Add(new Vector3(-1118.666 , 1976.339 , 72.84236 , "None"));
Path.Add(new Vector3(-1116.222 , 1978.947 , 72.11092 , "None"));
Path.Add(new Vector3(-1113.747 , 1981.027 , 71.35818 , "None"));
Path.Add(new Vector3(-1110.885 , 1983.276 , 70.40795 , "None"));
Path.Add(new Vector3(-1107.902 , 1985.54 , 69.43245 , "None"));
Path.Add(new Vector3(-1104.721 , 1986.594 , 68.59103 , "None"));
Path.Add(new Vector3(-1101.279 , 1987.841 , 67.78389 , "None"));
Path.Add(new Vector3(-1097.806 , 1987.995 , 67.62179 , "None"));
Path.Add(new Vector3(-1094.556 , 1986.478 , 67.94554 , "None"));
Path.Add(new Vector3(-1091.846 , 1984.107 , 68.65363 , "None"));
Path.Add(new Vector3(-1089.387 , 1981.598 , 69.79044 , "None"));
Path.Add(new Vector3(-1086.273 , 1980.019 , 70.94508 , "None"));
Path.Add(new Vector3(-1082.834 , 1979.301 , 71.78127 , "None"));
Path.Add(new Vector3(-1079.426 , 1978.202 , 72.71769 , "None"));
Path.Add(new Vector3(-1076.459 , 1977.014 , 73.58479 , "None"));
Path.Add(new Vector3(-1072.898 , 1976.955 , 73.65976 , "None"));
Path.Add(new Vector3(-1069.359 , 1977.11 , 73.19946 , "None"));
Path.Add(new Vector3(-1065.904 , 1977.26 , 72.66994 , "None"));
Path.Add(new Vector3(-1062.433 , 1977.494 , 73.00809 , "None"));
Path.Add(new Vector3(-1058.665 , 1977.627 , 72.62567 , "None"));
Path.Add(new Vector3(-1055.693 , 1976.182 , 72.58907 , "None"));
Path.Add(new Vector3(-1052.406 , 1974.404 , 72.59933 , "None"));
Path.Add(new Vector3(-1049.687 , 1972.457 , 73.99659 , "None"));
Path.Add(new Vector3(-1046.646 , 1970.663 , 74.2793 , "None"));
Path.Add(new Vector3(-1044.064 , 1968.905 , 74.12767 , "None"));
Path.Add(new Vector3(-1041.735 , 1965.967 , 75.13235 , "None"));
Path.Add(new Vector3(-1039.044 , 1963.794 , 76.37233 , "None"));
Path.Add(new Vector3(-1035.961 , 1962.267 , 77.20507 , "None"));
Path.Add(new Vector3(-1032.448 , 1961.547 , 77.01952 , "None"));
Path.Add(new Vector3(-1028.881 , 1961.068 , 74.96831 , "None"));
Path.Add(new Vector3(-1025.213 , 1961.044 , 73.27727 , "None"));
Path.Add(new Vector3(-1022.318 , 1960.136 , 72.18244 , "None"));
Path.Add(new Vector3(-1019.383 , 1957.792 , 72.06033 , "None"));
Path.Add(new Vector3(-1017.018 , 1955.13 , 71.70251 , "None"));
Path.Add(new Vector3(-1014.885 , 1952.277 , 71.95291 , "None"));
Path.Add(new Vector3(-1012.816 , 1949.532 , 72.11932 , "None"));
Path.Add(new Vector3(-1010.901 , 1946.568 , 72.55035 , "None"));
Path.Add(new Vector3(-1009.265 , 1943.297 , 72.98407 , "None"));
Path.Add(new Vector3(-1005.008 , 1937.472 , 73.81101 , "None"));
Path.Add(new Vector3(-1001.583 , 1932.643 , 75.28104 , "None"));
Path.Add(new Vector3(-1000.272 , 1930.742 , 76.32945 , "None"));
Path.Add(new Vector3(-997.5191 , 1926.595 , 78.05956 , "None"));
Path.Add(new Vector3(-994.6687 , 1923.454 , 78.47318 , "None"));
Path.Add(new Vector3(-992.2061 , 1920.45 , 79.01376 , "None"));
Path.Add(new Vector3(-990.1866 , 1917.713 , 80.10944 , "None"));
Path.Add(new Vector3(-988.4282 , 1916.01 , 80.86092 , "None"));
Path.Add(new Vector3(-985.9377 , 1914.528 , 81.39594 , "None"));
Path.Add(new Vector3(-980.8398 , 1911.22 , 82.04868 , "None"));
Path.Add(new Vector3(-977.4653 , 1910.055 , 81.56016 , "None"));
Path.Add(new Vector3(-973.9125 , 1908.552 , 80.90994 , "None"));
Path.Add(new Vector3(-970.8718 , 1906.61 , 80.55629 , "None"));
Path.Add(new Vector3(-964.6503 , 1902.288 , 79.78687 , "None"));
Path.Add(new Vector3(-961.5217 , 1900.6 , 79.22712 , "None"));
Path.Add(new Vector3(-954.7691 , 1897.358 , 78.39816 , "None"));
Path.Add(new Vector3(-951.3024 , 1897.668 , 77.26763 , "None"));
Path.Add(new Vector3(-941.2367 , 1901.093 , 73.56858 , "None"));
Path.Add(new Vector3(-933.3488 , 1901.944 , 72.44833 , "None"));
Path.Add(new Vector3(-923.6227 , 1907.184 , 69.66949 , "None"));
Path.Add(new Vector3(-913.4261 , 1909.686 , 68.24292 , "None"));
Path.Add(new Vector3(-903.2606 , 1908.596 , 67.62134 , "None"));
Path.Add(new Vector3(-893.0092 , 1906.824 , 67.16231 , "None"));
Path.Add(new Vector3(-883.3696 , 1902.7 , 67.17185 , "None"));
Path.Add(new Vector3(-877.5045 , 1898.816 , 67.23642 , "None"));
Path.Add(new Vector3(-868.5681 , 1893.06 , 67.1376 , "None"));
Path.Add(new Vector3(-858.8748 , 1887.902 , 67.10889 , "None"));
Path.Add(new Vector3(-849.3027 , 1883.486 , 66.57748 , "None"));
Path.Add(new Vector3(-839.5595 , 1879.414 , 64.84293 , "None"));
Path.Add(new Vector3(-835.3856 , 1877.866 , 64.35454 , "None"));
Path.Add(new Vector3(-813.5104 , 1869.935 , 66.40752 , "None"));
Path.Add(new Vector3(-793.4459 , 1864.403 , 68.53728 , "None"));
Path.Add(new Vector3(-772.1439 , 1866.752 , 67.18309 , "None"));
Path.Add(new Vector3(-752.2311 , 1875.752 , 64.98413 , "None"));
Path.Add(new Vector3(-736.4116 , 1873.835 , 62.58867 , "None"));
Path.Add(new Vector3(-715.4242 , 1872.004 , 62.91 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class ReturntoHonorHold : QuestClass
{
    public ReturntoHonorHold()
    {
        Name = "Return to Honor Hold";

        QuestId.AddRange(new[] { 10903 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10485;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LookingtotheLeadership : QuestGrinderClass
{
    public LookingtotheLeadership()
    {
        Name = "Looking to the Leadership";

        QuestId.AddRange(new[] { 10057 });

        Step = new List<int> { 1, 1, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10050;

        EntryTarget.Add(16977);
EntryTarget.Add(16978);
HotSpots.Add(new Vector3(-1314.18 , 2767.449 , -27.20556 , "None"));
HotSpots.Add(new Vector3(-1394.766 , 2710.156 , -25.91846 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThePoolsofAggonar : QuestGrinderClass
{
    public ThePoolsofAggonar()
    {
        Name = "The Pools of Aggonar";

        QuestId.AddRange(new[] { 9426 });

        Step = new List<int> { 6, 6, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(16951);
EntryTarget.Add(16901);
EntryTarget.Add(16903);
HotSpots.Add(new Vector3(-20.33588 , 3558.152 , 64.22555 , "None"));
HotSpots.Add(new Vector3(-15.74171 , 3498.982 , 62.28077 , "None"));
HotSpots.Add(new Vector3(111.6307 , 3611.842 , 73.34884 , "None"));
HotSpots.Add(new Vector3(209.6027 , 3423.275 , 68.66758 , "None"));
HotSpots.Add(new Vector3(307.7824 , 3417.08 , 70.09772 , "None"));
HotSpots.Add(new Vector3(351.7347 , 3410.229 , 63.01223 , "None"));
HotSpots.Add(new Vector3(367.2206 , 3364.965 , 63.98885 , "None"));
HotSpots.Add(new Vector3(273.9204 , 3458.352 , 62.82228 , "None"));
HotSpots.Add(new Vector3(168.8713 , 3531.009 , 63.08386 , "None"));
HotSpots.Add(new Vector3(128.0186 , 3591.276 , 66.7804 , "None"));
HotSpots.Add(new Vector3(-23.11177 , 3524.426 , 62.68824 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KILL6062HellfirePen1SouthofTempleofTelhamat : QuestGrinderClass
{
    public KILL6062HellfirePen1SouthofTempleofTelhamat()
    {
        Name = "KILL: 60-62 - Hellfire Pen 1 - South of Temple of Telhamat";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(16880);
EntryTarget.Add(16973);
EntryTarget.Add(19189);
EntryTarget.Add(16927);
EntryTarget.Add(16968);
EntryTarget.Add(16863);
HotSpots.Add(new Vector3(-277.1312 , 4307.639 , 79.90482 , "None"));
HotSpots.Add(new Vector3(-274.7803 , 4445.582 , 52.65475 , "None"));
HotSpots.Add(new Vector3(-424.6815 , 4246.749 , 78.34871 , "None"));
HotSpots.Add(new Vector3(-380.6661 , 4629.048 , 32.06873 , "None"));
HotSpots.Add(new Vector3(-456.9772 , 4502.81 , 42.56918 , "None"));
HotSpots.Add(new Vector3(-596.4195 , 4398.62 , 63.93069 , "None"));
HotSpots.Add(new Vector3(-663.7432 , 4356.397 , 61.67895 , "None"));
HotSpots.Add(new Vector3(-823.1623 , 4169.705 , 49.30552 , "None"));
HotSpots.Add(new Vector3(-890.1187 , 4137.917 , 32.97157 , "None"));
HotSpots.Add(new Vector3(-780.9308 , 4078.15 , 32.88121 , "None"));
HotSpots.Add(new Vector3(-643.5316 , 3983.638 , 29.15724 , "None"));
HotSpots.Add(new Vector3(-522.3218 , 4312.375 , 43.20781 , "None"));
HotSpots.Add(new Vector3(-303.7311 , 4370.361 , 62.53074 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 62 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(30) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6062HellfirePen2 : QuestGrinderClass
{
    public KILL6062HellfirePen2()
    {
        Name = "KILL: 60-62 - Hellfire Pen 2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(16880);
EntryTarget.Add(16973);
EntryTarget.Add(16863);
EntryTarget.Add(16927);
EntryTarget.Add(16968);
HotSpots.Add(new Vector3(-32.50663 , 4203.681 , 82.77606 , "None"));
HotSpots.Add(new Vector3(180.6817 , 4144.034 , 70.56198 , "None"));
HotSpots.Add(new Vector3(241.8919 , 3927.398 , 75.15787 , "None"));
HotSpots.Add(new Vector3(1.50563 , 3940.713 , 88.56855 , "None"));
HotSpots.Add(new Vector3(-355.9653 , 4004.819 , 92.38055 , "None"));
HotSpots.Add(new Vector3(-534.0822 , 3791.006 , 28.99524 , "None"));
HotSpots.Add(new Vector3(-673.566 , 4257.172 , 49.16491 , "None"));
HotSpots.Add(new Vector3(-373.8097 , 4425.206 , 52.37553 , "None"));
HotSpots.Add(new Vector3(87.78306 , 4015.132 , 72.86469 , "None"));
HotSpots.Add(new Vector3(150.5817 , 4175.349 , 67.37936 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 62 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(30) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6062Hellfire3NearThrallmar : QuestGrinderClass
{
    public KILL6062Hellfire3NearThrallmar()
    {
        Name = "KILL: 60-62 - Hellfire 3  - Near Thrallmar";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(16857);
EntryTarget.Add(16863);
EntryTarget.Add(16844);
HotSpots.Add(new Vector3(-58.22091 , 2768.112 , 57.58892 , "None"));
HotSpots.Add(new Vector3(-16.62832 , 3068.357 , 0.7052631 , "None"));
HotSpots.Add(new Vector3(108.7319 , 3139.234 , 20.2941 , "None"));
HotSpots.Add(new Vector3(288.0078 , 3087.951 , 26.20271 , "None"));
HotSpots.Add(new Vector3(109.545 , 2907.565 , 34.40145 , "None"));
HotSpots.Add(new Vector3(205.7359 , 3011.07 , -1.222306 , "None"));
HotSpots.Add(new Vector3(454.4467 , 3009.933 , 20.3472 , "None"));
HotSpots.Add(new Vector3(685.274 , 2860.329 , 25.42144 , "None"));
HotSpots.Add(new Vector3(93.34535 , 3006.143 , 14.92075 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 3;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 62 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(30) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6062HellFire4BoarsMiddleofMap : QuestGrinderClass
{
    public KILL6062HellFire4BoarsMiddleofMap()
    {
        Name = "KILL: 60-62 - Hell Fire 4 - Boars Middle of Map";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(16863);
EntryTarget.Add(16857);
EntryTarget.Add(16974);
EntryTarget.Add(16975);
EntryTarget.Add(16844);
EntryTarget.Add(16972);
EntryTarget.Add(16879);
EntryTarget.Add(16904);
EntryTarget.Add(16906);
EntryTarget.Add(16905);
HotSpots.Add(new Vector3(-715.4711 , 2956.669 , 26.79911 , "None"));
HotSpots.Add(new Vector3(-674.5154 , 3152.791 , -5.031823 , "None"));
HotSpots.Add(new Vector3(-847.1377 , 3236.999 , 21.43288 , "None"));
HotSpots.Add(new Vector3(-1321.577 , 3133.159 , 32.69788 , "None"));
HotSpots.Add(new Vector3(-1424.555 , 3048.188 , -7.408852 , "None"));
HotSpots.Add(new Vector3(-1381.026 , 2884.563 , -30.33685 , "None"));
HotSpots.Add(new Vector3(-1046.882 , 2884.045 , -1.19151 , "None"));
HotSpots.Add(new Vector3(-859.5882 , 2917.648 , 8.201855 , "None"));
HotSpots.Add(new Vector3(-849.7471 , 3157.04 , 13.54852 , "None"));
HotSpots.Add(new Vector3(-989.8471 , 2827.584 , -3.731276 , "None"));
HotSpots.Add(new Vector3(-971.8264 , 2594.564 , 7.882215 , "None"));
HotSpots.Add(new Vector3(-1176.913 , 2691.447 , 1.186291 , "None"));
HotSpots.Add(new Vector3(-1338.596 , 2920.667 , -11.57289 , "None"));
HotSpots.Add(new Vector3(-1409.164 , 3169.568 , 20.08543 , "None"));
HotSpots.Add(new Vector3(-811.7375 , 3068.153 , 9.291799 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 4;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 62 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(30) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6062HellfirePen5TunnelersandWhelps : QuestGrinderClass
{
    public KILL6062HellfirePen5TunnelersandWhelps()
    {
        Name = "KILL: 60-62- Hellfire Pen 5 - Tunnelers and Whelps";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(16927);
EntryTarget.Add(16968);
EntryTarget.Add(16929);
EntryTarget.Add(16863);
EntryTarget.Add(16928);
EntryTarget.Add(16973);
EntryTarget.Add(16880);
HotSpots.Add(new Vector3(-636.028 , 3379.322 , 42.48908 , "None"));
HotSpots.Add(new Vector3(-747.863 , 3504.841 , 102.3921 , "None"));
HotSpots.Add(new Vector3(-878.7388 , 3491.484 , 94.16315 , "None"));
HotSpots.Add(new Vector3(-764.801 , 3648.395 , 27.96357 , "None"));
HotSpots.Add(new Vector3(-566.8641 , 3596.439 , 29.33279 , "None"));
HotSpots.Add(new Vector3(-593.7845 , 3867.322 , 28.9978 , "None"));
HotSpots.Add(new Vector3(-432.2839 , 3973.24 , 71.04043 , "None"));
HotSpots.Add(new Vector3(-754.1235 , 4044.878 , 31.66063 , "None"));
HotSpots.Add(new Vector3(-721.3821 , 4249.516 , 49.58536 , "None"));
HotSpots.Add(new Vector3(-877.5677 , 4128.316 , 32.97023 , "None"));
HotSpots.Add(new Vector3(-372.1145 , 4395.093 , 53.73793 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 5;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 62 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(30) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class RavagerEggRoundup : QuestGathererClass
{
    public RavagerEggRoundup()
    {
        Name = "Ravager Egg Roundup";

        QuestId.AddRange(new[] { 9349 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(181385);
HotSpots.Add(new Vector3(-1455.608 , 3410.452 , 33.51141 , "None"));
HotSpots.Add(new Vector3(-1546.524 , 3483.61 , 23.31976 , "None"));
HotSpots.Add(new Vector3(-1560.861 , 3514.43 , 16.48443 , "None"));
HotSpots.Add(new Vector3(-1521.305 , 3578.51 , 41.6765 , "None"));
HotSpots.Add(new Vector3(-1576.999 , 3558.658 , 28.05526 , "None"));
HotSpots.Add(new Vector3(-1572.867 , 3605.724 , 34.15572 , "None"));
HotSpots.Add(new Vector3(-1569.321 , 3643.257 , 35.685 , "None"));
HotSpots.Add(new Vector3(-1584.221 , 3694.849 , 38.34237 , "None"));
HotSpots.Add(new Vector3(-1604.61 , 3746.449 , 40.98629 , "None"));
HotSpots.Add(new Vector3(-1682.524 , 3774.998 , 36.5693 , "None"));
HotSpots.Add(new Vector3(-1611.52 , 3791.209 , 42.25917 , "None"));
HotSpots.Add(new Vector3(-1609.037 , 3820.027 , 45.179 , "None"));
HotSpots.Add(new Vector3(-1625.583 , 3820.929 , 42.71371 , "None"));
HotSpots.Add(new Vector3(-1678.297 , 3826.537 , 33.38313 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class InCaseofEmergency : QuestGathererClass
{
    public InCaseofEmergency()
    {
        Name = "In Case of Emergency...";

        QuestId.AddRange(new[] { 10161 });

        Step = new List<int> { 30, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(183397);
EntryIdObjects.Add(183396);
EntryIdObjects.Add(183394);
EntryIdObjects.Add(183395);
HotSpots.Add(new Vector3(-1094.261 , 2922.66 , -1.662445 , "None"));
HotSpots.Add(new Vector3(-1071.303 , 2829.446 , -19.18965 , "None"));
HotSpots.Add(new Vector3(-1018.003 , 2616.453 , -9.267274 , "None"));
HotSpots.Add(new Vector3(-1049.974 , 2682.054 , -0.4358966 , "None"));
HotSpots.Add(new Vector3(-1050.473 , 2515.162 , 14.54595 , "None"));
HotSpots.Add(new Vector3(-1122.356 , 2373.681 , 26.98666 , "None"));
HotSpots.Add(new Vector3(-1063.304 , 2311.869 , 16.84436 , "None"));
HotSpots.Add(new Vector3(-907.0074 , 2214.274 , 9.346263 , "None"));
HotSpots.Add(new Vector3(-741.8365 , 2198.526 , 14.69799 , "None"));
HotSpots.Add(new Vector3(-919.6682 , 2445.153 , 1.890095 , "None"));
HotSpots.Add(new Vector3(-840.1031 , 2202.761 , 7.836483 , "None"));
HotSpots.Add(new Vector3(-1106.432 , 2423.319 , 26.73304 , "None"));
HotSpots.Add(new Vector3(-912.3492 , 2459.53 , 2.138414 , "None"));
HotSpots.Add(new Vector3(-994.7515 , 2601.349 , 4.47933 , "None"));
HotSpots.Add(new Vector3(-1046.482 , 2828.563 , -19.73326 , "None"));
HotSpots.Add(new Vector3(-1088.906 , 2922.096 , -1.596447 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class VoidwalkersGoneWild : QuestGrinderClass
{
    public VoidwalkersGoneWild()
    {
        Name = "Voidwalkers Gone Wild";

        QuestId.AddRange(new[] { 9351 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10161;

        EntryTarget.Add(16974);
EntryTarget.Add(16975);
HotSpots.Add(new Vector3(-1346.655 , 3054.954 , 16.68473 , "None"));
HotSpots.Add(new Vector3(-1359.392 , 2930.619 , -11.85661 , "None"));
HotSpots.Add(new Vector3(-1421.532 , 3055.26 , -4.372748 , "None"));
HotSpots.Add(new Vector3(-1433.32 , 3150.465 , 9.431623 , "None"));
HotSpots.Add(new Vector3(-1372.915 , 3178.116 , 30.64309 , "None"));
HotSpots.Add(new Vector3(-1327.027 , 3256.617 , 47.08298 , "None"));
HotSpots.Add(new Vector3(-1448.796 , 3302.122 , 20.50186 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HelboartheOtherWhiteMeat : QuestUseItemOnClass
{
    public HelboartheOtherWhiteMeat()
    {
        Name = "Helboar, the Other White Meat";

        QuestId.AddRange(new[] { 9361 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(16863);
HotSpots.Add(new Vector3(-1236.667 , 3058.257 , 26.28061 , "None"));
HotSpots.Add(new Vector3(-1069.954 , 3057.982 , 20.34836 , "None"));
HotSpots.Add(new Vector3(-984.0333 , 3264.721 , 54.48121 , "None"));
HotSpots.Add(new Vector3(-701.1564 , 2973.555 , 28.06458 , "None"));
HotSpots.Add(new Vector3(-870.1315 , 2872.567 , 8.713823 , "None"));
HotSpots.Add(new Vector3(-977.9313 , 2778.432 , 3.489233 , "None"));
HotSpots.Add(new Vector3(-1053.768 , 2908.404 , -0.5467742 , "None"));
HotSpots.Add(new Vector3(-935.2894 , 3101.172 , 17.8803 , "None"));
ItemId = 23268;
Range = 23.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(23248) >= 8;
}






}


public sealed class SmoothasButter : QuestGrinderClass
{
    public SmoothasButter()
    {
        Name = "Smooth as Butter";

        QuestId.AddRange(new[] { 9356 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9361;

        EntryTarget.Add(16972);
HotSpots.Add(new Vector3(-973.1017 , 2611.5 , 9.186933 , "None"));
HotSpots.Add(new Vector3(-842.3029 , 2519.854 , 26.18752 , "None"));
HotSpots.Add(new Vector3(-854.3795 , 2410.052 , 3.326046 , "None"));
HotSpots.Add(new Vector3(-819.5807 , 2365.611 , 6.97955 , "None"));
HotSpots.Add(new Vector3(-761.1035 , 2327.056 , 14.59496 , "None"));
HotSpots.Add(new Vector3(-780.8102 , 2238.128 , 10.05048 , "None"));
HotSpots.Add(new Vector3(-896.6701 , 2264.811 , 1.93643 , "None"));
HotSpots.Add(new Vector3(-936.6068 , 2377.08 , -2.661159 , "None"));
HotSpots.Add(new Vector3(-942.9924 , 2512.885 , 5.959702 , "None"));
HotSpots.Add(new Vector3(-988.7732 , 2635.641 , 8.565222 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class OutlandSucks : QuestGathererClass
{
    public OutlandSucks()
    {
        Name = "Outland Sucks!";

        QuestId.AddRange(new[] { 10236 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(183934);
HotSpots.Add(new Vector3(21.07561 , 3070.422 , -0.6484903 , "None"));
HotSpots.Add(new Vector3(-17.74 , 3095.42 , -0.08009131 , "None"));
HotSpots.Add(new Vector3(10.5839 , 3179.182 , 9.36633 , "None"));
HotSpots.Add(new Vector3(187.2631 , 3005.086 , -1.172004 , "None"));
HotSpots.Add(new Vector3(11.71231 , 3077.561 , -1.222276 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HowtoServeGoblins : QuestInteractWithClass
{
    public HowtoServeGoblins()
    {
        Name = "How to Serve Goblins";

        QuestId.AddRange(new[] { 10238 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10236;

        EntryIdTarget.Add(183936);
EntryIdTarget.Add(183940);
EntryIdTarget.Add(183941);
HotSpots.Add(new Vector3(67.98765 , 3209.704 , 32.08345 , "None"));
HotSpots.Add(new Vector3(-74.65635 , 3138.673 , -4.12923 , "None"));
HotSpots.Add(new Vector3(-122.7457 , 3086.803 , 2.952128 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "";
IgnoreIfDead = true;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HowtoServeGoblinsSaveManni : QuestInteractWithClass
{
    public HowtoServeGoblinsSaveManni()
    {
        Name = "How to Serve Goblins - Save Manni";

        QuestId.AddRange(new[] { 10238 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10236;

        EntryIdTarget.Add(183936);
HotSpots.Add(new Vector3(67.98765 , 3209.704 , 32.08345 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "";
IgnoreIfDead = true;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HowtoServeGoblinsSaveMoh : QuestInteractWithClass
{
    public HowtoServeGoblinsSaveMoh()
    {
        Name = "How to Serve Goblins - Save Moh";

        QuestId.AddRange(new[] { 10238 });

        Step = new List<int> { 0, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10236;

        EntryIdTarget.Add(183940);
HotSpots.Add(new Vector3(-74.47505 , 3139.333 , -4.150588 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "";
IgnoreIfDead = true;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNRuntoManni : QuestFollowPathClass
{
    public RUNRuntoManni()
    {
        Name = "RUN: Run to Manni";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(106.2843 , 3112.519 , 14.7315 , "None"));
Path.Add(new Vector3(103.6987 , 3120.585 , 15.8982 , "None"));
Path.Add(new Vector3(92.94568 , 3156.236 , 20.12931 , "None"));
Path.Add(new Vector3(83.02779 , 3188.567 , 26.21847 , "None"));
Path.Add(new Vector3(75.90488 , 3211.595 , 32.37797 , "None"));
Path.Add(new Vector3(72.36614 , 3209.991 , 32.28346 , "None"));
Path.Add(new Vector3(70.67872 , 3209.291 , 32.11757 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNRuntoMohtoSave : QuestFollowPathClass
{
    public RUNRuntoMohtoSave()
    {
        Name = "RUN: Run to Moh to Save";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(80.34532 , 3183.325 , 24.01931 , "None"));
Path.Add(new Vector3(79.5951 , 3178.766 , 22.35424 , "None"));
Path.Add(new Vector3(68.49952 , 3129.479 , 11.63268 , "None"));
Path.Add(new Vector3(66.4649 , 3125.869 , 10.72053 , "None"));
Path.Add(new Vector3(59.72765 , 3117.914 , 4.358121 , "None"));
Path.Add(new Vector3(50.50202 , 3114.426 , -0.01240323 , "None"));
Path.Add(new Vector3(39.1723 , 3115.467 , -1.196601 , "None"));
Path.Add(new Vector3(28.88629 , 3117.897 , -1.221443 , "None"));
Path.Add(new Vector3(19.07227 , 3119.56 , -1.221443 , "None"));
Path.Add(new Vector3(8.396978 , 3121.292 , -1.221443 , "None"));
Path.Add(new Vector3(-1.805452 , 3123.729 , -1.221443 , "None"));
Path.Add(new Vector3(-11.16344 , 3129.312 , -1.221443 , "None"));
Path.Add(new Vector3(-19.66954 , 3135.503 , -1.221443 , "None"));
Path.Add(new Vector3(-26.38357 , 3140.445 , -1.221443 , "None"));
Path.Add(new Vector3(-31.34371 , 3143.847 , -1.222983 , "None"));
Path.Add(new Vector3(-37.41936 , 3149.919 , -1.563003 , "None"));
Path.Add(new Vector3(-41.76137 , 3154.148 , -2.489015 , "None"));
Path.Add(new Vector3(-46.60404 , 3155.479 , -2.87967 , "None"));
Path.Add(new Vector3(-47.39195 , 3151.743 , -3.16952 , "None"));
Path.Add(new Vector3(-46.38327 , 3148.341 , -3.108142 , "None"));
Path.Add(new Vector3(-44.11506 , 3141.35 , -2.294415 , "None"));
Path.Add(new Vector3(-39.64242 , 3133.049 , -1.587121 , "None"));
Path.Add(new Vector3(-41.09841 , 3122.916 , -1.671647 , "None"));
Path.Add(new Vector3(-42.90614 , 3116.448 , -1.880998 , "None"));
Path.Add(new Vector3(-47.02754 , 3117.828 , -2.059279 , "None"));
Path.Add(new Vector3(-50.71134 , 3121.357 , -2.263345 , "None"));
Path.Add(new Vector3(-53.78537 , 3124.46 , -2.577014 , "None"));
Path.Add(new Vector3(-56.94807 , 3127.653 , -3.057312 , "None"));
Path.Add(new Vector3(-58.32521 , 3133.901 , -3.750409 , "None"));
Path.Add(new Vector3(-60.58249 , 3138.985 , -4.340767 , "None"));
Path.Add(new Vector3(-70.64138 , 3137.72 , -4.609508 , "None"));
Path.Add(new Vector3(-75.16462 , 3137.808 , -4.057017 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNSavetheLaseNoob : QuestFollowPathClass
{
    public RUNSavetheLaseNoob()
    {
        Name = "RUN: Save the Lase Noob";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-63.01663 , 3134.64 , -4.352776 , "None"));
Path.Add(new Vector3(-53.9234 , 3126.347 , -2.68512 , "None"));
Path.Add(new Vector3(-48.24984 , 3117.968 , -2.117897 , "None"));
Path.Add(new Vector3(-44.40353 , 3107.494 , -2.17754 , "None"));
Path.Add(new Vector3(-48.40741 , 3097.89 , -2.291702 , "None"));
Path.Add(new Vector3(-54.31552 , 3090.01 , -2.091645 , "None"));
Path.Add(new Vector3(-60.68345 , 3081.516 , -1.682909 , "None"));
Path.Add(new Vector3(-67.83109 , 3072.427 , -1.062427 , "None"));
Path.Add(new Vector3(-69.52013 , 3067.228 , -0.4860832 , "None"));
Path.Add(new Vector3(-71.94756 , 3056.966 , 0.8302111 , "None"));
Path.Add(new Vector3(-75.52511 , 3046.962 , 2.155189 , "None"));
Path.Add(new Vector3(-83.78245 , 3041.871 , 2.334823 , "None"));
Path.Add(new Vector3(-93.53664 , 3045.324 , 1.046315 , "None"));
Path.Add(new Vector3(-101.0501 , 3051.285 , -0.8525941 , "None"));
Path.Add(new Vector3(-109.067 , 3058.246 , -1.373536 , "None"));
Path.Add(new Vector3(-114.6263 , 3064.88 , -0.4068623 , "None"));
Path.Add(new Vector3(-117.0408 , 3069.456 , 0.2020745 , "None"));
Path.Add(new Vector3(-119.1264 , 3074.85 , 0.9459753 , "None"));
Path.Add(new Vector3(-120.5398 , 3080.134 , 1.668292 , "None"));
Path.Add(new Vector3(-121.1946 , 3083.686 , 2.340889 , "None"));
Path.Add(new Vector3(-121.8389 , 3088.43 , 3.320305 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class ShizzWork : QuestGathererClass
{
    public ShizzWork()
    {
        Name = "Shizz Work";

        QuestId.AddRange(new[] { 10629 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10238;

        EntryIdObjects.Add(184980);
HotSpots.Add(new Vector3(338.771 , 3063.353 , 23.8546 , "None"));
HotSpots.Add(new Vector3(270.6382 , 3081.915 , 23.61083 , "None"));
HotSpots.Add(new Vector3(207.7607 , 3092.925 , 19.47908 , "None"));
HotSpots.Add(new Vector3(115.9704 , 3136.659 , 21.18881 , "None"));
HotSpots.Add(new Vector3(81.66518 , 2949.631 , 24.5079 , "None"));
HotSpots.Add(new Vector3(114.2739 , 2907.748 , 34.34176 , "None"));
HotSpots.Add(new Vector3(166.5392 , 2942.346 , 24.39788 , "None"));
HotSpots.Add(new Vector3(416.2396 , 3010.927 , 19.5979 , "None"));
HotSpots.Add(new Vector3(445.0389 , 2991.511 , 22.27855 , "None"));
HotSpots.Add(new Vector3(450.4939 , 3043.317 , 16.59558 , "None"));
HotSpots.Add(new Vector3(506.2348 , 2955.376 , 31.16408 , "None"));
HotSpots.Add(new Vector3(526.5905 , 2952.957 , 26.15767 , "None"));
HotSpots.Add(new Vector3(679.9628 , 2873.117 , 24.43611 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BeneathThrallmar : QuestGrinderClass
{
    public BeneathThrallmar()
    {
        Name = "Beneath Thrallmar";

        QuestId.AddRange(new[] { 10630 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10629;

        EntryTarget.Add(18976);
EntryTarget.Add(19408);
EntryTarget.Add(18827);
HotSpots.Add(new Vector3(388.1284 , 2753.337 , 51.90135 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HelpingtheCenarionPost : QuestClass
{
    public HelpingtheCenarionPost()
    {
        Name = "Helping the Cenarion Post";

        QuestId.AddRange(new[] { 10443 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DeadlyPredators : QuestGrinderClass
{
    public DeadlyPredators()
    {
        Name = "Deadly Predators";

        QuestId.AddRange(new[] { 9398 });

        Step = new List<int> { 4, 8, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(16927);
EntryTarget.Add(16929);
HotSpots.Add(new Vector3(-792.5066 , 3532.541 , 109.9907 , "None"));
HotSpots.Add(new Vector3(-755.8644 , 3645.441 , 28.26377 , "None"));
HotSpots.Add(new Vector3(-656.4313 , 3648.215 , 31.98525 , "None"));
HotSpots.Add(new Vector3(-560.4005 , 3636.377 , 28.99643 , "None"));
HotSpots.Add(new Vector3(-560.8325 , 3715.248 , 29.92422 , "None"));
HotSpots.Add(new Vector3(-612.7559 , 3765.499 , 30.74393 , "None"));
HotSpots.Add(new Vector3(-588.0547 , 3873.306 , 30.66096 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CruelTaskmasters : QuestGrinderClass
{
    public CruelTaskmasters()
    {
        Name = "Cruel Taskmasters";

        QuestId.AddRange(new[] { 9399 });

        Step = new List<int> { 4, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class InSearchofSedai : QuestClass
{
    public InSearchofSedai()
    {
        Name = "In Search of Sedai";

        QuestId.AddRange(new[] { 9390 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReturntoObadei : QuestClass
{
    public ReturntoObadei()
    {
        Name = "Return to Obadei";

        QuestId.AddRange(new[] { 9423 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9390;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MakurusVengeance : QuestGrinderClass
{
    public MakurusVengeance()
    {
        Name = "Makuru's Vengeance";

        QuestId.AddRange(new[] { 9424 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9423;

        EntryTarget.Add(16846);
EntryTarget.Add(16847);
HotSpots.Add(new Vector3(354.1272 , 3886.753 , 141.064 , "None"));
HotSpots.Add(new Vector3(170.3703 , 3748.27 , 189.5671 , "None"));
HotSpots.Add(new Vector3(415.7233 , 3699.148 , 180.4771 , "None"));
HotSpots.Add(new Vector3(362.9556 , 3752.843 , 195.9993 , "None"));
HotSpots.Add(new Vector3(463.913 , 3783.373 , 186.2616 , "None"));
HotSpots.Add(new Vector3(517.3854 , 3702.356 , 187.6241 , "None"));
HotSpots.Add(new Vector3(421.8658 , 3690.451 , 184.0242 , "None"));
HotSpots.Add(new Vector3(314.296 , 3658.146 , 184.2395 , "None"));
HotSpots.Add(new Vector3(286.0652 , 3675.549 , 183.8738 , "None"));
HotSpots.Add(new Vector3(532.0543 , 3666.527 , 192.9304 , "None"));
HotSpots.Add(new Vector3(438.2313 , 3667.624 , 187.9326 , "None"));
HotSpots.Add(new Vector3(314.1796 , 3658.265 , 184.2378 , "None"));
HotSpots.Add(new Vector3(311.3244 , 3652.537 , 191.5306 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Atonement : QuestClass
{
    public Atonement()
    {
        Name = "Atonement";

        QuestId.AddRange(new[] { 9543 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9424;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ShanaarRelics : QuestGathererClass
{
    public ShanaarRelics()
    {
        Name = "Sha'naar Relics";

        QuestId.AddRange(new[] { 9430 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9543;

        EntryIdObjects.Add(181637);
HotSpots.Add(new Vector3(-507.1552 , 4907.694 , 36.57889 , "None"));
HotSpots.Add(new Vector3(-533.2131 , 4904.869 , 38.22971 , "None"));
HotSpots.Add(new Vector3(-457.8026 , 4678.967 , 30.28592 , "None"));
HotSpots.Add(new Vector3(-508.6087 , 4726.186 , 32.59084 , "None"));
HotSpots.Add(new Vector3(-561.3837 , 4742.697 , 37.15208 , "None"));
HotSpots.Add(new Vector3(-617.5938 , 4786.891 , 39.28044 , "None"));
HotSpots.Add(new Vector3(-621.1963 , 4828.575 , 40.17253 , "None"));
HotSpots.Add(new Vector3(-570.5828 , 4849.229 , 39.30316 , "None"));
HotSpots.Add(new Vector3(-570.7385 , 4788.681 , 35.48105 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CleansingtheWaters : QuestUseItemOnClass
{
    public CleansingtheWaters()
    {
        Name = "Cleansing the Waters";

        QuestId.AddRange(new[] { 9427 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9426;

        EntryIdTarget.Add(300069);
HotSpots.Add(new Vector3(432.5348 , 3454.321 , 63.26646 , "None"));
ItemId = 23361;
Range = 14.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNToCleansingWaters : QuestFollowPathClass
{
    public RUNToCleansingWaters()
    {
        Name = "RUN ; To Cleansing Waters";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-46.55948 , 3574.291 , 73.66064 , "None"));
Path.Add(new Vector3(-29.28511 , 3576.028 , 74.32826 , "None"));
Path.Add(new Vector3(-33.45523 , 3568.798 , 71.67303 , "None"));
Path.Add(new Vector3(-24.94728 , 3562.247 , 67.41271 , "None"));
Path.Add(new Vector3(-8.235818 , 3562.889 , 64.84046 , "None"));
Path.Add(new Vector3(0.4816897 , 3568.677 , 64.50159 , "None"));
Path.Add(new Vector3(9.018086 , 3574.725 , 64.51553 , "None"));
Path.Add(new Vector3(19.52184 , 3578.212 , 65.59329 , "None"));
Path.Add(new Vector3(29.6826 , 3580.751 , 66.59331 , "None"));
Path.Add(new Vector3(39.33788 , 3585.182 , 68.67752 , "None"));
Path.Add(new Vector3(49.10086 , 3589.883 , 69.42587 , "None"));
Path.Add(new Vector3(58.56113 , 3594.439 , 70.46941 , "None"));
Path.Add(new Vector3(68.17417 , 3598.649 , 71.61049 , "None"));
Path.Add(new Vector3(77.88113 , 3603.403 , 72.47323 , "None"));
Path.Add(new Vector3(87.178 , 3608.272 , 73.01543 , "None"));
Path.Add(new Vector3(96.76695 , 3612.492 , 74.15128 , "None"));
Path.Add(new Vector3(106.586 , 3617.12 , 75.34601 , "None"));
Path.Add(new Vector3(117.2473 , 3617.799 , 75.33229 , "None"));
Path.Add(new Vector3(126.1844 , 3612.679 , 73.06339 , "None"));
Path.Add(new Vector3(133.5661 , 3604.739 , 71.26396 , "None"));
Path.Add(new Vector3(138.6051 , 3596.498 , 70.34423 , "None"));
Path.Add(new Vector3(146.1011 , 3588.916 , 70.51349 , "None"));
Path.Add(new Vector3(152.5476 , 3580.61 , 70.66013 , "None"));
Path.Add(new Vector3(156.3397 , 3570.657 , 70.24229 , "None"));
Path.Add(new Vector3(159.0592 , 3560.536 , 69.99854 , "None"));
Path.Add(new Vector3(164.5249 , 3551.234 , 70.19016 , "None"));
Path.Add(new Vector3(171.3902 , 3543.298 , 69.29704 , "None"));
Path.Add(new Vector3(178.7344 , 3535.561 , 65.31055 , "None"));
Path.Add(new Vector3(188.5268 , 3532.937 , 66.10838 , "None"));
Path.Add(new Vector3(197.6916 , 3528.819 , 67.13558 , "None"));
Path.Add(new Vector3(207.4919 , 3525.324 , 67.9099 , "None"));
Path.Add(new Vector3(217.9113 , 3527.475 , 65.9566 , "None"));
Path.Add(new Vector3(224.5536 , 3535.399 , 68.12775 , "None"));
Path.Add(new Vector3(230.9913 , 3543.378 , 69.8935 , "None"));
Path.Add(new Vector3(239.4473 , 3550.154 , 72.02104 , "None"));
Path.Add(new Vector3(248.4515 , 3555.47 , 73.91624 , "None"));
Path.Add(new Vector3(258.7816 , 3554.277 , 73.5937 , "None"));
Path.Add(new Vector3(266.5594 , 3546.98 , 71.81976 , "None"));
Path.Add(new Vector3(271.3893 , 3537.696 , 69.54691 , "None"));
Path.Add(new Vector3(273.0048 , 3526.97 , 67.15826 , "None"));
Path.Add(new Vector3(274.0142 , 3516.523 , 65.69453 , "None"));
Path.Add(new Vector3(276.4362 , 3506.299 , 65.26987 , "None"));
Path.Add(new Vector3(285.3795 , 3501.206 , 67.08356 , "None"));
Path.Add(new Vector3(296.0057 , 3499.615 , 68.48109 , "None"));
Path.Add(new Vector3(306.4464 , 3500.666 , 67.3623 , "None"));
Path.Add(new Vector3(317.1988 , 3502.163 , 65.66186 , "None"));
Path.Add(new Vector3(327.162 , 3504.771 , 65.55595 , "None"));
Path.Add(new Vector3(335.7603 , 3510.78 , 67.18171 , "None"));
Path.Add(new Vector3(342.9391 , 3518.41 , 69.15484 , "None"));
Path.Add(new Vector3(352.87 , 3522.396 , 69.77232 , "None"));
Path.Add(new Vector3(363.0739 , 3524.871 , 68.72803 , "None"));
Path.Add(new Vector3(365.6072 , 3517.017 , 64.97881 , "None"));
Path.Add(new Vector3(366.7392 , 3508.117 , 62.86892 , "None"));
Path.Add(new Vector3(381.5319 , 3500.5 , 61.78895 , "None"));
Path.Add(new Vector3(387.8726 , 3492.652 , 61.86802 , "None"));
Path.Add(new Vector3(402.6679 , 3481.305 , 60.37368 , "None"));
Path.Add(new Vector3(410.843 , 3474.525 , 62.28724 , "None"));
Path.Add(new Vector3(418.5783 , 3467.456 , 63.23126 , "None"));
Path.Add(new Vector3(421.6638 , 3454.718 , 63.39429 , "None"));
Path.Add(new Vector3(421.5031 , 3445.805 , 62.86003 , "None"));
Path.Add(new Vector3(417.8448 , 3434.808 , 60.32996 , "None"));
Path.Add(new Vector3(432.6941 , 3453.434 , 63.27868 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNCleansingWatersBACKTOTURNIN : QuestFollowPathClass
{
    public RUNCleansingWatersBACKTOTURNIN()
    {
        Name = "RUN: Cleansing Waters - BACK TO TURN IN";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(421.1904 , 3468.469 , 62.98632 , "None"));
Path.Add(new Vector3(410.1607 , 3482.094 , 61.08426 , "None"));
Path.Add(new Vector3(401.8205 , 3489.042 , 60.89227 , "None"));
Path.Add(new Vector3(393.5865 , 3495.625 , 62.9606 , "None"));
Path.Add(new Vector3(384.7672 , 3501.847 , 62.94167 , "None"));
Path.Add(new Vector3(376.2803 , 3508.065 , 62.69699 , "None"));
Path.Add(new Vector3(369.3179 , 3513.167 , 63.51823 , "None"));
Path.Add(new Vector3(360.6784 , 3519.081 , 66.77715 , "None"));
Path.Add(new Vector3(350.5367 , 3521.397 , 69.63069 , "None"));
Path.Add(new Vector3(341.4388 , 3516.34 , 68.57522 , "None"));
Path.Add(new Vector3(333.0311 , 3509.512 , 66.9638 , "None"));
Path.Add(new Vector3(325.2026 , 3502.516 , 65.06309 , "None"));
Path.Add(new Vector3(315.302 , 3498.3 , 64.79305 , "None"));
Path.Add(new Vector3(305.0026 , 3496.569 , 65.61961 , "None"));
Path.Add(new Vector3(294.151 , 3496.17 , 66.73286 , "None"));
Path.Add(new Vector3(280.479 , 3504.15 , 65.8462 , "None"));
Path.Add(new Vector3(274.8345 , 3513.375 , 65.56368 , "None"));
Path.Add(new Vector3(272.8025 , 3523.858 , 66.61335 , "None"));
Path.Add(new Vector3(271.9483 , 3534.334 , 68.66122 , "None"));
Path.Add(new Vector3(270.8066 , 3544.77 , 71.6055 , "None"));
Path.Add(new Vector3(265.5812 , 3553.807 , 73.63704 , "None"));
Path.Add(new Vector3(255.2986 , 3552.86 , 73.14068 , "None"));
Path.Add(new Vector3(245.5448 , 3548.234 , 71.64346 , "None"));
Path.Add(new Vector3(236.8208 , 3542.354 , 69.76019 , "None"));
Path.Add(new Vector3(228.1082 , 3535.911 , 68.09895 , "None"));
Path.Add(new Vector3(219.6686 , 3529.664 , 66.37422 , "None"));
Path.Add(new Vector3(210.6826 , 3524.341 , 66.70367 , "None"));
Path.Add(new Vector3(199.8925 , 3524.713 , 67.05209 , "None"));
Path.Add(new Vector3(189.8674 , 3527.63 , 64.41128 , "None"));
Path.Add(new Vector3(179.8535 , 3531.28 , 63.78566 , "None"));
Path.Add(new Vector3(170.4835 , 3536.275 , 64.8615 , "None"));
Path.Add(new Vector3(164.0826 , 3544.688 , 66.95463 , "None"));
Path.Add(new Vector3(159.9784 , 3554.353 , 68.74284 , "None"));
Path.Add(new Vector3(155.6608 , 3564.52 , 68.93296 , "None"));
Path.Add(new Vector3(152.2734 , 3574.238 , 69.20464 , "None"));
Path.Add(new Vector3(148.5285 , 3584.359 , 70.00359 , "None"));
Path.Add(new Vector3(141.7986 , 3592.227 , 70.02423 , "None"));
Path.Add(new Vector3(133.7858 , 3599.511 , 69.42355 , "None"));
Path.Add(new Vector3(127.2165 , 3607.675 , 71.22787 , "None"));
Path.Add(new Vector3(119.9449 , 3615.704 , 74.36061 , "None"));
Path.Add(new Vector3(110.9891 , 3620.098 , 76.3561 , "None"));
Path.Add(new Vector3(100.2815 , 3618.723 , 76.36244 , "None"));
Path.Add(new Vector3(90.92822 , 3613.315 , 75.04639 , "None"));
Path.Add(new Vector3(83.04493 , 3606.402 , 72.66167 , "None"));
Path.Add(new Vector3(75.17117 , 3598.927 , 70.4361 , "None"));
Path.Add(new Vector3(65.19415 , 3596.684 , 70.86535 , "None"));
Path.Add(new Vector3(55.81416 , 3592.843 , 69.91654 , "None"));
Path.Add(new Vector3(47.05495 , 3586.872 , 68.38433 , "None"));
Path.Add(new Vector3(37.96355 , 3580.801 , 66.91517 , "None"));
Path.Add(new Vector3(27.71515 , 3577.347 , 65.81178 , "None"));
Path.Add(new Vector3(17.61385 , 3574.502 , 64.48623 , "None"));
Path.Add(new Vector3(6.963945 , 3572.392 , 64.119 , "None"));
Path.Add(new Vector3(-2.832817 , 3568.781 , 65.92368 , "None"));
Path.Add(new Vector3(-11.77345 , 3563.235 , 65.85233 , "None"));
Path.Add(new Vector3(-21.17751 , 3557.976 , 64.39986 , "None"));
Path.Add(new Vector3(-30.79461 , 3560.593 , 67.80506 , "None"));
Path.Add(new Vector3(-39.3969 , 3567.125 , 72.27213 , "None"));
Path.Add(new Vector3(-45.63107 , 3575.51 , 73.71111 , "None"));
Path.Add(new Vector3(-49.53194 , 3585.245 , 73.64088 , "None"));
Path.Add(new Vector3(-52.80507 , 3595.597 , 73.49241 , "None"));
Path.Add(new Vector3(-55.97058 , 3605.608 , 72.86139 , "None"));
Path.Add(new Vector3(-59.24371 , 3615.96 , 72.11983 , "None"));
Path.Add(new Vector3(-62.50407 , 3625.917 , 71.30043 , "None"));
Path.Add(new Vector3(-77.61346 , 3666.594 , 66.51526 , "None"));
Path.Add(new Vector3(-88.55262 , 3700.191 , 66.46574 , "None"));
Path.Add(new Vector3(-98.16534 , 3733.476 , 68.166 , "None"));
Path.Add(new Vector3(-107.4265 , 3768.451 , 70.91254 , "None"));
Path.Add(new Vector3(-110.8585 , 3795.995 , 77.0723 , "None"));
Path.Add(new Vector3(-107.8877 , 3811.819 , 78.93148 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class DemonicContamination : QuestGrinderClass
{
    public DemonicContamination()
    {
        Name = "Demonic Contamination";

        QuestId.AddRange(new[] { 9372 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10442;

        EntryTarget.Add(16880);
HotSpots.Add(new Vector3(-317.3145 , 4662.76 , 23.4587 , "None"));
HotSpots.Add(new Vector3(-471.6891 , 4499.345 , 48.42572 , "None"));
HotSpots.Add(new Vector3(-426.3514 , 4295.232 , 65.04759 , "None"));
HotSpots.Add(new Vector3(-260.5468 , 4314.781 , 76.58092 , "None"));
HotSpots.Add(new Vector3(-428.7657 , 4458.774 , 51.20617 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KeepThornfangHillClear : QuestGrinderClass
{
    public KeepThornfangHillClear()
    {
        Name = "Keep Thornfang Hill Clear!";

        QuestId.AddRange(new[] { 10159 });

        Step = new List<int> { 8, 8, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(19349);
EntryTarget.Add(19350);
HotSpots.Add(new Vector3(-394.6085 , 4928.644 , 36.17332 , "None"));
HotSpots.Add(new Vector3(-428.4174 , 4985.343 , 45.72647 , "None"));
HotSpots.Add(new Vector3(-372.5163 , 4999.357 , 48.5085 , "None"));
HotSpots.Add(new Vector3(-354.0566 , 5046.958 , 67.52021 , "None"));
HotSpots.Add(new Vector3(-285.95 , 5083.28 , 78.09131 , "None"));
HotSpots.Add(new Vector3(-223.6257 , 5113.227 , 85.68793 , "None"));
HotSpots.Add(new Vector3(-255.9561 , 5204.997 , 75.49979 , "None"));
HotSpots.Add(new Vector3(-268.2965 , 5292.485 , 43.46666 , "None"));
HotSpots.Add(new Vector3(-219.0535 , 5018.308 , 68.71262 , "None"));
HotSpots.Add(new Vector3(-159.8941 , 4881.516 , 49.35049 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheCenarionExpedition : QuestClass
{
    public TheCenarionExpedition()
    {
        Name = "The Cenarion Expedition";

        QuestId.AddRange(new[] { 9912 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TestingtheAntidote : QuestUseItemOnClass
{
    public TestingtheAntidote()
    {
        Name = "Testing the Antidote";

        QuestId.AddRange(new[] { 10255 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9372;

        EntryIdTarget.Add(16880);
EntryIdTarget.Add(16992);
HotSpots.Add(new Vector3(-365.5154 , 4615.882 , 32.7842 , "None"));
HotSpots.Add(new Vector3(-462.8254 , 4563.105 , 47.57598 , "None"));
HotSpots.Add(new Vector3(-482.1371 , 4482.2 , 52.05688 , "None"));
HotSpots.Add(new Vector3(-546.6125 , 4353.493 , 49.80758 , "None"));
HotSpots.Add(new Vector3(-392.8382 , 4291.96 , 70.72438 , "None"));
ItemId = 23337;
Range = 25f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheArakkoaThreat : QuestGrinderClass
{
    public TheArakkoaThreat()
    {
        Name = "The Arakkoa Threat";

        QuestId.AddRange(new[] { 9417 });

        Step = new List<int> { 4, 6, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9558;

        EntryTarget.Add(16967);
EntryTarget.Add(16966);
EntryTarget.Add(17053);
HotSpots.Add(new Vector3(-942.9565 , 4206.317 , 30.24095 , "None"));
HotSpots.Add(new Vector3(-1052.061 , 4198.417 , 15.09172 , "None"));
HotSpots.Add(new Vector3(-1086.725 , 4229.898 , 19.45507 , "None"));
HotSpots.Add(new Vector3(-1215.472 , 4190.285 , 37.19231 , "None"));
HotSpots.Add(new Vector3(-1223.703 , 4127.57 , 60.81123 , "None"));
HotSpots.Add(new Vector3(-1283.576 , 4083.394 , 91.5804 , "None"));
HotSpots.Add(new Vector3(-1200.769 , 4045.992 , 73.55348 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RampagingRavagers : QuestGrinderClass
{
    public RampagingRavagers()
    {
        Name = "Rampaging Ravagers";

        QuestId.AddRange(new[] { 9385 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(19189);
EntryTarget.Add(16934);
HotSpots.Add(new Vector3(-816.5546 , 4379.207 , 68.41372 , "None"));
HotSpots.Add(new Vector3(-773.9802 , 4417.961 , 83.4798 , "None"));
HotSpots.Add(new Vector3(-663.755 , 4371.475 , 66.64522 , "None"));
HotSpots.Add(new Vector3(-770.3411 , 4320.908 , 51.71914 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNZangerFP : QuestFollowPathClass
{
    public RUNZangerFP()
    {
        Name = "RUN Zanger FP";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-261.2473 , 4800.422 , 18.83915 , "None"));
Path.Add(new Vector3(-242.9659 , 4820.935 , 23.3557 , "None"));
Path.Add(new Vector3(-232.9034 , 4853.201 , 29.5815 , "None"));
Path.Add(new Vector3(-234.3037 , 4889.79 , 31.94635 , "None"));
Path.Add(new Vector3(-236.8865 , 4925.627 , 40.36878 , "None"));
Path.Add(new Vector3(-238.1369 , 4959.483 , 48.02977 , "None"));
Path.Add(new Vector3(-239.1041 , 4995.583 , 56.78348 , "None"));
Path.Add(new Vector3(-239.0593 , 5031.944 , 65.91116 , "None"));
Path.Add(new Vector3(-239.2734 , 5068.125 , 71.76114 , "None"));
Path.Add(new Vector3(-239.2703 , 5100.256 , 79.93497 , "None"));
Path.Add(new Vector3(-239.7195 , 5135.743 , 81.03864 , "None"));
Path.Add(new Vector3(-243.9328 , 5172.866 , 82.6143 , "None"));
Path.Add(new Vector3(-248.9064 , 5191.366 , 79.34576 , "None"));
Path.Add(new Vector3(-260.3831 , 5212.256 , 73.34394 , "None"));
Path.Add(new Vector3(-273.3147 , 5245.004 , 63.14698 , "None"));
Path.Add(new Vector3(-279.7684 , 5271.057 , 55.60514 , "None"));
Path.Add(new Vector3(-270.0065 , 5287.998 , 46.06676 , "None"));
Path.Add(new Vector3(-253.4525 , 5309.334 , 35.19061 , "None"));
Path.Add(new Vector3(-233.4573 , 5339.161 , 22.90758 , "None"));
Path.Add(new Vector3(-224.2781 , 5355.252 , 23.07542 , "None"));
Path.Add(new Vector3(-220.5428 , 5371.201 , 23.24546 , "None"));
Path.Add(new Vector3(-220.6844 , 5395.61 , 22.867 , "None"));
Path.Add(new Vector3(-222.3653 , 5416.192 , 22.41909 , "None"));
Path.Add(new Vector3(-226.597 , 5427.574 , 21.87294 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class PlantsofZangarmarsh : QuestGrinderClass
{
    public PlantsofZangarmarsh()
    {
        Name = "Plants of Zangarmarsh";

        QuestId.AddRange(new[] { 9802 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18134);
EntryTarget.Add(18130);
EntryTarget.Add(19402);
EntryTarget.Add(18124);
EntryTarget.Add(20324);
HotSpots.Add(new Vector3(7.210505 , 5445.632 , 18.91978 , "None"));
HotSpots.Add(new Vector3(126.5798 , 5304.184 , 21.36767 , "None"));
HotSpots.Add(new Vector3(237.9383 , 5240.417 , 23.34199 , "None"));
HotSpots.Add(new Vector3(455.0164 , 5183.08 , 21.82927 , "None"));
HotSpots.Add(new Vector3(458.8568 , 5177.028 , 21.61834 , "None"));
HotSpots.Add(new Vector3(593.0376 , 5230.542 , -2.550122 , "None"));
HotSpots.Add(new Vector3(738.8237 , 5518.092 , -0.4289998 , "None"));
HotSpots.Add(new Vector3(448.1404 , 5520.926 , 21.69352 , "None"));
HotSpots.Add(new Vector3(332.6494 , 5476.055 , 22.5917 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class StrainedSupplies : QuestGrinderClass
{
    public StrainedSupplies()
    {
        Name = "Strained Supplies";

        QuestId.AddRange(new[] { 10017 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18466);
EntryTarget.Add(18476);
HotSpots.Add(new Vector3(-2272.444 , 4740.637 , -1.434125 , "None"));
HotSpots.Add(new Vector3(-2080.217 , 4801.711 , 1.995496 , "None"));
HotSpots.Add(new Vector3(-1990.493 , 4898.625 , 15.11689 , "None"));
HotSpots.Add(new Vector3(-2061.364 , 5025.371 , 22.77263 , "None"));
HotSpots.Add(new Vector3(-2168.111 , 4989.154 , -2.99253 , "None"));
HotSpots.Add(new Vector3(-2267.894 , 5037.588 , -4.281546 , "None"));
HotSpots.Add(new Vector3(-2154.53 , 4896.841 , -2.849572 , "None"));
HotSpots.Add(new Vector3(-2103.874 , 4858.249 , 6.729229 , "None"));
HotSpots.Add(new Vector3(-1837.734 , 4545.675 , 9.025803 , "None"));
HotSpots.Add(new Vector3(-1742.245 , 4446.386 , 2.151698 , "None"));
HotSpots.Add(new Vector3(-2028.508 , 4566.327 , 2.878937 , "None"));
HotSpots.Add(new Vector3(-2148.996 , 4516.115 , -5.437953 , "None"));
HotSpots.Add(new Vector3(-2239.701 , 4431.125 , 1.967986 , "None"));
HotSpots.Add(new Vector3(-2295.292 , 4319.144 , 2.092984 , "None"));
HotSpots.Add(new Vector3(-2144.054 , 4456.206 , -2.252336 , "None"));
HotSpots.Add(new Vector3(-1823.638 , 4501.617 , 2.559011 , "None"));
HotSpots.Add(new Vector3(-1757.451 , 4465.764 , 0.711201 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class VorenthalsVisions : QuestGrinderClass
{
    public VorenthalsVisions()
    {
        Name = "Voren'thal's Visions";

        QuestId.AddRange(new[] { 10024 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18461);
EntryTarget.Add(21854);
HotSpots.Add(new Vector3(-1455.002 , 5010.755 , -7.123936 , "None"));
HotSpots.Add(new Vector3(-1519.344 , 4961.48 , -6.770042 , "None"));
HotSpots.Add(new Vector3(-1373.64 , 5076.529 , -2.609479 , "None"));
HotSpots.Add(new Vector3(-1271.922 , 5056.15 , -6.028968 , "None"));
HotSpots.Add(new Vector3(-1186.803 , 5093.29 , 3.755385 , "None"));
HotSpots.Add(new Vector3(-1192.786 , 5149.523 , 22.75996 , "None"));
HotSpots.Add(new Vector3(-1635.138 , 5028.896 , 1.479928 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheOutcastsPlight : QuestGrinderClass
{
    public TheOutcastsPlight()
    {
        Name = "The Outcast's Plight";

        QuestId.AddRange(new[] { 10917 });

        Step = new List<int> { 30, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18449);
EntryTarget.Add(18450);
EntryTarget.Add(18452);
EntryTarget.Add(18453);
HotSpots.Add(new Vector3(-1711.711 , 4431.667 , 6.474043 , "None"));
HotSpots.Add(new Vector3(-1554.277 , 4393.6 , 41.2178 , "None"));
HotSpots.Add(new Vector3(-1475.745 , 4499.501 , 40.90863 , "None"));
HotSpots.Add(new Vector3(-2414.011 , 5395.197 , 2.156202 , "None"));
HotSpots.Add(new Vector3(-2505.449 , 5334.382 , 1.167595 , "None"));
HotSpots.Add(new Vector3(-2621.355 , 5391.555 , 6.250573 , "None"));
HotSpots.Add(new Vector3(-2550.278 , 5428.001 , 0.06443323 , "None"));
HotSpots.Add(new Vector3(-2485.312 , 5386.585 , 0.1212459 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReporttoSpymasterThalodien : QuestClass
{
    public ReporttoSpymasterThalodien()
    {
        Name = "Report to Spymaster Thalodien";

        QuestId.AddRange(new[] { 11039 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RatherBeFishin : QuestGrinderClass
{
    public RatherBeFishin()
    {
        Name = "Rather Be Fishin'";

        QuestId.AddRange(new[] { 10037 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18750);
EntryTarget.Add(18461);
HotSpots.Add(new Vector3(-1312.325 , 4923.987 , -10.42466 , "Swimming"));
HotSpots.Add(new Vector3(-1413.083 , 4925.055 , -10.42466 , "Swimming"));
HotSpots.Add(new Vector3(-1453.198 , 4773.339 , -16.12839 , "Swimming"));
HotSpots.Add(new Vector3(-1349.136 , 4883.468 , -13.11848 , "Swimming"));
HotSpots.Add(new Vector3(-1321.685 , 4917.65 , -12.4153 , "Swimming"));
HotSpots.Add(new Vector3(-1357.042 , 5031.923 , -10.58271 , "Swimming"));
HotSpots.Add(new Vector3(-1217.176 , 5014.227 , -25.3355 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CluesintheThicket : QuestInteractWithClass
{
    public CluesintheThicket()
    {
        Name = "Clues in the Thicket";

        QuestId.AddRange(new[] { 9971 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(183789);
HotSpots.Add(new Vector3(-1782.899 , 4648.632 , 14.62058 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "";
IgnoreIfDead = false;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ItsWatchingYou : QuestGrinderClass
{
    public ItsWatchingYou()
    {
        Name = "It's Watching You!";

        QuestId.AddRange(new[] { 9951 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18438);
HotSpots.Add(new Vector3(-1795.19 , 4726.517 , 67.46546 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNItsWatchingYou : QuestFollowPathClass
{
    public RUNItsWatchingYou()
    {
        Name = "RUN: Its Watching You";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-1894.144 , 4684.236 , 1.355696 , "None"));
Path.Add(new Vector3(-1887.974 , 4690.543 , 2.397864 , "None"));
Path.Add(new Vector3(-1880.488 , 4697.967 , 3.63326 , "None"));
Path.Add(new Vector3(-1871.402 , 4707.031 , 3.943768 , "None"));
Path.Add(new Vector3(-1866.036 , 4715.177 , 2.605183 , "None"));
Path.Add(new Vector3(-1855.853 , 4719.456 , 4.05354 , "None"));
Path.Add(new Vector3(-1846.469 , 4721.295 , 5.629507 , "None"));
Path.Add(new Vector3(-1834.792 , 4725.694 , 10.88907 , "None"));
Path.Add(new Vector3(-1832.139 , 4741.808 , 16.02611 , "None"));
Path.Add(new Vector3(-1828.798 , 4749.937 , 18.35262 , "None"));
Path.Add(new Vector3(-1814.838 , 4751.593 , 23.49751 , "None"));
Path.Add(new Vector3(-1811.335 , 4739.221 , 25.59722 , "None"));
Path.Add(new Vector3(-1807.108 , 4736.799 , 26.97791 , "None"));
Path.Add(new Vector3(-1801.443 , 4734.805 , 28.6339 , "None"));
Path.Add(new Vector3(-1796.366 , 4734.339 , 29.31286 , "None"));
Path.Add(new Vector3(-1790.699 , 4736.256 , 29.30728 , "None"));
Path.Add(new Vector3(-1786.226 , 4736.24 , 29.30728 , "None"));
Path.Add(new Vector3(-1784.408 , 4732.512 , 30.4 , "None"));
Path.Add(new Vector3(-1784.709 , 4729.335 , 31.70716 , "None"));
Path.Add(new Vector3(-1787.419 , 4726.805 , 33.42067 , "None"));
Path.Add(new Vector3(-1790.797 , 4726.393 , 34.74857 , "None"));
Path.Add(new Vector3(-1794.15 , 4726.99 , 35.94971 , "None"));
Path.Add(new Vector3(-1796.992 , 4729.259 , 37.22842 , "None"));
Path.Add(new Vector3(-1797.987 , 4732.346 , 38.56453 , "None"));
Path.Add(new Vector3(-1797.582 , 4735.904 , 39.93734 , "None"));
Path.Add(new Vector3(-1795.589 , 4738.622 , 41.25006 , "None"));
Path.Add(new Vector3(-1792.295 , 4739.689 , 42.66055 , "None"));
Path.Add(new Vector3(-1788.776 , 4738.912 , 44.27946 , "None"));
Path.Add(new Vector3(-1785.792 , 4737.142 , 46.09538 , "None"));
Path.Add(new Vector3(-1784.006 , 4734.231 , 47.12769 , "None"));
Path.Add(new Vector3(-1784.536 , 4730.791 , 48.69946 , "None"));
Path.Add(new Vector3(-1787.04 , 4728.365 , 50.11184 , "None"));
Path.Add(new Vector3(-1790.223 , 4726.658 , 51.42416 , "None"));
Path.Add(new Vector3(-1793.582 , 4726.752 , 52.49276 , "None"));
Path.Add(new Vector3(-1796.946 , 4728.325 , 54.00706 , "None"));
Path.Add(new Vector3(-1798.738 , 4732.044 , 55.68167 , "None"));
Path.Add(new Vector3(-1797.868 , 4735.382 , 56.98877 , "None"));
Path.Add(new Vector3(-1795.331 , 4737.635 , 57.87224 , "None"));
Path.Add(new Vector3(-1791.983 , 4739.033 , 58.39498 , "None"));
Path.Add(new Vector3(-1788.545 , 4738.454 , 59.45804 , "None"));
Path.Add(new Vector3(-1786.282 , 4735.927 , 60.7106 , "None"));
Path.Add(new Vector3(-1784.968 , 4732.572 , 62.09647 , "None"));
Path.Add(new Vector3(-1785.763 , 4729.153 , 64.15887 , "None"));
Path.Add(new Vector3(-1787.997 , 4726.99 , 65.79786 , "None"));
Path.Add(new Vector3(-1793.258 , 4726.393 , 66.8315 , "None"));
Path.Add(new Vector3(-1797.081 , 4733.406 , 66.83186 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNItsWatchingYouRundown : QuestFollowPathClass
{
    public RUNItsWatchingYouRundown()
    {
        Name = "RUN: Its Watching You - Run down";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-1790.645 , 4726.646 , 66.8316 , "None"));
Path.Add(new Vector3(-1787.61 , 4728.181 , 65.22424 , "None"));
Path.Add(new Vector3(-1785.504 , 4729.57 , 63.79471 , "None"));
Path.Add(new Vector3(-1784.289 , 4732.55 , 62.07185 , "None"));
Path.Add(new Vector3(-1785.08 , 4736.388 , 60.63002 , "None"));
Path.Add(new Vector3(-1788.744 , 4739.414 , 59.09964 , "None"));
Path.Add(new Vector3(-1791.557 , 4739.536 , 58.43263 , "None"));
Path.Add(new Vector3(-1795.104 , 4738.714 , 57.96503 , "None"));
Path.Add(new Vector3(-1797.212 , 4736.015 , 57.2187 , "None"));
Path.Add(new Vector3(-1797.908 , 4733.189 , 56.12769 , "None"));
Path.Add(new Vector3(-1797.814 , 4729.875 , 54.61605 , "None"));
Path.Add(new Vector3(-1794.917 , 4727.374 , 53.00149 , "None"));
Path.Add(new Vector3(-1791.442 , 4726.366 , 51.88688 , "None"));
Path.Add(new Vector3(-1787.994 , 4726.417 , 50.85439 , "None"));
Path.Add(new Vector3(-1785.335 , 4728.712 , 49.65483 , "None"));
Path.Add(new Vector3(-1784.328 , 4732.007 , 48.20504 , "None"));
Path.Add(new Vector3(-1784.839 , 4735.481 , 46.74396 , "None"));
Path.Add(new Vector3(-1786.871 , 4738.36 , 45.33908 , "None"));
Path.Add(new Vector3(-1790.064 , 4739.756 , 43.59285 , "None"));
Path.Add(new Vector3(-1794.072 , 4738.538 , 41.84689 , "None"));
Path.Add(new Vector3(-1796.553 , 4735.827 , 40.08321 , "None"));
Path.Add(new Vector3(-1798.105 , 4732.715 , 38.71786 , "None"));
Path.Add(new Vector3(-1797.349 , 4729.516 , 37.34045 , "None"));
Path.Add(new Vector3(-1794.575 , 4727.291 , 36.08416 , "None"));
Path.Add(new Vector3(-1791.763 , 4725.139 , 34.98085 , "None"));
Path.Add(new Vector3(-1788.898 , 4725.526 , 34.07602 , "None"));
Path.Add(new Vector3(-1786.221 , 4727.724 , 32.58943 , "None"));
Path.Add(new Vector3(-1784.332 , 4730.719 , 30.96127 , "None"));
Path.Add(new Vector3(-1784.642 , 4734.05 , 29.87156 , "None"));
Path.Add(new Vector3(-1786.734 , 4736.99 , 29.30796 , "None"));
Path.Add(new Vector3(-1790.077 , 4736.462 , 29.30796 , "None"));
Path.Add(new Vector3(-1793.562 , 4735.796 , 29.30796 , "None"));
Path.Add(new Vector3(-1797.032 , 4735.72 , 29.29587 , "None"));
Path.Add(new Vector3(-1799.977 , 4736.582 , 28.89744 , "None"));
Path.Add(new Vector3(-1802.297 , 4737.456 , 28.18807 , "None"));
Path.Add(new Vector3(-1804.758 , 4739.289 , 27.65219 , "None"));
Path.Add(new Vector3(-1808.095 , 4740.86 , 26.67719 , "None"));
Path.Add(new Vector3(-1811.019 , 4742.925 , 25.53305 , "None"));
Path.Add(new Vector3(-1813.701 , 4745.183 , 24.56063 , "None"));
Path.Add(new Vector3(-1816.469 , 4747.371 , 23.16088 , "None"));
Path.Add(new Vector3(-1819.191 , 4749.503 , 21.62973 , "None"));
Path.Add(new Vector3(-1822.723 , 4750.267 , 20.00593 , "None"));
Path.Add(new Vector3(-1826.204 , 4750.559 , 18.87181 , "None"));
Path.Add(new Vector3(-1829.696 , 4750.463 , 18.25714 , "None"));
Path.Add(new Vector3(-1833.174 , 4749.696 , 18.01076 , "None"));
Path.Add(new Vector3(-1836.467 , 4748.335 , 18.00807 , "None"));
Path.Add(new Vector3(-1839.36 , 4746.245 , 17.39623 , "None"));
Path.Add(new Vector3(-1841.108 , 4743.276 , 15.26683 , "None"));
Path.Add(new Vector3(-1841.993 , 4739.89 , 13.28937 , "None"));
Path.Add(new Vector3(-1843.295 , 4736.564 , 11.85831 , "None"));
Path.Add(new Vector3(-1844.172 , 4733.125 , 10.66953 , "None"));
Path.Add(new Vector3(-1844.052 , 4729.811 , 8.902521 , "None"));
Path.Add(new Vector3(-1845.922 , 4726.542 , 6.1233 , "None"));
Path.Add(new Vector3(-1848.422 , 4724.751 , 4.837502 , "None"));
Path.Add(new Vector3(-1850.949 , 4723.221 , 4.312661 , "None"));
Path.Add(new Vector3(-1853.528 , 4721.656 , 4.123257 , "None"));
Path.Add(new Vector3(-1860.493 , 4717.145 , 2.696304 , "None"));
Path.Add(new Vector3(-1869.161 , 4710.749 , 3.787538 , "None"));
Path.Add(new Vector3(-1877.021 , 4704.779 , 2.615038 , "None"));
Path.Add(new Vector3(-1885.977 , 4698.083 , 2.684138 , "None"));
Path.Add(new Vector3(-1894.261 , 4692.05 , 1.743521 , "None"));
Path.Add(new Vector3(-1902.951 , 4685.096 , 0.4315462 , "None"));
Path.Add(new Vector3(-1911.504 , 4679.514 , -0.6953872 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class PATHSuppliesqtoFishingQTurninShattrath : QuestFollowPathClass
{
    public PATHSuppliesqtoFishingQTurninShattrath()
    {
        Name = "PATH: Supplies q to Fishing Q Turnin Shattrath";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-1605.026 , 5296.058 , -38.57764 , "None"));
Path.Add(new Vector3(-1608.573 , 5296.163 , -38.57764 , "None"));
Path.Add(new Vector3(-1611.997 , 5296.875 , -39.77258 , "None"));
Path.Add(new Vector3(-1618.841 , 5298.565 , -40.20889 , "None"));
Path.Add(new Vector3(-1625.671 , 5300.251 , -40.20889 , "None"));
Path.Add(new Vector3(-1632.195 , 5301.862 , -40.20889 , "None"));
Path.Add(new Vector3(-1639.003 , 5304.895 , -40.20889 , "None"));
Path.Add(new Vector3(-1641.055 , 5310.553 , -40.20889 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class BeforeDarknessFalls : QuestGrinderClass
{
    public BeforeDarknessFalls()
    {
        Name = "Before Darkness Falls";

        QuestId.AddRange(new[] { 10878 });

        Step = new List<int> { 8, 4, 2, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(21661);
EntryTarget.Add(21902);
EntryTarget.Add(21907);
HotSpots.Add(new Vector3(-3084.365 , 5061.248 , -21.45874 , "None"));
HotSpots.Add(new Vector3(-3008.721 , 5036.835 , -23.57646 , "None"));
HotSpots.Add(new Vector3(-2997.189 , 4869.932 , -22.29993 , "None"));
HotSpots.Add(new Vector3(-3088.515 , 4859.719 , -21.76303 , "None"));
HotSpots.Add(new Vector3(-3088.771 , 4949.318 , -20.82461 , "None"));
HotSpots.Add(new Vector3(-3148.601 , 4998.89 , -9.051871 , "None"));
HotSpots.Add(new Vector3(-3111.792 , 4889.046 , -22.4893 , "None"));
HotSpots.Add(new Vector3(-3150.396 , 4873.002 , -8.982167 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SpeakwithRilaktheRedeemed : QuestClass
{
    public SpeakwithRilaktheRedeemed()
    {
        Name = "Speak with Rilak the Redeemed";

        QuestId.AddRange(new[] { 10908 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TakenintheNight : QuestGrinderClass
{
    public TakenintheNight()
    {
        Name = "Taken in the Night";

        QuestId.AddRange(new[] { 10873 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(22355);
EntryTarget.Add(21242);
EntryTarget.Add(18467);
EntryTarget.Add(18470);
HotSpots.Add(new Vector3(-3777.287 , 4289.231 , 3.939965 , "None"));
HotSpots.Add(new Vector3(-3898.628 , 4248.728 , -10.56883 , "None"));
HotSpots.Add(new Vector3(-3972.3 , 4345.481 , -18.29731 , "None"));
HotSpots.Add(new Vector3(-3909.454 , 4318.822 , -7.005977 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheDreadRelic : QuestGathererClass
{
    public TheDreadRelic()
    {
        Name = "The Dread Relic";

        QuestId.AddRange(new[] { 10877 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(185220);
HotSpots.Add(new Vector3(-3752.265 , 4711.157 , -17.59444 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KILL6264TerkorraForest1 : QuestGrinderClass
{
    public KILL6264TerkorraForest1()
    {
        Name = "KILL: 62-64 Terkorra Forest 1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18466);
EntryTarget.Add(18468);
EntryTarget.Add(18476);
EntryTarget.Add(21854);
EntryTarget.Add(18449);
EntryTarget.Add(18437);
EntryTarget.Add(18461);
EntryTarget.Add(18750);
HotSpots.Add(new Vector3(-2289.489 , 4858.012 , -2.355711 , "None"));
HotSpots.Add(new Vector3(-2294.91 , 4363.043 , 2.362895 , "None"));
HotSpots.Add(new Vector3(-2224.217 , 4413.408 , 1.008062 , "None"));
HotSpots.Add(new Vector3(-2120.055 , 4539.727 , -2.302395 , "None"));
HotSpots.Add(new Vector3(-2033.957 , 4558.327 , 2.98119 , "None"));
HotSpots.Add(new Vector3(-1855.497 , 4370.305 , 0.4087485 , "None"));
HotSpots.Add(new Vector3(-1681.818 , 4418.387 , 13.70144 , "None"));
HotSpots.Add(new Vector3(-1762.262 , 4534.125 , 6.220839 , "None"));
HotSpots.Add(new Vector3(-1720.686 , 4582.86 , 3.05147 , "None"));
HotSpots.Add(new Vector3(-1483.648 , 4543.535 , 35.68149 , "None"));
HotSpots.Add(new Vector3(-1415.746 , 4773.187 , 6.117458 , "None"));
HotSpots.Add(new Vector3(-1512.573 , 4967.822 , -7.099529 , "None"));
HotSpots.Add(new Vector3(-1574.556 , 5031.01 , -9.745374 , "None"));
HotSpots.Add(new Vector3(-1308.766 , 5070.682 , -6.711011 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 64 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(35) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6264TerkorraForestv2nearmid : QuestGrinderClass
{
    public KILL6264TerkorraForestv2nearmid()
    {
        Name = "KILL: 62-64 Terkorra Forest v2 (near mid)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(21854);
EntryTarget.Add(18466);
EntryTarget.Add(18476);
EntryTarget.Add(18469);
EntryTarget.Add(22095);
EntryTarget.Add(22419);
EntryTarget.Add(18470);
EntryTarget.Add(18464);
EntryTarget.Add(21816);
EntryTarget.Add(18468);
HotSpots.Add(new Vector3(-2878.859 , 5236.951 , -13.74754 , "None"));
HotSpots.Add(new Vector3(-2700.128 , 5201.243 , -1.531778 , "None"));
HotSpots.Add(new Vector3(-2536.212 , 5246.344 , 4.122103 , "None"));
HotSpots.Add(new Vector3(-2362.393 , 5273.9 , 1.947471 , "None"));
HotSpots.Add(new Vector3(-2331.225 , 5465.806 , 1.578211 , "None"));
HotSpots.Add(new Vector3(-2241.031 , 5218.742 , -9.980652 , "None"));
HotSpots.Add(new Vector3(-2194.512 , 5020.481 , -12.70668 , "None"));
HotSpots.Add(new Vector3(-2269.363 , 5038.375 , -4.090096 , "None"));
HotSpots.Add(new Vector3(-2277.325 , 4836.388 , 0.7418172 , "None"));
HotSpots.Add(new Vector3(-2204.37 , 4842.319 , -1.224699 , "None"));
HotSpots.Add(new Vector3(-2092.969 , 5048.848 , 13.69314 , "None"));
HotSpots.Add(new Vector3(-2013.308 , 4790.999 , -0.2264753 , "None"));
HotSpots.Add(new Vector3(-2070.526 , 4622.516 , -5.564824 , "None"));
HotSpots.Add(new Vector3(-2150.082 , 4505.005 , -0.7593448 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 64 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(35) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6264TerkorraForestv3 : QuestGrinderClass
{
    public KILL6264TerkorraForestv3()
    {
        Name = "KILL: 62-64 Terkorra Forest v3";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(22095);
EntryTarget.Add(22419);
EntryTarget.Add(18477);
EntryTarget.Add(18467);
EntryTarget.Add(21324);
EntryTarget.Add(21198);
EntryTarget.Add(18453);
EntryTarget.Add(18469);
EntryTarget.Add(18464);
EntryTarget.Add(21816);
EntryTarget.Add(18476);
EntryTarget.Add(18466);
EntryTarget.Add(21854);
EntryTarget.Add(18468);
EntryTarget.Add(18437);
EntryTarget.Add(18449);
EntryTarget.Add(18463);
HotSpots.Add(new Vector3(-2724.155 , 5216.431 , -2.169382 , "None"));
HotSpots.Add(new Vector3(-2727.206 , 5371.263 , 0.7424251 , "None"));
HotSpots.Add(new Vector3(-2799.189 , 5463.61 , 2.429803 , "None"));
HotSpots.Add(new Vector3(-2631.862 , 5389.856 , 7.335525 , "None"));
HotSpots.Add(new Vector3(-2579.592 , 5262.41 , 7.80696 , "None"));
HotSpots.Add(new Vector3(-2397.921 , 5212.502 , -4.259291 , "None"));
HotSpots.Add(new Vector3(-2366.246 , 5455.403 , 0.1710433 , "None"));
HotSpots.Add(new Vector3(-2203.415 , 5208.599 , -9.469273 , "None"));
HotSpots.Add(new Vector3(-2184.902 , 5045.292 , -19.90462 , "None"));
HotSpots.Add(new Vector3(-2318.174 , 5045.147 , -2.715738 , "None"));
HotSpots.Add(new Vector3(-2267.738 , 4828.284 , 0.8698061 , "None"));
HotSpots.Add(new Vector3(-2174.484 , 4898.345 , -0.2318695 , "None"));
HotSpots.Add(new Vector3(-2190.69 , 5052.528 , -19.74222 , "None"));
HotSpots.Add(new Vector3(-2204.997 , 4811.668 , 2.450204 , "None"));
HotSpots.Add(new Vector3(-2257.382 , 4716.215 , -3.151749 , "None"));
HotSpots.Add(new Vector3(-2094.667 , 4862 , 7.725231 , "None"));
HotSpots.Add(new Vector3(-2021.921 , 4979.93 , 27.22264 , "None"));
HotSpots.Add(new Vector3(-1889.962 , 4717.577 , -2.122061 , "None"));
HotSpots.Add(new Vector3(-1823.659 , 4547.756 , 9.293494 , "None"));
HotSpots.Add(new Vector3(-1735.488 , 4422.061 , 5.880204 , "None"));
HotSpots.Add(new Vector3(-1868.128 , 4373.775 , 0.674718 , "None"));
HotSpots.Add(new Vector3(-1908.184 , 4062.44 , 2.289325 , "None"));
HotSpots.Add(new Vector3(-2064.056 , 3967.423 , 1.427616 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 3;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 64 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(35) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6264TerkorraForestv4ByTuuremMightbepvp : QuestGrinderClass
{
    public KILL6264TerkorraForestv4ByTuuremMightbepvp()
    {
        Name = "KILL: 62-64 Terkorra Forest v4 - By Tuurem (Might be pvp)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18463);
EntryTarget.Add(18469);
EntryTarget.Add(18464);
EntryTarget.Add(18477);
EntryTarget.Add(21816);
EntryTarget.Add(18466);
EntryTarget.Add(18468);
EntryTarget.Add(18476);
HotSpots.Add(new Vector3(-2085.058 , 3984.082 , 3.438889 , "None"));
HotSpots.Add(new Vector3(-2300.314 , 4030.877 , -28.82947 , "None"));
HotSpots.Add(new Vector3(-2425.2 , 3971.149 , -0.9529015 , "None"));
HotSpots.Add(new Vector3(-2582.005 , 3910.863 , 4.100491 , "None"));
HotSpots.Add(new Vector3(-2590.073 , 3685.692 , 1.337363 , "None"));
HotSpots.Add(new Vector3(-2585.884 , 3632.301 , 0.4242903 , "None"));
HotSpots.Add(new Vector3(-2568.104 , 3443.105 , -4.434791 , "None"));
HotSpots.Add(new Vector3(-2590.36 , 3220.242 , 2.241414 , "None"));
HotSpots.Add(new Vector3(-2672.755 , 3248.734 , 0.02934192 , "None"));
HotSpots.Add(new Vector3(-2143.44 , 3860.612 , 1.458403 , "None"));
HotSpots.Add(new Vector3(-2019.055 , 3858.057 , 0.2497826 , "None"));
HotSpots.Add(new Vector3(-1963.913 , 3899.808 , -1.359011 , "None"));
HotSpots.Add(new Vector3(-1984.724 , 3730.018 , -30.1853 , "None"));
HotSpots.Add(new Vector3(-2119.916 , 3648.995 , -51.54714 , "None"));
HotSpots.Add(new Vector3(-2212.306 , 3604.692 , -30.00753 , "None"));
HotSpots.Add(new Vector3(-2319.328 , 3537.576 , -8.618494 , "None"));
HotSpots.Add(new Vector3(-2119.891 , 3489.245 , -57.23405 , "None"));
HotSpots.Add(new Vector3(-2090.257 , 3380.024 , -53.97693 , "None"));
HotSpots.Add(new Vector3(-2133.831 , 3338.974 , -42.4927 , "None"));
HotSpots.Add(new Vector3(-2116.154 , 3209.578 , -38.83636 , "None"));
HotSpots.Add(new Vector3(-2144.829 , 3266.298 , -33.20518 , "None"));
HotSpots.Add(new Vector3(-2236.652 , 3584.558 , -20.3491 , "None"));
HotSpots.Add(new Vector3(-2456.772 , 3637.167 , -3.065131 , "None"));
HotSpots.Add(new Vector3(-2461.174 , 3779.706 , 3.707834 , "None"));
HotSpots.Add(new Vector3(-2566.637 , 3914.504 , 8.666745 , "None"));
HotSpots.Add(new Vector3(-2596.975 , 3682.795 , 2.237753 , "None"));
HotSpots.Add(new Vector3(-2749.516 , 3766.894 , -0.2939517 , "None"));
HotSpots.Add(new Vector3(-2464.389 , 3985.192 , -2.055645 , "None"));
HotSpots.Add(new Vector3(-2296.354 , 4107.053 , -18.88648 , "None"));
HotSpots.Add(new Vector3(-2324.412 , 4338.12 , -2.217909 , "None"));
HotSpots.Add(new Vector3(-2227.873 , 4551.832 , -1.217583 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 4;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 64 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(40) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6264ZangermarshSporeaggerRepV2Cave : QuestGrinderClass
{
    public KILL6264ZangermarshSporeaggerRepV2Cave()
    {
        Name = "KILL: 62-64 -Zangermarsh - Sporeagger Rep V2 (Cave) ";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18137);
EntryTarget.Add(18136);
EntryTarget.Add(18282);
HotSpots.Add(new Vector3(-1098.599 , 5659.279 , 59.54741 , "None"));
HotSpots.Add(new Vector3(-1126.145 , 5605.149 , 57.71473 , "None"));
HotSpots.Add(new Vector3(-1111.744 , 5728.709 , 59.00874 , "None"));
HotSpots.Add(new Vector3(-1165.495 , 5733.86 , 55.69432 , "None"));
HotSpots.Add(new Vector3(-1220.989 , 5741.57 , 43.00335 , "None"));
HotSpots.Add(new Vector3(-1222.881 , 5782.395 , 53.88292 , "None"));
HotSpots.Add(new Vector3(-1243.621 , 5853.606 , 38.14524 , "None"));
HotSpots.Add(new Vector3(-1330.261 , 5914.305 , 11.92299 , "None"));
HotSpots.Add(new Vector3(-1358.287 , 5834.604 , 18.58981 , "None"));
HotSpots.Add(new Vector3(-1345.142 , 5795.274 , 24.46285 , "None"));
HotSpots.Add(new Vector3(-1264.625 , 5742.718 , 40.25991 , "None"));
HotSpots.Add(new Vector3(-1262.531 , 5782.092 , 0.330247 , "None"));
HotSpots.Add(new Vector3(-1311.804 , 5845.962 , 8.386418 , "None"));
HotSpots.Add(new Vector3(-1330.473 , 5910.052 , 11.86967 , "None"));
HotSpots.Add(new Vector3(-1288.875 , 5855.157 , 40.13338 , "None"));
HotSpots.Add(new Vector3(-1249.255 , 5844.413 , 41.74566 , "None"));
HotSpots.Add(new Vector3(-1185.809 , 5866.133 , 34.46408 , "None"));
HotSpots.Add(new Vector3(-1219.752 , 5778.346 , 53.25738 , "None"));
HotSpots.Add(new Vector3(-1345.516 , 5790.986 , 24.16518 , "None"));
HotSpots.Add(new Vector3(-1323.693 , 5859.306 , 7.556516 , "None"));
HotSpots.Add(new Vector3(-1279.006 , 5817.471 , 46.50484 , "None"));
HotSpots.Add(new Vector3(-1217.817 , 5783.44 , 54.30671 , "None"));
HotSpots.Add(new Vector3(-1193.564 , 5723.706 , 51.91598 , "None"));
HotSpots.Add(new Vector3(-1121.49 , 5708.682 , 58.18668 , "None"));
HotSpots.Add(new Vector3(-1137.142 , 5598.079 , 57.00199 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 5;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 64 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(55) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class TheInfestedProtectors : QuestGrinderClass
{
    public TheInfestedProtectors()
    {
        Name = "The Infested Protectors";

        QuestId.AddRange(new[] { 10896 });

        Step = new List<int> { 25, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(22419);
EntryTarget.Add(22095);
HotSpots.Add(new Vector3(-3660.131 , 5431.452 , -6.612222 , "None"));
HotSpots.Add(new Vector3(-3619.126 , 5490.899 , -8.211939 , "None"));
HotSpots.Add(new Vector3(-3860.488 , 5384.763 , -21.84305 , "None"));
HotSpots.Add(new Vector3(-3843.755 , 5302.139 , -38.83025 , "None"));
HotSpots.Add(new Vector3(-2693.115 , 4993.626 , -6.650495 , "None"));
HotSpots.Add(new Vector3(-2735.603 , 4917.567 , -7.534964 , "None"));
HotSpots.Add(new Vector3(-2824.224 , 4619.656 , -12.48995 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AnImproperBurial : QuestInteractWithClass
{
    public AnImproperBurial()
    {
        Name = "An Improper Burial";

        QuestId.AddRange(new[] { 10913 });

        Step = new List<int> { 8, 8, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(21859);
EntryIdTarget.Add(21846);
HotSpots.Add(new Vector3(-3691.42 , 5220.902 , -21.2115 , "None"));
HotSpots.Add(new Vector3(-3739.767 , 5271.675 , -16.14314 , "None"));
HotSpots.Add(new Vector3(-3762.579 , 5203.5 , -23.39137 , "None"));
HotSpots.Add(new Vector3(-3759.105 , 5139.976 , -22.91365 , "None"));
HotSpots.Add(new Vector3(-3749.812 , 5124.324 , -21.99824 , "None"));
HotSpots.Add(new Vector3(-3770.799 , 5121.622 , -21.57426 , "None"));
HotSpots.Add(new Vector3(-3764.384 , 5095.725 , -19.13647 , "None"));
HotSpots.Add(new Vector3(-3752.174 , 5079.435 , -18.27741 , "None"));
HotSpots.Add(new Vector3(-3733.366 , 5061.738 , -17.76624 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "";
IgnoreIfDead = true;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CabalOrders : QuestClass
{
    public CabalOrders()
    {
        Name = "Cabal Orders";

        QuestId.AddRange(new[] { 10880 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 31707;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CabalOrdersKILLFORITEM : QuestGrinderClass
{
    public CabalOrdersKILLFORITEM()
    {
        Name = "Cabal Orders - KILL FOR ITEM";

        QuestId.AddRange(new[] { 10880 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(21661);
EntryTarget.Add(21907);
EntryTarget.Add(21902);
HotSpots.Add(new Vector3(-3088.068 , 5049.297 , -21.48035 , "None"));
HotSpots.Add(new Vector3(-3119.264 , 5005.438 , -20.6082 , "None"));
HotSpots.Add(new Vector3(-3093.783 , 4999.366 , -21.08148 , "None"));
HotSpots.Add(new Vector3(-3088.524 , 4951.017 , -20.91278 , "None"));
HotSpots.Add(new Vector3(-3017.498 , 4892.648 , -20.80853 , "None"));
HotSpots.Add(new Vector3(-3076.964 , 4830.712 , -24.15629 , "None"));
HotSpots.Add(new Vector3(-3098.477 , 4864.564 , -21.53906 , "None"));
HotSpots.Add(new Vector3(-3107.976 , 4846.829 , -21.57036 , "None"));
HotSpots.Add(new Vector3(-3127.087 , 4833.857 , -21.42433 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(31707) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class ShadowTombLEFTITEM : QuestFollowPathClass
{
    public ShadowTombLEFTITEM()
    {
        Name = "Shadow Tomb - LEFT ITEM";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2815.518 , 5192.731 , -11.23318 , "None"));
Path.Add(new Vector3(-2824.435 , 5211.976 , -11.05053 , "None"));
Path.Add(new Vector3(-2833.888 , 5232.128 , -11.10355 , "None"));
Path.Add(new Vector3(-2836.185 , 5242.49 , -9.790359 , "None"));
Path.Add(new Vector3(-2843.849 , 5277.071 , -9.743986 , "None"));
Path.Add(new Vector3(-2847.244 , 5292.809 , -9.381411 , "None"));
Path.Add(new Vector3(-2850.034 , 5306.027 , -9.200965 , "None"));
Path.Add(new Vector3(-2859.71 , 5310.937 , -9.445806 , "None"));
Path.Add(new Vector3(-2866.637 , 5322.78 , -9.789199 , "None"));
Path.Add(new Vector3(-2869.862 , 5329.307 , -9.987843 , "None"));
Path.Add(new Vector3(-2871.884 , 5333.785 , -10.10539 , "None"));
Path.Add(new Vector3(-2875.681 , 5343.46 , -10.32508 , "None"));
Path.Add(new Vector3(-2879.616 , 5353.647 , -10.59353 , "None"));
Path.Add(new Vector3(-2881.958 , 5363.077 , -10.51305 , "None"));
Path.Add(new Vector3(-2880.614 , 5365.217 , -10.31942 , "None"));
Path.Add(new Vector3(-2880.426 , 5370.593 , -9.968604 , "None"));
Path.Add(new Vector3(-2880.936 , 5374.104 , -9.746981 , "None"));
Path.Add(new Vector3(-2886.05 , 5377.151 , -9.507015 , "None"));
Path.Add(new Vector3(-2896.753 , 5378.971 , -9.432251 , "None"));
Path.Add(new Vector3(-2900.024 , 5379.528 , -9.432251 , "None"));
Path.Add(new Vector3(-2899.508 , 5383.76 , -9.432251 , "None"));
Path.Add(new Vector3(-2898.001 , 5388.563 , -9.173675 , "None"));
Path.Add(new Vector3(-2897.907 , 5394.084 , -8.92998 , "None"));
Path.Add(new Vector3(-2897.63 , 5398.359 , -9.993543 , "None"));
Path.Add(new Vector3(-2897.606 , 5401.131 , -12.11498 , "None"));
Path.Add(new Vector3(-2898.094 , 5406.379 , -16.14227 , "None"));
Path.Add(new Vector3(-2898.157 , 5411.313 , -18.59068 , "None"));
Path.Add(new Vector3(-2894.776 , 5412.704 , -18.59068 , "None"));
Path.Add(new Vector3(-2889.926 , 5412.825 , -20.6228 , "None"));
Path.Add(new Vector3(-2887.431 , 5412.957 , -22.3567 , "None"));
Path.Add(new Vector3(-2884.286 , 5413.138 , -24.5423 , "None"));
Path.Add(new Vector3(-2882.022 , 5413.269 , -26.11657 , "None"));
Path.Add(new Vector3(-2879.209 , 5413.184 , -28.06759 , "None"));
Path.Add(new Vector3(-2875.37 , 5413.253 , -28.2611 , "None"));
Path.Add(new Vector3(-2869.843 , 5413.987 , -28.2611 , "None"));
Path.Add(new Vector3(-2863.519 , 5417.168 , -28.2611 , "None"));
Path.Add(new Vector3(-2860.716 , 5419.522 , -28.2611 , "None"));
Path.Add(new Vector3(-2855.729 , 5421.953 , -28.26092 , "None"));
Path.Add(new Vector3(-2853.997 , 5424.573 , -28.25814 , "None"));
Path.Add(new Vector3(-2854.909 , 5428.328 , -28.25814 , "None"));
Path.Add(new Vector3(-2857.966 , 5431.977 , -28.25814 , "None"));
Path.Add(new Vector3(-2861.984 , 5435.562 , -28.25814 , "None"));
Path.Add(new Vector3(-2862.637 , 5439.02 , -28.97162 , "None"));
Path.Add(new Vector3(-2862.564 , 5442.211 , -30.18863 , "None"));
Path.Add(new Vector3(-2859.156 , 5445.1 , -30.18863 , "None"));
Path.Add(new Vector3(-2855.199 , 5445.958 , -30.18863 , "None"));
Path.Add(new Vector3(-2847.668 , 5446.618 , -30.19017 , "None"));
Path.Add(new Vector3(-2845.939 , 5449.754 , -30.19005 , "None"));
Path.Add(new Vector3(-2847.789 , 5455.004 , -30.18994 , "None"));
Path.Add(new Vector3(-2849.81 , 5458.826 , -30.18994 , "None"));
Path.Add(new Vector3(-2850.801 , 5462.854 , -30.18991 , "None"));
Path.Add(new Vector3(-2850.964 , 5467.051 , -30.18981 , "None"));
Path.Add(new Vector3(-2851.831 , 5472.19 , -30.18948 , "None"));
Path.Add(new Vector3(-2852.762 , 5474.823 , -30.18933 , "None"));
Path.Add(new Vector3(-2856.42 , 5478.932 , -30.18918 , "None"));
Path.Add(new Vector3(-2858.315 , 5480.625 , -30.18916 , "None"));
IsCompleteWhenAtLastPath = false;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class TheShadowTombGetGavelofKalen : QuestGathererClass
{
    public TheShadowTombGetGavelofKalen()
    {
        Name = "The Shadow Tomb - Get Gavel of Kalen";

        QuestId.AddRange(new[] { 10881 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(185225);
HotSpots.Add(new Vector3(-2860.47 , 5481.2 , -30.18707 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(31710) >= 1;
}






}


public sealed class TheShadowTombGETDRAPE : QuestGathererClass
{
    public TheShadowTombGETDRAPE()
    {
        Name = "The Shadow Tomb - GET DRAPE";

        QuestId.AddRange(new[] { 10881 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(185226);
HotSpots.Add(new Vector3(-2844.556 , 5350.708 , -30.54077 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(31709) >= 1;
}






}


public sealed class TheShadowTomb : QuestGathererClass
{
    public TheShadowTomb()
    {
        Name = "The Shadow Tomb";

        QuestId.AddRange(new[] { 10881 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10880;

        EntryIdObjects.Add(185224);
HotSpots.Add(new Vector3(-2679.862 , 5404.445 , -36.42067 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNShadowTomeRIGHTITEM : QuestFollowPathClass
{
    public RUNShadowTomeRIGHTITEM()
    {
        Name = "RUN: Shadow Tome - RIGHT ITEM";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2853.645 , 5476.091 , -30.18707 , "None"));
Path.Add(new Vector3(-2854.087 , 5471.388 , -30.18707 , "None"));
Path.Add(new Vector3(-2854.353 , 5464.526 , -30.18861 , "None"));
Path.Add(new Vector3(-2854.379 , 5453.712 , -30.18861 , "None"));
Path.Add(new Vector3(-2854.312 , 5446.531 , -30.19015 , "None"));
Path.Add(new Vector3(-2854.304 , 5443.045 , -29.55561 , "None"));
Path.Add(new Vector3(-2854.728 , 5437.938 , -28.2577 , "None"));
Path.Add(new Vector3(-2855.007 , 5427.777 , -28.2577 , "None"));
Path.Add(new Vector3(-2855.371 , 5421.992 , -28.25924 , "None"));
Path.Add(new Vector3(-2854.82 , 5416.37 , -28.26078 , "None"));
Path.Add(new Vector3(-2854.156 , 5412.457 , -28.26078 , "None"));
Path.Add(new Vector3(-2853.608 , 5406.856 , -28.25978 , "None"));
Path.Add(new Vector3(-2853.167 , 5402.362 , -28.25886 , "None"));
Path.Add(new Vector3(-2854.859 , 5399.267 , -28.25886 , "None"));
Path.Add(new Vector3(-2850.396 , 5394.807 , -28.25886 , "None"));
Path.Add(new Vector3(-2844.935 , 5393.203 , -28.25886 , "None"));
Path.Add(new Vector3(-2851.072 , 5390.608 , -28.25756 , "None"));
Path.Add(new Vector3(-2857.233 , 5390.609 , -28.25756 , "None"));
Path.Add(new Vector3(-2860.916 , 5389.975 , -28.50189 , "None"));
Path.Add(new Vector3(-2860.439 , 5383.84 , -30.18857 , "None"));
Path.Add(new Vector3(-2858.544 , 5380.63 , -30.18857 , "None"));
Path.Add(new Vector3(-2854.546 , 5376.639 , -30.18857 , "None"));
Path.Add(new Vector3(-2850.279 , 5372.413 , -30.18857 , "None"));
Path.Add(new Vector3(-2848.569 , 5360.914 , -30.18857 , "None"));
Path.Add(new Vector3(-2847.052 , 5351.695 , -30.45738 , "None"));
Path.Add(new Vector3(-2846.722 , 5350.339 , -30.4137 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNShadowTomeGetMiddleItem : QuestFollowPathClass
{
    public RUNShadowTomeGetMiddleItem()
    {
        Name = "RUN: Shadow Tome - Get Middle Item";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2896.213 , 5393.259 , -8.962063 , "None"));
Path.Add(new Vector3(-2896.477 , 5397.03 , -8.955199 , "None"));
Path.Add(new Vector3(-2897.966 , 5414.039 , -18.5897 , "None"));
Path.Add(new Vector3(-2893.689 , 5412.964 , -18.5897 , "None"));
Path.Add(new Vector3(-2887.929 , 5413.374 , -22.01696 , "None"));
Path.Add(new Vector3(-2884.451 , 5413.688 , -24.43662 , "None"));
Path.Add(new Vector3(-2880.823 , 5413.774 , -26.95638 , "None"));
Path.Add(new Vector3(-2877.376 , 5413.088 , -28.26168 , "None"));
Path.Add(new Vector3(-2872.219 , 5413.545 , -28.26168 , "None"));
Path.Add(new Vector3(-2868.56 , 5413.665 , -28.26168 , "None"));
Path.Add(new Vector3(-2861.98 , 5412.84 , -28.26168 , "None"));
Path.Add(new Vector3(-2858.335 , 5412.767 , -28.26168 , "None"));
Path.Add(new Vector3(-2851.4 , 5413.283 , -28.26128 , "None"));
Path.Add(new Vector3(-2847.847 , 5413.431 , -28.26016 , "None"));
Path.Add(new Vector3(-2840.691 , 5413.858 , -28.26016 , "None"));
Path.Add(new Vector3(-2833.704 , 5414.278 , -28.2617 , "None"));
Path.Add(new Vector3(-2830.158 , 5414.423 , -28.2617 , "None"));
Path.Add(new Vector3(-2826.681 , 5414.53 , -28.77345 , "None"));
Path.Add(new Vector3(-2823.084 , 5414.638 , -30.93082 , "None"));
Path.Add(new Vector3(-2819.439 , 5414.747 , -33.11796 , "None"));
Path.Add(new Vector3(-2816.102 , 5414.864 , -34.53465 , "None"));
Path.Add(new Vector3(-2812.606 , 5415.13 , -34.53465 , "None"));
Path.Add(new Vector3(-2808.928 , 5415.551 , -34.53618 , "None"));
Path.Add(new Vector3(-2802.511 , 5415.88 , -34.53618 , "None"));
Path.Add(new Vector3(-2795.422 , 5415.588 , -34.53618 , "None"));
Path.Add(new Vector3(-2791.881 , 5415.356 , -34.53618 , "None"));
Path.Add(new Vector3(-2784.846 , 5415.366 , -34.53772 , "None"));
Path.Add(new Vector3(-2781.202 , 5415.639 , -34.53772 , "None"));
Path.Add(new Vector3(-2775.74 , 5416.982 , -34.53772 , "None"));
Path.Add(new Vector3(-2770.684 , 5420.312 , -34.53772 , "None"));
Path.Add(new Vector3(-2768.413 , 5423.078 , -34.53772 , "None"));
Path.Add(new Vector3(-2764.882 , 5429.245 , -34.53772 , "None"));
Path.Add(new Vector3(-2760.023 , 5429.715 , -34.60958 , "None"));
Path.Add(new Vector3(-2761.568 , 5426.43 , -36.02665 , "None"));
Path.Add(new Vector3(-2759.07 , 5422.87 , -36.46962 , "None"));
Path.Add(new Vector3(-2758.822 , 5419.373 , -36.46962 , "None"));
Path.Add(new Vector3(-2759.188 , 5413.85 , -36.21231 , "None"));
Path.Add(new Vector3(-2759.884 , 5410.299 , -36.47115 , "None"));
Path.Add(new Vector3(-2760.163 , 5406.608 , -36.47115 , "None"));
Path.Add(new Vector3(-2755.616 , 5407.991 , -36.47086 , "None"));
Path.Add(new Vector3(-2751.155 , 5413.113 , -36.47085 , "None"));
Path.Add(new Vector3(-2747.925 , 5416.312 , -36.47084 , "None"));
Path.Add(new Vector3(-2744.152 , 5422.288 , -36.47067 , "None"));
Path.Add(new Vector3(-2740.037 , 5424.376 , -36.47057 , "None"));
Path.Add(new Vector3(-2736.511 , 5418.63 , -36.47056 , "None"));
Path.Add(new Vector3(-2734.932 , 5415.266 , -36.47056 , "None"));
Path.Add(new Vector3(-2733.306 , 5412.125 , -36.47056 , "None"));
Path.Add(new Vector3(-2728.835 , 5407.37 , -36.46927 , "None"));
Path.Add(new Vector3(-2724.999 , 5411.389 , -36.46927 , "None"));
Path.Add(new Vector3(-2721.581 , 5417.489 , -36.46903 , "None"));
Path.Add(new Vector3(-2719.432 , 5420.386 , -36.46902 , "None"));
Path.Add(new Vector3(-2714.959 , 5423.239 , -36.46902 , "None"));
Path.Add(new Vector3(-2711.602 , 5424.339 , -36.46902 , "None"));
Path.Add(new Vector3(-2704.951 , 5422.602 , -36.46902 , "None"));
Path.Add(new Vector3(-2701.653 , 5421.064 , -36.46902 , "None"));
Path.Add(new Vector3(-2695.158 , 5418.38 , -37.03858 , "None"));
Path.Add(new Vector3(-2691.441 , 5416.144 , -37.03858 , "None"));
Path.Add(new Vector3(-2688.583 , 5413.957 , -37.03858 , "None"));
Path.Add(new Vector3(-2685.9 , 5411.59 , -37.03858 , "None"));
Path.Add(new Vector3(-2682.947 , 5408.959 , -36.59495 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNShadowTomeAllItemsRUNOUT : QuestFollowPathClass
{
    public RUNShadowTomeAllItemsRUNOUT()
    {
        Name = "RUN: Shadow Tome - All Items - RUN OUT";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2707.206 , 5418.003 , -36.46885 , "None"));
Path.Add(new Vector3(-2712.39 , 5417.854 , -36.46885 , "None"));
Path.Add(new Vector3(-2718.054 , 5417.593 , -36.46863 , "None"));
Path.Add(new Vector3(-2723.613 , 5417.338 , -36.46863 , "None"));
Path.Add(new Vector3(-2727.592 , 5417.154 , -36.46863 , "None"));
Path.Add(new Vector3(-2731.179 , 5416.989 , -36.46863 , "None"));
Path.Add(new Vector3(-2734.759 , 5416.825 , -36.46863 , "None"));
Path.Add(new Vector3(-2738.291 , 5416.662 , -36.46863 , "None"));
Path.Add(new Vector3(-2744.247 , 5416.642 , -36.46863 , "None"));
Path.Add(new Vector3(-2747.892 , 5416.529 , -36.46863 , "None"));
Path.Add(new Vector3(-2754.819 , 5416.314 , -36.47017 , "None"));
Path.Add(new Vector3(-2758.422 , 5416.203 , -36.47017 , "None"));
Path.Add(new Vector3(-2762.039 , 5416.091 , -34.53802 , "None"));
Path.Add(new Vector3(-2765.552 , 5415.982 , -34.53802 , "None"));
Path.Add(new Vector3(-2772.216 , 5414.776 , -34.53802 , "None"));
Path.Add(new Vector3(-2775.848 , 5414.884 , -34.53802 , "None"));
Path.Add(new Vector3(-2779.683 , 5415.803 , -34.53802 , "None"));
Path.Add(new Vector3(-2783.396 , 5416.303 , -34.53802 , "None"));
Path.Add(new Vector3(-2786.856 , 5415.507 , -34.53799 , "None"));
Path.Add(new Vector3(-2793.037 , 5415.129 , -34.53739 , "None"));
Path.Add(new Vector3(-2796.563 , 5415.23 , -34.53706 , "None"));
Path.Add(new Vector3(-2800.188 , 5415.336 , -34.53706 , "None"));
Path.Add(new Vector3(-2807.263 , 5415.474 , -34.53704 , "None"));
Path.Add(new Vector3(-2810.798 , 5415.478 , -34.53704 , "None"));
Path.Add(new Vector3(-2814.382 , 5415.481 , -34.53631 , "None"));
Path.Add(new Vector3(-2821.323 , 5414.838 , -31.98939 , "None"));
Path.Add(new Vector3(-2824.858 , 5414.867 , -29.87057 , "None"));
Path.Add(new Vector3(-2828.323 , 5414.895 , -28.26163 , "None"));
Path.Add(new Vector3(-2831.949 , 5414.924 , -28.26163 , "None"));
Path.Add(new Vector3(-2836.14 , 5415.145 , -28.26163 , "None"));
Path.Add(new Vector3(-2840.74 , 5415.907 , -28.26141 , "None"));
Path.Add(new Vector3(-2844.778 , 5418.7 , -28.26091 , "None"));
Path.Add(new Vector3(-2848.374 , 5421.504 , -28.26068 , "None"));
Path.Add(new Vector3(-2851.88 , 5424.43 , -28.25829 , "None"));
Path.Add(new Vector3(-2856.553 , 5422.432 , -28.25829 , "None"));
Path.Add(new Vector3(-2859.88 , 5421.312 , -28.26188 , "None"));
Path.Add(new Vector3(-2863.432 , 5420.737 , -28.26188 , "None"));
Path.Add(new Vector3(-2866.745 , 5419.283 , -28.26188 , "None"));
Path.Add(new Vector3(-2872.744 , 5415.597 , -28.26145 , "None"));
Path.Add(new Vector3(-2879.5 , 5413.437 , -27.87011 , "None"));
Path.Add(new Vector3(-2882.812 , 5412.756 , -25.56066 , "None"));
Path.Add(new Vector3(-2886.484 , 5412.389 , -23.00587 , "None"));
Path.Add(new Vector3(-2890.037 , 5412.526 , -20.54122 , "None"));
Path.Add(new Vector3(-2893.45 , 5412.255 , -18.5906 , "None"));
Path.Add(new Vector3(-2895.105 , 5406.332 , -16.05643 , "None"));
Path.Add(new Vector3(-2895.407 , 5402.836 , -13.38412 , "None"));
Path.Add(new Vector3(-2895.583 , 5400.001 , -11.21604 , "None"));
Path.Add(new Vector3(-2893.941 , 5397.059 , -8.93629 , "None"));
Path.Add(new Vector3(-2891.831 , 5395.349 , -8.871401 , "None"));
Path.Add(new Vector3(-2889.161 , 5393.221 , -8.993052 , "None"));
Path.Add(new Vector3(-2890.511 , 5389.818 , -9.126506 , "None"));
Path.Add(new Vector3(-2891.438 , 5387.244 , -9.241484 , "None"));
Path.Add(new Vector3(-2891.788 , 5384.357 , -9.430888 , "None"));
Path.Add(new Vector3(-2891.601 , 5381.8 , -9.430888 , "None"));
Path.Add(new Vector3(-2890.49 , 5377.619 , -9.430888 , "None"));
Path.Add(new Vector3(-2888.718 , 5372.716 , -9.490432 , "None"));
Path.Add(new Vector3(-2886.579 , 5367.75 , -9.781469 , "None"));
Path.Add(new Vector3(-2885.092 , 5363.922 , -10.38151 , "None"));
Path.Add(new Vector3(-2883.154 , 5358.896 , -10.79933 , "None"));
Path.Add(new Vector3(-2882.161 , 5356.32 , -10.79503 , "None"));
Path.Add(new Vector3(-2878.53 , 5346.906 , -10.57166 , "None"));
Path.Add(new Vector3(-2874.59 , 5336.744 , -10.27382 , "None"));
Path.Add(new Vector3(-2870.176 , 5326.785 , -9.975161 , "None"));
Path.Add(new Vector3(-2865.334 , 5317.5 , -9.670607 , "None"));
Path.Add(new Vector3(-2860.162 , 5307.999 , -9.460323 , "None"));
Path.Add(new Vector3(-2855.864 , 5298.723 , -9.49396 , "None"));
Path.Add(new Vector3(-2851.366 , 5288.683 , -9.708518 , "None"));
Path.Add(new Vector3(-2846.899 , 5279.273 , -9.869689 , "None"));
Path.Add(new Vector3(-2842.746 , 5270.528 , -9.733191 , "None"));
Path.Add(new Vector3(-2835.223 , 5253.907 , -9.418188 , "None"));
Path.Add(new Vector3(-2831.329 , 5244.382 , -8.430546 , "None"));
Path.Add(new Vector3(-2827.402 , 5234.442 , -10.65054 , "None"));
Path.Add(new Vector3(-2824.019 , 5224.813 , -10.707 , "None"));
Path.Add(new Vector3(-2820.426 , 5214.59 , -10.74858 , "None"));
Path.Add(new Vector3(-2816.743 , 5204.109 , -10.86715 , "None"));
Path.Add(new Vector3(-2813.22 , 5194.084 , -11.04423 , "None"));
Path.Add(new Vector3(-2809.793 , 5184.03 , -11.08735 , "None"));
Path.Add(new Vector3(-2808.43 , 5173.313 , -11.38198 , "None"));
Path.Add(new Vector3(-2807.579 , 5163.564 , -11.78492 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class AHeroIsNeeded : QuestGrinderClass
{
    public AHeroIsNeeded()
    {
        Name = "A Hero Is Needed";

        QuestId.AddRange(new[] { 10914 });

        Step = new List<int> { 12, 5, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10913;

        EntryTarget.Add(21285);
EntryTarget.Add(21284);
HotSpots.Add(new Vector3(-3355.955 , 4476.208 , -21.53279 , "None"));
HotSpots.Add(new Vector3(-3488.198 , 4387.098 , -20.32534 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AHeroIsNeededInitiates : QuestGrinderClass
{
    public AHeroIsNeededInitiates()
    {
        Name = "A Hero Is Needed - Initiates";

        QuestId.AddRange(new[] { 10914 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(21284);
EntryTarget.Add(21285);
HotSpots.Add(new Vector3(-3700.63 , 5132.348 , -21.09394 , "None"));
HotSpots.Add(new Vector3(-3671.676 , 5047.492 , -21.16897 , "None"));
HotSpots.Add(new Vector3(-3633.883 , 5275.274 , -22.26432 , "None"));
HotSpots.Add(new Vector3(-3524.75 , 5320.587 , -19.55583 , "None"));
HotSpots.Add(new Vector3(-3462.004 , 5259.404 , -20.77258 , "None"));
HotSpots.Add(new Vector3(-3695.661 , 5129.561 , -21.43265 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class TheFallenExarch : QuestGathererClass
{
    public TheFallenExarch()
    {
        Name = "The Fallen Exarch";

        QuestId.AddRange(new[] { 10915 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10914;

        EntryIdObjects.Add(184999);
HotSpots.Add(new Vector3(-3365.646 , 5144.297 , -8.433946 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheFallenExarchRUNTO : QuestFollowPathClass
{
    public TheFallenExarchRUNTO()
    {
        Name = "The Fallen Exarch - RUN TO";

        QuestId.AddRange(new[] { 10915 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3682.765 , 5373.748 , -10.51649 , "None"));
Path.Add(new Vector3(-3654.684 , 5375.561 , -12.96438 , "None"));
Path.Add(new Vector3(-3619.761 , 5376.164 , -14.98675 , "None"));
Path.Add(new Vector3(-3587.174 , 5372.401 , -16.99424 , "None"));
Path.Add(new Vector3(-3562.344 , 5365.675 , -18.0393 , "None"));
Path.Add(new Vector3(-3548.982 , 5369.789 , -18.37704 , "None"));
Path.Add(new Vector3(-3529.727 , 5357.672 , -18.70298 , "None"));
Path.Add(new Vector3(-3511.91 , 5358.751 , -18.48539 , "None"));
Path.Add(new Vector3(-3496.771 , 5357.56 , -17.95295 , "None"));
Path.Add(new Vector3(-3488.018 , 5346.992 , -16.14205 , "None"));
Path.Add(new Vector3(-3478.502 , 5313.456 , -18.92892 , "None"));
Path.Add(new Vector3(-3475.043 , 5301.267 , -19.50226 , "None"));
Path.Add(new Vector3(-3463.559 , 5289.22 , -20.07355 , "None"));
Path.Add(new Vector3(-3454.553 , 5279.436 , -20.70644 , "None"));
Path.Add(new Vector3(-3437.675 , 5261.967 , -21.10679 , "None"));
Path.Add(new Vector3(-3435.958 , 5253.96 , -20.90815 , "None"));
Path.Add(new Vector3(-3434.656 , 5238.826 , -21.92963 , "None"));
Path.Add(new Vector3(-3431.25 , 5231.484 , -21.25425 , "None"));
Path.Add(new Vector3(-3427.122 , 5221.352 , -20.38136 , "None"));
Path.Add(new Vector3(-3423.209 , 5211.747 , -21.64254 , "None"));
Path.Add(new Vector3(-3418.375 , 5201.929 , -22.22111 , "None"));
Path.Add(new Vector3(-3414.016 , 5198.708 , -22.40384 , "None"));
Path.Add(new Vector3(-3406.885 , 5191.036 , -22.53204 , "None"));
Path.Add(new Vector3(-3403.287 , 5180.69 , -22.69219 , "None"));
Path.Add(new Vector3(-3396.977 , 5172.506 , -18.10518 , "None"));
Path.Add(new Vector3(-3390.968 , 5168.351 , -14.56871 , "None"));
Path.Add(new Vector3(-3397.032 , 5166.682 , -13.66684 , "None"));
Path.Add(new Vector3(-3403.116 , 5164.706 , -12.59376 , "None"));
Path.Add(new Vector3(-3405.009 , 5160.586 , -9.584068 , "None"));
Path.Add(new Vector3(-3409.479 , 5157.201 , -9.083497 , "None"));
Path.Add(new Vector3(-3403.54 , 5156.666 , -9.12456 , "None"));
Path.Add(new Vector3(-3396.643 , 5159.603 , -9.038958 , "None"));
Path.Add(new Vector3(-3392.889 , 5159.887 , -9.040586 , "None"));
Path.Add(new Vector3(-3389.11 , 5160.59 , -9.001435 , "None"));
Path.Add(new Vector3(-3385.761 , 5157.11 , -9.015808 , "None"));
Path.Add(new Vector3(-3384.04 , 5151.845 , -9.08459 , "None"));
Path.Add(new Vector3(-3382.209 , 5145.816 , -9.166204 , "None"));
Path.Add(new Vector3(-3380.734 , 5141.604 , -9.175095 , "None"));
Path.Add(new Vector3(-3376.833 , 5137.37 , -9.139112 , "None"));
Path.Add(new Vector3(-3371.856 , 5133.865 , -9.093119 , "None"));
Path.Add(new Vector3(-3367.069 , 5131.374 , -9.048998 , "None"));
Path.Add(new Vector3(-3362.315 , 5130.739 , -9.005197 , "None"));
Path.Add(new Vector3(-3357.094 , 5130.453 , -9.030793 , "None"));
Path.Add(new Vector3(-3351.489 , 5130.576 , -9.029241 , "None"));
Path.Add(new Vector3(-3343.512 , 5134.73 , -9.113417 , "None"));
Path.Add(new Vector3(-3342.046 , 5139.367 , -9.179117 , "None"));
Path.Add(new Vector3(-3340.973 , 5149.583 , -9.109973 , "None"));
Path.Add(new Vector3(-3343.924 , 5155.681 , -9.000214 , "None"));
Path.Add(new Vector3(-3347.859 , 5155.37 , -9.000214 , "None"));
Path.Add(new Vector3(-3351.801 , 5155.152 , -9.000214 , "None"));
Path.Add(new Vector3(-3355.594 , 5154.907 , -9.000214 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNEyeofReskk : QuestFollowPathClass
{
    public RUNEyeofReskk()
    {
        Name = "RUN - Eye of Reskk";

        QuestId.AddRange(new[] { 10847 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-1848.273 , 4863.998 , -0.5487266 , "None"));
Path.Add(new Vector3(-1829.659 , 4854.753 , 3.534388 , "None"));
Path.Add(new Vector3(-1806.446 , 4839.968 , 2.281016 , "None"));
Path.Add(new Vector3(-1782.045 , 4821.273 , 6.565985 , "None"));
Path.Add(new Vector3(-1754.559 , 4798.279 , 9.371284 , "None"));
Path.Add(new Vector3(-1738.126 , 4783.894 , 7.734907 , "None"));
Path.Add(new Vector3(-1709.978 , 4758.36 , 0.534699 , "None"));
Path.Add(new Vector3(-1687.704 , 4738.584 , 2.937678 , "None"));
Path.Add(new Vector3(-1684.971 , 4717.52 , 3.129614 , "None"));
Path.Add(new Vector3(-1690.913 , 4694.188 , 4.361567 , "None"));
Path.Add(new Vector3(-1682.093 , 4661.851 , 4.052598 , "None"));
Path.Add(new Vector3(-1684.727 , 4628.212 , 2.190887 , "None"));
Path.Add(new Vector3(-1691.069 , 4605.406 , 0.5360063 , "None"));
Path.Add(new Vector3(-1702.186 , 4587.914 , 1.423726 , "None"));
Path.Add(new Vector3(-1728.697 , 4561.621 , 4.172777 , "None"));
Path.Add(new Vector3(-1744.462 , 4543.175 , 6.199677 , "None"));
Path.Add(new Vector3(-1744.817 , 4527.737 , 3.098622 , "None"));
Path.Add(new Vector3(-1732.807 , 4498.617 , 1.506988 , "None"));
Path.Add(new Vector3(-1729.188 , 4476.37 , 1.110067 , "None"));
Path.Add(new Vector3(-1708.843 , 4465.055 , 4.276633 , "None"));
Path.Add(new Vector3(-1690.184 , 4462.358 , 9.469718 , "None"));
Path.Add(new Vector3(-1676.26 , 4453.105 , 13.69365 , "None"));
Path.Add(new Vector3(-1659.776 , 4448.927 , 15.76878 , "None"));
Path.Add(new Vector3(-1647.807 , 4451.497 , 18.50936 , "None"));
Path.Add(new Vector3(-1644.11 , 4451.807 , 19.16106 , "None"));
Path.Add(new Vector3(-1638.673 , 4453.13 , 19.40137 , "None"));
Path.Add(new Vector3(-1634.974 , 4453.09 , 19.72784 , "None"));
Path.Add(new Vector3(-1631.734 , 4452.009 , 20.87189 , "None"));
Path.Add(new Vector3(-1628.339 , 4450.64 , 22.31664 , "None"));
Path.Add(new Vector3(-1625.349 , 4449.067 , 23.32561 , "None"));
Path.Add(new Vector3(-1621.493 , 4446.87 , 24.06251 , "None"));
Path.Add(new Vector3(-1619.776 , 4444.119 , 24.19364 , "None"));
Path.Add(new Vector3(-1615.956 , 4445.09 , 24.19364 , "None"));
Path.Add(new Vector3(-1612.991 , 4443.188 , 24.19364 , "None"));
Path.Add(new Vector3(-1608.835 , 4439.173 , 24.19322 , "None"));
Path.Add(new Vector3(-1606.67 , 4436.334 , 24.19322 , "None"));
Path.Add(new Vector3(-1605.027 , 4433.293 , 24.19322 , "None"));
Path.Add(new Vector3(-1604.484 , 4429.723 , 24.19322 , "None"));
Path.Add(new Vector3(-1604.192 , 4426.256 , 24.19322 , "None"));
Path.Add(new Vector3(-1604.079 , 4422.724 , 24.88889 , "None"));
Path.Add(new Vector3(-1604.827 , 4419.511 , 25.91188 , "None"));
Path.Add(new Vector3(-1605.089 , 4416.024 , 27.4661 , "None"));
Path.Add(new Vector3(-1604.167 , 4412.883 , 28.97689 , "None"));
Path.Add(new Vector3(-1602.088 , 4409.898 , 30.66809 , "None"));
Path.Add(new Vector3(-1598.891 , 4409.154 , 31.69191 , "None"));
Path.Add(new Vector3(-1596.013 , 4408.334 , 32.43234 , "None"));
Path.Add(new Vector3(-1593.11 , 4406.113 , 33.33993 , "None"));
Path.Add(new Vector3(-1590.763 , 4403.526 , 34.13494 , "None"));
Path.Add(new Vector3(-1588.603 , 4400.69 , 34.77411 , "None"));
Path.Add(new Vector3(-1588.202 , 4397.687 , 34.91984 , "None"));
Path.Add(new Vector3(-1584.69 , 4397.539 , 35.54273 , "None"));
Path.Add(new Vector3(-1581.142 , 4396.698 , 36.38556 , "None"));
Path.Add(new Vector3(-1577.752 , 4395.915 , 37.14426 , "None"));
Path.Add(new Vector3(-1574.253 , 4395.107 , 37.8806 , "None"));
Path.Add(new Vector3(-1570.783 , 4394.128 , 38.5121 , "None"));
Path.Add(new Vector3(-1568.457 , 4391.884 , 39.0505 , "None"));
Path.Add(new Vector3(-1573.296 , 4385.94 , 37.759 , "None"));
Path.Add(new Vector3(-1578.634 , 4383.648 , 36.89153 , "None"));
Path.Add(new Vector3(-1582.196 , 4383.233 , 36.11056 , "None"));
Path.Add(new Vector3(-1585.104 , 4382.012 , 35.65655 , "None"));
Path.Add(new Vector3(-1588.656 , 4382.688 , 35.11553 , "None"));
Path.Add(new Vector3(-1591.024 , 4384.901 , 34.74801 , "None"));
Path.Add(new Vector3(-1594.959 , 4389.47 , 34.25782 , "None"));
Path.Add(new Vector3(-1597.074 , 4392.258 , 35.46815 , "None"));
Path.Add(new Vector3(-1599.177 , 4395.109 , 38.12366 , "None"));
Path.Add(new Vector3(-1601.302 , 4398.012 , 41.11458 , "None"));
Path.Add(new Vector3(-1603.241 , 4400.662 , 43.98844 , "None"));
Path.Add(new Vector3(-1605.618 , 4403.725 , 47.94287 , "None"));
Path.Add(new Vector3(-1607.791 , 4406.363 , 51.04028 , "None"));
Path.Add(new Vector3(-1609.642 , 4408.994 , 52.63806 , "None"));
Path.Add(new Vector3(-1610.328 , 4413.715 , 52.63869 , "None"));
Path.Add(new Vector3(-1609.871 , 4418.509 , 52.76286 , "None"));
Path.Add(new Vector3(-1609.431 , 4422.016 , 53.02499 , "None"));
Path.Add(new Vector3(-1608.913 , 4425.541 , 52.7916 , "None"));
Path.Add(new Vector3(-1609.231 , 4428.908 , 52.62038 , "None"));
Path.Add(new Vector3(-1611.224 , 4431.177 , 52.94445 , "None"));
Path.Add(new Vector3(-1614.499 , 4433.982 , 52.89297 , "None"));
Path.Add(new Vector3(-1617.281 , 4436.11 , 52.61686 , "None"));
Path.Add(new Vector3(-1620.77 , 4435.495 , 52.87078 , "None"));
Path.Add(new Vector3(-1623.889 , 4434.188 , 53.21593 , "None"));
Path.Add(new Vector3(-1627.162 , 4432.816 , 52.88127 , "None"));
Path.Add(new Vector3(-1629.239 , 4429.903 , 53.04358 , "None"));
Path.Add(new Vector3(-1630.732 , 4426.783 , 52.88678 , "None"));
Path.Add(new Vector3(-1631.431 , 4423.43 , 52.68878 , "None"));
Path.Add(new Vector3(-1634.068 , 4418.108 , 52.01586 , "None"));
Path.Add(new Vector3(-1640.208 , 4416.061 , 50.23412 , "None"));
Path.Add(new Vector3(-1643.329 , 4414.715 , 48.56258 , "None"));
Path.Add(new Vector3(-1646.129 , 4412.342 , 47.18079 , "None"));
Path.Add(new Vector3(-1648.738 , 4409.916 , 46.21889 , "None"));
Path.Add(new Vector3(-1651.493 , 4407.592 , 45.58215 , "None"));
Path.Add(new Vector3(-1654.384 , 4405.369 , 45.40352 , "None"));
Path.Add(new Vector3(-1657.143 , 4403.392 , 45.40352 , "None"));
Path.Add(new Vector3(-1660.142 , 4401.378 , 45.94776 , "None"));
Path.Add(new Vector3(-1663.105 , 4399.362 , 46.6069 , "None"));
Path.Add(new Vector3(-1665.879 , 4397.38 , 47.70446 , "None"));
Path.Add(new Vector3(-1668.793 , 4395.293 , 49.11276 , "None"));
Path.Add(new Vector3(-1671.342 , 4393.467 , 51.0416 , "None"));
Path.Add(new Vector3(-1674.047 , 4391.631 , 52.57729 , "None"));
Path.Add(new Vector3(-1676.272 , 4388.729 , 52.64198 , "None"));
Path.Add(new Vector3(-1676.949 , 4385.532 , 52.63839 , "None"));
Path.Add(new Vector3(-1677.823 , 4382.144 , 53.13951 , "None"));
Path.Add(new Vector3(-1678.854 , 4378.711 , 53.36283 , "None"));
Path.Add(new Vector3(-1679.898 , 4375.239 , 53.22116 , "None"));
Path.Add(new Vector3(-1681.608 , 4372.236 , 52.93782 , "None"));
Path.Add(new Vector3(-1684.297 , 4370.027 , 52.61522 , "None"));
Path.Add(new Vector3(-1687.475 , 4368.927 , 52.57287 , "None"));
Path.Add(new Vector3(-1691.299 , 4369.188 , 52.52364 , "None"));
Path.Add(new Vector3(-1694.538 , 4370.361 , 52.54796 , "None"));
Path.Add(new Vector3(-1697.354 , 4372.322 , 52.55637 , "None"));
Path.Add(new Vector3(-1699.953 , 4374.826 , 52.58104 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class TheEyesofSkettisEyeofReskk : QuestGathererClass
{
    public TheEyesofSkettisEyeofReskk()
    {
        Name = "The Eyes of Skettis - Eye of Reskk";

        QuestId.AddRange(new[] { 10847 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10908;

        EntryIdObjects.Add(185200);
HotSpots.Add(new Vector3(-1698.38 , 4376.609 , 53.25294 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(25638) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class RUNEyeofSheilenor : QuestFollowPathClass
{
    public RUNEyeofSheilenor()
    {
        Name = "RUN: Eye of Sheilenor";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-1700.718 , 4379.665 , 52.69012 , "None"));
Path.Add(new Vector3(-1699.339 , 4383.032 , 53.14418 , "None"));
Path.Add(new Vector3(-1697.057 , 4385.922 , 53.40024 , "None"));
Path.Add(new Vector3(-1694.637 , 4388.615 , 53.41188 , "None"));
Path.Add(new Vector3(-1691.935 , 4390.908 , 53.26185 , "None"));
Path.Add(new Vector3(-1688.97 , 4392.775 , 52.62614 , "None"));
Path.Add(new Vector3(-1685.659 , 4394.002 , 52.63132 , "None"));
Path.Add(new Vector3(-1682.331 , 4393.359 , 52.63599 , "None"));
Path.Add(new Vector3(-1678.872 , 4392.016 , 52.63997 , "None"));
Path.Add(new Vector3(-1676.003 , 4390.545 , 52.64399 , "None"));
Path.Add(new Vector3(-1672.467 , 4391.074 , 52.4698 , "None"));
Path.Add(new Vector3(-1669.655 , 4393.263 , 50.3014 , "None"));
Path.Add(new Vector3(-1667.184 , 4395.67 , 48.3709 , "None"));
Path.Add(new Vector3(-1664.449 , 4397.864 , 47.24191 , "None"));
Path.Add(new Vector3(-1661.448 , 4400.104 , 46.25793 , "None"));
Path.Add(new Vector3(-1658.688 , 4402.188 , 45.66559 , "None"));
Path.Add(new Vector3(-1655.927 , 4404.292 , 45.40406 , "None"));
Path.Add(new Vector3(-1652.959 , 4406.554 , 45.40406 , "None"));
Path.Add(new Vector3(-1650.164 , 4408.684 , 45.88485 , "None"));
Path.Add(new Vector3(-1647.497 , 4410.716 , 46.47741 , "None"));
Path.Add(new Vector3(-1644.602 , 4412.922 , 47.773 , "None"));
Path.Add(new Vector3(-1641.723 , 4415.104 , 49.21426 , "None"));
Path.Add(new Vector3(-1638.649 , 4417.048 , 51.25831 , "None"));
Path.Add(new Vector3(-1635.365 , 4417.922 , 51.8779 , "None"));
Path.Add(new Vector3(-1632.633 , 4416.156 , 52.08615 , "None"));
Path.Add(new Vector3(-1630.285 , 4413.45 , 52.29396 , "None"));
Path.Add(new Vector3(-1627.671 , 4410.933 , 52.39539 , "None"));
Path.Add(new Vector3(-1624.365 , 4409.403 , 52.51677 , "None"));
Path.Add(new Vector3(-1621.048 , 4408.801 , 52.57351 , "None"));
Path.Add(new Vector3(-1617.627 , 4408.34 , 52.60223 , "None"));
Path.Add(new Vector3(-1614.118 , 4408.399 , 52.64603 , "None"));
Path.Add(new Vector3(-1608.35 , 4407.944 , 51.85489 , "None"));
Path.Add(new Vector3(-1605.683 , 4404.339 , 48.47306 , "None"));
Path.Add(new Vector3(-1603.537 , 4401.315 , 44.68856 , "None"));
Path.Add(new Vector3(-1601.568 , 4398.586 , 41.63857 , "None"));
Path.Add(new Vector3(-1599.695 , 4395.534 , 38.64839 , "None"));
Path.Add(new Vector3(-1598.036 , 4392.326 , 35.94436 , "None"));
Path.Add(new Vector3(-1596.267 , 4389.387 , 34.13415 , "None"));
Path.Add(new Vector3(-1595.89 , 4386.827 , 34.29699 , "None"));
Path.Add(new Vector3(-1598.016 , 4382.152 , 34.43112 , "None"));
Path.Add(new Vector3(-1600.95 , 4380.057 , 34.37021 , "None"));
Path.Add(new Vector3(-1604.192 , 4378.37 , 34.41023 , "None"));
Path.Add(new Vector3(-1607.466 , 4377.163 , 34.26092 , "None"));
Path.Add(new Vector3(-1610.786 , 4376.294 , 33.69912 , "None"));
Path.Add(new Vector3(-1613.883 , 4374.183 , 33.12705 , "None"));
Path.Add(new Vector3(-1616.728 , 4371.98 , 32.69461 , "None"));
Path.Add(new Vector3(-1619.494 , 4369.848 , 32.14462 , "None"));
Path.Add(new Vector3(-1622.283 , 4367.698 , 31.61567 , "None"));
Path.Add(new Vector3(-1625.039 , 4365.574 , 31.27048 , "None"));
Path.Add(new Vector3(-1628.15 , 4363.504 , 30.97149 , "None"));
Path.Add(new Vector3(-1631.19 , 4361.802 , 30.64503 , "None"));
Path.Add(new Vector3(-1633.527 , 4359.116 , 30.61406 , "None"));
Path.Add(new Vector3(-1635.675 , 4356.478 , 30.77258 , "None"));
Path.Add(new Vector3(-1638.381 , 4354.009 , 30.87552 , "None"));
Path.Add(new Vector3(-1641.271 , 4352.834 , 30.74694 , "None"));
Path.Add(new Vector3(-1652.361 , 4352.616 , 29.44959 , "None"));
Path.Add(new Vector3(-1662.792 , 4353.999 , 27.99312 , "None"));
Path.Add(new Vector3(-1672.461 , 4357.375 , 27.08885 , "None"));
Path.Add(new Vector3(-1676.432 , 4358.172 , 26.86333 , "None"));
Path.Add(new Vector3(-1687.472 , 4357.109 , 26.53696 , "None"));
Path.Add(new Vector3(-1698.204 , 4356.475 , 26.22695 , "None"));
Path.Add(new Vector3(-1702.822 , 4358.553 , 26.45793 , "None"));
Path.Add(new Vector3(-1710.228 , 4364.693 , 24.96461 , "None"));
Path.Add(new Vector3(-1716.73 , 4372.546 , 22.83368 , "None"));
Path.Add(new Vector3(-1717.741 , 4375.396 , 22.1918 , "None"));
Path.Add(new Vector3(-1722.677 , 4380.599 , 19.16954 , "None"));
Path.Add(new Vector3(-1730.625 , 4388.359 , 16.47032 , "None"));
Path.Add(new Vector3(-1733.666 , 4393.984 , 13.39794 , "None"));
Path.Add(new Vector3(-1738.231 , 4398.603 , 12.39856 , "None"));
Path.Add(new Vector3(-1743.466 , 4398.833 , 11.81455 , "None"));
Path.Add(new Vector3(-1746.63 , 4398.072 , 11.60333 , "None"));
Path.Add(new Vector3(-1752.031 , 4396.425 , 11.11673 , "None"));
Path.Add(new Vector3(-1755.471 , 4395.321 , 10.74305 , "None"));
Path.Add(new Vector3(-1757.702 , 4393.995 , 10.79576 , "None"));
Path.Add(new Vector3(-1759.923 , 4392.675 , 10.85759 , "None"));
Path.Add(new Vector3(-1765.988 , 4389.07 , 10.86815 , "None"));
Path.Add(new Vector3(-1770.465 , 4387.316 , 10.17892 , "None"));
Path.Add(new Vector3(-1778.758 , 4384.318 , 7.361204 , "None"));
Path.Add(new Vector3(-1785.688 , 4381.093 , 6.467306 , "None"));
Path.Add(new Vector3(-1793.817 , 4374.827 , 7.383759 , "None"));
Path.Add(new Vector3(-1799.124 , 4365.881 , 7.454387 , "None"));
Path.Add(new Vector3(-1799.409 , 4361.039 , 8.097271 , "None"));
Path.Add(new Vector3(-1804.176 , 4363.061 , 6.901044 , "None"));
Path.Add(new Vector3(-1806.78 , 4367.157 , 5.125664 , "None"));
Path.Add(new Vector3(-1809.125 , 4368.823 , 4.018235 , "None"));
Path.Add(new Vector3(-1828.428 , 4376.36 , 0.3673143 , "None"));
Path.Add(new Vector3(-1846.213 , 4367.827 , 0.3625778 , "None"));
Path.Add(new Vector3(-1866.976 , 4365.804 , -0.1588826 , "None"));
Path.Add(new Vector3(-1886.162 , 4357.034 , -1.593571 , "None"));
Path.Add(new Vector3(-1898.715 , 4341.518 , 1.251988 , "None"));
Path.Add(new Vector3(-1900.071 , 4320.19 , 1.870952 , "None"));
Path.Add(new Vector3(-1899.196 , 4298.888 , 2.996534 , "None"));
Path.Add(new Vector3(-1888.999 , 4280.503 , 5.041022 , "None"));
Path.Add(new Vector3(-1891.636 , 4263.918 , 4.461652 , "None"));
Path.Add(new Vector3(-1901.191 , 4246.269 , -0.6082765 , "None"));
Path.Add(new Vector3(-1902.495 , 4224.952 , 2.099002 , "None"));
Path.Add(new Vector3(-1902.952 , 4204.44 , -0.6062031 , "None"));
Path.Add(new Vector3(-1905.044 , 4182.535 , -0.6991671 , "None"));
Path.Add(new Vector3(-1911.031 , 4162.795 , -0.2295021 , "None"));
Path.Add(new Vector3(-1916.326 , 4142.027 , 0.3111869 , "None"));
Path.Add(new Vector3(-1914.237 , 4121.304 , 1.670153 , "None"));
Path.Add(new Vector3(-1907.744 , 4102.476 , 1.2252 , "None"));
Path.Add(new Vector3(-1900.313 , 4082.402 , 2.278902 , "None"));
Path.Add(new Vector3(-1898.591 , 4065.567 , 1.53416 , "None"));
Path.Add(new Vector3(-1909.621 , 4051.796 , 1.396467 , "None"));
Path.Add(new Vector3(-1916.736 , 4039.487 , 0.7941685 , "None"));
Path.Add(new Vector3(-1927.702 , 4033.191 , 1.724486 , "None"));
Path.Add(new Vector3(-1937.282 , 4027.692 , 2.214003 , "None"));
Path.Add(new Vector3(-1946.696 , 4022.287 , 1.846358 , "None"));
Path.Add(new Vector3(-1955.707 , 4016.082 , 0.2489926 , "None"));
Path.Add(new Vector3(-1959.835 , 4000.873 , -3.576062 , "None"));
Path.Add(new Vector3(-1953.136 , 3986.19 , -3.898411 , "None"));
Path.Add(new Vector3(-1945.414 , 3977.086 , -3.567693 , "None"));
Path.Add(new Vector3(-1938.176 , 3972.938 , -2.272799 , "None"));
Path.Add(new Vector3(-1929.463 , 3974.899 , -2.476271 , "None"));
Path.Add(new Vector3(-1922.151 , 3976.897 , -5.013731 , "None"));
Path.Add(new Vector3(-1917.323 , 3971.097 , -4.610406 , "None"));
Path.Add(new Vector3(-1913.723 , 3964.022 , -3.099367 , "None"));
Path.Add(new Vector3(-1912.002 , 3956.045 , -2.162036 , "None"));
Path.Add(new Vector3(-1924.695 , 3975.54 , -3.624343 , "None"));
Path.Add(new Vector3(-1933.307 , 3964.169 , -1.024941 , "None"));
Path.Add(new Vector3(-1940.992 , 3956.61 , -0.1419185 , "None"));
Path.Add(new Vector3(-1943.998 , 3948.802 , -0.2720149 , "None"));
Path.Add(new Vector3(-1947.671 , 3940.833 , -0.5580927 , "None"));
Path.Add(new Vector3(-1952.463 , 3931.894 , -0.09751814 , "None"));
Path.Add(new Vector3(-1955.276 , 3921.408 , -0.5607669 , "None"));
Path.Add(new Vector3(-1956.907 , 3911.979 , -1.720294 , "None"));
Path.Add(new Vector3(-1956.108 , 3905.26 , -1.848337 , "None"));
Path.Add(new Vector3(-1949.369 , 3904.304 , -1.689967 , "None"));
Path.Add(new Vector3(-1945.767 , 3891.441 , -0.03334364 , "None"));
Path.Add(new Vector3(-1945.815 , 3883.44 , 0.3916738 , "None"));
Path.Add(new Vector3(-1944.966 , 3876.224 , 0.2928258 , "None"));
Path.Add(new Vector3(-1938.875 , 3868.009 , -1.200342 , "None"));
Path.Add(new Vector3(-1931.209 , 3860.849 , -1.143909 , "None"));
Path.Add(new Vector3(-1924.702 , 3857.597 , -1.302114 , "None"));
Path.Add(new Vector3(-1917.522 , 3857.919 , -2.062557 , "None"));
Path.Add(new Vector3(-1915.11 , 3857.813 , -2.286609 , "None"));
Path.Add(new Vector3(-1909.668 , 3857.419 , -2.64386 , "None"));
Path.Add(new Vector3(-1904.678 , 3857.057 , -2.224082 , "None"));
Path.Add(new Vector3(-1900.137 , 3857.787 , -1.609633 , "None"));
Path.Add(new Vector3(-1896.042 , 3859.241 , -0.6994867 , "None"));
Path.Add(new Vector3(-1893.786 , 3861.348 , -0.09045465 , "None"));
Path.Add(new Vector3(-1891.576 , 3863.412 , 0.5062501 , "None"));
Path.Add(new Vector3(-1888.369 , 3866.059 , 1.30004 , "None"));
Path.Add(new Vector3(-1884.263 , 3865.286 , 2.199819 , "None"));
Path.Add(new Vector3(-1882.406 , 3862.125 , 2.456831 , "None"));
Path.Add(new Vector3(-1881.915 , 3857.771 , 2.981047 , "None"));
Path.Add(new Vector3(-1883.335 , 3854.772 , 3.405053 , "None"));
Path.Add(new Vector3(-1885.624 , 3851.301 , 4.266325 , "None"));
Path.Add(new Vector3(-1887.573 , 3849.704 , 5.048553 , "None"));
Path.Add(new Vector3(-1890.419 , 3849.284 , 5.735417 , "None"));
Path.Add(new Vector3(-1893.246 , 3850.385 , 6.604246 , "None"));
Path.Add(new Vector3(-1895.158 , 3852.864 , 7.45369 , "None"));
Path.Add(new Vector3(-1896.781 , 3856.347 , 8.595208 , "None"));
Path.Add(new Vector3(-1896.388 , 3861.015 , 9.939812 , "None"));
Path.Add(new Vector3(-1895.542 , 3862.704 , 10.40224 , "None"));
Path.Add(new Vector3(-1889.994 , 3864.154 , 11.94731 , "None"));
Path.Add(new Vector3(-1887.653 , 3863.488 , 12.68548 , "None"));
Path.Add(new Vector3(-1885.885 , 3861.245 , 13.49791 , "None"));
Path.Add(new Vector3(-1884.402 , 3857.873 , 14.84088 , "None"));
Path.Add(new Vector3(-1884.431 , 3855.169 , 15.86462 , "None"));
Path.Add(new Vector3(-1885.335 , 3852.707 , 16.71969 , "None"));
Path.Add(new Vector3(-1889.282 , 3851.486 , 18.09681 , "None"));
Path.Add(new Vector3(-1891.888 , 3851.407 , 19.0366 , "None"));
Path.Add(new Vector3(-1894.843 , 3852.668 , 20.0665 , "None"));
Path.Add(new Vector3(-1895.901 , 3856.012 , 21.23179 , "None"));
Path.Add(new Vector3(-1895.924 , 3860.191 , 22.42634 , "None"));
Path.Add(new Vector3(-1893.922 , 3862.227 , 23.38758 , "None"));
Path.Add(new Vector3(-1891.072 , 3862.859 , 24.28786 , "None"));
Path.Add(new Vector3(-1886.537 , 3861.876 , 25.94011 , "None"));
Path.Add(new Vector3(-1883.777 , 3859.262 , 27.14984 , "None"));
Path.Add(new Vector3(-1884.324 , 3855.969 , 28.23737 , "None"));
Path.Add(new Vector3(-1885.879 , 3852.249 , 29.67444 , "None"));
Path.Add(new Vector3(-1887.284 , 3851.818 , 30.07337 , "None"));
Path.Add(new Vector3(-1889.014 , 3851.534 , 30.73678 , "None"));
Path.Add(new Vector3(-1893.76 , 3853.149 , 32.57297 , "None"));
Path.Add(new Vector3(-1895.726 , 3855.741 , 33.81075 , "None"));
Path.Add(new Vector3(-1895.288 , 3857.558 , 34.31921 , "None"));
Path.Add(new Vector3(-1891.918 , 3861.888 , 36.57626 , "None"));
Path.Add(new Vector3(-1889.43 , 3862.129 , 37.52487 , "None"));
Path.Add(new Vector3(-1886.85 , 3861.01 , 38.65107 , "None"));
Path.Add(new Vector3(-1885.517 , 3859.171 , 39.65063 , "None"));
Path.Add(new Vector3(-1885.124 , 3855.117 , 41.3862 , "None"));
Path.Add(new Vector3(-1887.242 , 3852.475 , 42.69976 , "None"));
Path.Add(new Vector3(-1890.241 , 3852.5 , 43.54416 , "None"));
Path.Add(new Vector3(-1891.464 , 3853.712 , 43.76645 , "None"));
Path.Add(new Vector3(-1893.096 , 3855.912 , 44.22715 , "None"));
Path.Add(new Vector3(-1894.246 , 3859.18 , 44.78314 , "None"));
Path.Add(new Vector3(-1896.017 , 3862.449 , 45.83749 , "None"));
Path.Add(new Vector3(-1897.151 , 3864.506 , 46.83896 , "None"));
Path.Add(new Vector3(-1898.685 , 3867.209 , 45.33584 , "None"));
Path.Add(new Vector3(-1899.974 , 3868.931 , 45.3278 , "None"));
Path.Add(new Vector3(-1901.434 , 3869.924 , 45.37457 , "None"));
Path.Add(new Vector3(-1902.983 , 3872.018 , 45.38809 , "None"));
Path.Add(new Vector3(-1901.544 , 3873.109 , 45.39818 , "None"));
Path.Add(new Vector3(-1897.609 , 3874.774 , 45.44072 , "None"));
Path.Add(new Vector3(-1895.733 , 3875.307 , 45.44072 , "None"));
Path.Add(new Vector3(-1892.008 , 3874.393 , 45.43764 , "None"));
Path.Add(new Vector3(-1885.07 , 3872.737 , 45.43456 , "None"));
Path.Add(new Vector3(-1881.618 , 3871.913 , 45.43456 , "None"));
Path.Add(new Vector3(-1878.951 , 3877.729 , 45.44637 , "None"));
Path.Add(new Vector3(-1877.612 , 3880.973 , 45.42368 , "None"));
Path.Add(new Vector3(-1875.862 , 3883.895 , 43.67155 , "None"));
Path.Add(new Vector3(-1874.106 , 3887.147 , 42.00515 , "None"));
Path.Add(new Vector3(-1872.473 , 3890.243 , 40.76529 , "None"));
Path.Add(new Vector3(-1870.85 , 3893.32 , 39.85651 , "None"));
Path.Add(new Vector3(-1869.227 , 3896.397 , 39.25186 , "None"));
Path.Add(new Vector3(-1867.472 , 3899.721 , 38.87664 , "None"));
Path.Add(new Vector3(-1864.149 , 3905.675 , 38.75755 , "None"));
Path.Add(new Vector3(-1862.306 , 3908.927 , 39.22611 , "None"));
Path.Add(new Vector3(-1858.872 , 3914.987 , 40.73792 , "None"));
Path.Add(new Vector3(-1856.76 , 3918.714 , 42.39996 , "None"));
Path.Add(new Vector3(-1855.079 , 3921.68 , 44.19587 , "None"));
Path.Add(new Vector3(-1853.229 , 3924.944 , 45.3587 , "None"));
Path.Add(new Vector3(-1854.084 , 3929.698 , 45.6312 , "None"));
Path.Add(new Vector3(-1855.992 , 3935.246 , 45.94064 , "None"));
Path.Add(new Vector3(-1858.283 , 3941.994 , 46.0569 , "None"));
Path.Add(new Vector3(-1858.944 , 3945.66 , 46.14852 , "None"));
Path.Add(new Vector3(-1857.59 , 3950.371 , 46.37208 , "None"));
Path.Add(new Vector3(-1853.12 , 3955.551 , 46.53407 , "None"));
Path.Add(new Vector3(-1850.365 , 3958.026 , 46.55263 , "None"));
Path.Add(new Vector3(-1844.018 , 3961.218 , 46.55529 , "None"));
Path.Add(new Vector3(-1837.513 , 3960.144 , 46.55687 , "None"));
Path.Add(new Vector3(-1849.833 , 3957.727 , 46.55425 , "None"));
Path.Add(new Vector3(-1847.217 , 3958.666 , 46.55425 , "None"));
Path.Add(new Vector3(-1843.955 , 3959.894 , 46.55271 , "None"));
Path.Add(new Vector3(-1840.757 , 3961.096 , 46.5558 , "None"));
Path.Add(new Vector3(-1837.356 , 3962.145 , 46.55921 , "None"));
Path.Add(new Vector3(-1833.742 , 3962.063 , 46.56197 , "None"));
Path.Add(new Vector3(-1831.239 , 3961.024 , 46.56234 , "None"));
Path.Add(new Vector3(-1830.054 , 3959.717 , 46.56234 , "None"));
Path.Add(new Vector3(-1832.571 , 3958.041 , 46.55746 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class TheEyesofSkettis : QuestGathererClass
{
    public TheEyesofSkettis()
    {
        Name = "The Eyes of Skettis";

        QuestId.AddRange(new[] { 10847 });

        Step = new List<int> { 1, 1, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10908;

        EntryIdObjects.Add(185201);
HotSpots.Add(new Vector3(-1831.404 , 3959.445 , 46.55994 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNEyeofSkettisGotItemsRuntoShattrath : QuestFollowPathClass
{
    public RUNEyeofSkettisGotItemsRuntoShattrath()
    {
        Name = "RUN: Eye of Skettis - Got Items Run to Shattrath";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-1892.375 , 4035.712 , 0.1230976 , "None"));
Path.Add(new Vector3(-1900.21 , 4049.616 , 0.1010012 , "None"));
Path.Add(new Vector3(-1903.066 , 4063.388 , 1.776087 , "None"));
Path.Add(new Vector3(-1908.269 , 4098.565 , 1.075719 , "None"));
Path.Add(new Vector3(-1912.053 , 4124.419 , 1.681093 , "None"));
Path.Add(new Vector3(-1915.646 , 4157.261 , 0.2199734 , "None"));
Path.Add(new Vector3(-1914.971 , 4171.941 , -3.217802 , "None"));
Path.Add(new Vector3(-1911.094 , 4189.844 , -1.633253 , "None"));
Path.Add(new Vector3(-1904.612 , 4226.818 , 1.439285 , "None"));
Path.Add(new Vector3(-1900.927 , 4261.976 , 1.038299 , "None"));
Path.Add(new Vector3(-1895.675 , 4297.322 , 3.081525 , "None"));
Path.Add(new Vector3(-1900.32 , 4320.418 , 1.876057 , "None"));
Path.Add(new Vector3(-1906.465 , 4366.146 , 1.659014 , "None"));
Path.Add(new Vector3(-1907.413 , 4388.192 , 1.792072 , "None"));
Path.Add(new Vector3(-1908.478 , 4414.254 , 2.840715 , "None"));
Path.Add(new Vector3(-1912.415 , 4446.954 , 5.779751 , "None"));
Path.Add(new Vector3(-1929.625 , 4478.897 , 9.550732 , "None"));
Path.Add(new Vector3(-1953.104 , 4504.882 , 12.42643 , "None"));
Path.Add(new Vector3(-1975.339 , 4529.501 , 13.48474 , "None"));
Path.Add(new Vector3(-1964.066 , 4556.55 , 11.82885 , "None"));
Path.Add(new Vector3(-1944.449 , 4586.815 , 6.837338 , "None"));
Path.Add(new Vector3(-1945.829 , 4622.235 , 1.625112 , "None"));
Path.Add(new Vector3(-1947.834 , 4653.862 , -1.168113 , "None"));
Path.Add(new Vector3(-1945.699 , 4676.262 , -1.867716 , "None"));
Path.Add(new Vector3(-1947.249 , 4710.903 , -2.916831 , "None"));
Path.Add(new Vector3(-1949.732 , 4747.027 , -2.967403 , "None"));
Path.Add(new Vector3(-1952.03 , 4768.485 , -1.904269 , "None"));
Path.Add(new Vector3(-1953.93 , 4800.189 , -0.1370113 , "None"));
Path.Add(new Vector3(-1945.973 , 4833.621 , 0.7889566 , "None"));
Path.Add(new Vector3(-1930.644 , 4863.71 , 1.86868 , "None"));
Path.Add(new Vector3(-1916.515 , 4887.792 , 2.180322 , "None"));
Path.Add(new Vector3(-1901.5 , 4905.026 , -0.8291107 , "None"));
Path.Add(new Vector3(-1879.091 , 4930.773 , -11.46376 , "None"));
Path.Add(new Vector3(-1863.076 , 4962.759 , -20.97789 , "None"));
Path.Add(new Vector3(-1861.712 , 4994.126 , -20.96042 , "None"));
Path.Add(new Vector3(-1857.318 , 5030.61 , -25.6958 , "None"));
Path.Add(new Vector3(-1853.489 , 5066.455 , -31.62971 , "None"));
Path.Add(new Vector3(-1850.86 , 5101.563 , -37.42171 , "None"));
Path.Add(new Vector3(-1849.162 , 5136.94 , -42.07089 , "None"));
Path.Add(new Vector3(-1851.833 , 5156.99 , -46.47802 , "None"));
Path.Add(new Vector3(-1835.808 , 5169.574 , -48.2941 , "None"));
Path.Add(new Vector3(-1825.209 , 5171.07 , -49.67056 , "None"));
Path.Add(new Vector3(-1813.749 , 5174.826 , -45.22437 , "None"));
Path.Add(new Vector3(-1796.964 , 5183.694 , -42.00914 , "None"));
Path.Add(new Vector3(-1790.209 , 5200.467 , -45.91299 , "None"));
Path.Add(new Vector3(-1786.252 , 5209.972 , -48.19418 , "None"));
Path.Add(new Vector3(-1777.8 , 5217.222 , -49.06376 , "None"));
Path.Add(new Vector3(-1768.142 , 5221.532 , -48.7777 , "None"));
Path.Add(new Vector3(-1758.59 , 5225.625 , -49.36814 , "None"));
Path.Add(new Vector3(-1748.353 , 5228.695 , -50.13731 , "None"));
Path.Add(new Vector3(-1738.309 , 5230.921 , -50.52971 , "None"));
Path.Add(new Vector3(-1727.074 , 5233.208 , -50.60227 , "None"));
Path.Add(new Vector3(-1715.214 , 5241.672 , -50.01109 , "None"));
Path.Add(new Vector3(-1707.974 , 5251.403 , -48.66211 , "None"));
Path.Add(new Vector3(-1699.81 , 5258.336 , -49.75151 , "None"));
Path.Add(new Vector3(-1691.838 , 5265.563 , -51.11097 , "None"));
Path.Add(new Vector3(-1684.528 , 5273.805 , -51.62525 , "None"));
Path.Add(new Vector3(-1679.205 , 5282.752 , -51.2562 , "None"));
Path.Add(new Vector3(-1675.641 , 5292.921 , -50.74372 , "None"));
Path.Add(new Vector3(-1673.83 , 5303.2 , -50.0438 , "None"));
Path.Add(new Vector3(-1672.576 , 5313.469 , -49.32253 , "None"));
Path.Add(new Vector3(-1671.39 , 5323.969 , -48.08355 , "None"));
Path.Add(new Vector3(-1669.413 , 5334.663 , -46.87503 , "None"));
Path.Add(new Vector3(-1667.219 , 5344.737 , -46.19364 , "None"));
Path.Add(new Vector3(-1664.913 , 5355.325 , -46.00459 , "None"));
Path.Add(new Vector3(-1662.583 , 5365.908 , -46.24506 , "None"));
Path.Add(new Vector3(-1650.612 , 5382.171 , -45.7648 , "None"));
Path.Add(new Vector3(-1646.958 , 5395.074 , -45.0205 , "None"));
Path.Add(new Vector3(-1645.695 , 5405.491 , -44.62906 , "None"));
Path.Add(new Vector3(-1642.826 , 5415.439 , -44.32493 , "None"));
Path.Add(new Vector3(-1640.64 , 5427.188 , -43.64601 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class SeekOutKirrik : QuestClass
{
    public SeekOutKirrik()
    {
        Name = "Seek Out Kirrik";

        QuestId.AddRange(new[] { 10849 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10847;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNSeekOutKirrik : QuestFollowPathClass
{
    public RUNSeekOutKirrik()
    {
        Name = "RUN: Seek Out Kirrik";

        QuestId.AddRange(new[] { 10849 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-1637.21 , 5426.955 , -43.04301 , "None"));
Path.Add(new Vector3(-1637.76 , 5412.094 , -43.95079 , "None"));
Path.Add(new Vector3(-1641.214 , 5395.247 , -45.18937 , "None"));
Path.Add(new Vector3(-1647.368 , 5375.051 , -45.80659 , "None"));
Path.Add(new Vector3(-1659.098 , 5356.851 , -45.82162 , "None"));
Path.Add(new Vector3(-1667.15 , 5337.376 , -46.34865 , "None"));
Path.Add(new Vector3(-1671.479 , 5317.07 , -48.85249 , "None"));
Path.Add(new Vector3(-1676.73 , 5296.159 , -50.47346 , "None"));
Path.Add(new Vector3(-1682.875 , 5275.29 , -51.64659 , "None"));
Path.Add(new Vector3(-1686.54 , 5255.063 , -51.58549 , "None"));
Path.Add(new Vector3(-1684.137 , 5233.606 , -50.21377 , "None"));
Path.Add(new Vector3(-1676.099 , 5218.716 , -47.63105 , "None"));
Path.Add(new Vector3(-1689.837 , 5222.034 , -49.86311 , "None"));
Path.Add(new Vector3(-1709.739 , 5227.428 , -51.06446 , "None"));
Path.Add(new Vector3(-1731.592 , 5228.583 , -50.75628 , "None"));
Path.Add(new Vector3(-1752.437 , 5226.42 , -49.9627 , "None"));
Path.Add(new Vector3(-1772.825 , 5219.618 , -48.90973 , "None"));
Path.Add(new Vector3(-1793.706 , 5217.658 , -48.95204 , "None"));
Path.Add(new Vector3(-1806.524 , 5209.416 , -49.68648 , "None"));
Path.Add(new Vector3(-1818.259 , 5191.085 , -51.38835 , "None"));
Path.Add(new Vector3(-1830.559 , 5174.075 , -49.6958 , "None"));
Path.Add(new Vector3(-1844.311 , 5157.623 , -45.73945 , "None"));
Path.Add(new Vector3(-1853.467 , 5138.58 , -42.45657 , "None"));
Path.Add(new Vector3(-1853.079 , 5117.464 , -38.876 , "None"));
Path.Add(new Vector3(-1854.308 , 5095.959 , -36.48176 , "None"));
Path.Add(new Vector3(-1854.975 , 5074.655 , -32.97548 , "None"));
Path.Add(new Vector3(-1856.773 , 5053.733 , -29.51175 , "None"));
Path.Add(new Vector3(-1858.914 , 5032.188 , -25.94641 , "None"));
Path.Add(new Vector3(-1862.132 , 5011.395 , -22.49015 , "None"));
Path.Add(new Vector3(-1865.702 , 4990.322 , -21.39207 , "None"));
Path.Add(new Vector3(-1869.563 , 4969.683 , -21.46087 , "None"));
Path.Add(new Vector3(-1872.493 , 4952.543 , -18.42423 , "None"));
Path.Add(new Vector3(-1878.927 , 4932.495 , -12.06841 , "None"));
Path.Add(new Vector3(-1890.925 , 4914.335 , -4.393878 , "None"));
Path.Add(new Vector3(-1901.471 , 4903.397 , -0.5366801 , "None"));
Path.Add(new Vector3(-1917.436 , 4899.375 , 2.437559 , "None"));
Path.Add(new Vector3(-1928.554 , 4917.414 , 8.124251 , "None"));
Path.Add(new Vector3(-1937.382 , 4936.768 , 15.34871 , "None"));
Path.Add(new Vector3(-1946.019 , 4956.314 , 23.04683 , "None"));
Path.Add(new Vector3(-1953.994 , 4976.219 , 27.54941 , "None"));
Path.Add(new Vector3(-1960.473 , 4995.854 , 30.61249 , "None"));
Path.Add(new Vector3(-1960.075 , 5017.611 , 32.85854 , "None"));
Path.Add(new Vector3(-1949.495 , 5035.589 , 28.21025 , "None"));
Path.Add(new Vector3(-1938.068 , 5053.333 , 20.57657 , "None"));
Path.Add(new Vector3(-1941.431 , 5072.207 , 16.11426 , "None"));
Path.Add(new Vector3(-1959.118 , 5084.822 , 11.21719 , "None"));
Path.Add(new Vector3(-1977.809 , 5095.285 , 8.135386 , "None"));
Path.Add(new Vector3(-2003.335 , 5109.573 , 8.123784 , "None"));
Path.Add(new Vector3(-2036.717 , 5122.318 , 8.461599 , "None"));
Path.Add(new Vector3(-2071.458 , 5122.049 , 5.940564 , "None"));
Path.Add(new Vector3(-2105.543 , 5109.354 , -0.470971 , "None"));
Path.Add(new Vector3(-2139.764 , 5110.991 , -12.80872 , "None"));
Path.Add(new Vector3(-2159.307 , 5119.395 , -19.4769 , "None"));
Path.Add(new Vector3(-2191.068 , 5134.769 , -21.53661 , "None"));
Path.Add(new Vector3(-2224.239 , 5146.692 , -19.21573 , "None"));
Path.Add(new Vector3(-2245.322 , 5146.634 , -16.60593 , "None"));
Path.Add(new Vector3(-2290.52 , 5145.317 , -9.238761 , "None"));
Path.Add(new Vector3(-2326.195 , 5145.455 , -5.591682 , "None"));
Path.Add(new Vector3(-2359.51 , 5153.394 , -3.195839 , "None"));
Path.Add(new Vector3(-2392.928 , 5160.89 , -0.8774204 , "None"));
Path.Add(new Vector3(-2422.53 , 5161.803 , 1.649041 , "None"));
Path.Add(new Vector3(-2453.339 , 5159.87 , 3.274012 , "None"));
Path.Add(new Vector3(-2473.033 , 5154.366 , 4.149249 , "None"));
Path.Add(new Vector3(-2489.94 , 5149.446 , 3.11193 , "None"));
Path.Add(new Vector3(-2504.752 , 5137.371 , 4.881644 , "None"));
Path.Add(new Vector3(-2519.797 , 5124.705 , 8.058157 , "None"));
Path.Add(new Vector3(-2554.571 , 5120.544 , 7.696242 , "None"));
Path.Add(new Vector3(-2587.8 , 5121.685 , 5.975401 , "None"));
Path.Add(new Vector3(-2605.297 , 5123.238 , 3.604504 , "None"));
Path.Add(new Vector3(-2625.323 , 5121.698 , -0.1907794 , "None"));
Path.Add(new Vector3(-2639.157 , 5117.893 , -2.041711 , "None"));
Path.Add(new Vector3(-2658.142 , 5116.473 , -3.316216 , "None"));
Path.Add(new Vector3(-2694.289 , 5114.842 , -4.981598 , "None"));
Path.Add(new Vector3(-2724.316 , 5115.199 , -4.838196 , "None"));
Path.Add(new Vector3(-2736.732 , 5122.333 , -4.363782 , "None"));
Path.Add(new Vector3(-2754.76 , 5134.405 , -5.505535 , "None"));
Path.Add(new Vector3(-2775.832 , 5135.566 , -8.375354 , "None"));
Path.Add(new Vector3(-2779.646 , 5135.101 , -9.005162 , "None"));
Path.Add(new Vector3(-2788.671 , 5128.379 , -10.52502 , "None"));
Path.Add(new Vector3(-2793.517 , 5124.657 , -11.25903 , "None"));
Path.Add(new Vector3(-2795.962 , 5121.404 , -11.55571 , "None"));
Path.Add(new Vector3(-2797.758 , 5118.343 , -11.70919 , "None"));
Path.Add(new Vector3(-2800.659 , 5113.398 , -11.89294 , "None"));
Path.Add(new Vector3(-2809.177 , 5109.796 , -12.85896 , "None"));
Path.Add(new Vector3(-2818.969 , 5105.099 , -14.135 , "None"));
Path.Add(new Vector3(-2825.778 , 5097.618 , -15.19752 , "None"));
Path.Add(new Vector3(-2828.871 , 5090.697 , -15.8032 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class VeilSkithDarkstoneofTerokk : QuestUseItemOnClass
{
    public VeilSkithDarkstoneofTerokk()
    {
        Name = "Veil Skith: Darkstone of Terokk";

        QuestId.AddRange(new[] { 10839 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10849;

        EntryIdTarget.Add(185191);
HotSpots.Add(new Vector3(-2515.28 , 5419.307 , -0.03016329 , "None"));
ItemId = 31610;
Range = 3.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNDarkstoneofTerokk : QuestFollowPathClass
{
    public RUNDarkstoneofTerokk()
    {
        Name = "RUN: Darkstone of Terokk";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2591.523 , 5305.058 , 7.062262 , "None"));
Path.Add(new Vector3(-2581.399 , 5316.989 , 7.043842 , "None"));
Path.Add(new Vector3(-2574.894 , 5324.961 , 6.458689 , "None"));
Path.Add(new Vector3(-2567.41 , 5330.258 , 5.131315 , "None"));
Path.Add(new Vector3(-2558.036 , 5334.668 , 2.737833 , "None"));
Path.Add(new Vector3(-2545.141 , 5341.07 , 1.298254 , "None"));
Path.Add(new Vector3(-2550.413 , 5354.492 , 0.7910703 , "None"));
Path.Add(new Vector3(-2545.449 , 5371.201 , 0.288431 , "None"));
Path.Add(new Vector3(-2540.436 , 5380.778 , 0.06515777 , "None"));
Path.Add(new Vector3(-2544.904 , 5397.261 , 0.04760614 , "None"));
Path.Add(new Vector3(-2548.615 , 5404.838 , 0.04760614 , "None"));
Path.Add(new Vector3(-2541.812 , 5408.767 , 0.04760614 , "None"));
Path.Add(new Vector3(-2535.524 , 5413.077 , 0.04760614 , "None"));
Path.Add(new Vector3(-2539.969 , 5422.352 , 0.04760614 , "None"));
Path.Add(new Vector3(-2538.042 , 5430.721 , 0.04760614 , "None"));
Path.Add(new Vector3(-2534.732 , 5440.176 , 0.04780367 , "None"));
Path.Add(new Vector3(-2532.091 , 5451.061 , 1.097628 , "None"));
Path.Add(new Vector3(-2523.85 , 5451.78 , 0.6867759 , "None"));
Path.Add(new Vector3(-2515.809 , 5442.262 , 0.04772697 , "None"));
Path.Add(new Vector3(-2512.668 , 5433.372 , 0.04772697 , "None"));
Path.Add(new Vector3(-2510.984 , 5424.988 , 0.04772697 , "None"));
Path.Add(new Vector3(-2504.997 , 5410.894 , 0.04772697 , "None"));
Path.Add(new Vector3(-2500.885 , 5403.545 , 0.04772697 , "None"));
Path.Add(new Vector3(-2497.491 , 5391.556 , 0.04588403 , "None"));
Path.Add(new Vector3(-2503.462 , 5402.11 , 0.04322194 , "None"));
Path.Add(new Vector3(-2508.008 , 5411.354 , 0.04706558 , "None"));
Path.Add(new Vector3(-2510.558 , 5414.992 , 0.04779585 , "None"));
Path.Add(new Vector3(-2518.68 , 5417.586 , 0.04779585 , "None"));
Path.Add(new Vector3(-2531.627 , 5417.462 , 0.04779585 , "None"));
Path.Add(new Vector3(-2541.188 , 5415.28 , 0.04779585 , "None"));
Path.Add(new Vector3(-2539.013 , 5426.32 , 0.04779585 , "None"));
Path.Add(new Vector3(-2536.357 , 5435.461 , 0.04631336 , "None"));
Path.Add(new Vector3(-2533.45 , 5445.541 , 0.2923722 , "None"));
Path.Add(new Vector3(-2528.286 , 5451.857 , 1.065717 , "None"));
Path.Add(new Vector3(-2519.842 , 5447.626 , 0.0904617 , "None"));
Path.Add(new Vector3(-2514.755 , 5439.37 , 0.04888503 , "None"));
Path.Add(new Vector3(-2512.058 , 5430.287 , 0.04734515 , "None"));
Path.Add(new Vector3(-2508.742 , 5419.721 , 0.04734515 , "None"));
Path.Add(new Vector3(-2504.818 , 5410.69 , 0.04734515 , "None"));
Path.Add(new Vector3(-2500.635 , 5402.163 , 0.04529198 , "None"));
Path.Add(new Vector3(-2497.693 , 5392.241 , 0.04632088 , "None"));
Path.Add(new Vector3(-2505.273 , 5405.75 , 0.0467361 , "None"));
Path.Add(new Vector3(-2509.92 , 5414.873 , 0.5750929 , "None"));
Path.Add(new Vector3(-2525.336 , 5409.237 , 0.04813474 , "None"));
Path.Add(new Vector3(-2532.037 , 5401.551 , 0.04756645 , "None"));
Path.Add(new Vector3(-2539.233 , 5393.6 , 0.04756645 , "None"));
Path.Add(new Vector3(-2548.21 , 5383.683 , 0.1341432 , "None"));
Path.Add(new Vector3(-2555.777 , 5375.321 , 0.2246588 , "None"));
Path.Add(new Vector3(-2563.147 , 5367.178 , 1.149492 , "None"));
Path.Add(new Vector3(-2570.278 , 5359.3 , 3.735326 , "None"));
Path.Add(new Vector3(-2577.493 , 5351.329 , 5.958481 , "None"));
Path.Add(new Vector3(-2584.75 , 5343.31 , 7.028649 , "None"));
Path.Add(new Vector3(-2591.655 , 5335.681 , 7.875461 , "None"));
Path.Add(new Vector3(-2598.701 , 5327.896 , 7.715201 , "None"));
Path.Add(new Vector3(-2605.83 , 5320.019 , 8.189786 , "None"));
Path.Add(new Vector3(-2612.96 , 5312.14 , 7.473708 , "None"));
Path.Add(new Vector3(-2619.865 , 5304.511 , 7.684663 , "None"));
Path.Add(new Vector3(-2627.348 , 5296.244 , 8.601598 , "None"));
Path.Add(new Vector3(-2634.436 , 5288.412 , 5.657353 , "None"));
Path.Add(new Vector3(-2641.722 , 5280.362 , 2.983101 , "None"));
Path.Add(new Vector3(-2660.957 , 5259.1 , 0.3432384 , "None"));
Path.Add(new Vector3(-2667.748 , 5248.01 , 0.06356714 , "None"));
Path.Add(new Vector3(-2676.341 , 5214.807 , 0.2925294 , "None"));
Path.Add(new Vector3(-2688.724 , 5188.373 , -2.075646 , "None"));
Path.Add(new Vector3(-2716.576 , 5173.56 , -3.683538 , "None"));
Path.Add(new Vector3(-2747.519 , 5158.922 , -6.25154 , "None"));
Path.Add(new Vector3(-2774.165 , 5146.335 , -8.492062 , "None"));
Path.Add(new Vector3(-2796.971 , 5123.875 , -11.74326 , "None"));
Path.Add(new Vector3(-2810.96 , 5107.287 , -13.03008 , "None"));
Path.Add(new Vector3(-2820.419 , 5096.071 , -14.39954 , "None"));
Path.Add(new Vector3(-2827.391 , 5087.803 , -15.64479 , "None"));
Path.Add(new Vector3(-2835.013 , 5087.256 , -16.69807 , "None"));
Path.Add(new Vector3(-2843.878 , 5090.062 , -16.45809 , "None"));
Path.Add(new Vector3(-2843.541 , 5092.148 , 7.984294 , "Flying"));
Path.Add(new Vector3(-2848.951 , 5095.023 , -17.79738 , "None"));
Path.Add(new Vector3(-2851.387 , 5083.952 , -18.24264 , "None"));
Path.Add(new Vector3(-2847.788 , 5073.589 , -18.23147 , "None"));
Path.Add(new Vector3(-2839.999 , 5081.756 , -17.38162 , "None"));
Path.Add(new Vector3(-2824.769 , 5100.231 , -15.00712 , "None"));
Path.Add(new Vector3(-2805.552 , 5129.774 , -12.83307 , "None"));
Path.Add(new Vector3(-2797.833 , 5163.342 , -11.07475 , "None"));
Path.Add(new Vector3(-2793.537 , 5197.308 , -9.67647 , "None"));
Path.Add(new Vector3(-2788.3 , 5216.851 , -8.429745 , "None"));
Path.Add(new Vector3(-2807.6 , 5228.4 , -9.546007 , "None"));
Path.Add(new Vector3(-2841.466 , 5230.532 , -11.59969 , "None"));
Path.Add(new Vector3(-2869.815 , 5252.904 , -12.62166 , "None"));
Path.Add(new Vector3(-2895.864 , 5278.127 , -12.28364 , "None"));
Path.Add(new Vector3(-2921.26 , 5302.717 , -13.44289 , "None"));
Path.Add(new Vector3(-2940.966 , 5332.837 , -14.76668 , "None"));
Path.Add(new Vector3(-2954.709 , 5364.87 , -14.18023 , "None"));
Path.Add(new Vector3(-2965.503 , 5397.427 , -14.3375 , "None"));
Path.Add(new Vector3(-2972.193 , 5417.628 , -13.77549 , "None"));
Path.Add(new Vector3(-2977.533 , 5433.752 , -13.38143 , "None"));
Path.Add(new Vector3(-2979.304 , 5460.282 , -11.98256 , "None"));
Path.Add(new Vector3(-2978.798 , 5472.464 , -11.59282 , "None"));
Path.Add(new Vector3(-2989.788 , 5512.419 , -10.13325 , "None"));
Path.Add(new Vector3(-2986.47 , 5539.903 , -7.101018 , "None"));
Path.Add(new Vector3(-2982.951 , 5524.48 , -7.938948 , "None"));
Path.Add(new Vector3(-2964.169 , 5505.808 , -7.396797 , "None"));
Path.Add(new Vector3(-2974.425 , 5485.787 , -10.55868 , "None"));
Path.Add(new Vector3(-2974.086 , 5471.791 , -11.14691 , "None"));
Path.Add(new Vector3(-2961.559 , 5448.601 , -11.24553 , "None"));
Path.Add(new Vector3(-2960.477 , 5428.887 , -12.90038 , "None"));
Path.Add(new Vector3(-2973.75 , 5418.099 , -13.79197 , "None"));
Path.Add(new Vector3(-2952.032 , 5411.863 , -13.40826 , "None"));
Path.Add(new Vector3(-2954.367 , 5397.797 , -13.9041 , "None"));
Path.Add(new Vector3(-2939.13 , 5400.834 , -12.54504 , "None"));
Path.Add(new Vector3(-2930.661 , 5393.721 , -10.75395 , "None"));
Path.Add(new Vector3(-2957.925 , 5381.954 , -14.193 , "None"));
Path.Add(new Vector3(-2977.538 , 5367.758 , -15.11898 , "None"));
Path.Add(new Vector3(-2989.628 , 5374.558 , -15.05 , "None"));
Path.Add(new Vector3(-3004.726 , 5391.06 , -14.7534 , "None"));
Path.Add(new Vector3(-3008.95 , 5367.788 , -16.17984 , "None"));
Path.Add(new Vector3(-3022.832 , 5365.976 , -17.29163 , "None"));
Path.Add(new Vector3(-3050.194 , 5371.918 , -19.39818 , "None"));
Path.Add(new Vector3(-3059.183 , 5372.943 , -20.03672 , "None"));
Path.Add(new Vector3(-3056.083 , 5356.94 , -19.98719 , "None"));
Path.Add(new Vector3(-3047.021 , 5344.798 , -18.85759 , "None"));
Path.Add(new Vector3(-3029.716 , 5349.123 , -18.23238 , "None"));
Path.Add(new Vector3(-3044.253 , 5320.35 , -20.51674 , "None"));
Path.Add(new Vector3(-3064.978 , 5292.825 , -22.18443 , "None"));
Path.Add(new Vector3(-3079.404 , 5268.142 , -22.4318 , "None"));
Path.Add(new Vector3(-3094.479 , 5255.85 , -22.67224 , "None"));
Path.Add(new Vector3(-3120.793 , 5276.574 , -22.69738 , "None"));
Path.Add(new Vector3(-3136.033 , 5306.854 , -21.60824 , "None"));
Path.Add(new Vector3(-3167.499 , 5317.726 , -22.26073 , "None"));
Path.Add(new Vector3(-3178.965 , 5321.034 , -22.07865 , "None"));
Path.Add(new Vector3(-3185.636 , 5344.05 , -21.35007 , "None"));
Path.Add(new Vector3(-3189.32 , 5351.874 , -21.42615 , "None"));
Path.Add(new Vector3(-3162.967 , 5370.511 , -21.501 , "None"));
Path.Add(new Vector3(-3144.416 , 5397.935 , -22.16315 , "None"));
Path.Add(new Vector3(-3124.151 , 5417.025 , -22.09815 , "None"));
Path.Add(new Vector3(-3121.785 , 5401.784 , -22.13972 , "None"));
Path.Add(new Vector3(-3122.185 , 5392.482 , -22.1428 , "None"));
Path.Add(new Vector3(-3104.96 , 5391.894 , -21.98714 , "None"));
Path.Add(new Vector3(-3067.465 , 5397.618 , -20.60899 , "None"));
Path.Add(new Vector3(-3044.279 , 5394.804 , -18.79573 , "None"));
Path.Add(new Vector3(-3009.811 , 5400.463 , -15.08585 , "None"));
Path.Add(new Vector3(-2975.204 , 5406.144 , -14.21816 , "None"));
Path.Add(new Vector3(-2953.889 , 5403.05 , -13.78238 , "None"));
Path.Add(new Vector3(-2952.811 , 5370.058 , -14.01281 , "None"));
Path.Add(new Vector3(-2930.285 , 5342.973 , -14.33968 , "None"));
Path.Add(new Vector3(-2907.838 , 5314.319 , -12.96686 , "None"));
Path.Add(new Vector3(-2885.169 , 5285.394 , -11.82712 , "None"));
Path.Add(new Vector3(-2865.273 , 5258.333 , -12.09506 , "None"));
Path.Add(new Vector3(-2852.231 , 5236.387 , -12.06191 , "None"));
Path.Add(new Vector3(-2855.301 , 5243.807 , -11.97872 , "None"));
Path.Add(new Vector3(-2882.943 , 5267.15 , -12.49397 , "None"));
Path.Add(new Vector3(-2907.169 , 5290.924 , -12.60867 , "None"));
Path.Add(new Vector3(-2916.016 , 5300.189 , -13.19896 , "None"));
Path.Add(new Vector3(-2927.392 , 5312.167 , -13.973 , "None"));
Path.Add(new Vector3(-2924.682 , 5326.273 , -14.16819 , "None"));
Path.Add(new Vector3(-2931.576 , 5355.271 , -13.68528 , "None"));
Path.Add(new Vector3(-2949.774 , 5372.602 , -13.80019 , "None"));
Path.Add(new Vector3(-2960.115 , 5382.45 , -14.29295 , "None"));
Path.Add(new Vector3(-2966.97 , 5392.594 , -14.45669 , "None"));
Path.Add(new Vector3(-2953.196 , 5405.809 , -13.67382 , "None"));
Path.Add(new Vector3(-2952.712 , 5439.554 , -11.53949 , "None"));
Path.Add(new Vector3(-2955.684 , 5475.622 , -9.132444 , "None"));
Path.Add(new Vector3(-2969.761 , 5478.213 , -10.46874 , "None"));
Path.Add(new Vector3(-2973.312 , 5496.634 , -9.439472 , "None"));
Path.Add(new Vector3(-2977.654 , 5512 , -8.296958 , "None"));
Path.Add(new Vector3(-2981.955 , 5524.381 , -7.788237 , "None"));
Path.Add(new Vector3(-2985.715 , 5535.205 , -7.42481 , "None"));
Path.Add(new Vector3(-2973.894 , 5562.165 , -2.88785 , "None"));
Path.Add(new Vector3(-2991.622 , 5558.777 , -5.672461 , "None"));
Path.Add(new Vector3(-2999.696 , 5569.593 , -5.321324 , "None"));
Path.Add(new Vector3(-2984.946 , 5558.021 , -4.809619 , "None"));
Path.Add(new Vector3(-2969.828 , 5561.302 , -2.601607 , "None"));
Path.Add(new Vector3(-2967.819 , 5542.784 , -4.287933 , "None"));
Path.Add(new Vector3(-2956.698 , 5528.319 , -4.669309 , "None"));
Path.Add(new Vector3(-2944.563 , 5496.084 , -7.33535 , "None"));
Path.Add(new Vector3(-2921.124 , 5471.834 , -7.629357 , "None"));
Path.Add(new Vector3(-2893.093 , 5449.388 , -7.057894 , "None"));
Path.Add(new Vector3(-2869.821 , 5423.431 , -7.291849 , "None"));
Path.Add(new Vector3(-2859.523 , 5390.64 , -8.520157 , "None"));
Path.Add(new Vector3(-2852.847 , 5369.185 , -6.444898 , "None"));
Path.Add(new Vector3(-2848.549 , 5354.47 , -5.954346 , "None"));
Path.Add(new Vector3(-2823.204 , 5346.095 , -5.096128 , "None"));
Path.Add(new Vector3(-2788.543 , 5356.089 , -0.6660626 , "None"));
Path.Add(new Vector3(-2782.84 , 5364.559 , 1.770517 , "None"));
Path.Add(new Vector3(-2792.284 , 5373.624 , -1.664843 , "None"));
Path.Add(new Vector3(-2790.137 , 5402.182 , 0.4022808 , "None"));
Path.Add(new Vector3(-2785.583 , 5432.845 , 0.8835771 , "None"));
Path.Add(new Vector3(-2785.35 , 5446.77 , 0.978323 , "None"));
Path.Add(new Vector3(-2770.176 , 5452.415 , 2.281208 , "None"));
Path.Add(new Vector3(-2756.211 , 5450.469 , 3.560231 , "None"));
Path.Add(new Vector3(-2764.773 , 5458.4 , 3.019154 , "None"));
Path.Add(new Vector3(-2771.042 , 5468.191 , 3.914644 , "None"));
Path.Add(new Vector3(-2778.632 , 5488.25 , 6.099319 , "None"));
Path.Add(new Vector3(-2800.266 , 5497.775 , 4.195004 , "None"));
Path.Add(new Vector3(-2825.063 , 5507.208 , 2.931791 , "None"));
Path.Add(new Vector3(-2838.455 , 5502.811 , 2.288122 , "None"));
Path.Add(new Vector3(-2847.284 , 5490.988 , 1.208668 , "None"));
Path.Add(new Vector3(-2856.378 , 5488.093 , 0.5712913 , "None"));
Path.Add(new Vector3(-2871.825 , 5486.408 , -1.790417 , "None"));
Path.Add(new Vector3(-2877.385 , 5479.732 , -2.571135 , "None"));
Path.Add(new Vector3(-2870.167 , 5491.677 , -0.9353713 , "None"));
Path.Add(new Vector3(-2889.762 , 5480.742 , -3.714336 , "None"));
Path.Add(new Vector3(-2900.419 , 5474.421 , -5.713097 , "None"));
Path.Add(new Vector3(-2898.584 , 5466.727 , -6.265913 , "None"));
Path.Add(new Vector3(-2896.184 , 5453.102 , -6.958344 , "None"));
Path.Add(new Vector3(-2895.641 , 5443.808 , -7.959778 , "None"));
Path.Add(new Vector3(-2893.48 , 5458.498 , -6.415378 , "None"));
Path.Add(new Vector3(-2899.888 , 5479.719 , -4.964208 , "None"));
Path.Add(new Vector3(-2893.729 , 5494.674 , -4.028856 , "None"));
Path.Add(new Vector3(-2903.251 , 5509.895 , -3.306262 , "None"));
Path.Add(new Vector3(-2903.59 , 5518.639 , -1.950234 , "None"));
Path.Add(new Vector3(-2904.77 , 5546.961 , 0.9435152 , "None"));
Path.Add(new Vector3(-2904.753 , 5560.82 , 0.3964058 , "None"));
Path.Add(new Vector3(-2905.577 , 5569.548 , 1.529976 , "None"));
Path.Add(new Vector3(-2913.586 , 5571.065 , -0.07759035 , "None"));
Path.Add(new Vector3(-2904.241 , 5577.673 , 0.2557545 , "None"));
Path.Add(new Vector3(-2909.939 , 5583.653 , -1.046468 , "None"));
Path.Add(new Vector3(-2919.219 , 5592.896 , 0.109392 , "None"));
Path.Add(new Vector3(-2906.683 , 5594.523 , 0.3615898 , "None"));
Path.Add(new Vector3(-2900.444 , 5590.378 , 0.9219706 , "None"));
Path.Add(new Vector3(-2907.642 , 5586.145 , -0.5080618 , "None"));
Path.Add(new Vector3(-2915.36 , 5591.831 , 0.05128571 , "None"));
Path.Add(new Vector3(-2913.857 , 5583.282 , -0.8839329 , "None"));
Path.Add(new Vector3(-2922.031 , 5590.055 , -0.2281186 , "None"));
Path.Add(new Vector3(-2944.759 , 5599.702 , 1.35101 , "None"));
Path.Add(new Vector3(-2940.115 , 5609.724 , 2.156361 , "None"));
Path.Add(new Vector3(-2946.048 , 5617.988 , 3.686531 , "None"));
Path.Add(new Vector3(-2960.729 , 5620.686 , 2.858911 , "None"));
Path.Add(new Vector3(-2975.532 , 5615.349 , 0.1199829 , "None"));
Path.Add(new Vector3(-2986.126 , 5619.782 , -0.01036429 , "None"));
Path.Add(new Vector3(-3006.555 , 5619.097 , -4.032523 , "None"));
Path.Add(new Vector3(-3017.167 , 5618.046 , -3.534958 , "None"));
Path.Add(new Vector3(-3026.417 , 5616.988 , -3.950734 , "None"));
Path.Add(new Vector3(-3042.82 , 5613.419 , -5.183662 , "None"));
Path.Add(new Vector3(-3058.992 , 5620.042 , -5.468906 , "None"));
Path.Add(new Vector3(-3073.287 , 5623.554 , -5.670462 , "None"));
Path.Add(new Vector3(-3088.386 , 5616.556 , -7.160849 , "None"));
Path.Add(new Vector3(-3096.635 , 5616.983 , -7.164238 , "None"));
Path.Add(new Vector3(-3113.178 , 5638.159 , -4.104144 , "None"));
Path.Add(new Vector3(-3137.978 , 5639.505 , -2.166859 , "None"));
Path.Add(new Vector3(-3140.076 , 5650.506 , -0.9848328 , "None"));
Path.Add(new Vector3(-3131.409 , 5659.322 , -1.222172 , "None"));
Path.Add(new Vector3(-3120.21 , 5677.032 , -0.4600546 , "None"));
Path.Add(new Vector3(-3128.82 , 5689.157 , -0.2135303 , "None"));
Path.Add(new Vector3(-3132.402 , 5697.522 , 0.2821782 , "None"));
Path.Add(new Vector3(-3128.319 , 5704.937 , -0.1146323 , "None"));
Path.Add(new Vector3(-3148.213 , 5720.424 , 0.4998439 , "None"));
Path.Add(new Vector3(-3157.854 , 5736.357 , 0.8358291 , "None"));
Path.Add(new Vector3(-3163.931 , 5756.574 , 1.581642 , "None"));
Path.Add(new Vector3(-3165.24 , 5764.464 , 1.740897 , "None"));
Path.Add(new Vector3(-3171.516 , 5776.126 , 3.039238 , "None"));
Path.Add(new Vector3(-3186.052 , 5767.879 , 3.386851 , "None"));
Path.Add(new Vector3(-3213.422 , 5764 , 3.36778 , "None"));
Path.Add(new Vector3(-3216.063 , 5784.463 , 3.971214 , "None"));
Path.Add(new Vector3(-3199.163 , 5780.777 , 3.688736 , "None"));
Path.Add(new Vector3(-3188.272 , 5808.729 , 2.38018 , "None"));
Path.Add(new Vector3(-3181.491 , 5843.426 , 0.8145821 , "None"));
Path.Add(new Vector3(-3178.674 , 5858.353 , 1.95202 , "None"));
Path.Add(new Vector3(-3175.973 , 5872.018 , 4.099827 , "None"));
Path.Add(new Vector3(-3170.44 , 5881.221 , 5.15025 , "None"));
Path.Add(new Vector3(-3147.175 , 5901.867 , 5.420799 , "None"));
Path.Add(new Vector3(-3143.568 , 5934.059 , 2.578037 , "None"));
Path.Add(new Vector3(-3132.778 , 5940.807 , 1.923964 , "None"));
Path.Add(new Vector3(-3136.149 , 5957.555 , -2.487271 , "None"));
Path.Add(new Vector3(-3140.752 , 5976.938 , -3.37466 , "None"));
Path.Add(new Vector3(-3143.264 , 5967.809 , -4.283187 , "None"));
Path.Add(new Vector3(-3170.598 , 5949.669 , 2.704762 , "None"));
Path.Add(new Vector3(-3202.718 , 5960.292 , 1.448392 , "None"));
Path.Add(new Vector3(-3221.943 , 5958.648 , 0.6618062 , "None"));
Path.Add(new Vector3(-3235.671 , 5971.019 , -1.17424 , "None"));
Path.Add(new Vector3(-3258.465 , 5977.631 , -2.379653 , "None"));
Path.Add(new Vector3(-3285.418 , 5999.253 , -1.795236 , "None"));
Path.Add(new Vector3(-3304.148 , 6029.032 , -0.02391805 , "None"));
Path.Add(new Vector3(-3317.447 , 6033.996 , 0.1311472 , "None"));
Path.Add(new Vector3(-3332.4 , 6034.51 , 0.6069263 , "None"));
Path.Add(new Vector3(-3349.754 , 6024.552 , 0.5718336 , "None"));
Path.Add(new Vector3(-3369.485 , 6012.144 , -3.87991 , "None"));
Path.Add(new Vector3(-3386.783 , 5996.188 , -8.668414 , "None"));
Path.Add(new Vector3(-3390.305 , 5983.954 , -10.72107 , "None"));
Path.Add(new Vector3(-3400.775 , 5949.325 , -17.63404 , "None"));
Path.Add(new Vector3(-3418.696 , 5923.341 , -28.12059 , "None"));
Path.Add(new Vector3(-3445.658 , 5902.392 , -31.20214 , "None"));
Path.Add(new Vector3(-3460.56 , 5893.277 , -28.68559 , "None"));
Path.Add(new Vector3(-3452.507 , 5888.466 , -26.79926 , "None"));
Path.Add(new Vector3(-3473.711 , 5865.812 , -24.13294 , "None"));
Path.Add(new Vector3(-3501.354 , 5856.545 , -18.55152 , "None"));
Path.Add(new Vector3(-3513.85 , 5845.107 , -16.30739 , "None"));
Path.Add(new Vector3(-3512.79 , 5819.08 , -12.83059 , "None"));
Path.Add(new Vector3(-3519.421 , 5806.748 , -9.419856 , "None"));
Path.Add(new Vector3(-3529.496 , 5784.245 , -6.419091 , "None"));
Path.Add(new Vector3(-3532.52 , 5774.87 , -5.498508 , "None"));
Path.Add(new Vector3(-3520.917 , 5753.234 , -0.2310186 , "None"));
Path.Add(new Vector3(-3543.445 , 5740.67 , -2.679936 , "None"));
Path.Add(new Vector3(-3557.683 , 5735.842 , -3.333302 , "None"));
Path.Add(new Vector3(-3579.832 , 5714.16 , -1.338145 , "None"));
Path.Add(new Vector3(-3606.927 , 5721.851 , -4.350058 , "None"));
Path.Add(new Vector3(-3620.781 , 5723.583 , -3.944999 , "None"));
Path.Add(new Vector3(-3631.593 , 5722.217 , -3.865453 , "None"));
Path.Add(new Vector3(-3649.668 , 5717.767 , -2.82914 , "None"));
Path.Add(new Vector3(-3659.783 , 5726.772 , -2.534484 , "None"));
Path.Add(new Vector3(-3681.022 , 5742.363 , -2.150814 , "None"));
Path.Add(new Vector3(-3696.776 , 5760.417 , -3.324249 , "None"));
Path.Add(new Vector3(-3729.229 , 5773.399 , 0.4542163 , "None"));
Path.Add(new Vector3(-3750.537 , 5790.742 , -1.820865 , "None"));
Path.Add(new Vector3(-3773.769 , 5810.856 , -9.062853 , "None"));
Path.Add(new Vector3(-3799.122 , 5832.906 , -13.1001 , "None"));
Path.Add(new Vector3(-3801.431 , 5858.249 , -16.2043 , "None"));
Path.Add(new Vector3(-3781.597 , 5897.335 , 6.112912 , "Flying"));
Path.Add(new Vector3(-3769.372 , 5953.789 , -5.494168 , "Flying"));
Path.Add(new Vector3(-3775.821 , 5976.013 , 10.77195 , "Flying"));
Path.Add(new Vector3(-3802.393 , 5998.504 , -2.550957 , "Flying"));
Path.Add(new Vector3(-3825.689 , 6041.866 , -4.34583 , "Flying"));
Path.Add(new Vector3(-3832.577 , 6030.81 , -4.34583 , "Flying"));
Path.Add(new Vector3(-3850.165 , 6054.914 , -13.45933 , "Flying"));
Path.Add(new Vector3(-3861.651 , 6072.821 , -14.54636 , "Flying"));
Path.Add(new Vector3(-3862.097 , 6091.994 , -6.52543 , "Flying"));
Path.Add(new Vector3(-3851.971 , 6111.454 , -1.804839 , "Flying"));
Path.Add(new Vector3(-3834.259 , 6092.851 , 1.307208 , "Flying"));
Path.Add(new Vector3(-3807.42 , 6091.278 , -7.973285 , "None"));
Path.Add(new Vector3(-3781.008 , 6098.48 , 8.07365 , "Flying"));
Path.Add(new Vector3(-3748.879 , 6105.971 , 1.331552 , "Flying"));
Path.Add(new Vector3(-3719.32 , 6112.452 , 1.20279 , "Flying"));
Path.Add(new Vector3(-3713.788 , 6150.897 , 2.041484 , "Flying"));
Path.Add(new Vector3(-3703.083 , 6137.14 , 2.041484 , "Flying"));
Path.Add(new Vector3(-3685.76 , 6142.847 , 14.85356 , "Flying"));
Path.Add(new Vector3(-3662.993 , 6168.908 , 2.083446 , "Flying"));
Path.Add(new Vector3(-3641.469 , 6164.076 , -0.8408842 , "None"));
Path.Add(new Vector3(-3646.105 , 6153.982 , 2.240797 , "None"));
Path.Add(new Vector3(-3637.629 , 6133.846 , 1.374599 , "None"));
Path.Add(new Vector3(-3620.583 , 6105.463 , 1.866446 , "None"));
Path.Add(new Vector3(-3598.754 , 6106.299 , -5.507512 , "None"));
Path.Add(new Vector3(-3569.056 , 6127.527 , -2.751186 , "None"));
Path.Add(new Vector3(-3549.149 , 6142.177 , 1.601412 , "None"));
Path.Add(new Vector3(-3527.439 , 6159.71 , 1.380136 , "None"));
Path.Add(new Vector3(-3521.181 , 6164.315 , 0.606604 , "None"));
Path.Add(new Vector3(-3512.395 , 6170.317 , 3.275643 , "None"));
Path.Add(new Vector3(-3498.904 , 6174.025 , 1.654166 , "None"));
Path.Add(new Vector3(-3486.321 , 6172.712 , 0.7009205 , "None"));
Path.Add(new Vector3(-3482.874 , 6163.958 , 0.171646 , "None"));
Path.Add(new Vector3(-3455.999 , 6147.264 , -2.000998 , "None"));
Path.Add(new Vector3(-3435.474 , 6151.939 , 0.1070076 , "None"));
Path.Add(new Vector3(-3410.911 , 6155.645 , 1.287142 , "None"));
Path.Add(new Vector3(-3393.249 , 6152.331 , 0.8207223 , "None"));
Path.Add(new Vector3(-3397.314 , 6143.136 , -0.02210377 , "None"));
Path.Add(new Vector3(-3376.555 , 6136.065 , -1.526564 , "None"));
Path.Add(new Vector3(-3385.998 , 6157.183 , 1.453832 , "None"));
Path.Add(new Vector3(-3372.418 , 6170.493 , 1.259026 , "None"));
Path.Add(new Vector3(-3365.125 , 6159.348 , 1.018738 , "None"));
Path.Add(new Vector3(-3352.404 , 6123.499 , -4.34876 , "None"));
Path.Add(new Vector3(-3351.308 , 6112.736 , -4.73219 , "None"));
Path.Add(new Vector3(-3333.334 , 6097.711 , 1.469272 , "None"));
Path.Add(new Vector3(-3329.382 , 6083.358 , 1.571674 , "None"));
Path.Add(new Vector3(-3321.76 , 6082.269 , 1.403276 , "None"));
Path.Add(new Vector3(-3319.379 , 6053.221 , -0.01187127 , "None"));
Path.Add(new Vector3(-3303.296 , 6036.197 , 0.01662928 , "None"));
Path.Add(new Vector3(-3289.312 , 6024.44 , -0.7243226 , "None"));
Path.Add(new Vector3(-3267.544 , 6029.096 , -1.170148 , "None"));
Path.Add(new Vector3(-3247.212 , 6017.162 , -1.689081 , "None"));
Path.Add(new Vector3(-3233.48 , 6005.135 , -0.8570635 , "Flying"));
Path.Add(new Vector3(-3263.678 , 5969.162 , -1.362869 , "Flying"));
Path.Add(new Vector3(-3257.188 , 5959.868 , -2.850675 , "None"));
Path.Add(new Vector3(-3271.414 , 5966.341 , -4.430737 , "None"));
Path.Add(new Vector3(-3297.886 , 5958.765 , -4.027986 , "None"));
Path.Add(new Vector3(-3317.521 , 5927.767 , -15.55592 , "None"));
Path.Add(new Vector3(-3326.266 , 5893.512 , -21.85822 , "None"));
Path.Add(new Vector3(-3322.59 , 5865.532 , -18.90029 , "None"));
Path.Add(new Vector3(-3320.069 , 5852.829 , -18.50204 , "None"));
Path.Add(new Vector3(-3316.539 , 5835.037 , -14.45632 , "None"));
Path.Add(new Vector3(-3339.211 , 5835.337 , -10.65253 , "None"));
Path.Add(new Vector3(-3343.342 , 5812.536 , -9.493987 , "None"));
Path.Add(new Vector3(-3353.205 , 5797.345 , -1.983771 , "None"));
Path.Add(new Vector3(-3370.961 , 5783.436 , -0.4829928 , "None"));
Path.Add(new Vector3(-3389.277 , 5797.375 , -0.6987649 , "None"));
Path.Add(new Vector3(-3396.196 , 5784.771 , -0.9647663 , "None"));
Path.Add(new Vector3(-3395.294 , 5764.187 , -0.1223122 , "None"));
Path.Add(new Vector3(-3381.901 , 5738.877 , 2.903874 , "None"));
Path.Add(new Vector3(-3358.094 , 5736.811 , 5.216093 , "None"));
Path.Add(new Vector3(-3335.673 , 5726.313 , 5.98774 , "None"));
Path.Add(new Vector3(-3311.549 , 5719.836 , 2.040522 , "None"));
Path.Add(new Vector3(-3293.618 , 5696.6 , 0.3250989 , "None"));
Path.Add(new Vector3(-3292.628 , 5665.078 , -2.49105 , "None"));
Path.Add(new Vector3(-3308.532 , 5652.609 , -3.576638 , "None"));
Path.Add(new Vector3(-3292.338 , 5622.603 , -6.399346 , "None"));
Path.Add(new Vector3(-3268.214 , 5595.361 , -6.449513 , "None"));
Path.Add(new Vector3(-3261.834 , 5570.576 , -8.747523 , "None"));
Path.Add(new Vector3(-3262.573 , 5560.153 , -10.72626 , "None"));
Path.Add(new Vector3(-3261.041 , 5525.183 , -12.47215 , "None"));
Path.Add(new Vector3(-3257.358 , 5516.632 , -12.61862 , "None"));
Path.Add(new Vector3(-3252.889 , 5504.789 , -13.84539 , "None"));
Path.Add(new Vector3(-3246.92 , 5491.74 , -15.48023 , "None"));
Path.Add(new Vector3(-3248.118 , 5506.541 , -14.42941 , "None"));
Path.Add(new Vector3(-3257.324 , 5494.121 , -14.24882 , "None"));
Path.Add(new Vector3(-3255.618 , 5459.63 , -15.90059 , "None"));
Path.Add(new Vector3(-3252.825 , 5428.863 , -19.15692 , "None"));
Path.Add(new Vector3(-3240.766 , 5409.376 , -20.22919 , "None"));
Path.Add(new Vector3(-3239.153 , 5395.195 , -20.93907 , "None"));
Path.Add(new Vector3(-3252.424 , 5365.441 , -21.93078 , "None"));
Path.Add(new Vector3(-3258.912 , 5352.872 , -21.50179 , "None"));
Path.Add(new Vector3(-3271.24 , 5342.982 , -21.39649 , "None"));
Path.Add(new Vector3(-3287.31 , 5321.294 , -20.97488 , "None"));
Path.Add(new Vector3(-3293.166 , 5327.242 , -20.74123 , "None"));
Path.Add(new Vector3(-3300.72 , 5354.129 , -20.93441 , "None"));
Path.Add(new Vector3(-3320.115 , 5380.514 , -19.56641 , "None"));
Path.Add(new Vector3(-3316.742 , 5393.426 , -19.28594 , "None"));
Path.Add(new Vector3(-3295.676 , 5411.659 , -16.85995 , "None"));
Path.Add(new Vector3(-3294.497 , 5434.828 , -15.91135 , "None"));
Path.Add(new Vector3(-3295.021 , 5447.697 , -15.33229 , "None"));
Path.Add(new Vector3(-3288.578 , 5478.692 , -13.39228 , "None"));
Path.Add(new Vector3(-3277.44 , 5510.383 , -10.87685 , "None"));
Path.Add(new Vector3(-3284.541 , 5547.437 , -11.41351 , "None"));
Path.Add(new Vector3(-3273.423 , 5577.029 , -8.44269 , "None"));
Path.Add(new Vector3(-3261.389 , 5609.608 , -5.437166 , "None"));
Path.Add(new Vector3(-3253.931 , 5644.063 , -0.810284 , "None"));
Path.Add(new Vector3(-3253.665 , 5651.901 , -0.6848808 , "None"));
Path.Add(new Vector3(-3231.071 , 5657.952 , 0.1162184 , "None"));
Path.Add(new Vector3(-3221.731 , 5679.256 , -0.2019136 , "None"));
Path.Add(new Vector3(-3207.937 , 5711.5 , 0.970638 , "None"));
Path.Add(new Vector3(-3222.071 , 5721.72 , 1.846142 , "None"));
Path.Add(new Vector3(-3226.31 , 5729.464 , 2.68235 , "None"));
Path.Add(new Vector3(-3214.747 , 5729.133 , 1.888831 , "None"));
Path.Add(new Vector3(-3197.064 , 5747.446 , 2.321888 , "None"));
Path.Add(new Vector3(-3162.216 , 5781.181 , 2.523738 , "Flying"));
Path.Add(new Vector3(-3158.489 , 5765.185 , 2.572881 , "Flying"));
Path.Add(new Vector3(-3177.08 , 5766.619 , 2.703333 , "None"));
Path.Add(new Vector3(-3180.991 , 5779.916 , 4.327208 , "None"));
Path.Add(new Vector3(-3175.918 , 5774.054 , 3.393334 , "None"));
Path.Add(new Vector3(-3186.196 , 5764.723 , 3.07599 , "None"));
Path.Add(new Vector3(-3217.688 , 5778.231 , 3.848935 , "None"));
Path.Add(new Vector3(-3227.859 , 5791.676 , 3.243256 , "None"));
Path.Add(new Vector3(-3258.664 , 5793.226 , -0.1242549 , "None"));
Path.Add(new Vector3(-3282.764 , 5784.065 , 1.217938 , "None"));
Path.Add(new Vector3(-3307.747 , 5767.316 , 1.480434 , "None"));
Path.Add(new Vector3(-3323.219 , 5753.211 , 3.90154 , "None"));
Path.Add(new Vector3(-3322.665 , 5738.328 , 3.335359 , "None"));
Path.Add(new Vector3(-3336.171 , 5724.933 , 6.148883 , "None"));
Path.Add(new Vector3(-3356.79 , 5742.342 , 4.994181 , "None"));
Path.Add(new Vector3(-3370.439 , 5739.179 , 4.396402 , "None"));
Path.Add(new Vector3(-3387.91 , 5736.829 , 3.229624 , "None"));
Path.Add(new Vector3(-3411.56 , 5734.381 , 3.287466 , "None"));
Path.Add(new Vector3(-3427.878 , 5733.724 , 3.019917 , "None"));
Path.Add(new Vector3(-3454.535 , 5730.89 , -0.07787751 , "None"));
Path.Add(new Vector3(-3463.595 , 5730.807 , 0.08032445 , "None"));
Path.Add(new Vector3(-3463.425 , 5749.449 , -1.926278 , "None"));
Path.Add(new Vector3(-3454.661 , 5758.101 , -2.882541 , "None"));
Path.Add(new Vector3(-3446.026 , 5771.195 , -1.011856 , "None"));
Path.Add(new Vector3(-3443.491 , 5802.106 , -1.58271 , "None"));
Path.Add(new Vector3(-3440.482 , 5814.744 , -0.8338809 , "None"));
Path.Add(new Vector3(-3454.002 , 5840.261 , -14.54779 , "None"));
Path.Add(new Vector3(-3484.515 , 5857.694 , -22.12126 , "None"));
Path.Add(new Vector3(-3474.789 , 5883.004 , -26.70239 , "None"));
Path.Add(new Vector3(-3461.617 , 5897.436 , -29.92792 , "None"));
Path.Add(new Vector3(-3446.409 , 5914.676 , -33.44332 , "None"));
Path.Add(new Vector3(-3436.513 , 5925.812 , -32.09296 , "None"));
Path.Add(new Vector3(-3405.702 , 5948.456 , -19.84555 , "Flying"));
Path.Add(new Vector3(-3431.336 , 5985.539 , -24.09551 , "Flying"));
Path.Add(new Vector3(-3405.45 , 5983.579 , -15.1623 , "Flying"));
Path.Add(new Vector3(-3392.779 , 5992.872 , -9.211643 , "Flying"));
Path.Add(new Vector3(-3383.607 , 5984.558 , -8.659789 , "None"));
Path.Add(new Vector3(-3394.425 , 5985.392 , -11.46185 , "None"));
Path.Add(new Vector3(-3390.326 , 5994.139 , -9.524567 , "None"));
Path.Add(new Vector3(-3387.089 , 6001.048 , -8.17248 , "None"));
Path.Add(new Vector3(-3391.063 , 6017.988 , -6.385733 , "None"));
Path.Add(new Vector3(-3400.607 , 6033.007 , -9.279162 , "None"));
Path.Add(new Vector3(-3428.875 , 6054.594 , -11.94892 , "None"));
Path.Add(new Vector3(-3458.897 , 6063.154 , -13.58071 , "None"));
Path.Add(new Vector3(-3478.116 , 6068.95 , -16.51618 , "None"));
Path.Add(new Vector3(-3467.232 , 6087.988 , -12.10816 , "None"));
Path.Add(new Vector3(-3458.459 , 6110.665 , -6.815181 , "None"));
Path.Add(new Vector3(-3433.854 , 6122.179 , -5.047384 , "None"));
Path.Add(new Vector3(-3418.278 , 6134.243 , -0.873417 , "None"));
Path.Add(new Vector3(-3395.837 , 6149.086 , 0.5013539 , "None"));
Path.Add(new Vector3(-3368.454 , 6167.61 , 1.591879 , "None"));
Path.Add(new Vector3(-3360.65 , 6179.427 , 3.631074 , "None"));
Path.Add(new Vector3(-3360.65 , 6179.427 , 22.68108 , "Flying"));
Path.Add(new Vector3(-3341.144 , 6202.626 , 20.87264 , "None"));
Path.Add(new Vector3(-3339.501 , 6211.428 , 14.46867 , "None"));
Path.Add(new Vector3(-3336.238 , 6181.811 , 9.779213 , "None"));
Path.Add(new Vector3(-3333.641 , 6166.784 , 2.552946 , "None"));
Path.Add(new Vector3(-3345.177 , 6185.923 , 5.140704 , "None"));
Path.Add(new Vector3(-3361.554 , 6179.957 , 3.448757 , "None"));
Path.Add(new Vector3(-3375 , 6175.215 , 0.7924691 , "None"));
Path.Add(new Vector3(-3377.41 , 6186.397 , -0.9342463 , "None"));
Path.Add(new Vector3(-3377.897 , 6178.032 , -0.1544574 , "None"));
Path.Add(new Vector3(-3399.069 , 6171.855 , 2.012349 , "None"));
Path.Add(new Vector3(-3407.935 , 6171.204 , 3.822426 , "None"));
Path.Add(new Vector3(-3417.566 , 6162.799 , 0.8984196 , "None"));
Path.Add(new Vector3(-3425.863 , 6171.729 , -2.079541 , "None"));
Path.Add(new Vector3(-3434.289 , 6177.132 , 0.1241395 , "None"));
Path.Add(new Vector3(-3430.738 , 6181.933 , -4.975934 , "None"));
Path.Add(new Vector3(-3428.977 , 6170.902 , -1.68992 , "None"));
Path.Add(new Vector3(-3439.65 , 6167.178 , 2.709913 , "None"));
Path.Add(new Vector3(-3454.7 , 6158.311 , 0.4553678 , "None"));
Path.Add(new Vector3(-3474.828 , 6170.913 , 2.283054 , "None"));
Path.Add(new Vector3(-3482.589 , 6187.064 , -0.09502935 , "None"));
Path.Add(new Vector3(-3491.283 , 6186.506 , 1.249874 , "None"));
Path.Add(new Vector3(-3511.058 , 6189.138 , 2.375528 , "None"));
Path.Add(new Vector3(-3509.279 , 6181.438 , 4.077498 , "None"));
Path.Add(new Vector3(-3518.44 , 6181.517 , 1.528489 , "None"));
Path.Add(new Vector3(-3532.602 , 6182.683 , 3.279918 , "None"));
Path.Add(new Vector3(-3550.74 , 6180.068 , 4.541644 , "None"));
Path.Add(new Vector3(-3569.229 , 6182.689 , 1.66217 , "None"));
Path.Add(new Vector3(-3585.825 , 6189.994 , -4.677697 , "None"));
Path.Add(new Vector3(-3593.881 , 6200.664 , -6.522205 , "None"));
Path.Add(new Vector3(-3602.269 , 6196.466 , -6.649501 , "None"));
Path.Add(new Vector3(-3597.997 , 6168.26 , -6.575684 , "None"));
Path.Add(new Vector3(-3593.728 , 6161.017 , -2.560044 , "None"));
Path.Add(new Vector3(-3579.186 , 6128.735 , -2.461389 , "None"));
Path.Add(new Vector3(-3582.892 , 6094.403 , -8.504815 , "None"));
Path.Add(new Vector3(-3589.075 , 6083.995 , -8.588576 , "None"));
Path.Add(new Vector3(-3601.45 , 6078.903 , -5.590273 , "None"));
Path.Add(new Vector3(-3612.522 , 6066.172 , -5.618775 , "None"));
Path.Add(new Vector3(-3626.034 , 6055.953 , -3.584444 , "None"));
Path.Add(new Vector3(-3645.689 , 6049.735 , -5.582367 , "None"));
Path.Add(new Vector3(-3679.038 , 6043.015 , -5.127546 , "None"));
Path.Add(new Vector3(-3690.428 , 6048.526 , -4.445857 , "None"));
Path.Add(new Vector3(-3716.182 , 6032.428 , 1.659364 , "None"));
Path.Add(new Vector3(-3729.251 , 6027.216 , 1.108088 , "None"));
Path.Add(new Vector3(-3737.62 , 6023.046 , 1.055016 , "None"));
Path.Add(new Vector3(-3753.838 , 6005.148 , 1.724931 , "None"));
Path.Add(new Vector3(-3773.258 , 5973.89 , 0.6814728 , "None"));
Path.Add(new Vector3(-3787.989 , 5956.934 , -5.89021 , "None"));
Path.Add(new Vector3(-3801.941 , 5935.362 , -12.94388 , "None"));
Path.Add(new Vector3(-3789.158 , 5923.689 , -15.5992 , "None"));
Path.Add(new Vector3(-3778.977 , 5933.476 , -14.38977 , "None"));
Path.Add(new Vector3(-3765.481 , 5932.774 , -5.632918 , "None"));
Path.Add(new Vector3(-3754.78 , 5909.683 , -1.323988 , "None"));
Path.Add(new Vector3(-3739.194 , 5891.466 , -4.079608 , "None"));
Path.Add(new Vector3(-3724.486 , 5880.866 , -3.87482 , "None"));
Path.Add(new Vector3(-3707.506 , 5868.628 , -2.589232 , "None"));
Path.Add(new Vector3(-3694.218 , 5859.05 , -1.509953 , "None"));
Path.Add(new Vector3(-3710.437 , 5855.891 , -1.861751 , "None"));
Path.Add(new Vector3(-3723.538 , 5863.362 , -3.78599 , "None"));
Path.Add(new Vector3(-3737.585 , 5864.165 , -7.736288 , "None"));
Path.Add(new Vector3(-3750.637 , 5875.448 , -6.346873 , "None"));
Path.Add(new Vector3(-3750.385 , 5857.141 , -8.501475 , "None"));
Path.Add(new Vector3(-3755.287 , 5839.631 , -11.98766 , "None"));
Path.Add(new Vector3(-3761.889 , 5833.471 , -15.96251 , "None"));
Path.Add(new Vector3(-3764.112 , 5843.215 , -13.64567 , "None"));
Path.Add(new Vector3(-3766.488 , 5861.553 , -7.207351 , "None"));
Path.Add(new Vector3(-3792.66 , 5864.206 , -12.31769 , "None"));
Path.Add(new Vector3(-3790.397 , 5850.907 , -13.44796 , "None"));
Path.Add(new Vector3(-3780.979 , 5853.861 , -10.19702 , "None"));
Path.Add(new Vector3(-3772.657 , 5868.492 , -7.625663 , "None"));
Path.Add(new Vector3(-3773.267 , 5881.6 , -6.308383 , "None"));
Path.Add(new Vector3(-3773.662 , 5893.509 , -6.330526 , "None"));
Path.Add(new Vector3(-3766.37 , 5904.6 , -4.037044 , "None"));
Path.Add(new Vector3(-3787.21 , 5932.082 , -11.65156 , "None"));
Path.Add(new Vector3(-3774.951 , 5938.349 , -11.69583 , "None"));
Path.Add(new Vector3(-3772.651 , 5970.883 , 0.3779376 , "None"));
Path.Add(new Vector3(-3789.729 , 5972.243 , -4.344352 , "None"));
Path.Add(new Vector3(-3804.741 , 5961.502 , -10.90423 , "None"));
Path.Add(new Vector3(-3812.103 , 5964.2 , -12.88554 , "None"));
Path.Add(new Vector3(-3823.885 , 5973.106 , -19.43977 , "None"));
Path.Add(new Vector3(-3830.074 , 5978.07 , -22.98889 , "None"));
Path.Add(new Vector3(-3830.026 , 5978.038 , -0.02340508 , "Flying"));
Path.Add(new Vector3(-3839.346 , 5974.669 , -16.64498 , "Flying"));
Path.Add(new Vector3(-3854.502 , 5973.194 , 3.016959 , "Flying"));
Path.Add(new Vector3(-3880.295 , 5988.544 , 13.48448 , "Flying"));
Path.Add(new Vector3(-3887.627 , 6029.827 , -11.34544 , "Flying"));
Path.Add(new Vector3(-3895.916 , 6082.806 , -29.59608 , "Flying"));
Path.Add(new Vector3(-3896.704 , 6095.814 , -30.2733 , "Flying"));
Path.Add(new Vector3(-3877.446 , 6090.027 , -22.62763 , "Flying"));
Path.Add(new Vector3(-3867.633 , 6080.132 , -19.40671 , "None"));
Path.Add(new Vector3(-3838.074 , 6065.882 , -10.70309 , "None"));
Path.Add(new Vector3(-3831.813 , 6091.407 , -11.13844 , "None"));
Path.Add(new Vector3(-3842.277 , 6109.437 , -15.91308 , "None"));
Path.Add(new Vector3(-3849.406 , 6112.163 , -18.10638 , "None"));
Path.Add(new Vector3(-3837.897 , 6145.661 , -21.27972 , "None"));
Path.Add(new Vector3(-3826.183 , 6179.755 , -28.20933 , "None"));
Path.Add(new Vector3(-3834.572 , 6211.122 , -2.328089 , "Flying"));
Path.Add(new Vector3(-3851.808 , 6236.081 , -28.41137 , "Flying"));
Path.Add(new Vector3(-3872.885 , 6251.848 , -7.783247 , "Flying"));
Path.Add(new Vector3(-3908.701 , 6257.619 , -16.98191 , "Flying"));
Path.Add(new Vector3(-3960.344 , 6258.137 , -35.47991 , "Flying"));
Path.Add(new Vector3(-4016.128 , 6263.6 , -10.29048 , "Flying"));
Path.Add(new Vector3(-4064.659 , 6291.528 , -36.07356 , "Flying"));
Path.Add(new Vector3(-4093.259 , 6311.689 , -16.03161 , "Flying"));
Path.Add(new Vector3(-4148.083 , 6320.845 , 14.32857 , "Flying"));
Path.Add(new Vector3(-4208.022 , 6326.336 , 13.77401 , "Flying"));
Path.Add(new Vector3(-4230.142 , 6297.112 , 41.3919 , "Flying"));
Path.Add(new Vector3(-4234.761 , 6243.68 , 47.15822 , "Flying"));
Path.Add(new Vector3(-4202.874 , 6176.297 , 25.07632 , "Flying"));
Path.Add(new Vector3(-4159.479 , 6137.563 , 61.34227 , "Flying"));
Path.Add(new Vector3(-4120.343 , 6097.979 , 103.7453 , "Flying"));
Path.Add(new Vector3(-4104.157 , 6042.658 , 70.11313 , "Flying"));
Path.Add(new Vector3(-4078.01 , 5971.591 , 48.60345 , "Flying"));
Path.Add(new Vector3(-4041.85 , 5934.747 , 10.58545 , "Flying"));
Path.Add(new Vector3(-3986.105 , 5943.256 , -23.03207 , "Flying"));
Path.Add(new Vector3(-3956.889 , 5937.35 , -4.20942 , "Flying"));
Path.Add(new Vector3(-3891.089 , 5941.017 , -7.639562 , "Flying"));
Path.Add(new Vector3(-3819.879 , 5950.329 , 0.2449477 , "Flying"));
Path.Add(new Vector3(-3784.801 , 5954.82 , -5.011829 , "None"));
Path.Add(new Vector3(-3755.74 , 5969.024 , 0.3350303 , "None"));
Path.Add(new Vector3(-3738.873 , 5974.297 , -0.7618837 , "None"));
Path.Add(new Vector3(-3736.379 , 5996.551 , -0.04399578 , "None"));
Path.Add(new Vector3(-3711.556 , 6019.277 , -0.8235092 , "None"));
Path.Add(new Vector3(-3677.562 , 6032.881 , -3.37925 , "None"));
Path.Add(new Vector3(-3645.042 , 6039.228 , -3.791903 , "None"));
Path.Add(new Vector3(-3614.758 , 6048.104 , -6.99536 , "None"));
Path.Add(new Vector3(-3580.777 , 6058.582 , -15.54784 , "None"));
Path.Add(new Vector3(-3546.36 , 6061.563 , -22.16879 , "None"));
Path.Add(new Vector3(-3514.172 , 6065.243 , -16.57624 , "None"));
Path.Add(new Vector3(-3480.228 , 6068.959 , -16.6638 , "None"));
Path.Add(new Vector3(-3466.046 , 6065.879 , -16.11123 , "None"));
Path.Add(new Vector3(-3438.619 , 6045.612 , -11.55019 , "None"));
Path.Add(new Vector3(-3441.905 , 6024.604 , -15.72069 , "None"));
Path.Add(new Vector3(-3421.023 , 6044.769 , -12.21708 , "None"));
Path.Add(new Vector3(-3390.109 , 6042.661 , -3.890346 , "None"));
Path.Add(new Vector3(-3378.006 , 6036.384 , -0.269433 , "None"));
Path.Add(new Vector3(-3389.032 , 6018.718 , -5.868222 , "None"));
Path.Add(new Vector3(-3402.646 , 5987.28 , -12.92667 , "None"));
Path.Add(new Vector3(-3427.359 , 5963.294 , -23.20652 , "None"));
Path.Add(new Vector3(-3451.242 , 5936.111 , -31.85242 , "None"));
Path.Add(new Vector3(-3474.39 , 5909.209 , -31.41105 , "None"));
Path.Add(new Vector3(-3497.749 , 5883.24 , -26.2662 , "None"));
Path.Add(new Vector3(-3527.094 , 5865.914 , -18.84433 , "None"));
Path.Add(new Vector3(-3555.234 , 5849.991 , -9.817234 , "None"));
Path.Add(new Vector3(-3568.077 , 5849.094 , -6.431083 , "None"));
Path.Add(new Vector3(-3586.958 , 5838.584 , -2.880873 , "None"));
Path.Add(new Vector3(-3592.58 , 5848.028 , -1.388326 , "None"));
Path.Add(new Vector3(-3613.201 , 5832.058 , -2.538219 , "None"));
Path.Add(new Vector3(-3622.567 , 5821.651 , -3.735559 , "None"));
Path.Add(new Vector3(-3630.804 , 5830.336 , -0.04005158 , "None"));
Path.Add(new Vector3(-3628.922 , 5843.285 , -0.2628779 , "None"));
Path.Add(new Vector3(-3640.114 , 5851.358 , -0.7176857 , "None"));
Path.Add(new Vector3(-3657.007 , 5860.107 , -3.431178 , "None"));
Path.Add(new Vector3(-3689.499 , 5874.386 , -5.207751 , "None"));
Path.Add(new Vector3(-3711.228 , 5882.225 , -4.254903 , "None"));
Path.Add(new Vector3(-3716.95 , 5863.98 , -2.934304 , "None"));
Path.Add(new Vector3(-3742.845 , 5841.6 , -7.30699 , "None"));
Path.Add(new Vector3(-3772.38 , 5818.803 , -10.44642 , "None"));
Path.Add(new Vector3(-3800.364 , 5797.203 , -11.70416 , "None"));
Path.Add(new Vector3(-3826.685 , 5776.887 , -17.3772 , "None"));
Path.Add(new Vector3(-3834.055 , 5771.198 , -19.74562 , "Flying"));
Path.Add(new Vector3(-3824.645 , 5782.527 , -28.72656 , "Flying"));
Path.Add(new Vector3(-3819.439 , 5788.123 , -28.18597 , "None"));
Path.Add(new Vector3(-3819.387 , 5788.148 , -4.635572 , "Flying"));
Path.Add(new Vector3(-3795.553 , 5803.648 , -10.09324 , "Flying"));
Path.Add(new Vector3(-3770.438 , 5821.164 , -12.4001 , "None"));
Path.Add(new Vector3(-3789.951 , 5834.52 , -18.78115 , "None"));
Path.Add(new Vector3(-3816.956 , 5857.655 , -22.57371 , "None"));
Path.Add(new Vector3(-3819.667 , 5859.978 , -9.279441 , "Flying"));
Path.Add(new Vector3(-3798.257 , 5860.938 , -11.94555 , "Flying"));
Path.Add(new Vector3(-3782.787 , 5849.074 , -12.7006 , "None"));
Path.Add(new Vector3(-3780.848 , 5853.877 , 11.57711 , "Flying"));
Path.Add(new Vector3(-3761.423 , 5854.454 , -1.184765 , "Flying"));
Path.Add(new Vector3(-3759.789 , 5876.487 , -4.602448 , "None"));
Path.Add(new Vector3(-3779.9 , 5904.558 , -6.537437 , "None"));
Path.Add(new Vector3(-3788.544 , 5911.101 , -9.270206 , "None"));
Path.Add(new Vector3(-3797.83 , 5913.483 , -12.61455 , "None"));
Path.Add(new Vector3(-3816.689 , 5924.034 , -20.71041 , "None"));
Path.Add(new Vector3(-3852.997 , 5922.789 , -24.20963 , "None"));
Path.Add(new Vector3(-3861.952 , 5922.482 , -15.97145 , "Flying"));
Path.Add(new Vector3(-3846.302 , 5936.55 , -15.37878 , "Flying"));
Path.Add(new Vector3(-3892.963 , 5964.606 , 3.500973 , "Flying"));
Path.Add(new Vector3(-3898.2 , 5987.921 , -7.711881 , "Flying"));
Path.Add(new Vector3(-3934.529 , 6042.002 , -17.02957 , "Flying"));
Path.Add(new Vector3(-3958.609 , 6113.056 , -17.02957 , "Flying"));
Path.Add(new Vector3(-3934.168 , 6181.441 , -17.02957 , "Flying"));
Path.Add(new Vector3(-3870.752 , 6201.461 , 5.949177 , "Flying"));
Path.Add(new Vector3(-3846.177 , 6203.466 , 24.19253 , "Flying"));
Path.Add(new Vector3(-3840.497 , 6182.6 , -0.6856187 , "Flying"));
Path.Add(new Vector3(-3840.361 , 6168.961 , -16.18549 , "Flying"));
Path.Add(new Vector3(-3810.4 , 6201.035 , -16.18549 , "Flying"));
Path.Add(new Vector3(-3772.646 , 6214.305 , 20.65702 , "Flying"));
Path.Add(new Vector3(-3737.447 , 6163.996 , -10.5944 , "Flying"));
Path.Add(new Vector3(-3745.137 , 6150.446 , -9.114225 , "Flying"));
Path.Add(new Vector3(-3717.676 , 6181.665 , -11.99858 , "Flying"));
Path.Add(new Vector3(-3707.422 , 6207.476 , -16.77193 , "Flying"));
Path.Add(new Vector3(-3707.422 , 6207.476 , 8.128069 , "Flying"));
Path.Add(new Vector3(-3689.171 , 6205.815 , -7.097982 , "Flying"));
Path.Add(new Vector3(-3661.116 , 6240.981 , -7.097982 , "Flying"));
Path.Add(new Vector3(-3644.951 , 6225.729 , -18.97387 , "Flying"));
Path.Add(new Vector3(-3624.705 , 6247.866 , 3.976134 , "Flying"));
Path.Add(new Vector3(-3596.281 , 6242.439 , -8.517064 , "Flying"));
Path.Add(new Vector3(-3588.999 , 6234.814 , -16.06426 , "None"));
Path.Add(new Vector3(-3585.304 , 6228.916 , -12.97729 , "None"));
Path.Add(new Vector3(-3571.277 , 6233.551 , 13.05265 , "Flying"));
Path.Add(new Vector3(-3536.425 , 6251.617 , -10.42287 , "Flying"));
Path.Add(new Vector3(-3526.053 , 6257.91 , -20.19515 , "Flying"));
Path.Add(new Vector3(-3514.217 , 6248.357 , 9.482915 , "Flying"));
Path.Add(new Vector3(-3478.807 , 6248.02 , 1.313349 , "Flying"));
Path.Add(new Vector3(-3441.77 , 6260.053 , 1.313349 , "Flying"));
Path.Add(new Vector3(-3428.074 , 6257.446 , 1.313349 , "Flying"));
Path.Add(new Vector3(-3404.113 , 6247.111 , 1.313349 , "Flying"));
Path.Add(new Vector3(-3367.956 , 6233.005 , 0.6271847 , "Flying"));
Path.Add(new Vector3(-3374.342 , 6231.639 , 25.07336 , "Flying"));
Path.Add(new Vector3(-3394.279 , 6232.275 , 25.07336 , "Flying"));
Path.Add(new Vector3(-3368.421 , 6208.351 , 0.864203 , "Flying"));
Path.Add(new Vector3(-3356.902 , 6199.842 , 2.097879 , "None"));
Path.Add(new Vector3(-3344.777 , 6196.641 , 7.324025 , "None"));
Path.Add(new Vector3(-3350.174 , 6181.896 , 5.154874 , "None"));
Path.Add(new Vector3(-3374.505 , 6170.929 , 1.029544 , "None"));
Path.Add(new Vector3(-3397.636 , 6160.215 , 0.9354328 , "None"));
Path.Add(new Vector3(-3418.951 , 6148.542 , 1.046423 , "None"));
Path.Add(new Vector3(-3403.764 , 6149.535 , 1.084719 , "None"));
Path.Add(new Vector3(-3411.469 , 6127.482 , -2.121492 , "None"));
Path.Add(new Vector3(-3412.774 , 6105.086 , -4.818899 , "None"));
Path.Add(new Vector3(-3427.049 , 6112.258 , -3.993106 , "None"));
Path.Add(new Vector3(-3446.682 , 6085.986 , -8.717112 , "None"));
Path.Add(new Vector3(-3423.675 , 6065.721 , -10.83342 , "None"));
Path.Add(new Vector3(-3446.042 , 6043.498 , -11.56682 , "None"));
Path.Add(new Vector3(-3453.527 , 6015.252 , -17.28643 , "None"));
Path.Add(new Vector3(-3441.909 , 5980.019 , -25.54171 , "None"));
Path.Add(new Vector3(-3430.928 , 5945.829 , -26.42672 , "None"));
Path.Add(new Vector3(-3436.972 , 5940.579 , -28.70517 , "None"));
Path.Add(new Vector3(-3459.146 , 5919.488 , -33.81971 , "None"));
Path.Add(new Vector3(-3470.885 , 5884.558 , -26.94734 , "None"));
Path.Add(new Vector3(-3480.914 , 5850.878 , -21.09743 , "None"));
Path.Add(new Vector3(-3458.213 , 5827.519 , -6.602481 , "None"));
Path.Add(new Vector3(-3429.101 , 5815.966 , -2.274885 , "None"));
Path.Add(new Vector3(-3400.299 , 5795.472 , -1.364209 , "None"));
Path.Add(new Vector3(-3391.123 , 5801.384 , -1.242052 , "None"));
Path.Add(new Vector3(-3372.277 , 5795.238 , -1.321707 , "None"));
Path.Add(new Vector3(-3348.553 , 5793.007 , -1.734873 , "None"));
Path.Add(new Vector3(-3348.778 , 5785.217 , -1.419441 , "None"));
Path.Add(new Vector3(-3333.03 , 5784.418 , -1.968668 , "None"));
Path.Add(new Vector3(-3340.815 , 5780.256 , -1.571994 , "None"));
Path.Add(new Vector3(-3313.723 , 5765.786 , 1.794415 , "None"));
Path.Add(new Vector3(-3292.583 , 5774.592 , 1.929234 , "None"));
Path.Add(new Vector3(-3265.3 , 5794.771 , -0.04939851 , "None"));
Path.Add(new Vector3(-3261.783 , 5811.232 , -6.506565 , "None"));
Path.Add(new Vector3(-3273.985 , 5803.515 , -2.869446 , "None"));
Path.Add(new Vector3(-3291.237 , 5804.686 , -7.473884 , "None"));
Path.Add(new Vector3(-3292.949 , 5815.223 , -9.450064 , "None"));
Path.Add(new Vector3(-3282.345 , 5830.514 , -15.37628 , "None"));
Path.Add(new Vector3(-3260.923 , 5863.137 , -20.88698 , "None"));
Path.Add(new Vector3(-3246.815 , 5881.393 , -14.42557 , "None"));
Path.Add(new Vector3(-3228.32 , 5910.511 , -8.671618 , "None"));
Path.Add(new Vector3(-3228.295 , 5941.434 , -2.111428 , "None"));
Path.Add(new Vector3(-3232.146 , 5955.838 , 0.5719057 , "None"));
Path.Add(new Vector3(-3212.139 , 5947.786 , 1.34012 , "None"));
Path.Add(new Vector3(-3184.437 , 5951.385 , 2.674265 , "None"));
Path.Add(new Vector3(-3160.612 , 5963.972 , -2.777413 , "None"));
Path.Add(new Vector3(-3130.732 , 5976.652 , -2.449967 , "None"));
Path.Add(new Vector3(-3112.631 , 5996.662 , 0.682064 , "None"));
Path.Add(new Vector3(-3107.481 , 6007.504 , 5.269845 , "None"));
Path.Add(new Vector3(-3088.303 , 6005.6 , 3.726017 , "None"));
Path.Add(new Vector3(-3067.965 , 6016.427 , 5.374605 , "None"));
Path.Add(new Vector3(-3034.855 , 6027.354 , 6.188232 , "None"));
Path.Add(new Vector3(-2999.528 , 6029.815 , 4.466762 , "None"));
Path.Add(new Vector3(-2986.135 , 6020.385 , 4.53161 , "None"));
Path.Add(new Vector3(-2959.141 , 6024.648 , 1.705396 , "None"));
Path.Add(new Vector3(-2937.815 , 6036.879 , -0.2372521 , "Swimming"));
Path.Add(new Vector3(-2917.289 , 6048.784 , -0.6731828 , "None"));
Path.Add(new Vector3(-2896.092 , 6061.483 , 0.2129376 , "None"));
Path.Add(new Vector3(-2875.852 , 6074.478 , 2.086418 , "None"));
Path.Add(new Vector3(-2855.968 , 6087.243 , 0.2919539 , "Swimming"));
Path.Add(new Vector3(-2836.6 , 6099.678 , 2.172589 , "None"));
Path.Add(new Vector3(-2815.01 , 6108.5 , 1.578778 , "None"));
Path.Add(new Vector3(-2792.069 , 6111.13 , 3.720634 , "None"));
Path.Add(new Vector3(-2767.822 , 6110.762 , 1.450497 , "Swimming"));
Path.Add(new Vector3(-2741.505 , 6102.686 , 4.260233 , "None"));
Path.Add(new Vector3(-2715.41 , 6124.554 , 6.342444 , "None"));
Path.Add(new Vector3(-2698.835 , 6155.376 , 3.961672 , "None"));
Path.Add(new Vector3(-2693.388 , 6186.719 , 7.447686 , "None"));
Path.Add(new Vector3(-2702.944 , 6194.6 , 8.235366 , "None"));
Path.Add(new Vector3(-2715.055 , 6189.566 , 6.046174 , "None"));
Path.Add(new Vector3(-2737.24 , 6181.579 , 5.04014 , "None"));
Path.Add(new Vector3(-2754.737 , 6186.885 , 6.301369 , "None"));
Path.Add(new Vector3(-2768.56 , 6184.26 , 5.528046 , "None"));
Path.Add(new Vector3(-2793.742 , 6177.893 , 5.195042 , "None"));
Path.Add(new Vector3(-2813.482 , 6173.315 , 7.074281 , "None"));
Path.Add(new Vector3(-2817.57 , 6164.531 , 6.90345 , "None"));
Path.Add(new Vector3(-2820.83 , 6154.827 , 7.649847 , "None"));
Path.Add(new Vector3(-2804.346 , 6162.228 , 6.017559 , "None"));
Path.Add(new Vector3(-2797.79 , 6173.791 , 5.655852 , "None"));
Path.Add(new Vector3(-2787.86 , 6174.791 , 4.907895 , "None"));
Path.Add(new Vector3(-2763.209 , 6180.478 , 5.498028 , "None"));
Path.Add(new Vector3(-2749.329 , 6182.894 , 5.671804 , "None"));
Path.Add(new Vector3(-2731.513 , 6188.032 , 6.842907 , "None"));
Path.Add(new Vector3(-2702.879 , 6195.577 , 8.481462 , "None"));
Path.Add(new Vector3(-2682.603 , 6216.194 , 26.06621 , "None"));
Path.Add(new Vector3(-2692.514 , 6226.075 , 22.8378 , "None"));
Path.Add(new Vector3(-2692.409 , 6251.122 , 25.59636 , "None"));
Path.Add(new Vector3(-2696.51 , 6266.736 , 29.13958 , "None"));
Path.Add(new Vector3(-2715.768 , 6296.603 , 33.43415 , "None"));
Path.Add(new Vector3(-2727.887 , 6298.743 , 34.52041 , "None"));
Path.Add(new Vector3(-2749.254 , 6284.704 , 38.02199 , "None"));
Path.Add(new Vector3(-2740.757 , 6305.653 , 35.56217 , "None"));
Path.Add(new Vector3(-2719.359 , 6319.366 , 32.32843 , "None"));
Path.Add(new Vector3(-2685.212 , 6323.554 , 33.63284 , "None"));
Path.Add(new Vector3(-2657.341 , 6303.82 , 38.56794 , "None"));
Path.Add(new Vector3(-2634.27 , 6281.664 , 39.36027 , "None"));
Path.Add(new Vector3(-2633.425 , 6256.48 , 34.94657 , "None"));
Path.Add(new Vector3(-2645.287 , 6224.36 , 36.05716 , "None"));
Path.Add(new Vector3(-2641.791 , 6191.738 , 35.8658 , "None"));
Path.Add(new Vector3(-2650.209 , 6186.894 , 36.59437 , "None"));
Path.Add(new Vector3(-2653.606 , 6159.209 , 38.10725 , "None"));
Path.Add(new Vector3(-2667.328 , 6130.034 , 39.02436 , "None"));
Path.Add(new Vector3(-2693.601 , 6105.449 , 40.95126 , "None"));
Path.Add(new Vector3(-2711.885 , 6077.21 , 39.1625 , "None"));
Path.Add(new Vector3(-2734.455 , 6051.929 , 37.10931 , "None"));
Path.Add(new Vector3(-2762.511 , 6032.466 , 33.63201 , "None"));
Path.Add(new Vector3(-2741.643 , 6057.202 , 37.71218 , "None"));
Path.Add(new Vector3(-2726.446 , 6087.168 , 29.65587 , "None"));
Path.Add(new Vector3(-2717.414 , 6104.667 , 37.72025 , "Flying"));
Path.Add(new Vector3(-2677.183 , 6163.15 , 53.44515 , "Flying"));
Path.Add(new Vector3(-2650.085 , 6229.913 , 41.57409 , "Flying"));
Path.Add(new Vector3(-2670.841 , 6292.439 , 61.02005 , "Flying"));
Path.Add(new Vector3(-2706.158 , 6357.2 , 49.91518 , "Flying"));
Path.Add(new Vector3(-2733.03 , 6396.483 , 61.60538 , "Flying"));
Path.Add(new Vector3(-2771.467 , 6417.99 , 69.95099 , "Flying"));
Path.Add(new Vector3(-2775.137 , 6418.922 , 78.61961 , "Flying"));
Path.Add(new Vector3(-2845.744 , 6421.555 , 82.4435 , "Flying"));
Path.Add(new Vector3(-2864.696 , 6400.317 , 80.46333 , "Flying"));
Path.Add(new Vector3(-2873.907 , 6383.365 , 82.2373 , "Flying"));
Path.Add(new Vector3(-2874.179 , 6397.912 , 82.2373 , "Flying"));
Path.Add(new Vector3(-2874.179 , 6397.912 , 98.7373 , "Flying"));
Path.Add(new Vector3(-2838.396 , 6420.46 , 127.7792 , "Flying"));
Path.Add(new Vector3(-2825.391 , 6484.262 , 109.9001 , "Flying"));
Path.Add(new Vector3(-2798.633 , 6535.499 , 70.22829 , "Flying"));
Path.Add(new Vector3(-2748.624 , 6566.796 , 35.09798 , "Flying"));
Path.Add(new Vector3(-2729.393 , 6587.614 , 26.9918 , "None"));
Path.Add(new Vector3(-2751.715 , 6599.694 , 28.00241 , "None"));
Path.Add(new Vector3(-2762.493 , 6572.353 , 34.46637 , "None"));
Path.Add(new Vector3(-2742.919 , 6558.985 , 32.00382 , "None"));
Path.Add(new Vector3(-2712.168 , 6543.364 , 31.04719 , "None"));
Path.Add(new Vector3(-2691.627 , 6551.86 , 25.91991 , "None"));
Path.Add(new Vector3(-2682.631 , 6548.269 , 25.53607 , "None"));
Path.Add(new Vector3(-2653.502 , 6539.287 , 22.52459 , "None"));
Path.Add(new Vector3(-2649.339 , 6517.941 , 24.48351 , "None"));
Path.Add(new Vector3(-2629.534 , 6500.185 , 24.31776 , "None"));
Path.Add(new Vector3(-2627.472 , 6479.466 , 23.33711 , "None"));
Path.Add(new Vector3(-2627.656 , 6459.24 , 26.59921 , "None"));
Path.Add(new Vector3(-2618.219 , 6427.044 , 31.50748 , "None"));
Path.Add(new Vector3(-2609.819 , 6398.519 , 29.67595 , "None"));
Path.Add(new Vector3(-2609.512 , 6373.386 , 34.33783 , "None"));
Path.Add(new Vector3(-2610.002 , 6351.354 , 37.80266 , "None"));
Path.Add(new Vector3(-2604.39 , 6340.137 , 38.84087 , "None"));
Path.Add(new Vector3(-2615.693 , 6362.507 , 35.61605 , "None"));
Path.Add(new Vector3(-2605.844 , 6376.959 , 33.94975 , "None"));
Path.Add(new Vector3(-2599.911 , 6371.534 , 34.28331 , "None"));
Path.Add(new Vector3(-2593.62 , 6382.073 , 32.15315 , "None"));
Path.Add(new Vector3(-2586.018 , 6407.44 , 27.09825 , "None"));
Path.Add(new Vector3(-2581.543 , 6395.391 , 28.72387 , "None"));
Path.Add(new Vector3(-2587.212 , 6384.066 , 31.17253 , "None"));
Path.Add(new Vector3(-2594.023 , 6367.702 , 35.53978 , "None"));
Path.Add(new Vector3(-2566.937 , 6374.396 , 31.00087 , "None"));
Path.Add(new Vector3(-2536.328 , 6390.948 , 27.0191 , "None"));
Path.Add(new Vector3(-2523.069 , 6402.774 , 26.62754 , "None"));
Path.Add(new Vector3(-2540.457 , 6398.717 , 27.49249 , "None"));
Path.Add(new Vector3(-2571.119 , 6379.851 , 30.36258 , "None"));
Path.Add(new Vector3(-2601.292 , 6371.948 , 34.14246 , "None"));
Path.Add(new Vector3(-2617.25 , 6369.193 , 35.39023 , "None"));
Path.Add(new Vector3(-2608.738 , 6376.785 , 34.07619 , "None"));
Path.Add(new Vector3(-2608.646 , 6409.203 , 29.12806 , "None"));
Path.Add(new Vector3(-2601.375 , 6443.59 , 25.84688 , "None"));
Path.Add(new Vector3(-2617.199 , 6461.53 , 25.44231 , "None"));
Path.Add(new Vector3(-2620.367 , 6469.611 , 23.54415 , "None"));
Path.Add(new Vector3(-2616.501 , 6498.722 , 22.61042 , "None"));
Path.Add(new Vector3(-2618.673 , 6531.967 , 19.71927 , "None"));
Path.Add(new Vector3(-2620.769 , 6539.594 , 18.37804 , "None"));
Path.Add(new Vector3(-2609.64 , 6568.574 , 15.5902 , "None"));
Path.Add(new Vector3(-2632.475 , 6593.127 , 16.34734 , "None"));
Path.Add(new Vector3(-2645.031 , 6616.654 , 10.9222 , "None"));
Path.Add(new Vector3(-2651.462 , 6635.324 , 8.70978 , "None"));
Path.Add(new Vector3(-2658.944 , 6656.856 , 3.083069 , "None"));
Path.Add(new Vector3(-2648.489 , 6680.501 , 0.8130993 , "None"));
Path.Add(new Vector3(-2648.232 , 6715.366 , -2.375961 , "None"));
Path.Add(new Vector3(-2645.676 , 6747.718 , -2.202404 , "None"));
Path.Add(new Vector3(-2643.74 , 6784.313 , -2.250644 , "None"));
Path.Add(new Vector3(-2648.169 , 6819.736 , 1.110273 , "None"));
Path.Add(new Vector3(-2653.063 , 6856.371 , -1.833395 , "None"));
Path.Add(new Vector3(-2657.462 , 6883.365 , -3.305657 , "None"));
Path.Add(new Vector3(-2659.871 , 6897.156 , -4.588375 , "None"));
Path.Add(new Vector3(-2662.817 , 6914.02 , -3.192975 , "None"));
Path.Add(new Vector3(-2647.915 , 6913.11 , -2.190588 , "None"));
Path.Add(new Vector3(-2634.57 , 6896.935 , -1.440115 , "None"));
Path.Add(new Vector3(-2631.941 , 6881.215 , 1.123095 , "None"));
Path.Add(new Vector3(-2634.63 , 6859.414 , 2.695564 , "None"));
Path.Add(new Vector3(-2612.956 , 6884.202 , 7.294955 , "None"));
Path.Add(new Vector3(-2580.296 , 6875.917 , 24.5182 , "None"));
Path.Add(new Vector3(-2564.448 , 6850.319 , 24.78677 , "None"));
Path.Add(new Vector3(-2584.233 , 6824.043 , 34.06314 , "None"));
Path.Add(new Vector3(-2599.482 , 6795.833 , 25.56819 , "None"));
Path.Add(new Vector3(-2624.797 , 6771.867 , 22.39755 , "None"));
Path.Add(new Vector3(-2651.229 , 6746.841 , 15.07465 , "None"));
Path.Add(new Vector3(-2677.154 , 6722.297 , 2.825764 , "None"));
Path.Add(new Vector3(-2689.478 , 6695.245 , -2.803992 , "None"));
Path.Add(new Vector3(-2715.446 , 6676.248 , 7.010216 , "None"));
Path.Add(new Vector3(-2734.361 , 6689.328 , 10.49785 , "None"));
Path.Add(new Vector3(-2765.047 , 6684.378 , 17.38427 , "None"));
Path.Add(new Vector3(-2775.776 , 6702.516 , 17.93521 , "None"));
Path.Add(new Vector3(-2776.41 , 6733.045 , 13.36614 , "None"));
Path.Add(new Vector3(-2777.01 , 6761.961 , 4.393381 , "None"));
Path.Add(new Vector3(-2787.081 , 6779.035 , -6.108962 , "None"));
Path.Add(new Vector3(-2806.701 , 6751.497 , 2.415585 , "None"));
Path.Add(new Vector3(-2799.659 , 6719.991 , 11.76944 , "None"));
Path.Add(new Vector3(-2804.794 , 6685.078 , 18.76185 , "None"));
Path.Add(new Vector3(-2813.92 , 6651.352 , 24.0846 , "None"));
Path.Add(new Vector3(-2813.347 , 6617.295 , 28.91241 , "None"));
Path.Add(new Vector3(-2813.722 , 6582.667 , 36.67504 , "None"));
Path.Add(new Vector3(-2800.283 , 6563.268 , 37.67126 , "None"));
Path.Add(new Vector3(-2779.153 , 6554.349 , 36.37588 , "None"));
Path.Add(new Vector3(-2760.912 , 6537.254 , 35.6987 , "None"));
Path.Add(new Vector3(-2731.1 , 6518.875 , 32.77227 , "None"));
Path.Add(new Vector3(-2702.071 , 6520.208 , 33.62947 , "None"));
Path.Add(new Vector3(-2666.552 , 6524.775 , 27.0911 , "None"));
Path.Add(new Vector3(-2633.498 , 6514.705 , 22.7702 , "None"));
Path.Add(new Vector3(-2607.473 , 6493.897 , 20.12117 , "None"));
Path.Add(new Vector3(-2581.051 , 6473.401 , 21.89199 , "None"));
Path.Add(new Vector3(-2559.597 , 6446.875 , 22.9103 , "None"));
Path.Add(new Vector3(-2549.078 , 6416.292 , 25.36461 , "None"));
Path.Add(new Vector3(-2551.441 , 6379.699 , 27.79029 , "None"));
Path.Add(new Vector3(-2566.652 , 6348.983 , 35.65974 , "None"));
Path.Add(new Vector3(-2568.225 , 6346.014 , 56.19261 , "Flying"));
Path.Add(new Vector3(-2579.738 , 6329.805 , 75.59897 , "Flying"));
Path.Add(new Vector3(-2593.36 , 6311.909 , 73.16353 , "Flying"));
Path.Add(new Vector3(-2635.979 , 6252.588 , 74.09913 , "Flying"));
Path.Add(new Vector3(-2688.565 , 6197.2 , 58.06289 , "Flying"));
Path.Add(new Vector3(-2675.722 , 6211.868 , 46.39069 , "Flying"));
Path.Add(new Vector3(-2627.013 , 6255.026 , 52.23682 , "Flying"));
Path.Add(new Vector3(-2614.744 , 6317.638 , 52.27638 , "Flying"));
Path.Add(new Vector3(-2591.481 , 6387.403 , 31.73444 , "Flying"));
Path.Add(new Vector3(-2586.598 , 6415.391 , 26.96807 , "None"));
Path.Add(new Vector3(-2589.005 , 6424.513 , 27.16108 , "None"));
Path.Add(new Vector3(-2597.061 , 6445.128 , 24.88839 , "None"));
Path.Add(new Vector3(-2597.469 , 6457.162 , 22.85831 , "None"));
Path.Add(new Vector3(-2598.951 , 6467.626 , 21.78656 , "None"));
Path.Add(new Vector3(-2594.487 , 6493.649 , 18.30966 , "None"));
Path.Add(new Vector3(-2595.822 , 6508.014 , 17.67677 , "None"));
Path.Add(new Vector3(-2592.932 , 6525.23 , 15.07848 , "None"));
Path.Add(new Vector3(-2568.017 , 6545.147 , 12.1363 , "None"));
Path.Add(new Vector3(-2571.363 , 6523.358 , 15.50686 , "None"));
Path.Add(new Vector3(-2582.107 , 6504.301 , 16.84001 , "None"));
Path.Add(new Vector3(-2562.736 , 6481.878 , 18.39932 , "None"));
Path.Add(new Vector3(-2527.29 , 6472.013 , 18.38334 , "None"));
Path.Add(new Vector3(-2492.827 , 6464.143 , 22.08134 , "None"));
Path.Add(new Vector3(-2465.905 , 6441.549 , 22.9335 , "None"));
Path.Add(new Vector3(-2454.811 , 6435.328 , 21.48597 , "None"));
Path.Add(new Vector3(-2453.096 , 6447.661 , 19.20409 , "None"));
Path.Add(new Vector3(-2429.049 , 6458.701 , 13.26014 , "None"));
Path.Add(new Vector3(-2411.051 , 6442.635 , 13.60277 , "None"));
Path.Add(new Vector3(-2428.387 , 6466.579 , 13.43347 , "None"));
Path.Add(new Vector3(-2423.478 , 6474.654 , 13.40247 , "None"));
Path.Add(new Vector3(-2396.241 , 6469.903 , 17.81281 , "None"));
Path.Add(new Vector3(-2385.64 , 6488.428 , 24.17956 , "None"));
Path.Add(new Vector3(-2408.056 , 6467.645 , 16.15577 , "None"));
Path.Add(new Vector3(-2431.335 , 6440.925 , 13.20436 , "None"));
Path.Add(new Vector3(-2460.919 , 6420.329 , 23.54485 , "None"));
Path.Add(new Vector3(-2490.176 , 6401.255 , 28.5437 , "None"));
Path.Add(new Vector3(-2515.924 , 6378.255 , 29.93004 , "None"));
Path.Add(new Vector3(-2541.354 , 6361.376 , 32.60002 , "None"));
Path.Add(new Vector3(-2549.712 , 6345.189 , 33.73987 , "None"));
Path.Add(new Vector3(-2570.288 , 6368.985 , 34.58578 , "None"));
Path.Add(new Vector3(-2606.795 , 6366.801 , 35.40107 , "None"));
Path.Add(new Vector3(-2634.25 , 6363.829 , 33.92262 , "None"));
Path.Add(new Vector3(-2654.912 , 6341.907 , 37.89407 , "None"));
Path.Add(new Vector3(-2662.58 , 6309.177 , 37.59945 , "None"));
Path.Add(new Vector3(-2671.354 , 6300.409 , 34.42269 , "None"));
Path.Add(new Vector3(-2686.447 , 6283.786 , 31.59746 , "None"));
Path.Add(new Vector3(-2690.948 , 6249.892 , 26.21045 , "None"));
Path.Add(new Vector3(-2712.831 , 6219.814 , 21.05001 , "None"));
Path.Add(new Vector3(-2731.346 , 6200.039 , 20.61621 , "Flying"));
Path.Add(new Vector3(-2758.625 , 6171.482 , 43.07421 , "Flying"));
Path.Add(new Vector3(-2818.033 , 6123.081 , 40.84764 , "Flying"));
Path.Add(new Vector3(-2885.95 , 6096.639 , 39.36332 , "Flying"));
Path.Add(new Vector3(-2951.853 , 6066.248 , 37.88511 , "Flying"));
Path.Add(new Vector3(-3011.614 , 6020.14 , 33.84608 , "Flying"));
Path.Add(new Vector3(-3045.154 , 5963.804 , 26.36136 , "Flying"));
Path.Add(new Vector3(-3084.904 , 5899.595 , 12.60012 , "Flying"));
Path.Add(new Vector3(-3084.4 , 5881.625 , 8.378398 , "None"));
Path.Add(new Vector3(-3076.477 , 5854.842 , 25.35326 , "Flying"));
Path.Add(new Vector3(-3065.808 , 5793.4 , 12.86385 , "Flying"));
Path.Add(new Vector3(-3054.012 , 5727.932 , 16.68368 , "Flying"));
Path.Add(new Vector3(-3048.555 , 5669.497 , -0.4235254 , "Flying"));
Path.Add(new Vector3(-3048.356 , 5658.209 , -2.278545 , "None"));
Path.Add(new Vector3(-3055.328 , 5666.157 , -0.7978719 , "None"));
Path.Add(new Vector3(-3071.208 , 5675.579 , -0.6196021 , "None"));
Path.Add(new Vector3(-3095.406 , 5670.137 , -0.6585162 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class VeilRhazeUnlivingEvil : QuestGrinderClass
{
    public VeilRhazeUnlivingEvil()
    {
        Name = "Veil Rhaze: Unliving Evil";

        QuestId.AddRange(new[] { 10848 });

        Step = new List<int> { 4, 4, 2, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10839;

        EntryTarget.Add(21324);
EntryTarget.Add(21198);
EntryTarget.Add(21200);
HotSpots.Add(new Vector3(-2771.042 , 5468.191 , 3.914644 , "None"));
HotSpots.Add(new Vector3(-2915.36 , 5591.831 , 0.05128571 , "None"));
HotSpots.Add(new Vector3(-2986.126 , 5619.782 , -0.01036429 , "None"));
HotSpots.Add(new Vector3(-3042.82 , 5613.419 , -5.183662 , "None"));
HotSpots.Add(new Vector3(-3096.635 , 5616.983 , -7.164238 , "None"));
HotSpots.Add(new Vector3(-3140.076 , 5650.506 , -0.9848328 , "None"));
HotSpots.Add(new Vector3(-3132.402 , 5697.522 , 0.2821782 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class VeilLithicPreemptiveStrike : QuestGrinderClass
{
    public VeilLithicPreemptiveStrike()
    {
        Name = "Veil Lithic: Preemptive Strike";

        QuestId.AddRange(new[] { 10861 });

        Step = new List<int> { 3, 3, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10848;

        EntryTarget.Add(22337);
EntryTarget.Add(22388);
EntryTarget.Add(22387);
HotSpots.Add(new Vector3(-3637.554 , 5668.451 , 1.649308 , "None"));
HotSpots.Add(new Vector3(-3654.505 , 5744.022 , -1.984071 , "None"));
HotSpots.Add(new Vector3(-3630.563 , 5794.533 , -0.6236167 , "None"));
HotSpots.Add(new Vector3(-3573.084 , 5776.165 , -2.601745 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class VeilLithicPreemptiveStrikeGETEGGSforReeemedBirds : QuestGathererClass
{
    public VeilLithicPreemptiveStrikeGETEGGSforReeemedBirds()
    {
        Name = "Veil Lithic: Preemptive Strike - GET EGGS for Reeemed Birds";

        QuestId.AddRange(new[] { 10861 });

        Step = new List<int> { 3, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(185211);
EntryIdObjects.Add(185210);
EntryIdObjects.Add(181800);
HotSpots.Add(new Vector3(-3639.499 , 5831.161 , 0.0704515 , "None"));
HotSpots.Add(new Vector3(-3568.458 , 5772.294 , -3.049527 , "None"));
HotSpots.Add(new Vector3(-3560.13 , 5771.708 , -3.180722 , "None"));
HotSpots.Add(new Vector3(-3679.069 , 5734.386 , -1.035047 , "None"));
HotSpots.Add(new Vector3(-3660.548 , 5811.047 , 0.0245314 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PATHVeilLithicPreamptiveStrike : QuestFollowPathClass
{
    public PATHVeilLithicPreamptiveStrike()
    {
        Name = "PATH: Veil Lithic Preamptive Strike";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3643.923 , 5530.156 , -6.789549 , "None"));
Path.Add(new Vector3(-3646.647 , 5553.645 , -2.450992 , "None"));
Path.Add(new Vector3(-3652.515 , 5586.728 , -0.8490182 , "None"));
Path.Add(new Vector3(-3650.782 , 5604.746 , 2.907605 , "None"));
Path.Add(new Vector3(-3645.822 , 5632.307 , 3.378039 , "None"));
Path.Add(new Vector3(-3642.421 , 5654.049 , 2.312957 , "None"));
Path.Add(new Vector3(-3644.783 , 5669.053 , 0.9137223 , "None"));
Path.Add(new Vector3(-3649.805 , 5679.939 , -0.331525 , "None"));
Path.Add(new Vector3(-3658.415 , 5689.701 , -1.528523 , "None"));
Path.Add(new Vector3(-3663.01 , 5698.007 , -2.004345 , "None"));
Path.Add(new Vector3(-3660.79 , 5712.476 , -2.616657 , "None"));
Path.Add(new Vector3(-3656.94 , 5719.413 , -2.292509 , "None"));
Path.Add(new Vector3(-3659.933 , 5725.196 , -2.393209 , "None"));
Path.Add(new Vector3(-3665.697 , 5728.881 , -1.808936 , "None"));
Path.Add(new Vector3(-3672.493 , 5734.009 , -1.305182 , "None"));
Path.Add(new Vector3(-3676.496 , 5736.145 , -1.277459 , "None"));
Path.Add(new Vector3(-3685.766 , 5745.227 , -3.354239 , "None"));
Path.Add(new Vector3(-3689.366 , 5748.813 , -4.524032 , "None"));
Path.Add(new Vector3(-3696.344 , 5755.971 , -4.21958 , "None"));
Path.Add(new Vector3(-3693.574 , 5758.223 , -4.301706 , "None"));
Path.Add(new Vector3(-3689.725 , 5759.593 , -4.4356 , "None"));
Path.Add(new Vector3(-3679.709 , 5759.695 , -4.91604 , "None"));
Path.Add(new Vector3(-3673.262 , 5759.761 , -4.840414 , "None"));
Path.Add(new Vector3(-3667.366 , 5763.638 , -4.008222 , "None"));
Path.Add(new Vector3(-3661.83 , 5772.58 , -2.580519 , "None"));
Path.Add(new Vector3(-3659.101 , 5782.893 , -1.816076 , "None"));
Path.Add(new Vector3(-3658.299 , 5791.233 , -1.221072 , "None"));
Path.Add(new Vector3(-3654.79 , 5797.072 , -0.9058021 , "None"));
Path.Add(new Vector3(-3652.548 , 5799.928 , -1.006407 , "None"));
Path.Add(new Vector3(-3646.828 , 5809.103 , -0.2256075 , "None"));
Path.Add(new Vector3(-3644.875 , 5813.13 , 0.07831805 , "None"));
Path.Add(new Vector3(-3639.785 , 5818.32 , 0.05129674 , "None"));
Path.Add(new Vector3(-3637.239 , 5822.523 , -0.03596295 , "None"));
Path.Add(new Vector3(-3634.643 , 5826.156 , -0.169419 , "None"));
Path.Add(new Vector3(-3631.715 , 5829.389 , -0.1341004 , "None"));
Path.Add(new Vector3(-3630.116 , 5826.105 , -0.9553681 , "None"));
Path.Add(new Vector3(-3627.059 , 5818.985 , -2.382321 , "None"));
Path.Add(new Vector3(-3619.73 , 5816.97 , -4.128028 , "None"));
Path.Add(new Vector3(-3614.355 , 5818.83 , -4.843557 , "None"));
Path.Add(new Vector3(-3608.929 , 5823.107 , -4.894948 , "None"));
Path.Add(new Vector3(-3604.196 , 5826.838 , -4.817761 , "None"));
Path.Add(new Vector3(-3600.585 , 5824.84 , -4.485837 , "None"));
Path.Add(new Vector3(-3601.134 , 5817.724 , -4.738377 , "None"));
Path.Add(new Vector3(-3599.032 , 5812.707 , -3.773649 , "None"));
Path.Add(new Vector3(-3597.295 , 5808.676 , -3.440394 , "None"));
Path.Add(new Vector3(-3591.822 , 5803.803 , -4.291946 , "None"));
Path.Add(new Vector3(-3598.687 , 5803.635 , -3.224524 , "None"));
Path.Add(new Vector3(-3593.202 , 5803.333 , -4.353276 , "None"));
Path.Add(new Vector3(-3587.39 , 5802.342 , -4.151306 , "None"));
Path.Add(new Vector3(-3581.5 , 5794.311 , -4.553421 , "None"));
Path.Add(new Vector3(-3580.443 , 5785.461 , -3.395607 , "None"));
Path.Add(new Vector3(-3584.348 , 5776.906 , -4.301758 , "None"));
Path.Add(new Vector3(-3587.79 , 5773.677 , -4.791439 , "None"));
Path.Add(new Vector3(-3590.385 , 5765.732 , -4.415274 , "None"));
Path.Add(new Vector3(-3591.351 , 5761.043 , -4.181937 , "None"));
Path.Add(new Vector3(-3596.048 , 5758.118 , -2.867668 , "None"));
Path.Add(new Vector3(-3599.715 , 5756.656 , -1.422982 , "None"));
Path.Add(new Vector3(-3605.054 , 5754.942 , 0.503022 , "None"));
Path.Add(new Vector3(-3615.919 , 5753.42 , 1.655312 , "None"));
Path.Add(new Vector3(-3619.898 , 5751.295 , 1.671388 , "None"));
Path.Add(new Vector3(-3622.078 , 5748.468 , 1.584641 , "None"));
Path.Add(new Vector3(-3628.773 , 5745.832 , 1.221231 , "None"));
Path.Add(new Vector3(-3634.365 , 5742.884 , 0.1664149 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class VeilShalasSignalFires : QuestGathererClass
{
    public VeilShalasSignalFires()
    {
        Name = "Veil Shalas: Signal Fires";

        QuestId.AddRange(new[] { 10874 });

        Step = new List<int> { 1, 1, 1, 1, 0 };

        StepAutoDetect = new[] { true, true, true, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10861;

        EntryIdObjects.Add(185219);
EntryIdObjects.Add(181800);
HotSpots.Add(new Vector3(-3608.52 , 4049.221 , 112.427 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class VeilShalasSignalFiresSAPHIRE : QuestGathererClass
{
    public VeilShalasSignalFiresSAPHIRE()
    {
        Name = "Veil Shalas: Signal Fires - SAPHIRE";

        QuestId.AddRange(new[] { 10874 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10861;

        EntryIdObjects.Add(185216);
EntryIdObjects.Add(181800);
HotSpots.Add(new Vector3(-3421.458 , 4102.701 , 62.68126 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class VeilShalasSignalFiresEmerald : QuestGathererClass
{
    public VeilShalasSignalFiresEmerald()
    {
        Name = "Veil Shalas: Signal Fires - Emerald";

        QuestId.AddRange(new[] { 10874 });

        Step = new List<int> { 0, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10861;

        EntryIdObjects.Add(185217);
EntryIdObjects.Add(181800);
HotSpots.Add(new Vector3(-3513.002 , 4085.563 , 92.88654 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class VeilShalasSignalFiresViolet : QuestGathererClass
{
    public VeilShalasSignalFiresViolet()
    {
        Name = "Veil Shalas: Signal Fires - Violet";

        QuestId.AddRange(new[] { 10874 });

        Step = new List<int> { 0, 0, 1, 0, 0 };

        StepAutoDetect = new[] { false, false, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10861;

        EntryIdObjects.Add(185218);
EntryIdObjects.Add(181800);
HotSpots.Add(new Vector3(-3493.552 , 4024.918 , 113.1133 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNSaphireFire : QuestFollowPathClass
{
    public RUNSaphireFire()
    {
        Name = "RUN: Saphire Fire";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3490.984 , 4039.857 , 59.21191 , "None"));
Path.Add(new Vector3(-3487.784 , 4037.426 , 59.55333 , "None"));
Path.Add(new Vector3(-3481.691 , 4034.152 , 59.75139 , "None"));
Path.Add(new Vector3(-3471.293 , 4030.375 , 59.49654 , "None"));
Path.Add(new Vector3(-3460.935 , 4026.786 , 59.47606 , "None"));
Path.Add(new Vector3(-3450.832 , 4023.234 , 59.78962 , "None"));
Path.Add(new Vector3(-3440.967 , 4019.2 , 60.9888 , "None"));
Path.Add(new Vector3(-3432.556 , 4013.781 , 61.88854 , "None"));
Path.Add(new Vector3(-3427.371 , 4010.277 , 62.36269 , "None"));
Path.Add(new Vector3(-3421.115 , 4008.958 , 61.93301 , "None"));
Path.Add(new Vector3(-3410.795 , 4009.165 , 60.51735 , "None"));
Path.Add(new Vector3(-3399.709 , 4008.989 , 59.64218 , "None"));
Path.Add(new Vector3(-3389.054 , 4007.603 , 58.5694 , "None"));
Path.Add(new Vector3(-3378.854 , 4005.498 , 57.85661 , "None"));
Path.Add(new Vector3(-3368.476 , 4003.122 , 58.17225 , "None"));
Path.Add(new Vector3(-3357.873 , 4001.46 , 59.22839 , "None"));
Path.Add(new Vector3(-3347.794 , 3999.456 , 60.85385 , "None"));
Path.Add(new Vector3(-3337.768 , 3995.675 , 66.76179 , "None"));
Path.Add(new Vector3(-3331.91 , 3990.032 , 71.63184 , "None"));
Path.Add(new Vector3(-3334.752 , 3989.751 , 70.09093 , "None"));
Path.Add(new Vector3(-3338.838 , 3990.628 , 67.93614 , "None"));
Path.Add(new Vector3(-3349.393 , 3992.888 , 70.50384 , "None"));
Path.Add(new Vector3(-3359.387 , 3995.246 , 77.37768 , "None"));
Path.Add(new Vector3(-3368.288 , 3997.646 , 84.88482 , "None"));
Path.Add(new Vector3(-3370.986 , 3998.445 , 85.17753 , "None"));
Path.Add(new Vector3(-3373.636 , 3999.101 , 85.90488 , "None"));
Path.Add(new Vector3(-3381.955 , 4003.069 , 86.90997 , "None"));
Path.Add(new Vector3(-3391.139 , 4007.431 , 88.02008 , "None"));
Path.Add(new Vector3(-3401.166 , 4012.224 , 87.07035 , "None"));
Path.Add(new Vector3(-3404.594 , 4017.237 , 86.68695 , "None"));
Path.Add(new Vector3(-3407.796 , 4027.976 , 79.64715 , "None"));
Path.Add(new Vector3(-3411.355 , 4038.121 , 75.2123 , "None"));
Path.Add(new Vector3(-3414.703 , 4047.451 , 72.62122 , "None"));
Path.Add(new Vector3(-3418.537 , 4058.232 , 71.62697 , "None"));
Path.Add(new Vector3(-3422.027 , 4068.113 , 73.39323 , "None"));
Path.Add(new Vector3(-3425.49 , 4072.083 , 73.84383 , "None"));
Path.Add(new Vector3(-3435.776 , 4075.347 , 74.26595 , "None"));
Path.Add(new Vector3(-3444.71 , 4079.968 , 73.67645 , "None"));
Path.Add(new Vector3(-3454.222 , 4085.497 , 72.67039 , "None"));
Path.Add(new Vector3(-3458.926 , 4086.623 , 72.40866 , "None"));
Path.Add(new Vector3(-3460.977 , 4084.82 , 72.20643 , "None"));
Path.Add(new Vector3(-3458.309 , 4081.656 , 72.19048 , "None"));
Path.Add(new Vector3(-3451.569 , 4073.862 , 67.96712 , "None"));
Path.Add(new Vector3(-3442.273 , 4068.854 , 62.8147 , "None"));
Path.Add(new Vector3(-3437.259 , 4069.316 , 62.39742 , "None"));
Path.Add(new Vector3(-3436.717 , 4072.098 , 62.46402 , "None"));
Path.Add(new Vector3(-3438.904 , 4073.869 , 62.4091 , "None"));
Path.Add(new Vector3(-3442.406 , 4076.753 , 62.44479 , "None"));
Path.Add(new Vector3(-3450.307 , 4083.464 , 62.60997 , "None"));
Path.Add(new Vector3(-3450.922 , 4088.114 , 62.7247 , "None"));
Path.Add(new Vector3(-3450.178 , 4092.227 , 62.86574 , "None"));
Path.Add(new Vector3(-3447.951 , 4097.78 , 62.58018 , "None"));
Path.Add(new Vector3(-3442.936 , 4104.44 , 62.48381 , "None"));
Path.Add(new Vector3(-3436.912 , 4105.875 , 62.73253 , "None"));
Path.Add(new Vector3(-3430.445 , 4105.384 , 62.74531 , "None"));
Path.Add(new Vector3(-3426.571 , 4105.213 , 62.70219 , "None"));
Path.Add(new Vector3(-3423.725 , 4104.806 , 62.68731 , "None"));
Path.Add(new Vector3(-3421.807 , 4102.36 , 62.68912 , "None"));
Path.Add(new Vector3(-3420.226 , 4100.345 , 62.59417 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNEmeraldFire : QuestFollowPathClass
{
    public RUNEmeraldFire()
    {
        Name = "RUN: Emerald Fire";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3421.458 , 4102.701 , 62.68126 , "None"));
Path.Add(new Vector3(-3425.352 , 4104.537 , 62.70315 , "None"));
Path.Add(new Vector3(-3428.353 , 4105.519 , 62.71349 , "None"));
Path.Add(new Vector3(-3430.955 , 4105.038 , 62.75676 , "None"));
Path.Add(new Vector3(-3436.895 , 4104.303 , 62.75566 , "None"));
Path.Add(new Vector3(-3440.61 , 4103.115 , 62.64634 , "None"));
Path.Add(new Vector3(-3445.191 , 4100.964 , 62.34864 , "None"));
Path.Add(new Vector3(-3448.395 , 4092.38 , 62.85854 , "None"));
Path.Add(new Vector3(-3447.764 , 4087.21 , 62.8376 , "None"));
Path.Add(new Vector3(-3447.166 , 4083.074 , 62.70066 , "None"));
Path.Add(new Vector3(-3444.62 , 4079.577 , 62.54904 , "None"));
Path.Add(new Vector3(-3442.037 , 4075.677 , 62.41627 , "None"));
Path.Add(new Vector3(-3439.036 , 4070.477 , 62.34081 , "None"));
Path.Add(new Vector3(-3439.623 , 4067.673 , 62.32082 , "None"));
Path.Add(new Vector3(-3443.124 , 4067.493 , 62.97138 , "None"));
Path.Add(new Vector3(-3446.694 , 4068.667 , 64.74345 , "None"));
Path.Add(new Vector3(-3454.256 , 4074.095 , 68.78854 , "None"));
Path.Add(new Vector3(-3456.598 , 4077.6 , 70.68452 , "None"));
Path.Add(new Vector3(-3458.654 , 4082.118 , 72.25536 , "None"));
Path.Add(new Vector3(-3458.479 , 4084.928 , 72.40047 , "None"));
Path.Add(new Vector3(-3456.483 , 4087.421 , 72.60404 , "None"));
Path.Add(new Vector3(-3453.725 , 4087.148 , 72.76604 , "None"));
Path.Add(new Vector3(-3446.042 , 4081.567 , 73.67358 , "None"));
Path.Add(new Vector3(-3436.286 , 4076.029 , 74.49609 , "None"));
Path.Add(new Vector3(-3426.266 , 4072.194 , 73.84098 , "None"));
Path.Add(new Vector3(-3422.842 , 4070.755 , 73.84863 , "None"));
Path.Add(new Vector3(-3421.817 , 4068.361 , 73.43234 , "None"));
Path.Add(new Vector3(-3418.039 , 4059.084 , 71.65172 , "None"));
Path.Add(new Vector3(-3414.149 , 4048.524 , 72.46563 , "None"));
Path.Add(new Vector3(-3410.775 , 4038.338 , 75.20523 , "None"));
Path.Add(new Vector3(-3407.616 , 4028.787 , 79.2851 , "None"));
Path.Add(new Vector3(-3404.119 , 4018.732 , 85.75504 , "None"));
Path.Add(new Vector3(-3401.193 , 4012.972 , 87.074 , "None"));
Path.Add(new Vector3(-3397.288 , 4010.858 , 87.06784 , "None"));
Path.Add(new Vector3(-3387.562 , 4006.214 , 88.00726 , "None"));
Path.Add(new Vector3(-3378.821 , 4000.746 , 86.61112 , "None"));
Path.Add(new Vector3(-3374.411 , 3998.839 , 86.01982 , "None"));
Path.Add(new Vector3(-3365.838 , 3997.06 , 82.83589 , "None"));
Path.Add(new Vector3(-3355.867 , 3995.086 , 74.82802 , "None"));
Path.Add(new Vector3(-3345.312 , 3992.463 , 68.28098 , "None"));
Path.Add(new Vector3(-3338.626 , 3991.722 , 67.74171 , "None"));
Path.Add(new Vector3(-3333.706 , 3993.889 , 69.67558 , "None"));
Path.Add(new Vector3(-3338.134 , 3995.28 , 66.69077 , "None"));
Path.Add(new Vector3(-3345.99 , 3995.724 , 62.03778 , "None"));
Path.Add(new Vector3(-3351.183 , 3996.335 , 60.77046 , "None"));
Path.Add(new Vector3(-3353.924 , 3997.209 , 59.82652 , "None"));
Path.Add(new Vector3(-3359.368 , 3998.698 , 59.20029 , "None"));
Path.Add(new Vector3(-3370.12 , 4001.32 , 57.80516 , "None"));
Path.Add(new Vector3(-3380.31 , 4003.854 , 57.52484 , "None"));
Path.Add(new Vector3(-3390.809 , 4006.695 , 58.63832 , "None"));
Path.Add(new Vector3(-3400.654 , 4009.236 , 59.67979 , "None"));
Path.Add(new Vector3(-3411.031 , 4010.764 , 60.61059 , "None"));
Path.Add(new Vector3(-3421.739 , 4012.402 , 62.31374 , "None"));
Path.Add(new Vector3(-3431.778 , 4015.503 , 61.88352 , "None"));
Path.Add(new Vector3(-3441.76 , 4019.603 , 60.92161 , "None"));
Path.Add(new Vector3(-3451.167 , 4023.669 , 59.68715 , "None"));
Path.Add(new Vector3(-3461.128 , 4027.989 , 59.26742 , "None"));
Path.Add(new Vector3(-3471.286 , 4032.488 , 59.41291 , "None"));
Path.Add(new Vector3(-3480.568 , 4037.201 , 59.36533 , "None"));
Path.Add(new Vector3(-3489.212 , 4042.529 , 57.7346 , "None"));
Path.Add(new Vector3(-3498.846 , 4048.266 , 59.21322 , "None"));
Path.Add(new Vector3(-3508.756 , 4052.434 , 61.07064 , "None"));
Path.Add(new Vector3(-3512.775 , 4053.368 , 61.41955 , "None"));
Path.Add(new Vector3(-3532.212 , 4038.345 , 65.21096 , "None"));
Path.Add(new Vector3(-3534.28 , 4036.594 , 66.26289 , "None"));
Path.Add(new Vector3(-3538.139 , 4031.985 , 68.71906 , "None"));
Path.Add(new Vector3(-3542.424 , 4024.324 , 71.22757 , "None"));
Path.Add(new Vector3(-3547.801 , 4015.037 , 70.69922 , "None"));
Path.Add(new Vector3(-3554.092 , 4007.192 , 69.77934 , "None"));
Path.Add(new Vector3(-3559.299 , 4004.29 , 70.41909 , "None"));
Path.Add(new Vector3(-3566.529 , 3999.54 , 71.76544 , "None"));
Path.Add(new Vector3(-3575.686 , 3994.404 , 75.10825 , "None"));
Path.Add(new Vector3(-3580.71 , 3992.922 , 75.86448 , "None"));
Path.Add(new Vector3(-3584.045 , 3993.869 , 75.97869 , "None"));
Path.Add(new Vector3(-3586.912 , 3996.362 , 76.19103 , "None"));
Path.Add(new Vector3(-3588.88 , 3998.927 , 76.22594 , "None"));
Path.Add(new Vector3(-3593.308 , 4005.258 , 75.83257 , "None"));
Path.Add(new Vector3(-3597.938 , 4013.61 , 74.20235 , "None"));
Path.Add(new Vector3(-3593.5 , 4011.31 , 74.63862 , "None"));
Path.Add(new Vector3(-3584.173 , 4006.912 , 74.7459 , "None"));
Path.Add(new Vector3(-3573.435 , 4003.458 , 82.43303 , "None"));
Path.Add(new Vector3(-3563.364 , 4001.572 , 91.78225 , "None"));
Path.Add(new Vector3(-3558.529 , 4001.276 , 92.93377 , "None"));
Path.Add(new Vector3(-3553.619 , 4005.315 , 92.84651 , "None"));
Path.Add(new Vector3(-3546.635 , 4007.72 , 92.83405 , "None"));
Path.Add(new Vector3(-3536.142 , 4009.949 , 92.24274 , "None"));
Path.Add(new Vector3(-3532.628 , 4010.779 , 92.05333 , "None"));
Path.Add(new Vector3(-3532.313 , 4013.427 , 91.34191 , "None"));
Path.Add(new Vector3(-3530.357 , 4023.702 , 86.76902 , "None"));
Path.Add(new Vector3(-3528.051 , 4033.919 , 85.69162 , "None"));
Path.Add(new Vector3(-3526.166 , 4044.931 , 87.64053 , "None"));
Path.Add(new Vector3(-3524.516 , 4055.299 , 92.81524 , "None"));
Path.Add(new Vector3(-3523.263 , 4059.162 , 92.93096 , "None"));
Path.Add(new Vector3(-3529.04 , 4067.111 , 93.02269 , "None"));
Path.Add(new Vector3(-3531.078 , 4070.599 , 92.88178 , "None"));
Path.Add(new Vector3(-3531.958 , 4074.691 , 92.88649 , "None"));
Path.Add(new Vector3(-3529.439 , 4077.621 , 93.1551 , "None"));
Path.Add(new Vector3(-3527.646 , 4079.708 , 93.41965 , "None"));
Path.Add(new Vector3(-3525.041 , 4082.078 , 93.44726 , "None"));
Path.Add(new Vector3(-3522.096 , 4083.916 , 93.19398 , "None"));
Path.Add(new Vector3(-3517.836 , 4084.429 , 93.11142 , "None"));
Path.Add(new Vector3(-3514.039 , 4084.269 , 92.92931 , "None"));
Path.Add(new Vector3(-3510.845 , 4081.866 , 93.00768 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNVioletFire : QuestFollowPathClass
{
    public RUNVioletFire()
    {
        Name = "RUN: Violet Fire";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3513.045 , 4084.977 , 92.91233 , "None"));
Path.Add(new Vector3(-3517.69 , 4084.385 , 93.14084 , "None"));
Path.Add(new Vector3(-3522.182 , 4082.498 , 93.61844 , "None"));
Path.Add(new Vector3(-3525.866 , 4080.499 , 93.58866 , "None"));
Path.Add(new Vector3(-3528.449 , 4077.144 , 93.57034 , "None"));
Path.Add(new Vector3(-3530.506 , 4072.451 , 93.16074 , "None"));
Path.Add(new Vector3(-3529.032 , 4067.745 , 93.24828 , "None"));
Path.Add(new Vector3(-3525.222 , 4063.22 , 93.04944 , "None"));
Path.Add(new Vector3(-3521.671 , 4060.134 , 92.92491 , "None"));
Path.Add(new Vector3(-3522.229 , 4055.896 , 92.90177 , "None"));
Path.Add(new Vector3(-3523.365 , 4053.184 , 91.81975 , "None"));
Path.Add(new Vector3(-3526.039 , 4043.793 , 87.29353 , "None"));
Path.Add(new Vector3(-3528.773 , 4033.504 , 85.69156 , "None"));
Path.Add(new Vector3(-3531.354 , 4023.045 , 87.0195 , "None"));
Path.Add(new Vector3(-3534.067 , 4012.643 , 91.88099 , "None"));
Path.Add(new Vector3(-3535.084 , 4009.331 , 92.28531 , "None"));
Path.Add(new Vector3(-3537.937 , 4008.265 , 92.51826 , "None"));
Path.Add(new Vector3(-3544.833 , 4005.723 , 93.67182 , "None"));
Path.Add(new Vector3(-3549 , 4004.281 , 93.66291 , "None"));
Path.Add(new Vector3(-3555.16 , 4002.265 , 92.92448 , "None"));
Path.Add(new Vector3(-3558.417 , 4001.632 , 92.93198 , "None"));
Path.Add(new Vector3(-3563.823 , 4001.367 , 91.59053 , "None"));
Path.Add(new Vector3(-3566.265 , 4001.784 , 89.67081 , "None"));
Path.Add(new Vector3(-3568.666 , 4002.198 , 87.15515 , "None"));
Path.Add(new Vector3(-3572.242 , 4002.948 , 83.50565 , "None"));
Path.Add(new Vector3(-3575.454 , 4003.556 , 80.71744 , "None"));
Path.Add(new Vector3(-3578.297 , 4004.12 , 78.32602 , "None"));
Path.Add(new Vector3(-3582.241 , 4003.047 , 75.564 , "None"));
Path.Add(new Vector3(-3585.897 , 4004.358 , 75.19584 , "None"));
Path.Add(new Vector3(-3592.477 , 4009.674 , 74.9154 , "None"));
Path.Add(new Vector3(-3591.514 , 4013.033 , 74.20654 , "None"));
Path.Add(new Vector3(-3587.38 , 4016.371 , 73.51462 , "None"));
Path.Add(new Vector3(-3581.313 , 4020.552 , 71.77918 , "None"));
Path.Add(new Vector3(-3572.698 , 4026.369 , 69.79684 , "None"));
Path.Add(new Vector3(-3567.274 , 4030.031 , 69.49143 , "None"));
Path.Add(new Vector3(-3561.305 , 4034.062 , 69.58475 , "None"));
Path.Add(new Vector3(-3554.076 , 4039.701 , 69.5849 , "None"));
Path.Add(new Vector3(-3552.775 , 4045.34 , 69.55966 , "None"));
Path.Add(new Vector3(-3555.044 , 4050.464 , 69.58659 , "None"));
Path.Add(new Vector3(-3560.428 , 4053.443 , 69.35869 , "None"));
Path.Add(new Vector3(-3564.783 , 4055.853 , 69.34956 , "None"));
Path.Add(new Vector3(-3567.915 , 4059.112 , 69.16837 , "None"));
Path.Add(new Vector3(-3571.657 , 4063.437 , 68.63043 , "None"));
Path.Add(new Vector3(-3581.969 , 4066.836 , 69.29441 , "None"));
Path.Add(new Vector3(-3593.093 , 4067.091 , 67.46111 , "None"));
Path.Add(new Vector3(-3599.829 , 4067.346 , 66.30927 , "None"));
Path.Add(new Vector3(-3602.909 , 4067.557 , 65.16719 , "None"));
Path.Add(new Vector3(-3606.813 , 4066.392 , 62.61972 , "None"));
Path.Add(new Vector3(-3611.863 , 4068.609 , 60.77546 , "None"));
Path.Add(new Vector3(-3618.546 , 4075.7 , 56.58649 , "None"));
Path.Add(new Vector3(-3621.05 , 4074.251 , 56.46445 , "None"));
Path.Add(new Vector3(-3623.445 , 4070.724 , 57.29908 , "None"));
Path.Add(new Vector3(-3619.684 , 4062.837 , 61.13537 , "None"));
Path.Add(new Vector3(-3614.722 , 4052.753 , 62.8727 , "None"));
Path.Add(new Vector3(-3611.436 , 4046.529 , 65.06566 , "None"));
Path.Add(new Vector3(-3609.766 , 4043.592 , 65.12691 , "None"));
Path.Add(new Vector3(-3607.405 , 4041.736 , 65.73795 , "None"));
Path.Add(new Vector3(-3602.181 , 4039.427 , 66.83953 , "None"));
Path.Add(new Vector3(-3599.077 , 4034.868 , 68.15048 , "None"));
Path.Add(new Vector3(-3598.712 , 4029.753 , 68.97209 , "None"));
Path.Add(new Vector3(-3601.049 , 4028.351 , 69.1999 , "None"));
Path.Add(new Vector3(-3605.23 , 4027.636 , 69.78603 , "None"));
Path.Add(new Vector3(-3610.086 , 4029.061 , 70.91626 , "None"));
Path.Add(new Vector3(-3614.406 , 4033.2 , 72.79974 , "None"));
Path.Add(new Vector3(-3614.177 , 4036.339 , 73.61712 , "None"));
Path.Add(new Vector3(-3612.309 , 4038.645 , 74.45614 , "None"));
Path.Add(new Vector3(-3606.287 , 4040.497 , 76.45639 , "None"));
Path.Add(new Vector3(-3603.45 , 4039.39 , 77.36709 , "None"));
Path.Add(new Vector3(-3601.816 , 4036.895 , 78.39143 , "None"));
Path.Add(new Vector3(-3600.553 , 4033.951 , 79.52893 , "None"));
Path.Add(new Vector3(-3601.222 , 4030.468 , 80.61623 , "None"));
Path.Add(new Vector3(-3602.688 , 4028.877 , 81.21114 , "None"));
Path.Add(new Vector3(-3608.28 , 4027.673 , 82.99357 , "None"));
Path.Add(new Vector3(-3611.422 , 4032.001 , 84.68764 , "None"));
Path.Add(new Vector3(-3612.133 , 4034.353 , 85.78679 , "None"));
Path.Add(new Vector3(-3611.841 , 4037.258 , 86.89091 , "None"));
Path.Add(new Vector3(-3608.826 , 4038.922 , 88.0476 , "None"));
Path.Add(new Vector3(-3604.949 , 4040.031 , 89.61265 , "None"));
Path.Add(new Vector3(-3602.62 , 4036.496 , 90.97649 , "None"));
Path.Add(new Vector3(-3601.689 , 4032.942 , 92.57664 , "None"));
Path.Add(new Vector3(-3603.629 , 4028.648 , 94.27944 , "None"));
Path.Add(new Vector3(-3607.692 , 4028.948 , 95.59306 , "None"));
Path.Add(new Vector3(-3611.226 , 4030.873 , 97.13495 , "None"));
Path.Add(new Vector3(-3611.773 , 4032.327 , 97.69699 , "None"));
Path.Add(new Vector3(-3611.089 , 4035.287 , 98.93198 , "None"));
Path.Add(new Vector3(-3609.515 , 4037.77 , 100.2327 , "None"));
Path.Add(new Vector3(-3606.78 , 4039.14 , 101.6674 , "None"));
Path.Add(new Vector3(-3604.819 , 4038.046 , 102.5936 , "None"));
Path.Add(new Vector3(-3602.868 , 4035.788 , 104.0255 , "None"));
Path.Add(new Vector3(-3602.665 , 4031.718 , 105.8581 , "None"));
Path.Add(new Vector3(-3605.546 , 4029.022 , 107.4337 , "None"));
Path.Add(new Vector3(-3608.047 , 4030.167 , 108.5169 , "None"));
Path.Add(new Vector3(-3609.355 , 4032.247 , 109.5305 , "None"));
Path.Add(new Vector3(-3610.186 , 4034.979 , 110.4624 , "None"));
Path.Add(new Vector3(-3609.722 , 4037.349 , 110.8793 , "None"));
Path.Add(new Vector3(-3606.985 , 4038.866 , 111.2699 , "None"));
Path.Add(new Vector3(-3604.499 , 4041.425 , 112.2922 , "None"));
Path.Add(new Vector3(-3601.284 , 4045.522 , 112.4346 , "None"));
Path.Add(new Vector3(-3599.629 , 4047.134 , 111.915 , "None"));
Path.Add(new Vector3(-3597.673 , 4048.722 , 111.9487 , "None"));
Path.Add(new Vector3(-3594.588 , 4045.847 , 111.9967 , "None"));
Path.Add(new Vector3(-3592.53 , 4043.409 , 111.9967 , "None"));
Path.Add(new Vector3(-3591.708 , 4040.761 , 111.9951 , "None"));
Path.Add(new Vector3(-3590.813 , 4034.843 , 111.9936 , "None"));
Path.Add(new Vector3(-3590.219 , 4030.919 , 111.9948 , "None"));
Path.Add(new Vector3(-3589.912 , 4028.884 , 111.9965 , "None"));
Path.Add(new Vector3(-3590.294 , 4033.132 , 111.995 , "None"));
Path.Add(new Vector3(-3586.831 , 4034.732 , 112.0017 , "None"));
Path.Add(new Vector3(-3583.381 , 4034.1 , 112.0087 , "None"));
Path.Add(new Vector3(-3577.186 , 4033.087 , 110.5275 , "None"));
Path.Add(new Vector3(-3566.634 , 4032.065 , 106.5767 , "None"));
Path.Add(new Vector3(-3555.608 , 4031.391 , 105.3176 , "None"));
Path.Add(new Vector3(-3545.324 , 4030.438 , 106.3567 , "None"));
Path.Add(new Vector3(-3534.686 , 4029.198 , 110.2195 , "None"));
Path.Add(new Vector3(-3531.786 , 4028.86 , 111.7922 , "None"));
Path.Add(new Vector3(-3527.652 , 4028.252 , 112.1455 , "None"));
Path.Add(new Vector3(-3525.835 , 4030.373 , 112.2863 , "None"));
Path.Add(new Vector3(-3522.984 , 4033.874 , 112.4276 , "None"));
Path.Add(new Vector3(-3520.911 , 4035.65 , 112.5465 , "None"));
Path.Add(new Vector3(-3520.211 , 4029.701 , 112.7426 , "None"));
Path.Add(new Vector3(-3519.344 , 4018.941 , 112.861 , "None"));
Path.Add(new Vector3(-3518.345 , 4013.097 , 112.9799 , "None"));
Path.Add(new Vector3(-3512.46 , 4009.941 , 112.9422 , "None"));
Path.Add(new Vector3(-3505.333 , 4008.7 , 113.1166 , "None"));
Path.Add(new Vector3(-3498.895 , 4011.556 , 113.1166 , "None"));
Path.Add(new Vector3(-3497.217 , 4013.548 , 113.1151 , "None"));
Path.Add(new Vector3(-3493.352 , 4016.75 , 113.1145 , "None"));
Path.Add(new Vector3(-3493.367 , 4020.446 , 113.1145 , "None"));
Path.Add(new Vector3(-3493.791 , 4023.355 , 113.1145 , "None"));
Path.Add(new Vector3(-3494.147 , 4025.637 , 113.113 , "None"));
Path.Add(new Vector3(-3494.408 , 4027.255 , 113.113 , "None"));
Path.Add(new Vector3(-3494.12 , 4025.291 , 113.113 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNBloodstoneFireLast : QuestFollowPathClass
{
    public RUNBloodstoneFireLast()
    {
        Name = "RUN: Bloodstone Fire (Last)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3493.405 , 4022.229 , 113.1134 , "None"));
Path.Add(new Vector3(-3498.03 , 4017.181 , 113.1073 , "None"));
Path.Add(new Vector3(-3500.558 , 4015.679 , 113.1073 , "None"));
Path.Add(new Vector3(-3503.052 , 4014.519 , 113.1073 , "None"));
Path.Add(new Vector3(-3507.374 , 4012.558 , 113.1083 , "None"));
Path.Add(new Vector3(-3510.282 , 4012.367 , 113.1047 , "None"));
Path.Add(new Vector3(-3514.272 , 4013.528 , 113.0172 , "None"));
Path.Add(new Vector3(-3516.969 , 4014.941 , 113.0145 , "None"));
Path.Add(new Vector3(-3519.889 , 4022.189 , 112.9093 , "None"));
Path.Add(new Vector3(-3521.181 , 4025.543 , 112.7701 , "None"));
Path.Add(new Vector3(-3523.008 , 4027.683 , 112.5859 , "None"));
Path.Add(new Vector3(-3525.423 , 4029.208 , 112.3451 , "None"));
Path.Add(new Vector3(-3528.258 , 4029.253 , 112.0818 , "None"));
Path.Add(new Vector3(-3533.332 , 4029.526 , 110.9418 , "None"));
Path.Add(new Vector3(-3543.068 , 4030.267 , 106.8908 , "None"));
Path.Add(new Vector3(-3554.175 , 4031.247 , 105.3181 , "None"));
Path.Add(new Vector3(-3564.917 , 4032.068 , 106.18 , "None"));
Path.Add(new Vector3(-3575.135 , 4032.849 , 109.4048 , "None"));
Path.Add(new Vector3(-3577.991 , 4033.407 , 110.977 , "None"));
Path.Add(new Vector3(-3582.55 , 4035.087 , 112.0106 , "None"));
Path.Add(new Vector3(-3591.384 , 4043.394 , 111.9993 , "None"));
Path.Add(new Vector3(-3598.683 , 4050.334 , 111.9454 , "None"));
Path.Add(new Vector3(-3601.704 , 4050.975 , 111.8407 , "None"));
Path.Add(new Vector3(-3604.212 , 4050.73 , 111.9699 , "None"));
Path.Add(new Vector3(-3606.228 , 4052.603 , 111.9997 , "None"));
Path.Add(new Vector3(-3607.915 , 4050.09 , 111.9951 , "None"));
Path.Add(new Vector3(-3611.109 , 4048.211 , 111.9926 , "None"));
Path.Add(new Vector3(-3621.823 , 4046.764 , 112.002 , "None"));
Path.Add(new Vector3(-3614.176 , 4052.515 , 112.0022 , "None"));
Path.Add(new Vector3(-3610.655 , 4054.092 , 112.0031 , "None"));
Path.Add(new Vector3(-3610.163 , 4053.454 , 112.0037 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNDonewithFiresruntoturnin : QuestFollowPathClass
{
    public RUNDonewithFiresruntoturnin()
    {
        Name = "RUN: Done with Fires, run to turn in";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3600.699 , 4051.198 , 111.9083 , "None"));
Path.Add(new Vector3(-3601.277 , 4044.891 , 112.8258 , "None"));
Path.Add(new Vector3(-3603.095 , 4041.872 , 112.634 , "None"));
Path.Add(new Vector3(-3606.863 , 4037.42 , 111.1183 , "None"));
Path.Add(new Vector3(-3609.163 , 4034.866 , 110.2317 , "None"));
Path.Add(new Vector3(-3609.875 , 4031.812 , 109.6378 , "None"));
Path.Add(new Vector3(-3605.35 , 4029.717 , 107.2736 , "None"));
Path.Add(new Vector3(-3602.924 , 4030.731 , 106.2819 , "None"));
Path.Add(new Vector3(-3601.691 , 4034.357 , 104.7672 , "None"));
Path.Add(new Vector3(-3603.877 , 4038.966 , 102.7351 , "None"));
Path.Add(new Vector3(-3607.062 , 4040.099 , 101.5956 , "None"));
Path.Add(new Vector3(-3612.826 , 4036.448 , 99.25903 , "None"));
Path.Add(new Vector3(-3612.886 , 4031.798 , 97.75201 , "None"));
Path.Add(new Vector3(-3608.999 , 4027.894 , 96.03146 , "None"));
Path.Add(new Vector3(-3600.623 , 4029.356 , 93.69341 , "None"));
Path.Add(new Vector3(-3599.357 , 4036.472 , 91.69877 , "None"));
Path.Add(new Vector3(-3605.455 , 4042.365 , 89.46917 , "None"));
Path.Add(new Vector3(-3608.471 , 4040.887 , 88.51958 , "None"));
Path.Add(new Vector3(-3612.908 , 4037.11 , 86.70816 , "None"));
Path.Add(new Vector3(-3612.202 , 4032.394 , 84.99838 , "None"));
Path.Add(new Vector3(-3608.083 , 4028.202 , 82.99603 , "None"));
Path.Add(new Vector3(-3602.676 , 4027.141 , 81.60089 , "None"));
Path.Add(new Vector3(-3601.774 , 4030.087 , 80.79501 , "None"));
Path.Add(new Vector3(-3601.351 , 4038.217 , 78.14026 , "None"));
Path.Add(new Vector3(-3604.537 , 4041.17 , 76.87244 , "None"));
Path.Add(new Vector3(-3609.791 , 4040.074 , 75.33614 , "None"));
Path.Add(new Vector3(-3615.039 , 4034.536 , 73.20959 , "None"));
Path.Add(new Vector3(-3615.339 , 4031.081 , 72.45863 , "None"));
Path.Add(new Vector3(-3610.872 , 4028.019 , 70.96237 , "None"));
Path.Add(new Vector3(-3601.88 , 4027.495 , 69.36912 , "None"));
Path.Add(new Vector3(-3597.927 , 4030.847 , 68.88352 , "None"));
Path.Add(new Vector3(-3598.598 , 4036.456 , 67.87389 , "None"));
Path.Add(new Vector3(-3602.098 , 4039.306 , 66.87246 , "None"));
Path.Add(new Vector3(-3608.136 , 4043.101 , 65.48657 , "None"));
Path.Add(new Vector3(-3613.839 , 4048.344 , 63.97173 , "None"));
Path.Add(new Vector3(-3615.645 , 4056.036 , 62.29018 , "None"));
Path.Add(new Vector3(-3616.765 , 4059.093 , 62.00941 , "None"));
Path.Add(new Vector3(-3617.991 , 4062.243 , 61.63163 , "None"));
Path.Add(new Vector3(-3620.302 , 4068.754 , 58.66018 , "None"));
Path.Add(new Vector3(-3621.777 , 4072.91 , 56.77023 , "None"));
Path.Add(new Vector3(-3623.294 , 4077.185 , 54.7381 , "None"));
Path.Add(new Vector3(-3624.216 , 4079.955 , 53.15767 , "None"));
Path.Add(new Vector3(-3627.229 , 4090.165 , 47.03871 , "None"));
Path.Add(new Vector3(-3630.045 , 4100.628 , 38.84451 , "None"));
Path.Add(new Vector3(-3631.891 , 4108.413 , 33.08126 , "None"));
Path.Add(new Vector3(-3632.79 , 4115.574 , 28.2599 , "None"));
Path.Add(new Vector3(-3631.489 , 4126.711 , 20.14835 , "None"));
Path.Add(new Vector3(-3629.908 , 4136.938 , 13.9103 , "None"));
Path.Add(new Vector3(-3628.442 , 4147.639 , 8.88927 , "None"));
Path.Add(new Vector3(-3624.565 , 4157.613 , 4.507807 , "None"));
Path.Add(new Vector3(-3620.448 , 4166.791 , 1.378777 , "None"));
Path.Add(new Vector3(-3615.97 , 4176.774 , 0.6996908 , "None"));
Path.Add(new Vector3(-3611.829 , 4186.215 , -0.4767753 , "None"));
Path.Add(new Vector3(-3610.375 , 4190.221 , -0.7898837 , "None"));
Path.Add(new Vector3(-3607.05 , 4200.38 , -1.433552 , "None"));
Path.Add(new Vector3(-3603.862 , 4210.119 , -2.141382 , "None"));
Path.Add(new Vector3(-3600.475 , 4220.522 , -2.843567 , "None"));
Path.Add(new Vector3(-3597.264 , 4230.435 , -2.755302 , "None"));
Path.Add(new Vector3(-3588.198 , 4245.113 , -2.686112 , "None"));
Path.Add(new Vector3(-3578.571 , 4272.198 , -5.313142 , "None"));
Path.Add(new Vector3(-3552.07 , 4290.455 , -4.55953 , "None"));
Path.Add(new Vector3(-3523.875 , 4304.406 , -6.082364 , "None"));
Path.Add(new Vector3(-3493.092 , 4307.782 , -11.92979 , "None"));
Path.Add(new Vector3(-3462.225 , 4312.789 , -13.62961 , "None"));
Path.Add(new Vector3(-3418.994 , 4314.991 , -19.41801 , "None"));
Path.Add(new Vector3(-3384.732 , 4317.692 , -20.18949 , "None"));
Path.Add(new Vector3(-3352.474 , 4320.038 , -20.91655 , "None"));
Path.Add(new Vector3(-3318.879 , 4322.281 , -20.97014 , "None"));
Path.Add(new Vector3(-3287.604 , 4337.911 , -21.24121 , "None"));
Path.Add(new Vector3(-3273.287 , 4362.76 , -20.74241 , "None"));
Path.Add(new Vector3(-3254.542 , 4402.984 , -21.92253 , "None"));
Path.Add(new Vector3(-3248.106 , 4446.01 , -22.95014 , "None"));
Path.Add(new Vector3(-3224.085 , 4477.867 , -22.82822 , "None"));
Path.Add(new Vector3(-3194.683 , 4499.763 , -21.88116 , "None"));
Path.Add(new Vector3(-3165.031 , 4520.143 , -22.05243 , "None"));
Path.Add(new Vector3(-3143.11 , 4535.21 , -21.15332 , "None"));
Path.Add(new Vector3(-3117.968 , 4554.226 , -21.79114 , "None"));
Path.Add(new Vector3(-3092.561 , 4590.856 , -21.28454 , "None"));
Path.Add(new Vector3(-3073.295 , 4620.038 , -21.60538 , "None"));
Path.Add(new Vector3(-3054.692 , 4643.639 , -21.14713 , "None"));
Path.Add(new Vector3(-3055.82 , 4673.335 , -21.93711 , "None"));
Path.Add(new Vector3(-3031.344 , 4702.203 , -21.80544 , "None"));
Path.Add(new Vector3(-2994.683 , 4718.803 , -21.37526 , "None"));
Path.Add(new Vector3(-2986.519 , 4750.912 , -21.69042 , "None"));
Path.Add(new Vector3(-2986.657 , 4777.017 , -22.02483 , "None"));
Path.Add(new Vector3(-2974.632 , 4802.152 , -21.75186 , "None"));
Path.Add(new Vector3(-2950.426 , 4834.41 , -21.49529 , "None"));
Path.Add(new Vector3(-2918.836 , 4882.494 , -20.54344 , "None"));
Path.Add(new Vector3(-2896.572 , 4908.16 , -21.18042 , "None"));
Path.Add(new Vector3(-2876.587 , 4935.431 , -20.91519 , "None"));
Path.Add(new Vector3(-2858.265 , 4954.928 , -20.02704 , "None"));
Path.Add(new Vector3(-2822.685 , 4985.141 , -16.43665 , "None"));
Path.Add(new Vector3(-2869.613 , 5014.627 , -20.53478 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class ReturntoShattrath : QuestClass
{
    public ReturntoShattrath()
    {
        Name = "Return to Shattrath";

        QuestId.AddRange(new[] { 10889 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10874;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheTombofLights : QuestGrinderClass
{
    public TheTombofLights()
    {
        Name = "The Tomb of Lights";

        QuestId.AddRange(new[] { 10840 });

        Step = new List<int> { 10, 10, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10849;

        EntryTarget.Add(21370);
EntryTarget.Add(21368);
EntryTarget.Add(21405);
HotSpots.Add(new Vector3(-2975.956 , 4597.307 , -19.97194 , "None"));
HotSpots.Add(new Vector3(-3031.564 , 4590.547 , -20.3242 , "None"));
HotSpots.Add(new Vector3(-3003.848 , 4489.691 , -21.51701 , "None"));
HotSpots.Add(new Vector3(-2913.128 , 4538.877 , -16.6165 , "None"));
HotSpots.Add(new Vector3(-2975.506 , 4508.095 , -41.0206 , "None"));
HotSpots.Add(new Vector3(-2932.859 , 4504.484 , -42.94881 , "None"));
HotSpots.Add(new Vector3(-3014.426 , 4503.566 , -42.94651 , "None"));
HotSpots.Add(new Vector3(-2974.956 , 4464.112 , -47.29431 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MissingFriends : QuestGathererClass
{
    public MissingFriends()
    {
        Name = "Missing Friends";

        QuestId.AddRange(new[] { 10852 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10849;

        EntryIdObjects.Add(185202);
EntryIdObjects.Add(181800);
EntryIdObjects.Add(185203);
EntryIdObjects.Add(185205);
EntryIdObjects.Add(185204);
HotSpots.Add(new Vector3(-2543.883 , 5483.099 , 8.258019 , "None"));
HotSpots.Add(new Vector3(-2578.925 , 5428.432 , 27.7275 , "None"));
HotSpots.Add(new Vector3(-2528.083 , 5385.11 , 28.01616 , "None"));
HotSpots.Add(new Vector3(-2462.197 , 5400.864 , 2.055511 , "None"));
HotSpots.Add(new Vector3(-2543.646 , 5482.726 , 8.258869 , "None"));
HotSpots.Add(new Vector3(-2579.784 , 5428.59 , 27.6864 , "None"));
HotSpots.Add(new Vector3(-2527.479 , 5385.599 , 28.01311 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PATHMissingFriendsKillforKeys : QuestFollowPathClass
{
    public PATHMissingFriendsKillforKeys()
    {
        Name = "PATH: Missing Friends ; Kill for Keys";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2582.46 , 5410.313 , 0.07683496 , "None"));
Path.Add(new Vector3(-2576.818 , 5418.917 , 0.05517239 , "None"));
Path.Add(new Vector3(-2568.754 , 5413.725 , 0.08346954 , "None"));
Path.Add(new Vector3(-2562.543 , 5410.35 , 0.2279423 , "None"));
Path.Add(new Vector3(-2553.388 , 5406.489 , 0.1266121 , "None"));
Path.Add(new Vector3(-2546.39 , 5406.844 , 0.04859171 , "None"));
Path.Add(new Vector3(-2539.22 , 5408.93 , 0.04859171 , "None"));
Path.Add(new Vector3(-2536.179 , 5401.997 , 0.04859171 , "None"));
Path.Add(new Vector3(-2535.608 , 5395.169 , 0.04859171 , "None"));
Path.Add(new Vector3(-2527.552 , 5396.147 , 0.04859171 , "None"));
Path.Add(new Vector3(-2520.4 , 5397.176 , 0.04859171 , "None"));
Path.Add(new Vector3(-2514.794 , 5393.378 , 0.04859171 , "None"));
Path.Add(new Vector3(-2510.492 , 5388.286 , 0.04859171 , "None"));
Path.Add(new Vector3(-2503.321 , 5385.608 , 0.04705183 , "None"));
Path.Add(new Vector3(-2492.252 , 5385.091 , 0.04705183 , "None"));
Path.Add(new Vector3(-2484.353 , 5386.99 , 0.1444202 , "None"));
Path.Add(new Vector3(-2481.105 , 5395.98 , 1.447791 , "None"));
Path.Add(new Vector3(-2477.051 , 5401.047 , 2.248474 , "None"));
Path.Add(new Vector3(-2482.233 , 5406.399 , 2.342977 , "None"));
Path.Add(new Vector3(-2488.127 , 5410.559 , 1.074632 , "None"));
Path.Add(new Vector3(-2492.298 , 5416.075 , 0.07730483 , "None"));
Path.Add(new Vector3(-2498.917 , 5420.289 , 0.04753387 , "None"));
Path.Add(new Vector3(-2506.266 , 5422.077 , 0.04753387 , "None"));
Path.Add(new Vector3(-2513.694 , 5423.057 , 0.04753387 , "None"));
Path.Add(new Vector3(-2513.183 , 5430.928 , 0.04753387 , "None"));
Path.Add(new Vector3(-2518.75 , 5440.139 , 0.04753387 , "None"));
Path.Add(new Vector3(-2523.657 , 5449.89 , 0.3672634 , "None"));
Path.Add(new Vector3(-2527.282 , 5457.726 , 2.669491 , "None"));
Path.Add(new Vector3(-2530.18 , 5463.99 , 5.303956 , "None"));
Path.Add(new Vector3(-2533.486 , 5470.333 , 7.399786 , "None"));
Path.Add(new Vector3(-2539.586 , 5473.449 , 8.242507 , "None"));
Path.Add(new Vector3(-2545.206 , 5469.388 , 8.260062 , "None"));
Path.Add(new Vector3(-2550.303 , 5464.589 , 11.99376 , "None"));
Path.Add(new Vector3(-2554.516 , 5460.241 , 16.99839 , "None"));
Path.Add(new Vector3(-2559.494 , 5455.044 , 24.1202 , "None"));
Path.Add(new Vector3(-2564.473 , 5450.217 , 27.24617 , "None"));
Path.Add(new Vector3(-2571.521 , 5449.238 , 27.40358 , "None"));
Path.Add(new Vector3(-2578.541 , 5449.239 , 27.61522 , "None"));
Path.Add(new Vector3(-2586.446 , 5443.575 , 27.52723 , "None"));
Path.Add(new Vector3(-2588.833 , 5437.094 , 27.23742 , "None"));
Path.Add(new Vector3(-2586.757 , 5430.251 , 27.14046 , "None"));
Path.Add(new Vector3(-2578.189 , 5425.64 , 26.90546 , "None"));
Path.Add(new Vector3(-2571.271 , 5425.024 , 26.75404 , "None"));
Path.Add(new Vector3(-2565.577 , 5420.782 , 25.1885 , "None"));
Path.Add(new Vector3(-2561.146 , 5415.449 , 22.05074 , "None"));
Path.Add(new Vector3(-2556.203 , 5410.493 , 20.33275 , "None"));
Path.Add(new Vector3(-2551.185 , 5405.462 , 20.0027 , "None"));
Path.Add(new Vector3(-2546.048 , 5400.374 , 21.03207 , "None"));
Path.Add(new Vector3(-2541.04 , 5395.453 , 23.26069 , "None"));
Path.Add(new Vector3(-2535.983 , 5390.482 , 27.17176 , "None"));
Path.Add(new Vector3(-2528.672 , 5388.113 , 27.31047 , "None"));
Path.Add(new Vector3(-2521.376 , 5388.337 , 27.78114 , "None"));
Path.Add(new Vector3(-2515.047 , 5385.667 , 27.45966 , "None"));
Path.Add(new Vector3(-2511.595 , 5379.642 , 27.15014 , "None"));
Path.Add(new Vector3(-2511.982 , 5372.475 , 27.1497 , "None"));
Path.Add(new Vector3(-2515.074 , 5366.203 , 27.15808 , "None"));
Path.Add(new Vector3(-2520.313 , 5362.148 , 27.26331 , "None"));
Path.Add(new Vector3(-2526.578 , 5364.974 , 27.2243 , "None"));
Path.Add(new Vector3(-2531.597 , 5369.605 , 27.31782 , "None"));
Path.Add(new Vector3(-2534.737 , 5376.212 , 27.22548 , "None"));
Path.Add(new Vector3(-2533.43 , 5382.995 , 27.33051 , "None"));
Path.Add(new Vector3(-2537.361 , 5391.674 , 26.47569 , "None"));
Path.Add(new Vector3(-2543.363 , 5397.498 , 22.23128 , "None"));
Path.Add(new Vector3(-2550.93 , 5405.564 , 20.00308 , "None"));
Path.Add(new Vector3(-2558.843 , 5412.992 , 20.97452 , "None"));
Path.Add(new Vector3(-2566.257 , 5420.725 , 25.44585 , "None"));
Path.Add(new Vector3(-2569.221 , 5429.524 , 27.16166 , "None"));
Path.Add(new Vector3(-2566.963 , 5440.423 , 28.00201 , "None"));
Path.Add(new Vector3(-2564.395 , 5447.468 , 27.23962 , "None"));
Path.Add(new Vector3(-2560.31 , 5453.169 , 25.67565 , "None"));
Path.Add(new Vector3(-2553.752 , 5460.572 , 16.35374 , "None"));
Path.Add(new Vector3(-2545.894 , 5468.241 , 8.650887 , "None"));
Path.Add(new Vector3(-2536.572 , 5473.96 , 8.097694 , "None"));
Path.Add(new Vector3(-2527.015 , 5475.826 , 8.22233 , "None"));
Path.Add(new Vector3(-2530.326 , 5468.03 , 6.670648 , "None"));
Path.Add(new Vector3(-2528.395 , 5460.982 , 4.031812 , "None"));
Path.Add(new Vector3(-2524.146 , 5454.059 , 1.193818 , "None"));
Path.Add(new Vector3(-2516.604 , 5448.614 , 0.04763624 , "None"));
Path.Add(new Vector3(-2509.506 , 5440.587 , 0.04763624 , "None"));
Path.Add(new Vector3(-2502.543 , 5441.427 , 0.04763624 , "None"));
Path.Add(new Vector3(-2498.092 , 5429.239 , 0.04763624 , "None"));
Path.Add(new Vector3(-2493.2 , 5420.307 , 0.04763624 , "None"));
Path.Add(new Vector3(-2488.148 , 5410.959 , 1.054854 , "None"));
Path.Add(new Vector3(-2484.36 , 5402.008 , 1.888806 , "None"));
Path.Add(new Vector3(-2476.409 , 5395.036 , 1.741665 , "None"));
Path.Add(new Vector3(-2460.779 , 5388.812 , 2.039715 , "None"));
Path.Add(new Vector3(-2452.915 , 5387.121 , 1.774343 , "None"));
Path.Add(new Vector3(-2441.69 , 5383.833 , 1.500758 , "None"));
Path.Add(new Vector3(-2430.84 , 5378.597 , 1.924637 , "None"));
Path.Add(new Vector3(-2424.246 , 5379.165 , 1.994236 , "None"));
Path.Add(new Vector3(-2419.549 , 5388.284 , 1.923732 , "None"));
Path.Add(new Vector3(-2421.468 , 5399.374 , 1.983411 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RecovertheBones : QuestGathererClass
{
    public RecovertheBones()
    {
        Name = "Recover the Bones";

        QuestId.AddRange(new[] { 10030 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10840;

        EntryIdObjects.Add(182585);
EntryIdObjects.Add(182584);
HotSpots.Add(new Vector3(-3030.819 , 5332.859 , -18.84396 , "None"));
HotSpots.Add(new Vector3(-3034.668 , 5067.88 , -21.19855 , "None"));
HotSpots.Add(new Vector3(-2966.326 , 5131.661 , -20.00898 , "None"));
HotSpots.Add(new Vector3(-2767.677 , 5198.169 , -7.380538 , "None"));
HotSpots.Add(new Vector3(-2832.477 , 5266.246 , -7.677206 , "None"));
HotSpots.Add(new Vector3(-2899.059 , 5332.266 , -12.02257 , "None"));
HotSpots.Add(new Vector3(-3030.844 , 5331.868 , -18.87902 , "None"));
HotSpots.Add(new Vector3(-3234.992 , 5266.471 , -20.97658 , "None"));
HotSpots.Add(new Vector3(-3234.399 , 5398.309 , -20.55686 , "None"));
HotSpots.Add(new Vector3(-3298.239 , 5466.454 , -13.84523 , "None"));
HotSpots.Add(new Vector3(-3502.224 , 5401.584 , -15.60554 , "None"));
HotSpots.Add(new Vector3(-3231.709 , 5529.275 , -16.89078 , "None"));
HotSpots.Add(new Vector3(-3033.631 , 5601.711 , -5.780432 , "None"));
HotSpots.Add(new Vector3(-2964.773 , 5537.144 , -4.500772 , "None"));
HotSpots.Add(new Vector3(-2767.788 , 5199.376 , -7.331984 , "None"));
HotSpots.Add(new Vector3(-2699.533 , 4999.223 , -7.101208 , "None"));
HotSpots.Add(new Vector3(-2832.846 , 4866.209 , -16.0229 , "None"));
HotSpots.Add(new Vector3(-2837.653 , 4600.257 , -11.60675 , "None"));
HotSpots.Add(new Vector3(-2898.124 , 4534.115 , -14.241 , "None"));
HotSpots.Add(new Vector3(-3032.367 , 4399.864 , -14.41634 , "None"));
HotSpots.Add(new Vector3(-3167.07 , 4399.062 , -19.54143 , "None"));
HotSpots.Add(new Vector3(-3235.111 , 4466.679 , -22.83828 , "None"));
HotSpots.Add(new Vector3(-3433.46 , 4267.104 , -13.097 , "None"));
HotSpots.Add(new Vector3(-3500.822 , 4333.092 , -14.36638 , "None"));
HotSpots.Add(new Vector3(-3498.212 , 4599.939 , -20.54618 , "None"));
HotSpots.Add(new Vector3(-3767.593 , 4468.754 , -7.632164 , "None"));
HotSpots.Add(new Vector3(-3764.686 , 4867.26 , -20.07732 , "None"));
HotSpots.Add(new Vector3(-3765.705 , 5000.571 , -19.56704 , "None"));
HotSpots.Add(new Vector3(-3696.953 , 5064.214 , -19.62158 , "None"));
HotSpots.Add(new Vector3(-3765.3 , 5266.732 , -17.59011 , "None"));
HotSpots.Add(new Vector3(-3631.946 , 5401.224 , -11.14938 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HelpingtheLostFindTheirWay : QuestGrinderClass
{
    public HelpingtheLostFindTheirWay()
    {
        Name = "Helping the Lost Find Their Way";

        QuestId.AddRange(new[] { 10031 });

        Step = new List<int> { 10, 10, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10030;

        EntryTarget.Add(16805);
EntryTarget.Add(18460);
HotSpots.Add(new Vector3(-3901.044 , 4841.558 , -46.94833 , "None"));
HotSpots.Add(new Vector3(-3799.036 , 4857.249 , -21.93871 , "None"));
HotSpots.Add(new Vector3(-3736.729 , 4865.854 , -18.69261 , "None"));
HotSpots.Add(new Vector3(-3760.729 , 4964.22 , -21.09195 , "None"));
HotSpots.Add(new Vector3(-3839.596 , 4997.088 , -28.00899 , "None"));
HotSpots.Add(new Vector3(-3850.637 , 4893.156 , -29.84605 , "None"));
HotSpots.Add(new Vector3(-3904.822 , 5005.919 , -67.41694 , "None"));
HotSpots.Add(new Vector3(-3828.716 , 5115.591 , -32.86099 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ISeeDeadDraenei : QuestClass
{
    public ISeeDeadDraenei()
    {
        Name = "I See Dead Draenei";

        QuestId.AddRange(new[] { 10227 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Ezekiel : QuestClass
{
    public Ezekiel()
    {
        Name = "Ezekiel";

        QuestId.AddRange(new[] { 10228 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheSkettisOffensive : QuestGrinderClass
{
    public TheSkettisOffensive()
    {
        Name = "The Skettis Offensive";

        QuestId.AddRange(new[] { 10879 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10889;

        EntryTarget.Add(22376);
EntryTarget.Add(22375);
HotSpots.Add(new Vector3(-1640.137 , 5430.195 , -43.30561 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNZangermarshlift : QuestFollowPathClass
{
    public RUNZangermarshlift()
    {
        Name = "RUN: Zangermarsh lift";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(282.8883 , 5959.866 , 25.88519 , "None"));
Path.Add(new Vector3(283.3296 , 5949.007 , 26.42551 , "None"));
Path.Add(new Vector3(283.5502 , 5945.803 , 26.46035 , "None"));
Path.Add(new Vector3(283.8723 , 5941.792 , 26.50396 , "None"));
Path.Add(new Vector3(284.3512 , 5937.666 , 26.54894 , "None"));
Path.Add(new Vector3(284.8566 , 5933.673 , 26.59248 , "None"));
Path.Add(new Vector3(285.6443 , 5927.456 , 26.58157 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNWeareUPRuntoFPandLearnit : QuestFollowPathClass
{
    public RUNWeareUPRuntoFPandLearnit()
    {
        Name = "RUN: We are UP - Run to FP and Learn it";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(281.4654 , 5952.846 , 149.772 , "None"));
Path.Add(new Vector3(281.7745 , 5958.868 , 149.6973 , "None"));
Path.Add(new Vector3(281.9276 , 5963.074 , 150.1573 , "None"));
Path.Add(new Vector3(282.0487 , 5967.065 , 150.2316 , "None"));
Path.Add(new Vector3(282.019 , 5971.259 , 150.033 , "None"));
Path.Add(new Vector3(281.8911 , 5975.182 , 148.6156 , "None"));
Path.Add(new Vector3(281.7004 , 5979.25 , 146.8665 , "None"));
Path.Add(new Vector3(281.2741 , 5983.454 , 144.7299 , "None"));
Path.Add(new Vector3(280.8079 , 5987.484 , 144.7386 , "None"));
Path.Add(new Vector3(280.338 , 5991.547 , 144.7387 , "None"));
Path.Add(new Vector3(279.8819 , 5995.489 , 144.7311 , "None"));
Path.Add(new Vector3(279.4018 , 5999.639 , 144.7294 , "None"));
Path.Add(new Vector3(278.9392 , 6003.638 , 144.7294 , "None"));
Path.Add(new Vector3(278.4626 , 6007.707 , 144.7294 , "None"));
Path.Add(new Vector3(277.6951 , 6011.746 , 143.8384 , "None"));
Path.Add(new Vector3(276.5941 , 6015.583 , 141.1267 , "None"));
Path.Add(new Vector3(274.5524 , 6019.31 , 138.1861 , "None"));
Path.Add(new Vector3(271.8778 , 6022.156 , 135.6273 , "None"));
Path.Add(new Vector3(268.4915 , 6024.525 , 133.3082 , "None"));
Path.Add(new Vector3(264.937 , 6026.443 , 131.641 , "None"));
Path.Add(new Vector3(261.2838 , 6028.143 , 131.6127 , "None"));
Path.Add(new Vector3(258.6957 , 6031.728 , 131.6289 , "None"));
Path.Add(new Vector3(258.2341 , 6035.857 , 131.6219 , "None"));
Path.Add(new Vector3(258.1304 , 6039.945 , 131.6146 , "None"));
Path.Add(new Vector3(257.9102 , 6043.94 , 133.0124 , "None"));
Path.Add(new Vector3(256.532 , 6047.694 , 133.354 , "None"));
Path.Add(new Vector3(253.2349 , 6049.992 , 134.0557 , "None"));
Path.Add(new Vector3(249.4017 , 6051.694 , 136.3126 , "None"));
Path.Add(new Vector3(245.5699 , 6053.296 , 138.3794 , "None"));
Path.Add(new Vector3(241.9434 , 6054.606 , 140.4011 , "None"));
Path.Add(new Vector3(238.0443 , 6056.015 , 142.6499 , "None"));
Path.Add(new Vector3(234.0407 , 6057.167 , 144.8277 , "None"));
Path.Add(new Vector3(230.271 , 6058.277 , 146.9274 , "None"));
Path.Add(new Vector3(226.2687 , 6059.634 , 148.3126 , "None"));
Path.Add(new Vector3(222.4152 , 6060.901 , 148.3132 , "None"));
Path.Add(new Vector3(218.4733 , 6062.018 , 148.3146 , "None"));
Path.Add(new Vector3(214.6293 , 6063.264 , 148.3159 , "None"));
Path.Add(new Vector3(211.7625 , 6064.234 , 148.3169 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class TheOreborHarborage : QuestClass
{
    public TheOreborHarborage()
    {
        Name = "The Orebor Harborage";

        QuestId.AddRange(new[] { 9776 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class NoTimeforCuriosity : QuestClass
{
    public NoTimeforCuriosity()
    {
        Name = "No Time for Curiosity";

        QuestId.AddRange(new[] { 9794 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ConcernsAboutTuurem : QuestClass
{
    public ConcernsAboutTuurem()
    {
        Name = "Concerns About Tuurem";

        QuestId.AddRange(new[] { 10104 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AngoroshEncroachment : QuestGrinderClass
{
    public AngoroshEncroachment()
    {
        Name = "Ango'rosh Encroachment";

        QuestId.AddRange(new[] { 9835 });

        Step = new List<int> { 5, 10, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18117);
EntryTarget.Add(18118);
HotSpots.Add(new Vector3(979.0163 , 7622.489 , 22.05569 , "None"));
HotSpots.Add(new Vector3(871.2145 , 7708.35 , 22.22312 , "None"));
HotSpots.Add(new Vector3(982.958 , 7699.561 , 23.57799 , "None"));
HotSpots.Add(new Vector3(920.7461 , 7900.248 , 22.3483 , "None"));
HotSpots.Add(new Vector3(1011.388 , 7975.038 , 22.11344 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DaggerfenDeviance : QuestGrinderClass
{
    public DaggerfenDeviance()
    {
        Name = "Daggerfen Deviance";

        QuestId.AddRange(new[] { 10115 });

        Step = new List<int> { 3, 15, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18116);
EntryTarget.Add(18115);
HotSpots.Add(new Vector3(1070.271 , 8125.543 , 20.45847 , "Flying"));
HotSpots.Add(new Vector3(1110.175 , 8186.642 , 22.37144 , "None"));
HotSpots.Add(new Vector3(1132.091 , 8284.77 , 19.57434 , "None"));
HotSpots.Add(new Vector3(1168.105 , 8288.534 , 19.1859 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class OverlordGorefist : QuestGrinderClass
{
    public OverlordGorefist()
    {
        Name = "Overlord Gorefist";

        QuestId.AddRange(new[] { 9839 });

        Step = new List<int> { 1, 10, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9835;

        EntryTarget.Add(18120);
EntryTarget.Add(18121);
EntryTarget.Add(18160);
HotSpots.Add(new Vector3(1462.188 , 8613.619 , -12.8203 , "None"));
HotSpots.Add(new Vector3(1655.135 , 8503.89 , -6.547703 , "None"));
HotSpots.Add(new Vector3(1674.057 , 8555.607 , 2.690514 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AMessagetoTelaar : QuestClass
{
    public AMessagetoTelaar()
    {
        Name = "A Message to Telaar";

        QuestId.AddRange(new[] { 9792 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class NaturalArmor : QuestGrinderClass
{
    public NaturalArmor()
    {
        Name = "Natural Armor";

        QuestId.AddRange(new[] { 9834 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9839;

        EntryTarget.Add(18214);
HotSpots.Add(new Vector3(694.6455 , 6982.341 , -28.89036 , "Swimming"));
HotSpots.Add(new Vector3(641.6646 , 6834.857 , -28.01998 , "Swimming"));
HotSpots.Add(new Vector3(527.9391 , 6794.523 , -29.94312 , "Swimming"));
HotSpots.Add(new Vector3(426.6061 , 6918.623 , -13.69381 , "Swimming"));
HotSpots.Add(new Vector3(511.2934 , 7025.928 , -38.676 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheTerrorofMarshlightLake : QuestGrinderClass
{
    public TheTerrorofMarshlightLake()
    {
        Name = "The Terror of Marshlight Lake";

        QuestId.AddRange(new[] { 9902 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9839;

        EntryTarget.Add(20477);
HotSpots.Add(new Vector3(400.72 , 8353.38 , 22.6682 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LinesofCommunication : QuestGrinderClass
{
    public LinesofCommunication()
    {
        Name = "Lines of Communication";

        QuestId.AddRange(new[] { 9833 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9839;

        EntryTarget.Add(18131);
EntryTarget.Add(18285);
EntryTarget.Add(18133);
HotSpots.Add(new Vector3(-49.54015 , 7698.113 , 21.27058 , "None"));
HotSpots.Add(new Vector3(-191.276 , 7779.938 , 19.75023 , "None"));
HotSpots.Add(new Vector3(1.976759 , 7864.232 , 20.71785 , "None"));
HotSpots.Add(new Vector3(95.07198 , 8118.521 , 21.43479 , "None"));
HotSpots.Add(new Vector3(142.3295 , 8224.932 , 23.46952 , "None"));
HotSpots.Add(new Vector3(0.8971032 , 8462.034 , 22.29698 , "None"));
HotSpots.Add(new Vector3(164.0099 , 8435.607 , 23.52934 , "None"));
HotSpots.Add(new Vector3(-141.3904 , 7767.73 , 23.80739 , "None"));
HotSpots.Add(new Vector3(104.4814 , 7822.288 , 22.18048 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class StingerVenom : QuestGrinderClass
{
    public StingerVenom()
    {
        Name = "Stinger Venom";

        QuestId.AddRange(new[] { 9830 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9839;

        EntryTarget.Add(18133);
HotSpots.Add(new Vector3(169.8249 , 8167.775 , 22.95117 , "None"));
HotSpots.Add(new Vector3(117.5124 , 8338.476 , 20.23981 , "None"));
HotSpots.Add(new Vector3(154.3784 , 8405.817 , 22.02058 , "None"));
HotSpots.Add(new Vector3(205.6245 , 8451.361 , 25.26906 , "None"));
HotSpots.Add(new Vector3(39.97327 , 8472.655 , 22.67112 , "None"));
HotSpots.Add(new Vector3(69.32923 , 8445.51 , 20.43248 , "None"));
HotSpots.Add(new Vector3(152.416 , 8245.833 , 22.5068 , "None"));
HotSpots.Add(new Vector3(152.7958 , 8218.873 , 23.58139 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheCountoftheMarshes : QuestClass
{
    public TheCountoftheMarshes()
    {
        Name = "The Count of the Marshes";

        QuestId.AddRange(new[] { 9911 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 25459;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheCountoftheMarshesKILLFORITEM : QuestGrinderClass
{
    public TheCountoftheMarshesKILLFORITEM()
    {
        Name = "The Count of the Marshes - KILL FOR ITEM";

        QuestId.AddRange(new[] { 9911 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18285);
HotSpots.Add(new Vector3(-60.22543 , 7827.97 , 23.13414 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(25459) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class MaktusRevenge : QuestGrinderClass
{
    public MaktusRevenge()
    {
        Name = "Maktu's Revenge";

        QuestId.AddRange(new[] { 9905 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9834;

        EntryTarget.Add(18286);
HotSpots.Add(new Vector3(546.99 , 7351.98 , 6.03459 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNSporaggerQuests : QuestFollowPathClass
{
    public RUNSporaggerQuests()
    {
        Name = "RUN: Sporagger Quests";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(881.591 , 7449.66 , 21.13502 , "None"));
Path.Add(new Vector3(854.7755 , 7468.951 , 23.07882 , "None"));
Path.Add(new Vector3(823.4769 , 7487.467 , 17.80467 , "None"));
Path.Add(new Vector3(794.4777 , 7506.816 , 22.18258 , "None"));
Path.Add(new Vector3(765.6544 , 7528.16 , 21.88311 , "None"));
Path.Add(new Vector3(735.9506 , 7547.876 , 17.46533 , "None"));
Path.Add(new Vector3(704.158 , 7562.124 , 19.19602 , "None"));
Path.Add(new Vector3(669.9049 , 7571.676 , 20.84737 , "None"));
Path.Add(new Vector3(640.6423 , 7586.014 , 22.29981 , "None"));
Path.Add(new Vector3(623.1325 , 7612.517 , 20.38494 , "None"));
Path.Add(new Vector3(595.4198 , 7635.069 , 22.74912 , "None"));
Path.Add(new Vector3(567.0211 , 7656.736 , 18.14954 , "None"));
Path.Add(new Vector3(546.0204 , 7702.648 , 17.3746 , "None"));
Path.Add(new Vector3(519.4688 , 7723.772 , 18.72544 , "None"));
Path.Add(new Vector3(489.6682 , 7742.965 , 18.17018 , "None"));
Path.Add(new Vector3(498.6677 , 7767.84 , 17.77566 , "None"));
Path.Add(new Vector3(507.3907 , 7790.585 , 17.37419 , "None"));
Path.Add(new Vector3(498.364 , 7755.026 , 17.88573 , "None"));
Path.Add(new Vector3(477.4806 , 7726.068 , 17.37456 , "None"));
Path.Add(new Vector3(448.9313 , 7704.655 , 17.37432 , "None"));
Path.Add(new Vector3(418.4611 , 7685.447 , 20.85532 , "None"));
Path.Add(new Vector3(390.6199 , 7674.447 , 17.59177 , "None"));
Path.Add(new Vector3(370.2063 , 7658.094 , 22.21691 , "None"));
Path.Add(new Vector3(351.0452 , 7644.433 , 23.53975 , "None"));
Path.Add(new Vector3(319.9604 , 7624.859 , 23.45791 , "None"));
Path.Add(new Vector3(287.6181 , 7610.952 , 22.64453 , "None"));
Path.Add(new Vector3(254.4798 , 7597.862 , 22.13518 , "None"));
Path.Add(new Vector3(220.0455 , 7593.857 , 17.38647 , "None"));
Path.Add(new Vector3(191.515 , 7588.14 , 18.0961 , "None"));
Path.Add(new Vector3(135.2387 , 7580.3 , 17.37524 , "None"));
Path.Add(new Vector3(113.3494 , 7582.941 , 17.37524 , "None"));
Path.Add(new Vector3(91.44218 , 7586.464 , 17.37524 , "None"));
Path.Add(new Vector3(62.43879 , 7588.119 , 17.53943 , "None"));
Path.Add(new Vector3(27.46055 , 7589.353 , 17.44988 , "None"));
Path.Add(new Vector3(-8.571726 , 7590.624 , 17.59888 , "None"));
Path.Add(new Vector3(-30.70726 , 7591.973 , 17.37424 , "None"));
Path.Add(new Vector3(-50.13379 , 7616.469 , 18.92154 , "None"));
Path.Add(new Vector3(-70.35923 , 7662.979 , 17.3741 , "None"));
Path.Add(new Vector3(-82.27434 , 7696.183 , 17.3741 , "None"));
Path.Add(new Vector3(-98.52711 , 7726.814 , 18.9925 , "None"));
Path.Add(new Vector3(-117.8367 , 7757.235 , 22.88303 , "None"));
Path.Add(new Vector3(-126.7807 , 7778.754 , 22.74547 , "None"));
Path.Add(new Vector3(-129.598 , 7807.675 , 21.06676 , "None"));
Path.Add(new Vector3(-120.5096 , 7842.613 , 19.5343 , "None"));
Path.Add(new Vector3(-111.0241 , 7876.302 , 19.16057 , "None"));
Path.Add(new Vector3(-112.0266 , 7911.813 , 21.07198 , "None"));
Path.Add(new Vector3(-120.0113 , 7936.735 , 18.54064 , "None"));
Path.Add(new Vector3(-99.05453 , 7949.279 , 18.6499 , "None"));
Path.Add(new Vector3(-87.33003 , 7981.469 , 18.09993 , "None"));
Path.Add(new Vector3(-79.45249 , 7868.594 , 19.09758 , "None"));
Path.Add(new Vector3(-61.29756 , 7855.995 , 24.98129 , "None"));
Path.Add(new Vector3(-30.70605 , 7875.45 , 19.39376 , "None"));
Path.Add(new Vector3(-5.407656 , 7898.976 , 19.92767 , "None"));
Path.Add(new Vector3(8.624722 , 7920.495 , 19.69852 , "None"));
Path.Add(new Vector3(29.42701 , 7948.524 , 22.3657 , "None"));
Path.Add(new Vector3(49.04144 , 7977.26 , 19.57688 , "None"));
Path.Add(new Vector3(52.48721 , 8012.941 , 19.2209 , "None"));
Path.Add(new Vector3(52.37914 , 8048.01 , 19.93299 , "None"));
Path.Add(new Vector3(51.86683 , 8083.937 , 21.84689 , "None"));
Path.Add(new Vector3(46.55217 , 8107.365 , 22.27224 , "None"));
Path.Add(new Vector3(31.43201 , 8139.82 , 22.57449 , "None"));
Path.Add(new Vector3(3.855538 , 8161.678 , 22.56376 , "None"));
Path.Add(new Vector3(-27.01289 , 8178.093 , 22.29268 , "None"));
Path.Add(new Vector3(-46.91763 , 8190.331 , 22.70016 , "None"));
Path.Add(new Vector3(-76.60888 , 8208.863 , 22.88598 , "None"));
Path.Add(new Vector3(-106.3001 , 8227.395 , 22.94373 , "None"));
Path.Add(new Vector3(-137.1281 , 8246.193 , 22.53339 , "None"));
Path.Add(new Vector3(-170.4759 , 8259.172 , 22.66544 , "None"));
Path.Add(new Vector3(-176.7367 , 8301.995 , 18.37436 , "None"));
Path.Add(new Vector3(-191.191 , 8333.871 , 19.66541 , "None"));
Path.Add(new Vector3(-206.2124 , 8366.716 , 23.09662 , "None"));
Path.Add(new Vector3(-220.822 , 8391.983 , 21.88875 , "None"));
Path.Add(new Vector3(-192.5486 , 8526.985 , 22.24671 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class TheSporelingsPlight : QuestGathererClass
{
    public TheSporelingsPlight()
    {
        Name = "The Sporelings' Plight";

        QuestId.AddRange(new[] { 9739 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(182069);
HotSpots.Add(new Vector3(-86.63401 , 8565.384 , 21.56697 , "None"));
HotSpots.Add(new Vector3(-80.79223 , 8657.176 , 17.20507 , "None"));
HotSpots.Add(new Vector3(-194.4662 , 8729.248 , 20.41207 , "None"));
HotSpots.Add(new Vector3(-208.7518 , 8861.83 , 19.76902 , "None"));
HotSpots.Add(new Vector3(-183.9868 , 8916.499 , 23.69532 , "None"));
HotSpots.Add(new Vector3(-145.3295 , 8961.142 , 19.75632 , "None"));
HotSpots.Add(new Vector3(-109.5431 , 8922.576 , 18.81909 , "None"));
HotSpots.Add(new Vector3(-12.25171 , 8851.717 , 21.09783 , "None"));
HotSpots.Add(new Vector3(-79.77654 , 8659.635 , 17.33225 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class NaturalEnemies : QuestGrinderClass
{
    public NaturalEnemies()
    {
        Name = "Natural Enemies";

        QuestId.AddRange(new[] { 9743 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18125);
EntryTarget.Add(19519);
HotSpots.Add(new Vector3(-146.9718 , 8579.296 , 18.00485 , "None"));
HotSpots.Add(new Vector3(-117.5006 , 8746.246 , 19.20321 , "None"));
HotSpots.Add(new Vector3(-17.61847 , 8886.29 , 18.55729 , "None"));
HotSpots.Add(new Vector3(-200.7732 , 8890.632 , 18.50703 , "None"));
HotSpots.Add(new Vector3(-170.5079 , 8654.775 , 20.48146 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KILL6466ZangermarshSporeaggerRepWestSpawningGlen : QuestGrinderClass
{
    public KILL6466ZangermarshSporeaggerRepWestSpawningGlen()
    {
        Name = "KILL: 64-66 - Zangermarsh Sporeagger Rep - West - Spawning Glen";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18125);
EntryTarget.Add(19519);
EntryTarget.Add(18135);
EntryTarget.Add(18131);
HotSpots.Add(new Vector3(-183.7916 , 8599.761 , 19.05194 , "None"));
HotSpots.Add(new Vector3(-29.73792 , 8492.429 , 22.4593 , "None"));
HotSpots.Add(new Vector3(-13.3613 , 8547.008 , 18.08394 , "None"));
HotSpots.Add(new Vector3(-80.72383 , 8606.409 , 18.4106 , "None"));
HotSpots.Add(new Vector3(-212.4295 , 8810.625 , 17.9714 , "None"));
HotSpots.Add(new Vector3(-153.5281 , 8947.74 , 20.97739 , "None"));
HotSpots.Add(new Vector3(-19.90232 , 8740.513 , 18.14194 , "None"));
HotSpots.Add(new Vector3(8.060912 , 8575.42 , 22.22745 , "None"));
HotSpots.Add(new Vector3(-123.4694 , 8708.32 , 19.97778 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 66 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(60) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6466TerekkorBleedingHollowRuinsNoPVP : QuestGrinderClass
{
    public KILL6466TerekkorBleedingHollowRuinsNoPVP()
    {
        Name = "KILL: 64-66 - Terekkor - Bleeding Hollow Ruins No PVP";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18460);
EntryTarget.Add(22100);
EntryTarget.Add(21324);
EntryTarget.Add(18467);
EntryTarget.Add(18465);
EntryTarget.Add(18260);
EntryTarget.Add(17130);
EntryTarget.Add(18334);
EntryTarget.Add(18205);
EntryTarget.Add(17158);
HotSpots.Add(new Vector3(-3294.497 , 5434.828 , -15.91135 , "None"));
HotSpots.Add(new Vector3(-3289.42 , 5781.114 , 1.622691 , "None"));
HotSpots.Add(new Vector3(-3370.439 , 5739.179 , 4.396402 , "None"));
HotSpots.Add(new Vector3(-3440.482 , 5814.744 , -0.8338809 , "None"));
HotSpots.Add(new Vector3(-3436.513 , 5925.812 , -32.09296 , "None"));
HotSpots.Add(new Vector3(-3394.425 , 5985.392 , -11.46185 , "None"));
HotSpots.Add(new Vector3(-3478.116 , 6068.95 , -16.51618 , "None"));
HotSpots.Add(new Vector3(-3399.069 , 6171.855 , 2.012349 , "None"));
HotSpots.Add(new Vector3(-3491.283 , 6186.506 , 1.249874 , "None"));
HotSpots.Add(new Vector3(-3532.602 , 6182.683 , 3.279918 , "None"));
HotSpots.Add(new Vector3(-3589.075 , 6083.995 , -8.588576 , "None"));
HotSpots.Add(new Vector3(-3729.251 , 6027.216 , 1.108088 , "None"));
HotSpots.Add(new Vector3(-3773.662 , 5893.509 , -6.330526 , "None"));
HotSpots.Add(new Vector3(-3812.103 , 5964.2 , -12.88554 , "None"));
HotSpots.Add(new Vector3(-3475.796 , 6068.308 , -16.46408 , "None"));
HotSpots.Add(new Vector3(-3389.991 , 5803.714 , -1.452502 , "None"));
HotSpots.Add(new Vector3(-2797.79 , 6173.791 , 5.655852 , "None"));
HotSpots.Add(new Vector3(-2729.742 , 6188.451 , 6.920348 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 66 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(60) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6466Nagrand1NearzangermarshEntrance : QuestGrinderClass
{
    public KILL6466Nagrand1NearzangermarshEntrance()
    {
        Name = "KILL: 64-66 Nagrand 1 - Near zangermarsh Entrance";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(17129);
EntryTarget.Add(17131);
EntryTarget.Add(18334);
EntryTarget.Add(17159);
EntryTarget.Add(18062);
EntryTarget.Add(17132);
EntryTarget.Add(17128);
EntryTarget.Add(17130);
HotSpots.Add(new Vector3(-723.8324 , 8323.826 , 42.06366 , "None"));
HotSpots.Add(new Vector3(-721.5332 , 8174.598 , 51.41057 , "None"));
HotSpots.Add(new Vector3(-738.931 , 8152.985 , 47.99941 , "None"));
HotSpots.Add(new Vector3(-932.5208 , 7956.721 , 32.04893 , "None"));
HotSpots.Add(new Vector3(-965.7659 , 7752.603 , 32.64421 , "None"));
HotSpots.Add(new Vector3(-1178.51 , 7700.185 , 14.57094 , "None"));
HotSpots.Add(new Vector3(-1448.243 , 7698.5 , -10.42111 , "None"));
HotSpots.Add(new Vector3(-1120.73 , 7414.824 , 33.18435 , "None"));
HotSpots.Add(new Vector3(-1034.631 , 7400.02 , 36.48478 , "None"));
HotSpots.Add(new Vector3(-772.1922 , 7329.619 , 45.40609 , "None"));
HotSpots.Add(new Vector3(-778.1556 , 7437.268 , 53.35557 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 3;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 66 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(40) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6466Nagrand2BeastsMID : QuestGrinderClass
{
    public KILL6466Nagrand2BeastsMID()
    {
        Name = "KILL: 64-66 Nagrand 2 - Beasts MID ";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(17131);
EntryTarget.Add(17132);
EntryTarget.Add(18062);
EntryTarget.Add(17153);
EntryTarget.Add(17159);
EntryTarget.Add(18334);
EntryTarget.Add(17128);
EntryTarget.Add(17158);
EntryTarget.Add(18205);
EntryTarget.Add(17130);
EntryTarget.Add(17156);
HotSpots.Add(new Vector3(-678.8453 , 7472.813 , 69.81113 , "None"));
HotSpots.Add(new Vector3(-741.3002 , 7109.615 , 37.56258 , "None"));
HotSpots.Add(new Vector3(-874.46 , 7310.365 , 33.28214 , "None"));
HotSpots.Add(new Vector3(-1122.517 , 7661.377 , 16.92221 , "None"));
HotSpots.Add(new Vector3(-1332.897 , 7600.023 , 6.710629 , "None"));
HotSpots.Add(new Vector3(-1547.386 , 7393.062 , 0.5502353 , "None"));
HotSpots.Add(new Vector3(-1760.777 , 7539.247 , -7.184579 , "None"));
HotSpots.Add(new Vector3(-1797.252 , 7628.259 , -7.0632 , "None"));
HotSpots.Add(new Vector3(-1873.444 , 7497.788 , -6.929167 , "None"));
HotSpots.Add(new Vector3(-2021.454 , 7367.201 , -32.3783 , "None"));
HotSpots.Add(new Vector3(-1652.166 , 7427.769 , -3.040856 , "None"));
HotSpots.Add(new Vector3(-1549.906 , 7169.875 , 9.693759 , "None"));
HotSpots.Add(new Vector3(-1519.35 , 7051.721 , 8.882936 , "None"));
HotSpots.Add(new Vector3(-1474.839 , 6883.694 , 0.5063331 , "None"));
HotSpots.Add(new Vector3(-1335.888 , 6605.258 , 47.84785 , "None"));
HotSpots.Add(new Vector3(-1323.655 , 6344.5 , 37.19637 , "None"));
HotSpots.Add(new Vector3(-1343.32 , 6275.577 , 49.74498 , "None"));
HotSpots.Add(new Vector3(-1609.649 , 6253.304 , 70.58215 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 4;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 66 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(40) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6466Nagrand3MiddleEast : QuestGrinderClass
{
    public KILL6466Nagrand3MiddleEast()
    {
        Name = "KILL: 64-66 Nagrand 3 - Middle East ";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(17130);
EntryTarget.Add(17158);
EntryTarget.Add(17156);
EntryTarget.Add(18205);
EntryTarget.Add(17128);
EntryTarget.Add(18964);
EntryTarget.Add(18226);
EntryTarget.Add(18334);
EntryTarget.Add(17141);
EntryTarget.Add(18062);
HotSpots.Add(new Vector3(-1341.411 , 6248.002 , 53.48207 , "None"));
HotSpots.Add(new Vector3(-1634.864 , 6266.085 , 67.55081 , "None"));
HotSpots.Add(new Vector3(-1652.408 , 6581.338 , 5.889861 , "None"));
HotSpots.Add(new Vector3(-1742.488 , 6850.307 , -27.89197 , "None"));
HotSpots.Add(new Vector3(-1866.653 , 6720.386 , -63.07006 , "None"));
HotSpots.Add(new Vector3(-1887.05 , 6621.328 , -1.602839 , "None"));
HotSpots.Add(new Vector3(-1849.312 , 6451.437 , 27.02019 , "None"));
HotSpots.Add(new Vector3(-1634.412 , 6372.751 , 31.82795 , "None"));
HotSpots.Add(new Vector3(-1746.663 , 6294.288 , 51.17473 , "None"));
HotSpots.Add(new Vector3(-1802.086 , 6377.562 , 42.77927 , "None"));
HotSpots.Add(new Vector3(-1933.286 , 6450.718 , 27.0438 , "None"));
HotSpots.Add(new Vector3(-2051.507 , 6348.524 , 44.99535 , "None"));
HotSpots.Add(new Vector3(-2161.633 , 6347.844 , 45.5179 , "None"));
HotSpots.Add(new Vector3(-2156.233 , 6212.263 , 74.82628 , "None"));
HotSpots.Add(new Vector3(-2328.77 , 6332.416 , 29.21815 , "None"));
HotSpots.Add(new Vector3(-2227.193 , 6628.653 , -1.390667 , "None"));
HotSpots.Add(new Vector3(-2196.567 , 6842.191 , -8.280811 , "None"));
HotSpots.Add(new Vector3(-2345.557 , 6970.5 , -3.433485 , "None"));
HotSpots.Add(new Vector3(-1943.19 , 7175.357 , -99.90385 , "None"));
HotSpots.Add(new Vector3(-1975.799 , 6939.667 , -86.71469 , "None"));
HotSpots.Add(new Vector3(-1797.617 , 6642.869 , -15.93443 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 5;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 66 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(40) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6466Nagrand4SouthEasternArea : QuestGrinderClass
{
    public KILL6466Nagrand4SouthEasternArea()
    {
        Name = "KILL: 64-66 Nagrand 4 - SouthEastern Area";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(17159);
EntryTarget.Add(17132);
EntryTarget.Add(17131);
EntryTarget.Add(18205);
EntryTarget.Add(17158);
EntryTarget.Add(18352);
EntryTarget.Add(18334);
EntryTarget.Add(18964);
EntryTarget.Add(17130);
EntryTarget.Add(18226);
EntryTarget.Add(18062);
EntryTarget.Add(17157);
EntryTarget.Add(19183);
EntryTarget.Add(17133);
EntryTarget.Add(17981);
HotSpots.Add(new Vector3(-2215.456 , 6912.327 , -7.159867 , "None"));
HotSpots.Add(new Vector3(-2551.855 , 6968.654 , -0.587715 , "None"));
HotSpots.Add(new Vector3(-2668.59 , 6876.311 , -4.014941 , "None"));
HotSpots.Add(new Vector3(-2461.188 , 6573.569 , 6.164535 , "None"));
HotSpots.Add(new Vector3(-2239.954 , 6614.192 , -1.461459 , "None"));
HotSpots.Add(new Vector3(-2151.213 , 6276.978 , 58.63003 , "None"));
HotSpots.Add(new Vector3(-2534.719 , 6483.225 , 17.33194 , "None"));
HotSpots.Add(new Vector3(-2794.229 , 6689.676 , 15.97935 , "None"));
HotSpots.Add(new Vector3(-2772.79 , 6906.556 , -18.2713 , "None"));
HotSpots.Add(new Vector3(-2864.411 , 6818.858 , -32.23882 , "None"));
HotSpots.Add(new Vector3(-2870.158 , 6931.987 , -32.04341 , "None"));
HotSpots.Add(new Vector3(-2923.77 , 7011.515 , -38.54554 , "None"));
HotSpots.Add(new Vector3(-2858.905 , 7070.371 , -15.32558 , "None"));
HotSpots.Add(new Vector3(-2954.924 , 7265.524 , 2.413652 , "None"));
HotSpots.Add(new Vector3(-2980.802 , 7496.658 , -2.285167 , "None"));
HotSpots.Add(new Vector3(-2972.527 , 7605.839 , 22.08012 , "None"));
HotSpots.Add(new Vector3(-2785.204 , 7684.589 , -10.43062 , "None"));
HotSpots.Add(new Vector3(-2785.102 , 7505.936 , 1.127801 , "None"));
HotSpots.Add(new Vector3(-2843.952 , 7967.888 , -24.81566 , "None"));
HotSpots.Add(new Vector3(-2862.78 , 8065.523 , -29.76695 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 6;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 66 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(40) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6466Nagrand5ByZangerEntHUGEPATH : QuestGrinderClass
{
    public KILL6466Nagrand5ByZangerEntHUGEPATH()
    {
        Name = "KILL: 64-66 Nagrand 5 - By Zanger Ent - HUGE PATH";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18684);
EntryTarget.Add(17160);
EntryTarget.Add(18065);
EntryTarget.Add(18037);
EntryTarget.Add(18334);
EntryTarget.Add(17129);
EntryTarget.Add(17133);
EntryTarget.Add(18062);
EntryTarget.Add(17154);
EntryTarget.Add(17159);
EntryTarget.Add(17132);
EntryTarget.Add(17131);
EntryTarget.Add(17153);
EntryTarget.Add(17128);
EntryTarget.Add(18205);
EntryTarget.Add(17158);
EntryTarget.Add(17130);
EntryTarget.Add(17156);
HotSpots.Add(new Vector3(-1081.888 , 8898.04 , 101.8076 , "None"));
HotSpots.Add(new Vector3(-1211.698 , 8689.474 , 38.64587 , "None"));
HotSpots.Add(new Vector3(-922.9441 , 8485.392 , 41.49332 , "None"));
HotSpots.Add(new Vector3(-1240.727 , 8233.302 , 4.819708 , "None"));
HotSpots.Add(new Vector3(-1350.28 , 8085.051 , -98.75876 , "None"));
HotSpots.Add(new Vector3(-1525.01 , 7804.539 , -99.7797 , "None"));
HotSpots.Add(new Vector3(-1371.372 , 7648.853 , -1.880079 , "None"));
HotSpots.Add(new Vector3(-1547.283 , 7576.177 , -5.287403 , "None"));
HotSpots.Add(new Vector3(-1374.592 , 7453.988 , 10.17233 , "None"));
HotSpots.Add(new Vector3(-1290.979 , 7543.972 , 11.32165 , "None"));
HotSpots.Add(new Vector3(-778.6214 , 7228.436 , 38.3416 , "None"));
HotSpots.Add(new Vector3(-1076.526 , 7412.045 , 34.36902 , "None"));
HotSpots.Add(new Vector3(-1327.928 , 7529.513 , 8.978733 , "None"));
HotSpots.Add(new Vector3(-1434.044 , 7668.368 , -7.85165 , "None"));
HotSpots.Add(new Vector3(-1507.234 , 7585.264 , -4.005242 , "None"));
HotSpots.Add(new Vector3(-1716.291 , 7661.52 , -13.90626 , "None"));
HotSpots.Add(new Vector3(-1632.955 , 7546.368 , -6.801902 , "None"));
HotSpots.Add(new Vector3(-1495.695 , 7433.784 , 2.881727 , "None"));
HotSpots.Add(new Vector3(-1369.239 , 7459.835 , 10.60782 , "None"));
HotSpots.Add(new Vector3(-1575.844 , 7140.458 , 11.11475 , "None"));
HotSpots.Add(new Vector3(-1644.364 , 7153.934 , 3.995379 , "None"));
HotSpots.Add(new Vector3(-1830.934 , 6959.666 , -45.72052 , "None"));
HotSpots.Add(new Vector3(-1963.276 , 7002.037 , -88.13686 , "None"));
HotSpots.Add(new Vector3(-2303.757 , 7081.827 , -20.05902 , "None"));
HotSpots.Add(new Vector3(-2173.557 , 7088.142 , -11.12987 , "None"));
HotSpots.Add(new Vector3(-2055.618 , 7112.718 , -2.339151 , "None"));
HotSpots.Add(new Vector3(-2109.771 , 6905.422 , -14.51257 , "None"));
HotSpots.Add(new Vector3(-2171.962 , 6304.759 , 50.51089 , "None"));
HotSpots.Add(new Vector3(-1742.099 , 6702.495 , -19.56774 , "Flying"));
HotSpots.Add(new Vector3(-1313.585 , 6646.696 , 49.13794 , "None"));
HotSpots.Add(new Vector3(-1600.413 , 6899.086 , -13.30758 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 7;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 66 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(40) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6466Nagrand6AroundAllianceHubNOPVP : QuestGrinderClass
{
    public KILL6466Nagrand6AroundAllianceHubNOPVP()
    {
        Name = "KILL: 64-66 Nagrand 6 - Around Alliance Hub (NO PVP)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(17158);
EntryTarget.Add(18205);
EntryTarget.Add(17130);
EntryTarget.Add(17156);
EntryTarget.Add(18352);
EntryTarget.Add(18334);
EntryTarget.Add(17157);
EntryTarget.Add(17131);
EntryTarget.Add(17159);
EntryTarget.Add(17132);
EntryTarget.Add(18062);
EntryTarget.Add(19183);
EntryTarget.Add(17981);
EntryTarget.Add(17150);
EntryTarget.Add(17149);
EntryTarget.Add(17133);
EntryTarget.Add(18289);
EntryTarget.Add(18220);
HotSpots.Add(new Vector3(-2302.591 , 6944.643 , -4.24792 , "None"));
HotSpots.Add(new Vector3(-2446.229 , 7157.145 , -17.56361 , "None"));
HotSpots.Add(new Vector3(-2578.304 , 6943.639 , -0.7580303 , "None"));
HotSpots.Add(new Vector3(-2702.622 , 6879.687 , -3.645411 , "None"));
HotSpots.Add(new Vector3(-2608.457 , 6689.521 , -0.3336427 , "None"));
HotSpots.Add(new Vector3(-2588.966 , 6565.539 , 11.30998 , "None"));
HotSpots.Add(new Vector3(-2800.657 , 6909.782 , -25.3108 , "None"));
HotSpots.Add(new Vector3(-2867.697 , 6848.003 , -32.2146 , "None"));
HotSpots.Add(new Vector3(-2814.064 , 6956.889 , -23.38871 , "None"));
HotSpots.Add(new Vector3(-2841.913 , 7072.596 , -12.17558 , "None"));
HotSpots.Add(new Vector3(-2807.543 , 7109.391 , -10.44185 , "None"));
HotSpots.Add(new Vector3(-2545.485 , 7051.541 , -7.367261 , "None"));
HotSpots.Add(new Vector3(-2934.317 , 7259.748 , -0.2110921 , "None"));
HotSpots.Add(new Vector3(-2910.03 , 7432.025 , 6.850562 , "None"));
HotSpots.Add(new Vector3(-2824.817 , 7591.329 , -1.336783 , "None"));
HotSpots.Add(new Vector3(-2812.491 , 7717.733 , -9.389858 , "None"));
HotSpots.Add(new Vector3(-2678.708 , 7579.039 , 27.16623 , "None"));
HotSpots.Add(new Vector3(-2495.996 , 7496.081 , -4.818889 , "None"));
HotSpots.Add(new Vector3(-2483.527 , 7783.303 , -36.94178 , "None"));
HotSpots.Add(new Vector3(-2518.218 , 7891.021 , -54.57764 , "None"));
HotSpots.Add(new Vector3(-2780.469 , 7985.26 , -37.87816 , "None"));
HotSpots.Add(new Vector3(-2732.469 , 8169.291 , -45.91467 , "None"));
HotSpots.Add(new Vector3(-3007.967 , 8021.236 , -12.59737 , "None"));
HotSpots.Add(new Vector3(-2898.844 , 8350.413 , -31.02738 , "None"));
HotSpots.Add(new Vector3(-2758.861 , 8219.411 , -46.51452 , "None"));
HotSpots.Add(new Vector3(-2867.586 , 8010.192 , -25.39436 , "None"));
HotSpots.Add(new Vector3(-2779.094 , 7903.249 , -36.19845 , "None"));
HotSpots.Add(new Vector3(-2691.67 , 7753.646 , -29.81951 , "None"));
HotSpots.Add(new Vector3(-2448.697 , 7733.436 , -21.912 , "None"));
HotSpots.Add(new Vector3(-2322.693 , 7708.619 , -18.89385 , "None"));
HotSpots.Add(new Vector3(-2363.427 , 7591.407 , -6.271429 , "None"));
HotSpots.Add(new Vector3(-2380.778 , 7406.474 , -164.0154 , "None"));
HotSpots.Add(new Vector3(-2335.506 , 7067.517 , -15.42194 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 8;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 66 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(40) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class CantStayAway : QuestClass
{
    public CantStayAway()
    {
        Name = "Can't Stay Away";

        QuestId.AddRange(new[] { 10180 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MagicalDisturbances : QuestGrinderClass
{
    public MagicalDisturbances()
    {
        Name = "Magical Disturbances";

        QuestId.AddRange(new[] { 10026 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18464);
EntryTarget.Add(18477);
HotSpots.Add(new Vector3(-2803.733 , 3908.914 , -9.079843 , "None"));
HotSpots.Add(new Vector3(-2409.289 , 3915.785 , 9.768567 , "None"));
HotSpots.Add(new Vector3(-2343.799 , 4104.54 , -11.98068 , "None"));
HotSpots.Add(new Vector3(-2205.208 , 4046.583 , -3.360949 , "None"));
HotSpots.Add(new Vector3(-2428.655 , 3976.95 , -1.088504 , "None"));
HotSpots.Add(new Vector3(-2332.822 , 4117.263 , -15.0043 , "None"));
HotSpots.Add(new Vector3(-2269.174 , 4090.56 , -17.8199 , "None"));
HotSpots.Add(new Vector3(-2299.425 , 3932.255 , -5.576102 , "None"));
HotSpots.Add(new Vector3(-2105.736 , 3837.362 , -0.9400488 , "None"));
HotSpots.Add(new Vector3(-2141.407 , 3609.729 , -50.71296 , "None"));
HotSpots.Add(new Vector3(-2179.619 , 3364.435 , -33.62867 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNRuntoFPinAllerianhold : QuestFollowPathClass
{
    public RUNRuntoFPinAllerianhold()
    {
        Name = "RUN: Run to FP in Allerian hold";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2931.324 , 4012.056 , -1.389993 , "None"));
Path.Add(new Vector3(-2936.153 , 4007.296 , -1.162817 , "None"));
Path.Add(new Vector3(-2943.446 , 4000.899 , -0.9128144 , "None"));
Path.Add(new Vector3(-2948.983 , 3991.215 , -0.4729443 , "None"));
Path.Add(new Vector3(-2949.319 , 3981.186 , -0.08123087 , "None"));
Path.Add(new Vector3(-2947.041 , 3970.035 , -0.2195506 , "None"));
Path.Add(new Vector3(-2946.605 , 3959.642 , 0.1173806 , "None"));
Path.Add(new Vector3(-2949.166 , 3949.513 , 0.962388 , "None"));
Path.Add(new Vector3(-2949.561 , 3939.059 , 1.446012 , "None"));
Path.Add(new Vector3(-2949.268 , 3928.227 , 1.669396 , "None"));
Path.Add(new Vector3(-2949.236 , 3918.025 , 1.823972 , "None"));
Path.Add(new Vector3(-2949.858 , 3907.502 , 2.58496 , "None"));
Path.Add(new Vector3(-2951.653 , 3896.656 , 5.013993 , "None"));
Path.Add(new Vector3(-2954.93 , 3886.749 , 6.574456 , "None"));
Path.Add(new Vector3(-2958.731 , 3876.781 , 6.039906 , "None"));
Path.Add(new Vector3(-2962.713 , 3866.853 , 4.058697 , "None"));
Path.Add(new Vector3(-2969.094 , 3859.503 , 5.292649 , "None"));
Path.Add(new Vector3(-2979.716 , 3858.668 , 7.083436 , "None"));
Path.Add(new Vector3(-2987.118 , 3866.597 , 8.588447 , "None"));
Path.Add(new Vector3(-2994.605 , 3874.241 , 9.539501 , "None"));
Path.Add(new Vector3(-2994.605 , 3874.241 , 9.539501 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class UnrulyNeighbors : QuestGrinderClass
{
    public UnrulyNeighbors()
    {
        Name = "Unruly Neighbors";

        QuestId.AddRange(new[] { 9998 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18595);
HotSpots.Add(new Vector3(-2877.736 , 3644.646 , -20.61647 , "None"));
HotSpots.Add(new Vector3(-2855.928 , 3594.774 , -17.04217 , "None"));
HotSpots.Add(new Vector3(-2847.439 , 3539.996 , -30.60438 , "None"));
HotSpots.Add(new Vector3(-2844.664 , 3488.263 , -35.94604 , "None"));
HotSpots.Add(new Vector3(-2827.144 , 3446.747 , -39.1846 , "None"));
HotSpots.Add(new Vector3(-2867.783 , 3409.515 , -33.95346 , "None"));
HotSpots.Add(new Vector3(-2945.413 , 3333.574 , 3.41891 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TimberWorgTails : QuestGrinderClass
{
    public TimberWorgTails()
    {
        Name = "Timber Worg Tails";

        QuestId.AddRange(new[] { 10016 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18477);
HotSpots.Add(new Vector3(-2482.766 , 3763.636 , 1.138674 , "None"));
HotSpots.Add(new Vector3(-2766.742 , 3771.745 , -0.09095661 , "None"));
HotSpots.Add(new Vector3(-2797.695 , 3882.184 , -5.399399 , "None"));
HotSpots.Add(new Vector3(-2513.813 , 4049.606 , -2.058696 , "None"));
HotSpots.Add(new Vector3(-2304.283 , 4079.884 , -23.36548 , "None"));
HotSpots.Add(new Vector3(-2222.26 , 3797.453 , -6.446767 , "None"));
HotSpots.Add(new Vector3(-2219.259 , 3559.551 , -27.27419 , "None"));
HotSpots.Add(new Vector3(-2179.619 , 3364.435 , -33.62867 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WhatsWrongatCenarionThicket : QuestClass
{
    public WhatsWrongatCenarionThicket()
    {
        Name = "What's Wrong at Cenarion Thicket?";

        QuestId.AddRange(new[] { 9961 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WANTEDBonelashersDead : QuestGrinderClass
{
    public WANTEDBonelashersDead()
    {
        Name = "WANTED: Bonelashers Dead!";

        QuestId.AddRange(new[] { 10033 });

        Step = new List<int> { 20, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18470);
HotSpots.Add(new Vector3(-3183.049 , 4538.021 , -21.96383 , "None"));
HotSpots.Add(new Vector3(-3053.962 , 4638.373 , -21.26623 , "None"));
HotSpots.Add(new Vector3(-2877.521 , 4704.511 , -11.12925 , "None"));
HotSpots.Add(new Vector3(-2811.83 , 4816.802 , -11.70288 , "None"));
HotSpots.Add(new Vector3(-2870.666 , 4968.413 , -20.27973 , "None"));
HotSpots.Add(new Vector3(-2922.729 , 5168.878 , -16.73995 , "None"));
HotSpots.Add(new Vector3(-3084.828 , 5227.968 , -22.43013 , "None"));
HotSpots.Add(new Vector3(-2879.486 , 4968.967 , -20.37921 , "None"));
HotSpots.Add(new Vector3(-2894.326 , 4801.383 , -9.099444 , "None"));
HotSpots.Add(new Vector3(-2862.501 , 4681.173 , -16.16453 , "None"));
HotSpots.Add(new Vector3(-3075.664 , 4672.221 , -20.81589 , "None"));
HotSpots.Add(new Vector3(-3536.966 , 4525.621 , -20.19054 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class OlembaSeeds : QuestGathererClass
{
    public OlembaSeeds()
    {
        Name = "Olemba Seeds";

        QuestId.AddRange(new[] { 9992 });

        Step = new List<int> { 30, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(182541);
HotSpots.Add(new Vector3(-2748.652 , 3890.594 , -16.45005 , "None"));
HotSpots.Add(new Vector3(-2600.522 , 3843.92 , -4.05662 , "None"));
HotSpots.Add(new Vector3(-2545.213 , 3944.58 , 11.26384 , "None"));
HotSpots.Add(new Vector3(-2654.272 , 4015.373 , 5.985569 , "None"));
HotSpots.Add(new Vector3(-2475.225 , 4163.638 , 1.561884 , "None"));
HotSpots.Add(new Vector3(-2383.575 , 4180.069 , 2.232816 , "None"));
HotSpots.Add(new Vector3(-2361.452 , 4338.517 , 0.7684872 , "None"));
HotSpots.Add(new Vector3(-2320.687 , 4387.492 , 2.788373 , "None"));
HotSpots.Add(new Vector3(-2189.931 , 4433.184 , 1.491849 , "None"));
HotSpots.Add(new Vector3(-2102.334 , 4465.974 , 1.518742 , "None"));
HotSpots.Add(new Vector3(-2141.945 , 4568.734 , -2.882887 , "None"));
HotSpots.Add(new Vector3(-2122.312 , 4655.711 , -7.95895 , "None"));
HotSpots.Add(new Vector3(-2171.074 , 4572.355 , -3.018661 , "None"));
HotSpots.Add(new Vector3(-2225.643 , 4598.077 , 0.1433058 , "None"));
HotSpots.Add(new Vector3(-2253.013 , 4667.521 , 0.5663465 , "None"));
HotSpots.Add(new Vector3(-2261.374 , 4754.679 , -1.786225 , "None"));
HotSpots.Add(new Vector3(-2172.067 , 4861.503 , -3.905853 , "None"));
HotSpots.Add(new Vector3(-2249.161 , 4992.694 , -0.7156664 , "None"));
HotSpots.Add(new Vector3(-2351.984 , 5202.502 , -2.029757 , "None"));
HotSpots.Add(new Vector3(-2543.214 , 5158.548 , 9.588622 , "None"));
HotSpots.Add(new Vector3(-2171.425 , 4573.921 , -3.045465 , "None"));
HotSpots.Add(new Vector3(-2187.391 , 4384.812 , 1.018705 , "None"));
HotSpots.Add(new Vector3(-2220.531 , 4089.007 , -1.22954 , "None"));
HotSpots.Add(new Vector3(-2243.202 , 4007.202 , -23.90128 , "None"));
HotSpots.Add(new Vector3(-2037.34 , 4016.109 , 1.778171 , "None"));
HotSpots.Add(new Vector3(-2015.077 , 3894.262 , 1.571291 , "None"));
HotSpots.Add(new Vector3(-2220.936 , 3371.293 , -21.08972 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThintheFlock : QuestGrinderClass
{
    public ThintheFlock()
    {
        Name = "Thin the Flock";

        QuestId.AddRange(new[] { 10869 });

        Step = new List<int> { 14, 6, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18450);
EntryTarget.Add(18540);
EntryTarget.Add(18449);
EntryTarget.Add(18539);
EntryTarget.Add(18451);
HotSpots.Add(new Vector3(-1974.228 , 3929.097 , 0.8908179 , "None"));
HotSpots.Add(new Vector3(-1855.87 , 3879.817 , 5.665362 , "None"));
HotSpots.Add(new Vector3(-1903.095 , 4008.608 , -0.1425902 , "None"));
HotSpots.Add(new Vector3(-1708.048 , 4407.327 , 14.44625 , "None"));
HotSpots.Add(new Vector3(-1611.195 , 4410.205 , 52.64721 , "None"));
HotSpots.Add(new Vector3(-1647.005 , 4333.546 , 35.53437 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SpeakwithPrivateWeeks : QuestClass
{
    public SpeakwithPrivateWeeks()
    {
        Name = "Speak with Private Weeks";

        QuestId.AddRange(new[] { 10038 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheFirewingLiaison : QuestGrinderClass
{
    public TheFirewingLiaison()
    {
        Name = "The Firewing Liaison";

        QuestId.AddRange(new[] { 10002 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9998;

        EntryTarget.Add(18583);
HotSpots.Add(new Vector3(-2918.558 , 3427.533 , 0.9492529 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThinningtheRanks : QuestGrinderClass
{
    public ThinningtheRanks()
    {
        Name = "Thinning the Ranks";

        QuestId.AddRange(new[] { 10007 });

        Step = new List<int> { 10, 6, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9998;

        EntryTarget.Add(16772);
EntryTarget.Add(16810);
EntryTarget.Add(18595);
EntryTarget.Add(18583);
HotSpots.Add(new Vector3(-2843.148 , 3505.102 , -34.91529 , "None"));
HotSpots.Add(new Vector3(-2927.648 , 3526.931 , -19.30598 , "None"));
HotSpots.Add(new Vector3(-2971.267 , 3541.691 , -7.238 , "None"));
HotSpots.Add(new Vector3(-2918.558 , 3427.533 , 0.9492529 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class FelOrcPlans : QuestClass
{
    public FelOrcPlans()
    {
        Name = "Fel Orc Plans";

        QuestId.AddRange(new[] { 10012 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNRunoutFelOrcplans : QuestFollowPathClass
{
    public RUNRunoutFelOrcplans()
    {
        Name = "RUN: Run out Fel Orc plans";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2945.01 , 3445.616 , 1.892609 , "None"));
Path.Add(new Vector3(-2949.109 , 3449.919 , 1.249454 , "None"));
Path.Add(new Vector3(-2954.915 , 3456.218 , 1.470569 , "None"));
Path.Add(new Vector3(-2957.461 , 3460.636 , 1.884371 , "None"));
Path.Add(new Vector3(-2960.347 , 3464.163 , 0.6618634 , "None"));
Path.Add(new Vector3(-2963.716 , 3463.045 , 0.6068377 , "None"));
Path.Add(new Vector3(-2962.222 , 3480.281 , -1.125206 , "None"));
Path.Add(new Vector3(-2956.756 , 3482.158 , -1.25408 , "None"));
Path.Add(new Vector3(-2953.082 , 3482.55 , -1.081792 , "None"));
Path.Add(new Vector3(-2946.172 , 3483.746 , -0.7192969 , "None"));
Path.Add(new Vector3(-2941.612 , 3484.137 , -0.4323797 , "None"));
Path.Add(new Vector3(-2936.783 , 3480.406 , 0.1320666 , "None"));
Path.Add(new Vector3(-2927.387 , 3473.46 , 0.2283006 , "None"));
Path.Add(new Vector3(-2917.048 , 3469.016 , 0.2283006 , "None"));
Path.Add(new Vector3(-2909.868 , 3465.9 , 0.3408441 , "None"));
Path.Add(new Vector3(-2906.766 , 3463.529 , 0.6835377 , "None"));
Path.Add(new Vector3(-2905.585 , 3456.573 , 0.2292739 , "None"));
Path.Add(new Vector3(-2901.366 , 3446.363 , 0.2394305 , "None"));
Path.Add(new Vector3(-2897.921 , 3439.48 , 0.2371052 , "None"));
Path.Add(new Vector3(-2887.789 , 3435.033 , 0.3048564 , "None"));
Path.Add(new Vector3(-2885.114 , 3432.2 , 0.480669 , "None"));
Path.Add(new Vector3(-2884.69 , 3428.403 , 0.55998 , "None"));
Path.Add(new Vector3(-2885.501 , 3424.328 , 0.6602861 , "None"));
Path.Add(new Vector3(-2888.046 , 3417.354 , 0.5654816 , "None"));
Path.Add(new Vector3(-2895.151 , 3411.563 , 0.4767179 , "None"));
Path.Add(new Vector3(-2903.496 , 3404.585 , 0.3456908 , "None"));
Path.Add(new Vector3(-2911.597 , 3397.68 , 0.2340785 , "None"));
Path.Add(new Vector3(-2915.802 , 3393.048 , 0.2309729 , "None"));
Path.Add(new Vector3(-2921.213 , 3386.361 , 0.1983999 , "None"));
Path.Add(new Vector3(-2923.438 , 3383.206 , 0.184541 , "None"));
Path.Add(new Vector3(-2925.607 , 3378.694 , 0.228721 , "None"));
Path.Add(new Vector3(-2925.987 , 3373.708 , 0.0269971 , "None"));
Path.Add(new Vector3(-2927.424 , 3368.579 , -2.325422 , "None"));
Path.Add(new Vector3(-2926.7 , 3363.753 , -3.745679 , "None"));
Path.Add(new Vector3(-2922.736 , 3364.855 , -5.36991 , "None"));
Path.Add(new Vector3(-2911.482 , 3362.861 , -8.632397 , "None"));
Path.Add(new Vector3(-2902.023 , 3357.462 , -11.12597 , "None"));
Path.Add(new Vector3(-2896.23 , 3353.301 , -12.75721 , "None"));
Path.Add(new Vector3(-2892.699 , 3349.055 , -13.05595 , "None"));
Path.Add(new Vector3(-2887.488 , 3339.544 , -11.91435 , "None"));
Path.Add(new Vector3(-2884.565 , 3336.646 , -12.20949 , "None"));
Path.Add(new Vector3(-2881.402 , 3335.051 , -12.77822 , "None"));
Path.Add(new Vector3(-2877.678 , 3332.534 , -12.9807 , "None"));
Path.Add(new Vector3(-2868.869 , 3326.58 , -12.71338 , "None"));
Path.Add(new Vector3(-2862.415 , 3322.604 , -13.15276 , "None"));
Path.Add(new Vector3(-2853.284 , 3317.257 , -13.2044 , "None"));
Path.Add(new Vector3(-2840.698 , 3308.203 , -8.773292 , "None"));
Path.Add(new Vector3(-2833.117 , 3300.754 , -5.210055 , "None"));
Path.Add(new Vector3(-2824.894 , 3294.209 , -4.443603 , "None"));
Path.Add(new Vector3(-2815.745 , 3288.482 , -2.975997 , "None"));
Path.Add(new Vector3(-2806.961 , 3283.076 , 2.834361 , "None"));
Path.Add(new Vector3(-2797.378 , 3277.91 , 5.487445 , "None"));
Path.Add(new Vector3(-2787.563 , 3273.785 , 4.833101 , "None"));
Path.Add(new Vector3(-2769.47 , 3272.663 , 3.77638 , "None"));
Path.Add(new Vector3(-2760.822 , 3282.225 , 2.122519 , "None"));
Path.Add(new Vector3(-2750.649 , 3281.51 , 2.704785 , "None"));
Path.Add(new Vector3(-2741.054 , 3278.49 , 1.756879 , "None"));
Path.Add(new Vector3(-2732.001 , 3277.134 , -0.4939081 , "None"));
Path.Add(new Vector3(-2718.4 , 3276.589 , -1.79231 , "None"));
Path.Add(new Vector3(-2711.16 , 3282.952 , -2.015125 , "None"));
Path.Add(new Vector3(-2703.348 , 3290.309 , -0.8785461 , "None"));
Path.Add(new Vector3(-2695.229 , 3296.281 , 1.182263 , "None"));
Path.Add(new Vector3(-2685.255 , 3300.474 , 2.138949 , "None"));
Path.Add(new Vector3(-2676.403 , 3306.938 , 1.795034 , "None"));
Path.Add(new Vector3(-2668.186 , 3312.849 , 0.4659138 , "None"));
Path.Add(new Vector3(-2659.213 , 3319.254 , 1.471366 , "None"));
Path.Add(new Vector3(-2649.64 , 3323.991 , 1.194422 , "None"));
Path.Add(new Vector3(-2639.453 , 3323.119 , 1.335735 , "None"));
Path.Add(new Vector3(-2629.022 , 3321.923 , 1.742534 , "None"));
Path.Add(new Vector3(-2618.303 , 3322.253 , 1.380532 , "None"));
Path.Add(new Vector3(-2607.51 , 3322.125 , 0.8651866 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class StymyingtheArakkoa : QuestGrinderClass
{
    public StymyingtheArakkoa()
    {
        Name = "Stymying the Arakkoa";

        QuestId.AddRange(new[] { 9986 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18541);
HotSpots.Add(new Vector3(-2513.741 , 5373.243 , 27.79616 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class StymyingtheArakkoaAshkaz : QuestGrinderClass
{
    public StymyingtheArakkoaAshkaz()
    {
        Name = "Stymying the Arakkoa - Ashkaz";

        QuestId.AddRange(new[] { 9986 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18539);
HotSpots.Add(new Vector3(-1607.96 , 4431.23 , 52.63023 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class StymyingtheArakkoaAyit : QuestGrinderClass
{
    public StymyingtheArakkoaAyit()
    {
        Name = "Stymying the Arakkoa - Ayit";

        QuestId.AddRange(new[] { 9986 });

        Step = new List<int> { 0, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18540);
HotSpots.Add(new Vector3(-1844.924 , 3875.955 , 6.248853 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNRuntoAyit : QuestFollowPathClass
{
    public RUNRuntoAyit()
    {
        Name = "RUN: Run to Ayit";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2120.652 , 3891.803 , 2.020241 , "None"));
Path.Add(new Vector3(-2112.092 , 3890.348 , 1.28227 , "None"));
Path.Add(new Vector3(-2103.6 , 3885.819 , 0.8657815 , "None"));
Path.Add(new Vector3(-2094.938 , 3883.53 , 1.32462 , "None"));
Path.Add(new Vector3(-2082.181 , 3877.332 , 0.594347 , "None"));
Path.Add(new Vector3(-2064.891 , 3865.152 , -3.061371 , "Swimming"));
Path.Add(new Vector3(-2050.219 , 3853.405 , -3.061371 , "Swimming"));
Path.Add(new Vector3(-2026.198 , 3837.194 , 0.5839207 , "None"));
Path.Add(new Vector3(-2007.137 , 3836.242 , -0.04277648 , "None"));
Path.Add(new Vector3(-1996.645 , 3840.731 , -0.2596208 , "None"));
Path.Add(new Vector3(-1987.59 , 3842.736 , -1.772952 , "None"));
Path.Add(new Vector3(-1968.961 , 3841.307 , 0.3350208 , "None"));
Path.Add(new Vector3(-1957.832 , 3837.25 , 1.018905 , "None"));
Path.Add(new Vector3(-1947.752 , 3831.33 , 2.274368 , "None"));
Path.Add(new Vector3(-1930.745 , 3823.571 , -2.856502 , "None"));
Path.Add(new Vector3(-1907.895 , 3819.169 , -1.565331 , "None"));
Path.Add(new Vector3(-1895.142 , 3817.365 , 4.204846 , "None"));
Path.Add(new Vector3(-1882.022 , 3825.354 , 4.8236 , "None"));
Path.Add(new Vector3(-1873.643 , 3836.57 , 1.93556 , "None"));
Path.Add(new Vector3(-1864.392 , 3851.363 , 1.871643 , "None"));
Path.Add(new Vector3(-1855.085 , 3851.15 , 4.299172 , "None"));
Path.Add(new Vector3(-1861.287 , 3862.438 , 3.339572 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNAshkaz : QuestFollowPathClass
{
    public RUNAshkaz()
    {
        Name = "RUN: Ashkaz ";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-1857.064 , 3882.288 , 5.325051 , "None"));
Path.Add(new Vector3(-1857.928 , 3875.143 , 5.588012 , "None"));
Path.Add(new Vector3(-1860.893 , 3865.431 , 3.840705 , "None"));
Path.Add(new Vector3(-1863.014 , 3854.934 , 2.399381 , "None"));
Path.Add(new Vector3(-1865.013 , 3844.305 , 2.00061 , "None"));
Path.Add(new Vector3(-1866.748 , 3836.806 , 3.495764 , "None"));
Path.Add(new Vector3(-1875.071 , 3829.934 , 4.291872 , "None"));
Path.Add(new Vector3(-1884.288 , 3824.959 , 4.690346 , "None"));
Path.Add(new Vector3(-1894.125 , 3821.325 , 3.940684 , "None"));
Path.Add(new Vector3(-1904.922 , 3820.698 , 0.198013 , "None"));
Path.Add(new Vector3(-1915.438 , 3820.701 , -2.93384 , "None"));
Path.Add(new Vector3(-1925.964 , 3823.152 , -3.054146 , "None"));
Path.Add(new Vector3(-1935.068 , 3828.265 , -0.4003386 , "None"));
Path.Add(new Vector3(-1937.814 , 3838.76 , 2.052308 , "None"));
Path.Add(new Vector3(-1939.604 , 3849.106 , 1.663486 , "None"));
Path.Add(new Vector3(-1942.466 , 3859.569 , -0.01677693 , "None"));
Path.Add(new Vector3(-1946.301 , 3866.395 , 0.6674649 , "None"));
Path.Add(new Vector3(-1948.57 , 3874.491 , 0.6661251 , "None"));
Path.Add(new Vector3(-1949.901 , 3882.423 , 0.4589942 , "None"));
Path.Add(new Vector3(-1952.893 , 3891.584 , -0.4146295 , "None"));
Path.Add(new Vector3(-1954.64 , 3902.108 , -1.661416 , "None"));
Path.Add(new Vector3(-1956.074 , 3912.712 , -1.67479 , "None"));
Path.Add(new Vector3(-1954.9 , 3919.783 , -0.7460978 , "None"));
Path.Add(new Vector3(-1952.481 , 3929.348 , -0.01976596 , "None"));
Path.Add(new Vector3(-1951.902 , 3938.212 , -0.3220657 , "None"));
Path.Add(new Vector3(-1949.532 , 3949.46 , 0.3412954 , "None"));
Path.Add(new Vector3(-1950.415 , 3960.187 , 0.7772284 , "None"));
Path.Add(new Vector3(-1952.779 , 3970.328 , -0.314031 , "None"));
Path.Add(new Vector3(-1956.604 , 3980.495 , -3.58011 , "None"));
Path.Add(new Vector3(-1960.358 , 3990.365 , -3.890828 , "None"));
Path.Add(new Vector3(-1962.724 , 4000.883 , -3.526263 , "None"));
Path.Add(new Vector3(-1962.836 , 4011.316 , -2.222419 , "None"));
Path.Add(new Vector3(-1961.876 , 4021.942 , 1.550421 , "None"));
Path.Add(new Vector3(-1963.81 , 4031.577 , 3.073122 , "None"));
Path.Add(new Vector3(-1964.097 , 4042.325 , 3.531846 , "None"));
Path.Add(new Vector3(-1964.433 , 4052.693 , 2.894337 , "None"));
Path.Add(new Vector3(-1964.234 , 4063.232 , 1.804361 , "None"));
Path.Add(new Vector3(-1966.654 , 4072.506 , 1.19259 , "None"));
Path.Add(new Vector3(-1970.696 , 4082.604 , 0.6694022 , "None"));
Path.Add(new Vector3(-1974.521 , 4092.5 , 2.775339 , "None"));
Path.Add(new Vector3(-1977.206 , 4102.936 , 4.280484 , "None"));
Path.Add(new Vector3(-1976.521 , 4113.546 , 4.146486 , "None"));
Path.Add(new Vector3(-1973.317 , 4123.534 , 3.948868 , "None"));
Path.Add(new Vector3(-1968.022 , 4132.773 , 3.443274 , "None"));
Path.Add(new Vector3(-1960.719 , 4140.347 , 3.854378 , "None"));
Path.Add(new Vector3(-1952.286 , 4147.122 , 5.13602 , "None"));
Path.Add(new Vector3(-1943.288 , 4152.906 , 4.273179 , "None"));
Path.Add(new Vector3(-1933.558 , 4156.793 , 2.0922 , "None"));
Path.Add(new Vector3(-1923.451 , 4160.757 , 0.302606 , "None"));
Path.Add(new Vector3(-1915.27 , 4166.514 , -1.649188 , "None"));
Path.Add(new Vector3(-1908.971 , 4175.354 , -2.743538 , "None"));
Path.Add(new Vector3(-1905.103 , 4185.441 , -0.281842 , "None"));
Path.Add(new Vector3(-1903.218 , 4195.498 , 0.8181745 , "None"));
Path.Add(new Vector3(-1903.217 , 4206.241 , -0.949091 , "None"));
Path.Add(new Vector3(-1903.618 , 4216.881 , 1.351411 , "None"));
Path.Add(new Vector3(-1904.052 , 4227.708 , 1.232583 , "None"));
Path.Add(new Vector3(-1904.667 , 4238.19 , -0.4476792 , "None"));
Path.Add(new Vector3(-1905.379 , 4248.981 , -1.047263 , "None"));
Path.Add(new Vector3(-1905.981 , 4259.586 , 0.6506643 , "None"));
Path.Add(new Vector3(-1905.047 , 4270.116 , 2.665684 , "None"));
Path.Add(new Vector3(-1903.014 , 4279.28 , 3.122979 , "None"));
Path.Add(new Vector3(-1900.736 , 4289.551 , 3.631032 , "None"));
Path.Add(new Vector3(-1898.395 , 4300.11 , 2.882652 , "None"));
Path.Add(new Vector3(-1894.571 , 4310.067 , 2.19561 , "None"));
Path.Add(new Vector3(-1889.593 , 4319.312 , 2.548005 , "None"));
Path.Add(new Vector3(-1887.75 , 4329.817 , 2.211106 , "None"));
Path.Add(new Vector3(-1889.175 , 4340.216 , 0.2154249 , "None"));
Path.Add(new Vector3(-1889.348 , 4350.415 , -1.660991 , "None"));
Path.Add(new Vector3(-1894.097 , 4360.341 , 0.611693 , "None"));
Path.Add(new Vector3(-1897.762 , 4370.439 , 1.940327 , "None"));
Path.Add(new Vector3(-1899.249 , 4380.668 , 2.194076 , "None"));
Path.Add(new Vector3(-1897.05 , 4391.3 , 1.862916 , "None"));
Path.Add(new Vector3(-1893.366 , 4401.05 , 3.027293 , "None"));
Path.Add(new Vector3(-1888.423 , 4410.717 , 3.314562 , "None"));
Path.Add(new Vector3(-1883.642 , 4420.065 , 4.217297 , "None"));
Path.Add(new Vector3(-1878.379 , 4429.114 , 3.141516 , "None"));
Path.Add(new Vector3(-1868.624 , 4430.627 , 2.436726 , "None"));
Path.Add(new Vector3(-1859.715 , 4424.45 , 2.516768 , "None"));
Path.Add(new Vector3(-1849.923 , 4420.969 , 1.482163 , "None"));
Path.Add(new Vector3(-1839.185 , 4419.578 , 1.734089 , "None"));
Path.Add(new Vector3(-1833.973 , 4418.949 , 2.400641 , "None"));
Path.Add(new Vector3(-1823.215 , 4417.651 , 3.175638 , "None"));
Path.Add(new Vector3(-1812.79 , 4416.393 , 1.967861 , "None"));
Path.Add(new Vector3(-1802.605 , 4414.243 , 1.96309 , "None"));
Path.Add(new Vector3(-1792.346 , 4411.864 , 3.843737 , "None"));
Path.Add(new Vector3(-1781.907 , 4412.915 , 5.314841 , "None"));
Path.Add(new Vector3(-1771.795 , 4413.892 , 4.719457 , "None"));
Path.Add(new Vector3(-1766.946 , 4414.51 , 4.428163 , "None"));
Path.Add(new Vector3(-1760.714 , 4414.103 , 3.544273 , "None"));
Path.Add(new Vector3(-1752.272 , 4412.021 , 4.323101 , "None"));
Path.Add(new Vector3(-1746.969 , 4410.061 , 6.013719 , "None"));
Path.Add(new Vector3(-1741.794 , 4408.963 , 7.688437 , "None"));
Path.Add(new Vector3(-1735.972 , 4405.634 , 10.11879 , "None"));
Path.Add(new Vector3(-1732.721 , 4402.471 , 11.67904 , "None"));
Path.Add(new Vector3(-1728.835 , 4392.74 , 14.35353 , "None"));
Path.Add(new Vector3(-1722.19 , 4384.154 , 17.47351 , "None"));
Path.Add(new Vector3(-1718.725 , 4380.209 , 19.90064 , "None"));
Path.Add(new Vector3(-1712.468 , 4373.612 , 22.43296 , "None"));
Path.Add(new Vector3(-1705.199 , 4365.968 , 24.15146 , "None"));
Path.Add(new Vector3(-1700.861 , 4364.15 , 24.31041 , "None"));
Path.Add(new Vector3(-1693.672 , 4362.62 , 23.93641 , "None"));
Path.Add(new Vector3(-1688.846 , 4361.879 , 24.27112 , "None"));
Path.Add(new Vector3(-1680.838 , 4361.383 , 25.22657 , "None"));
Path.Add(new Vector3(-1673.323 , 4359.784 , 26.26484 , "None"));
Path.Add(new Vector3(-1667.599 , 4357.684 , 26.75658 , "None"));
Path.Add(new Vector3(-1659.983 , 4350.504 , 29.16277 , "None"));
Path.Add(new Vector3(-1652.385 , 4342.727 , 32.00133 , "None"));
Path.Add(new Vector3(-1648.05 , 4337.73 , 33.89144 , "None"));
Path.Add(new Vector3(-1644.231 , 4333.231 , 35.11219 , "None"));
Path.Add(new Vector3(-1640.832 , 4330.216 , 35.75134 , "None"));
Path.Add(new Vector3(-1634.405 , 4334.972 , 35.0068 , "None"));
Path.Add(new Vector3(-1629.588 , 4340.156 , 34.43398 , "None"));
Path.Add(new Vector3(-1621.788 , 4349.989 , 34.25795 , "None"));
Path.Add(new Vector3(-1617.533 , 4352.487 , 35.03386 , "None"));
Path.Add(new Vector3(-1616.128 , 4358.628 , 34.24364 , "None"));
Path.Add(new Vector3(-1611.395 , 4362.111 , 34.95147 , "None"));
Path.Add(new Vector3(-1605.907 , 4373.372 , 34.84328 , "None"));
Path.Add(new Vector3(-1599.633 , 4377.78 , 34.73539 , "None"));
Path.Add(new Vector3(-1594.409 , 4381.339 , 34.74447 , "None"));
Path.Add(new Vector3(-1592.437 , 4385.508 , 34.61872 , "None"));
Path.Add(new Vector3(-1592.99 , 4386.376 , 34.54275 , "None"));
Path.Add(new Vector3(-1597.302 , 4392.066 , 35.46922 , "None"));
Path.Add(new Vector3(-1600.621 , 4396.296 , 39.63935 , "None"));
Path.Add(new Vector3(-1603.744 , 4400.089 , 43.87282 , "None"));
Path.Add(new Vector3(-1606.339 , 4403.148 , 47.96546 , "None"));
Path.Add(new Vector3(-1608.47 , 4404.882 , 50.63707 , "None"));
Path.Add(new Vector3(-1609.637 , 4406.744 , 51.74661 , "None"));
Path.Add(new Vector3(-1614.595 , 4408.968 , 52.64497 , "None"));
Path.Add(new Vector3(-1617.547 , 4409.717 , 52.6039 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNURDAKlastmob : QuestFollowPathClass
{
    public RUNURDAKlastmob()
    {
        Name = "RUN: URDAK (last mob)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-1610.177 , 4409.347 , 52.63767 , "None"));
Path.Add(new Vector3(-1603.943 , 4400.872 , 44.61056 , "None"));
Path.Add(new Vector3(-1598.051 , 4391.782 , 35.659 , "None"));
Path.Add(new Vector3(-1594.56 , 4386.159 , 34.43883 , "None"));
Path.Add(new Vector3(-1596.764 , 4379.598 , 34.73918 , "None"));
Path.Add(new Vector3(-1602.82 , 4374.541 , 34.97602 , "None"));
Path.Add(new Vector3(-1610.478 , 4366.555 , 34.67501 , "None"));
Path.Add(new Vector3(-1617.737 , 4359.1 , 33.68538 , "None"));
Path.Add(new Vector3(-1627.04 , 4353.628 , 32.59208 , "None"));
Path.Add(new Vector3(-1635.015 , 4346.917 , 32.55491 , "None"));
Path.Add(new Vector3(-1643.619 , 4340.717 , 33.03174 , "None"));
Path.Add(new Vector3(-1653.354 , 4341.63 , 32.48513 , "None"));
Path.Add(new Vector3(-1660.535 , 4350.047 , 29.24165 , "None"));
Path.Add(new Vector3(-1669.644 , 4355.287 , 27.17385 , "None"));
Path.Add(new Vector3(-1679.695 , 4358.672 , 26.32937 , "None"));
Path.Add(new Vector3(-1689.507 , 4356.532 , 25.94228 , "None"));
Path.Add(new Vector3(-1699.106 , 4360.397 , 25.16804 , "None"));
Path.Add(new Vector3(-1702.056 , 4362.827 , 24.81182 , "None"));
Path.Add(new Vector3(-1713.828 , 4364.59 , 25.17181 , "None"));
Path.Add(new Vector3(-1716.439 , 4367.88 , 24.06362 , "None"));
Path.Add(new Vector3(-1719.564 , 4374.083 , 23.05525 , "None"));
Path.Add(new Vector3(-1720.733 , 4382.36 , 18.55394 , "None"));
Path.Add(new Vector3(-1726.42 , 4391.147 , 15.03198 , "None"));
Path.Add(new Vector3(-1730.779 , 4401.08 , 12.45423 , "None"));
Path.Add(new Vector3(-1733.399 , 4410.845 , 8.649446 , "None"));
Path.Add(new Vector3(-1745.787 , 4413.404 , 4.772293 , "None"));
Path.Add(new Vector3(-1756.629 , 4414.107 , 3.119234 , "None"));
Path.Add(new Vector3(-1766.725 , 4414.229 , 4.480762 , "None"));
Path.Add(new Vector3(-1777.93 , 4415.252 , 4.803687 , "None"));
Path.Add(new Vector3(-1787.884 , 4416.298 , 4.848496 , "None"));
Path.Add(new Vector3(-1794.904 , 4415.842 , 3.42334 , "None"));
Path.Add(new Vector3(-1804.757 , 4415.084 , 1.643498 , "None"));
Path.Add(new Vector3(-1815.004 , 4416.804 , 2.311092 , "None"));
Path.Add(new Vector3(-1824.718 , 4421.749 , 3.720501 , "None"));
Path.Add(new Vector3(-1831.319 , 4425.518 , 3.092179 , "None"));
Path.Add(new Vector3(-1836.941 , 4430.645 , 1.730671 , "None"));
Path.Add(new Vector3(-1843.903 , 4438.464 , -0.2203531 , "None"));
Path.Add(new Vector3(-1852.42 , 4445.39 , -1.684761 , "None"));
Path.Add(new Vector3(-1862.21 , 4448.776 , -0.7950803 , "None"));
Path.Add(new Vector3(-1872.71 , 4450.988 , 1.616042 , "None"));
Path.Add(new Vector3(-1895.683 , 4455.73 , 6.548213 , "None"));
Path.Add(new Vector3(-1918.353 , 4465.44 , 7.98916 , "None"));
Path.Add(new Vector3(-1939.73 , 4485.617 , 10.59326 , "None"));
Path.Add(new Vector3(-1960.985 , 4506.433 , 12.7403 , "None"));
Path.Add(new Vector3(-1975.168 , 4524.514 , 13.37676 , "None"));
Path.Add(new Vector3(-1971.454 , 4546.233 , 12.96648 , "None"));
Path.Add(new Vector3(-1957.406 , 4583.63 , 7.904135 , "None"));
Path.Add(new Vector3(-1953.561 , 4619.235 , 1.647102 , "None"));
Path.Add(new Vector3(-1951.081 , 4653.726 , -1.087462 , "None"));
Path.Add(new Vector3(-1948.802 , 4685.424 , -2.1153 , "None"));
Path.Add(new Vector3(-1947.38 , 4707.366 , -2.650108 , "None"));
Path.Add(new Vector3(-1946.777 , 4734.207 , -3.239193 , "None"));
Path.Add(new Vector3(-1949.402 , 4757.157 , -2.559327 , "None"));
Path.Add(new Vector3(-1953.091 , 4783.872 , -0.6267164 , "None"));
Path.Add(new Vector3(-1946.618 , 4832.549 , 0.7165851 , "None"));
Path.Add(new Vector3(-1931.842 , 4865.448 , 2.058686 , "None"));
Path.Add(new Vector3(-1919.456 , 4894.76 , 2.581171 , "None"));
Path.Add(new Vector3(-1929.61 , 4921.993 , 9.461305 , "None"));
Path.Add(new Vector3(-1951.799 , 4967.928 , 26.06783 , "None"));
Path.Add(new Vector3(-1960.73 , 5002.983 , 31.47913 , "None"));
Path.Add(new Vector3(-1947.993 , 5037.222 , 27.28381 , "None"));
Path.Add(new Vector3(-1936.54 , 5067.228 , 17.14038 , "None"));
Path.Add(new Vector3(-1973.086 , 5093.037 , 8.493449 , "None"));
Path.Add(new Vector3(-2006.056 , 5107.106 , 8.35471 , "None"));
Path.Add(new Vector3(-2038.354 , 5121.982 , 8.461497 , "None"));
Path.Add(new Vector3(-2063.63 , 5125.678 , 6.85874 , "None"));
Path.Add(new Vector3(-2107.263 , 5108.819 , -0.9402232 , "None"));
Path.Add(new Vector3(-2136.006 , 5107.666 , -10.88629 , "None"));
Path.Add(new Vector3(-2154.875 , 5113.695 , -17.55575 , "None"));
Path.Add(new Vector3(-2173.033 , 5122.29 , -21.25479 , "None"));
Path.Add(new Vector3(-2191.043 , 5131.501 , -21.32053 , "None"));
Path.Add(new Vector3(-2215.769 , 5144.187 , -20.02281 , "None"));
Path.Add(new Vector3(-2242.954 , 5150.224 , -16.76986 , "None"));
Path.Add(new Vector3(-2277.758 , 5146.78 , -11.0114 , "None"));
Path.Add(new Vector3(-2314.165 , 5144.789 , -6.626891 , "None"));
Path.Add(new Vector3(-2348.211 , 5150.846 , -4.174026 , "None"));
Path.Add(new Vector3(-2378.135 , 5157.288 , -1.951877 , "None"));
Path.Add(new Vector3(-2429.199 , 5166.78 , 1.675537 , "None"));
Path.Add(new Vector3(-2454.87 , 5172.114 , 0.6276063 , "None"));
Path.Add(new Vector3(-2475.96 , 5173.538 , 2.287839 , "None"));
Path.Add(new Vector3(-2478.321 , 5183.006 , 2.346974 , "None"));
Path.Add(new Vector3(-2481.802 , 5195.478 , 1.252786 , "None"));
Path.Add(new Vector3(-2485.185 , 5205.529 , 1.162158 , "None"));
Path.Add(new Vector3(-2491.017 , 5214.39 , 1.056713 , "None"));
Path.Add(new Vector3(-2499.218 , 5220.625 , 2.900841 , "None"));
Path.Add(new Vector3(-2501.942 , 5222.626 , 2.707 , "None"));
Path.Add(new Vector3(-2508.492 , 5227.437 , 1.268241 , "None"));
Path.Add(new Vector3(-2514.652 , 5231.286 , -0.09916955 , "None"));
Path.Add(new Vector3(-2519.4 , 5234.188 , -0.01718513 , "None"));
Path.Add(new Vector3(-2527.368 , 5239.182 , 1.638663 , "None"));
Path.Add(new Vector3(-2534.315 , 5247.513 , 3.756621 , "None"));
Path.Add(new Vector3(-2537.137 , 5251.104 , 4.465084 , "None"));
Path.Add(new Vector3(-2538.594 , 5261.435 , 4.155231 , "None"));
Path.Add(new Vector3(-2539.555 , 5272.228 , 2.39977 , "None"));
Path.Add(new Vector3(-2540.054 , 5277.833 , 1.629832 , "None"));
Path.Add(new Vector3(-2539.476 , 5288.723 , 0.8388847 , "None"));
Path.Add(new Vector3(-2538.149 , 5295.972 , 1.137585 , "None"));
Path.Add(new Vector3(-2537.548 , 5299.391 , 1.656317 , "None"));
Path.Add(new Vector3(-2530.769 , 5305.54 , 1.018825 , "None"));
Path.Add(new Vector3(-2527.433 , 5310.388 , 0.5517293 , "None"));
Path.Add(new Vector3(-2525.066 , 5316.181 , 0.2740382 , "None"));
Path.Add(new Vector3(-2529.309 , 5309.578 , 0.7431924 , "None"));
Path.Add(new Vector3(-2525.339 , 5311.051 , 0.3577163 , "None"));
Path.Add(new Vector3(-2524.716 , 5319.457 , 0.3761102 , "None"));
Path.Add(new Vector3(-2526.152 , 5323.563 , 0.8044685 , "None"));
Path.Add(new Vector3(-2531.359 , 5327.965 , 1.222574 , "None"));
Path.Add(new Vector3(-2539.494 , 5334.47 , 0.7698501 , "None"));
Path.Add(new Vector3(-2544.281 , 5338.136 , 0.8890718 , "None"));
Path.Add(new Vector3(-2547.281 , 5340.365 , 1.243818 , "None"));
Path.Add(new Vector3(-2551.575 , 5344.313 , 1.402387 , "None"));
Path.Add(new Vector3(-2586.879 , 5336.463 , 7.817698 , "None"));
Path.Add(new Vector3(-2588.61 , 5341.078 , 7.334176 , "None"));
Path.Add(new Vector3(-2591.04 , 5347.199 , 6.636099 , "None"));
Path.Add(new Vector3(-2595.328 , 5355.145 , 6.132046 , "None"));
Path.Add(new Vector3(-2600.445 , 5363.958 , 6.406188 , "None"));
Path.Add(new Vector3(-2602.152 , 5371.099 , 5.41656 , "None"));
Path.Add(new Vector3(-2602.796 , 5379.879 , 4.532824 , "None"));
Path.Add(new Vector3(-2603.091 , 5388.272 , 4.46162 , "None"));
Path.Add(new Vector3(-2602.16 , 5399.065 , 2.999762 , "None"));
Path.Add(new Vector3(-2599.768 , 5408.571 , 2.374059 , "None"));
Path.Add(new Vector3(-2596.082 , 5415.273 , 1.216071 , "None"));
Path.Add(new Vector3(-2590.537 , 5418.309 , 0.203345 , "None"));
Path.Add(new Vector3(-2583.554 , 5422.146 , 0.07519715 , "None"));
Path.Add(new Vector3(-2579.425 , 5424.44 , 0.1308635 , "None"));
Path.Add(new Vector3(-2571.98 , 5430.362 , 0.07038984 , "None"));
Path.Add(new Vector3(-2567.178 , 5434.499 , 0.4975347 , "None"));
Path.Add(new Vector3(-2560.689 , 5441.858 , 0.04891719 , "None"));
Path.Add(new Vector3(-2555.676 , 5445.618 , 0.04737731 , "None"));
Path.Add(new Vector3(-2552 , 5447.213 , 0.04737731 , "None"));
Path.Add(new Vector3(-2544.915 , 5450.195 , 2.962296 , "None"));
Path.Add(new Vector3(-2538.861 , 5454.913 , 3.634519 , "None"));
Path.Add(new Vector3(-2536.654 , 5458.084 , 3.498162 , "None"));
Path.Add(new Vector3(-2535.74 , 5464.933 , 6.381382 , "None"));
Path.Add(new Vector3(-2535.246 , 5468.68 , 7.298344 , "None"));
Path.Add(new Vector3(-2533.972 , 5475.241 , 8.120556 , "None"));
Path.Add(new Vector3(-2535.146 , 5478.9 , 8.251042 , "None"));
Path.Add(new Vector3(-2540.547 , 5478.284 , 8.256604 , "None"));
Path.Add(new Vector3(-2542.342 , 5474.366 , 8.25686 , "None"));
Path.Add(new Vector3(-2548.906 , 5466.13 , 10.41616 , "None"));
Path.Add(new Vector3(-2552.56 , 5461.55 , 15.05834 , "None"));
Path.Add(new Vector3(-2557.51 , 5457.194 , 21.10258 , "None"));
Path.Add(new Vector3(-2562.316 , 5452.992 , 26.43232 , "None"));
Path.Add(new Vector3(-2565.211 , 5450.627 , 27.24633 , "None"));
Path.Add(new Vector3(-2567.68 , 5445.973 , 27.59998 , "None"));
Path.Add(new Vector3(-2567.419 , 5440.469 , 28.00361 , "None"));
Path.Add(new Vector3(-2567.463 , 5431.159 , 27.31981 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class TheElusiveIronjaw : QuestGrinderClass
{
    public TheElusiveIronjaw()
    {
        Name = "The Elusive Ironjaw";

        QuestId.AddRange(new[] { 10022 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10016;

        EntryTarget.Add(18670);
HotSpots.Add(new Vector3(-2257.22 , 3547.44 , -21.6101 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class VesselsofPower : QuestGathererClass
{
    public VesselsofPower()
    {
        Name = "Vessels of Power";

        QuestId.AddRange(new[] { 10028 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9992;

        EntryIdObjects.Add(182581);
EntryIdObjects.Add(182583);
EntryIdObjects.Add(182582);
EntryIdObjects.Add(181798);
HotSpots.Add(new Vector3(-2173.167 , 4162.964 , 11.3172 , "None"));
HotSpots.Add(new Vector3(-2179.666 , 4183.073 , 12.91904 , "None"));
HotSpots.Add(new Vector3(-2174.045 , 4262.593 , 2.996051 , "None"));
HotSpots.Add(new Vector3(-2244.332 , 4201.315 , 1.066685 , "None"));
HotSpots.Add(new Vector3(-2218.169 , 4282.582 , 3.205813 , "None"));
HotSpots.Add(new Vector3(-2187.39 , 4314.554 , 1.455847 , "None"));
HotSpots.Add(new Vector3(-2023.111 , 4260.466 , 4.403712 , "None"));
HotSpots.Add(new Vector3(-1970.454 , 4280.752 , 1.312705 , "None"));
HotSpots.Add(new Vector3(-1966.974 , 4210.959 , 2.306762 , "None"));
HotSpots.Add(new Vector3(-1987.22 , 4150.485 , 3.665783 , "None"));
HotSpots.Add(new Vector3(-2082.267 , 4021.237 , 1.029807 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNFromUrDakStymyingtheArakkoatoThintheflock : QuestFollowPathClass
{
    public RUNFromUrDakStymyingtheArakkoatoThintheflock()
    {
        Name = "RUN: From UrDak(Stymying the Arakkoa) to Thin the flock";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2570.22 , 5426.682 , 26.82587 , "None"));
Path.Add(new Vector3(-2566.937 , 5431.547 , 27.16003 , "None"));
Path.Add(new Vector3(-2564.413 , 5439.122 , 27.18032 , "None"));
Path.Add(new Vector3(-2564.558 , 5448.179 , 27.23951 , "None"));
Path.Add(new Vector3(-2561.966 , 5451.898 , 26.69554 , "None"));
Path.Add(new Vector3(-2554.665 , 5459.932 , 17.27918 , "None"));
Path.Add(new Vector3(-2547.986 , 5468.441 , 8.803701 , "None"));
Path.Add(new Vector3(-2548.208 , 5477.092 , 8.267042 , "None"));
Path.Add(new Vector3(-2555.824 , 5480.657 , 8.990797 , "None"));
Path.Add(new Vector3(-2562.758 , 5478.449 , 6.11482 , "None"));
Path.Add(new Vector3(-2568.34 , 5467.067 , 0.2453214 , "None"));
Path.Add(new Vector3(-2575.046 , 5459.164 , 0.03948766 , "None"));
Path.Add(new Vector3(-2583.682 , 5452.598 , 0.04794225 , "None"));
Path.Add(new Vector3(-2591.617 , 5446.029 , 0.2068672 , "None"));
Path.Add(new Vector3(-2597.716 , 5436.958 , -0.312189 , "None"));
Path.Add(new Vector3(-2600.739 , 5427.163 , 0.1612643 , "None"));
Path.Add(new Vector3(-2601.344 , 5416.143 , 1.900312 , "None"));
Path.Add(new Vector3(-2602.391 , 5405.962 , 2.997324 , "None"));
Path.Add(new Vector3(-2605.014 , 5395.272 , 4.220797 , "None"));
Path.Add(new Vector3(-2610.254 , 5386.782 , 5.559846 , "None"));
Path.Add(new Vector3(-2618.799 , 5380.326 , 6.493927 , "None"));
Path.Add(new Vector3(-2619.99 , 5376.598 , 6.601019 , "None"));
Path.Add(new Vector3(-2613.103 , 5368.538 , 7.592563 , "None"));
Path.Add(new Vector3(-2604.204 , 5362.616 , 7.399857 , "None"));
Path.Add(new Vector3(-2595.46 , 5356.803 , 6.032446 , "None"));
Path.Add(new Vector3(-2587.578 , 5349.509 , 6.474112 , "None"));
Path.Add(new Vector3(-2579.608 , 5343.169 , 6.952134 , "None"));
Path.Add(new Vector3(-2569.395 , 5339.945 , 5.521588 , "None"));
Path.Add(new Vector3(-2559.734 , 5336.343 , 3.165576 , "None"));
Path.Add(new Vector3(-2550.291 , 5332.815 , 1.224817 , "None"));
Path.Add(new Vector3(-2543.268 , 5330.191 , 0.7551545 , "None"));
Path.Add(new Vector3(-2533.626 , 5326.15 , 1.235303 , "None"));
Path.Add(new Vector3(-2524.013 , 5320.679 , 0.4370086 , "None"));
Path.Add(new Vector3(-2514.702 , 5316.549 , 0.720043 , "None"));
Path.Add(new Vector3(-2503.963 , 5317.078 , 0.7366107 , "None"));
Path.Add(new Vector3(-2493.581 , 5318.273 , 0.9332451 , "None"));
Path.Add(new Vector3(-2482.823 , 5319.299 , 1.294097 , "None"));
Path.Add(new Vector3(-2475.72 , 5314.107 , 0.8100621 , "None"));
Path.Add(new Vector3(-2471.597 , 5304.299 , -0.07280083 , "None"));
Path.Add(new Vector3(-2465.787 , 5295.759 , 0.2488104 , "None"));
Path.Add(new Vector3(-2457.429 , 5288.496 , 1.261979 , "None"));
Path.Add(new Vector3(-2448.832 , 5282.504 , 1.608435 , "None"));
Path.Add(new Vector3(-2440.337 , 5276.13 , 1.056133 , "None"));
Path.Add(new Vector3(-2432.375 , 5269.447 , 0.1241005 , "None"));
Path.Add(new Vector3(-2424.353 , 5262.344 , -0.3155341 , "None"));
Path.Add(new Vector3(-2416.903 , 5254.665 , 0.261429 , "None"));
Path.Add(new Vector3(-2409.808 , 5246.434 , 0.152861 , "None"));
Path.Add(new Vector3(-2400.269 , 5233.189 , -0.970736 , "None"));
Path.Add(new Vector3(-2383.039 , 5208.845 , -2.543269 , "None"));
Path.Add(new Vector3(-2364.448 , 5178.772 , -1.739912 , "None"));
Path.Add(new Vector3(-2351.195 , 5158.351 , -3.842499 , "None"));
Path.Add(new Vector3(-2342.834 , 5150.281 , -4.462044 , "None"));
Path.Add(new Vector3(-2334.887 , 5145.168 , -4.531178 , "None"));
Path.Add(new Vector3(-2319.673 , 5138.042 , -5.689013 , "None"));
Path.Add(new Vector3(-2307.231 , 5129.527 , -6.329352 , "None"));
Path.Add(new Vector3(-2284.945 , 5137.546 , -9.859142 , "None"));
Path.Add(new Vector3(-2259.838 , 5139.538 , -13.9452 , "None"));
Path.Add(new Vector3(-2243.453 , 5142.043 , -16.60303 , "None"));
Path.Add(new Vector3(-2209.614 , 5134.25 , -20.11847 , "None"));
Path.Add(new Vector3(-2177.107 , 5120.996 , -21.25539 , "None"));
Path.Add(new Vector3(-2142.547 , 5111.461 , -13.77448 , "None"));
Path.Add(new Vector3(-2108.553 , 5108.415 , -1.298249 , "None"));
Path.Add(new Vector3(-2074.608 , 5117.465 , 5.580348 , "None"));
Path.Add(new Vector3(-2052.396 , 5122.843 , 7.889225 , "None"));
Path.Add(new Vector3(-2033.584 , 5125.283 , 8.444638 , "None"));
Path.Add(new Vector3(-2017.289 , 5116.845 , 8.437372 , "None"));
Path.Add(new Vector3(-1996.932 , 5103.933 , 7.855223 , "None"));
Path.Add(new Vector3(-1964.483 , 5086.717 , 10.22065 , "None"));
Path.Add(new Vector3(-1940.039 , 5063.144 , 17.99412 , "None"));
Path.Add(new Vector3(-1938.674 , 5045.085 , 23.2015 , "None"));
Path.Add(new Vector3(-1952.936 , 5021.81 , 32.58466 , "None"));
Path.Add(new Vector3(-1958.133 , 5013.337 , 32.40258 , "None"));
Path.Add(new Vector3(-1961.052 , 5006.898 , 31.91162 , "None"));
Path.Add(new Vector3(-1958.897 , 4991.933 , 30.08456 , "None"));
Path.Add(new Vector3(-1951.497 , 4957.777 , 23.76079 , "None"));
Path.Add(new Vector3(-1942.54 , 4924.144 , 13.27629 , "None"));
Path.Add(new Vector3(-1938.809 , 4887.434 , 4.447939 , "None"));
Path.Add(new Vector3(-1944.193 , 4853.258 , 3.043807 , "None"));
Path.Add(new Vector3(-1950.808 , 4817.681 , 0.5265517 , "None"));
Path.Add(new Vector3(-1953.847 , 4783.255 , -0.6831664 , "None"));
Path.Add(new Vector3(-1952.016 , 4748.006 , -2.957052 , "None"));
Path.Add(new Vector3(-1947.851 , 4712.5 , -3.017264 , "None"));
Path.Add(new Vector3(-1949.302 , 4676.561 , -1.912758 , "None"));
Path.Add(new Vector3(-1952.062 , 4642.793 , -0.4341156 , "None"));
Path.Add(new Vector3(-1949.864 , 4606.473 , 3.386476 , "None"));
Path.Add(new Vector3(-1953.22 , 4573.015 , 9.187675 , "None"));
Path.Add(new Vector3(-1971.87 , 4542.044 , 13.21598 , "None"));
Path.Add(new Vector3(-1976.028 , 4507.157 , 12.5207 , "None"));
Path.Add(new Vector3(-1971.872 , 4504.061 , 12.50798 , "None"));
Path.Add(new Vector3(-1950.2 , 4493.834 , 11.74266 , "None"));
Path.Add(new Vector3(-1931.579 , 4478.572 , 9.522923 , "None"));
Path.Add(new Vector3(-1907.321 , 4451.81 , 6.372079 , "None"));
Path.Add(new Vector3(-1900.986 , 4444.988 , 5.95195 , "None"));
Path.Add(new Vector3(-1890.734 , 4435.454 , 4.652551 , "None"));
Path.Add(new Vector3(-1881.011 , 4427.114 , 3.983217 , "None"));
Path.Add(new Vector3(-1873.891 , 4421.445 , 3.995528 , "None"));
Path.Add(new Vector3(-1849.028 , 4419.84 , 1.419827 , "None"));
Path.Add(new Vector3(-1821.532 , 4414.615 , 2.53647 , "None"));
Path.Add(new Vector3(-1800.918 , 4410.605 , 2.561434 , "None"));
Path.Add(new Vector3(-1796.452 , 4409.736 , 3.159106 , "None"));
Path.Add(new Vector3(-1785.869 , 4408.904 , 5.085634 , "None"));
Path.Add(new Vector3(-1776.502 , 4409.407 , 5.312137 , "None"));
Path.Add(new Vector3(-1770.632 , 4409.039 , 5.548966 , "None"));
Path.Add(new Vector3(-1757.331 , 4407.387 , 6.394358 , "None"));
Path.Add(new Vector3(-1737.982 , 4402.822 , 10.96192 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class StrangeEnergy : QuestGrinderClass
{
    public StrangeEnergy()
    {
        Name = "Strange Energy";

        QuestId.AddRange(new[] { 9968 });

        Step = new List<int> { 4, 4, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9961;

        EntryTarget.Add(18468);
EntryTarget.Add(18437);
HotSpots.Add(new Vector3(-2194.11 , 4456.67 , 1.92529 , "None"));
HotSpots.Add(new Vector3(-2077.944 , 4724.255 , -3.697142 , "None"));
HotSpots.Add(new Vector3(-1732.797 , 4608.33 , 8.999082 , "None"));
HotSpots.Add(new Vector3(-1782.759 , 4813.391 , 7.76449 , "None"));
HotSpots.Add(new Vector3(-1863.488 , 4621.358 , 11.50479 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ByAnyMeansNecessary : QuestClass
{
    public ByAnyMeansNecessary()
    {
        Name = "By Any Means Necessary";

        QuestId.AddRange(new[] { 9978 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9968;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WindTraderLathrai : QuestClass
{
    public WindTraderLathrai()
    {
        Name = "Wind Trader Lathrai";

        QuestId.AddRange(new[] { 9979 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9978;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class APersonalFavor : QuestGrinderClass
{
    public APersonalFavor()
    {
        Name = "A Personal Favor";

        QuestId.AddRange(new[] { 10112 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9979;

        EntryTarget.Add(18453);
EntryTarget.Add(18452);
HotSpots.Add(new Vector3(-2387.828 , 5402.873 , 1.789126 , "None"));
HotSpots.Add(new Vector3(-2602.395 , 5401.289 , 2.990363 , "None"));
HotSpots.Add(new Vector3(-2519.639 , 5451.979 , 0.3532193 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class InvestigateTuurem : QuestGathererClass
{
    public InvestigateTuurem()
    {
        Name = "Investigate Tuurem";

        QuestId.AddRange(new[] { 9990 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10112;

        EntryIdObjects.Add(182542);
EntryIdObjects.Add(184794);
EntryIdObjects.Add(181798);
HotSpots.Add(new Vector3(-2079.358 , 4168.122 , 7.676788 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WhatAreTheseThings : QuestClass
{
    public WhatAreTheseThings()
    {
        Name = "What Are These Things?";

        QuestId.AddRange(new[] { 9994 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9990;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReporttotheAllerianPost : QuestClass
{
    public ReporttotheAllerianPost()
    {
        Name = "Report to the Allerian Post";

        QuestId.AddRange(new[] { 10444 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9994;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AttackonFirewingPoint : QuestGrinderClass
{
    public AttackonFirewingPoint()
    {
        Name = "Attack on Firewing Point";

        QuestId.AddRange(new[] { 9996 });

        Step = new List<int> { 10, 10, 10, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5355);
EntryTarget.Add(1410);
EntryTarget.Add(16769);
HotSpots.Add(new Vector3(-2447.313 , 3223.687 , 7.08355 , "None"));
HotSpots.Add(new Vector3(-2376.802 , 3315.836 , -2.770295 , "None"));
HotSpots.Add(new Vector3(-2288.836 , 3308.688 , 1.169471 , "None"));
HotSpots.Add(new Vector3(-2276.573 , 3265.133 , -1.930647 , "None"));
HotSpots.Add(new Vector3(-2289.674 , 3168.203 , -0.2023908 , "None"));
HotSpots.Add(new Vector3(-2405.129 , 3137.985 , 2.111605 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNFinalCode1TO : QuestFollowPathClass
{
    public RUNFinalCode1TO()
    {
        Name = "RUN: Final Code 1 - TO";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2512.956 , 3297.514 , 2.566953 , "None"));
Path.Add(new Vector3(-2501.51 , 3272.722 , 1.192297 , "None"));
Path.Add(new Vector3(-2492.955 , 3242.174 , 2.02808 , "None"));
Path.Add(new Vector3(-2471.919 , 3215.955 , 4.248827 , "None"));
Path.Add(new Vector3(-2463.568 , 3212.093 , 5.373917 , "None"));
Path.Add(new Vector3(-2453.699 , 3211.976 , 6.935207 , "None"));
Path.Add(new Vector3(-2448.293 , 3211.084 , 7.164592 , "None"));
Path.Add(new Vector3(-2443.408 , 3209.936 , 6.931045 , "None"));
Path.Add(new Vector3(-2432.928 , 3207.543 , 5.401947 , "None"));
Path.Add(new Vector3(-2422.617 , 3205.139 , 3.626017 , "None"));
Path.Add(new Vector3(-2412.082 , 3204.957 , 2.41516 , "None"));
Path.Add(new Vector3(-2401.601 , 3202.598 , 2.211031 , "None"));
Path.Add(new Vector3(-2397.416 , 3199.602 , 2.211031 , "None"));
Path.Add(new Vector3(-2391.702 , 3192.487 , 2.210748 , "None"));
Path.Add(new Vector3(-2386.156 , 3183.654 , 2.019132 , "None"));
Path.Add(new Vector3(-2382.316 , 3173.671 , 2.647067 , "None"));
Path.Add(new Vector3(-2375.079 , 3166.066 , 2.628848 , "None"));
Path.Add(new Vector3(-2366.586 , 3159.884 , 3.550929 , "None"));
Path.Add(new Vector3(-2357.824 , 3153.509 , 6.194039 , "None"));
Path.Add(new Vector3(-2348.792 , 3148.17 , 8.75671 , "None"));
Path.Add(new Vector3(-2338.478 , 3142.24 , 9.49938 , "None"));
Path.Add(new Vector3(-2330.39 , 3137.351 , 10.81882 , "None"));
Path.Add(new Vector3(-2321.433 , 3131.873 , 12.05471 , "None"));
Path.Add(new Vector3(-2312.646 , 3125.539 , 12.36665 , "None"));
Path.Add(new Vector3(-2304.665 , 3118.725 , 13.82279 , "None"));
Path.Add(new Vector3(-2297.828 , 3110.827 , 13.82407 , "None"));
Path.Add(new Vector3(-2296.042 , 3106.307 , 13.82453 , "None"));
Path.Add(new Vector3(-2295.896 , 3102.48 , 13.82591 , "None"));
Path.Add(new Vector3(-2300.45 , 3094.296 , 13.82685 , "None"));
Path.Add(new Vector3(-2303.249 , 3086.778 , 13.82685 , "None"));
Path.Add(new Vector3(-2302.335 , 3080.163 , 13.82686 , "None"));
Path.Add(new Vector3(-2299.946 , 3075.484 , 14.14891 , "None"));
Path.Add(new Vector3(-2296.629 , 3073.596 , 14.8296 , "None"));
Path.Add(new Vector3(-2294.236 , 3073.039 , 15.40965 , "None"));
Path.Add(new Vector3(-2286.571 , 3072.235 , 17.05515 , "None"));
Path.Add(new Vector3(-2276.288 , 3075.394 , 19.66933 , "None"));
Path.Add(new Vector3(-2268.894 , 3082.46 , 21.74102 , "None"));
Path.Add(new Vector3(-2266.279 , 3092.703 , 23.702 , "None"));
Path.Add(new Vector3(-2267.954 , 3101.663 , 25.01305 , "None"));
Path.Add(new Vector3(-2267.936 , 3104.256 , 25.01459 , "None"));
Path.Add(new Vector3(-2267.907 , 3106.006 , 25.01585 , "None"));
Path.Add(new Vector3(-2266.85 , 3109.307 , 25.01626 , "None"));
Path.Add(new Vector3(-2266.09 , 3110.797 , 25.01723 , "None"));
Path.Add(new Vector3(-2264.27 , 3112.473 , 25.01773 , "None"));
Path.Add(new Vector3(-2261.52 , 3114.637 , 25.01773 , "None"));
Path.Add(new Vector3(-2258.679 , 3116.876 , 25.11438 , "None"));
Path.Add(new Vector3(-2255.583 , 3118.483 , 26.71873 , "None"));
Path.Add(new Vector3(-2252.241 , 3120.388 , 27.389 , "None"));
Path.Add(new Vector3(-2249.182 , 3122.089 , 27.389 , "None"));
Path.Add(new Vector3(-2247.029 , 3123.259 , 27.58805 , "None"));
Path.Add(new Vector3(-2248.725 , 3122.299 , 27.38889 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNFinalCodeUpSpiralAfterTP : QuestFollowPathClass
{
    public RUNFinalCodeUpSpiralAfterTP()
    {
        Name = "RUN: Final Code - Up Spiral (After TP)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2268.165 , 3109.338 , 136.2895 , "None"));
Path.Add(new Vector3(-2272.205 , 3106.497 , 136.208 , "None"));
Path.Add(new Vector3(-2274.566 , 3103.832 , 138.1994 , "None"));
Path.Add(new Vector3(-2275.908 , 3100.487 , 138.7548 , "None"));
Path.Add(new Vector3(-2277.036 , 3097.179 , 138.7532 , "None"));
Path.Add(new Vector3(-2279.013 , 3094.148 , 138.7517 , "None"));
Path.Add(new Vector3(-2279.89 , 3090.789 , 138.7517 , "None"));
Path.Add(new Vector3(-2281.589 , 3087.612 , 138.7517 , "None"));
Path.Add(new Vector3(-2284.456 , 3085.639 , 138.7517 , "None"));
Path.Add(new Vector3(-2287.906 , 3084.647 , 139.2409 , "None"));
Path.Add(new Vector3(-2291.277 , 3084.941 , 140.6334 , "None"));
Path.Add(new Vector3(-2294.753 , 3085.869 , 141.5957 , "None"));
Path.Add(new Vector3(-2297.811 , 3087.564 , 142.3803 , "None"));
Path.Add(new Vector3(-2300.426 , 3089.95 , 143.3617 , "None"));
Path.Add(new Vector3(-2302.097 , 3093.065 , 144.55 , "None"));
Path.Add(new Vector3(-2302.604 , 3096.599 , 146.0852 , "None"));
Path.Add(new Vector3(-2302.012 , 3099.941 , 147.401 , "None"));
Path.Add(new Vector3(-2297.797 , 3103.076 , 149.3987 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = true;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class TheFinalCode : QuestGathererClass
{
    public TheFinalCode()
    {
        Name = "The Final Code";

        QuestId.AddRange(new[] { 10446 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9996;

        EntryIdObjects.Add(184725);
HotSpots.Add(new Vector3(-2347.607 , 3234.114 , -3.375562 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheFinalCodeKillForCode : QuestGrinderClass
{
    public TheFinalCodeKillForCode()
    {
        Name = "The Final Code - Kill For Code";

        QuestId.AddRange(new[] { 10446 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18554);
HotSpots.Add(new Vector3(-2289.5 , 3094.68 , 152.8184 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(29912) >= 1;
}






}


public sealed class RUNFinalCodeHaveItemGoClickOrb : QuestFollowPathClass
{
    public RUNFinalCodeHaveItemGoClickOrb()
    {
        Name = "RUN: Final Code - Have Item - Go Click Orb";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2288.852 , 3094.74 , 152.8178 , "None"));
Path.Add(new Vector3(-2292.598 , 3092.401 , 152.8178 , "None"));
Path.Add(new Vector3(-2295.261 , 3090.13 , 153.3602 , "None"));
Path.Add(new Vector3(-2297.939 , 3087.881 , 155.8036 , "None"));
Path.Add(new Vector3(-2300.866 , 3085.815 , 157.507 , "None"));
Path.Add(new Vector3(-2303.197 , 3083.168 , 158.3859 , "None"));
Path.Add(new Vector3(-2305.5 , 3080.386 , 158.3859 , "None"));
Path.Add(new Vector3(-2307.949 , 3077.879 , 158.3859 , "None"));
Path.Add(new Vector3(-2311.023 , 3076.257 , 158.3859 , "None"));
Path.Add(new Vector3(-2314.55 , 3076.867 , 158.3859 , "None"));
Path.Add(new Vector3(-2316.452 , 3078.334 , 158.3859 , "None"));
Path.Add(new Vector3(-2316.305 , 3079.838 , 158.3859 , "None"));
Path.Add(new Vector3(-2315.416 , 3081.606 , 158.3859 , "None"));
Path.Add(new Vector3(-2313.621 , 3081.926 , 158.3859 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNFinalCodeWeareDOWNRunToCodeShit : QuestFollowPathClass
{
    public RUNFinalCodeWeareDOWNRunToCodeShit()
    {
        Name = "RUN: Final Code - We are DOWN_RunTo Code Shit";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2305.36 , 3119.912 , 13.82391 , "None"));
Path.Add(new Vector3(-2307.039 , 3122.144 , 13.80595 , "None"));
Path.Add(new Vector3(-2313.94 , 3129.825 , 12.09001 , "None"));
Path.Add(new Vector3(-2322.248 , 3136.271 , 11.61957 , "None"));
Path.Add(new Vector3(-2331.655 , 3141.751 , 9.893372 , "None"));
Path.Add(new Vector3(-2341.142 , 3146.443 , 9.203394 , "None"));
Path.Add(new Vector3(-2350.742 , 3151.19 , 7.720491 , "None"));
Path.Add(new Vector3(-2360.112 , 3155.928 , 5.225889 , "None"));
Path.Add(new Vector3(-2369.415 , 3161.47 , 3.09008 , "None"));
Path.Add(new Vector3(-2377.287 , 3168.434 , 2.758772 , "None"));
Path.Add(new Vector3(-2382.932 , 3177.443 , 2.394066 , "None"));
Path.Add(new Vector3(-2386.785 , 3182.535 , 2.04092 , "None"));
Path.Add(new Vector3(-2386.018 , 3191.952 , 1.307521 , "None"));
Path.Add(new Vector3(-2385.058 , 3199.978 , -0.06194337 , "None"));
Path.Add(new Vector3(-2384.172 , 3205.939 , -0.5233932 , "None"));
Path.Add(new Vector3(-2383.084 , 3210.621 , -0.9042562 , "None"));
Path.Add(new Vector3(-2380.64 , 3214.884 , -1.441673 , "None"));
Path.Add(new Vector3(-2378.304 , 3217.63 , -2.029907 , "None"));
Path.Add(new Vector3(-2376.036 , 3220.296 , -2.545252 , "None"));
Path.Add(new Vector3(-2375.741 , 3222.931 , -2.729524 , "None"));
Path.Add(new Vector3(-2377.022 , 3225.995 , -2.695908 , "None"));
Path.Add(new Vector3(-2377.482 , 3229.549 , -2.715099 , "None"));
Path.Add(new Vector3(-2377.944 , 3232.813 , -2.708924 , "None"));
Path.Add(new Vector3(-2374.79 , 3237.151 , -3.251986 , "None"));
Path.Add(new Vector3(-2374.285 , 3240.072 , -3.327954 , "None"));
Path.Add(new Vector3(-2372.826 , 3236.602 , -3.298662 , "None"));
Path.Add(new Vector3(-2371.69 , 3231.825 , -3.258421 , "None"));
Path.Add(new Vector3(-2371.36 , 3228.354 , -3.204171 , "None"));
Path.Add(new Vector3(-2369.088 , 3225.88 , -3.241852 , "None"));
Path.Add(new Vector3(-2371.102 , 3223.853 , -3.123732 , "None"));
Path.Add(new Vector3(-2370.386 , 3220.656 , -3.088663 , "None"));
Path.Add(new Vector3(-2368.644 , 3217.459 , -3.117408 , "None"));
Path.Add(new Vector3(-2366.559 , 3214.609 , -3.188243 , "None"));
Path.Add(new Vector3(-2363.953 , 3215.772 , -3.304761 , "None"));
Path.Add(new Vector3(-2361.492 , 3218.181 , -3.364818 , "None"));
Path.Add(new Vector3(-2357.55 , 3218.497 , -3.375597 , "None"));
Path.Add(new Vector3(-2356.413 , 3221.522 , -3.375597 , "None"));
Path.Add(new Vector3(-2355.181 , 3224.939 , -3.375597 , "None"));
Path.Add(new Vector3(-2354.043 , 3227.989 , -3.375597 , "None"));
Path.Add(new Vector3(-2351.094 , 3229.065 , -3.375597 , "None"));
Path.Add(new Vector3(-2348.092 , 3229.139 , -3.375597 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class LettingEarthbinderTavgrenKnow : QuestClass
{
    public LettingEarthbinderTavgrenKnow()
    {
        Name = "Letting Earthbinder Tavgren Know";

        QuestId.AddRange(new[] { 10005 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10446;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class FierceEnemies : QuestGrinderClass
{
    public FierceEnemies()
    {
        Name = "Fierce Enemies";

        QuestId.AddRange(new[] { 10476 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18352);
EntryTarget.Add(18351);
EntryTarget.Add(17135);
EntryTarget.Add(17134);
HotSpots.Add(new Vector3(-2647.417 , 6892.206 , -2.291637 , "None"));
HotSpots.Add(new Vector3(-2584.337 , 6877.392 , 22.71096 , "None"));
HotSpots.Add(new Vector3(-2504.559 , 6316.768 , 22.01305 , "None"));
HotSpots.Add(new Vector3(-2513.663 , 6300.444 , 20.9719 , "None"));
HotSpots.Add(new Vector3(-2565.046 , 6263.301 , 18.2477 , "None"));
HotSpots.Add(new Vector3(-2592.887 , 6191.496 , 21.95544 , "None"));
HotSpots.Add(new Vector3(-2479.625 , 6269.525 , 30.71658 , "None"));
HotSpots.Add(new Vector3(-2495.118 , 6175.91 , 59.93989 , "None"));
HotSpots.Add(new Vector3(-2455.761 , 6113.213 , 88.88644 , "None"));
HotSpots.Add(new Vector3(-2458.698 , 6097.642 , 94.42073 , "None"));
HotSpots.Add(new Vector3(-2467.993 , 6084.923 , 92.61878 , "None"));
HotSpots.Add(new Vector3(-2338.074 , 6162.692 , 53.48646 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheRavagedCaravan : QuestGathererClass
{
    public TheRavagedCaravan()
    {
        Name = "The Ravaged Caravan";

        QuestId.AddRange(new[] { 9956 });

        Step = new List<int> { 20, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(182520);
HotSpots.Add(new Vector3(-1141.529 , 8686.277 , 46.26167 , "None"));
HotSpots.Add(new Vector3(-1076.255 , 8858.678 , 102.3951 , "None"));
HotSpots.Add(new Vector3(-1130.89 , 8987.506 , 103.7046 , "None"));
HotSpots.Add(new Vector3(-1036.011 , 9012.72 , 93.61523 , "None"));
HotSpots.Add(new Vector3(-985.0563 , 8935.427 , 104.2779 , "None"));
HotSpots.Add(new Vector3(-817.6166 , 8867.212 , 182.4642 , "None"));
HotSpots.Add(new Vector3(-881.2742 , 8891.997 , 186.117 , "None"));
HotSpots.Add(new Vector3(-811.3513 , 8724.68 , 179.1617 , "None"));
HotSpots.Add(new Vector3(-906.9637 , 8659.485 , 171.7042 , "None"));
HotSpots.Add(new Vector3(-572.463 , 8866.819 , 211.3042 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HeCalledHimselfAltruis : QuestClass
{
    public HeCalledHimselfAltruis()
    {
        Name = "He Called Himself Altruis...";

        QuestId.AddRange(new[] { 9982 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheNesingwarySafari : QuestClass
{
    public TheNesingwarySafari()
    {
        Name = "The Nesingwary Safari";

        QuestId.AddRange(new[] { 10113 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DoMyEyesDeceiveMe : QuestGrinderClass
{
    public DoMyEyesDeceiveMe()
    {
        Name = "Do My Eyes Deceive Me";

        QuestId.AddRange(new[] { 9917 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18352);
EntryTarget.Add(18351);
HotSpots.Add(new Vector3(-2621.176 , 6890.751 , 5.920489 , "None"));
HotSpots.Add(new Vector3(-2615.015 , 6839.346 , 16.60879 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AMystifyingVision : QuestClass
{
    public AMystifyingVision()
    {
        Name = "A Mystifying Vision";

        QuestId.AddRange(new[] { 11042 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class VisionsofDestruction : QuestClass
{
    public VisionsofDestruction()
    {
        Name = "Visions of Destruction";

        QuestId.AddRange(new[] { 11044 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheThroneoftheElements : QuestClass
{
    public TheThroneoftheElements()
    {
        Name = "The Throne of the Elements";

        QuestId.AddRange(new[] { 9869 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class StoppingtheSpread : QuestInteractWithClass
{
    public StoppingtheSpread()
    {
        Name = "Stopping the Spread";

        QuestId.AddRange(new[] { 9874 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(18240);
HotSpots.Add(new Vector3(-1541.584 , 8501.485 , 0.5632532 , "None"));
HotSpots.Add(new Vector3(-1544.923 , 8572.601 , 7.259845 , "None"));
HotSpots.Add(new Vector3(-1500.569 , 8566.396 , 7.26062 , "None"));
HotSpots.Add(new Vector3(-1441.446 , 8542.653 , 13.2308 , "None"));
HotSpots.Add(new Vector3(-1417.157 , 8542.228 , 14.03887 , "None"));
HotSpots.Add(new Vector3(-1456.39 , 8447.794 , -0.02933799 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "";
IgnoreIfDead = true;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SolvingtheProblem : QuestGrinderClass
{
    public SolvingtheProblem()
    {
        Name = "Solving the Problem";

        QuestId.AddRange(new[] { 9878 });

        Step = new List<int> { 20, 10, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18207);
EntryTarget.Add(18211);
EntryTarget.Add(18203);
HotSpots.Add(new Vector3(-1612.344 , 8500.809 , -13.39312 , "None"));
HotSpots.Add(new Vector3(-1455.14 , 8523.541 , 11.80751 , "None"));
HotSpots.Add(new Vector3(-1572.997 , 8548.392 , 2.001161 , "None"));
HotSpots.Add(new Vector3(-1473.193 , 8622.546 , 7.259536 , "None"));
HotSpots.Add(new Vector3(-1447.458 , 8528.683 , 13.34285 , "None"));
HotSpots.Add(new Vector3(-1659.751 , 8497.555 , -14.64499 , "None"));
HotSpots.Add(new Vector3(-1648.447 , 8501.505 , -13.38179 , "None"));
HotSpots.Add(new Vector3(-1497.463 , 8445.357 , -0.2387748 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNNagrandTelaarFlightPath : QuestFollowPathClass
{
    public RUNNagrandTelaarFlightPath()
    {
        Name = "RUN: Nagrand Telaar Flight Path";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2666.727 , 7279.189 , 34.68955 , "None"));
Path.Add(new Vector3(-2677.3 , 7275.851 , 36.90705 , "None"));
Path.Add(new Vector3(-2686.652 , 7271.882 , 38.50168 , "None"));
Path.Add(new Vector3(-2697.427 , 7269.182 , 39.9679 , "None"));
Path.Add(new Vector3(-2707.185 , 7268.841 , 41.45635 , "None"));
Path.Add(new Vector3(-2718.164 , 7271.722 , 41.86392 , "None"));
Path.Add(new Vector3(-2727.93 , 7276.013 , 41.54849 , "None"));
Path.Add(new Vector3(-2738.587 , 7275.558 , 40.9002 , "None"));
Path.Add(new Vector3(-2748.536 , 7272.334 , 39.64315 , "None"));
Path.Add(new Vector3(-2759.246 , 7272.059 , 40.15743 , "None"));
Path.Add(new Vector3(-2764.732 , 7275.598 , 42.00747 , "None"));
Path.Add(new Vector3(-2771.962 , 7282.71 , 44.33871 , "None"));
Path.Add(new Vector3(-2778.819 , 7289.868 , 47.67121 , "None"));
Path.Add(new Vector3(-2786.339 , 7297.728 , 52.17476 , "None"));
Path.Add(new Vector3(-2792.354 , 7306.187 , 56.22969 , "None"));
Path.Add(new Vector3(-2793.529 , 7309.946 , 57.36796 , "None"));
Path.Add(new Vector3(-2794.673 , 7316.899 , 60.93956 , "None"));
Path.Add(new Vector3(-2795.431 , 7323.512 , 62.75801 , "None"));
Path.Add(new Vector3(-2795.788 , 7329.129 , 63.55271 , "None"));
Path.Add(new Vector3(-2786.316 , 7321.339 , 66.25911 , "None"));
Path.Add(new Vector3(-2780.871 , 7316.376 , 70.61385 , "None"));
Path.Add(new Vector3(-2773.838 , 7309.913 , 76.92271 , "None"));
Path.Add(new Vector3(-2767.27 , 7305.056 , 81.34118 , "None"));
Path.Add(new Vector3(-2764.338 , 7302.982 , 82.75948 , "None"));
Path.Add(new Vector3(-2760.742 , 7300.465 , 84.49475 , "None"));
Path.Add(new Vector3(-2755.156 , 7296.909 , 86.61457 , "None"));
Path.Add(new Vector3(-2751.423 , 7297.909 , 87.48171 , "None"));
Path.Add(new Vector3(-2743.674 , 7301.04 , 88.17394 , "None"));
Path.Add(new Vector3(-2738.199 , 7302.875 , 88.36024 , "None"));
Path.Add(new Vector3(-2734.173 , 7304.084 , 88.50972 , "None"));
Path.Add(new Vector3(-2731.278 , 7303.708 , 88.5442 , "None"));
Path.Add(new Vector3(-2728.925 , 7303.403 , 88.57609 , "None"));
Path.Add(new Vector3(-2726.619 , 7303.268 , 88.61318 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class WANTEDGiseldatheCrone : QuestGrinderClass
{
    public WANTEDGiseldatheCrone()
    {
        Name = "WANTED: Giselda the Crone";

        QuestId.AddRange(new[] { 9936 });

        Step = new List<int> { 1, 15, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(17148);
EntryTarget.Add(17146);
EntryTarget.Add(18391);
EntryTarget.Add(17147);
HotSpots.Add(new Vector3(-2787.245 , 6432.076 , 61.70755 , "None"));
HotSpots.Add(new Vector3(-2864.376 , 6390.099 , 80.75794 , "None"));
HotSpots.Add(new Vector3(-2885.968 , 6389.409 , 81.35638 , "None"));
HotSpots.Add(new Vector3(-2913.797 , 6376.134 , 85.56864 , "None"));
HotSpots.Add(new Vector3(-2986.639 , 6345.004 , 96.14577 , "None"));
HotSpots.Add(new Vector3(-2938.964 , 6458.878 , 83.11636 , "None"));
HotSpots.Add(new Vector3(-2918.403 , 6366.026 , 87.1166 , "None"));
HotSpots.Add(new Vector3(-2881.782 , 6335.93 , 84.43444 , "None"));
HotSpots.Add(new Vector3(-2830.053 , 6312.189 , 64.63322 , "None"));
HotSpots.Add(new Vector3(-2798.645 , 6405.793 , 62.15479 , "None"));
HotSpots.Add(new Vector3(-2905.485 , 6377.062 , 84.3746 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WANTEDGiseldatheCroneKILLHERFORQ : QuestGrinderClass
{
    public WANTEDGiseldatheCroneKILLHERFORQ()
    {
        Name = "WANTED: Giselda the Crone - KILL HER FOR Q";

        QuestId.AddRange(new[] { 9936 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18391);
HotSpots.Add(new Vector3(-2987.087 , 6346.373 , 96.16071 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNKllGeseldaDONERunout : QuestFollowPathClass
{
    public RUNKllGeseldaDONERunout()
    {
        Name = "RUN: Kll Geselda DONE - Run out";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2978.538 , 6334.343 , 96.14877 , "None"));
Path.Add(new Vector3(-2975.002 , 6336.771 , 96.17507 , "None"));
Path.Add(new Vector3(-2969.579 , 6342.338 , 96.15967 , "None"));
Path.Add(new Vector3(-2967.393 , 6348.246 , 96.14836 , "None"));
Path.Add(new Vector3(-2964.665 , 6356.522 , 96.18676 , "None"));
Path.Add(new Vector3(-2963.968 , 6361.319 , 96.18676 , "None"));
Path.Add(new Vector3(-2964.741 , 6369.203 , 96.18678 , "None"));
Path.Add(new Vector3(-2963.095 , 6372.707 , 96.19431 , "None"));
Path.Add(new Vector3(-2956.485 , 6375.236 , 96.21285 , "None"));
Path.Add(new Vector3(-2948.154 , 6378 , 94.80592 , "None"));
Path.Add(new Vector3(-2943.211 , 6379.64 , 93.27478 , "None"));
Path.Add(new Vector3(-2937.49 , 6381.538 , 90.62518 , "None"));
Path.Add(new Vector3(-2933.48 , 6383.814 , 88.62796 , "None"));
Path.Add(new Vector3(-2929.605 , 6390.076 , 87.10349 , "None"));
Path.Add(new Vector3(-2925.833 , 6398.877 , 84.9247 , "None"));
Path.Add(new Vector3(-2921.995 , 6406.988 , 82.28021 , "None"));
Path.Add(new Vector3(-2918.874 , 6410.675 , 82.2813 , "None"));
Path.Add(new Vector3(-2911.214 , 6416.836 , 82.42159 , "None"));
Path.Add(new Vector3(-2900.994 , 6421.673 , 82.66211 , "None"));
Path.Add(new Vector3(-2894.5 , 6423.217 , 82.40881 , "None"));
Path.Add(new Vector3(-2887.782 , 6423.341 , 82.48028 , "None"));
Path.Add(new Vector3(-2882.122 , 6421.027 , 82.94319 , "None"));
Path.Add(new Vector3(-2876.87 , 6415.313 , 82.21466 , "None"));
Path.Add(new Vector3(-2873.256 , 6410.171 , 81.29996 , "None"));
Path.Add(new Vector3(-2866.995 , 6406.13 , 80.49102 , "None"));
Path.Add(new Vector3(-2860.627 , 6405.681 , 79.43107 , "None"));
Path.Add(new Vector3(-2853.136 , 6406.696 , 77.60017 , "None"));
Path.Add(new Vector3(-2849.099 , 6407.244 , 76.57358 , "None"));
Path.Add(new Vector3(-2842.325 , 6408.589 , 74.80888 , "None"));
Path.Add(new Vector3(-2837.004 , 6413.918 , 72.61509 , "None"));
Path.Add(new Vector3(-2831.203 , 6419.954 , 69.91363 , "None"));
Path.Add(new Vector3(-2822.305 , 6426.748 , 65.60301 , "None"));
Path.Add(new Vector3(-2813.394 , 6431.441 , 63.26805 , "None"));
Path.Add(new Vector3(-2805.927 , 6434.323 , 62.74091 , "None"));
Path.Add(new Vector3(-2798.877 , 6434.868 , 62.6862 , "None"));
Path.Add(new Vector3(-2790.37 , 6433.279 , 62.10361 , "None"));
Path.Add(new Vector3(-2779.865 , 6430.797 , 60.56065 , "None"));
Path.Add(new Vector3(-2769.833 , 6428.325 , 57.62872 , "None"));
Path.Add(new Vector3(-2758.934 , 6424.979 , 53.23596 , "None"));
Path.Add(new Vector3(-2751.167 , 6418.992 , 50.08897 , "None"));
Path.Add(new Vector3(-2742.533 , 6412.48 , 46.75667 , "None"));
Path.Add(new Vector3(-2731.997 , 6407.609 , 42.66881 , "None"));
Path.Add(new Vector3(-2721.929 , 6405.406 , 40.33487 , "None"));
Path.Add(new Vector3(-2711.331 , 6402.961 , 38.50653 , "None"));
Path.Add(new Vector3(-2699.784 , 6398.562 , 37.89257 , "None"));
Path.Add(new Vector3(-2688.476 , 6390.438 , 36.98712 , "None"));
Path.Add(new Vector3(-2679.344 , 6374.671 , 36.59733 , "None"));
Path.Add(new Vector3(-2669.74 , 6346.141 , 37.08691 , "None"));
Path.Add(new Vector3(-2663.537 , 6331.58 , 37.55656 , "None"));
IsCompleteWhenAtLastPath = false;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNToBossforWANTEDGielda : QuestFollowPathClass
{
    public RUNToBossforWANTEDGielda()
    {
        Name = "RUN: To Boss for WANTED Gielda";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2470.606 , 6450.432 , 22.75758 , "None"));
Path.Add(new Vector3(-2476.266 , 6490.919 , 18.94536 , "None"));
Path.Add(new Vector3(-2493.071 , 6519.586 , 13.27397 , "None"));
Path.Add(new Vector3(-2517.443 , 6542.667 , 9.782043 , "None"));
Path.Add(new Vector3(-2536.306 , 6556.531 , 8.832258 , "None"));
Path.Add(new Vector3(-2564.178 , 6568.993 , 8.391966 , "None"));
Path.Add(new Vector3(-2584.988 , 6578.552 , 11.97697 , "None"));
Path.Add(new Vector3(-2616.271 , 6591.792 , 13.98217 , "None"));
Path.Add(new Vector3(-2647.752 , 6609.33 , 13.42189 , "None"));
Path.Add(new Vector3(-2676.41 , 6613.024 , 15.96246 , "None"));
Path.Add(new Vector3(-2704.508 , 6607.981 , 18.49088 , "None"));
Path.Add(new Vector3(-2723.863 , 6603.887 , 22.19181 , "None"));
Path.Add(new Vector3(-2740.353 , 6607.7 , 24.8059 , "None"));
Path.Add(new Vector3(-2771.929 , 6619.359 , 25.61348 , "None"));
Path.Add(new Vector3(-2806.431 , 6633.561 , 26.50441 , "None"));
Path.Add(new Vector3(-2817.2 , 6628.916 , 27.08344 , "None"));
Path.Add(new Vector3(-2837.658 , 6610.947 , 33.58445 , "None"));
Path.Add(new Vector3(-2864.329 , 6586.579 , 45.57154 , "None"));
Path.Add(new Vector3(-2887.82 , 6565.577 , 50.68064 , "None"));
Path.Add(new Vector3(-2914.786 , 6544.727 , 63.7749 , "None"));
Path.Add(new Vector3(-2925.897 , 6532.146 , 70.06726 , "None"));
Path.Add(new Vector3(-2930.24 , 6521.075 , 74.91643 , "None"));
Path.Add(new Vector3(-2929.936 , 6510.594 , 78.70058 , "None"));
Path.Add(new Vector3(-2932.46 , 6500.734 , 81.81422 , "None"));
Path.Add(new Vector3(-2934.587 , 6490.29 , 82.48305 , "None"));
Path.Add(new Vector3(-2934.153 , 6483.822 , 82.48573 , "None"));
Path.Add(new Vector3(-2933.742 , 6478.027 , 82.40617 , "None"));
Path.Add(new Vector3(-2933.933 , 6471.376 , 82.25435 , "None"));
Path.Add(new Vector3(-2933.709 , 6464.499 , 82.47594 , "None"));
Path.Add(new Vector3(-2933.59 , 6460.868 , 82.60411 , "None"));
Path.Add(new Vector3(-2932.832 , 6457.42 , 82.65576 , "None"));
Path.Add(new Vector3(-2931.403 , 6453.975 , 82.6183 , "None"));
Path.Add(new Vector3(-2929.848 , 6447.175 , 82.42531 , "None"));
Path.Add(new Vector3(-2927.747 , 6440.468 , 82.34833 , "None"));
Path.Add(new Vector3(-2926.659 , 6436.995 , 82.3553 , "None"));
Path.Add(new Vector3(-2925.582 , 6433.555 , 82.33939 , "None"));
Path.Add(new Vector3(-2924.521 , 6430.168 , 82.3317 , "None"));
Path.Add(new Vector3(-2922.46 , 6423.588 , 82.32451 , "None"));
Path.Add(new Vector3(-2921.374 , 6420.121 , 82.32451 , "None"));
Path.Add(new Vector3(-2920.273 , 6416.607 , 82.32136 , "None"));
Path.Add(new Vector3(-2916.841 , 6410.683 , 82.29809 , "None"));
Path.Add(new Vector3(-2914.25 , 6408.217 , 82.28405 , "None"));
Path.Add(new Vector3(-2912.141 , 6405.339 , 81.92548 , "None"));
Path.Add(new Vector3(-2909.193 , 6399.036 , 81.93593 , "None"));
Path.Add(new Vector3(-2911.354 , 6393.264 , 82.68112 , "None"));
Path.Add(new Vector3(-2908.842 , 6390.83 , 82.54333 , "None"));
Path.Add(new Vector3(-2910.807 , 6387.667 , 83.64972 , "None"));
Path.Add(new Vector3(-2917.452 , 6386.755 , 85.081 , "None"));
Path.Add(new Vector3(-2920.882 , 6387.337 , 85.72261 , "None"));
Path.Add(new Vector3(-2926.968 , 6388.834 , 86.66822 , "None"));
Path.Add(new Vector3(-2929.437 , 6386.317 , 87.20547 , "None"));
Path.Add(new Vector3(-2932.357 , 6384.248 , 87.80862 , "None"));
Path.Add(new Vector3(-2935.164 , 6382.534 , 89.49751 , "None"));
Path.Add(new Vector3(-2938.451 , 6380.786 , 91.17782 , "None"));
Path.Add(new Vector3(-2941.454 , 6379.357 , 92.72968 , "None"));
Path.Add(new Vector3(-2944.928 , 6377.889 , 93.91538 , "None"));
Path.Add(new Vector3(-2948.231 , 6376.71 , 94.96426 , "None"));
Path.Add(new Vector3(-2951.739 , 6375.682 , 96.11036 , "None"));
Path.Add(new Vector3(-2958.328 , 6373.677 , 96.21215 , "None"));
Path.Add(new Vector3(-2961.898 , 6372.695 , 96.2039 , "None"));
Path.Add(new Vector3(-2964.461 , 6368.086 , 96.18695 , "None"));
Path.Add(new Vector3(-2963.74 , 6364.426 , 96.18695 , "None"));
Path.Add(new Vector3(-2963.429 , 6360.826 , 96.1849 , "None"));
Path.Add(new Vector3(-2963.944 , 6357.337 , 96.1853 , "None"));
Path.Add(new Vector3(-2964.704 , 6353.837 , 96.18377 , "None"));
Path.Add(new Vector3(-2966.995 , 6347.125 , 96.14784 , "None"));
Path.Add(new Vector3(-2970.532 , 6341.265 , 96.174 , "None"));
Path.Add(new Vector3(-2972.896 , 6338.516 , 96.17425 , "None"));
Path.Add(new Vector3(-2975.601 , 6336.02 , 96.17506 , "None"));
Path.Add(new Vector3(-2978.715 , 6334.251 , 96.14603 , "None"));
Path.Add(new Vector3(-2982.352 , 6333.078 , 96.13627 , "None"));
Path.Add(new Vector3(-2984.541 , 6336.698 , 96.14921 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class ClefthoofMastery : QuestGrinderClass
{
    public ClefthoofMastery()
    {
        Name = "Clefthoof Mastery";

        QuestId.AddRange(new[] { 9789 });

        Step = new List<int> { 30, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18205);
EntryTarget.Add(18684);
HotSpots.Add(new Vector3(-1437.971 , 6310.896 , 40.67657 , "None"));
HotSpots.Add(new Vector3(-1665.188 , 6439.176 , 31.06462 , "None"));
HotSpots.Add(new Vector3(-1563.925 , 6789.884 , 1.058186 , "None"));
HotSpots.Add(new Vector3(-1718.82 , 6674.4 , -17.15408 , "None"));
HotSpots.Add(new Vector3(-1814.371 , 6862.708 , -37.27616 , "None"));
HotSpots.Add(new Vector3(-1790.943 , 7099.062 , -17.46799 , "None"));
HotSpots.Add(new Vector3(-1437.77 , 6859.087 , 15.76191 , "None"));
HotSpots.Add(new Vector3(-2143.778 , 6258.015 , 65.24683 , "None"));
HotSpots.Add(new Vector3(-2534.251 , 6406.685 , 25.8247 , "None"));
HotSpots.Add(new Vector3(-2582.341 , 6606.078 , 6.526693 , "None"));
HotSpots.Add(new Vector3(-2701.101 , 6538.555 , 29.73313 , "None"));
HotSpots.Add(new Vector3(-2763.986 , 6773.234 , -0.2133679 , "None"));
HotSpots.Add(new Vector3(-2768.817 , 6903.762 , -17.37319 , "None"));
HotSpots.Add(new Vector3(-2458.986 , 7119.277 , -15.40836 , "None"));
HotSpots.Add(new Vector3(-2324.597 , 7070.896 , -16.09622 , "None"));
HotSpots.Add(new Vector3(-2172.627 , 6877.123 , -6.962801 , "None"));
HotSpots.Add(new Vector3(-1769.849 , 6716.625 , -21.56219 , "None"));
HotSpots.Add(new Vector3(-1909.621 , 6572.121 , 11.62437 , "None"));
HotSpots.Add(new Vector3(-1899.751 , 6444.702 , 30.9308 , "None"));
HotSpots.Add(new Vector3(-2214.618 , 6319.562 , 41.05996 , "None"));
HotSpots.Add(new Vector3(-2624.944 , 6402.928 , 31.35639 , "None"));
HotSpots.Add(new Vector3(-2702.736 , 6567.418 , 26.29571 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WindrocMastery : QuestGrinderClass
{
    public WindrocMastery()
    {
        Name = "Windroc Mastery";

        QuestId.AddRange(new[] { 9854 });

        Step = new List<int> { 30, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(17128);
HotSpots.Add(new Vector3(-1303.944 , 6266.602 , 46.81145 , "None"));
HotSpots.Add(new Vector3(-1425.157 , 6521.979 , 33.78417 , "None"));
HotSpots.Add(new Vector3(-1410.181 , 6620.504 , 44.14308 , "None"));
HotSpots.Add(new Vector3(-1257.782 , 6800.446 , 37.13467 , "None"));
HotSpots.Add(new Vector3(-1411.691 , 6889.519 , 18.74078 , "None"));
HotSpots.Add(new Vector3(-1725.068 , 6307.148 , 49.12093 , "None"));
HotSpots.Add(new Vector3(-1529.83 , 6506.652 , 21.74173 , "None"));
HotSpots.Add(new Vector3(-1397.809 , 6282.278 , 49.04123 , "None"));
HotSpots.Add(new Vector3(-1276.424 , 6246.223 , 49.36094 , "None"));
HotSpots.Add(new Vector3(-1429.343 , 6468.695 , 30.24916 , "None"));
HotSpots.Add(new Vector3(-1458.459 , 6563.482 , 30.42953 , "None"));
HotSpots.Add(new Vector3(-1337.258 , 6680.523 , 42.86426 , "None"));
HotSpots.Add(new Vector3(-1352.191 , 6775.439 , 31.89174 , "None"));
HotSpots.Add(new Vector3(-1242.347 , 6822.204 , 39.57658 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TalbukMastery : QuestGrinderClass
{
    public TalbukMastery()
    {
        Name = "Talbuk Mastery";

        QuestId.AddRange(new[] { 9857 });

        Step = new List<int> { 30, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(17130);
HotSpots.Add(new Vector3(-1342.851 , 6272.125 , 50.76221 , "None"));
HotSpots.Add(new Vector3(-2184.651 , 6288.388 , 53.27918 , "None"));
HotSpots.Add(new Vector3(-2306.11 , 6307.604 , 36.94295 , "None"));
HotSpots.Add(new Vector3(-2441.559 , 6359.968 , 29.30287 , "None"));
HotSpots.Add(new Vector3(-2718.858 , 6505.097 , 33.90903 , "None"));
HotSpots.Add(new Vector3(-2667.767 , 6675.541 , -1.217184 , "None"));
HotSpots.Add(new Vector3(-2721.84 , 6712.601 , 4.683259 , "None"));
HotSpots.Add(new Vector3(-2215.276 , 6862.251 , -8.313778 , "None"));
HotSpots.Add(new Vector3(-2233.441 , 6692.254 , -1.79962 , "None"));
HotSpots.Add(new Vector3(-2212.652 , 6566.117 , 6.131867 , "None"));
HotSpots.Add(new Vector3(-2123.624 , 6465.321 , 13.65549 , "None"));
HotSpots.Add(new Vector3(-2000.624 , 6443.429 , 26.93574 , "None"));
HotSpots.Add(new Vector3(-1761.949 , 6391.09 , 40.16079 , "None"));
HotSpots.Add(new Vector3(-1684.266 , 6302.945 , 54.9387 , "None"));
HotSpots.Add(new Vector3(-1623.227 , 6305.525 , 50.59307 , "None"));
HotSpots.Add(new Vector3(-1352.946 , 6268.88 , 51.75241 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ClefthoofMasteryPart2 : QuestGrinderClass
{
    public ClefthoofMasteryPart2()
    {
        Name = "Clefthoof Mastery - Part 2";

        QuestId.AddRange(new[] { 9850 });

        Step = new List<int> { 30, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9789;

        EntryTarget.Add(17156);
HotSpots.Add(new Vector3(-1979.248 , 6834.352 , -76.73595 , "None"));
HotSpots.Add(new Vector3(-1834.18 , 6691.954 , -46.10174 , "None"));
HotSpots.Add(new Vector3(-1814.083 , 6791.316 , -36.17162 , "None"));
HotSpots.Add(new Vector3(-1529.826 , 6338.014 , 61.92944 , "None"));
HotSpots.Add(new Vector3(-1567.047 , 6253.675 , 70.45541 , "None"));
HotSpots.Add(new Vector3(-1328.814 , 6484.148 , 74.1424 , "None"));
HotSpots.Add(new Vector3(-1301.466 , 6550.523 , 80.00769 , "None"));
HotSpots.Add(new Vector3(-1412.784 , 6642.858 , 48.98998 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WindrocMasteryPart2 : QuestGrinderClass
{
    public WindrocMasteryPart2()
    {
        Name = "Windroc Mastery - Part 2";

        QuestId.AddRange(new[] { 9855 });

        Step = new List<int> { 30, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9854;

        EntryTarget.Add(18220);
HotSpots.Add(new Vector3(-2183.725 , 7476.482 , -33.39259 , "None"));
HotSpots.Add(new Vector3(-2229.771 , 7662.803 , -14.208 , "None"));
HotSpots.Add(new Vector3(-2350.636 , 7579.044 , -7.415783 , "None"));
HotSpots.Add(new Vector3(-2100.674 , 7469.022 , -21.77725 , "None"));
HotSpots.Add(new Vector3(-1983.669 , 7900.998 , -32.02617 , "None"));
HotSpots.Add(new Vector3(-2167.969 , 7730.677 , -21.13216 , "None"));
HotSpots.Add(new Vector3(-2220.188 , 7594.628 , -19.84998 , "None"));
HotSpots.Add(new Vector3(-2103.25 , 7543.809 , -41.40984 , "None"));
HotSpots.Add(new Vector3(-2293.387 , 7501.736 , -12.26084 , "None"));
HotSpots.Add(new Vector3(-2359.476 , 7620.216 , -5.556324 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TalbukMasteryPart2 : QuestGrinderClass
{
    public TalbukMasteryPart2()
    {
        Name = "Talbuk Mastery - Part 2";

        QuestId.AddRange(new[] { 9858 });

        Step = new List<int> { 30, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9857;

        EntryTarget.Add(17131);
HotSpots.Add(new Vector3(-1741.029 , 7348.872 , -2.573054 , "None"));
HotSpots.Add(new Vector3(-1759.285 , 7556.45 , -7.407301 , "None"));
HotSpots.Add(new Vector3(-1697.729 , 7713.674 , -18.86702 , "None"));
HotSpots.Add(new Vector3(-1522.407 , 7672.937 , -10.65271 , "None"));
HotSpots.Add(new Vector3(-1538.391 , 7518.625 , -4.707166 , "None"));
HotSpots.Add(new Vector3(-1427.722 , 7391.675 , 8.124714 , "None"));
HotSpots.Add(new Vector3(-1332.871 , 7548.276 , 8.063499 , "None"));
HotSpots.Add(new Vector3(-1151.934 , 7657.82 , 14.43325 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ImSaved : QuestClass
{
    public ImSaved()
    {
        Name = "I'm Saved!";

        QuestId.AddRange(new[] { 9897 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ARareBean : QuestGathererClass
{
    public ARareBean()
    {
        Name = "A Rare Bean";

        QuestId.AddRange(new[] { 9800 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(182128);
HotSpots.Add(new Vector3(-858.572 , 7291.301 , 33.14174 , "None"));
HotSpots.Add(new Vector3(-776.7547 , 7371.447 , 45.96286 , "None"));
HotSpots.Add(new Vector3(-721.1366 , 7454.774 , 64.18887 , "None"));
HotSpots.Add(new Vector3(-790.842 , 7451.519 , 54.26536 , "None"));
HotSpots.Add(new Vector3(-831.1957 , 7450.374 , 43.89574 , "None"));
HotSpots.Add(new Vector3(-932.1778 , 7426.652 , 34.46435 , "None"));
HotSpots.Add(new Vector3(-964.6541 , 7377.046 , 33.98473 , "None"));
HotSpots.Add(new Vector3(-990.1324 , 7376.49 , 34.57717 , "None"));
HotSpots.Add(new Vector3(-1075.164 , 7380.896 , 34.48752 , "None"));
HotSpots.Add(new Vector3(-950.1877 , 7507.005 , 35.61006 , "None"));
HotSpots.Add(new Vector3(-733.3652 , 7478.74 , 62.33553 , "None"));
HotSpots.Add(new Vector3(-695.8513 , 7463.812 , 65.21206 , "None"));
HotSpots.Add(new Vector3(-777.1796 , 7369.396 , 45.6937 , "None"));
HotSpots.Add(new Vector3(-671.6926 , 7210.185 , 53.16725 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MuckDiving : QuestGrinderClass
{
    public MuckDiving()
    {
        Name = "Muck Diving";

        QuestId.AddRange(new[] { 9815 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(17154);
HotSpots.Add(new Vector3(-1311.626 , 7987.887 , -96.44119 , "None"));
HotSpots.Add(new Vector3(-1496.565 , 8012.628 , -103.7341 , "Swimming"));
HotSpots.Add(new Vector3(-1540.567 , 7795.821 , -103.0663 , "None"));
HotSpots.Add(new Vector3(-1726.177 , 7826.28 , -102.9959 , "None"));
HotSpots.Add(new Vector3(-1773.595 , 7916.845 , -101.178 , "None"));
HotSpots.Add(new Vector3(-1608.05 , 8093.23 , -103.1195 , "None"));
HotSpots.Add(new Vector3(-1367.769 , 8102.11 , -100.9343 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheUnderneath : QuestClass
{
    public TheUnderneath()
    {
        Name = "The Underneath";

        QuestId.AddRange(new[] { 9818 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheTorturedEarth : QuestGrinderClass
{
    public TheTorturedEarth()
    {
        Name = "The Tortured Earth";

        QuestId.AddRange(new[] { 9819 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9818;

        EntryTarget.Add(17156);
EntryTarget.Add(17158);
HotSpots.Add(new Vector3(-1863.719 , 6721.107 , -62.62481 , "None"));
HotSpots.Add(new Vector3(-1997.001 , 6985.412 , -88.15891 , "None"));
HotSpots.Add(new Vector3(-1914.433 , 7157.773 , -94.57015 , "None"));
HotSpots.Add(new Vector3(-2233.675 , 7106.296 , -18.04008 , "None"));
HotSpots.Add(new Vector3(-1855.827 , 6707.9 , -59.2263 , "None"));
HotSpots.Add(new Vector3(-1419.662 , 6617.304 , 39.36749 , "None"));
HotSpots.Add(new Vector3(-1325.165 , 6536.835 , 67.94417 , "None"));
HotSpots.Add(new Vector3(-1488.925 , 6261.925 , 56.19406 , "None"));
HotSpots.Add(new Vector3(-1642.026 , 6242.521 , 75.63772 , "None"));
HotSpots.Add(new Vector3(-1415.871 , 6641.22 , 49.43573 , "None"));
HotSpots.Add(new Vector3(-1321.744 , 6547.891 , 73.57907 , "None"));
HotSpots.Add(new Vector3(-1869.053 , 6740.537 , -63.53688 , "None"));
HotSpots.Add(new Vector3(-1978.874 , 6883.76 , -84.67081 , "None"));
HotSpots.Add(new Vector3(-2017.123 , 6993.534 , -85.86636 , "None"));
HotSpots.Add(new Vector3(-1931.198 , 7106.59 , -92.96372 , "None"));
HotSpots.Add(new Vector3(-2130.806 , 7198.305 , -107.8242 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AgitatedSpiritsofSkysong : QuestGrinderClass
{
    public AgitatedSpiritsofSkysong()
    {
        Name = "Agitated Spirits of Skysong";

        QuestId.AddRange(new[] { 9804 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9800;

        EntryTarget.Add(17153);
HotSpots.Add(new Vector3(-991.5309 , 6968.455 , 21.10038 , "Swimming"));
HotSpots.Add(new Vector3(-1096.006 , 6887.602 , 0.9871447 , "Swimming"));
HotSpots.Add(new Vector3(-1109.633 , 7056.728 , 1.003592 , "Swimming"));
HotSpots.Add(new Vector3(-1054.948 , 7180.989 , 17.422 , "Swimming"));
HotSpots.Add(new Vector3(-966.6616 , 7298.226 , 25.78931 , "Swimming"));
HotSpots.Add(new Vector3(-917.263 , 7292.694 , 26.30122 , "Swimming"));
HotSpots.Add(new Vector3(-933.2825 , 7038.364 , 26.06145 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WANTEDZorbotheAdvisor : QuestGrinderClass
{
    public WANTEDZorbotheAdvisor()
    {
        Name = "WANTED: Zorbo the Advisor";

        QuestId.AddRange(new[] { 9940 });

        Step = new List<int> { 1, 10, 10, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18413);
EntryTarget.Add(18064);
EntryTarget.Add(17138);
HotSpots.Add(new Vector3(-630.8943 , 7730.956 , 84.46464 , "None"));
HotSpots.Add(new Vector3(-746.535 , 7693.35 , 74.9062 , "None"));
HotSpots.Add(new Vector3(-816.7339 , 7623.539 , 45.95673 , "None"));
HotSpots.Add(new Vector3(-795.262 , 7682.046 , 46.19496 , "None"));
HotSpots.Add(new Vector3(-756.329 , 7788.525 , 48.66917 , "None"));
HotSpots.Add(new Vector3(-764.3973 , 7919.574 , 59.21721 , "None"));
HotSpots.Add(new Vector3(-809.8798 , 7808.285 , 38.83084 , "None"));
HotSpots.Add(new Vector3(-824.0537 , 7683.712 , 40.91085 , "None"));
HotSpots.Add(new Vector3(-735.1595 , 7601.547 , 57.63282 , "None"));
HotSpots.Add(new Vector3(-813.3285 , 7579.434 , 50.77342 , "None"));
HotSpots.Add(new Vector3(-822.1 , 7637.025 , 44.49551 , "None"));
HotSpots.Add(new Vector3(-804.1656 , 7684.961 , 44.45976 , "None"));
HotSpots.Add(new Vector3(-817.5457 , 7706.407 , 41.34266 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNZorboRunToHim : QuestFollowPathClass
{
    public RUNZorboRunToHim()
    {
        Name = "RUN: Zorbo- Run To Him";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-850.1467 , 7806.25 , 39.78477 , "None"));
Path.Add(new Vector3(-841.5696 , 7802.284 , 39.72015 , "None"));
Path.Add(new Vector3(-832.7016 , 7799.791 , 38.74566 , "None"));
Path.Add(new Vector3(-824.9734 , 7798.621 , 38.5053 , "None"));
Path.Add(new Vector3(-820.4993 , 7798.303 , 39.17041 , "None"));
Path.Add(new Vector3(-816.5961 , 7799.953 , 39.2219 , "None"));
Path.Add(new Vector3(-812.8439 , 7804.158 , 39.22003 , "None"));
Path.Add(new Vector3(-804.9012 , 7799.435 , 36.17915 , "None"));
Path.Add(new Vector3(-797.319 , 7792.635 , 36.18678 , "None"));
Path.Add(new Vector3(-790.2959 , 7787.786 , 38.56527 , "None"));
Path.Add(new Vector3(-786.179 , 7786.68 , 39.31458 , "None"));
Path.Add(new Vector3(-778.8851 , 7785.095 , 40.94971 , "None"));
Path.Add(new Vector3(-773.0341 , 7783.672 , 43.08204 , "None"));
Path.Add(new Vector3(-764.3235 , 7778.053 , 49.11959 , "None"));
Path.Add(new Vector3(-755.3608 , 7772.191 , 55.2332 , "None"));
Path.Add(new Vector3(-746.6964 , 7766.64 , 62.28281 , "None"));
Path.Add(new Vector3(-736.532 , 7761.125 , 67.26012 , "None"));
Path.Add(new Vector3(-727.0688 , 7757.779 , 68.507 , "None"));
Path.Add(new Vector3(-716.8546 , 7754.29 , 73.53497 , "None"));
Path.Add(new Vector3(-707.0892 , 7750.982 , 78.78092 , "None"));
Path.Add(new Vector3(-703.1555 , 7749.572 , 79.99311 , "None"));
Path.Add(new Vector3(-697.6331 , 7750.259 , 81.3784 , "None"));
Path.Add(new Vector3(-691.2592 , 7760.852 , 85.01274 , "None"));
Path.Add(new Vector3(-685.9113 , 7766.538 , 87.29055 , "None"));
Path.Add(new Vector3(-682.5338 , 7768.267 , 87.83298 , "None"));
Path.Add(new Vector3(-678.6879 , 7769.248 , 87.86378 , "None"));
Path.Add(new Vector3(-671.9846 , 7771.884 , 87.65872 , "None"));
Path.Add(new Vector3(-667.3054 , 7772.386 , 87.59611 , "None"));
Path.Add(new Vector3(-662.6038 , 7772.719 , 89.16681 , "None"));
Path.Add(new Vector3(-656.4647 , 7770.819 , 88.63943 , "None"));
Path.Add(new Vector3(-658.6691 , 7765.567 , 87.71794 , "None"));
Path.Add(new Vector3(-664.2323 , 7759.094 , 85.51763 , "None"));
Path.Add(new Vector3(-671.53 , 7750.713 , 84.77338 , "None"));
Path.Add(new Vector3(-677.0003 , 7743.366 , 84.22157 , "None"));
Path.Add(new Vector3(-673.0903 , 7745.064 , 84.35744 , "None"));
Path.Add(new Vector3(-666.6746 , 7749.248 , 85.06223 , "None"));
Path.Add(new Vector3(-661.7141 , 7750.322 , 85.23373 , "None"));
Path.Add(new Vector3(-658.0394 , 7749.319 , 86.05695 , "None"));
Path.Add(new Vector3(-655.4185 , 7745.864 , 86.45703 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class EatingDamnation : QuestGrinderClass
{
    public EatingDamnation()
    {
        Name = "Eating Damnation";

        QuestId.AddRange(new[] { 9821 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9819;

        EntryTarget.Add(18062);
HotSpots.Add(new Vector3(-686.4775 , 7238.266 , 61.04979 , "None"));
HotSpots.Add(new Vector3(-738.312 , 7321.858 , 61.3918 , "None"));
HotSpots.Add(new Vector3(-673.9396 , 7440.144 , 72.34383 , "None"));
HotSpots.Add(new Vector3(-650.5253 , 7576.001 , 98.54191 , "None"));
HotSpots.Add(new Vector3(-1393.189 , 7740.653 , -36.20068 , "None"));
HotSpots.Add(new Vector3(-1362.068 , 7894.453 , -96.56567 , "None"));
HotSpots.Add(new Vector3(-1873.244 , 7750.226 , -95.96017 , "None"));
HotSpots.Add(new Vector3(-1921.947 , 7722.36 , -92.69359 , "None"));
HotSpots.Add(new Vector3(-1872.86 , 7937.701 , -61.41175 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ShatteringtheVeil : QuestUseItemOnClass
{
    public ShatteringtheVeil()
    {
        Name = "Shattering the Veil";

        QuestId.AddRange(new[] { 9849 });

        Step = new List<int> { 30, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9821;

        EntryIdTarget.Add(17157);
HotSpots.Add(new Vector3(-2316.736 , 8721.532 , -7.366107 , "None"));
HotSpots.Add(new Vector3(-2377.711 , 8738.105 , 7.834188 , "None"));
HotSpots.Add(new Vector3(-2387.935 , 8684.602 , -13.86988 , "None"));
HotSpots.Add(new Vector3(-2475.805 , 8687.729 , -17.29221 , "None"));
HotSpots.Add(new Vector3(-2541.862 , 8711.552 , -4.462383 , "None"));
HotSpots.Add(new Vector3(-2649.604 , 8783.147 , -12.98807 , "None"));
HotSpots.Add(new Vector3(-2586.569 , 8957.758 , -4.464566 , "None"));
HotSpots.Add(new Vector3(-2750.287 , 8710.938 , -31.01427 , "None"));
HotSpots.Add(new Vector3(-2929.72 , 8655.255 , -35.69021 , "None"));
HotSpots.Add(new Vector3(-2918.251 , 8548.027 , -27.01724 , "None"));
HotSpots.Add(new Vector3(-2926.344 , 8482.367 , -25.98815 , "None"));
HotSpots.Add(new Vector3(-2960.162 , 8342.563 , -28.17223 , "None"));
HotSpots.Add(new Vector3(-2988.474 , 8147.571 , -23.93089 , "None"));
HotSpots.Add(new Vector3(-3007.782 , 8031.276 , -14.26947 , "None"));
HotSpots.Add(new Vector3(-2666.791 , 7949.205 , -20.4244 , "None"));
ItemId = 24501;
Range = 26f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BlessingofIncineratus : QuestUseItemOnClass
{
    public BlessingofIncineratus()
    {
        Name = "Blessing of Incineratus";

        QuestId.AddRange(new[] { 9805 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, true, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9804;

        EntryIdTarget.Add(300077);
HotSpots.Add(new Vector3(-1798.268 , 6293.728 , 59.27198 , "None"));
HotSpots.Add(new Vector3(-1841.629 , 6387.741 , 52.86546 , "None"));
HotSpots.Add(new Vector3(-1919.254 , 6360.213 , 56.00274 , "None"));
HotSpots.Add(new Vector3(-1974.312 , 6274.736 , 56.92573 , "None"));
ItemId = 24467;
Range = 6.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheSpiritPolluted : QuestGrinderClass
{
    public TheSpiritPolluted()
    {
        Name = "The Spirit Polluted";

        QuestId.AddRange(new[] { 9810 });

        Step = new List<int> { 1, 10, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 9805;

        EntryTarget.Add(17155);
EntryTarget.Add(18145);
HotSpots.Add(new Vector3(-1831.488 , 8470.521 , -69.67554 , "Swimming"));
HotSpots.Add(new Vector3(-1836.164 , 8563.668 , -48.00893 , "Swimming"));
HotSpots.Add(new Vector3(-1963.776 , 8554.066 , -34.17535 , "Swimming"));
HotSpots.Add(new Vector3(-1702.573 , 8321.923 , -55.61503 , "Swimming"));
HotSpots.Add(new Vector3(-1833.301 , 8468.549 , -69.25583 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MattersofSecurity : QuestGrinderClass
{
    public MattersofSecurity()
    {
        Name = "Matters of Security";

        QuestId.AddRange(new[] { 9925 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(17981);
HotSpots.Add(new Vector3(-2522.408 , 8507.632 , -37.25868 , "None"));
HotSpots.Add(new Vector3(-2333.764 , 8254.662 , -36.5197 , "None"));
HotSpots.Add(new Vector3(-2309.416 , 8095.683 , -36.82262 , "None"));
HotSpots.Add(new Vector3(-2484.692 , 8094.612 , -43.30101 , "None"));
HotSpots.Add(new Vector3(-2711.669 , 8126.061 , -47.84195 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Gavaxi : QuestGrinderClass
{
    public Gavaxi()
    {
        Name = "Gava'xi";

        QuestId.AddRange(new[] { 9900 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18298);
HotSpots.Add(new Vector3(-2664.54 , 7954.71 , -18.838 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class StealingfromThieves : QuestGathererClass
{
    public StealingfromThieves()
    {
        Name = "Stealing from Thieves";

        QuestId.AddRange(new[] { 9882 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(182258);
HotSpots.Add(new Vector3(-2537.954 , 7971.595 , -52.20828 , "None"));
HotSpots.Add(new Vector3(-2530.783 , 8049.75 , -48.3429 , "None"));
HotSpots.Add(new Vector3(-2555.135 , 8134.917 , -41.47323 , "None"));
HotSpots.Add(new Vector3(-2615.214 , 8129.697 , -42.80729 , "None"));
HotSpots.Add(new Vector3(-2761.052 , 8322.232 , -42.38722 , "None"));
HotSpots.Add(new Vector3(-2770.593 , 8563.662 , -36.04568 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AHeadFullofIvory : QuestGrinderClass
{
    public AHeadFullofIvory()
    {
        Name = "A Head Full of Ivory";

        QuestId.AddRange(new[] { 9914 });

        Step = new List<int> { 3, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18334);
EntryTarget.Add(17160);
HotSpots.Add(new Vector3(-2142.415 , 8129.129 , -17.52552 , "None"));
HotSpots.Add(new Vector3(-2173.804 , 8314.62 , -24.17289 , "None"));
HotSpots.Add(new Vector3(-2238.942 , 8664.297 , -8.430365 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNNagrandtoBladesEdgeMountain : QuestFollowPathClass
{
    public RUNNagrandtoBladesEdgeMountain()
    {
        Name = "RUN: Nagrand to Blades Edge Mountain";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-1220.296 , 7512.444 , 19.82591 , "None"));
Path.Add(new Vector3(-1212.913 , 7535.425 , 18.64225 , "None"));
Path.Add(new Vector3(-1213.57 , 7556.539 , 17.34875 , "None"));
Path.Add(new Vector3(-1220.039 , 7597.764 , 14.24 , "None"));
Path.Add(new Vector3(-1226.32 , 7624.383 , 12.33183 , "None"));
Path.Add(new Vector3(-1238.318 , 7655.56 , 10.48064 , "None"));
Path.Add(new Vector3(-1242.452 , 7670.755 , 9.633454 , "None"));
Path.Add(new Vector3(-1242.997 , 7686.925 , 9.02623 , "None"));
Path.Add(new Vector3(-1220.797 , 7713.15 , 10.64838 , "None"));
Path.Add(new Vector3(-1196.572 , 7742.835 , 11.85364 , "None"));
Path.Add(new Vector3(-1187.388 , 7756.024 , 11.75418 , "None"));
Path.Add(new Vector3(-1181.762 , 7770.073 , 11.97916 , "None"));
Path.Add(new Vector3(-1162.452 , 7802.516 , 12.89705 , "None"));
Path.Add(new Vector3(-1142 , 7837.275 , 14.36601 , "None"));
Path.Add(new Vector3(-1120.858 , 7873.124 , 15.67626 , "None"));
Path.Add(new Vector3(-1100.113 , 7907.585 , 16.52736 , "None"));
Path.Add(new Vector3(-1089.851 , 7924.615 , 18.1605 , "None"));
Path.Add(new Vector3(-1076.39 , 7934.927 , 19.58943 , "None"));
Path.Add(new Vector3(-1040.285 , 7953.094 , 21.6151 , "None"));
Path.Add(new Vector3(-1007.185 , 7976.65 , 23.42846 , "None"));
Path.Add(new Vector3(-975.8951 , 8002.33 , 24.61264 , "None"));
Path.Add(new Vector3(-958.4293 , 8017.92 , 26.8773 , "None"));
Path.Add(new Vector3(-944.7118 , 8037.001 , 25.19818 , "None"));
Path.Add(new Vector3(-924.6096 , 8073.019 , 21.40687 , "None"));
Path.Add(new Vector3(-933.7509 , 8099.981 , 19.0071 , "None"));
Path.Add(new Vector3(-940.0806 , 8115.968 , 16.30949 , "None"));
Path.Add(new Vector3(-945.4186 , 8126.095 , 11.64511 , "None"));
Path.Add(new Vector3(-950.3683 , 8136.709 , 8.464752 , "None"));
Path.Add(new Vector3(-955.783 , 8147.69 , 8.24785 , "None"));
Path.Add(new Vector3(-961.6116 , 8158.622 , 11.48741 , "None"));
Path.Add(new Vector3(-967.4589 , 8169.407 , 14.46507 , "None"));
Path.Add(new Vector3(-972.5065 , 8178.839 , 14.92363 , "None"));
Path.Add(new Vector3(-974.022 , 8188.414 , 15.95183 , "None"));
Path.Add(new Vector3(-973.3082 , 8198.799 , 16.38484 , "None"));
Path.Add(new Vector3(-972.7076 , 8205.524 , 16.92974 , "None"));
Path.Add(new Vector3(-971.4462 , 8213.582 , 17.39519 , "None"));
Path.Add(new Vector3(-969.9185 , 8220.665 , 17.60623 , "None"));
Path.Add(new Vector3(-966.4845 , 8232.682 , 18.3553 , "None"));
Path.Add(new Vector3(-964.1889 , 8243.68 , 19.00099 , "None"));
Path.Add(new Vector3(-961.4745 , 8256.612 , 19.31981 , "None"));
Path.Add(new Vector3(-955.5276 , 8272.913 , 19.80469 , "None"));
Path.Add(new Vector3(-938.9691 , 8294.557 , 21.35909 , "None"));
Path.Add(new Vector3(-924.0013 , 8313.217 , 23.40865 , "None"));
Path.Add(new Vector3(-906.6086 , 8330.932 , 24.59281 , "None"));
Path.Add(new Vector3(-886.5406 , 8345.184 , 25.89563 , "None"));
Path.Add(new Vector3(-866.1031 , 8358.262 , 27.86971 , "None"));
Path.Add(new Vector3(-842.751 , 8359.761 , 29.89608 , "None"));
Path.Add(new Vector3(-819.1446 , 8367.446 , 31.74941 , "None"));
Path.Add(new Vector3(-796.6864 , 8376.383 , 32.71312 , "None"));
Path.Add(new Vector3(-774.1762 , 8386.38 , 33.81924 , "None"));
Path.Add(new Vector3(-752.2272 , 8396.897 , 34.01025 , "None"));
Path.Add(new Vector3(-732.2954 , 8411.23 , 35.40205 , "None"));
Path.Add(new Vector3(-717.5227 , 8362.271 , 37.52225 , "None"));
Path.Add(new Vector3(-698.6479 , 8369.828 , 41.22527 , "None"));
Path.Add(new Vector3(-679.0483 , 8383.789 , 43.61732 , "None"));
Path.Add(new Vector3(-661.857 , 8400.513 , 42.04777 , "None"));
Path.Add(new Vector3(-649.1779 , 8421.088 , 44.38914 , "None"));
Path.Add(new Vector3(-633.0938 , 8438.158 , 51.37621 , "None"));
Path.Add(new Vector3(-608.6211 , 8442.384 , 59.86787 , "None"));
Path.Add(new Vector3(-584.5949 , 8442.76 , 64.44621 , "None"));
Path.Add(new Vector3(-560.39 , 8440.335 , 57.76186 , "None"));
Path.Add(new Vector3(-535.2721 , 8439.951 , 50.28307 , "None"));
Path.Add(new Vector3(-511.9018 , 8436.378 , 43.01638 , "None"));
Path.Add(new Vector3(-490.4692 , 8423.048 , 34.81172 , "None"));
Path.Add(new Vector3(-467.2924 , 8418.603 , 27.8176 , "None"));
Path.Add(new Vector3(-442.8823 , 8415.556 , 23.15986 , "None"));
Path.Add(new Vector3(-417.7495 , 8415.417 , 22.8818 , "None"));
Path.Add(new Vector3(-395.7544 , 8414.946 , 23.47796 , "None"));
Path.Add(new Vector3(-372.2564 , 8414.932 , 23.38521 , "None"));
Path.Add(new Vector3(-347.2417 , 8415.021 , 22.56907 , "None"));
Path.Add(new Vector3(-326.5029 , 8409.016 , 22.07387 , "None"));
Path.Add(new Vector3(-312.0747 , 8391.835 , 21.90825 , "None"));
Path.Add(new Vector3(-297.0914 , 8372.496 , 22.25656 , "None"));
Path.Add(new Vector3(-286.5287 , 8350.596 , 22.47469 , "None"));
Path.Add(new Vector3(-277.0258 , 8328.179 , 22.22231 , "None"));
Path.Add(new Vector3(-260.4047 , 8318.923 , 21.46462 , "None"));
Path.Add(new Vector3(-248.2445 , 8318.773 , 21.55376 , "None"));
Path.Add(new Vector3(-237.2312 , 8316.986 , 21.96319 , "None"));
Path.Add(new Vector3(-217.8161 , 8310.478 , 22.30799 , "None"));
Path.Add(new Vector3(-208.851 , 8304.085 , 21.75953 , "None"));
Path.Add(new Vector3(-198.8558 , 8295.49 , 21.43896 , "None"));
Path.Add(new Vector3(-190.5487 , 8286.585 , 21.68218 , "None"));
Path.Add(new Vector3(-184.0979 , 8276.65 , 22.08722 , "None"));
Path.Add(new Vector3(-177.8 , 8265.537 , 22.56448 , "None"));
Path.Add(new Vector3(-172.1113 , 8254.997 , 22.10079 , "None"));
Path.Add(new Vector3(-163.6456 , 8246.144 , 22.26236 , "None"));
Path.Add(new Vector3(-152.2438 , 8242.16 , 22.7063 , "None"));
Path.Add(new Vector3(-144.822 , 8223.218 , 22.97008 , "None"));
Path.Add(new Vector3(-135.7315 , 8214.534 , 22.80801 , "None"));
Path.Add(new Vector3(-118.3075 , 8207.022 , 23.73853 , "None"));
Path.Add(new Vector3(-105.5643 , 8207.37 , 24.35238 , "None"));
Path.Add(new Vector3(-93.77308 , 8205.362 , 23.37934 , "None"));
Path.Add(new Vector3(-81.76425 , 8202.854 , 22.14352 , "None"));
Path.Add(new Vector3(-70.9855 , 8198.103 , 22.20951 , "None"));
Path.Add(new Vector3(-59.39153 , 8192.185 , 22.31998 , "None"));
Path.Add(new Vector3(-48.56418 , 8187.397 , 22.45236 , "None"));
Path.Add(new Vector3(-37.35058 , 8181.646 , 22.35833 , "None"));
Path.Add(new Vector3(-27.81604 , 8174.569 , 22.53109 , "None"));
Path.Add(new Vector3(-17.28845 , 8168.14 , 22.41298 , "None"));
Path.Add(new Vector3(-6.257125 , 8161.793 , 22.32844 , "None"));
Path.Add(new Vector3(2.181888 , 8153.613 , 22.30822 , "None"));
Path.Add(new Vector3(8.912182 , 8143.281 , 22.59337 , "None"));
Path.Add(new Vector3(14.7891 , 8132.165 , 19.91634 , "None"));
Path.Add(new Vector3(19.82286 , 8122.045 , 17.37451 , "None"));
Path.Add(new Vector3(25.18384 , 8111.28 , 17.42011 , "None"));
Path.Add(new Vector3(31.481 , 8099.889 , 19.67138 , "None"));
Path.Add(new Vector3(37.28251 , 8089.391 , 22.21233 , "None"));
Path.Add(new Vector3(43.0069 , 8078.061 , 21.41092 , "None"));
Path.Add(new Vector3(47.67447 , 8067.187 , 20.48451 , "None"));
Path.Add(new Vector3(53.9771 , 8057.287 , 20.18933 , "None"));
Path.Add(new Vector3(66.06281 , 8056.371 , 21.65439 , "None"));
Path.Add(new Vector3(78.32767 , 8055.111 , 20.74009 , "None"));
Path.Add(new Vector3(90.62659 , 8053.431 , 19.84765 , "None"));
Path.Add(new Vector3(102.6805 , 8051.957 , 18.46868 , "None"));
Path.Add(new Vector3(114.6717 , 8053.271 , 17.37818 , "None"));
Path.Add(new Vector3(126.9384 , 8054.774 , 20.08506 , "None"));
Path.Add(new Vector3(138.3278 , 8057.564 , 22.85016 , "None"));
Path.Add(new Vector3(150.0993 , 8061.388 , 23.07367 , "None"));
Path.Add(new Vector3(161.5936 , 8066.847 , 22.42988 , "None"));
Path.Add(new Vector3(172.6713 , 8072.285 , 22.66921 , "None"));
Path.Add(new Vector3(183.4983 , 8076.976 , 23.28139 , "None"));
Path.Add(new Vector3(195.89 , 8080.294 , 22.70234 , "None"));
Path.Add(new Vector3(207.7755 , 8081.379 , 22.2025 , "None"));
Path.Add(new Vector3(218.9525 , 8078.745 , 18.73091 , "None"));
Path.Add(new Vector3(230.343 , 8073.395 , 17.38886 , "None"));
Path.Add(new Vector3(240.534 , 8067.254 , 17.37588 , "None"));
Path.Add(new Vector3(251.2839 , 8059.874 , 17.4005 , "None"));
Path.Add(new Vector3(261.1164 , 8052.824 , 18.26292 , "None"));
Path.Add(new Vector3(271.0924 , 8046.032 , 18.35388 , "None"));
Path.Add(new Vector3(282.3607 , 8040.183 , 17.55244 , "None"));
Path.Add(new Vector3(293.2519 , 8035.256 , 17.37533 , "None"));
Path.Add(new Vector3(304.6518 , 8030.662 , 17.66737 , "None"));
Path.Add(new Vector3(316.0741 , 8026.53 , 17.37448 , "None"));
Path.Add(new Vector3(327.7083 , 8022.715 , 17.37448 , "None"));
Path.Add(new Vector3(339.5221 , 8018.833 , 18.89067 , "None"));
Path.Add(new Vector3(350.3679 , 8013.803 , 21.23528 , "None"));
Path.Add(new Vector3(360.4997 , 8007.913 , 24.3474 , "None"));
Path.Add(new Vector3(369.8982 , 7999.486 , 24.14608 , "None"));
Path.Add(new Vector3(377.9216 , 7990.247 , 23.13412 , "None"));
Path.Add(new Vector3(383.336 , 7979.324 , 23.2109 , "None"));
Path.Add(new Vector3(387.6766 , 7968.134 , 23.14682 , "None"));
Path.Add(new Vector3(392.2086 , 7956.89 , 22.22707 , "None"));
Path.Add(new Vector3(397.1714 , 7945.197 , 19.50399 , "None"));
Path.Add(new Vector3(401.6871 , 7934.183 , 17.37409 , "None"));
Path.Add(new Vector3(408.353 , 7923.423 , 17.49356 , "None"));
Path.Add(new Vector3(416.5939 , 7914.127 , 17.68017 , "None"));
Path.Add(new Vector3(424.5726 , 7905.235 , 17.37536 , "None"));
Path.Add(new Vector3(432.3739 , 7895.642 , 17.37536 , "None"));
Path.Add(new Vector3(439.867 , 7886.421 , 18.6974 , "None"));
Path.Add(new Vector3(447.8141 , 7876.292 , 22.58995 , "None"));
Path.Add(new Vector3(455.0227 , 7866.605 , 23.29737 , "None"));
Path.Add(new Vector3(463.5382 , 7858.845 , 22.27195 , "None"));
Path.Add(new Vector3(475.2781 , 7854.085 , 22.89472 , "None"));
Path.Add(new Vector3(487.1688 , 7852.526 , 22.42557 , "None"));
Path.Add(new Vector3(499.7388 , 7851.065 , 21.9798 , "None"));
Path.Add(new Vector3(511.1769 , 7850.354 , 21.35563 , "None"));
Path.Add(new Vector3(524.0004 , 7850.416 , 20.9741 , "None"));
Path.Add(new Vector3(535.7853 , 7850.491 , 21.83478 , "None"));
Path.Add(new Vector3(548.5117 , 7851.186 , 22.03327 , "None"));
Path.Add(new Vector3(559.4146 , 7838.27 , 22.64468 , "None"));
Path.Add(new Vector3(562.4796 , 7826.667 , 19.91474 , "None"));
Path.Add(new Vector3(567.3102 , 7815.499 , 17.4698 , "None"));
Path.Add(new Vector3(573.1842 , 7804.263 , 17.652 , "None"));
Path.Add(new Vector3(587.375 , 7798.041 , 20.4909 , "None"));
Path.Add(new Vector3(599.3543 , 7798.387 , 22.16999 , "None"));
Path.Add(new Vector3(610.4585 , 7795.073 , 20.15934 , "None"));
Path.Add(new Vector3(621.1651 , 7788.438 , 18.04907 , "None"));
Path.Add(new Vector3(630.2102 , 7779.881 , 18.52248 , "None"));
Path.Add(new Vector3(637.5111 , 7770.358 , 20.97862 , "None"));
Path.Add(new Vector3(643.7876 , 7759.265 , 20.6614 , "None"));
Path.Add(new Vector3(647.7131 , 7747.975 , 19.31889 , "None"));
Path.Add(new Vector3(648.9465 , 7736.12 , 18.47388 , "None"));
Path.Add(new Vector3(647.0269 , 7724.005 , 18.20351 , "None"));
Path.Add(new Vector3(642.5895 , 7712.348 , 18.06754 , "None"));
Path.Add(new Vector3(642.4502 , 7700.638 , 17.37588 , "None"));
Path.Add(new Vector3(645.6884 , 7688.174 , 17.37421 , "None"));
Path.Add(new Vector3(649.0769 , 7677.063 , 17.37421 , "None"));
Path.Add(new Vector3(652.7708 , 7664.734 , 17.37421 , "None"));
Path.Add(new Vector3(655.3373 , 7653.678 , 17.37421 , "None"));
Path.Add(new Vector3(658.171 , 7641.165 , 17.74515 , "None"));
Path.Add(new Vector3(663.0406 , 7629.793 , 20.19029 , "None"));
Path.Add(new Vector3(668.0639 , 7619.025 , 21.34356 , "None"));
Path.Add(new Vector3(673.8342 , 7608.545 , 22.72739 , "None"));
Path.Add(new Vector3(681.0171 , 7597.991 , 22.84925 , "None"));
Path.Add(new Vector3(688.6144 , 7588.236 , 21.84891 , "None"));
Path.Add(new Vector3(696.7863 , 7579.281 , 22.95328 , "None"));
Path.Add(new Vector3(706.7816 , 7572.754 , 22.16674 , "None"));
Path.Add(new Vector3(718.5081 , 7567.815 , 20.67229 , "None"));
Path.Add(new Vector3(729.7922 , 7563.253 , 19.34453 , "None"));
Path.Add(new Vector3(741.1421 , 7558.294 , 17.89627 , "None"));
Path.Add(new Vector3(751.7712 , 7553.56 , 17.5797 , "None"));
Path.Add(new Vector3(763.5444 , 7548.726 , 17.53618 , "None"));
Path.Add(new Vector3(774.3124 , 7544.305 , 17.5957 , "None"));
Path.Add(new Vector3(785.5328 , 7538.08 , 17.6748 , "None"));
Path.Add(new Vector3(795.9603 , 7533.802 , 17.67425 , "None"));
Path.Add(new Vector3(806.8951 , 7526.48 , 17.68745 , "None"));
Path.Add(new Vector3(817.1499 , 7520.178 , 17.646 , "None"));
Path.Add(new Vector3(828.8275 , 7517.638 , 17.54083 , "None"));
Path.Add(new Vector3(840.7558 , 7514.358 , 17.77994 , "None"));
Path.Add(new Vector3(852.735 , 7510.59 , 17.75175 , "None"));
Path.Add(new Vector3(863.391 , 7506.688 , 17.85869 , "None"));
Path.Add(new Vector3(881.6157 , 7499.983 , 19.06599 , "None"));
Path.Add(new Vector3(896.2254 , 7505.314 , 18.85242 , "None"));
Path.Add(new Vector3(907.4412 , 7499.698 , 22.42745 , "None"));
Path.Add(new Vector3(913.5856 , 7488.586 , 22.75678 , "None"));
Path.Add(new Vector3(918.3714 , 7477.133 , 22.2955 , "None"));
Path.Add(new Vector3(921.2953 , 7465.885 , 21.93897 , "None"));
Path.Add(new Vector3(920.283 , 7453.597 , 22.98451 , "None"));
Path.Add(new Vector3(919.9256 , 7439.575 , 22.77908 , "None"));
Path.Add(new Vector3(921.6134 , 7426.967 , 19.49516 , "None"));
Path.Add(new Vector3(923.2512 , 7419.095 , 18.01162 , "None"));
Path.Add(new Vector3(925.4335 , 7407.268 , 18.33731 , "None"));
Path.Add(new Vector3(927.559 , 7395.75 , 20.11499 , "None"));
Path.Add(new Vector3(930.4758 , 7386.875 , 20.08877 , "None"));
Path.Add(new Vector3(932.7624 , 7382.214 , 19.90347 , "None"));
Path.Add(new Vector3(941.2386 , 7375.221 , 23.16854 , "None"));
Path.Add(new Vector3(947.0032 , 7372.987 , 25.77464 , "None"));
Path.Add(new Vector3(952.1446 , 7371.016 , 27.88574 , "None"));
Path.Add(new Vector3(968.0606 , 7372.242 , 29.43312 , "None"));
Path.Add(new Vector3(979.954 , 7370.212 , 32.05486 , "None"));
Path.Add(new Vector3(987.0633 , 7368.828 , 35.41481 , "None"));
Path.Add(new Vector3(993.827 , 7366.833 , 35.81465 , "None"));
Path.Add(new Vector3(1001.463 , 7360.106 , 36.41543 , "None"));
Path.Add(new Vector3(1007.452 , 7349.957 , 36.70457 , "None"));
Path.Add(new Vector3(1012.853 , 7341.405 , 36.68101 , "None"));
Path.Add(new Vector3(1014.762 , 7329.919 , 39.65604 , "None"));
Path.Add(new Vector3(1015.608 , 7316.93 , 41.61024 , "None"));
Path.Add(new Vector3(1016.172 , 7304.845 , 45.27469 , "None"));
Path.Add(new Vector3(1016.102 , 7292.865 , 49.05385 , "None"));
Path.Add(new Vector3(1015.615 , 7280.318 , 52.84197 , "None"));
Path.Add(new Vector3(1014.91 , 7268.264 , 54.93608 , "None"));
Path.Add(new Vector3(1014.524 , 7256.026 , 58.60769 , "None"));
Path.Add(new Vector3(1013.898 , 7244.429 , 62.41233 , "None"));
Path.Add(new Vector3(1012.957 , 7229.621 , 67.5021 , "None"));
Path.Add(new Vector3(1014.288 , 7204.765 , 76.05653 , "None"));
Path.Add(new Vector3(1015.69 , 7180.196 , 84.28712 , "None"));
Path.Add(new Vector3(1017.03 , 7156.734 , 92.10828 , "None"));
Path.Add(new Vector3(1023.753 , 7132.748 , 101.1497 , "None"));
Path.Add(new Vector3(1040.494 , 7115.2 , 108.2325 , "None"));
Path.Add(new Vector3(1058.568 , 7099.343 , 117.6824 , "None"));
Path.Add(new Vector3(1073.282 , 7089.601 , 118.2896 , "None"));
Path.Add(new Vector3(1097.113 , 7089.441 , 121.2303 , "None"));
Path.Add(new Vector3(1111.383 , 7093.976 , 122.3252 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KILL6668BladesEdgeMountains1 : QuestGrinderClass
{
    public KILL6668BladesEdgeMountains1()
    {
        Name = "KILL: 66-68 - Blade's Edge Mountains 1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(20713);
EntryTarget.Add(21022);
EntryTarget.Add(19943);
EntryTarget.Add(20109);
EntryTarget.Add(19945);
EntryTarget.Add(19944);
EntryTarget.Add(21033);
EntryTarget.Add(21004);
HotSpots.Add(new Vector3(1859.237 , 6919.068 , 147.0271 , "Flying"));
HotSpots.Add(new Vector3(2069.963 , 6671.181 , 145.8189 , "None"));
HotSpots.Add(new Vector3(1922.087 , 6609.762 , 144.6372 , "None"));
HotSpots.Add(new Vector3(1819.9 , 6771.326 , 141.108 , "None"));
HotSpots.Add(new Vector3(1533.02 , 6798.809 , 122.2181 , "None"));
HotSpots.Add(new Vector3(1662.043 , 6869.642 , 144.1577 , "None"));
HotSpots.Add(new Vector3(1864.766 , 6800.449 , 141.8847 , "None"));
HotSpots.Add(new Vector3(2077.213 , 6658.201 , 145.408 , "None"));
HotSpots.Add(new Vector3(1976.744 , 6165.985 , 143.9713 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 68 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(40) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6668BladesEdgeMountains2 : QuestGrinderClass
{
    public KILL6668BladesEdgeMountains2()
    {
        Name = "KILL: 66-68 - Blades Edge Mountains 2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(20749);
EntryTarget.Add(20751);
EntryTarget.Add(21189);
EntryTarget.Add(21004);
EntryTarget.Add(20601);
EntryTarget.Add(20609);
EntryTarget.Add(21123);
EntryTarget.Add(21124);
EntryTarget.Add(20668);
EntryTarget.Add(21300);
EntryTarget.Add(20925);
HotSpots.Add(new Vector3(2428.324 , 5507.091 , 266.768 , "None"));
HotSpots.Add(new Vector3(2412.719 , 5244.196 , 259.2914 , "None"));
HotSpots.Add(new Vector3(2207.267 , 5231.924 , 265.3911 , "None"));
HotSpots.Add(new Vector3(1978.062 , 5119.882 , 265.4688 , "None"));
HotSpots.Add(new Vector3(1735.013 , 5094.478 , 264.9976 , "None"));
HotSpots.Add(new Vector3(1646.404 , 5210.63 , 265.1075 , "None"));
HotSpots.Add(new Vector3(1680.219 , 5271.564 , 266.1537 , "None"));
HotSpots.Add(new Vector3(2001.266 , 5150.718 , 265.0993 , "None"));
HotSpots.Add(new Vector3(2419.016 , 5212.2 , 262.951 , "None"));
HotSpots.Add(new Vector3(2559.709 , 5402.418 , 269.4456 , "None"));
HotSpots.Add(new Vector3(2613.11 , 5158.913 , 265.2312 , "None"));
HotSpots.Add(new Vector3(2775.995 , 5107.132 , 267.0749 , "None"));
HotSpots.Add(new Vector3(2849.608 , 4991.638 , 268.3395 , "None"));
HotSpots.Add(new Vector3(3162.097 , 5056.569 , 264.2945 , "None"));
HotSpots.Add(new Vector3(1648.319 , 5617.154 , 266.0874 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 68 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(40) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6668Nagrand1 : QuestGrinderClass
{
    public KILL6668Nagrand1()
    {
        Name = "KILL: 66-68 - Nagrand 1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(17160);
EntryTarget.Add(17133);
EntryTarget.Add(17155);
EntryTarget.Add(18062);
EntryTarget.Add(17129);
EntryTarget.Add(17131);
EntryTarget.Add(17132);
EntryTarget.Add(17159);
EntryTarget.Add(18334);
EntryTarget.Add(17158);
EntryTarget.Add(18220);
EntryTarget.Add(18065);
EntryTarget.Add(18037);
EntryTarget.Add(17981);
EntryTarget.Add(17157);
EntryTarget.Add(18289);
HotSpots.Add(new Vector3(-677.7977 , 8317.707 , 46.59825 , "None"));
HotSpots.Add(new Vector3(-692.4103 , 8212.187 , 54.75765 , "None"));
HotSpots.Add(new Vector3(-766.631 , 8071.524 , 48.0569 , "None"));
HotSpots.Add(new Vector3(-953.3489 , 7886.973 , 36.2707 , "None"));
HotSpots.Add(new Vector3(-938.4528 , 7555.697 , 38.48162 , "None"));
HotSpots.Add(new Vector3(-747.0162 , 7200.259 , 41.9365 , "None"));
HotSpots.Add(new Vector3(-1106.552 , 7353.613 , 33.97135 , "None"));
HotSpots.Add(new Vector3(-1578.447 , 7621.038 , -9.346899 , "None"));
HotSpots.Add(new Vector3(-1659.455 , 7205.913 , 0.8817832 , "None"));
HotSpots.Add(new Vector3(-1865.068 , 6830.097 , -42.31828 , "None"));
HotSpots.Add(new Vector3(-1095.869 , 7773.42 , 20.1126 , "None"));
HotSpots.Add(new Vector3(-945.1505 , 8473.437 , 38.91196 , "None"));
HotSpots.Add(new Vector3(-1218.184 , 8569.089 , 32.63866 , "None"));
HotSpots.Add(new Vector3(-1318.01 , 8597.146 , 20.95778 , "None"));
HotSpots.Add(new Vector3(-1081.683 , 8739.68 , 81.49011 , "None"));
HotSpots.Add(new Vector3(-2409.254 , 8560.599 , -28.59264 , "None"));
HotSpots.Add(new Vector3(-2468.377 , 8677.546 , -17.7093 , "None"));
HotSpots.Add(new Vector3(-2685.56 , 8787.093 , -18.23379 , "None"));
HotSpots.Add(new Vector3(-2916.753 , 8593.218 , -29.54436 , "None"));
HotSpots.Add(new Vector3(-2755.401 , 8423.445 , -40.14728 , "None"));
HotSpots.Add(new Vector3(-2978.278 , 8286.52 , -36.70017 , "None"));
HotSpots.Add(new Vector3(-2872.766 , 8140.781 , -37.41912 , "None"));
HotSpots.Add(new Vector3(-3020.707 , 8064.774 , -22.16219 , "None"));
HotSpots.Add(new Vector3(-2799.075 , 7899.339 , -30.82919 , "None"));
HotSpots.Add(new Vector3(-2569.279 , 7894.171 , -55.77854 , "None"));
HotSpots.Add(new Vector3(-2441.299 , 7830.963 , -38.22096 , "None"));
HotSpots.Add(new Vector3(-2384.998 , 7697.086 , -15.8987 , "None"));
HotSpots.Add(new Vector3(-2287.983 , 7632.654 , -9.857718 , "None"));
HotSpots.Add(new Vector3(-2259.007 , 7820.596 , -24.19332 , "None"));
HotSpots.Add(new Vector3(-1943.784 , 8273.417 , 8.844131 , "None"));
HotSpots.Add(new Vector3(-2132.716 , 7460.908 , -27.11974 , "None"));
HotSpots.Add(new Vector3(-1739.758 , 7391.798 , -1.757381 , "None"));
HotSpots.Add(new Vector3(-1529.696 , 7386.701 , 0.4379671 , "None"));
HotSpots.Add(new Vector3(-1584.19 , 7186.977 , 6.849162 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 3;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 68 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(80) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6668Nagrand3MiddleEast : QuestGrinderClass
{
    public KILL6668Nagrand3MiddleEast()
    {
        Name = "KILL: 66-68 Nagrand 3 - Middle East ";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(17130);
EntryTarget.Add(17158);
EntryTarget.Add(17156);
EntryTarget.Add(18205);
EntryTarget.Add(17128);
EntryTarget.Add(18964);
EntryTarget.Add(18226);
EntryTarget.Add(18334);
EntryTarget.Add(17141);
EntryTarget.Add(18062);
HotSpots.Add(new Vector3(-1341.411 , 6248.002 , 53.48207 , "None"));
HotSpots.Add(new Vector3(-1634.864 , 6266.085 , 67.55081 , "None"));
HotSpots.Add(new Vector3(-1652.408 , 6581.338 , 5.889861 , "None"));
HotSpots.Add(new Vector3(-1742.488 , 6850.307 , -27.89197 , "None"));
HotSpots.Add(new Vector3(-1866.653 , 6720.386 , -63.07006 , "None"));
HotSpots.Add(new Vector3(-1887.05 , 6621.328 , -1.602839 , "None"));
HotSpots.Add(new Vector3(-1849.312 , 6451.437 , 27.02019 , "None"));
HotSpots.Add(new Vector3(-1634.412 , 6372.751 , 31.82795 , "None"));
HotSpots.Add(new Vector3(-1746.663 , 6294.288 , 51.17473 , "None"));
HotSpots.Add(new Vector3(-1802.086 , 6377.562 , 42.77927 , "None"));
HotSpots.Add(new Vector3(-1933.286 , 6450.718 , 27.0438 , "None"));
HotSpots.Add(new Vector3(-2051.507 , 6348.524 , 44.99535 , "None"));
HotSpots.Add(new Vector3(-2161.633 , 6347.844 , 45.5179 , "None"));
HotSpots.Add(new Vector3(-2156.233 , 6212.263 , 74.82628 , "None"));
HotSpots.Add(new Vector3(-2328.77 , 6332.416 , 29.21815 , "None"));
HotSpots.Add(new Vector3(-2227.193 , 6628.653 , -1.390667 , "None"));
HotSpots.Add(new Vector3(-2196.567 , 6842.191 , -8.280811 , "None"));
HotSpots.Add(new Vector3(-2345.557 , 6970.5 , -3.433485 , "None"));
HotSpots.Add(new Vector3(-1943.19 , 7175.357 , -99.90385 , "None"));
HotSpots.Add(new Vector3(-1975.799 , 6939.667 , -86.71469 , "None"));
HotSpots.Add(new Vector3(-1797.617 , 6642.869 , -15.93443 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 4;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 68 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(80) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6668Nagrand4SouthEasternArea : QuestGrinderClass
{
    public KILL6668Nagrand4SouthEasternArea()
    {
        Name = "KILL: 66-68 Nagrand 4 - SouthEastern Area";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(17159);
EntryTarget.Add(17132);
EntryTarget.Add(17131);
EntryTarget.Add(18205);
EntryTarget.Add(17158);
EntryTarget.Add(18352);
EntryTarget.Add(18334);
EntryTarget.Add(18964);
EntryTarget.Add(17130);
EntryTarget.Add(18226);
EntryTarget.Add(18062);
EntryTarget.Add(17157);
EntryTarget.Add(19183);
EntryTarget.Add(17133);
EntryTarget.Add(17981);
HotSpots.Add(new Vector3(-2215.456 , 6912.327 , -7.159867 , "None"));
HotSpots.Add(new Vector3(-2551.855 , 6968.654 , -0.587715 , "None"));
HotSpots.Add(new Vector3(-2668.59 , 6876.311 , -4.014941 , "None"));
HotSpots.Add(new Vector3(-2461.188 , 6573.569 , 6.164535 , "None"));
HotSpots.Add(new Vector3(-2239.954 , 6614.192 , -1.461459 , "None"));
HotSpots.Add(new Vector3(-2151.213 , 6276.978 , 58.63003 , "None"));
HotSpots.Add(new Vector3(-2534.719 , 6483.225 , 17.33194 , "None"));
HotSpots.Add(new Vector3(-2794.229 , 6689.676 , 15.97935 , "None"));
HotSpots.Add(new Vector3(-2772.79 , 6906.556 , -18.2713 , "None"));
HotSpots.Add(new Vector3(-2864.411 , 6818.858 , -32.23882 , "None"));
HotSpots.Add(new Vector3(-2870.158 , 6931.987 , -32.04341 , "None"));
HotSpots.Add(new Vector3(-2923.77 , 7011.515 , -38.54554 , "None"));
HotSpots.Add(new Vector3(-2858.905 , 7070.371 , -15.32558 , "None"));
HotSpots.Add(new Vector3(-2954.924 , 7265.524 , 2.413652 , "None"));
HotSpots.Add(new Vector3(-2980.802 , 7496.658 , -2.285167 , "None"));
HotSpots.Add(new Vector3(-2972.527 , 7605.839 , 22.08012 , "None"));
HotSpots.Add(new Vector3(-2785.204 , 7684.589 , -10.43062 , "None"));
HotSpots.Add(new Vector3(-2785.102 , 7505.936 , 1.127801 , "None"));
HotSpots.Add(new Vector3(-2843.952 , 7967.888 , -24.81566 , "None"));
HotSpots.Add(new Vector3(-2862.78 , 8065.523 , -29.76695 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 5;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 68 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(80) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KillingtheCrawlers : QuestGrinderClass
{
    public KillingtheCrawlers()
    {
        Name = "Killing the Crawlers";

        QuestId.AddRange(new[] { 10927 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(22044);
EntryTarget.Add(22132);
HotSpots.Add(new Vector3(1186.272 , 7012.516 , 105.223 , "None"));
HotSpots.Add(new Vector3(1335.873 , 6916.26 , 93.73146 , "None"));
HotSpots.Add(new Vector3(1473.758 , 6828.754 , 107.5135 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheBloodmaulOgres : QuestGrinderClass
{
    public TheBloodmaulOgres()
    {
        Name = "The Bloodmaul Ogres";

        QuestId.AddRange(new[] { 10502 });

        Step = new List<int> { 30, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(19991);
EntryTarget.Add(19992);
EntryTarget.Add(19957);
EntryTarget.Add(20058);
EntryTarget.Add(19948);
EntryTarget.Add(19952);
HotSpots.Add(new Vector3(1541.149 , 6549.554 , -1.634531 , "None"));
HotSpots.Add(new Vector3(1423.764 , 6539.717 , -1.716131 , "None"));
HotSpots.Add(new Vector3(1638.696 , 6383.304 , -9.49639 , "None"));
HotSpots.Add(new Vector3(1649.778 , 6341.584 , -1.279494 , "None"));
HotSpots.Add(new Vector3(1736.516 , 6481.698 , -0.1592368 , "None"));
HotSpots.Add(new Vector3(1673.83 , 6691.841 , 97.93811 , "None"));
HotSpots.Add(new Vector3(2001.079 , 6457.635 , 2.075833 , "None"));
HotSpots.Add(new Vector3(2127.894 , 6322.927 , 2.070213 , "None"));
HotSpots.Add(new Vector3(2275.491 , 6326.708 , 2.015224 , "None"));
HotSpots.Add(new Vector3(1697.762 , 6475.267 , -1.204491 , "None"));
HotSpots.Add(new Vector3(1467.921 , 6528.809 , -10.33878 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Malaise : QuestGrinderClass
{
    public Malaise()
    {
        Name = "Malaise";

        QuestId.AddRange(new[] { 10555 });

        Step = new List<int> { 18, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(19943);
EntryTarget.Add(19944);
EntryTarget.Add(19945);
EntryTarget.Add(20113);
HotSpots.Add(new Vector3(1732.418 , 6924.085 , 144.4264 , "None"));
HotSpots.Add(new Vector3(1732.418 , 6924.085 , 144.4264 , "None"));
HotSpots.Add(new Vector3(1724.297 , 6945.008 , 147.8266 , "None"));
HotSpots.Add(new Vector3(1670.952 , 6986.359 , 156.6639 , "None"));
HotSpots.Add(new Vector3(1637.856 , 6986.247 , 158.3561 , "None"));
HotSpots.Add(new Vector3(1616.588 , 6970.622 , 159.1575 , "None"));
HotSpots.Add(new Vector3(1629.474 , 6932.85 , 159.5274 , "None"));
HotSpots.Add(new Vector3(1659.404 , 6877.458 , 145.3167 , "None"));
HotSpots.Add(new Vector3(1594.022 , 6924.418 , 157.696 , "None"));
HotSpots.Add(new Vector3(1582.102 , 6979.322 , 155.2705 , "None"));
HotSpots.Add(new Vector3(1640.034 , 6991.284 , 158.0714 , "None"));
HotSpots.Add(new Vector3(1724.684 , 6941.259 , 146.8766 , "None"));
HotSpots.Add(new Vector3(1683.349 , 6922.385 , 164.5966 , "None"));
HotSpots.Add(new Vector3(1610.434 , 6986.097 , 189.9993 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class StrangeBrew : QuestGathererClass
{
    public StrangeBrew()
    {
        Name = "Strange Brew";

        QuestId.AddRange(new[] { 10511 });

        Step = new List<int> { 11, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(184504);
HotSpots.Add(new Vector3(1529.522 , 6386.511 , 0.9828365 , "None"));
HotSpots.Add(new Vector3(1491.539 , 6378.651 , 34.97307 , "None"));
HotSpots.Add(new Vector3(1532.171 , 6333.328 , 3.607695 , "None"));
HotSpots.Add(new Vector3(1570.884 , 6298.002 , 3.798218 , "None"));
HotSpots.Add(new Vector3(1654.452 , 6290.156 , 3.600585 , "None"));
HotSpots.Add(new Vector3(1586.88 , 6259.72 , 4.138 , "None"));
HotSpots.Add(new Vector3(1700.95 , 6255.334 , 2.122745 , "None"));
HotSpots.Add(new Vector3(1961.547 , 6468.748 , 2.524158 , "None"));
HotSpots.Add(new Vector3(2242.656 , 6324.953 , 1.861415 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class IntotheDraenethystMine : QuestGathererClass
{
    public IntotheDraenethystMine()
    {
        Name = "Into the Draenethyst Mine";

        QuestId.AddRange(new[] { 10510 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(184689);
HotSpots.Add(new Vector3(1344.683 , 6538.391 , 6.303216 , "None"));
HotSpots.Add(new Vector3(1344.189 , 6584.72 , -7.285796 , "None"));
HotSpots.Add(new Vector3(1359.369 , 6613.532 , -12.68965 , "None"));
HotSpots.Add(new Vector3(1380.644 , 6541.579 , 12.61621 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheEncroachingWilderness : QuestGrinderClass
{
    public TheEncroachingWilderness()
    {
        Name = "The Encroaching Wilderness";

        QuestId.AddRange(new[] { 10455 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(21022);
HotSpots.Add(new Vector3(1823.971 , 6774.932 , 140.862 , "None"));
HotSpots.Add(new Vector3(1921.525 , 6654.74 , 146.51 , "None"));
HotSpots.Add(new Vector3(1914.692 , 6603.699 , 144.3702 , "None"));
HotSpots.Add(new Vector3(1551.793 , 6775.927 , 129.1735 , "None"));
HotSpots.Add(new Vector3(1860.189 , 6913.309 , 145.5985 , "None"));
HotSpots.Add(new Vector3(1980.027 , 6682.509 , 147.1863 , "None"));
HotSpots.Add(new Vector3(1882.46 , 6916.115 , 148.2162 , "None"));
HotSpots.Add(new Vector3(1565.852 , 6788.91 , 131.6848 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheDenMother : QuestGrinderClass
{
    public TheDenMother()
    {
        Name = "The Den Mother";

        QuestId.AddRange(new[] { 10690 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(21956);
HotSpots.Add(new Vector3(1693.082 , 6047.126 , 144.3378 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNBladesEdgeMtnRuntoFlightPath : QuestFollowPathClass
{
    public RUNBladesEdgeMtnRuntoFlightPath()
    {
        Name = "RUN: Blades Edge Mtn - Run to FlightPath";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2077.256 , 6882.215 , 179.4609 , "None"));
Path.Add(new Vector3(2071.625 , 6874.757 , 177.9116 , "None"));
Path.Add(new Vector3(2067.822 , 6863.24 , 174.8074 , "None"));
Path.Add(new Vector3(2072.504 , 6852.474 , 172.3984 , "None"));
Path.Add(new Vector3(2083.278 , 6846.365 , 172.7559 , "None"));
Path.Add(new Vector3(2094.843 , 6842.271 , 173.9396 , "None"));
Path.Add(new Vector3(2106.297 , 6837.788 , 173.9975 , "None"));
Path.Add(new Vector3(2113.359 , 6828.907 , 174.3499 , "None"));
Path.Add(new Vector3(2116.55 , 6817.087 , 174.8046 , "None"));
Path.Add(new Vector3(2120.387 , 6805.396 , 173.912 , "None"));
Path.Add(new Vector3(2125.254 , 6800.763 , 172.0595 , "None"));
Path.Add(new Vector3(2130.941 , 6802.144 , 171.1782 , "None"));
Path.Add(new Vector3(2137.522 , 6803.992 , 171.5433 , "None"));
Path.Add(new Vector3(2142.736 , 6804.482 , 173.0374 , "None"));
Path.Add(new Vector3(2153.456 , 6804.251 , 180.3395 , "None"));
Path.Add(new Vector3(2165.578 , 6804.103 , 183.0933 , "None"));
Path.Add(new Vector3(2169.268 , 6803.744 , 183.0663 , "None"));
Path.Add(new Vector3(2178.026 , 6799.668 , 183.0305 , "None"));
Path.Add(new Vector3(2185.712 , 6794.836 , 183.3301 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class CrystalClear : QuestGrinderClass
{
    public CrystalClear()
    {
        Name = "Crystal Clear";

        QuestId.AddRange(new[] { 10608 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(21189);
EntryTarget.Add(21004);
HotSpots.Add(new Vector3(1788.493 , 5605.075 , 265.5578 , "None"));
HotSpots.Add(new Vector3(1726.853 , 5654.39 , 265.5417 , "None"));
HotSpots.Add(new Vector3(1603.414 , 5606.409 , 266.5648 , "None"));
HotSpots.Add(new Vector3(1555.897 , 5494.439 , 268.5094 , "None"));
HotSpots.Add(new Vector3(1583.714 , 5393.94 , 266.585 , "None"));
HotSpots.Add(new Vector3(1670.021 , 5348.256 , 265.4193 , "None"));
HotSpots.Add(new Vector3(1688.646 , 5239.642 , 265.8544 , "None"));
HotSpots.Add(new Vector3(1669.294 , 5143.678 , 265.6966 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BuildingaBetterGryphon : QuestClass
{
    public BuildingaBetterGryphon()
    {
        Name = "Building a Better Gryphon";

        QuestId.AddRange(new[] { 11043 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Scratches : QuestUseItemOnClass
{
    public Scratches()
    {
        Name = "Scratches";

        QuestId.AddRange(new[] { 10556 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10555;

        EntryIdTarget.Add(300106);
HotSpots.Add(new Vector3(1612.136 , 6933.985 , 159.0312 , "None"));
ItemId = 30530;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MaraudingWolves : QuestGrinderClass
{
    public MaraudingWolves()
    {
        Name = "Marauding Wolves";

        QuestId.AddRange(new[] { 10456 });

        Step = new List<int> { 4, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10455;

        EntryTarget.Add(20748);
HotSpots.Add(new Vector3(1951.882 , 6090.12 , 142.9331 , "None"));
HotSpots.Add(new Vector3(2194.731 , 6131.975 , 143.6437 , "None"));
HotSpots.Add(new Vector3(2093.878 , 6176.142 , 146.5559 , "None"));
HotSpots.Add(new Vector3(1915.756 , 6162.523 , 144.1273 , "None"));
HotSpots.Add(new Vector3(1814.927 , 5956.832 , 142.1674 , "None"));
HotSpots.Add(new Vector3(1824.328 , 5890.802 , 150.075 , "None"));
HotSpots.Add(new Vector3(1949.511 , 5975.538 , 141.5956 , "None"));
HotSpots.Add(new Vector3(2075.031 , 6088.737 , 146.9551 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNScratchesHaveBirdgotofuckertoturnin : QuestFollowPathClass
{
    public RUNScratchesHaveBirdgotofuckertoturnin()
    {
        Name = "RUN: Scratches - Have Bird, go to fucker to turnin";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(1615.563 , 6929.399 , 158.5182 , "None"));
Path.Add(new Vector3(1627.113 , 6925.2 , 157.7289 , "None"));
Path.Add(new Vector3(1638.625 , 6921.334 , 158.207 , "None"));
Path.Add(new Vector3(1649.687 , 6916.121 , 158.3368 , "None"));
Path.Add(new Vector3(1660.347 , 6910.296 , 159.237 , "None"));
Path.Add(new Vector3(1651.306 , 6914.894 , 158.3329 , "None"));
Path.Add(new Vector3(1639.887 , 6920.675 , 158.2809 , "None"));
Path.Add(new Vector3(1628.528 , 6924.453 , 157.8484 , "None"));
Path.Add(new Vector3(1617.505 , 6920.709 , 156.1019 , "None"));
Path.Add(new Vector3(1613.707 , 6918.137 , 155.9212 , "None"));
Path.Add(new Vector3(1605.884 , 6913.387 , 156.6238 , "None"));
Path.Add(new Vector3(1610.456 , 6910.875 , 156.0135 , "None"));
Path.Add(new Vector3(1621.805 , 6905.171 , 154.0334 , "None"));
Path.Add(new Vector3(1633.216 , 6901.327 , 150.5492 , "None"));
Path.Add(new Vector3(1642.227 , 6893.395 , 147.9886 , "None"));
Path.Add(new Vector3(1651.274 , 6885.251 , 146.4329 , "None"));
Path.Add(new Vector3(1657.819 , 6879.941 , 145.8949 , "None"));
Path.Add(new Vector3(1659.509 , 6874.563 , 144.7144 , "None"));
Path.Add(new Vector3(1663.213 , 6869.572 , 144.2489 , "None"));
Path.Add(new Vector3(1669.05 , 6867.772 , 144.5452 , "None"));
Path.Add(new Vector3(1677.951 , 6866.384 , 142.0916 , "None"));
Path.Add(new Vector3(1683.016 , 6863.963 , 141.101 , "None"));
Path.Add(new Vector3(1686.921 , 6853.089 , 140.3035 , "None"));
Path.Add(new Vector3(1691.144 , 6841.047 , 137.4514 , "None"));
Path.Add(new Vector3(1697.44 , 6831.384 , 136.1663 , "None"));
Path.Add(new Vector3(1702.787 , 6835.02 , 136.7334 , "None"));
Path.Add(new Vector3(1707.158 , 6839.257 , 138.3046 , "None"));
Path.Add(new Vector3(1709.978 , 6841.799 , 139.2194 , "None"));
Path.Add(new Vector3(1717.309 , 6851.337 , 139.0256 , "None"));
Path.Add(new Vector3(1720.026 , 6854.974 , 139.3972 , "None"));
Path.Add(new Vector3(1723.919 , 6858.086 , 140.2124 , "None"));
Path.Add(new Vector3(1728.814 , 6859.52 , 141.0807 , "None"));
Path.Add(new Vector3(1734.631 , 6857.318 , 141.2527 , "None"));
Path.Add(new Vector3(1739.52 , 6854.128 , 140.9263 , "None"));
Path.Add(new Vector3(1742.909 , 6851.024 , 139.884 , "None"));
Path.Add(new Vector3(1750.813 , 6839.042 , 137.0769 , "None"));
Path.Add(new Vector3(1755.912 , 6831.312 , 139.3532 , "None"));
Path.Add(new Vector3(1760.032 , 6824.621 , 139.8223 , "None"));
Path.Add(new Vector3(1765.917 , 6816.457 , 137.7749 , "None"));
Path.Add(new Vector3(1777.626 , 6814.611 , 137.4113 , "None"));
Path.Add(new Vector3(1786.916 , 6808.215 , 137.2865 , "None"));
Path.Add(new Vector3(1798.578 , 6804.905 , 137.4384 , "None"));
Path.Add(new Vector3(1810.709 , 6808.105 , 137.955 , "None"));
Path.Add(new Vector3(1822.502 , 6810.898 , 138.3421 , "None"));
Path.Add(new Vector3(1833.943 , 6812.716 , 139.1461 , "None"));
Path.Add(new Vector3(1845.744 , 6816.719 , 140.2171 , "None"));
Path.Add(new Vector3(1857.11 , 6820.574 , 142.7738 , "None"));
Path.Add(new Vector3(1869.311 , 6824.675 , 143.7829 , "None"));
Path.Add(new Vector3(1880.597 , 6828.332 , 144.9139 , "None"));
Path.Add(new Vector3(1892.686 , 6831.935 , 145.7116 , "None"));
Path.Add(new Vector3(1903.931 , 6834.841 , 146.7073 , "None"));
Path.Add(new Vector3(1916.252 , 6836.463 , 148.2408 , "None"));
Path.Add(new Vector3(1928.451 , 6837.764 , 151.082 , "None"));
Path.Add(new Vector3(1940.781 , 6839.392 , 154.5927 , "None"));
Path.Add(new Vector3(1952.975 , 6841.44 , 157.4057 , "None"));
Path.Add(new Vector3(1965.116 , 6843.479 , 160.0792 , "None"));
Path.Add(new Vector3(1976.81 , 6845.443 , 162.703 , "None"));
Path.Add(new Vector3(1988.647 , 6847.431 , 165.9876 , "None"));
Path.Add(new Vector3(2000.181 , 6848.761 , 168.61 , "None"));
Path.Add(new Vector3(2013.492 , 6849.401 , 170.4089 , "None"));
Path.Add(new Vector3(2025.106 , 6847.152 , 171.2388 , "None"));
Path.Add(new Vector3(2034.019 , 6839.197 , 173.1507 , "None"));
Path.Add(new Vector3(2036.145 , 6833.987 , 173.7774 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class ProtectingOurOwn : QuestGathererClass
{
    public ProtectingOurOwn()
    {
        Name = "Protecting Our Own";

        QuestId.AddRange(new[] { 10457 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10456;

        EntryIdObjects.Add(184631);
HotSpots.Add(new Vector3(1882.176 , 6870.648 , 144.9534 , "None"));
HotSpots.Add(new Vector3(1831.457 , 6793.408 , 139.1455 , "None"));
HotSpots.Add(new Vector3(1967.581 , 6700.781 , 146.7829 , "None"));
HotSpots.Add(new Vector3(1781.694 , 6822.683 , 137.7291 , "None"));
HotSpots.Add(new Vector3(1674.822 , 6803.305 , 135.9922 , "None"));
HotSpots.Add(new Vector3(1583.44 , 6808.836 , 130.4 , "None"));
HotSpots.Add(new Vector3(1513.902 , 6794.834 , 118.7885 , "None"));
HotSpots.Add(new Vector3(1906.943 , 6619.699 , 144.6803 , "None"));
HotSpots.Add(new Vector3(2065.646 , 6599.389 , 139.8389 , "None"));
HotSpots.Add(new Vector3(2030.682 , 6694.179 , 146.2766 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheBladespireOgres : QuestGrinderClass
{
    public TheBladespireOgres()
    {
        Name = "The Bladespire Ogres";

        QuestId.AddRange(new[] { 10504 });

        Step = new List<int> { 30, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10502;

        EntryTarget.Add(19995);
EntryTarget.Add(20728);
EntryTarget.Add(19998);
EntryTarget.Add(21296);
HotSpots.Add(new Vector3(2549.698 , 6298.114 , 8.375718 , "None"));
HotSpots.Add(new Vector3(2489.432 , 6491.911 , -5.160652 , "None"));
HotSpots.Add(new Vector3(2607.701 , 6538.215 , 0.7299212 , "None"));
HotSpots.Add(new Vector3(2498.112 , 6555.802 , -0.6677294 , "None"));
HotSpots.Add(new Vector3(2359.906 , 6532.925 , 3.469044 , "None"));
HotSpots.Add(new Vector3(2348.471 , 6672.412 , 15.83466 , "None"));
HotSpots.Add(new Vector3(2307.605 , 6731.327 , 40.2049 , "None"));
HotSpots.Add(new Vector3(2516.666 , 6505.497 , -2.76463 , "None"));
HotSpots.Add(new Vector3(2647.455 , 6153.066 , 13.94524 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GettingtheBladespireTanked : QuestGrinderClass
{
    public GettingtheBladespireTanked()
    {
        Name = "Getting the Bladespire Tanked";

        QuestId.AddRange(new[] { 10512 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10511;

        EntryTarget.Add(19995);
EntryTarget.Add(19998);
HotSpots.Add(new Vector3(2519.791 , 6297.731 , 12.93419 , "None"));
HotSpots.Add(new Vector3(2595.953 , 6180.186 , 14.86444 , "None"));
HotSpots.Add(new Vector3(2656.923 , 6142.567 , 11.72482 , "None"));
HotSpots.Add(new Vector3(2515.033 , 6485.294 , -4.077343 , "None"));
HotSpots.Add(new Vector3(2633.146 , 6523.941 , 0.7335792 , "None"));
HotSpots.Add(new Vector3(2516.666 , 6505.497 , -2.76463 , "None"));
HotSpots.Add(new Vector3(2539.198 , 6305.431 , 8.765295 , "None"));
HotSpots.Add(new Vector3(2647.455 , 6153.066 , 13.94524 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ADatewithDorgok : QuestGrinderClass
{
    public ADatewithDorgok()
    {
        Name = "A Date with Dorgok";

        QuestId.AddRange(new[] { 10795 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(20753);
HotSpots.Add(new Vector3(3538.87 , 5854.35 , 25.89534 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CrushtheBloodmaulCamp : QuestGrinderClass
{
    public CrushtheBloodmaulCamp()
    {
        Name = "Crush the Bloodmaul Camp!";

        QuestId.AddRange(new[] { 10796 });

        Step = new List<int> { 10, 5, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(19993);
EntryTarget.Add(19994);
HotSpots.Add(new Vector3(3374.532 , 5703.14 , -7.53352 , "None"));
HotSpots.Add(new Vector3(3461.953 , 5803.072 , 1.281883 , "None"));
HotSpots.Add(new Vector3(3181.628 , 5805.181 , -10.32743 , "None"));
HotSpots.Add(new Vector3(3138.064 , 5919.345 , -10.33308 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CullingtheWild : QuestGrinderClass
{
    public CullingtheWild()
    {
        Name = "Culling the Wild";

        QuestId.AddRange(new[] { 10753 });

        Step = new List<int> { 4, 4, 2, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(21124);
EntryTarget.Add(21300);
EntryTarget.Add(21123);
HotSpots.Add(new Vector3(3098.853 , 5091.778 , 267.7095 , "None"));
HotSpots.Add(new Vector3(3198.6 , 5065.023 , 264.16 , "None"));
HotSpots.Add(new Vector3(3178.721 , 4958.516 , 265.459 , "None"));
HotSpots.Add(new Vector3(3348.199 , 4906.823 , 267.8625 , "None"));
HotSpots.Add(new Vector3(3441.078 , 4971.553 , 265.5833 , "None"));
HotSpots.Add(new Vector3(3478.097 , 4859.764 , 255.9501 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ATimeforNegotiation : QuestInteractWithClass
{
    public ATimeforNegotiation()
    {
        Name = "A Time for Negotiation...";

        QuestId.AddRange(new[] { 10682 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(21981);
HotSpots.Add(new Vector3(2882.957 , 5502.225 , 145.3804 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "";
IgnoreIfDead = false;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LittleEmbers : QuestGrinderClass
{
    public LittleEmbers()
    {
        Name = "Little Embers";

        QuestId.AddRange(new[] { 10770 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(20514);
EntryTarget.Add(21021);
HotSpots.Add(new Vector3(3535.37 , 4999.997 , 269.5015 , "None"));
HotSpots.Add(new Vector3(3656.085 , 5021.719 , 267.765 , "None"));
HotSpots.Add(new Vector3(3642.641 , 4925.79 , 268.4097 , "None"));
HotSpots.Add(new Vector3(3740.331 , 4963.499 , 276.5883 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class FromtheAshes : QuestGathererClass
{
    public FromtheAshes()
    {
        Name = "From the Ashes";

        QuestId.AddRange(new[] { 10771 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(185147);
EntryIdObjects.Add(185124);
EntryIdObjects.Add(185148);
HotSpots.Add(new Vector3(3599.212 , 4957.048 , 267.8359 , "None"));
HotSpots.Add(new Vector3(3673.558 , 4960.47 , 266.0372 , "None"));
HotSpots.Add(new Vector3(3738.227 , 4962.105 , 276.5655 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class andaTimeforAction : QuestGrinderClass
{
    public andaTimeforAction()
    {
        Name = "...and a Time for Action";

        QuestId.AddRange(new[] { 10713 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10682;

        EntryTarget.Add(21810);
EntryTarget.Add(21811);
EntryTarget.Add(21809);
HotSpots.Add(new Vector3(3010.285 , 5719.656 , 145.5869 , "None"));
HotSpots.Add(new Vector3(2920.939 , 5702.51 , 147.8345 , "None"));
HotSpots.Add(new Vector3(2893.986 , 5512.39 , 144.5638 , "None"));
HotSpots.Add(new Vector3(2833.74 , 5478.205 , 143.9098 , "None"));
HotSpots.Add(new Vector3(2783.318 , 5428.115 , 137.6161 , "None"));
HotSpots.Add(new Vector3(3074.855 , 5670.267 , 142.7154 , "None"));
HotSpots.Add(new Vector3(3090.196 , 5629.348 , 144.1632 , "None"));
HotSpots.Add(new Vector3(3164.779 , 5572.843 , 141.4543 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PoachingfromPoachers : QuestGrinderClass
{
    public PoachingfromPoachers()
    {
        Name = "Poaching from Poachers";

        QuestId.AddRange(new[] { 10717 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10682;

        EntryTarget.Add(21809);
EntryTarget.Add(21811);
EntryTarget.Add(21810);
HotSpots.Add(new Vector3(3010.285 , 5719.656 , 145.5869 , "None"));
HotSpots.Add(new Vector3(2920.939 , 5702.51 , 147.8345 , "None"));
HotSpots.Add(new Vector3(2893.986 , 5512.39 , 144.5638 , "None"));
HotSpots.Add(new Vector3(2833.74 , 5478.205 , 143.9098 , "None"));
HotSpots.Add(new Vector3(2783.318 , 5428.115 , 137.6161 , "None"));
HotSpots.Add(new Vector3(3074.855 , 5670.267 , 142.7154 , "None"));
HotSpots.Add(new Vector3(3090.196 , 5629.348 , 144.1632 , "None"));
HotSpots.Add(new Vector3(3164.779 , 5572.843 , 141.4543 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DidYouGetTheNote : QuestClass
{
    public DidYouGetTheNote()
    {
        Name = "Did You Get The Note?";

        QuestId.AddRange(new[] { 10719 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 31120;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DidYouGetTheNoteKILLFORQuestITEM : QuestGrinderClass
{
    public DidYouGetTheNoteKILLFORQuestITEM()
    {
        Name = "Did You Get The Note? - KILL FOR Quest ITEM";

        QuestId.AddRange(new[] { 10719 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(21809);
EntryTarget.Add(21811);
EntryTarget.Add(21810);
HotSpots.Add(new Vector3(2893.122 , 5464.208 , 149.3682 , "None"));
HotSpots.Add(new Vector3(2886.319 , 5547.979 , 146.3349 , "None"));
HotSpots.Add(new Vector3(2932.975 , 5660.865 , 147.9233 , "None"));
HotSpots.Add(new Vector3(2981.27 , 5694.335 , 148.8816 , "None"));
HotSpots.Add(new Vector3(3035.152 , 5639.88 , 144.0238 , "None"));
HotSpots.Add(new Vector3(3076.464 , 5634.137 , 142.7392 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(31120) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class WyrmskullWatcher : QuestClass
{
    public WyrmskullWatcher()
    {
        Name = "Wyrmskull Watcher";

        QuestId.AddRange(new[] { 10894 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10719;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CreatingthePendant : QuestUseItemOnClass
{
    public CreatingthePendant()
    {
        Name = "Creating the Pendant";

        QuestId.AddRange(new[] { 10567 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(300111);
HotSpots.Add(new Vector3(3211.078 , 5348.833 , 144.5374 , "None"));
ItemId = 30704;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CreatingthePendantKillForItems : QuestGrinderClass
{
    public CreatingthePendantKillForItems()
    {
        Name = "Creating the Pendant - Kill For Items";

        QuestId.AddRange(new[] { 10567 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(19986);
EntryTarget.Add(19985);
EntryTarget.Add(19987);
EntryTarget.Add(20987);
HotSpots.Add(new Vector3(3164.491 , 5383.903 , 145.7478 , "None"));
HotSpots.Add(new Vector3(3256.915 , 5390.433 , 143.6664 , "None"));
HotSpots.Add(new Vector3(3279.786 , 5320.926 , 149.7438 , "None"));
HotSpots.Add(new Vector3(3312.46 , 5320.569 , 153.4439 , "None"));
HotSpots.Add(new Vector3(3155.947 , 5306.627 , 148.38 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(30704) >= 6;
}






}


public sealed class RUNRunUptoDograkQuest : QuestFollowPathClass
{
    public RUNRunUptoDograkQuest()
    {
        Name = "RUN: Run Up to Dograk Quest";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(3503.268 , 5829.876 , 1.345587 , "None"));
Path.Add(new Vector3(3505.428 , 5840.893 , 4.248272 , "None"));
Path.Add(new Vector3(3506.967 , 5852.013 , 11.64174 , "None"));
Path.Add(new Vector3(3506.932 , 5859.749 , 18.04654 , "None"));
Path.Add(new Vector3(3509.745 , 5863.645 , 21.691 , "None"));
Path.Add(new Vector3(3510.714 , 5866.706 , 23.57897 , "None"));
Path.Add(new Vector3(3513.844 , 5872.987 , 25.69352 , "None"));
Path.Add(new Vector3(3515.429 , 5870.279 , 25.61105 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class FavoroftheGronn : QuestClass
{
    public FavoroftheGronn()
    {
        Name = "Favor of the Gronn";

        QuestId.AddRange(new[] { 10797 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 31363;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class FavoroftheGronnKILLFORQITEM : QuestGrinderClass
{
    public FavoroftheGronnKILLFORQITEM()
    {
        Name = "Favor of the Gronn - KILL FOR Q ITEM";

        QuestId.AddRange(new[] { 10797 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(20753);
HotSpots.Add(new Vector3(3530.671 , 5858.937 , 25.89545 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(31363) >= 1;
}






}


public sealed class RUNNagrandtoShadowmoonValleyFP : QuestFollowPathClass
{
    public RUNNagrandtoShadowmoonValleyFP()
    {
        Name = "RUN: Nagrand to Shadowmoon Valley FP";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-2694.299 , 3380.36 , -0.1031279 , "None"));
Path.Add(new Vector3(-2722.31 , 3334.552 , -0.9699407 , "None"));
Path.Add(new Vector3(-2747.77 , 3301.87 , 0.06224396 , "None"));
Path.Add(new Vector3(-2777.072 , 3274.33 , 3.535003 , "None"));
Path.Add(new Vector3(-2805.078 , 3243.573 , 6.627214 , "None"));
Path.Add(new Vector3(-2831.296 , 3213.033 , 7.706459 , "None"));
Path.Add(new Vector3(-2857.915 , 3183.176 , 9.845234 , "None"));
Path.Add(new Vector3(-2876.021 , 3163.689 , 15.23582 , "None"));
Path.Add(new Vector3(-2890.797 , 3144.692 , 21.48131 , "None"));
Path.Add(new Vector3(-2904.28 , 3124.83 , 27.27187 , "None"));
Path.Add(new Vector3(-2915.357 , 3097.073 , 35.25036 , "None"));
Path.Add(new Vector3(-2917.523 , 3070.714 , 42.31964 , "None"));
Path.Add(new Vector3(-2912.627 , 3043.012 , 48.34236 , "None"));
Path.Add(new Vector3(-2933.32 , 3016.459 , 57.97052 , "None"));
Path.Add(new Vector3(-2965.125 , 2992.248 , 69.80796 , "None"));
Path.Add(new Vector3(-2979.083 , 2981.901 , 75.24632 , "None"));
Path.Add(new Vector3(-2994.197 , 2973.143 , 79.58958 , "None"));
Path.Add(new Vector3(-3008.626 , 2963.912 , 83.02572 , "None"));
Path.Add(new Vector3(-3021.239 , 2953.906 , 85.80212 , "None"));
Path.Add(new Vector3(-3040.214 , 2928.64 , 86.34084 , "None"));
Path.Add(new Vector3(-3059.162 , 2903.305 , 83.85195 , "None"));
Path.Add(new Vector3(-3071.071 , 2887.282 , 82.48454 , "None"));
Path.Add(new Vector3(-3086.416 , 2865.9 , 81.33528 , "None"));
Path.Add(new Vector3(-3099.428 , 2844.324 , 79.1636 , "None"));
Path.Add(new Vector3(-3115.022 , 2818.478 , 77.68993 , "None"));
Path.Add(new Vector3(-3135.838 , 2785.924 , 75.48663 , "None"));
Path.Add(new Vector3(-3158.49 , 2748.544 , 73.74952 , "None"));
Path.Add(new Vector3(-3169.008 , 2730.542 , 72.14867 , "None"));
Path.Add(new Vector3(-3180.593 , 2713.904 , 68.1912 , "None"));
Path.Add(new Vector3(-3195.536 , 2706.406 , 66.31562 , "None"));
Path.Add(new Vector3(-3219.884 , 2696.832 , 63.49867 , "None"));
Path.Add(new Vector3(-3257.807 , 2683.568 , 59.52157 , "None"));
Path.Add(new Vector3(-3298.647 , 2675.603 , 57.2254 , "None"));
Path.Add(new Vector3(-3337.387 , 2663.72 , 58.26485 , "None"));
Path.Add(new Vector3(-3377.163 , 2652.958 , 59.99216 , "None"));
Path.Add(new Vector3(-3416.966 , 2645.12 , 59.03375 , "None"));
Path.Add(new Vector3(-3455.143 , 2631.435 , 60.03548 , "None"));
Path.Add(new Vector3(-3486.01 , 2608.121 , 62.3441 , "None"));
Path.Add(new Vector3(-3510.657 , 2573.962 , 64.29398 , "None"));
Path.Add(new Vector3(-3518.523 , 2550.876 , 65.6533 , "None"));
Path.Add(new Vector3(-3538.277 , 2514.483 , 69.55295 , "None"));
Path.Add(new Vector3(-3561.779 , 2480.685 , 72.59012 , "None"));
Path.Add(new Vector3(-3588.266 , 2452.026 , 72.91856 , "None"));
Path.Add(new Vector3(-3601.783 , 2439.022 , 72.9926 , "None"));
Path.Add(new Vector3(-3619.19 , 2413.589 , 74.48515 , "None"));
Path.Add(new Vector3(-3643.42 , 2381.746 , 77.00626 , "None"));
Path.Add(new Vector3(-3671.522 , 2350.939 , 76.79678 , "None"));
Path.Add(new Vector3(-3683.905 , 2333.883 , 76.41973 , "None"));
Path.Add(new Vector3(-3713.242 , 2308.365 , 78.42898 , "None"));
Path.Add(new Vector3(-3730.478 , 2293.347 , 76.5013 , "None"));
Path.Add(new Vector3(-3744.169 , 2271.195 , 76.68536 , "None"));
Path.Add(new Vector3(-3748.688 , 2235.902 , 76.8449 , "None"));
Path.Add(new Vector3(-3753.788 , 2195.327 , 75.88844 , "None"));
Path.Add(new Vector3(-3758.584 , 2155.203 , 75.91899 , "None"));
Path.Add(new Vector3(-3760.5 , 2125.888 , 76.72183 , "None"));
Path.Add(new Vector3(-3794.258 , 2104.602 , 84.36427 , "None"));
Path.Add(new Vector3(-3829.811 , 2084.491 , 91.52509 , "None"));
Path.Add(new Vector3(-3857.977 , 2066.184 , 94.04703 , "None"));
Path.Add(new Vector3(-3880.181 , 2057.211 , 94.69263 , "None"));
Path.Add(new Vector3(-3895.779 , 2050.937 , 94.54327 , "None"));
Path.Add(new Vector3(-3902.917 , 2075.715 , 94.26695 , "None"));
Path.Add(new Vector3(-3917.254 , 2094.22 , 94.60169 , "None"));
Path.Add(new Vector3(-3936.558 , 2108.653 , 95.50915 , "None"));
Path.Add(new Vector3(-3946.183 , 2130.367 , 97.51165 , "None"));
Path.Add(new Vector3(-3954.149 , 2140.844 , 98.48669 , "None"));
Path.Add(new Vector3(-3956.923 , 2135.729 , 99.44126 , "None"));
Path.Add(new Vector3(-3962.716 , 2124.833 , 100.8081 , "None"));
Path.Add(new Vector3(-3972.839 , 2118.852 , 103.5067 , "None"));
Path.Add(new Vector3(-3982.985 , 2124.808 , 104.9517 , "None"));
Path.Add(new Vector3(-3988.431 , 2135.514 , 104.8106 , "None"));
Path.Add(new Vector3(-3990.56 , 2147.353 , 104.1459 , "None"));
Path.Add(new Vector3(-3991.493 , 2159.468 , 104.443 , "None"));
Path.Add(new Vector3(-3983.698 , 2156.915 , 104.8453 , "None"));
Path.Add(new Vector3(-3983.698 , 2156.915 , 104.8453 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Besieged : QuestGrinderClass
{
    public Besieged()
    {
        Name = "Besieged!";

        QuestId.AddRange(new[] { 10562 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 11044;

        EntryTarget.Add(21419);
HotSpots.Add(new Vector3(-3814.686 , 2094.475 , 88.20699 , "None"));
HotSpots.Add(new Vector3(-3842.635 , 1974.352 , 93.27316 , "None"));
HotSpots.Add(new Vector3(-3999.258 , 1994.872 , 95.12331 , "None"));
HotSpots.Add(new Vector3(-3837.83 , 1957.617 , 91.34575 , "None"));
HotSpots.Add(new Vector3(-3885.144 , 2042.448 , 94.6403 , "None"));
HotSpots.Add(new Vector3(-3254.634 , 2672.577 , 60.28937 , "None"));
HotSpots.Add(new Vector3(-3137.415 , 2722.532 , 67.73857 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheSkethlonWreckage : QuestGrinderClass
{
    public TheSkethlonWreckage()
    {
        Name = "The Sketh'lon Wreckage";

        QuestId.AddRange(new[] { 10569 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(19826);
EntryTarget.Add(21450);
EntryTarget.Add(21386);
HotSpots.Add(new Vector3(-3161.241 , 2221.542 , 62.7675 , "None"));
HotSpots.Add(new Vector3(-3114.011 , 2249.545 , 62.38787 , "None"));
HotSpots.Add(new Vector3(-3067.177 , 2297.404 , 62.80937 , "None"));
HotSpots.Add(new Vector3(-3026.589 , 2257.301 , 64.73002 , "None"));
HotSpots.Add(new Vector3(-3062.078 , 2217.076 , 67.05363 , "None"));
HotSpots.Add(new Vector3(-3149.883 , 2148.665 , 76.39877 , "None"));
HotSpots.Add(new Vector3(-3117.081 , 2224.696 , 64.08094 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Spleendid : QuestGrinderClass
{
    public Spleendid()
    {
        Name = "Spleendid!";

        QuestId.AddRange(new[] { 10661 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(21408);
HotSpots.Add(new Vector3(-4199.375 , 1754.392 , 91.0603 , "None"));
HotSpots.Add(new Vector3(-4142.873 , 1736.295 , 99.52421 , "None"));
HotSpots.Add(new Vector3(-4127.52 , 1654.913 , 94.21928 , "None"));
HotSpots.Add(new Vector3(-4197.912 , 1639.542 , 93.80718 , "None"));
HotSpots.Add(new Vector3(-4258.66 , 1657.81 , 102.4904 , "None"));
HotSpots.Add(new Vector3(-4225.619 , 1743.199 , 91.21062 , "None"));
HotSpots.Add(new Vector3(-4178.178 , 1752.398 , 94.53704 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheHandofGuldan : QuestClass
{
    public TheHandofGuldan()
    {
        Name = "The Hand of Gul'dan";

        QuestId.AddRange(new[] { 10680 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AGhostintheMachine : QuestGathererClass
{
    public AGhostintheMachine()
    {
        Name = "A Ghost in the Machine";

        QuestId.AddRange(new[] { 10642 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(184948);
HotSpots.Add(new Vector3(-3608.051 , 2087.401 , 70.20962 , "None"));
HotSpots.Add(new Vector3(-3468.265 , 2125.193 , 87.812 , "None"));
HotSpots.Add(new Vector3(-3410.804 , 2091.878 , 78.90321 , "None"));
HotSpots.Add(new Vector3(-3346.677 , 2077.878 , 80.48463 , "None"));
HotSpots.Add(new Vector3(-3540.149 , 2247.547 , 78.47363 , "None"));
HotSpots.Add(new Vector3(-3387.02 , 2250.404 , 68.31184 , "None"));
HotSpots.Add(new Vector3(-3415.287 , 2090.686 , 79.55907 , "None"));
HotSpots.Add(new Vector3(-3351.24 , 2077.227 , 80.40532 , "None"));
HotSpots.Add(new Vector3(-3608.287 , 2092.615 , 71.0049 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PutOnYerKneepads : QuestGrinderClass
{
    public PutOnYerKneepads()
    {
        Name = "Put On Yer Kneepads...";

        QuestId.AddRange(new[] { 10703 });

        Step = new List<int> { 20, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(21878);
EntryTarget.Add(21879);
HotSpots.Add(new Vector3(-3587.65 , 2085.828 , 69.77791 , "None"));
HotSpots.Add(new Vector3(-3478.71 , 2311.865 , 64.7767 , "None"));
HotSpots.Add(new Vector3(-3609.649 , 2538.76 , 73.43743 , "None"));
HotSpots.Add(new Vector3(-3482.864 , 2550.554 , 61.03313 , "None"));
HotSpots.Add(new Vector3(-3387.615 , 2359.202 , 64.42848 , "None"));
HotSpots.Add(new Vector3(-3299.314 , 2362.343 , 63.05865 , "None"));
HotSpots.Add(new Vector3(-3537.571 , 2055.885 , 68.71038 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HarbingersofShadowmoon : QuestGrinderClass
{
    public HarbingersofShadowmoon()
    {
        Name = "Harbingers of Shadowmoon";

        QuestId.AddRange(new[] { 10643 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10642;

        EntryTarget.Add(21795);
HotSpots.Add(new Vector3(-3936.216 , 2210.569 , 101.8885 , "None"));
HotSpots.Add(new Vector3(-3970.081 , 2233.798 , 101.9748 , "None"));
HotSpots.Add(new Vector3(-4012.048 , 2234.433 , 108.2371 , "None"));
HotSpots.Add(new Vector3(-4041.348 , 2191.722 , 110.2457 , "None"));
HotSpots.Add(new Vector3(-4040.782 , 2151.666 , 105.9966 , "None"));
HotSpots.Add(new Vector3(-3947.617 , 2138.295 , 98.80823 , "None"));
HotSpots.Add(new Vector3(-3902.238 , 2085.239 , 95.24504 , "None"));
HotSpots.Add(new Vector3(-3868.07 , 2099.341 , 95.06522 , "None"));
HotSpots.Add(new Vector3(-3928.237 , 2048.52 , 95.10541 , "None"));
HotSpots.Add(new Vector3(-3946.529 , 2177.473 , 101.3225 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheSecondCourse : QuestGrinderClass
{
    public TheSecondCourse()
    {
        Name = "The Second Course...";

        QuestId.AddRange(new[] { 10677 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10661;

        EntryTarget.Add(21462);
HotSpots.Add(new Vector3(-4511.571 , 1147.613 , 35.72256 , "None"));
HotSpots.Add(new Vector3(-3856.704 , 996.3774 , 26.22222 , "None"));
HotSpots.Add(new Vector3(-3933.442 , 1097.881 , 28.42467 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TeronGorefiendLoreandLegend : QuestClass
{
    public TeronGorefiendLoreandLegend()
    {
        Name = "Teron Gorefiend - Lore and Legend";

        QuestId.AddRange(new[] { 10644 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10643;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheMainCourse : QuestGrinderClass
{
    public TheMainCourse()
    {
        Name = "The Main Course!";

        QuestId.AddRange(new[] { 10678 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10677;

        EntryTarget.Add(21897);
HotSpots.Add(new Vector3(-3522.428 , 1133.214 , 15.79273 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class FindtheDeserter : QuestClass
{
    public FindtheDeserter()
    {
        Name = "Find the Deserter";

        QuestId.AddRange(new[] { 10759 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10569;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AsgharsTotem : QuestGrinderClass
{
    public AsgharsTotem()
    {
        Name = "Asghar's Totem";

        QuestId.AddRange(new[] { 10777 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10759;

        EntryTarget.Add(22025);
HotSpots.Add(new Vector3(-3027.722 , 2042.176 , 96.85224 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SecuringtheShaleskinShale : QuestGrinderClass
{
    public SecuringtheShaleskinShale()
    {
        Name = "Securing the Shaleskin Shale";

        QuestId.AddRange(new[] { 10342 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(20210);
HotSpots.Add(new Vector3(3163.399 , 3754.284 , 137.5045 , "None"));
HotSpots.Add(new Vector3(3260.313 , 3623.34 , 127.3695 , "None"));
HotSpots.Add(new Vector3(3171.911 , 3596.74 , 135.6053 , "None"));
HotSpots.Add(new Vector3(3000.152 , 3375.374 , 104.2549 , "None"));
HotSpots.Add(new Vector3(2642.707 , 3471.938 , 144.288 , "None"));
HotSpots.Add(new Vector3(2812.876 , 3511.979 , 143.6446 , "None"));
HotSpots.Add(new Vector3(3215.57 , 3615.003 , 127.7723 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class YoureHired : QuestGathererClass
{
    public YoureHired()
    {
        Name = "You're Hired!";

        QuestId.AddRange(new[] { 10186 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 11042;

        EntryIdObjects.Add(183767);
EntryIdObjects.Add(183768);
HotSpots.Add(new Vector3(3435.241 , 3660.845 , 153.0099 , "None"));
HotSpots.Add(new Vector3(3439.206 , 3700.49 , 147.2292 , "None"));
HotSpots.Add(new Vector3(3404.953 , 3684.074 , 147.1663 , "None"));
HotSpots.Add(new Vector3(3410.58 , 3617.188 , 141.8796 , "None"));
HotSpots.Add(new Vector3(3467.554 , 3631.885 , 140.7057 , "None"));
HotSpots.Add(new Vector3(3545.261 , 3626.131 , 126.0282 , "None"));
HotSpots.Add(new Vector3(3552.141 , 3570.915 , 128.1748 , "None"));
HotSpots.Add(new Vector3(3501.358 , 3589.074 , 154.0529 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheArchmagesStaff : QuestUseItemOnClass
{
    public TheArchmagesStaff()
    {
        Name = "The Archmage's Staff";

        QuestId.AddRange(new[] { 10173 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(184143);
HotSpots.Add(new Vector3(2756.941 , 3199.905 , 150.735 , "None"));
ItemId = 29207;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThatLittleExtraKick : QuestGrinderClass
{
    public ThatLittleExtraKick()
    {
        Name = "That Little Extra Kick";

        QuestId.AddRange(new[] { 10199 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18880);
HotSpots.Add(new Vector3(2794.527 , 2995.597 , 123.1823 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class InvaluableAssetZapping : QuestGathererClass
{
    public InvaluableAssetZapping()
    {
        Name = "Invaluable Asset Zapping";

        QuestId.AddRange(new[] { 10203 });

        Step = new List<int> { 1, 1, 1, 1, 0 };

        StepAutoDetect = new[] { true, true, true, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10186;

        EntryIdObjects.Add(183807);
EntryIdObjects.Add(183806);
EntryIdObjects.Add(183805);
EntryIdObjects.Add(183808);
HotSpots.Add(new Vector3(2748.193 , 3237.791 , 147.5978 , "None"));
HotSpots.Add(new Vector3(2785.985 , 3173.953 , 145.9446 , "None"));
HotSpots.Add(new Vector3(2716.435 , 3189.78 , 147.5925 , "None"));
HotSpots.Add(new Vector3(2779.864 , 3113.46 , 154.7729 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReporttoEngineering : QuestClass
{
    public ReporttoEngineering()
    {
        Name = "Report to Engineering";

        QuestId.AddRange(new[] { 10225 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10186;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class EssencefortheEngines : QuestGrinderClass
{
    public EssencefortheEngines()
    {
        Name = "Essence for the Engines";

        QuestId.AddRange(new[] { 10224 });

        Step = new List<int> { 7, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10225;

        EntryTarget.Add(18864);
EntryTarget.Add(18880);
HotSpots.Add(new Vector3(3304.363 , 3675.874 , 129.5498 , "None"));
HotSpots.Add(new Vector3(3281.324 , 3610.948 , 127.5342 , "None"));
HotSpots.Add(new Vector3(3297.041 , 3543.999 , 127.3666 , "None"));
HotSpots.Add(new Vector3(3305.267 , 3438.32 , 113.4948 , "None"));
HotSpots.Add(new Vector3(3195.908 , 3375.718 , 103.7714 , "None"));
HotSpots.Add(new Vector3(3195.434 , 3500.558 , 112.4761 , "None"));
HotSpots.Add(new Vector3(3278.659 , 3844.111 , 144.1711 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNInvalubleassetbombsfirst : QuestFollowPathClass
{
    public RUNInvalubleassetbombsfirst()
    {
        Name = "RUN: Invaluble asset - bombs first";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2655.69 , 3072.28 , 124.5618 , "None"));
Path.Add(new Vector3(2673.884 , 3083.873 , 126.0101 , "None"));
Path.Add(new Vector3(2679.708 , 3089.386 , 126.8668 , "None"));
Path.Add(new Vector3(2682.685 , 3096.917 , 128.0574 , "None"));
Path.Add(new Vector3(2679.653 , 3104.496 , 129.0644 , "None"));
Path.Add(new Vector3(2678.208 , 3112.508 , 130.6264 , "None"));
Path.Add(new Vector3(2678.646 , 3120.872 , 132.8361 , "None"));
Path.Add(new Vector3(2681.011 , 3132.836 , 136.4296 , "None"));
Path.Add(new Vector3(2685.641 , 3144.259 , 140.014 , "None"));
Path.Add(new Vector3(2690.543 , 3150.206 , 141.7526 , "None"));
Path.Add(new Vector3(2694.961 , 3155.197 , 143.7567 , "None"));
Path.Add(new Vector3(2703.155 , 3164.456 , 146.7278 , "None"));
Path.Add(new Vector3(2711.254 , 3173.607 , 147.328 , "None"));
Path.Add(new Vector3(2717.681 , 3183.831 , 147.496 , "None"));
Path.Add(new Vector3(2721.904 , 3191.813 , 147.5988 , "None"));
Path.Add(new Vector3(2725.104 , 3194.43 , 147.5973 , "None"));
Path.Add(new Vector3(2730.796 , 3197.101 , 147.6834 , "None"));
Path.Add(new Vector3(2736.126 , 3203.567 , 148.0985 , "None"));
Path.Add(new Vector3(2739.196 , 3210.518 , 148.0313 , "None"));
Path.Add(new Vector3(2742.397 , 3217.003 , 147.728 , "None"));
Path.Add(new Vector3(2744.527 , 3222.127 , 147.6592 , "None"));
Path.Add(new Vector3(2739.491 , 3230.295 , 147.5976 , "None"));
Path.Add(new Vector3(2737.848 , 3235.271 , 147.5976 , "None"));
Path.Add(new Vector3(2749.609 , 3230.254 , 147.5974 , "None"));
Path.Add(new Vector3(2755.979 , 3229.923 , 147.5974 , "None"));
Path.Add(new Vector3(2762.134 , 3228 , 147.7754 , "None"));
Path.Add(new Vector3(2765.753 , 3226.87 , 148.0453 , "None"));
Path.Add(new Vector3(2765.478 , 3232.368 , 147.609 , "None"));
Path.Add(new Vector3(2762.07 , 3240.94 , 147.5977 , "None"));
Path.Add(new Vector3(2765.14 , 3243.964 , 147.5977 , "None"));
Path.Add(new Vector3(2770.787 , 3243.099 , 147.5977 , "None"));
Path.Add(new Vector3(2777.698 , 3235.784 , 147.5977 , "None"));
Path.Add(new Vector3(2787.832 , 3228.869 , 147.5977 , "None"));
Path.Add(new Vector3(2798.511 , 3223.099 , 147.5977 , "None"));
Path.Add(new Vector3(2797.517 , 3208.527 , 146.4479 , "None"));
Path.Add(new Vector3(2794.789 , 3197.106 , 145.5177 , "None"));
Path.Add(new Vector3(2792.126 , 3188.685 , 145.5232 , "None"));
Path.Add(new Vector3(2793.052 , 3182.455 , 145.6658 , "None"));
Path.Add(new Vector3(2794.619 , 3171.004 , 146.5518 , "None"));
Path.Add(new Vector3(2794.042 , 3160.405 , 148.8264 , "None"));
Path.Add(new Vector3(2793.262 , 3154.039 , 149.7466 , "None"));
Path.Add(new Vector3(2792.899 , 3149.426 , 150.3226 , "None"));
Path.Add(new Vector3(2793.531 , 3145.918 , 150.8471 , "None"));
Path.Add(new Vector3(2793.772 , 3143.711 , 151.1508 , "None"));
Path.Add(new Vector3(2793.884 , 3141.806 , 151.4312 , "None"));
Path.Add(new Vector3(2794.996 , 3139.714 , 151.7692 , "None"));
Path.Add(new Vector3(2796.931 , 3136.173 , 152.3466 , "None"));
Path.Add(new Vector3(2797.933 , 3132.635 , 152.9743 , "None"));
Path.Add(new Vector3(2795.946 , 3128.29 , 153.6438 , "None"));
Path.Add(new Vector3(2794.071 , 3124.674 , 154.1693 , "None"));
Path.Add(new Vector3(2792.492 , 3120.985 , 154.6521 , "None"));
Path.Add(new Vector3(2790.818 , 3117.136 , 155.0857 , "None"));
Path.Add(new Vector3(2788.253 , 3114.027 , 155.2868 , "None"));
Path.Add(new Vector3(2784.326 , 3114.067 , 154.9835 , "None"));
Path.Add(new Vector3(2781.615 , 3114.357 , 154.7741 , "None"));
Path.Add(new Vector3(2778.502 , 3114.486 , 154.5836 , "None"));
Path.Add(new Vector3(2778.108 , 3114.502 , 154.5641 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = true;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNThatlittleextrakick : QuestFollowPathClass
{
    public RUNThatlittleextrakick()
    {
        Name = "RUN: That little extra kick";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2954.624 , 3520.662 , 142.507 , "None"));
Path.Add(new Vector3(2931.947 , 3518.482 , 140.897 , "None"));
Path.Add(new Vector3(2912.097 , 3515.195 , 140.1065 , "None"));
Path.Add(new Vector3(2882.475 , 3496.228 , 137.8152 , "None"));
Path.Add(new Vector3(2863.427 , 3481.383 , 136.2994 , "None"));
Path.Add(new Vector3(2849.119 , 3474.282 , 135.355 , "None"));
Path.Add(new Vector3(2808.365 , 3461.405 , 136.0652 , "None"));
Path.Add(new Vector3(2770.316 , 3448.277 , 138.0292 , "None"));
Path.Add(new Vector3(2731.017 , 3434.674 , 141.172 , "None"));
Path.Add(new Vector3(2705.455 , 3418.483 , 143.0514 , "None"));
Path.Add(new Vector3(2686.323 , 3395.931 , 143.1796 , "None"));
Path.Add(new Vector3(2656.331 , 3367.922 , 141.7221 , "None"));
Path.Add(new Vector3(2642.879 , 3341.472 , 138.9257 , "None"));
Path.Add(new Vector3(2642.111 , 3313.705 , 137.296 , "None"));
Path.Add(new Vector3(2642.249 , 3290.038 , 136.9503 , "None"));
Path.Add(new Vector3(2642.701 , 3251.726 , 137.6306 , "None"));
Path.Add(new Vector3(2646.144 , 3236.081 , 139.3802 , "None"));
Path.Add(new Vector3(2647.339 , 3208.492 , 139.2168 , "None"));
Path.Add(new Vector3(2643.702 , 3168.041 , 135.0325 , "None"));
Path.Add(new Vector3(2639.963 , 3146.793 , 134.9583 , "None"));
Path.Add(new Vector3(2639.245 , 3134.329 , 132.9477 , "None"));
Path.Add(new Vector3(2640.931 , 3122.13 , 130.8632 , "None"));
Path.Add(new Vector3(2642.33 , 3110.172 , 128.9014 , "None"));
Path.Add(new Vector3(2640.458 , 3098.148 , 126.9653 , "None"));
Path.Add(new Vector3(2640.03 , 3085.995 , 125.5742 , "None"));
Path.Add(new Vector3(2646.787 , 3077.878 , 124.4109 , "None"));
Path.Add(new Vector3(2647.141 , 3066.088 , 123.9617 , "None"));
Path.Add(new Vector3(2650.72 , 3052.756 , 122.929 , "None"));
Path.Add(new Vector3(2665.063 , 3057.225 , 118.428 , "None"));
Path.Add(new Vector3(2676.338 , 3053.05 , 115.5147 , "None"));
Path.Add(new Vector3(2688.639 , 3052.363 , 122.0898 , "None"));
Path.Add(new Vector3(2697.959 , 3044.651 , 123.15 , "None"));
Path.Add(new Vector3(2709.54 , 3043.155 , 123.1388 , "None"));
Path.Add(new Vector3(2720.4 , 3036.571 , 123.1472 , "None"));
Path.Add(new Vector3(2728.339 , 3028.209 , 122.079 , "None"));
Path.Add(new Vector3(2734.282 , 3016.995 , 121.1176 , "None"));
Path.Add(new Vector3(2745.796 , 3006.825 , 119.7404 , "None"));
Path.Add(new Vector3(2757.99 , 3003.937 , 119.7356 , "None"));
Path.Add(new Vector3(2768.91 , 3001.893 , 120.7875 , "None"));
Path.Add(new Vector3(2781.772 , 3007.552 , 123.4118 , "None"));
Path.Add(new Vector3(2788.082 , 3021.929 , 126.2011 , "None"));
Path.Add(new Vector3(2788.858 , 3033.653 , 127.0984 , "None"));
Path.Add(new Vector3(2793.092 , 3043.655 , 127.6048 , "None"));
Path.Add(new Vector3(2803.94 , 3075.473 , 129.5123 , "None"));
Path.Add(new Vector3(2820.291 , 3068.823 , 130.5381 , "None"));
Path.Add(new Vector3(2830.191 , 3061.398 , 129.7441 , "None"));
Path.Add(new Vector3(2836.399 , 3056.135 , 128.293 , "None"));
Path.Add(new Vector3(2845.603 , 3052.298 , 127.3516 , "None"));
Path.Add(new Vector3(2857.52 , 3052.886 , 127.0951 , "None"));
Path.Add(new Vector3(2856.43 , 3038.832 , 126.1229 , "None"));
Path.Add(new Vector3(2852.791 , 3033.02 , 121.0942 , "None"));
Path.Add(new Vector3(2844.856 , 3024.195 , 123.4867 , "None"));
Path.Add(new Vector3(2836.406 , 3021.678 , 124.5028 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RunInvalubleObj2DredingClaw : QuestFollowPathClass
{
    public RunInvalubleObj2DredingClaw()
    {
        Name = "Run: Invaluble Obj 2 - Dreding Claw";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2781.506 , 3112.912 , 154.9396 , "None"));
Path.Add(new Vector3(2785.424 , 3114.139 , 155.0553 , "None"));
Path.Add(new Vector3(2789.279 , 3115.661 , 155.1601 , "None"));
Path.Add(new Vector3(2792.153 , 3118.449 , 155.0035 , "None"));
Path.Add(new Vector3(2793.763 , 3122.275 , 154.5488 , "None"));
Path.Add(new Vector3(2795.12 , 3126.064 , 154.0016 , "None"));
Path.Add(new Vector3(2796.678 , 3129.92 , 153.3795 , "None"));
Path.Add(new Vector3(2797.778 , 3133.72 , 152.7882 , "None"));
Path.Add(new Vector3(2796.766 , 3137.742 , 152.1353 , "None"));
Path.Add(new Vector3(2794.217 , 3140.841 , 151.582 , "None"));
Path.Add(new Vector3(2791.818 , 3144.057 , 151.042 , "None"));
Path.Add(new Vector3(2790.936 , 3147.97 , 150.461 , "None"));
Path.Add(new Vector3(2791.082 , 3152.031 , 149.9056 , "None"));
Path.Add(new Vector3(2792.681 , 3155.846 , 149.4247 , "None"));
Path.Add(new Vector3(2793.737 , 3159.73 , 148.9345 , "None"));
Path.Add(new Vector3(2794.33 , 3163.849 , 148.1189 , "None"));
Path.Add(new Vector3(2793.973 , 3167.29 , 147.2975 , "None"));
Path.Add(new Vector3(2792.795 , 3171.281 , 146.2822 , "None"));
Path.Add(new Vector3(2790.427 , 3173.407 , 145.9265 , "None"));
Path.Add(new Vector3(2790.066 , 3173.166 , 145.9414 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNInvalubleObj3DigaMatic : QuestFollowPathClass
{
    public RUNInvalubleObj3DigaMatic()
    {
        Name = "RUN: Invaluble Obj 3 - Dig a Matic";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2775.406 , 3176.447 , 147.3612 , "None"));
Path.Add(new Vector3(2770.022 , 3176.01 , 147.8363 , "None"));
Path.Add(new Vector3(2766.04 , 3175.783 , 147.9815 , "None"));
Path.Add(new Vector3(2761.948 , 3176.31 , 148.0699 , "None"));
Path.Add(new Vector3(2758.012 , 3176.744 , 148.1233 , "None"));
Path.Add(new Vector3(2753.923 , 3177.065 , 148.1681 , "None"));
Path.Add(new Vector3(2749.832 , 3177.311 , 148.1034 , "None"));
Path.Add(new Vector3(2745.679 , 3177.036 , 148.0731 , "None"));
Path.Add(new Vector3(2741.759 , 3176.776 , 147.9744 , "None"));
Path.Add(new Vector3(2737.637 , 3177.035 , 147.8831 , "None"));
Path.Add(new Vector3(2733.619 , 3177.052 , 147.7276 , "None"));
Path.Add(new Vector3(2729.435 , 3176.665 , 147.6064 , "None"));
Path.Add(new Vector3(2725.546 , 3175.823 , 147.398 , "None"));
Path.Add(new Vector3(2721.585 , 3174.861 , 147.2312 , "None"));
Path.Add(new Vector3(2717.652 , 3174.222 , 147.219 , "None"));
Path.Add(new Vector3(2713.495 , 3174.435 , 147.2826 , "None"));
Path.Add(new Vector3(2710.512 , 3176.829 , 147.4688 , "None"));
Path.Add(new Vector3(2712.668 , 3180.139 , 147.5061 , "None"));
Path.Add(new Vector3(2715.78 , 3182.678 , 147.5265 , "None"));
Path.Add(new Vector3(2718.346 , 3185.944 , 147.5223 , "None"));
Path.Add(new Vector3(2720.344 , 3189.428 , 147.5665 , "None"));
Path.Add(new Vector3(2722.283 , 3193.102 , 147.5968 , "None"));
Path.Add(new Vector3(2723.074 , 3196.968 , 147.5968 , "None"));
Path.Add(new Vector3(2721.844 , 3200.607 , 147.5476 , "None"));
Path.Add(new Vector3(2718.071 , 3201.986 , 147.5934 , "None"));
Path.Add(new Vector3(2714.176 , 3203.405 , 147.6274 , "None"));
Path.Add(new Vector3(2710.331 , 3204.594 , 147.7093 , "None"));
Path.Add(new Vector3(2706.357 , 3205.828 , 147.6201 , "None"));
Path.Add(new Vector3(2702.573 , 3206.772 , 147.598 , "None"));
Path.Add(new Vector3(2705.479 , 3203.878 , 147.639 , "None"));
Path.Add(new Vector3(2708.384 , 3201.234 , 147.6502 , "None"));
Path.Add(new Vector3(2711.694 , 3198.569 , 147.5976 , "None"));
Path.Add(new Vector3(2714.858 , 3196.068 , 147.5976 , "None"));
Path.Add(new Vector3(2715.312 , 3195.682 , 147.5976 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNInvaluableObj4TerrainAnalyzer : QuestFollowPathClass
{
    public RUNInvaluableObj4TerrainAnalyzer()
    {
        Name = "RUN: Invaluable Obj 4 -Terrain Analyzer";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2719.636 , 3202.313 , 147.5738 , "None"));
Path.Add(new Vector3(2723.908 , 3204.86 , 147.5872 , "None"));
Path.Add(new Vector3(2727.798 , 3206.114 , 147.8272 , "None"));
Path.Add(new Vector3(2731.779 , 3206.851 , 147.9788 , "None"));
Path.Add(new Vector3(2735.762 , 3207.237 , 148.0024 , "None"));
Path.Add(new Vector3(2735.753 , 3211.773 , 147.7212 , "None"));
Path.Add(new Vector3(2734.009 , 3215.636 , 147.6734 , "None"));
Path.Add(new Vector3(2732.737 , 3219.437 , 147.6333 , "None"));
Path.Add(new Vector3(2732.059 , 3223.393 , 147.6066 , "None"));
Path.Add(new Vector3(2732.354 , 3227.381 , 147.5999 , "None"));
Path.Add(new Vector3(2733.739 , 3231.284 , 147.5968 , "None"));
Path.Add(new Vector3(2736.553 , 3234.294 , 147.5968 , "None"));
Path.Add(new Vector3(2741.067 , 3239.261 , 147.5968 , "None"));
Path.Add(new Vector3(2743.767 , 3245.373 , 148.2908 , "None"));
Path.Add(new Vector3(2744.978 , 3249.373 , 148.4556 , "None"));
Path.Add(new Vector3(2746.182 , 3244.217 , 147.6892 , "None"));
Path.Add(new Vector3(2746.126 , 3242.449 , 147.5974 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RebuildingtheStaff : QuestGrinderClass
{
    public RebuildingtheStaff()
    {
        Name = "Rebuilding the Staff";

        QuestId.AddRange(new[] { 10300 });

        Step = new List<int> { 4, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10173;

        EntryTarget.Add(18873);
EntryTarget.Add(21058);
EntryTarget.Add(18872);
HotSpots.Add(new Vector3(3351.65 , 3500.719 , 133.8709 , "None"));
HotSpots.Add(new Vector3(3384.497 , 3491.028 , 139.5714 , "None"));
HotSpots.Add(new Vector3(3440.371 , 3489.116 , 145.9957 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ElementalPowerExtraction : QuestGrinderClass
{
    public ElementalPowerExtraction()
    {
        Name = "Elemental Power Extraction";

        QuestId.AddRange(new[] { 10226 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10224;

        EntryTarget.Add(18865);
EntryTarget.Add(18881);
EntryTarget.Add(21322);
HotSpots.Add(new Vector3(2586.327 , 3151.412 , 112.7613 , "None"));
HotSpots.Add(new Vector3(2589.263 , 3186.933 , 122.0447 , "None"));
HotSpots.Add(new Vector3(2586.52 , 3294.437 , 128.4301 , "None"));
HotSpots.Add(new Vector3(2563.218 , 3540.62 , 142.0887 , "None"));
HotSpots.Add(new Vector3(2630.138 , 3583.028 , 147.4063 , "None"));
HotSpots.Add(new Vector3(2510.031 , 3717.356 , 128.7276 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DrBoom : QuestGrinderClass
{
    public DrBoom()
    {
        Name = "Dr. Boom!";

        QuestId.AddRange(new[] { 10221 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10203;

        EntryTarget.Add(20284);
EntryTarget.Add(19692);
HotSpots.Add(new Vector3(3207.87 , 3538.252 , 126.7572 , "None"));
HotSpots.Add(new Vector3(3227.719 , 3551.001 , 124.2818 , "None"));
HotSpots.Add(new Vector3(3230.08 , 3533.661 , 122.8115 , "None"));
HotSpots.Add(new Vector3(3241.92 , 3532.806 , 121.3476 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CurseoftheVioletTower : QuestClass
{
    public CurseoftheVioletTower()
    {
        Name = "Curse of the Violet Tower";

        QuestId.AddRange(new[] { 10174 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10300;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AFateWorseThanDeath : QuestGrinderClass
{
    public AFateWorseThanDeath()
    {
        Name = "A Fate Worse Than Death";

        QuestId.AddRange(new[] { 10185 });

        Step = new List<int> { 10, 10, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10174;

        EntryTarget.Add(18866);
EntryTarget.Add(18867);
HotSpots.Add(new Vector3(2268.439 , 2300.839 , 92.08313 , "None"));
HotSpots.Add(new Vector3(2275.028 , 2373.142 , 115.173 , "None"));
HotSpots.Add(new Vector3(2195.366 , 2447.242 , 109.1024 , "None"));
HotSpots.Add(new Vector3(2122.861 , 2421.807 , 85.99906 , "None"));
HotSpots.Add(new Vector3(2120.068 , 2388.536 , 80.71527 , "None"));
HotSpots.Add(new Vector3(2127.892 , 2360.548 , 71.30166 , "None"));
HotSpots.Add(new Vector3(2201.737 , 2368.378 , 97.19288 , "None"));
HotSpots.Add(new Vector3(2262.014 , 2306.29 , 93.49066 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MalevolentRemnants : QuestGrinderClass
{
    public MalevolentRemnants()
    {
        Name = "Malevolent Remnants";

        QuestId.AddRange(new[] { 10184 });

        Step = new List<int> { 20, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10174;

        EntryTarget.Add(19881);
EntryTarget.Add(20934);
HotSpots.Add(new Vector3(2269.379 , 2194.698 , 90.76713 , "None"));
HotSpots.Add(new Vector3(2312.552 , 2179.407 , 91.0661 , "None"));
HotSpots.Add(new Vector3(2325.927 , 2187.237 , 92.03156 , "None"));
HotSpots.Add(new Vector3(2251.811 , 2169.383 , 82.77503 , "None"));
HotSpots.Add(new Vector3(2171.487 , 2177.432 , 70.04176 , "None"));
HotSpots.Add(new Vector3(2109.045 , 2206.556 , 72.47522 , "None"));
HotSpots.Add(new Vector3(2149.021 , 2262.294 , 75.06717 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheSunfuryGarrison : QuestGrinderClass
{
    public TheSunfuryGarrison()
    {
        Name = "The Sunfury Garrison";

        QuestId.AddRange(new[] { 10222 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10174;

        EntryTarget.Add(19707);
EntryTarget.Add(20221);
HotSpots.Add(new Vector3(2448.747 , 2345.834 , 139.8989 , "None"));
HotSpots.Add(new Vector3(2491.048 , 2345.216 , 136.4502 , "None"));
HotSpots.Add(new Vector3(2493.932 , 2374.696 , 135.8266 , "None"));
HotSpots.Add(new Vector3(2503.106 , 2412.686 , 133.0235 , "None"));
HotSpots.Add(new Vector3(2537.617 , 2367.391 , 128.5081 , "None"));
HotSpots.Add(new Vector3(2553.57 , 2326.534 , 115.9217 , "None"));
HotSpots.Add(new Vector3(2573.088 , 2344.735 , 115.4306 , "None"));
HotSpots.Add(new Vector3(2577.681 , 2352.587 , 112.3162 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheUnendingInvasion : QuestGathererClass
{
    public TheUnendingInvasion()
    {
        Name = "The Unending Invasion";

        QuestId.AddRange(new[] { 10343 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10174;

        EntryIdObjects.Add(184433);
HotSpots.Add(new Vector3(2214.888 , 2379.136 , 103.0549 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class IndispensableTools : QuestGrinderClass
{
    public IndispensableTools()
    {
        Name = "Indispensable Tools";

        QuestId.AddRange(new[] { 10331 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(20409);
HotSpots.Add(new Vector3(2308.806 , 2095.695 , 79.54735 , "None"));
HotSpots.Add(new Vector3(2302.203 , 2072.83 , 74.75613 , "None"));
HotSpots.Add(new Vector3(2298.946 , 2072.152 , 75.02821 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class NeedsMoreCowbell : QuestClass
{
    public NeedsMoreCowbell()
    {
        Name = "Needs More Cowbell";

        QuestId.AddRange(new[] { 10334 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MasterSmithRhonsus : QuestGrinderClass
{
    public MasterSmithRhonsus()
    {
        Name = "Master Smith Rhonsus";

        QuestId.AddRange(new[] { 10332 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10331;

        EntryTarget.Add(20410);
HotSpots.Add(new Vector3(2290.337 , 2101.975 , 75.17014 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PotentialEnergySource : QuestGathererClass
{
    public PotentialEnergySource()
    {
        Name = "Potential Energy Source";

        QuestId.AddRange(new[] { 10239 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10343;

        EntryIdObjects.Add(183945);
HotSpots.Add(new Vector3(2455.176 , 2754.462 , 134.4934 , "None"));
HotSpots.Add(new Vector3(2454.63 , 2774.005 , 134.4933 , "None"));
HotSpots.Add(new Vector3(2424.948 , 2795.936 , 134.4929 , "None"));
HotSpots.Add(new Vector3(2371.342 , 2660.944 , 131.535 , "None"));
HotSpots.Add(new Vector3(2353.353 , 2680.861 , 127.2737 , "None"));
HotSpots.Add(new Vector3(2377.224 , 2590.542 , 135.7256 , "None"));
HotSpots.Add(new Vector3(2381.408 , 2561.703 , 136.6933 , "None"));
HotSpots.Add(new Vector3(2441.17 , 2593.339 , 134.3221 , "None"));
HotSpots.Add(new Vector3(2441.548 , 2614.023 , 134.3228 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DownWithDaellis : QuestGrinderClass
{
    public DownWithDaellis()
    {
        Name = "Down With Daellis";

        QuestId.AddRange(new[] { 10223 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10222;

        EntryTarget.Add(19705);
EntryTarget.Add(20207);
HotSpots.Add(new Vector3(2988.31 , 2357.27 , 155.0622 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheAnnalsofKirinVar : QuestGrinderClass
{
    public TheAnnalsofKirinVar()
    {
        Name = "The Annals of Kirin'Var";

        QuestId.AddRange(new[] { 10312 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10184;

        EntryTarget.Add(19543);
HotSpots.Add(new Vector3(2196.025 , 2109.567 , 71.18881 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNRuntoDownwithDaelllis : QuestFollowPathClass
{
    public RUNRuntoDownwithDaelllis()
    {
        Name = "RUN: Run to Down with Daelllis";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2768.719 , 2620.996 , 102.3362 , "None"));
Path.Add(new Vector3(2781.023 , 2623.511 , 102.4728 , "None"));
Path.Add(new Vector3(2793.565 , 2626.102 , 102.4728 , "None"));
Path.Add(new Vector3(2799.156 , 2627.657 , 102.4728 , "None"));
Path.Add(new Vector3(2803.22 , 2629.049 , 102.4728 , "None"));
Path.Add(new Vector3(2806.917 , 2630.376 , 102.4728 , "None"));
Path.Add(new Vector3(2813.546 , 2632.873 , 102.4728 , "None"));
Path.Add(new Vector3(2824.649 , 2638.301 , 105.0712 , "None"));
Path.Add(new Vector3(2829.957 , 2640.797 , 106.1448 , "None"));
Path.Add(new Vector3(2833.866 , 2640.653 , 106.9608 , "None"));
Path.Add(new Vector3(2842.259 , 2636.54 , 108.8113 , "None"));
Path.Add(new Vector3(2854.25 , 2636.773 , 110.8519 , "None"));
Path.Add(new Vector3(2865.908 , 2640.614 , 111.9872 , "None"));
Path.Add(new Vector3(2877.122 , 2644.108 , 113.1484 , "None"));
Path.Add(new Vector3(2884.888 , 2643.377 , 113.5779 , "None"));
Path.Add(new Vector3(2895.78 , 2639.597 , 114.7078 , "None"));
Path.Add(new Vector3(2906.725 , 2633.664 , 115.5268 , "None"));
Path.Add(new Vector3(2918.322 , 2630.708 , 115.8709 , "None"));
Path.Add(new Vector3(2928.782 , 2624.081 , 115.6664 , "None"));
Path.Add(new Vector3(2936.61 , 2614.824 , 117.2378 , "None"));
Path.Add(new Vector3(2943.823 , 2605.599 , 118.149 , "None"));
Path.Add(new Vector3(2952.059 , 2597.04 , 119.3734 , "None"));
Path.Add(new Vector3(2955.803 , 2585.827 , 121.6443 , "None"));
Path.Add(new Vector3(2959.186 , 2574.027 , 123.4524 , "None"));
Path.Add(new Vector3(2960.932 , 2564.236 , 124.4497 , "None"));
Path.Add(new Vector3(2961.031 , 2558.779 , 124.9731 , "None"));
Path.Add(new Vector3(2961.122 , 2553.129 , 125.2884 , "None"));
Path.Add(new Vector3(2960.892 , 2548.112 , 125.4495 , "None"));
Path.Add(new Vector3(2962.097 , 2540.753 , 125.2891 , "None"));
Path.Add(new Vector3(2956.233 , 2528.289 , 126.0659 , "None"));
Path.Add(new Vector3(2953.013 , 2517.859 , 128.5183 , "None"));
Path.Add(new Vector3(2949.45 , 2506.322 , 130.2842 , "None"));
Path.Add(new Vector3(2951.065 , 2501.796 , 126.5023 , "None"));
Path.Add(new Vector3(2953.729 , 2493.113 , 130.3837 , "None"));
Path.Add(new Vector3(2955.677 , 2486.764 , 133.0641 , "None"));
Path.Add(new Vector3(2956.207 , 2479.853 , 133.1299 , "None"));
Path.Add(new Vector3(2959.2 , 2467.98 , 132.738 , "None"));
Path.Add(new Vector3(2962.254 , 2465.616 , 133.2189 , "None"));
Path.Add(new Vector3(2965.026 , 2459.165 , 132.565 , "None"));
Path.Add(new Vector3(2961.519 , 2460.363 , 132.1678 , "None"));
Path.Add(new Vector3(2961.388 , 2466.102 , 133.0881 , "None"));
Path.Add(new Vector3(2967.022 , 2441.357 , 132.7534 , "None"));
Path.Add(new Vector3(2966.35 , 2434.08 , 133.1985 , "None"));
Path.Add(new Vector3(2961.177 , 2427.051 , 133.012 , "None"));
Path.Add(new Vector3(2954.969 , 2422.051 , 132.5392 , "None"));
Path.Add(new Vector3(2949.701 , 2421.451 , 132.0244 , "None"));
Path.Add(new Vector3(2944.034 , 2422.218 , 131.4166 , "None"));
Path.Add(new Vector3(2943.412 , 2423.496 , 130.8489 , "None"));
Path.Add(new Vector3(2941.831 , 2424.609 , 129.2254 , "None"));
Path.Add(new Vector3(2939.964 , 2425.709 , 127.5223 , "None"));
Path.Add(new Vector3(2937.654 , 2425.82 , 125.3402 , "None"));
Path.Add(new Vector3(2935.388 , 2425.549 , 125.0006 , "None"));
Path.Add(new Vector3(2933.142 , 2425.907 , 125.2042 , "None"));
Path.Add(new Vector3(2930.761 , 2425.047 , 125.0434 , "None"));
Path.Add(new Vector3(2926.892 , 2419.296 , 125.0933 , "None"));
Path.Add(new Vector3(2925.51 , 2418.053 , 125.6816 , "None"));
Path.Add(new Vector3(2924.948 , 2414.694 , 127.8653 , "None"));
Path.Add(new Vector3(2930.249 , 2412.069 , 129.4755 , "None"));
Path.Add(new Vector3(2941.69 , 2408.661 , 134.5297 , "None"));
Path.Add(new Vector3(2950.565 , 2405.818 , 142.2022 , "None"));
Path.Add(new Vector3(2959.13 , 2403.946 , 146.6385 , "None"));
Path.Add(new Vector3(2966.503 , 2405.386 , 150.1301 , "None"));
Path.Add(new Vector3(2970.146 , 2403.372 , 151.689 , "None"));
Path.Add(new Vector3(2973.241 , 2399.909 , 153.0986 , "None"));
Path.Add(new Vector3(2974.056 , 2398.039 , 153.7874 , "None"));
Path.Add(new Vector3(2974.671 , 2393.687 , 154.6175 , "None"));
Path.Add(new Vector3(2975.225 , 2389.765 , 154.7314 , "None"));
Path.Add(new Vector3(2976.076 , 2384.668 , 154.4982 , "None"));
Path.Add(new Vector3(2976.94 , 2380.186 , 154.4319 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNTurnInDownwithDaellis : QuestFollowPathClass
{
    public RUNTurnInDownwithDaellis()
    {
        Name = "RUN: TurnIn Down with Daellis";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2977.943 , 2374.801 , 153.142 , "None"));
Path.Add(new Vector3(2974.441 , 2382.732 , 154.2846 , "None"));
Path.Add(new Vector3(2970.197 , 2391.737 , 153.115 , "None"));
Path.Add(new Vector3(2963.957 , 2398.428 , 149.6888 , "None"));
Path.Add(new Vector3(2954.345 , 2406.54 , 143.9723 , "None"));
Path.Add(new Vector3(2947.224 , 2408.017 , 139.6206 , "None"));
Path.Add(new Vector3(2941.594 , 2407.093 , 134.5909 , "None"));
Path.Add(new Vector3(2937.817 , 2409.864 , 130.5744 , "None"));
Path.Add(new Vector3(2931.323 , 2416.8 , 125.9065 , "None"));
Path.Add(new Vector3(2926.496 , 2427.615 , 126.2562 , "None"));
Path.Add(new Vector3(2924.908 , 2434.835 , 127.2887 , "None"));
Path.Add(new Vector3(2920.987 , 2446.161 , 125.6954 , "None"));
Path.Add(new Vector3(2916.831 , 2455.227 , 123.6048 , "None"));
Path.Add(new Vector3(2915.082 , 2461.128 , 122.7142 , "None"));
Path.Add(new Vector3(2913.137 , 2471.522 , 122.3895 , "None"));
Path.Add(new Vector3(2912.273 , 2476.126 , 121.7874 , "None"));
Path.Add(new Vector3(2911.18 , 2479.782 , 120.3568 , "None"));
Path.Add(new Vector3(2907.125 , 2492.479 , 114.6172 , "None"));
Path.Add(new Vector3(2906.716 , 2497.049 , 117.0433 , "None"));
Path.Add(new Vector3(2906.077 , 2502.591 , 119.5669 , "None"));
Path.Add(new Vector3(2907.759 , 2506.883 , 122.4277 , "None"));
Path.Add(new Vector3(2908.694 , 2511.819 , 123.447 , "None"));
Path.Add(new Vector3(2911.721 , 2520.223 , 123.9972 , "None"));
Path.Add(new Vector3(2914.385 , 2527.706 , 124.3148 , "None"));
Path.Add(new Vector3(2915.12 , 2533.284 , 124.3064 , "None"));
Path.Add(new Vector3(2917.078 , 2538.201 , 124.505 , "None"));
Path.Add(new Vector3(2920.501 , 2546.557 , 123.2515 , "None"));
Path.Add(new Vector3(2926.276 , 2557.565 , 124.7281 , "None"));
Path.Add(new Vector3(2934.377 , 2566.938 , 124.4296 , "None"));
Path.Add(new Vector3(2941.642 , 2575.75 , 123.3142 , "None"));
Path.Add(new Vector3(2949.373 , 2586.61 , 121.5844 , "None"));
Path.Add(new Vector3(2954 , 2597.122 , 119.35 , "None"));
Path.Add(new Vector3(2954.896 , 2609.484 , 117.3148 , "None"));
Path.Add(new Vector3(2953.254 , 2620.977 , 115.8826 , "None"));
Path.Add(new Vector3(2949.398 , 2633.159 , 116.8831 , "None"));
Path.Add(new Vector3(2940.13 , 2639.909 , 117.6704 , "None"));
Path.Add(new Vector3(2929.331 , 2646.122 , 118.4456 , "None"));
Path.Add(new Vector3(2920.74 , 2648.208 , 117.6868 , "None"));
Path.Add(new Vector3(2918.01 , 2646.067 , 117.0164 , "None"));
Path.Add(new Vector3(2910.3 , 2653.237 , 117.1974 , "None"));
Path.Add(new Vector3(2901.069 , 2660.609 , 117.3237 , "None"));
Path.Add(new Vector3(2891.683 , 2665.162 , 115.9327 , "None"));
Path.Add(new Vector3(2885.336 , 2662.688 , 114.9154 , "None"));
Path.Add(new Vector3(2873.568 , 2660.531 , 108.9545 , "None"));
Path.Add(new Vector3(2861.139 , 2660.143 , 109.4152 , "None"));
Path.Add(new Vector3(2848.644 , 2661.397 , 108.5975 , "None"));
Path.Add(new Vector3(2837.094 , 2658.339 , 106.1219 , "None"));
Path.Add(new Vector3(2827.914 , 2651.115 , 104.1288 , "None"));
Path.Add(new Vector3(2821.43 , 2640.31 , 103.6311 , "None"));
Path.Add(new Vector3(2813.553 , 2631.5 , 102.4715 , "None"));
Path.Add(new Vector3(2802.793 , 2626.344 , 102.4715 , "None"));
Path.Add(new Vector3(2790.972 , 2623.177 , 102.4715 , "None"));
Path.Add(new Vector3(2778.115 , 2621.306 , 102.4007 , "None"));
Path.Add(new Vector3(2766.293 , 2619.705 , 102.3363 , "None"));
Path.Add(new Vector3(2753.921 , 2618.029 , 102.3432 , "None"));
Path.Add(new Vector3(2742.17 , 2616.437 , 102.3463 , "None"));
Path.Add(new Vector3(2728.41 , 2614.573 , 102.4798 , "None"));
Path.Add(new Vector3(2717.757 , 2613.155 , 102.4808 , "None"));
Path.Add(new Vector3(2705.508 , 2611.667 , 102.4793 , "None"));
Path.Add(new Vector3(2693.394 , 2611.213 , 103.1174 , "None"));
Path.Add(new Vector3(2681.86 , 2611.028 , 105.208 , "None"));
Path.Add(new Vector3(2669.47 , 2610.852 , 108.5065 , "None"));
Path.Add(new Vector3(2656.72 , 2610.671 , 112.936 , "None"));
Path.Add(new Vector3(2650.974 , 2610.589 , 114.6552 , "None"));
Path.Add(new Vector3(2643.915 , 2600.562 , 119.2648 , "None"));
Path.Add(new Vector3(2636.796 , 2590.659 , 123.297 , "None"));
Path.Add(new Vector3(2633.862 , 2588.747 , 123.5727 , "None"));
Path.Add(new Vector3(2627.64 , 2601.307 , 123.2744 , "None"));
Path.Add(new Vector3(2622.715 , 2607.452 , 124.7128 , "None"));
Path.Add(new Vector3(2611.797 , 2613.253 , 126.4913 , "None"));
Path.Add(new Vector3(2600.694 , 2619.069 , 130.6774 , "None"));
Path.Add(new Vector3(2589.485 , 2624.942 , 131.498 , "None"));
Path.Add(new Vector3(2577.963 , 2627.541 , 130.8404 , "None"));
Path.Add(new Vector3(2570.917 , 2626.391 , 131.0524 , "None"));
Path.Add(new Vector3(2560.631 , 2621.042 , 130.6185 , "None"));
Path.Add(new Vector3(2547.822 , 2619.377 , 126.6965 , "None"));
Path.Add(new Vector3(2538.769 , 2617.258 , 126.0661 , "None"));
Path.Add(new Vector3(2534.632 , 2616.289 , 128.2152 , "None"));
Path.Add(new Vector3(2528.46 , 2609.305 , 130.6064 , "None"));
Path.Add(new Vector3(2523.527 , 2597.706 , 129.5686 , "None"));
Path.Add(new Vector3(2519.918 , 2589.962 , 129.2042 , "None"));
Path.Add(new Vector3(2514.958 , 2580.289 , 129.3424 , "None"));
Path.Add(new Vector3(2513.621 , 2567.89 , 129.1658 , "None"));
Path.Add(new Vector3(2512.013 , 2556.412 , 129.2072 , "None"));
Path.Add(new Vector3(2509.528 , 2544.39 , 129.3591 , "None"));
Path.Add(new Vector3(2506.837 , 2532.148 , 129.1527 , "None"));
Path.Add(new Vector3(2503.88 , 2520.143 , 128.916 , "None"));
Path.Add(new Vector3(2500.698 , 2508.469 , 129.1126 , "None"));
Path.Add(new Vector3(2497.101 , 2497.041 , 129.0481 , "None"));
Path.Add(new Vector3(2493.236 , 2485.067 , 129.109 , "None"));
Path.Add(new Vector3(2488.961 , 2473.704 , 129.305 , "None"));
Path.Add(new Vector3(2483.91 , 2462.389 , 130.3508 , "None"));
Path.Add(new Vector3(2481.548 , 2451.686 , 131.7921 , "None"));
Path.Add(new Vector3(2474.844 , 2441.317 , 135.1267 , "None"));
Path.Add(new Vector3(2466.27 , 2432.528 , 137.7769 , "None"));
Path.Add(new Vector3(2458.631 , 2423.052 , 141.6128 , "None"));
Path.Add(new Vector3(2451.129 , 2413.745 , 142.0686 , "None"));
Path.Add(new Vector3(2443.182 , 2404.116 , 141.5429 , "None"));
Path.Add(new Vector3(2434.772 , 2394.887 , 142.8408 , "None"));
Path.Add(new Vector3(2426.047 , 2386.154 , 143.0359 , "None"));
Path.Add(new Vector3(2416.897 , 2378.481 , 143.7518 , "None"));
Path.Add(new Vector3(2404.593 , 2377.792 , 145.0301 , "None"));
Path.Add(new Vector3(2393.192 , 2381.005 , 143.8612 , "None"));
Path.Add(new Vector3(2382.493 , 2386.325 , 136.7596 , "None"));
Path.Add(new Vector3(2370.308 , 2386.347 , 130.0026 , "None"));
Path.Add(new Vector3(2357.875 , 2383.334 , 123.9376 , "None"));
Path.Add(new Vector3(2347.638 , 2378.45 , 120.0848 , "None"));
Path.Add(new Vector3(2338.767 , 2369.676 , 116.6075 , "None"));
Path.Add(new Vector3(2332.568 , 2359.516 , 114.0513 , "None"));
Path.Add(new Vector3(2327.672 , 2348.2 , 111.2084 , "None"));
Path.Add(new Vector3(2325.646 , 2335.54 , 108.0001 , "None"));
Path.Add(new Vector3(2323.825 , 2323.651 , 105.139 , "None"));
Path.Add(new Vector3(2320.726 , 2311.659 , 102.5451 , "None"));
Path.Add(new Vector3(2313.352 , 2301.958 , 100.0833 , "None"));
Path.Add(new Vector3(2303.452 , 2295.046 , 98.05044 , "None"));
Path.Add(new Vector3(2293.297 , 2288.253 , 96.10274 , "None"));
Path.Add(new Vector3(2282.655 , 2282.35 , 94.56827 , "None"));
Path.Add(new Vector3(2272.037 , 2276.747 , 95.30953 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNPotentialengergysource : QuestFollowPathClass
{
    public RUNPotentialengergysource()
    {
        Name = "RUN: Potential engergy source";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2324.6 , 2594.658 , 126.1998 , "None"));
Path.Add(new Vector3(2324.232 , 2602.422 , 126.4817 , "None"));
Path.Add(new Vector3(2330.781 , 2613.709 , 127.2563 , "None"));
Path.Add(new Vector3(2335.009 , 2618.882 , 127.8966 , "None"));
Path.Add(new Vector3(2336.982 , 2625.522 , 128.3995 , "None"));
Path.Add(new Vector3(2333.156 , 2633.949 , 128.5772 , "None"));
Path.Add(new Vector3(2333.243 , 2643.673 , 128.4794 , "None"));
Path.Add(new Vector3(2337.215 , 2655.574 , 128.3626 , "None"));
Path.Add(new Vector3(2340.528 , 2660.524 , 127.2164 , "None"));
Path.Add(new Vector3(2344.4 , 2664.252 , 127.1078 , "None"));
Path.Add(new Vector3(2350.701 , 2657.284 , 130.4404 , "None"));
Path.Add(new Vector3(2358.021 , 2651.485 , 130.9026 , "None"));
Path.Add(new Vector3(2360.874 , 2655.795 , 130.8357 , "None"));
Path.Add(new Vector3(2364.488 , 2661.251 , 130.9347 , "None"));
Path.Add(new Vector3(2369.526 , 2675.094 , 133.0842 , "None"));
Path.Add(new Vector3(2380.997 , 2704.745 , 133.0842 , "None"));
Path.Add(new Vector3(2391.285 , 2716.549 , 133.6262 , "None"));
Path.Add(new Vector3(2394.462 , 2724.294 , 134.4932 , "None"));
Path.Add(new Vector3(2399.904 , 2723.705 , 134.4932 , "None"));
Path.Add(new Vector3(2404.886 , 2725.972 , 134.4932 , "None"));
Path.Add(new Vector3(2409.436 , 2728.025 , 134.4932 , "None"));
Path.Add(new Vector3(2414.735 , 2729.826 , 134.4932 , "None"));
Path.Add(new Vector3(2419.098 , 2734.245 , 134.1432 , "None"));
Path.Add(new Vector3(2424.664 , 2738.153 , 134.0581 , "None"));
Path.Add(new Vector3(2426.55 , 2742.759 , 133.6541 , "None"));
Path.Add(new Vector3(2429.063 , 2746.349 , 133.6501 , "None"));
Path.Add(new Vector3(2431.639 , 2748.781 , 133.7605 , "None"));
Path.Add(new Vector3(2436.316 , 2753.807 , 134.0101 , "None"));
Path.Add(new Vector3(2437.618 , 2757.057 , 134.1145 , "None"));
Path.Add(new Vector3(2439.085 , 2763.676 , 134.2695 , "None"));
Path.Add(new Vector3(2438.762 , 2770.667 , 134.3737 , "None"));
Path.Add(new Vector3(2436.686 , 2777.437 , 134.4507 , "None"));
Path.Add(new Vector3(2435.096 , 2780.664 , 134.4549 , "None"));
Path.Add(new Vector3(2431.015 , 2786.381 , 134.4587 , "None"));
Path.Add(new Vector3(2426.2 , 2791.328 , 134.4911 , "None"));
Path.Add(new Vector3(2423.062 , 2792.961 , 134.4912 , "None"));
Path.Add(new Vector3(2419.553 , 2792.985 , 134.4912 , "None"));
Path.Add(new Vector3(2415.719 , 2795.718 , 134.4923 , "None"));
Path.Add(new Vector3(2410.451 , 2796.663 , 134.4923 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class SearchingforEvidence : QuestClass
{
    public SearchingforEvidence()
    {
        Name = "Searching for Evidence";

        QuestId.AddRange(new[] { 10316 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10312;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BuildingaPerimeter : QuestUseItemOnClass
{
    public BuildingaPerimeter()
    {
        Name = "Building a Perimeter";

        QuestId.AddRange(new[] { 10240 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10239;

        EntryIdTarget.Add(183947);
HotSpots.Add(new Vector3(2256 , 2455.37 , 99.10286 , "None"));
HotSpots.Add(new Vector3(2377.175 , 2285.015 , 135.749 , "None"));
HotSpots.Add(new Vector3(2284.803 , 2181.133 , 92.4549 , "None"));
ItemId = 28725;
Range = 9.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RUNPremiete1 : QuestFollowPathClass
{
    public RUNPremiete1()
    {
        Name = "RUN: Premiete 1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2306.71 , 2297.282 , 98.4935 , "None"));
Path.Add(new Vector3(2312.094 , 2315.249 , 101.7889 , "None"));
Path.Add(new Vector3(2311.306 , 2319.196 , 102.1771 , "None"));
Path.Add(new Vector3(2315.778 , 2336.083 , 107.985 , "None"));
Path.Add(new Vector3(2320.539 , 2352.888 , 113.1526 , "None"));
Path.Add(new Vector3(2320.749 , 2366.152 , 116.5212 , "None"));
Path.Add(new Vector3(2319.8 , 2371.461 , 117.1543 , "None"));
Path.Add(new Vector3(2317.149 , 2377.786 , 117.3535 , "None"));
Path.Add(new Vector3(2310.366 , 2387.769 , 115.2406 , "None"));
Path.Add(new Vector3(2303.14 , 2397.92 , 111.9463 , "None"));
Path.Add(new Vector3(2295.568 , 2407.321 , 109.4131 , "None"));
Path.Add(new Vector3(2288.047 , 2417.286 , 107.2791 , "None"));
Path.Add(new Vector3(2279.88 , 2426.103 , 104.0824 , "None"));
Path.Add(new Vector3(2270.821 , 2434.086 , 100.2452 , "None"));
Path.Add(new Vector3(2267.227 , 2437.312 , 100.4286 , "None"));
Path.Add(new Vector3(2266.424 , 2442.07 , 100.3342 , "None"));
Path.Add(new Vector3(2263.765 , 2447.485 , 99.85567 , "None"));
Path.Add(new Vector3(2258.813 , 2454.304 , 99.65777 , "None"));
Path.Add(new Vector3(2256.378 , 2456.986 , 98.9273 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNPremiere2 : QuestFollowPathClass
{
    public RUNPremiere2()
    {
        Name = "RUN: Premiere 2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2320.074 , 2363.634 , 116.0987 , "None"));
Path.Add(new Vector3(2320.149 , 2358.804 , 115.049 , "None"));
Path.Add(new Vector3(2320.16 , 2351.947 , 112.8419 , "None"));
Path.Add(new Vector3(2321.59 , 2339.96 , 109.3736 , "None"));
Path.Add(new Vector3(2323.212 , 2327.653 , 106.0102 , "None"));
Path.Add(new Vector3(2324.8 , 2315.61 , 103.8639 , "None"));
Path.Add(new Vector3(2326.534 , 2303.344 , 103.9764 , "None"));
Path.Add(new Vector3(2328.58 , 2291.478 , 104.5089 , "None"));
Path.Add(new Vector3(2332.215 , 2279.486 , 105.3836 , "None"));
Path.Add(new Vector3(2334.506 , 2268.059 , 106.3358 , "None"));
Path.Add(new Vector3(2335.796 , 2255.798 , 106.6551 , "None"));
Path.Add(new Vector3(2335.501 , 2243.67 , 106.1967 , "None"));
Path.Add(new Vector3(2333.477 , 2231.863 , 105.8826 , "None"));
Path.Add(new Vector3(2329.831 , 2220.353 , 105.2933 , "None"));
Path.Add(new Vector3(2326.329 , 2213.16 , 104.1694 , "None"));
Path.Add(new Vector3(2322.737 , 2206.845 , 102.3629 , "None"));
Path.Add(new Vector3(2315.678 , 2203.389 , 98.42697 , "None"));
Path.Add(new Vector3(2312.73 , 2197.971 , 96.25165 , "None"));
Path.Add(new Vector3(2317.176 , 2191.574 , 93.78426 , "None"));
Path.Add(new Vector3(2319.974 , 2186.605 , 91.99338 , "None"));
Path.Add(new Vector3(2325.437 , 2186.467 , 91.72019 , "None"));
Path.Add(new Vector3(2330.135 , 2184.225 , 90.76059 , "None"));
Path.Add(new Vector3(2335.305 , 2183.112 , 90.16209 , "None"));
Path.Add(new Vector3(2340.152 , 2182.392 , 89.94868 , "None"));
Path.Add(new Vector3(2349.806 , 2182.232 , 89.45567 , "None"));
Path.Add(new Vector3(2362.355 , 2182.689 , 88.90723 , "None"));
Path.Add(new Vector3(2374.412 , 2183.359 , 88.41319 , "None"));
Path.Add(new Vector3(2386.365 , 2184.41 , 87.97611 , "None"));
Path.Add(new Vector3(2399.17 , 2185.694 , 87.53084 , "None"));
Path.Add(new Vector3(2403.466 , 2187.193 , 88.45589 , "None"));
Path.Add(new Vector3(2408.91 , 2188.609 , 90.77087 , "None"));
Path.Add(new Vector3(2413.711 , 2186.849 , 91.83788 , "None"));
Path.Add(new Vector3(2419.258 , 2188.339 , 94.3826 , "None"));
Path.Add(new Vector3(2419.239 , 2194.881 , 97.09035 , "None"));
Path.Add(new Vector3(2415.274 , 2205.151 , 100.0858 , "None"));
Path.Add(new Vector3(2411.367 , 2217.624 , 105.9729 , "None"));
Path.Add(new Vector3(2406.412 , 2228.628 , 111.8753 , "None"));
Path.Add(new Vector3(2404.532 , 2237.146 , 115.9559 , "None"));
Path.Add(new Vector3(2405.501 , 2243.398 , 118.7696 , "None"));
Path.Add(new Vector3(2406.148 , 2249.416 , 121.5075 , "None"));
Path.Add(new Vector3(2399.399 , 2252.866 , 123.3847 , "None"));
Path.Add(new Vector3(2392.051 , 2261.478 , 127.5075 , "None"));
Path.Add(new Vector3(2388.913 , 2267.933 , 130.3731 , "None"));
Path.Add(new Vector3(2385.557 , 2272.599 , 132.3787 , "None"));
Path.Add(new Vector3(2380.19 , 2280.618 , 134.943 , "None"));
Path.Add(new Vector3(2378.012 , 2283.955 , 135.6881 , "None"));
Path.Add(new Vector3(2376.26 , 2286.198 , 135.474 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class RUNPremiere3 : QuestFollowPathClass
{
    public RUNPremiere3()
    {
        Name = "RUN: Premiere 3";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2384.635 , 2278.232 , 134.4339 , "None"));
Path.Add(new Vector3(2386.682 , 2268.496 , 130.6786 , "None"));
Path.Add(new Vector3(2390.987 , 2256.375 , 125.3139 , "None"));
Path.Add(new Vector3(2396.235 , 2245.452 , 120.1877 , "None"));
Path.Add(new Vector3(2401.907 , 2235.287 , 115.2839 , "None"));
Path.Add(new Vector3(2407.477 , 2224.506 , 109.8297 , "None"));
Path.Add(new Vector3(2412.495 , 2212.71 , 103.0576 , "None"));
Path.Add(new Vector3(2409.82 , 2202.602 , 98.22595 , "None"));
Path.Add(new Vector3(2411.27 , 2197.203 , 97.7324 , "None"));
Path.Add(new Vector3(2416.366 , 2189.142 , 94.21809 , "None"));
Path.Add(new Vector3(2415.095 , 2185.372 , 91.92522 , "None"));
Path.Add(new Vector3(2403.957 , 2184.877 , 88.2041 , "None"));
Path.Add(new Vector3(2398.849 , 2183.82 , 87.28511 , "None"));
Path.Add(new Vector3(2386.975 , 2182.316 , 87.65483 , "None"));
Path.Add(new Vector3(2374.811 , 2182.442 , 88.26544 , "None"));
Path.Add(new Vector3(2362.812 , 2182.148 , 88.80962 , "None"));
Path.Add(new Vector3(2350.742 , 2181.849 , 89.35654 , "None"));
Path.Add(new Vector3(2340.675 , 2181.38 , 89.78278 , "None"));
Path.Add(new Vector3(2333.558 , 2182.091 , 90.09207 , "None"));
Path.Add(new Vector3(2330.771 , 2186.427 , 91.62992 , "None"));
Path.Add(new Vector3(2322.915 , 2185.373 , 91.25194 , "None"));
Path.Add(new Vector3(2313.627 , 2185.3 , 92.18002 , "None"));
Path.Add(new Vector3(2308.071 , 2186.569 , 92.62998 , "None"));
Path.Add(new Vector3(2304.502 , 2187.43 , 93.12675 , "None"));
Path.Add(new Vector3(2299.591 , 2189.041 , 93.95971 , "None"));
Path.Add(new Vector3(2295.45 , 2189.641 , 93.91389 , "None"));
Path.Add(new Vector3(2288.716 , 2188.523 , 92.48875 , "None"));
Path.Add(new Vector3(2280.958 , 2186.816 , 91.95107 , "None"));
Path.Add(new Vector3(2275.724 , 2189.158 , 91.30433 , "None"));
Path.Add(new Vector3(2272.758 , 2186.257 , 90.47204 , "None"));
Path.Add(new Vector3(2274.462 , 2181.581 , 90.5504 , "None"));
Path.Add(new Vector3(2277.541 , 2179.63 , 91.51572 , "None"));
Path.Add(new Vector3(2281.908 , 2180.467 , 92.31168 , "None"));
Path.Add(new Vector3(2285.296 , 2181.684 , 92.44968 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class ALingeringSuspicion : QuestGrinderClass
{
    public ALingeringSuspicion()
    {
        Name = "A Lingering Suspicion";

        QuestId.AddRange(new[] { 10314 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10316;

        EntryTarget.Add(20512);
EntryTarget.Add(21065);
HotSpots.Add(new Vector3(2531.059 , 2117.234 , 99.57959 , "None"));
HotSpots.Add(new Vector3(2528.969 , 2029.788 , 87.92022 , "None"));
HotSpots.Add(new Vector3(2497.893 , 2000.051 , 83.82332 , "None"));
HotSpots.Add(new Vector3(2512.09 , 2150.094 , 98.74476 , "None"));
HotSpots.Add(new Vector3(2415.854 , 2183.802 , 91.88899 , "None"));
HotSpots.Add(new Vector3(2476.819 , 2163.255 , 89.58918 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CapturingthePhylactery : QuestInteractWithClass
{
    public CapturingthePhylactery()
    {
        Name = "Capturing the Phylactery";

        QuestId.AddRange(new[] { 10319 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 10314;

        EntryIdTarget.Add(184310);
HotSpots.Add(new Vector3(2469.662 , 2147.62 , 94.09668 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "";
IgnoreIfDead = true;
Range = 7.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(29361) >= 1;
}






}


public sealed class RUNRuntoCaptureingPhylactery : QuestFollowPathClass
{
    public RUNRuntoCaptureingPhylactery()
    {
        Name = "RUN: Run to Captureing Phylactery";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2317.049 , 2274.248 , 100.4282 , "None"));
Path.Add(new Vector3(2320.584 , 2261.696 , 101.4197 , "None"));
Path.Add(new Vector3(2325.22 , 2232.799 , 103.0956 , "None"));
Path.Add(new Vector3(2326.252 , 2224.329 , 103.8119 , "None"));
Path.Add(new Vector3(2325.605 , 2216.305 , 103.8298 , "None"));
Path.Add(new Vector3(2322.792 , 2209.772 , 102.6067 , "None"));
Path.Add(new Vector3(2320.613 , 2206.416 , 100.9618 , "None"));
Path.Add(new Vector3(2317.213 , 2204.329 , 99.15036 , "None"));
Path.Add(new Vector3(2313.847 , 2201.724 , 97.54479 , "None"));
Path.Add(new Vector3(2312.609 , 2198.151 , 96.29469 , "None"));
Path.Add(new Vector3(2314.089 , 2194.4 , 95.09332 , "None"));
Path.Add(new Vector3(2315.886 , 2190.811 , 93.72231 , "None"));
Path.Add(new Vector3(2318.71 , 2187.977 , 92.58126 , "None"));
Path.Add(new Vector3(2322.885 , 2187.653 , 92.15031 , "None"));
Path.Add(new Vector3(2326.749 , 2186.761 , 91.9669 , "None"));
Path.Add(new Vector3(2330.48 , 2184.997 , 91.05193 , "None"));
Path.Add(new Vector3(2339.237 , 2183.868 , 90.19843 , "None"));
Path.Add(new Vector3(2351.74 , 2183.496 , 89.53834 , "None"));
Path.Add(new Vector3(2363.425 , 2183.18 , 88.92368 , "None"));
Path.Add(new Vector3(2376.019 , 2183.478 , 88.3511 , "None"));
Path.Add(new Vector3(2387.892 , 2184.355 , 87.89373 , "None"));
Path.Add(new Vector3(2399.878 , 2185.805 , 87.51107 , "None"));
Path.Add(new Vector3(2410.601 , 2189.763 , 92.0867 , "None"));
Path.Add(new Vector3(2415.367 , 2186.799 , 92.51399 , "None"));
Path.Add(new Vector3(2418.95 , 2189.411 , 94.81377 , "None"));
Path.Add(new Vector3(2418.188 , 2200.556 , 98.79527 , "None"));
Path.Add(new Vector3(2417.364 , 2212.603 , 103.2701 , "None"));
Path.Add(new Vector3(2421.805 , 2224.036 , 108.0836 , "None"));
Path.Add(new Vector3(2431.349 , 2231.158 , 110.4873 , "None"));
Path.Add(new Vector3(2443.175 , 2232.786 , 110.5247 , "None"));
Path.Add(new Vector3(2455.201 , 2233.963 , 110.8702 , "None"));
Path.Add(new Vector3(2465.313 , 2228.731 , 107.6462 , "None"));
Path.Add(new Vector3(2470.97 , 2222.423 , 103.6079 , "None"));
Path.Add(new Vector3(2477.635 , 2219.598 , 102.5929 , "None"));
Path.Add(new Vector3(2486.034 , 2211.159 , 101.9691 , "None"));
Path.Add(new Vector3(2486.348 , 2206.792 , 102.5512 , "None"));
Path.Add(new Vector3(2486.208 , 2199.544 , 103.2036 , "None"));
Path.Add(new Vector3(2484.159 , 2187.324 , 101.6946 , "None"));
Path.Add(new Vector3(2480.771 , 2184.251 , 99.01663 , "None"));
Path.Add(new Vector3(2480.678 , 2177.9 , 97.62443 , "None"));
Path.Add(new Vector3(2483.478 , 2166.205 , 95.51414 , "None"));
Path.Add(new Vector3(2483.134 , 2155.811 , 96.44786 , "None"));
Path.Add(new Vector3(2477.855 , 2145.409 , 95.04553 , "None"));
Path.Add(new Vector3(2472.754 , 2143.912 , 94.42702 , "None"));
Path.Add(new Vector3(2469.174 , 2144.63 , 94.04333 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class KILL6870NetherstormBubble1 : QuestGrinderClass
{
    public KILL6870NetherstormBubble1()
    {
        Name = "KILL: 68-70 - Netherstorm Bubble 1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(18879);
EntryTarget.Add(18880);
EntryTarget.Add(20671);
EntryTarget.Add(20611);
EntryTarget.Add(18883);
EntryTarget.Add(20773);
HotSpots.Add(new Vector3(3533.904 , 3234.479 , 99.80468 , "None"));
HotSpots.Add(new Vector3(3324.743 , 3107.311 , 124.1939 , "None"));
HotSpots.Add(new Vector3(3375.824 , 3080.051 , 134.211 , "None"));
HotSpots.Add(new Vector3(3547.611 , 3078.102 , 135.789 , "None"));
HotSpots.Add(new Vector3(3635.781 , 2988.687 , 137.679 , "None"));
HotSpots.Add(new Vector3(3592.409 , 2839.733 , 172.762 , "None"));
HotSpots.Add(new Vector3(3532.296 , 2775.941 , 150.6642 , "None"));
HotSpots.Add(new Vector3(3547.044 , 2672.258 , 148.8594 , "None"));
HotSpots.Add(new Vector3(3460.186 , 2824.344 , 145.728 , "None"));
HotSpots.Add(new Vector3(3383.696 , 2935.325 , 148.9766 , "None"));
HotSpots.Add(new Vector3(3498.044 , 2965.34 , 142.9896 , "None"));
HotSpots.Add(new Vector3(3470.295 , 3097.227 , 135.4917 , "None"));
HotSpots.Add(new Vector3(3590.175 , 2700.506 , 146.7873 , "None"));
HotSpots.Add(new Vector3(3719.871 , 2840.912 , 120.8494 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 70 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(40) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6870NetherstormBubble2 : QuestGrinderClass
{
    public KILL6870NetherstormBubble2()
    {
        Name = "KILL: 68-70 Netherstorm Bubble 2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(20774);
EntryTarget.Add(20610);
EntryTarget.Add(20777);
EntryTarget.Add(20983);
HotSpots.Add(new Vector3(3923.306 , 2945.717 , 119.0211 , "None"));
HotSpots.Add(new Vector3(3973.241 , 2835.095 , 117.8542 , "None"));
HotSpots.Add(new Vector3(4072.526 , 2816.629 , 135.7422 , "None"));
HotSpots.Add(new Vector3(4173.327 , 2833.115 , 140.6947 , "None"));
HotSpots.Add(new Vector3(4285.829 , 2887.63 , 115.4583 , "None"));
HotSpots.Add(new Vector3(4375.58 , 2836.746 , 113.3794 , "None"));
HotSpots.Add(new Vector3(4517.853 , 2862.115 , 144.2485 , "None"));
HotSpots.Add(new Vector3(4532.169 , 2903.316 , 142.9609 , "None"));
HotSpots.Add(new Vector3(4335.416 , 3056.004 , 132.7357 , "None"));
HotSpots.Add(new Vector3(4246.086 , 3170.95 , 176.9551 , "None"));
HotSpots.Add(new Vector3(4185.947 , 3195.897 , 177.2293 , "None"));
HotSpots.Add(new Vector3(4106.599 , 3365.097 , 152.2883 , "None"));
HotSpots.Add(new Vector3(4081.729 , 3299.078 , 155.2165 , "None"));
HotSpots.Add(new Vector3(4139.011 , 3188.599 , 192.4485 , "None"));
HotSpots.Add(new Vector3(3953.771 , 3212.13 , 130.9276 , "None"));
HotSpots.Add(new Vector3(3981.979 , 3003.373 , 135.6642 , "None"));
HotSpots.Add(new Vector3(3948.899 , 2951.812 , 126.925 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 70 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(40) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}


public sealed class KILL6870NetherstormBubble1nd2 : QuestGrinderClass
{
    public KILL6870NetherstormBubble1nd2()
    {
        Name = "KILL: 68-70 : Netherstorm Bubble 1 nd 2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 58;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(20671);
EntryTarget.Add(20611);
EntryTarget.Add(18879);
EntryTarget.Add(18883);
EntryTarget.Add(18884);
EntryTarget.Add(20673);
EntryTarget.Add(20773);
EntryTarget.Add(20774);
EntryTarget.Add(20610);
EntryTarget.Add(20777);
HotSpots.Add(new Vector3(3541.889 , 3063.339 , 138.605 , "None"));
HotSpots.Add(new Vector3(3535.683 , 3081.83 , 135.2984 , "None"));
HotSpots.Add(new Vector3(3709.114 , 2871.614 , 121.5 , "None"));
HotSpots.Add(new Vector3(3439.479 , 2568.413 , 142.5805 , "None"));
HotSpots.Add(new Vector3(3314.273 , 2453.446 , 78.60588 , "None"));
HotSpots.Add(new Vector3(3353.03 , 2339.904 , 88.66473 , "None"));
HotSpots.Add(new Vector3(3289.717 , 2169.321 , 121.2249 , "None"));
HotSpots.Add(new Vector3(3255.683 , 2063.875 , 125.3805 , "None"));
HotSpots.Add(new Vector3(3298.425 , 2003.272 , 112.2583 , "None"));
HotSpots.Add(new Vector3(3248.889 , 1963.885 , 132.8779 , "None"));
HotSpots.Add(new Vector3(3304.912 , 1819.454 , 121.566 , "None"));
HotSpots.Add(new Vector3(3212.486 , 1718.121 , 122.9881 , "None"));
HotSpots.Add(new Vector3(2952.929 , 1856.303 , 135.9724 , "None"));
HotSpots.Add(new Vector3(3111.373 , 1784.484 , 144.7404 , "None"));
HotSpots.Add(new Vector3(3282.424 , 2161.176 , 123.8906 , "None"));
HotSpots.Add(new Vector3(3219.184 , 2485.113 , 90.00164 , "None"));
HotSpots.Add(new Vector3(3414.931 , 3054.55 , 144.2665 , "None"));
HotSpots.Add(new Vector3(3549.308 , 2893.751 , 140.9294 , "None"));
HotSpots.Add(new Vector3(3428.675 , 3234.41 , 103.1978 , "None"));
HotSpots.Add(new Vector3(3511.222 , 3252.07 , 103.0936 , "None"));
HotSpots.Add(new Vector3(3536.926 , 3194.782 , 104.8958 , "None"));
HotSpots.Add(new Vector3(4002.534 , 3142.851 , 141.598 , "None"));
HotSpots.Add(new Vector3(3960.843 , 3267.719 , 125.9929 , "None"));
HotSpots.Add(new Vector3(4165.437 , 3189.515 , 181.7129 , "None"));
HotSpots.Add(new Vector3(4325.61 , 3041.777 , 131.9068 , "None"));
HotSpots.Add(new Vector3(4428.39 , 2911.87 , 132.8349 , "Flying"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 3;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 70 || robotManager.Helpful.Var.GetVar<System.DateTime>("randomGrindTimer").AddMinutes(40) < System.DateTime.Now;
}



public override bool HasQuest() { return true; }


}
