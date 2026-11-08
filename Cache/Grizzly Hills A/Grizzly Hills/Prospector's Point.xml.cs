
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



public sealed class CheckUponRaegar : QuestClass
{
    public CheckUponRaegar()
    {
        Name = "Check Up on Raegar";

        QuestId.AddRange(new[] { 12128 });

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


public sealed class ThePerfectPlan : QuestUseItemOnClass
{
    public ThePerfectPlan()
    {
        Name = "The Perfect Plan";

        QuestId.AddRange(new[] { 12129 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26347);
EntryIdTarget.Add(26408);
HotSpots.Add(new Vector3(3381.484 , -5100.912 , 326.5625 , "None"));
HotSpots.Add(new Vector3(3354.67 , -5093.97 , 325.3047 , "None"));
HotSpots.Add(new Vector3(3343.36 , -5063.28 , 327.8731 , "None"));
ItemId = 36849;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheCaptiveProspectors : QuestClass
{
    public TheCaptiveProspectors()
    {
        Name = "The Captive Prospectors";

        QuestId.AddRange(new[] { 12180 });

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


public sealed class Key : QuestGrinderClass
{
    public Key()
    {
        Name = "Key";

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

        EntryTarget.Add(26407);
EntryTarget.Add(26414);
EntryTarget.Add(26347);
HotSpots.Add(new Vector3(3641.569 , -5003.792 , 176.9106 , "None"));
HotSpots.Add(new Vector3(3625.874 , -5001.461 , 180.084 , "None"));
HotSpots.Add(new Vector3(3591.369 , -4957.748 , 185.8633 , "None"));
HotSpots.Add(new Vector3(3552.851 , -4978.137 , 206.4933 , "None"));
HotSpots.Add(new Vector3(3496.487 , -4937.507 , 225.7442 , "None"));
HotSpots.Add(new Vector3(3426.462 , -4936.65 , 258.2262 , "None"));
HotSpots.Add(new Vector3(3473.422 , -5010.537 , 238.1344 , "None"));
HotSpots.Add(new Vector3(3517.59 , -5123.6 , 233.6775 , "None"));
HotSpots.Add(new Vector3(3468.222 , -5075.796 , 236.9161 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(37013) >= 3;
}



public override bool HasQuest() { return true; }


}


public sealed class Cage1 : QuestGathererClass
{
    public Cage1()
    {
        Name = "Cage 1";

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

        EntryIdObjects.Add(188554);
HotSpots.Add(new Vector3(3468.074 , -5116.113 , 236.8651 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(2, 12180);
}



public override bool HasQuest() { return true; }


}


public sealed class Cage2 : QuestGathererClass
{
    public Cage2()
    {
        Name = "Cage 2";

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

        EntryIdObjects.Add(188554);
HotSpots.Add(new Vector3(3579.305 , -5125.142 , 167.1186 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 12180);
}



public override bool HasQuest() { return true; }


}


public sealed class Cage3 : QuestGathererClass
{
    public Cage3()
    {
        Name = "Cage 3";

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

        EntryIdObjects.Add(188554);
HotSpots.Add(new Vector3(3381.484 , -5100.912 , 326.5625 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(3, 12180);
}



public override bool HasQuest() { return true; }


}


public sealed class WhyFabricateWhenYouCanAppropriate : QuestGathererClass
{
    public WhyFabricateWhenYouCanAppropriate()
    {
        Name = "Why Fabricate When You Can Appropriate?";

        QuestId.AddRange(new[] { 12130 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188503);
HotSpots.Add(new Vector3(3444.5 , -5145.823 , 235.7882 , "None"));
HotSpots.Add(new Vector3(3459.299 , -5120.118 , 237.1884 , "None"));
HotSpots.Add(new Vector3(3527.192 , -5090.254 , 236.1076 , "None"));
HotSpots.Add(new Vector3(3525.857 , -5160.567 , 234.261 , "None"));
HotSpots.Add(new Vector3(3520.324 , -5086.153 , 238.2051 , "None"));
HotSpots.Add(new Vector3(3429.244 , -5013.987 , 279.7532 , "None"));
HotSpots.Add(new Vector3(3410.889 , -4972.043 , 285.2611 , "None"));
HotSpots.Add(new Vector3(3374.412 , -5053.318 , 326.1091 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LookingthePart : QuestGrinderClass
{
    public LookingthePart()
    {
        Name = "Looking the Part";

        QuestId.AddRange(new[] { 12183 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27177);
HotSpots.Add(new Vector3(3488.918 , -5107.724 , 236.845 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CultivatinganImage : QuestInteractWithClass
{
    public CultivatinganImage()
    {
        Name = "Cultivating an Image";

        QuestId.AddRange(new[] { 12184 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26414);
EntryIdTarget.Add(26408);
HotSpots.Add(new Vector3(3517.851 , -5123.994 , 233.6775 , "None"));
HotSpots.Add(new Vector3(3522.033 , -5111.431 , 233.7356 , "None"));
HotSpots.Add(new Vector3(3505.47 , -5212.75 , 245.4465 , "None"));
HotSpots.Add(new Vector3(3445.266 , -5193.24 , 270.4861 , "None"));
HotSpots.Add(new Vector3(3403.73 , -5410.23 , 267.8567 , "None"));
HotSpots.Add(new Vector3(3439.7 , -5143.72 , 235.788 , "None"));
HotSpots.Add(new Vector3(3542.92 , -5067.19 , 236.7091 , "None"));
HotSpots.Add(new Vector3(3516.19 , -5050.43 , 235.9162 , "None"));
HotSpots.Add(new Vector3(3364.25 , -4968.11 , 304.2957 , "None"));
HotSpots.Add(new Vector3(3377.278 , -4999.141 , 313.8253 , "None"));
HotSpots.Add(new Vector3(3384.46 , -5043.536 , 327.0819 , "None"));
HotSpots.Add(new Vector3(3354.67 , -5093.97 , 325.3047 , "None"));
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


public sealed class WeHavethePower : QuestGrinderClass
{
    public WeHavethePower()
    {
        Name = "We Have the Power";

        QuestId.AddRange(new[] { 12131 });

        Step = new List<int> { 1, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26410);
EntryTarget.Add(26409);
HotSpots.Add(new Vector3(3438.839 , -5143.798 , 238.998 , "None"));
HotSpots.Add(new Vector3(3524.7 , -5042.13 , 235.9156 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PutonYourBestFaceforLoken : QuestGathererClass
{
    public PutonYourBestFaceforLoken()
    {
        Name = "Put on Your Best Face for Loken";

        QuestId.AddRange(new[] { 12185 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188596);
HotSpots.Add(new Vector3(3408 , -5385.562 , 267.856 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class OrMaybeWeDont : QuestGrinderClass
{
    public OrMaybeWeDont()
    {
        Name = "... Or Maybe We Don't";

        QuestId.AddRange(new[] { 12138 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26407);
HotSpots.Add(new Vector3(3576.243 , -5253.851 , 151.3354 , "None"));
HotSpots.Add(new Vector3(3607.777 , -5226.901 , 153.7883 , "None"));
HotSpots.Add(new Vector3(3655.24 , -5180.24 , 142.9405 , "None"));
HotSpots.Add(new Vector3(3591.298 , -5194.195 , 163.7809 , "None"));
HotSpots.Add(new Vector3(3677.978 , -5139.968 , 145.9736 , "None"));
HotSpots.Add(new Vector3(3724.333 , -5074.587 , 127.9748 , "None"));
HotSpots.Add(new Vector3(3640.956 , -5004.462 , 177.1114 , "None"));
HotSpots.Add(new Vector3(3593.227 , -4959.468 , 185.5759 , "None"));
HotSpots.Add(new Vector3(3551.666 , -4977.423 , 206.8945 , "None"));
HotSpots.Add(new Vector3(3496.562 , -4938.63 , 225.504 , "None"));
HotSpots.Add(new Vector3(3506.529 , -4989.844 , 216.9747 , "None"));
HotSpots.Add(new Vector3(3470.333 , -5012.116 , 240.9108 , "None"));
HotSpots.Add(new Vector3(3427.921 , -4939.374 , 255.8734 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LokenP : QuestFollowPathClass
{
    public LokenP()
    {
        Name = "Loken P";

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

        Path.Add(new Vector3(3408 , -5385.562 , 267.856 , "None"));
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


public sealed class Blackout : QuestUseItemOnClass
{
    public Blackout()
    {
        Name = "Blackout";

        QuestId.AddRange(new[] { 12154 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3302.398 , -5124.94 , 297.884 , "None"));
ItemId = 36935;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheIronThaneandHisAnvil : QuestGrinderClass
{
    public TheIronThaneandHisAnvil()
    {
        Name = "The Iron Thane and His Anvil";

        QuestId.AddRange(new[] { 12153 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3302.398 , -5124.94 , 297.884 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}
