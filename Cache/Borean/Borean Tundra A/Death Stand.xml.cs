
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



public sealed class FindingthePhylactery1 : QuestFollowPathClass
{
    public FindingthePhylactery1()
    {
        Name = "Finding the Phylactery1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(3615.35 , 3646.094 , 24.44311 , "Swimming"));
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


public sealed class FindingthePhylactery : QuestGrinderClass
{
    public FindingthePhylactery()
    {
        Name = "Finding the Phylactery";

        QuestId.AddRange(new[] { 11956 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26225);
HotSpots.Add(new Vector3(3617.139 , 3648.6 , 24.22073 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BuyingSomeTime : QuestGrinderClass
{
    public BuyingSomeTime()
    {
        Name = "Buying Some Time";

        QuestId.AddRange(new[] { 11938 });

        Step = new List<int> { 20, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25393);
EntryTarget.Add(25383);
EntryTarget.Add(25386);
HotSpots.Add(new Vector3(3650.969 , 3715.416 , 45.83693 , "None"));
HotSpots.Add(new Vector3(3820.145 , 3659.441 , 46.36835 , "None"));
HotSpots.Add(new Vector3(3867.664 , 3618.299 , 46.98124 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WordsofPower : QuestGrinderClass
{
    public WordsofPower()
    {
        Name = "Words of Power";

        QuestId.AddRange(new[] { 11942 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { false, false, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25378);
EntryTarget.Add(26076);
EntryTarget.Add(25392);
EntryTarget.Add(25422);
EntryTarget.Add(26073);
HotSpots.Add(new Vector3(4122.239 , 3709.781 , 92.66574 , "None"));
HotSpots.Add(new Vector3(4133.34 , 3743.31 , 92.6702 , "None"));
HotSpots.Add(new Vector3(4101.93 , 3761.12 , 92.6647 , "None"));
HotSpots.Add(new Vector3(4111.34 , 3735.04 , 91.76582 , "None"));
HotSpots.Add(new Vector3(4093.01 , 3495.03 , 131.6672 , "None"));
HotSpots.Add(new Vector3(3791.1 , 3411.64 , 85.0317 , "None"));
HotSpots.Add(new Vector3(3779.65 , 3417.63 , 85.03088 , "None"));
HotSpots.Add(new Vector3(3790.408 , 3421.688 , 85.01455 , "None"));
HotSpots.Add(new Vector3(3791.1 , 3411.64 , 85.0317 , "None"));
HotSpots.Add(new Vector3(3779.65 , 3417.63 , 85.03088 , "None"));
HotSpots.Add(new Vector3(3786.346 , 3418.399 , 85.03382 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LastRites : QuestGrinderClass
{
    public LastRites()
    {
        Name = "Last Rites";

        QuestId.AddRange(new[] { 12019 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3709.891 , 3572.806 , 477.4433 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Teleport1 : QuestFollowPathClass
{
    public Teleport1()
    {
        Name = "Teleport 1";

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

        Path.Add(new Vector3(3801.744 , 3586.361 , 49.51417 , "None"));
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


public sealed class Teleport2 : QuestFollowPathClass
{
    public Teleport2()
    {
        Name = "Teleport 2";

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

        Path.Add(new Vector3(3719.947 , 3569.744 , 294.731 , "None"));
Path.Add(new Vector3(3724.233 , 3569.566 , 295.9835 , "None"));
Path.Add(new Vector3(3728.386 , 3569.296 , 297.5222 , "None"));
Path.Add(new Vector3(3732.327 , 3568.632 , 298.5192 , "None"));
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


public sealed class TheLostCourier : QuestClass
{
    public TheLostCourier()
    {
        Name = "The Lost Courier";

        QuestId.AddRange(new[] { 12157 });

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
