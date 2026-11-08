
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



public sealed class JungleSecrets : QuestClass
{
    public JungleSecrets()
    {
        Name = "Jungle Secrets";

        QuestId.AddRange(new[] { 215 });

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


public sealed class BadMedicine : QuestClass
{
    public BadMedicine()
    {
        Name = "Bad Medicine";

        QuestId.AddRange(new[] { 204 });

        Step = new List<int> { 7, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

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


public sealed class TheSecondRebellion : QuestGrinderClass
{
    public TheSecondRebellion()
    {
        Name = "The Second Rebellion";

        QuestId.AddRange(new[] { 203 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(937);
HotSpots.Add(new Vector3(-11583.23 , -561.5098 , 28.66279 , "None"));
HotSpots.Add(new Vector3(-11579.5 , -594.973 , 28.09513 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KrazeksCookery : QuestClass
{
    public KrazeksCookery()
    {
        Name = "Krazek's Cookery";

        QuestId.AddRange(new[] { 210 });

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


public sealed class PantherMastery1 : QuestGrinderClass
{
    public PantherMastery1()
    {
        Name = "Panther Mastery1";

        QuestId.AddRange(new[] { 190 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(683);
HotSpots.Add(new Vector3(-11692.6 , -180.5202 , 36.74952 , "None"));
HotSpots.Add(new Vector3(-11741.74 , -219.2266 , 41.90736 , "None"));
HotSpots.Add(new Vector3(-11649.14 , -379.2832 , 17.13421 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TigerMastery1 : QuestGrinderClass
{
    public TigerMastery1()
    {
        Name = "Tiger Mastery1";

        QuestId.AddRange(new[] { 185 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(681);
HotSpots.Add(new Vector3(-11719.87 , -79.79688 , 9.575424 , "None"));
HotSpots.Add(new Vector3(-11777.88 , -163.7129 , 8.693993 , "None"));
HotSpots.Add(new Vector3(-11591.21 , -326.5759 , 37.59956 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RaptorMastery1 : QuestGrinderClass
{
    public RaptorMastery1()
    {
        Name = "Raptor Mastery1";

        QuestId.AddRange(new[] { 194 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(685);
HotSpots.Add(new Vector3(-11838.12 , 688.9824 , 44.59111 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BookieHerod : QuestClass
{
    public BookieHerod()
    {
        Name = "Bookie Herod";

        QuestId.AddRange(new[] { 200 });

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


public sealed class WelcometotheJungle : QuestClass
{
    public WelcometotheJungle()
    {
        Name = "Welcome to the Jungle";

        QuestId.AddRange(new[] { 583 });

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


public sealed class TheGreenHillsofStranglethorn : QuestClass
{
    public TheGreenHillsofStranglethorn()
    {
        Name = "The Green Hills of Stranglethorn";

        QuestId.AddRange(new[] { 338 });

        Step = new List<int> { 1, 1, 1, 1, 0 };

        StepAutoDetect = new[] { false, false, false, true, false };

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


public sealed class TigerMastery2 : QuestGrinderClass
{
    public TigerMastery2()
    {
        Name = "Tiger Mastery2";

        QuestId.AddRange(new[] { 186 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(682);
HotSpots.Add(new Vector3(-11553.61 , 275.4629 , 39.7915 , "None"));
HotSpots.Add(new Vector3(-11651.34 , 322.313 , 41.25534 , "None"));
HotSpots.Add(new Vector3(-11749.27 , 296.6587 , 17.56174 , "None"));
HotSpots.Add(new Vector3(-11817.56 , 285.0781 , 17.87057 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PantherMastery2 : QuestGrinderClass
{
    public PantherMastery2()
    {
        Name = "Panther Mastery2";

        QuestId.AddRange(new[] { 191 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(736);
HotSpots.Add(new Vector3(-11583.77 , 307.344 , 42.71172 , "None"));
HotSpots.Add(new Vector3(-11622.86 , 277.2637 , 42.7406 , "None"));
HotSpots.Add(new Vector3(-11647.51 , 250.9473 , 37.70525 , "None"));
HotSpots.Add(new Vector3(-11789.18 , 244.377 , 15.83067 , "None"));
HotSpots.Add(new Vector3(-11845.83 , 379.5762 , 41.79058 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RaptorMastery2 : QuestGrinderClass
{
    public RaptorMastery2()
    {
        Name = "Raptor Mastery2";

        QuestId.AddRange(new[] { 195 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(686);
HotSpots.Add(new Vector3(-11996.06 , -286.4023 , 29.89863 , "None"));
HotSpots.Add(new Vector3(-12215.96 , -262.3613 , 18.43169 , "None"));
HotSpots.Add(new Vector3(-12317 , -206.877 , 14.32384 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TigerMastery3 : QuestGrinderClass
{
    public TigerMastery3()
    {
        Name = "Tiger Mastery3";

        QuestId.AddRange(new[] { 187 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(1085);
HotSpots.Add(new Vector3(-11997.13 , 55.0332 , 6.716763 , "None"));
HotSpots.Add(new Vector3(-11989.69 , -11.42188 , 16.14669 , "None"));
HotSpots.Add(new Vector3(-12008.11 , -42.26989 , 16.14188 , "None"));
HotSpots.Add(new Vector3(-11853.99 , 187.1621 , 15.65202 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PantherMastery3 : QuestGrinderClass
{
    public PantherMastery3()
    {
        Name = "Panther Mastery3";

        QuestId.AddRange(new[] { 192 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(684);
HotSpots.Add(new Vector3(-12244.71 , -942.1335 , 42.25406 , "None"));
HotSpots.Add(new Vector3(-12248.58 , -987.7676 , 33.7169 , "None"));
HotSpots.Add(new Vector3(-12032.48 , -952.6292 , 42.28189 , "None"));
HotSpots.Add(new Vector3(-12042.52 , -878.2941 , 41.03225 , "None"));
HotSpots.Add(new Vector3(-12036.4 , -856.4003 , 38.68188 , "None"));
HotSpots.Add(new Vector3(-12108.78 , -879.8212 , 48.9733 , "None"));
HotSpots.Add(new Vector3(-12150.92 , -790.8691 , 25.57345 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RaptorMastery3 : QuestGrinderClass
{
    public RaptorMastery3()
    {
        Name = "Raptor Mastery3";

        QuestId.AddRange(new[] { 196 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(687);
HotSpots.Add(new Vector3(-12873.28 , 10.17578 , 17.81246 , "None"));
HotSpots.Add(new Vector3(-12824.84 , 7.454677 , 8.495524 , "None"));
HotSpots.Add(new Vector3(-12833.25 , 135.8555 , 18.28834 , "None"));
HotSpots.Add(new Vector3(-12905.31 , 185.0996 , 18.12489 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TigerMastery4 : QuestGrinderClass
{
    public TigerMastery4()
    {
        Name = "Tiger Mastery4";

        QuestId.AddRange(new[] { 188 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(729);
HotSpots.Add(new Vector3(-11908.5 , 165.374 , 41.40444 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PantherMastery4 : QuestGrinderClass
{
    public PantherMastery4()
    {
        Name = "Panther Mastery4";

        QuestId.AddRange(new[] { 193 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(728);
HotSpots.Add(new Vector3(-12190.03 , -929.493 , 33.44306 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RaptorMastery4 : QuestGrinderClass
{
    public RaptorMastery4()
    {
        Name = "Raptor Mastery4";

        QuestId.AddRange(new[] { 197 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(730);
HotSpots.Add(new Vector3(-13076.6 , 387.179 , 15.17367 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BadMedicine1 : QuestGathererClass
{
    public BadMedicine1()
    {
        Name = "Bad Medicine1";

        QuestId.AddRange(new[] { 204 });

        Step = new List<int> { 0, 1, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(263);
HotSpots.Add(new Vector3(-11572.04 , -592.939 , 27.92901 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(2634) >=1;
}



public override bool HasQuest() { return true; }


}


public sealed class BadMedicine2 : QuestGrinderClass
{
    public BadMedicine2()
    {
        Name = "Bad Medicine2";

        QuestId.AddRange(new[] { 204 });

        Step = new List<int> { 7, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(940);
HotSpots.Add(new Vector3(-11616.5 , -583.9043 , 26.3907 , "None"));
HotSpots.Add(new Vector3(-11585.4 , -615.933 , 28.3622 , "None"));
HotSpots.Add(new Vector3(-11566.5 , -593.847 , 28.161 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class TheHiddenKey : QuestClass
{
    public TheHiddenKey()
    {
        Name = "The Hidden Key";

        QuestId.AddRange(new[] { 328 });

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


public sealed class SpecialForces : QuestGrinderClass
{
    public SpecialForces()
    {
        Name = "Special Forces";

        QuestId.AddRange(new[] { 574 });

        Step = new List<int> { 10, 6, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(938);
EntryTarget.Add(941);
HotSpots.Add(new Vector3(-11476.64 , -775.3256 , 31.88225 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheSpyRevealed : QuestClass
{
    public TheSpyRevealed()
    {
        Name = "The Spy Revealed!";

        QuestId.AddRange(new[] { 329 });

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


public sealed class PatrolSchedules : QuestClass
{
    public PatrolSchedules()
    {
        Name = "Patrol Schedules";

        QuestId.AddRange(new[] { 330 });

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


public sealed class ColonelKurzen : QuestGrinderClass
{
    public ColonelKurzen()
    {
        Name = "Colonel Kurzen";

        QuestId.AddRange(new[] { 202 });

        Step = new List<int> { 6, 4, 1, 0, 0 };

        StepAutoDetect = new[] { false, false, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(939);
EntryTarget.Add(813);
EntryTarget.Add(978);
HotSpots.Add(new Vector3(-11502.73 , -924.8813 , 25.43988 , "None"));
HotSpots.Add(new Vector3(-11336.9 , -966.252 , 29.90921 , "None"));
HotSpots.Add(new Vector3(-11429.95 , -934.877 , 19.62888 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReporttoDoren : QuestClass
{
    public ReporttoDoren()
    {
        Name = "Report to Doren";

        QuestId.AddRange(new[] { 331 });

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


public sealed class SuppliestoPrivateThorsen : QuestClass
{
    public SuppliestoPrivateThorsen()
    {
        Name = "Supplies to Private Thorsen";

        QuestId.AddRange(new[] { 198 });

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


public sealed class TheHauntedIsle : QuestClass
{
    public TheHauntedIsle()
    {
        Name = "The Haunted Isle";

        QuestId.AddRange(new[] { 616 });

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


public sealed class InvestigatetheCamp : QuestClass
{
    public InvestigatetheCamp()
    {
        Name = "Investigate the Camp";

        QuestId.AddRange(new[] { 201 });

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


public sealed class FavorforKrazek1111111 : QuestGathererClass
{
    public FavorforKrazek1111111()
    {
        Name = "Favor for Krazek1111111";

        QuestId.AddRange(new[] { 627 });

        Step = new List<int> { 4, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(2653);
HotSpots.Add(new Vector3(-884.4332 , -3883.058 , 135.156 , "None"));
HotSpots.Add(new Vector3(-948.3661 , -3929.498 , 145.5405 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BloodscalpEars : QuestGrinderClass
{
    public BloodscalpEars()
    {
        Name = "Bloodscalp Ears";

        QuestId.AddRange(new[] { 189 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(694);
EntryTarget.Add(587);
EntryTarget.Add(702);
EntryTarget.Add(699);
EntryTarget.Add(588);
EntryTarget.Add(701);
HotSpots.Add(new Vector3(-11844.4 , 55.266 , 14.47752 , "None"));
HotSpots.Add(new Vector3(-11882.34 , 43.67188 , 22.49166 , "None"));
HotSpots.Add(new Vector3(-11719.35 , 229.4345 , 39.97992 , "None"));
HotSpots.Add(new Vector3(-11650.2 , 463.512 , 42.91344 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HostileTakeover : QuestGrinderClass
{
    public HostileTakeover()
    {
        Name = "Hostile Takeover";

        QuestId.AddRange(new[] { 213 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(1096);
HotSpots.Add(new Vector3(-12151.4 , -571.4356 , 12.99061 , "None"));
HotSpots.Add(new Vector3(-12119.95 , -560.7695 , 13.19056 , "None"));
HotSpots.Add(new Vector3(-12057.92 , -529.1753 , 11.51445 , "None"));
HotSpots.Add(new Vector3(-12043.14 , -617.0433 , 14.56668 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheStoneoftheTides : QuestFollowPathClass
{
    public TheStoneoftheTides()
    {
        Name = "The Stone of the Tides";

        QuestId.AddRange(new[] { 578 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-12087.28 , 863.8032 , 0.8921313 , "None"));
Path.Add(new Vector3(-12087.24 , 866.8168 , 0.9207854 , "None"));
Path.Add(new Vector3(-12087.17 , 871.5563 , 0.9456068 , "None"));
Path.Add(new Vector3(-12087.2 , 869.5989 , 0.9358006 , "None"));
Path.Add(new Vector3(-12087.23 , 867.3401 , 0.9257465 , "None"));
Path.Add(new Vector3(-12087.25 , 865.6843 , 0.9110285 , "None"));
Path.Add(new Vector3(-12083.36 , 863.4752 , -0.2279879 , "None"));
Path.Add(new Vector3(-12078.91 , 858.5942 , -1.323594 , "None"));
Path.Add(new Vector3(-12075.45 , 854.8101 , -2.208834 , "Swimming"));
Path.Add(new Vector3(-12073.81 , 853.0136 , -2.201716 , "Swimming"));
Path.Add(new Vector3(-12072.22 , 851.2625 , -2.194777 , "Swimming"));
Path.Add(new Vector3(-12070.62 , 849.5113 , -2.187839 , "Swimming"));
Path.Add(new Vector3(-12069.02 , 847.7602 , -2.180901 , "Swimming"));
Path.Add(new Vector3(-12067.37 , 845.9532 , -2.173742 , "Swimming"));
Path.Add(new Vector3(-12065.77 , 844.2021 , -2.166803 , "Swimming"));
Path.Add(new Vector3(-12064.13 , 842.3951 , -2.161758 , "Swimming"));
Path.Add(new Vector3(-12062.47 , 840.5812 , -2.161758 , "Swimming"));
Path.Add(new Vector3(-12060.93 , 838.8928 , -2.161758 , "Swimming"));
Path.Add(new Vector3(-12059.33 , 837.1451 , -2.161758 , "Swimming"));
Path.Add(new Vector3(-12057.9 , 835.5684 , -2.161758 , "Swimming"));
Path.Add(new Vector3(-12056.18 , 833.6847 , -2.161758 , "Swimming"));
Path.Add(new Vector3(-12054.64 , 831.9963 , -2.161758 , "Swimming"));
Path.Add(new Vector3(-12052.92 , 830.1196 , -2.161758 , "Swimming"));
Path.Add(new Vector3(-12050.72 , 829.2812 , -2.161758 , "Swimming"));
Path.Add(new Vector3(-12048.49 , 828.5602 , -2.161758 , "Swimming"));
Path.Add(new Vector3(-12044.52 , 827.2903 , -1.65167 , "None"));
Path.Add(new Vector3(-12040.06 , 825.8521 , -2.16194 , "Swimming"));
Path.Add(new Vector3(-12037.81 , 825.1244 , -2.161945 , "Swimming"));
Path.Add(new Vector3(-12035.52 , 824.3848 , -2.161183 , "Swimming"));
Path.Add(new Vector3(-12033.23 , 823.645 , -2.161183 , "Swimming"));
Path.Add(new Vector3(-12030.97 , 822.9168 , -2.161183 , "Swimming"));
Path.Add(new Vector3(-12028.64 , 822.1654 , -2.161183 , "Swimming"));
Path.Add(new Vector3(-12026.42 , 821.4473 , -2.161183 , "Swimming"));
Path.Add(new Vector3(-12024.13 , 820.7089 , -2.161183 , "Swimming"));
Path.Add(new Vector3(-12021.83 , 819.9662 , -2.161183 , "Swimming"));
Path.Add(new Vector3(-12019.55 , 819.2308 , -2.161183 , "Swimming"));
Path.Add(new Vector3(-12017.24 , 818.4837 , -2.161183 , "Swimming"));
Path.Add(new Vector3(-12015.04 , 817.7729 , -2.161183 , "Swimming"));
Path.Add(new Vector3(-12014.04 , 817.4523 , -2.161183 , "Swimming"));
Path.Add(new Vector3(-12011.92 , 816.7676 , -2.161183 , "Swimming"));
Path.Add(new Vector3(-12008.99 , 815.8203 , -2.161183 , "Swimming"));
Path.Add(new Vector3(-12006.73 , 815.0906 , -2.161183 , "Swimming"));
Path.Add(new Vector3(-12002.03 , 813.6113 , -0.3653197 , "None"));
Path.Add(new Vector3(-11995.61 , 811.538 , 0.885085 , "None"));
Path.Add(new Vector3(-11989.41 , 809.5359 , 0.8222736 , "None"));
Path.Add(new Vector3(-11983.18 , 807.526 , 1.271037 , "None"));
Path.Add(new Vector3(-11977.05 , 805.5477 , 1.033916 , "None"));
Path.Add(new Vector3(-11970.81 , 803.5338 , 1.412497 , "None"));
Path.Add(new Vector3(-11964.65 , 801.5435 , 3.541787 , "None"));
Path.Add(new Vector3(-11959.13 , 799.7631 , 5.869643 , "None"));
Path.Add(new Vector3(-11952.81 , 797.7214 , 7.729399 , "None"));
Path.Add(new Vector3(-11946.02 , 795.5294 , 7.208992 , "None"));
Path.Add(new Vector3(-11939.75 , 793.5076 , 6.985299 , "None"));
Path.Add(new Vector3(-11933.49 , 791.4857 , 6.571033 , "None"));
Path.Add(new Vector3(-11927.17 , 789.4441 , 4.035285 , "None"));
Path.Add(new Vector3(-11921.56 , 787.6359 , 2.492547 , "None"));
Path.Add(new Vector3(-11914.73 , 785.4262 , 1.806139 , "None"));
Path.Add(new Vector3(-11908.59 , 783.4377 , 2.146693 , "None"));
Path.Add(new Vector3(-11902.44 , 781.4454 , 2.411328 , "None"));
Path.Add(new Vector3(-11896.16 , 779.4133 , 1.843726 , "None"));
Path.Add(new Vector3(-11889.83 , 777.3613 , 1.138667 , "None"));
Path.Add(new Vector3(-11883.97 , 775.4642 , 1.418456 , "None"));
Path.Add(new Vector3(-11877.41 , 773.3408 , 2.551122 , "None"));
Path.Add(new Vector3(-11871.29 , 770.8229 , 5.417438 , "None"));
Path.Add(new Vector3(-11865.4 , 768.1188 , 7.533213 , "None"));
Path.Add(new Vector3(-11860.72 , 763.1957 , 9.431389 , "None"));
Path.Add(new Vector3(-11856.21 , 758.3511 , 13.0166 , "None"));
Path.Add(new Vector3(-11851.82 , 753.6328 , 18.04706 , "None"));
Path.Add(new Vector3(-11845.61 , 752.5509 , 23.26633 , "None"));
Path.Add(new Vector3(-11841.99 , 752.1447 , 25.08158 , "None"));
Path.Add(new Vector3(-11844.72 , 753.2379 , 23.55811 , "None"));
Path.Add(new Vector3(-11851.04 , 753.5192 , 18.78975 , "None"));
Path.Add(new Vector3(-11855.62 , 757.9102 , 13.40881 , "None"));
Path.Add(new Vector3(-11855.57 , 764.4897 , 9.824085 , "None"));
Path.Add(new Vector3(-11853.84 , 770.4928 , 7.73545 , "None"));
Path.Add(new Vector3(-11855.05 , 770.3295 , 7.593508 , "None"));
Path.Add(new Vector3(-11856.2 , 763.7956 , 9.92189 , "None"));
Path.Add(new Vector3(-11855.89 , 757.2773 , 13.55219 , "None"));
Path.Add(new Vector3(-11850.98 , 753.1902 , 18.94338 , "None"));
Path.Add(new Vector3(-11847.2 , 752.7604 , 22.06399 , "None"));
Path.Add(new Vector3(-11849.39 , 753.6317 , 20.1238 , "None"));
Path.Add(new Vector3(-11854.9 , 756.7503 , 14.1949 , "None"));
Path.Add(new Vector3(-11855.97 , 762.9067 , 10.54376 , "None"));
Path.Add(new Vector3(-11854.2 , 769.1234 , 8.263471 , "None"));
Path.Add(new Vector3(-11852.41 , 775.3772 , 6.173108 , "None"));
Path.Add(new Vector3(-11850.61 , 781.6558 , 5.55652 , "None"));
Path.Add(new Vector3(-11848.33 , 787.7141 , 5.695423 , "None"));
Path.Add(new Vector3(-11842.22 , 789.6314 , 5.58704 , "None"));
Path.Add(new Vector3(-11836.04 , 788.7243 , 4.02689 , "None"));
Path.Add(new Vector3(-11829.44 , 787.6744 , 2.658833 , "None"));
Path.Add(new Vector3(-11823.07 , 786.662 , 5.778588 , "None"));
Path.Add(new Vector3(-11816.47 , 785.6122 , 11.79061 , "None"));
Path.Add(new Vector3(-11810.09 , 784.5967 , 15.33861 , "None"));
Path.Add(new Vector3(-11803.5 , 783.5488 , 19.00842 , "None"));
Path.Add(new Vector3(-11797.11 , 782.5333 , 23.15014 , "None"));
Path.Add(new Vector3(-11790.89 , 782.3253 , 21.62585 , "None"));
Path.Add(new Vector3(-11784.69 , 782.999 , 24.98115 , "None"));
Path.Add(new Vector3(-11777.69 , 783.5472 , 29.74693 , "None"));
Path.Add(new Vector3(-11771.24 , 784.0523 , 33.66927 , "None"));
Path.Add(new Vector3(-11764.82 , 784.5557 , 37.04391 , "None"));
Path.Add(new Vector3(-11760.95 , 784.8489 , 35.20408 , "None"));
Path.Add(new Vector3(-11753.63 , 784.5085 , 31.38463 , "None"));
Path.Add(new Vector3(-11747.66 , 784.9153 , 29.53353 , "None"));
Path.Add(new Vector3(-11741.81 , 785.3133 , 29.55495 , "None"));
Path.Add(new Vector3(-11738.19 , 785.5599 , 30.37592 , "None"));
Path.Add(new Vector3(-11735.94 , 789.0714 , 30.9245 , "None"));
Path.Add(new Vector3(-11733.68 , 792.5757 , 31.19978 , "None"));
Path.Add(new Vector3(-11733.28 , 793.1931 , 31.16392 , "None"));
Path.Add(new Vector3(-11736.78 , 791.5263 , 30.97044 , "None"));
Path.Add(new Vector3(-11743.11 , 790.2311 , 29.43162 , "None"));
Path.Add(new Vector3(-11749.44 , 788.9381 , 29.86352 , "None"));
Path.Add(new Vector3(-11755.76 , 787.6454 , 32.3144 , "None"));
Path.Add(new Vector3(-11762.31 , 786.3063 , 35.80116 , "None"));
Path.Add(new Vector3(-11768.82 , 784.9749 , 35.0368 , "None"));
Path.Add(new Vector3(-11775.17 , 783.677 , 31.16532 , "None"));
Path.Add(new Vector3(-11781.45 , 782.3921 , 27.4156 , "None"));
Path.Add(new Vector3(-11787.86 , 781.9308 , 23.24576 , "None"));
Path.Add(new Vector3(-11794.44 , 782.8125 , 22.34838 , "None"));
Path.Add(new Vector3(-11800.84 , 783.7603 , 21.83052 , "None"));
Path.Add(new Vector3(-11807.24 , 784.7081 , 16.15455 , "None"));
Path.Add(new Vector3(-11813.62 , 785.6539 , 14.31717 , "None"));
Path.Add(new Vector3(-11820.04 , 786.6055 , 8.534002 , "None"));
Path.Add(new Vector3(-11826.6 , 787.5778 , 3.676777 , "None"));
Path.Add(new Vector3(-11832.86 , 788.5048 , 3.130611 , "None"));
Path.Add(new Vector3(-11839.57 , 789.4997 , 5.020081 , "None"));
Path.Add(new Vector3(-11845.79 , 789.6719 , 5.898139 , "None"));
Path.Add(new Vector3(-11847.69 , 786.365 , 5.806348 , "None"));
Path.Add(new Vector3(-11847.7 , 783.3306 , 5.829991 , "None"));
Path.Add(new Vector3(-11848.19 , 782.154 , 5.807773 , "None"));
Path.Add(new Vector3(-11850.64 , 776.2831 , 6.083058 , "None"));
Path.Add(new Vector3(-11853.28 , 769.9843 , 8.07275 , "None"));
Path.Add(new Vector3(-11855.7 , 764.1902 , 9.920214 , "None"));
Path.Add(new Vector3(-11855.86 , 757.7263 , 13.3914 , "None"));
Path.Add(new Vector3(-11850.95 , 753.3881 , 18.91689 , "None"));
Path.Add(new Vector3(-11844.47 , 752.5663 , 23.77495 , "None"));
Path.Add(new Vector3(-11838.03 , 751.7495 , 27.2565 , "None"));
Path.Add(new Vector3(-11836.73 , 751.1907 , 28.17099 , "None"));
Path.Add(new Vector3(-11831.93 , 747.022 , 34.06494 , "None"));
Path.Add(new Vector3(-11828.01 , 741.6841 , 38.42618 , "None"));
Path.Add(new Vector3(-11824.64 , 736.0933 , 41.27468 , "None"));
Path.Add(new Vector3(-11823.53 , 729.7637 , 45.40873 , "None"));
Path.Add(new Vector3(-11823 , 723.1125 , 45.40694 , "None"));
Path.Add(new Vector3(-11822.5 , 716.7113 , 45.25409 , "None"));
Path.Add(new Vector3(-11821.97 , 710.0344 , 44.86037 , "None"));
Path.Add(new Vector3(-11821.47 , 703.6272 , 44.63034 , "None"));
Path.Add(new Vector3(-11820.96 , 697.1558 , 44.56002 , "None"));
Path.Add(new Vector3(-11820.45 , 690.7614 , 45.01474 , "None"));
Path.Add(new Vector3(-11819.93 , 684.1102 , 47.66785 , "None"));
Path.Add(new Vector3(-11819.42 , 677.6516 , 47.01981 , "None"));
Path.Add(new Vector3(-11818.89 , 671.0133 , 47.45767 , "None"));
Path.Add(new Vector3(-11817.4 , 665.0664 , 51.01173 , "None"));
Path.Add(new Vector3(-11812.58 , 660.6122 , 51.12646 , "None"));
Path.Add(new Vector3(-11806.79 , 658.4598 , 53.4572 , "None"));
Path.Add(new Vector3(-11803.34 , 652.759 , 58.8147 , "None"));
Path.Add(new Vector3(-11799.91 , 647.4291 , 60.29148 , "None"));
Path.Add(new Vector3(-11794.34 , 644.488 , 64.66739 , "None"));
Path.Add(new Vector3(-11789.13 , 647.0722 , 68.81056 , "None"));
Path.Add(new Vector3(-11785.99 , 652.8855 , 71.837 , "None"));
Path.Add(new Vector3(-11782.87 , 658.6649 , 72.12463 , "None"));
Path.Add(new Vector3(-11779.76 , 664.4102 , 73.30454 , "None"));
Path.Add(new Vector3(-11776.73 , 670.0309 , 72.70238 , "None"));
Path.Add(new Vector3(-11773.62 , 675.7762 , 69.78363 , "None"));
Path.Add(new Vector3(-11770.49 , 681.5782 , 66.64799 , "None"));
Path.Add(new Vector3(-11767.33 , 687.4255 , 66.63683 , "None"));
Path.Add(new Vector3(-11764.34 , 692.9555 , 66.97115 , "None"));
Path.Add(new Vector3(-11761.18 , 698.8029 , 64.22167 , "None"));
Path.Add(new Vector3(-11757.53 , 703.9907 , 61.3354 , "None"));
Path.Add(new Vector3(-11753.51 , 709.4108 , 60.50327 , "None"));
Path.Add(new Vector3(-11749.49 , 714.5692 , 58.47983 , "None"));
Path.Add(new Vector3(-11745.5 , 719.6768 , 54.25571 , "None"));
Path.Add(new Vector3(-11742.07 , 724.1295 , 51.94871 , "None"));
Path.Add(new Vector3(-11738.24 , 729.6032 , 51.47953 , "None"));
Path.Add(new Vector3(-11734.53 , 734.8871 , 51.08798 , "None"));
Path.Add(new Vector3(-11731.91 , 738.6298 , 50.77899 , "None"));
Path.Add(new Vector3(-11729.74 , 741.7267 , 50.72925 , "None"));
Path.Add(new Vector3(-11729.38 , 742.9654 , 50.72393 , "None"));
Path.Add(new Vector3(-11728.81 , 745.9705 , 50.72231 , "None"));
Path.Add(new Vector3(-11729.01 , 748.7 , 51.10216 , "None"));
Path.Add(new Vector3(-11729.27 , 750.562 , 51.45642 , "None"));
Path.Add(new Vector3(-11729.73 , 753.2515 , 52.16731 , "None"));
Path.Add(new Vector3(-11729.96 , 754.4838 , 52.5374 , "None"));
Path.Add(new Vector3(-11727.27 , 753.9336 , 52.67775 , "None"));
Path.Add(new Vector3(-11723.21 , 753.2028 , 51.07355 , "None"));
Path.Add(new Vector3(-11719.3 , 752.6312 , 50.74268 , "None"));
Path.Add(new Vector3(-11717.04 , 752.3271 , 50.52505 , "None"));
Path.Add(new Vector3(-11714.62 , 751.8497 , 51.24684 , "None"));
Path.Add(new Vector3(-11710.79 , 750.5513 , 50.14471 , "None"));
Path.Add(new Vector3(-11706.97 , 749.2553 , 49.69093 , "None"));
Path.Add(new Vector3(-11703.01 , 747.917 , 49.63273 , "None"));
Path.Add(new Vector3(-11701.62 , 747.445 , 49.64957 , "None"));
Path.Add(new Vector3(-11702.57 , 743.9432 , 49.71994 , "None"));
Path.Add(new Vector3(-11703.64 , 740.0453 , 49.69974 , "None"));
Path.Add(new Vector3(-11704.71 , 736.1553 , 49.56639 , "None"));
Path.Add(new Vector3(-11704.47 , 735.1428 , 49.55097 , "None"));
Path.Add(new Vector3(-11702.72 , 733.3521 , 49.5502 , "None"));
Path.Add(new Vector3(-11701.16 , 732.2895 , 49.58694 , "None"));
Path.Add(new Vector3(-11698.43 , 734.2486 , 49.72834 , "None"));
Path.Add(new Vector3(-11695.04 , 736.6764 , 50.02983 , "None"));
Path.Add(new Vector3(-11691.75 , 739.0271 , 49.83172 , "None"));
Path.Add(new Vector3(-11689.88 , 740.3489 , 49.76376 , "None"));
Path.Add(new Vector3(-11688.54 , 739.1497 , 49.74399 , "None"));
Path.Add(new Vector3(-11685.32 , 736.2856 , 49.95675 , "None"));
Path.Add(new Vector3(-11682.91 , 734.1388 , 50.27492 , "None"));
Path.Add(new Vector3(-11681.36 , 732.7603 , 50.4692 , "None"));
Path.Add(new Vector3(-11683 , 735.9022 , 50.17706 , "None"));
Path.Add(new Vector3(-11685.51 , 738.9021 , 49.84733 , "None"));
Path.Add(new Vector3(-11688.11 , 742.0063 , 49.65121 , "None"));
Path.Add(new Vector3(-11688.23 , 745.2503 , 49.73764 , "None"));
Path.Add(new Vector3(-11688.54 , 749.2088 , 49.91226 , "None"));
Path.Add(new Vector3(-11688.84 , 753.1011 , 50.17557 , "None"));
Path.Add(new Vector3(-11688.95 , 754.4215 , 50.28085 , "None"));
Path.Add(new Vector3(-11692.14 , 757.1779 , 50.49014 , "None"));
Path.Add(new Vector3(-11695.49 , 759.4326 , 50.58091 , "None"));
Path.Add(new Vector3(-11698.78 , 761.7236 , 50.58337 , "None"));
Path.Add(new Vector3(-11699.09 , 765.3796 , 50.62199 , "None"));
Path.Add(new Vector3(-11697.51 , 769.4183 , 50.94355 , "None"));
Path.Add(new Vector3(-11695.51 , 770.4174 , 51.02364 , "None"));
Path.Add(new Vector3(-11691.99 , 772.2783 , 51.22788 , "None"));
Path.Add(new Vector3(-11691.4 , 772.5872 , 51.25598 , "None"));
Path.Add(new Vector3(-11690.48 , 772.1274 , 51.10926 , "None"));
Path.Add(new Vector3(-11684.81 , 770.9084 , 50.79187 , "None"));
Path.Add(new Vector3(-11679.57 , 768.1821 , 50.72349 , "None"));
Path.Add(new Vector3(-11673.1 , 767.9544 , 50.72206 , "None"));
Path.Add(new Vector3(-11669.44 , 763.9738 , 50.72206 , "None"));
Path.Add(new Vector3(-11668.31 , 757.6082 , 50.72206 , "None"));
Path.Add(new Vector3(-11667.86 , 752.5526 , 50.72206 , "None"));
Path.Add(new Vector3(-11667.64 , 746.0776 , 50.71147 , "None"));
Path.Add(new Vector3(-11667.42 , 739.4095 , 50.72181 , "None"));
Path.Add(new Vector3(-11667.24 , 734.2605 , 50.7212 , "None"));
Path.Add(new Vector3(-11667.02 , 727.5795 , 50.7212 , "None"));
Path.Add(new Vector3(-11666.8 , 721.1304 , 50.64816 , "None"));
Path.Add(new Vector3(-11666.63 , 716.2509 , 50.63242 , "None"));
Path.Add(new Vector3(-11666.48 , 711.7325 , 50.59875 , "None"));
Path.Add(new Vector3(-11666.34 , 707.5569 , 50.58411 , "None"));
Path.Add(new Vector3(-11665.8 , 702.4809 , 50.58097 , "None"));
Path.Add(new Vector3(-11665.63 , 696.0173 , 50.49592 , "None"));
Path.Add(new Vector3(-11665.46 , 689.5666 , 50.53215 , "None"));
Path.Add(new Vector3(-11665.29 , 682.8842 , 50.53861 , "None"));
Path.Add(new Vector3(-11665.13 , 676.4334 , 50.573 , "None"));
Path.Add(new Vector3(-11664.96 , 669.9698 , 50.49013 , "None"));
Path.Add(new Vector3(-11664.78 , 663.2874 , 50.42304 , "None"));
Path.Add(new Vector3(-11664.62 , 656.8366 , 50.23875 , "None"));
Path.Add(new Vector3(-11659.01 , 654.8875 , 50.8712 , "None"));
Path.Add(new Vector3(-11653.76 , 657.3852 , 50.73944 , "None"));
Path.Add(new Vector3(-11651.48 , 663.4122 , 50.32865 , "None"));
Path.Add(new Vector3(-11649.2 , 669.4602 , 49.26086 , "None"));
Path.Add(new Vector3(-11646.83 , 675.7131 , 47.75555 , "None"));
Path.Add(new Vector3(-11644.55 , 681.7491 , 46.23386 , "None"));
Path.Add(new Vector3(-11642.26 , 687.7972 , 44.7795 , "None"));
Path.Add(new Vector3(-11637.95 , 686.0304 , 45.44402 , "None"));
Path.Add(new Vector3(-11636.87 , 692.0162 , 43.91179 , "None"));
Path.Add(new Vector3(-11636.43 , 698.6733 , 43.04195 , "None"));
Path.Add(new Vector3(-11634.14 , 703.3644 , 42.62102 , "None"));
Path.Add(new Vector3(-11628.22 , 703.7694 , 42.38998 , "None"));
Path.Add(new Vector3(-11626.61 , 697.9953 , 43.56857 , "None"));
Path.Add(new Vector3(-11625.56 , 691.7999 , 45.56778 , "None"));
Path.Add(new Vector3(-11624.48 , 685.4365 , 48.41946 , "None"));
Path.Add(new Vector3(-11623.39 , 678.9232 , 50.50127 , "None"));
Path.Add(new Vector3(-11622.73 , 675.0175 , 51.56909 , "None"));
Path.Add(new Vector3(-11622.63 , 674.3971 , 51.74175 , "None"));
Path.Add(new Vector3(-11625.46 , 674.3214 , 51.86647 , "None"));
Path.Add(new Vector3(-11625.65 , 672.0005 , 52.25117 , "None"));
Path.Add(new Vector3(-11627.5 , 672.7695 , 51.98138 , "None"));
Path.Add(new Vector3(-11625.01 , 672.3026 , 52.13595 , "None"));
Path.Add(new Vector3(-11622.44 , 674.8419 , 51.63523 , "None"));
Path.Add(new Vector3(-11623.38 , 678.9191 , 50.50275 , "None"));
Path.Add(new Vector3(-11626.55 , 681.0224 , 50.75808 , "None"));
Path.Add(new Vector3(-11629.87 , 681.131 , 51.06567 , "None"));
Path.Add(new Vector3(-11627.73 , 682.1037 , 50.67964 , "None"));
Path.Add(new Vector3(-11626.61 , 685.8318 , 48.76369 , "None"));
Path.Add(new Vector3(-11626.82 , 689.7466 , 46.53564 , "None"));
Path.Add(new Vector3(-11627.04 , 693.7739 , 44.76685 , "None"));
Path.Add(new Vector3(-11627.2 , 697.9728 , 43.5622 , "None"));
Path.Add(new Vector3(-11627.36 , 702.2927 , 42.6326 , "None"));
Path.Add(new Vector3(-11627.4 , 703.262 , 42.45472 , "None"));
Path.Add(new Vector3(-11630.13 , 705.8089 , 42.08218 , "None"));
Path.Add(new Vector3(-11633.25 , 708.3846 , 41.6623 , "None"));
Path.Add(new Vector3(-11636.96 , 708.7034 , 41.3617 , "None"));
Path.Add(new Vector3(-11639.18 , 705.5099 , 41.8411 , "None"));
Path.Add(new Vector3(-11639.92 , 701.5939 , 42.51688 , "None"));
Path.Add(new Vector3(-11641.03 , 698.0613 , 42.97673 , "None"));
Path.Add(new Vector3(-11640.78 , 693.9001 , 43.54168 , "None"));
Path.Add(new Vector3(-11641.21 , 689.8832 , 44.32158 , "None"));
Path.Add(new Vector3(-11641.68 , 685.7322 , 45.26656 , "None"));
Path.Add(new Vector3(-11638.63 , 684.1614 , 45.85411 , "None"));
Path.Add(new Vector3(-11639.1 , 680.0185 , 46.72381 , "None"));
Path.Add(new Vector3(-11638.85 , 676.1022 , 47.75469 , "None"));
Path.Add(new Vector3(-11638.36 , 672.1029 , 48.74816 , "None"));
Path.Add(new Vector3(-11638.67 , 667.9446 , 49.63575 , "None"));
Path.Add(new Vector3(-11638.97 , 663.9147 , 50.41273 , "None"));
Path.Add(new Vector3(-11639.06 , 659.8908 , 50.84319 , "None"));
Path.Add(new Vector3(-11637.17 , 656.666 , 51.18573 , "None"));
Path.Add(new Vector3(-11636.31 , 652.7924 , 51.32364 , "None"));
Path.Add(new Vector3(-11636.71 , 648.856 , 51.22481 , "None"));
Path.Add(new Vector3(-11637.58 , 645.0736 , 51.07993 , "None"));
Path.Add(new Vector3(-11637.93 , 641.0321 , 51.01329 , "None"));
Path.Add(new Vector3(-11638.18 , 636.896 , 50.97046 , "None"));
Path.Add(new Vector3(-11638.4 , 632.937 , 50.82749 , "None"));
Path.Add(new Vector3(-11636.63 , 629.6438 , 50.77095 , "None"));
Path.Add(new Vector3(-11636.14 , 625.6519 , 50.4365 , "None"));
Path.Add(new Vector3(-11635.7 , 621.7753 , 50.20359 , "None"));
Path.Add(new Vector3(-11635.74 , 617.7343 , 50.14467 , "None"));
Path.Add(new Vector3(-11636.14 , 613.5889 , 50.21046 , "None"));
Path.Add(new Vector3(-11636.64 , 609.5797 , 50.30796 , "None"));
Path.Add(new Vector3(-11637.17 , 605.4426 , 50.65293 , "None"));
Path.Add(new Vector3(-11637.27 , 601.4379 , 51.01194 , "None"));
Path.Add(new Vector3(-11637.29 , 597.403 , 50.74141 , "None"));
Path.Add(new Vector3(-11637.73 , 593.3999 , 50.4248 , "None"));
Path.Add(new Vector3(-11639.58 , 589.6521 , 50.25267 , "None"));
Path.Add(new Vector3(-11641.51 , 586.1962 , 50.11495 , "None"));
Path.Add(new Vector3(-11643.74 , 582.9067 , 49.9707 , "None"));
Path.Add(new Vector3(-11644.66 , 578.9808 , 49.92851 , "None"));
Path.Add(new Vector3(-11644.92 , 574.9573 , 49.93444 , "None"));
Path.Add(new Vector3(-11645.02 , 570.9176 , 49.96568 , "None"));
Path.Add(new Vector3(-11645.13 , 566.7492 , 49.9246 , "None"));
Path.Add(new Vector3(-11645.24 , 562.7095 , 49.85324 , "None"));
Path.Add(new Vector3(-11645.04 , 558.6898 , 49.82961 , "None"));
Path.Add(new Vector3(-11644.35 , 554.7079 , 49.68867 , "None"));
Path.Add(new Vector3(-11643.64 , 550.5991 , 49.43327 , "None"));
Path.Add(new Vector3(-11642.96 , 546.6251 , 48.9139 , "None"));
Path.Add(new Vector3(-11642.24 , 542.5083 , 48.19304 , "None"));
Path.Add(new Vector3(-11641.55 , 538.5264 , 47.41961 , "None"));
Path.Add(new Vector3(-11641.12 , 534.5239 , 46.65292 , "None"));
Path.Add(new Vector3(-11641.21 , 530.492 , 45.75554 , "None"));
Path.Add(new Vector3(-11640.74 , 526.5372 , 44.93106 , "None"));
Path.Add(new Vector3(-11640.84 , 522.4973 , 43.90707 , "None"));
Path.Add(new Vector3(-11640.94 , 518.3287 , 43.21365 , "None"));
Path.Add(new Vector3(-11640.67 , 514.4282 , 43.07358 , "None"));
Path.Add(new Vector3(-11640.12 , 510.3096 , 42.8721 , "None"));
Path.Add(new Vector3(-11639.58 , 506.3125 , 42.82316 , "None"));
Path.Add(new Vector3(-11638.05 , 502.5853 , 43.38638 , "None"));
Path.Add(new Vector3(-11636.27 , 498.8077 , 43.43676 , "None"));
Path.Add(new Vector3(-11634.37 , 495.2507 , 43.10033 , "None"));
Path.Add(new Vector3(-11632.65 , 491.6292 , 43.26337 , "None"));
Path.Add(new Vector3(-11630.83 , 488.2279 , 42.92019 , "None"));
Path.Add(new Vector3(-11627.24 , 486.7468 , 43.50298 , "None"));
Path.Add(new Vector3(-11623.9 , 484.723 , 45.69707 , "None"));
Path.Add(new Vector3(-11620.81 , 482.4515 , 48.54813 , "None"));
Path.Add(new Vector3(-11618.08 , 479.7663 , 51.34796 , "None"));
Path.Add(new Vector3(-11617.63 , 476.0602 , 52.87761 , "None"));
Path.Add(new Vector3(-11618.01 , 474.3619 , 53.43955 , "None"));
Path.Add(new Vector3(-11617.23 , 476.3261 , 53.15149 , "None"));
Path.Add(new Vector3(-11614.6 , 479.179 , 54.35344 , "None"));
Path.Add(new Vector3(-11614.56 , 480.8357 , 54.93284 , "None"));
Path.Add(new Vector3(-11615.24 , 482.3055 , 54.64021 , "None"));
Path.Add(new Vector3(-11616.77 , 486.0345 , 52.3821 , "None"));
Path.Add(new Vector3(-11617.82 , 490.0485 , 51.16093 , "None"));
Path.Add(new Vector3(-11617.87 , 492.6025 , 52.20361 , "None"));
Path.Add(new Vector3(-11615.79 , 489.7365 , 53.33353 , "None"));
Path.Add(new Vector3(-11615.5 , 489.4432 , 53.66945 , "None"));
Path.Add(new Vector3(-11616.27 , 486.8098 , 53.17063 , "None"));
Path.Add(new Vector3(-11616.28 , 482.9685 , 52.85924 , "None"));
Path.Add(new Vector3(-11616.08 , 479.524 , 53.11879 , "None"));
Path.Add(new Vector3(-11612.5 , 478.9966 , 56.3443 , "None"));
Path.Add(new Vector3(-11609.12 , 481.0465 , 58.68138 , "None"));
Path.Add(new Vector3(-11608.05 , 484.8958 , 60.83817 , "None"));
Path.Add(new Vector3(-11607.08 , 488.8506 , 62.32063 , "None"));
Path.Add(new Vector3(-11606 , 492.8402 , 63.75565 , "None"));
Path.Add(new Vector3(-11603.5 , 495.9987 , 66.74097 , "None"));
Path.Add(new Vector3(-11600.74 , 499.1205 , 67.75991 , "None"));
Path.Add(new Vector3(-11599.08 , 502.4596 , 66.98663 , "None"));
Path.Add(new Vector3(-11596.41 , 505.4849 , 65.51826 , "None"));
Path.Add(new Vector3(-11593.83 , 508.4771 , 66.32079 , "None"));
Path.Add(new Vector3(-11592.05 , 512.2526 , 68.18925 , "None"));
Path.Add(new Vector3(-11590.39 , 515.9363 , 70.94201 , "None"));
Path.Add(new Vector3(-11589.5 , 519.8655 , 73.01639 , "None"));
Path.Add(new Vector3(-11589.63 , 521.8467 , 73.42325 , "None"));
Path.Add(new Vector3(-11589.92 , 522.5959 , 73.48787 , "None"));
Path.Add(new Vector3(-11590.33 , 521.2021 , 73.4468 , "None"));
Path.Add(new Vector3(-11592.87 , 519.2577 , 71.33653 , "None"));
Path.Add(new Vector3(-11596.68 , 520.5875 , 69.10526 , "None"));
Path.Add(new Vector3(-11600.52 , 521.9023 , 64.57309 , "None"));
Path.Add(new Vector3(-11605.24 , 520.3924 , 58.55984 , "None"));
Path.Add(new Vector3(-11608.25 , 522.6167 , 56.96739 , "None"));
Path.Add(new Vector3(-11611.89 , 524.2683 , 56.53103 , "None"));
Path.Add(new Vector3(-11615.08 , 526.5479 , 55.88314 , "None"));
Path.Add(new Vector3(-11618.8 , 528.126 , 55.04944 , "None"));
Path.Add(new Vector3(-11621.85 , 530.3491 , 53.81778 , "None"));
Path.Add(new Vector3(-11625.72 , 531.9542 , 52.01141 , "None"));
Path.Add(new Vector3(-11629.61 , 532.993 , 50.56099 , "None"));
Path.Add(new Vector3(-11633.36 , 532.8486 , 51.44509 , "None"));
Path.Add(new Vector3(-11636.82 , 530.7666 , 51.55544 , "None"));
Path.Add(new Vector3(-11639.33 , 531.2853 , 50.53192 , "None"));
Path.Add(new Vector3(-11641.4 , 534.75 , 48.01944 , "None"));
Path.Add(new Vector3(-11644.05 , 537.7747 , 46.98166 , "None"));
Path.Add(new Vector3(-11644.75 , 538.4055 , 47.02027 , "None"));
Path.Add(new Vector3(-11646.25 , 539.7546 , 47.26048 , "None"));
Path.Add(new Vector3(-11649.51 , 536.9601 , 46.64178 , "None"));
Path.Add(new Vector3(-11651.97 , 534.8428 , 46.16012 , "None"));
Path.Add(new Vector3(-11653.51 , 536.7626 , 46.61086 , "None"));
Path.Add(new Vector3(-11654.22 , 539.0145 , 47.1078 , "None"));
Path.Add(new Vector3(-11654.93 , 542.1862 , 47.84682 , "None"));
Path.Add(new Vector3(-11655.71 , 546.5765 , 48.75841 , "None"));
Path.Add(new Vector3(-11656.16 , 550.6815 , 49.51525 , "None"));
Path.Add(new Vector3(-11656.54 , 552.9354 , 49.88736 , "None"));
Path.Add(new Vector3(-11657.25 , 557.0443 , 50.19107 , "None"));
Path.Add(new Vector3(-11657.52 , 558.5632 , 50.27317 , "None"));
Path.Add(new Vector3(-11656.54 , 558.1804 , 50.16878 , "None"));
Path.Add(new Vector3(-11654.68 , 554.1434 , 49.79246 , "None"));
Path.Add(new Vector3(-11652.99 , 550.4794 , 49.19849 , "None"));
Path.Add(new Vector3(-11651.3 , 546.8008 , 48.57407 , "None"));
Path.Add(new Vector3(-11650.4 , 544.8481 , 48.20905 , "None"));
Path.Add(new Vector3(-11649.96 , 545.717 , 48.36134 , "None"));
Path.Add(new Vector3(-11648.25 , 549.0922 , 48.90432 , "None"));
Path.Add(new Vector3(-11646.41 , 552.7402 , 49.38054 , "None"));
Path.Add(new Vector3(-11644.82 , 555.8712 , 49.71576 , "None"));
Path.Add(new Vector3(-11643.24 , 558.9951 , 49.94108 , "None"));
Path.Add(new Vector3(-11641.39 , 562.6478 , 50.13221 , "None"));
Path.Add(new Vector3(-11639.75 , 565.8866 , 50.39721 , "None"));
Path.Add(new Vector3(-11639.3 , 566.7695 , 50.51018 , "None"));
Path.Add(new Vector3(-11638.53 , 567.8707 , 50.55719 , "None"));
Path.Add(new Vector3(-11636.1 , 571.0554 , 50.65506 , "None"));
Path.Add(new Vector3(-11635.11 , 572.1915 , 50.64001 , "None"));
Path.Add(new Vector3(-11632.64 , 574.718 , 50.52909 , "None"));
Path.Add(new Vector3(-11630.58 , 576.7987 , 50.38771 , "None"));
Path.Add(new Vector3(-11629.96 , 577.4155 , 50.30803 , "None"));
Path.Add(new Vector3(-11627.67 , 580.7433 , 49.99453 , "None"));
Path.Add(new Vector3(-11625.91 , 583.2955 , 49.7391 , "None"));
Path.Add(new Vector3(-11623.3 , 582.9778 , 49.52886 , "None"));
Path.Add(new Vector3(-11619.1 , 582.4669 , 49.31826 , "None"));
Path.Add(new Vector3(-11615.22 , 581.9958 , 49.37749 , "None"));
Path.Add(new Vector3(-11611.08 , 581.4927 , 49.59436 , "None"));
Path.Add(new Vector3(-11607.06 , 581.0042 , 49.74657 , "None"));
Path.Add(new Vector3(-11602.92 , 580.501 , 49.96014 , "None"));
Path.Add(new Vector3(-11598.92 , 580.0143 , 50.23033 , "None"));
Path.Add(new Vector3(-11598.59 , 581.3178 , 50.16795 , "None"));
Path.Add(new Vector3(-11597.6 , 585.2516 , 50.03133 , "None"));
Path.Add(new Vector3(-11596.48 , 589.1194 , 50.03873 , "None"));
Path.Add(new Vector3(-11595.18 , 593.0735 , 50.24269 , "None"));
Path.Add(new Vector3(-11593.96 , 596.7837 , 50.60093 , "None"));
Path.Add(new Vector3(-11593.59 , 597.9388 , 50.68942 , "None"));
Path.Add(new Vector3(-11591.57 , 597.7911 , 50.53762 , "None"));
Path.Add(new Vector3(-11587.41 , 597.4864 , 50.37873 , "None"));
Path.Add(new Vector3(-11583.38 , 597.191 , 50.26466 , "None"));
Path.Add(new Vector3(-11580.18 , 596.9562 , 50.21282 , "None"));
Path.Add(new Vector3(-11578.79 , 596.7405 , 50.2075 , "None"));
Path.Add(new Vector3(-11576.03 , 596.1385 , 50.21024 , "None"));
Path.Add(new Vector3(-11572.73 , 594.9703 , 50.21305 , "None"));
Path.Add(new Vector3(-11570.48 , 594.0669 , 50.23108 , "None"));
Path.Add(new Vector3(-11570.37 , 592.2633 , 50.19303 , "None"));
Path.Add(new Vector3(-11567.47 , 593.9766 , 50.25904 , "None"));
Path.Add(new Vector3(-11566.77 , 594.3905 , 50.27342 , "None"));
Path.Add(new Vector3(-11567.75 , 596.5362 , 50.31086 , "None"));
Path.Add(new Vector3(-11566.74 , 596.9201 , 51.9244 , "None"));
Path.Add(new Vector3(-11565.22 , 597.2351 , 50.32882 , "None"));
Path.Add(new Vector3(-11563.13 , 597.6712 , 50.33533 , "None"));
Path.Add(new Vector3(-11561.09 , 598.5771 , 50.34356 , "None"));
Path.Add(new Vector3(-11559.55 , 599.6006 , 50.3687 , "None"));
Path.Add(new Vector3(-11558.03 , 600.6959 , 50.39034 , "None"));
Path.Add(new Vector3(-11556.19 , 601.651 , 50.42888 , "None"));
Path.Add(new Vector3(-11555.17 , 602.3022 , 50.4565 , "None"));
Path.Add(new Vector3(-11554.94 , 601.5101 , 50.45385 , "None"));
Path.Add(new Vector3(-11554.75 , 600.9304 , 50.45061 , "None"));
Path.Add(new Vector3(-11556.17 , 601.1853 , 50.42725 , "None"));
Path.Add(new Vector3(-11557.09 , 601.3206 , 50.41264 , "None"));
Path.Add(new Vector3(-11559.66 , 599.1924 , 50.36189 , "None"));
Path.Add(new Vector3(-11563.66 , 598.6114 , 50.35575 , "None"));
Path.Add(new Vector3(-11567.3 , 597.5556 , 50.3484 , "None"));
Path.Add(new Vector3(-11571.15 , 596.3714 , 50.2888 , "None"));
Path.Add(new Vector3(-11575.11 , 595.5724 , 50.20107 , "None"));
Path.Add(new Vector3(-11579.21 , 594.7465 , 50.13943 , "None"));
Path.Add(new Vector3(-11583.16 , 593.9491 , 50.16872 , "None"));
Path.Add(new Vector3(-11587.19 , 592.8831 , 50.2243 , "None"));
Path.Add(new Vector3(-11590.97 , 591.4886 , 50.20525 , "None"));
Path.Add(new Vector3(-11594.76 , 590.0917 , 50.10521 , "None"));
Path.Add(new Vector3(-11598.68 , 588.6498 , 49.92067 , "None"));
Path.Add(new Vector3(-11602.48 , 587.2498 , 49.61953 , "None"));
Path.Add(new Vector3(-11606.26 , 585.8553 , 49.28823 , "None"));
Path.Add(new Vector3(-11610.05 , 584.458 , 49.32253 , "None"));
Path.Add(new Vector3(-11613.97 , 583.0162 , 49.31282 , "None"));
Path.Add(new Vector3(-11617.76 , 581.6189 , 49.35767 , "None"));
Path.Add(new Vector3(-11621.55 , 580.2216 , 49.58645 , "None"));
Path.Add(new Vector3(-11625.47 , 578.777 , 49.87064 , "None"));
Path.Add(new Vector3(-11629.2 , 577.402 , 50.23084 , "None"));
Path.Add(new Vector3(-11633.11 , 575.9601 , 50.54243 , "None"));
Path.Add(new Vector3(-11636.88 , 574.574 , 50.45121 , "None"));
Path.Add(new Vector3(-11640.75 , 573.1461 , 50.2097 , "None"));
Path.Add(new Vector3(-11644.54 , 571.7453 , 49.98843 , "None"));
Path.Add(new Vector3(-11647.01 , 570.4132 , 49.87701 , "None"));
Path.Add(new Vector3(-11643.75 , 571.0683 , 50.04218 , "None"));
Path.Add(new Vector3(-11639.64 , 572.3649 , 50.30937 , "None"));
Path.Add(new Vector3(-11636.38 , 573.391 , 50.53109 , "None"));
Path.Add(new Vector3(-11632.4 , 574.644 , 50.51796 , "None"));
Path.Add(new Vector3(-11628.55 , 575.8584 , 50.22278 , "None"));
Path.Add(new Vector3(-11624.7 , 577.0703 , 49.90864 , "None"));
Path.Add(new Vector3(-11620.85 , 578.2847 , 49.69026 , "None"));
Path.Add(new Vector3(-11616.86 , 579.5402 , 49.62266 , "None"));
Path.Add(new Vector3(-11612.88 , 580.7932 , 49.62337 , "None"));
Path.Add(new Vector3(-11609.03 , 582.0076 , 49.60373 , "None"));
Path.Add(new Vector3(-11605.18 , 583.2219 , 49.64551 , "None"));
Path.Add(new Vector3(-11601.2 , 584.4749 , 49.72396 , "None"));
Path.Add(new Vector3(-11597.34 , 585.6893 , 50.03219 , "None"));
Path.Add(new Vector3(-11593.49 , 586.9036 , 50.16117 , "None"));
Path.Add(new Vector3(-11590.93 , 587.7116 , 50.20116 , "None"));
Path.Add(new Vector3(-11587.59 , 586.6602 , 50.24561 , "None"));
Path.Add(new Vector3(-11583.73 , 585.4469 , 50.24401 , "None"));
Path.Add(new Vector3(-11579.75 , 584.1924 , 50.17066 , "None"));
Path.Add(new Vector3(-11575.9 , 582.9816 , 50.19668 , "None"));
Path.Add(new Vector3(-11572.05 , 581.7706 , 50.40295 , "None"));
Path.Add(new Vector3(-11570.93 , 581.4168 , 50.49978 , "None"));
Path.Add(new Vector3(-11569.18 , 581.5216 , 50.68781 , "None"));
Path.Add(new Vector3(-11565.21 , 581.7602 , 50.74504 , "None"));
Path.Add(new Vector3(-11560.99 , 581.9299 , 50.73888 , "None"));
Path.Add(new Vector3(-11559.79 , 582.0234 , 50.66871 , "None"));
Path.Add(new Vector3(-11558.5 , 581.4686 , 50.61384 , "None"));
Path.Add(new Vector3(-11560.46 , 580.673 , 50.73945 , "None"));
Path.Add(new Vector3(-11563.61 , 580.6024 , 50.7429 , "None"));
Path.Add(new Vector3(-11564.36 , 580.6763 , 50.7429 , "None"));
Path.Add(new Vector3(-11570.89 , 581.5929 , 50.49964 , "None"));
Path.Add(new Vector3(-11577.29 , 582.4917 , 50.14207 , "None"));
Path.Add(new Vector3(-11583.7 , 583.3904 , 50.32218 , "None"));
Path.Add(new Vector3(-11590.09 , 584.2875 , 50.32093 , "None"));
Path.Add(new Vector3(-11596.71 , 585.2167 , 50.0907 , "None"));
Path.Add(new Vector3(-11603.1 , 586.1136 , 49.53093 , "None"));
Path.Add(new Vector3(-11609.5 , 587.0124 , 49.17742 , "None"));
Path.Add(new Vector3(-11615.9 , 587.9112 , 48.82876 , "None"));
Path.Add(new Vector3(-11622.52 , 588.8404 , 49.25318 , "None"));
Path.Add(new Vector3(-11628.92 , 589.6185 , 50.076 , "None"));
Path.Add(new Vector3(-11635.38 , 589.4182 , 50.43198 , "None"));
Path.Add(new Vector3(-11641.73 , 588.3948 , 50.14415 , "None"));
Path.Add(new Vector3(-11648.33 , 587.3324 , 49.91973 , "None"));
Path.Add(new Vector3(-11654.92 , 586.2721 , 49.9362 , "None"));
Path.Add(new Vector3(-11661.3 , 585.2446 , 50.33512 , "None"));
Path.Add(new Vector3(-11667.69 , 584.217 , 50.76386 , "None"));
Path.Add(new Vector3(-11674.28 , 583.1567 , 50.43495 , "None"));
Path.Add(new Vector3(-11680.66 , 582.1292 , 50.5577 , "None"));
Path.Add(new Vector3(-11685.62 , 579.4095 , 50.69621 , "None"));
Path.Add(new Vector3(-11687.12 , 573.1284 , 50.39648 , "None"));
Path.Add(new Vector3(-11691.89 , 568.4622 , 49.98066 , "None"));
Path.Add(new Vector3(-11696.52 , 563.9495 , 49.50779 , "None"));
Path.Add(new Vector3(-11701.14 , 559.4459 , 49.33039 , "None"));
Path.Add(new Vector3(-11705.78 , 554.9243 , 49.39968 , "None"));
Path.Add(new Vector3(-11710.57 , 550.2589 , 49.74134 , "None"));
Path.Add(new Vector3(-11715.85 , 547.2499 , 50.12281 , "None"));
Path.Add(new Vector3(-11722.22 , 547.4397 , 49.87183 , "None"));
Path.Add(new Vector3(-11728.08 , 550.8496 , 49.65231 , "None"));
Path.Add(new Vector3(-11733.7 , 554.1253 , 50.23045 , "None"));
Path.Add(new Vector3(-11739.22 , 557.3407 , 50.74122 , "None"));
Path.Add(new Vector3(-11745.01 , 560.8293 , 50.90947 , "None"));
Path.Add(new Vector3(-11749.76 , 565.2929 , 53.627 , "None"));
Path.Add(new Vector3(-11754.41 , 569.6595 , 56.73395 , "None"));
Path.Add(new Vector3(-11759.13 , 574.0977 , 59.95994 , "None"));
Path.Add(new Vector3(-11763.98 , 578.6583 , 61.88065 , "None"));
Path.Add(new Vector3(-11768.54 , 583.4968 , 65.21638 , "None"));
Path.Add(new Vector3(-11771.66 , 589.1325 , 69.64745 , "None"));
Path.Add(new Vector3(-11773.97 , 595.153 , 68.38342 , "None"));
Path.Add(new Vector3(-11776.03 , 601.2666 , 67.00099 , "None"));
Path.Add(new Vector3(-11778.17 , 607.6122 , 68.28957 , "None"));
Path.Add(new Vector3(-11780.23 , 613.7137 , 70.81656 , "None"));
Path.Add(new Vector3(-11782.37 , 620.0471 , 72.88933 , "None"));
Path.Add(new Vector3(-11784.44 , 626.1617 , 73.37626 , "None"));
Path.Add(new Vector3(-11786.5 , 632.2807 , 73.66254 , "None"));
Path.Add(new Vector3(-11788.57 , 638.3944 , 70.86583 , "None"));
Path.Add(new Vector3(-11791.76 , 643.8094 , 67.25999 , "None"));
Path.Add(new Vector3(-11797.93 , 645.7044 , 61.56523 , "None"));
Path.Add(new Vector3(-11802.11 , 650.5718 , 60.17291 , "None"));
Path.Add(new Vector3(-11805.37 , 656.391 , 55.60687 , "None"));
Path.Add(new Vector3(-11810.45 , 659.7192 , 51.52929 , "None"));
Path.Add(new Vector3(-11815.91 , 663.2329 , 51.8552 , "None"));
Path.Add(new Vector3(-11818.56 , 668.7081 , 48.70517 , "None"));
Path.Add(new Vector3(-11819.06 , 675.1542 , 46.9257 , "None"));
Path.Add(new Vector3(-11819.58 , 681.8141 , 47.99806 , "None"));
Path.Add(new Vector3(-11820.07 , 688.042 , 46.04727 , "None"));
Path.Add(new Vector3(-11820.59 , 694.6936 , 44.58958 , "None"));
Path.Add(new Vector3(-11821.11 , 701.3581 , 44.58306 , "None"));
Path.Add(new Vector3(-11821.61 , 707.8043 , 44.77729 , "None"));
Path.Add(new Vector3(-11822.12 , 714.2761 , 45.12107 , "None"));
Path.Add(new Vector3(-11822.63 , 720.8905 , 45.2929 , "None"));
Path.Add(new Vector3(-11823.13 , 727.3238 , 45.68813 , "None"));
Path.Add(new Vector3(-11823.64 , 733.7828 , 43.30545 , "None"));
Path.Add(new Vector3(-11826.57 , 739.4689 , 39.20957 , "None"));
Path.Add(new Vector3(-11830.07 , 745.144 , 36.5197 , "None"));
Path.Add(new Vector3(-11834.69 , 749.645 , 30.21483 , "None"));
Path.Add(new Vector3(-11840.55 , 750.7253 , 26.28693 , "None"));
Path.Add(new Vector3(-11847.08 , 752.1132 , 22.24893 , "None"));
Path.Add(new Vector3(-11852.74 , 754.837 , 16.74619 , "None"));
Path.Add(new Vector3(-11857.25 , 759.421 , 11.97289 , "None"));
Path.Add(new Vector3(-11861.42 , 764.6296 , 8.749229 , "None"));
Path.Add(new Vector3(-11865.46 , 769.6774 , 6.779 , "None"));
Path.Add(new Vector3(-11869.5 , 774.7251 , 4.219303 , "None"));
Path.Add(new Vector3(-11873.54 , 779.7729 , 2.212762 , "None"));
Path.Add(new Vector3(-11877.64 , 784.891 , 0.7018313 , "None"));
Path.Add(new Vector3(-11881.65 , 789.8986 , 0.8049331 , "None"));
Path.Add(new Vector3(-11885.54 , 794.7552 , 0.9466879 , "None"));
Path.Add(new Vector3(-11889.88 , 800.175 , 1.744398 , "None"));
Path.Add(new Vector3(-11893.96 , 805.2731 , 1.434397 , "None"));
Path.Add(new Vector3(-11898.03 , 810.361 , 1.183619 , "None"));
Path.Add(new Vector3(-11902.2 , 815.5696 , 1.276989 , "None"));
Path.Add(new Vector3(-11906.13 , 820.4766 , 1.449705 , "None"));
Path.Add(new Vector3(-11910.15 , 825.5043 , 2.443833 , "None"));
Path.Add(new Vector3(-11914.39 , 830.8034 , 1.53764 , "None"));
Path.Add(new Vector3(-11919.83 , 834.5141 , 0.7476262 , "None"));
Path.Add(new Vector3(-11925.54 , 836.9202 , 0.7763492 , "None"));
Path.Add(new Vector3(-11931.72 , 839.5264 , 0.512179 , "None"));
Path.Add(new Vector3(-11937.86 , 842.1125 , -0.1997105 , "None"));
Path.Add(new Vector3(-11943.78 , 844.6086 , -1.369332 , "None"));
Path.Add(new Vector3(-11948.22 , 846.4847 , -2.285993 , "Swimming"));
Path.Add(new Vector3(-11950.49 , 847.4402 , -2.280927 , "Swimming"));
Path.Add(new Vector3(-11952.65 , 848.3499 , -2.276104 , "Swimming"));
Path.Add(new Vector3(-11954.91 , 849.3017 , -2.271057 , "Swimming"));
Path.Add(new Vector3(-11957.02 , 850.1912 , -2.266341 , "Swimming"));
Path.Add(new Vector3(-11959.27 , 851.1412 , -2.261305 , "Swimming"));
Path.Add(new Vector3(-11961.46 , 852.0618 , -2.256423 , "Swimming"));
Path.Add(new Vector3(-11963.72 , 853.0137 , -2.251377 , "Swimming"));
Path.Add(new Vector3(-11965.74 , 853.8684 , -1.944697 , "Swimming"));
Path.Add(new Vector3(-11967.88 , 854.7695 , 0.3101648 , "None"));
Path.Add(new Vector3(-11969.49 , 855.4481 , -0.9849627 , "None"));
Path.Add(new Vector3(-11972.32 , 856.64 , -2.644186 , "Swimming"));
Path.Add(new Vector3(-11974.58 , 857.5917 , -2.605136 , "Swimming"));
Path.Add(new Vector3(-11976.76 , 858.5123 , -2.567365 , "Swimming"));
Path.Add(new Vector3(-11978.87 , 859.3996 , -2.543451 , "Swimming"));
Path.Add(new Vector3(-11980.98 , 860.2905 , -2.519658 , "Swimming"));
Path.Add(new Vector3(-11983.17 , 861.2109 , -2.480842 , "Swimming"));
Path.Add(new Vector3(-11985.42 , 862.1606 , -2.440789 , "Swimming"));
Path.Add(new Vector3(-11987.61 , 863.081 , -2.401972 , "Swimming"));
Path.Add(new Vector3(-11989.86 , 864.0325 , -2.361841 , "Swimming"));
Path.Add(new Vector3(-11991.97 , 864.9199 , -2.324417 , "Swimming"));
Path.Add(new Vector3(-11994.23 , 865.8715 , -2.284286 , "Swimming"));
Path.Add(new Vector3(-11996.48 , 866.8212 , -2.244233 , "Swimming"));
Path.Add(new Vector3(-11998.67 , 867.7435 , -2.205339 , "Swimming"));
Path.Add(new Vector3(-12000.92 , 868.6913 , -2.165363 , "Swimming"));
Path.Add(new Vector3(-12003.1 , 869.6118 , -2.126547 , "Swimming"));
Path.Add(new Vector3(-12005.29 , 870.5321 , -2.08773 , "Swimming"));
Path.Add(new Vector3(-12007.47 , 871.4525 , -2.048914 , "Swimming"));
Path.Add(new Vector3(-12009.74 , 872.4096 , -2.008551 , "Swimming"));
Path.Add(new Vector3(-12011.91 , 873.3226 , -1.970044 , "Swimming"));
Path.Add(new Vector3(-12013.61 , 874.0375 , -0.3540012 , "None"));
Path.Add(new Vector3(-12014.72 , 874.5083 , -0.08219082 , "None"));
Path.Add(new Vector3(-12016.5 , 875.2573 , -1.581831 , "Swimming"));
Path.Add(new Vector3(-12018.69 , 876.1777 , -1.58193 , "Swimming"));
Path.Add(new Vector3(-12020.87 , 877.0983 , -1.582028 , "Swimming"));
Path.Add(new Vector3(-12023.2 , 878.0793 , -1.582133 , "Swimming"));
Path.Add(new Vector3(-12025.38 , 878.9998 , -1.582231 , "Swimming"));
Path.Add(new Vector3(-12027.64 , 879.9496 , -1.582332 , "Swimming"));
Path.Add(new Vector3(-12029.89 , 880.8995 , -1.582434 , "Swimming"));
Path.Add(new Vector3(-12032.13 , 881.4736 , -1.570462 , "Swimming"));
Path.Add(new Vector3(-12034.15 , 880.9932 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12036.32 , 881.1611 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12038.56 , 880.3969 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12040.88 , 879.6052 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12043.12 , 878.8425 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12045.44 , 878.0538 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12047.68 , 877.2911 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12049.92 , 876.5268 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12052.18 , 875.7565 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12054.49 , 874.9724 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12056.73 , 874.2097 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12058.97 , 873.4454 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12061.24 , 872.672 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12063.56 , 871.8834 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12065.77 , 871.1282 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12068.09 , 870.3381 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12070.33 , 869.5753 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12072.58 , 868.811 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12074.89 , 868.0224 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12077.14 , 867.2582 , -1.523511 , "Swimming"));
Path.Add(new Vector3(-12079.92 , 866.3071 , -1.093817 , "None"));
Path.Add(new Vector3(-12083.87 , 864.9626 , -0.07611177 , "None"));
Path.Add(new Vector3(-12085.9 , 864.2732 , 0.490524 , "None"));
Path.Add(new Vector3(-12087 , 867.6774 , 0.8586639 , "None"));
Path.Add(new Vector3(-12087.1 , 870.098 , 0.9090196 , "None"));
Path.Add(new Vector3(-12092.09 , 870.564 , 2.204629 , "None"));
Path.Add(new Vector3(-12098.65 , 869.7629 , 3.218278 , "None"));
Path.Add(new Vector3(-12105.01 , 868.9855 , 6.345846 , "None"));
Path.Add(new Vector3(-12111.56 , 868.1857 , 8.533266 , "None"));
Path.Add(new Vector3(-12117.11 , 870.2117 , 9.845049 , "None"));
Path.Add(new Vector3(-12123.65 , 871.3471 , 11.76844 , "None"));
Path.Add(new Vector3(-12130.18 , 872.4825 , 15.98192 , "None"));
Path.Add(new Vector3(-12136.65 , 873.6069 , 16.91053 , "None"));
Path.Add(new Vector3(-12142.91 , 874.6938 , 17.03638 , "None"));
Path.Add(new Vector3(-12149.42 , 875.8248 , 16.90588 , "None"));
Path.Add(new Vector3(-12155.99 , 876.9668 , 17.11321 , "None"));
Path.Add(new Vector3(-12162.36 , 878.0735 , 16.70433 , "None"));
Path.Add(new Vector3(-12168.72 , 879.1781 , 13.78362 , "None"));
Path.Add(new Vector3(-12175.31 , 880.3223 , 11.3112 , "None"));
Path.Add(new Vector3(-12181.68 , 881.429 , 9.646599 , "None"));
Path.Add(new Vector3(-12188.04 , 882.5336 , 6.739098 , "None"));
Path.Add(new Vector3(-12194.41 , 883.6403 , 4.183107 , "None"));
Path.Add(new Vector3(-12200.63 , 885.3425 , 2.498968 , "None"));
Path.Add(new Vector3(-12206.99 , 887.3502 , 1.19441 , "None"));
Path.Add(new Vector3(-12213.16 , 889.2959 , -0.9722291 , "None"));
Path.Add(new Vector3(-12216.73 , 890.4215 , -2.276871 , "Swimming"));
Path.Add(new Vector3(-12219.06 , 891.1576 , -2.275498 , "Swimming"));
Path.Add(new Vector3(-12221.32 , 891.871 , -2.274168 , "Swimming"));
Path.Add(new Vector3(-12223.66 , 892.6085 , -2.272792 , "Swimming"));
Path.Add(new Vector3(-12225.84 , 893.2977 , -2.271506 , "Swimming"));
Path.Add(new Vector3(-12228.17 , 894.0338 , -2.270133 , "Swimming"));
Path.Add(new Vector3(-12230.51 , 894.7713 , -2.268758 , "Swimming"));
Path.Add(new Vector3(-12232.77 , 895.4847 , -2.267427 , "Swimming"));
Path.Add(new Vector3(-12235.26 , 896.2705 , -2.265961 , "Swimming"));
Path.Add(new Vector3(-12237.27 , 896.9029 , -2.264781 , "Swimming"));
Path.Add(new Vector3(-12239.58 , 897.6347 , -2.263417 , "Swimming"));
Path.Add(new Vector3(-12241.92 , 898.3708 , -2.262043 , "Swimming"));
Path.Add(new Vector3(-12244.12 , 899.0671 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12244.9 , 898.4542 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12245.89 , 896.3699 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12246.15 , 893.9459 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12246.26 , 891.5961 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12247.05 , 889.2795 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12247.81 , 887.0344 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12248.57 , 884.7894 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12249.33 , 882.5443 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12250.12 , 880.2188 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12250.88 , 877.9648 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12251.64 , 875.7242 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12252.43 , 873.3898 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12253.22 , 871.0642 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12254.01 , 868.7432 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12254.79 , 866.4399 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12255.55 , 864.2128 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12256.34 , 861.8784 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12257.1 , 859.6288 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12257.87 , 857.3659 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12258.71 , 854.8659 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12259.38 , 852.8937 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12260.16 , 850.5995 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12260.93 , 848.3231 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12261.72 , 846.0065 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12262.48 , 843.7749 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12263.23 , 841.5433 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12264.02 , 839.2311 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12264.77 , 836.9951 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12265.55 , 834.7187 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12266.33 , 832.4155 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12267.07 , 830.2242 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12267.85 , 827.9344 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12268.62 , 825.6536 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12269.4 , 823.3504 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12270.15 , 821.1367 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12270.92 , 818.8648 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12271.7 , 816.575 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12272.47 , 814.3032 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12273.24 , 812.0179 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12274.01 , 809.746 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12274.77 , 807.4965 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12275.54 , 805.2425 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12276.3 , 803.0064 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12277.07 , 800.739 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12277.84 , 798.4537 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12278.63 , 796.1147 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12279.38 , 793.91 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12280.17 , 791.58 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12280.91 , 789.3931 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12281.73 , 786.9736 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12282.46 , 784.8314 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12283.24 , 782.5193 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12284 , 780.2877 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12284.76 , 778.0426 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12285.52 , 775.811 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12286.3 , 773.5078 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12287.06 , 771.2717 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12287.85 , 768.9283 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12288.6 , 766.7056 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12289.39 , 764.3845 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12290.22 , 761.9517 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12290.91 , 759.9078 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12291.7 , 757.5868 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12292.45 , 755.3552 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12293.24 , 753.0341 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12293.98 , 750.8383 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12294.76 , 748.5441 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12295.52 , 746.3169 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12296.3 , 744.0002 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12297.06 , 741.7642 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12297.84 , 739.4565 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12298.6 , 737.1317 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12297.88 , 734.9453 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12295.76 , 733.9018 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12293.53 , 732.9199 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12291.54 , 731.9462 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12291.15 , 733.6705 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12291.29 , 736.0651 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12291.44 , 738.4267 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12291.58 , 740.7977 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12291.72 , 743.2394 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12291.86 , 745.5256 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12292.01 , 747.9673 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12292.15 , 750.3337 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12292.26 , 752.2286 , -2.260745 , "Swimming"));
Path.Add(new Vector3(-12292.73 , 753.003 , -2.248821 , "Swimming"));
Path.Add(new Vector3(-12294.08 , 754.9788 , -2.21408 , "Swimming"));
Path.Add(new Vector3(-12295.79 , 756.1587 , -2.181222 , "Swimming"));
Path.Add(new Vector3(-12297.99 , 755.3751 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12300.29 , 754.5533 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12302.72 , 754.5179 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12304.9 , 754.8706 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12306.24 , 756.8278 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12307.62 , 758.8511 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12308.96 , 760.8044 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12310.33 , 762.8239 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12311.67 , 764.7771 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12313.01 , 766.7382 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12314.39 , 768.7576 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12315.71 , 770.6875 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12317.04 , 772.629 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12317.49 , 773.2877 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12317.13 , 772.5181 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12315.32 , 771.012 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12313.05 , 770.0908 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12310.78 , 769.509 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12308.44 , 769.6832 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12306.14 , 770.2523 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12303.75 , 770.403 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12301.55 , 769.5477 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12299.27 , 768.6533 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12297.13 , 767.8174 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12294.86 , 766.9247 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12292.65 , 766.0596 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12290.37 , 765.1652 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12288.16 , 764.3018 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12285.96 , 763.4366 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12283.75 , 762.5715 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12281.46 , 761.6719 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12279.34 , 760.8412 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12277.01 , 759.9312 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12275.07 , 759.1677 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12272.87 , 758.306 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12271.77 , 757.8752 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12270.67 , 757.4443 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12267.77 , 756.3087 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12265.55 , 755.4366 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12263.45 , 754.6129 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12261.09 , 753.6908 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12258.79 , 752.7878 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12256.62 , 751.9381 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12254.33 , 751.0402 , -2.161898 , "Swimming"));
Path.Add(new Vector3(-12252.03 , 749.9692 , -0.01612447 , "None"));
Path.Add(new Vector3(-12252.59 , 744.0134 , -0.01612447 , "None"));
Path.Add(new Vector3(-12255.41 , 737.7256 , -0.01612447 , "None"));
Path.Add(new Vector3(-12257.97 , 732.0256 , -0.01612447 , "None"));
Path.Add(new Vector3(-12260.64 , 726.0552 , -0.01612447 , "None"));
Path.Add(new Vector3(-12263.35 , 720.0261 , -0.01612447 , "None"));
Path.Add(new Vector3(-12266.09 , 713.9029 , -0.01612447 , "None"));
Path.Add(new Vector3(-12268.7 , 708.097 , -0.01612447 , "None"));
Path.Add(new Vector3(-12271.41 , 702.0444 , -0.01612447 , "None"));
Path.Add(new Vector3(-12274.1 , 696.0505 , -0.01612447 , "None"));
Path.Add(new Vector3(-12276.79 , 690.0331 , -0.01612447 , "None"));
Path.Add(new Vector3(-12279.36 , 684.3095 , -0.01612447 , "None"));
Path.Add(new Vector3(-12282.06 , 678.2803 , -0.01612447 , "None"));
Path.Add(new Vector3(-12284.46 , 672.9329 , -0.01612447 , "None"));
Path.Add(new Vector3(-12285.78 , 669.9992 , -0.01612447 , "None"));
Path.Add(new Vector3(-12286.6 , 666.6291 , -0.01612447 , "None"));
Path.Add(new Vector3(-12287.32 , 672.5147 , -0.01612447 , "None"));
Path.Add(new Vector3(-12287.38 , 679.1863 , -0.01612447 , "None"));
Path.Add(new Vector3(-12287.44 , 685.8707 , -0.01612447 , "None"));
Path.Add(new Vector3(-12287.5 , 692.1172 , -0.01612447 , "None"));
Path.Add(new Vector3(-12287.56 , 698.8146 , -0.01612447 , "None"));
Path.Add(new Vector3(-12287.62 , 705.5634 , -0.01612447 , "None"));
Path.Add(new Vector3(-12287.68 , 711.9517 , -0.01612447 , "None"));
Path.Add(new Vector3(-12287.74 , 718.3914 , -0.01612447 , "None"));
Path.Add(new Vector3(-12287.79 , 724.2872 , -0.01612447 , "None"));
Path.Add(new Vector3(-12287.85 , 730.8043 , -0.01612447 , "None"));
Path.Add(new Vector3(-12287.91 , 737.5016 , -0.01612447 , "None"));
Path.Add(new Vector3(-12287.97 , 743.8383 , -0.01612447 , "None"));
Path.Add(new Vector3(-12288.03 , 750.4326 , -0.01612447 , "None"));
Path.Add(new Vector3(-12288.72 , 753.3137 , -0.01612447 , "None"));
Path.Add(new Vector3(-12295.11 , 753.7868 , -0.01612447 , "None"));
Path.Add(new Vector3(-12301.81 , 754.2837 , -0.01612447 , "None"));
Path.Add(new Vector3(-12306.67 , 757.8147 , -0.01612447 , "None"));
Path.Add(new Vector3(-12310.35 , 763.1291 , -0.01612447 , "None"));
Path.Add(new Vector3(-12314.04 , 768.4435 , -0.01612447 , "None"));
Path.Add(new Vector3(-12317.72 , 773.7578 , -0.01612447 , "None"));
Path.Add(new Vector3(-12321.52 , 779.2416 , -0.01612447 , "None"));
Path.Add(new Vector3(-12325.46 , 783.7271 , -0.01612447 , "None"));
Path.Add(new Vector3(-12331.76 , 782.2752 , -0.01612447 , "None"));
Path.Add(new Vector3(-12338.26 , 780.7772 , -0.01612447 , "None"));
Path.Add(new Vector3(-12344.56 , 779.3253 , -0.01612447 , "None"));
Path.Add(new Vector3(-12351.06 , 777.8272 , -0.01612447 , "None"));
Path.Add(new Vector3(-12357.58 , 776.3262 , -0.01612447 , "None"));
Path.Add(new Vector3(-12363.88 , 774.8745 , -0.01612447 , "None"));
Path.Add(new Vector3(-12370.17 , 773.4255 , -0.01612447 , "None"));
Path.Add(new Vector3(-12376.47 , 771.9737 , -0.01612447 , "None"));
Path.Add(new Vector3(-12382.97 , 770.4756 , -0.01612447 , "None"));
Path.Add(new Vector3(-12389.48 , 768.9746 , -0.01612447 , "None"));
Path.Add(new Vector3(-12395.78 , 767.5228 , -0.01612447 , "None"));
Path.Add(new Vector3(-12401.87 , 766.1202 , -0.01612447 , "None"));
Path.Add(new Vector3(-12408.37 , 764.6221 , -0.01612447 , "None"));
Path.Add(new Vector3(-12414.52 , 763.205 , -0.01612447 , "None"));
Path.Add(new Vector3(-12421.19 , 761.6693 , -0.01612447 , "None"));
Path.Add(new Vector3(-12427.47 , 760.2204 , -0.01612447 , "None"));
Path.Add(new Vector3(-12433.78 , 758.7686 , -0.01612447 , "None"));
Path.Add(new Vector3(-12440.28 , 757.2704 , -0.01612447 , "None"));
Path.Add(new Vector3(-12446.59 , 755.8157 , -0.01612447 , "None"));
Path.Add(new Vector3(-12452.88 , 754.3668 , -0.01612447 , "None"));
Path.Add(new Vector3(-12459.38 , 752.8688 , -0.01612447 , "None"));
Path.Add(new Vector3(-12465.69 , 751.4141 , -0.01612447 , "None"));
Path.Add(new Vector3(-12471.98 , 749.9651 , -0.01612447 , "None"));
Path.Add(new Vector3(-12478.29 , 748.5104 , -0.01612447 , "None"));
Path.Add(new Vector3(-12484.8 , 747.0123 , -0.01612447 , "None"));
Path.Add(new Vector3(-12490.88 , 745.6097 , -0.01612447 , "None"));
Path.Add(new Vector3(-12497.2 , 744.155 , -0.01612447 , "None"));
Path.Add(new Vector3(-12502.86 , 742.8506 , -0.01612447 , "None"));
Path.Add(new Vector3(-12511.62 , 740.832 , 0.8374957 , "None"));
Path.Add(new Vector3(-12514.73 , 737.8965 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12516.88 , 734.4736 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12519.03 , 731.0539 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12521.19 , 727.6448 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12523.43 , 724.11 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12525.59 , 720.7078 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12527.84 , 717.1941 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12530.03 , 713.7854 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12532.23 , 710.3594 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12534.39 , 707.0056 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12537.58 , 705.3052 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12540.69 , 704.6399 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12544.77 , 703.7698 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12548.59 , 702.9552 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12552.68 , 702.0834 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12556.68 , 701.2285 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12560.62 , 700.3887 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12564.56 , 699.5471 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12568.7 , 698.6636 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12572.69 , 697.8137 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12576.58 , 696.9822 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12580.06 , 696.2398 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12586.37 , 694.0534 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12592.42 , 691.9366 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12598.69 , 690.3008 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12605.35 , 690.6297 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12611.75 , 691.512 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12618.14 , 692.3926 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12624.55 , 693.2749 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12631.17 , 694.1871 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12637.56 , 695.0677 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12644.19 , 695.9799 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12650.57 , 696.8587 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12656.98 , 697.7428 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12663.17 , 698.5953 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12670.01 , 699.5374 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12676.4 , 700.4179 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12682.95 , 701.3196 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12689.21 , 702.1826 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12695.91 , 703.1053 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12702.33 , 703.9894 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12707.82 , 704.7452 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12715 , 705.7347 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12721.7 , 706.6575 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12727.29 , 707.4274 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12734.56 , 708.4292 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12740.95 , 709.3098 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12747.37 , 710.1938 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12752.81 , 710.9426 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12760.68 , 712.0271 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12766.06 , 712.7688 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12773.54 , 713.7988 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12779.93 , 714.6793 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12786.4 , 715.5705 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12792.82 , 716.4545 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12799.26 , 717.3422 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12805.81 , 718.2438 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12812.19 , 719.1226 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12818.7 , 720.019 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12825.24 , 720.9207 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12831.62 , 721.7995 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12838.08 , 722.6888 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12842.32 , 723.2724 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12848.46 , 724.1196 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12857.56 , 725.3728 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12863.88 , 726.2428 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12870.44 , 727.1462 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12876.97 , 728.0461 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12882.93 , 728.8669 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12889.87 , 729.8231 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12896.4 , 730.723 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12902.72 , 731.593 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12909.4 , 732.514 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12915.7 , 733.3806 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12921.37 , 734.1627 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12926.03 , 734.8042 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12935.32 , 736.0838 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12941.6 , 736.9485 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12948.16 , 737.8519 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12954.66 , 738.7484 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12961.21 , 739.65 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12967.43 , 740.5078 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12974.13 , 741.4305 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12980.44 , 742.2988 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12986.91 , 743.1899 , 0.0005996302 , "None"));
Path.Add(new Vector3(-12993.38 , 744.081 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13000.04 , 744.9985 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13006.54 , 745.8949 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13012.87 , 746.7667 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13019.2 , 747.6384 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13025.68 , 748.5313 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13032.32 , 749.4453 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13038.7 , 750.3241 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13045.2 , 751.2205 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13051.7 , 752.1151 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13058.09 , 752.9957 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13064.71 , 753.9079 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13071.11 , 754.7885 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13077.51 , 755.6708 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13083.92 , 756.5532 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13090.53 , 757.4636 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13096.93 , 758.3459 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13103.34 , 759.2283 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13107.47 , 759.7977 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13116.91 , 761.0984 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13123.3 , 761.9789 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13129.71 , 762.8613 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13136.4 , 763.7823 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13142.79 , 764.6628 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13149.35 , 765.5663 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13155.75 , 766.4486 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13162.15 , 767.3292 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13168.55 , 768.2115 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13174.96 , 769.0939 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13181.55 , 770.0025 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13187.98 , 770.8884 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13194.16 , 771.7391 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13201 , 772.6812 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13207.22 , 773.5389 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13213.8 , 774.4441 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13220.41 , 775.3545 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13226.81 , 776.2369 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13233.22 , 777.1192 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13239.84 , 778.0314 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13246.45 , 778.9418 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13252.85 , 779.8242 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13257.56 , 780.4698 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13265.18 , 780.7294 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13271.94 , 780.9597 , 0.0005996302 , "None"));
Path.Add(new Vector3(-13278.41 , 781.1801 , 0.5189722 , "None"));
Path.Add(new Vector3(-13285.11 , 781.4081 , 1.285573 , "None"));
Path.Add(new Vector3(-13291.67 , 781.6318 , 1.284014 , "None"));
Path.Add(new Vector3(-13298.12 , 781.8514 , 1.727258 , "None"));
Path.Add(new Vector3(-13304.58 , 782.0716 , 1.836393 , "None"));
Path.Add(new Vector3(-13311.2 , 782.2191 , 1.353627 , "None"));
Path.Add(new Vector3(-13317.65 , 782.0555 , 2.45068 , "None"));
Path.Add(new Vector3(-13324.2 , 781.8894 , 3.078366 , "None"));
Path.Add(new Vector3(-13330.65 , 781.7259 , 2.045438 , "None"));
Path.Add(new Vector3(-13337.31 , 781.5571 , 1.056072 , "None"));
Path.Add(new Vector3(-13343.78 , 781.3932 , 1.200291 , "None"));
Path.Add(new Vector3(-13350.46 , 781.2239 , 2.023308 , "None"));
Path.Add(new Vector3(-13356.77 , 781.0639 , 2.945665 , "None"));
Path.Add(new Vector3(-13363.38 , 780.8962 , 3.146922 , "None"));
Path.Add(new Vector3(-13370.04 , 780.7274 , 1.553144 , "None"));
Path.Add(new Vector3(-13376.39 , 780.5665 , 0.3199974 , "None"));
Path.Add(new Vector3(-13383.11 , 780.3961 , 0.02689486 , "None"));
Path.Add(new Vector3(-13389.32 , 780.2388 , 0.03401137 , "None"));
Path.Add(new Vector3(-13395.65 , 780.0782 , 0.0009423001 , "None"));
Path.Add(new Vector3(-13402.45 , 779.9059 , 0.0009423001 , "None"));
Path.Add(new Vector3(-13408.97 , 779.7407 , 0.0009423001 , "None"));
Path.Add(new Vector3(-13415.44 , 779.5765 , 0.0009423001 , "None"));
Path.Add(new Vector3(-13422.24 , 779.4042 , 0.0009423001 , "None"));
Path.Add(new Vector3(-13428.38 , 779.2485 , 0.0009423001 , "None"));
Path.Add(new Vector3(-13435.27 , 779.0739 , 0.0009423001 , "None"));
Path.Add(new Vector3(-13441.76 , 778.9094 , 0.0009423001 , "None"));
Path.Add(new Vector3(-13448.17 , 778.7468 , 0.0009423001 , "None"));
Path.Add(new Vector3(-13454.59 , 778.4772 , 0.0009423001 , "None"));
Path.Add(new Vector3(-13461.41 , 777.8013 , 0.0009423001 , "None"));
Path.Add(new Vector3(-13467.73 , 777.1748 , 0.0009423001 , "None"));
Path.Add(new Vector3(-13474.38 , 776.5153 , 0.3562858 , "None"));
Path.Add(new Vector3(-13480.56 , 775.9029 , 0.6987509 , "None"));
Path.Add(new Vector3(-13487.24 , 775.2408 , 1.258825 , "None"));
Path.Add(new Vector3(-13493.66 , 774.6042 , 1.730185 , "None"));
Path.Add(new Vector3(-13500.19 , 773.9562 , 2.274191 , "None"));
Path.Add(new Vector3(-13506.72 , 773.3094 , 3.618326 , "None"));
Path.Add(new Vector3(-13513.36 , 772.6512 , 4.036029 , "None"));
Path.Add(new Vector3(-13519.57 , 772.0349 , 5.094358 , "None"));
Path.Add(new Vector3(-13526.23 , 771.3755 , 6.551732 , "None"));
Path.Add(new Vector3(-13532.61 , 770.7427 , 6.931159 , "None"));
Path.Add(new Vector3(-13539.22 , 770.087 , 5.992906 , "None"));
Path.Add(new Vector3(-13545.64 , 769.4504 , 3.013557 , "None"));
Path.Add(new Vector3(-13552.27 , 768.7935 , 0.8038253 , "None"));
Path.Add(new Vector3(-13558.67 , 768.1594 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13565.28 , 767.5037 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13571.57 , 766.8798 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13578.16 , 766.2267 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13584.69 , 765.5799 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13591.12 , 764.942 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13597.81 , 764.2787 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13604.17 , 763.6485 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13610.68 , 763.003 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13617.37 , 762.3397 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13623.8 , 761.7018 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13628.52 , 761.2342 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13636.88 , 760.4057 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13643.31 , 759.7678 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13649.75 , 759.1299 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13656.18 , 758.4921 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13662.82 , 757.8339 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13669.46 , 757.1757 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13675.89 , 756.5378 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13682.33 , 755.8999 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13688.92 , 755.2468 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13695.2 , 754.6241 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13701.69 , 753.9799 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13708.13 , 753.342 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13714.78 , 752.6826 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13721.43 , 752.0231 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13728.15 , 751.3572 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13734.26 , 750.7512 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13740.72 , 750.1107 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13747.28 , 749.4601 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13753.72 , 748.8223 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13760.4 , 748.1602 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13766.87 , 747.5186 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13773.39 , 746.8718 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13779.69 , 746.2479 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13786.38 , 745.5846 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13792.89 , 744.9391 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13799.21 , 744.3126 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13805.99 , 743.6404 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13812.15 , 743.0292 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13818.83 , 742.3672 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13825.43 , 741.7128 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13831.74 , 741.0876 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13838.3 , 740.4371 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13844.91 , 739.7814 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13851.18 , 739.16 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13857.88 , 738.4955 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13864.19 , 737.8703 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13870.7 , 737.2248 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13877.31 , 736.5692 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13883.8 , 735.9262 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13890.26 , 735.2858 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13896.72 , 734.6453 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13903.31 , 733.9922 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13909.55 , 733.3734 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13916.13 , 732.7216 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13922.78 , 732.0621 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13929.13 , 731.4318 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13936.03 , 730.7482 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13942.54 , 730.1027 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13948.85 , 729.4775 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13955.67 , 728.8015 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13962.18 , 728.156 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13964.65 , 727.9107 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13968.94 , 727.485 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13975.58 , 726.8268 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13982.03 , 726.1877 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13988.45 , 725.5511 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13994.01 , 724.9996 , 0.0007859617 , "None"));
Path.Add(new Vector3(-13999.09 , 724.4963 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14005 , 723.9106 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14011.45 , 723.2714 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14017.53 , 721.7228 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14022.05 , 718.4109 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14028.31 , 713.8278 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14033.69 , 709.884 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14038.17 , 705.2386 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14042.68 , 700.3229 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14047.05 , 695.5589 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14051.66 , 690.5388 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14056.08 , 685.7179 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14060.3 , 681.1153 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14064.81 , 676.1995 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14069.19 , 671.4261 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14073.73 , 666.4818 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14078.07 , 661.7559 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14082.44 , 656.9919 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14087.11 , 652.6089 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14092.79 , 649.5092 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14098.64 , 646.3108 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14104.46 , 643.5415 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14110.8 , 641.4488 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14116.77 , 639.6431 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14123.42 , 638.6826 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14129.78 , 637.7643 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14136.18 , 636.8406 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14142.78 , 635.8874 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14149.35 , 634.9397 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14155.57 , 634.0417 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14162.19 , 633.0867 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14168.38 , 632.1882 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14174.97 , 631.2372 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14181.37 , 630.3137 , 0.0007859617 , "None"));
Path.Add(new Vector3(-14183.09 , 630.0292 , -1.996085 , "None"));
Path.Add(new Vector3(-14184.57 , 629.8126 , -2.294528 , "Swimming"));
Path.Add(new Vector3(-14187 , 629.4626 , -2.291559 , "Swimming"));
Path.Add(new Vector3(-14189.19 , 629.147 , -2.288881 , "Swimming"));
Path.Add(new Vector3(-14191.77 , 628.7748 , -2.285722 , "Swimming"));
Path.Add(new Vector3(-14193.87 , 628.4708 , -2.283141 , "Swimming"));
Path.Add(new Vector3(-14196.5 , 628.0925 , -2.279931 , "Swimming"));
Path.Add(new Vector3(-14198.8 , 627.7594 , -2.277104 , "Swimming"));
Path.Add(new Vector3(-14201.23 , 627.4101 , -2.27414 , "Swimming"));
Path.Add(new Vector3(-14203.65 , 627.0609 , -2.271176 , "Swimming"));
Path.Add(new Vector3(-14206 , 626.7217 , -2.268298 , "Swimming"));
Path.Add(new Vector3(-14208.26 , 626.3953 , -2.265529 , "Swimming"));
Path.Add(new Vector3(-14210.68 , 626.046 , -2.262565 , "Swimming"));
Path.Add(new Vector3(-14213.03 , 625.7076 , -2.259692 , "Swimming"));
Path.Add(new Vector3(-14215.45 , 625.3583 , -2.256728 , "Swimming"));
Path.Add(new Vector3(-14217.79 , 625.0198 , -2.253856 , "Swimming"));
Path.Add(new Vector3(-14220.18 , 624.6759 , -2.250937 , "Swimming"));
Path.Add(new Vector3(-14222.49 , 624.3428 , -2.248111 , "Swimming"));
Path.Add(new Vector3(-14224.91 , 623.9935 , -2.245147 , "Swimming"));
Path.Add(new Vector3(-14227.33 , 623.6436 , -2.242177 , "Swimming"));
Path.Add(new Vector3(-14229.68 , 623.3059 , -2.23931 , "Swimming"));
Path.Add(new Vector3(-14232.03 , 622.9691 , -2.236432 , "Swimming"));
Path.Add(new Vector3(-14234.45 , 622.6223 , -2.233468 , "Swimming"));
Path.Add(new Vector3(-14236.79 , 622.2861 , -2.230595 , "Swimming"));
Path.Add(new Vector3(-14239.14 , 621.9506 , -2.227729 , "Swimming"));
Path.Add(new Vector3(-14241.56 , 621.6031 , -2.224759 , "Swimming"));
Path.Add(new Vector3(-14243.88 , 621.2717 , -2.221926 , "Swimming"));
Path.Add(new Vector3(-14246.28 , 620.9282 , -2.218991 , "Swimming"));
Path.Add(new Vector3(-14248.58 , 620.5974 , -2.216164 , "Swimming"));
Path.Add(new Vector3(-14251.02 , 620.2485 , -2.213183 , "Swimming"));
Path.Add(new Vector3(-14253.34 , 619.9158 , -2.210339 , "Swimming"));
Path.Add(new Vector3(-14255.64 , 619.587 , -2.20753 , "Swimming"));
Path.Add(new Vector3(-14258.07 , 619.2381 , -2.204548 , "Swimming"));
Path.Add(new Vector3(-14260.49 , 618.8926 , -2.201596 , "Swimming"));
Path.Add(new Vector3(-14262.84 , 618.5558 , -2.198718 , "Swimming"));
Path.Add(new Vector3(-14264.64 , 616.9725 , -2.193175 , "Swimming"));
Path.Add(new Vector3(-14266.33 , 615.3073 , -2.187772 , "Swimming"));
Path.Add(new Vector3(-14268.08 , 613.5925 , -2.182208 , "Swimming"));
Path.Add(new Vector3(-14269.77 , 611.9272 , -2.176805 , "Swimming"));
Path.Add(new Vector3(-14271.46 , 610.272 , -2.171433 , "Swimming"));
Path.Add(new Vector3(-14273.15 , 608.6101 , -2.166041 , "Swimming"));
Path.Add(new Vector3(-14274.89 , 606.8953 , -2.161723 , "Swimming"));
Path.Add(new Vector3(-14276.58 , 605.2334 , -2.161723 , "Swimming"));
Path.Add(new Vector3(-14278.27 , 603.5715 , -2.161723 , "Swimming"));
Path.Add(new Vector3(-14280.01 , 601.8566 , -2.161723 , "Swimming"));
Path.Add(new Vector3(-14281.65 , 600.251 , -2.161723 , "Swimming"));
Path.Add(new Vector3(-14283.3 , 598.6288 , -2.161723 , "Swimming"));
Path.Add(new Vector3(-14285.09 , 597.0181 , -2.348667 , "Swimming"));
Path.Add(new Vector3(-14286.46 , 596.4494 , -3.300611 , "Swimming"));
Path.Add(new Vector3(-14287.71 , 595.8676 , -4.14922 , "Swimming"));
Path.Add(new Vector3(-14288.95 , 595.1503 , -4.939545 , "Swimming"));
Path.Add(new Vector3(-14289.96 , 594.437 , -5.560518 , "Swimming"));
Path.Add(new Vector3(-14290.95 , 593.4372 , -6.127714 , "Swimming"));
Path.Add(new Vector3(-14291.72 , 592.653 , -6.565671 , "Swimming"));
Path.Add(new Vector3(-14292.33 , 591.9736 , -6.893392 , "Swimming"));
Path.Add(new Vector3(-14292.8 , 591.4598 , -7.138753 , "Swimming"));
Path.Add(new Vector3(-14293.15 , 591.0781 , -7.316873 , "Swimming"));
Path.Add(new Vector3(-14293.45 , 590.709 , -7.485474 , "Swimming"));
Path.Add(new Vector3(-14295.42 , 590.341 , -6.935896 , "Swimming"));
Path.Add(new Vector3(-14296.37 , 590.454 , -7.317899 , "Swimming"));
Path.Add(new Vector3(-14298.29 , 589.2922 , -7.490417 , "Swimming"));
Path.Add(new Vector3(-14299.06 , 590.2747 , -7.54167 , "Swimming"));
Path.Add(new Vector3(-14299.02 , 590.9871 , -7.540957 , "Swimming"));
Path.Add(new Vector3(-14300.13 , 590.0137 , -7.372858 , "Swimming"));
Path.Add(new Vector3(-14298.36 , 589.6025 , -7.356637 , "Swimming"));
Path.Add(new Vector3(-14296.32 , 589.6793 , -7.419569 , "Swimming"));
Path.Add(new Vector3(-14297.01 , 588.5437 , -7.388424 , "Swimming"));
Path.Add(new Vector3(-14298.16 , 586.7662 , -6.534445 , "Swimming"));
Path.Add(new Vector3(-14299.45 , 585.0822 , -5.346458 , "Swimming"));
Path.Add(new Vector3(-14300.73 , 583.4161 , -4.289242 , "Swimming"));
Path.Add(new Vector3(-14299.89 , 584.6534 , -5.045942 , "Swimming"));
Path.Add(new Vector3(-14298.89 , 585.9472 , -5.754089 , "Swimming"));
Path.Add(new Vector3(-14298.14 , 586.9297 , -6.28476 , "Swimming"));
Path.Add(new Vector3(-14297.61 , 587.6147 , -6.650378 , "Swimming"));
Path.Add(new Vector3(-14298.46 , 586.6638 , -6.572248 , "Swimming"));
Path.Add(new Vector3(-14300.1 , 584.8397 , -6.572773 , "Swimming"));
Path.Add(new Vector3(-14301.68 , 583.0788 , -6.573279 , "Swimming"));
Path.Add(new Vector3(-14302.82 , 581.8226 , -6.40062 , "Swimming"));
Path.Add(new Vector3(-14304.4 , 580.0613 , -6.410799 , "Swimming"));
Path.Add(new Vector3(-14305.98 , 578.2931 , -6.421019 , "Swimming"));
Path.Add(new Vector3(-14307.39 , 576.7206 , -6.308121 , "Swimming"));
Path.Add(new Vector3(-14309.03 , 574.8983 , -6.327054 , "Swimming"));
Path.Add(new Vector3(-14310.25 , 573.5261 , -5.778773 , "Swimming"));
Path.Add(new Vector3(-14311.48 , 572.1552 , -4.550637 , "Swimming"));
Path.Add(new Vector3(-14312.58 , 570.9323 , -3.245602 , "Swimming"));
Path.Add(new Vector3(-14313.51 , 569.8959 , -1.853191 , "Swimming"));
Path.Add(new Vector3(-14314.79 , 568.4682 , -0.7961995 , "None"));
Path.Add(new Vector3(-14315.75 , 567.3978 , 0.0009631254 , "None"));
Path.Add(new Vector3(-14318.46 , 564.3778 , 0.0009631254 , "None"));
Path.Add(new Vector3(-14320.88 , 561.6815 , 0.0009631254 , "None"));
Path.Add(new Vector3(-14323.85 , 558.3881 , 0.0009631254 , "None"));
Path.Add(new Vector3(-14326.63 , 555.2806 , 0.0009631254 , "None"));
Path.Add(new Vector3(-14327.41 , 554.4263 , -0.06709591 , "None"));
Path.Add(new Vector3(-14328.26 , 553.5077 , -1.688731 , "Swimming"));
Path.Add(new Vector3(-14329.87 , 551.6791 , -1.727591 , "Swimming"));
Path.Add(new Vector3(-14331.44 , 549.6534 , -1.720443 , "Swimming"));
Path.Add(new Vector3(-14332.91 , 547.7503 , -1.710336 , "Swimming"));
Path.Add(new Vector3(-14334.35 , 545.8809 , -1.700409 , "Swimming"));
Path.Add(new Vector3(-14335.81 , 543.989 , -1.690362 , "Swimming"));
Path.Add(new Vector3(-14337.27 , 542.097 , -1.680315 , "Swimming"));
Path.Add(new Vector3(-14338.68 , 540.2725 , -1.670625 , "Swimming"));
Path.Add(new Vector3(-14340.18 , 538.3207 , -1.660261 , "Swimming"));
Path.Add(new Vector3(-14341.67 , 536.3951 , -1.650035 , "Swimming"));
Path.Add(new Vector3(-14343.12 , 534.522 , -1.640088 , "Swimming"));
Path.Add(new Vector3(-14344.1 , 532.7527 , -1.63742 , "Swimming"));
Path.Add(new Vector3(-14345.37 , 530.4391 , -1.633962 , "Swimming"));
Path.Add(new Vector3(-14346.44 , 528.494 , -1.631054 , "Swimming"));
Path.Add(new Vector3(-14347.73 , 526.1473 , -1.627547 , "Swimming"));
Path.Add(new Vector3(-14348.92 , 523.9869 , -1.624317 , "Swimming"));
Path.Add(new Vector3(-14349.89 , 522.2155 , -1.62167 , "Swimming"));
Path.Add(new Vector3(-14351.19 , 519.8523 , -1.618137 , "Swimming"));
Path.Add(new Vector3(-14352.35 , 517.7457 , -1.614988 , "Swimming"));
Path.Add(new Vector3(-14353.2 , 516.1854 , -1.612656 , "Swimming"));
Path.Add(new Vector3(-14354.54 , 513.7601 , -1.609031 , "Swimming"));
Path.Add(new Vector3(-14355.75 , 511.5542 , -1.605734 , "Swimming"));
Path.Add(new Vector3(-14356.91 , 509.4434 , -1.602578 , "Swimming"));
Path.Add(new Vector3(-14357.77 , 507.8665 , -1.600221 , "Swimming"));
Path.Add(new Vector3(-14359.16 , 505.3461 , -1.596454 , "Swimming"));
Path.Add(new Vector3(-14360.11 , 503.6078 , -1.593856 , "Swimming"));
Path.Add(new Vector3(-14361.48 , 501.1122 , -1.590125 , "Swimming"));
Path.Add(new Vector3(-14362.5 , 499.2663 , -1.587366 , "Swimming"));
Path.Add(new Vector3(-14363.8 , 496.8989 , -1.583827 , "Swimming"));
Path.Add(new Vector3(-14364.84 , 495.0075 , -1.581 , "Swimming"));
Path.Add(new Vector3(-14365.88 , 493.112 , -1.578167 , "Swimming"));
Path.Add(new Vector3(-14367.15 , 490.7985 , -1.574709 , "Swimming"));
Path.Add(new Vector3(-14368.3 , 488.7043 , -1.571578 , "Swimming"));
Path.Add(new Vector3(-14369.18 , 487.1108 , -1.569197 , "Swimming"));
Path.Add(new Vector3(-14370.05 , 485.5216 , -1.566821 , "Swimming"));
Path.Add(new Vector3(-14371.49 , 482.8935 , -1.562893 , "Swimming"));
Path.Add(new Vector3(-14372.66 , 480.7662 , -1.559713 , "Swimming"));
Path.Add(new Vector3(-14373.83 , 478.6389 , -1.556533 , "Swimming"));
Path.Add(new Vector3(-14374.81 , 476.8551 , -1.553867 , "Swimming"));
Path.Add(new Vector3(-14376.09 , 474.5291 , -1.55039 , "Swimming"));
Path.Add(new Vector3(-14377.26 , 472.3936 , -1.547198 , "Swimming"));
Path.Add(new Vector3(-14378.3 , 470.5063 , -1.544494 , "Swimming"));
Path.Add(new Vector3(-14378.98 , 468.2705 , -1.524253 , "Swimming"));
Path.Add(new Vector3(-14379.63 , 466.0523 , -1.524563 , "Swimming"));
Path.Add(new Vector3(-14380.05 , 464.6201 , -1.525373 , "Swimming"));
Path.Add(new Vector3(-14380.55 , 462.9386 , -1.52477 , "Swimming"));
Path.Add(new Vector3(-14381.23 , 460.6408 , -1.524459 , "Swimming"));
Path.Add(new Vector3(-14381.87 , 458.4737 , -1.524251 , "Swimming"));
Path.Add(new Vector3(-14382.52 , 456.2652 , -1.524252 , "Swimming"));
Path.Add(new Vector3(-14383.19 , 453.9969 , -1.524254 , "Swimming"));
Path.Add(new Vector3(-14383.81 , 451.89 , -1.525253 , "Swimming"));
Path.Add(new Vector3(-14384.45 , 449.7619 , -1.524252 , "Swimming"));
Path.Add(new Vector3(-14385.1 , 447.589 , -1.524252 , "Swimming"));
Path.Add(new Vector3(-14385.69 , 445.6556 , -1.524252 , "Swimming"));
Path.Add(new Vector3(-14386.34 , 443.4825 , -1.524252 , "Swimming"));
Path.Add(new Vector3(-14386.94 , 441.5035 , -1.524252 , "Swimming"));
Path.Add(new Vector3(-14387.52 , 439.5169 , -1.525257 , "Swimming"));
Path.Add(new Vector3(-14388.07 , 437.664 , -1.525255 , "Swimming"));
Path.Add(new Vector3(-14388.58 , 435.9427 , -1.524254 , "Swimming"));
Path.Add(new Vector3(-14389.07 , 434.3036 , -1.525255 , "Swimming"));
Path.Add(new Vector3(-14389.49 , 432.8674 , -1.526265 , "Swimming"));
Path.Add(new Vector3(-14389.88 , 431.5631 , -1.525299 , "Swimming"));
Path.Add(new Vector3(-14390.19 , 430.5027 , -1.524254 , "Swimming"));
Path.Add(new Vector3(-14390.46 , 429.6034 , -1.526267 , "Swimming"));
Path.Add(new Vector3(-14390.67 , 428.8627 , -1.524255 , "Swimming"));
Path.Add(new Vector3(-14390.85 , 428.2665 , -1.526262 , "Swimming"));
Path.Add(new Vector3(-14390.42 , 427.7373 , -1.527273 , "Swimming"));
Path.Add(new Vector3(-14389.72 , 426.8526 , 0.3269944 , "None"));
Path.Add(new Vector3(-14390.12 , 425.6341 , -0.4938929 , "None"));
Path.Add(new Vector3(-14391.15 , 425.2409 , -1.525306 , "Swimming"));
Path.Add(new Vector3(-14392.64 , 425.1465 , -1.525401 , "Swimming"));
Path.Add(new Vector3(-14394.02 , 425.0598 , -1.525255 , "Swimming"));
Path.Add(new Vector3(-14395.2 , 424.9852 , -1.524255 , "Swimming"));
Path.Add(new Vector3(-14396.19 , 424.9229 , -1.524621 , "Swimming"));
Path.Add(new Vector3(-14397.04 , 424.8694 , -1.526793 , "Swimming"));
Path.Add(new Vector3(-14397.68 , 424.8275 , -1.524772 , "Swimming"));
Path.Add(new Vector3(-14398.13 , 423.3983 , -1.540521 , "Swimming"));
Path.Add(new Vector3(-14399.03 , 423.093 , 0.560257 , "None"));
Path.Add(new Vector3(-14400.28 , 423.1678 , -1.207913 , "None"));
Path.Add(new Vector3(-14401.65 , 422.4823 , -1.360423 , "None"));
Path.Add(new Vector3(-14402.3 , 423.5507 , 0.4558504 , "None"));
Path.Add(new Vector3(-14403.29 , 424.4286 , -1.534789 , "Swimming"));
Path.Add(new Vector3(-14405.51 , 424.5276 , -1.524436 , "Swimming"));
Path.Add(new Vector3(-14407.61 , 424.6212 , -1.524431 , "Swimming"));
Path.Add(new Vector3(-14409.66 , 424.7127 , -1.524252 , "Swimming"));
Path.Add(new Vector3(-14411.65 , 424.8014 , -1.524287 , "Swimming"));
Path.Add(new Vector3(-14413.64 , 424.8897 , -1.524253 , "Swimming"));
Path.Add(new Vector3(-14415.47 , 424.9711 , -1.524618 , "Swimming"));
Path.Add(new Vector3(-14417.17 , 425.0472 , -1.525259 , "Swimming"));
Path.Add(new Vector3(-14418.79 , 425.1196 , -1.524885 , "Swimming"));
Path.Add(new Vector3(-14420.21 , 425.1825 , -1.525994 , "Swimming"));
Path.Add(new Vector3(-14421.46 , 425.2382 , -1.525558 , "Swimming"));
Path.Add(new Vector3(-14422.55 , 425.2863 , -1.524723 , "Swimming"));
Path.Add(new Vector3(-14423.51 , 425.3289 , -1.525814 , "Swimming"));
Path.Add(new Vector3(-14424.28 , 425.3628 , -1.525255 , "Swimming"));
Path.Add(new Vector3(-14424.89 , 425.3899 , -0.9430211 , "None"));
Path.Add(new Vector3(-14426.15 , 425.4456 , -0.6364631 , "None"));
Path.Add(new Vector3(-14426.48 , 425.4604 , -1.585161 , "Swimming"));
Path.Add(new Vector3(-14426.76 , 425.4645 , -0.5070748 , "None"));
Path.Add(new Vector3(-14428.01 , 425.483 , -0.9772408 , "None"));
Path.Add(new Vector3(-14429.27 , 425.0577 , -1.525254 , "Swimming"));
Path.Add(new Vector3(-14430.64 , 424.4988 , -1.518469 , "Swimming"));
Path.Add(new Vector3(-14434.13 , 423.0773 , -0.1885021 , "None"));
Path.Add(new Vector3(-14434.76 , 422.8177 , 0.2329044 , "None"));
Path.Add(new Vector3(-14434.36 , 425.3468 , -1.342179 , "None"));
Path.Add(new Vector3(-14434.22 , 425.9568 , -1.579406 , "Swimming"));
Path.Add(new Vector3(-14432.31 , 424.3668 , -1.34207 , "None"));
Path.Add(new Vector3(-14430.41 , 422.3807 , -0.9045213 , "None"));
Path.Add(new Vector3(-14429.56 , 421.7304 , -0.9165925 , "None"));
Path.Add(new Vector3(-14426.31 , 419.3309 , -0.8825458 , "None"));
Path.Add(new Vector3(-14422.95 , 416.8549 , -1.015089 , "None"));
Path.Add(new Vector3(-14419.81 , 414.5367 , -1.267022 , "None"));
Path.Add(new Vector3(-14416.85 , 412.3542 , -1.533833 , "Swimming"));
Path.Add(new Vector3(-14414.94 , 410.9467 , -1.527442 , "Swimming"));
Path.Add(new Vector3(-14412.98 , 409.4942 , -1.524029 , "Swimming"));
Path.Add(new Vector3(-14411.07 , 408.0895 , -1.524029 , "Swimming"));
Path.Add(new Vector3(-14409.1 , 406.6342 , -1.524029 , "Swimming"));
Path.Add(new Vector3(-14407.26 , 405.2743 , -1.524029 , "Swimming"));
Path.Add(new Vector3(-14405.29 , 403.8219 , -1.524029 , "Swimming"));
Path.Add(new Vector3(-14403.38 , 402.4143 , -1.524029 , "Swimming"));
Path.Add(new Vector3(-14401.41 , 400.9619 , -1.524029 , "Swimming"));
Path.Add(new Vector3(-14399.51 , 399.5543 , -1.524029 , "Swimming"));
Path.Add(new Vector3(-14397.59 , 398.1411 , -1.524029 , "Swimming"));
Path.Add(new Vector3(-14395.63 , 396.6971 , -1.524029 , "Swimming"));
Path.Add(new Vector3(-14393.72 , 395.3872 , -1.524029 , "Swimming"));
Path.Add(new Vector3(-14393.3 , 396.4573 , -1.526258 , "Swimming"));
Path.Add(new Vector3(-14393.15 , 397.4249 , -1.530269 , "Swimming"));
Path.Add(new Vector3(-14393.03 , 398.1919 , -1.529269 , "Swimming"));
Path.Add(new Vector3(-14392.94 , 398.81 , -1.524254 , "Swimming"));
Path.Add(new Vector3(-14394.29 , 399.5468 , -0.5958993 , "None"));
Path.Add(new Vector3(-14394.02 , 400.7734 , 0.4069066 , "None"));
Path.Add(new Vector3(-14394.17 , 402.1822 , -1.524253 , "Swimming"));
Path.Add(new Vector3(-14395.13 , 403.8993 , -1.525269 , "Swimming"));
Path.Add(new Vector3(-14396.13 , 405.6761 , -1.525253 , "Swimming"));
Path.Add(new Vector3(-14397.05 , 407.3148 , -1.524253 , "Swimming"));
Path.Add(new Vector3(-14397.94 , 408.8897 , -1.525254 , "Swimming"));
Path.Add(new Vector3(-14398.71 , 410.272 , -1.52425 , "Swimming"));
Path.Add(new Vector3(-14399.43 , 411.5839 , -1.524273 , "Swimming"));
Path.Add(new Vector3(-14400.07 , 412.7357 , -1.52429 , "Swimming"));
Path.Add(new Vector3(-14400.6 , 413.6845 , -1.524313 , "Swimming"));
Path.Add(new Vector3(-14400.9 , 414.2526 , -1.526271 , "Swimming"));
Path.Add(new Vector3(-14401.42 , 414.0681 , -1.526298 , "Swimming"));
Path.Add(new Vector3(-14402.53 , 414.164 , 0.2792068 , "None"));
Path.Add(new Vector3(-14403.1 , 415.2777 , -0.3352378 , "None"));
Path.Add(new Vector3(-14403.26 , 415.8084 , -1.524253 , "Swimming"));
Path.Add(new Vector3(-14402.56 , 416.0101 , -1.525291 , "Swimming"));
Path.Add(new Vector3(-14401.65 , 416.5208 , 0.3920777 , "None"));
Path.Add(new Vector3(-14401.39 , 417.7496 , -0.5516278 , "None"));
Path.Add(new Vector3(-14401.39 , 418.1215 , -1.625566 , "Swimming"));
Path.Add(new Vector3(-14402.51 , 417.1702 , -0.1563013 , "None"));
Path.Add(new Vector3(-14403 , 417.0841 , -1.530932 , "Swimming"));
Path.Add(new Vector3(-14402.96 , 417.1246 , -0.3834445 , "None"));
Path.Add(new Vector3(-14402.79 , 417.2763 , 0.2962942 , "None"));
Path.Add(new Vector3(-14402.41 , 417.5869 , -1.528478 , "Swimming"));
Path.Add(new Vector3(-14402.65 , 419.6824 , -1.530746 , "Swimming"));
Path.Add(new Vector3(-14403.75 , 421.8636 , -1.530746 , "Swimming"));
Path.Add(new Vector3(-14404.91 , 423.9335 , -1.530746 , "Swimming"));
Path.Add(new Vector3(-14405.09 , 425.855 , -1.523874 , "Swimming"));
Path.Add(new Vector3(-14403.54 , 427.6418 , -1.523874 , "Swimming"));
Path.Add(new Vector3(-14401.24 , 428.4482 , -1.523874 , "Swimming"));
Path.Add(new Vector3(-14398.94 , 428.5403 , -1.523874 , "Swimming"));
Path.Add(new Vector3(-14397.48 , 427.1676 , -1.523874 , "Swimming"));
Path.Add(new Vector3(-14396.99 , 424.7865 , -1.523874 , "Swimming"));
Path.Add(new Vector3(-14396.57 , 422.3953 , -1.523874 , "Swimming"));
Path.Add(new Vector3(-14397.28 , 423.8587 , -1.52425 , "Swimming"));
Path.Add(new Vector3(-14397.78 , 426.0788 , -1.510923 , "Swimming"));
Path.Add(new Vector3(-14399 , 428.0867 , -1.524471 , "Swimming"));
Path.Add(new Vector3(-14400.39 , 429.9959 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14401.93 , 431.9037 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14403.41 , 433.7524 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14404.94 , 435.6638 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14405.56 , 437.7665 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14407.04 , 439.6153 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14408.52 , 441.4604 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14410.05 , 443.3681 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14411.54 , 445.2169 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14413.02 , 447.0731 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14414.55 , 448.9734 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14416.36 , 450.4854 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14418.29 , 451.8605 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14420.28 , 453.2794 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14422.21 , 454.6546 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14424.14 , 456.0297 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14426.07 , 457.4048 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14428.06 , 458.8238 , -1.524269 , "Swimming"));
Path.Add(new Vector3(-14430.39 , 458.84 , 0.6076366 , "None"));
Path.Add(new Vector3(-14433.27 , 458.4403 , 0.2803029 , "None"));
Path.Add(new Vector3(-14436.99 , 457.0468 , 2.970074 , "None"));
Path.Add(new Vector3(-14440.95 , 457.3525 , 3.786833 , "None"));
Path.Add(new Vector3(-14442.24 , 455.8843 , 3.759127 , "None"));
Path.Add(new Vector3(-14439.75 , 452.9309 , 3.760774 , "None"));
Path.Add(new Vector3(-14438.15 , 451.0349 , 3.73989 , "None"));
Path.Add(new Vector3(-14439.08 , 447.6198 , 3.701019 , "None"));
Path.Add(new Vector3(-14441.18 , 441.3427 , 3.718816 , "None"));
Path.Add(new Vector3(-14441.1 , 439.1917 , 3.931956 , "None"));
Path.Add(new Vector3(-14439.67 , 440.2359 , 3.806525 , "None"));
Path.Add(new Vector3(-14441.31 , 439.1981 , 3.768397 , "None"));
Path.Add(new Vector3(-14441.33 , 439.1446 , 5.054763 , "None"));
Path.Add(new Vector3(-14441.33 , 439.172 , 4.381893 , "None"));
Path.Add(new Vector3(-14441.17 , 439.3382 , 3.714786 , "None"));
Path.Add(new Vector3(-14438.67 , 436.9325 , 4.199624 , "None"));
Path.Add(new Vector3(-14437.17 , 435.3693 , 4.19292 , "None"));
Path.Add(new Vector3(-14439.33 , 433.4376 , 4.196887 , "None"));
Path.Add(new Vector3(-14443.17 , 431.8254 , 4.182671 , "None"));
Path.Add(new Vector3(-14443.11 , 428.9658 , 5.350528 , "None"));
Path.Add(new Vector3(-14440.55 , 425.766 , 9.06221 , "None"));
Path.Add(new Vector3(-14437.27 , 426.3798 , 10.93936 , "None"));
Path.Add(new Vector3(-14434.16 , 429.1569 , 14.76083 , "None"));
Path.Add(new Vector3(-14435.8 , 432.6794 , 15.56721 , "None"));
Path.Add(new Vector3(-14437.91 , 436.2739 , 15.58013 , "None"));
Path.Add(new Vector3(-14439.64 , 439.7536 , 15.3236 , "None"));
Path.Add(new Vector3(-14439.94 , 442.8438 , 15.35038 , "None"));
Path.Add(new Vector3(-14436.26 , 443.5634 , 15.51199 , "None"));
Path.Add(new Vector3(-14433.65 , 440.5066 , 16.32734 , "None"));
Path.Add(new Vector3(-14430.78 , 437.4769 , 17.43365 , "None"));
Path.Add(new Vector3(-14428 , 434.5408 , 18.82416 , "None"));
Path.Add(new Vector3(-14425.14 , 431.5135 , 20.96206 , "None"));
Path.Add(new Vector3(-14422.36 , 428.5775 , 21.90645 , "None"));
Path.Add(new Vector3(-14419.49 , 425.542 , 21.99244 , "None"));
Path.Add(new Vector3(-14416.29 , 423.2786 , 22.12094 , "None"));
Path.Add(new Vector3(-14412.64 , 421.5461 , 22.24516 , "None"));
Path.Add(new Vector3(-14409.04 , 419.718 , 22.33461 , "None"));
Path.Add(new Vector3(-14405.32 , 417.8316 , 22.44268 , "None"));
Path.Add(new Vector3(-14401.71 , 416.0035 , 22.52282 , "None"));
Path.Add(new Vector3(-14397.99 , 414.1134 , 22.60912 , "None"));
Path.Add(new Vector3(-14394.39 , 412.2889 , 22.68946 , "None"));
Path.Add(new Vector3(-14391.62 , 409.582 , 22.75773 , "None"));
Path.Add(new Vector3(-14393.99 , 406.9245 , 22.72398 , "None"));
Path.Add(new Vector3(-14395.29 , 403.1055 , 22.70006 , "None"));
Path.Add(new Vector3(-14396.43 , 399.7282 , 22.67441 , "None"));
Path.Add(new Vector3(-14396.47 , 399.2271 , 22.67181 , "None"));
Path.Add(new Vector3(-14393.41 , 403.7125 , 22.72025 , "None"));
Path.Add(new Vector3(-14391.98 , 409.9199 , 22.7529 , "None"));
Path.Add(new Vector3(-14396.96 , 413.6936 , 22.63533 , "None"));
Path.Add(new Vector3(-14402.51 , 417.4271 , 22.49727 , "None"));
Path.Add(new Vector3(-14408.55 , 420.1599 , 22.34066 , "None"));
Path.Add(new Vector3(-14414.61 , 422.4175 , 22.18231 , "None"));
Path.Add(new Vector3(-14420.85 , 423.7475 , 21.91351 , "None"));
Path.Add(new Vector3(-14426.93 , 421.8991 , 21.99838 , "None"));
Path.Add(new Vector3(-14433.04 , 419.2282 , 22.21921 , "None"));
Path.Add(new Vector3(-14438.97 , 416.6399 , 23.83883 , "None"));
Path.Add(new Vector3(-14444.59 , 413.5977 , 25.01898 , "None"));
Path.Add(new Vector3(-14448.91 , 417.1676 , 25.04599 , "None"));
Path.Add(new Vector3(-14452.88 , 422.5424 , 25.08334 , "None"));
Path.Add(new Vector3(-14456.59 , 427.565 , 25.15902 , "None"));
Path.Add(new Vector3(-14460.58 , 431.2383 , 25.22054 , "None"));
Path.Add(new Vector3(-14462.64 , 437.0183 , 27.3302 , "None"));
Path.Add(new Vector3(-14465.97 , 442.5606 , 30.08627 , "None"));
Path.Add(new Vector3(-14469.41 , 448.2795 , 30.52384 , "None"));
Path.Add(new Vector3(-14471.43 , 454.2967 , 30.48518 , "None"));
Path.Add(new Vector3(-14470.03 , 460.7906 , 30.5935 , "None"));
Path.Add(new Vector3(-14468.41 , 466.8229 , 30.67742 , "None"));
Path.Add(new Vector3(-14466.9 , 473.3021 , 29.59561 , "None"));
Path.Add(new Vector3(-14466.58 , 479.7647 , 26.88412 , "None"));
Path.Add(new Vector3(-14471.04 , 485.0431 , 26.76764 , "None"));
Path.Add(new Vector3(-14472.26 , 490.0678 , 26.55104 , "None"));
Path.Add(new Vector3(-14467.69 , 494.6062 , 25.64768 , "None"));
Path.Add(new Vector3(-14464.54 , 497.7267 , 26.27309 , "None"));
Path.Add(new Vector3(-14460.84 , 498.6619 , 26.27309 , "None"));
Path.Add(new Vector3(-14456.8 , 498.7707 , 26.27309 , "None"));
Path.Add(new Vector3(-14455.86 , 498.7961 , 26.27309 , "None"));
Path.Add(new Vector3(-14454.19 , 497.514 , 26.27513 , "None"));
Path.Add(new Vector3(-14452.81 , 496.2295 , 26.28001 , "None"));
Path.Add(new Vector3(-14451.95 , 494.127 , 26.28541 , "None"));
Path.Add(new Vector3(-14450.18 , 490.5554 , 25.26019 , "None"));
Path.Add(new Vector3(-14446.49 , 489.4268 , 23.94031 , "None"));
Path.Add(new Vector3(-14447.43 , 492.1643 , 21.64684 , "None"));
Path.Add(new Vector3(-14449.91 , 495.0769 , 21.60588 , "None"));
Path.Add(new Vector3(-14453.01 , 493.09 , 21.82683 , "None"));
Path.Add(new Vector3(-14455.98 , 490.2043 , 20.69091 , "None"));
Path.Add(new Vector3(-14458.85 , 487.3898 , 20.09475 , "None"));
Path.Add(new Vector3(-14461.72 , 484.5838 , 20.37478 , "None"));
Path.Add(new Vector3(-14464.52 , 482.3657 , 20.37633 , "None"));
Path.Add(new Vector3(-14468.27 , 483.8029 , 20.37815 , "None"));
Path.Add(new Vector3(-14470.18 , 487.3393 , 20.37928 , "None"));
Path.Add(new Vector3(-14471.5 , 491.2202 , 20.37985 , "None"));
Path.Add(new Vector3(-14469.06 , 493.7383 , 19.76487 , "None"));
Path.Add(new Vector3(-14466.17 , 496.4324 , 18.07925 , "None"));
Path.Add(new Vector3(-14463.37 , 499.5214 , 16.07526 , "None"));
Path.Add(new Vector3(-14459.78 , 500.0815 , 15.12041 , "None"));
Path.Add(new Vector3(-14459.35 , 496.3062 , 15.12272 , "None"));
Path.Add(new Vector3(-14459.26 , 492.3161 , 15.12472 , "None"));
Path.Add(new Vector3(-14457.32 , 490.7761 , 15.12472 , "None"));
Path.Add(new Vector3(-14458.82 , 490.3401 , 15.12472 , "None"));
Path.Add(new Vector3(-14462.75 , 491.2784 , 15.12084 , "None"));
Path.Add(new Vector3(-14466.67 , 492.2149 , 15.11688 , "None"));
Path.Add(new Vector3(-14470.77 , 492.5915 , 15.23671 , "None"));
Path.Add(new Vector3(-14471.02 , 489.8578 , 14.90428 , "None"));
Path.Add(new Vector3(-14468.65 , 486.6596 , 14.89948 , "None"));
Path.Add(new Vector3(-14465.44 , 484.1026 , 14.89797 , "None"));
Path.Add(new Vector3(-14462.28 , 481.3778 , 14.90476 , "None"));
Path.Add(new Vector3(-14459.14 , 478.6726 , 14.96343 , "None"));
Path.Add(new Vector3(-14455.55 , 477.2395 , 15.04738 , "None"));
Path.Add(new Vector3(-14451.58 , 477.7662 , 15.10131 , "None"));
Path.Add(new Vector3(-14447.56 , 478.8022 , 15.15176 , "None"));
Path.Add(new Vector3(-14445.49 , 482.2637 , 15.12387 , "None"));
Path.Add(new Vector3(-14443.44 , 485.7486 , 15.08426 , "None"));
Path.Add(new Vector3(-14441.33 , 489.3445 , 14.47238 , "None"));
Path.Add(new Vector3(-14439.28 , 492.8363 , 13.76995 , "None"));
Path.Add(new Vector3(-14437.24 , 496.3142 , 12.94551 , "None"));
Path.Add(new Vector3(-14435.19 , 499.7991 , 11.15916 , "None"));
Path.Add(new Vector3(-14433.08 , 503.395 , 9.117158 , "None"));
Path.Add(new Vector3(-14431.04 , 506.8799 , 7.168555 , "None"));
Path.Add(new Vector3(-14428.92 , 510.4758 , 5.22666 , "None"));
Path.Add(new Vector3(-14425.65 , 512.539 , 4.94507 , "None"));
Path.Add(new Vector3(-14422.2 , 514.5035 , 4.970786 , "None"));
Path.Add(new Vector3(-14425.96 , 511.5955 , 4.939503 , "None"));
Path.Add(new Vector3(-14430.53 , 507.3986 , 6.812156 , "None"));
Path.Add(new Vector3(-14434.25 , 501.8432 , 10.08573 , "None"));
Path.Add(new Vector3(-14437.84 , 496.4697 , 13.01796 , "None"));
Path.Add(new Vector3(-14441.55 , 490.925 , 14.34476 , "None"));
Path.Add(new Vector3(-14444.62 , 485.382 , 15.07918 , "None"));
Path.Add(new Vector3(-14443.82 , 478.9934 , 15.19388 , "None"));
Path.Add(new Vector3(-14442.6 , 472.4347 , 15.27878 , "None"));
Path.Add(new Vector3(-14441.41 , 466.0786 , 15.3792 , "None"));
Path.Add(new Vector3(-14440.23 , 459.7224 , 15.37224 , "None"));
Path.Add(new Vector3(-14437.79 , 453.6071 , 15.35809 , "None"));
Path.Add(new Vector3(-14434.56 , 447.9927 , 15.43443 , "None"));
Path.Add(new Vector3(-14431.18 , 442.5005 , 16.22454 , "None"));
Path.Add(new Vector3(-14427.46 , 437.2312 , 18.11746 , "None"));
Path.Add(new Vector3(-14423.6 , 431.7725 , 21.42867 , "None"));
Path.Add(new Vector3(-14419.87 , 426.4926 , 22.00552 , "None"));
Path.Add(new Vector3(-14414.89 , 422.6617 , 22.17124 , "None"));
Path.Add(new Vector3(-14409.12 , 419.7428 , 22.33262 , "None"));
Path.Add(new Vector3(-14403.17 , 416.7308 , 22.4928 , "None"));
Path.Add(new Vector3(-14397.4 , 413.8118 , 22.62484 , "None"));
Path.Add(new Vector3(-14392.14 , 410.1057 , 22.75273 , "None"));
Path.Add(new Vector3(-14393.23 , 403.9147 , 22.72488 , "None"));
Path.Add(new Vector3(-14389.64 , 398.4315 , 22.85001 , "None"));
Path.Add(new Vector3(-14386.31 , 393.7343 , 22.99657 , "None"));
Path.Add(new Vector3(-14381.26 , 388.4414 , 23.053 , "None"));
Path.Add(new Vector3(-14375.79 , 385.3662 , 22.61507 , "None"));
Path.Add(new Vector3(-14369.22 , 384.1781 , 22.85095 , "None"));
Path.Add(new Vector3(-14363.03 , 383.6489 , 23.40851 , "None"));
Path.Add(new Vector3(-14356.85 , 385.4894 , 23.28947 , "None"));
Path.Add(new Vector3(-14350.7 , 387.819 , 23.2794 , "None"));
Path.Add(new Vector3(-14344.45 , 390.1878 , 23.12443 , "None"));
Path.Add(new Vector3(-14338.13 , 392.584 , 23.22545 , "None"));
Path.Add(new Vector3(-14332.17 , 394.8434 , 23.17755 , "None"));
Path.Add(new Vector3(-14326.19 , 397.1072 , 23.41766 , "None"));
Path.Add(new Vector3(-14321.75 , 400.8198 , 24.01998 , "None"));
Path.Add(new Vector3(-14320.02 , 406.6486 , 23.90372 , "None"));
Path.Add(new Vector3(-14318.92 , 413.1769 , 23.69666 , "None"));
Path.Add(new Vector3(-14317.74 , 419.4818 , 23.41229 , "None"));
Path.Add(new Vector3(-14316.54 , 425.9005 , 23.12158 , "None"));
Path.Add(new Vector3(-14315.9 , 432.3788 , 22.74621 , "None"));
Path.Add(new Vector3(-14316.06 , 433.3102 , 22.75154 , "None"));
Path.Add(new Vector3(-14316.87 , 437.8635 , 22.86702 , "None"));
Path.Add(new Vector3(-14318.01 , 444.3447 , 23.11023 , "None"));
Path.Add(new Vector3(-14319.16 , 450.8512 , 23.39775 , "None"));
Path.Add(new Vector3(-14318.87 , 457.2815 , 22.61734 , "None"));
Path.Add(new Vector3(-14317.1 , 463.5545 , 20.07534 , "None"));
Path.Add(new Vector3(-14315.4 , 469.6043 , 18.43655 , "None"));
Path.Add(new Vector3(-14313.27 , 475.8917 , 17.99608 , "None"));
Path.Add(new Vector3(-14310.42 , 481.7828 , 15.11271 , "None"));
Path.Add(new Vector3(-14307.59 , 487.6275 , 13.23966 , "None"));
Path.Add(new Vector3(-14304.67 , 493.6809 , 11.66888 , "None"));
Path.Add(new Vector3(-14301.93 , 499.3517 , 10.22248 , "None"));
Path.Add(new Vector3(-14300.95 , 501.3811 , 9.710321 , "None"));
Path.Add(new Vector3(-14304.27 , 497.523 , 10.80797 , "None"));
Path.Add(new Vector3(-14307.15 , 491.7352 , 12.28436 , "None"));
Path.Add(new Vector3(-14310.04 , 485.9359 , 13.79596 , "None"));
Path.Add(new Vector3(-14312.92 , 480.1597 , 16.12286 , "None"));
Path.Add(new Vector3(-14315.59 , 474.0922 , 18.38395 , "None"));
Path.Add(new Vector3(-14317 , 467.791 , 18.47998 , "None"));
Path.Add(new Vector3(-14318.46 , 461.2803 , 21.0961 , "None"));
Path.Add(new Vector3(-14319.57 , 455.1792 , 23.57746 , "None"));
Path.Add(new Vector3(-14318.36 , 448.6084 , 23.33247 , "None"));
Path.Add(new Vector3(-14317.26 , 442.0273 , 23.02625 , "None"));
Path.Add(new Vector3(-14316.2 , 435.6494 , 22.83258 , "None"));
Path.Add(new Vector3(-14315.8 , 429.7476 , 22.94868 , "None"));
Path.Add(new Vector3(-14317.09 , 422.9787 , 23.25315 , "None"));
Path.Add(new Vector3(-14318.3 , 416.6273 , 23.53903 , "None"));
Path.Add(new Vector3(-14319.56 , 410.0621 , 23.83417 , "None"));
Path.Add(new Vector3(-14320.81 , 403.5744 , 23.96212 , "None"));
Path.Add(new Vector3(-14323.9 , 398.2906 , 23.82182 , "None"));
Path.Add(new Vector3(-14329.84 , 395.805 , 23.25607 , "None"));
Path.Add(new Vector3(-14335.48 , 393.6407 , 23.21711 , "None"));
Path.Add(new Vector3(-14341.71 , 391.2503 , 23.07244 , "None"));
Path.Add(new Vector3(-14348.14 , 388.7815 , 23.36675 , "None"));
Path.Add(new Vector3(-14350.09 , 388.032 , 23.26837 , "None"));
Path.Add(new Vector3(-14352.91 , 386.9563 , 23.36871 , "None"));
Path.Add(new Vector3(-14358.75 , 384.7267 , 23.21279 , "None"));
Path.Add(new Vector3(-14365.23 , 383.6726 , 23.36039 , "None"));
Path.Add(new Vector3(-14371.63 , 384.5397 , 22.62716 , "None"));
Path.Add(new Vector3(-14378.11 , 385.8756 , 22.70831 , "None"));
Path.Add(new Vector3(-14382.83 , 390.2643 , 23.02902 , "None"));
Path.Add(new Vector3(-14387.1 , 394.807 , 22.97455 , "None"));
Path.Add(new Vector3(-14391.25 , 400.3094 , 22.77768 , "None"));
Path.Add(new Vector3(-14392.72 , 405.8449 , 22.73129 , "None"));
Path.Add(new Vector3(-14393.47 , 411.7816 , 22.71265 , "None"));
Path.Add(new Vector3(-14399.27 , 414.6301 , 22.5804 , "None"));
Path.Add(new Vector3(-14405.26 , 417.5686 , 22.44979 , "None"));
Path.Add(new Vector3(-14411.07 , 420.4164 , 22.28819 , "None"));
Path.Add(new Vector3(-14416.84 , 423.3164 , 22.10046 , "None"));
Path.Add(new Vector3(-14421.44 , 428.1449 , 21.98146 , "None"));
Path.Add(new Vector3(-14425.91 , 432.8242 , 20.14976 , "None"));
Path.Add(new Vector3(-14430.51 , 437.6572 , 17.4474 , "None"));
Path.Add(new Vector3(-14434.97 , 442.3365 , 15.73362 , "None"));
Path.Add(new Vector3(-14440.59 , 441.2433 , 15.34147 , "None"));
Path.Add(new Vector3(-14437.88 , 435.8242 , 15.5825 , "None"));
Path.Add(new Vector3(-14435.16 , 431.2348 , 15.57012 , "None"));
Path.Add(new Vector3(-14434.92 , 427.705 , 13.4195 , "None"));
Path.Add(new Vector3(-14437.33 , 424.7992 , 10.14337 , "None"));
Path.Add(new Vector3(-14437.99 , 420.9278 , 9.014797 , "None"));
Path.Add(new Vector3(-14434.3 , 420.9547 , 8.852685 , "None"));
Path.Add(new Vector3(-14430.69 , 423.0539 , 8.847203 , "None"));
Path.Add(new Vector3(-14427.2 , 425.0883 , 8.856092 , "None"));
Path.Add(new Vector3(-14423.24 , 426.0969 , 9.013347 , "None"));
Path.Add(new Vector3(-14419.29 , 426.705 , 9.013861 , "None"));
Path.Add(new Vector3(-14415.25 , 427.3279 , 8.965599 , "None"));
Path.Add(new Vector3(-14419.33 , 425.8357 , 9.02098 , "None"));
Path.Add(new Vector3(-14426 , 425.3781 , 9.005569 , "None"));
Path.Add(new Vector3(-14431.12 , 422.963 , 8.85226 , "None"));
Path.Add(new Vector3(-14437.19 , 421.3584 , 8.995671 , "None"));
Path.Add(new Vector3(-14437.61 , 422.049 , 9.048529 , "None"));
Path.Add(new Vector3(-14438.87 , 421.2375 , 9.939727 , "None"));
Path.Add(new Vector3(-14437.91 , 421.8517 , 10.19364 , "None"));
Path.Add(new Vector3(-14437.58 , 422.1368 , 9.755143 , "None"));
Path.Add(new Vector3(-14437.56 , 422.0482 , 9.047463 , "None"));
Path.Add(new Vector3(-14438.54 , 422.6117 , 9.061281 , "None"));
Path.Add(new Vector3(-14437.48 , 424.073 , 9.690243 , "None"));
Path.Add(new Vector3(-14435.39 , 425.6604 , 12.03171 , "None"));
Path.Add(new Vector3(-14432.27 , 427.1428 , 15.12465 , "None"));
Path.Add(new Vector3(-14434.12 , 430.1956 , 15.55723 , "None"));
Path.Add(new Vector3(-14437.71 , 431.9323 , 15.59013 , "None"));
Path.Add(new Vector3(-14440.83 , 430.0204 , 15.55684 , "None"));
Path.Add(new Vector3(-14441.45 , 426.5359 , 15.55684 , "None"));
Path.Add(new Vector3(-14440 , 424.3012 , 15.8633 , "None"));
Path.Add(new Vector3(-14436.65 , 426.8352 , 19.29478 , "None"));
Path.Add(new Vector3(-14435.74 , 430.3238 , 20.29184 , "None"));
Path.Add(new Vector3(-14439.38 , 432.0733 , 20.3427 , "None"));
Path.Add(new Vector3(-14443.15 , 432.9578 , 20.3267 , "None"));
Path.Add(new Vector3(-14446.95 , 431.2313 , 20.27862 , "None"));
Path.Add(new Vector3(-14450.37 , 429.361 , 22.17224 , "None"));
Path.Add(new Vector3(-14454.04 , 427.3596 , 24.46076 , "None"));
Path.Add(new Vector3(-14456.64 , 426.1312 , 25.14025 , "None"));
Path.Add(new Vector3(-14459.04 , 427.0663 , 25.16247 , "None"));
Path.Add(new Vector3(-14459.21 , 429.4193 , 25.19586 , "None"));
Path.Add(new Vector3(-14459.89 , 431.1974 , 25.22261 , "None"));
Path.Add(new Vector3(-14460.09 , 434.2512 , 25.74231 , "None"));
Path.Add(new Vector3(-14462.1 , 438.0001 , 27.54815 , "None"));
Path.Add(new Vector3(-14464.41 , 441.3488 , 29.28334 , "None"));
Path.Add(new Vector3(-14466.72 , 444.7042 , 30.81568 , "None"));
Path.Add(new Vector3(-14469.05 , 448.0927 , 30.54657 , "None"));
Path.Add(new Vector3(-14471.1 , 451.6944 , 30.49642 , "None"));
Path.Add(new Vector3(-14471.63 , 455.6152 , 30.4614 , "None"));
Path.Add(new Vector3(-14470.56 , 459.51 , 30.5775 , "None"));
Path.Add(new Vector3(-14469.53 , 463.1907 , 30.62795 , "None"));
Path.Add(new Vector3(-14468.37 , 467.2897 , 30.68421 , "None"));
Path.Add(new Vector3(-14467.24 , 471.3036 , 30.6653 , "None"));
Path.Add(new Vector3(-14466.7 , 475.2779 , 28.45737 , "None"));
Path.Add(new Vector3(-14466.5 , 479.4431 , 26.88523 , "None"));
Path.Add(new Vector3(-14468.47 , 482.5822 , 26.79558 , "None"));
Path.Add(new Vector3(-14471.31 , 485.6432 , 26.75146 , "None"));
Path.Add(new Vector3(-14473.7 , 488.8448 , 26.65687 , "None"));
Path.Add(new Vector3(-14472.59 , 490.1233 , 26.5593 , "None"));
Path.Add(new Vector3(-14470.02 , 491.8468 , 25.73601 , "None"));
Path.Add(new Vector3(-14467.21 , 494.8087 , 25.69796 , "None"));
Path.Add(new Vector3(-14464.46 , 497.7064 , 26.27231 , "None"));
Path.Add(new Vector3(-14461.58 , 500.26 , 26.27231 , "None"));
Path.Add(new Vector3(-14458.07 , 498.3698 , 26.27231 , "None"));
Path.Add(new Vector3(-14455.34 , 496.8997 , 26.27446 , "None"));
Path.Add(new Vector3(-14450.77 , 494.4369 , 26.28718 , "None"));
Path.Add(new Vector3(-14447.39 , 492.3963 , 28.71979 , "None"));
Path.Add(new Vector3(-14445.82 , 490.9411 , 28.72229 , "None"));
Path.Add(new Vector3(-14445.44 , 490.5573 , 28.71895 , "None"));
Path.Add(new Vector3(-14447.24 , 491.1976 , 28.71027 , "None"));
Path.Add(new Vector3(-14450.31 , 493.8727 , 26.632 , "None"));
Path.Add(new Vector3(-14451.87 , 493.3052 , 26.28665 , "None"));
Path.Add(new Vector3(-14449.91 , 489.9693 , 24.67746 , "None"));
Path.Add(new Vector3(-14446 , 489.5499 , 23.86262 , "None"));
Path.Add(new Vector3(-14447.93 , 492.4961 , 21.59202 , "None"));
Path.Add(new Vector3(-14450.57 , 495.3503 , 21.57893 , "None"));
Path.Add(new Vector3(-14453.52 , 492.593 , 21.72286 , "None"));
Path.Add(new Vector3(-14456.41 , 489.771 , 20.51786 , "None"));
Path.Add(new Vector3(-14459.29 , 486.9518 , 20.11359 , "None"));
Path.Add(new Vector3(-14462.28 , 484.0312 , 20.37546 , "None"));
Path.Add(new Vector3(-14465.15 , 482.6329 , 20.37661 , "None"));
Path.Add(new Vector3(-14468.68 , 484.553 , 20.37819 , "None"));
Path.Add(new Vector3(-14470.54 , 488.1361 , 20.37953 , "None"));
Path.Add(new Vector3(-14471.32 , 491.8826 , 20.37977 , "None"));
Path.Add(new Vector3(-14468.36 , 494.0302 , 19.50667 , "None"));
Path.Add(new Vector3(-14465.55 , 497.1218 , 17.63529 , "None"));
Path.Add(new Vector3(-14462.84 , 500.1122 , 15.6885 , "None"));
Path.Add(new Vector3(-14459.17 , 499.499 , 15.11543 , "None"));
Path.Add(new Vector3(-14459.58 , 495.4899 , 15.12288 , "None"));
Path.Add(new Vector3(-14461.08 , 492.2153 , 15.12469 , "None"));
Path.Add(new Vector3(-14465.09 , 492.6172 , 15.11685 , "None"));
Path.Add(new Vector3(-14468.49 , 492.8467 , 15.11685 , "None"));
Path.Add(new Vector3(-14471.68 , 490.9503 , 14.90368 , "None"));
Path.Add(new Vector3(-14468.85 , 488.0842 , 14.90067 , "None"));
Path.Add(new Vector3(-14465.96 , 485.2603 , 14.89899 , "None"));
Path.Add(new Vector3(-14463.07 , 482.4421 , 14.89824 , "None"));
Path.Add(new Vector3(-14460.09 , 479.5282 , 14.93037 , "None"));
Path.Add(new Vector3(-14457.2 , 476.7044 , 15.03543 , "None"));
Path.Add(new Vector3(-14454.31 , 473.8805 , 15.13467 , "None"));
Path.Add(new Vector3(-14451.32 , 470.961 , 15.21311 , "None"));
Path.Add(new Vector3(-14449.17 , 467.6787 , 15.27848 , "None"));
Path.Add(new Vector3(-14447.94 , 463.8322 , 15.35284 , "None"));
Path.Add(new Vector3(-14446.65 , 459.8554 , 15.42871 , "None"));
Path.Add(new Vector3(-14448.21 , 457.1815 , 15.43341 , "None"));
Path.Add(new Vector3(-14450.49 , 453.7717 , 15.55544 , "None"));
Path.Add(new Vector3(-14449.04 , 450.6367 , 15.64477 , "None"));
Path.Add(new Vector3(-14448.53 , 451.7354 , 15.67416 , "None"));
Path.Add(new Vector3(-14450.31 , 455.1796 , 15.51514 , "None"));
Path.Add(new Vector3(-14447.97 , 458.367 , 15.44551 , "None"));
Path.Add(new Vector3(-14446.31 , 461.3407 , 15.41781 , "None"));
Path.Add(new Vector3(-14447.88 , 465.154 , 15.33006 , "None"));
Path.Add(new Vector3(-14449.43 , 468.9376 , 15.26165 , "None"));
Path.Add(new Vector3(-14451.89 , 472.0804 , 15.19464 , "None"));
Path.Add(new Vector3(-14454.72 , 474.9526 , 15.11197 , "None"));
Path.Add(new Vector3(-14457.55 , 477.8248 , 15.00756 , "None"));
Path.Add(new Vector3(-14460.49 , 480.8002 , 14.91821 , "None"));
Path.Add(new Vector3(-14463.32 , 483.6724 , 14.89763 , "None"));
Path.Add(new Vector3(-14466.25 , 486.6478 , 14.8983 , "None"));
Path.Add(new Vector3(-14468.52 , 488.9467 , 14.8998 , "None"));
Path.Add(new Vector3(-14470.77 , 492.7066 , 15.23543 , "None"));
Path.Add(new Vector3(-14467.29 , 493.2589 , 15.11774 , "None"));
Path.Add(new Vector3(-14463.16 , 492.6825 , 15.11982 , "None"));
Path.Add(new Vector3(-14459.93 , 493.2087 , 15.12476 , "None"));
Path.Add(new Vector3(-14459.29 , 497.2165 , 15.11791 , "None"));
Path.Add(new Vector3(-14460.59 , 500.7599 , 15.11884 , "None"));
Path.Add(new Vector3(-14464.33 , 499.4987 , 16.37635 , "None"));
Path.Add(new Vector3(-14466.9 , 496.8501 , 18.15118 , "None"));
Path.Add(new Vector3(-14470.06 , 493.6071 , 20.05266 , "None"));
Path.Add(new Vector3(-14470.14 , 490.3905 , 20.38007 , "None"));
Path.Add(new Vector3(-14471.08 , 487.718 , 20.38063 , "None"));
Path.Add(new Vector3(-14468.79 , 484.3843 , 20.38063 , "None"));
Path.Add(new Vector3(-14465.06 , 482.9773 , 20.37918 , "None"));
Path.Add(new Vector3(-14461.43 , 482.4363 , 20.37543 , "None"));
Path.Add(new Vector3(-14460.69 , 485.5121 , 20.39156 , "None"));
Path.Add(new Vector3(-14457.73 , 488.2564 , 20.12433 , "None"));
Path.Add(new Vector3(-14454.77 , 491.0062 , 21.01594 , "None"));
Path.Add(new Vector3(-14451.74 , 493.4681 , 21.64068 , "None"));
Path.Add(new Vector3(-14448.69 , 493.5567 , 21.56589 , "None"));
Path.Add(new Vector3(-14446.11 , 490.5276 , 23.18356 , "None"));
Path.Add(new Vector3(-14446.42 , 489.1777 , 23.96014 , "None"));
Path.Add(new Vector3(-14450.05 , 489.4437 , 24.41043 , "None"));
Path.Add(new Vector3(-14452.11 , 493.0499 , 26.28777 , "None"));
Path.Add(new Vector3(-14450.57 , 495.4604 , 26.28491 , "None"));
Path.Add(new Vector3(-14447.84 , 495.0399 , 27.3288 , "None"));
Path.Add(new Vector3(-14445.65 , 491.5982 , 28.72828 , "None"));
Path.Add(new Vector3(-14442.82 , 490.2765 , 28.736 , "None"));
Path.Add(new Vector3(-14440.89 , 486.8393 , 28.74609 , "None"));
Path.Add(new Vector3(-14439.96 , 485.1906 , 28.74609 , "None"));
Path.Add(new Vector3(-14440.89 , 485.1608 , 28.75019 , "None"));
Path.Add(new Vector3(-14443.36 , 488.6445 , 28.72988 , "None"));
Path.Add(new Vector3(-14445.76 , 492.01 , 28.73172 , "None"));
Path.Add(new Vector3(-14447.98 , 495.1497 , 27.19059 , "None"));
Path.Add(new Vector3(-14448.74 , 496.3149 , 26.28863 , "None"));
Path.Add(new Vector3(-14449.49 , 497.4457 , 26.28476 , "None"));
Path.Add(new Vector3(-14452.15 , 496.966 , 26.28148 , "None"));
Path.Add(new Vector3(-14455.84 , 497.6127 , 26.27401 , "None"));
Path.Add(new Vector3(-14457.85 , 498.7273 , 26.27247 , "None"));
Path.Add(new Vector3(-14459.62 , 499.713 , 26.27247 , "None"));
Path.Add(new Vector3(-14460.39 , 499.6387 , 26.27247 , "None"));
Path.Add(new Vector3(-14457.52 , 495.5655 , 26.65884 , "None"));
Path.Add(new Vector3(-14454.27 , 493.532 , 26.2818 , "None"));
Path.Add(new Vector3(-14451.13 , 491.0172 , 26.20705 , "None"));
Path.Add(new Vector3(-14448.62 , 489.1154 , 23.96315 , "None"));
Path.Add(new Vector3(-14444.6 , 489.8179 , 23.95735 , "None"));
Path.Add(new Vector3(-14447.52 , 492.4549 , 21.62344 , "None"));
Path.Add(new Vector3(-14450.21 , 495.3176 , 21.60422 , "None"));
Path.Add(new Vector3(-14453.28 , 492.8151 , 21.82545 , "None"));
Path.Add(new Vector3(-14456.22 , 489.9503 , 20.59081 , "None"));
Path.Add(new Vector3(-14459.12 , 487.1199 , 20.09243 , "None"));
Path.Add(new Vector3(-14460.41 , 485.8539 , 20.33084 , "None"));
Path.Add(new Vector3(-14463.55 , 482.374 , 20.37634 , "None"));
Path.Add(new Vector3(-14466.38 , 482.1431 , 20.37799 , "None"));
Path.Add(new Vector3(-14469.1 , 485.0704 , 20.37877 , "None"));
Path.Add(new Vector3(-14470.85 , 488.7224 , 20.37999 , "None"));
Path.Add(new Vector3(-14471.18 , 492.3465 , 20.37999 , "None"));
Path.Add(new Vector3(-14467.87 , 494.4365 , 19.26459 , "None"));
Path.Add(new Vector3(-14465.17 , 497.4712 , 17.38836 , "None"));
Path.Add(new Vector3(-14462.47 , 500.4887 , 15.19522 , "None"));
Path.Add(new Vector3(-14458.44 , 499.5284 , 15.11351 , "None"));
Path.Add(new Vector3(-14459.04 , 496.4694 , 15.12349 , "None"));
Path.Add(new Vector3(-14460.65 , 492.251 , 15.12515 , "None"));
Path.Add(new Vector3(-14464.85 , 492.6215 , 15.11709 , "None"));
Path.Add(new Vector3(-14468.82 , 492.8382 , 15.11549 , "None"));
Path.Add(new Vector3(-14471.34 , 491.0307 , 14.90468 , "None"));
Path.Add(new Vector3(-14469.46 , 487.3288 , 14.90157 , "None"));
Path.Add(new Vector3(-14466.4 , 484.8826 , 14.89835 , "None"));
Path.Add(new Vector3(-14463.2 , 482.1708 , 14.89784 , "None"));
Path.Add(new Vector3(-14460.06 , 479.462 , 14.93259 , "None"));
Path.Add(new Vector3(-14456.73 , 477.2664 , 15.02998 , "None"));
Path.Add(new Vector3(-14452.88 , 477.7 , 15.07959 , "None"));
Path.Add(new Vector3(-14448.79 , 478.3704 , 15.13828 , "None"));
Path.Add(new Vector3(-14445.97 , 481.0014 , 15.13945 , "None"));
Path.Add(new Vector3(-14443.96 , 484.4713 , 15.10987 , "None"));
Path.Add(new Vector3(-14441.88 , 488.0735 , 14.69271 , "None"));
Path.Add(new Vector3(-14439.82 , 491.6339 , 13.98318 , "None"));
Path.Add(new Vector3(-14437.79 , 495.1386 , 13.23701 , "None"));
Path.Add(new Vector3(-14435.78 , 498.6154 , 11.79297 , "None"));
Path.Add(new Vector3(-14433.92 , 501.8205 , 9.980883 , "None"));
Path.Add(new Vector3(-14431.68 , 505.6875 , 7.7967 , "None"));
Path.Add(new Vector3(-14430.54 , 507.6663 , 6.730448 , "None"));
Path.Add(new Vector3(-14427.46 , 511.7299 , 4.950542 , "None"));
Path.Add(new Vector3(-14424.37 , 513.3972 , 4.954865 , "None"));
Path.Add(new Vector3(-14421.5 , 514.9474 , 4.976824 , "None"));
Path.Add(new Vector3(-14425.29 , 511.9277 , 4.943884 , "None"));
Path.Add(new Vector3(-14430.31 , 508.2319 , 6.460588 , "None"));
Path.Add(new Vector3(-14433.84 , 502.8335 , 9.585399 , "None"));
Path.Add(new Vector3(-14437.39 , 497.4243 , 12.78022 , "None"));
Path.Add(new Vector3(-14441.04 , 491.8427 , 14.16534 , "None"));
Path.Add(new Vector3(-14444.59 , 486.4197 , 15.0578 , "None"));
Path.Add(new Vector3(-14445.43 , 479.8217 , 15.16841 , "None"));
Path.Add(new Vector3(-14446.19 , 473.4012 , 15.23184 , "None"));
Path.Add(new Vector3(-14446.97 , 466.8272 , 15.31379 , "None"));
Path.Add(new Vector3(-14447.72 , 460.5602 , 15.4177 , "None"));
Path.Add(new Vector3(-14450.04 , 454.4911 , 15.51915 , "None"));
Path.Add(new Vector3(-14449.13 , 451.1134 , 15.64958 , "None"));
Path.Add(new Vector3(-14448.94 , 452.2534 , 15.63223 , "None"));
Path.Add(new Vector3(-14449.55 , 455.7356 , 15.46815 , "None"));
Path.Add(new Vector3(-14446.16 , 457.0595 , 15.40373 , "None"));
Path.Add(new Vector3(-14442.33 , 455.8737 , 15.38364 , "None"));
Path.Add(new Vector3(-14438.36 , 454.6401 , 15.36146 , "None"));
Path.Add(new Vector3(-14434.45 , 454.9062 , 15.34613 , "None"));
Path.Add(new Vector3(-14435.65 , 455.2791 , 15.34613 , "None"));
Path.Add(new Vector3(-14439.13 , 454.9885 , 15.36291 , "None"));
Path.Add(new Vector3(-14441.79 , 458.0305 , 15.37746 , "None"));
Path.Add(new Vector3(-14444.45 , 461.0724 , 15.392 , "None"));
Path.Add(new Vector3(-14447.2 , 464.2114 , 15.3571 , "None"));
Path.Add(new Vector3(-14449.87 , 467.2594 , 15.27804 , "None"));
Path.Add(new Vector3(-14452.63 , 470.4165 , 15.20725 , "None"));
Path.Add(new Vector3(-14455.3 , 473.4706 , 15.12869 , "None"));
Path.Add(new Vector3(-14457.94 , 476.4944 , 15.03144 , "None"));
Path.Add(new Vector3(-14460.63 , 479.5667 , 14.92358 , "None"));
Path.Add(new Vector3(-14463.33 , 482.6572 , 14.89652 , "None"));
Path.Add(new Vector3(-14465.9 , 485.5961 , 14.89727 , "None"));
Path.Add(new Vector3(-14467.31 , 487.2188 , 14.89857 , "None"));
Path.Add(new Vector3(-14469.96 , 490.2659 , 14.90081 , "None"));
Path.Add(new Vector3(-14471.52 , 492.0647 , 14.90229 , "None"));
Path.Add(new Vector3(-14470.45 , 492.1411 , 15.23495 , "None"));
Path.Add(new Vector3(-14468.66 , 493.3071 , 15.11213 , "None"));
Path.Add(new Vector3(-14466.52 , 491.9523 , 15.11651 , "None"));
Path.Add(new Vector3(-14465.83 , 491.3133 , 15.11651 , "None"));
Path.Add(new Vector3(-14468.64 , 492.2912 , 15.11675 , "None"));
Path.Add(new Vector3(-14471.63 , 492.1277 , 15.01664 , "None"));
Path.Add(new Vector3(-14469.68 , 488.9273 , 14.90264 , "None"));
Path.Add(new Vector3(-14466.7 , 486.0114 , 14.89928 , "None"));
Path.Add(new Vector3(-14463.77 , 483.1461 , 14.89762 , "None"));
Path.Add(new Vector3(-14460.89 , 480.3259 , 14.91531 , "None"));
Path.Add(new Vector3(-14458 , 477.5001 , 15.00606 , "None"));
Path.Add(new Vector3(-14455.12 , 474.6799 , 15.10866 , "None"));
Path.Add(new Vector3(-14452.19 , 471.8146 , 15.1931 , "None"));
Path.Add(new Vector3(-14449.41 , 468.8038 , 15.2619 , "None"));
Path.Add(new Vector3(-14447.61 , 465.1784 , 15.33078 , "None"));
Path.Add(new Vector3(-14445.76 , 461.4521 , 15.41669 , "None"));
Path.Add(new Vector3(-14444.05 , 458.0213 , 15.39121 , "None"));
Path.Add(new Vector3(-14442.16 , 454.2157 , 15.38064 , "None"));
Path.Add(new Vector3(-14440.3 , 450.4822 , 15.38364 , "None"));
Path.Add(new Vector3(-14439.52 , 448.9221 , 15.38912 , "None"));
Path.Add(new Vector3(-14439.36 , 445.8539 , 15.45208 , "None"));
Path.Add(new Vector3(-14439.18 , 439.182 , 15.33287 , "None"));
Path.Add(new Vector3(-14438.53 , 433.1489 , 15.58961 , "None"));
Path.Add(new Vector3(-14440.11 , 429.2795 , 15.55921 , "None"));
Path.Add(new Vector3(-14441.41 , 425.4978 , 15.55898 , "None"));
Path.Add(new Vector3(-14438.28 , 425.7307 , 17.69027 , "None"));
Path.Add(new Vector3(-14436.17 , 428.8933 , 20.27546 , "None"));
Path.Add(new Vector3(-14437.92 , 431.6654 , 20.32091 , "None"));
Path.Add(new Vector3(-14441.66 , 433.2112 , 20.38704 , "None"));
Path.Add(new Vector3(-14442.6 , 433.1527 , 20.35173 , "None"));
Path.Add(new Vector3(-14446.3 , 431.5452 , 20.27803 , "None"));
Path.Add(new Vector3(-14449.87 , 429.642 , 21.87818 , "None"));
Path.Add(new Vector3(-14453.41 , 427.7041 , 24.06833 , "None"));
Path.Add(new Vector3(-14457.3 , 426.7555 , 25.15143 , "None"));
Path.Add(new Vector3(-14457.47 , 429.6881 , 25.19273 , "None"));
Path.Add(new Vector3(-14459.85 , 432.4711 , 25.26278 , "None"));
Path.Add(new Vector3(-14461.42 , 433.9159 , 25.90585 , "None"));
Path.Add(new Vector3(-14465.66 , 438.7799 , 28.67447 , "None"));
Path.Add(new Vector3(-14470.39 , 442.8712 , 30.83026 , "None"));
Path.Add(new Vector3(-14475.1 , 439.8162 , 30.74919 , "None"));
Path.Add(new Vector3(-14474.99 , 433.3515 , 33.8173 , "None"));
Path.Add(new Vector3(-14479.28 , 428.5779 , 34.22832 , "None"));
Path.Add(new Vector3(-14484.61 , 428.1231 , 34.6182 , "None"));
Path.Add(new Vector3(-14488.65 , 428.068 , 34.59718 , "None"));
Path.Add(new Vector3(-14491.34 , 428.8385 , 34.58292 , "None"));
Path.Add(new Vector3(-14488.23 , 431.2378 , 34.58153 , "None"));
Path.Add(new Vector3(-14485.17 , 433.5163 , 34.58153 , "None"));
Path.Add(new Vector3(-14484.1 , 432.8688 , 34.58388 , "None"));
Path.Add(new Vector3(-14483.93 , 432.8894 , 35.58381 , "None"));
Path.Add(new Vector3(-14483.93 , 432.8894 , 35.0602 , "None"));
Path.Add(new Vector3(-14483.93 , 431.1425 , 34.59129 , "None"));
Path.Add(new Vector3(-14483.93 , 426.9726 , 34.61687 , "None"));
Path.Add(new Vector3(-14483.91 , 425.1282 , 34.59606 , "None"));
Path.Add(new Vector3(-14484.22 , 424.7914 , 36.14869 , "None"));
Path.Add(new Vector3(-14484.92 , 423.1307 , 35.23302 , "None"));
Path.Add(new Vector3(-14485.55 , 422.8037 , 34.57639 , "None"));
Path.Add(new Vector3(-14487.22 , 423.303 , 34.58385 , "None"));
Path.Add(new Vector3(-14487.94 , 424.3693 , 34.60307 , "None"));
Path.Add(new Vector3(-14486.81 , 425.6233 , 34.60649 , "None"));
Path.Add(new Vector3(-14488.39 , 429.2214 , 34.58767 , "None"));
Path.Add(new Vector3(-14492.01 , 428.5093 , 34.58243 , "None"));
Path.Add(new Vector3(-14489.22 , 431.4552 , 34.69387 , "None"));
Path.Add(new Vector3(-14486.51 , 434.1621 , 36.13364 , "None"));
Path.Add(new Vector3(-14485.62 , 435.0457 , 36.30408 , "None"));
Path.Add(new Vector3(-14486.47 , 434.1141 , 35.9992 , "None"));
Path.Add(new Vector3(-14489.33 , 431.2563 , 34.58244 , "None"));
Path.Add(new Vector3(-14490.57 , 430.0226 , 35.71983 , "None"));
Path.Add(new Vector3(-14491.5 , 428.3936 , 34.82195 , "None"));
Path.Add(new Vector3(-14489.4 , 430.2349 , 35.41327 , "None"));
Path.Add(new Vector3(-14487.14 , 431.3017 , 34.58217 , "None"));
Path.Add(new Vector3(-14484.88 , 433.3198 , 34.58217 , "None"));
Path.Add(new Vector3(-14484.26 , 432.9072 , 34.58217 , "None"));
Path.Add(new Vector3(-14483.93 , 432.8894 , 35.05905 , "None"));
Path.Add(new Vector3(-14485.64 , 432.5423 , 34.93244 , "None"));
Path.Add(new Vector3(-14486.3 , 431.756 , 34.58235 , "None"));
Path.Add(new Vector3(-14489.19 , 429.0295 , 34.5834 , "None"));
Path.Add(new Vector3(-14490.61 , 427.6047 , 34.58744 , "None"));
Path.Add(new Vector3(-14491.08 , 428.5513 , 34.58208 , "None"));
Path.Add(new Vector3(-14488.13 , 431.507 , 34.582 , "None"));
Path.Add(new Vector3(-14485.67 , 433.8511 , 34.582 , "None"));
Path.Add(new Vector3(-14485 , 433.399 , 34.582 , "None"));
Path.Add(new Vector3(-14484.4 , 433.0003 , 34.582 , "None"));
Path.Add(new Vector3(-14483.93 , 432.8894 , 35.4118 , "None"));
Path.Add(new Vector3(-14483.93 , 432.8894 , 34.72561 , "None"));
Path.Add(new Vector3(-14483.93 , 432.8894 , 35.52998 , "None"));
Path.Add(new Vector3(-14483.93 , 432.8894 , 34.58201 , "None"));
Path.Add(new Vector3(-14483.93 , 432.8894 , 35.58201 , "None"));
Path.Add(new Vector3(-14483.88 , 431.038 , 34.59232 , "None"));
Path.Add(new Vector3(-14482.82 , 428.3354 , 34.62085 , "None"));
Path.Add(new Vector3(-14479.65 , 428.5164 , 34.23059 , "None"));
Path.Add(new Vector3(-14477.41 , 431.2787 , 34.22837 , "None"));
Path.Add(new Vector3(-14474.78 , 433.8303 , 33.63483 , "None"));
Path.Add(new Vector3(-14475.62 , 437.5995 , 31.39596 , "None"));
Path.Add(new Vector3(-14475.08 , 441.7191 , 30.68443 , "None"));
Path.Add(new Vector3(-14471.62 , 443.7914 , 30.73348 , "None"));
Path.Add(new Vector3(-14469.04 , 445.7507 , 30.68038 , "None"));
Path.Add(new Vector3(-14468.19 , 447.1183 , 30.62839 , "None"));
Path.Add(new Vector3(-14465.78 , 450.5292 , 30.49934 , "None"));
Path.Add(new Vector3(-14462.63 , 452.3514 , 28.073 , "None"));
Path.Add(new Vector3(-14462.15 , 455.2451 , 24.42499 , "None"));
Path.Add(new Vector3(-14463.76 , 459.0938 , 19.82831 , "None"));
Path.Add(new Vector3(-14463.72 , 462.6967 , 15.16771 , "None"));
Path.Add(new Vector3(-14462.26 , 466.4662 , 15.14472 , "None"));
Path.Add(new Vector3(-14460.76 , 470.3587 , 15.10061 , "None"));
Path.Add(new Vector3(-14459.31 , 474.131 , 15.05779 , "None"));
Path.Add(new Vector3(-14461.12 , 477.6326 , 14.96189 , "None"));
Path.Add(new Vector3(-14463.22 , 481.0816 , 14.90115 , "None"));
Path.Add(new Vector3(-14465.52 , 484.5552 , 14.8966 , "None"));
Path.Add(new Vector3(-14466.64 , 485.7216 , 14.89724 , "None"));
Path.Add(new Vector3(-14464.49 , 482.751 , 14.89724 , "None"));
Path.Add(new Vector3(-14459.97 , 477.8493 , 14.9708 , "None"));
Path.Add(new Vector3(-14455.42 , 473.2581 , 15.12997 , "None"));
Path.Add(new Vector3(-14450.88 , 468.6479 , 15.24825 , "None"));
Path.Add(new Vector3(-14446.98 , 463.5148 , 15.36833 , "None"));
Path.Add(new Vector3(-14442.96 , 458.1714 , 15.38606 , "None"));
Path.Add(new Vector3(-14439.11 , 452.9763 , 15.36688 , "None"));
Path.Add(new Vector3(-14435.45 , 447.3983 , 15.44305 , "None"));
Path.Add(new Vector3(-14431.88 , 442.0114 , 16.23634 , "None"));
Path.Add(new Vector3(-14428.09 , 436.7738 , 18.10248 , "None"));
Path.Add(new Vector3(-14424.01 , 431.5033 , 21.38717 , "None"));
Path.Add(new Vector3(-14420.05 , 426.3902 , 21.99802 , "None"));
Path.Add(new Vector3(-14415.21 , 422.1558 , 22.1638 , "None"));
Path.Add(new Vector3(-14409.18 , 419.3245 , 22.33512 , "None"));
Path.Add(new Vector3(-14403.04 , 416.7116 , 22.49406 , "None"));
Path.Add(new Vector3(-14397.04 , 416.3877 , 22.60748 , "None"));
Path.Add(new Vector3(-14393.17 , 411.2985 , 22.72071 , "None"));
Path.Add(new Vector3(-14392.35 , 405.197 , 22.73574 , "None"));
Path.Add(new Vector3(-14391.15 , 398.6726 , 22.79205 , "None"));
Path.Add(new Vector3(-14387.35 , 393.221 , 22.9754 , "None"));
Path.Add(new Vector3(-14382.56 , 388.8888 , 23.07328 , "None"));
Path.Add(new Vector3(-14377.18 , 384.9457 , 22.61142 , "None"));
Path.Add(new Vector3(-14371.14 , 382.6994 , 22.77132 , "None"));
Path.Add(new Vector3(-14364.8 , 381.8637 , 23.31015 , "None"));
Path.Add(new Vector3(-14358.32 , 383.3197 , 23.32749 , "None"));
Path.Add(new Vector3(-14352.17 , 385.3176 , 23.38768 , "None"));
Path.Add(new Vector3(-14346.02 , 387.3155 , 23.22596 , "None"));
Path.Add(new Vector3(-14340.02 , 389.6665 , 23.07371 , "None"));
Path.Add(new Vector3(-14333.98 , 392.5356 , 23.15985 , "None"));
Path.Add(new Vector3(-14328.14 , 395.3121 , 23.29521 , "None"));
Path.Add(new Vector3(-14322.92 , 399.0399 , 23.90241 , "None"));
Path.Add(new Vector3(-14319.71 , 404.8393 , 23.927 , "None"));
Path.Add(new Vector3(-14318.04 , 411.0783 , 23.80444 , "None"));
Path.Add(new Vector3(-14317.28 , 417.4985 , 23.5396 , "None"));
Path.Add(new Vector3(-14316.6 , 423.9279 , 23.22578 , "None"));
Path.Add(new Vector3(-14315.89 , 430.5495 , 22.90148 , "None"));
Path.Add(new Vector3(-14314.37 , 436.7743 , 22.98947 , "None"));
Path.Add(new Vector3(-14308.54 , 439.5021 , 25.86716 , "None"));
Path.Add(new Vector3(-14302.51 , 438.0667 , 29.67915 , "None"));
Path.Add(new Vector3(-14296.48 , 435.2032 , 31.90066 , "None"));
Path.Add(new Vector3(-14290.48 , 432.2622 , 32.58288 , "None"));
Path.Add(new Vector3(-14284.94 , 428.9952 , 34.00177 , "None"));
Path.Add(new Vector3(-14280.08 , 424.7412 , 35.44536 , "None"));
Path.Add(new Vector3(-14276.56 , 419.3463 , 36.55708 , "None"));
Path.Add(new Vector3(-14274.21 , 413.1266 , 37.15787 , "None"));
Path.Add(new Vector3(-14274.17 , 406.6946 , 37.11322 , "None"));
Path.Add(new Vector3(-14275.3 , 400.3282 , 37.30299 , "None"));
Path.Add(new Vector3(-14276.33 , 393.7357 , 36.79535 , "None"));
Path.Add(new Vector3(-14277.27 , 387.3394 , 36.12542 , "None"));
Path.Add(new Vector3(-14277.83 , 380.8996 , 35.43756 , "None"));
Path.Add(new Vector3(-14277.69 , 374.445 , 34.61913 , "None"));
Path.Add(new Vector3(-14276.63 , 367.8627 , 33.77206 , "None"));
Path.Add(new Vector3(-14274.57 , 361.7519 , 33.28634 , "None"));
Path.Add(new Vector3(-14271.48 , 355.8412 , 32.82072 , "None"));
Path.Add(new Vector3(-14267.95 , 350.4159 , 32.12523 , "None"));
Path.Add(new Vector3(-14263.69 , 345.5697 , 29.90804 , "None"));
Path.Add(new Vector3(-14259.39 , 340.7364 , 27.55351 , "None"));
Path.Add(new Vector3(-14254.96 , 335.749 , 26.74076 , "None"));
Path.Add(new Vector3(-14250.67 , 330.9157 , 24.15422 , "None"));
Path.Add(new Vector3(-14247.76 , 325.2538 , 24.92898 , "None"));
Path.Add(new Vector3(-14246.51 , 318.7099 , 25.6907 , "None"));
Path.Add(new Vector3(-14245.57 , 312.3151 , 26.17925 , "None"));
Path.Add(new Vector3(-14244.92 , 305.6777 , 26.80539 , "None"));
Path.Add(new Vector3(-14244.71 , 299.2152 , 27.13187 , "None"));
Path.Add(new Vector3(-14244.5 , 292.5338 , 27.07312 , "None"));
Path.Add(new Vector3(-14244.31 , 286.3029 , 27.00277 , "None"));
Path.Add(new Vector3(-14244.07 , 279.8545 , 26.82061 , "None"));
Path.Add(new Vector3(-14243.78 , 273.1762 , 26.45302 , "None"));
Path.Add(new Vector3(-14243.5 , 266.7296 , 25.84808 , "None"));
Path.Add(new Vector3(-14243.21 , 260.1543 , 25.05902 , "None"));
Path.Add(new Vector3(-14242.92 , 253.7205 , 24.40728 , "None"));
Path.Add(new Vector3(-14242.87 , 252.4466 , 24.26515 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AkirisbytheBundle : QuestGrinderClass
{
    public AkirisbytheBundle()
    {
        Name = "Akiris by the Bundle";

        QuestId.AddRange(new[] { 617 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(1907);
HotSpots.Add(new Vector3(-13908.09 , 659.0043 , 12.10419 , "None"));
HotSpots.Add(new Vector3(-13878.63 , 620.7598 , 24.39997 , "None"));
HotSpots.Add(new Vector3(-13845.16 , 646.041 , 12.83639 , "None"));
HotSpots.Add(new Vector3(-13873.62 , 691.4323 , 2.636522 , "None"));
HotSpots.Add(new Vector3(-13811.78 , 684.3727 , 3.637609 , "None"));
HotSpots.Add(new Vector3(-13745.98 , 631.5039 , 14.48091 , "None"));
HotSpots.Add(new Vector3(-13813.06 , 497.3523 , 79.50951 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SingingBlueShards : QuestGrinderClass
{
    public SingingBlueShards()
    {
        Name = "Singing Blue Shards";

        QuestId.AddRange(new[] { 605 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(1550);
HotSpots.Add(new Vector3(-13283.95 , -182.1908 , 13.74593 , "None"));
HotSpots.Add(new Vector3(-13315.16 , -219.2266 , 13.85756 , "None"));
HotSpots.Add(new Vector3(-13313.83 , -274.2852 , 14.18689 , "None"));
HotSpots.Add(new Vector3(-13379.15 , -276.3691 , 13.94005 , "None"));
HotSpots.Add(new Vector3(-13386.4 , -362.2523 , 17.41521 , "None"));
HotSpots.Add(new Vector3(-13352.37 , -391.1992 , 18.08425 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ZanzilsSecret : QuestGrinderClass
{
    public ZanzilsSecret()
    {
        Name = "Zanzil's Secret";

        QuestId.AddRange(new[] { 621 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(1488);
EntryTarget.Add(1490);
EntryTarget.Add(1491);
HotSpots.Add(new Vector3(-13681.91 , -388.119 , 0.649662 , "None"));
HotSpots.Add(new Vector3(-13367.1 , -4.92871 , 22.43017 , "None"));
HotSpots.Add(new Vector3(-13344.3 , -21.2062 , 22.18365 , "None"));
HotSpots.Add(new Vector3(-13646.15 , -336.1022 , 8.213072 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ScaringShaky : QuestGrinderClass
{
    public ScaringShaky()
    {
        Name = "Scaring Shaky";

        QuestId.AddRange(new[] { 606 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(1557);
HotSpots.Add(new Vector3(-13853.09 , 103.4402 , 17.64338 , "None"));
HotSpots.Add(new Vector3(-13876.88 , 82.57813 , 15.44579 , "None"));
HotSpots.Add(new Vector3(-13911.96 , 50.96094 , 15.9665 , "None"));
HotSpots.Add(new Vector3(-13927.47 , 111.8887 , 14.48008 , "None"));
HotSpots.Add(new Vector3(-13951.48 , 83.28583 , 15.85387 , "None"));
HotSpots.Add(new Vector3(-14021.01 , 78.63069 , 10.00282 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheCaptainsChest : QuestGrinderClass
{
    public TheCaptainsChest()
    {
        Name = "The Captain's Chest";

        QuestId.AddRange(new[] { 614 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(1492);
HotSpots.Add(new Vector3(-14118.79 , -118.6845 , 0.4384643 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheBloodsailBuccaneers1 : QuestClass
{
    public TheBloodsailBuccaneers1()
    {
        Name = "The Bloodsail Buccaneers1";

        QuestId.AddRange(new[] { 595 });

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


public sealed class TheBloodsailBuccaneers2 : QuestClass
{
    public TheBloodsailBuccaneers2()
    {
        Name = "The Bloodsail Buccaneers2";

        QuestId.AddRange(new[] { 597 });

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


public sealed class TheBloodsailBuccaneers3 : QuestClass
{
    public TheBloodsailBuccaneers3()
    {
        Name = "The Bloodsail Buccaneers3";

        QuestId.AddRange(new[] { 599 });

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


public sealed class TheBloodsailBuccaneers4 : QuestClass
{
    public TheBloodsailBuccaneers4()
    {
        Name = "The Bloodsail Buccaneers4";

        QuestId.AddRange(new[] { 604 });

        Step = new List<int> { 10, 1, 1, 0, 0 };

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


public sealed class TheBloodsailBuccaneers5 : QuestGrinderClass
{
    public TheBloodsailBuccaneers5()
    {
        Name = "The Bloodsail Buccaneers5";

        QuestId.AddRange(new[] { 608 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { false, false, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(2550);
EntryTarget.Add(2546);
EntryTarget.Add(2548);
HotSpots.Add(new Vector3(-14924.98 , 119.5256 , 7.521097 , "None"));
HotSpots.Add(new Vector3(-15014.57 , 261.3713 , 7.518458 , "None"));
HotSpots.Add(new Vector3(-14924.9 , 349.625 , 8.089344 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KurzensMystery : QuestClass
{
    public KurzensMystery()
    {
        Name = "Kurzen's Mystery";

        QuestId.AddRange(new[] { 207 });

        Step = new List<int> { 1, 1, 1, 1, 0 };

        StepAutoDetect = new[] { false, false, false, true, false };

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


public sealed class KurzensMystery1 : QuestGathererClass
{
    public KurzensMystery1()
    {
        Name = "Kurzen's Mystery1";

        QuestId.AddRange(new[] { 207 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(57);
HotSpots.Add(new Vector3(-11985.94 , 342.229 , 3.430182 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(2005) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class KurzensMystery2 : QuestGathererClass
{
    public KurzensMystery2()
    {
        Name = "Kurzen's Mystery2";

        QuestId.AddRange(new[] { 207 });

        Step = new List<int> { 0, 1, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(58);
HotSpots.Add(new Vector3(-12149.68 , 635.6844 , -69.19474 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(2006) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class KurzensMystery3 : QuestGathererClass
{
    public KurzensMystery3()
    {
        Name = "Kurzen's Mystery3";

        QuestId.AddRange(new[] { 207 });

        Step = new List<int> { 0, 0, 1, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(52);
HotSpots.Add(new Vector3(-11682.49 , 757.3735 , 50.675 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(2007) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class KurzensMystery4 : QuestGathererClass
{
    public KurzensMystery4()
    {
        Name = "Kurzen's Mystery4";

        QuestId.AddRange(new[] { 207 });

        Step = new List<int> { 0, 0, 0, 1, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(54);
HotSpots.Add(new Vector3(-11543.99 , 646.6354 , 60.4677 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(2008) >= 1;
}






}


public sealed class WaterElementals : QuestGrinderClass
{
    public WaterElementals()
    {
        Name = "Water Elementals";

        QuestId.AddRange(new[] { 601 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(691);
HotSpots.Add(new Vector3(-12149.5 , 784.0625 , 2.871405 , "None"));
HotSpots.Add(new Vector3(-12159.07 , 879.1563 , 16.8978 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SkullsplitterTusks : QuestGrinderClass
{
    public SkullsplitterTusks()
    {
        Name = "Skullsplitter Tusks";

        QuestId.AddRange(new[] { 209 });

        Step = new List<int> { 18, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(696);
EntryTarget.Add(667);
EntryTarget.Add(780);
EntryTarget.Add(782);
HotSpots.Add(new Vector3(-12619 , -784.983 , 45.82495 , "None"));
HotSpots.Add(new Vector3(-12676.2 , -799.077 , 59.09009 , "None"));
HotSpots.Add(new Vector3(-12860.76 , -807.248 , 54.71131 , "None"));
HotSpots.Add(new Vector3(-12889.25 , -715.4492 , 53.30951 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class UptoSnuff : QuestGrinderClass
{
    public UptoSnuff()
    {
        Name = "Up to Snuff";

        QuestId.AddRange(new[] { 587 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(1562);
EntryTarget.Add(1561);
HotSpots.Add(new Vector3(-14254 , 175.7617 , 9.487399 , "None"));
HotSpots.Add(new Vector3(-14269.58 , 155.846 , 8.744818 , "None"));
HotSpots.Add(new Vector3(-14314.68 , 105.5352 , 3.884428 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class VentureCompanyMining : QuestGrinderClass
{
    public VentureCompanyMining()
    {
        Name = "Venture Company Mining";

        QuestId.AddRange(new[] { 600 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(674);
HotSpots.Add(new Vector3(-13033.4 , -422.727 , 54.15156 , "None"));
HotSpots.Add(new Vector3(-13067.1 , -432.447 , 49.00683 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AkirisbytheBundle1 : QuestClass
{
    public AkirisbytheBundle1()
    {
        Name = "Akiris by the Bundle1";

        QuestId.AddRange(new[] { 623 });

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


public sealed class StoleysDebt : QuestClass
{
    public StoleysDebt()
    {
        Name = "Stoley's Debt";

        QuestId.AddRange(new[] { 2872 });

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


public sealed class TheBloodsailBuccaneers41 : QuestGrinderClass
{
    public TheBloodsailBuccaneers41()
    {
        Name = "The Bloodsail Buccaneers4-1";

        QuestId.AddRange(new[] { 604 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(1563);
HotSpots.Add(new Vector3(-14458.47 , 111.8688 , 5.563733 , "None"));
HotSpots.Add(new Vector3(-14550.49 , 187.7539 , 2.732006 , "None"));
HotSpots.Add(new Vector3(-14612.38 , 242.0427 , 0.7260023 , "None"));
HotSpots.Add(new Vector3(-14677.37 , 412.916 , 3.753506 , "None"));
HotSpots.Add(new Vector3(-14714.04 , 485.7274 , 3.296393 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheBloodsailBuccaneers42 : QuestGathererClass
{
    public TheBloodsailBuccaneers42()
    {
        Name = "The Bloodsail Buccaneers4-2";

        QuestId.AddRange(new[] { 604 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(2086);
HotSpots.Add(new Vector3(-14687.34 , 485.7484 , 2.891027 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheBloodsailBuccaneers43 : QuestGathererClass
{
    public TheBloodsailBuccaneers43()
    {
        Name = "The Bloodsail Buccaneers4-3";

        QuestId.AddRange(new[] { 604 });

        Step = new List<int> { 0, 0, 1, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(2087);
HotSpots.Add(new Vector3(-14703.68 , 448.6262 , -0.6458251 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class StranglethornFever : QuestClass
{
    public StranglethornFever()
    {
        Name = "Stranglethorn Fever";

        QuestId.AddRange(new[] { 348 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

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


public sealed class WhiskeySlimsLostGrog : QuestGathererClass
{
    public WhiskeySlimsLostGrog()
    {
        Name = "Whiskey Slim's Lost Grog";

        QuestId.AddRange(new[] { 580 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

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


public sealed class KeepAnEyeOut : QuestGrinderClass
{
    public KeepAnEyeOut()
    {
        Name = "Keep An Eye Out";

        QuestId.AddRange(new[] { 576 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(1562);
EntryTarget.Add(1561);
EntryTarget.Add(1564);
HotSpots.Add(new Vector3(-14245.88 , 176.4844 , 9.026242 , "None"));
HotSpots.Add(new Vector3(-14258.5 , 154.6548 , 7.764846 , "None"));
HotSpots.Add(new Vector3(-14679.3 , 456.319 , 3.355185 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReturntoMacKinley : QuestClass
{
    public ReturntoMacKinley()
    {
        Name = "Return to MacKinley";

        QuestId.AddRange(new[] { 607 });

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


public sealed class VoodooDues : QuestGrinderClass
{
    public VoodooDues()
    {
        Name = "Voodoo Dues";

        QuestId.AddRange(new[] { 609 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { false, false, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(2537);
EntryTarget.Add(2536);
EntryTarget.Add(2535);
HotSpots.Add(new Vector3(-13662.25 , -346.7388 , 3.539806 , "None"));
HotSpots.Add(new Vector3(-13374.3 , -7.69423 , 21.85953 , "None"));
HotSpots.Add(new Vector3(-13321.61 , -11.14975 , 21.46175 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class StranglethornFever1 : QuestGrinderClass
{
    public StranglethornFever1()
    {
        Name = "Stranglethorn Fever1";

        QuestId.AddRange(new[] { 348 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(1557);
HotSpots.Add(new Vector3(-13871.79 , 86.92578 , 15.90491 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(2799) >=1;
}






}


public sealed class StranglethornFever3 : QuestGrinderClass
{
    public StranglethornFever3()
    {
        Name = "Stranglethorn Fever3";

        QuestId.AddRange(new[] { 348 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(1511);
EntryTarget.Add(1514);
HotSpots.Add(new Vector3(-13741.72 , -24.81142 , 44.77733 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WitchDoctorUnbagwa : QuestGrinderClass
{
    public WitchDoctorUnbagwa()
    {
        Name = "Witch Doctor Unbagwa";

        QuestId.AddRange(new[] { 349 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(1511);
EntryTarget.Add(1516);
EntryTarget.Add(1514);
HotSpots.Add(new Vector3(-13743.7 , -23.97 , 45.14 , "None"));
HotSpots.Add(new Vector3(-13743.7 , -23.97 , 45.14 , "None"));
HotSpots.Add(new Vector3(-13743.7 , -23.97 , 45.14 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class MagicalAnalysis : QuestClass
{
    public MagicalAnalysis()
    {
        Name = "Magical Analysis";

        QuestId.AddRange(new[] { 602 });

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


public sealed class CrackingMaurysFoot : QuestGrinderClass
{
    public CrackingMaurysFoot()
    {
        Name = "Cracking Maury's Foot";

        QuestId.AddRange(new[] { 613 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(709);
EntryTarget.Add(710);
EntryTarget.Add(678);
HotSpots.Add(new Vector3(-12248.13 , -790.2476 , 12.41705 , "None"));
HotSpots.Add(new Vector3(-12314.08 , -919.8981 , 10.11456 , "None"));
HotSpots.Add(new Vector3(-12370.5 , -1069.95 , 2.936184 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TrollWitchery : QuestGrinderClass
{
    public TrollWitchery()
    {
        Name = "Troll Witchery";

        QuestId.AddRange(new[] { 205 });

        Step = new List<int> { 4, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(780);
EntryTarget.Add(670);
HotSpots.Add(new Vector3(-12852.07 , -852.0801 , 54.88165 , "None"));
HotSpots.Add(new Vector3(-12857.97 , -774.6523 , 60.88631 , "None"));
HotSpots.Add(new Vector3(-12948.79 , -649.6523 , 52.80225 , "None"));
HotSpots.Add(new Vector3(-12964.6 , -607.433 , 53.62691 , "None"));
HotSpots.Add(new Vector3(-12865.03 , -611.0279 , 56.64903 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BigGameHunter : QuestGrinderClass
{
    public BigGameHunter()
    {
        Name = "Big Game Hunter";

        QuestId.AddRange(new[] { 208 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(731);
HotSpots.Add(new Vector3(-12664.5 , -219.9988 , 37.02156 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MaiZoth : QuestGrinderClass
{
    public MaiZoth()
    {
        Name = "Mai'Zoth";

        QuestId.AddRange(new[] { 206 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(818);
HotSpots.Add(new Vector3(-12349.33 , -1151.384 , 1.229621 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThePerenoldeTiara : QuestClass
{
    public ThePerenoldeTiara()
    {
        Name = "The Perenolde Tiara";

        QuestId.AddRange(new[] { 543 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

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
