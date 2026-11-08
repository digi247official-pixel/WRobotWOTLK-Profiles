
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



public sealed class DEPRECATEDChallengeOverlordMokMorokk : QuestGrinderClass
{
    public DEPRECATEDChallengeOverlordMokMorokk()
    {
        Name = "[DEPRECATED]Challenge Overlord Mok&#039;Morokk";

        QuestId.AddRange(new[] { 1173 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(4500);
HotSpots.Add(new Vector3(-3132.84 , -2880.27 , 34.70113 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DEPRECATEDTheBroodofOnyxia : QuestGathererClass
{
    public DEPRECATEDTheBroodofOnyxia()
    {
        Name = "[DEPRECATED]The Brood of Onyxia";

        QuestId.AddRange(new[] { 1172 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(20359);
HotSpots.Add(new Vector3(-4609.285 , -3519.927 , 34.01663 , "None"));
HotSpots.Add(new Vector3(-4692.503 , -3514.833 , 37.98732 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ATaleofSorrow : QuestInteractWithClass
{
    public ATaleofSorrow()
    {
        Name = "A Tale of Sorrow";

        QuestId.AddRange(new[] { 2801 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(7572);
HotSpots.Add(new Vector3(-10632.3 , -3009.37 , 29.19128 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "";
IgnoreIfDead = false;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Caught : QuestGrinderClass
{
    public Caught()
    {
        Name = "Caught!";

        QuestId.AddRange(new[] { 4449 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5839);
HotSpots.Add(new Vector3(-7019.81 , -1719.915 , 241.6667 , "None"));
HotSpots.Add(new Vector3(-7012.38 , -1731.65 , 234.099 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CortellosRiddle : QuestClass
{
    public CortellosRiddle()
    {
        Name = "Cortello&#039;s Riddle";

        QuestId.AddRange(new[] { 624 });

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
return ObjectManager.Me.Position.DistanceTo2D(new Vector3(-10363.96, -2753.892, 17.65852)) < 5000;
}






}


public sealed class CortellosRiddlept2 : QuestClass
{
    public CortellosRiddlept2()
    {
        Name = "Cortello&#039;s Riddle pt2";

        QuestId.AddRange(new[] { 625 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6948) == 1;
}






}


public sealed class CortellosRiddlept3 : QuestClass
{
    public CortellosRiddlept3()
    {
        Name = "Cortello&#039;s Riddle pt3";

        QuestId.AddRange(new[] { 626 });

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


public sealed class CurseTheseFatFingers : QuestGrinderClass
{
    public CurseTheseFatFingers()
    {
        Name = "Curse These Fat Fingers";

        QuestId.AddRange(new[] { 7723 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5854);
HotSpots.Add(new Vector3(-6778.555 , -1045.232 , 240.6218 , "None"));
HotSpots.Add(new Vector3(-6775.038 , -1107.057 , 242.2745 , "None"));
HotSpots.Add(new Vector3(-6813.129 , -1078.428 , 242.5203 , "None"));
HotSpots.Add(new Vector3(-6770.353 , -1157.414 , 243.4223 , "None"));
HotSpots.Add(new Vector3(-6758.537 , -1214.956 , 246.0368 , "None"));
HotSpots.Add(new Vector3(-6715.53 , -1252.479 , 242.0029 , "None"));
HotSpots.Add(new Vector3(-6720.086 , -1346.052 , 240.7834 , "None"));
HotSpots.Add(new Vector3(-6687.85 , -1386.751 , 240.6164 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DivineRetribution : QuestInteractWithClass
{
    public DivineRetribution()
    {
        Name = "Divine Retribution";

        QuestId.AddRange(new[] { 3441 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(8479);
HotSpots.Add(new Vector3(-6679.93 , -1194.36 , 240.2136 , "None"));
GossipOptionNpcInteractWith = 2;
Macro = "/click";
IgnoreIfDead = false;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class FallFromGrace : QuestInteractWithClass
{
    public FallFromGrace()
    {
        Name = "Fall From Grace";

        QuestId.AddRange(new[] { 2784 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(7572);
HotSpots.Add(new Vector3(-10632.3 , -3009.37 , 29.19128 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "";
IgnoreIfDead = false;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class FieryMenace : QuestGrinderClass
{
    public FieryMenace()
    {
        Name = "Fiery Menace!";

        QuestId.AddRange(new[] { 7724 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5858);
HotSpots.Add(new Vector3(-6707.361 , -1015.721 , 243.3257 , "None"));
HotSpots.Add(new Vector3(-6692.658 , -1043.012 , 242.8665 , "None"));
HotSpots.Add(new Vector3(-6759.114 , -985.7971 , 240.1432 , "None"));
HotSpots.Add(new Vector3(-6850.646 , -948.5798 , 243.2014 , "None"));
HotSpots.Add(new Vector3(-6937.443 , -983.0574 , 240.7437 , "None"));
HotSpots.Add(new Vector3(-7010.85 , -1014.732 , 241.6711 , "None"));
HotSpots.Add(new Vector3(-7111.2 , -1022.59 , 242.031 , "None"));
HotSpots.Add(new Vector3(-7153.95 , -1000.73 , 242.9638 , "None"));
HotSpots.Add(new Vector3(-7232.97 , -971.864 , 246.8642 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ForgingtheShaft : QuestGrinderClass
{
    public ForgingtheShaft()
    {
        Name = "Forging the Shaft";

        QuestId.AddRange(new[] { 3443 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5846);
HotSpots.Add(new Vector3(-6692.682 , -1417.23 , 242.3627 , "None"));
HotSpots.Add(new Vector3(-6682.65 , -1345.57 , 247.9507 , "None"));
HotSpots.Add(new Vector3(-6798.761 , -1094.803 , 243.9281 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GetBurningSteppersFp : QuestInteractWithClass
{
    public GetBurningSteppersFp()
    {
        Name = "Get Burning Steppers Fp";

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

        EntryIdTarget.Add(13177);
HotSpots.Add(new Vector3(-7504.06 , -2190.77 , 165.2206 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "";
IgnoreIfDead = false;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ObjectManager.Me.Position.DistanceTo2D(new Vector3(-7504.06, -2190.77, 165.2206)) < 1;
}






}


public sealed class IncendosaursWhateverosaurisMoreLikeIt : QuestGrinderClass
{
    public IncendosaursWhateverosaurisMoreLikeIt()
    {
        Name = "Incendosaurs? Whateverosaur is More Like It";

        QuestId.AddRange(new[] { 7727 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(9318);
HotSpots.Add(new Vector3(-6678.207 , -1438.762 , 167.7041 , "None"));
HotSpots.Add(new Vector3(-6655.073 , -1477.233 , 167.9288 , "None"));
HotSpots.Add(new Vector3(-6599.249 , -1463.012 , 166.3416 , "None"));
HotSpots.Add(new Vector3(-6515.064 , -1410.242 , 148.8641 , "None"));
HotSpots.Add(new Vector3(-6448.887 , -1433.389 , 144.956 , "None"));
HotSpots.Add(new Vector3(-6417.821 , -1386.026 , 139.6457 , "None"));
HotSpots.Add(new Vector3(-6416.5 , -1325.584 , 134.2959 , "None"));
HotSpots.Add(new Vector3(-6518.726 , -1289.385 , 136.2674 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class IntotheField : QuestClass
{
    public IntotheField()
    {
        Name = "Into the Field";

        QuestId.AddRange(new[] { 243 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(8523) == 1;
}






}


public sealed class JOBOPPORTUNITYCullingtheCompetition : QuestGrinderClass
{
    public JOBOPPORTUNITYCullingtheCompetition()
    {
        Name = "JOB OPPORTUNITY: Culling the Competition";

        QuestId.AddRange(new[] { 7729 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5846);
EntryTarget.Add(5844);
HotSpots.Add(new Vector3(-6788.352 , -1090.353 , 243.1615 , "None"));
HotSpots.Add(new Vector3(-6789.762 , -1086.111 , 242.9659 , "None"));
HotSpots.Add(new Vector3(-6703.07 , -1278.2 , 240.9516 , "None"));
HotSpots.Add(new Vector3(-6689.86 , -1342.14 , 247.9613 , "None"));
HotSpots.Add(new Vector3(-6685.11 , -1422.08 , 241.838 , "None"));
HotSpots.Add(new Vector3(-6725.4 , -1609.78 , 193.2109 , "None"));
HotSpots.Add(new Vector3(-6906.375 , -1322.579 , 178.9874 , "None"));
HotSpots.Add(new Vector3(-6856.942 , -1222.294 , 176.9421 , "None"));
HotSpots.Add(new Vector3(-6847.861 , -1186.258 , 183.2883 , "None"));
HotSpots.Add(new Vector3(-6841.047 , -1176.51 , 185.9731 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LedgerfromTanaris : QuestGathererClass
{
    public LedgerfromTanaris()
    {
        Name = "Ledger from Tanaris";

        QuestId.AddRange(new[] { 4450 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(173266);
HotSpots.Add(new Vector3(-7024.894 , -1784.041 , 265.7347 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(11727) == 1;
}






}


public sealed class LedgerfromTanarisGoodsteelsBalancedFlameberge : QuestGrinderClass
{
    public LedgerfromTanarisGoodsteelsBalancedFlameberge()
    {
        Name = "Ledger from Tanaris - Goodsteel's Balanced Flameberge";

        QuestId.AddRange(new[] { 4450 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(9916);
HotSpots.Add(new Vector3(-10416.8 , -4396.86 , 3.973591 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LedgerfromTanarisoverdueP : QuestGathererClass
{
    public LedgerfromTanarisoverdueP()
    {
        Name = "Ledger from Tanaris overdue P";

        QuestId.AddRange(new[] { 4450 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(174728);
HotSpots.Add(new Vector3(-3991.059 , -3812.968 , 35.06221 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LedgerfromTanarisspider : QuestGrinderClass
{
    public LedgerfromTanarisspider()
    {
        Name = "Ledger from Tanaris spider";

        QuestId.AddRange(new[] { 4450 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5856);
HotSpots.Add(new Vector3(-7155.381 , -1716.229 , 243.9746 , "None"));
HotSpots.Add(new Vector3(-7118.373 , -1665.789 , 241.6679 , "None"));
HotSpots.Add(new Vector3(-6862.31 , -1704.322 , 250.8758 , "None"));
HotSpots.Add(new Vector3(-6910.77 , -1724.094 , 243.3186 , "None"));
HotSpots.Add(new Vector3(-6667.64 , -1775.023 , 261.0372 , "None"));
HotSpots.Add(new Vector3(-6681.203 , -1845.29 , 247.7388 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReturntoFelZerul : QuestClass
{
    public ReturntoFelZerul()
    {
        Name = "Return to Fel&#039;Zerul";

        QuestId.AddRange(new[] { 1444 });

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
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6948) == 1;
}






}


public sealed class SetThemAblaze : QuestGathererClass
{
    public SetThemAblaze()
    {
        Name = "Set Them Ablaze!";

        QuestId.AddRange(new[] { 3463 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, true, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(149031);
EntryIdObjects.Add(149030);
EntryIdObjects.Add(149025);
EntryIdObjects.Add(149032);
HotSpots.Add(new Vector3(-6914.342 , -1439.592 , 257.2903 , "None"));
HotSpots.Add(new Vector3(-7006.688 , -1305.988 , 259.3432 , "None"));
HotSpots.Add(new Vector3(-7002.423 , -1118.428 , 258.8406 , "None"));
HotSpots.Add(new Vector3(-6910.25 , -1066.04 , 257.864 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SlakeThatThirst : QuestGrinderClass
{
    public SlakeThatThirst()
    {
        Name = "Slake That Thirst";

        QuestId.AddRange(new[] { 379 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5615);
EntryTarget.Add(5623);
EntryTarget.Add(5617);
EntryTarget.Add(5616);
HotSpots.Add(new Vector3(-7386.246 , -4423.582 , 10.75148 , "None"));
HotSpots.Add(new Vector3(-7382.903 , -4409.313 , 9.363078 , "None"));
HotSpots.Add(new Vector3(-7361.306 , -4415.875 , 9.894652 , "None"));
HotSpots.Add(new Vector3(-7453.742 , -4481.789 , 9.213753 , "None"));
HotSpots.Add(new Vector3(-7409.34 , -4584.32 , 8.830967 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SquireMaltrake : QuestClass
{
    public SquireMaltrake()
    {
        Name = "Squire Maltrake";

        QuestId.AddRange(new[] { 3462 });

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
return ObjectManager.Me.Position.DistanceTo2D(new Vector3(-6679.93, -1194.36, 240.2135)) < 5000;
}






}


public sealed class STOLENSmithingTuyereandLookoutsSpyglass : QuestGrinderClass
{
    public STOLENSmithingTuyereandLookoutsSpyglass()
    {
        Name = "STOLEN: Smithing Tuyere and Lookout&#039;s Spyglass";

        QuestId.AddRange(new[] { 7728 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(8566);
HotSpots.Add(new Vector3(-6894.89 , -1058.802 , 240.0117 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class STOLENSmithingTuyereandLookoutsSpyglassmeh : QuestGrinderClass
{
    public STOLENSmithingTuyereandLookoutsSpyglassmeh()
    {
        Name = "STOLEN: Smithing Tuyere and Lookout&#039;s Spyglass . meh";

        QuestId.AddRange(new[] { 7728 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5840);
HotSpots.Add(new Vector3(-6861.831 , -1171.039 , 240.2192 , "None"));
HotSpots.Add(new Vector3(-6871.943 , -1280.61 , 242.4263 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SuntaraStones : QuestFollowNpcClass
{
    public SuntaraStones()
    {
        Name = "Suntara Stones";

        QuestId.AddRange(new[] { 3367 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        StartPosition = new Vector3(-7007.21 , -1749.16 , 234.0989 , "None");
NpcEntry = 8284;
Assist = true;
FollowDistance = 5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SuntaraStonespt2 : QuestClass
{
    public SuntaraStonespt2()
    {
        Name = "Suntara Stones pt2";

        QuestId.AddRange(new[] { 3368 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(10443) == 1;
}






}


public sealed class TestingtheVessel : QuestClass
{
    public TestingtheVessel()
    {
        Name = "Testing the Vessel";

        QuestId.AddRange(new[] { 3123 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

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


public sealed class TheDisgracedOne : QuestClass
{
    public TheDisgracedOne()
    {
        Name = "The Disgraced One";

        QuestId.AddRange(new[] { 2621 });

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
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6948) == 1;
}






}


public sealed class TheFlamesCasing : QuestGrinderClass
{
    public TheFlamesCasing()
    {
        Name = "The Flame&#039;s Casing";

        QuestId.AddRange(new[] { 3452 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5860);
EntryTarget.Add(5861);
HotSpots.Add(new Vector3(-6711.61 , -845.6608 , 244.1521 , "None"));
HotSpots.Add(new Vector3(-6685.643 , -848.4754 , 245.451 , "None"));
HotSpots.Add(new Vector3(-6679.388 , -817.5284 , 244.145 , "None"));
HotSpots.Add(new Vector3(-6644.476 , -846.1769 , 246.5618 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheFlawlessFlame : QuestGrinderClass
{
    public TheFlawlessFlame()
    {
        Name = "The Flawless Flame";

        QuestId.AddRange(new[] { 3442 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5855);
EntryTarget.Add(5852);
EntryTarget.Add(5850);
HotSpots.Add(new Vector3(-7213.454 , -1021.568 , 239.4463 , "None"));
HotSpots.Add(new Vector3(-7150.242 , -1045.566 , 240.5084 , "None"));
HotSpots.Add(new Vector3(-7057.716 , -1001.999 , 241.3088 , "None"));
HotSpots.Add(new Vector3(-6901.171 , -866.5716 , 250.8388 , "None"));
HotSpots.Add(new Vector3(-6755.378 , -1014.916 , 237.7953 , "None"));
HotSpots.Add(new Vector3(-6676.806 , -1270.7 , 239.5666 , "None"));
HotSpots.Add(new Vector3(-7242.113 , -1119.153 , 274.0133 , "None"));
HotSpots.Add(new Vector3(-6756.839 , -1013.65 , 237.8825 , "None"));
HotSpots.Add(new Vector3(-6930.647 , -1197.202 , 144.7751 , "None"));
HotSpots.Add(new Vector3(-6840.8 , -1397.034 , 168.3366 , "None"));
HotSpots.Add(new Vector3(-6834.01 , -1388.063 , 169.2904 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheKeytoFreedom : QuestGrinderClass
{
    public TheKeytoFreedom()
    {
        Name = "The Key to Freedom";

        QuestId.AddRange(new[] { 4451 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 11818;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5844);
EntryTarget.Add(5846);
EntryTarget.Add(5840);
EntryTarget.Add(8566);
HotSpots.Add(new Vector3(-6845.046 , -1377.016 , 168.8581 , "None"));
HotSpots.Add(new Vector3(-6708.303 , -1621.988 , 199.3925 , "None"));
HotSpots.Add(new Vector3(-6685.11 , -1422.08 , 241.838 , "None"));
HotSpots.Add(new Vector3(-6837.651 , -1225.446 , 240.223 , "None"));
HotSpots.Add(new Vector3(-6837.624 , -1160.278 , 240.975 , "None"));
HotSpots.Add(new Vector3(-6800.205 , -1091.896 , 243.8792 , "None"));
HotSpots.Add(new Vector3(-6871.796 , -1073.839 , 240.0136 , "None"));
HotSpots.Add(new Vector3(-6928.068 , -1050.353 , 239.1319 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(11818) == 1;
}



public override bool HasQuest() { return true; }


}


public sealed class TheMissingOrders : QuestClass
{
    public TheMissingOrders()
    {
        Name = "The Missing Orders";

        QuestId.AddRange(new[] { 2622 });

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
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6948) == 1;
}






}


public sealed class TheSwampTalker : QuestGrinderClass
{
    public TheSwampTalker()
    {
        Name = "The Swamp Talker";

        QuestId.AddRange(new[] { 2623 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(950);
HotSpots.Add(new Vector3(-10967.6 , -3658.81 , 27.97396 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheTorchofRetribution : QuestClass
{
    public TheTorchofRetribution()
    {
        Name = "The Torch of Retribution";

        QuestId.AddRange(new[] { 3453 });

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

public override bool IsComplete() { 
return ObjectManager.Me.Position.DistanceTo2D(new Vector3(-6679.93, -1194.36, 240.2135)) < 5000;
}






}


public sealed class TheTorchofRetributionpt2 : QuestClass
{
    public TheTorchofRetributionpt2()
    {
        Name = "The Torch of Retribution pt2";

        QuestId.AddRange(new[] { 3454 });

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

public override bool IsComplete() { 
return ObjectManager.Me.Position.DistanceTo2D(new Vector3(-6679.93, -1194.36, 240.2135)) < 5000;
}






}


public sealed class Trinkets : QuestClass
{
    public Trinkets()
    {
        Name = "Trinkets...";

        QuestId.AddRange(new[] { 3481 });

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
return ObjectManager.Me.Position.DistanceTo2D(new Vector3(-6679.93, -1194.36, 240.2135)) < 5000;
}






}


public sealed class WANTEDOverseerMaltorius : QuestGrinderClass
{
    public WANTEDOverseerMaltorius()
    {
        Name = "WANTED: Overseer Maltorius";

        QuestId.AddRange(new[] { 7701 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(14621);
HotSpots.Add(new Vector3(-6633.88 , -1232.66 , 209.8091 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WhattheFlux : QuestGathererClass
{
    public WhattheFlux()
    {
        Name = "What the Flux?";

        QuestId.AddRange(new[] { 7722 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(179826);
HotSpots.Add(new Vector3(-6631.514 , -1226.458 , 209.8098 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Killmargol : QuestGrinderClass
{
    public Killmargol()
    {
        Name = "Kill margol";

        QuestId.AddRange(new[] { 3181 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(5833);
HotSpots.Add(new Vector3(-7196.305 , -1945.077 , 316.8829 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(10000) == 1;
}






}


public sealed class Followmetothevillage : QuestFollowPathClass
{
    public Followmetothevillage()
    {
        Name = "Follow me to the village";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-6681.637 , -1192.805 , 240.0903 , "None"));
Path.Add(new Vector3(-6681.962 , -1177.478 , 240.0155 , "None"));
Path.Add(new Vector3(-6674.573 , -1171.818 , 240.7328 , "None"));
Path.Add(new Vector3(-6662.945 , -1161.894 , 243.4578 , "None"));
Path.Add(new Vector3(-6659.721 , -1157.445 , 244.2589 , "None"));
Path.Add(new Vector3(-6650.323 , -1142.695 , 244.4531 , "None"));
Path.Add(new Vector3(-6641.416 , -1127.632 , 244.4543 , "None"));
Path.Add(new Vector3(-6632.413 , -1112.625 , 244.2425 , "None"));
Path.Add(new Vector3(-6623.441 , -1097.6 , 244.2943 , "None"));
Path.Add(new Vector3(-6616.88 , -1084.381 , 244.7881 , "None"));
Path.Add(new Vector3(-6612.614 , -1071.977 , 245.7343 , "None"));
Path.Add(new Vector3(-6612.5 , -1065.234 , 245.6192 , "None"));
Path.Add(new Vector3(-6612.328 , -1058.518 , 245.6636 , "None"));
Path.Add(new Vector3(-6611.667 , -1048.748 , 244.6838 , "None"));
Path.Add(new Vector3(-6610.889 , -1043.911 , 245.003 , "None"));
Path.Add(new Vector3(-6605.504 , -1025.625 , 244.5636 , "None"));
Path.Add(new Vector3(-6599.489 , -1017.9 , 244.6741 , "None"));
Path.Add(new Vector3(-6591.514 , -1032.885 , 254.5023 , "None"));
Path.Add(new Vector3(-6587.038 , -1041.677 , 259.5689 , "None"));
Path.Add(new Vector3(-6580.457 , -1049.518 , 262.9613 , "None"));
Path.Add(new Vector3(-6564.826 , -1057.377 , 269.2411 , "None"));
Path.Add(new Vector3(-6549.126 , -1065.04 , 276.3479 , "None"));
Path.Add(new Vector3(-6532.793 , -1071.18 , 282.1298 , "None"));
Path.Add(new Vector3(-6515.805 , -1075.38 , 287.8802 , "None"));
Path.Add(new Vector3(-6499.095 , -1080.519 , 293.5792 , "None"));
Path.Add(new Vector3(-6488.105 , -1088.325 , 297.487 , "None"));
Path.Add(new Vector3(-6485.863 , -1091.453 , 298.4653 , "None"));
Path.Add(new Vector3(-6482.293 , -1100.655 , 301.1787 , "None"));
Path.Add(new Vector3(-6483.365 , -1117.624 , 305.2491 , "None"));
Path.Add(new Vector3(-6490.557 , -1133.561 , 306.5769 , "None"));
Path.Add(new Vector3(-6498.863 , -1148.964 , 307.9005 , "None"));
Path.Add(new Vector3(-6501.2 , -1153.271 , 308.1756 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = true;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ObjectManager.Me.Position.DistanceTo2D(new Vector3(-6501.2, -1153.271, 308.1756)) < 5;
}



public override bool HasQuest() { return true; }


}


public sealed class DwarvenJustice : QuestClass
{
    public DwarvenJustice()
    {
        Name = "Dwarven Justice";

        QuestId.AddRange(new[] { 3371 });

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
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6948) == 1;
}






}


public sealed class TheHornoftheBeast : QuestClass
{
    public TheHornoftheBeast()
    {
        Name = "The Horn of the Beast";

        QuestId.AddRange(new[] { 3181 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6948) == 1;
}






}


public sealed class ProofofDeed : QuestClass
{
    public ProofofDeed()
    {
        Name = "Proof of Deed";

        QuestId.AddRange(new[] { 3182 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(10005) == 1;
}






}


public sealed class AtLast : QuestClass
{
    public AtLast()
    {
        Name = "At Last!";

        QuestId.AddRange(new[] { 3201 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(10022) == 1;
}






}


public sealed class ALittleSlimeGoesaLongWay : QuestGrinderClass
{
    public ALittleSlimeGoesaLongWay()
    {
        Name = "A Little Slime Goes a Long Way";

        QuestId.AddRange(new[] { 4512 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

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


public sealed class FollowpathtoDwarven : QuestFollowPathClass
{
    public FollowpathtoDwarven()
    {
        Name = "Follow path to Dwarven";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-6914.344 , -1246.218 , 178.336 , "None"));
Path.Add(new Vector3(-6903.962 , -1245.711 , 177.7624 , "None"));
Path.Add(new Vector3(-6893.074 , -1244.924 , 178.7554 , "None"));
Path.Add(new Vector3(-6887.726 , -1242.252 , 178.3242 , "None"));
Path.Add(new Vector3(-6882.538 , -1237.368 , 177.6314 , "None"));
Path.Add(new Vector3(-6878.955 , -1232.531 , 177.1619 , "None"));
Path.Add(new Vector3(-6872.621 , -1222.292 , 177.1698 , "None"));
Path.Add(new Vector3(-6863.594 , -1206.659 , 178.9938 , "None"));
Path.Add(new Vector3(-6856.341 , -1191.351 , 182.7116 , "None"));
Path.Add(new Vector3(-6853.501 , -1185.423 , 184.192 , "None"));
Path.Add(new Vector3(-6846.603 , -1176.328 , 186.5813 , "None"));
Path.Add(new Vector3(-6833.58 , -1172.142 , 188.1253 , "None"));
Path.Add(new Vector3(-6826.486 , -1171.775 , 189.7545 , "None"));
Path.Add(new Vector3(-6758.906 , -1166.678 , 187.1132 , "None"));
IsCompleteWhenAtLastPath = false;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ObjectManager.Me.Position.DistanceTo2D(new Vector3(-6758.906, -1166.678, 187.1132)) < 2;
}



public override bool HasQuest() { return true; }


}


public sealed class ReleaseThem : QuestClass
{
    public ReleaseThem()
    {
        Name = "Release Them";

        QuestId.AddRange(new[] { 3372 });

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
        return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(10442) == 1;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(10442) == 1;
}






}


public sealed class FollowpathtoZamael : QuestFollowPathClass
{
    public FollowpathtoZamael()
    {
        Name = "Follow path to Zamael";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-6578.786 , -867.605 , 260.1881 , "None"));
Path.Add(new Vector3(-6574.353 , -870.8521 , 263.2739 , "None"));
Path.Add(new Vector3(-6569.5 , -874.415 , 266.6772 , "None"));
Path.Add(new Vector3(-6563.901 , -878.7296 , 271.8954 , "None"));
Path.Add(new Vector3(-6556.849 , -885.0452 , 279.9575 , "None"));
Path.Add(new Vector3(-6551.913 , -890.8337 , 287.3663 , "None"));
Path.Add(new Vector3(-6550.638 , -893.2477 , 289.7939 , "None"));
Path.Add(new Vector3(-6548.686 , -895.8963 , 293.0074 , "None"));
Path.Add(new Vector3(-6546.835 , -897.9507 , 295.3286 , "None"));
Path.Add(new Vector3(-6543.267 , -899.2717 , 298.9974 , "None"));
Path.Add(new Vector3(-6537.389 , -899.6321 , 303.4919 , "None"));
Path.Add(new Vector3(-6533.843 , -896.2695 , 305.7678 , "None"));
Path.Add(new Vector3(-6528.465 , -890.0927 , 310.1678 , "None"));
Path.Add(new Vector3(-6522.62 , -883.5854 , 313.5839 , "None"));
Path.Add(new Vector3(-6519.345 , -880.6846 , 315.5577 , "None"));
Path.Add(new Vector3(-6511.252 , -877.6895 , 318.9406 , "None"));
Path.Add(new Vector3(-6507.402 , -877.6462 , 320.0251 , "None"));
Path.Add(new Vector3(-6505.429 , -887.8522 , 319.5336 , "None"));
Path.Add(new Vector3(-6501.863 , -894.521 , 321.7307 , "None"));
Path.Add(new Vector3(-6499.13 , -897.937 , 323.1549 , "None"));
Path.Add(new Vector3(-6492.643 , -903.8049 , 324.5114 , "None"));
Path.Add(new Vector3(-6487.407 , -909.3665 , 325.3409 , "None"));
Path.Add(new Vector3(-6485.462 , -912.0202 , 326.9389 , "None"));
Path.Add(new Vector3(-6481.582 , -918.5275 , 331.8891 , "None"));
Path.Add(new Vector3(-6481.241 , -922.3624 , 333.3492 , "None"));
Path.Add(new Vector3(-6481.046 , -926.7329 , 334.1729 , "None"));
Path.Add(new Vector3(-6481.454 , -935.4308 , 334.2441 , "None"));
Path.Add(new Vector3(-6482.36 , -941.382 , 334.2441 , "None"));
Path.Add(new Vector3(-6482.707 , -943.5595 , 334.2441 , "None"));
IsCompleteWhenAtLastPath = false;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ObjectManager.Me.Position.DistanceTo2D(new Vector3(-6482.707, -943.5595, 334.2441)) < 2;
}



public override bool HasQuest() { return true; }


}


public sealed class PrayertoElune : QuestClass
{
    public PrayertoElune()
    {
        Name = "Prayer to Elune";

        QuestId.AddRange(new[] { 3377 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6948) == 1;
}






}


public sealed class PrayertoElunept2 : QuestGrinderClass
{
    public PrayertoElunept2()
    {
        Name = "Prayer to Elune pt2";

        QuestId.AddRange(new[] { 3378 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(8419);
EntryTarget.Add(5861);
HotSpots.Add(new Vector3(-6485.55 , -984.542 , 335.3589 , "None"));
HotSpots.Add(new Vector3(-6495.398 , -980.8807 , 335.1884 , "None"));
HotSpots.Add(new Vector3(-6490.791 , -1008.856 , 341.0741 , "None"));
HotSpots.Add(new Vector3(-6477.95 , -962.255 , 335.1293 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BoatfromBBAuberdine : QuestClass
{
    public BoatfromBBAuberdine()
    {
        Name = "Boat from BB -> Auberdine";

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


    }

	public override bool CanConditions()
	{
        return Usefuls.ContinentId == (int) ContinentId.Azeroth;
	}

public override bool IsComplete() { 
return Usefuls.ContinentId == (int) ContinentId.Kalimdor && !ObjectManager.Me.InTransport;
}



public override bool HasQuest() { return true; }

public override bool Pulse() {
// Sample of how to use Zeppelin/Ship
// In this sample, WRobot catch Zeppelin from Kalimdor (Ogrimmard) to Northrend (Borean Tundra (Warsong Hold))

/* Quest settings:
    * Can condition: "return Usefuls.ContinentId == (int) ContinentId.Kalimdor;"
    * Is complete condition: "return Usefuls.ContinentId == (int) ContinentId.Northrend && !ObjectManager.Me.InTransport;"
    * Not required in quest log: "True"
    * Quest type: "OverridePulseCSharpCode"
*/

// You can get zeppelin/ship/player positions and entry ID in tab "Tools" > "Development Tools" > "Dump all informations" (or "Memory information").

// Settings:
var zeppelinEntryId = 176310; // Zeppelin/Ship EntryId
// From
var fromZeppelinWaitPosition = new Vector3(-3709.475, -575.0988, 0); // Position where Zeppelin/Ship waits players (from)
var fromPlayerWaitPosition = new Vector3(-3721.774, -581.1777, 6.224298); // Position where the player waits Zeppelin/Ship (from)
var fromPlayerInZeppelinPosition = new Vector3(-3709.045, -579.3682, 6.097368); // Position where the player waits in the Zeppelin/Ship (from)
// To
var toZeppelinWaitPosition = new Vector3(6406.216, 823.0809, 0); // Position where Zeppelin/Ship waits players (to)
var toPlayerLeavePosition = new Vector3(6425.884, 816.0533, 5.456141); // Position to go out the Zeppelin/Ship (to)

// Change WRobot settings:
wManager.wManagerSetting.CurrentSetting.CloseIfPlayerTeleported = false;

// Code:
if (!Conditions.InGameAndConnectedAndProductStartedNotInPause)
    return true;

if (Usefuls.ContinentId == (int)ContinentId.Azeroth)
{
    if (!ObjectManager.Me.InTransport)
    {
        if (GoToTask.ToPosition(fromPlayerWaitPosition))
        {
            var zeppelin = ObjectManager.GetWoWGameObjectByEntry(zeppelinEntryId).OrderBy(o => o.GetDistance).FirstOrDefault();
            if (zeppelin != null && zeppelin.Position.DistanceTo(fromZeppelinWaitPosition) < 1)
            {
                GoToTask.ToPosition(fromPlayerInZeppelinPosition);
            }
        }
    }
}
else if (Usefuls.ContinentId == (int)ContinentId.Kalimdor)
{
    if (ObjectManager.Me.InTransport)
    {
        var zeppelin = ObjectManager.GetWoWGameObjectByEntry(zeppelinEntryId).OrderBy(o => o.GetDistance).FirstOrDefault();
        if (zeppelin != null && zeppelin.Position.DistanceTo(toZeppelinWaitPosition) < 1)
        {
            GoToTask.ToPosition(toPlayerLeavePosition);
        }
    }
}
return true;


}
}


public sealed class Followthoughportal : QuestFollowPathClass
{
    public Followthoughportal()
    {
        Name = "Follow though portal";

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

        Path.Add(new Vector3(8642.748 , 845.5197 , 23.33269 , "None"));
Path.Add(new Vector3(8643.926 , 853.0933 , 22.37526 , "None"));
Path.Add(new Vector3(8646.895 , 866.9244 , 22.91792 , "None"));
Path.Add(new Vector3(8652.455 , 871.2744 , 23.05359 , "None"));
Path.Add(new Vector3(8661.021 , 874.5355 , 22.21798 , "None"));
Path.Add(new Vector3(8670.055 , 876.3946 , 22.15471 , "None"));
Path.Add(new Vector3(8677.642 , 879.4062 , 22.61702 , "None"));
Path.Add(new Vector3(8684.587 , 887.715 , 22.65967 , "None"));
Path.Add(new Vector3(8687.063 , 896.0626 , 22.19837 , "None"));
Path.Add(new Vector3(8687.627 , 906.4392 , 20.8764 , "None"));
Path.Add(new Vector3(8687.529 , 916.8336 , 18.213 , "None"));
Path.Add(new Vector3(8688.176 , 927.2369 , 15.5352 , "None"));
Path.Add(new Vector3(8690.966 , 935.4517 , 14.92343 , "None"));
Path.Add(new Vector3(8696.768 , 940.4317 , 14.03958 , "None"));
Path.Add(new Vector3(8706.972 , 942.0364 , 13.76643 , "None"));
Path.Add(new Vector3(8715.714 , 942.3594 , 14.74416 , "None"));
Path.Add(new Vector3(8727.709 , 942.9644 , 17.56696 , "None"));
Path.Add(new Vector3(8736.847 , 944.7423 , 20.49175 , "None"));
Path.Add(new Vector3(8748.399 , 948.0801 , 24.31801 , "None"));
Path.Add(new Vector3(8756.961 , 951.6359 , 26.83865 , "None"));
Path.Add(new Vector3(8767.176 , 956.7337 , 29.4467 , "None"));
Path.Add(new Vector3(8773.063 , 959.6729 , 30.15397 , "None"));
Path.Add(new Vector3(8779.419 , 962.8467 , 30.2617 , "None"));
Path.Add(new Vector3(8782.362 , 964.3163 , 30.22004 , "None"));
Path.Add(new Vector3(8784.304 , 965.2856 , 30.20418 , "None"));
Path.Add(new Vector3(8785.772 , 966.0262 , 30.20247 , "None"));
Path.Add(new Vector3(8788.222 , 967.2314 , 30.1961 , "None"));
Path.Add(new Vector3(8789.796 , 967.7084 , 30.1961 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = true;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return ObjectManager.Me.Position.DistanceTo2D(new Vector3(8643.821f, 840.7147f, 23.26179f)) < 30;
	}

public override bool IsComplete() { 
return ObjectManager.Me.Position.DistanceTo2D(new Vector3(9948.959f, 2618.695f, 1316.98f)) < 30;
}



public override bool HasQuest() { return true; }


}


public sealed class RiseoftheSilithid : QuestClass
{
    public RiseoftheSilithid()
    {
        Name = "Rise of the Silithid";

        QuestId.AddRange(new[] { 162 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(8594) == 1;
}






}


public sealed class MarchoftheSilithid : QuestClass
{
    public MarchoftheSilithid()
    {
        Name = "March of the Silithid";

        QuestId.AddRange(new[] { 4493 });

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

public override bool IsComplete() { 
return ObjectManager.Me.Position.DistanceTo2D(new Vector3(-7115.3f, -3729.93f, 8.773399f)) < 50;
}






}


public sealed class AssistingArchDruidStaghelm : QuestClass
{
    public AssistingArchDruidStaghelm()
    {
        Name = "Assisting Arch Druid Staghelm";

        QuestId.AddRange(new[] { 3763 });

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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(6948) == 1;
}






}


public sealed class UnGoroSoil : QuestGrinderClass
{
    public UnGoroSoil()
    {
        Name = "Un&#039;Goro Soil";

        QuestId.AddRange(new[] { 3764 });

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


public sealed class Totoflightmasteragain : QuestFollowPathClass
{
    public Totoflightmasteragain()
    {
        Name = "To to flight master again";

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

        Path.Add(new Vector3(10127.92 , 2228.312 , 1328.641 , "None"));
Path.Add(new Vector3(10125.65 , 2238.278 , 1327.867 , "None"));
Path.Add(new Vector3(10123.79 , 2242.805 , 1327.596 , "None"));
Path.Add(new Vector3(10117.25 , 2252.898 , 1327.475 , "None"));
Path.Add(new Vector3(10107.42 , 2265.999 , 1328.27 , "None"));
Path.Add(new Vector3(10096.88 , 2279.301 , 1328.275 , "None"));
Path.Add(new Vector3(10085.63 , 2293.386 , 1329.509 , "None"));
Path.Add(new Vector3(10083.23 , 2296.395 , 1329.441 , "None"));
Path.Add(new Vector3(10065.44 , 2294.82 , 1329.388 , "None"));
Path.Add(new Vector3(10048.1 , 2289.967 , 1329.052 , "None"));
Path.Add(new Vector3(10031.42 , 2286.859 , 1329.758 , "None"));
Path.Add(new Vector3(10014.07 , 2284.592 , 1338.392 , "None"));
Path.Add(new Vector3(9996.592 , 2283.837 , 1341.394 , "None"));
Path.Add(new Vector3(9987.323 , 2283.488 , 1341.394 , "None"));
Path.Add(new Vector3(9971.64 , 2282.958 , 1341.394 , "None"));
Path.Add(new Vector3(9962.76 , 2280.178 , 1341.394 , "None"));
Path.Add(new Vector3(9953.565 , 2280.105 , 1341.394 , "None"));
Path.Add(new Vector3(9950.535 , 2293.922 , 1340.777 , "None"));
Path.Add(new Vector3(9950.767 , 2311.421 , 1336.552 , "None"));
Path.Add(new Vector3(9950.399 , 2329.44 , 1333.674 , "None"));
Path.Add(new Vector3(9949.693 , 2346.4 , 1330.761 , "None"));
Path.Add(new Vector3(9949.005 , 2364.412 , 1330.296 , "None"));
Path.Add(new Vector3(9948.365 , 2381.375 , 1329.65 , "None"));
Path.Add(new Vector3(9947.688 , 2399.387 , 1328.566 , "None"));
Path.Add(new Vector3(9947.049 , 2416.35 , 1326.875 , "None"));
Path.Add(new Vector3(9946.413 , 2434.364 , 1324.589 , "None"));
Path.Add(new Vector3(9946.332 , 2451.338 , 1321.534 , "None"));
Path.Add(new Vector3(9947.508 , 2469.309 , 1317.685 , "None"));
Path.Add(new Vector3(9951.536 , 2485.708 , 1316.342 , "None"));
Path.Add(new Vector3(9961.074 , 2500.964 , 1317.124 , "None"));
Path.Add(new Vector3(9968.858 , 2512.891 , 1317.831 , "None"));
Path.Add(new Vector3(9973.779 , 2520.753 , 1317.604 , "None"));
Path.Add(new Vector3(9977.584 , 2536.482 , 1316.295 , "None"));
Path.Add(new Vector3(9974.626 , 2540.919 , 1316.29 , "None"));
Path.Add(new Vector3(9960.004 , 2549.488 , 1316.69 , "None"));
Path.Add(new Vector3(9946.866 , 2561.179 , 1316.033 , "None"));
Path.Add(new Vector3(9945.856 , 2578.034 , 1317.772 , "None"));
Path.Add(new Vector3(9945.946 , 2595.531 , 1316.191 , "None"));
Path.Add(new Vector3(9945.97 , 2609.741 , 1316.245 , "None"));
Path.Add(new Vector3(9945.971 , 2610.266 , 1316.246 , "None"));
Path.Add(new Vector3(9945.997 , 2627.207 , 1318.354 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = true;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return ObjectManager.Me.Position.DistanceTo2D(new Vector3(10127.9f, 2224.79f, 1328.739f)) < 40;
	}

public override bool IsComplete() { 
return ObjectManager.Me.Position.DistanceTo2D(new Vector3(8779.753f, 965.7244f, 30.28374f)) < 40;
}



public override bool HasQuest() { return true; }


}


public sealed class BungleintheJungle : QuestGrinderClass
{
    public BungleintheJungle()
    {
        Name = "Bungle in the Jungle";

        QuestId.AddRange(new[] { 4496 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

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
