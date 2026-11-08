
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



public sealed class AVisittotheCurator : QuestGrinderClass
{
    public AVisittotheCurator()
    {
        Name = "A Visit to the Curator";

        QuestId.AddRange(new[] { 11623 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25448);
HotSpots.Add(new Vector3(3646.87 , 5676.2 , 66.243 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Elder : QuestFollowPathClass
{
    public Elder()
    {
        Name = "Elder";

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

        Path.Add(new Vector3(3522.827 , 5417.313 , 41.03947 , "None"));
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


public sealed class HamperingTheirEscape : QuestClass
{
    public HamperingTheirEscape()
    {
        Name = "Hampering Their Escape";

        QuestId.AddRange(new[] { 11617 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

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


public sealed class LeadingtheAncestorsHome : QuestUseItemOnClass
{
    public LeadingtheAncestorsHome()
    {
        Name = "Leading the Ancestors Home";

        QuestId.AddRange(new[] { 11610 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(25398);
EntryIdTarget.Add(25399);
EntryIdTarget.Add(25397);
HotSpots.Add(new Vector3(3567.32 , 5505.58 , 27.012 , "None"));
HotSpots.Add(new Vector3(3683.96 , 5569.8 , 34.8291 , "None"));
HotSpots.Add(new Vector3(3643.49 , 5634.1 , 34.58552 , "None"));
ItemId = 34715;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PickingUpthePieces : QuestGathererClass
{
    public PickingUpthePieces()
    {
        Name = "Picking Up the Pieces";

        QuestId.AddRange(new[] { 11609 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(187671);
HotSpots.Add(new Vector3(3586.844 , 5486.615 , 27.77109 , "None"));
HotSpots.Add(new Vector3(3617.448 , 5548.409 , 27.70325 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReclaimingtheQuarry : QuestGrinderClass
{
    public ReclaimingtheQuarry()
    {
        Name = "Reclaiming the Quarry";

        QuestId.AddRange(new[] { 11612 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25353);
HotSpots.Add(new Vector3(3545.454 , 5425.878 , 40.46927 , "None"));
HotSpots.Add(new Vector3(3585.83 , 5452.683 , 38.12481 , "None"));
HotSpots.Add(new Vector3(3549.015 , 5430.367 , 39.45744 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheHonoredAncestors : QuestClass
{
    public TheHonoredAncestors()
    {
        Name = "The Honored Ancestors";

        QuestId.AddRange(new[] { 11605 });

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


public sealed class TheLostSpirits : QuestClass
{
    public TheLostSpirits()
    {
        Name = "The Lost Spirits";

        QuestId.AddRange(new[] { 11607 });

        Step = new List<int> { 3, 3, 0, 0, 0 };

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


public sealed class Kesuk : QuestUseItemOnClass
{
    public Kesuk()
    {
        Name = "Kesuk";

        QuestId.AddRange(new[] { 11605 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3589.73 , 5525.151 , 26.93825 , "None"));
ItemId = 34715;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(2, 11610);
}



public override bool HasQuest() { return true; }


}


public sealed class Sagani : QuestUseItemOnClass
{
    public Sagani()
    {
        Name = "Sagani";

        QuestId.AddRange(new[] { 11605 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3652.768 , 5640.552 , 34.5863 , "None"));
ItemId = 34715;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 11610);
}



public override bool HasQuest() { return true; }


}


public sealed class Takret : QuestUseItemOnClass
{
    public Takret()
    {
        Name = "Takret";

        QuestId.AddRange(new[] { 11605 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3699.74 , 5555.604 , 35.37346 , "None"));
ItemId = 34715;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(3, 11610);
}



public override bool HasQuest() { return true; }


}
