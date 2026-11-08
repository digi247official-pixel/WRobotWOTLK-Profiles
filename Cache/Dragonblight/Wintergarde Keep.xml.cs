
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



public sealed class ADisturbanceInTheWest : QuestClass
{
    public ADisturbanceInTheWest()
    {
        Name = "A Disturbance In The West";

        QuestId.AddRange(new[] { 12439 });

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


public sealed class ARighteousSermon : QuestUseItemOnClass
{
    public ARighteousSermon()
    {
        Name = "A Righteous Sermon";

        QuestId.AddRange(new[] { 12321 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3801.372 , -678.7133 , 213.7528 , "None"));
ItemId = 0;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BreakingOffAPiece : QuestGrinderClass
{
    public BreakingOffAPiece()
    {
        Name = "Breaking Off A Piece";

        QuestId.AddRange(new[] { 12462 });

        Step = new List<int> { 1, 1, 15, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27797);
EntryTarget.Add(27823);
EntryTarget.Add(27824);
EntryTarget.Add(27805);
EntryTarget.Add(27826);
HotSpots.Add(new Vector3(3634.468 , -1174.659 , 89.1885 , "None"));
HotSpots.Add(new Vector3(3635.693 , -1147.488 , 89.23079 , "None"));
HotSpots.Add(new Vector3(3664.532 , -1110.975 , 92.18962 , "None"));
HotSpots.Add(new Vector3(3597.17 , -1234.094 , 89.0818 , "None"));
HotSpots.Add(new Vector3(3597.04 , -1234.76 , 89.08206 , "None"));
HotSpots.Add(new Vector3(3600.75 , -1249.157 , 86.10649 , "None"));
HotSpots.Add(new Vector3(3668.02 , -1103.13 , 92.18884 , "None"));
HotSpots.Add(new Vector3(3601.415 , -1158.87 , 88.94254 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Cave : QuestFollowPathClass
{
    public Cave()
    {
        Name = "Cave";

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

        Path.Add(new Vector3(3529.024 , -1092.027 , 81.76012 , "None"));
Path.Add(new Vector3(3526.572 , -1089.222 , 81.85967 , "None"));
Path.Add(new Vector3(3520.559 , -1089.785 , 81.7047 , "None"));
Path.Add(new Vector3(3516.833 , -1089.908 , 82.58566 , "None"));
Path.Add(new Vector3(3509.353 , -1092.048 , 81.73798 , "None"));
Path.Add(new Vector3(3506.176 , -1094.492 , 82.56024 , "None"));
Path.Add(new Vector3(3499.347 , -1096.772 , 82.34068 , "None"));
Path.Add(new Vector3(3493.098 , -1098.032 , 83.02104 , "None"));
Path.Add(new Vector3(3490.202 , -1093.87 , 83.77909 , "None"));
Path.Add(new Vector3(3484.775 , -1088.023 , 83.35659 , "None"));
Path.Add(new Vector3(3480.167 , -1082.973 , 83.1265 , "None"));
Path.Add(new Vector3(3477.387 , -1075.115 , 81.7718 , "None"));
Path.Add(new Vector3(3475.887 , -1068.114 , 80.80421 , "None"));
Path.Add(new Vector3(3475.117 , -1064.036 , 79.96502 , "None"));
Path.Add(new Vector3(3478.106 , -1060.137 , 79.48172 , "None"));
Path.Add(new Vector3(3483.978 , -1057.317 , 79.4593 , "None"));
Path.Add(new Vector3(3490.483 , -1057.85 , 79.94188 , "None"));
Path.Add(new Vector3(3493.813 , -1058.927 , 80.20793 , "None"));
Path.Add(new Vector3(3494.64 , -1062.167 , 81.59048 , "None"));
Path.Add(new Vector3(3494.507 , -1057.726 , 80.2167 , "None"));
Path.Add(new Vector3(3500.89 , -1056.082 , 80.46974 , "None"));
Path.Add(new Vector3(3506.976 , -1054.061 , 79.73429 , "None"));
Path.Add(new Vector3(3511.383 , -1049.611 , 77.85749 , "None"));
Path.Add(new Vector3(3512.894 , -1043.316 , 76.3246 , "None"));
Path.Add(new Vector3(3512.533 , -1039.835 , 75.99438 , "None"));
Path.Add(new Vector3(3514.263 , -1033.276 , 75.82716 , "None"));
Path.Add(new Vector3(3515.982 , -1030.227 , 75.57838 , "None"));
Path.Add(new Vector3(3521.927 , -1028.188 , 76.05367 , "None"));
Path.Add(new Vector3(3526.382 , -1030.365 , 75.16795 , "None"));
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


public sealed class CaveBack : QuestFollowPathClass
{
    public CaveBack()
    {
        Name = "Cave Back";

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

        Path.Add(new Vector3(3544.073 , -1037.347 , 76.05682 , "None"));
Path.Add(new Vector3(3539.684 , -1037.044 , 76.05682 , "None"));
Path.Add(new Vector3(3535.785 , -1036.068 , 76.05682 , "None"));
Path.Add(new Vector3(3533.452 , -1033.107 , 76.05682 , "None"));
Path.Add(new Vector3(3530.997 , -1030.277 , 75.9073 , "None"));
Path.Add(new Vector3(3527.693 , -1028.477 , 75.56792 , "None"));
Path.Add(new Vector3(3523.738 , -1027.808 , 75.65977 , "None"));
Path.Add(new Vector3(3519.723 , -1028.042 , 75.73151 , "None"));
Path.Add(new Vector3(3515.747 , -1028.667 , 75.46662 , "None"));
Path.Add(new Vector3(3513.297 , -1035.08 , 75.75109 , "None"));
Path.Add(new Vector3(3512.431 , -1039.008 , 75.90848 , "None"));
Path.Add(new Vector3(3511.547 , -1042.8 , 76.3461 , "None"));
Path.Add(new Vector3(3512.052 , -1046.72 , 76.9914 , "None"));
Path.Add(new Vector3(3511.579 , -1050.717 , 78.09016 , "None"));
Path.Add(new Vector3(3509.67 , -1054.112 , 79.29541 , "None"));
Path.Add(new Vector3(3505.878 , -1055.439 , 80.27962 , "None"));
Path.Add(new Vector3(3502.003 , -1056.496 , 80.43956 , "None"));
Path.Add(new Vector3(3498.474 , -1057.881 , 80.45837 , "None"));
Path.Add(new Vector3(3494.827 , -1058.923 , 80.28687 , "None"));
Path.Add(new Vector3(3490.932 , -1059.069 , 80.01282 , "None"));
Path.Add(new Vector3(3487.331 , -1057.635 , 79.68072 , "None"));
Path.Add(new Vector3(3483.593 , -1058.176 , 79.575 , "None"));
Path.Add(new Vector3(3479.994 , -1059.845 , 79.68356 , "None"));
Path.Add(new Vector3(3476.918 , -1061.936 , 79.72205 , "None"));
Path.Add(new Vector3(3474.663 , -1065.275 , 80.15454 , "None"));
Path.Add(new Vector3(3473.482 , -1069.053 , 81.08242 , "None"));
Path.Add(new Vector3(3476.35 , -1075.134 , 81.56328 , "None"));
Path.Add(new Vector3(3477.903 , -1078.855 , 82.1656 , "None"));
Path.Add(new Vector3(3479.463 , -1081.953 , 82.83275 , "None"));
Path.Add(new Vector3(3480.92 , -1085.445 , 82.98014 , "None"));
Path.Add(new Vector3(3483.951 , -1088.083 , 83.19214 , "None"));
Path.Add(new Vector3(3487.085 , -1090.329 , 83.7035 , "None"));
Path.Add(new Vector3(3489.815 , -1093.287 , 83.83627 , "None"));
Path.Add(new Vector3(3493.043 , -1095.262 , 83.38544 , "None"));
Path.Add(new Vector3(3499.278 , -1094.622 , 82.26996 , "None"));
Path.Add(new Vector3(3502.683 , -1093.329 , 81.86393 , "None"));
Path.Add(new Vector3(3506.289 , -1091.602 , 81.18051 , "None"));
Path.Add(new Vector3(3509.848 , -1090.245 , 81.29063 , "None"));
Path.Add(new Vector3(3513.262 , -1088.329 , 82.09702 , "None"));
Path.Add(new Vector3(3516.952 , -1088.173 , 82.09738 , "None"));
Path.Add(new Vector3(3520.653 , -1089.749 , 81.67582 , "None"));
Path.Add(new Vector3(3524.305 , -1090.598 , 81.41466 , "None"));
Path.Add(new Vector3(3527.802 , -1092.587 , 81.50657 , "None"));
Path.Add(new Vector3(3531.288 , -1094.598 , 82.09564 , "None"));
Path.Add(new Vector3(3534.583 , -1099.88 , 82.84826 , "None"));
Path.Add(new Vector3(3532.879 , -1103.524 , 83.05841 , "None"));
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


public sealed class ChasingIcestormThe7thLegionFront : QuestClass
{
    public ChasingIcestormThe7thLegionFront()
    {
        Name = "Chasing Icestorm: The 7th Legion Front";

        QuestId.AddRange(new[] { 12466 });

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


public sealed class Deathgaze : QuestUseItemOnClass
{
    public Deathgaze()
    {
        Name = "Deathgaze";

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

        EntryIdTarget.Add(27122);
HotSpots.Add(new Vector3(4861.43 , -1393.79 , 174.1992 , "None"));
ItemId = 37887;
Range = 5.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(3, 12459);
}



public override bool HasQuest() { return true; }


}


public sealed class FindDurkon : QuestClass
{
    public FindDurkon()
    {
        Name = "Find Durkon!";

        QuestId.AddRange(new[] { 12309 });

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


public sealed class FrostmourneCavern : QuestUseItemOnClass
{
    public FrostmourneCavern()
    {
        Name = "Frostmourne Cavern";

        QuestId.AddRange(new[] { 12478 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(4816.929 , -583.9493 , 163.4309 , "None"));
ItemId = 37933;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ImprintsonthePast : QuestGathererClass
{
    public ImprintsonthePast()
    {
        Name = "Imprints on the Past";

        QuestId.AddRange(new[] { 12282 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(189291);
HotSpots.Add(new Vector3(3671.873 , -795.0671 , 174.5037 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class IntoHostileTerritory : QuestClass
{
    public IntoHostileTerritory()
    {
        Name = "Into Hostile Territory";

        QuestId.AddRange(new[] { 12325 });

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


public sealed class IntotheBreach : QuestClass
{
    public IntotheBreach()
    {
        Name = "Into the Breach!";

        QuestId.AddRange(new[] { 12789 });

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


public sealed class LeaveNothingtoChance : QuestUseItemOnClass
{
    public LeaveNothingtoChance()
    {
        Name = "Leave Nothing to Chance";

        QuestId.AddRange(new[] { 12277 });

        Step = new List<int> { 1, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        ItemId = 0;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Lower : QuestUseItemOnClass
{
    public Lower()
    {
        Name = "Lower";

        QuestId.AddRange(new[] { 12277 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3882.892 , -868.1578 , 111.1031 , "None"));
ItemId = 37465;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(2, 12277);
}



public override bool HasQuest() { return true; }


}


public sealed class MyOldEnemy : QuestGrinderClass
{
    public MyOldEnemy()
    {
        Name = "My Old Enemy";

        QuestId.AddRange(new[] { 12464 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

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


public sealed class MysteryoftheInfinite : QuestUseItemOnClass
{
    public MysteryoftheInfinite()
    {
        Name = "Mystery of the Infinite";

        QuestId.AddRange(new[] { 12470 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(4100.646 , -421.2919 , 125.2258 , "None"));
ItemId = 37923;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MysteryoftheTome : QuestClass
{
    public MysteryoftheTome()
    {
        Name = "Mystery of the Tome";

        QuestId.AddRange(new[] { 12319 });

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


public sealed class NotInOurMine : QuestGrinderClass
{
    public NotInOurMine()
    {
        Name = "Not In Our Mine";

        QuestId.AddRange(new[] { 12269 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27401);
HotSpots.Add(new Vector3(3910.117 , -875.1691 , 121.0346 , "None"));
HotSpots.Add(new Vector3(3927.05 , -862.171 , 121.92 , "None"));
HotSpots.Add(new Vector3(3948.44 , -853.7137 , 122.3738 , "None"));
HotSpots.Add(new Vector3(3977.75 , -824.31 , 124.6496 , "None"));
HotSpots.Add(new Vector3(3970.27 , -804.854 , 124.139 , "None"));
HotSpots.Add(new Vector3(3978.144 , -806.9991 , 123.6759 , "None"));
HotSpots.Add(new Vector3(3996.7 , -804.852 , 124.5756 , "None"));
HotSpots.Add(new Vector3(4000.029 , -802.4964 , 122.6336 , "None"));
HotSpots.Add(new Vector3(4018.18 , -838.566 , 120.079 , "None"));
HotSpots.Add(new Vector3(4017.87 , -878.109 , 118.034 , "None"));
HotSpots.Add(new Vector3(3995.52 , -915.74 , 105.364 , "None"));
HotSpots.Add(new Vector3(3995.679 , -934.5359 , 104.3021 , "None"));
HotSpots.Add(new Vector3(3988.69 , -963.698 , 105.731 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class OrikTrueheartandtheForgottenShore : QuestClass
{
    public OrikTrueheartandtheForgottenShore()
    {
        Name = "Orik Trueheart and the Forgotten Shore";

        QuestId.AddRange(new[] { 12287 });

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


public sealed class PartingThoughts : QuestClass
{
    public PartingThoughts()
    {
        Name = "Parting Thoughts";

        QuestId.AddRange(new[] { 12305 });

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


public sealed class PickUpBomb : QuestGathererClass
{
    public PickUpBomb()
    {
        Name = "Pick Up Bomb";

        QuestId.AddRange(new[] { 12277 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(189288);
HotSpots.Add(new Vector3(4028.896 , -900.8966 , 108.8073 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(37465) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class PlunderbeardMustBeFound : QuestClass
{
    public PlunderbeardMustBeFound()
    {
        Name = "Plunderbeard Must Be Found!";

        QuestId.AddRange(new[] { 12463 });

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


public sealed class PlunderbeardsJournal : QuestGrinderClass
{
    public PlunderbeardsJournal()
    {
        Name = "Plunderbeard's Journal";

        QuestId.AddRange(new[] { 12465 });

        Step = new List<int> { 1, 1, 1, 1, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27835);
EntryTarget.Add(27836);
HotSpots.Add(new Vector3(3545.103 , -1022.598 , 76.05657 , "None"));
HotSpots.Add(new Vector3(3564.546 , -972.7117 , 76.05657 , "None"));
HotSpots.Add(new Vector3(3534.822 , -990.1624 , 76.05688 , "None"));
HotSpots.Add(new Vector3(3578.292 , -1034.93 , 75.20752 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RescuefromTownSquare : QuestInteractWithClass
{
    public RescuefromTownSquare()
    {
        Name = "Rescue from Town Square";

        QuestId.AddRange(new[] { 12253 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(27359);
HotSpots.Add(new Vector3(3686.41 , -806.22 , 174.3835 , "None"));
HotSpots.Add(new Vector3(3679.84 , -802.775 , 164.6473 , "None"));
HotSpots.Add(new Vector3(3672.57 , -821.037 , 164.6777 , "None"));
HotSpots.Add(new Vector3(3686.88 , -904.526 , 176.6536 , "None"));
HotSpots.Add(new Vector3(3694.48 , -884.995 , 164.2185 , "None"));
HotSpots.Add(new Vector3(3702.571 , -899.4818 , 164.0603 , "None"));
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


public sealed class ReturntotheHighCommander : QuestClass
{
    public ReturntotheHighCommander()
    {
        Name = "Return to the High Commander";

        QuestId.AddRange(new[] { 12251 });

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


public sealed class ScatteredToTheWind : QuestGathererClass
{
    public ScatteredToTheWind()
    {
        Name = "Scattered To The Wind";

        QuestId.AddRange(new[] { 12455 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(190032);
HotSpots.Add(new Vector3(3745.682 , -1214.791 , 125.9271 , "None"));
HotSpots.Add(new Vector3(3705.215 , -1239.523 , 116.4339 , "None"));
HotSpots.Add(new Vector3(3725.694 , -1290.63 , 120.5451 , "None"));
HotSpots.Add(new Vector3(3757.133 , -1248.399 , 135.0201 , "None"));
HotSpots.Add(new Vector3(3676.566 , -1322.677 , 116.0791 , "None"));
HotSpots.Add(new Vector3(3649.018 , -1360.947 , 111.5196 , "None"));
HotSpots.Add(new Vector3(3679.92 , -1368.66 , 130.9312 , "None"));
HotSpots.Add(new Vector3(3638.289 , -1290.726 , 112.4342 , "None"));
HotSpots.Add(new Vector3(3590.96 , -1303.457 , 111.7028 , "None"));
HotSpots.Add(new Vector3(3614.512 , -1180.53 , 116.2964 , "None"));
HotSpots.Add(new Vector3(3607.015 , -1172.019 , 116.2336 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SecretsoftheScourge : QuestClass
{
    public SecretsoftheScourge()
    {
        Name = "Secrets of the Scourge";

        QuestId.AddRange(new[] { 12312 });

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


public sealed class SteamtankSurprise : QuestClass
{
    public SteamtankSurprise()
    {
        Name = "Steamtank Surprise";

        QuestId.AddRange(new[] { 12326 });

        Step = new List<int> { 6, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

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


public sealed class ThatWhichCreatesCanAlsoDestroy : QuestClass
{
    public ThatWhichCreatesCanAlsoDestroy()
    {
        Name = "That Which Creates Can Also Destroy";

        QuestId.AddRange(new[] { 12459 });

        Step = new List<int> { 1, 1, 1, 0, 0 };

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


public sealed class TheBleedingOre : QuestGathererClass
{
    public TheBleedingOre()
    {
        Name = "The Bleeding Ore";

        QuestId.AddRange(new[] { 12272 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188699);
HotSpots.Add(new Vector3(4016.755 , -946.704 , 104.8543 , "None"));
HotSpots.Add(new Vector3(4008.365 , -964.0848 , 105.7221 , "None"));
HotSpots.Add(new Vector3(3997.609 , -973.3777 , 104.6879 , "None"));
HotSpots.Add(new Vector3(3999.67 , -895.4526 , 109.1674 , "None"));
HotSpots.Add(new Vector3(4012.974 , -922.48 , 106.7989 , "None"));
HotSpots.Add(new Vector3(3992.158 , -790.5237 , 122.3937 , "None"));
HotSpots.Add(new Vector3(3964.953 , -819.947 , 124.5487 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheCallOfTheCrusade : QuestClass
{
    public TheCallOfTheCrusade()
    {
        Name = "The Call Of The Crusade";

        QuestId.AddRange(new[] { 12542 });

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


public sealed class TheChainGunAndYou : QuestClass
{
    public TheChainGunAndYou()
    {
        Name = "The Chain Gun And You";

        QuestId.AddRange(new[] { 12457 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

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


public sealed class TheCleansingOfJinthakalar : QuestGrinderClass
{
    public TheCleansingOfJinthakalar()
    {
        Name = "The Cleansing Of Jintha'kalar";

        QuestId.AddRange(new[] { 12545 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26948);
HotSpots.Add(new Vector3(4732.324 , -1253.143 , 165.3497 , "None"));
HotSpots.Add(new Vector3(4745.21 , -1261.96 , 166.7816 , "None"));
HotSpots.Add(new Vector3(4752.973 , -1274.865 , 168.8238 , "None"));
HotSpots.Add(new Vector3(4748.425 , -1292.321 , 168.6476 , "None"));
HotSpots.Add(new Vector3(4765.065 , -1285.885 , 168.4185 , "None"));
HotSpots.Add(new Vector3(4769.811 , -1307.343 , 168.0511 , "None"));
HotSpots.Add(new Vector3(4785.657 , -1356.613 , 168.5131 , "None"));
HotSpots.Add(new Vector3(4791.414 , -1358.868 , 168.0273 , "None"));
HotSpots.Add(new Vector3(4816.478 , -1375.949 , 168.0511 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheDemognome : QuestClass
{
    public TheDemognome()
    {
        Name = "The Demo-gnome";

        QuestId.AddRange(new[] { 12275 });

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


public sealed class TheFateoftheDead : QuestGrinderClass
{
    public TheFateoftheDead()
    {
        Name = "The Fate of the Dead";

        QuestId.AddRange(new[] { 12258 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27370);
HotSpots.Add(new Vector3(3733.366 , -878.2416 , 162.7702 , "None"));
HotSpots.Add(new Vector3(3767.136 , -894.387 , 162.559 , "None"));
HotSpots.Add(new Vector3(3712.178 , -914.397 , 163.3359 , "None"));
HotSpots.Add(new Vector3(3666.195 , -890.8138 , 162.9059 , "None"));
HotSpots.Add(new Vector3(3673.659 , -921.2031 , 162.681 , "None"));
HotSpots.Add(new Vector3(3655.417 , -911.7531 , 162.7522 , "None"));
HotSpots.Add(new Vector3(3626.105 , -896.0034 , 164.0796 , "None"));
HotSpots.Add(new Vector3(3669.151 , -843.8846 , 165.1424 , "None"));
HotSpots.Add(new Vector3(3589.812 , -882.427 , 163.1587 , "None"));
HotSpots.Add(new Vector3(3767.95 , -891.8551 , 162.7748 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheForgottenTale : QuestUseItemOnClass
{
    public TheForgottenTale()
    {
        Name = "The Forgotten Tale";

        QuestId.AddRange(new[] { 12291 });

        Step = new List<int> { 1, 1, 1, 1, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        ItemId = 0;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheMurkweedElixir : QuestGathererClass
{
    public TheMurkweedElixir()
    {
        Name = "The Murkweed Elixir";

        QuestId.AddRange(new[] { 12290 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(189295);
HotSpots.Add(new Vector3(3182.097 , -1360.604 , 67.28365 , "None"));
HotSpots.Add(new Vector3(3114.858 , -1377.364 , 60.40277 , "None"));
HotSpots.Add(new Vector3(3109.796 , -1410.526 , 59.74081 , "None"));
HotSpots.Add(new Vector3(3082.739 , -1472.414 , 43.12354 , "None"));
HotSpots.Add(new Vector3(3029.827 , -1493.335 , 50.84834 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheNoblesCrypt : QuestGrinderClass
{
    public TheNoblesCrypt()
    {
        Name = "The Noble's Crypt";

        QuestId.AddRange(new[] { 12311 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27508);
HotSpots.Add(new Vector3(3616.929 , -781.0521 , 147.0599 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThePathofRedemption : QuestGrinderClass
{
    public ThePathofRedemption()
    {
        Name = "The Path of Redemption";

        QuestId.AddRange(new[] { 12477 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27330);
HotSpots.Add(new Vector3(4006.551 , -1255.853 , 133.3513 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheReturnoftheCrusade : QuestGrinderClass
{
    public TheReturnoftheCrusade()
    {
        Name = "The Return of the Crusade?";

        QuestId.AddRange(new[] { 12476 });

        Step = new List<int> { 20, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27330);
EntryTarget.Add(27333);
HotSpots.Add(new Vector3(4164.033 , -1274.076 , 165.6205 , "None"));
HotSpots.Add(new Vector3(4261.199 , -1275.946 , 151.1286 , "None"));
HotSpots.Add(new Vector3(4213.156 , -1258.564 , 149.9569 , "None"));
HotSpots.Add(new Vector3(4237.49 , -1190.52 , 151.8035 , "None"));
HotSpots.Add(new Vector3(4212.96 , -1160.06 , 151.9603 , "None"));
HotSpots.Add(new Vector3(4186.501 , -1188.294 , 147.7782 , "None"));
HotSpots.Add(new Vector3(4171.83 , -1136.38 , 150.4536 , "None"));
HotSpots.Add(new Vector3(4190.718 , -1125.368 , 150.7445 , "None"));
HotSpots.Add(new Vector3(4171.83 , -1136.38 , 150.4536 , "None"));
HotSpots.Add(new Vector3(4010.615 , -1253.992 , 132.5157 , "None"));
HotSpots.Add(new Vector3(4028.323 , -1158.321 , 130.7354 , "None"));
HotSpots.Add(new Vector3(4025.92 , -1087.03 , 136.7243 , "None"));
HotSpots.Add(new Vector3(4036.152 , -1299.072 , 130.5968 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheSearchforSlinkin : QuestClass
{
    public TheSearchforSlinkin()
    {
        Name = "The Search for Slinkin";

        QuestId.AddRange(new[] { 12276 });

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


public sealed class TheTruthShallSetUsFree : QuestUseItemOnClass
{
    public TheTruthShallSetUsFree()
    {
        Name = "The Truth Shall Set Us Free";

        QuestId.AddRange(new[] { 12301 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3100.236 , -1240.691 , 10.49641 , "None"));
ItemId = 37577;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class UnderstandingtheLanguageofDeath : QuestClass
{
    public UnderstandingtheLanguageofDeath()
    {
        Name = "Understanding the Language of Death";

        QuestId.AddRange(new[] { 12320 });

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


public sealed class UnderstandingtheScourgeWarMachine : QuestClass
{
    public UnderstandingtheScourgeWarMachine()
    {
        Name = "Understanding the Scourge War Machine";

        QuestId.AddRange(new[] { 12281 });

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


public sealed class Upper : QuestUseItemOnClass
{
    public Upper()
    {
        Name = "Upper";

        QuestId.AddRange(new[] { 12277 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3898.236 , -876.3508 , 110.808 , "None"));
ItemId = 37465;
Range = 8f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 12277);
}



public override bool HasQuest() { return true; }


}


public sealed class Vile : QuestUseItemOnClass
{
    public Vile()
    {
        Name = "Vile";

        QuestId.AddRange(new[] { 12459 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(27808);
HotSpots.Add(new Vector3(3816.62 , -1204.04 , 125.876 , "None"));
ItemId = 37887;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(2, 12459);
}



public override bool HasQuest() { return true; }


}


public sealed class WantedHighShamanBloodpaw : QuestGrinderClass
{
    public WantedHighShamanBloodpaw()
    {
        Name = "Wanted: High Shaman Bloodpaw";

        QuestId.AddRange(new[] { 12441 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27762);
HotSpots.Add(new Vector3(2857.899 , -1464.805 , 61.20535 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WantedKreugOathbreaker : QuestGrinderClass
{
    public WantedKreugOathbreaker()
    {
        Name = "Wanted: Kreug Oathbreaker";

        QuestId.AddRange(new[] { 12438 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27105);
HotSpots.Add(new Vector3(3603.286 , -1423.347 , 108.5548 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WantedOnslaughtCommanderIustus : QuestGrinderClass
{
    public WantedOnslaughtCommanderIustus()
    {
        Name = "Wanted: Onslaught Commander Iustus";

        QuestId.AddRange(new[] { 12442 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27334);
HotSpots.Add(new Vector3(4145.342 , -1284.775 , 195.564 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WhatSecretsMenHide : QuestGathererClass
{
    public WhatSecretsMenHide()
    {
        Name = "What Secrets Men Hide";

        QuestId.AddRange(new[] { 12475 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(190189);
HotSpots.Add(new Vector3(4150.016 , -1285.982 , 165.6237 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Path : QuestFollowPathClass
{
    public Path()
    {
        Name = "Path";

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

        Path.Add(new Vector3(4705.692 , -1314.682 , 164.2804 , "None"));
Path.Add(new Vector3(4714.13 , -1320.22 , 163.1925 , "None"));
Path.Add(new Vector3(4721.236 , -1322.979 , 163.8486 , "None"));
Path.Add(new Vector3(4728.258 , -1327.588 , 164.1789 , "None"));
Path.Add(new Vector3(4735.502 , -1332.35 , 165.0783 , "None"));
Path.Add(new Vector3(4742.284 , -1337.302 , 165.4869 , "None"));
Path.Add(new Vector3(4748.929 , -1342.391 , 165.7664 , "None"));
Path.Add(new Vector3(4755.359 , -1347.795 , 165.6447 , "None"));
Path.Add(new Vector3(4761.49 , -1353.513 , 164.7941 , "None"));
Path.Add(new Vector3(4767.507 , -1359.348 , 164.86 , "None"));
Path.Add(new Vector3(4773.366 , -1365.389 , 165.5151 , "None"));
Path.Add(new Vector3(4779.277 , -1370.947 , 167.5158 , "None"));
Path.Add(new Vector3(4786.234 , -1376.135 , 169.2941 , "None"));
Path.Add(new Vector3(4793.565 , -1380.235 , 170.3551 , "None"));
Path.Add(new Vector3(4800.908 , -1384.314 , 170.2269 , "None"));
Path.Add(new Vector3(4807.947 , -1388.351 , 168.8628 , "None"));
Path.Add(new Vector3(4815.607 , -1392.443 , 169.7946 , "None"));
Path.Add(new Vector3(4822.845 , -1396.089 , 169.8214 , "None"));
Path.Add(new Vector3(4830.766 , -1399.247 , 168.9641 , "None"));
Path.Add(new Vector3(4837.646 , -1398.786 , 168.5582 , "None"));
Path.Add(new Vector3(4840.103 , -1390.466 , 167.7566 , "None"));
Path.Add(new Vector3(4841.631 , -1383.748 , 168.0701 , "None"));
Path.Add(new Vector3(4850.142 , -1384.574 , 171.6633 , "None"));
Path.Add(new Vector3(4856.902 , -1389.024 , 174.1993 , "None"));
Path.Add(new Vector3(4859.743 , -1391.335 , 174.1993 , "None"));
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
