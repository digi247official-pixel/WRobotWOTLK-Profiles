
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



public sealed class AnExerciseinDiplomacy : QuestClass
{
    public AnExerciseinDiplomacy()
    {
        Name = "An Exercise in Diplomacy";

        QuestId.AddRange(new[] { 12295 });

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


public sealed class BrazieZeb : QuestFollowPathClass
{
    public BrazieZeb()
    {
        Name = "Brazie Zeb";

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

        Path.Add(new Vector3(4244.481 , -2023.061 , 237.3333 , "None"));
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


public sealed class Brazier1 : QuestFollowPathClass
{
    public Brazier1()
    {
        Name = "Brazier 1";

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

        Path.Add(new Vector3(3386.673 , -1807.193 , 114.1667 , "None"));
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


public sealed class ElixirZeb : QuestGrinderClass
{
    public ElixirZeb()
    {
        Name = "Elixir Zeb";

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

        EntryTarget.Add(26544);
HotSpots.Add(new Vector3(4186.27 , -1871.81 , 204.4635 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(35836) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class Eye : QuestGrinderClass
{
    public Eye()
    {
        Name = "Eye";

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

        EntryTarget.Add(26446);
HotSpots.Add(new Vector3(3382.164 , -1690.819 , 85.03421 , "None"));
HotSpots.Add(new Vector3(3358.462 , -1722.302 , 88.60169 , "None"));
HotSpots.Add(new Vector3(3298.983 , -1733.968 , 84.27467 , "None"));
HotSpots.Add(new Vector3(3326.976 , -1809.605 , 91.22034 , "None"));
HotSpots.Add(new Vector3(3349.603 , -1872.752 , 108.3752 , "None"));
HotSpots.Add(new Vector3(3354.066 , -1917.855 , 121.8104 , "None"));
HotSpots.Add(new Vector3(3423.77 , -1844.46 , 106.258 , "None"));
HotSpots.Add(new Vector3(3473.796 , -1797.129 , 109.7642 , "None"));
HotSpots.Add(new Vector3(3322.698 , -1685.855 , 88.48183 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(35798) >= 5;
}



public override bool HasQuest() { return true; }


}


public sealed class FillingtheCages : QuestUseSpellOnClass
{
    public FillingtheCages()
    {
        Name = "Filling the Cages";

        QuestId.AddRange(new[] { 11984 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26425);
HotSpots.Add(new Vector3(3425.443 , -1759.042 , 93.80753 , "None"));
HotSpots.Add(new Vector3(3383.636 , -1771.485 , 94.61777 , "None"));
HotSpots.Add(new Vector3(3370.44 , -1736.288 , 90.39832 , "None"));
HotSpots.Add(new Vector3(3333.528 , -1770.675 , 88.54598 , "None"));
HotSpots.Add(new Vector3(3356.529 , -1779.482 , 92.88072 , "None"));
HotSpots.Add(new Vector3(3430.159 , -1807.181 , 103.1588 , "None"));
SpellId = 47035;
Range = 5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Frond : QuestGathererClass
{
    public Frond()
    {
        Name = "Frond";

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

        EntryIdObjects.Add(188351);
HotSpots.Add(new Vector3(4113.545 , -1913.367 , 187.1968 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(3, 11990);
}



public override bool HasQuest() { return true; }


}


public sealed class Haze : QuestGathererClass
{
    public Haze()
    {
        Name = "Haze";

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

        EntryIdObjects.Add(188600);
HotSpots.Add(new Vector3(3963.803 , -1884.507 , 208.4393 , "None"));
HotSpots.Add(new Vector3(3957.718 , -1908.903 , 209.9277 , "None"));
HotSpots.Add(new Vector3(3950.136 , -1946.221 , 204.8786 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(2, 11990);
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


public sealed class Knife : QuestFollowPathClass
{
    public Knife()
    {
        Name = "Knife";

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

        Path.Add(new Vector3(3842.575 , -1977.992 , 208.179 , "None"));
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

        EntryTarget.Add(26425);
EntryTarget.Add(26447);
HotSpots.Add(new Vector3(3425.147 , -1761.167 , 93.99965 , "None"));
HotSpots.Add(new Vector3(3429.004 , -1806.328 , 102.7924 , "None"));
HotSpots.Add(new Vector3(3438.758 , -1850.165 , 111.3846 , "None"));
HotSpots.Add(new Vector3(3372.92 , -1887.65 , 118.3793 , "None"));
HotSpots.Add(new Vector3(3368.646 , -1844.705 , 103.7496 , "None"));
HotSpots.Add(new Vector3(3337.088 , -1832.565 , 97.96554 , "None"));
HotSpots.Add(new Vector3(3358.898 , -1781.619 , 94.438 , "None"));
HotSpots.Add(new Vector3(3340.559 , -1762.639 , 87.22086 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(35799) >= 5;
}



public override bool HasQuest() { return true; }


}


public sealed class PickUp : QuestGathererClass
{
    public PickUp()
    {
        Name = "Pick Up";

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

        EntryIdObjects.Add(190223);
HotSpots.Add(new Vector3(3881.076 , -1940.22 , 209.0191 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(38149) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class Root : QuestGathererClass
{
    public Root()
    {
        Name = "Root";

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

        EntryIdObjects.Add(188601);
HotSpots.Add(new Vector3(4218.58 , -1991.612 , 210.929 , "None"));
HotSpots.Add(new Vector3(4170.479 , -2035.916 , 216.1765 , "None"));
HotSpots.Add(new Vector3(4135.26 , -2025.233 , 216.863 , "None"));
HotSpots.Add(new Vector3(4217.14 , -2164.986 , 218.6437 , "None"));
HotSpots.Add(new Vector3(4320.199 , -2004.164 , 202.4463 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(37087) >= 5;
}



public override bool HasQuest() { return true; }


}


public sealed class SacrificesMustbeMade : QuestGathererClass
{
    public SacrificesMustbeMade()
    {
        Name = "Sacrifices Must be Made";

        QuestId.AddRange(new[] { 12007 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188458);
HotSpots.Add(new Vector3(4239.347 , -2051.418 , 241.9204 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SayHellotoMyLittleFriend : QuestClass
{
    public SayHellotoMyLittleFriend()
    {
        Name = "Say Hello to My Little Friend";

        QuestId.AddRange(new[] { 12190 });

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


public sealed class Scourgekabob : QuestUseItemOnClass
{
    public Scourgekabob()
    {
        Name = "Scourgekabob";

        QuestId.AddRange(new[] { 12484 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3825.115 , -1995.099 , 209.6516 , "None"));
ItemId = 38149;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SearedScourge : QuestClass
{
    public SearedScourge()
    {
        Name = "Seared Scourge";

        QuestId.AddRange(new[] { 12029 });

        Step = new List<int> { 20, 0, 0, 0, 0 };

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
return Quest.IsObjectiveComplete(1, 12029);
}





public override bool Pulse() {
// Seared Scourge (12029): throw Mack's Dark Grog (35908, ground-targeted) on Famished Scourge Trolls (26570)
uint grog = 35908;
int trollEntry = 26570;
var south = new Vector3(4535.5, -2125.5, 160.95);
var north = new Vector3(4535.0, -1962.0, 160.95);
var mack = new Vector3(3826.5, -1985.58, 208.2886);

// Throws grog at the densest troll group within range. Safe to call in or out of combat.
System.Func<bool> tryThrow = () =>
{
    if (ItemsManager.GetItemCountById(grog) <= 0 || ObjectManager.Me.IsCast)
        return false;
    var myPos = ObjectManager.Me.Position;
    var near = ObjectManager.GetWoWUnitByEntry(trollEntry)
        .Where(u => u.IsValid && u.IsAlive && u.Position.DistanceTo(myPos) < 30)
        .ToList();
    if (near.Count == 0)
        return false;

    WoWUnit best = null;
    int bestCount = 0;
    foreach (var t in near)
    {
        int c = near.Count(o => o.Position.DistanceTo(t.Position) < 7);
        if (best == null || c > bestCount || (c == bestCount && t.GetDistance < best.GetDistance))
        {
            best = t;
            bestCount = c;
        }
    }

    if (ObjectManager.Me.IsMounted)
        MountTask.DismountMount();

    ItemsManager.UseItem(grog);
    bool targeting = false;
    for (int i = 0; i < 10 && !targeting; i++)
    {
        Thread.Sleep(100);
        targeting = Lua.LuaDoString<bool>("return SpellIsTargeting() and true or false");
    }
    if (!targeting)
        return false;

    ClickOnTerrain.Pulse(best.Position);
    Thread.Sleep(300);
    if (Lua.LuaDoString<bool>("return SpellIsTargeting() and true or false"))
        Lua.LuaDoString("SpellStopTargeting()");
    Logging.Write("[Seared Scourge] Threw grog at " + bestCount + " troll(s), " + System.Math.Round(best.GetDistance) + "y away");
    Thread.Sleep(1500);
    return true;
};

// Background thrower: keeps burning trolls while the fight class is busy fighting them
if (System.AppDomain.CurrentDomain.GetData("SearedScourgeThread") == null)
{
    System.AppDomain.CurrentDomain.SetData("SearedScourgeThread", "running");
    var th = new Thread(() =>
    {
        try
        {
            while (robotManager.Products.Products.IsStarted && Quest.HasQuest(12029) && !Quest.IsObjectiveComplete(1, 12029))
            {
                try
                {
                    if (Conditions.InGameAndConnectedAndAliveAndProductStartedNotInPause && ObjectManager.Me.InCombat)
                        tryThrow();
                }
                catch (System.Exception ex)
                {
                    Logging.WriteError("[Seared Scourge] " + ex.Message);
                }
                Thread.Sleep(1000);
            }
        }
        finally
        {
            System.AppDomain.CurrentDomain.SetData("SearedScourgeThread", null);
        }
    });
    th.IsBackground = true;
    th.Start();
}

if (!Conditions.InGameAndConnectedAndAliveAndProductStartedNotInPause)
    return true;
if (Quest.IsObjectiveComplete(1, 12029))
    return true;

if (ItemsManager.GetItemCountById(grog) <= 0)
{
    Logging.Write("[Seared Scourge] Out of grog, asking Mack for more.");
    GoToTask.ToPositionAndIntecractWithNpc(mack, 26604, 1);
    Thread.Sleep(1500);
    return true;
}

if (tryThrow())
    return true;

// Nothing in range: approach the nearest troll on the edge of a group (don't walk into the middle)
var me = ObjectManager.Me.Position;
var nearest = ObjectManager.GetWoWUnitByEntry(trollEntry)
    .Where(u => u.IsValid && u.IsAlive && u.Position.DistanceTo(me) < 120)
    .OrderBy(u => u.Position.DistanceTo(me))
    .FirstOrDefault();
if (nearest != null)
{
    GoToTask.ToPosition(nearest.Position, 22);
    return true;
}

// No trolls visible: alternate between the two groups beside the Drak'Tharon stairs
var spot = south.DistanceTo(me) < 70 ? north : south;
GoToTask.ToPosition(spot, 50);
return true;
}
}


public sealed class ShimmercapStew : QuestClass
{
    public ShimmercapStew()
    {
        Name = "Shimmercap Stew";

        QuestId.AddRange(new[] { 12483 });

        Step = new List<int> { 5, 5, 5, 0, 0 };

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


public sealed class Snowcap : QuestGathererClass
{
    public Snowcap()
    {
        Name = "Snowcap";

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

        EntryIdObjects.Add(188345);
HotSpots.Add(new Vector3(3455.671 , -1722.767 , 104.0434 , "None"));
HotSpots.Add(new Vector3(3430.366 , -1703.776 , 95.38826 , "None"));
HotSpots.Add(new Vector3(3445.074 , -1688.313 , 98.24415 , "None"));
HotSpots.Add(new Vector3(3356.889 , -1687.576 , 84.28133 , "None"));
HotSpots.Add(new Vector3(3353.102 , -1690.435 , 84.62836 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(35782) >= 5;
}



public override bool HasQuest() { return true; }


}


public sealed class Stone : QuestFollowPathClass
{
    public Stone()
    {
        Name = "Stone ";

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

        Path.Add(new Vector3(4239.347 , -2051.418 , 241.9204 , "None"));
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


public sealed class SubjecttoInterpretation : QuestClass
{
    public SubjecttoInterpretation()
    {
        Name = "Subject to Interpretation";

        QuestId.AddRange(new[] { 11991 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

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


public sealed class Truce : QuestInteractWithClass
{
    public Truce()
    {
        Name = "Truce?";

        QuestId.AddRange(new[] { 11989 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3844.59 , -1973.08 , 208.432 , "None"));
GossipOptionNpcInteractWith = 3;
Macro = "";
IgnoreIfDead = false;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Vial : QuestGrinderClass
{
    public Vial()
    {
        Name = "Vial";

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

        HotSpots.Add(new Vector3(3842.629 , -1950.548 , 208.7116 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 11990);
}



public override bool HasQuest() { return true; }


}


public sealed class VialofVisions : QuestClass
{
    public VialofVisions()
    {
        Name = "Vial of Visions";

        QuestId.AddRange(new[] { 11990 });

        Step = new List<int> { 1, 3, 1, 0, 0 };

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


public sealed class SearchandRescue : QuestClass
{
    public SearchandRescue()
    {
        Name = "Search and Rescue";

        QuestId.AddRange(new[] { 12037 });

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
