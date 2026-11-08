
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



public sealed class ABundleofTrouble : QuestGathererClass
{
    public ABundleofTrouble()
    {
        Name = "A Bundle of Trouble";

        QuestId.AddRange(new[] { 5545 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Paladin;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(176793);
HotSpots.Add(new Vector3(-9398.259 , -1141.236 , 59.89825 , "None"));
HotSpots.Add(new Vector3(-9425.253 , -1127.182 , 58.73188 , "None"));
HotSpots.Add(new Vector3(-9382.719 , -1185.155 , 63.25574 , "None"));
HotSpots.Add(new Vector3(-9353.512 , -1204.283 , 66.95008 , "None"));
HotSpots.Add(new Vector3(-9362.285 , -1249.774 , 63.50182 , "None"));
HotSpots.Add(new Vector3(-9328.022 , -1246.493 , 66.45615 , "None"));
HotSpots.Add(new Vector3(-9364.824 , -1285.202 , 59.89677 , "None"));
HotSpots.Add(new Vector3(-9380.443 , -1263.532 , 56.94385 , "None"));
HotSpots.Add(new Vector3(-9331.091 , -1339.174 , 64.3543 , "None"));
HotSpots.Add(new Vector3(-9309.166 , -1362.955 , 69.96427 , "None"));
HotSpots.Add(new Vector3(-9338.951 , -1374.833 , 64.72314 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AFishyPeril : QuestClass
{
    public AFishyPeril()
    {
        Name = "A Fishy Peril";

        QuestId.AddRange(new[] { 40 });

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


public sealed class AThreatWithin : QuestClass
{
    public AThreatWithin()
    {
        Name = "A Threat Within";

        QuestId.AddRange(new[] { 783 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 3;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BacktoBilly : QuestClass
{
    public BacktoBilly()
    {
        Name = "Back to Billy";

        QuestId.AddRange(new[] { 84 });

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


public sealed class BountyonGarrickPadfoot : QuestGrinderClass
{
    public BountyonGarrickPadfoot()
    {
        Name = "Bounty on Garrick Padfoot";

        QuestId.AddRange(new[] { 6 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(103);
HotSpots.Add(new Vector3(-9056.48 , -460.903 , 72.64869 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BountyonMurlocs : QuestGrinderClass
{
    public BountyonMurlocs()
    {
        Name = "Bounty on Murlocs";

        QuestId.AddRange(new[] { 46 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(732);
EntryTarget.Add(46);
HotSpots.Add(new Vector3(-9784.134 , -1119.641 , 35.91335 , "None"));
HotSpots.Add(new Vector3(-9836.91 , -1118.42 , 26.52402 , "None"));
HotSpots.Add(new Vector3(-9855.29 , -1127.58 , 29.3902 , "None"));
HotSpots.Add(new Vector3(-9876.3 , -1097.24 , 27.4363 , "None"));
HotSpots.Add(new Vector3(-9889.92 , -1113.932 , 28.71736 , "None"));
HotSpots.Add(new Vector3(-9908.063 , -1108.651 , 26.4587 , "None"));
HotSpots.Add(new Vector3(-9891.698 , -1136.669 , 26.50863 , "None"));
HotSpots.Add(new Vector3(-9907.11 , -1144.85 , 23.96983 , "None"));
HotSpots.Add(new Vector3(-9940.03 , -1134.11 , 21.20656 , "None"));
HotSpots.Add(new Vector3(-9930.98 , -1100.81 , 23.79809 , "None"));
HotSpots.Add(new Vector3(-9943.45 , -1087.18 , 21.41449 , "None"));
HotSpots.Add(new Vector3(-9913.13 , -1058.6 , 25.33076 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BrotherhoodofThieves : QuestGrinderClass
{
    public BrotherhoodofThieves()
    {
        Name = "Brotherhood of Thieves";

        QuestId.AddRange(new[] { 18 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(38);
HotSpots.Add(new Vector3(-8994.59 , -312.364 , 71.82077 , "None"));
HotSpots.Add(new Vector3(-9024.365 , -344.3 , 76.48814 , "None"));
HotSpots.Add(new Vector3(-9049.006 , -322.4438 , 73.45351 , "None"));
HotSpots.Add(new Vector3(-9069.638 , -313.8892 , 73.45016 , "None"));
HotSpots.Add(new Vector3(-9071.87 , -355.235 , 73.45215 , "None"));
HotSpots.Add(new Vector3(-9077.32 , -377.228 , 73.45114 , "None"));
HotSpots.Add(new Vector3(-9027.98 , -383.922 , 74.8967 , "None"));
HotSpots.Add(new Vector3(-8998.78 , -390.347 , 71.67842 , "None"));
HotSpots.Add(new Vector3(-8957.728 , -389.5124 , 70.25455 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ClothandLeatherArmor : QuestClass
{
    public ClothandLeatherArmor()
    {
        Name = "Cloth and Leather Armor";

        QuestId.AddRange(new[] { 59 });

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


public sealed class CollectingKelp : QuestGrinderClass
{
    public CollectingKelp()
    {
        Name = "Collecting Kelp";

        QuestId.AddRange(new[] { 112 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(735);
EntryTarget.Add(285);
HotSpots.Add(new Vector3(-9544.652 , -252.6811 , 61.19466 , "None"));
HotSpots.Add(new Vector3(-9528.95 , -268.761 , 59.01782 , "None"));
HotSpots.Add(new Vector3(-9530.46 , -269.478 , 59.35596 , "None"));
HotSpots.Add(new Vector3(-9493.42 , -224.326 , 58.44777 , "None"));
HotSpots.Add(new Vector3(-9486.42 , -206.092 , 57.6915 , "None"));
HotSpots.Add(new Vector3(-9476.74 , -194.136 , 56.73153 , "Swimming"));
HotSpots.Add(new Vector3(-9472.11 , -220.709 , 56.31403 , "Swimming"));
HotSpots.Add(new Vector3(-9445.453 , -252.4497 , 62.0937 , "None"));
HotSpots.Add(new Vector3(-9445.9 , -287.94 , 57.978 , "None"));
HotSpots.Add(new Vector3(-9449.908 , -293.0462 , 56.64393 , "Swimming"));
HotSpots.Add(new Vector3(-9493.42 , -224.326 , 58.44777 , "None"));
HotSpots.Add(new Vector3(-9505 , -209.918 , 52.29803 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DeliverThomasReport : QuestClass
{
    public DeliverThomasReport()
    {
        Name = "Deliver Thomas' Report";

        QuestId.AddRange(new[] { 39 });

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


public sealed class DiscoverRolfsFate : QuestClass
{
    public DiscoverRolfsFate()
    {
        Name = "Discover Rolf's Fate";

        QuestId.AddRange(new[] { 45 });

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


public sealed class EaganPeltskinner : QuestClass
{
    public EaganPeltskinner()
    {
        Name = "Eagan Peltskinner";

        QuestId.AddRange(new[] { 5261 });

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


public sealed class FindtheLostGuards : QuestClass
{
    public FindtheLostGuards()
    {
        Name = "Find the Lost Guards";

        QuestId.AddRange(new[] { 37 });

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


public sealed class FurlbrowsDeed : QuestClass
{
    public FurlbrowsDeed()
    {
        Name = "Furlbrow's Deed";

        QuestId.AddRange(new[] { 184 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 1972;

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


public sealed class FurtherConcerns : QuestClass
{
    public FurtherConcerns()
    {
        Name = "Further Concerns";

        QuestId.AddRange(new[] { 35 });

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


public sealed class GoldDustExchange : QuestGrinderClass
{
    public GoldDustExchange()
    {
        Name = "Gold Dust Exchange";

        QuestId.AddRange(new[] { 47 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(40);
EntryTarget.Add(475);
HotSpots.Add(new Vector3(-9800.91 , 117.807 , 5.79624 , "None"));
HotSpots.Add(new Vector3(-9823.255 , 123.8396 , 4.131168 , "None"));
HotSpots.Add(new Vector3(-9857.651 , 157.9234 , 6.302776 , "None"));
HotSpots.Add(new Vector3(-9827.914 , 216.3226 , 15.70865 , "None"));
HotSpots.Add(new Vector3(-9878.06 , 214.0423 , 14.00902 , "None"));
HotSpots.Add(new Vector3(-9851.695 , 180.3728 , 20.85659 , "None"));
HotSpots.Add(new Vector3(-9807.468 , 182.2405 , 22.52802 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Goldtooth : QuestGrinderClass
{
    public Goldtooth()
    {
        Name = "Goldtooth";

        QuestId.AddRange(new[] { 87 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(327);
HotSpots.Add(new Vector3(-9745.84 , 87.567 , 12.7499 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GoretuskLiverPie : QuestGrinderClass
{
    public GoretuskLiverPie()
    {
        Name = "Goretusk Liver Pie";

        QuestId.AddRange(new[] { 22 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(454);
EntryTarget.Add(157);
HotSpots.Add(new Vector3(-10026.65 , 1122.432 , 41.79823 , "None"));
HotSpots.Add(new Vector3(-10084.25 , 1251.407 , 39.66981 , "None"));
HotSpots.Add(new Vector3(-10112.98 , 1465.703 , 41.55465 , "None"));
HotSpots.Add(new Vector3(-10149.84 , 1481.858 , 42.00555 , "None"));
HotSpots.Add(new Vector3(-10104.76 , 1583.266 , 43.79781 , "None"));
HotSpots.Add(new Vector3(-9949.674 , 1537.642 , 45.17913 , "None"));
HotSpots.Add(new Vector3(-10050.68 , 1649.249 , 40.95583 , "None"));
HotSpots.Add(new Vector3(-10006.74 , 1695.563 , 36.13878 , "None"));
HotSpots.Add(new Vector3(-10104.19 , 1584.299 , 43.49691 , "None"));
HotSpots.Add(new Vector3(-10171.12 , 1573.017 , 45.19342 , "None"));
HotSpots.Add(new Vector3(-10188.75 , 1639.945 , 42.60678 , "None"));
HotSpots.Add(new Vector3(-10303.16 , 1550.528 , 41.86889 , "None"));
HotSpots.Add(new Vector3(-10325.05 , 1476.473 , 37.78379 , "None"));
HotSpots.Add(new Vector3(-10357.77 , 1691.225 , 36.60133 , "None"));
HotSpots.Add(new Vector3(-10392.07 , 1681.593 , 38.7389 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GrapeManifest : QuestClass
{
    public GrapeManifest()
    {
        Name = "Grape Manifest";

        QuestId.AddRange(new[] { 3905 });

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


public sealed class Grindto16 : QuestGrinderClass
{
    public Grindto16()
    {
        Name = "Grind to 16";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 15;
        RequiredQuest = 0;

        EntryTarget.Add(157);
EntryTarget.Add(1109);
EntryTarget.Add(154);
EntryTarget.Add(547);
EntryTarget.Add(832);
EntryTarget.Add(115);
HotSpots.Add(new Vector3(-10439.95 , 926.9653 , 38.73569 , "None"));
HotSpots.Add(new Vector3(-10395.15 , 922.9349 , 42.84087 , "None"));
HotSpots.Add(new Vector3(-10421.35 , 892.7868 , 43.69877 , "None"));
HotSpots.Add(new Vector3(-10549.44 , 846.2332 , 45.34864 , "None"));
HotSpots.Add(new Vector3(-10604.58 , 834.666 , 48.86919 , "None"));
HotSpots.Add(new Vector3(-10605.25 , 803.3615 , 52.80608 , "None"));
HotSpots.Add(new Vector3(-10746.84 , 813.6816 , 32.69489 , "None"));
HotSpots.Add(new Vector3(-10828.12 , 789.5872 , 33.05705 , "None"));
HotSpots.Add(new Vector3(-10846.7 , 861.3537 , 32.89159 , "None"));
HotSpots.Add(new Vector3(-10894.86 , 956.7318 , 37.7002 , "None"));
HotSpots.Add(new Vector3(-10986.84 , 971.4041 , 35.26348 , "None"));
HotSpots.Add(new Vector3(-10979.63 , 1018.622 , 36.86414 , "None"));
HotSpots.Add(new Vector3(-10910.51 , 1131.224 , 42.5093 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Grindto9 : QuestGrinderClass
{
    public Grindto9()
    {
        Name = "Grind to 9";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 8;
        RequiredQuest = 0;

        EntryTarget.Add(524);
EntryTarget.Add(822);
EntryTarget.Add(116);
HotSpots.Add(new Vector3(-9838.329 , 42.64194 , 32.33175 , "None"));
HotSpots.Add(new Vector3(-9816.715 , 26.08113 , 31.04544 , "None"));
HotSpots.Add(new Vector3(-9770.977 , -8.023315 , 30.34099 , "None"));
HotSpots.Add(new Vector3(-9796.32 , -75.3252 , 25.7988 , "None"));
HotSpots.Add(new Vector3(-9819.854 , -112.0785 , 27.72043 , "None"));
HotSpots.Add(new Vector3(-9813.173 , -140.069 , 30.37803 , "None"));
HotSpots.Add(new Vector3(-9867.391 , -152.8014 , 31.41758 , "None"));
HotSpots.Add(new Vector3(-9700.23 , -164.423 , 42.59615 , "None"));
HotSpots.Add(new Vector3(-9691.26 , -182.507 , 45.69072 , "None"));
HotSpots.Add(new Vector3(-9743.303 , -272.7338 , 48.15207 , "None"));
HotSpots.Add(new Vector3(-9788.367 , -371.4615 , 53.92972 , "None"));
HotSpots.Add(new Vector3(-9876.13 , -351.713 , 34.10389 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Grind25 : QuestGrinderClass
{
    public Grind25()
    {
        Name = "Grind25";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 18;
        MaxLevel = 23;
        RequiredQuest = 0;

        EntryTarget.Add(122);
EntryTarget.Add(121);
EntryTarget.Add(449);
HotSpots.Add(new Vector3(-11095.2 , 1174.104 , 55.24203 , "None"));
HotSpots.Add(new Vector3(-11149.34 , 1197.736 , 72.76579 , "None"));
HotSpots.Add(new Vector3(-11153.59 , 1222.807 , 78.04732 , "None"));
HotSpots.Add(new Vector3(-11237.6 , 1249.72 , 89.57966 , "None"));
HotSpots.Add(new Vector3(-11246.12 , 1396.68 , 89.3877 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class Grindto13 : QuestGrinderClass
{
    public Grindto13()
    {
        Name = "Grindto13";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 12;
        RequiredQuest = 0;

        EntryTarget.Add(199);
EntryTarget.Add(834);
EntryTarget.Add(454);
EntryTarget.Add(36);
HotSpots.Add(new Vector3(-10326.18 , 875.5051 , 40.02756 , "None"));
HotSpots.Add(new Vector3(-10278.79 , 909.0887 , 36.74015 , "None"));
HotSpots.Add(new Vector3(-10192.31 , 914.1441 , 41.24878 , "None"));
HotSpots.Add(new Vector3(-10095.51 , 892.2311 , 35.14207 , "None"));
HotSpots.Add(new Vector3(-10050.72 , 850.1185 , 33.61843 , "None"));
HotSpots.Add(new Vector3(-9949.82 , 813.3333 , 31.47883 , "None"));
HotSpots.Add(new Vector3(-9890.332 , 848.9468 , 30.03519 , "None"));
HotSpots.Add(new Vector3(-9890.288 , 849.0074 , 30.06057 , "None"));
HotSpots.Add(new Vector3(-10233.4 , 1027.19 , 34.65946 , "None"));
HotSpots.Add(new Vector3(-10327.24 , 1015.839 , 39.27953 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Grindto6 : QuestGrinderClass
{
    public Grindto6()
    {
        Name = "Grindto6";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryTarget.Add(257);
HotSpots.Add(new Vector3(-8741.391 , -194.2569 , 86.288 , "None"));
HotSpots.Add(new Vector3(-8761.652 , -235.7418 , 85.05066 , "None"));
HotSpots.Add(new Vector3(-8781.521 , -274.4883 , 78.72359 , "None"));
HotSpots.Add(new Vector3(-8762.41 , -158.9035 , 82.96833 , "None"));
HotSpots.Add(new Vector3(-8714.222 , -91.23244 , 89.46088 , "None"));
HotSpots.Add(new Vector3(-8689.384 , -73.05397 , 90.26814 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HezukPoint : QuestFollowPathClass
{
    public HezukPoint()
    {
        Name = "Hezuk Point";

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

        Path.Add(new Vector3(-9130.529 , -981.2916 , 75.52266 , "None"));
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


public sealed class InvestigateEchoRidge : QuestGrinderClass
{
    public InvestigateEchoRidge()
    {
        Name = "Investigate Echo Ridge";

        QuestId.AddRange(new[] { 15 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryTarget.Add(257);
HotSpots.Add(new Vector3(-8785.465 , -102.2445 , 83.67698 , "None"));
HotSpots.Add(new Vector3(-8717.657 , -98.76048 , 88.20525 , "None"));
HotSpots.Add(new Vector3(-8723.167 , -154.763 , 85.24142 , "None"));
HotSpots.Add(new Vector3(-8741.146 , -194.7261 , 86.36668 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KeeperoftheFlame : QuestGrinderClass
{
    public KeeperoftheFlame()
    {
        Name = "Keeper of the Flame";

        QuestId.AddRange(new[] { 103 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(114);
EntryTarget.Add(36);
HotSpots.Add(new Vector3(-10590.07 , 1607.615 , 41.53209 , "None"));
HotSpots.Add(new Vector3(-10656.92 , 1622.267 , 42.84969 , "None"));
HotSpots.Add(new Vector3(-10647.4 , 1688.998 , 42.09417 , "None"));
HotSpots.Add(new Vector3(-10581.97 , 1759.784 , 39.97152 , "None"));
HotSpots.Add(new Vector3(-10501.07 , 1778.766 , 35.59869 , "None"));
HotSpots.Add(new Vector3(-10488.55 , 1843.732 , 38.42304 , "None"));
HotSpots.Add(new Vector3(-10474.36 , 1764.536 , 35.37035 , "None"));
HotSpots.Add(new Vector3(-10229.02 , 1864.275 , 36.93933 , "None"));
HotSpots.Add(new Vector3(-10273.92 , 1863.399 , 37.16052 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KoboldCampCleanup : QuestGrinderClass
{
    public KoboldCampCleanup()
    {
        Name = "Kobold Camp Cleanup";

        QuestId.AddRange(new[] { 7 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 4;
        RequiredQuest = 0;

        EntryTarget.Add(6);
HotSpots.Add(new Vector3(-8781.3 , -115.552 , 82.68146 , "None"));
HotSpots.Add(new Vector3(-8770.179 , -161.4433 , 82.22926 , "None"));
HotSpots.Add(new Vector3(-8769.874 , -247.7564 , 82.77581 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KoboldCandles : QuestGrinderClass
{
    public KoboldCandles()
    {
        Name = "Kobold Candles";

        QuestId.AddRange(new[] { 60 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(475);
EntryTarget.Add(40);
HotSpots.Add(new Vector3(-9851.575 , 213.1517 , 14.05242 , "None"));
HotSpots.Add(new Vector3(-9879.89 , 191.1164 , 16.51571 , "None"));
HotSpots.Add(new Vector3(-9816.459 , 179.5673 , 23.02014 , "None"));
HotSpots.Add(new Vector3(-9801.582 , 169.8515 , 23.97364 , "None"));
HotSpots.Add(new Vector3(-9782.1 , 139.407 , 26.2336 , "None"));
HotSpots.Add(new Vector3(-9759.31 , 148.983 , 22.3136 , "None"));
HotSpots.Add(new Vector3(-9738.96 , 134.806 , 19.15395 , "None"));
HotSpots.Add(new Vector3(-9742.84 , 91.17863 , 12.79851 , "None"));
HotSpots.Add(new Vector3(-9800.91 , 117.807 , 5.79624 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LostNecklace : QuestClass
{
    public LostNecklace()
    {
        Name = "Lost Necklace";

        QuestId.AddRange(new[] { 85 });

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


public sealed class MillyOsworth : QuestClass
{
    public MillyOsworth()
    {
        Name = "Milly Osworth";

        QuestId.AddRange(new[] { 3903 });

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


public sealed class MillysHarvest : QuestGathererClass
{
    public MillysHarvest()
    {
        Name = "Milly's Harvest";

        QuestId.AddRange(new[] { 3904 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(161557);
HotSpots.Add(new Vector3(-9041.23 , -333.9626 , 74.59308 , "None"));
HotSpots.Add(new Vector3(-9027.347 , -331.9944 , 74.83852 , "None"));
HotSpots.Add(new Vector3(-9039.291 , -343.5045 , 74.65062 , "None"));
HotSpots.Add(new Vector3(-9050.295 , -304.8076 , 73.655 , "None"));
HotSpots.Add(new Vector3(-9063.661 , -311.8221 , 74.5883 , "None"));
HotSpots.Add(new Vector3(-9073.68 , -314.567 , 74.58837 , "None"));
HotSpots.Add(new Vector3(-9085.829 , -340.4874 , 74.5883 , "None"));
HotSpots.Add(new Vector3(-9095.706 , -334.6961 , 74.58823 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class NotetoWilliam : QuestClass
{
    public NotetoWilliam()
    {
        Name = "Note to William";

        QuestId.AddRange(new[] { 107 });

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


public sealed class PatrollingWestfall : QuestGrinderClass
{
    public PatrollingWestfall()
    {
        Name = "Patrolling Westfall";

        QuestId.AddRange(new[] { 102 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(117);
EntryTarget.Add(500);
EntryTarget.Add(123);
HotSpots.Add(new Vector3(-9712.951 , 996.2818 , 35.87474 , "None"));
HotSpots.Add(new Vector3(-9749.256 , 1392.732 , 43.60852 , "None"));
HotSpots.Add(new Vector3(-9788.698 , 1418.975 , 41.53354 , "None"));
HotSpots.Add(new Vector3(-9785.928 , 1480.045 , 44.50769 , "None"));
HotSpots.Add(new Vector3(-9744.461 , 1517.309 , 44.4326 , "None"));
HotSpots.Add(new Vector3(-9850.359 , 1560.232 , 45.72321 , "None"));
HotSpots.Add(new Vector3(-9880.235 , 1589.305 , 42.27197 , "None"));
HotSpots.Add(new Vector3(-9908.571 , 1590.423 , 41.9509 , "None"));
HotSpots.Add(new Vector3(-10061.97 , 1709.071 , 37.18481 , "None"));
HotSpots.Add(new Vector3(-10141.33 , 1775.112 , 34.68109 , "None"));
HotSpots.Add(new Vector3(-10085.69 , 1871.92 , 36.11343 , "None"));
HotSpots.Add(new Vector3(-10058.37 , 1834.342 , 35.67958 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PieforBilly : QuestGrinderClass
{
    public PieforBilly()
    {
        Name = "Pie for Billy";

        QuestId.AddRange(new[] { 86 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(113);
HotSpots.Add(new Vector3(-9940.337 , 49.08577 , 32.89724 , "None"));
HotSpots.Add(new Vector3(-9941.671 , 86.02416 , 33.00898 , "None"));
HotSpots.Add(new Vector3(-9979.583 , 114.6916 , 33.96225 , "None"));
HotSpots.Add(new Vector3(-9977.046 , 82.14802 , 34.65937 , "None"));
HotSpots.Add(new Vector3(-9905.823 , 116.1684 , 32.33785 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PoorOldBlanchy : QuestGathererClass
{
    public PoorOldBlanchy()
    {
        Name = "Poor Old Blanchy";

        QuestId.AddRange(new[] { 151 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(2724);
HotSpots.Add(new Vector3(-9839.965 , 948.6375 , 29.85234 , "None"));
HotSpots.Add(new Vector3(-9849.065 , 1026.32 , 33.01832 , "None"));
HotSpots.Add(new Vector3(-9881.676 , 1025.357 , 32.77863 , "None"));
HotSpots.Add(new Vector3(-10117.22 , 1063.756 , 37.50006 , "None"));
HotSpots.Add(new Vector3(-10226.93 , 1052.676 , 38.43317 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PrincessMustDie : QuestGrinderClass
{
    public PrincessMustDie()
    {
        Name = "Princess Must Die!";

        QuestId.AddRange(new[] { 88 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(330);
HotSpots.Add(new Vector3(-9774.412 , -886.6924 , 39.51846 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ProtecttheFrontierCARE : QuestGrinderClass
{
    public ProtecttheFrontierCARE()
    {
        Name = "Protect the Frontier (CARE)";

        QuestId.AddRange(new[] { 52 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(118);
EntryTarget.Add(822);
HotSpots.Add(new Vector3(-9309.487 , -1319.602 , 68.27721 , "None"));
HotSpots.Add(new Vector3(-9345.57 , -1241.07 , 66.04347 , "None"));
HotSpots.Add(new Vector3(-9367.15 , -1161.51 , 65.4592 , "None"));
HotSpots.Add(new Vector3(-9414.977 , -1126.484 , 58.78807 , "None"));
HotSpots.Add(new Vector3(-9357.34 , -1446.03 , 66.01109 , "None"));
HotSpots.Add(new Vector3(-9415.73 , -1461.76 , 62.57465 , "None"));
HotSpots.Add(new Vector3(-9459.35 , -1529.994 , 65.38902 , "None"));
HotSpots.Add(new Vector3(-9524.04 , -1496.84 , 62.1365 , "None"));
HotSpots.Add(new Vector3(-9607.771 , -1520.971 , 60.01569 , "None"));
HotSpots.Add(new Vector3(-9608.467 , -1467.426 , 59.16502 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RedLeatherBandanas : QuestGrinderClass
{
    public RedLeatherBandanas()
    {
        Name = "Red Leather Bandanas";

        QuestId.AddRange(new[] { 153 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(504);
EntryTarget.Add(95);
HotSpots.Add(new Vector3(-10504.24 , 1248.844 , 69.5402 , "None"));
HotSpots.Add(new Vector3(-10490.1 , 1330.69 , 42.57017 , "None"));
HotSpots.Add(new Vector3(-10645 , 1385.82 , 41.57761 , "None"));
HotSpots.Add(new Vector3(-10324.28 , 1411.198 , 40.83028 , "None"));
HotSpots.Add(new Vector3(-10261.4 , 1392.5 , 39.3987 , "None"));
HotSpots.Add(new Vector3(-10250.04 , 1354.666 , 41.26732 , "None"));
HotSpots.Add(new Vector3(-10353.7 , 1588.67 , 40.58495 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RedLinenGoods : QuestGrinderClass
{
    public RedLinenGoods()
    {
        Name = "Red Linen Goods";

        QuestId.AddRange(new[] { 83 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(474);
HotSpots.Add(new Vector3(-9227.32 , -1031.4 , 69.57453 , "None"));
HotSpots.Add(new Vector3(-9245.24 , -980.931 , 68.57003 , "None"));
HotSpots.Add(new Vector3(-9213.36 , -974.892 , 71.29473 , "None"));
HotSpots.Add(new Vector3(-9193.12 , -1002.59 , 70.31323 , "None"));
HotSpots.Add(new Vector3(-9154.25 , -1011.36 , 70.45849 , "None"));
HotSpots.Add(new Vector3(-9123.83 , -1020.25 , 72.17517 , "None"));
HotSpots.Add(new Vector3(-9091.25 , -1011.04 , 73.0416 , "None"));
HotSpots.Add(new Vector3(-9012.59 , -983.277 , 69.3455 , "None"));
HotSpots.Add(new Vector3(-9026.78 , -1048.42 , 68.72793 , "None"));
HotSpots.Add(new Vector3(-9037.58 , -1103.8 , 70.82219 , "None"));
HotSpots.Add(new Vector3(-9065.2 , -1131.12 , 70.46211 , "None"));
HotSpots.Add(new Vector3(-9065.2 , -1131.12 , 70.46211 , "None"));
HotSpots.Add(new Vector3(-9145.17 , -1063.72 , 71.32093 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReporttoGoldshire : QuestClass
{
    public ReporttoGoldshire()
    {
        Name = "Report to Goldshire";

        QuestId.AddRange(new[] { 54 });

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


public sealed class ReporttoGryanStoutmantle : QuestClass
{
    public ReporttoGryanStoutmantle()
    {
        Name = "Report to Gryan Stoutmantle";

        QuestId.AddRange(new[] { 109 });

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


public sealed class ReporttoThomas : QuestClass
{
    public ReporttoThomas()
    {
        Name = "Report to Thomas";

        QuestId.AddRange(new[] { 71 });

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


public sealed class RestandRelaxation : QuestClass
{
    public RestandRelaxation()
    {
        Name = "Rest and Relaxation";

        QuestId.AddRange(new[] { 2158 });

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


public sealed class RiverpawGnollBounty : QuestGrinderClass
{
    public RiverpawGnollBounty()
    {
        Name = "Riverpaw Gnoll Bounty";

        QuestId.AddRange(new[] { 11 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(478);
HotSpots.Add(new Vector3(-9824.469 , 623.5729 , 41.21107 , "None"));
HotSpots.Add(new Vector3(-9904.437 , 627.0163 , 40.02581 , "None"));
HotSpots.Add(new Vector3(-9818.49 , 558.7675 , 38.03192 , "None"));
HotSpots.Add(new Vector3(-9846.001 , 585.0823 , 40.32221 , "None"));
HotSpots.Add(new Vector3(-9786.854 , 586.0884 , 37.67593 , "None"));
HotSpots.Add(new Vector3(-9959.66 , 545.6459 , 37.76777 , "None"));
HotSpots.Add(new Vector3(-9961.993 , 551.719 , 37.66301 , "None"));
HotSpots.Add(new Vector3(-10026.8 , 608.6069 , 38.61489 , "None"));
HotSpots.Add(new Vector3(-10010.78 , 581.4779 , 38.7765 , "None"));
HotSpots.Add(new Vector3(-10034.25 , 646.1039 , 38.33022 , "None"));
HotSpots.Add(new Vector3(-10120.63 , 653.0137 , 34.78418 , "None"));
HotSpots.Add(new Vector3(-10145.02 , 616.3444 , 28.27858 , "None"));
HotSpots.Add(new Vector3(-10126.16 , 573.6713 , 33.2929 , "None"));
HotSpots.Add(new Vector3(-10091.23 , 545.2827 , 26.15619 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ROUTEGotoLakeshire : QuestFollowPathClass
{
    public ROUTEGotoLakeshire()
    {
        Name = "ROUTE Go to Lakeshire";

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

        Path.Add(new Vector3(-10578.54 , 982.639 , 38.36399 , "None"));
Path.Add(new Vector3(-10573.12 , 980.654 , 39.25007 , "None"));
Path.Add(new Vector3(-10548.76 , 970.8658 , 41.31413 , "None"));
Path.Add(new Vector3(-10524.95 , 961.988 , 40.95663 , "None"));
Path.Add(new Vector3(-10498.71 , 955.8418 , 39.35476 , "None"));
Path.Add(new Vector3(-10473.57 , 958.5822 , 36.15079 , "None"));
Path.Add(new Vector3(-10450.64 , 972.5047 , 35.20912 , "None"));
Path.Add(new Vector3(-10429.14 , 987.1809 , 34.10606 , "None"));
Path.Add(new Vector3(-10403.43 , 990.7147 , 31.85712 , "None"));
Path.Add(new Vector3(-10378.2 , 983.6775 , 31.06006 , "None"));
Path.Add(new Vector3(-10353.24 , 979.2138 , 31.13083 , "None"));
Path.Add(new Vector3(-10326.8 , 973.5203 , 31.13073 , "None"));
Path.Add(new Vector3(-10301.37 , 967.1399 , 31.12883 , "None"));
Path.Add(new Vector3(-10276.77 , 970.547 , 31.1261 , "None"));
Path.Add(new Vector3(-10256.69 , 988.5554 , 31.28201 , "None"));
Path.Add(new Vector3(-10230.95 , 992.4501 , 31.70264 , "None"));
Path.Add(new Vector3(-10204.86 , 990.0595 , 32.65121 , "None"));
Path.Add(new Vector3(-10178.9 , 986.4907 , 34.44781 , "None"));
Path.Add(new Vector3(-10152.67 , 987.4384 , 34.12534 , "None"));
Path.Add(new Vector3(-10126.54 , 989.8502 , 37.06704 , "None"));
Path.Add(new Vector3(-10101.3 , 996.8591 , 37.73118 , "None"));
Path.Add(new Vector3(-10076.67 , 1001.528 , 33.42601 , "None"));
Path.Add(new Vector3(-10051.92 , 993.1497 , 32.96318 , "None"));
Path.Add(new Vector3(-10026.35 , 985.6774 , 32.47126 , "None"));
Path.Add(new Vector3(-10000.95 , 992.0131 , 32.00468 , "None"));
Path.Add(new Vector3(-9975.764 , 999.2656 , 31.44913 , "None"));
Path.Add(new Vector3(-9949.633 , 999.2313 , 31.48869 , "None"));
Path.Add(new Vector3(-9925.111 , 992.6086 , 31.44064 , "None"));
Path.Add(new Vector3(-9900.411 , 983.8613 , 31.15994 , "None"));
Path.Add(new Vector3(-9880.328 , 966.313 , 31.26473 , "None"));
Path.Add(new Vector3(-9873.507 , 942.0598 , 30.98717 , "None"));
Path.Add(new Vector3(-9864.169 , 917.7894 , 30.10327 , "None"));
Path.Add(new Vector3(-9848.287 , 895.8655 , 29.18406 , "None"));
Path.Add(new Vector3(-9833.575 , 875.1528 , 26.13203 , "None"));
Path.Add(new Vector3(-9817.518 , 853.3349 , 26.94155 , "None"));
Path.Add(new Vector3(-9801.009 , 832.9467 , 29.09916 , "None"));
Path.Add(new Vector3(-9784.328 , 813.7782 , 25.8123 , "None"));
Path.Add(new Vector3(-9778.479 , 804.8734 , 25.2554 , "None"));
Path.Add(new Vector3(-9760.627 , 771.1721 , 25.03684 , "None"));
Path.Add(new Vector3(-9755.92 , 736.5677 , 25.10719 , "None"));
Path.Add(new Vector3(-9757.473 , 702.7913 , 25.5597 , "None"));
Path.Add(new Vector3(-9755.549 , 667.0353 , 27.72631 , "None"));
Path.Add(new Vector3(-9746.044 , 634.5411 , 29.33176 , "None"));
Path.Add(new Vector3(-9742.74 , 598.6224 , 31.09418 , "None"));
Path.Add(new Vector3(-9742.274 , 563.6407 , 35.08386 , "None"));
Path.Add(new Vector3(-9744.516 , 528.7212 , 35.5636 , "None"));
Path.Add(new Vector3(-9749.327 , 494.0571 , 33.62323 , "None"));
Path.Add(new Vector3(-9754.521 , 460.5793 , 34.62741 , "None"));
Path.Add(new Vector3(-9756.137 , 425.7081 , 37.2209 , "None"));
Path.Add(new Vector3(-9748.815 , 391.6579 , 39.79926 , "None"));
Path.Add(new Vector3(-9735.674 , 358.0432 , 42.2979 , "None"));
Path.Add(new Vector3(-9719.124 , 328.5193 , 44.26149 , "None"));
Path.Add(new Vector3(-9698.633 , 298.8057 , 45.98235 , "None"));
Path.Add(new Vector3(-9673.998 , 274.0821 , 46.54459 , "None"));
Path.Add(new Vector3(-9644.585 , 257.5545 , 46.5836 , "None"));
Path.Add(new Vector3(-9608.692 , 254.8543 , 47.4841 , "None"));
Path.Add(new Vector3(-9573.865 , 251.4447 , 48.9199 , "None"));
Path.Add(new Vector3(-9540.693 , 244.9783 , 50.492 , "None"));
Path.Add(new Vector3(-9511.931 , 223.9924 , 52.50176 , "None"));
Path.Add(new Vector3(-9493.302 , 195.7587 , 54.56862 , "None"));
Path.Add(new Vector3(-9483.522 , 161.1976 , 56.00888 , "None"));
Path.Add(new Vector3(-9481.827 , 126.3266 , 56.57478 , "None"));
Path.Add(new Vector3(-9488.03 , 91.9052 , 56.25784 , "None"));
Path.Add(new Vector3(-9496.43 , 57.95111 , 56.01605 , "None"));
Path.Add(new Vector3(-9510.052 , 25.74638 , 56.51975 , "None"));
Path.Add(new Vector3(-9524.805 , -5.992437 , 55.82334 , "None"));
Path.Add(new Vector3(-9537.023 , -37.43125 , 56.4688 , "None"));
Path.Add(new Vector3(-9544.798 , -72.49687 , 57.52163 , "None"));
Path.Add(new Vector3(-9548.643 , -106.1333 , 57.39839 , "None"));
Path.Add(new Vector3(-9558.825 , -140.6799 , 57.48469 , "None"));
Path.Add(new Vector3(-9575.119 , -171.5659 , 57.56018 , "None"));
Path.Add(new Vector3(-9590.038 , -203.1752 , 57.75747 , "None"));
Path.Add(new Vector3(-9602.063 , -234.8496 , 57.50234 , "None"));
Path.Add(new Vector3(-9612.57 , -269.3592 , 57.08909 , "None"));
Path.Add(new Vector3(-9616.729 , -304.0911 , 57.50143 , "None"));
Path.Add(new Vector3(-9618.479 , -337.9081 , 57.6159 , "None"));
Path.Add(new Vector3(-9617.481 , -374.01 , 57.6528 , "None"));
Path.Add(new Vector3(-9612.958 , -407.5518 , 57.55217 , "None"));
Path.Add(new Vector3(-9601.522 , -441.6726 , 57.68248 , "None"));
Path.Add(new Vector3(-9590.109 , -474.6123 , 57.749 , "None"));
Path.Add(new Vector3(-9596.157 , -507.5139 , 57.41179 , "None"));
Path.Add(new Vector3(-9611.037 , -540.3707 , 54.64994 , "None"));
Path.Add(new Vector3(-9616.952 , -573.7214 , 54.3227 , "None"));
Path.Add(new Vector3(-9624.935 , -610.0111 , 52.32542 , "None"));
Path.Add(new Vector3(-9633.298 , -642.9078 , 50.51195 , "None"));
Path.Add(new Vector3(-9643.41 , -676.4128 , 48.64456 , "None"));
Path.Add(new Vector3(-9649.888 , -709.6235 , 45.17323 , "None"));
Path.Add(new Vector3(-9653.105 , -745.5536 , 44.58104 , "None"));
Path.Add(new Vector3(-9649.678 , -780.3218 , 44.19565 , "None"));
Path.Add(new Vector3(-9637.263 , -812.7983 , 43.73221 , "None"));
Path.Add(new Vector3(-9613.578 , -836.9742 , 43.65589 , "None"));
Path.Add(new Vector3(-9593.17 , -865.0067 , 43.8547 , "None"));
Path.Add(new Vector3(-9584.511 , -898.7922 , 43.80296 , "None"));
Path.Add(new Vector3(-9588.771 , -934.2 , 43.53084 , "None"));
Path.Add(new Vector3(-9608.293 , -963.0604 , 43.7916 , "None"));
Path.Add(new Vector3(-9619.868 , -995.5 , 42.61161 , "None"));
Path.Add(new Vector3(-9619.816 , -1029.306 , 39.8168 , "None"));
Path.Add(new Vector3(-9615.81 , -1065.202 , 39.64175 , "None"));
Path.Add(new Vector3(-9614.146 , -1100.134 , 40.46901 , "None"));
Path.Add(new Vector3(-9618.17 , -1134.839 , 42.7071 , "None"));
Path.Add(new Vector3(-9627.546 , -1168.514 , 41.00233 , "None"));
Path.Add(new Vector3(-9641.857 , -1200.447 , 36.64378 , "None"));
Path.Add(new Vector3(-9649.407 , -1234.341 , 37.11071 , "None"));
Path.Add(new Vector3(-9650.509 , -1269.323 , 43.07482 , "None"));
Path.Add(new Vector3(-9653.628 , -1304.112 , 46.80077 , "None"));
Path.Add(new Vector3(-9659.467 , -1338.561 , 48.6335 , "None"));
Path.Add(new Vector3(-9661.494 , -1372.329 , 49.92158 , "None"));
Path.Add(new Vector3(-9657.111 , -1407.021 , 53.45008 , "None"));
Path.Add(new Vector3(-9652.804 , -1442.79 , 54.01834 , "None"));
Path.Add(new Vector3(-9654.207 , -1477.758 , 55.37632 , "None"));
Path.Add(new Vector3(-9650.904 , -1512.556 , 57.11935 , "None"));
Path.Add(new Vector3(-9648.37 , -1547.458 , 53.82714 , "None"));
Path.Add(new Vector3(-9646.362 , -1582.4 , 54.90095 , "None"));
Path.Add(new Vector3(-9642.333 , -1617.093 , 56.02602 , "None"));
Path.Add(new Vector3(-9629.428 , -1649.508 , 55.85596 , "None"));
Path.Add(new Vector3(-9616.949 , -1682.066 , 55.93571 , "None"));
Path.Add(new Vector3(-9612.222 , -1716.609 , 55.89406 , "None"));
Path.Add(new Vector3(-9614.248 , -1751.549 , 55.66163 , "None"));
Path.Add(new Vector3(-9614.801 , -1786.509 , 52.06497 , "None"));
Path.Add(new Vector3(-9610.497 , -1820.101 , 52.15186 , "None"));
Path.Add(new Vector3(-9605.158 , -1855.786 , 55.8406 , "None"));
Path.Add(new Vector3(-9603.12 , -1867.652 , 57.04078 , "None"));
Path.Add(new Vector3(-9602.129 , -1873.021 , 57.52559 , "None"));
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


public sealed class ROUTEGrapeManifestPathOut : QuestFollowPathClass
{
    public ROUTEGrapeManifestPathOut()
    {
        Name = "ROUTE Grape Manifest Path Out";

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

        Path.Add(new Vector3(-8900.383 , -180.8875 , 113.1576 , "None"));
Path.Add(new Vector3(-8896.136 , -178.8604 , 113.1576 , "None"));
Path.Add(new Vector3(-8891.747 , -173.7926 , 113.1583 , "None"));
Path.Add(new Vector3(-8885.461 , -173.225 , 113.269 , "None"));
Path.Add(new Vector3(-8884.938 , -178.0817 , 113.1611 , "None"));
Path.Add(new Vector3(-8886.686 , -181.1127 , 112.3187 , "None"));
Path.Add(new Vector3(-8888.517 , -184.0896 , 109.515 , "None"));
Path.Add(new Vector3(-8891.099 , -186.2465 , 106.7954 , "None"));
Path.Add(new Vector3(-8894.613 , -186.9746 , 104.0325 , "None"));
Path.Add(new Vector3(-8897.962 , -186.8254 , 101.1541 , "None"));
Path.Add(new Vector3(-8901.478 , -185.9969 , 98.07801 , "None"));
Path.Add(new Vector3(-8904.495 , -184.2599 , 97.6843 , "None"));
Path.Add(new Vector3(-8907.654 , -179.1831 , 97.68521 , "None"));
Path.Add(new Vector3(-8909.505 , -172.7169 , 97.68527 , "None"));
Path.Add(new Vector3(-8905.561 , -163.6351 , 97.68542 , "None"));
Path.Add(new Vector3(-8895.709 , -160.8628 , 97.68551 , "None"));
Path.Add(new Vector3(-8886.923 , -165.9914 , 97.68554 , "None"));
Path.Add(new Vector3(-8884.683 , -175.857 , 97.68555 , "None"));
Path.Add(new Vector3(-8890.915 , -184.034 , 91.95816 , "None"));
Path.Add(new Vector3(-8900.716 , -186.8378 , 83.14736 , "None"));
Path.Add(new Vector3(-8905.506 , -184.7563 , 81.93962 , "None"));
Path.Add(new Vector3(-8907.417 , -181.7973 , 81.93962 , "None"));
Path.Add(new Vector3(-8908.001 , -171.4139 , 81.93962 , "None"));
Path.Add(new Vector3(-8905.886 , -161.6737 , 81.93962 , "None"));
Path.Add(new Vector3(-8904.519 , -158.1802 , 81.93962 , "None"));
Path.Add(new Vector3(-8909.045 , -148.3435 , 81.94553 , "None"));
Path.Add(new Vector3(-8913.201 , -139.0906 , 81.54812 , "None"));
Path.Add(new Vector3(-8915.223 , -134.612 , 80.5045 , "None"));
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
return (!Quest.HasQuest(6) || new Vector3(-8915.223f, -134.612f, 80.5045f).DistanceTo(ObjectManager.Me.Position) < 3);
}



public override bool HasQuest() { return true; }


}


public sealed class ROUTEMillyGrapeManifestPath : QuestFollowPathClass
{
    public ROUTEMillyGrapeManifestPath()
    {
        Name = "ROUTE Milly Grape Manifest Path";

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

        Path.Add(new Vector3(-8890.371 , -131.3932 , 81.35853 , "None"));
Path.Add(new Vector3(-8894.242 , -130.2447 , 81.55597 , "None"));
Path.Add(new Vector3(-8901.236 , -128.9571 , 81.3771 , "None"));
Path.Add(new Vector3(-8908.075 , -129.7165 , 80.94688 , "None"));
Path.Add(new Vector3(-8910.969 , -135.666 , 80.44675 , "None"));
Path.Add(new Vector3(-8910.728 , -139.1468 , 82.05646 , "None"));
Path.Add(new Vector3(-8909.979 , -142.5661 , 82.20622 , "None"));
Path.Add(new Vector3(-8909.235 , -145.986 , 81.94894 , "None"));
Path.Add(new Vector3(-8908.49 , -149.4059 , 81.94749 , "None"));
Path.Add(new Vector3(-8906.268 , -155.6902 , 81.94147 , "None"));
Path.Add(new Vector3(-8905.477 , -159.1904 , 81.94006 , "None"));
Path.Add(new Vector3(-8907.494 , -165.859 , 81.94006 , "None"));
Path.Add(new Vector3(-8908.516 , -169.2067 , 81.94006 , "None"));
Path.Add(new Vector3(-8909.537 , -172.5543 , 81.94006 , "None"));
Path.Add(new Vector3(-8906.657 , -178.5729 , 81.94006 , "None"));
Path.Add(new Vector3(-8902.812 , -184.1897 , 81.94006 , "None"));
Path.Add(new Vector3(-8899.751 , -185.8499 , 83.79668 , "None"));
Path.Add(new Vector3(-8896.321 , -186.3419 , 86.95963 , "None"));
Path.Add(new Vector3(-8893.083 , -185.0457 , 89.89516 , "None"));
Path.Add(new Vector3(-8890.201 , -183.0805 , 93.09738 , "None"));
Path.Add(new Vector3(-8887.862 , -180.4772 , 96.05166 , "None"));
Path.Add(new Vector3(-8886.188 , -177.4199 , 97.68683 , "None"));
Path.Add(new Vector3(-8886.541 , -170.6774 , 97.68683 , "None"));
Path.Add(new Vector3(-8890.916 , -165.2258 , 97.68683 , "None"));
Path.Add(new Vector3(-8896.838 , -161.5708 , 97.68683 , "None"));
Path.Add(new Vector3(-8903.162 , -163.118 , 97.68683 , "None"));
Path.Add(new Vector3(-8907.37 , -168.3602 , 97.68683 , "None"));
Path.Add(new Vector3(-8908.011 , -175.1469 , 97.68683 , "None"));
Path.Add(new Vector3(-8905.806 , -181.7541 , 97.68683 , "None"));
Path.Add(new Vector3(-8900.969 , -186.3896 , 98.63823 , "None"));
Path.Add(new Vector3(-8897.508 , -185.9027 , 101.5993 , "None"));
Path.Add(new Vector3(-8894.061 , -185.2977 , 104.9199 , "None"));
Path.Add(new Vector3(-8890.851 , -183.9424 , 107.991 , "None"));
Path.Add(new Vector3(-8888.384 , -181.4723 , 111.2529 , "None"));
Path.Add(new Vector3(-8886.807 , -178.3729 , 113.1603 , "None"));
Path.Add(new Vector3(-8889.972 , -173.4178 , 113.1603 , "None"));
Path.Add(new Vector3(-8894.285 , -177.828 , 113.1589 , "None"));
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
return (!Quest.HasQuest(3905) || new Vector3(-8894.285f, -177.828f, 113.1589f).DistanceTo(ObjectManager.Me.Position) < 2);
}



public override bool HasQuest() { return true; }


}


public sealed class ROUTESentinelHilltoLT : QuestFollowPathClass
{
    public ROUTESentinelHilltoLT()
    {
        Name = "ROUTE Sentinel Hill to LT";

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

        Path.Add(new Vector3(-10607.85 , 1125.707 , 37.61607 , "None"));
Path.Add(new Vector3(-10607.83 , 1129.97 , 37.59277 , "None"));
Path.Add(new Vector3(-10607.17 , 1140.44 , 37.59814 , "None"));
Path.Add(new Vector3(-10606.08 , 1150.568 , 37.34587 , "None"));
Path.Add(new Vector3(-10604.62 , 1164.234 , 36.74309 , "None"));
Path.Add(new Vector3(-10602.26 , 1190.371 , 34.32053 , "None"));
Path.Add(new Vector3(-10601.08 , 1216.592 , 32.49745 , "None"));
Path.Add(new Vector3(-10603.97 , 1241.709 , 33.07291 , "None"));
Path.Add(new Vector3(-10614.57 , 1266.474 , 32.89584 , "None"));
Path.Add(new Vector3(-10626.09 , 1289.18 , 35.45842 , "None"));
Path.Add(new Vector3(-10635.76 , 1313.579 , 37.69055 , "None"));
Path.Add(new Vector3(-10651.54 , 1335.343 , 38.52823 , "None"));
Path.Add(new Vector3(-10668.41 , 1354.416 , 39.16297 , "None"));
Path.Add(new Vector3(-10683.93 , 1376.484 , 40.04715 , "None"));
Path.Add(new Vector3(-10693.95 , 1400.711 , 40.59533 , "None"));
Path.Add(new Vector3(-10700.77 , 1425.242 , 40.3001 , "None"));
Path.Add(new Vector3(-10708.19 , 1451.177 , 43.57318 , "None"));
Path.Add(new Vector3(-10723.94 , 1470.702 , 48.95936 , "None"));
Path.Add(new Vector3(-10746.88 , 1484.969 , 49.87458 , "None"));
Path.Add(new Vector3(-10770.13 , 1497.118 , 47.68063 , "None"));
Path.Add(new Vector3(-10795.55 , 1503.489 , 48.31474 , "None"));
Path.Add(new Vector3(-10818.5 , 1513.525 , 47.05252 , "None"));
Path.Add(new Vector3(-10838.01 , 1530.935 , 47.15272 , "None"));
Path.Add(new Vector3(-10854.59 , 1552.208 , 47.29769 , "None"));
Path.Add(new Vector3(-10870.02 , 1573.42 , 46.42822 , "None"));
Path.Add(new Vector3(-10887.62 , 1591.818 , 45.76818 , "None"));
Path.Add(new Vector3(-10901.44 , 1613.989 , 41.87697 , "None"));
Path.Add(new Vector3(-10905.76 , 1640.559 , 43.29377 , "None"));
Path.Add(new Vector3(-10903.62 , 1665.893 , 42.43877 , "None"));
Path.Add(new Vector3(-10899.29 , 1691.78 , 36.08408 , "None"));
Path.Add(new Vector3(-10897.68 , 1717.765 , 37.74101 , "None"));
Path.Add(new Vector3(-10910.2 , 1741.126 , 43.9941 , "None"));
Path.Add(new Vector3(-10934.18 , 1750.191 , 52.67819 , "None"));
Path.Add(new Vector3(-10960.31 , 1752.668 , 45.76707 , "None"));
Path.Add(new Vector3(-10985.6 , 1759.373 , 49.10011 , "None"));
Path.Add(new Vector3(-11008.47 , 1772.197 , 44.56169 , "None"));
Path.Add(new Vector3(-11030.27 , 1786.829 , 42.72269 , "None"));
Path.Add(new Vector3(-11051.24 , 1801.262 , 40.94992 , "None"));
Path.Add(new Vector3(-11073.52 , 1816.587 , 38.28627 , "None"));
Path.Add(new Vector3(-11097.96 , 1825.474 , 38.04724 , "None"));
Path.Add(new Vector3(-11123 , 1833.177 , 40.82297 , "None"));
Path.Add(new Vector3(-11147.53 , 1842.532 , 39.00167 , "None"));
Path.Add(new Vector3(-11171.32 , 1851.607 , 36.66328 , "None"));
Path.Add(new Vector3(-11179.76 , 1854.825 , 36.87057 , "None"));
Path.Add(new Vector3(-11184.37 , 1857.731 , 36.91785 , "None"));
Path.Add(new Vector3(-11199.22 , 1866.986 , 35.38661 , "None"));
Path.Add(new Vector3(-11213.78 , 1876.7 , 35.64002 , "None"));
Path.Add(new Vector3(-11220.62 , 1881.265 , 36.01807 , "None"));
Path.Add(new Vector3(-11228.42 , 1905.953 , 34.47936 , "None"));
Path.Add(new Vector3(-11233.08 , 1913.361 , 33.79583 , "None"));
Path.Add(new Vector3(-11240.26 , 1925.012 , 31.42523 , "None"));
Path.Add(new Vector3(-11245.31 , 1932.79 , 23.9817 , "None"));
Path.Add(new Vector3(-11250.69 , 1941.063 , 18.10153 , "None"));
Path.Add(new Vector3(-11258.27 , 1946.469 , 15.91949 , "None"));
Path.Add(new Vector3(-11265.6 , 1951.249 , 13.84291 , "None"));
Path.Add(new Vector3(-11275.83 , 1949.79 , 12.26612 , "None"));
Path.Add(new Vector3(-11291.4 , 1941.89 , 10.4916 , "None"));
Path.Add(new Vector3(-11305.47 , 1932.403 , 9.084557 , "None"));
Path.Add(new Vector3(-11320.59 , 1922.632 , 7.989406 , "None"));
Path.Add(new Vector3(-11337.54 , 1919.321 , 3.878632 , "None"));
Path.Add(new Vector3(-11341.34 , 1919.939 , 2.744164 , "None"));
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
return (!Quest.HasQuest(14) || new Vector3(-11407f, 1966f, 10f).DistanceTo(ObjectManager.Me.Position) < 100);
}



public override bool HasQuest() { return true; }


}


public sealed class ROUTETheCoastisntclearRouteLower : QuestFollowPathClass
{
    public ROUTETheCoastisntclearRouteLower()
    {
        Name = "ROUTE The Coast isnt clear Route Lower";

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

        Path.Add(new Vector3(-11256.32 , 1958.061 , 13.34249 , "None"));
Path.Add(new Vector3(-11251.44 , 1945.875 , 15.8788 , "None"));
Path.Add(new Vector3(-11241.13 , 1921.741 , 32.84441 , "None"));
Path.Add(new Vector3(-11238.42 , 1917.621 , 33.75108 , "None"));
Path.Add(new Vector3(-11226.47 , 1910.382 , 34.62524 , "None"));
Path.Add(new Vector3(-11206.19 , 1894.127 , 37.10963 , "None"));
Path.Add(new Vector3(-11188.19 , 1875.029 , 35.76269 , "None"));
Path.Add(new Vector3(-11168.37 , 1857.84 , 36.95797 , "None"));
Path.Add(new Vector3(-11146.41 , 1843.496 , 39.13748 , "None"));
Path.Add(new Vector3(-11123.41 , 1831.494 , 40.62878 , "None"));
Path.Add(new Vector3(-11098.89 , 1825.54 , 38.14991 , "None"));
Path.Add(new Vector3(-11072.28 , 1820.877 , 38.30712 , "None"));
Path.Add(new Vector3(-11048.33 , 1812.385 , 41.37952 , "None"));
Path.Add(new Vector3(-11023.1 , 1802.563 , 44.79574 , "None"));
Path.Add(new Vector3(-11000.78 , 1788.771 , 45.86512 , "None"));
Path.Add(new Vector3(-10979.77 , 1774.482 , 49.89098 , "None"));
Path.Add(new Vector3(-10957 , 1759.911 , 47.19831 , "None"));
Path.Add(new Vector3(-10940.59 , 1754.764 , 52.70327 , "None"));
Path.Add(new Vector3(-10920.21 , 1735.807 , 43.2962 , "None"));
Path.Add(new Vector3(-10900.52 , 1718.717 , 37.90495 , "None"));
Path.Add(new Vector3(-10877.12 , 1706.834 , 36.37916 , "None"));
Path.Add(new Vector3(-10854.68 , 1694.981 , 38.60675 , "None"));
Path.Add(new Vector3(-10832.47 , 1679.533 , 39.70758 , "None"));
Path.Add(new Vector3(-10812.25 , 1662.818 , 41.85105 , "None"));
Path.Add(new Vector3(-10792.53 , 1645.501 , 42.43288 , "None"));
Path.Add(new Vector3(-10771.54 , 1629.739 , 42.94979 , "None"));
Path.Add(new Vector3(-10750.57 , 1613.947 , 44.39017 , "None"));
Path.Add(new Vector3(-10729.6 , 1598.154 , 45.14142 , "None"));
Path.Add(new Vector3(-10708.51 , 1582.533 , 45.52162 , "None"));
Path.Add(new Vector3(-10685.68 , 1569.651 , 46.64412 , "None"));
Path.Add(new Vector3(-10662.08 , 1558.171 , 47.02151 , "None"));
Path.Add(new Vector3(-10638.32 , 1549.529 , 47.62894 , "None"));
Path.Add(new Vector3(-10612.34 , 1552.194 , 47.20504 , "None"));
Path.Add(new Vector3(-10585.75 , 1557.341 , 47.43761 , "None"));
Path.Add(new Vector3(-10562.54 , 1567.223 , 46.37202 , "None"));
Path.Add(new Vector3(-10540.67 , 1583.204 , 44.9679 , "None"));
Path.Add(new Vector3(-10522.58 , 1600.791 , 43.53922 , "None"));
Path.Add(new Vector3(-10505.11 , 1621.487 , 40.92382 , "None"));
Path.Add(new Vector3(-10487.51 , 1640.968 , 38.34162 , "None"));
Path.Add(new Vector3(-10469.3 , 1659.869 , 36.10919 , "None"));
Path.Add(new Vector3(-10451.1 , 1678.782 , 34.76156 , "None"));
Path.Add(new Vector3(-10433.69 , 1697.254 , 35.00097 , "None"));
Path.Add(new Vector3(-10413.98 , 1715.775 , 34.92825 , "None"));
Path.Add(new Vector3(-10390.47 , 1723.904 , 37.86837 , "None"));
Path.Add(new Vector3(-10364.24 , 1724.471 , 37.38166 , "None"));
Path.Add(new Vector3(-10337.42 , 1721.067 , 34.55883 , "None"));
Path.Add(new Vector3(-10312.51 , 1712.84 , 36.24477 , "None"));
Path.Add(new Vector3(-10289.08 , 1703.22 , 37.11487 , "None"));
Path.Add(new Vector3(-10265.93 , 1691.009 , 35.77244 , "None"));
Path.Add(new Vector3(-10247.24 , 1672.645 , 34.5213 , "None"));
Path.Add(new Vector3(-10230.76 , 1652.215 , 36.34638 , "None"));
Path.Add(new Vector3(-10217.12 , 1629.865 , 41.32547 , "None"));
Path.Add(new Vector3(-10204.12 , 1607.062 , 45.95091 , "None"));
Path.Add(new Vector3(-10184.76 , 1588.323 , 45.80747 , "None"));
Path.Add(new Vector3(-10161.96 , 1575.341 , 44.64675 , "None"));
Path.Add(new Vector3(-10138.86 , 1562.866 , 42.35705 , "None"));
Path.Add(new Vector3(-10131.65 , 1558.974 , 42.15594 , "None"));
Path.Add(new Vector3(-10113.19 , 1542.788 , 42.23735 , "None"));
Path.Add(new Vector3(-10095.09 , 1523.78 , 41.45385 , "None"));
Path.Add(new Vector3(-10077.98 , 1503.914 , 44.52446 , "None"));
Path.Add(new Vector3(-10064.97 , 1481.246 , 46.17404 , "None"));
Path.Add(new Vector3(-10063.79 , 1455.142 , 44.37059 , "None"));
Path.Add(new Vector3(-10063.43 , 1429.763 , 42.98168 , "None"));
Path.Add(new Vector3(-10059.17 , 1403.085 , 44.11469 , "None"));
Path.Add(new Vector3(-10048.82 , 1379.102 , 43.58551 , "None"));
Path.Add(new Vector3(-10030.74 , 1360.146 , 41.44078 , "None"));
Path.Add(new Vector3(-10009.63 , 1346.195 , 42.58387 , "None"));
Path.Add(new Vector3(-9983.893 , 1343.188 , 43.00651 , "None"));
Path.Add(new Vector3(-9958.438 , 1349.518 , 42.72223 , "None"));
Path.Add(new Vector3(-9932.244 , 1356.402 , 45.99979 , "None"));
Path.Add(new Vector3(-9906.543 , 1361.51 , 45.6229 , "None"));
Path.Add(new Vector3(-9880.425 , 1364.141 , 43.92875 , "None"));
Path.Add(new Vector3(-9865.748 , 1365.632 , 44.04372 , "None"));
Path.Add(new Vector3(-9848.82 , 1364.987 , 44.05931 , "None"));
Path.Add(new Vector3(-9826.916 , 1349.048 , 45.06037 , "None"));
Path.Add(new Vector3(-9808.047 , 1330.886 , 42.76616 , "None"));
Path.Add(new Vector3(-9792.172 , 1311.063 , 41.38247 , "None"));
Path.Add(new Vector3(-9772.942 , 1292.185 , 41.51419 , "None"));
Path.Add(new Vector3(-9767.661 , 1288.291 , 42.35667 , "None"));
Path.Add(new Vector3(-9761.076 , 1283.422 , 42.70159 , "None"));
Path.Add(new Vector3(-9755.54 , 1304.62 , 42.2459 , "None"));
Path.Add(new Vector3(-9739.479 , 1307.423 , 36.73233 , "None"));
Path.Add(new Vector3(-9722.797 , 1298.667 , 25.55798 , "None"));
Path.Add(new Vector3(-9702.087 , 1282.607 , 11.91881 , "None"));
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
return (!Quest.HasQuest(14) || new Vector3(-9699f, 1276f, 10f).DistanceTo(ObjectManager.Me.Position) < 25);
}



public override bool HasQuest() { return true; }


}


public sealed class ROUTEBackToLt : QuestFollowPathClass
{
    public ROUTEBackToLt()
    {
        Name = "ROUTEBackToLt";

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

        Path.Add(new Vector3(-10354.33 , 1720.325 , 36.36941 , "None"));
Path.Add(new Vector3(-10376.68 , 1723.689 , 38.32354 , "None"));
Path.Add(new Vector3(-10402.74 , 1721.16 , 36.32817 , "None"));
Path.Add(new Vector3(-10424.33 , 1706.98 , 34.4522 , "None"));
Path.Add(new Vector3(-10441.4 , 1687.055 , 34.87947 , "None"));
Path.Add(new Vector3(-10460.18 , 1668.706 , 35.35576 , "None"));
Path.Add(new Vector3(-10478.6 , 1650.117 , 37.19178 , "None"));
Path.Add(new Vector3(-10495.88 , 1630.352 , 39.60336 , "None"));
Path.Add(new Vector3(-10513.08 , 1610.528 , 42.45596 , "None"));
Path.Add(new Vector3(-10530.7 , 1592.276 , 44.05994 , "None"));
Path.Add(new Vector3(-10551.61 , 1575.083 , 45.73106 , "None"));
Path.Add(new Vector3(-10573.4 , 1562.209 , 47.03008 , "None"));
Path.Add(new Vector3(-10598.97 , 1553.401 , 47.47892 , "None"));
Path.Add(new Vector3(-10623.71 , 1544.734 , 47.25405 , "None"));
Path.Add(new Vector3(-10644.95 , 1529.38 , 47.29602 , "None"));
Path.Add(new Vector3(-10663 , 1512.858 , 46.69585 , "None"));
Path.Add(new Vector3(-10687.41 , 1505.942 , 46.30054 , "None"));
Path.Add(new Vector3(-10714.4 , 1503.756 , 48.29499 , "None"));
Path.Add(new Vector3(-10739.77 , 1503.56 , 47.98645 , "None"));
Path.Add(new Vector3(-10766.71 , 1501.981 , 47.97842 , "None"));
Path.Add(new Vector3(-10792.8 , 1499.588 , 47.9165 , "None"));
Path.Add(new Vector3(-10818.19 , 1505.247 , 46.99117 , "None"));
Path.Add(new Vector3(-10837.99 , 1522.196 , 46.98089 , "None"));
Path.Add(new Vector3(-10854.36 , 1541.63 , 47.15827 , "None"));
Path.Add(new Vector3(-10871.03 , 1562.933 , 48.07526 , "None"));
Path.Add(new Vector3(-10885.89 , 1584.572 , 46.64001 , "None"));
Path.Add(new Vector3(-10898.23 , 1607.728 , 42.87629 , "None"));
Path.Add(new Vector3(-10907.86 , 1632.126 , 42.23811 , "None"));
Path.Add(new Vector3(-10912.59 , 1656.986 , 43.83684 , "None"));
Path.Add(new Vector3(-10913.23 , 1684.055 , 39.81826 , "None"));
Path.Add(new Vector3(-10913.06 , 1710.305 , 36.17805 , "None"));
Path.Add(new Vector3(-10919.44 , 1734.946 , 42.77064 , "None"));
Path.Add(new Vector3(-10942.82 , 1745.825 , 51.20979 , "None"));
Path.Add(new Vector3(-10967.51 , 1751.702 , 45.66072 , "None"));
Path.Add(new Vector3(-10992.25 , 1762.71 , 47.79841 , "None"));
Path.Add(new Vector3(-11016.13 , 1773.619 , 43.85457 , "None"));
Path.Add(new Vector3(-11037.41 , 1788.93 , 42.09315 , "None"));
Path.Add(new Vector3(-11057.39 , 1804.627 , 40.27706 , "None"));
Path.Add(new Vector3(-11079.49 , 1820.222 , 37.64042 , "None"));
Path.Add(new Vector3(-11104.16 , 1828.835 , 39.31446 , "None"));
Path.Add(new Vector3(-11129.41 , 1835.977 , 40.59862 , "None"));
Path.Add(new Vector3(-11154.11 , 1844.858 , 38.43439 , "None"));
Path.Add(new Vector3(-11177.65 , 1856.45 , 36.78605 , "None"));
Path.Add(new Vector3(-11198.99 , 1871.629 , 35.5175 , "None"));
Path.Add(new Vector3(-11218.32 , 1889.347 , 36.86383 , "None"));
Path.Add(new Vector3(-11225.68 , 1899.164 , 35.52515 , "None"));
Path.Add(new Vector3(-11202.26 , 1914.442 , 33.95241 , "None"));
Path.Add(new Vector3(-11210.01 , 1921.759 , 33.6477 , "None"));
Path.Add(new Vector3(-11218.5 , 1930.709 , 33.46229 , "None"));
Path.Add(new Vector3(-11196.61 , 1941.097 , 33.66427 , "None"));
Path.Add(new Vector3(-11197.68 , 1955.213 , 29.18435 , "None"));
Path.Add(new Vector3(-11200.91 , 1981.084 , 16.33455 , "None"));
Path.Add(new Vector3(-11224.05 , 1978.837 , 12.03557 , "None"));
Path.Add(new Vector3(-11247.06 , 1966.252 , 11.12736 , "None"));
Path.Add(new Vector3(-11270.57 , 1954.584 , 11.99301 , "None"));
Path.Add(new Vector3(-11294.09 , 1942.914 , 10.06646 , "None"));
Path.Add(new Vector3(-11316.96 , 1931.761 , 7.833922 , "None"));
Path.Add(new Vector3(-11336.19 , 1918.28 , 4.480731 , "None"));
Path.Add(new Vector3(-11361.32 , 1928.181 , 3.260561 , "None"));
Path.Add(new Vector3(-11385.39 , 1938.638 , 2.128022 , "None"));
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
return (!Quest.HasQuest(14) || new Vector3(-11407f, 1966f, 10f).DistanceTo(ObjectManager.Me.Position) < 100);
}



public override bool HasQuest() { return true; }


}


public sealed class ROUTEThirdPartMurlocs : QuestFollowPathClass
{
    public ROUTEThirdPartMurlocs()
    {
        Name = "ROUTEThirdPartMurlocs";

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

        Path.Add(new Vector3(-9714.855 , 1375.606 , 37.60924 , "None"));
Path.Add(new Vector3(-9729.401 , 1383.054 , 42.44762 , "None"));
Path.Add(new Vector3(-9734.45 , 1391.494 , 42.58606 , "None"));
Path.Add(new Vector3(-9744.029 , 1406.114 , 43.5325 , "None"));
Path.Add(new Vector3(-9755.947 , 1418.901 , 41.83836 , "None"));
Path.Add(new Vector3(-9770.607 , 1428.272 , 42.16497 , "None"));
Path.Add(new Vector3(-9787.073 , 1434.191 , 43.63511 , "None"));
Path.Add(new Vector3(-9803.542 , 1440.109 , 45.82426 , "None"));
Path.Add(new Vector3(-9819.459 , 1447.361 , 50.76805 , "None"));
Path.Add(new Vector3(-9834.351 , 1456.527 , 54.89339 , "None"));
Path.Add(new Vector3(-9848.193 , 1467.173 , 55.73328 , "None"));
Path.Add(new Vector3(-9861.348 , 1479.544 , 57.72099 , "None"));
Path.Add(new Vector3(-9868.869 , 1486.719 , 62.0089 , "None"));
Path.Add(new Vector3(-9883.6 , 1493.922 , 62.37836 , "None"));
Path.Add(new Vector3(-9900.655 , 1497.763 , 58.51028 , "None"));
Path.Add(new Vector3(-9915.03 , 1507.344 , 52.28825 , "None"));
Path.Add(new Vector3(-9926.735 , 1520.321 , 45.29741 , "None"));
Path.Add(new Vector3(-9936.32 , 1534.903 , 44.70294 , "None"));
Path.Add(new Vector3(-9942.77 , 1551.128 , 41.9262 , "None"));
Path.Add(new Vector3(-9943.392 , 1568.553 , 41.8118 , "None"));
Path.Add(new Vector3(-9941.228 , 1585.911 , 40.94239 , "None"));
Path.Add(new Vector3(-9938.01 , 1603.112 , 40.24332 , "None"));
Path.Add(new Vector3(-9935.181 , 1620.372 , 40.64967 , "None"));
Path.Add(new Vector3(-9933.95 , 1629.6 , 37.27318 , "None"));
Path.Add(new Vector3(-9932.664 , 1639.916 , 35.31892 , "None"));
Path.Add(new Vector3(-9930.499 , 1657.281 , 33.75189 , "None"));
Path.Add(new Vector3(-9931.21 , 1675.198 , 33.35798 , "None"));
Path.Add(new Vector3(-9936.935 , 1691.051 , 34.75848 , "None"));
Path.Add(new Vector3(-9945.565 , 1706.273 , 34.84957 , "None"));
Path.Add(new Vector3(-9949.797 , 1711.299 , 34.24709 , "None"));
Path.Add(new Vector3(-9955.313 , 1718.795 , 34.82817 , "None"));
Path.Add(new Vector3(-9961.318 , 1728.56 , 35.76452 , "None"));
Path.Add(new Vector3(-9967.853 , 1744.781 , 35.92776 , "None"));
Path.Add(new Vector3(-9974.435 , 1761.588 , 37.8133 , "None"));
Path.Add(new Vector3(-9978.446 , 1768.714 , 36.7365 , "None"));
Path.Add(new Vector3(-9988.134 , 1783.274 , 32.94624 , "None"));
Path.Add(new Vector3(-9991.114 , 1800.048 , 31.95615 , "None"));
Path.Add(new Vector3(-9987.595 , 1817.17 , 35.18242 , "None"));
Path.Add(new Vector3(-9981.909 , 1833.697 , 36.33428 , "None"));
Path.Add(new Vector3(-9977.527 , 1849.454 , 36.51177 , "None"));
Path.Add(new Vector3(-9982.134 , 1853.33 , 36.81891 , "None"));
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
return (!Quest.HasQuest(14) || new Vector3(-9982.134f, 1853.33f, 36.81891f).DistanceTo(ObjectManager.Me.Position) < 10);
}



public override bool HasQuest() { return true; }


}


public sealed class ShipmenttoStormwind : QuestClass
{
    public ShipmenttoStormwind()
    {
        Name = "Shipment to Stormwind";

        QuestId.AddRange(new[] { 61 });

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


public sealed class SkirmishatEchoRidge : QuestGrinderClass
{
    public SkirmishatEchoRidge()
    {
        Name = "Skirmish at Echo Ridge";

        QuestId.AddRange(new[] { 21 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(80);
HotSpots.Add(new Vector3(-8660.179 , -124.8799 , 91.19839 , "None"));
HotSpots.Add(new Vector3(-8637.981 , -133.4326 , 86.90179 , "None"));
HotSpots.Add(new Vector3(-8634.207 , -145.2421 , 86.28511 , "None"));
HotSpots.Add(new Vector3(-8601.23 , -138.195 , 87.6999 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SpeakwithGramma : QuestClass
{
    public SpeakwithGramma()
    {
        Name = "Speak with Gramma";

        QuestId.AddRange(new[] { 111 });

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


public sealed class TheCoastIsntClear12 : QuestGrinderClass
{
    public TheCoastIsntClear12()
    {
        Name = "The Coast Isn't Clear 1/2";

        QuestId.AddRange(new[] { 152 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, true, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(517);
EntryTarget.Add(127);
HotSpots.Add(new Vector3(-11331.23 , 1837.138 , 10.40895 , "None"));
HotSpots.Add(new Vector3(-11165.7 , 2037.17 , 0.1789154 , "None"));
HotSpots.Add(new Vector3(-11101.3 , 2035.25 , 1.121491 , "None"));
HotSpots.Add(new Vector3(-11097.3 , 2067.77 , 1.065526 , "None"));
HotSpots.Add(new Vector3(-11037.69 , 2082.255 , 1.277024 , "None"));
HotSpots.Add(new Vector3(-11088.27 , 2108.763 , -1.929706 , "Swimming"));
HotSpots.Add(new Vector3(-11029.89 , 2050.927 , 8.941248 , "None"));
HotSpots.Add(new Vector3(-11039.06 , 2018.877 , 11.30671 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheCoastisntclear22 : QuestGrinderClass
{
    public TheCoastisntclear22()
    {
        Name = "The Coast isnt clear 2/2";

        QuestId.AddRange(new[] { 152 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(126);
HotSpots.Add(new Vector3(-9636.599 , 1095.452 , 4.209462 , "None"));
HotSpots.Add(new Vector3(-9649.841 , 1206.744 , 10.1822 , "None"));
HotSpots.Add(new Vector3(-9620.528 , 1415.068 , 8.34141 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheCoastisntclear32 : QuestGrinderClass
{
    public TheCoastisntclear32()
    {
        Name = "The Coast isnt clear 3/2";

        QuestId.AddRange(new[] { 152 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(171);
HotSpots.Add(new Vector3(-9914.616 , 1833.659 , 6.006959 , "None"));
HotSpots.Add(new Vector3(-9996.248 , 1932.089 , 0.1565798 , "None"));
HotSpots.Add(new Vector3(-10133.27 , 1968.841 , 11.45675 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheCoastalMenace : QuestGrinderClass
{
    public TheCoastalMenace()
    {
        Name = "The Coastal Menace";

        QuestId.AddRange(new[] { 104 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(391);
HotSpots.Add(new Vector3(-11300.88 , 1923.925 , 10.33628 , "None"));
HotSpots.Add(new Vector3(-11280.52 , 1945.38 , 12.01794 , "None"));
HotSpots.Add(new Vector3(-11276.59 , 1949.579 , 14.20306 , "None"));
HotSpots.Add(new Vector3(-11226.63 , 1986.285 , 10.00591 , "None"));
HotSpots.Add(new Vector3(-11188.6 , 1997.304 , 11.09834 , "None"));
HotSpots.Add(new Vector3(-11145.71 , 2008.946 , 6.850026 , "None"));
HotSpots.Add(new Vector3(-11120.71 , 2015.897 , 5.516792 , "None"));
HotSpots.Add(new Vector3(-11096.19 , 2034.486 , 2.053939 , "None"));
HotSpots.Add(new Vector3(-11011.53 , 2068.172 , 6.197918 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheEscape : QuestClass
{
    public TheEscape()
    {
        Name = "The Escape";

        QuestId.AddRange(new[] { 114 });

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


public sealed class TheFargodeepMine : QuestFollowPathClass
{
    public TheFargodeepMine()
    {
        Name = "The Fargodeep Mine";

        QuestId.AddRange(new[] { 62 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-9851.057 , 156.7349 , 25.10009 , "None"));
Path.Add(new Vector3(-9850.817 , 161.8741 , 23.75425 , "None"));
Path.Add(new Vector3(-9850.567 , 165.3651 , 23.05951 , "None"));
Path.Add(new Vector3(-9849.986 , 172.0101 , 21.93556 , "None"));
Path.Add(new Vector3(-9847.646 , 178.5744 , 21.19731 , "None"));
Path.Add(new Vector3(-9845.712 , 181.4881 , 21.00518 , "None"));
Path.Add(new Vector3(-9843.019 , 183.6965 , 21.9274 , "None"));
Path.Add(new Vector3(-9839.683 , 184.6746 , 22.62533 , "None"));
Path.Add(new Vector3(-9833.036 , 182.6731 , 22.39208 , "None"));
Path.Add(new Vector3(-9829.755 , 181.4546 , 22.35465 , "None"));
Path.Add(new Vector3(-9822.981 , 180.6541 , 23.00181 , "None"));
Path.Add(new Vector3(-9819.564 , 181.4104 , 22.78627 , "None"));
Path.Add(new Vector3(-9812.633 , 182.3187 , 22.43591 , "None"));
Path.Add(new Vector3(-9806.099 , 179.8411 , 22.46997 , "None"));
Path.Add(new Vector3(-9803.748 , 177.2526 , 22.79586 , "None"));
Path.Add(new Vector3(-9801.519 , 174.5568 , 23.14606 , "None"));
Path.Add(new Vector3(-9799.536 , 171.6723 , 23.50196 , "None"));
Path.Add(new Vector3(-9797.563 , 168.7812 , 24.04167 , "None"));
Path.Add(new Vector3(-9795.47 , 165.9809 , 24.8014 , "None"));
Path.Add(new Vector3(-9793.116 , 163.3924 , 25.74019 , "None"));
Path.Add(new Vector3(-9788.088 , 158.524 , 25.85029 , "None"));
Path.Add(new Vector3(-9782.151 , 155.1275 , 26.22579 , "None"));
Path.Add(new Vector3(-9775.171 , 154.7075 , 25.24824 , "None"));
Path.Add(new Vector3(-9771.674 , 154.555 , 25.02743 , "None"));
Path.Add(new Vector3(-9764.858 , 153.2317 , 24.86944 , "None"));
Path.Add(new Vector3(-9761.63 , 151.623 , 23.73583 , "None"));
Path.Add(new Vector3(-9758.826 , 149.7271 , 22.33799 , "None"));
Path.Add(new Vector3(-9756.035 , 147.446 , 21.0001 , "None"));
Path.Add(new Vector3(-9753.608 , 144.9254 , 20.21455 , "None"));
Path.Add(new Vector3(-9750.19 , 139.0279 , 19.61851 , "None"));
Path.Add(new Vector3(-9749.71 , 135.4549 , 19.4414 , "None"));
Path.Add(new Vector3(-9750.1 , 131.8691 , 18.98014 , "None"));
Path.Add(new Vector3(-9750.683 , 128.4181 , 17.46359 , "None"));
Path.Add(new Vector3(-9751.291 , 124.9713 , 16.82088 , "None"));
Path.Add(new Vector3(-9752.771 , 118.2448 , 15.39025 , "None"));
Path.Add(new Vector3(-9753.12 , 114.6683 , 14.66451 , "None"));
Path.Add(new Vector3(-9751.335 , 107.9206 , 14.06269 , "None"));
Path.Add(new Vector3(-9750.165 , 104.6218 , 13.23928 , "None"));
Path.Add(new Vector3(-9749.398 , 101.2116 , 12.7004 , "None"));
Path.Add(new Vector3(-9752.346 , 95.33691 , 13.32397 , "None"));
Path.Add(new Vector3(-9755.355 , 93.55157 , 13.02948 , "None"));
Path.Add(new Vector3(-9762.018 , 92.26297 , 11.88591 , "None"));
Path.Add(new Vector3(-9765.19 , 93.68506 , 10.69217 , "None"));
Path.Add(new Vector3(-9767.747 , 96.06673 , 9.368035 , "None"));
Path.Add(new Vector3(-9770.092 , 98.80491 , 7.552598 , "None"));
Path.Add(new Vector3(-9772.312 , 101.3736 , 6.371613 , "None"));
Path.Add(new Vector3(-9774.696 , 103.9354 , 5.708362 , "None"));
Path.Add(new Vector3(-9777.265 , 106.4633 , 5.054179 , "None"));
Path.Add(new Vector3(-9779.886 , 108.7809 , 4.939611 , "None"));
Path.Add(new Vector3(-9785.838 , 112.4266 , 4.655867 , "None"));
Path.Add(new Vector3(-9789.089 , 113.7183 , 4.491781 , "None"));
Path.Add(new Vector3(-9792.365 , 114.9484 , 4.931942 , "None"));
Path.Add(new Vector3(-9799.069 , 116.9429 , 5.86853 , "None"));
Path.Add(new Vector3(-9802.469 , 117.7756 , 5.520005 , "None"));
Path.Add(new Vector3(-9805.868 , 118.6082 , 4.894794 , "None"));
Path.Add(new Vector3(-9809.269 , 119.4409 , 4.397281 , "None"));
Path.Add(new Vector3(-9812.668 , 120.2735 , 3.913087 , "None"));
Path.Add(new Vector3(-9816.067 , 121.1062 , 3.880196 , "None"));
Path.Add(new Vector3(-9822.751 , 122.7934 , 4.007136 , "None"));
Path.Add(new Vector3(-9826.123 , 124.0678 , 4.12267 , "None"));
Path.Add(new Vector3(-9832.633 , 126.6404 , 5.62686 , "None"));
Path.Add(new Vector3(-9835.888 , 127.9268 , 5.703764 , "None"));
Path.Add(new Vector3(-9839.142 , 129.2145 , 5.044979 , "None"));
Path.Add(new Vector3(-9842.879 , 130.7761 , 5.033172 , "None"));
Path.Add(new Vector3(-9846.059 , 132.2351 , 5.232219 , "None"));
IsCompleteWhenAtLastPath = false;
ForceToStartFirstPosition = false;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheForgottenHeirloom : QuestGathererClass
{
    public TheForgottenHeirloom()
    {
        Name = "The Forgotten Heirloom";

        QuestId.AddRange(new[] { 64 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(290);
HotSpots.Add(new Vector3(-9847.888 , 1287.781 , 41.88741 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheJasperlodeMine : QuestFollowPathClass
{
    public TheJasperlodeMine()
    {
        Name = "The Jasperlode Mine";

        QuestId.AddRange(new[] { 76 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-9380.226 , -737.4111 , 68.7368 , "None"));
Path.Add(new Vector3(-9376.389 , -730.5378 , 68.63022 , "None"));
Path.Add(new Vector3(-9372.603 , -720.7563 , 67.26493 , "None"));
Path.Add(new Vector3(-9369.693 , -710.6782 , 66.42593 , "None"));
Path.Add(new Vector3(-9367.545 , -700.4005 , 67.11022 , "None"));
Path.Add(new Vector3(-9364.811 , -690.2679 , 67.86057 , "None"));
Path.Add(new Vector3(-9359.876 , -681.0851 , 67.91405 , "None"));
Path.Add(new Vector3(-9353.91 , -675.4678 , 67.25663 , "None"));
Path.Add(new Vector3(-9344.428 , -668.9844 , 68.59095 , "None"));
Path.Add(new Vector3(-9336.159 , -663.0415 , 68.5292 , "None"));
Path.Add(new Vector3(-9326.751 , -657.7457 , 66.87372 , "None"));
Path.Add(new Vector3(-9316.718 , -654.736 , 65.96291 , "None"));
Path.Add(new Vector3(-9306.329 , -653.2159 , 65.04826 , "None"));
Path.Add(new Vector3(-9296.289 , -651.5096 , 65.32387 , "None"));
Path.Add(new Vector3(-9285.749 , -649.0946 , 64.78708 , "None"));
Path.Add(new Vector3(-9275.485 , -646.9044 , 64.71301 , "None"));
Path.Add(new Vector3(-9265.007 , -646.3433 , 64.44216 , "None"));
Path.Add(new Vector3(-9254.535 , -646.9207 , 63.48208 , "None"));
Path.Add(new Vector3(-9250.606 , -647.3116 , 63.24055 , "None"));
Path.Add(new Vector3(-9240.662 , -649.3809 , 64.14176 , "None"));
Path.Add(new Vector3(-9230.364 , -651.4384 , 63.223 , "None"));
Path.Add(new Vector3(-9221.214 , -652.3632 , 62.30016 , "None"));
Path.Add(new Vector3(-9211.252 , -651.3046 , 62.80899 , "None"));
Path.Add(new Vector3(-9203.099 , -644.8224 , 62.67623 , "None"));
Path.Add(new Vector3(-9197.629 , -635.9459 , 63.34175 , "None"));
Path.Add(new Vector3(-9195.676 , -625.6795 , 61.59207 , "None"));
Path.Add(new Vector3(-9194.647 , -615.5649 , 61.13736 , "None"));
Path.Add(new Vector3(-9188.038 , -607.382 , 62.24088 , "None"));
Path.Add(new Vector3(-9178.781 , -602.4303 , 63.35656 , "None"));
Path.Add(new Vector3(-9169.243 , -598.0466 , 62.45854 , "None"));
Path.Add(new Vector3(-9159.346 , -594.5577 , 59.05626 , "None"));
Path.Add(new Vector3(-9153.492 , -593.6888 , 58.67741 , "None"));
Path.Add(new Vector3(-9145.461 , -595.2902 , 58.09733 , "None"));
Path.Add(new Vector3(-9137.071 , -593.8347 , 57.59293 , "None"));
Path.Add(new Vector3(-9129.498 , -590.0268 , 57.72093 , "None"));
Path.Add(new Vector3(-9126.715 , -585.9897 , 58.09775 , "None"));
Path.Add(new Vector3(-9122.755 , -578.4398 , 58.93557 , "None"));
Path.Add(new Vector3(-9116.692 , -569.949 , 59.04721 , "None"));
Path.Add(new Vector3(-9109.107 , -564.3735 , 60.55472 , "None"));
Path.Add(new Vector3(-9102.605 , -563.606 , 61.2911 , "None"));
Path.Add(new Vector3(-9096.381 , -563.2386 , 62.49043 , "None"));
Path.Add(new Vector3(-9092.184 , -560.7032 , 61.71646 , "None"));
Path.Add(new Vector3(-9084.486 , -554.0334 , 60.0296 , "None"));
IsCompleteWhenAtLastPath = false;
ForceToStartFirstPosition = true;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheKillingFields : QuestGrinderClass
{
    public TheKillingFields()
    {
        Name = "The Killing Fields";

        QuestId.AddRange(new[] { 9 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(114);
HotSpots.Add(new Vector3(-10620.42 , 1587.896 , 42.51301 , "None"));
HotSpots.Add(new Vector3(-10645.91 , 1685.771 , 42.03016 , "None"));
HotSpots.Add(new Vector3(-10547.91 , 1705.934 , 42.2132 , "None"));
HotSpots.Add(new Vector3(-10585.83 , 1752.678 , 40.5857 , "None"));
HotSpots.Add(new Vector3(-10286.97 , 1452.77 , 40.05658 , "None"));
HotSpots.Add(new Vector3(-10219.08 , 1485.419 , 41.45226 , "None"));
HotSpots.Add(new Vector3(-10173.84 , 1417.725 , 39.96553 , "None"));
HotSpots.Add(new Vector3(-9979.238 , 1216.501 , 42.28904 , "None"));
HotSpots.Add(new Vector3(-9911.494 , 1206.601 , 42.18521 , "None"));
HotSpots.Add(new Vector3(-9893.572 , 1270.293 , 41.80188 , "None"));
HotSpots.Add(new Vector3(-9871.32 , 1230.381 , 41.70824 , "None"));
HotSpots.Add(new Vector3(-10117.1 , 1157.756 , 36.35425 , "None"));
HotSpots.Add(new Vector3(-10189.57 , 1082.477 , 36.55599 , "None"));
HotSpots.Add(new Vector3(-10221.71 , 1131.827 , 36.22331 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThePeoplesMilitia1 : QuestGrinderClass
{
    public ThePeoplesMilitia1()
    {
        Name = "The People's Militia 1";

        QuestId.AddRange(new[] { 12 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(504);
EntryTarget.Add(95);
HotSpots.Add(new Vector3(-10324.88 , 1241.079 , 39.10248 , "None"));
HotSpots.Add(new Vector3(-10297.15 , 1403.008 , 40.14988 , "None"));
HotSpots.Add(new Vector3(-10341.12 , 1556.699 , 41.24932 , "None"));
HotSpots.Add(new Vector3(-10460.36 , 1314.412 , 45.98338 , "None"));
HotSpots.Add(new Vector3(-10209.28 , 1897.915 , 36.54889 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThePeoplesMilitia2 : QuestGrinderClass
{
    public ThePeoplesMilitia2()
    {
        Name = "The People's Militia 2";

        QuestId.AddRange(new[] { 13 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(590);
EntryTarget.Add(589);
HotSpots.Add(new Vector3(-10727.84 , 1657.191 , 44.13061 , "None"));
HotSpots.Add(new Vector3(-10739.64 , 1689.841 , 46.03408 , "None"));
HotSpots.Add(new Vector3(-10702.8 , 1721.623 , 42.2625 , "None"));
HotSpots.Add(new Vector3(-10670.64 , 1716.325 , 41.45312 , "None"));
HotSpots.Add(new Vector3(-10693.13 , 1744.061 , 41.50656 , "None"));
HotSpots.Add(new Vector3(-10674.6 , 1757.24 , 39.09567 , "None"));
HotSpots.Add(new Vector3(-10657.21 , 1767.144 , 37.13271 , "None"));
HotSpots.Add(new Vector3(-10654.6 , 1791.67 , 35.55579 , "None"));
HotSpots.Add(new Vector3(-10986.88 , 1511.549 , 43.52535 , "None"));
HotSpots.Add(new Vector3(-11006 , 1497.93 , 43.85267 , "None"));
HotSpots.Add(new Vector3(-11016 , 1487.04 , 43.35218 , "None"));
HotSpots.Add(new Vector3(-10989.1 , 1490.65 , 43.75387 , "None"));
HotSpots.Add(new Vector3(-10992.4 , 1491.23 , 50.60788 , "None"));
HotSpots.Add(new Vector3(-11001.2 , 1466.05 , 43.20272 , "None"));
HotSpots.Add(new Vector3(-11042 , 1424.21 , 44.36043 , "None"));
HotSpots.Add(new Vector3(-11058.46 , 1405.459 , 46.42199 , "None"));
HotSpots.Add(new Vector3(-11045.5 , 1538.39 , 43.35302 , "None"));
HotSpots.Add(new Vector3(-11064.33 , 1561.88 , 45.21096 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThePeoplesMilitia3 : QuestGrinderClass
{
    public ThePeoplesMilitia3()
    {
        Name = "The People's Militia 3";

        QuestId.AddRange(new[] { 14 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(449);
EntryTarget.Add(121);
HotSpots.Add(new Vector3(-11113.38 , 1660.869 , 49.11116 , "None"));
HotSpots.Add(new Vector3(-11139.21 , 1741.263 , 38.6748 , "None"));
HotSpots.Add(new Vector3(-11194.54 , 1753.004 , 36.55698 , "None"));
HotSpots.Add(new Vector3(-11276.79 , 1750.7 , 36.18906 , "None"));
HotSpots.Add(new Vector3(-11274.95 , 1720.366 , 39.62949 , "None"));
HotSpots.Add(new Vector3(-11279.12 , 1706.447 , 41.04146 , "None"));
HotSpots.Add(new Vector3(-11291.03 , 1689.974 , 43.14636 , "None"));
HotSpots.Add(new Vector3(-11274.43 , 1677.837 , 46.85141 , "None"));
HotSpots.Add(new Vector3(-11250.96 , 1650.697 , 50.60011 , "None"));
HotSpots.Add(new Vector3(-11080.81 , 1788.046 , 37.87852 , "None"));
HotSpots.Add(new Vector3(-11322.5 , 1727.94 , 36.97581 , "None"));
HotSpots.Add(new Vector3(-11279.25 , 1544.452 , 74.21453 , "None"));
HotSpots.Add(new Vector3(-11248.1 , 1400.41 , 89.42614 , "None"));
HotSpots.Add(new Vector3(-11206.75 , 1296.008 , 91.43874 , "None"));
HotSpots.Add(new Vector3(-11233.27 , 1235.063 , 89.41393 , "None"));
HotSpots.Add(new Vector3(-11197.55 , 1208.26 , 86.98955 , "None"));
HotSpots.Add(new Vector3(-11122.18 , 1173.247 , 62.33527 , "None"));
HotSpots.Add(new Vector3(-11120.93 , 1177.75 , 62.27338 , "None"));
HotSpots.Add(new Vector3(-11119.42 , 1209.609 , 66.76859 , "None"));
HotSpots.Add(new Vector3(-11229.98 , 1219.839 , 89.16655 , "None"));
HotSpots.Add(new Vector3(-11238.89 , 1291.413 , 89.90898 , "None"));
HotSpots.Add(new Vector3(-11292.4 , 1374.8 , 95.79098 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheTomeofDivinityFive : QuestClass
{
    public TheTomeofDivinityFive()
    {
        Name = "The Tome of Divinity Five";

        QuestId.AddRange(new[] { 1786 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Paladin;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheTomeofDivinityFour : QuestInteractWithClass
{
    public TheTomeofDivinityFour()
    {
        Name = "The Tome of Divinity Four";

        QuestId.AddRange(new[] { 1781 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Paladin;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(-8516 , 862.654 , 109.839 , "None"));
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


public sealed class TheTomeofDivinityRez : QuestUseItemOnClass
{
    public TheTomeofDivinityRez()
    {
        Name = "The Tome of Divinity Rez";

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

        EntryIdTarget.Add(6172);
HotSpots.Add(new Vector3(-9129.634 , -982.0455 , 75.65228 , "None"));
ItemId = 6866;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheTomeofDivinitySeven : QuestClass
{
    public TheTomeofDivinitySeven()
    {
        Name = "The Tome of Divinity Seven";

        QuestId.AddRange(new[] { 1788 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Paladin;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheTomeofDivinitySix : QuestGrinderClass
{
    public TheTomeofDivinitySix()
    {
        Name = "The Tome of Divinity Six";

        QuestId.AddRange(new[] { 1787 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Paladin;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(474);
HotSpots.Add(new Vector3(-9123.83 , -1020.25 , 72.17343 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheTomeofDivinityOne : QuestClass
{
    public TheTomeofDivinityOne()
    {
        Name = "The Tome of DivinityOne";

        QuestId.AddRange(new[] { 1643 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Paladin;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheTomeofDivinitythree : QuestClass
{
    public TheTomeofDivinitythree()
    {
        Name = "The Tome of Divinitythree";

        QuestId.AddRange(new[] { 1780 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Paladin;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheTomeofDivinityTwo : QuestClass
{
    public TheTomeofDivinityTwo()
    {
        Name = "The Tome of DivinityTwo";

        QuestId.AddRange(new[] { 1644 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Paladin;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TomeofDivinity : QuestClass
{
    public TomeofDivinity()
    {
        Name = "Tome of Divinity";

        QuestId.AddRange(new[] { 2998 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Paladin;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WantedHogger : QuestGrinderClass
{
    public WantedHogger()
    {
        Name = "Wanted: &quot;Hogger&quot;";

        QuestId.AddRange(new[] { 176 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(448);
HotSpots.Add(new Vector3(-10107.2 , 617.835 , 38.06871 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WestbrookGarrisonNeedsHelp : QuestClass
{
    public WestbrookGarrisonNeedsHelp()
    {
        Name = "Westbrook Garrison Needs Help!";

        QuestId.AddRange(new[] { 239 });

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


public sealed class WestfallStew : QuestClass
{
    public WestfallStew()
    {
        Name = "Westfall Stew";

        QuestId.AddRange(new[] { 36 });

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


public sealed class WestfallStew21 : QuestGrinderClass
{
    public WestfallStew21()
    {
        Name = "Westfall Stew 2 1";

        QuestId.AddRange(new[] { 38 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(199);
EntryTarget.Add(1109);
HotSpots.Add(new Vector3(-10047.4 , 1182.311 , 39.45678 , "None"));
HotSpots.Add(new Vector3(-9976.965 , 1287.108 , 43.93761 , "None"));
HotSpots.Add(new Vector3(-10047.3 , 1324.433 , 44.33318 , "None"));
HotSpots.Add(new Vector3(-10079.71 , 1404.478 , 44.08891 , "None"));
HotSpots.Add(new Vector3(-10187.02 , 1514.439 , 43.08158 , "None"));
HotSpots.Add(new Vector3(-10301.99 , 1636.546 , 44.1793 , "None"));
HotSpots.Add(new Vector3(-10361.55 , 1775.162 , 35.5318 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(729) >= 3;
}






}


public sealed class WestfallStew22 : QuestGrinderClass
{
    public WestfallStew22()
    {
        Name = "Westfall Stew 2 2";

        QuestId.AddRange(new[] { 38 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(515);
EntryTarget.Add(126);
HotSpots.Add(new Vector3(-9641.685 , 1188.967 , 6.901905 , "None"));
HotSpots.Add(new Vector3(-9609.431 , 1162.662 , 2.405972 , "None"));
HotSpots.Add(new Vector3(-9627.599 , 1123.171 , 2.761538 , "None"));
HotSpots.Add(new Vector3(-9623.379 , 1358.47 , 4.386265 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(730) >= 3;
}






}


public sealed class WestfallStew23 : QuestGrinderClass
{
    public WestfallStew23()
    {
        Name = "Westfall Stew 2 3";

        QuestId.AddRange(new[] { 38 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(454);
EntryTarget.Add(157);
HotSpots.Add(new Vector3(-10084.66 , 1249.155 , 39.39725 , "None"));
HotSpots.Add(new Vector3(-10111.71 , 1467.671 , 41.66559 , "None"));
HotSpots.Add(new Vector3(-10060.01 , 1517.78 , 47.07253 , "None"));
HotSpots.Add(new Vector3(-10357.25 , 1692.416 , 36.51793 , "None"));
HotSpots.Add(new Vector3(-10153.05 , 910.9261 , 38.93478 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(731) >= 3;
}






}


public sealed class WestfallStew24 : QuestGrinderClass
{
    public WestfallStew24()
    {
        Name = "Westfall Stew 2 4";

        QuestId.AddRange(new[] { 38 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(480);
HotSpots.Add(new Vector3(-9978.676 , 1148.072 , 43.32422 , "None"));
HotSpots.Add(new Vector3(-10171.68 , 1276.32 , 37.07275 , "None"));
HotSpots.Add(new Vector3(-10473.35 , 1764.972 , 35.36771 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(732) >= 3;
}






}


public sealed class WolvesAcrosstheBorder : QuestGrinderClass
{
    public WolvesAcrosstheBorder()
    {
        Name = "Wolves Across the Border";

        QuestId.AddRange(new[] { 33 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(299);
HotSpots.Add(new Vector3(-8858 , -132.429 , 81.21887 , "None"));
HotSpots.Add(new Vector3(-8863.379 , -68.6726 , 85.25532 , "None"));
HotSpots.Add(new Vector3(-8918.563 , -73.67161 , 88.3206 , "None"));
HotSpots.Add(new Vector3(-8959.145 , -47.76953 , 91.73681 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class YoungLovers : QuestClass
{
    public YoungLovers()
    {
        Name = "Young Lovers";

        QuestId.AddRange(new[] { 106 });

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
