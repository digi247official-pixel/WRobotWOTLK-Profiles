
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

        Path.Add(new Vector3(4587.627 , -4215.174 , 178.3663 , "None"));
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


public sealed class Carrot : QuestGathererClass
{
    public Carrot()
    {
        Name = "Carrot";

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

        EntryIdObjects.Add(189983);
HotSpots.Add(new Vector3(4485.241 , -4240.499 , 164.895 , "None"));
HotSpots.Add(new Vector3(4463.542 , -4299.554 , 161.3867 , "None"));
HotSpots.Add(new Vector3(4439.168 , -4319.041 , 159.7668 , "None"));
HotSpots.Add(new Vector3(4356.53 , -4287.646 , 161.6199 , "None"));
HotSpots.Add(new Vector3(4364.058 , -4345.262 , 158.703 , "None"));
HotSpots.Add(new Vector3(4340.751 , -4391.164 , 155.2235 , "None"));
HotSpots.Add(new Vector3(4388.221 , -4409.631 , 149.0934 , "None"));
HotSpots.Add(new Vector3(4415.792 , -4380.67 , 151.5073 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(37707) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class Horse : QuestClass
{
    public Horse()
    {
        Name = "Horse";

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
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 12414) && Lua.LuaDoString<int>("return GetInventoryItemID('player',16) or 0") != 37708;
}



public override bool HasQuest() { return true; }

public override bool Pulse() {
// Mounting Up (12414): gather Wild Carrot, lure a Highland Mustang with the Stick (equip only for the cast),
// ride it to Squire Percy and use vehicle button 1 (Scare Highland Mustang) for credit.
const int quest = 12414;
const uint stick = 37708, carrot = 37707, carrotObj = 189983, mustang = 26472;
var percy = new Vector3(4587.627, -4215.174, 178.3663);
var hotspots = new List<Vector3>
{
    new Vector3(4391.108, -4328.992, 158.2199),
    new Vector3(4400.177, -4364.176, 154.4831),
    new Vector3(4362.803, -4402.033, 152.168),
    new Vector3(4352.609, -4458.24, 147.0823),
    new Vector3(4392.91, -4450.604, 140.6051),
    new Vector3(4440.0, -4000.0, 181.0),
};

System.Func<bool> inVehicle = () => ObjectManager.Me.InTransport ||
    Lua.LuaDoString<bool>("return UnitInVehicle('player') and true or false");

// Remember the real weapon(s) and put them back when the Stick is equipped.
System.Action saveWeapon = () => Lua.LuaDoString(@"
    local id = GetInventoryItemID('player', 16)
    if id and id ~= 37708 then
        wrMuMH = GetItemInfo(id)
        local oh = GetInventoryItemID('player', 17)
        wrMuOH = oh and GetItemInfo(oh) or nil
    end");
System.Action restoreWeapon = () => Lua.LuaDoString(@"
    if GetInventoryItemID('player', 16) ~= 37708 then return end
    local mh = wrMuMH
    if not mh then
        local best, bestLvl = nil, -1
        for b = 0, 4 do for s = 1, GetContainerNumSlots(b) do
            local id = GetContainerItemID(b, s)
            if id and id ~= 37708 then
                local n, _, _, lvl, _, _, _, _, loc = GetItemInfo(id)
                if (loc == 'INVTYPE_2HWEAPON' or loc == 'INVTYPE_WEAPON' or loc == 'INVTYPE_WEAPONMAINHAND') and lvl > bestLvl then best, bestLvl = n, lvl end
            end
        end end
        mh = best
    end
    if mh then EquipItemByName(mh, 16) end
    if wrMuOH then EquipItemByName(wrMuOH, 17) end");

if (!Conditions.InGameAndConnectedAndAliveAndProductStartedNotInPause || Quest.IsObjectiveComplete(1, quest))
{
    restoreWeapon();
    return true;
}

// 1) Riding a mustang: bring it to Squire Percy and scare it off for credit.
if (inVehicle())
{
    restoreWeapon();
    if (ObjectManager.Me.Position.DistanceTo(percy) > 8)
    {
        Logging.Write("[Mounting Up] Riding mustang to Squire Percy");
        MovementManager.Go(PathFinder.FindPath(percy));
        var t = new robotManager.Helpful.Timer(90000);
        while (inVehicle() && !t.IsReady && ObjectManager.Me.IsAlive &&
               ObjectManager.Me.Position.DistanceTo(percy) > 8 && robotManager.Products.Products.IsStarted)
        {
            if (!MovementManager.InMovement)
                MovementManager.Go(PathFinder.FindPath(percy));
            Thread.Sleep(300);
        }
        MovementManager.StopMove();
    }
    if (inVehicle() && ObjectManager.Me.Position.DistanceTo(percy) <= 12)
    {
        Logging.Write("[Mounting Up] Returning mustang");
        Lua.LuaDoString("VehicleMenuBarActionButton1:Click()");
        Thread.Sleep(2500);
        if (inVehicle())
            Lua.LuaDoString("VehicleExit()");
        Thread.Sleep(1000);
    }
    return true;
}

// Never fight with the Stick.
if (ObjectManager.Me.InCombat)
{
    restoreWeapon();
    return true;
}
restoreWeapon();

// 2) Need a Wild Carrot.
if (ItemsManager.GetItemCountById(carrot) < 1)
{
    var node = ObjectManager.GetWoWGameObjectByEntry((int)carrotObj)
        .OrderBy(o => o.GetDistance).FirstOrDefault();
    if (node == null)
    {
        var spot = hotspots.OrderBy(h => h.DistanceTo(ObjectManager.Me.Position)).First();
        if (spot.DistanceTo(ObjectManager.Me.Position) < 10)
            spot = hotspots[Others.Random(0, hotspots.Count - 1)];
        Logging.Write("[Mounting Up] Searching for Wild Carrot");
        GoToTask.ToPosition(spot, 5f);
        return true;
    }
    Logging.Write("[Mounting Up] Picking Wild Carrot");
    GoToTask.ToPositionAndIntecractWithGameObject(node.Position, (int)carrotObj);
    Thread.Sleep(Usefuls.Latency + 500);
    Usefuls.WaitIsCasting();
    Thread.Sleep(800);
    Lua.LuaDoString("for i = GetNumLootItems(), 1, -1 do LootSlot(i) end CloseLoot()");
    Thread.Sleep(500);
    return true;
}

// 3) Find a free Highland Mustang.
var horse = ObjectManager.GetWoWUnitByEntry((int)mustang)
    .Where(u => u.IsAlive && !u.InCombat && !u.IsTargetingMe)
    .OrderBy(u => u.GetDistance).FirstOrDefault();
if (horse == null)
{
    var spot = hotspots.OrderBy(h => h.DistanceTo(ObjectManager.Me.Position)).First();
    if (spot.DistanceTo(ObjectManager.Me.Position) < 10)
        spot = hotspots[Others.Random(0, hotspots.Count - 1)];
    Logging.Write("[Mounting Up] Searching for Highland Mustang");
    GoToTask.ToPosition(spot, 5f);
    return true;
}

if (horse.GetDistance > 15)
{
    GoToTask.ToPosition(horse.Position, 12f);
    return true;
}

if (ObjectManager.Me.IsMounted)
    MountTask.DismountMount();
MovementManager.StopMove();
ObjectManager.Me.Target = horse.Guid;
Thread.Sleep(300);

saveWeapon();
if (ItemsManager.GetItemCountById(stick) > 0)
    Lua.LuaDoString("EquipItemByName(37708)");
Thread.Sleep(1200);

Logging.Write("[Mounting Up] Dangling carrot at Highland Mustang");
ItemsManager.UseItem(stick);
Thread.Sleep(Usefuls.Latency + 300);
Usefuls.WaitIsCasting();
restoreWeapon();

var w = new robotManager.Helpful.Timer(5000);
while (!w.IsReady && !inVehicle())
    Thread.Sleep(200);
return true;


}
}


public sealed class MountingUp : QuestGrinderClass
{
    public MountingUp()
    {
        Name = "Mounting Up";

        QuestId.AddRange(new[] { 12414 });

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
