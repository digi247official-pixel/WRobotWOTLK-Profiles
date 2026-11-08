
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



public sealed class RainingDownDestruction : QuestClass
{
    public RainingDownDestruction()
    {
        Name = "Raining Down Destruction";

        QuestId.AddRange(new[] { 11982 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

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


public sealed class RallyingtheTroops : QuestUseItemOnClass
{
    public RallyingtheTroops()
    {
        Name = "Rallying the Troops";

        QuestId.AddRange(new[] { 12070 });

        Step = new List<int> { 5, 5, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26261);
ItemId = 36764;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Gaints : QuestClass
{
    public Gaints()
    {
        Name = "Gaints";

        QuestId.AddRange(new[] { 12070 });

        Step = new List<int> { 5, 5, 0, 0, 0 };

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
return Quest.IsObjectiveComplete(1, 12070) && Quest.IsObjectiveComplete(2, 12070);
}



public override bool HasQuest() { return true; }

public override bool Pulse() {
// Rallying the Troops (12070): Shard of the Earth (36764) on Grizzly Hills Giants (26261); rallied giants summon Iron Rune Avengers (26786) to kill
const int quest = 12070;
const uint shard = 36764;
if (!Conditions.InGameAndConnectedAndAliveAndProductStartedNotInPause)
    return true;
if (Quest.IsObjectiveComplete(1, quest) && Quest.IsObjectiveComplete(2, quest))
    return true;
if (ObjectManager.Me.InCombat)
{
    Thread.Sleep(500);
    return true;
}

var spots = new[] { new Vector3(4954.16, -4734.24, 287.264), new Vector3(5009.42, -4723.11, 297.773), new Vector3(5036.92, -4836.47, 285.7), new Vector3(5100.0, -4700.0, 290.0), new Vector3(5150.0, -4800.0, 290.0), new Vector3(4982.83, -4793.33, 286.901) };

if (!Quest.IsObjectiveComplete(1, quest) || !Quest.IsObjectiveComplete(2, quest))
{
    // Avengers still alive after rallying: let the fight class take them
    var dwarf = ObjectManager.GetWoWUnitByEntry(26786).Where(u => u.IsAlive).OrderBy(u => u.GetDistance).FirstOrDefault();
    if (dwarf != null && dwarf.GetDistance < 40)
    {
        if (dwarf.GetDistance > 25) GoToTask.ToPosition(dwarf.Position, 20f);
        ObjectManager.Me.Target = dwarf.Guid;
        Fight.StartFight(dwarf.Guid);
        Thread.Sleep(1000);
        return true;
    }
}

if (Quest.IsObjectiveComplete(1, quest))
{
    // all giants rallied; wait for the dwarves to show up
    Thread.Sleep(1500);
    return true;
}

var giant = ObjectManager.GetWoWUnitByEntry(26261).Where(u => u.IsAlive && !u.InCombat).OrderBy(u => u.GetDistance).FirstOrDefault();
if (giant == null)
{
    var spot = spots.OrderBy(s => s.DistanceTo(ObjectManager.Me.Position)).First();
    if (spot.DistanceTo(ObjectManager.Me.Position) < 12)
        spot = spots[Others.Random(0, spots.Length - 1)];
    GoToTask.ToPosition(spot, 8f);
    return true;
}
if (giant.GetDistance > 12)
{
    GoToTask.ToPosition(giant.Position, 8f);
    return true;
}
if (ObjectManager.Me.IsMounted) MountTask.DismountMount();
MovementManager.StopMove();
ObjectManager.Me.Target = giant.Guid;
Thread.Sleep(300);
Logging.Write("[Rallying the Troops] Using Shard of the Earth");
ItemsManager.UseItem(shard);
Thread.Sleep(Usefuls.Latency + 500);
Usefuls.WaitIsCasting();
Thread.Sleep(2000);
return true;


}
}


public sealed class IronRuneAven : QuestGrinderClass
{
    public IronRuneAven()
    {
        Name = "Iron Rune Aven";

        QuestId.AddRange(new[] { 12070 });

        Step = new List<int> { 5, 5, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26786);

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class IntotheBreach : QuestGrinderClass
{
    public IntotheBreach()
    {
        Name = "Into the Breach";

        QuestId.AddRange(new[] { 11985 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26348);
HotSpots.Add(new Vector3(5063.283 , -4797.542 , 219.4137 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Gavrock : QuestClass
{
    public Gavrock()
    {
        Name = "Gavrock";

        QuestId.AddRange(new[] { 12081 });

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


public sealed class Mojo : QuestGrinderClass
{
    public Mojo()
    {
        Name = "Mojo";

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

        EntryTarget.Add(26795);
HotSpots.Add(new Vector3(4627.08 , -4897.85 , 35.49727 , "None"));
HotSpots.Add(new Vector3(4629.29 , -4916.89 , 43.16351 , "None"));
HotSpots.Add(new Vector3(4616.21 , -4919.9 , 47.5276 , "None"));
HotSpots.Add(new Vector3(4568.86 , -4870.528 , 47.99237 , "None"));
HotSpots.Add(new Vector3(4731.796 , -4892.644 , 49.92331 , "None"));
HotSpots.Add(new Vector3(4475.053 , -4984.952 , 8.451402 , "None"));
HotSpots.Add(new Vector3(4474.65 , -4944.88 , 14.25867 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(36758) >= 5;
}



public override bool HasQuest() { return true; }


}


public sealed class VoicesFromtheDust : QuestGathererClass
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

        EntryIdObjects.Add(188461);
HotSpots.Add(new Vector3(4881.424 , -4753.447 , 27.61985 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Brazier : QuestFollowPathClass
{
    public Brazier()
    {
        Name = "Brazier";

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

        Path.Add(new Vector3(4601.265 , -4875.715 , 48.06346 , "None"));
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


public sealed class CleansingDrakTharon : QuestClass
{
    public CleansingDrakTharon()
    {
        Name = "Cleansing Drak'Tharon";

        QuestId.AddRange(new[] { 12238 });

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


public sealed class RunesofCompulsion : QuestGrinderClass
{
    public RunesofCompulsion()
    {
        Name = "Runes of Compulsion";

        QuestId.AddRange(new[] { 12093 });

        Step = new List<int> { 1, 1, 1, 1, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26820);
EntryTarget.Add(26923);
EntryTarget.Add(26922);
EntryTarget.Add(26921);
EntryTarget.Add(26920);
HotSpots.Add(new Vector3(4225.299 , -5066.035 , 6.556028 , "None"));
HotSpots.Add(new Vector3(4207.021 , -5046.519 , 6.3194 , "None"));
HotSpots.Add(new Vector3(4307.46 , -4891.04 , 34.33722 , "None"));
HotSpots.Add(new Vector3(4328.4 , -4893.99 , 34.12001 , "None"));
HotSpots.Add(new Vector3(4328.7 , -4871.32 , 34.34808 , "None"));
HotSpots.Add(new Vector3(4305.36 , -4869.95 , 35.28391 , "None"));
HotSpots.Add(new Vector3(4478.67 , -4662.77 , 77.6043 , "None"));
HotSpots.Add(new Vector3(4479.58 , -4642.15 , 80.27815 , "None"));
HotSpots.Add(new Vector3(4497.71 , -4645.45 , 79.81178 , "None"));
HotSpots.Add(new Vector3(4496.51 , -4662.97 , 77.02094 , "None"));
HotSpots.Add(new Vector3(3996.08 , -5238.03 , 7.976912 , "None"));
HotSpots.Add(new Vector3(3995.7 , -5261.26 , 7.805999 , "None"));
HotSpots.Add(new Vector3(3973.19 , -5260.42 , 7.514164 , "None"));
HotSpots.Add(new Vector3(3974.12 , -5239.27 , 7.843063 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LatentPower : QuestUseItemOnClass
{
    public LatentPower()
    {
        Name = "Latent Power";

        QuestId.AddRange(new[] { 12094 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

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


public sealed class Second : QuestUseItemOnClass
{
    public Second()
    {
        Name = "Second";

        QuestId.AddRange(new[] { 12094 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(4120.872 , -5250.508 , 7.204704 , "None"));
ItemId = 36787;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(2, 12094);
}



public override bool HasQuest() { return true; }


}


public sealed class Third : QuestUseItemOnClass
{
    public Third()
    {
        Name = "Third";

        QuestId.AddRange(new[] { 12094 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3964.82 , -5000.379 , 73.99802 , "None"));
ItemId = 36787;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(3, 12094);
}



public override bool HasQuest() { return true; }


}


public sealed class First : QuestUseItemOnClass
{
    public First()
    {
        Name = "First";

        QuestId.AddRange(new[] { 12094 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(4128.466 , -4853.688 , 73.11268 , "None"));
ItemId = 36787;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 12094);
}



public override bool HasQuest() { return true; }


}


public sealed class FreeatLast : QuestUseItemOnClass
{
    public FreeatLast()
    {
        Name = "Free at Last";

        QuestId.AddRange(new[] { 12099 });

        Step = new List<int> { 4, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26872);
EntryIdTarget.Add(26417);
HotSpots.Add(new Vector3(3924.014 , -5295.819 , 7.540585 , "None"));
HotSpots.Add(new Vector3(4001.604 , -5169.938 , 16.54745 , "None"));
HotSpots.Add(new Vector3(4035.906 , -5052.45 , 36.40346 , "None"));
HotSpots.Add(new Vector3(4017.202 , -4912.851 , 67.28797 , "None"));
HotSpots.Add(new Vector3(4288.006 , -4859.377 , 35.90852 , "None"));
HotSpots.Add(new Vector3(4266.219 , -4720.387 , 74.10536 , "None"));
ItemId = 36796;
Range = 30f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}
