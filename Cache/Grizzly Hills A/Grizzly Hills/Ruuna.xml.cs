
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



public sealed class RuunatheBlind : QuestClass
{
    public RuunatheBlind()
    {
        Name = "Ruuna the Blind";

        QuestId.AddRange(new[] { 12161 });

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


public sealed class RuunasRequest : QuestGrinderClass
{
    public RuunasRequest()
    {
        Name = "Ruuna's Request";

        QuestId.AddRange(new[] { 12328 });

        Step = new List<int> { 4, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27421);
HotSpots.Add(new Vector3(4079.948 , -3530.365 , 251.1662 , "None"));
HotSpots.Add(new Vector3(4071.52 , -3540.552 , 253.1004 , "None"));
HotSpots.Add(new Vector3(4266.682 , -3695.023 , 258.2431 , "None"));
HotSpots.Add(new Vector3(4383.698 , -3681.934 , 255.5139 , "None"));
HotSpots.Add(new Vector3(4436.512 , -3733.333 , 227.9366 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MrFloppysPerilousAdventure : QuestFollowNpcClass
{
    public MrFloppysPerilousAdventure()
    {
        Name = "Mr. Floppy's Perilous Adventure";

        QuestId.AddRange(new[] { 12027 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        StartPosition = new Vector3(4322.89 , -3693.61 , 263.8404 , "None");
NpcEntry = 26588;
Assist = true;
FollowDistance = 6f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class OutofBodyExperience : QuestUseItemOnClass
{
    public OutofBodyExperience()
    {
        Name = "Out of Body Experience";

        QuestId.AddRange(new[] { 12327 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        ItemId = 37661;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class FateandCoincidence : QuestClass
{
    public FateandCoincidence()
    {
        Name = "Fate and Coincidence";

        QuestId.AddRange(new[] { 12329 });

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


public sealed class SashasHunt : QuestGrinderClass
{
    public SashasHunt()
    {
        Name = "Sasha's Hunt";

        QuestId.AddRange(new[] { 12134 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26389);
HotSpots.Add(new Vector3(4082.997 , -4294.125 , 251.6569 , "None"));
HotSpots.Add(new Vector3(4065.44 , -4291.6 , 251.477 , "None"));
HotSpots.Add(new Vector3(4056.66 , -4277.92 , 251.8052 , "None"));
HotSpots.Add(new Vector3(3984.73 , -4353.15 , 252.3278 , "None"));
HotSpots.Add(new Vector3(3983.32 , -4462 , 267.9265 , "None"));
HotSpots.Add(new Vector3(4046.65 , -4401.38 , 260.9018 , "None"));
HotSpots.Add(new Vector3(4054.62 , -4406.89 , 260.9254 , "None"));
HotSpots.Add(new Vector3(4080.22 , -4409.22 , 261.3969 , "None"));
HotSpots.Add(new Vector3(4115.46 , -4381.54 , 266.1874 , "None"));
HotSpots.Add(new Vector3(4128.9 , -4350.52 , 275.5696 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AnatolyWillTalk : QuestUseItemOnClass
{
    public AnatolyWillTalk()
    {
        Name = "Anatoly Will Talk";

        QuestId.AddRange(new[] { 12330 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(27627);
ItemId = 0;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Path : QuestFollowPathClass
{
    public Path()
    {
        Name = "Path";

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

        Path.Add(new Vector3(4018.767 , -4395.235 , 261.3622 , "None"));
Path.Add(new Vector3(4021.562 , -4397.899 , 261.7269 , "None"));
Path.Add(new Vector3(4024.931 , -4401.682 , 262.2672 , "None"));
Path.Add(new Vector3(4029.21 , -4398.068 , 262.4266 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = true;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class MountUp : QuestInteractWithClass
{
    public MountUp()
    {
        Name = "Mount Up";

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

        EntryIdTarget.Add(27626);
HotSpots.Add(new Vector3(4033.07 , -4375.17 , 262.1113 , "None"));
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
return ObjectManager.Me.InTransport;
}



public override bool HasQuest() { return true; }


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

        IsCompleteWhenAtLastPath = false;
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


public sealed class Wait : QuestFollowPathClass
{
    public Wait()
    {
        Name = "Wait";

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

        Path.Add(new Vector3(4030.614 , -4396.217 , 262.3641 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ObjectManager.GetNearestWoWUnit(ObjectManager.GetWoWUnitByEntry(27627)).IsAlive && ObjectManager.GetNearestWoWUnit(ObjectManager.GetWoWUnitByEntry(27627)).GetDistance < 50;
}



public override bool HasQuest() { return true; }


}


public sealed class ASistersPledge : QuestClass
{
    public ASistersPledge()
    {
        Name = "A Sister's Pledge";

        QuestId.AddRange(new[] { 12411 });

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


public sealed class HouroftheWorg : QuestClass
{
    public HouroftheWorg()
    {
        Name = "Hour of the Worg";

        QuestId.AddRange(new[] { 12164 });

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
