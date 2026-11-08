
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



public sealed class AStrangeDevice : QuestClass
{
    public AStrangeDevice()
    {
        Name = "A Strange Device";

        QuestId.AddRange(new[] { 12055 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 36742;

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


public sealed class Amulet : QuestGrinderClass
{
    public Amulet()
    {
        Name = "Amulet";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26815);
HotSpots.Add(new Vector3(2880.594 , 1865.068 , 131.0484 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(36779) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class AtoptheWoodlands : QuestUseItemOnClass
{
    public AtoptheWoodlands()
    {
        Name = "Atop the Woodlands";

        QuestId.AddRange(new[] { 12083 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(2901.278 , 1818.459 , 131.0944 , "None"));
ItemId = 36779;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Bark : QuestInteractWithClass
{
    public Bark()
    {
        Name = "Bark";

        QuestId.AddRange(new[] { 12092 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26421);
HotSpots.Add(new Vector3(3227.172 , 1977.39 , 134.5505 , "None"));
HotSpots.Add(new Vector3(3113.151 , 1925.829 , 127.0134 , "None"));
HotSpots.Add(new Vector3(3037.182 , 1953.753 , 127.073 , "None"));
HotSpots.Add(new Vector3(3044.106 , 1882.633 , 128.7594 , "None"));
HotSpots.Add(new Vector3(2952.979 , 1885.378 , 127.1471 , "None"));
HotSpots.Add(new Vector3(2920.48 , 1961.751 , 137.7852 , "None"));
HotSpots.Add(new Vector3(2964.746 , 1753.132 , 139.0722 , "None"));
HotSpots.Add(new Vector3(2848.956 , 1648.726 , 153.6146 , "None"));
HotSpots.Add(new Vector3(2880.433 , 1581.274 , 156.9417 , "None"));
HotSpots.Add(new Vector3(3012.546 , 1638.388 , 159.679 , "None"));
HotSpots.Add(new Vector3(3226.438 , 1737.816 , 135.3352 , "None"));
HotSpots.Add(new Vector3(3234.373 , 1841.542 , 135.2876 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "";
IgnoreIfDead = false;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(36786) >= 3;
}



public override bool HasQuest() { return true; }


}


public sealed class Blood : QuestGrinderClass
{
    public Blood()
    {
        Name = "Blood";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26196);
HotSpots.Add(new Vector3(3355.026 , 1026.139 , 142.88 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(35688) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class Call : QuestGathererClass
{
    public Call()
    {
        Name = "Call";

        QuestId.AddRange(new[] { 12032 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188422);
HotSpots.Add(new Vector3(2455.219 , 1719.839 , 59.94918 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ObjectManager.GetNearestWoWUnit(ObjectManager.GetWoWUnitByEntry(26648)).IsAlive && ObjectManager.GetNearestWoWUnit(ObjectManager.GetWoWUnitByEntry(26648)).GetDistance < 150;
}



public override bool HasQuest() { return true; }


}


public sealed class ConversingWiththeDepths : QuestUseItemOnClass
{
    public ConversingWiththeDepths()
    {
        Name = "Conversing With the Depths";

        QuestId.AddRange(new[] { 12032 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        ItemId = 0;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ElderManaloa : QuestClass
{
    public ElderManaloa()
    {
        Name = "Elder Mana'loa";

        QuestId.AddRange(new[] { 12030 });

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


public sealed class FreedomfortheLingering : QuestGrinderClass
{
    public FreedomfortheLingering()
    {
        Name = "Freedom for the Lingering";

        QuestId.AddRange(new[] { 12031 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26344);
EntryTarget.Add(26343);
HotSpots.Add(new Vector3(3156 , 1559.71 , 162.4064 , "None"));
HotSpots.Add(new Vector3(3144.535 , 1557.658 , 163.3198 , "None"));
HotSpots.Add(new Vector3(3118.9 , 1582.3 , 163.5228 , "None"));
HotSpots.Add(new Vector3(3180.59 , 1463.69 , 151.773 , "None"));
HotSpots.Add(new Vector3(3189.88 , 1315.27 , 158.4857 , "None"));
HotSpots.Add(new Vector3(3185.16 , 1284.473 , 158.4438 , "None"));
HotSpots.Add(new Vector3(3126.4 , 1339.83 , 159.5466 , "None"));
HotSpots.Add(new Vector3(3103.332 , 1232.063 , 156.7634 , "None"));
HotSpots.Add(new Vector3(2982.76 , 1302.55 , 150.0675 , "None"));
HotSpots.Add(new Vector3(2918.341 , 1521.921 , 156.8424 , "None"));
HotSpots.Add(new Vector3(3022.34 , 1525.82 , 149.2742 , "None"));
HotSpots.Add(new Vector3(3118.9 , 1582.3 , 163.5228 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GaininganAudience : QuestClass
{
    public GaininganAudience()
    {
        Name = "Gaining an Audience";

        QuestId.AddRange(new[] { 12119 });

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


public sealed class Jump : QuestFollowPathClass
{
    public Jump()
    {
        Name = "Jump";

        QuestId.AddRange(new[] { 12032 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2455.108 , 1719.923 , 59.95078 , "None"));
Path.Add(new Vector3(2450.07 , 1716.991 , 58.41357 , "None"));
Path.Add(new Vector3(2446.998 , 1715.315 , 52.29829 , "None"));
Path.Add(new Vector3(2443.925 , 1713.638 , 41.36024 , "None"));
Path.Add(new Vector3(2440.853 , 1711.962 , 25.5994 , "None"));
Path.Add(new Vector3(2437.781 , 1710.286 , 5.015792 , "None"));
Path.Add(new Vector3(2436.336 , 1709.497 , -1.468742 , "Swimming"));
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


public sealed class LetNothingGoToWaste : QuestGrinderClass
{
    public LetNothingGoToWaste()
    {
        Name = "Let Nothing Go To Waste";

        QuestId.AddRange(new[] { 11958 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26198);
EntryTarget.Add(26199);
EntryTarget.Add(26197);
HotSpots.Add(new Vector3(2976.541 , 1016.416 , 102.8737 , "None"));
HotSpots.Add(new Vector3(3010.597 , 1042.149 , 105.6936 , "None"));
HotSpots.Add(new Vector3(3091.51 , 1065.994 , 118.1 , "None"));
HotSpots.Add(new Vector3(3059.475 , 1123.632 , 124.9289 , "None"));
HotSpots.Add(new Vector3(3254.089 , 1095.929 , 132.0569 , "None"));
HotSpots.Add(new Vector3(3289.52 , 1125.36 , 136.4303 , "None"));
HotSpots.Add(new Vector3(3323.881 , 1186.976 , 138.9872 , "None"));
HotSpots.Add(new Vector3(3346.057 , 1216.713 , 139.0364 , "None"));
HotSpots.Add(new Vector3(3355.254 , 1097.042 , 139.1623 , "None"));
HotSpots.Add(new Vector3(3358.751 , 1081.277 , 141.1025 , "None"));
HotSpots.Add(new Vector3(3295.739 , 1054.157 , 136.3096 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MeatontheHook : QuestUseItemOnClass
{
    public MeatontheHook()
    {
        Name = "Meat on the Hook";

        QuestId.AddRange(new[] { 12017 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(2650.555 , 1006.676 , -24.03772 , "Swimming"));
HotSpots.Add(new Vector3(2640.727 , 1017.431 , -22.49541 , "Swimming"));
ItemId = 35838;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PickUP : QuestInteractWithClass
{
    public PickUP()
    {
        Name = "Pick UP";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26477);
HotSpots.Add(new Vector3(3329.318 , 2297.353 , 34.37101 , "None"));
HotSpots.Add(new Vector3(3289.8 , 2315.15 , 29.98415 , "None"));
HotSpots.Add(new Vector3(3286.67 , 2266.59 , 30.00132 , "None"));
HotSpots.Add(new Vector3(3273.81 , 2236.8 , 37.47058 , "None"));
HotSpots.Add(new Vector3(3388.77 , 2204.16 , 37.24191 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "";
IgnoreIfDead = true;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(35792) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class PlanningfortheFuture : QuestInteractWithClass
{
    public PlanningfortheFuture()
    {
        Name = "Planning for the Future";

        QuestId.AddRange(new[] { 11960 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26200);
HotSpots.Add(new Vector3(3012.232 , 1170.385 , 136.9475 , "None"));
HotSpots.Add(new Vector3(2902.318 , 1124.658 , 123.4958 , "None"));
HotSpots.Add(new Vector3(2897.507 , 1125.873 , 123.863 , "None"));
HotSpots.Add(new Vector3(2896.568 , 1123.723 , 123.7951 , "None"));
HotSpots.Add(new Vector3(2880.29 , 1194.746 , 141.2924 , "None"));
HotSpots.Add(new Vector3(2881.211 , 1198.696 , 140.3818 , "None"));
HotSpots.Add(new Vector3(2878.859 , 1204.085 , 139.3626 , "None"));
HotSpots.Add(new Vector3(2895.165 , 1234.312 , 143.8067 , "None"));
HotSpots.Add(new Vector3(2894.015 , 1237.333 , 144.719 , "None"));
HotSpots.Add(new Vector3(3014.963 , 1169.945 , 136.8658 , "None"));
HotSpots.Add(new Vector3(3011.148 , 1169.305 , 136.9464 , "None"));
HotSpots.Add(new Vector3(3014.814 , 1167.999 , 136.8145 , "None"));
HotSpots.Add(new Vector3(3373.132 , 1044.741 , 141.4464 , "None"));
HotSpots.Add(new Vector3(3373.34 , 1041.5 , 141.542 , "None"));
HotSpots.Add(new Vector3(3371.22 , 1042.69 , 141.3317 , "None"));
HotSpots.Add(new Vector3(3280.713 , 1075.32 , 134.2819 , "None"));
HotSpots.Add(new Vector3(3286.709 , 1075.699 , 134.7771 , "None"));
HotSpots.Add(new Vector3(3271.197 , 993.4784 , 133.0773 , "None"));
HotSpots.Add(new Vector3(3279.848 , 1096.817 , 133.7986 , "None"));
HotSpots.Add(new Vector3(3370.994 , 1193.777 , 139.6837 , "None"));
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


public sealed class PreventtheAccord : QuestGrinderClass
{
    public PreventtheAccord()
    {
        Name = "Prevent the Accord";

        QuestId.AddRange(new[] { 12004 });

        Step = new List<int> { 1, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26349);
EntryTarget.Add(26496);
HotSpots.Add(new Vector3(3401.72 , 2532.42 , 59.40012 , "None"));
HotSpots.Add(new Vector3(3373.428 , 2597.067 , 39.73312 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ProjectionsandPlans : QuestUseItemOnClass
{
    public ProjectionsandPlans()
    {
        Name = "Projections and Plans";

        QuestId.AddRange(new[] { 12060 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3318.738 , 2436.941 , 38.07557 , "None"));
ItemId = 36747;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RifletheBodies : QuestUseItemOnClass
{
    public RifletheBodies()
    {
        Name = "Rifle the Bodies";

        QuestId.AddRange(new[] { 12000 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3330.682 , 2274.433 , 33.50723 , "None"));
ItemId = 35792;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Ring : QuestGrinderClass
{
    public Ring()
    {
        Name = "Ring";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26762);
HotSpots.Add(new Vector3(3150.61 , 2155.077 , 23.64094 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(36751) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class SearchInduleVillage : QuestClass
{
    public SearchInduleVillage()
    {
        Name = "Search Indu'le Village";

        QuestId.AddRange(new[] { 12098 });

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


public sealed class SignsofBigWateryTrouble : QuestClass
{
    public SignsofBigWateryTrouble()
    {
        Name = "Signs of Big Watery Trouble";

        QuestId.AddRange(new[] { 12011 });

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


public sealed class SlayLoguhn : QuestUseItemOnClass
{
    public SlayLoguhn()
    {
        Name = "Slay Loguhn";

        QuestId.AddRange(new[] { 11959 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(2774.107 , 931.6827 , 22.53788 , "None"));
ItemId = 35688;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SpeakwithyourAmbassador : QuestClass
{
    public SpeakwithyourAmbassador()
    {
        Name = "Speak with your Ambassador";

        QuestId.AddRange(new[] { 12766 });

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


public sealed class SpiritualInsight : QuestUseItemOnClass
{
    public SpiritualInsight()
    {
        Name = "Spiritual Insight";

        QuestId.AddRange(new[] { 12028 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(2739.673 , 882.84 , 6.609715 , "None"));
ItemId = 35907;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Stone : QuestFollowPathClass
{
    public Stone()
    {
        Name = "Stone";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(3159.963 , 1600.954 , 162.3762 , "None"));
Path.Add(new Vector3(3156.79 , 1596.817 , 162.9198 , "None"));
Path.Add(new Vector3(3155.197 , 1592.974 , 163.2752 , "None"));
Path.Add(new Vector3(3154.98 , 1589.216 , 163.4301 , "None"));
Path.Add(new Vector3(3153.593 , 1585.438 , 163.4893 , "None"));
Path.Add(new Vector3(3152.708 , 1581.767 , 163.4798 , "None"));
Path.Add(new Vector3(3152.154 , 1580.174 , 163.4667 , "None"));
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


public sealed class StrengthentheAncients : QuestUseItemOnClass
{
    public StrengthentheAncients()
    {
        Name = "Strengthen the Ancients";

        QuestId.AddRange(new[] { 12092 });

        Step = new List<int> { 3, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26321);
HotSpots.Add(new Vector3(3019.185 , 1849.651 , 129.5896 , "None"));
HotSpots.Add(new Vector3(2897.75 , 1921.42 , 132.6811 , "None"));
HotSpots.Add(new Vector3(2824.71 , 1750.11 , 151.6983 , "None"));
HotSpots.Add(new Vector3(2919.1 , 1686.02 , 142.0047 , "None"));
HotSpots.Add(new Vector3(3137.95 , 1819.67 , 128.0773 , "None"));
HotSpots.Add(new Vector3(3197.59 , 1911 , 128.646 , "None"));
ItemId = 36786;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Swim : QuestFollowPathClass
{
    public Swim()
    {
        Name = "Swim";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2724.796 , 933.6248 , 0.1779517 , "None"));
Path.Add(new Vector3(2724.398 , 940.9677 , 0.1328253 , "None"));
Path.Add(new Vector3(2724.578 , 944.9887 , 0.2936105 , "None"));
Path.Add(new Vector3(2724.385 , 948.9977 , 0.1212988 , "None"));
Path.Add(new Vector3(2723.64 , 952.9534 , 0.02947321 , "None"));
Path.Add(new Vector3(2721.988 , 956.6205 , -0.1148983 , "None"));
Path.Add(new Vector3(2719.679 , 959.9126 , -0.2759832 , "None"));
Path.Add(new Vector3(2716.971 , 962.8766 , -0.4161571 , "None"));
Path.Add(new Vector3(2714.115 , 965.9144 , -0.6763733 , "None"));
Path.Add(new Vector3(2710.879 , 970.0764 , -1.47766 , "Swimming"));
Path.Add(new Vector3(2695.584 , 989.8518 , -1.47766 , "Swimming"));
Path.Add(new Vector3(2680.274 , 1009.615 , -1.47766 , "Swimming"));
Path.Add(new Vector3(2663.998 , 1028.59 , -1.47766 , "Swimming"));
Path.Add(new Vector3(2647.083 , 1048.138 , -1.47766 , "Swimming"));
Path.Add(new Vector3(2631.281 , 1066.4 , -1.47766 , "Swimming"));
Path.Add(new Vector3(2614.861 , 1085.251 , -1.47766 , "Swimming"));
Path.Add(new Vector3(2598.259 , 1103.943 , -1.47766 , "Swimming"));
Path.Add(new Vector3(2580.285 , 1122.518 , -1.47766 , "Swimming"));
Path.Add(new Vector3(2562.881 , 1140.464 , -1.47766 , "Swimming"));
Path.Add(new Vector3(2546.231 , 1157.957 , -1.47766 , "Swimming"));
Path.Add(new Vector3(2527.156 , 1174.095 , -1.148615 , "None"));
Path.Add(new Vector3(2521.806 , 1176.859 , 0.6894907 , "None"));
Path.Add(new Vector3(2518.612 , 1178.276 , 1.531774 , "None"));
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


public sealed class SwimB : QuestFollowPathClass
{
    public SwimB()
    {
        Name = "Swim B";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2513.739 , 1176.86 , 2.62678 , "None"));
Path.Add(new Vector3(2517.472 , 1174.447 , 1.610649 , "None"));
Path.Add(new Vector3(2519.8 , 1171.176 , 0.8137847 , "None"));
Path.Add(new Vector3(2522.323 , 1166.294 , -0.53958 , "None"));
Path.Add(new Vector3(2527.192 , 1157.605 , -3.744337 , "Swimming"));
Path.Add(new Vector3(2542.433 , 1137.129 , -1.862055 , "Swimming"));
Path.Add(new Vector3(2559.561 , 1118.925 , -1.637011 , "Swimming"));
Path.Add(new Vector3(2576.749 , 1100.771 , -1.637011 , "Swimming"));
Path.Add(new Vector3(2593.937 , 1082.617 , -1.637011 , "Swimming"));
Path.Add(new Vector3(2611.125 , 1064.463 , -1.637011 , "Swimming"));
Path.Add(new Vector3(2628.313 , 1046.309 , -1.637011 , "Swimming"));
Path.Add(new Vector3(2645.501 , 1028.155 , -1.637011 , "Swimming"));
Path.Add(new Vector3(2662.689 , 1010.001 , -1.637011 , "Swimming"));
Path.Add(new Vector3(2679.877 , 991.8467 , -1.637011 , "Swimming"));
Path.Add(new Vector3(2697.065 , 973.6927 , -1.637011 , "Swimming"));
Path.Add(new Vector3(2707.24 , 962.9531 , -0.6041374 , "None"));
Path.Add(new Vector3(2710.443 , 958.0024 , -0.07334004 , "None"));
Path.Add(new Vector3(2712.413 , 954.4926 , 0.06831509 , "None"));
Path.Add(new Vector3(2714.367 , 950.9734 , 0.08409101 , "None"));
Path.Add(new Vector3(2716.32 , 947.4543 , 0.1533998 , "None"));
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


public sealed class TheBait : QuestGrinderClass
{
    public TheBait()
    {
        Name = "The Bait";

        QuestId.AddRange(new[] { 12016 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26521);
HotSpots.Add(new Vector3(2508.208 , 1173.217 , 3.154628 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheEndoftheLine : QuestUseItemOnClass
{
    public TheEndoftheLine()
    {
        Name = "The End of the Line";

        QuestId.AddRange(new[] { 12107 });

        Step = new List<int> { 1, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3063.143 , 1401.051 , 123.9759 , "Swimming"));
HotSpots.Add(new Vector3(3107.427 , 672.752 , 80.17345 , "None"));
ItemId = 36815;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheFocusontheBeach : QuestUseItemOnClass
{
    public TheFocusontheBeach()
    {
        Name = "The Focus on the Beach";

        QuestId.AddRange(new[] { 12065 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3134.34 , 2139.55 , 24.28954 , "None"));
ItemId = 36751;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThePearl : QuestFollowPathClass
{
    public ThePearl()
    {
        Name = "The Pearl";

        QuestId.AddRange(new[] { 12032 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(3139.777 , 1591.606 , 163.522 , "None"));
Path.Add(new Vector3(3143.048 , 1595.281 , 163.4951 , "None"));
Path.Add(new Vector3(3140.889 , 1600.013 , 163.4151 , "None"));
Path.Add(new Vector3(3140.152 , 1603.488 , 163.3121 , "None"));
Path.Add(new Vector3(3139.389 , 1608.148 , 163.1796 , "None"));
Path.Add(new Vector3(3138.803 , 1611.726 , 162.9884 , "None"));
Path.Add(new Vector3(3138.238 , 1615.173 , 162.7323 , "None"));
Path.Add(new Vector3(3137.672 , 1618.627 , 162.448 , "None"));
Path.Add(new Vector3(3137.107 , 1622.081 , 162.1036 , "None"));
Path.Add(new Vector3(3136.541 , 1625.535 , 161.6211 , "None"));
Path.Add(new Vector3(3135.975 , 1628.989 , 161.0106 , "None"));
Path.Add(new Vector3(3135.41 , 1632.443 , 160.2628 , "None"));
Path.Add(new Vector3(3134.844 , 1635.897 , 159.311 , "None"));
Path.Add(new Vector3(3133.894 , 1639.237 , 158.3551 , "None"));
Path.Add(new Vector3(3132.409 , 1642.407 , 157.7137 , "None"));
Path.Add(new Vector3(3130.925 , 1645.576 , 157.2365 , "None"));
Path.Add(new Vector3(3129.44 , 1648.746 , 156.4212 , "None"));
Path.Add(new Vector3(3127.905 , 1652.023 , 155.5126 , "None"));
Path.Add(new Vector3(3125.925 , 1658.269 , 154.2289 , "None"));
Path.Add(new Vector3(3124.344 , 1661.391 , 153.765 , "None"));
Path.Add(new Vector3(3122.414 , 1664.265 , 152.704 , "None"));
Path.Add(new Vector3(3119.774 , 1666.73 , 151.7153 , "None"));
Path.Add(new Vector3(3117.072 , 1668.924 , 150.9677 , "None"));
Path.Add(new Vector3(3111.263 , 1670.232 , 149.7083 , "None"));
Path.Add(new Vector3(3102.595 , 1670.231 , 148.726 , "None"));
Path.Add(new Vector3(3094.201 , 1670.565 , 148.0489 , "None"));
Path.Add(new Vector3(3085.809 , 1670.93 , 147.645 , "None"));
Path.Add(new Vector3(3077.417 , 1671.295 , 147.5144 , "None"));
Path.Add(new Vector3(3069.025 , 1671.659 , 147.6301 , "None"));
Path.Add(new Vector3(3060.902 , 1672.012 , 148.4163 , "None"));
Path.Add(new Vector3(3052.51 , 1672.377 , 150.3402 , "None"));
Path.Add(new Vector3(3043.947 , 1671.991 , 152.8432 , "None"));
Path.Add(new Vector3(3036.056 , 1669.11 , 152.8934 , "None"));
Path.Add(new Vector3(3028.165 , 1666.229 , 152.998 , "None"));
Path.Add(new Vector3(3020.527 , 1663.441 , 154.1221 , "None"));
Path.Add(new Vector3(3012.384 , 1660.468 , 155.0293 , "None"));
Path.Add(new Vector3(3004.746 , 1657.679 , 155.2568 , "None"));
Path.Add(new Vector3(2996.856 , 1654.798 , 155.0751 , "None"));
Path.Add(new Vector3(2988.965 , 1651.918 , 154.7494 , "None"));
Path.Add(new Vector3(2981.074 , 1649.037 , 154.6346 , "None"));
Path.Add(new Vector3(2973.184 , 1646.156 , 154.1488 , "None"));
Path.Add(new Vector3(2965.293 , 1643.275 , 153.5305 , "None"));
Path.Add(new Vector3(2957.403 , 1640.394 , 153.0045 , "None"));
Path.Add(new Vector3(2949.244 , 1637.416 , 152.0402 , "None"));
Path.Add(new Vector3(2941.761 , 1634.481 , 151.0979 , "None"));
Path.Add(new Vector3(2937.603 , 1626.885 , 150.125 , "None"));
Path.Add(new Vector3(2931.197 , 1622.822 , 149.3135 , "None"));
Path.Add(new Vector3(2924.865 , 1618.034 , 149.3668 , "None"));
Path.Add(new Vector3(2917.96 , 1613.257 , 149.7529 , "None"));
Path.Add(new Vector3(2912.778 , 1606.693 , 150.5742 , "None"));
Path.Add(new Vector3(2908.333 , 1599.292 , 151.507 , "None"));
Path.Add(new Vector3(2902.126 , 1594.219 , 152.8324 , "None"));
Path.Add(new Vector3(2894.759 , 1589.619 , 154.2466 , "None"));
Path.Add(new Vector3(2888.143 , 1584.489 , 155.4495 , "None"));
Path.Add(new Vector3(2882.562 , 1578.576 , 156.6652 , "None"));
Path.Add(new Vector3(2876.815 , 1572.449 , 157.6494 , "None"));
Path.Add(new Vector3(2871.08 , 1566.335 , 158.7299 , "None"));
Path.Add(new Vector3(2865.213 , 1560.288 , 159.9032 , "None"));
Path.Add(new Vector3(2857.764 , 1556.487 , 160.4358 , "None"));
Path.Add(new Vector3(2849.988 , 1552.619 , 160.7514 , "None"));
Path.Add(new Vector3(2842.722 , 1549.005 , 159.9416 , "None"));
Path.Add(new Vector3(2835.186 , 1545.256 , 159.1786 , "None"));
Path.Add(new Vector3(2827.672 , 1541.519 , 159.4636 , "None"));
Path.Add(new Vector3(2820.166 , 1537.785 , 159.6619 , "None"));
Path.Add(new Vector3(2812.987 , 1535.037 , 159.1419 , "None"));
Path.Add(new Vector3(2809.516 , 1534.6 , 158.791 , "None"));
Path.Add(new Vector3(2805.982 , 1534.174 , 158.3907 , "None"));
Path.Add(new Vector3(2800.822 , 1533.552 , 157.7373 , "None"));
Path.Add(new Vector3(2795.509 , 1532.912 , 157.0398 , "None"));
Path.Add(new Vector3(2792.027 , 1532.493 , 156.6151 , "None"));
Path.Add(new Vector3(2788.552 , 1532.074 , 156.1596 , "None"));
Path.Add(new Vector3(2781.609 , 1531.237 , 154.8136 , "None"));
Path.Add(new Vector3(2774.771 , 1530.413 , 153.064 , "None"));
Path.Add(new Vector3(2771.178 , 1529.98 , 152.2487 , "None"));
Path.Add(new Vector3(2764.346 , 1529.157 , 151.4826 , "None"));
Path.Add(new Vector3(2760.865 , 1528.737 , 151.3911 , "None"));
Path.Add(new Vector3(2753.922 , 1527.9 , 151.3734 , "None"));
Path.Add(new Vector3(2750.447 , 1527.482 , 151.3492 , "None"));
Path.Add(new Vector3(2746.854 , 1527.049 , 151.301 , "None"));
Path.Add(new Vector3(2739.907 , 1526.191 , 151.0211 , "None"));
Path.Add(new Vector3(2736.917 , 1524.405 , 150.4904 , "None"));
Path.Add(new Vector3(2731.644 , 1519.911 , 148.2346 , "None"));
Path.Add(new Vector3(2727.835 , 1515.762 , 145.8897 , "None"));
Path.Add(new Vector3(2722.697 , 1509.124 , 143.8056 , "None"));
Path.Add(new Vector3(2718.923 , 1501.393 , 143.4495 , "None"));
Path.Add(new Vector3(2716.361 , 1493.692 , 141.933 , "None"));
Path.Add(new Vector3(2710.724 , 1487.193 , 137.2315 , "None"));
Path.Add(new Vector3(2703.219 , 1485.359 , 133.6482 , "None"));
Path.Add(new Vector3(2698.148 , 1491.671 , 131.8591 , "None"));
Path.Add(new Vector3(2698.657 , 1500.101 , 128.6298 , "None"));
Path.Add(new Vector3(2701.379 , 1508.035 , 125.5679 , "None"));
Path.Add(new Vector3(2704.344 , 1515.606 , 124.8982 , "None"));
Path.Add(new Vector3(2707.408 , 1523.428 , 122.08 , "None"));
Path.Add(new Vector3(2710.847 , 1531.38 , 118.0405 , "None"));
Path.Add(new Vector3(2714.637 , 1538.573 , 116.1437 , "None"));
Path.Add(new Vector3(2718.628 , 1545.965 , 112.4718 , "None"));
Path.Add(new Vector3(2722.619 , 1553.356 , 109.8941 , "None"));
Path.Add(new Vector3(2726.585 , 1560.756 , 110.3699 , "None"));
Path.Add(new Vector3(2728.282 , 1569.221 , 109.5706 , "None"));
Path.Add(new Vector3(2728.679 , 1577.336 , 108.1102 , "None"));
Path.Add(new Vector3(2728.55 , 1586.021 , 106.6791 , "None"));
Path.Add(new Vector3(2728.358 , 1594.133 , 105.8792 , "None"));
Path.Add(new Vector3(2727.949 , 1602.808 , 104.2281 , "None"));
Path.Add(new Vector3(2727.465 , 1611.178 , 102.1868 , "None"));
Path.Add(new Vector3(2727.083 , 1619.3 , 99.32001 , "None"));
Path.Add(new Vector3(2726.689 , 1627.691 , 96.05659 , "None"));
Path.Add(new Vector3(2726.295 , 1636.081 , 92.7519 , "None"));
Path.Add(new Vector3(2725.901 , 1644.472 , 88.84588 , "None"));
Path.Add(new Vector3(2726.268 , 1652.67 , 85.05756 , "None"));
Path.Add(new Vector3(2725.709 , 1660.918 , 82.70641 , "None"));
Path.Add(new Vector3(2719.422 , 1663.547 , 81.98275 , "None"));
Path.Add(new Vector3(2713.852 , 1657.309 , 80.11837 , "None"));
Path.Add(new Vector3(2710.242 , 1649.921 , 80.10281 , "None"));
Path.Add(new Vector3(2708.44 , 1641.727 , 80.10281 , "None"));
Path.Add(new Vector3(2702.731 , 1635.959 , 79.99544 , "None"));
Path.Add(new Vector3(2694.737 , 1637.943 , 79.22649 , "None"));
Path.Add(new Vector3(2693.074 , 1645.786 , 76.8073 , "None"));
Path.Add(new Vector3(2693.792 , 1654.158 , 71.91106 , "None"));
Path.Add(new Vector3(2695.462 , 1662.407 , 64.364 , "None"));
Path.Add(new Vector3(2697.132 , 1670.622 , 56.55498 , "None"));
Path.Add(new Vector3(2698.802 , 1678.838 , 49.10552 , "None"));
Path.Add(new Vector3(2700.531 , 1687.349 , 42.70662 , "None"));
Path.Add(new Vector3(2702.77 , 1695.403 , 37.37719 , "None"));
Path.Add(new Vector3(2706.439 , 1703.275 , 35.15032 , "None"));
Path.Add(new Vector3(2708.96 , 1710.923 , 34.32057 , "None"));
Path.Add(new Vector3(2710.322 , 1719.212 , 33.56446 , "None"));
Path.Add(new Vector3(2711.73 , 1727.782 , 29.97178 , "None"));
Path.Add(new Vector3(2710.05 , 1735.028 , 26.56039 , "None"));
Path.Add(new Vector3(2703.816 , 1740.659 , 23.06508 , "None"));
Path.Add(new Vector3(2697.583 , 1746.289 , 19.29453 , "None"));
Path.Add(new Vector3(2696.406 , 1754.823 , 15.82396 , "None"));
Path.Add(new Vector3(2697.462 , 1762.823 , 12.85799 , "None"));
Path.Add(new Vector3(2698.648 , 1770.701 , 9.726797 , "None"));
Path.Add(new Vector3(2699.42 , 1778.814 , 6.433446 , "None"));
Path.Add(new Vector3(2697.1 , 1785.016 , 3.35152 , "None"));
Path.Add(new Vector3(2688.75 , 1785.671 , -1.547313 , "None"));
Path.Add(new Vector3(2683.653 , 1785.856 , -2.548499 , "Swimming"));
Path.Add(new Vector3(2679.51 , 1783.639 , -2.528949 , "Swimming"));
Path.Add(new Vector3(2675.812 , 1780.702 , -2.528949 , "Swimming"));
Path.Add(new Vector3(2672.115 , 1777.765 , -2.528949 , "Swimming"));
Path.Add(new Vector3(2668.417 , 1774.828 , -2.528949 , "Swimming"));
Path.Add(new Vector3(2664.719 , 1771.89 , -2.528949 , "Swimming"));
Path.Add(new Vector3(2661.022 , 1768.953 , -2.528949 , "Swimming"));
Path.Add(new Vector3(2657.324 , 1766.016 , -2.528949 , "Swimming"));
Path.Add(new Vector3(2653.627 , 1763.079 , -2.528949 , "Swimming"));
Path.Add(new Vector3(2649.929 , 1760.142 , -2.528949 , "Swimming"));
Path.Add(new Vector3(2646.228 , 1757.202 , -2.528949 , "Swimming"));
Path.Add(new Vector3(2642.471 , 1754.217 , -2.528949 , "Swimming"));
Path.Add(new Vector3(2638.836 , 1751.33 , -2.528949 , "Swimming"));
Path.Add(new Vector3(2632.146 , 1745.934 , -1.250084 , "None"));
Path.Add(new Vector3(2629.244 , 1743.629 , -0.9148472 , "None"));
Path.Add(new Vector3(2626.504 , 1741.452 , -0.6942763 , "None"));
Path.Add(new Vector3(2623.763 , 1739.275 , -0.4796537 , "None"));
Path.Add(new Vector3(2618.282 , 1734.921 , -0.1037508 , "None"));
Path.Add(new Vector3(2615.536 , 1732.74 , 0.07658318 , "None"));
Path.Add(new Vector3(2613.195 , 1730.162 , 0.4486025 , "None"));
Path.Add(new Vector3(2610.936 , 1727.489 , 0.9192209 , "None"));
Path.Add(new Vector3(2607.752 , 1724.101 , 0.7547812 , "None"));
Path.Add(new Vector3(2601.132 , 1717.513 , 0.3202455 , "None"));
Path.Add(new Vector3(2594.362 , 1712.54 , 0.7480495 , "None"));
Path.Add(new Vector3(2587.579 , 1707.557 , 0.2505004 , "None"));
Path.Add(new Vector3(2580.834 , 1702.602 , 2.433896 , "None"));
Path.Add(new Vector3(2574.065 , 1697.629 , 7.080088 , "None"));
Path.Add(new Vector3(2567.202 , 1692.82 , 13.02944 , "None"));
Path.Add(new Vector3(2560.152 , 1688.193 , 17.00669 , "None"));
Path.Add(new Vector3(2553.281 , 1683.391 , 20.31614 , "None"));
Path.Add(new Vector3(2546.382 , 1678.569 , 24.11245 , "None"));
Path.Add(new Vector3(2539.51 , 1673.766 , 27.49079 , "None"));
Path.Add(new Vector3(2532.626 , 1668.954 , 30.55322 , "None"));
Path.Add(new Vector3(2524.973 , 1665.649 , 32.87384 , "None"));
Path.Add(new Vector3(2518.297 , 1661.69 , 35.4149 , "None"));
Path.Add(new Vector3(2509.958 , 1660.948 , 38.33238 , "None"));
Path.Add(new Vector3(2501.906 , 1663.207 , 41.69551 , "None"));
Path.Add(new Vector3(2494.939 , 1667.852 , 45.30746 , "None"));
Path.Add(new Vector3(2488.393 , 1673.113 , 49.81456 , "None"));
Path.Add(new Vector3(2482.007 , 1678.575 , 54.15192 , "None"));
Path.Add(new Vector3(2475.013 , 1682.615 , 57.25225 , "None"));
Path.Add(new Vector3(2468.991 , 1687.378 , 58.90215 , "None"));
Path.Add(new Vector3(2465.614 , 1694.297 , 59.11752 , "None"));
Path.Add(new Vector3(2464.655 , 1702.641 , 58.77097 , "None"));
Path.Add(new Vector3(2464.82 , 1710.482 , 59.67027 , "None"));
Path.Add(new Vector3(2460.964 , 1718.177 , 59.93924 , "None"));
Path.Add(new Vector3(2455.95 , 1722.555 , 60.01952 , "None"));
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


public sealed class TraveltoMoakiHarbor : QuestClass
{
    public TraveltoMoakiHarbor()
    {
        Name = "Travel to Moa'ki Harbor";

        QuestId.AddRange(new[] { 12117 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

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


public sealed class TuakeasCrabTraps : QuestGathererClass
{
    public TuakeasCrabTraps()
    {
        Name = "Tua'kea's Crab Traps";

        QuestId.AddRange(new[] { 12009 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188359);
HotSpots.Add(new Vector3(2740.88 , 1010.432 , -15.48254 , "Swimming"));
HotSpots.Add(new Vector3(2710.186 , 1038.156 , -16.6606 , "Swimming"));
HotSpots.Add(new Vector3(2677.08 , 1015.168 , -40.88181 , "Swimming"));
HotSpots.Add(new Vector3(2634.979 , 984.6721 , -45.77201 , "Swimming"));
HotSpots.Add(new Vector3(2647.275 , 1043.228 , -30.92898 , "Swimming"));
HotSpots.Add(new Vector3(2645.264 , 1071.74 , -23.47966 , "Swimming"));
HotSpots.Add(new Vector3(2592.228 , 1084.343 , -34.77656 , "Swimming"));
HotSpots.Add(new Vector3(2575.092 , 1031.354 , -52.81654 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class YourPresenceisRequiredatStarsRest : QuestClass
{
    public YourPresenceisRequiredatStarsRest()
    {
        Name = "Your Presence is Required at Stars' Rest";

        QuestId.AddRange(new[] { 11995 });

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
