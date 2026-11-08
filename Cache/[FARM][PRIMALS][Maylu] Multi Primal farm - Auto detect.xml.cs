
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



public sealed class SMVAirEles : QuestGrinderClass
{
    public SMVAirEles()
    {
        Name = "SMV - Air Eles";

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

        EntryTarget.Add(21060);
HotSpots.Add(new Vector3(-4508.692 , 1057.655 , 15.95327 , "None"));
HotSpots.Add(new Vector3(-4352.814 , 985.0887 , 43.87105 , "None"));
HotSpots.Add(new Vector3(-4344.894 , 824.6222 , 13.80856 , "None"));
HotSpots.Add(new Vector3(-4213.356 , 796.8143 , 18.84974 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class NagrandhalaaWaterEles : QuestGrinderClass
{
    public NagrandhalaaWaterEles()
    {
        Name = "Nagrand - (halaa) Water Eles";

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

        EntryTarget.Add(17154);
HotSpots.Add(new Vector3(-1336.096 , 7998.209 , -99.44376 , "None"));
HotSpots.Add(new Vector3(-1594.677 , 8101.386 , -102.1533 , "None"));
HotSpots.Add(new Vector3(-1777.669 , 7863.88 , -101.3575 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class BEMSkaldFireEles : QuestGrinderClass
{
    public BEMSkaldFireEles()
    {
        Name = "BEM - Skald - Fire Eles";

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

        EntryTarget.Add(20514);
EntryTarget.Add(21021);
HotSpots.Add(new Vector3(3618.694 , 4956.407 , 267.3079 , "None"));
HotSpots.Add(new Vector3(3728.425 , 4973.779 , 275.619 , "None"));
HotSpots.Add(new Vector3(3719.161 , 4811.708 , 250.7279 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class NetherstormManaEles : QuestGrinderClass
{
    public NetherstormManaEles()
    {
        Name = "Netherstorm - Mana Eles";

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

        EntryTarget.Add(18867);
EntryTarget.Add(18866);
HotSpots.Add(new Vector3(2274.045 , 2314.482 , 100.6128 , "None"));
HotSpots.Add(new Vector3(2193.385 , 2438.647 , 107.9406 , "None"));
HotSpots.Add(new Vector3(2120.625 , 2352.783 , 67.1455 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class ZangarLifeEles : QuestGrinderClass
{
    public ZangarLifeEles()
    {
        Name = "Zangar - Life Eles";

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

        EntryTarget.Add(18127);
EntryTarget.Add(18125);
HotSpots.Add(new Vector3(-131.7167 , 8049.743 , 18.99269 , "None"));
HotSpots.Add(new Vector3(-184.9974 , 7907.102 , 20.29399 , "None"));
HotSpots.Add(new Vector3(-273.3262 , 8055.591 , 19.4153 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}
