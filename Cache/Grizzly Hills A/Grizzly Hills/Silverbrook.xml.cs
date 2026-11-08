
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



public sealed class NorthernHospitality : QuestGrinderClass
{
    public NorthernHospitality()
    {
        Name = "Northern Hospitality";

        QuestId.AddRange(new[] { 12299 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27424);
HotSpots.Add(new Vector3(4351.15 , -2455.02 , 239.0924 , "None"));
HotSpots.Add(new Vector3(4329.54 , -2351.51 , 223.4311 , "None"));
HotSpots.Add(new Vector3(4400.69 , -2382.1 , 224.4919 , "None"));
HotSpots.Add(new Vector3(4401.685 , -2354.563 , 215.7503 , "None"));
HotSpots.Add(new Vector3(4446.424 , -2345.805 , 200.202 , "None"));
HotSpots.Add(new Vector3(4268.67 , -2362.47 , 226.08 , "None"));
HotSpots.Add(new Vector3(4231.784 , -2393.868 , 229.0705 , "None"));
HotSpots.Add(new Vector3(4209.29 , -2382.64 , 229.3621 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WolfsbaneRoot : QuestGathererClass
{
    public WolfsbaneRoot()
    {
        Name = "Wolfsbane Root";

        QuestId.AddRange(new[] { 12307 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(189313);
HotSpots.Add(new Vector3(4190.663 , -2584.505 , 236.5021 , "None"));
HotSpots.Add(new Vector3(4176.731 , -2601.092 , 235.0024 , "None"));
HotSpots.Add(new Vector3(4173.506 , -2650.655 , 236.7135 , "None"));
HotSpots.Add(new Vector3(4199.786 , -2651.571 , 240.6197 , "None"));
HotSpots.Add(new Vector3(4220.753 , -2647.431 , 242.2355 , "None"));
HotSpots.Add(new Vector3(4267.707 , -2627.363 , 247.1513 , "None"));
HotSpots.Add(new Vector3(4288.643 , -2645.09 , 254.8662 , "None"));
HotSpots.Add(new Vector3(4323.711 , -2631.287 , 254.609 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TestofMettle : QuestGrinderClass
{
    public TestofMettle()
    {
        Name = "Test of Mettle";

        QuestId.AddRange(new[] { 12300 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27493);
HotSpots.Add(new Vector3(4466.636 , -2261.333 , 181.2797 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WordsofWarning : QuestClass
{
    public WordsofWarning()
    {
        Name = "Words of Warning";

        QuestId.AddRange(new[] { 12302 });

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


public sealed class EscapefromSilverbrook : QuestClass
{
    public EscapefromSilverbrook()
    {
        Name = "Escape from Silverbrook";

        QuestId.AddRange(new[] { 12308 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 5;

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


public sealed class ASwiftResponse : QuestGrinderClass
{
    public ASwiftResponse()
    {
        Name = "A Swift Response";

        QuestId.AddRange(new[] { 12310 });

        Step = new List<int> { 7, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27546);
EntryTarget.Add(27547);
HotSpots.Add(new Vector3(3127.299 , -2963.337 , 124.0718 , "None"));
HotSpots.Add(new Vector3(3152.864 , -2970.984 , 125.9652 , "None"));
HotSpots.Add(new Vector3(3161.46 , -3005.84 , 127.9138 , "None"));
HotSpots.Add(new Vector3(3129.28 , -2980.31 , 124.4969 , "None"));
HotSpots.Add(new Vector3(3142.06 , -3013.31 , 134.1746 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DescentintoDarkness : QuestClass
{
    public DescentintoDarkness()
    {
        Name = "Descent into Darkness";

        QuestId.AddRange(new[] { 12105 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 36940;

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


public sealed class ReporttoGryanStoutmantleAgain : QuestClass
{
    public ReporttoGryanStoutmantleAgain()
    {
        Name = "Report to Gryan Stoutmantle... Again";

        QuestId.AddRange(new[] { 12109 });

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


public sealed class TheFailedWorldTree : QuestGrinderClass
{
    public TheFailedWorldTree()
    {
        Name = "The Failed World Tree";

        QuestId.AddRange(new[] { 12219 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26366);
HotSpots.Add(new Vector3(3785.59 , -2883.1 , 225.5125 , "None"));
HotSpots.Add(new Vector3(3807.17 , -2886.23 , 222.7852 , "None"));
HotSpots.Add(new Vector3(3782.773 , -2937.355 , 229.2701 , "None"));
HotSpots.Add(new Vector3(3747.323 , -2945.547 , 229.3404 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ADarkInfluence : QuestClass
{
    public ADarkInfluence()
    {
        Name = "A Dark Influence";

        QuestId.AddRange(new[] { 12220 });

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

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 12220) && Quest.IsObjectiveComplete(2, 12220) && Quest.IsObjectiveComplete(3, 12220);
}





public override bool Pulse() {
// A Dark Influence (12220): use Geomancer's Orb (37173) at the 3 spots beneath Vordrassil
uint orb = 37173;
var spots = new[]
{
    new { Obj = 1, Name = "Vordrassil's Heart", Pos = new Vector3(3604.45, -3263.44, 223.016) },
    new { Obj = 2, Name = "Vordrassil's Limb",  Pos = new Vector3(3915.0, -2810.83, 176.211) },
    new { Obj = 3, Name = "Vordrassil's Tears", Pos = new Vector3(3974.06, -2710.11, 165.813) },
};

if (!Conditions.InGameAndConnectedAndAliveAndProductStartedNotInPause)
    return true;

var me = ObjectManager.Me.Position;
var next = spots
    .Where(s => !Quest.IsObjectiveComplete(s.Obj, 12220))
    .OrderBy(s => s.Pos.DistanceTo(me))
    .FirstOrDefault();
if (next == null)
    return true;

if (next.Pos.DistanceTo(me) > 3)
{
    GoToTask.ToPosition(next.Pos, 1.5f);
    return true;
}

if (ObjectManager.Me.IsMounted)
    MountTask.DismountMount();
MovementManager.StopMove();

Logging.Write("[A Dark Influence] Using orb at " + next.Name);
ItemsManager.UseItem(orb);
Thread.Sleep(Usefuls.Latency + 300);
Usefuls.WaitIsCasting();
Thread.Sleep(1500);

if (!Quest.IsObjectiveComplete(next.Obj, 12220))
    Thread.Sleep(4000); // orb has a 5 sec cooldown; retry next pulse
return true;
}
}


public sealed class APossibleLink : QuestGrinderClass
{
    public APossibleLink()
    {
        Name = "A Possible Link";

        QuestId.AddRange(new[] { 12246 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26428);
EntryTarget.Add(26357);
HotSpots.Add(new Vector3(3636.99 , -3844.782 , 191.162 , "None"));
HotSpots.Add(new Vector3(3615.09 , -3879.88 , 194.1912 , "None"));
HotSpots.Add(new Vector3(3595.9 , -3910.19 , 196.3482 , "None"));
HotSpots.Add(new Vector3(3566.19 , -3932.7 , 202.7598 , "None"));
HotSpots.Add(new Vector3(3507.77 , -3885.6 , 211.563 , "None"));
HotSpots.Add(new Vector3(3519.71 , -3849.12 , 219.045 , "None"));
HotSpots.Add(new Vector3(3540.68 , -3769.28 , 226.8423 , "None"));
HotSpots.Add(new Vector3(3511.59 , -3770.57 , 227.1644 , "None"));
HotSpots.Add(new Vector3(3496.04 , -3698.497 , 231.619 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ChildrenofUrsoc : QuestClass
{
    public ChildrenofUrsoc()
    {
        Name = "Children of Ursoc";

        QuestId.AddRange(new[] { 12247 });

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


public sealed class Orsonn : QuestInteractWithClass
{
    public Orsonn()
    {
        Name = "Orsonn";

        QuestId.AddRange(new[] { 12247 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(27274);
HotSpots.Add(new Vector3(3455.86 , -3632.16 , 245.135 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "GossipTitleButton1:Click();GossipTitleButton1:Click(); GossipTitleButton1:Click();GossipTitleButton1:Click();";
IgnoreIfDead = false;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 12247);
}



public override bool HasQuest() { return true; }


}


public sealed class Kodian : QuestInteractWithClass
{
    public Kodian()
    {
        Name = "Kodian";

        QuestId.AddRange(new[] { 12247 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(27275);
HotSpots.Add(new Vector3(3332.45 , -4622.38 , 232.1419 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "GossipTitleButton1:Click();GossipTitleButton1:Click(); GossipTitleButton1:Click();GossipTitleButton1:Click();";
IgnoreIfDead = false;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(2, 12247);
}



public override bool HasQuest() { return true; }


}


public sealed class VordrassilsSapling : QuestUseItemOnClass
{
    public VordrassilsSapling()
    {
        Name = "Vordrassil's Sapling";

        QuestId.AddRange(new[] { 12248 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(4023.025 , -3772.705 , 115.4176 , "None"));
ItemId = 37306;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class VordrassilsSeeds : QuestGathererClass
{
    public VordrassilsSeeds()
    {
        Name = "Vordrassil's Seeds";

        QuestId.AddRange(new[] { 12250 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188691);
HotSpots.Add(new Vector3(4093.217 , -3930.013 , 174.1541 , "None"));
HotSpots.Add(new Vector3(4101.313 , -3918.897 , 174.0182 , "None"));
HotSpots.Add(new Vector3(4180.787 , -3886.879 , 178.7304 , "None"));
HotSpots.Add(new Vector3(4209.132 , -3882.063 , 178.4386 , "None"));
HotSpots.Add(new Vector3(4198.25 , -3859.714 , 179.1297 , "None"));
HotSpots.Add(new Vector3(4148.607 , -3837.278 , 181.8671 , "None"));
HotSpots.Add(new Vector3(4199.851 , -3924.196 , 175.1838 , "None"));
HotSpots.Add(new Vector3(4201.738 , -3948.298 , 173.3904 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class UrsoctheBearGod : QuestInteractWithClass
{
    public UrsoctheBearGod()
    {
        Name = "Ursoc, the Bear God";

        QuestId.AddRange(new[] { 12249 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26633);
HotSpots.Add(new Vector3(4878.457 , -3849.658 , 337.4379 , "None"));
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


public sealed class TurRagepaw : QuestFollowPathClass
{
    public TurRagepaw()
    {
        Name = "Tur Ragepaw";

        QuestId.AddRange(new[] { 12249 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(4673.495 , -3870.874 , 330.2744 , "None"));
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


public sealed class Kill : QuestGrinderClass
{
    public Kill()
    {
        Name = "Kill";

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

        EntryTarget.Add(26633);
HotSpots.Add(new Vector3(4876.248 , -3842.404 , 337.6947 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ObjectManager.GetWoWUnitByEntry(26633).Count == 0;
}



public override bool HasQuest() { return true; }


}


public sealed class HeartoftheAncients : QuestClass
{
    public HeartoftheAncients()
    {
        Name = "Heart of the Ancients";

        QuestId.AddRange(new[] { 12042 });

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


public sealed class MyHeartisinYourHands : QuestClass
{
    public MyHeartisinYourHands()
    {
        Name = "My Heart is in Your Hands";

        QuestId.AddRange(new[] { 12802 });

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


public sealed class DesperateMojo : QuestGrinderClass
{
    public DesperateMojo()
    {
        Name = "Desperate Mojo";

        QuestId.AddRange(new[] { 12802 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26704);
EntryTarget.Add(27555);
HotSpots.Add(new Vector3(4551.043 , -3473.33 , 226.9319 , "None"));
HotSpots.Add(new Vector3(4495.938 , -3397.301 , 229.1348 , "None"));
HotSpots.Add(new Vector3(4512.51 , -3435.678 , 226.9319 , "None"));
HotSpots.Add(new Vector3(4516.31 , -3409.38 , 226.9368 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(36743) >= 5;
}



public override bool HasQuest() { return true; }


}


public sealed class BrazierDrak : QuestFollowPathClass
{
    public BrazierDrak()
    {
        Name = "Brazier Drak";

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

        Path.Add(new Vector3(4522.224 , -3473.46 , 227.4103 , "None"));
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


public sealed class VoicesFromtheDust : QuestClass
{
    public VoicesFromtheDust()
    {
        Name = "Voices From the Dust";

        QuestId.AddRange(new[] { 12068 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 5;

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
