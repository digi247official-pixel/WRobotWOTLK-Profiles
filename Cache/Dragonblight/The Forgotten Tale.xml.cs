
using System.Linq;
using robotManager.Helpful;
using wManager.Wow.Class;
using wManager.Wow.Enums;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;
using System.Collections.Generic;
using System.Threading;
using wManager.Wow.Bot.Tasks;


public class ForgottenTaleFix
{
    public static void Question(int entry, int objective, float x, float y, float z)
    {
        if (!wManager.Wow.Helpers.Quest.HasQuest(12291)) return;
        var destination = new robotManager.Helpful.Vector3(x, y, z);
        var deadline = System.DateTime.Now.AddMinutes(6);
        System.Func<bool> complete = () => wManager.Wow.Helpers.Quest.IsObjectiveComplete(objective, 12291);
        System.Func<bool> disguised = () => wManager.Wow.Helpers.Lua.LuaDoString<int>("local n=GetSpellInfo(48810) for _,f in ipairs({UnitBuff,UnitDebuff}) do for i=1,40 do local b=f('player',i) if not b then break end if b==n then return 1 end end end return 0") == 1;
        while (robotManager.Products.Products.IsStarted && System.DateTime.Now < deadline && !complete())
        {
            if (wManager.Wow.ObjectManager.ObjectManager.Me.IsDead)
            {
                robotManager.Helpful.Logging.WriteDebug("[Forgotten] Dead; stopping for recovery.");
                robotManager.Products.Products.ProductStop();
                return;
            }
            if (!disguised())
            {
                wManager.Wow.Helpers.MovementManager.StopMove();
                int count = wManager.Wow.Helpers.Lua.LuaDoString<int>("return GetItemCount(37570)");
                if (count < 1)
                {
                    robotManager.Helpful.Logging.WriteDebug("[Forgotten] Missing Murkweed Elixir (37570); get a replacement from Orik Trueheart.");
                    robotManager.Products.Products.ProductStop();
                    return;
                }
                wManager.Wow.Helpers.Lua.LuaDoString("if IsMounted() then Dismount() end UseItemByName(37570)");
                System.Threading.Thread.Sleep(4000);
                if (!disguised())
                {
                    robotManager.Helpful.Logging.WriteDebug("[Forgotten] Elixir did not apply Death's Door; retrying at the Forgotten Shore.");
                    wManager.Wow.Bot.Tasks.GoToTask.ToPosition(destination);
                    System.Threading.Thread.Sleep(1000);
                    continue;
                }
                robotManager.Helpful.Logging.WriteDebug("[Forgotten] Death's Door active.");
            }
            wManager.Wow.ObjectManager.WoWUnit target = null;
            float distance = float.MaxValue;
            foreach (var unit in wManager.Wow.ObjectManager.ObjectManager.GetObjectWoWUnit())
            {
                if (unit.Entry == entry && !unit.IsDead && unit.GetDistance < distance)
                {
                    target = unit;
                    distance = unit.GetDistance;
                }
            }
            if (target == null || distance > 4f)
            {
                wManager.Wow.Bot.Tasks.GoToTask.ToPosition(target == null ? destination : target.Position);
                System.Threading.Thread.Sleep(400);
                continue;
            }
            wManager.Wow.Helpers.MovementManager.StopMove();
            wManager.Wow.ObjectManager.ObjectManager.Me.Target = target.Guid;
            wManager.Wow.Helpers.Interact.InteractGameObject(target.GetBaseAddress);
            System.Threading.Thread.Sleep(800);
            wManager.Wow.Helpers.Lua.LuaDoString("if GossipFrame and GossipFrame:IsVisible() and GetNumGossipOptions()>0 then SelectGossipOption(1) end");
            System.Threading.Thread.Sleep(2500);
            robotManager.Helpful.Logging.WriteDebug("[Forgotten] NPC " + entry + " objective " + objective + " complete=" + complete());
        }
        if (robotManager.Products.Products.IsStarted && !complete())
        {
            robotManager.Helpful.Logging.WriteDebug("[Forgotten] Timed out on NPC " + entry + "; stopping instead of endlessly roaming.");
            robotManager.Products.Products.ProductStop();
        }
    }
}
public class MyCustomScript
{
    static MyCustomScript()
    {
        // You can put here code to run when bot start, you can also add methods and classes.
    }
}



public sealed class TheForgottenTale : QuestInteractWithClass
{
    public TheForgottenTale()
    {
        Name = "The Forgotten Tale";

        QuestId.AddRange(new[] { 12291 });

        Step = new List<int> { 1, 1, 1, 1, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(27224);
EntryIdTarget.Add(27229);
EntryIdTarget.Add(27226);
EntryIdTarget.Add(27225);
HotSpots.Add(new Vector3(3062.74 , -1035.583 , 9.511545 , "None"));
HotSpots.Add(new Vector3(3033.672 , -1146.482 , 6.219958 , "None"));
HotSpots.Add(new Vector3(2965.67 , -1029.49 , 8.096415 , "None"));
HotSpots.Add(new Vector3(2986.09 , -907.52 , 16.57373 , "None"));
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


public sealed class Spot : QuestFollowPathClass
{
    public Spot()
    {
        Name = "Spot";

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

        Path.Add(new Vector3(3057.668 , -1033.389 , 9.842855 , "None"));
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


public sealed class Peasant : QuestInteractWithClass
{
    public Peasant()
    {
        Name = "Peasant";

        QuestId.AddRange(new[] { 12291 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(27226);
HotSpots.Add(new Vector3(2955.74 , -1063.1 , 6.017701 , "None"));
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
return Quest.IsObjectiveComplete(1, 12291);
}



public override bool HasQuest() { return true; }


}


public sealed class Rifleman : QuestInteractWithClass
{
    public Rifleman()
    {
        Name = "Rifleman";

        QuestId.AddRange(new[] { 12291 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(27225);
HotSpots.Add(new Vector3(2974.96 , -955.84 , 16.10903 , "None"));
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
return Quest.IsObjectiveComplete(2, 12291);
}



public override bool HasQuest() { return true; }


}


public sealed class Knight : QuestInteractWithClass
{
    public Knight()
    {
        Name = "Knight";

        QuestId.AddRange(new[] { 12291 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(27224);
HotSpots.Add(new Vector3(3051.675 , -848.9927 , 17.16414 , "None"));
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
return Quest.IsObjectiveComplete(3, 12291);
}



public override bool HasQuest() { return true; }


}


public sealed class Footman : QuestInteractWithClass
{
    public Footman()
    {
        Name = "Footman";

        QuestId.AddRange(new[] { 12291 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(27229);
HotSpots.Add(new Vector3(2938.539 , -1129.782 , 4.828012 , "None"));
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
return Quest.IsObjectiveComplete(4, 12291);
}



public override bool HasQuest() { return true; }


}
