
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
HotSpots.Add(new Vector3(-9847.958 , 1289.561 , 41.88807 , "None"));

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
HotSpots.Add(new Vector3(-9844.76 , 1024.659 , 33.07675 , "None"));
HotSpots.Add(new Vector3(-9865.708 , 1270.898 , 40.93409 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WestfallStew : QuestInteractWithClass
{
    public WestfallStew()
    {
        Name = "Westfall Stew";

        QuestId.AddRange(new[] { 36 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(235);
HotSpots.Add(new Vector3(-10112.1 , 1042.1 , 37.47142 , "None"));
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


public sealed class GoretuskLiverPie : QuestGrinderClass
{
    public GoretuskLiverPie()
    {
        Name = "Goretusk Liver Pie";

        QuestId.AddRange(new[] { 22 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(454);
HotSpots.Add(new Vector3(-10183.34 , 911.3032 , 37.99134 , "None"));
HotSpots.Add(new Vector3(-10103.83 , 900.1684 , 36.49719 , "None"));
HotSpots.Add(new Vector3(-10047.79 , 849.438 , 33.66676 , "None"));
HotSpots.Add(new Vector3(-9959.258 , 817.7745 , 33.66861 , "None"));
HotSpots.Add(new Vector3(-9718.582 , 957.3962 , 34.17479 , "None"));
HotSpots.Add(new Vector3(-9690.059 , 974.6022 , 36.95388 , "None"));
HotSpots.Add(new Vector3(-10391.37 , 1048.376 , 36.92416 , "None"));

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
HotSpots.Add(new Vector3(-10150.51 , 1115.193 , 36.77108 , "None"));
HotSpots.Add(new Vector3(-10139.29 , 1097.805 , 36.32685 , "None"));
HotSpots.Add(new Vector3(-10185.75 , 1152.214 , 36.75488 , "None"));
HotSpots.Add(new Vector3(-10185.11 , 1152.079 , 36.75632 , "None"));
HotSpots.Add(new Vector3(-10113.69 , 1154.507 , 36.3263 , "None"));
HotSpots.Add(new Vector3(-10188.23 , 1080.354 , 36.57059 , "None"));
HotSpots.Add(new Vector3(-10219.53 , 1373.642 , 39.65617 , "None"));
HotSpots.Add(new Vector3(-10177.05 , 1440.91 , 40.58904 , "None"));
HotSpots.Add(new Vector3(-10221.2 , 1484.355 , 41.45509 , "None"));
HotSpots.Add(new Vector3(-10252.34 , 1483.207 , 40.59826 , "None"));
HotSpots.Add(new Vector3(-10238.83 , 1510.445 , 40.38154 , "None"));
HotSpots.Add(new Vector3(-10287.6 , 1451.867 , 40.06758 , "None"));
HotSpots.Add(new Vector3(-10246.17 , 1407.291 , 40.6557 , "None"));
HotSpots.Add(new Vector3(-10221.09 , 1375.386 , 39.71345 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheDefiasBrotherhood : QuestInteractWithClass
{
    public TheDefiasBrotherhood()
    {
        Name = "The Defias Brotherhood";

        QuestId.AddRange(new[] { 65 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

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


public sealed class ThePeoplesMilitia : QuestGrinderClass
{
    public ThePeoplesMilitia()
    {
        Name = "The People&#039;s Militia";

        QuestId.AddRange(new[] { 12 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(95);
HotSpots.Add(new Vector3(-10352.5 , 1255.29 , 40.92291 , "None"));
HotSpots.Add(new Vector3(-10343.6 , 1223.4 , 40.11631 , "None"));
HotSpots.Add(new Vector3(-10343.6 , 1223.4 , 40.11631 , "None"));
HotSpots.Add(new Vector3(-10335.1 , 1239.62 , 39.30665 , "None"));
HotSpots.Add(new Vector3(-10455.23 , 1315.052 , 45.20005 , "None"));
HotSpots.Add(new Vector3(-10469.8 , 1345.15 , 45.60867 , "None"));
HotSpots.Add(new Vector3(-10477.5 , 1366.4 , 51.17028 , "None"));
HotSpots.Add(new Vector3(-10516.93 , 1316.209 , 47.1279 , "None"));

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

        EntryTarget.Add(123);
EntryTarget.Add(500);
HotSpots.Add(new Vector3(-10195.7 , 1704.38 , 34.21137 , "None"));
HotSpots.Add(new Vector3(-10145.6 , 1652.06 , 38.02856 , "None"));
HotSpots.Add(new Vector3(-10175.55 , 1612.278 , 44.91568 , "None"));
HotSpots.Add(new Vector3(-10066.1 , 1681.58 , 34.50004 , "None"));
HotSpots.Add(new Vector3(-10056.08 , 1722.532 , 38.4949 , "None"));
HotSpots.Add(new Vector3(-9914.023 , 1589.696 , 41.75609 , "None"));

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

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(95);
EntryTarget.Add(504);
EntryTarget.Add(589);
EntryTarget.Add(590);
HotSpots.Add(new Vector3(-10452.87 , 1316.585 , 44.8034 , "None"));
HotSpots.Add(new Vector3(-10456.98 , 1317.775 , 45.21435 , "None"));
HotSpots.Add(new Vector3(-10487.5 , 1328.78 , 42.57557 , "None"));
HotSpots.Add(new Vector3(-10508.69 , 1318.191 , 44.37765 , "None"));
HotSpots.Add(new Vector3(-10477.5 , 1366.4 , 51.16853 , "None"));
HotSpots.Add(new Vector3(-10411.8 , 1346.22 , 55.25347 , "None"));
HotSpots.Add(new Vector3(-10645 , 1385.82 , 41.5794 , "None"));
HotSpots.Add(new Vector3(-10669.14 , 1714.864 , 41.26048 , "None"));
HotSpots.Add(new Vector3(-10703.78 , 1720.896 , 42.35429 , "None"));
HotSpots.Add(new Vector3(-10692.72 , 1744.963 , 41.31654 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThePeoplesMilitiapt2 : QuestGrinderClass
{
    public ThePeoplesMilitiapt2()
    {
        Name = "The People&#039;s Militia pt2";

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

        EntryTarget.Add(589);
EntryTarget.Add(590);
HotSpots.Add(new Vector3(-10726.51 , 1658.49 , 43.90334 , "None"));
HotSpots.Add(new Vector3(-10737.96 , 1689.575 , 46.09823 , "None"));
HotSpots.Add(new Vector3(-10752.86 , 1714.286 , 42.82014 , "None"));
HotSpots.Add(new Vector3(-10703.63 , 1721.525 , 42.32072 , "None"));
HotSpots.Add(new Vector3(-10672.88 , 1712.672 , 41.71187 , "None"));
HotSpots.Add(new Vector3(-10638.7 , 1755.37 , 38.24504 , "None"));
HotSpots.Add(new Vector3(-10991.61 , 1510.982 , 43.42539 , "None"));
HotSpots.Add(new Vector3(-10933.66 , 1461.807 , 48.74645 , "None"));
HotSpots.Add(new Vector3(-10960.5 , 1420.412 , 43.05785 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThePeoplesMilitiapt3 : QuestGrinderClass
{
    public ThePeoplesMilitiapt3()
    {
        Name = "The People&#039;s Militia pt3";

        QuestId.AddRange(new[] { 14 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(122);
EntryTarget.Add(121);
EntryTarget.Add(449);
HotSpots.Add(new Vector3(-11097.58 , 1195.298 , 58.80698 , "None"));
HotSpots.Add(new Vector3(-11116.18 , 1170.808 , 60.34309 , "None"));
HotSpots.Add(new Vector3(-11120.84 , 1177.498 , 62.20356 , "None"));
HotSpots.Add(new Vector3(-11156.1 , 1191.27 , 75.24882 , "None"));
HotSpots.Add(new Vector3(-11154.3 , 1224.8 , 78.59726 , "None"));
HotSpots.Add(new Vector3(-11200.25 , 1207.99 , 87.37321 , "None"));
HotSpots.Add(new Vector3(-11224.44 , 1208.704 , 89.46622 , "None"));
HotSpots.Add(new Vector3(-11237.6 , 1249.72 , 89.57973 , "None"));
HotSpots.Add(new Vector3(-11189.38 , 1288.376 , 88.97551 , "None"));
HotSpots.Add(new Vector3(-11241.15 , 1292.719 , 90.24736 , "None"));
HotSpots.Add(new Vector3(-11201.11 , 1330.715 , 89.22559 , "None"));
HotSpots.Add(new Vector3(-11226.36 , 1393.171 , 89.0518 , "None"));
HotSpots.Add(new Vector3(-11248.1 , 1400.41 , 89.42569 , "None"));
HotSpots.Add(new Vector3(-11261.09 , 1501.237 , 82.67162 , "None"));
HotSpots.Add(new Vector3(-11274.72 , 1550.844 , 73.34754 , "None"));
HotSpots.Add(new Vector3(-11255.89 , 1583.141 , 66.13631 , "None"));
HotSpots.Add(new Vector3(-11249.71 , 1649.819 , 50.8035 , "None"));
HotSpots.Add(new Vector3(-11277.89 , 1675.265 , 47.44301 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThunderbrewLager : QuestGrinderClass
{
    public ThunderbrewLager()
    {
        Name = "Thunderbrew Lager";

        QuestId.AddRange(new[] { 117 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(115);
HotSpots.Add(new Vector3(-10845.72 , 860.8074 , 32.89604 , "None"));
HotSpots.Add(new Vector3(-10779.23 , 836.4747 , 32.98218 , "None"));
HotSpots.Add(new Vector3(-10841.04 , 786.2244 , 33.07214 , "None"));
HotSpots.Add(new Vector3(-10808.64 , 738.1918 , 35.38666 , "None"));
HotSpots.Add(new Vector3(-10847.26 , 723.2197 , 33.55754 , "None"));
HotSpots.Add(new Vector3(-10742.52 , 810.2625 , 33.34637 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GrindTo15 : QuestGrinderClass
{
    public GrindTo15()
    {
        Name = "GrindTo15";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 15;
        RequiredQuest = 0;

        EntryTarget.Add(1109);
EntryTarget.Add(454);
EntryTarget.Add(95);
EntryTarget.Add(504);
EntryTarget.Add(114);
EntryTarget.Add(157);
HotSpots.Add(new Vector3(-10488.16 , 923.7827 , 37.75411 , "None"));
HotSpots.Add(new Vector3(-10392.12 , 1048.684 , 37.21747 , "None"));
HotSpots.Add(new Vector3(-10315.39 , 1021.095 , 41.43914 , "None"));
HotSpots.Add(new Vector3(-10329.42 , 1112.294 , 37.37463 , "None"));
HotSpots.Add(new Vector3(-10360.8 , 1193.547 , 40.22166 , "None"));
HotSpots.Add(new Vector3(-10452.34 , 1320.166 , 44.37298 , "None"));
HotSpots.Add(new Vector3(-10330.4 , 1321.991 , 55.56489 , "None"));
HotSpots.Add(new Vector3(-10231.92 , 1300.763 , 38.52056 , "None"));
HotSpots.Add(new Vector3(-10186.05 , 1337.527 , 37.97929 , "None"));
HotSpots.Add(new Vector3(-10174.26 , 1419.285 , 40.02431 , "None"));
HotSpots.Add(new Vector3(-10288.92 , 1451.155 , 40.06844 , "None"));
HotSpots.Add(new Vector3(-10301.68 , 1550.46 , 41.64046 , "None"));
HotSpots.Add(new Vector3(-10323.2 , 1586.112 , 40.88516 , "None"));
HotSpots.Add(new Vector3(-10376.36 , 1639.96 , 34.25779 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GrindTo17 : QuestGrinderClass
{
    public GrindTo17()
    {
        Name = "GrindTo17";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 15;
        MaxLevel = 17;
        RequiredQuest = 0;

        EntryTarget.Add(114);
EntryTarget.Add(1109);
EntryTarget.Add(157);
EntryTarget.Add(36);
EntryTarget.Add(547);
EntryTarget.Add(154);
EntryTarget.Add(115);
HotSpots.Add(new Vector3(-10515.35 , 1689.448 , 40.075 , "None"));
HotSpots.Add(new Vector3(-10589.08 , 1680.886 , 40.76252 , "None"));
HotSpots.Add(new Vector3(-10622.73 , 1710.53 , 41.25042 , "None"));
HotSpots.Add(new Vector3(-10683.44 , 1657.897 , 42.35761 , "None"));
HotSpots.Add(new Vector3(-10781.36 , 1611.389 , 40.91926 , "None"));
HotSpots.Add(new Vector3(-10848.6 , 1483.887 , 45.37563 , "None"));
HotSpots.Add(new Vector3(-10888.08 , 1415.08 , 44.54685 , "None"));
HotSpots.Add(new Vector3(-10960.58 , 1359.749 , 47.02367 , "None"));
HotSpots.Add(new Vector3(-10986.53 , 1367.031 , 44.5438 , "None"));
HotSpots.Add(new Vector3(-11012.29 , 1387.113 , 45.87497 , "None"));
HotSpots.Add(new Vector3(-10998.51 , 1271.265 , 42.27288 , "None"));
HotSpots.Add(new Vector3(-10969.27 , 1207.439 , 43.17428 , "None"));
HotSpots.Add(new Vector3(-10992.16 , 1110.679 , 39.31157 , "None"));
HotSpots.Add(new Vector3(-10890.54 , 1056.825 , 36.30532 , "None"));
HotSpots.Add(new Vector3(-10828.16 , 1069.049 , 38.32114 , "None"));
HotSpots.Add(new Vector3(-10779.87 , 1009.351 , 32.94122 , "None"));
HotSpots.Add(new Vector3(-10790.17 , 947.1559 , 37.30331 , "None"));
HotSpots.Add(new Vector3(-10817.66 , 879.069 , 33.16457 , "None"));
HotSpots.Add(new Vector3(-10831.16 , 791.8978 , 33.02907 , "None"));
HotSpots.Add(new Vector3(-10842.77 , 757.9647 , 33.21344 , "None"));
HotSpots.Add(new Vector3(-10689.38 , 787.3898 , 46.89841 , "None"));
HotSpots.Add(new Vector3(-10693.8 , 775.9686 , 48.11762 , "None"));
HotSpots.Add(new Vector3(-10680.18 , 880.603 , 37.31952 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WestfallStew0 : QuestClass
{
    public WestfallStew0()
    {
        Name = "Westfall Stew0";

        QuestId.AddRange(new[] { 38 });

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


public sealed class WestfallStew1 : QuestGrinderClass
{
    public WestfallStew1()
    {
        Name = "Westfall Stew1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 3, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(1109);
EntryTarget.Add(154);
EntryTarget.Add(199);
HotSpots.Add(new Vector3(-10417.15 , 892.0065 , 44.62105 , "None"));
HotSpots.Add(new Vector3(-10545.54 , 849.6614 , 44.74687 , "None"));
HotSpots.Add(new Vector3(-10329.97 , 919.5293 , 39.9232 , "None"));
HotSpots.Add(new Vector3(-10220.62 , 852.1533 , 37.88123 , "None"));
HotSpots.Add(new Vector3(-10154.4 , 918.7002 , 38.5203 , "None"));
HotSpots.Add(new Vector3(-10056.25 , 875.9561 , 34.77457 , "None"));
HotSpots.Add(new Vector3(-10046.52 , 1180.231 , 39.65502 , "None"));
HotSpots.Add(new Vector3(-10183.76 , 1511.288 , 42.96274 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(729) >= 3;
}



public override bool HasQuest() { return true; }


}


public sealed class WestfallStew2 : QuestGrinderClass
{
    public WestfallStew2()
    {
        Name = "Westfall Stew2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 3, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(513);
EntryTarget.Add(171);
HotSpots.Add(new Vector3(-9929.658 , 1804.965 , 9.982752 , "None"));
HotSpots.Add(new Vector3(-9908.63 , 1778.59 , 10.04818 , "None"));
HotSpots.Add(new Vector3(-9886.684 , 1793.458 , 5.576396 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(730) >= 3;
}



public override bool HasQuest() { return true; }


}


public sealed class WestfallStew3 : QuestGrinderClass
{
    public WestfallStew3()
    {
        Name = "Westfall Stew3";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 3, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(157);
EntryTarget.Add(454);
HotSpots.Add(new Vector3(-10450.39 , 870.4434 , 39.64291 , "None"));
HotSpots.Add(new Vector3(-10242.26 , 877.0225 , 38.50275 , "None"));
HotSpots.Add(new Vector3(-10150.57 , 915.1189 , 37.69305 , "None"));
HotSpots.Add(new Vector3(-10101.88 , 895.0771 , 35.72282 , "None"));
HotSpots.Add(new Vector3(-10053.39 , 851.2227 , 33.60761 , "None"));
HotSpots.Add(new Vector3(-10085.68 , 1244.128 , 38.50036 , "None"));
HotSpots.Add(new Vector3(-10151.22 , 1479.779 , 41.89686 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(731) >= 3;
}



public override bool HasQuest() { return true; }


}


public sealed class WestfallStew4 : QuestGrinderClass
{
    public WestfallStew4()
    {
        Name = "Westfall Stew4";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 3, 0 };

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
HotSpots.Add(new Vector3(-10115.12 , 1144.482 , 36.70754 , "None"));
HotSpots.Add(new Vector3(-10149.78 , 1306.621 , 38.95613 , "None"));
HotSpots.Add(new Vector3(-10187.77 , 1340.287 , 37.97555 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(732) >= 3;
}



public override bool HasQuest() { return true; }


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








}


public sealed class ASwiftMessage1 : QuestClass
{
    public ASwiftMessage1()
    {
        Name = "A Swift Message1";

        QuestId.AddRange(new[] { 6181 });

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


public sealed class ASwiftMessage2 : QuestClass
{
    public ASwiftMessage2()
    {
        Name = "A Swift Message2";

        QuestId.AddRange(new[] { 6281 });

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


public sealed class ASwiftMessage3 : QuestClass
{
    public ASwiftMessage3()
    {
        Name = "A Swift Message3";

        QuestId.AddRange(new[] { 6261 });

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


public sealed class ASwiftMessage4 : QuestClass
{
    public ASwiftMessage4()
    {
        Name = "A Swift Message4";

        QuestId.AddRange(new[] { 6285 });

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


public sealed class AWatchfulEye : QuestClass
{
    public AWatchfulEye()
    {
        Name = "A Watchful Eye";

        QuestId.AddRange(new[] { 94 });

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


public sealed class EncroachingGnolls : QuestClass
{
    public EncroachingGnolls()
    {
        Name = "Encroaching Gnolls";

        QuestId.AddRange(new[] { 244 });

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


public sealed class AssessingtheThreat : QuestGrinderClass
{
    public AssessingtheThreat()
    {
        Name = "Assessing the Threat";

        QuestId.AddRange(new[] { 246 });

        Step = new List<int> { 10, 6, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(423);
EntryTarget.Add(424);
HotSpots.Add(new Vector3(-9491.52 , -1933.311 , 78.63216 , "None"));
HotSpots.Add(new Vector3(-9445.73 , -1906.657 , 84.25474 , "None"));
HotSpots.Add(new Vector3(-9792.97 , -2219.13 , 58.62935 , "None"));
HotSpots.Add(new Vector3(-9750.783 , -2257.615 , 62.02866 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BlackrockBounty : QuestGrinderClass
{
    public BlackrockBounty()
    {
        Name = "Blackrock Bounty";

        QuestId.AddRange(new[] { 128 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

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


public sealed class TheCoastalMenace : QuestGrinderClass
{
    public TheCoastalMenace()
    {
        Name = "The Coastal Menace";

        QuestId.AddRange(new[] { 104 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(391);
HotSpots.Add(new Vector3(-11139.66 , 2003.434 , 7.947801 , "None"));
HotSpots.Add(new Vector3(-11347.63 , 1836.688 , 7.753009 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(3636) >= 1;
}






}


public sealed class TheCoastIsntClear : QuestGrinderClass
{
    public TheCoastIsntClear()
    {
        Name = "The Coast Isn't Clear";

        QuestId.AddRange(new[] { 152 });

        Step = new List<int> { 7, 7, 7, 7, 0 };

        StepAutoDetect = new[] { false, false, false, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(517);
EntryTarget.Add(127);
EntryTarget.Add(171);
EntryTarget.Add(126);
HotSpots.Add(new Vector3(-11340.18 , 1834.728 , 9.020456 , "None"));
HotSpots.Add(new Vector3(-11405.86 , 1802.699 , 6.351696 , "None"));
HotSpots.Add(new Vector3(-11165.7 , 2037.17 , 0.1786994 , "None"));
HotSpots.Add(new Vector3(-11038.67 , 2081.334 , 1.518207 , "None"));
HotSpots.Add(new Vector3(-10551.61 , 2104.031 , 3.724672 , "None"));
HotSpots.Add(new Vector3(-10309.29 , 2046.952 , 7.754663 , "None"));
HotSpots.Add(new Vector3(-10231.93 , 2004.401 , 12.34483 , "None"));
HotSpots.Add(new Vector3(-9610.28 , 1151.229 , 2.105826 , "None"));
HotSpots.Add(new Vector3(-9625.245 , 1359.245 , 4.863277 , "None"));

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

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(114);
HotSpots.Add(new Vector3(-10645.52 , 1684.241 , 42.02029 , "None"));
HotSpots.Add(new Vector3(-10619.94 , 1725.042 , 41.42428 , "None"));
HotSpots.Add(new Vector3(-10550.58 , 1650.653 , 41.46416 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}
