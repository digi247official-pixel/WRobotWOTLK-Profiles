
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
HotSpots.Add(new Vector3(4529.063 , -424.1348 , 81.0825 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(36855) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class DisturbingImplications : QuestClass
{
    public DisturbingImplications()
    {
        Name = "Disturbing Implications";

        QuestId.AddRange(new[] { 12146 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 36855;

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


public sealed class OneofaKind : QuestGrinderClass
{
    public OneofaKind()
    {
        Name = "One of a Kind";

        QuestId.AddRange(new[] { 12148 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27006);
HotSpots.Add(new Vector3(3327.316 , 732.6764 , 89.74254 , "None"));
HotSpots.Add(new Vector3(3400.559 , 863.8686 , 55.39355 , "None"));
HotSpots.Add(new Vector3(3332.113 , 804.6628 , 55.36413 , "None"));
HotSpots.Add(new Vector3(3269.647 , 695.4613 , 57.08076 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MightyMagnataur : QuestGrinderClass
{
    public MightyMagnataur()
    {
        Name = "Mighty Magnataur";

        QuestId.AddRange(new[] { 12149 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27008);
EntryTarget.Add(27007);
EntryTarget.Add(27009);
HotSpots.Add(new Vector3(2940.961 , -162.5057 , 95.20906 , "None"));
HotSpots.Add(new Vector3(3677.846 , -247.4238 , 66.049 , "None"));
HotSpots.Add(new Vector3(4125.589 , -173.6682 , 57.91661 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReclusiveRunemaster : QuestGrinderClass
{
    public ReclusiveRunemaster()
    {
        Name = "Reclusive Runemaster";

        QuestId.AddRange(new[] { 12150 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27003);
HotSpots.Add(new Vector3(3717.16 , -453.423 , 161.2523 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WantonWarlord : QuestUseItemOnClass
{
    public WantonWarlord()
    {
        Name = "Wanton Warlord";

        QuestId.AddRange(new[] { 12151 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(2722.919 , 426.0631 , 67.05073 , "None"));
ItemId = 36864;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}
