
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


public sealed class ItTakesGuts : QuestGathererClass
{
    public ItTakesGuts()
    {
        Name = "It Takes Guts....";

        QuestId.AddRange(new[] { 12116 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188499);
HotSpots.Add(new Vector3(4778.643 , -4864.257 , 26.64961 , "None"));
HotSpots.Add(new Vector3(4784.274 , -4869.484 , 26.55042 , "None"));
HotSpots.Add(new Vector3(4803.9 , -4879.6 , 25.88343 , "None"));
HotSpots.Add(new Vector3(4807.862 , -4873.444 , 25.9082 , "None"));
HotSpots.Add(new Vector3(4818.075 , -4861.685 , 25.91771 , "None"));
HotSpots.Add(new Vector3(4846.636 , -4831.276 , 26.12474 , "None"));
HotSpots.Add(new Vector3(4852.286 , -4824.679 , 25.94766 , "None"));
HotSpots.Add(new Vector3(4844.786 , -4812.757 , 26.07046 , "None"));
HotSpots.Add(new Vector3(4832.951 , -4801.368 , 26.12343 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Therapy : QuestGrinderClass
{
    public Therapy()
    {
        Name = "Therapy";

        QuestId.AddRange(new[] { 12114 });

        Step = new List<int> { 10, 10, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26795);
EntryTarget.Add(26919);
EntryTarget.Add(26797);
HotSpots.Add(new Vector3(4448.52 , -4904.343 , 20.10596 , "None"));
HotSpots.Add(new Vector3(4473.245 , -4885.601 , 25.31012 , "None"));
HotSpots.Add(new Vector3(4479.051 , -4895.744 , 23.77939 , "None"));
HotSpots.Add(new Vector3(4476.988 , -4987.797 , 7.56354 , "None"));
HotSpots.Add(new Vector3(4478.94 , -5017.4 , 0.1649749 , "None"));
HotSpots.Add(new Vector3(4570.917 , -4865.775 , 47.99238 , "None"));
HotSpots.Add(new Vector3(4558.07 , -4793.71 , 50.3106 , "None"));
HotSpots.Add(new Vector3(4597.87 , -4763.41 , 49.50858 , "None"));
HotSpots.Add(new Vector3(4625.969 , -4793.035 , 47.99237 , "None"));
HotSpots.Add(new Vector3(4690.29 , -4796.18 , 47.99275 , "None"));
HotSpots.Add(new Vector3(4729.718 , -4894.52 , 49.05213 , "None"));
HotSpots.Add(new Vector3(4689.97 , -4995.982 , 42.90927 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class NicetoMeatYou : QuestGrinderClass
{
    public NicetoMeatYou()
    {
        Name = "Nice to Meat You";

        QuestId.AddRange(new[] { 12113 });

        Step = new List<int> { 10, 10, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27408);
EntryTarget.Add(26418);
HotSpots.Add(new Vector3(4374.036 , -4912.712 , 32.15171 , "None"));
HotSpots.Add(new Vector3(4387.436 , -4920.164 , 30.49535 , "None"));
HotSpots.Add(new Vector3(4354.478 , -4896.87 , 33.8532 , "None"));
HotSpots.Add(new Vector3(4355.26 , -4857.69 , 37.54319 , "None"));
HotSpots.Add(new Vector3(4341.869 , -4841.172 , 38.95715 , "None"));
HotSpots.Add(new Vector3(4290.033 , -4842.446 , 39.27657 , "None"));
HotSpots.Add(new Vector3(4211.689 , -4812.986 , 55.06041 , "None"));
HotSpots.Add(new Vector3(4207.832 , -4775.525 , 64.52351 , "None"));
HotSpots.Add(new Vector3(4219.653 , -4749.984 , 71.16911 , "None"));
HotSpots.Add(new Vector3(4231.03 , -4712.101 , 77.89249 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DrakaguulsMallet : QuestGrinderClass
{
    public DrakaguulsMallet()
    {
        Name = "Drak'aguul's Mallet";

        QuestId.AddRange(new[] { 12120 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26919);
HotSpots.Add(new Vector3(4474.562 , -4865.612 , 25.3093 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SeeYouontheOtherSide : QuestUseItemOnClass
{
    public SeeYouontheOtherSide()
    {
        Name = "See You on the Other Side";

        QuestId.AddRange(new[] { 12121 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(4663.363 , -4859.149 , 35.48021 , "None"));
ItemId = 36834;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ChillOutMon : QuestUseItemOnClass
{
    public ChillOutMon()
    {
        Name = "Chill Out, Mon";

        QuestId.AddRange(new[] { 12137 });

        Step = new List<int> { 1, 5, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26811);
EntryIdTarget.Add(26812);
HotSpots.Add(new Vector3(4802.175 , -4801.747 , 25.58915 , "None"));
HotSpots.Add(new Vector3(4848.124 , -4821.602 , 25.61216 , "None"));
HotSpots.Add(new Vector3(4825.709 , -4835.934 , 25.46932 , "None"));
HotSpots.Add(new Vector3(4798.543 , -4847.514 , 25.49679 , "None"));
HotSpots.Add(new Vector3(4795.167 , -4870.424 , 25.75309 , "None"));
HotSpots.Add(new Vector3(4762.366 , -4834.174 , 25.53031 , "None"));
HotSpots.Add(new Vector3(4762.776 , -4820.409 , 25.90254 , "None"));
ItemId = 36859;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SacredDrakkariOffering : QuestGathererClass
{
    public SacredDrakkariOffering()
    {
        Name = "Sacred Drakkari Offering";

        QuestId.AddRange(new[] { 12152 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188530);
HotSpots.Add(new Vector3(4827.533 , -4849.487 , 25.47058 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(36870) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class DundaDuntah : QuestClass
{
    public DundaDuntah()
    {
        Name = "Dun-da-Dun-tah!";

        QuestId.AddRange(new[] { 12082 });

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


public sealed class Chest : QuestGathererClass
{
    public Chest()
    {
        Name = "Chest";

        QuestId.AddRange(new[] { 12137 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188518);
HotSpots.Add(new Vector3(4833.445 , -4752.564 , 32.42848 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 12137);
}



public override bool HasQuest() { return true; }


}


public sealed class JinarraksEnd : QuestUseItemOnClass
{
    public JinarraksEnd()
    {
        Name = "Jin'arrak's End";

        QuestId.AddRange(new[] { 12152 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(4653.438 , -4866.943 , 35.4803 , "None"));
ItemId = 37063;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Infused : QuestClass
{
    public Infused()
    {
        Name = "Infused";

        QuestId.AddRange(new[] { 37063 });

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
return ItemsManager.GetItemCountById(37063) >= 1;
}






}
