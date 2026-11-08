
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



public sealed class ARaceAgainstTime : QuestGathererClass
{
    public ARaceAgainstTime()
    {
        Name = "A Race Against Time";

        QuestId.AddRange(new[] { 11671 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3391.38 , 6159.72 , 79.83113 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ObjectManager.GetWoWUnitByEntry(34909).Count == 1;
}






}


public sealed class ARaceAgainstTime0 : QuestFollowPathClass
{
    public ARaceAgainstTime0()
    {
        Name = "A Race Against Time0";

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

        Path.Add(new Vector3(3392.509 , 6159.168 , 79.83113 , "None"));
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


public sealed class Abduction : QuestUseItemOnClass
{
    public Abduction()
    {
        Name = "Abduction";

        QuestId.AddRange(new[] { 11590 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(25316);
HotSpots.Add(new Vector3(3440.69 , 6107.64 , 68.43136 , "None"));
ItemId = 0;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ObjectManager.GetNearestWoWUnit(ObjectManager.GetWoWUnitByEntry(25474)).IsAlive && ObjectManager.GetNearestWoWUnit(ObjectManager.GetWoWUnitByEntry(25474)).GetDistance < 10;
}






}


public sealed class Dragonspeak : QuestClass
{
    public Dragonspeak()
    {
        Name = "Dragonspeak";

        QuestId.AddRange(new[] { 11682 });

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


public sealed class MonitoringtheRiftCleftcliffAnomaly : QuestUseItemOnClass
{
    public MonitoringtheRiftCleftcliffAnomaly()
    {
        Name = "Monitoring the Rift: Cleftcliff Anomaly";

        QuestId.AddRange(new[] { 11576 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3285.18 , 6603.898 , -1.832502 , "None"));
ItemId = 34669;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MonitoringtheRiftSunderedChasm : QuestUseItemOnClass
{
    public MonitoringtheRiftSunderedChasm()
    {
        Name = "Monitoring the Rift: Sundered Chasm";

        QuestId.AddRange(new[] { 11582 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3807.863 , 6039.987 , -131.6338 , "Swimming"));
ItemId = 34669;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 11582);
}






}


public sealed class MonitoringtheRiftWinterfinCavern : QuestUseItemOnClass
{
    public MonitoringtheRiftWinterfinCavern()
    {
        Name = "Monitoring the Rift: Winterfin Cavern";

        QuestId.AddRange(new[] { 12728 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(4128.131 , 6262.76 , 28.56054 , "None"));
ItemId = 34669;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 12728);
}






}


public sealed class NickofTime : QuestClass
{
    public NickofTime()
    {
        Name = "Nick of Time";

        QuestId.AddRange(new[] { 11575 });

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


public sealed class PrisonBreak : QuestGrinderClass
{
    public PrisonBreak()
    {
        Name = "Prison Break";

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

        EntryTarget.Add(25585);
HotSpots.Add(new Vector3(3467.281 , 6099.414 , 67.7821 , "None"));
HotSpots.Add(new Vector3(3449.691 , 6149.251 , 74.3848 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(34688) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class PrisonBreak0 : QuestGathererClass
{
    public PrisonBreak0()
    {
        Name = "Prison Break0";

        QuestId.AddRange(new[] { 11587 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(187561);
HotSpots.Add(new Vector3(3482.183 , 6117.411 , 70.9672 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReforgingtheKey : QuestClass
{
    public ReforgingtheKey()
    {
        Name = "Reforging the Key";

        QuestId.AddRange(new[] { 11679 });

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


public sealed class RescuingEvanor : QuestClass
{
    public RescuingEvanor()
    {
        Name = "Rescuing Evanor";

        QuestId.AddRange(new[] { 11681 });

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


public sealed class Road1 : QuestFollowPathClass
{
    public Road1()
    {
        Name = "Road1";

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

        Path.Add(new Vector3(3836.867 , 5899.183 , -1.524098 , "Swimming"));
Path.Add(new Vector3(3832.868 , 5898.706 , -1.524098 , "Swimming"));
Path.Add(new Vector3(3828.071 , 5898.134 , -1.524098 , "Swimming"));
Path.Add(new Vector3(3823.392 , 5897.193 , -1.524098 , "Swimming"));
Path.Add(new Vector3(3818.933 , 5895.379 , -1.524098 , "Swimming"));
Path.Add(new Vector3(3814.322 , 5894.153 , -1.485907 , "Swimming"));
Path.Add(new Vector3(3810.727 , 5892.307 , 1.85458 , "None"));
Path.Add(new Vector3(3806.95 , 5890.874 , 6.085081 , "None"));
Path.Add(new Vector3(3803.197 , 5890.186 , 10.23904 , "None"));
Path.Add(new Vector3(3796.208 , 5887.338 , 17.37778 , "None"));
Path.Add(new Vector3(3788.418 , 5883.531 , 23.75893 , "None"));
Path.Add(new Vector3(3784.701 , 5880.516 , 27.3412 , "None"));
Path.Add(new Vector3(3789.121 , 5882.298 , 23.58302 , "None"));
Path.Add(new Vector3(3794.206 , 5884.711 , 20.27254 , "None"));
Path.Add(new Vector3(3801.63 , 5880.22 , 22.6794 , "None"));
Path.Add(new Vector3(3808.868 , 5877.627 , 29.10669 , "None"));
Path.Add(new Vector3(3806.479 , 5870.746 , 31.51092 , "None"));
Path.Add(new Vector3(3798.171 , 5869.568 , 39.76547 , "None"));
Path.Add(new Vector3(3789.773 , 5869.013 , 47.23765 , "None"));
Path.Add(new Vector3(3781.387 , 5868.147 , 53.82792 , "None"));
Path.Add(new Vector3(3772.872 , 5866.378 , 58.78743 , "None"));
Path.Add(new Vector3(3765.782 , 5862.193 , 60.64133 , "None"));
Path.Add(new Vector3(3757.128 , 5861.138 , 61.27143 , "None"));
Path.Add(new Vector3(3748.715 , 5861.602 , 61.49492 , "None"));
Path.Add(new Vector3(3740.324 , 5862.268 , 62.1681 , "None"));
Path.Add(new Vector3(3731.917 , 5862.936 , 63.82347 , "None"));
Path.Add(new Vector3(3723.427 , 5864.35 , 64.22453 , "None"));
Path.Add(new Vector3(3716.192 , 5868.675 , 64.25308 , "None"));
Path.Add(new Vector3(3711.012 , 5875.679 , 63.84185 , "None"));
Path.Add(new Vector3(3705.418 , 5881.968 , 63.52631 , "None"));
Path.Add(new Vector3(3699.304 , 5887.327 , 62.65862 , "None"));
Path.Add(new Vector3(3694.297 , 5894.047 , 62.02989 , "None"));
Path.Add(new Vector3(3691.294 , 5902.216 , 62.56096 , "None"));
Path.Add(new Vector3(3690.156 , 5910.174 , 61.54243 , "None"));
Path.Add(new Vector3(3687.015 , 5917.979 , 59.26419 , "None"));
Path.Add(new Vector3(3682.251 , 5924.906 , 59.66165 , "None"));
Path.Add(new Vector3(3677.989 , 5932.512 , 61.65676 , "None"));
Path.Add(new Vector3(3673.91 , 5939.874 , 62.17572 , "None"));
Path.Add(new Vector3(3669.767 , 5947.542 , 62.30858 , "None"));
Path.Add(new Vector3(3667.379 , 5955.599 , 62.92368 , "None"));
Path.Add(new Vector3(3666.271 , 5963.957 , 64.09857 , "None"));
Path.Add(new Vector3(3664.734 , 5972.248 , 65.13269 , "None"));
Path.Add(new Vector3(3662.767 , 5980.717 , 65.18381 , "None"));
Path.Add(new Vector3(3659.924 , 5988.654 , 64.02422 , "None"));
Path.Add(new Vector3(3656.594 , 5996.713 , 63.35899 , "None"));
Path.Add(new Vector3(3653.379 , 6004.491 , 61.56693 , "None"));
Path.Add(new Vector3(3650.157 , 6012.285 , 59.81248 , "None"));
Path.Add(new Vector3(3646.347 , 6019.783 , 59.57027 , "None"));
Path.Add(new Vector3(3641 , 6026.606 , 60.04805 , "None"));
Path.Add(new Vector3(3633.949 , 6031.068 , 60.14372 , "None"));
Path.Add(new Vector3(3625.505 , 6033.135 , 60.40974 , "None"));
Path.Add(new Vector3(3617.235 , 6034.786 , 60.93937 , "None"));
Path.Add(new Vector3(3608.964 , 6036.437 , 61.25598 , "None"));
Path.Add(new Vector3(3600.43 , 6038.141 , 61.25171 , "None"));
Path.Add(new Vector3(3592.16 , 6039.792 , 61.02832 , "None"));
Path.Add(new Vector3(3583.609 , 6041.499 , 61.51709 , "None"));
Path.Add(new Vector3(3575.681 , 6043.231 , 63.77996 , "None"));
Path.Add(new Vector3(3568.074 , 6047.391 , 68.20534 , "None"));
Path.Add(new Vector3(3562.024 , 6053.26 , 70.51283 , "None"));
Path.Add(new Vector3(3555.762 , 6059.246 , 71.64328 , "None"));
Path.Add(new Vector3(3548.042 , 6062.347 , 69.6208 , "None"));
Path.Add(new Vector3(3539.816 , 6061.318 , 67.09904 , "None"));
Path.Add(new Vector3(3531.735 , 6059.229 , 65.93694 , "None"));
Path.Add(new Vector3(3524.418 , 6062.985 , 64.92097 , "None"));
Path.Add(new Vector3(3516.972 , 6066.91 , 64.98368 , "None"));
Path.Add(new Vector3(3508.589 , 6069.142 , 65.99979 , "None"));
Path.Add(new Vector3(3500.382 , 6067.772 , 65.48124 , "None"));
Path.Add(new Vector3(3492.645 , 6064.443 , 65.58014 , "None"));
Path.Add(new Vector3(3485.904 , 6062.196 , 65.4074 , "None"));
Path.Add(new Vector3(3482.075 , 6063.45 , 65.83054 , "None"));
Path.Add(new Vector3(3478.092 , 6062.87 , 65.97201 , "None"));
Path.Add(new Vector3(3474.03 , 6062.278 , 66.78666 , "None"));
Path.Add(new Vector3(3470.219 , 6062.417 , 66.40508 , "None"));
Path.Add(new Vector3(3466.265 , 6061.595 , 65.91479 , "None"));
Path.Add(new Vector3(3462.37 , 6059.347 , 66.24386 , "None"));
Path.Add(new Vector3(3460.25 , 6055.749 , 67.04092 , "None"));
Path.Add(new Vector3(3458.582 , 6052.077 , 68.87 , "None"));
Path.Add(new Vector3(3456.93 , 6048.424 , 71.20589 , "None"));
Path.Add(new Vector3(3455.231 , 6044.669 , 73.98349 , "None"));
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


public sealed class Road2 : QuestFollowPathClass
{
    public Road2()
    {
        Name = "Road2";

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

        Path.Add(new Vector3(4126.234 , 6269.706 , 28.44563 , "None"));
Path.Add(new Vector3(4130.593 , 6267.319 , 28.59485 , "None"));
Path.Add(new Vector3(4133.104 , 6264.386 , 28.69858 , "None"));
Path.Add(new Vector3(4139.586 , 6260.042 , 28.34659 , "None"));
Path.Add(new Vector3(4147.167 , 6256.587 , 30.53529 , "None"));
Path.Add(new Vector3(4153.867 , 6252.646 , 31.14725 , "None"));
Path.Add(new Vector3(4160.15 , 6247.167 , 30.29915 , "None"));
Path.Add(new Vector3(4165.563 , 6241.193 , 25.86169 , "None"));
Path.Add(new Vector3(4171.034 , 6234.878 , 21.3934 , "None"));
Path.Add(new Vector3(4176.816 , 6228.875 , 16.5451 , "None"));
Path.Add(new Vector3(4183.374 , 6224.167 , 12.5115 , "None"));
Path.Add(new Vector3(4190.231 , 6219.899 , 10.83054 , "None"));
Path.Add(new Vector3(4197.093 , 6215.629 , 7.834797 , "None"));
Path.Add(new Vector3(4204.151 , 6211.737 , 5.770345 , "None"));
Path.Add(new Vector3(4211.615 , 6208.017 , 3.646971 , "None"));
Path.Add(new Vector3(4218.849 , 6204.412 , 2.111093 , "None"));
Path.Add(new Vector3(4226.083 , 6200.807 , 0.4745639 , "None"));
Path.Add(new Vector3(4233.316 , 6197.201 , 0.1739407 , "None"));
Path.Add(new Vector3(4240.747 , 6193.419 , 0.5159283 , "None"));
Path.Add(new Vector3(4247.461 , 6188.921 , 0.8979886 , "None"));
Path.Add(new Vector3(4254.023 , 6183.784 , 0.5327219 , "None"));
Path.Add(new Vector3(4259.946 , 6178.286 , -0.3952715 , "None"));
Path.Add(new Vector3(4265.77 , 6172.695 , -1.136713 , "None"));
Path.Add(new Vector3(4269.994 , 6169.034 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4274.043 , 6166.426 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4278.024 , 6163.86 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4282.141 , 6161.208 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4286.47 , 6159.141 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4290.845 , 6157.33 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4294.917 , 6154.469 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4298.662 , 6151.838 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4302.607 , 6149.067 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4306.552 , 6146.295 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4310.428 , 6143.573 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4314.369 , 6140.804 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4318.245 , 6138.082 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4322.198 , 6135.305 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4326.131 , 6132.542 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4330.073 , 6129.772 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4334.08 , 6126.958 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4338.021 , 6124.189 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4341.962 , 6121.42 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4345.842 , 6118.695 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4349.783 , 6115.926 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4353.791 , 6113.111 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4357.267 , 6109.7 , -2.188619 , "Swimming"));
Path.Add(new Vector3(4361.457 , 6102.987 , -1.676713 , "None"));
Path.Add(new Vector3(4361.838 , 6098.532 , -1.259793 , "None"));
Path.Add(new Vector3(4367.365 , 6092.265 , 0.5645729 , "None"));
Path.Add(new Vector3(4372.013 , 6085.73 , 0.5055531 , "None"));
Path.Add(new Vector3(4374.916 , 6078.221 , 0.7585268 , "None"));
Path.Add(new Vector3(4376.087 , 6070.001 , 0.7796336 , "None"));
Path.Add(new Vector3(4375.618 , 6062.655 , 0.6083336 , "None"));
Path.Add(new Vector3(4369.253 , 6057.677 , 0.2137237 , "None"));
Path.Add(new Vector3(4363.117 , 6052.005 , -1.210449 , "None"));
Path.Add(new Vector3(4360.543 , 6049.63 , -2.323098 , "Swimming"));
Path.Add(new Vector3(4357.05 , 6046.424 , -2.323098 , "Swimming"));
Path.Add(new Vector3(4358.571 , 6042.147 , -2.161927 , "Swimming"));
Path.Add(new Vector3(4355.211 , 6040.232 , -0.8923426 , "None"));
Path.Add(new Vector3(4347.628 , 6037.486 , 2.015301 , "None"));
Path.Add(new Vector3(4340.136 , 6033.804 , 7.359428 , "None"));
Path.Add(new Vector3(4333.338 , 6029.501 , 13.65747 , "None"));
Path.Add(new Vector3(4328.223 , 6023.271 , 19.80154 , "None"));
Path.Add(new Vector3(4323.726 , 6016.23 , 25.4612 , "None"));
Path.Add(new Vector3(4318.785 , 6009.86 , 29.94468 , "None"));
Path.Add(new Vector3(4313.272 , 6003.774 , 33.31159 , "None"));
Path.Add(new Vector3(4307.748 , 5997.699 , 35.52731 , "None"));
Path.Add(new Vector3(4302.31 , 5991.72 , 37.36968 , "None"));
Path.Add(new Vector3(4297.657 , 5985.128 , 39.30956 , "None"));
Path.Add(new Vector3(4293.253 , 5978.064 , 41.32117 , "None"));
Path.Add(new Vector3(4288.635 , 5971.44 , 43.26205 , "None"));
Path.Add(new Vector3(4283.042 , 5965.63 , 45.07657 , "None"));
Path.Add(new Vector3(4276.757 , 5960.549 , 46.42474 , "None"));
Path.Add(new Vector3(4270.896 , 5955.814 , 47.71754 , "None"));
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


public sealed class SharingIntelligence : QuestClass
{
    public SharingIntelligence()
    {
        Name = "Sharing Intelligence";

        QuestId.AddRange(new[] { 11663 });

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


public sealed class TakingWing : QuestClass
{
    public TakingWing()
    {
        Name = "Taking Wing";

        QuestId.AddRange(new[] { 11680 });

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


public sealed class TheArtofPersuasion : QuestClass
{
    public TheArtofPersuasion()
    {
        Name = "The Art of Persuasion";

        QuestId.AddRange(new[] { 11648 });

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


public sealed class TheBoreanInquisition : QuestClass
{
    public TheBoreanInquisition()
    {
        Name = "The Borean Inquisition";

        QuestId.AddRange(new[] { 11646 });

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


public sealed class TraversingtheRift : QuestClass
{
    public TraversingtheRift()
    {
        Name = "Traversing the Rift";

        QuestId.AddRange(new[] { 11733 });

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


public sealed class TooCloseForComfort : QuestClass
{
    public TooCloseForComfort()
    {
        Name = "Too Close For Comfort";

        QuestId.AddRange(new[] { 11574 });

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

        Path.Add(new Vector3(3273.292 , 6589.954 , -1.052306 , "None"));
Path.Add(new Vector3(3270.712 , 6587.272 , 0.5638554 , "None"));
Path.Add(new Vector3(3266.94 , 6582.164 , 1.289344 , "None"));
Path.Add(new Vector3(3266.495 , 6579.011 , -1.065309 , "None"));
Path.Add(new Vector3(3265.983 , 6575.276 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3265.55 , 6570.414 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3266.042 , 6565.477 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3266.643 , 6559.446 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3266.994 , 6555.929 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3267.346 , 6552.397 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3267.697 , 6548.88 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3268.049 , 6545.349 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3268.399 , 6541.832 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3268.75 , 6538.308 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3268.755 , 6534.77 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3268.682 , 6531.229 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3268.608 , 6527.688 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3268.534 , 6524.147 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3268.461 , 6520.606 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3268.387 , 6517.065 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3268.313 , 6513.518 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3268.24 , 6509.977 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3268.166 , 6506.436 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3268.092 , 6502.902 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3268.019 , 6499.354 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3267.945 , 6495.813 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3267.869 , 6492.159 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3267.724 , 6485.197 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3267.65 , 6481.649 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3267.575 , 6478.052 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3267.43 , 6471.083 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3267.354 , 6467.45 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3267.207 , 6460.347 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3267.132 , 6456.757 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3266.986 , 6449.746 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3266.838 , 6442.614 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3266.693 , 6435.646 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3266.618 , 6432.034 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3266.473 , 6425.073 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3266.398 , 6421.468 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3266.324 , 6417.913 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3266.25 , 6414.365 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3266.176 , 6410.831 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3266.103 , 6407.291 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3266.341 , 6403.761 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3266.685 , 6400.229 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3267.028 , 6396.704 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3267.37 , 6393.186 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3267.713 , 6389.661 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3268.057 , 6386.129 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3268.4 , 6382.604 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3268.742 , 6379.086 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3269.086 , 6375.554 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3269.429 , 6372.029 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3269.772 , 6368.504 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3270.115 , 6364.979 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3270.458 , 6361.454 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3270.801 , 6357.929 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3271.144 , 6354.404 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3271.487 , 6350.879 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3271.83 , 6347.354 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3272.173 , 6343.829 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3272.516 , 6340.304 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3272.859 , 6336.779 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3273.202 , 6333.253 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3273.545 , 6329.729 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3273.888 , 6326.204 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3274.231 , 6322.679 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3274.574 , 6319.153 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3274.918 , 6315.622 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3275.261 , 6312.097 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3275.604 , 6308.579 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3275.947 , 6305.054 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3276.29 , 6301.528 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3276.633 , 6298.003 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3276.976 , 6294.471 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3277.319 , 6290.954 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3277.662 , 6287.428 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3278.005 , 6283.903 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3278.348 , 6280.378 , -1.742413 , "Swimming"));
Path.Add(new Vector3(3278.683 , 6277.026 , 0.5268179 , "None"));
Path.Add(new Vector3(3279.022 , 6273.543 , 2.226552 , "None"));
Path.Add(new Vector3(3279.36 , 6270.066 , 4.136744 , "None"));
Path.Add(new Vector3(3278.819 , 6266.612 , 6.444166 , "None"));
Path.Add(new Vector3(3278.363 , 6263.142 , 8.400077 , "None"));
Path.Add(new Vector3(3277.907 , 6259.671 , 10.15927 , "None"));
Path.Add(new Vector3(3277.466 , 6256.319 , 11.74767 , "None"));
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


public sealed class TurnInNPC : QuestFollowPathClass
{
    public TurnInNPC()
    {
        Name = "Turn In NPC";

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

        Path.Add(new Vector3(3615.737 , 5960.408 , 136.2144 , "None"));
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
