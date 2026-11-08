
using System.Linq;
using robotManager.Helpful;
using wManager.Wow.Class;
using wManager.Wow.Enums;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;
using System.Collections.Generic;
using System.Threading;
using wManager.Wow.Bot.Tasks;


public class LumberDefense
{
    private static bool Mounted()
    {
        return wManager.Wow.ObjectManager.ObjectManager.Me.InTransport ||
            wManager.Wow.Helpers.Lua.LuaDoString<int>("if UnitInVehicle and UnitInVehicle('player') or UnitExists('vehicle') then return 1 end local n=GetSpellInfo(47921) for i=1,10 do local a,_,_,token=GetPetActionInfo(i) if token and a then a=_G[a] end if n and a==n then return 1 end end return 0") == 1;
    }

    private static bool Complete()
    {
        return wManager.Wow.Helpers.Quest.IsObjectiveComplete(1, 12050);
    }

    private static int Lumber()
    {
        return wManager.Wow.Helpers.Lua.LuaDoString<int>("return GetItemCount(36733)");
    }

    private static void Ability(int spell)
    {
        int found = wManager.Wow.Helpers.Lua.LuaDoString<int>("local id=" + spell + " local n=GetSpellInfo(id) for i=1,10 do local a,_,_,token=GetPetActionInfo(i) if token and a then a=_G[a] end if n and a==n then local s,d=GetPetActionCooldown(i) if not s or s==0 or s+d<=GetTime() then CastPetAction(i) end return 1 end end for i=1,12 do local b=_G['VehicleMenuBarActionButton'..i] local slot=b and b:GetAttribute('action') if slot then local t,v=GetActionInfo(slot) if t=='spell' and v==id then local s,d=GetActionCooldown(slot) if not s or s==0 or s+d<=GetTime() then b:Click() end return 1 end end end return 0");
        if (found == 0)
        {
            robotManager.Helpful.Logging.WriteDebug("[Lumber] Shredder ability " + spell + " missing from action bars; stopping.");
            robotManager.Products.Products.ProductStop();
        }
    }

