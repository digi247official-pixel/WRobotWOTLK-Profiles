
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



public sealed class Abo : QuestGrinderClass
{
    public Abo()
    {
        Name = "Abo";

        QuestId.AddRange(new[] { 12416 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27531);
HotSpots.Add(new Vector3(3607.294 , 759.7529 , 72.63924 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(3, 12416);
}



public override bool HasQuest() { return true; }


}


public sealed class CullingtheDamned : QuestGrinderClass
{
    public CullingtheDamned()
    {
        Name = "Culling the Damned";

        QuestId.AddRange(new[] { 12264 });

        Step = new List<int> { 3, 6, 6, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27362);
EntryTarget.Add(27358);
EntryTarget.Add(27363);
HotSpots.Add(new Vector3(4571.376 , 1724.706 , 168.8841 , "None"));
HotSpots.Add(new Vector3(4507.93 , 1765.15 , 165.227 , "None"));
HotSpots.Add(new Vector3(4576.38 , 1711.56 , 171.3174 , "None"));
HotSpots.Add(new Vector3(4491.65 , 1765.98 , 164.784 , "None"));
HotSpots.Add(new Vector3(4464.82 , 1781.086 , 167.4524 , "None"));
HotSpots.Add(new Vector3(4440.93 , 1785.24 , 164.22 , "None"));
HotSpots.Add(new Vector3(4435.14 , 1803.47 , 164.2203 , "None"));
HotSpots.Add(new Vector3(4429.718 , 1848.594 , 163.8676 , "None"));
HotSpots.Add(new Vector3(4469.5 , 1858.04 , 171.3622 , "None"));
HotSpots.Add(new Vector3(4424.142 , 1851.453 , 163.9001 , "None"));
HotSpots.Add(new Vector3(4497.34 , 1892.62 , 164.3171 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CycleofLife : QuestGrinderClass
{
    public CycleofLife()
    {
        Name = "Cycle of Life";

        QuestId.AddRange(new[] { 12454 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27244);
HotSpots.Add(new Vector3(2794.112 , 78.92297 , 17.43131 , "None"));
HotSpots.Add(new Vector3(2809.257 , 74.52099 , 18.3009 , "None"));
HotSpots.Add(new Vector3(2717.19 , 66.5486 , 13.08509 , "None"));
HotSpots.Add(new Vector3(2854.34 , 193.962 , 5.62777 , "None"));
HotSpots.Add(new Vector3(2880.071 , 74.18421 , 26.60701 , "None"));
HotSpots.Add(new Vector3(2845.38 , -16.13723 , 24.0009 , "None"));
HotSpots.Add(new Vector3(2893.16 , -80.2691 , 13.068 , "None"));
HotSpots.Add(new Vector3(2810.06 , 9.85938 , 8.55685 , "None"));
HotSpots.Add(new Vector3(2762.453 , -8.993722 , 1.465595 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DefendingWyrmrestTemple : QuestClass
{
    public DefendingWyrmrestTemple()
    {
        Name = "Defending Wyrmrest Temple";

        QuestId.AddRange(new[] { 12372 });

        Step = new List<int> { 3, 5, 1, 0, 0 };

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


public sealed class DefilingtheDefilers : QuestGathererClass
{
    public DefilingtheDefilers()
    {
        Name = "Defiling the Defilers";

        QuestId.AddRange(new[] { 12265 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188695);
HotSpots.Add(new Vector3(4601.96 , 1699.611 , 171.9091 , "None"));
HotSpots.Add(new Vector3(4604.2 , 1726.079 , 170.6446 , "None"));
HotSpots.Add(new Vector3(4573.693 , 1707.742 , 171.659 , "None"));
HotSpots.Add(new Vector3(4561.32 , 1731.498 , 166.641 , "None"));
HotSpots.Add(new Vector3(4545.349 , 1738.735 , 167.5414 , "None"));
HotSpots.Add(new Vector3(4512.741 , 1782.544 , 164.4725 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Fate : QuestGrinderClass
{
    public Fate()
    {
        Name = "Fate";

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

        EntryTarget.Add(27680);
HotSpots.Add(new Vector3(3743.825 , 953.1482 , 53.74992 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(37833) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class FlightoftheWintergardeDefender : QuestClass
{
    public FlightoftheWintergardeDefender()
    {
        Name = "Flight of the Wintergarde Defender";

        QuestId.AddRange(new[] { 12237 });

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


public sealed class Gheist : QuestGrinderClass
{
    public Gheist()
    {
        Name = "Gheist";

        QuestId.AddRange(new[] { 12416 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27686);
HotSpots.Add(new Vector3(3607.294 , 759.7529 , 72.63924 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(2, 12416);
}



public override bool HasQuest() { return true; }


}


public sealed class Ghuls : QuestGrinderClass
{
    public Ghuls()
    {
        Name = "Ghuls";

        QuestId.AddRange(new[] { 12416 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27685);
HotSpots.Add(new Vector3(3607.294 , 759.7529 , 72.63924 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 12416);
}



public override bool HasQuest() { return true; }


}


public sealed class HeatedBattle : QuestGrinderClass
{
    public HeatedBattle()
    {
        Name = "Heated Battle";

        QuestId.AddRange(new[] { 12416 });

        Step = new List<int> { 12, 8, 1, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27685);
EntryTarget.Add(27686);
EntryTarget.Add(27531);
HotSpots.Add(new Vector3(3605.636 , 762.3697 , 72.53636 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HighCommanderHalfordWyrmbane : QuestClass
{
    public HighCommanderHalfordWyrmbane()
    {
        Name = "High Commander Halford Wyrmbane";

        QuestId.AddRange(new[] { 12298 });

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


public sealed class InformingtheQueen : QuestClass
{
    public InformingtheQueen()
    {
        Name = "Informing the Queen";

        QuestId.AddRange(new[] { 12123 });

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


public sealed class Into : QuestFollowPathClass
{
    public Into()
    {
        Name = "Into";

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

        Path.Add(new Vector3(3764.063 , 692.6333 , 79.59285 , "None"));
Path.Add(new Vector3(3759.891 , 693.1207 , 79.83029 , "None"));
Path.Add(new Vector3(3753.001 , 694.3032 , 80.50442 , "None"));
Path.Add(new Vector3(3746.192 , 695.8425 , 80.15092 , "None"));
Path.Add(new Vector3(3739.665 , 698.316 , 80.15562 , "None"));
Path.Add(new Vector3(3733.571 , 701.4951 , 80.40065 , "None"));
Path.Add(new Vector3(3730.552 , 703.2805 , 80.34927 , "None"));
Path.Add(new Vector3(3727.54 , 705.0624 , 80.25866 , "None"));
Path.Add(new Vector3(3724.431 , 706.9012 , 80.12813 , "None"));
Path.Add(new Vector3(3721.413 , 708.6866 , 79.98134 , "None"));
Path.Add(new Vector3(3718.4 , 710.4685 , 79.79277 , "None"));
Path.Add(new Vector3(3712.381 , 714.0286 , 79.43278 , "None"));
Path.Add(new Vector3(3709.369 , 715.8105 , 79.3993 , "None"));
Path.Add(new Vector3(3703.326 , 719.3848 , 79.02358 , "None"));
Path.Add(new Vector3(3700.307 , 721.1703 , 78.84776 , "None"));
Path.Add(new Vector3(3694.306 , 724.7197 , 78.45944 , "None"));
Path.Add(new Vector3(3691.294 , 726.5015 , 78.52354 , "None"));
Path.Add(new Vector3(3688.275 , 728.287 , 78.44732 , "None"));
Path.Add(new Vector3(3682.256 , 731.8471 , 78.40726 , "None"));
Path.Add(new Vector3(3679.238 , 733.6325 , 78.83202 , "None"));
Path.Add(new Vector3(3674.007 , 737.7845 , 78.86526 , "None"));
Path.Add(new Vector3(3670.983 , 739.5735 , 79.36332 , "None"));
Path.Add(new Vector3(3667.977 , 741.3515 , 80.03584 , "None"));
Path.Add(new Vector3(3662.052 , 744.8563 , 81.02032 , "None"));
Path.Add(new Vector3(3658.846 , 746.7521 , 81.14109 , "None"));
Path.Add(new Vector3(3653.02 , 750.1982 , 82.15697 , "None"));
Path.Add(new Vector3(3650.008 , 751.9801 , 82.83905 , "None"));
Path.Add(new Vector3(3646.893 , 753.8225 , 82.58056 , "None"));
Path.Add(new Vector3(3644.004 , 755.5778 , 81.44361 , "None"));
Path.Add(new Vector3(3641.353 , 757.8615 , 78.90033 , "None"));
Path.Add(new Vector3(3638.584 , 760.1982 , 76.489 , "None"));
Path.Add(new Vector3(3635.467 , 761.7671 , 74.90189 , "None"));
Path.Add(new Vector3(3632.24 , 762.2726 , 72.87428 , "None"));
Path.Add(new Vector3(3625.93 , 759.2382 , 73.13567 , "None"));
Path.Add(new Vector3(3620.443 , 755.0854 , 73.60554 , "None"));
Path.Add(new Vector3(3614.398 , 751.98 , 73.49314 , "None"));
Path.Add(new Vector3(3607.831 , 753.8392 , 73.01021 , "None"));
Path.Add(new Vector3(3605.846 , 756.7988 , 72.85721 , "None"));
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


public sealed class IntoShire : QuestFollowPathClass
{
    public IntoShire()
    {
        Name = "Into Shire";

        QuestId.AddRange(new[] { 12417 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(3758.094 , 708.2305 , 83.24524 , "None"));
Path.Add(new Vector3(3764.427 , 703.1566 , 81.02773 , "None"));
Path.Add(new Vector3(3771.015 , 697.891 , 79.35708 , "None"));
Path.Add(new Vector3(3777.563 , 692.6569 , 79.05885 , "None"));
Path.Add(new Vector3(3784.258 , 687.6447 , 78.30936 , "None"));
Path.Add(new Vector3(3792.115 , 684.673 , 78.10715 , "None"));
Path.Add(new Vector3(3798.372 , 680.0001 , 77.49271 , "None"));
Path.Add(new Vector3(3805.508 , 676.2402 , 75.9205 , "None"));
Path.Add(new Vector3(3810.141 , 669.765 , 73.47012 , "None"));
Path.Add(new Vector3(3817.458 , 665.6405 , 70.19218 , "None"));
Path.Add(new Vector3(3824.771 , 661.473 , 65.76472 , "None"));
Path.Add(new Vector3(3832.137 , 657.4973 , 63.15582 , "None"));
Path.Add(new Vector3(3840.529 , 657.6329 , 61.97552 , "None"));
Path.Add(new Vector3(3848.722 , 658.9981 , 61.02468 , "None"));
Path.Add(new Vector3(3856.481 , 662.1444 , 59.97824 , "None"));
Path.Add(new Vector3(3863.344 , 667.0449 , 60.93603 , "None"));
Path.Add(new Vector3(3869.391 , 672.7399 , 61.94688 , "None"));
Path.Add(new Vector3(3874.874 , 679.0829 , 63.39261 , "None"));
Path.Add(new Vector3(3880.367 , 685.4379 , 65.62717 , "None"));
Path.Add(new Vector3(3886.185 , 691.4915 , 67.20082 , "None"));
Path.Add(new Vector3(3892.599 , 696.895 , 67.65899 , "None"));
Path.Add(new Vector3(3899.01 , 702.2965 , 68.79667 , "None"));
Path.Add(new Vector3(3905.433 , 707.7089 , 68.83342 , "None"));
Path.Add(new Vector3(3911.002 , 713.8915 , 67.73373 , "None"));
Path.Add(new Vector3(3915.709 , 720.8493 , 67.19881 , "None"));
Path.Add(new Vector3(3920.395 , 727.8206 , 65.32891 , "None"));
Path.Add(new Vector3(3925.081 , 734.7919 , 64.57177 , "None"));
Path.Add(new Vector3(3925.774 , 743.1174 , 63.4348 , "None"));
Path.Add(new Vector3(3926.482 , 751.4538 , 62.00438 , "None"));
Path.Add(new Vector3(3927.165 , 759.826 , 59.11532 , "None"));
Path.Add(new Vector3(3927.847 , 768.1982 , 58.30223 , "None"));
Path.Add(new Vector3(3928.53 , 776.5705 , 58.27869 , "None"));
Path.Add(new Vector3(3928.964 , 784.9597 , 57.35501 , "None"));
Path.Add(new Vector3(3927.987 , 793.3027 , 56.67791 , "None"));
Path.Add(new Vector3(3927.012 , 801.629 , 56.74582 , "None"));
Path.Add(new Vector3(3924.883 , 809.7427 , 56.77136 , "None"));
Path.Add(new Vector3(3921.88 , 817.5512 , 56.43354 , "None"));
Path.Add(new Vector3(3917.505 , 824.7222 , 56.72104 , "None"));
Path.Add(new Vector3(3915.243 , 832.2391 , 57.07372 , "None"));
Path.Add(new Vector3(3910.877 , 839.3957 , 56.66131 , "None"));
Path.Add(new Vector3(3906.511 , 846.5523 , 55.72041 , "None"));
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


public sealed class MysteryoftheInfinite : QuestClass
{
    public MysteryoftheInfinite()
    {
        Name = "Mystery of the Infinite";

        QuestId.AddRange(new[] { 12470 });

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


public sealed class NaxxramasandtheFallofWintergarde : QuestClass
{
    public NaxxramasandtheFallofWintergarde()
    {
        Name = "Naxxramas and the Fall of Wintergarde";

        QuestId.AddRange(new[] { 12235 });

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


public sealed class NeltharionsFlame : QuestUseItemOnClass
{
    public NeltharionsFlame()
    {
        Name = "Neltharion's Flame";

        QuestId.AddRange(new[] { 12267 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(27355);
HotSpots.Add(new Vector3(4416.804 , 1864.836 , 166.4237 , "None"));
ItemId = 37539;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class NoOnetoSaveYou : QuestGrinderClass
{
    public NoOnetoSaveYou()
    {
        Name = "No One to Save You";

        QuestId.AddRange(new[] { 12262 });

        Step = new List<int> { 6, 10, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27356);
EntryTarget.Add(27360);
HotSpots.Add(new Vector3(4388.356 , 1552.916 , 136.6534 , "None"));
HotSpots.Add(new Vector3(4402.881 , 1327.459 , 142.4807 , "None"));
HotSpots.Add(new Vector3(4401.96 , 1354.86 , 140.0649 , "None"));
HotSpots.Add(new Vector3(4406.43 , 1374.69 , 137.9197 , "None"));
HotSpots.Add(new Vector3(4360.818 , 1444.556 , 126.6412 , "None"));
HotSpots.Add(new Vector3(4384.104 , 1508.021 , 130.498 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class NoPlacetoRun : QuestUseItemOnClass
{
    public NoPlacetoRun()
    {
        Name = "No Place to Run";

        QuestId.AddRange(new[] { 12261 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(4382.796 , 1297.217 , 151.0314 , "None"));
ItemId = 37445;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReporttoLordAfrasastrasz : QuestClass
{
    public ReporttoLordAfrasastrasz()
    {
        Name = "Report to Lord Afrasastrasz";

        QuestId.AddRange(new[] { 12435 });

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


public sealed class ReporttotheRubyDragonshrine : QuestClass
{
    public ReporttotheRubyDragonshrine()
    {
        Name = "Report to the Ruby Dragonshrine";

        QuestId.AddRange(new[] { 12460 });

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


public sealed class ReturntotheEarth : QuestInteractWithClass
{
    public ReturntotheEarth()
    {
        Name = "Return to the Earth";

        QuestId.AddRange(new[] { 12417 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(27530);
HotSpots.Add(new Vector3(3907.35 , 866.472 , 56.14072 , "None"));
HotSpots.Add(new Vector3(3813.84 , 865.602 , 57.5154 , "None"));
HotSpots.Add(new Vector3(3783.67 , 894.99 , 55.332 , "None"));
HotSpots.Add(new Vector3(3830.08 , 958.533 , 55.66745 , "None"));
HotSpots.Add(new Vector3(3830.39 , 1054.13 , 57.25857 , "None"));
HotSpots.Add(new Vector3(3757.5 , 1066.13 , 56.36879 , "None"));
HotSpots.Add(new Vector3(3618.7 , 1053.83 , 58.9106 , "None"));
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


public sealed class RubyCorn : QuestGathererClass
{
    public RubyCorn()
    {
        Name = "Ruby Corn";

        QuestId.AddRange(new[] { 12417 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(189992);
HotSpots.Add(new Vector3(3848.571 , 864.454 , 56.72145 , "None"));
HotSpots.Add(new Vector3(3887.605 , 896.7863 , 56.78132 , "None"));
HotSpots.Add(new Vector3(3863.692 , 953.4282 , 57.14517 , "None"));
HotSpots.Add(new Vector3(3891.044 , 974.5974 , 57.33644 , "None"));
HotSpots.Add(new Vector3(3844.281 , 1007.151 , 56.70178 , "None"));
HotSpots.Add(new Vector3(3792.877 , 1096.781 , 56.09224 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(37727) >= 6;
}



public override bool HasQuest() { return true; }


}


public sealed class SeedsoftheLashers : QuestGrinderClass
{
    public SeedsoftheLashers()
    {
        Name = "Seeds of the Lashers";

        QuestId.AddRange(new[] { 12458 });

        Step = new List<int> { 3, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27254);
HotSpots.Add(new Vector3(2908.566 , 72.5927 , 3.555435 , "None"));
HotSpots.Add(new Vector3(2884.54 , 114.481 , 2.631619 , "None"));
HotSpots.Add(new Vector3(2852.21 , 145.984 , 2.519687 , "None"));
HotSpots.Add(new Vector3(2903.23 , 149.243 , 2.459096 , "None"));
HotSpots.Add(new Vector3(2842.53 , 184.96 , 3.125699 , "None"));
HotSpots.Add(new Vector3(2801.04 , 140.674 , 1.929537 , "None"));
HotSpots.Add(new Vector3(2757.673 , 129.236 , 5.163775 , "None"));

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


public sealed class TalesofDestruction : QuestClass
{
    public TalesofDestruction()
    {
        Name = "Tales of Destruction";

        QuestId.AddRange(new[] { 12266 });

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


public sealed class Taxi : QuestFollowPathClass
{
    public Taxi()
    {
        Name = "Taxi";

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

        Path.Add(new Vector3(3551.37 , 380.3273 , 52.22744 , "None"));
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


public sealed class ThatWhichCreatesCanAlsoDestroy : QuestClass
{
    public ThatWhichCreatesCanAlsoDestroy()
    {
        Name = "That Which Creates Can Also Destroy";

        QuestId.AddRange(new[] { 12459 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

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


public sealed class TheBestofIntentions : QuestUseItemOnClass
{
    public TheBestofIntentions()
    {
        Name = "The Best of Intentions";

        QuestId.AddRange(new[] { 12263 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(4419.673 , 1850.561 , 164.0867 , "None"));
ItemId = 0;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheFateoftheRubyDragonshrine : QuestClass
{
    public TheFateoftheRubyDragonshrine()
    {
        Name = "The Fate of the Ruby Dragonshrine";

        QuestId.AddRange(new[] { 12419 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 37833;

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


public sealed class TheHillsHaveUs : QuestClass
{
    public TheHillsHaveUs()
    {
        Name = "The Hills Have Us";

        QuestId.AddRange(new[] { 12511 });

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


public sealed class TheObsidianDragonshrine : QuestClass
{
    public TheObsidianDragonshrine()
    {
        Name = "The Obsidian Dragonshrine";

        QuestId.AddRange(new[] { 12447 });

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


public sealed class ThePlumeofAlystros : QuestUseItemOnClass
{
    public ThePlumeofAlystros()
    {
        Name = "The Plume of Alystros";

        QuestId.AddRange(new[] { 12456 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(2655.205 , -19.20964 , 3.097064 , "None"));
ItemId = 37881;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheStewardofWyrmrestTemple : QuestClass
{
    public TheStewardofWyrmrestTemple()
    {
        Name = "The Steward of Wyrmrest Temple";

        QuestId.AddRange(new[] { 12768 });

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


public sealed class ThroughFieldsofFlame : QuestGrinderClass
{
    public ThroughFieldsofFlame()
    {
        Name = "Through Fields of Flame";

        QuestId.AddRange(new[] { 12418 });

        Step = new List<int> { 6, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27539);
EntryTarget.Add(27680);
HotSpots.Add(new Vector3(3779.092 , 1003.184 , 59.89857 , "None"));
HotSpots.Add(new Vector3(3743.564 , 1015.027 , 64.24279 , "None"));
HotSpots.Add(new Vector3(3714.787 , 1008.436 , 62.54094 , "None"));
HotSpots.Add(new Vector3(3668.405 , 984.9074 , 56.16857 , "None"));
HotSpots.Add(new Vector3(3743.176 , 955.3269 , 53.71586 , "None"));
HotSpots.Add(new Vector3(3841.08 , 898.789 , 57.71007 , "None"));
HotSpots.Add(new Vector3(3783.59 , 920.945 , 60.88765 , "None"));
HotSpots.Add(new Vector3(3798.94 , 944.174 , 60.95962 , "None"));
HotSpots.Add(new Vector3(3702.85 , 927.352 , 53.8359 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TurnIn : QuestFollowPathClass
{
    public TurnIn()
    {
        Name = "Turn In";

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

        Path.Add(new Vector3(3845.114 , 927.0455 , 56.00691 , "None"));
Path.Add(new Vector3(3850.063 , 920.2994 , 56.2851 , "None"));
Path.Add(new Vector3(3854.961 , 913.6212 , 56.83902 , "None"));
Path.Add(new Vector3(3859.86 , 906.9429 , 58.20761 , "None"));
Path.Add(new Vector3(3864.958 , 899.9937 , 56.55671 , "None"));
Path.Add(new Vector3(3869.896 , 893.2612 , 56.20438 , "None"));
Path.Add(new Vector3(3874.795 , 886.5828 , 56.31813 , "None"));
Path.Add(new Vector3(3879.812 , 879.7442 , 57.07867 , "None"));
Path.Add(new Vector3(3884.79 , 872.9576 , 57.27084 , "None"));
Path.Add(new Vector3(3889.758 , 866.1844 , 56.56473 , "None"));
Path.Add(new Vector3(3894.896 , 859.181 , 55.43645 , "None"));
Path.Add(new Vector3(3899.695 , 852.6382 , 55.21497 , "None"));
Path.Add(new Vector3(3904.664 , 845.8651 , 55.76033 , "None"));
Path.Add(new Vector3(3909.632 , 839.0919 , 56.62616 , "None"));
Path.Add(new Vector3(3914.456 , 831.8798 , 57.0753 , "None"));
Path.Add(new Vector3(3917.535 , 824.4086 , 56.68791 , "None"));
Path.Add(new Vector3(3920.073 , 816.1032 , 56.40586 , "None"));
Path.Add(new Vector3(3921.99 , 807.91 , 57.27918 , "None"));
Path.Add(new Vector3(3923.071 , 799.8881 , 57.49467 , "None"));
Path.Add(new Vector3(3923.111 , 791.4882 , 57.54137 , "None"));
Path.Add(new Vector3(3923.052 , 783.0686 , 58.60947 , "None"));
Path.Add(new Vector3(3922.597 , 774.6978 , 59.89458 , "None"));
Path.Add(new Vector3(3922.14 , 766.2934 , 60.50333 , "None"));
Path.Add(new Vector3(3921.253 , 757.7365 , 62.11866 , "None"));
Path.Add(new Vector3(3918.514 , 750.0532 , 65.01902 , "None"));
Path.Add(new Vector3(3913.744 , 743.2794 , 67.64246 , "None"));
Path.Add(new Vector3(3907.085 , 738.1661 , 71.64015 , "None"));
Path.Add(new Vector3(3899.857 , 733.9204 , 75.01845 , "None"));
Path.Add(new Vector3(3892.353 , 730.1465 , 76.91458 , "None"));
Path.Add(new Vector3(3885.228 , 725.7572 , 78.20561 , "None"));
Path.Add(new Vector3(3878.749 , 720.3615 , 78.75133 , "None"));
Path.Add(new Vector3(3872.923 , 714.3396 , 77.32017 , "None"));
Path.Add(new Vector3(3867.31 , 708.1133 , 75.80903 , "None"));
Path.Add(new Vector3(3861.674 , 701.8621 , 71.94544 , "None"));
Path.Add(new Vector3(3856.06 , 695.6359 , 65.44886 , "None"));
Path.Add(new Vector3(3850.364 , 689.4169 , 60.17342 , "None"));
Path.Add(new Vector3(3844.665 , 683.2919 , 58.55034 , "None"));
Path.Add(new Vector3(3838.931 , 677.1299 , 57.81305 , "None"));
Path.Add(new Vector3(3833.22 , 670.9926 , 57.24453 , "None"));
Path.Add(new Vector3(3827.304 , 664.6339 , 62.19493 , "None"));
Path.Add(new Vector3(3821.561 , 659.6181 , 68.93072 , "None"));
Path.Add(new Vector3(3814.153 , 663.498 , 71.28123 , "None"));
Path.Add(new Vector3(3807.244 , 668.7199 , 73.79654 , "None"));
Path.Add(new Vector3(3801.192 , 674.1503 , 76.05699 , "None"));
Path.Add(new Vector3(3794.941 , 679.7864 , 77.65308 , "None"));
Path.Add(new Vector3(3787.237 , 683.3435 , 78.19262 , "None"));
Path.Add(new Vector3(3779.168 , 683.8417 , 78.75899 , "None"));
Path.Add(new Vector3(3770.786 , 683.558 , 78.19579 , "None"));
Path.Add(new Vector3(3762.407 , 682.9592 , 79.15524 , "None"));
Path.Add(new Vector3(3753.761 , 682.3413 , 79.16399 , "None"));
Path.Add(new Vector3(3745.655 , 681.7101 , 79.15269 , "None"));
Path.Add(new Vector3(3737.259 , 680.9217 , 79.67983 , "None"));
Path.Add(new Vector3(3728.894 , 681.0358 , 78.84302 , "None"));
Path.Add(new Vector3(3720.495 , 681.1623 , 81.62622 , "None"));
Path.Add(new Vector3(3712.521 , 683.5707 , 86.67169 , "None"));
Path.Add(new Vector3(3706.603 , 689.3635 , 88.89705 , "None"));
Path.Add(new Vector3(3704.677 , 694.6207 , 89.251 , "None"));
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
