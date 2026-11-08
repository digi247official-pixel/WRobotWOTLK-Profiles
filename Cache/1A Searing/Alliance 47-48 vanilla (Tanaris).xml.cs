
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



public sealed class AFutureTask : QuestClass
{
    public AFutureTask()
    {
        Name = "A Future Task";

        QuestId.AddRange(new[] { 2964 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6948) == 1;
}






}


public sealed class AShortIncubation : QuestClass
{
    public AShortIncubation()
    {
        Name = "A Short Incubation";

        QuestId.AddRange(new[] { 3842 });

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
        return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(3825) == 2;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(3825) == 2;
}






}


public sealed class AnEasyPickup : QuestClass
{
    public AnEasyPickup()
    {
        Name = "An Easy Pickup";

        QuestId.AddRange(new[] { 3450 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6948) == 1;
}






}


public sealed class AnOrphanLookingForaHome : QuestClass
{
    public AnOrphanLookingForaHome()
    {
        Name = "An Orphan Looking For a Home";

        QuestId.AddRange(new[] { 3841 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(11102) == 1;
}






}


public sealed class ArcaneRunes : QuestGrinderClass
{
    public ArcaneRunes()
    {
        Name = "Arcane Runes";

        QuestId.AddRange(new[] { 3449 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, true, true, false };

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


public sealed class BoatfromTheramoreIsleMenethil : QuestClass
{
    public BoatfromTheramoreIsleMenethil()
    {
        Name = "Boat from Theramore Isle -> Menethil";

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


    }

	public override bool CanConditions()
	{
        return Usefuls.ContinentId == (int) ContinentId.Kalimdor;
	}

public override bool IsComplete() { 
return Usefuls.ContinentId == (int) ContinentId.Azeroth && !ObjectManager.Me.InTransport;
}



public override bool HasQuest() { return true; }

public override bool Pulse() {
// Sample of how to use Zeppelin/Ship
// In this sample, WRobot catch Zeppelin from Kalimdor (Ogrimmard) to Northrend (Borean Tundra (Warsong Hold))

/* Quest settings:
    * Can condition: "return Usefuls.ContinentId == (int) ContinentId.Kalimdor;"
    * Is complete condition: "return Usefuls.ContinentId == (int) ContinentId.Northrend && !ObjectManager.Me.InTransport;"
    * Not required in quest log: "True"
    * Quest type: "OverridePulseCSharpCode"
*/

// You can get zeppelin/ship/player positions and entry ID in tab "Tools" > "Development Tools" > "Dump all informations" (or "Memory information").

// Settings:
var zeppelinEntryId = 176231; // Zeppelin/Ship EntryId
// From
var fromZeppelinWaitPosition = new Vector3(-4016.39, -4740.588, 0); // Position where Zeppelin/Ship waits players (from)
var fromPlayerWaitPosition = new Vector3(-4006.753f, -4731.034f, 5.385289f); // Position where the player waits Zeppelin/Ship (from)
var fromPlayerInZeppelinPosition = new Vector3(-4010.584f, -4733.477f, 6.099737f); // Position where the player waits in the Zeppelin/Ship (from)
// To
var toZeppelinWaitPosition = new Vector3(-3905.225, -585.8085, 0); // Position where Zeppelin/Ship waits players (to)
var toPlayerLeavePosition = new Vector3(-3897.605f, -608.2468f, 5.217994f); // Position to go out the Zeppelin/Ship (to)

// Change WRobot settings:
wManager.wManagerSetting.CurrentSetting.CloseIfPlayerTeleported = false;

// Code:
if (!Conditions.InGameAndConnectedAndProductStartedNotInPause)
    return true;

if (Usefuls.ContinentId == (int)ContinentId.Kalimdor)
{
    if (!ObjectManager.Me.InTransport)
    {
        if (GoToTask.ToPosition(fromPlayerWaitPosition))
        {
            var zeppelin = ObjectManager.GetWoWGameObjectByEntry(zeppelinEntryId).OrderBy(o => o.GetDistance).FirstOrDefault();
            if (zeppelin != null && zeppelin.Position.DistanceTo(fromZeppelinWaitPosition) < 1)
            {
                GoToTask.ToPosition(fromPlayerInZeppelinPosition);
            }
        }
    }
}
else if (Usefuls.ContinentId == (int)ContinentId.Azeroth)
{
    if (ObjectManager.Me.InTransport)
    {
        var zeppelin = ObjectManager.GetWoWGameObjectByEntry(zeppelinEntryId).OrderBy(o => o.GetDistance).FirstOrDefault();
        if (zeppelin != null && zeppelin.Position.DistanceTo(toZeppelinWaitPosition) < 1)
        {
            GoToTask.ToPosition(toPlayerLeavePosition);
        }
    }
}
return true;
}
}


public sealed class Followme : QuestFollowPathClass
{
    public Followme()
    {
        Name = "Follow me!";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-9500.867 , -2956.023 , 14.97442 , "None"));
Path.Add(new Vector3(-9514.199 , -2946.508 , 17.50557 , "None"));
Path.Add(new Vector3(-9526.822 , -2937.811 , 21.25751 , "None"));
Path.Add(new Vector3(-9541.626 , -2928.486 , 27.52535 , "None"));
Path.Add(new Vector3(-9554.615 , -2928.934 , 31.25947 , "None"));
Path.Add(new Vector3(-9566.963 , -2924.931 , 35.80984 , "None"));
Path.Add(new Vector3(-9574.473 , -2909.862 , 35.79746 , "None"));
Path.Add(new Vector3(-9573.833 , -2895.704 , 32.49963 , "None"));
Path.Add(new Vector3(-9572.758 , -2879.293 , 24.51797 , "None"));
Path.Add(new Vector3(-9581.647 , -2864.748 , 25.22844 , "None"));
Path.Add(new Vector3(-9598.279 , -2854.115 , 24.91267 , "None"));
Path.Add(new Vector3(-9627.769 , -2835.263 , 20.53359 , "None"));
Path.Add(new Vector3(-9636.256 , -2825.956 , 13.56418 , "None"));
Path.Add(new Vector3(-9624.672 , -2822.491 , 11.1813 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = true;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ObjectManager.Me.Position.DistanceTo2D(new Vector3(-9623.168, -2820.645, 10.47848)) < 10;
}



public override bool HasQuest() { return true; }


}


public sealed class FoodforBaby : QuestGrinderClass
{
    public FoodforBaby()
    {
        Name = "Food for Baby";

        QuestId.AddRange(new[] { 4297 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(2926);
HotSpots.Add(new Vector3(204.9618 , -3584.564 , 126.4563 , "None"));
HotSpots.Add(new Vector3(29.3276 , -3635.01 , 124.482 , "None"));
HotSpots.Add(new Vector3(74.5918 , -3871.353 , 136.4507 , "None"));
HotSpots.Add(new Vector3(36.58267 , -3935.228 , 141.952 , "None"));
HotSpots.Add(new Vector3(75.788 , -3915.425 , 140.5888 , "None"));
HotSpots.Add(new Vector3(122.412 , -4005.43 , 127.7074 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Gahzridian : QuestGathererClass
{
    public Gahzridian()
    {
        Name = "Gahz&#039;ridian";

        QuestId.AddRange(new[] { 3161 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(140971);
HotSpots.Add(new Vector3(-8510.762 , -3503.497 , 9.887743 , "None"));
HotSpots.Add(new Vector3(-8823.387 , -3453.393 , 11.56716 , "None"));
HotSpots.Add(new Vector3(-8913.894 , -3472.525 , 11.97187 , "None"));
HotSpots.Add(new Vector3(-9053.983 , -3646.387 , 29.88349 , "None"));
HotSpots.Add(new Vector3(-9222.117 , -3554.354 , 13.23727 , "None"));
HotSpots.Add(new Vector3(-9428.69 , -3603.747 , 10.81015 , "None"));
HotSpots.Add(new Vector3(-9374.788 , -3455.807 , 10.57793 , "None"));
HotSpots.Add(new Vector3(-9432.983 , -3202.792 , 13.39879 , "None"));
HotSpots.Add(new Vector3(-9296.392 , -3120.955 , 10.36251 , "None"));
HotSpots.Add(new Vector3(-9247.048 , -3116.27 , 16.92793 , "None"));
HotSpots.Add(new Vector3(-9169.561 , -3061.177 , 34.96294 , "None"));
HotSpots.Add(new Vector3(-9222.629 , -3000.749 , 18.38664 , "None"));
HotSpots.Add(new Vector3(-9310.989 , -3004.306 , 9.628617 , "None"));
HotSpots.Add(new Vector3(-9232.568 , -2901.335 , 13.82558 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GT48 : QuestGrinderClass
{
    public GT48()
    {
        Name = "GT 48";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 47;
        RequiredQuest = 0;

        EntryTarget.Add(5472);
EntryTarget.Add(5474);
EntryTarget.Add(5475);
EntryTarget.Add(5473);
HotSpots.Add(new Vector3(-8494.523 , -3038.038 , 9.245074 , "None"));
HotSpots.Add(new Vector3(-8514.028 , -3020.096 , 9.639702 , "None"));
HotSpots.Add(new Vector3(-8546.523 , -2969.879 , 9.270301 , "None"));
HotSpots.Add(new Vector3(-8475.552 , -2821.976 , 10.28266 , "None"));
HotSpots.Add(new Vector3(-8380.749 , -2865.382 , 9.128762 , "None"));
HotSpots.Add(new Vector3(-8316.28 , -2881.63 , 10.8531 , "None"));
HotSpots.Add(new Vector3(-8229.13 , -2952.299 , 12.34098 , "None"));
HotSpots.Add(new Vector3(-8208.462 , -3033.1 , 10.34793 , "None"));
HotSpots.Add(new Vector3(-8884.511 , -3389.994 , 15.1699 , "None"));
HotSpots.Add(new Vector3(-8881.8 , -3451.87 , 11.10192 , "None"));
IsGrinderNotQuest = true;

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
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(8603) == 1;
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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6948) == 1;
}






}


public sealed class InsectPartAnalysispt2 : QuestClass
{
    public InsectPartAnalysispt2()
    {
        Name = "Insect Part Analysis pt2";

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(8594) == 1;
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
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5456);
EntryTarget.Add(5455);
EntryTarget.Add(5457);
EntryTarget.Add(4196);
EntryTarget.Add(5458);
HotSpots.Add(new Vector3(-8016.569 , -2536.595 , 8.799075 , "None"));
HotSpots.Add(new Vector3(-7988.713 , -2595.92 , 9.341833 , "None"));
HotSpots.Add(new Vector3(-7914.9 , -2584.643 , 9.809505 , "None"));
HotSpots.Add(new Vector3(-7879.761 , -2628.418 , 9.997913 , "None"));
HotSpots.Add(new Vector3(-7797.652 , -2522.948 , 14.64834 , "None"));
HotSpots.Add(new Vector3(-7762.89 , -2520.39 , 9.620175 , "None"));
HotSpots.Add(new Vector3(-7693.77 , -2552.61 , 14.52931 , "None"));
HotSpots.Add(new Vector3(-7748.217 , -2681.489 , 8.798247 , "None"));
HotSpots.Add(new Vector3(-7848.776 , -2717.255 , 8.933538 , "None"));
HotSpots.Add(new Vector3(-8011.744 , -2674.069 , 9.2858 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PassingtheBurden : QuestClass
{
    public PassingtheBurden()
    {
        Name = "Passing the Burden";

        QuestId.AddRange(new[] { 3448 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6948) == 1;
}






}


public sealed class ReturntoIronforge : QuestClass
{
    public ReturntoIronforge()
    {
        Name = "Return to Ironforge";

        QuestId.AddRange(new[] { 2977 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6064) == 1;
}






}


public sealed class RhapsodysKalimdorKocktail : QuestGrinderClass
{
    public RhapsodysKalimdorKocktail()
    {
        Name = "Rhapsody&#039;s Kalimdor Kocktail";

        QuestId.AddRange(new[] { 1452 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5428);
EntryTarget.Add(5429);
HotSpots.Add(new Vector3(-7579.894 , -3615.134 , 12.98989 , "None"));
HotSpots.Add(new Vector3(-7511.824 , -3612.561 , 11.83804 , "None"));
HotSpots.Add(new Vector3(-7515.584 , -3498.325 , 13.14495 , "None"));
HotSpots.Add(new Vector3(-7706.737 , -3351.644 , 58.17872 , "None"));
HotSpots.Add(new Vector3(-7756.966 , -3249.811 , 73.82162 , "None"));
HotSpots.Add(new Vector3(-7756.873 , -3173.317 , 76.7935 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RhapsodysTale : QuestGrinderClass
{
    public RhapsodysTale()
    {
        Name = "Rhapsody&#039;s Tale";

        QuestId.AddRange(new[] { 1469 });

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


public sealed class RiseoftheSilithid : QuestGrinderClass
{
    public RiseoftheSilithid()
    {
        Name = "Rise of the Silithid";

        QuestId.AddRange(new[] { 162 });

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


public sealed class SeeingWhatHappens : QuestClass
{
    public SeeingWhatHappens()
    {
        Name = "Seeing What Happens";

        QuestId.AddRange(new[] { 2946 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6064) == 1;
}






}


public sealed class SignalforPickup : QuestClass
{
    public SignalforPickup()
    {
        Name = "Signal for Pickup";

        QuestId.AddRange(new[] { 3451 });

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
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6948) == 1;
}






}


public sealed class SprinklesSecretIngredient : QuestGathererClass
{
    public SprinklesSecretIngredient()
    {
        Name = "Sprinkle&#039;s Secret Ingredient";

        QuestId.AddRange(new[] { 2641 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(141853);
HotSpots.Add(new Vector3(-79.25096 , -3152.123 , 102.4748 , "Swimming"));

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

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5472);
EntryTarget.Add(5474);
HotSpots.Add(new Vector3(-8546.02 , -2970.402 , 9.285242 , "None"));
HotSpots.Add(new Vector3(-8545.843 , -2995.025 , 10.00802 , "None"));
HotSpots.Add(new Vector3(-8482.694 , -3057.59 , 10.58 , "None"));
HotSpots.Add(new Vector3(-8477.232 , -3086.989 , 10.18255 , "None"));
HotSpots.Add(new Vector3(-8434.883 , -3059.067 , 8.624936 , "None"));
HotSpots.Add(new Vector3(-8374.889 , -3023.59 , 8.797299 , "None"));
HotSpots.Add(new Vector3(-8234.975 , -2987.141 , 9.57558 , "None"));
HotSpots.Add(new Vector3(-8205.075 , -3029.213 , 10.93409 , "None"));
HotSpots.Add(new Vector3(-8227.903 , -2931.208 , 15.57021 , "None"));
HotSpots.Add(new Vector3(-8500.28 , -2815.99 , 10.20247 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheDunemaulCompoundboss : QuestGrinderClass
{
    public TheDunemaulCompoundboss()
    {
        Name = "The Dunemaul Compound boss";

        QuestId.AddRange(new[] { 5863 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(12046);
HotSpots.Add(new Vector3(-8534.26 , -3082.25 , 8.701457 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheNewestMemberoftheFamily : QuestClass
{
    public TheNewestMemberoftheFamily()
    {
        Name = "The Newest Member of the Family";

        QuestId.AddRange(new[] { 3843 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(11471) == 1;
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
HotSpots.Add(new Vector3(-9148.857 , -4078.723 , -45.55185 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheStoneCircle : QuestGrinderClass
{
    public TheStoneCircle()
    {
        Name = "The Stone Circle";

        QuestId.AddRange(new[] { 3444 });

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


public sealed class TheStoneWatcher : QuestClass
{
    public TheStoneWatcher()
    {
        Name = "The Stone Watcher";

        QuestId.AddRange(new[] { 2954 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6948) == 1;
}






}


public sealed class TheSunkenTemple : QuestClass
{
    public TheSunkenTemple()
    {
        Name = "The Sunken Temple";

        QuestId.AddRange(new[] { 3445 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6948) == 1;
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
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5481);
HotSpots.Add(new Vector3(-8841.307 , -2303.531 , 8.877669 , "None"));
HotSpots.Add(new Vector3(-8821.188 , -2165.488 , 9.831945 , "None"));

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
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5485);
EntryTarget.Add(5490);
HotSpots.Add(new Vector3(-8843.522 , -2313.718 , 8.877622 , "None"));
HotSpots.Add(new Vector3(-8946.683 , -2311.605 , 11.39197 , "None"));
HotSpots.Add(new Vector3(-8954.932 , -2241.25 , 9.261538 , "None"));
HotSpots.Add(new Vector3(-8952.22 , -2184.428 , 8.878753 , "None"));
HotSpots.Add(new Vector3(-8918.4 , -2151.863 , 11.04185 , "None"));
HotSpots.Add(new Vector3(-8889.695 , -2184.531 , 9.20158 , "None"));
HotSpots.Add(new Vector3(-8747.598 , -2246.076 , 8.923034 , "None"));
HotSpots.Add(new Vector3(-8720.37 , -2210.51 , 10.92781 , "None"));
HotSpots.Add(new Vector3(-9098.728 , -2155.878 , 12.28341 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class YukaScrewspigot : QuestClass
{
    public YukaScrewspigot()
    {
        Name = "Yuka Screwspigot";

        QuestId.AddRange(new[] { 4324 });

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


public sealed class BecomingaParent : QuestClass
{
    public BecomingaParent()
    {
        Name = "Becoming a Parent";

        QuestId.AddRange(new[] { 4298 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6948) == 1;
}






}


public sealed class BacktoBootyBay : QuestClass
{
    public BacktoBootyBay()
    {
        Name = "Back to Booty Bay";

        QuestId.AddRange(new[] { 1118 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(5826) == 1;
}






}