    public static void Run()
    {
        if (!wManager.Wow.Helpers.Quest.HasQuest(12050) || Complete()) return;
        var settings = wManager.wManagerSetting.CurrentSetting;
        bool mount = settings.UseMount;
        bool fight = settings.DontStartFighting;
        var start = new robotManager.Helpful.Vector3(4812.355f, 656.595f, 163.3746f);
        var patrol = new robotManager.Helpful.Vector3[] {
            new robotManager.Helpful.Vector3(4818.934f, 667.802f, 162.7298f),
            new robotManager.Helpful.Vector3(4839.565f, 664.705f, 161.2909f),
            new robotManager.Helpful.Vector3(4842.121f, 678.0922f, 162.8588f),
            new robotManager.Helpful.Vector3(4844.048f, 719.478f, 165.0541f),
            new robotManager.Helpful.Vector3(4868.52f, 719.6243f, 163.4347f),
            new robotManager.Helpful.Vector3(4889.129f, 709.4864f, 161.3134f)
        };
        var ignored = new System.Collections.Generic.Dictionary<ulong, System.DateTime>();
        var deadline = System.DateTime.Now.AddMinutes(25);
        var lastProgress = System.DateTime.Now;
        var nextSummon = System.DateTime.MinValue;
        var lastLog = System.DateTime.MinValue;
        int previous = Lumber();
        int waypoint = 0;
        ulong lastEnemy = 0;
        ulong approachingTree = 0;
        var approachEnd = System.DateTime.MinValue;
        try
        {
            settings.UseMount = false;
            robotManager.Helpful.Logging.WriteDebug("[Lumber] Started; shredder controls=" + Mounted());
            while (robotManager.Products.Products.IsStarted &&
                wManager.Wow.Helpers.Quest.HasQuest(12050) && !Complete() &&
                System.DateTime.Now < deadline)
            {
                if (wManager.Wow.ObjectManager.ObjectManager.Me.IsDead)
                {
                    robotManager.Helpful.Logging.WriteDebug("[Lumber] Player died; stopping for recovery.");
                    break;
                }
                int count = Lumber();
                if (count > previous)
                {
                    previous = count;
                    lastProgress = System.DateTime.Now;
                    robotManager.Helpful.Logging.WriteDebug("[Lumber] Collected " + count + "/50.");
                }
                if ((System.DateTime.Now - lastProgress).TotalMinutes > 5)
                {
                    robotManager.Helpful.Logging.WriteDebug("[Lumber] No lumber gained in five minutes; stopping.");
                    break;
                }
                if (!Mounted())
                {
                    settings.DontStartFighting = fight;
                    if ((System.DateTime.Now - lastLog).TotalSeconds > 20)
                    {
                        lastLog = System.DateTime.Now;
                        robotManager.Helpful.Logging.WriteDebug("[Lumber] Shredder controls absent; finding and boarding shredder.");
                    }
                    var me = wManager.Wow.ObjectManager.ObjectManager.Me.Position;
                    if (me.DistanceTo(start) > 15f)
                    {
                        wManager.Wow.Bot.Tasks.GoToTask.ToPosition(start);
                        System.Threading.Thread.Sleep(400);
                        continue;
                    }
                    wManager.Wow.ObjectManager.WoWUnit shredder = null;
                    float nearest = float.MaxValue;
                    foreach (var unit in wManager.Wow.ObjectManager.ObjectManager.GetObjectWoWUnit())
                        if (unit.Entry == 27061 && !unit.IsDead && unit.GetDistance < nearest)
                        { shredder = unit; nearest = unit.GetDistance; }
                    if (shredder == null)
                    {
                        if (System.DateTime.Now >= nextSummon)
                        {
                            if (wManager.Wow.Helpers.Lua.LuaDoString<int>("return GetItemCount(36734)") < 1)
                            {
                                robotManager.Helpful.Logging.WriteDebug("[Lumber] Missing Xink's Shredder Control Device (36734).");
                                break;
                            }
                            wManager.Wow.Helpers.MovementManager.StopMove();
                            wManager.Wow.Helpers.Lua.LuaDoString("if IsMounted() then Dismount() end UseItemByName(36734)");
                            nextSummon = System.DateTime.Now.AddSeconds(15);
                            System.Threading.Thread.Sleep(3000);
                        }
                    }
                    else if (nearest > 4f)
                    {
                        if (nearest < 25f)
                            wManager.Wow.Helpers.MovementManager.MoveTo(shredder.Position.X, shredder.Position.Y, shredder.Position.Z);
                        else
                            wManager.Wow.Bot.Tasks.GoToTask.ToPosition(shredder.Position);
                    }
                    else
                    {
                        wManager.Wow.Helpers.MovementManager.StopMove();
                        wManager.Wow.Helpers.Interact.InteractGameObject(shredder.GetBaseAddress);
                        System.Threading.Thread.Sleep(1500);
                        wManager.Wow.Helpers.Lua.LuaDoString("if GossipFrame and GossipFrame:IsVisible() and GetNumGossipOptions()>0 then SelectGossipOption(1) end");
                    }
                    System.Threading.Thread.Sleep(500);
                    continue;
                }
                settings.DontStartFighting = true;
                if (wManager.Wow.Helpers.Lua.LuaDoString<int>("local u=UnitExists('vehicle') and 'vehicle' or 'pet' if UnitHealthMax(u)>0 and UnitHealth(u)/UnitHealthMax(u)<0.65 then return 1 end return 0") == 1)
                    Ability(47966);
                var position = wManager.Wow.ObjectManager.ObjectManager.Me.Position;
                wManager.Wow.ObjectManager.WoWUnit enemy = null;
                float best = float.MaxValue;
                foreach (var unit in wManager.Wow.ObjectManager.ObjectManager.GetObjectWoWUnit())
                {
                    if (unit.IsDead || unit.GetDistance > 30f ||
                        System.Math.Abs(unit.Position.Z - position.Z) > 12f) continue;
                    bool attacking = unit.IsTargetingMeOrMyPet;
                    bool harpy = unit.Entry == 26577 || unit.Entry == 26578 ||
                        (unit.Name != null && unit.Name.IndexOf("Coldwind", System.StringComparison.OrdinalIgnoreCase) >= 0);
                    if (!attacking && !harpy) continue;
                    float score = unit.GetDistance - (attacking ? 100f : 0f);
                    if (score < best) { best = score; enemy = unit; }
                }
                if (enemy != null)
                {
                    if (lastEnemy != enemy.Guid)
                    {
                        lastEnemy = enemy.Guid;
                        robotManager.Helpful.Logging.WriteDebug("[Lumber] Targeting " + enemy.Name + " (" + enemy.Entry + ") distance=" + enemy.GetDistance);
                    }
                    wManager.Wow.ObjectManager.ObjectManager.Me.Target = enemy.Guid;
                    wManager.Wow.Helpers.Lua.LuaDoString("TargetUnit('0x" + enemy.Guid.ToString("X16") + "')");
                    wManager.Wow.Helpers.MovementManager.Face(enemy.Position);
                    if (enemy.GetDistance > 5f)
                        wManager.Wow.Helpers.MovementManager.MoveTo(enemy.Position.X, enemy.Position.Y, enemy.Position.Z);
                    else
                        wManager.Wow.Helpers.MovementManager.StopMove();
                    Ability(47921);
                    if (enemy.GetDistance < 7f) Ability(47938);
                    System.Threading.Thread.Sleep(400);
                    continue;
                }
                wManager.Wow.ObjectManager.WoWGameObject tree = null;
                float distance = float.MaxValue;
                foreach (var obj in wManager.Wow.ObjectManager.ObjectManager.GetObjectWoWGameObject())
                {
                    if (obj.Entry != 188539 || obj.GetDistance > 100f ||
                        System.Math.Abs(obj.Position.Z - position.Z) > 18f) continue;
                    System.DateTime until;
                    if (ignored.TryGetValue(obj.Guid, out until) && System.DateTime.Now < until) continue;
                    if (obj.GetDistance < distance) { tree = obj; distance = obj.GetDistance; }
                }
                if (tree != null)
                {
                    var point = tree.Position;
                    if (approachingTree != tree.Guid)
                    {
                        approachingTree = tree.Guid;
                        approachEnd = System.DateTime.Now.AddSeconds(25);
                        robotManager.Helpful.Logging.WriteDebug("[Lumber] Approaching marked tree " + tree.Guid + " distance=" + distance);
                    }
                    if (distance > 4f)
                    {
                        if (System.DateTime.Now > approachEnd)
                        {
                            ignored[tree.Guid] = System.DateTime.Now.AddSeconds(45);
                            approachingTree = 0;
                            wManager.Wow.Helpers.MovementManager.StopMove();
                            robotManager.Helpful.Logging.WriteDebug("[Lumber] Cannot reach marker within harvest range; trying another.");
                            continue;
                        }
                        float horizontal = position.DistanceTo2D(point);
                        if (horizontal < 0.1f) horizontal = 0.1f;
                        var beside = new robotManager.Helpful.Vector3(
                            point.X + (position.X - point.X) * 2.5f / horizontal,
                            point.Y + (position.Y - point.Y) * 2.5f / horizontal, point.Z);
                        if (distance > 12f) wManager.Wow.Bot.Tasks.GoToTask.ToPosition(beside);
                        else wManager.Wow.Helpers.MovementManager.MoveTo(beside.X, beside.Y, beside.Z);
                        System.Threading.Thread.Sleep(300);
                        continue;
                    }
                    wManager.Wow.Helpers.MovementManager.StopMove();
                    wManager.Wow.Helpers.MovementManager.Face(point);
                    wManager.Wow.Helpers.Lua.LuaDoString("ClearTarget()");
                    int before = Lumber();
                    Ability(47939);
                    System.Threading.Thread.Sleep(3500);
                    int after = Lumber();
                    ignored[tree.Guid] = System.DateTime.Now.AddSeconds(after > before ? 40 : 15);
                    approachingTree = 0;
                    robotManager.Helpful.Logging.WriteDebug("[Lumber] Harvest at " + distance + " yards: " + before + " -> " + after);
                }
                else
                {
                    if (position.DistanceTo(patrol[waypoint]) < 5f) waypoint = (waypoint + 1) % patrol.Length;
                    wManager.Wow.Bot.Tasks.GoToTask.ToPosition(patrol[waypoint]);
                    if ((System.DateTime.Now - lastLog).TotalSeconds > 20)
                    {
                        lastLog = System.DateTime.Now;
                        robotManager.Helpful.Logging.WriteDebug("[Lumber] Searching marked trees; lumber=" + count);
                    }
                    System.Threading.Thread.Sleep(400);
                }
            }
        }
        finally
        {
            wManager.Wow.Helpers.MovementManager.StopMove();
            if (Mounted()) wManager.Wow.Helpers.Lua.LuaDoString("VehicleExit()");
            settings.UseMount = mount;
            settings.DontStartFighting = fight;
        }
        robotManager.Helpful.Logging.WriteDebug("[Lumber] Finished; complete=" + Complete() + " lumber=" + Lumber());
        if (robotManager.Products.Products.IsStarted && !Complete())
            robotManager.Products.Products.ProductStop();
    }
}
public class MyCustomScript
{
    static MyCustomScript()
    {
        // You can put here code to run when bot start, you can also add methods and classes.
    }
}



