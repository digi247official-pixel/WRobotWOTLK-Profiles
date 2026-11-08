
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



public sealed class AFreeLunch : QuestClass
{
    public AFreeLunch()
    {
        Name = "A Free Lunch";

        QuestId.AddRange(new[] { 129 });

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


public sealed class AWatchfulEye : QuestClass
{
    public AWatchfulEye()
    {
        Name = "A Watchful Eye";

        QuestId.AddRange(new[] { 94 });

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


public sealed class AnUnwelcomeGuest : QuestGrinderClass
{
    public AnUnwelcomeGuest()
    {
        Name = "An Unwelcome Guest";

        QuestId.AddRange(new[] { 34 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(345);
HotSpots.Add(new Vector3(-9288.95 , -1911.28 , 74.803 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AssessingtheThreat : QuestGrinderClass
{
    public AssessingtheThreat()
    {
        Name = "Assessing the Threat";

        QuestId.AddRange(new[] { 246 });

        Step = new List<int> { 10, 6, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(423);
EntryTarget.Add(424);
HotSpots.Add(new Vector3(-9526.99 , -1885.205 , 75.68925 , "None"));
HotSpots.Add(new Vector3(-9500.44 , -1903.07 , 79.32554 , "None"));
HotSpots.Add(new Vector3(-9487.25 , -1934.2 , 78.92355 , "None"));
HotSpots.Add(new Vector3(-9726.943 , -2188.21 , 59.2024 , "None"));
HotSpots.Add(new Vector3(-9786.23 , -2206.33 , 58.64092 , "None"));
HotSpots.Add(new Vector3(-9794.47 , -2241.88 , 69.40854 , "None"));
HotSpots.Add(new Vector3(-9788.65 , -2338.09 , 80.46679 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BlackrockBounty : QuestGrinderClass
{
    public BlackrockBounty()
    {
        Name = "Blackrock Bounty";

        QuestId.AddRange(new[] { 128 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(435);
HotSpots.Add(new Vector3(-8677.435 , -2283.73 , 155.4649 , "None"));
HotSpots.Add(new Vector3(-8726.706 , -2220.636 , 150.5038 , "None"));
HotSpots.Add(new Vector3(-8764.91 , -2258.66 , 151.1862 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BlackrockMenace : QuestGrinderClass
{
    public BlackrockMenace()
    {
        Name = "Blackrock Menace";

        QuestId.AddRange(new[] { 20 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(437);
EntryTarget.Add(436);
EntryTarget.Add(4065);
HotSpots.Add(new Vector3(-9521.688 , -2867.35 , 90.84948 , "None"));
HotSpots.Add(new Vector3(-9387.881 , -3024.846 , 136.688 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Grind27 : QuestGrinderClass
{
    public Grind27()
    {
        Name = "Grind 27";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 23;
        MaxLevel = 26;
        RequiredQuest = 0;

        EntryTarget.Add(485);
EntryTarget.Add(4463);
EntryTarget.Add(440);
HotSpots.Add(new Vector3(-9686.17 , -3088.98 , 53.94139 , "None"));
HotSpots.Add(new Vector3(-9734.4 , -3142.29 , 58.84855 , "None"));
HotSpots.Add(new Vector3(-9757.48 , -3140.41 , 58.82954 , "None"));
HotSpots.Add(new Vector3(-9756.7 , -3196.37 , 58.60955 , "None"));
HotSpots.Add(new Vector3(-9789.736 , -3202.358 , 58.60723 , "None"));
HotSpots.Add(new Vector3(-9800.33 , -3220.85 , 59.02044 , "None"));
HotSpots.Add(new Vector3(-9772.561 , -3212.482 , 58.60723 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HilarysNecklace : QuestGathererClass
{
    public HilarysNecklace()
    {
        Name = "Hilary's Necklace";

        QuestId.AddRange(new[] { 3741 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(154357);
HotSpots.Add(new Vector3(-9324.878 , -1989.095 , 43.52174 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LookingFurther : QuestClass
{
    public LookingFurther()
    {
        Name = "Looking Further";

        QuestId.AddRange(new[] { 248 });

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


public sealed class MessengertoStormwind1 : QuestClass
{
    public MessengertoStormwind1()
    {
        Name = "Messenger to Stormwind1";

        QuestId.AddRange(new[] { 120 });

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


public sealed class MessengertoStormwind2 : QuestClass
{
    public MessengertoStormwind2()
    {
        Name = "Messenger to Stormwind2";

        QuestId.AddRange(new[] { 121 });

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


public sealed class Missing : QuestFollowNpcClass
{
    public Missing()
    {
        Name = "Missing";

        QuestId.AddRange(new[] { 219 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        StartPosition = new Vector3(-8758.252 , -2188.584 , 139.8081 , "None");
NpcEntry = 349;
Assist = true;
FollowDistance = 5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MissingInAction : QuestFollowNpcClass
{
    public MissingInAction()
    {
        Name = "Missing In Action";

        QuestId.AddRange(new[] { 219 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        StartPosition = new Vector3(-8756.77 , -2187.12 , 139.794 , "None");
NpcEntry = 349;
Assist = true;
FollowDistance = 5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MurlocPoachers : QuestGrinderClass
{
    public MurlocPoachers()
    {
        Name = "Murloc Poachers";

        QuestId.AddRange(new[] { 150 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(578);
EntryTarget.Add(422);
EntryTarget.Add(548);
EntryTarget.Add(1083);
HotSpots.Add(new Vector3(-9247.6 , -2457.275 , 55.22992 , "None"));
HotSpots.Add(new Vector3(-9550.842 , -2618.475 , 54.6192 , "Swimming"));
HotSpots.Add(new Vector3(-9521.19 , -2823.86 , 79.66779 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(1468) >= 8;
}






}


public sealed class SellingFish : QuestGrinderClass
{
    public SellingFish()
    {
        Name = "Selling Fish";

        QuestId.AddRange(new[] { 127 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(578);
EntryTarget.Add(422);
EntryTarget.Add(548);
EntryTarget.Add(1083);
HotSpots.Add(new Vector3(-9286.926 , -2427.996 , 55.0042 , "None"));
HotSpots.Add(new Vector3(-9226.94 , -2442.88 , 55.77864 , "None"));
HotSpots.Add(new Vector3(-9550.842 , -2618.475 , 54.6192 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(1467) >= 10;
}






}


public sealed class ShadowMagic : QuestGrinderClass
{
    public ShadowMagic()
    {
        Name = "Shadow Magic";

        QuestId.AddRange(new[] { 115 });

        Step = new List<int> { 3, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(436);
HotSpots.Add(new Vector3(-9387.217 , -3026.329 , 136.6872 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SolomonsLaw : QuestGrinderClass
{
    public SolomonsLaw()
    {
        Name = "Solomon's Law";

        QuestId.AddRange(new[] { 91 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(433);
EntryTarget.Add(432);
EntryTarget.Add(434);
HotSpots.Add(new Vector3(-9371.312 , -3146.802 , 86.74325 , "None"));
HotSpots.Add(new Vector3(-9368.08 , -3154.996 , 86.48449 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Tharilzun : QuestGrinderClass
{
    public Tharilzun()
    {
        Name = "Tharil'zun";

        QuestId.AddRange(new[] { 19 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(486);
HotSpots.Add(new Vector3(-9442.19 , -3074.29 , 136.676 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(1260) >= 1;
}






}


public sealed class TheDefiasBrotherhood1 : QuestClass
{
    public TheDefiasBrotherhood1()
    {
        Name = "The Defias Brotherhood1";

        QuestId.AddRange(new[] { 65 });

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


public sealed class TheDefiasBrotherhood2 : QuestClass
{
    public TheDefiasBrotherhood2()
    {
        Name = "The Defias Brotherhood2";

        QuestId.AddRange(new[] { 132 });

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


public sealed class TheDefiasBrotherhood3 : QuestClass
{
    public TheDefiasBrotherhood3()
    {
        Name = "The Defias Brotherhood3";

        QuestId.AddRange(new[] { 135 });

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


public sealed class TheDefiasBrotherhood4 : QuestClass
{
    public TheDefiasBrotherhood4()
    {
        Name = "The Defias Brotherhood4";

        QuestId.AddRange(new[] { 141 });

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


public sealed class TheEverstillBridge : QuestGrinderClass
{
    public TheEverstillBridge()
    {
        Name = "The Everstill Bridge";

        QuestId.AddRange(new[] { 89 });

        Step = new List<int> { 5, 5, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(426);
EntryTarget.Add(430);
EntryTarget.Add(446);
HotSpots.Add(new Vector3(-9038.051 , -2455.211 , 134.6438 , "None"));
HotSpots.Add(new Vector3(-8980.15 , -2337.88 , 132.4483 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheLostTools : QuestGathererClass
{
    public TheLostTools()
    {
        Name = "The Lost Tools";

        QuestId.AddRange(new[] { 125 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(32);
HotSpots.Add(new Vector3(-9366.308 , -2473.59 , 16.81989 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThePriceofShoes : QuestClass
{
    public ThePriceofShoes()
    {
        Name = "The Price of Shoes";

        QuestId.AddRange(new[] { 118 });

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


public sealed class TheocritusRetrieval : QuestClass
{
    public TheocritusRetrieval()
    {
        Name = "Theocritus' Retrieval";

        QuestId.AddRange(new[] { 178 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 1962;

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


public sealed class TheocritusRetrieval1 : QuestGrinderClass
{
    public TheocritusRetrieval1()
    {
        Name = "TheocritusRetrieval1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(568);
EntryTarget.Add(432);
EntryTarget.Add(433);
EntryTarget.Add(429);
HotSpots.Add(new Vector3(-9138.18 , -3196.13 , 107.3936 , "None"));
HotSpots.Add(new Vector3(-9227.928 , -3235.59 , 101.4638 , "None"));
HotSpots.Add(new Vector3(-9141.729 , -3266.6 , 101.8966 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(1962) <= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class VisittheHerbalist : QuestClass
{
    public VisittheHerbalist()
    {
        Name = "Visit the Herbalist";

        QuestId.AddRange(new[] { 130 });

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


public sealed class WantedGathIlzogg : QuestGrinderClass
{
    public WantedGathIlzogg()
    {
        Name = "Wanted: Gath'Ilzogg";

        QuestId.AddRange(new[] { 169 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(334);
HotSpots.Add(new Vector3(-9386.304 , -3069.727 , 156.7786 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(3633) >= 1;
}






}


public sealed class WantedLieutenantFangore : QuestGrinderClass
{
    public WantedLieutenantFangore()
    {
        Name = "Wanted: Lieutenant Fangore";

        QuestId.AddRange(new[] { 180 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(703);
HotSpots.Add(new Vector3(-9112.404 , -3313.687 , 102.1305 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WhatComesAround : QuestGrinderClass
{
    public WhatComesAround()
    {
        Name = "What Comes Around...";

        QuestId.AddRange(new[] { 386 });

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
