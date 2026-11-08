
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



public sealed class ABearofanAppetite : QuestUseItemOnClass
{
    public ABearofanAppetite()
    {
        Name = "A Bear of an Appetite";

        QuestId.AddRange(new[] { 12279 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(4383.753 , -5343.705 , -1.4792 , "Swimming"));
HotSpots.Add(new Vector3(4343.11 , -5410.043 , -0.4975141 , "None"));
HotSpots.Add(new Vector3(4243.151 , -5371.076 , -0.5060087 , "None"));
HotSpots.Add(new Vector3(4247.638 , -5297.857 , -0.4153739 , "None"));
HotSpots.Add(new Vector3(4161.269 , -5314.261 , -1.056362 , "None"));
HotSpots.Add(new Vector3(4310.432 , -5076.292 , -1.446687 , "Swimming"));
HotSpots.Add(new Vector3(4242.12 , -5160.318 , -1.876665 , "Swimming"));
ItemId = 37542;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ANamefromthePast : QuestClass
{
    public ANamefromthePast()
    {
        Name = "A Name from the Past";

        QuestId.AddRange(new[] { 12160 });

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


public sealed class BrothersinBattle : QuestGrinderClass
{
    public BrothersinBattle()
    {
        Name = "Brothers in Battle";

        QuestId.AddRange(new[] { 12002 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26284);
HotSpots.Add(new Vector3(4663.917 , -4422.068 , 192.0495 , "None"));
HotSpots.Add(new Vector3(4687.077 , -4448.235 , 194.3574 , "None"));
HotSpots.Add(new Vector3(4678.865 , -4476.8 , 196.4379 , "None"));
HotSpots.Add(new Vector3(4741.686 , -4468.725 , 195.0846 , "None"));
HotSpots.Add(new Vector3(4739 , -4443.33 , 197.0473 , "None"));
HotSpots.Add(new Vector3(4769.143 , -4451.9 , 199.0378 , "None"));
HotSpots.Add(new Vector3(4717.865 , -4533.243 , 203.7075 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
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


public sealed class FindKurun : QuestClass
{
    public FindKurun()
    {
        Name = "Find Kurun!";

        QuestId.AddRange(new[] { 11981 });

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


public sealed class HollowstoneMine : QuestClass
{
    public HollowstoneMine()
    {
        Name = "Hollowstone Mine";

        QuestId.AddRange(new[] { 12158 });

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


public sealed class Kill : QuestGrinderClass
{
    public Kill()
    {
        Name = "Kill";

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

        EntryTarget.Add(26891);
HotSpots.Add(new Vector3(4712.909 , -3937.854 , 204.978 , "None"));
HotSpots.Add(new Vector3(4733.076 , -3923.455 , 199.5229 , "None"));
HotSpots.Add(new Vector3(4693.125 , -3936.978 , 208.1105 , "None"));
HotSpots.Add(new Vector3(4687.557 , -3930.919 , 209.0911 , "None"));
HotSpots.Add(new Vector3(4749.478 , -3939.918 , 199.7363 , "None"));
HotSpots.Add(new Vector3(4773.506 , -3937.307 , 194.903 , "None"));
HotSpots.Add(new Vector3(4824.641 , -3906.552 , 185.6656 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ObjectManager.GetWoWUnitByEntry(26891).Count == 0;
}



public override bool HasQuest() { return true; }


}


public sealed class MountingUp : QuestClass
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


public sealed class Page : QuestGathererClass
{
    public Page()
    {
        Name = "Page";

        QuestId.AddRange(new[] { 11986 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188262);
HotSpots.Add(new Vector3(4820.804 , -4488.068 , 198.9037 , "None"));
HotSpots.Add(new Vector3(4802.01 , -4491.62 , 198.7541 , "None"));
HotSpots.Add(new Vector3(4826.03 , -4506.396 , 201.1495 , "None"));
HotSpots.Add(new Vector3(4764.629 , -4494.776 , 196.4654 , "None"));
HotSpots.Add(new Vector3(4750.937 , -4513.737 , 200.2565 , "None"));
HotSpots.Add(new Vector3(4713.594 , -4495.23 , 196.9083 , "None"));
HotSpots.Add(new Vector3(4684.765 , -4508.63 , 196.9259 , "None"));
HotSpots.Add(new Vector3(4662.69 , -4521.126 , 201.879 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(35737) >= 8;
}



public override bool HasQuest() { return true; }


}


public sealed class Portable : QuestGrinderClass
{
    public Portable()
    {
        Name = "Portable";

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

        EntryTarget.Add(26522);
HotSpots.Add(new Vector3(4971.256 , -4651.976 , 211.4902 , "Swimming"));
HotSpots.Add(new Vector3(4974.068 , -4699.962 , 211.674 , "Swimming"));
HotSpots.Add(new Vector3(5002.137 , -4758.713 , 212.0064 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(35837) >= 1;
}



public override bool HasQuest() { return true; }


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


public sealed class SofteningtheBlow : QuestGrinderClass
{
    public SofteningtheBlow()
    {
        Name = "Softening the Blow";

        QuestId.AddRange(new[] { 11998 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

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


public sealed class SoulsatUnrest : QuestInteractWithClass
{
    public SoulsatUnrest()
    {
        Name = "Souls at Unrest";

        QuestId.AddRange(new[] { 12159 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26891);
HotSpots.Add(new Vector3(4733.091 , -3926.171 , 199.3477 , "None"));
HotSpots.Add(new Vector3(4711.822 , -3940.029 , 205.5243 , "None"));
HotSpots.Add(new Vector3(4694.516 , -3934.591 , 208.1428 , "None"));
HotSpots.Add(new Vector3(4688.483 , -3930.438 , 209.0246 , "None"));
HotSpots.Add(new Vector3(4745.408 , -3941.981 , 199.8797 , "None"));
HotSpots.Add(new Vector3(4773.34 , -3937.16 , 194.929 , "None"));
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

        Path.Add(new Vector3(5059.093 , -4823.87 , 219.4937 , "None"));
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


public sealed class SteadyasaRock : QuestGathererClass
{
    public SteadyasaRock()
    {
        Name = "Steady as a Rock?";

        QuestId.AddRange(new[] { 12014 });

        Step = new List<int> { 1, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188367);
HotSpots.Add(new Vector3(5059.093 , -4823.87 , 219.4937 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheDamagedJournal : QuestUseItemOnClass
{
    public TheDamagedJournal()
    {
        Name = "The Damaged Journal";

        QuestId.AddRange(new[] { 11986 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(4827.985 , -4486.762 , 199.3668 , "None"));
ItemId = 35739;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheFateofOrlond : QuestClass
{
    public TheFateofOrlond()
    {
        Name = "The Fate of Orlond";

        QuestId.AddRange(new[] { 12010 });

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


public sealed class TheRunicKeystone : QuestGrinderClass
{
    public TheRunicKeystone()
    {
        Name = "The Runic Keystone";

        QuestId.AddRange(new[] { 11988 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26268);
HotSpots.Add(new Vector3(4888.29 , -4550.037 , 210.9905 , "None"));
HotSpots.Add(new Vector3(4911.411 , -4569.291 , 219.5651 , "None"));
HotSpots.Add(new Vector3(4925.4 , -4556.63 , 219.5496 , "None"));
HotSpots.Add(new Vector3(4927.69 , -4576.82 , 219.5349 , "None"));
HotSpots.Add(new Vector3(4911.31 , -4613.84 , 219.51 , "None"));
HotSpots.Add(new Vector3(4943.368 , -4628.941 , 219.6719 , "None"));
HotSpots.Add(new Vector3(4992.79 , -4648.07 , 219.4726 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheRunicProphecies : QuestGathererClass
{
    public TheRunicProphecies()
    {
        Name = "The Runic Prophecies";

        QuestId.AddRange(new[] { 11993 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188289);
EntryIdObjects.Add(188288);
EntryIdObjects.Add(188264);
HotSpots.Add(new Vector3(4949.525 , -4707.405 , 219.6263 , "None"));
HotSpots.Add(new Vector3(5003.39 , -4794.838 , 219.6273 , "None"));
HotSpots.Add(new Vector3(5011.43 , -4732.48 , 219.6983 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class UncoveringtheTunnels : QuestUseItemOnClass
{
    public UncoveringtheTunnels()
    {
        Name = "Uncovering the Tunnels";

        QuestId.AddRange(new[] { 12003 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(4529.292 , -4441.599 , 186.3557 , "None"));
HotSpots.Add(new Vector3(4664.278 , -4607.245 , 208.7763 , "None"));
HotSpots.Add(new Vector3(4787.143 , -4401.971 , 199.0291 , "None"));
ItemId = 0;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class VoicesFromtheDust : QuestGathererClass
{
    public VoicesFromtheDust()
    {
        Name = "Voices From the Dust";

        QuestId.AddRange(new[] { 12068 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 5;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188461);
HotSpots.Add(new Vector3(4881.424 , -4753.447 , 27.61985 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}
