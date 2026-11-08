
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



public sealed class Back : QuestFollowPathClass
{
    public Back()
    {
        Name = "Back";

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

        Path.Add(new Vector3(4538.449 , 6347.128 , -1.677962 , "Swimming"));
Path.Add(new Vector3(4540.359 , 6337.591 , -3.099923 , "Swimming"));
Path.Add(new Vector3(4542.932 , 6322.901 , -3.70299 , "Swimming"));
Path.Add(new Vector3(4544.729 , 6307.508 , -3.264594 , "Swimming"));
Path.Add(new Vector3(4545.715 , 6293.064 , -2.67045 , "Swimming"));
Path.Add(new Vector3(4547.007 , 6277.653 , -2.035712 , "Swimming"));
Path.Add(new Vector3(4543.971 , 6263.201 , -1.971746 , "Swimming"));
Path.Add(new Vector3(4534.309 , 6251.825 , -1.971746 , "Swimming"));
Path.Add(new Vector3(4520.99 , 6242.109 , -1.971746 , "Swimming"));
Path.Add(new Vector3(4510.086 , 6235.053 , -1.971746 , "Swimming"));
Path.Add(new Vector3(4496.823 , 6227.013 , -1.971746 , "Swimming"));
Path.Add(new Vector3(4484.42 , 6219.522 , -1.971746 , "Swimming"));
Path.Add(new Vector3(4471.143 , 6211.503 , -1.971746 , "Swimming"));
Path.Add(new Vector3(4458.742 , 6204.009 , -1.971746 , "Swimming"));
Path.Add(new Vector3(4446.306 , 6194.938 , -1.971746 , "Swimming"));
Path.Add(new Vector3(4437.295 , 6182.958 , -1.971746 , "Swimming"));
Path.Add(new Vector3(4429.109 , 6171.005 , -1.971746 , "Swimming"));
Path.Add(new Vector3(4425.407 , 6166.392 , -0.8010194 , "None"));
Path.Add(new Vector3(4421.218 , 6162.865 , 0.9230689 , "None"));
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


public sealed class CommerceRoad : QuestFollowPathClass
{
    public CommerceRoad()
    {
        Name = "Commerce Road";

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

        Path.Add(new Vector3(4400.589 , 6140.282 , 0.5222364 , "None"));
Path.Add(new Vector3(4396.998 , 6142.739 , 0.4759049 , "None"));
Path.Add(new Vector3(4391.655 , 6141.778 , 0.4938298 , "None"));
Path.Add(new Vector3(4388.063 , 6138.976 , 0.3934905 , "None"));
Path.Add(new Vector3(4385.831 , 6133.057 , 0.2611324 , "None"));
Path.Add(new Vector3(4380.638 , 6130.385 , -0.2604353 , "None"));
Path.Add(new Vector3(4375.293 , 6130.277 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4371.747 , 6130.206 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4368.199 , 6130.133 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4364.687 , 6130.281 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4361.296 , 6131.304 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4357.958 , 6132.466 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4354.771 , 6134.009 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4351.577 , 6135.556 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4348.287 , 6137.149 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4342.121 , 6140.352 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4339.294 , 6142.486 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4336.467 , 6144.619 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4333.545 , 6146.827 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4328.882 , 6151.996 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4326.514 , 6154.648 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4324.166 , 6157.28 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4321.928 , 6160.027 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4319.896 , 6162.928 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4317.865 , 6165.83 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4315.833 , 6168.73 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4313.806 , 6171.626 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4311.771 , 6174.533 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4309.739 , 6177.434 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4307.643 , 6180.428 , -1.702722 , "Swimming"));
Path.Add(new Vector3(4303.708 , 6186.059 , -0.6026373 , "None"));
Path.Add(new Vector3(4301.701 , 6188.926 , -0.2858507 , "None"));
Path.Add(new Vector3(4299.693 , 6191.793 , 0.1823655 , "None"));
Path.Add(new Vector3(4294.492 , 6196.469 , 0.4909689 , "None"));
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


public sealed class ComunicateRoad : QuestFollowPathClass
{
    public ComunicateRoad()
    {
        Name = "Comunicate Road";

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

        Path.Add(new Vector3(4361.871 , 6068.554 , 0.9162338 , "None"));
Path.Add(new Vector3(4351.062 , 6071.631 , 3.621548 , "None"));
Path.Add(new Vector3(4342.939 , 6073.901 , 1.034973 , "None"));
Path.Add(new Vector3(4337.366 , 6075.476 , -2.644896 , "Swimming"));
Path.Add(new Vector3(4332.875 , 6076.928 , -2.772499 , "Swimming"));
Path.Add(new Vector3(4328.296 , 6078.423 , -2.738873 , "Swimming"));
Path.Add(new Vector3(4323.877 , 6079.957 , -3.195109 , "Swimming"));
Path.Add(new Vector3(4319.741 , 6081.924 , -4.678423 , "Swimming"));
Path.Add(new Vector3(4316.866 , 6084.659 , -6.784912 , "Swimming"));
Path.Add(new Vector3(4314.048 , 6086.251 , -10.19666 , "Swimming"));
Path.Add(new Vector3(4310.718 , 6088.089 , -13.15215 , "Swimming"));
Path.Add(new Vector3(4307.388 , 6089.926 , -16.10764 , "Swimming"));
Path.Add(new Vector3(4304.243 , 6090.796 , -19.92671 , "Swimming"));
Path.Add(new Vector3(4301.614 , 6091.106 , -23.69969 , "Swimming"));
Path.Add(new Vector3(4299.099 , 6091.403 , -27.31031 , "Swimming"));
Path.Add(new Vector3(4296.26 , 6091.738 , -31.38481 , "Swimming"));
Path.Add(new Vector3(4293.609 , 6092.051 , -35.18872 , "Swimming"));
Path.Add(new Vector3(4290.833 , 6092.379 , -39.17431 , "Swimming"));
Path.Add(new Vector3(4288.077 , 6092.704 , -43.12898 , "Swimming"));
Path.Add(new Vector3(4285.338 , 6093.027 , -47.06046 , "Swimming"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = true;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class Conch : QuestFollowPathClass
{
    public Conch()
    {
        Name = "Conch";

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

        Path.Add(new Vector3(4312.402 , 6131.43 , -129.1462 , "Swimming"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ObjectManager.GetNearestWoWUnit(ObjectManager.GetWoWUnitByEntry(25226)).IsAlive && ObjectManager.GetNearestWoWUnit(ObjectManager.GetWoWUnitByEntry(25226)).GetDistance < 15;
}



public override bool HasQuest() { return true; }


}


public sealed class EscapefromtheWinterfinCaverns : QuestFollowNpcClass
{
    public EscapefromtheWinterfinCaverns()
    {
        Name = "Escape from the Winterfin Caverns";

        QuestId.AddRange(new[] { 11570 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        StartPosition = new Vector3(4012.175 , 6392.963 , 29.52081 , "None");
NpcEntry = 25208;
Assist = true;
FollowDistance = 5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GrmmurggllMrllggrlGlrggl : QuestGrinderClass
{
    public GrmmurggllMrllggrlGlrggl()
    {
        Name = "Grmmurggll Mrllggrl Glrggl!!!";

        QuestId.AddRange(new[] { 11563 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25203);
HotSpots.Add(new Vector3(4539.171 , 6373.481 , -14 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ImBeingBlackmailedByMyCleaner : QuestClass
{
    public ImBeingBlackmailedByMyCleaner()
    {
        Name = "I'm Being Blackmailed By My Cleaner";

        QuestId.AddRange(new[] { 11562 });

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


public sealed class KeymasterUrmgrgl : QuestGrinderClass
{
    public KeymasterUrmgrgl()
    {
        Name = "Keymaster Urmgrgl";

        QuestId.AddRange(new[] { 11569 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25210);
HotSpots.Add(new Vector3(4023.953 , 6326.175 , 8.605372 , "None"));

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


public sealed class LearningtoCommunicate : QuestInteractWithClass
{
    public LearningtoCommunicate()
    {
        Name = "Learning to Communicate";

        QuestId.AddRange(new[] { 11571 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(25226);
HotSpots.Add(new Vector3(4280.319 , 6119.468 , -129.1453 , "Swimming"));
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


public sealed class OhNoestheTadpoles : QuestGathererClass
{
    public OhNoestheTadpoles()
    {
        Name = "Oh Noes, the Tadpoles!";

        QuestId.AddRange(new[] { 11560 });

        Step = new List<int> { 20, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(187373);
HotSpots.Add(new Vector3(4300.69 , 6207.235 , 0.6108221 , "None"));
HotSpots.Add(new Vector3(4231.88 , 6185.959 , 1.17494 , "None"));
HotSpots.Add(new Vector3(4226.287 , 6227.829 , 1.031789 , "None"));
HotSpots.Add(new Vector3(4293.498 , 6251.457 , 0.5593799 , "None"));
HotSpots.Add(new Vector3(4285.024 , 6299.653 , 0.5649377 , "None"));
HotSpots.Add(new Vector3(4163.266 , 6188.125 , 9.25176 , "None"));
HotSpots.Add(new Vector3(4061.139 , 6256.077 , 22.04379 , "None"));
HotSpots.Add(new Vector3(3987.789 , 6343.578 , 8.010564 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class OrcaRoad : QuestFollowPathClass
{
    public OrcaRoad()
    {
        Name = "Orca Road";

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

        IsCompleteWhenAtLastPath = false;
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


public sealed class SucculentOrcaStew : QuestGrinderClass
{
    public SucculentOrcaStew()
    {
        Name = "Succulent Orca Stew";

        QuestId.AddRange(new[] { 11564 });

        Step = new List<int> { 7, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25204);
HotSpots.Add(new Vector3(4364.186 , 6160.304 , -6 , "Swimming"));
HotSpots.Add(new Vector3(4399.204 , 6236.997 , -42.1767 , "Swimming"));
HotSpots.Add(new Vector3(4396.77 , 6254.1 , -30.7924 , "Swimming"));
HotSpots.Add(new Vector3(4423.681 , 6248.828 , -57.1556 , "Swimming"));
HotSpots.Add(new Vector3(4496.533 , 6271.467 , -14.87057 , "Swimming"));
HotSpots.Add(new Vector3(4389.241 , 6379.878 , -5.76468 , "Swimming"));
HotSpots.Add(new Vector3(4387.748 , 6434.073 , -1.524136 , "Swimming"));
HotSpots.Add(new Vector3(4473.985 , 6441.818 , -6 , "Swimming"));
HotSpots.Add(new Vector3(4519.377 , 6554.554 , -6 , "Swimming"));
HotSpots.Add(new Vector3(4575.583 , 6491.236 , -1.528556 , "Swimming"));
HotSpots.Add(new Vector3(4630.815 , 6472.934 , -6.8642 , "Swimming"));
HotSpots.Add(new Vector3(4712.717 , 6333.184 , -1.528582 , "Swimming"));
HotSpots.Add(new Vector3(4696.349 , 6291.953 , -1.539582 , "Swimming"));
HotSpots.Add(new Vector3(4705.394 , 6212.517 , -1.532966 , "Swimming"));
HotSpots.Add(new Vector3(4625.789 , 6201.271 , -1.548387 , "Swimming"));
HotSpots.Add(new Vector3(4484.691 , 6244.559 , -6 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Suit1 : QuestFollowPathClass
{
    public Suit1()
    {
        Name = "Suit1";

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

        Path.Add(new Vector3(4273.218 , 6187.605 , 0.2518791 , "None"));
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


public sealed class Suit2 : QuestFollowPathClass
{
    public Suit2()
    {
        Name = "Suit2";

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

        Path.Add(new Vector3(3861.369 , 6391.819 , 25.42157 , "None"));
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


public sealed class SurrenderNot : QuestGrinderClass
{
    public SurrenderNot()
    {
        Name = "Surrender... Not!";

        QuestId.AddRange(new[] { 11566 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25209);
HotSpots.Add(new Vector3(3839.85 , 6406.78 , 23.55122 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheSpareSuit : QuestClass
{
    public TheSpareSuit()
    {
        Name = "The Spare Suit";

        QuestId.AddRange(new[] { 11565 });

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


public sealed class Them : QuestGrinderClass
{
    public Them()
    {
        Name = "Them!";

        QuestId.AddRange(new[] { 11561 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25215);
EntryTarget.Add(25217);
EntryTarget.Add(25216);
HotSpots.Add(new Vector3(4333.97 , 6193.68 , -6.42245 , "None"));
HotSpots.Add(new Vector3(4283.544 , 6279.894 , 0.15899 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WinterfinCommerce : QuestGathererClass
{
    public WinterfinCommerce()
    {
        Name = "Winterfin Commerce";

        QuestId.AddRange(new[] { 11559 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(187367);
HotSpots.Add(new Vector3(4326.842 , 6322.728 , 0.5337474 , "None"));
HotSpots.Add(new Vector3(4249.823 , 6184.754 , 0.68962 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}
