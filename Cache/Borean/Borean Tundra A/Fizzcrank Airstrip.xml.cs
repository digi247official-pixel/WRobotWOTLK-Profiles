
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



public sealed class ABotinMammothsClothing : QuestGrinderClass
{
    public ABotinMammothsClothing()
    {
        Name = "A Bot in Mammoth's Clothing";

        QuestId.AddRange(new[] { 11718 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(24614);
EntryTarget.Add(25743);
EntryTarget.Add(24613);
HotSpots.Add(new Vector3(4075.65 , 5393.36 , 29.38283 , "None"));
HotSpots.Add(new Vector3(4125.97 , 5488.55 , 27.40946 , "None"));
HotSpots.Add(new Vector3(4056.387 , 5545.543 , 39.85349 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ALittleBitofSpice : QuestGrinderClass
{
    public ALittleBitofSpice()
    {
        Name = "A Little Bit of Spice";

        QuestId.AddRange(new[] { 11726 });

        Step = new List<int> { 4, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25687);
EntryTarget.Add(25685);
HotSpots.Add(new Vector3(3314.99 , 4852.64 , 28.7645 , "None"));
HotSpots.Add(new Vector3(3349.4 , 4804.98 , 29.45693 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BacktotheAirstrip : QuestClass
{
    public BacktotheAirstrip()
    {
        Name = "Back to the Airstrip";

        QuestId.AddRange(new[] { 11701 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

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


public sealed class Biasto : QuestGathererClass
{
    public Biasto()
    {
        Name = "Biasto";

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

        EntryIdObjects.Add(188108);
EntryIdObjects.Add(187986);
HotSpots.Add(new Vector3(4033.849 , 4900.23 , -12.77946 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(3, 11788);
}



public override bool HasQuest() { return true; }


}


public sealed class CheckinWithBixie : QuestClass
{
    public CheckinWithBixie()
    {
        Name = "Check in With Bixie";

        QuestId.AddRange(new[] { 11692 });

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


public sealed class DeploytheShakenQuake : QuestGrinderClass
{
    public DeploytheShakenQuake()
    {
        Name = "Deploy the Shake-n-Quake!";

        QuestId.AddRange(new[] { 11723 });

        Step = new List<int> { 1, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25629);
HotSpots.Add(new Vector3(3494.956 , 4552.034 , -12.89141 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DirtyStinkinSnobolds : QuestGathererClass
{
    public DirtyStinkinSnobolds()
    {
        Name = "Dirty, Stinkin' Snobolds!";

        QuestId.AddRange(new[] { 11645 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(187689);
HotSpots.Add(new Vector3(4278.188 , 5380.33 , 37.08601 , "None"));
HotSpots.Add(new Vector3(4285.73 , 5403.024 , 34.35839 , "None"));
HotSpots.Add(new Vector3(4314.348 , 5345.572 , 45.44991 , "None"));
HotSpots.Add(new Vector3(4325.056 , 5391.823 , 44.72791 , "None"));
HotSpots.Add(new Vector3(4309.514 , 5437.989 , 42.62217 , "None"));
HotSpots.Add(new Vector3(4324.144 , 5441.144 , 44.46725 , "None"));
HotSpots.Add(new Vector3(4363.107 , 5454.239 , 49.09571 , "None"));
HotSpots.Add(new Vector3(4374.676 , 5472.863 , 48.99075 , "None"));
HotSpots.Add(new Vector3(4355.116 , 5501.525 , 49.27336 , "None"));
HotSpots.Add(new Vector3(4359.905 , 5510.941 , 50.44596 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DistressCall : QuestClass
{
    public DistressCall()
    {
        Name = "Distress Call";

        QuestId.AddRange(new[] { 11707 });

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


public sealed class Doctor : QuestGrinderClass
{
    public Doctor()
    {
        Name = "Doctor";

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

        EntryTarget.Add(25678);
HotSpots.Add(new Vector3(4403.909 , 4552.796 , 88.7558 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(34958) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class ED : QuestGathererClass
{
    public ED()
    {
        Name = "ED";

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

        EntryIdObjects.Add(188107);
EntryIdObjects.Add(187985);
HotSpots.Add(new Vector3(4226.611 , 4797.948 , -12.99553 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(2, 11788);
}



public override bool HasQuest() { return true; }


}


public sealed class EmergencyProtocolSection82ParagraphC : QuestInteractWithClass
{
    public EmergencyProtocolSection82ParagraphC()
    {
        Name = "Emergency Protocol: Section 8.2, Paragraph C";

        QuestId.AddRange(new[] { 11795 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(25841);
HotSpots.Add(new Vector3(3525.88 , 5124.33 , 13.29199 , "None"));
HotSpots.Add(new Vector3(3395.417 , 5144.976 , 13.03777 , "None"));
HotSpots.Add(new Vector3(3417.605 , 5078.548 , 13.94145 , "None"));
HotSpots.Add(new Vector3(3493.85 , 5153.4 , 16.41853 , "None"));
HotSpots.Add(new Vector3(3425.42 , 5182.84 , 17.56367 , "None"));
HotSpots.Add(new Vector3(3325.55 , 5169.61 , 13.03798 , "None"));
HotSpots.Add(new Vector3(3290.12 , 5082.75 , 16.20187 , "None"));
HotSpots.Add(new Vector3(3356.85 , 5044.32 , 13.03778 , "None"));
HotSpots.Add(new Vector3(3418.47 , 5076.99 , 14.21118 , "None"));
HotSpots.Add(new Vector3(3521.55 , 4876.76 , 15.5655 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "";
IgnoreIfDead = true;
Range = 3.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class EmergencyProtocolSection82ParagraphD : QuestUseItemOnClass
{
    public EmergencyProtocolSection82ParagraphD()
    {
        Name = "Emergency Protocol: Section 8.2, Paragraph D";

        QuestId.AddRange(new[] { 11796 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(25845);
EntryIdTarget.Add(25846);
EntryIdTarget.Add(25847);
HotSpots.Add(new Vector3(3474.915 , 4908.92 , 12.71542 , "None"));
HotSpots.Add(new Vector3(3361.53 , 5049.887 , 13.03853 , "None"));
HotSpots.Add(new Vector3(3389.946 , 5139.579 , 13.03853 , "None"));
HotSpots.Add(new Vector3(3606.448 , 5068.025 , 13.00726 , "None"));
ItemId = 35224;
Range = 4f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class FindingPilotTailspin : QuestClass
{
    public FindingPilotTailspin()
    {
        Name = "Finding Pilot Tailspin";

        QuestId.AddRange(new[] { 11725 });

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


public sealed class FuelingtheProject : QuestClass
{
    public FuelingtheProject()
    {
        Name = "Fueling the Project";

        QuestId.AddRange(new[] { 11715 });

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


public sealed class GetMeOutaHere : QuestFollowNpcClass
{
    public GetMeOutaHere()
    {
        Name = "Get Me Outa Here!";

        QuestId.AddRange(new[] { 11673 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        StartPosition = new Vector3(4464.63 , 5378.07 , -15.2737 , "None");
NpcEntry = 25589;
Assist = true;
FollowDistance = 4f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GetMeOutaHereSpot : QuestFollowPathClass
{
    public GetMeOutaHereSpot()
    {
        Name = "Get Me Outa Here! Spot";

        QuestId.AddRange(new[] { 11673 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(4438.842 , 5380.152 , -17.32743 , "Swimming"));
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


public sealed class Ghul : QuestGrinderClass
{
    public Ghul()
    {
        Name = "Ghul";

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

        EntryTarget.Add(25660);
HotSpots.Add(new Vector3(4246.823 , 4527.525 , 37.90676 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(34957) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class GiveFizzcranktheNews : QuestClass
{
    public GiveFizzcranktheNews()
    {
        Name = "Give Fizzcrank the News";

        QuestId.AddRange(new[] { 11873 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

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


public sealed class Grinder : QuestGathererClass
{
    public Grinder()
    {
        Name = "Grinder";

        QuestId.AddRange(new[] { 11907 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(187987);
EntryIdObjects.Add(188109);
HotSpots.Add(new Vector3(3791.885 , 4811.586 , -13.0264 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(4, 11788);
}



public override bool HasQuest() { return true; }


}


public sealed class ImStuckinthisDamnedCageButNotForLong : QuestGrinderClass
{
    public ImStuckinthisDamnedCageButNotForLong()
    {
        Name = "I'm Stuck in this Damned Cage... But Not For Long!";

        QuestId.AddRange(new[] { 11699 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { false, false, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25682);
EntryTarget.Add(25678);
EntryTarget.Add(25660);
HotSpots.Add(new Vector3(4388.674 , 4545.024 , 88.75626 , "None"));
HotSpots.Add(new Vector3(4385.13 , 4527.21 , 111.5567 , "None"));
HotSpots.Add(new Vector3(4394.047 , 4612.036 , 87.61288 , "None"));
HotSpots.Add(new Vector3(4450.122 , 4711.816 , 39.02001 , "None"));
HotSpots.Add(new Vector3(4263.343 , 4726.267 , 11.96232 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class JustaFewMoreThings : QuestGathererClass
{
    public JustaFewMoreThings()
    {
        Name = "Just a Few More Things...";

        QuestId.AddRange(new[] { 11650 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(187697);
HotSpots.Add(new Vector3(4008.736 , 4861.504 , -12.48924 , "None"));
HotSpots.Add(new Vector3(3264.023 , 3868.812 , 33.10892 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KingMrglMrgl : QuestClass
{
    public KingMrglMrgl()
    {
        Name = "King Mrgl-Mrgl";

        QuestId.AddRange(new[] { 11704 });

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


public sealed class LeftyLooseyRightyTighty : QuestGathererClass
{
    public LeftyLooseyRightyTighty()
    {
        Name = "Lefty Loosey, Righty Tighty";

        QuestId.AddRange(new[] { 11788 });

        Step = new List<int> { 1, 1, 1, 1, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(187984);
EntryIdObjects.Add(187986);
EntryIdObjects.Add(187987);
EntryIdObjects.Add(187985);
HotSpots.Add(new Vector3(4111.052 , 5098.755 , -1.509639 , "None"));
HotSpots.Add(new Vector3(4032.37 , 4897.083 , -12.77677 , "None"));
HotSpots.Add(new Vector3(4221.09 , 4793.311 , -12.99541 , "None"));
HotSpots.Add(new Vector3(3791.02 , 4812.61 , -12.9669 , "None"));
HotSpots.Add(new Vector3(4224.503 , 4798.444 , -12.99519 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LetBixieKnow : QuestClass
{
    public LetBixieKnow()
    {
        Name = "Let Bixie Know";

        QuestId.AddRange(new[] { 11700 });

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


public sealed class Lich : QuestGrinderClass
{
    public Lich()
    {
        Name = "Lich";

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

        EntryTarget.Add(25682);
HotSpots.Add(new Vector3(4371.842 , 4580.468 , 119.9194 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(34959) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class LupusPupus : QuestUseItemOnClass
{
    public LupusPupus()
    {
        Name = "Lupus Pupus";

        QuestId.AddRange(new[] { 11728 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(25791);
HotSpots.Add(new Vector3(3482.935 , 5013.639 , -1.509709 , "None"));
HotSpots.Add(new Vector3(3437.804 , 5047.117 , -1.508833 , "None"));
HotSpots.Add(new Vector3(3541.195 , 4972.279 , -1.510832 , "None"));
ItemId = 35121;
Range = 25f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MasterandServant : QuestInteractWithClass
{
    public MasterandServant()
    {
        Name = "Master and Servant";

        QuestId.AddRange(new[] { 11730 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(25753);
EntryIdTarget.Add(25758);
EntryIdTarget.Add(25752);
HotSpots.Add(new Vector3(4026.654 , 5180.911 , 13.13328 , "None"));
HotSpots.Add(new Vector3(4089.347 , 5189.686 , 13.11744 , "None"));
HotSpots.Add(new Vector3(4121.15 , 5183.466 , 13.11744 , "None"));
HotSpots.Add(new Vector3(4160.278 , 5192.33 , 13.17955 , "None"));
HotSpots.Add(new Vector3(4023.596 , 5120.156 , -1.387888 , "None"));
HotSpots.Add(new Vector3(4085.096 , 5119.733 , -1.510137 , "None"));
HotSpots.Add(new Vector3(4170.786 , 5158.869 , 13.0926 , "None"));
HotSpots.Add(new Vector3(4179.66 , 5125.22 , 13.0945 , "None"));
HotSpots.Add(new Vector3(4190.711 , 5183.772 , 13.54254 , "None"));
HotSpots.Add(new Vector3(4219.734 , 5184.801 , 13.48272 , "None"));
HotSpots.Add(new Vector3(4251.285 , 5196.916 , 13.09401 , "None"));
HotSpots.Add(new Vector3(4231.92 , 5091.18 , 13.27379 , "None"));
HotSpots.Add(new Vector3(4179.545 , 5064.618 , 13.37253 , "None"));
HotSpots.Add(new Vector3(4212.324 , 5051.385 , 13.27339 , "None"));
HotSpots.Add(new Vector3(4236.23 , 5017.397 , 13.27339 , "None"));
HotSpots.Add(new Vector3(4174.294 , 5012.729 , 13.43374 , "None"));
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


public sealed class MightAsWellWipeOuttheScourge : QuestGrinderClass
{
    public MightAsWellWipeOuttheScourge()
    {
        Name = "Might As Well Wipe Out the Scourge";

        QuestId.AddRange(new[] { 11698 });

        Step = new List<int> { 20, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26126);
EntryTarget.Add(25660);
EntryTarget.Add(24957);
EntryTarget.Add(25684);
HotSpots.Add(new Vector3(4347.708 , 4452.736 , 76.36478 , "None"));
HotSpots.Add(new Vector3(4278.948 , 4476.732 , 42.98 , "None"));
HotSpots.Add(new Vector3(4259.517 , 4593.535 , 19.6874 , "None"));
HotSpots.Add(new Vector3(4328.391 , 4570.619 , 23.21599 , "None"));
HotSpots.Add(new Vector3(4325.072 , 4719.949 , 24.60803 , "None"));
HotSpots.Add(new Vector3(4379.949 , 4709.055 , 23.34381 , "None"));
HotSpots.Add(new Vector3(4426.108 , 4562.209 , 104.9508 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class OhGreatPlaguedMagnataur : QuestGrinderClass
{
    public OhGreatPlaguedMagnataur()
    {
        Name = "Oh Great... Plagued Magnataur!";

        QuestId.AddRange(new[] { 11693 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25615);
HotSpots.Add(new Vector3(4281.537 , 4411.018 , 57.50788 , "None"));
HotSpots.Add(new Vector3(4284.02 , 4304.459 , 91.00606 , "None"));
HotSpots.Add(new Vector3(4254.729 , 4229.213 , 100.6565 , "None"));
HotSpots.Add(new Vector3(4200.9 , 4209.7 , 82.38141 , "None"));
HotSpots.Add(new Vector3(4150.601 , 4118.4 , 91.44518 , "None"));
HotSpots.Add(new Vector3(3993.85 , 4076.101 , 57.12291 , "None"));
HotSpots.Add(new Vector3(4281.165 , 4411.668 , 57.13771 , "None"));
HotSpots.Add(new Vector3(3928.094 , 3947.88 , 62.33667 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Point0 : QuestFollowPathClass
{
    public Point0()
    {
        Name = "Point0";

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

        Path.Add(new Vector3(3489.643 , 4516.276 , -20.73973 , "None"));
Path.Add(new Vector3(3493.525 , 4518.983 , -20.73973 , "None"));
Path.Add(new Vector3(3489.19 , 4518.75 , -20.73973 , "None"));
Path.Add(new Vector3(3484.977 , 4518.986 , -20.73973 , "None"));
Path.Add(new Vector3(3478.497 , 4521.051 , -20.41158 , "None"));
Path.Add(new Vector3(3475.383 , 4522.613 , -18.46586 , "None"));
Path.Add(new Vector3(3475.692 , 4528.427 , -14.9625 , "None"));
Path.Add(new Vector3(3482.079 , 4529.72 , -13.84724 , "None"));
Path.Add(new Vector3(3478.985 , 4527.671 , -14.43142 , "None"));
Path.Add(new Vector3(3474.318 , 4524.055 , -16.49475 , "None"));
Path.Add(new Vector3(3471.572 , 4521.923 , -15.51613 , "None"));
Path.Add(new Vector3(3468.857 , 4515.996 , -15.72285 , "None"));
Path.Add(new Vector3(3471.393 , 4509.556 , -14.95268 , "None"));
Path.Add(new Vector3(3474.644 , 4505.301 , -14.48167 , "None"));
Path.Add(new Vector3(3479.804 , 4500.611 , -15.07426 , "None"));
Path.Add(new Vector3(3484.948 , 4496.354 , -15.19418 , "None"));
Path.Add(new Vector3(3490.728 , 4495.203 , -14.95101 , "None"));
Path.Add(new Vector3(3496.329 , 4499.381 , -14.71098 , "None"));
Path.Add(new Vector3(3499.085 , 4501.539 , -14.88752 , "None"));
Path.Add(new Vector3(3501.829 , 4503.734 , -14.68624 , "None"));
Path.Add(new Vector3(3507.075 , 4508.342 , -14.70238 , "None"));
Path.Add(new Vector3(3511.764 , 4513.531 , -13.88807 , "None"));
Path.Add(new Vector3(3512.104 , 4516.786 , -11.32276 , "None"));
Path.Add(new Vector3(3512.201 , 4520.195 , -12.21783 , "None"));
Path.Add(new Vector3(3510.62 , 4523.634 , -12.72558 , "None"));
Path.Add(new Vector3(3511.412 , 4528.412 , -13.06739 , "None"));
Path.Add(new Vector3(3510.716 , 4532.11 , -12.99556 , "None"));
Path.Add(new Vector3(3510.099 , 4535.703 , -12.99556 , "None"));
Path.Add(new Vector3(3509.647 , 4545.03 , -12.75282 , "None"));
Path.Add(new Vector3(3509.863 , 4551.733 , -12.98228 , "None"));
Path.Add(new Vector3(3513.06 , 4557.936 , -12.98228 , "None"));
Path.Add(new Vector3(3517.858 , 4562.6 , -12.98228 , "None"));
Path.Add(new Vector3(3523.406 , 4566.845 , -11.65735 , "None"));
Path.Add(new Vector3(3529.342 , 4571.387 , -12.15609 , "None"));
Path.Add(new Vector3(3534.712 , 4575.497 , -11.89967 , "None"));
Path.Add(new Vector3(3540.294 , 4579.768 , -12.83866 , "None"));
Path.Add(new Vector3(3545.464 , 4583.724 , -12.99245 , "None"));
Path.Add(new Vector3(3551.987 , 4586.82 , -13.20768 , "None"));
Path.Add(new Vector3(3557.644 , 4589.902 , -13.67157 , "None"));
Path.Add(new Vector3(3561.42 , 4592.168 , -13.67157 , "None"));
Path.Add(new Vector3(3564.781 , 4594.544 , -13.67157 , "None"));
Path.Add(new Vector3(3570.295 , 4598.434 , -13.67157 , "None"));
Path.Add(new Vector3(3575.291 , 4603.595 , -13.6659 , "None"));
Path.Add(new Vector3(3579.354 , 4609.192 , -13.66028 , "None"));
Path.Add(new Vector3(3583.549 , 4614.969 , -13.671 , "None"));
Path.Add(new Vector3(3587.514 , 4620.43 , -13.671 , "None"));
Path.Add(new Vector3(3591.717 , 4626.219 , -12.89052 , "None"));
Path.Add(new Vector3(3595.789 , 4631.827 , -12.82987 , "None"));
Path.Add(new Vector3(3599.034 , 4638.035 , -11.56966 , "None"));
Path.Add(new Vector3(3602.187 , 4644.348 , -12.80145 , "None"));
Path.Add(new Vector3(3605.314 , 4650.61 , -13.08164 , "None"));
Path.Add(new Vector3(3608.448 , 4656.885 , -13.67168 , "None"));
Path.Add(new Vector3(3611.619 , 4663.055 , -13.67168 , "None"));
Path.Add(new Vector3(3616.126 , 4668.466 , -13.63271 , "None"));
Path.Add(new Vector3(3620.597 , 4673.833 , -13.66999 , "None"));
Path.Add(new Vector3(3625.104 , 4679.244 , -13.64207 , "None"));
Path.Add(new Vector3(3629.495 , 4684.515 , -12.99529 , "None"));
Path.Add(new Vector3(3633.976 , 4689.893 , -12.81894 , "None"));
Path.Add(new Vector3(3638.608 , 4695.454 , -12.93147 , "None"));
Path.Add(new Vector3(3642.936 , 4700.65 , -13.3115 , "None"));
Path.Add(new Vector3(3647.425 , 4706.039 , -14.43529 , "None"));
Path.Add(new Vector3(3651.897 , 4711.406 , -13.94907 , "None"));
Path.Add(new Vector3(3656.529 , 4716.968 , -12.99509 , "None"));
Path.Add(new Vector3(3660.857 , 4722.163 , -12.99509 , "None"));
Path.Add(new Vector3(3665.338 , 4727.542 , -13.7175 , "None"));
Path.Add(new Vector3(3669.811 , 4732.911 , -13.43934 , "None"));
Path.Add(new Vector3(3674.444 , 4738.472 , -12.97863 , "None"));
Path.Add(new Vector3(3678.771 , 4743.668 , -13.8226 , "None"));
Path.Add(new Vector3(3683.404 , 4749.229 , -13.1701 , "None"));
Path.Add(new Vector3(3687.683 , 4754.458 , -11.80548 , "None"));
Path.Add(new Vector3(3690.817 , 4760.717 , -11.87572 , "None"));
Path.Add(new Vector3(3693.951 , 4766.976 , -12.30363 , "None"));
Path.Add(new Vector3(3697.085 , 4773.235 , -12.95566 , "None"));
Path.Add(new Vector3(3700.326 , 4779.707 , -12.99252 , "None"));
Path.Add(new Vector3(3703.555 , 4785.619 , -12.90913 , "None"));
Path.Add(new Vector3(3708.239 , 4790.821 , -12.38802 , "None"));
Path.Add(new Vector3(3712.933 , 4796.033 , -11.6583 , "None"));
Path.Add(new Vector3(3717.767 , 4801.401 , -12.92702 , "None"));
Path.Add(new Vector3(3722.292 , 4806.426 , -12.96721 , "None"));
Path.Add(new Vector3(3726.976 , 4811.628 , -13.15339 , "None"));
Path.Add(new Vector3(3731.66 , 4816.83 , -13.27598 , "None"));
Path.Add(new Vector3(3736.503 , 4822.209 , -13.67123 , "None"));
Path.Add(new Vector3(3741.028 , 4827.234 , -13.67123 , "None"));
Path.Add(new Vector3(3745.722 , 4832.446 , -13.67123 , "None"));
Path.Add(new Vector3(3750.556 , 4837.814 , -13.67123 , "None"));
Path.Add(new Vector3(3755.249 , 4843.026 , -13.67123 , "None"));
Path.Add(new Vector3(3759.915 , 4848.208 , -13.54003 , "None"));
Path.Add(new Vector3(3764.44 , 4853.233 , -13.14065 , "None"));
Path.Add(new Vector3(3769.284 , 4858.612 , -11.25291 , "None"));
Path.Add(new Vector3(3773.968 , 4863.814 , -10.74559 , "None"));
Path.Add(new Vector3(3778.493 , 4868.839 , -11.88499 , "None"));
Path.Add(new Vector3(3783.336 , 4874.218 , -12.41933 , "None"));
Path.Add(new Vector3(3788.02 , 4879.419 , -12.73851 , "None"));
Path.Add(new Vector3(3792.657 , 4884.569 , -13.11375 , "None"));
Path.Add(new Vector3(3797.388 , 4889.823 , -13.11375 , "None"));
Path.Add(new Vector3(3801.923 , 4894.859 , -13.11375 , "None"));
Path.Add(new Vector3(3806.691 , 4900.154 , -13.11375 , "None"));
Path.Add(new Vector3(3811.291 , 4905.262 , -12.7883 , "None"));
Path.Add(new Vector3(3816.125 , 4910.631 , -13.11339 , "None"));
Path.Add(new Vector3(3820.659 , 4915.666 , -13.11339 , "None"));
Path.Add(new Vector3(3824.664 , 4920.114 , -13.11339 , "None"));
Path.Add(new Vector3(3828.235 , 4923.605 , -13.11339 , "None"));
Path.Add(new Vector3(3833.322 , 4930.267 , -13.11339 , "None"));
Path.Add(new Vector3(3838.011 , 4935.159 , -12.58144 , "None"));
Path.Add(new Vector3(3841.786 , 4940.97 , -7.317469 , "None"));
Path.Add(new Vector3(3844.939 , 4947.22 , -0.8092797 , "None"));
Path.Add(new Vector3(3848.094 , 4953.469 , -0.6300129 , "None"));
Path.Add(new Vector3(3851.348 , 4959.918 , -1.407337 , "None"));
Path.Add(new Vector3(3854.401 , 4965.967 , -1.405025 , "None"));
Path.Add(new Vector3(3857.538 , 4972.225 , -0.9446019 , "None"));
Path.Add(new Vector3(3860.669 , 4978.486 , -0.5574717 , "None"));
Path.Add(new Vector3(3863.8 , 4984.747 , -0.5797378 , "None"));
Path.Add(new Vector3(3866.938 , 4991.02 , 1.203455 , "None"));
Path.Add(new Vector3(3870.063 , 4997.268 , 0.7082584 , "None"));
Path.Add(new Vector3(3874.54 , 5002.612 , 0.3334245 , "None"));
Path.Add(new Vector3(3879.222 , 5007.815 , -1.34114 , "None"));
Path.Add(new Vector3(3883.905 , 5013.019 , -3.492208 , "None"));
Path.Add(new Vector3(3888.588 , 5018.222 , -6.518398 , "None"));
Path.Add(new Vector3(3893.271 , 5023.424 , -8.60669 , "None"));
Path.Add(new Vector3(3897.954 , 5028.627 , -10.15991 , "None"));
Path.Add(new Vector3(3902.646 , 5033.841 , -11.41261 , "None"));
Path.Add(new Vector3(3907.347 , 5039.065 , -11.83717 , "None"));
Path.Add(new Vector3(3912.095 , 5044.341 , -11.7692 , "None"));
Path.Add(new Vector3(3916.735 , 5049.496 , -9.496863 , "None"));
Path.Add(new Vector3(3921.333 , 5054.605 , -7.72086 , "None"));
Path.Add(new Vector3(3926.035 , 5059.829 , -6.188055 , "None"));
Path.Add(new Vector3(3930.652 , 5064.959 , -3.155338 , "None"));
Path.Add(new Vector3(3935.344 , 5070.172 , -0.9812764 , "None"));
Path.Add(new Vector3(3940.074 , 5075.427 , 0.3733201 , "None"));
Path.Add(new Vector3(3944.775 , 5080.651 , 0.8125774 , "None"));
Path.Add(new Vector3(3949.524 , 5085.927 , 1.122717 , "None"));
Path.Add(new Vector3(3954.216 , 5091.141 , 2.208788 , "None"));
Path.Add(new Vector3(3958.852 , 5096.292 , 1.511944 , "None"));
Path.Add(new Vector3(3963.544 , 5101.505 , 0.2543305 , "None"));
Path.Add(new Vector3(3968.142 , 5106.614 , -1.414391 , "None"));
Path.Add(new Vector3(3972.919 , 5111.921 , -1.508637 , "None"));
Path.Add(new Vector3(3977.555 , 5117.073 , -1.508637 , "None"));
Path.Add(new Vector3(3982.444 , 5122.504 , -1.510061 , "None"));
Path.Add(new Vector3(3987.098 , 5127.676 , -1.510061 , "None"));
Path.Add(new Vector3(3991.734 , 5132.827 , -1.510061 , "None"));
Path.Add(new Vector3(3996.567 , 5138.197 , -1.508646 , "None"));
Path.Add(new Vector3(4001.062 , 5143.192 , -1.207582 , "None"));
Path.Add(new Vector3(4005.724 , 5148.372 , -0.02669036 , "None"));
Path.Add(new Vector3(4010.515 , 5153.853 , 5.048462 , "None"));
Path.Add(new Vector3(4015.043 , 5159.136 , 11.53865 , "None"));
Path.Add(new Vector3(4019.617 , 5164.472 , 15.32294 , "None"));
Path.Add(new Vector3(4023.963 , 5169.542 , 13.89562 , "None"));
Path.Add(new Vector3(4028.673 , 5175.038 , 13.12845 , "None"));
Path.Add(new Vector3(4033.174 , 5180.289 , 13.11782 , "None"));
Path.Add(new Vector3(4037.675 , 5185.54 , 13.11782 , "None"));
Path.Add(new Vector3(4042.34 , 5190.982 , 13.11782 , "None"));
Path.Add(new Vector3(4046.85 , 5196.244 , 13.11782 , "None"));
Path.Add(new Vector3(4051.387 , 5201.538 , 13.12363 , "None"));
Path.Add(new Vector3(4055.906 , 5206.81 , 13.34864 , "None"));
Path.Add(new Vector3(4060.635 , 5212.327 , 14.08278 , "None"));
Path.Add(new Vector3(4065.154 , 5217.599 , 17.68318 , "None"));
Path.Add(new Vector3(4069.545 , 5222.723 , 22.83933 , "None"));
Path.Add(new Vector3(4074.089 , 5228.023 , 25.78093 , "None"));
Path.Add(new Vector3(4078.44 , 5233.1 , 25.37894 , "None"));
Path.Add(new Vector3(4082.986 , 5238.404 , 26.26765 , "None"));
Path.Add(new Vector3(4087.669 , 5243.867 , 25.28211 , "None"));
Path.Add(new Vector3(4092.161 , 5249.108 , 24.73251 , "None"));
Path.Add(new Vector3(4096.716 , 5254.422 , 24.7286 , "None"));
Path.Add(new Vector3(4100.551 , 5260.177 , 24.72851 , "None"));
Path.Add(new Vector3(4105.38 , 5265.087 , 24.88823 , "None"));
Path.Add(new Vector3(4111.487 , 5268.303 , 24.72862 , "None"));
Path.Add(new Vector3(4117.693 , 5271.571 , 24.72862 , "None"));
Path.Add(new Vector3(4122.221 , 5276.212 , 24.845 , "None"));
Path.Add(new Vector3(4123.976 , 5279.537 , 25.66884 , "None"));
Path.Add(new Vector3(4130.025 , 5280.406 , 25.27079 , "None"));
Path.Add(new Vector3(4136.765 , 5278.621 , 25.08232 , "None"));
Path.Add(new Vector3(4143.6 , 5276.811 , 24.91968 , "None"));
Path.Add(new Vector3(4150.434 , 5275.001 , 24.85022 , "None"));
Path.Add(new Vector3(4157.092 , 5273.237 , 26.18473 , "None"));
Path.Add(new Vector3(4164.145 , 5271.376 , 26.54945 , "None"));
Path.Add(new Vector3(4170.589 , 5269.679 , 26.69792 , "None"));
Path.Add(new Vector3(4174.992 , 5264.683 , 26.46659 , "None"));
Path.Add(new Vector3(4178.336 , 5258.406 , 26.39447 , "None"));
Path.Add(new Vector3(4180.117 , 5263.992 , 26.37617 , "None"));
Path.Add(new Vector3(4184.707 , 5269.175 , 26.79643 , "None"));
Path.Add(new Vector3(4189.476 , 5274.583 , 27.07635 , "None"));
Path.Add(new Vector3(4193.314 , 5285.371 , 26.65334 , "None"));
Path.Add(new Vector3(4196.417 , 5294.134 , 27.0586 , "None"));
Path.Add(new Vector3(4197.285 , 5301.226 , 31.28236 , "None"));
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


public sealed class RatsTinkyWentintotheNecropolis : QuestClass
{
    public RatsTinkyWentintotheNecropolis()
    {
        Name = "Rats, Tinky Went into the Necropolis!";

        QuestId.AddRange(new[] { 11697 });

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


public sealed class ReCursive : QuestClass
{
    public ReCursive()
    {
        Name = "Re-Cursive";

        QuestId.AddRange(new[] { 11712 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

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


public sealed class ScoutingtheSinkholes : QuestUseItemOnClass
{
    public ScoutingtheSinkholes()
    {
        Name = "Scouting the Sinkholes";

        QuestId.AddRange(new[] { 11713 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

        StepAutoDetect = new[] { false, false, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3648.631 , 4746.115 , -20.73988 , "None"));
HotSpots.Add(new Vector3(3646.186 , 4554.417 , -20.73973 , "None"));
HotSpots.Add(new Vector3(3487.488 , 4517.197 , -20.73957 , "None"));
ItemId = 34920;
Range = 5.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheGearmaster : QuestGathererClass
{
    public TheGearmaster()
    {
        Name = "The Gearmaster";

        QuestId.AddRange(new[] { 11798 });

        Step = new List<int> { 1, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(190334);
EntryIdObjects.Add(190335);
HotSpots.Add(new Vector3(4000.347 , 4854.095 , 25.97182 , "None"));
HotSpots.Add(new Vector3(4004.218 , 4850.408 , 25.96775 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheUltrasonicScrewdriver : QuestClass
{
    public TheUltrasonicScrewdriver()
    {
        Name = "The Ultrasonic Screwdriver";

        QuestId.AddRange(new[] { 11729 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 34984;

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


public sealed class TheresSomethingGoingOnInThoseCaves : QuestUseItemOnClass
{
    public TheresSomethingGoingOnInThoseCaves()
    {
        Name = "There's Something Going On In Those Caves";

        QuestId.AddRange(new[] { 11694 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(4358.476 , 4260.182 , 98.17039 , "None"));
ItemId = 34915;
Range = 5.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Twonky : QuestGathererClass
{
    public Twonky()
    {
        Name = "Twonky";

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

        EntryIdObjects.Add(188106);
EntryIdObjects.Add(187984);
HotSpots.Add(new Vector3(4113.325 , 5100.248 , -1.509952 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 11788);
}



public override bool HasQuest() { return true; }


}


public sealed class WhatstheMatterwiththeTransmatter : QuestGathererClass
{
    public WhatstheMatterwiththeTransmatter()
    {
        Name = "What's the Matter with the Transmatter?";

        QuestId.AddRange(new[] { 11710 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(187899);
HotSpots.Add(new Vector3(4046.098 , 5158.081 , 14.64482 , "None"));
HotSpots.Add(new Vector3(4116.266 , 5181.066 , 13.11844 , "None"));
HotSpots.Add(new Vector3(4166.504 , 5037.159 , 13.81884 , "None"));
HotSpots.Add(new Vector3(4183.335 , 4983.019 , 18.30911 , "None"));
HotSpots.Add(new Vector3(4213.12 , 4948.271 , 14.74577 , "None"));
HotSpots.Add(new Vector3(4289.644 , 4925.444 , 20.64818 , "None"));
HotSpots.Add(new Vector3(4317 , 4986.173 , 13.27481 , "None"));
HotSpots.Add(new Vector3(4329.469 , 5051.376 , 13.27375 , "None"));
HotSpots.Add(new Vector3(4280.507 , 5151.208 , 13.07553 , "None"));
HotSpots.Add(new Vector3(4254.281 , 5170.824 , 13.07553 , "None"));
HotSpots.Add(new Vector3(4154.831 , 5206.307 , 13.14783 , "None"));
HotSpots.Add(new Vector3(4114.827 , 5184.609 , 13.11843 , "None"));
HotSpots.Add(new Vector3(4179.899 , 5183.375 , 13.52798 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}
