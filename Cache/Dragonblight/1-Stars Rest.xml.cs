
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


public sealed class TheMagicalKingdomofDalaran : QuestClass
{
    public TheMagicalKingdomofDalaran()
    {
        Name = "The Magical Kingdom of Dalaran";

        QuestId.AddRange(new[] { 12794 });

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


public sealed class TheLiquidFireofElune : QuestClass
{
    public TheLiquidFireofElune()
    {
        Name = "The Liquid Fire of Elune";

        QuestId.AddRange(new[] { 12166 });

        Step = new List<int> { 6, 6, 0, 0, 0 };

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


public sealed class AvengethisAtrocity : QuestGrinderClass
{
    public AvengethisAtrocity()
    {
        Name = "Avenge this Atrocity!";

        QuestId.AddRange(new[] { 12006 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26816);
EntryTarget.Add(26281);
EntryTarget.Add(26280);
EntryTarget.Add(26762);
HotSpots.Add(new Vector3(3183.25 , 2315.09 , 4.449746 , "None"));
HotSpots.Add(new Vector3(3157.335 , 2321.537 , 9.957159 , "None"));
HotSpots.Add(new Vector3(3161.32 , 2279.92 , 18.53932 , "None"));
HotSpots.Add(new Vector3(3148.14 , 2244.39 , 5.003128 , "None"));
HotSpots.Add(new Vector3(3108.922 , 2283.792 , 6.668377 , "None"));
HotSpots.Add(new Vector3(3123.61 , 2230.42 , 17.52231 , "None"));
HotSpots.Add(new Vector3(3134.59 , 2205.85 , 17.66846 , "None"));
HotSpots.Add(new Vector3(3138.13 , 2178.02 , 23.75639 , "None"));
HotSpots.Add(new Vector3(3149.37 , 2151.22 , 24.5547 , "None"));
HotSpots.Add(new Vector3(3111.75 , 2150.37 , 19.96632 , "None"));
HotSpots.Add(new Vector3(3095.39 , 2129.27 , 22.21997 , "None"));
HotSpots.Add(new Vector3(3103.91 , 2074.72 , 22.06548 , "None"));
HotSpots.Add(new Vector3(3104.12 , 2091.17 , 30.93494 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class EmmyMalin : QuestGrinderClass
{
    public EmmyMalin()
    {
        Name = "Emmy Malin";

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

        EntryTarget.Add(26762);
HotSpots.Add(new Vector3(3149.37 , 2151.22 , 24.63345 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(36756) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class ALetterforHome : QuestClass
{
    public ALetterforHome()
    {
        Name = "A Letter for Home";

        QuestId.AddRange(new[] { 12067 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 36756;

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


public sealed class EndArcanimus : QuestGrinderClass
{
    public EndArcanimus()
    {
        Name = "End Arcanimus";

        QuestId.AddRange(new[] { 12013 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26370);
HotSpots.Add(new Vector3(3338.948 , 2498.006 , -16.33462 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KilltheCultists : QuestGrinderClass
{
    public KilltheCultists()
    {
        Name = "Kill the Cultists";

        QuestId.AddRange(new[] { 12167 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26319);
HotSpots.Add(new Vector3(4040.351 , 2129.982 , 151.3716 , "None"));
HotSpots.Add(new Vector3(4052.334 , 2111.313 , 153.4818 , "None"));
HotSpots.Add(new Vector3(3947.74 , 2159.613 , 156.1711 , "None"));
HotSpots.Add(new Vector3(3946.935 , 2226.33 , 157.2424 , "None"));
HotSpots.Add(new Vector3(3936.567 , 2288.626 , 155.993 , "None"));
HotSpots.Add(new Vector3(3919.258 , 2287.307 , 155.876 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HighCommanderHalfordWyrmbane : QuestClass
{
    public HighCommanderHalfordWyrmbane()
    {
        Name = "High Commander Halford Wyrmbane";

        QuestId.AddRange(new[] { 12298, 12174 });

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


public sealed class TheFavorofZangus : QuestClass
{
    public TheFavorofZangus()
    {
        Name = "The Favor of Zangus";

        QuestId.AddRange(new[] { 12168 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 36958;

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


public sealed class TheHighCultist : QuestGrinderClass
{
    public TheHighCultist()
    {
        Name = "The High Cultist";

        QuestId.AddRange(new[] { 12169 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26655);
HotSpots.Add(new Vector3(3715.42 , 2007.22 , 22.382 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LearningtoLeaveandReturntheMagicalWay : QuestGathererClass
{
    public LearningtoLeaveandReturntheMagicalWay()
    {
        Name = "Learning to Leave and Return: the Magical Way";

        QuestId.AddRange(new[] { 12790 });

        Step = new List<int> { 1, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(191230);
HotSpots.Add(new Vector3(5729.796 , 1012.89 , 174.48 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DalaStone : QuestGathererClass
{
    public DalaStone()
    {
        Name = "Dala Stone";

        QuestId.AddRange(new[] { 12790 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(191229);
HotSpots.Add(new Vector3(5808.546 , 587.9744 , 652.3804 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 12790);
}



public override bool HasQuest() { return true; }


}


public sealed class OfTraitorsandTreason : QuestClass
{
    public OfTraitorsandTreason()
    {
        Name = "Of Traitors and Treason";

        QuestId.AddRange(new[] { 12171 });

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
