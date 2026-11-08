
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



public sealed class Airship : QuestFollowPathClass
{
    public Airship()
    {
        Name = "Airship";

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

        Path.Add(new Vector3(4129.271 , 5311.257 , 28.77621 , "None"));
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


public sealed class BaitandSwitch : QuestGathererClass
{
    public BaitandSwitch()
    {
        Name = "Bait and Switch";

        QuestId.AddRange(new[] { 11951 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188140);
HotSpots.Add(new Vector3(3785.094 , 6875.944 , 159.1656 , "None"));
HotSpots.Add(new Vector3(3747.64 , 6906.882 , 162.7545 , "None"));
HotSpots.Add(new Vector3(3962.446 , 7124.823 , 161.773 , "None"));
HotSpots.Add(new Vector3(4059.498 , 7015.918 , 165.4203 , "None"));
HotSpots.Add(new Vector3(4033.319 , 6989.129 , 162.2856 , "None"));
HotSpots.Add(new Vector3(4038.742 , 6946.779 , 164.1844 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BaseCampEnd : QuestFollowPathClass
{
    public BaseCampEnd()
    {
        Name = "Base Camp End";

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

        Path.Add(new Vector3(3576.139 , 6651.985 , 195.2248 , "None"));
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


public sealed class BasicTraining : QuestGrinderClass
{
    public BasicTraining()
    {
        Name = "Basic Training";

        QuestId.AddRange(new[] { 11918 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25722);
HotSpots.Add(new Vector3(4082.558 , 7179.327 , 175.0057 , "None"));
HotSpots.Add(new Vector3(4156.418 , 7113.168 , 171.7855 , "None"));
HotSpots.Add(new Vector3(3770.838 , 7348.437 , 204.7453 , "None"));
HotSpots.Add(new Vector3(4091.055 , 7202.244 , 179.6503 , "None"));
HotSpots.Add(new Vector3(4120.93 , 6850.19 , 173.3259 , "None"));
HotSpots.Add(new Vector3(3981.413 , 6784.437 , 158.2499 , "None"));
HotSpots.Add(new Vector3(4034.41 , 6670.583 , 177.0567 , "None"));
HotSpots.Add(new Vector3(4008.948 , 6574.284 , 183.2404 , "None"));
HotSpots.Add(new Vector3(3785.938 , 6557.487 , 172.139 , "None"));
HotSpots.Add(new Vector3(3710.633 , 6758.644 , 159.0569 , "None"));
HotSpots.Add(new Vector3(3643.473 , 6858.383 , 160.614 , "None"));
HotSpots.Add(new Vector3(3719.756 , 7140.192 , 161.5652 , "None"));
HotSpots.Add(new Vector3(3883.421 , 7187.441 , 167.3569 , "None"));
HotSpots.Add(new Vector3(3725.034 , 7142.038 , 161.8909 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Camp : QuestFollowPathClass
{
    public Camp()
    {
        Name = "Camp ";

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

        Path.Add(new Vector3(3575.546 , 6652.993 , 195.2078 , "None"));
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


public sealed class CrackingtheCode : QuestGrinderClass
{
    public CrackingtheCode()
    {
        Name = "Cracking the Code";

        QuestId.AddRange(new[] { 11931 });

        Step = new List<int> { 3, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25719);
EntryTarget.Add(25720);
HotSpots.Add(new Vector3(3836.24 , 6692.86 , 152.7828 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DrakeHunt : QuestClass
{
    public DrakeHunt()
    {
        Name = "Drake Hunt";

        QuestId.AddRange(new[] { 11919 });

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


public sealed class HatchingaPlan : QuestGathererClass
{
    public HatchingaPlan()
    {
        Name = "Hatching a Plan";

        QuestId.AddRange(new[] { 11936 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188133);
HotSpots.Add(new Vector3(3976.328 , 6996.879 , 103.7502 , "None"));
HotSpots.Add(new Vector3(3970.812 , 6927.778 , 104.0461 , "None"));
HotSpots.Add(new Vector3(3951.666 , 6924.397 , 103.6944 , "None"));
HotSpots.Add(new Vector3(3908.093 , 6901.377 , 104.3678 , "None"));
HotSpots.Add(new Vector3(3913.458 , 6879.722 , 103.2756 , "None"));
HotSpots.Add(new Vector3(3877.292 , 6867.797 , 103.2171 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HatchingaPlan1 : QuestGrinderClass
{
    public HatchingaPlan1()
    {
        Name = "Hatching a Plan1";

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

        EntryTarget.Add(25728);
HotSpots.Add(new Vector3(3811.121 , 7107.18 , 167.6101 , "None"));
HotSpots.Add(new Vector3(3850.911 , 7140.357 , 166.6181 , "None"));
HotSpots.Add(new Vector3(4026.89 , 6888.631 , 166.1291 , "None"));
HotSpots.Add(new Vector3(4087.539 , 6936.494 , 165.8763 , "None"));
HotSpots.Add(new Vector3(4021.504 , 6929.067 , 166.2751 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(35586) >= 5;
}



public override bool HasQuest() { return true; }


}


public sealed class HaveTheyNoShame : QuestClass
{
    public HaveTheyNoShame()
    {
        Name = "Have They No Shame?";

        QuestId.AddRange(new[] { 13094, 13095 });

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


public sealed class KeeptheSecretSafe : QuestGrinderClass
{
    public KeeptheSecretSafe()
    {
        Name = "Keep the Secret Safe";

        QuestId.AddRange(new[] { 11914 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25721);
HotSpots.Add(new Vector3(3911.739 , 7059.362 , 104.8918 , "None"));
HotSpots.Add(new Vector3(3928.762 , 6906.948 , 115.977 , "None"));
HotSpots.Add(new Vector3(3973.783 , 6961.408 , 103.1996 , "None"));
HotSpots.Add(new Vector3(3957.598 , 7034.585 , 113.679 , "None"));
HotSpots.Add(new Vector3(3915.748 , 7056.389 , 111.517 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Keristrasza : QuestClass
{
    public Keristrasza()
    {
        Name = "Keristrasza";

        QuestId.AddRange(new[] { 11946 });

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


public sealed class MusteringtheReds : QuestClass
{
    public MusteringtheReds()
    {
        Name = "Mustering the Reds";

        QuestId.AddRange(new[] { 11967 });

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


public sealed class NutsforBerries : QuestGathererClass
{
    public NutsforBerries()
    {
        Name = "Nuts for Berries";

        QuestId.AddRange(new[] { 11912 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188113);
HotSpots.Add(new Vector3(3599.508 , 6973.855 , 173.4944 , "None"));
HotSpots.Add(new Vector3(3585.243 , 7018.861 , 188.0927 , "None"));
HotSpots.Add(new Vector3(3639.937 , 7008.422 , 168.3716 , "None"));
HotSpots.Add(new Vector3(3542.164 , 6999.96 , 194.4778 , "None"));
HotSpots.Add(new Vector3(3518.065 , 7017.021 , 199.6466 , "None"));
HotSpots.Add(new Vector3(3511.366 , 7063.337 , 207.0945 , "None"));
HotSpots.Add(new Vector3(3486.206 , 7089.04 , 214.4481 , "None"));
HotSpots.Add(new Vector3(3536.452 , 7125.414 , 214.5002 , "None"));
HotSpots.Add(new Vector3(3804.683 , 7389.815 , 201.1463 , "None"));
HotSpots.Add(new Vector3(4050.465 , 7210.322 , 183.1804 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PointMalygos : QuestFollowPathClass
{
    public PointMalygos()
    {
        Name = "Point Malygos";

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

        Path.Add(new Vector3(4059.304 , 7108.292 , 169.9175 , "None"));
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


public sealed class PointSargosa : QuestFollowPathClass
{
    public PointSargosa()
    {
        Name = "Point Sargosa";

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

        Path.Add(new Vector3(3580.458 , 6653.335 , 195.5932 , "None"));
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


public sealed class PostponingtheInevitable : QuestClass
{
    public PostponingtheInevitable()
    {
        Name = "Postponing the Inevitable";

        QuestId.AddRange(new[] { 11905 });

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


public sealed class Puzzling : QuestClass
{
    public Puzzling()
    {
        Name = "Puzzling";

        QuestId.AddRange(new[] { 11941 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 35648;

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


public sealed class Quickening : QuestClass
{
    public Quickening()
    {
        Name = "Quickening";

        QuestId.AddRange(new[] { 11911 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 5;

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


public sealed class ReadingtheMeters : QuestGathererClass
{
    public ReadingtheMeters()
    {
        Name = "Reading the Meters";

        QuestId.AddRange(new[] { 11900 });

        Step = new List<int> { 1, 1, 1, 1, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188101);
EntryIdObjects.Add(188103);
EntryIdObjects.Add(188102);
EntryIdObjects.Add(188100);
HotSpots.Add(new Vector3(3804.443 , 6940.468 , 107.9712 , "None"));
HotSpots.Add(new Vector3(3554.337 , 6908.487 , 174.2217 , "None"));
HotSpots.Add(new Vector3(3550.88 , 6942.12 , 174.011 , "None"));
HotSpots.Add(new Vector3(3967.608 , 7284.269 , 178.9592 , "None"));
HotSpots.Add(new Vector3(4000.722 , 7266.899 , 178.9384 , "None"));
HotSpots.Add(new Vector3(4124.479 , 6770.246 , 172.2124 , "None"));
HotSpots.Add(new Vector3(4107.795 , 6740.116 , 172.2859 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SaragosasEnd : QuestGrinderClass
{
    public SaragosasEnd()
    {
        Name = "Saragosa's End";

        QuestId.AddRange(new[] { 11957 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26232);
HotSpots.Add(new Vector3(4050.19 , 7329.25 , 635.97 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ScintillatingFragment : QuestGrinderClass
{
    public ScintillatingFragment()
    {
        Name = "Scintillating Fragment";

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

        EntryTarget.Add(25719);
HotSpots.Add(new Vector3(3836.24 , 6692.86 , 152.7823 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(35648) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class SecretsoftheAncients : QuestGrinderClass
{
    public SecretsoftheAncients()
    {
        Name = "Secrets of the Ancients";

        QuestId.AddRange(new[] { 11910 });

        Step = new List<int> { 3, 3, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25709);
EntryTarget.Add(25707);
HotSpots.Add(new Vector3(4204.853 , 7043.868 , 175.3194 , "None"));
HotSpots.Add(new Vector3(3625.298 , 7302.792 , 223.2927 , "None"));
HotSpots.Add(new Vector3(3754.599 , 7355.447 , 214.7545 , "None"));
HotSpots.Add(new Vector3(4027.595 , 6740.948 , 163.6056 , "None"));
HotSpots.Add(new Vector3(3836.413 , 6567.34 , 168.4731 , "None"));
HotSpots.Add(new Vector3(3713.065 , 6775.945 , 160.7448 , "None"));
HotSpots.Add(new Vector3(3808.672 , 7224.471 , 164.0089 , "None"));
HotSpots.Add(new Vector3(3851.115 , 7196.806 , 164.4474 , "None"));
HotSpots.Add(new Vector3(3924.745 , 6775.056 , 151.2909 , "None"));
HotSpots.Add(new Vector3(3763.302 , 6843.947 , 149.6033 , "None"));
HotSpots.Add(new Vector3(3652.468 , 6958.175 , 157.965 , "None"));
HotSpots.Add(new Vector3(4014.051 , 7148.074 , 168.1994 , "None"));
HotSpots.Add(new Vector3(3945.457 , 6672.307 , 166.6698 , "None"));
HotSpots.Add(new Vector3(3772.059 , 6584.062 , 169.5218 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SpringingtheTrap : QuestFollowNpcClass
{
    public SpringingtheTrap()
    {
        Name = "Springing the Trap";

        QuestId.AddRange(new[] { 11969 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 5;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        StartPosition = new Vector3(4063.72 , 7084.12 , 172 , "None");
NpcEntry = 26237;
Assist = true;
FollowDistance = 2f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 11969);
}






}


public sealed class TheCell : QuestGrinderClass
{
    public TheCell()
    {
        Name = "The Cell";

        QuestId.AddRange(new[] { 11943 });

        Step = new List<int> { 1, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25712);
EntryTarget.Add(25716);
HotSpots.Add(new Vector3(3760.33 , 7179.92 , 162.365 , "None"));
HotSpots.Add(new Vector3(4113.679 , 6998.698 , 165.3075 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CallSaragosa : QuestFollowPathClass
{
    public CallSaragosa()
    {
        Name = "Call Saragosa";

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

        Path.Add(new Vector3(4026.007 , 7325.457 , 635.9725 , "None"));
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


public sealed class LandingCast : QuestFollowPathClass
{
    public LandingCast()
    {
        Name = "Landing Cast";

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

        Path.Add(new Vector3(4007.798 , 7322.894 , 635.9719 , "None"));
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
