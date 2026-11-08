
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



public sealed class AnEndAndABeginning : QuestFollowNpcClass
{
    public AnEndAndABeginning()
    {
        Name = "An End And A Beginning";

        QuestId.AddRange(new[] { 12473 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        StartPosition = new Vector3(3681.807 , -917.9012 , 76.93134 , "None");
NpcEntry = 27857;
Assist = true;
FollowDistance = 10f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AudienceWithTheDragonQueen : QuestClass
{
    public AudienceWithTheDragonQueen()
    {
        Name = "Audience With The Dragon Queen";

        QuestId.AddRange(new[] { 12495 });

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


public sealed class CanyonChase : QuestGrinderClass
{
    public CanyonChase()
    {
        Name = "Canyon Chase";

        QuestId.AddRange(new[] { 12143 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27005);
HotSpots.Add(new Vector3(4649.875 , -193.145 , 76.03185 , "None"));
HotSpots.Add(new Vector3(4593.022 , -350.5484 , 83.78854 , "None"));
HotSpots.Add(new Vector3(4536.711 , -420.7296 , 81.09996 , "None"));
HotSpots.Add(new Vector3(4462.432 , -448.3078 , 78.50717 , "None"));
HotSpots.Add(new Vector3(4451.979 , -475.8505 , 83.40213 , "None"));
HotSpots.Add(new Vector3(4384.418 , -500.8148 , 82.46854 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ChasingIcestormThelzansPhylactery : QuestGathererClass
{
    public ChasingIcestormThelzansPhylactery()
    {
        Name = "Chasing Icestorm: Thel'zan's Phylactery";

        QuestId.AddRange(new[] { 12467 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(190127);
HotSpots.Add(new Vector3(4540.79 , 42.75035 , 80.66927 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Finality : QuestClass
{
    public Finality()
    {
        Name = "Finality";

        QuestId.AddRange(new[] { 12472 });

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


public sealed class Fly : QuestFollowPathClass
{
    public Fly()
    {
        Name = "Fly";

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

        Path.Add(new Vector3(4603.04 , 1409.209 , 194.72 , "None"));
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


public sealed class FlyFromWyrm : QuestFollowPathClass
{
    public FlyFromWyrm()
    {
        Name = "Fly From Wyrm";

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

        Path.Add(new Vector3(3645.853 , 251.1947 , 52.22783 , "None"));
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


public sealed class FrostWyrm : QuestUseItemOnClass
{
    public FrostWyrm()
    {
        Name = "Frost Wyrm";

        QuestId.AddRange(new[] { 12459 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26841);
HotSpots.Add(new Vector3(4468.818 , 750.9407 , 80.43453 , "None"));
ItemId = 37887;
Range = 25f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 12459);
}






}


public sealed class FrostmourneCavern : QuestUseItemOnClass
{
    public FrostmourneCavern()
    {
        Name = "Frostmourne Cavern";

        QuestId.AddRange(new[] { 12478 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(4816.929 , -583.9493 , 163.4309 , "None"));
ItemId = 37933;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GalakrondandtheScourge : QuestClass
{
    public GalakrondandtheScourge()
    {
        Name = "Galakrond and the Scourge";

        QuestId.AddRange(new[] { 12497 });

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


public sealed class Magnataur : QuestGrinderClass
{
    public Magnataur()
    {
        Name = "Magnataur";

        QuestId.AddRange(new[] { 12142 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26295);
HotSpots.Add(new Vector3(4316.099 , -226.9996 , 76.6473 , "None"));
HotSpots.Add(new Vector3(4460.768 , -261.7068 , 91.78635 , "None"));
HotSpots.Add(new Vector3(4515.249 , -428.6416 , 80.58369 , "None"));
HotSpots.Add(new Vector3(4425.767 , -498.1129 , 85.24719 , "None"));
HotSpots.Add(new Vector3(4048.015 , -19.00368 , 53.90801 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(2, 12142);
}



public override bool HasQuest() { return true; }


}


public sealed class MysteryoftheInfinite : QuestUseItemOnClass
{
    public MysteryoftheInfinite()
    {
        Name = "Mystery of the Infinite";

        QuestId.AddRange(new[] { 12470 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(4100.646 , -421.2919 , 125.2258 , "None"));
ItemId = 37923;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class OnRubyWings : QuestClass
{
    public OnRubyWings()
    {
        Name = "On Ruby Wings";

        QuestId.AddRange(new[] { 12498 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

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


public sealed class PestControl : QuestGrinderClass
{
    public PestControl()
    {
        Name = "Pest Control";

        QuestId.AddRange(new[] { 12142 });

        Step = new List<int> { 10, 3, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27278);
EntryTarget.Add(27279);
HotSpots.Add(new Vector3(4478.71 , -244.848 , 90.20757 , "None"));
HotSpots.Add(new Vector3(4357.079 , -314.3247 , 86.16134 , "None"));
HotSpots.Add(new Vector3(3983.242 , 8.757861 , 50.78361 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReturnToAngrathar : QuestClass
{
    public ReturnToAngrathar()
    {
        Name = "Return To Angrathar";

        QuestId.AddRange(new[] { 12499 });

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


public sealed class ReturntoSender : QuestClass
{
    public ReturntoSender()
    {
        Name = "Return to Sender";

        QuestId.AddRange(new[] { 12469 });

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


public sealed class Road : QuestFollowPathClass
{
    public Road()
    {
        Name = "Road";

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

        Path.Add(new Vector3(4305.086 , 793.4064 , 77.89118 , "None"));
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


public sealed class ThatWhichCreatesCanAlsoDestroy : QuestGrinderClass
{
    public ThatWhichCreatesCanAlsoDestroy()
    {
        Name = "That Which Creates Can Also Destroy";

        QuestId.AddRange(new[] { 12459 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

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


public sealed class ToFordragonHold : QuestClass
{
    public ToFordragonHold()
    {
        Name = "To Fordragon Hold!";

        QuestId.AddRange(new[] { 12474 });

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


public sealed class WyrmFly : QuestFollowPathClass
{
    public WyrmFly()
    {
        Name = "Wyrm Fly";

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

        Path.Add(new Vector3(3547.181 , 380.6184 , 52.22749 , "None"));
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


public sealed class Horn : QuestGrinderClass
{
    public Horn()
    {
        Name = "Horn";

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

        EntryTarget.Add(27005);
HotSpots.Add(new Vector3(4483.144 , -437.457 , 78.60229 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(36855) >= 1;
}






}
