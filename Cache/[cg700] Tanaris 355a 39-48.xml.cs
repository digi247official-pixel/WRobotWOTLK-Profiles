
using System.Linq;
using robotManager.Helpful;
using wManager.Wow.Class;
using wManager.Wow.Enums;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;
using System.Collections.Generic;
using System.Threading;
using wManager.Wow.Bot.Tasks;


public class MyCustomScript
{
    static MyCustomScript()
    {
        // You can put here code to run when bot start, you can also add methods and classes.
    }
}



public sealed class DivinomaticRod : QuestGrinderClass
{
    public DivinomaticRod()
    {
        Name = "Divino matic Rod";

        QuestId.AddRange(new[] { 2768 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WastewanderJustice : QuestGrinderClass
{
    public WastewanderJustice()
    {
        Name = "Wastewander Justice";

        QuestId.AddRange(new[] { 1690 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5616);
EntryTarget.Add(5618);
HotSpots.Add(new Vector3(-7256.21 , -4543.549 , 9.175329 , "None"));
HotSpots.Add(new Vector3(-7220.598 , -4647.242 , 9.402942 , "None"));
HotSpots.Add(new Vector3(-7354.41 , -4608.633 , 8.882348 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ScarabShells : QuestGrinderClass
{
    public ScarabShells()
    {
        Name = "Scarab Shells";

        QuestId.AddRange(new[] { 2865 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TrollTemper : QuestGrinderClass
{
    public TrollTemper()
    {
        Name = "Troll Temper";

        QuestId.AddRange(new[] { 3042 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WaterPouchBounty : QuestGrinderClass
{
    public WaterPouchBounty()
    {
        Name = "Water Pouch Bounty";

        QuestId.AddRange(new[] { 1707 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5618);
HotSpots.Add(new Vector3(-7250.005 , -4564.663 , 9.395923 , "None"));
HotSpots.Add(new Vector3(-7246.898 , -4618.13 , 8.631964 , "None"));
HotSpots.Add(new Vector3(-7372.084 , -4709.103 , 12.18501 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GadgetzanWaterSurvey : QuestClass
{
    public GadgetzanWaterSurvey()
    {
        Name = "Gadgetzan Water Survey";

        QuestId.AddRange(new[] { 992 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 39;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheSuperEggOMatic : QuestGrinderClass
{
    public TheSuperEggOMatic()
    {
        Name = "The Super Egg-O-Matic";

        QuestId.AddRange(new[] { 2741 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WANTEDAndreFirebeard : QuestGrinderClass
{
    public WANTEDAndreFirebeard()
    {
        Name = "WANTED Andre Firebeard";

        QuestId.AddRange(new[] { 2875 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(7883);
HotSpots.Add(new Vector3(-7978.589 , -5358.004 , 0.561245 , "None"));
HotSpots.Add(new Vector3(-8053.729 , -5278.582 , 0.580693 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WANTEDCaliphScorpidsting : QuestGrinderClass
{
    public WANTEDCaliphScorpidsting()
    {
        Name = "WANTED Caliph Scorpidsting";

        QuestId.AddRange(new[] { 2781 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(7847);
HotSpots.Add(new Vector3(-7770.9 , -4318.319 , 10.54805 , "None"));
HotSpots.Add(new Vector3(-7410.188 , -4545.746 , 11.00268 , "None"));
HotSpots.Add(new Vector3(-7426.567 , -4783.335 , 9.164981 , "None"));
HotSpots.Add(new Vector3(-7728.111 , -4542.324 , 9.455441 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class NoxiousLairInvestigation : QuestGrinderClass
{
    public NoxiousLairInvestigation()
    {
        Name = "Noxious Lair Investigation";

        QuestId.AddRange(new[] { 82 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 39;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5455);
EntryTarget.Add(5458);
HotSpots.Add(new Vector3(-7708.104 , -2755.474 , 8.795823 , "None"));
HotSpots.Add(new Vector3(-7681.096 , -2712.204 , 9.564355 , "None"));
HotSpots.Add(new Vector3(-7647.659 , -2758.195 , 9.750969 , "None"));
HotSpots.Add(new Vector3(-7816.154 , -2679.409 , 9.146482 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MoreWastewanderJustice : QuestGrinderClass
{
    public MoreWastewanderJustice()
    {
        Name = "More Wastewander Justice";

        QuestId.AddRange(new[] { 1691 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5617);
EntryTarget.Add(5623);
EntryTarget.Add(5615);
EntryTarget.Add(7847);
HotSpots.Add(new Vector3(-7384.182 , -4385.336 , 11.00708 , "None"));
HotSpots.Add(new Vector3(-7490.949 , -4499.299 , 9.11281 , "None"));
HotSpots.Add(new Vector3(-7683.463 , -4419.698 , 10.20887 , "None"));
HotSpots.Add(new Vector3(-7551.652 , -4287.318 , 9.633687 , "None"));
HotSpots.Add(new Vector3(-7686.543 , -4250.783 , 9.284355 , "None"));
HotSpots.Add(new Vector3(-7597.428 , -4260.281 , 10.6246 , "None"));
HotSpots.Add(new Vector3(-7713.64 , -4619.74 , 8.878536 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CarnivalJerkins : QuestGrinderClass
{
    public CarnivalJerkins()
    {
        Name = "Carnival Jerkins";

        QuestId.AddRange(new[] { 8366 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(7855);
EntryTarget.Add(7856);
EntryTarget.Add(7858);
EntryTarget.Add(7857);
HotSpots.Add(new Vector3(-7857.297 , -5089.942 , 5.876472 , "None"));
HotSpots.Add(new Vector3(-7875.683 , -5133.113 , 5.883028 , "None"));
HotSpots.Add(new Vector3(-7960.208 , -5241.001 , 1.664316 , "None"));
HotSpots.Add(new Vector3(-7976.5 , -5371.73 , 0.5657369 , "None"));
HotSpots.Add(new Vector3(-8059.029 , -5383.065 , 11.85492 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PirateHatsAhoy : QuestGrinderClass
{
    public PirateHatsAhoy()
    {
        Name = "Pirate Hats Ahoy!";

        QuestId.AddRange(new[] { 8365 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(7855);
EntryTarget.Add(7856);
EntryTarget.Add(7858);
EntryTarget.Add(7857);
HotSpots.Add(new Vector3(-7857.148 , -5089.421 , 5.808146 , "None"));
HotSpots.Add(new Vector3(-7875.683 , -5133.113 , 5.883028 , "None"));
HotSpots.Add(new Vector3(-7960.208 , -5241.001 , 1.664316 , "None"));
HotSpots.Add(new Vector3(-7976.5 , -5371.73 , 0.5657369 , "None"));
HotSpots.Add(new Vector3(-8055.468 , -5379.642 , 11.85294 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThistleshrubValley : QuestGrinderClass
{
    public ThistleshrubValley()
    {
        Name = "Thistleshrub Valley";

        QuestId.AddRange(new[] { 3362 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 45;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5490);
EntryTarget.Add(5485);
HotSpots.Add(new Vector3(-8926.7 , -2270.624 , 8.876987 , "None"));
HotSpots.Add(new Vector3(-8990.204 , -2301.459 , 21.75289 , "None"));
HotSpots.Add(new Vector3(-8882.041 , -2182.623 , 9.353007 , "None"));
HotSpots.Add(new Vector3(-8767.573 , -2199.685 , 9.922082 , "None"));
HotSpots.Add(new Vector3(-8919.925 , -2344.338 , 10.50685 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheThirstyGoblin : QuestGrinderClass
{
    public TheThirstyGoblin()
    {
        Name = "The Thirsty Goblin";

        QuestId.AddRange(new[] { 2605 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 44;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5481);
HotSpots.Add(new Vector3(-8968.335 , -2341.119 , 11.6171 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheDunemaulCompound : QuestGrinderClass
{
    public TheDunemaulCompound()
    {
        Name = "The Dunemaul Compound";

        QuestId.AddRange(new[] { 5863 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 44;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5474);
EntryTarget.Add(5472);
EntryTarget.Add(12046);
HotSpots.Add(new Vector3(-8469.692 , -3032.081 , 9.068373 , "None"));
HotSpots.Add(new Vector3(-8395.744 , -3179.337 , 8.762474 , "None"));
HotSpots.Add(new Vector3(-8544.261 , -2970.042 , 9.305984 , "None"));
HotSpots.Add(new Vector3(-8534.26 , -3082.25 , 8.700504 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class InGoodTaste : QuestClass
{
    public InGoodTaste()
    {
        Name = "In Good Taste";

        QuestId.AddRange(new[] { 2606 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 44;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheScrimshankRedemption : QuestGathererClass
{
    public TheScrimshankRedemption()
    {
        Name = "The Scrimshank Redemption";

        QuestId.AddRange(new[] { 10 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(144053);
HotSpots.Add(new Vector3(-9174.043 , -4123.688 , -41.82735 , "None"));
HotSpots.Add(new Vector3(-9155.853 , -4092.031 , -45.60398 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class InsectPartAnalysis : QuestClass
{
    public InsectPartAnalysis()
    {
        Name = "Insect Part Analysis";

        QuestId.AddRange(new[] { 110 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class InsectPartAnalysisPart2 : QuestClass
{
    public InsectPartAnalysisPart2()
    {
        Name = "Insect Part AnalysisPart2";

        QuestId.AddRange(new[] { 113 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SuperSticky : QuestGrinderClass
{
    public SuperSticky()
    {
        Name = "Super Sticky";

        QuestId.AddRange(new[] { 4504 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 48;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(6517);
EntryTarget.Add(6527);
EntryTarget.Add(6518);
HotSpots.Add(new Vector3(-6779.767 , -1685.342 , -273.3085 , "None"));
HotSpots.Add(new Vector3(-6689.875 , -1643.443 , -272.2683 , "None"));
HotSpots.Add(new Vector3(-6555.443 , -1484.443 , -274.3472 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RiseoftheSilithid : QuestClass
{
    public RiseoftheSilithid()
    {
        Name = "Rise of the Silithid";

        QuestId.AddRange(new[] { 32 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SouthSeaShakedown : QuestGrinderClass
{
    public SouthSeaShakedown()
    {
        Name = "South Sea Shakedown";

        QuestId.AddRange(new[] { 8366 });

        Step = new List<int> { 10, 10, 10, 10, 0 };

        StepAutoDetect = new[] { true, true, true, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(7857);
EntryTarget.Add(7856);
EntryTarget.Add(7858);
EntryTarget.Add(7855);
HotSpots.Add(new Vector3(-8079.21 , -5287.67 , 0.5748501 , "None"));
HotSpots.Add(new Vector3(-8047.374 , -5302.905 , 0.5750353 , "None"));
HotSpots.Add(new Vector3(-7996.3 , -5390.23 , 1.121439 , "None"));
HotSpots.Add(new Vector3(-8047.83 , -5346.45 , 18.22206 , "None"));
HotSpots.Add(new Vector3(-8044 , -5336.31 , 8.206648 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}