public sealed class LumberHack : QuestClass
{
    public LumberHack()
    {
        Name = "Lumber Hack";

        QuestId.AddRange(new[] { 12050 });

        Step = new List<int> { 50, 0, 0, 0, 0 };

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


public sealed class Start : QuestFollowPathClass
{
    public Start()
    {
        Name = "Start";

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

        Path.Add(new Vector3(4812.355 , 656.595 , 163.3746 , "None"));
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


public sealed class W1 : QuestFollowPathClass
{
    public W1()
    {
        Name = "W1";

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

        Path.Add(new Vector3(4818.934 , 667.802 , 162.7298 , "None"));
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


public sealed class W2 : QuestFollowPathClass
{
    public W2()
    {
        Name = "W2";

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

        Path.Add(new Vector3(4839.565 , 664.705 , 161.2909 , "None"));
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


public sealed class W3 : QuestFollowPathClass
{
    public W3()
    {
        Name = "W3";

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

        Path.Add(new Vector3(4842.121 , 678.0922 , 162.8588 , "None"));
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


public sealed class W4 : QuestFollowPathClass
{
    public W4()
    {
        Name = "W4";

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

        Path.Add(new Vector3(4844.048 , 719.478 , 165.0541 , "None"));
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


public sealed class W5 : QuestFollowPathClass
{
    public W5()
    {
        Name = "W5";

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

        Path.Add(new Vector3(4868.52 , 719.6243 , 163.4347 , "None"));
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


public sealed class W6 : QuestFollowPathClass
{
    public W6()
    {
        Name = "W6";

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

        Path.Add(new Vector3(4889.129 , 709.4864 , 161.3134 , "None"));
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
