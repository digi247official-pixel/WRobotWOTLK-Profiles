
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



public sealed class andaBatchofOoze : QuestGrinderClass
{
    public andaBatchofOoze()
    {
        Name = "... and a Batch of Ooze";

        QuestId.AddRange(new[] { 4294 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(6556);
EntryTarget.Add(6559);
EntryTarget.Add(6557);
HotSpots.Add(new Vector3(-6878.623 , -1837.786 , -272.3317 , "None"));
HotSpots.Add(new Vector3(-6490.516 , -894.6382 , -274.1595 , "None"));
HotSpots.Add(new Vector3(-6818.506 , -697.4849 , -271.1538 , "None"));
HotSpots.Add(new Vector3(-6873.697 , -744.8174 , -272.539 , "None"));
HotSpots.Add(new Vector3(-6974.013 , -801.6385 , -271.9028 , "None"));
HotSpots.Add(new Vector3(-7105.545 , -675.6849 , -269.6873 , "None"));
HotSpots.Add(new Vector3(-7192.008 , -845.4004 , -270.5408 , "None"));
HotSpots.Add(new Vector3(-7545.603 , -995.7031 , -270.0639 , "None"));
HotSpots.Add(new Vector3(-7707.72 , -1171.22 , -271.2005 , "None"));
HotSpots.Add(new Vector3(-7709.5 , -1249.516 , -269.3934 , "None"));
HotSpots.Add(new Vector3(-7681.57 , -1615.472 , -271.7886 , "None"));
HotSpots.Add(new Vector3(-8013.351 , -1596.673 , -271.1738 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(12235) == 30;
}






}


public sealed class ALittleHelpFromMyFriends : QuestFollowPathClass
{
    public ALittleHelpFromMyFriends()
    {
        Name = "A Little Help From My Friends";

        QuestId.AddRange(new[] { 4491 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(-7202.764 , -1388.943 , -232.3584 , "None"));
Path.Add(new Vector3(-7210.22 , -1396.641 , -231.8425 , "None"));
Path.Add(new Vector3(-7217.537 , -1404.172 , -231.5132 , "None"));
Path.Add(new Vector3(-7226.423 , -1410.624 , -230.6878 , "None"));
Path.Add(new Vector3(-7234.991 , -1416.102 , -231.9974 , "None"));
Path.Add(new Vector3(-7244.934 , -1410.704 , -232.4401 , "None"));
Path.Add(new Vector3(-7254.866 , -1407.344 , -237.2355 , "None"));
Path.Add(new Vector3(-7263.665 , -1406.327 , -241.1586 , "None"));
Path.Add(new Vector3(-7273.986 , -1406.707 , -245.5362 , "None"));
Path.Add(new Vector3(-7280.986 , -1406.617 , -259.1221 , "None"));
Path.Add(new Vector3(-7291.47 , -1406.032 , -261.3676 , "None"));
Path.Add(new Vector3(-7306.38 , -1403.901 , -265.2263 , "None"));
Path.Add(new Vector3(-7323.806 , -1402.575 , -268.2133 , "None"));
Path.Add(new Vector3(-7341.29 , -1403.148 , -271.1309 , "None"));
Path.Add(new Vector3(-7358.376 , -1406.681 , -272.0531 , "None"));
Path.Add(new Vector3(-7375.207 , -1411.475 , -272.1152 , "None"));
Path.Add(new Vector3(-7385.664 , -1428.465 , -272.1152 , "None"));
Path.Add(new Vector3(-7388.696 , -1445.7 , -272.1167 , "None"));
Path.Add(new Vector3(-7391.174 , -1463.017 , -272.1167 , "None"));
Path.Add(new Vector3(-7392.146 , -1480.478 , -272.1165 , "None"));
Path.Add(new Vector3(-7391.377 , -1497.948 , -271.9564 , "None"));
Path.Add(new Vector3(-7388.357 , -1515.135 , -271.5531 , "None"));
Path.Add(new Vector3(-7382.939 , -1531.736 , -270.811 , "None"));
Path.Add(new Vector3(-7373.511 , -1546.432 , -270.7459 , "None"));
Path.Add(new Vector3(-7361.116 , -1558.685 , -272.2934 , "None"));
Path.Add(new Vector3(-7346.076 , -1567.622 , -272.34 , "None"));
Path.Add(new Vector3(-7329.321 , -1572.06 , -271.8134 , "None"));
Path.Add(new Vector3(-7311.875 , -1570.959 , -271.6241 , "None"));
Path.Add(new Vector3(-7294.428 , -1569.61 , -271.28 , "None"));
Path.Add(new Vector3(-7287.016 , -1582.541 , -271.3603 , "None"));
Path.Add(new Vector3(-7268.317 , -1594.708 , -272.0288 , "None"));
Path.Add(new Vector3(-7258.011 , -1601.695 , -271.4533 , "None"));
Path.Add(new Vector3(-7243.708 , -1605.315 , -269.8994 , "None"));
Path.Add(new Vector3(-7226.217 , -1605.436 , -263.8407 , "None"));
Path.Add(new Vector3(-7208.73 , -1604.833 , -265.0987 , "None"));
Path.Add(new Vector3(-7191.244 , -1604.149 , -264.9856 , "None"));
Path.Add(new Vector3(-7173.775 , -1604.995 , -264.2062 , "None"));
Path.Add(new Vector3(-7156.491 , -1607.687 , -269.589 , "None"));
Path.Add(new Vector3(-7144.116 , -1609.864 , -269.8559 , "None"));
Path.Add(new Vector3(-7126.881 , -1612.896 , -270.8081 , "None"));
Path.Add(new Vector3(-7109.646 , -1615.928 , -271.5232 , "None"));
Path.Add(new Vector3(-7092.366 , -1618.483 , -272.0881 , "None"));
Path.Add(new Vector3(-7074.886 , -1617.655 , -272.1843 , "None"));
Path.Add(new Vector3(-7057.405 , -1616.827 , -272.0899 , "None"));
Path.Add(new Vector3(-7039.925 , -1615.999 , -271.1907 , "None"));
Path.Add(new Vector3(-7008.81 , -1614.526 , -272.5072 , "None"));
Path.Add(new Vector3(-6981.949 , -1609.123 , -275.4464 , "Swimming"));
Path.Add(new Vector3(-6949.031 , -1606.374 , -271.1768 , "None"));
Path.Add(new Vector3(-6914.995 , -1598.515 , -272.5416 , "None"));
Path.Add(new Vector3(-6880.611 , -1591.977 , -272.0059 , "None"));
Path.Add(new Vector3(-6846.27 , -1585.534 , -271.2798 , "None"));
Path.Add(new Vector3(-6811.874 , -1579.112 , -271.3214 , "None"));
Path.Add(new Vector3(-6781.461 , -1562.571 , -271.4665 , "None"));
Path.Add(new Vector3(-6754 , -1540.872 , -272.2217 , "None"));
Path.Add(new Vector3(-6726.638 , -1519.153 , -272.111 , "None"));
Path.Add(new Vector3(-6699.272 , -1497.431 , -271.0924 , "None"));
Path.Add(new Vector3(-6671.858 , -1475.671 , -271.642 , "None"));
Path.Add(new Vector3(-6644.445 , -1453.911 , -272.2207 , "None"));
Path.Add(new Vector3(-6617.05 , -1432.166 , -268.4982 , "None"));
Path.Add(new Vector3(-6589.637 , -1410.406 , -271.2639 , "None"));
Path.Add(new Vector3(-6562.224 , -1388.646 , -272.1468 , "None"));
Path.Add(new Vector3(-6534.81 , -1366.885 , -272.222 , "None"));
Path.Add(new Vector3(-6507.441 , -1345.161 , -273.6648 , "None"));
Path.Add(new Vector3(-6480.028 , -1323.401 , -270.4403 , "None"));
Path.Add(new Vector3(-6452.255 , -1302.202 , -270.6668 , "None"));
Path.Add(new Vector3(-6419.056 , -1291.433 , -271.1375 , "None"));
Path.Add(new Vector3(-6388.555 , -1274.856 , -272.0319 , "None"));
Path.Add(new Vector3(-6360.667 , -1253.738 , -269.7716 , "None"));
Path.Add(new Vector3(-6338.805 , -1226.636 , -268.554 , "None"));
Path.Add(new Vector3(-6320.472 , -1198.479 , -274.8254 , "None"));
Path.Add(new Vector3(-6314.422 , -1189.578 , -271.4079 , "None"));
Path.Add(new Vector3(-6308.179 , -1181.136 , -269.5789 , "None"));
Path.Add(new Vector3(-6301.936 , -1172.693 , -268.7026 , "None"));
Path.Add(new Vector3(-6294.812 , -1164.981 , -261.8217 , "None"));
Path.Add(new Vector3(-6287.674 , -1157.28 , -256.6612 , "None"));
Path.Add(new Vector3(-6278.756 , -1151.93 , -251.4955 , "None"));
Path.Add(new Vector3(-6268.162 , -1146.548 , -246.1567 , "None"));
Path.Add(new Vector3(-6259.521 , -1140.583 , -241.9691 , "None"));
Path.Add(new Vector3(-6250.551 , -1135.146 , -237.9111 , "None"));
Path.Add(new Vector3(-6237.448 , -1127.886 , -231.0514 , "None"));
Path.Add(new Vector3(-6223.354 , -1122.01 , -225.456 , "None"));
Path.Add(new Vector3(-6206.95 , -1115.925 , -220.6243 , "None"));
Path.Add(new Vector3(-6197.211 , -1112.396 , -219.4863 , "None"));
Path.Add(new Vector3(-6181.254 , -1105.259 , -215.4511 , "None"));
Path.Add(new Vector3(-6173.154 , -1099.632 , -212.6452 , "None"));
Path.Add(new Vector3(-6164.664 , -1091.854 , -208.0115 , "None"));
Path.Add(new Vector3(-6156.934 , -1085.775 , -202.7391 , "None"));
Path.Add(new Vector3(-6148.156 , -1081.285 , -199.3272 , "None"));
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


public sealed class AlienEcology : QuestUseItemOnClass
{
    public AlienEcology()
    {
        Name = "Alien Ecology";

        QuestId.AddRange(new[] { 3883 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(-8072.068 , -1267.624 , -329.9602 , "None"));
ItemId = 11132;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(11131) == 1;
}






}


public sealed class BewareofPterrordax : QuestGrinderClass
{
    public BewareofPterrordax()
    {
        Name = "Beware of Pterrordax ";

        QuestId.AddRange(new[] { 4501 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(9167);
HotSpots.Add(new Vector3(-7088.771 , -882.7185 , -272.168 , "None"));
HotSpots.Add(new Vector3(-7121.482 , -953.8622 , -271.3428 , "None"));
HotSpots.Add(new Vector3(-7248.615 , -996.3753 , -271.3792 , "None"));
HotSpots.Add(new Vector3(-7084.01 , -486.2379 , -273.4729 , "None"));
HotSpots.Add(new Vector3(-6920.09 , -451.264 , -272.0367 , "None"));
HotSpots.Add(new Vector3(-7590.663 , -942.4107 , -265.6678 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BewareofPterrordaxother : QuestGrinderClass
{
    public BewareofPterrordaxother()
    {
        Name = "Beware of Pterrordax other";

        QuestId.AddRange(new[] { 4501 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(9166);
HotSpots.Add(new Vector3(-8181.42 , -1081.739 , -211.7383 , "None"));
HotSpots.Add(new Vector3(-8215.344 , -1053.62 , -193.2938 , "None"));
HotSpots.Add(new Vector3(-8254.626 , -1080.021 , -195.8861 , "None"));
HotSpots.Add(new Vector3(-8214.882 , -1565.021 , -215.6024 , "None"));
HotSpots.Add(new Vector3(-8246.38 , -1587.95 , -200.2236 , "None"));
HotSpots.Add(new Vector3(-7616.306 , -903.7736 , -268.752 , "None"));
HotSpots.Add(new Vector3(-7567.9 , -1063.836 , -268.2114 , "None"));
HotSpots.Add(new Vector3(-6849.995 , -979.8936 , -269.9596 , "None"));
HotSpots.Add(new Vector3(-6815.166 , -945.9131 , -269.8115 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BoneBladedWeapons : QuestGrinderClass
{
    public BoneBladedWeapons()
    {
        Name = "Bone-Bladed Weapons";

        QuestId.AddRange(new[] { 4300 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(6505);
EntryTarget.Add(6506);
HotSpots.Add(new Vector3(-7930.217 , -1620.249 , -272.0163 , "None"));
HotSpots.Add(new Vector3(-7901.567 , -1613.873 , -270.8637 , "None"));
HotSpots.Add(new Vector3(-7977.848 , -1679.737 , -269.6713 , "None"));
HotSpots.Add(new Vector3(-7988.628 , -1729.792 , -273.5133 , "None"));
HotSpots.Add(new Vector3(-7944.373 , -1781.96 , -273.9256 , "None"));
HotSpots.Add(new Vector3(-7848.92 , -1777.101 , -272.9651 , "None"));
HotSpots.Add(new Vector3(-7817.579 , -1651.047 , -270.6267 , "None"));
HotSpots.Add(new Vector3(-7646.795 , -1915.19 , -271.096 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BungleintheJungle : QuestGrinderClass
{
    public BungleintheJungle()
    {
        Name = "Bungle in the Jungle";

        QuestId.AddRange(new[] { 4496 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(6505);
EntryTarget.Add(6506);
HotSpots.Add(new Vector3(-7683.359 , -1708.894 , -270.8962 , "None"));
HotSpots.Add(new Vector3(-7748.686 , -1840.36 , -272.9149 , "None"));
HotSpots.Add(new Vector3(-7721.12 , -1937.29 , -270.819 , "None"));
HotSpots.Add(new Vector3(-7767.285 , -1967.162 , -272.3984 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BungleintheJungleother : QuestGrinderClass
{
    public BungleintheJungleother()
    {
        Name = "Bungle in the Jungle other";

        QuestId.AddRange(new[] { 4496 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(6552);
EntryTarget.Add(6553);
EntryTarget.Add(6551);
HotSpots.Add(new Vector3(-7944.165 , -1273.375 , -275.0854 , "None"));
HotSpots.Add(new Vector3(-7990.381 , -1188.78 , -273.9548 , "None"));
HotSpots.Add(new Vector3(-7985.909 , -1186.819 , -273.273 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ChasingAMe01 : QuestClass
{
    public ChasingAMe01()
    {
        Name = "Chasing A-Me 01";

        QuestId.AddRange(new[] { 4243 });

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


public sealed class CrystalsofPower : QuestGathererClass
{
    public CrystalsofPower()
    {
        Name = "Crystals of Power";

        QuestId.AddRange(new[] { 4284 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, true, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(164660);
EntryIdObjects.Add(164778);
EntryIdObjects.Add(164659);
EntryIdObjects.Add(164781);
HotSpots.Add(new Vector3(-6284.222 , -1217.699 , -265.857 , "None"));
HotSpots.Add(new Vector3(-6302.169 , -1374.685 , -267.69 , "None"));
HotSpots.Add(new Vector3(-6269.521 , -1557.963 , -228.3227 , "None"));
HotSpots.Add(new Vector3(-6467.519 , -1656.747 , -275.0268 , "None"));
HotSpots.Add(new Vector3(-6678.716 , -2021.697 , -270.8616 , "None"));
HotSpots.Add(new Vector3(-7122.437 , -2164.334 , -265.8948 , "None"));
HotSpots.Add(new Vector3(-7426.13 , -315.8448 , -218.9716 , "None"));
HotSpots.Add(new Vector3(-7823.183 , -1801.059 , -271.1656 , "None"));
HotSpots.Add(new Vector3(-7680.454 , -2039.114 , -271.5357 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DreadmaulRock : QuestClass
{
    public DreadmaulRock()
    {
        Name = "Dreadmaul Rock";

        QuestId.AddRange(new[] { 3821 });

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


public sealed class ExpeditionSalvation : QuestGathererClass
{
    public ExpeditionSalvation()
    {
        Name = "Expedition Salvation";

        QuestId.AddRange(new[] { 3881 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(161521);
HotSpots.Add(new Vector3(-7596.49 , -891.3494 , -271.8173 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ExpeditionSalvationother : QuestGathererClass
{
    public ExpeditionSalvationother()
    {
        Name = "Expedition Salvation other";

        QuestId.AddRange(new[] { 3881 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(161526);
HotSpots.Add(new Vector3(-6867.297 , -2001.508 , -272.2022 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class FindingtheSource : QuestUseItemOnClass
{
    public FindingtheSource()
    {
        Name = "Finding the Source";

        QuestId.AddRange(new[] { 974 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(148503);
HotSpots.Add(new Vector3(-7139.095 , -1469.434 , -241.6959 , "None"));
HotSpots.Add(new Vector3(-7094.848 , -1303.777 , -186.3378 , "None"));
HotSpots.Add(new Vector3(-7282.143 , -1242.664 , -246.0886 , "None"));
ItemId = 12472;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class getWhellidensJournal : QuestGrinderClass
{
    public getWhellidensJournal()
    {
        Name = "get Whe lliden&#039;s Journal";

        QuestId.AddRange(new[] { 3884 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(6505);
EntryTarget.Add(6506);
HotSpots.Add(new Vector3(-7804.337 , -1990.196 , -270.2715 , "None"));
HotSpots.Add(new Vector3(-7874.64 , -1919.958 , -271.4012 , "None"));
HotSpots.Add(new Vector3(-7877.54 , -1835.15 , -273.9003 , "None"));
HotSpots.Add(new Vector3(-7901.204 , -1815.278 , -272.8876 , "None"));
HotSpots.Add(new Vector3(-7837.387 , -1735.17 , -272.2227 , "None"));
HotSpots.Add(new Vector3(-7785.5 , -1687.807 , -271.1525 , "None"));
HotSpots.Add(new Vector3(-7813.672 , -1656.492 , -270.0899 , "None"));
HotSpots.Add(new Vector3(-7600.646 , -1801.167 , -264.1937 , "None"));
HotSpots.Add(new Vector3(-7583.06 , -1877.023 , -271.3915 , "None"));
HotSpots.Add(new Vector3(-7722.938 , -1875.099 , -272.2633 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(11116) == 1;
}



public override bool HasQuest() { return true; }


}


public sealed class ItsaSecrettoEverybody : QuestClass
{
    public ItsaSecrettoEverybody()
    {
        Name = "It&#039;s a Secret to Everybody";

        QuestId.AddRange(new[] { 3844 });

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


public sealed class ItsaSecrettoEverybodypt2 : QuestGathererClass
{
    public ItsaSecrettoEverybodypt2()
    {
        Name = "It&#039;s a Secret to Everybody pt2";

        QuestId.AddRange(new[] { 3845 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

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


public sealed class LarionandMuigin : QuestGrinderClass
{
    public LarionandMuigin()
    {
        Name = "Larion and Muigin";

        QuestId.AddRange(new[] { 4145 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, true, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(6509);
EntryTarget.Add(6511);
EntryTarget.Add(6510);
EntryTarget.Add(6512);
HotSpots.Add(new Vector3(-6618.624 , -1881.131 , -272.1777 , "None"));
HotSpots.Add(new Vector3(-6655.202 , -1892.779 , -270.8144 , "None"));
HotSpots.Add(new Vector3(-6614.74 , -1948.104 , -272.2214 , "None"));
HotSpots.Add(new Vector3(-6708.227 , -2000.568 , -269.9568 , "None"));
HotSpots.Add(new Vector3(-6753.212 , -2027.579 , -272.2226 , "None"));
HotSpots.Add(new Vector3(-6829.098 , -1952.855 , -271.7559 , "None"));
HotSpots.Add(new Vector3(-6919.73 , -1785.22 , -268.5539 , "None"));
HotSpots.Add(new Vector3(-6950.299 , -1698.146 , -272.007 , "None"));
HotSpots.Add(new Vector3(-7046.46 , -786.0594 , -271.697 , "None"));
HotSpots.Add(new Vector3(-7150.958 , -870.257 , -270.4341 , "None"));
HotSpots.Add(new Vector3(-7513.962 , -751.437 , -264.0129 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Lost : QuestClass
{
    public Lost()
    {
        Name = "Lost!";

        QuestId.AddRange(new[] { 4492 });

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


public sealed class MakingSenseofIt : QuestClass
{
    public MakingSenseofIt()
    {
        Name = "Making Sense of It";

        QuestId.AddRange(new[] { 4321 });

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
return ObjectManager.Me.Position.DistanceTo2D(new Vector3(-6033.25, -1017.56, -217.0732)) < 10;
}






}


public sealed class MarvonsWorkshop : QuestClass
{
    public MarvonsWorkshop()
    {
        Name = "Marvon&#039;s Workshop";

        QuestId.AddRange(new[] { 4147 });

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


public sealed class RolltheBones : QuestGrinderClass
{
    public RolltheBones()
    {
        Name = "Roll the Bones";

        QuestId.AddRange(new[] { 3882 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(9164);
HotSpots.Add(new Vector3(-7114.729 , -1052.506 , -272.166 , "None"));
HotSpots.Add(new Vector3(-7204.141 , -966.3083 , -271.9273 , "None"));
HotSpots.Add(new Vector3(-7060.465 , -527.3564 , -275.0105 , "None"));
HotSpots.Add(new Vector3(-7731.186 , -871.2676 , -269.8627 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ShizzlesFlyer : QuestGrinderClass
{
    public ShizzlesFlyer()
    {
        Name = "Shizzle&#039;s Flyer";

        QuestId.AddRange(new[] { 4503 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(9166);
EntryTarget.Add(9164);
HotSpots.Add(new Vector3(-8241.283 , -1592.573 , -199.1714 , "None"));
HotSpots.Add(new Vector3(-8022.875 , -925.7446 , -271.4833 , "None"));
HotSpots.Add(new Vector3(-8213.551 , -1053.75 , -193.7855 , "None"));
HotSpots.Add(new Vector3(-7782.543 , -1040.165 , -266.64 , "None"));
HotSpots.Add(new Vector3(-7588.981 , -940.5518 , -266.9229 , "None"));
HotSpots.Add(new Vector3(-7618.158 , -906.5993 , -268.2698 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SuperSticky : QuestGrinderClass
{
    public SuperSticky()
    {
        Name = "Super Sticky";

        QuestId.AddRange(new[] { 4504 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(6527);
EntryTarget.Add(6517);
EntryTarget.Add(6519);
EntryTarget.Add(6518);
HotSpots.Add(new Vector3(-6548.634 , -1814.996 , -273.6958 , "None"));
HotSpots.Add(new Vector3(-6545.255 , -1721.639 , -274.668 , "None"));
HotSpots.Add(new Vector3(-6585.999 , -1688.307 , -271.2819 , "None"));
HotSpots.Add(new Vector3(-6583.547 , -1685.437 , -270.844 , "None"));
HotSpots.Add(new Vector3(-6739.672 , -1649.277 , -277.1894 , "None"));
HotSpots.Add(new Vector3(-6551.272 , -1813.092 , -273.1083 , "None"));
HotSpots.Add(new Vector3(-6719.711 , -1682.625 , -272.7061 , "None"));
HotSpots.Add(new Vector3(-6341.363 , -1224.706 , -269.0012 , "None"));
HotSpots.Add(new Vector3(-6648.534 , -1378.381 , -276.1015 , "None"));
HotSpots.Add(new Vector3(-6585.937 , -1382.396 , -272.1327 , "None"));
HotSpots.Add(new Vector3(-6522.491 , -1320.454 , -272.2136 , "None"));
HotSpots.Add(new Vector3(-6418.663 , -1214.635 , -275.7009 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheApesofUnGoro : QuestGrinderClass
{
    public TheApesofUnGoro()
    {
        Name = "The Apes of Un&#039;Goro";

        QuestId.AddRange(new[] { 4289 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(6513);
EntryTarget.Add(6514);
EntryTarget.Add(6516);
HotSpots.Add(new Vector3(-6417.382 , -1745.684 , -272.5135 , "None"));
HotSpots.Add(new Vector3(-6391.644 , -1767.074 , -271.2676 , "None"));
HotSpots.Add(new Vector3(-6379.438 , -1810.11 , -265.5205 , "None"));
HotSpots.Add(new Vector3(-6376.35 , -1878.599 , -259.4296 , "None"));
HotSpots.Add(new Vector3(-6376.58 , -1970.12 , -257.1676 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheBaitforLarkorwi : QuestGrinderClass
{
    public TheBaitforLarkorwi()
    {
        Name = "The Bait for Lar&#039;korwi";

        QuestId.AddRange(new[] { 4292 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(9684);
HotSpots.Add(new Vector3(-7196.45 , -2405.63 , -217.2884 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheBaitforLarkorwigetitems : QuestUseItemOnClass
{
    public TheBaitforLarkorwigetitems()
    {
        Name = "The Bait for Lar&#039;korwi get items";

        QuestId.AddRange(new[] { 4292 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(-7193.697 , -2415.446 , -217.3635 , "None"));
ItemId = 11568;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(11568) == 0;
}






}


public sealed class TheBaitforLarkorwiusemeat : QuestUseItemOnClass
{
    public TheBaitforLarkorwiusemeat()
    {
        Name = "The Bait for Lar&#039;korwi use meat";

        QuestId.AddRange(new[] { 4292 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(169217);
HotSpots.Add(new Vector3(-7196.763 , -2424.449 , -216.8551 , "None"));
ItemId = 11569;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(11569) == 0;
}






}


public sealed class TheBaitforLarkorwiusemixture : QuestUseItemOnClass
{
    public TheBaitforLarkorwiusemixture()
    {
        Name = "The Bait for Lar&#039;korwi use mixture";

        QuestId.AddRange(new[] { 4292 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(169216);
HotSpots.Add(new Vector3(-7197.069 , -2423.806 , -216.9376 , "None"));
ItemId = 11570;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(11570) == 0;
}






}


public sealed class TheEasternPylon : QuestGathererClass
{
    public TheEasternPylon()
    {
        Name = "The Eastern Pylon";

        QuestId.AddRange(new[] { 4287 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(164957);
HotSpots.Add(new Vector3(-7199.432 , -2324.621 , -227.1989 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheFareofLarkorwi : QuestGathererClass
{
    public TheFareofLarkorwi()
    {
        Name = "The Fare of Lar&#039;korwi";

        QuestId.AddRange(new[] { 4290 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(166863);
HotSpots.Add(new Vector3(-7363.159 , -2007.923 , -269.3361 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheMightyUcha : QuestGrinderClass
{
    public TheMightyUcha()
    {
        Name = "The Mighty U&#039;cha";

        QuestId.AddRange(new[] { 4301 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(9622);
HotSpots.Add(new Vector3(-6276.53 , -1987.97 , -261.8678 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheNewSprings : QuestClass
{
    public TheNewSprings()
    {
        Name = "The New Springs";

        QuestId.AddRange(new[] { 980 });

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


public sealed class TheNorthernPylon : QuestGathererClass
{
    public TheNorthernPylon()
    {
        Name = "The Northern Pylon";

        QuestId.AddRange(new[] { 4285 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(164955);
HotSpots.Add(new Vector3(-6273.487 , -1556.734 , -230.7749 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheRiseoftheMachines : QuestGrinderClass
{
    public TheRiseoftheMachines()
    {
        Name = "The Rise of the Machines";

        QuestId.AddRange(new[] { 4061 });

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


public sealed class TheScentofLarkorwi : QuestGathererClass
{
    public TheScentofLarkorwi()
    {
        Name = "The Scent of Lar&#039;korwi";

        QuestId.AddRange(new[] { 4291 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(176231);
HotSpots.Add(new Vector3(-7768.486 , -1957.405 , -271.471 , "None"));
HotSpots.Add(new Vector3(-7510.258 , -1946.487 , -270.7359 , "None"));
HotSpots.Add(new Vector3(-7462.554 , -1957.399 , -272.5158 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheWesternPylon : QuestGathererClass
{
    public TheWesternPylon()
    {
        Name = "The Western Pylon";

        QuestId.AddRange(new[] { 4288 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(164956);
HotSpots.Add(new Vector3(-7426.103 , -346.9125 , -232.3692 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
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

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(11018) >= 20;
}






}


public sealed class VivianLagrave : QuestClass
{
    public VivianLagrave()
    {
        Name = "Vivian Lagrave";

        QuestId.AddRange(new[] { 4133 });

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


public sealed class VolcanicActivity : QuestGrinderClass
{
    public VolcanicActivity()
    {
        Name = "Volcanic Activity";

        QuestId.AddRange(new[] { 4502 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(6520);
EntryTarget.Add(14460);
EntryTarget.Add(6521);
HotSpots.Add(new Vector3(-7279.899 , -1218.804 , -240.4684 , "None"));
HotSpots.Add(new Vector3(-7296.813 , -1194.974 , -253.4336 , "None"));
HotSpots.Add(new Vector3(-7239.063 , -1158.738 , -252.7952 , "None"));
HotSpots.Add(new Vector3(-7298.759 , -1272.894 , -252.9381 , "None"));
HotSpots.Add(new Vector3(-7281.09 , -1316.369 , -240.621 , "None"));
HotSpots.Add(new Vector3(-7230.646 , -1445.53 , -231.2894 , "None"));
HotSpots.Add(new Vector3(-7094.891 , -1418.688 , -234.7438 , "None"));
HotSpots.Add(new Vector3(-7129.904 , -1347.921 , -194.4089 , "None"));
HotSpots.Add(new Vector3(-7108.97 , -1278.442 , -194.1645 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WillidensJournal : QuestGrinderClass
{
    public WillidensJournal()
    {
        Name = "Williden&#039;s Journal";

        QuestId.AddRange(new[] { 3884 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 11116;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(6514);
EntryTarget.Add(6517);
EntryTarget.Add(6511);
EntryTarget.Add(6556);
HotSpots.Add(new Vector3(-6375.294 , -1822.613 , -261.0093 , "None"));
HotSpots.Add(new Vector3(-6376.718 , -1815.14 , -262.4366 , "None"));
HotSpots.Add(new Vector3(-6530.191 , -1680.344 , -270.3608 , "None"));
HotSpots.Add(new Vector3(-6646.483 , -1717.862 , -272.2149 , "None"));
HotSpots.Add(new Vector3(-6592.53 , -1756.005 , -271.8378 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(11116) == 1;
}






}


public sealed class MuiginandLarion : QuestGrinderClass
{
    public MuiginandLarion()
    {
        Name = "Muigin and Larion";

        QuestId.AddRange(new[] { 4141 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(6512);
HotSpots.Add(new Vector3(-7396.877 , -392.003 , -270.1023 , "None"));
HotSpots.Add(new Vector3(-7263.867 , -385.3642 , -266.6478 , "None"));
HotSpots.Add(new Vector3(-7121.074 , -439.4641 , -271.209 , "None"));
HotSpots.Add(new Vector3(-7032.742 , -491.0777 , -275.2703 , "None"));
HotSpots.Add(new Vector3(-7058.64 , -571.233 , -272.7615 , "None"));
HotSpots.Add(new Vector3(-6972.095 , -591.2872 , -271.6378 , "None"));
HotSpots.Add(new Vector3(-6931.23 , -536.3455 , -272.1324 , "None"));
HotSpots.Add(new Vector3(-6850.51 , -737.748 , -271.4433 , "None"));
HotSpots.Add(new Vector3(-6818.404 , -821.4874 , -272.0414 , "None"));
HotSpots.Add(new Vector3(-6715.912 , -773.5166 , -271.6683 , "None"));
HotSpots.Add(new Vector3(-6735.416 , -615.4166 , -272.1458 , "None"));
HotSpots.Add(new Vector3(-6793.569 , -523.4948 , -270.2272 , "None"));
HotSpots.Add(new Vector3(-6936.708 , -535.2093 , -271.6569 , "None"));
HotSpots.Add(new Vector3(-7373.987 , -558.2896 , -275.435 , "None"));
HotSpots.Add(new Vector3(-7646.739 , -460.5458 , -269.9485 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ItsaSecrettoEverybodypt3 : QuestGrinderClass
{
    public ItsaSecrettoEverybodypt3()
    {
        Name = "It&#039;s a Secret to Everybody pt3";

        QuestId.AddRange(new[] { 3908 });

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


public sealed class MorrowgrainResearch : QuestClass
{
    public MorrowgrainResearch()
    {
        Name = "Morrowgrain Research";

        QuestId.AddRange(new[] { 3781 });

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
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(11103) == 1;
}






}


public sealed class MorrowgrainResearchpt2 : QuestGrinderClass
{
    public MorrowgrainResearchpt2()
    {
        Name = "Morrowgrain Research pt2";

        QuestId.AddRange(new[] { 3785 });

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


public sealed class MoontouchedWildkin : QuestGrinderClass
{
    public MoontouchedWildkin()
    {
        Name = "Moontouched Wildkin";

        QuestId.AddRange(new[] { 978 });

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


public sealed class gothoughportal : QuestFollowPathClass
{
    public gothoughportal()
    {
        Name = "go though portal";

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

        Path.Add(new Vector3(9944.149 , 2607.064 , 1316.238 , "None"));
Path.Add(new Vector3(9944.487 , 2610.097 , 1316.316 , "None"));
Path.Add(new Vector3(9944.621 , 2611.294 , 1316.313 , "None"));
Path.Add(new Vector3(9944.634 , 2611.405 , 1316.313 , "None"));
Path.Add(new Vector3(9944.863 , 2613.464 , 1316.274 , "None"));
Path.Add(new Vector3(9945.24 , 2616.838 , 1316.45 , "None"));
Path.Add(new Vector3(9945.24 , 2616.838 , 1316.45 , "None"));
Path.Add(new Vector3(9945.398 , 2618.25 , 1316.757 , "None"));
Path.Add(new Vector3(9945.57 , 2619.781 , 1317.12 , "None"));
Path.Add(new Vector3(8779.968 , 965.9459 , 30.27966 , "None"));
Path.Add(new Vector3(8776.552 , 965.1842 , 30.36445 , "None"));
Path.Add(new Vector3(8773.136 , 964.4225 , 30.29216 , "None"));
Path.Add(new Vector3(8753.363 , 960.0138 , 26.43205 , "None"));
Path.Add(new Vector3(8737.566 , 955.8237 , 21.39302 , "None"));
Path.Add(new Vector3(8706.902 , 939.0208 , 14.00029 , "None"));
Path.Add(new Vector3(8685.648 , 910.4335 , 20.00197 , "None"));
Path.Add(new Vector3(8681.479 , 896.0206 , 22.20263 , "None"));
Path.Add(new Vector3(8672.418 , 878.1046 , 22.0997 , "None"));
Path.Add(new Vector3(8650.621 , 859.167 , 22.43011 , "None"));
Path.Add(new Vector3(8642.742 , 858.3528 , 22.3152 , "None"));
Path.Add(new Vector3(8644 , 849.1912 , 22.87238 , "None"));
Path.Add(new Vector3(8645.041 , 845.6354 , 23.33428 , "None"));
Path.Add(new Vector3(8637.527 , 840.1329 , 26.87406 , "None"));
Path.Add(new Vector3(8625.33 , 837.8 , 30.97311 , "None"));
Path.Add(new Vector3(8609.333 , 835.0508 , 36.43077 , "None"));
Path.Add(new Vector3(8594.636 , 833.0179 , 41.77688 , "None"));
Path.Add(new Vector3(8583.964 , 831.1445 , 46.47163 , "None"));
Path.Add(new Vector3(8571.249 , 829.1893 , 51.90406 , "None"));
Path.Add(new Vector3(8555.784 , 827.7565 , 57.40472 , "None"));
Path.Add(new Vector3(8534.373 , 827.1328 , 63.29442 , "None"));
Path.Add(new Vector3(8521.927 , 827.1973 , 66.30257 , "None"));
Path.Add(new Vector3(8510.813 , 827.3331 , 69.1979 , "None"));
Path.Add(new Vector3(8499.262 , 827.5557 , 72.2804 , "None"));
Path.Add(new Vector3(8487.055 , 827.8821 , 75.47704 , "None"));
Path.Add(new Vector3(8473.98 , 828.3292 , 78.71479 , "None"));
Path.Add(new Vector3(8459.823 , 828.9138 , 81.92062 , "None"));
Path.Add(new Vector3(8444.368 , 829.6527 , 85.02149 , "None"));
Path.Add(new Vector3(8427.401 , 830.5629 , 87.94438 , "None"));
Path.Add(new Vector3(8408.708 , 831.6612 , 90.61626 , "None"));
Path.Add(new Vector3(8388.074 , 832.9645 , 92.9641 , "None"));
Path.Add(new Vector3(8365.284 , 834.4897 , 94.91489 , "None"));
Path.Add(new Vector3(8350.212 , 835.5568 , 95.8774 , "None"));
Path.Add(new Vector3(8338.094 , 836.4891 , 96.48994 , "None"));
Path.Add(new Vector3(8324.885 , 837.5643 , 97.03251 , "None"));
Path.Add(new Vector3(8311.009 , 838.7427 , 97.49173 , "None"));
Path.Add(new Vector3(8296.083 , 840.0515 , 97.8849 , "None"));
Path.Add(new Vector3(8281.499 , 841.3602 , 98.18789 , "None"));
Path.Add(new Vector3(8265.513 , 842.8176 , 98.4454 , "None"));
Path.Add(new Vector3(8250.044 , 844.2423 , 98.63414 , "None"));
Path.Add(new Vector3(8233.738 , 845.7518 , 98.78097 , "None"));
Path.Add(new Vector3(8217.127 , 847.2902 , 98.88621 , "None"));
Path.Add(new Vector3(8200.271 , 848.8452 , 98.95683 , "None"));
Path.Add(new Vector3(8183.228 , 850.4045 , 98.99982 , "None"));
Path.Add(new Vector3(8166.061 , 851.9556 , 99.0221 , "None"));
Path.Add(new Vector3(8148.829 , 853.4862 , 99.03065 , "None"));
Path.Add(new Vector3(8131.593 , 854.9839 , 99.03248 , "None"));
Path.Add(new Vector3(8114.411 , 856.4362 , 99.03448 , "None"));
Path.Add(new Vector3(8097.346 , 857.8307 , 99.04366 , "None"));
Path.Add(new Vector3(8080.456 , 859.1552 , 99.06699 , "None"));
Path.Add(new Vector3(8063.307 , 860.4329 , 99.11314 , "None"));
Path.Add(new Vector3(8047.445 , 861.5442 , 99.1839 , "None"));
Path.Add(new Vector3(8030.969 , 862.6134 , 99.29524 , "None"));
Path.Add(new Vector3(8015.859 , 863.504 , 99.44093 , "None"));
Path.Add(new Vector3(8000.306 , 864.3135 , 99.64616 , "None"));
Path.Add(new Vector3(7986.127 , 864.9377 , 99.89483 , "None"));
Path.Add(new Vector3(7968.417 , 865.6645 , 100.2733 , "None"));
Path.Add(new Vector3(7952.218 , 866.3536 , 100.6644 , "None"));
Path.Add(new Vector3(7935.948 , 867.0521 , 101.0984 , "None"));
Path.Add(new Vector3(7920.058 , 867.7218 , 101.5592 , "None"));
Path.Add(new Vector3(7904.027 , 868.3635 , 102.0572 , "None"));
Path.Add(new Vector3(7889.185 , 868.9067 , 102.5436 , "None"));
Path.Add(new Vector3(7873.634 , 869.4009 , 103.0738 , "None"));
Path.Add(new Vector3(7859.133 , 869.7723 , 103.5818 , "None"));
Path.Add(new Vector3(7843.825 , 870.0492 , 104.1258 , "None"));
Path.Add(new Vector3(7829.439 , 870.1829 , 104.6382 , "None"));
Path.Add(new Vector3(7814.582 , 870.1749 , 105.1621 , "None"));
Path.Add(new Vector3(7799.64 , 870.0024 , 105.677 , "None"));
Path.Add(new Vector3(7784.555 , 869.6482 , 106.1787 , "None"));
Path.Add(new Vector3(7769.271 , 869.0952 , 106.6626 , "None"));
Path.Add(new Vector3(7753.728 , 868.3267 , 107.1243 , "None"));
Path.Add(new Vector3(7737.868 , 867.3254 , 107.5593 , "None"));
Path.Add(new Vector3(7721.634 , 866.0745 , 107.9631 , "None"));
Path.Add(new Vector3(7704.968 , 864.5571 , 108.3313 , "None"));
Path.Add(new Vector3(7687.813 , 862.756 , 108.6595 , "None"));
Path.Add(new Vector3(7672.357 , 860.9223 , 108.9179 , "None"));
Path.Add(new Vector3(7658.019 , 859.0042 , 109.1601 , "None"));
Path.Add(new Vector3(7643.348 , 856.8463 , 109.4125 , "None"));
Path.Add(new Vector3(7628.375 , 854.4666 , 109.6718 , "None"));
Path.Add(new Vector3(7613.134 , 851.8825 , 109.9348 , "None"));
Path.Add(new Vector3(7597.655 , 849.1116 , 110.1984 , "None"));
Path.Add(new Vector3(7581.971 , 846.1716 , 110.4593 , "None"));
Path.Add(new Vector3(7566.113 , 843.0803 , 110.7145 , "None"));
Path.Add(new Vector3(7550.114 , 839.8552 , 110.9606 , "None"));
Path.Add(new Vector3(7533.52 , 836.4121 , 111.2014 , "None"));
Path.Add(new Vector3(7517.818 , 833.0742 , 111.4133 , "None"));
Path.Add(new Vector3(7501.585 , 829.5536 , 111.6134 , "None"));
Path.Add(new Vector3(7485.338 , 825.9699 , 111.7918 , "None"));
Path.Add(new Vector3(7469.109 , 822.3406 , 111.9454 , "None"));
Path.Add(new Vector3(7452.931 , 818.6833 , 112.0708 , "None"));
Path.Add(new Vector3(7436.834 , 815.0159 , 112.1651 , "None"));
Path.Add(new Vector3(7420.851 , 811.3558 , 112.2248 , "None"));
Path.Add(new Vector3(7405.013 , 807.7207 , 112.247 , "None"));
Path.Add(new Vector3(7389.851 , 804.2425 , 112.2297 , "None"));
Path.Add(new Vector3(7373.902 , 800.5963 , 112.1658 , "None"));
Path.Add(new Vector3(7358.692 , 797.1422 , 112.0561 , "None"));
Path.Add(new Vector3(7343.756 , 793.7838 , 111.896 , "None"));
Path.Add(new Vector3(7329.125 , 790.5385 , 111.6824 , "None"));
Path.Add(new Vector3(7314.408 , 787.333 , 111.4031 , "None"));
Path.Add(new Vector3(7300.876 , 784.452 , 111.0812 , "None"));
Path.Add(new Vector3(7283.176 , 780.4987 , 110.5271 , "None"));
Path.Add(new Vector3(7267.019 , 776.5103 , 109.8686 , "None"));
Path.Add(new Vector3(7250.829 , 772.1848 , 109.0658 , "None"));
Path.Add(new Vector3(7235.057 , 767.699 , 108.1518 , "None"));
Path.Add(new Vector3(7219.645 , 763.1094 , 107.1416 , "None"));
Path.Add(new Vector3(7204.54 , 758.4731 , 106.0502 , "None"));
Path.Add(new Vector3(7189.683 , 753.8472 , 104.8925 , "None"));
Path.Add(new Vector3(7175.02 , 749.2882 , 103.6834 , "None"));
Path.Add(new Vector3(7160.495 , 744.8534 , 102.4379 , "None"));
Path.Add(new Vector3(7146.051 , 740.5994 , 101.1708 , "None"));
Path.Add(new Vector3(7131.633 , 736.5834 , 99.89713 , "None"));
Path.Add(new Vector3(7117.185 , 732.8619 , 98.63183 , "None"));
Path.Add(new Vector3(7102.212 , 729.3972 , 97.35308 , "None"));
Path.Add(new Vector3(7087.972 , 726.5311 , 96.18605 , "None"));
Path.Add(new Vector3(7073.097 , 724.0354 , 95.03542 , "None"));
Path.Add(new Vector3(7057.967 , 722.062 , 93.95291 , "None"));
Path.Add(new Vector3(7042.058 , 720.6357 , 92.92487 , "None"));
Path.Add(new Vector3(7026.72 , 719.91 , 92.05187 , "None"));
Path.Add(new Vector3(7010.492 , 719.8451 , 91.26324 , "None"));
Path.Add(new Vector3(6995.554 , 720.5704 , 90.66532 , "None"));
Path.Add(new Vector3(6980.875 , 722.3799 , 90.18844 , "None"));
Path.Add(new Vector3(6965.721 , 725.1994 , 89.78918 , "None"));
Path.Add(new Vector3(6950.154 , 728.9068 , 89.45883 , "None"));
Path.Add(new Vector3(6934.239 , 733.3803 , 89.18864 , "None"));
Path.Add(new Vector3(6917.551 , 738.6598 , 88.96405 , "None"));
Path.Add(new Vector3(6901.622 , 744.1368 , 88.79391 , "None"));
Path.Add(new Vector3(6885.047 , 750.1758 , 88.65192 , "None"));
Path.Add(new Vector3(6868.381 , 756.4926 , 88.5352 , "None"));
Path.Add(new Vector3(6851.687 , 762.9651 , 88.43505 , "None"));
Path.Add(new Vector3(6835.028 , 769.4713 , 88.34273 , "None"));
Path.Add(new Vector3(6817.976 , 776.079 , 88.2466 , "None"));
Path.Add(new Vector3(6802.076 , 782.0965 , 88.14669 , "None"));
Path.Add(new Vector3(6785.911 , 787.9715 , 88.02552 , "None"));
Path.Add(new Vector3(6770.038 , 793.392 , 87.8773 , "None"));
Path.Add(new Vector3(6754.521 , 798.2361 , 87.69329 , "None"));
Path.Add(new Vector3(6739.424 , 802.3815 , 87.46476 , "None"));
Path.Add(new Vector3(6724.382 , 805.7922 , 87.17364 , "None"));
Path.Add(new Vector3(6710.748 , 808.0886 , 86.8393 , "None"));
Path.Add(new Vector3(6697.297 , 809.4061 , 86.42492 , "None"));
Path.Add(new Vector3(6684.522 , 809.5369 , 85.93114 , "None"));
Path.Add(new Vector3(6672.488 , 808.3588 , 85.34921 , "None"));
Path.Add(new Vector3(6661.259 , 805.7501 , 84.67044 , "None"));
Path.Add(new Vector3(6649.048 , 800.6903 , 83.74405 , "None"));
Path.Add(new Vector3(6637.401 , 793.2836 , 82.66016 , "None"));
Path.Add(new Vector3(6626.342 , 783.5768 , 81.42149 , "None"));
Path.Add(new Vector3(6616.728 , 772.7343 , 80.15404 , "None"));
Path.Add(new Vector3(6607.557 , 760.0591 , 78.75749 , "None"));
Path.Add(new Vector3(6599.067 , 746.0949 , 77.2824 , "None"));
Path.Add(new Vector3(6591.188 , 731.0754 , 75.74163 , "None"));
Path.Add(new Vector3(6583.849 , 715.2339 , 74.14798 , "None"));
Path.Add(new Vector3(6576.776 , 698.3049 , 72.46483 , "None"));
Path.Add(new Vector3(6570.498 , 682.0205 , 70.85349 , "None"));
Path.Add(new Vector3(6564.345 , 665.1157 , 69.17832 , "None"));
Path.Add(new Vector3(6558.444 , 648.3235 , 67.50166 , "None"));
Path.Add(new Vector3(6552.554 , 631.3921 , 65.78667 , "None"));
Path.Add(new Vector3(6547.112 , 616.0117 , 64.19517 , "None"));
Path.Add(new Vector3(6541.372 , 600.5226 , 62.54362 , "None"));
Path.Add(new Vector3(6535.932 , 586.9539 , 61.03675 , "None"));
Path.Add(new Vector3(6530.045 , 573.8697 , 59.50153 , "None"));
Path.Add(new Vector3(6524.329 , 563.019 , 58.12913 , "None"));
Path.Add(new Vector3(6518.172 , 553.5309 , 56.79759 , "None"));
Path.Add(new Vector3(6503.472 , 535.029 , 53.73702 , "None"));
Path.Add(new Vector3(6489.718 , 520.3738 , 50.76271 , "None"));
Path.Add(new Vector3(6476.79 , 509.0445 , 47.89637 , "None"));
Path.Add(new Vector3(6464.569 , 500.5207 , 45.15981 , "None"));
Path.Add(new Vector3(6452.936 , 494.2817 , 42.57479 , "None"));
Path.Add(new Vector3(6441.77 , 489.8069 , 40.16306 , "None"));
Path.Add(new Vector3(6430.954 , 486.5757 , 37.94641 , "None"));
Path.Add(new Vector3(6419.058 , 483.9556 , 35.72105 , "None"));
Path.Add(new Vector3(6402.901 , 485.1594 , 33.24107 , "None"));
Path.Add(new Vector3(6387.523 , 491.3521 , 31.2929 , "None"));
Path.Add(new Vector3(6373.581 , 500.3491 , 29.64016 , "None"));
Path.Add(new Vector3(6361.729 , 509.9657 , 28.04634 , "None"));
Path.Add(new Vector3(6351.515 , 519.3771 , 25.97488 , "None"));
Path.Add(new Vector3(6343.732 , 535.8303 , 22.28763 , "None"));
Path.Add(new Vector3(6341.519 , 550.7707 , 19.17039 , "None"));
Path.Add(new Vector3(6340.384 , 557.595 , 17.50286 , "None"));
Path.Add(new Vector3(6320.883 , 548.2947 , 16.97699 , "None"));
Path.Add(new Vector3(6292.917 , 529.6859 , 16.40051 , "None"));
Path.Add(new Vector3(6261.566 , 514.1033 , 11.23006 , "None"));
Path.Add(new Vector3(6230.092 , 498.8389 , 14.63283 , "None"));
Path.Add(new Vector3(6203.994 , 477.5487 , 16.50577 , "None"));
Path.Add(new Vector3(6190.15 , 455.3315 , 21.8917 , "None"));
Path.Add(new Vector3(6171.651 , 426.8643 , 26.39579 , "None"));
Path.Add(new Vector3(6152.58 , 397.5166 , 28.72377 , "None"));
Path.Add(new Vector3(6133.508 , 368.1689 , 29.94354 , "None"));
Path.Add(new Vector3(6110.043 , 340.9181 , 29.81545 , "None"));
Path.Add(new Vector3(6086.828 , 316.1462 , 30.29638 , "None"));
Path.Add(new Vector3(6061.99 , 291.5482 , 24.62284 , "None"));
Path.Add(new Vector3(6033.348 , 271.9004 , 24.03136 , "None"));
Path.Add(new Vector3(6000.553 , 256.9544 , 20.72215 , "None"));
Path.Add(new Vector3(5969.463 , 243.401 , 21.95873 , "None"));
Path.Add(new Vector3(5934.77 , 240.0249 , 24.33584 , "None"));
Path.Add(new Vector3(5900.472 , 245.8282 , 23.78889 , "None"));
Path.Add(new Vector3(5867.292 , 256.9129 , 24.36679 , "None"));
Path.Add(new Vector3(5834.443 , 268.994 , 25.46253 , "None"));
Path.Add(new Vector3(5800.479 , 281.0778 , 23.23925 , "None"));
Path.Add(new Vector3(5768.436 , 292.2945 , 20.63839 , "None"));
Path.Add(new Vector3(5734.411 , 304.205 , 20.57873 , "None"));
Path.Add(new Vector3(5702.367 , 315.4218 , 19.29147 , "None"));
Path.Add(new Vector3(5668.647 , 322.6263 , 18.50462 , "None"));
Path.Add(new Vector3(5633.727 , 321.195 , 19.99141 , "None"));
Path.Add(new Vector3(5598.957 , 317.1827 , 24.03039 , "None"));
Path.Add(new Vector3(5564.279 , 312.9908 , 27.27676 , "None"));
Path.Add(new Vector3(5529.793 , 307.0695 , 27.86089 , "None"));
Path.Add(new Vector3(5497.1 , 294.8709 , 29.04562 , "None"));
Path.Add(new Vector3(5464.489 , 282.6217 , 30.25909 , "None"));
Path.Add(new Vector3(5429.683 , 279.6803 , 31.35212 , "None"));
Path.Add(new Vector3(5395.092 , 274.9609 , 30.20651 , "None"));
Path.Add(new Vector3(5360.873 , 267.6111 , 28.93804 , "None"));
Path.Add(new Vector3(5326.619 , 260.4208 , 27.81618 , "None"));
Path.Add(new Vector3(5291.933 , 255.7545 , 28.27884 , "None"));
Path.Add(new Vector3(5257.299 , 251.2055 , 30.24429 , "None"));
Path.Add(new Vector3(5222.422 , 248.4618 , 33.24962 , "None"));
Path.Add(new Vector3(5187.477 , 246.5034 , 34.4897 , "None"));
Path.Add(new Vector3(5152.532 , 244.545 , 31.48913 , "None"));
Path.Add(new Vector3(5117.691 , 241.1837 , 30.62563 , "None"));
Path.Add(new Vector3(5082.972 , 236.7621 , 28.51768 , "None"));
Path.Add(new Vector3(5047.21 , 232.2079 , 30.84993 , "None"));
Path.Add(new Vector3(5013.924 , 226.1851 , 33.15762 , "None"));
Path.Add(new Vector3(4978.146 , 222.1894 , 39.48204 , "None"));
Path.Add(new Vector3(4944.258 , 222.0137 , 42.26537 , "None"));
Path.Add(new Vector3(4909.225 , 221.8409 , 45.27531 , "None"));
Path.Add(new Vector3(4874.225 , 221.6683 , 49.02123 , "None"));
Path.Add(new Vector3(4838.175 , 221.4905 , 49.95874 , "None"));
Path.Add(new Vector3(4804.289 , 222.8016 , 48.63717 , "None"));
Path.Add(new Vector3(4769.863 , 228.5766 , 49.04079 , "None"));
Path.Add(new Vector3(4735.955 , 237.1606 , 48.57271 , "None"));
Path.Add(new Vector3(4712.221 , 250.6848 , 51.3944 , "None"));
Path.Add(new Vector3(4708.834 , 270.3643 , 48.12577 , "None"));
Path.Add(new Vector3(4673.117 , 274.6555 , 49.55259 , "None"));
Path.Add(new Vector3(4639.464 , 279.1411 , 51.3684 , "None"));
Path.Add(new Vector3(4604.737 , 283.4827 , 54.12053 , "None"));
Path.Add(new Vector3(4569.882 , 282.5797 , 57.52416 , "None"));
Path.Add(new Vector3(4534.003 , 279.1552 , 56.55729 , "None"));
Path.Add(new Vector3(4500.495 , 275.4831 , 58.4557 , "None"));
Path.Add(new Vector3(4467.614 , 260.8076 , 59.04368 , "None"));
Path.Add(new Vector3(4440.151 , 241.0546 , 58.15975 , "None"));
Path.Add(new Vector3(4412.627 , 217.7873 , 53.9702 , "None"));
Path.Add(new Vector3(4385.904 , 196.847 , 50.20068 , "None"));
Path.Add(new Vector3(4356.958 , 177.2349 , 47.25988 , "None"));
Path.Add(new Vector3(4326.958 , 159.3136 , 47.56538 , "None"));
Path.Add(new Vector3(4296.659 , 141.8332 , 45.55222 , "None"));
Path.Add(new Vector3(4266.251 , 124.503 , 41.5664 , "None"));
Path.Add(new Vector3(4235.85 , 107.1651 , 37.17468 , "None"));
Path.Add(new Vector3(4208.299 , 85.70547 , 32.97376 , "None"));
Path.Add(new Vector3(4180.209 , 64.87054 , 28.90027 , "None"));
Path.Add(new Vector3(4150.693 , 46.10603 , 24.71677 , "None"));
Path.Add(new Vector3(4119.539 , 27.96801 , 19.40028 , "None"));
Path.Add(new Vector3(4088.024 , 15.52786 , 16.12074 , "None"));
Path.Add(new Vector3(4055.098 , 3.753493 , 15.6327 , "None"));
Path.Add(new Vector3(4022.142 , -8.031976 , 16.65607 , "None"));
Path.Add(new Vector3(3987.807 , -11.53987 , 16.81129 , "None"));
Path.Add(new Vector3(3957.931 , 4.116603 , 16.95796 , "None"));
Path.Add(new Vector3(3928.048 , 24.27291 , 15.843 , "None"));
Path.Add(new Vector3(3900.237 , 43.74456 , 15.52687 , "None"));
Path.Add(new Vector3(3871.451 , 63.65248 , 15.01595 , "None"));
Path.Add(new Vector3(3847.177 , 88.48006 , 13.43942 , "None"));
Path.Add(new Vector3(3825.352 , 115.8418 , 10.36827 , "None"));
Path.Add(new Vector3(3801.85 , 141.4474 , 9.383531 , "None"));
Path.Add(new Vector3(3768.267 , 154.0437 , 7.647649 , "None"));
Path.Add(new Vector3(3738.974 , 171.2043 , 6.851986 , "None"));
Path.Add(new Vector3(3708.774 , 188.8957 , 4.849082 , "None"));
Path.Add(new Vector3(3676.725 , 202.3375 , 3.062378 , "None"));
Path.Add(new Vector3(3642.949 , 211.4586 , 1.627219 , "None"));
Path.Add(new Vector3(3608.002 , 213.3434 , 1.050247 , "None"));
Path.Add(new Vector3(3572 , 215.2033 , 4.408596 , "None"));
Path.Add(new Vector3(3538.134 , 216.6258 , 7.790507 , "None"));
Path.Add(new Vector3(3502.465 , 212.2918 , 10.05776 , "None"));
Path.Add(new Vector3(3468.836 , 215.4795 , 13.23425 , "None"));
Path.Add(new Vector3(3433.688 , 223.2555 , 10.08056 , "None"));
Path.Add(new Vector3(3399.924 , 224.1559 , 9.557377 , "None"));
Path.Add(new Vector3(3364.076 , 220.9208 , 12.41263 , "None"));
Path.Add(new Vector3(3330.823 , 214.0858 , 12.79715 , "None"));
Path.Add(new Vector3(3295.099 , 216.9989 , 11.34128 , "None"));
Path.Add(new Vector3(3261.617 , 220.9167 , 11.14834 , "None"));
Path.Add(new Vector3(3227.047 , 225.3935 , 10.18329 , "None"));
Path.Add(new Vector3(3192.13 , 226.4936 , 14.43856 , "None"));
Path.Add(new Vector3(3157.607 , 230.946 , 21.15633 , "None"));
Path.Add(new Vector3(3122.806 , 228.5201 , 30.8766 , "None"));
Path.Add(new Vector3(3089.061 , 219.8513 , 41.5967 , "None"));
Path.Add(new Vector3(3061.035 , 200.0265 , 50.69955 , "None"));
Path.Add(new Vector3(3045.889 , 167.5874 , 57.1249 , "None"));
Path.Add(new Vector3(3019.998 , 147.617 , 63.79803 , "None"));
Path.Add(new Vector3(2984.998 , 153.6567 , 71.4278 , "None"));
Path.Add(new Vector3(2953.987 , 167.4749 , 79.65852 , "None"));
Path.Add(new Vector3(2921.058 , 182.1477 , 87.99879 , "None"));
Path.Add(new Vector3(2890.103 , 195.9411 , 89.92454 , "None"));
Path.Add(new Vector3(2855.729 , 205.9284 , 88.29955 , "None"));
Path.Add(new Vector3(2822.225 , 211.4162 , 82.98579 , "None"));
Path.Add(new Vector3(2786.649 , 217.2435 , 76.54299 , "None"));
Path.Add(new Vector3(2753.146 , 222.7313 , 65.79742 , "None"));
Path.Add(new Vector3(2718.601 , 228.3897 , 75.24797 , "None"));
Path.Add(new Vector3(2694.282 , 213.623 , 84.62459 , "None"));
Path.Add(new Vector3(2713.624 , 206.9088 , 82.43776 , "None"));
Path.Add(new Vector3(2710.019 , 216.5189 , 79.74808 , "None"));
Path.Add(new Vector3(2744.875 , 219.3228 , 68.94678 , "None"));
Path.Add(new Vector3(2775.133 , 221.0492 , 58.42397 , "Swimming"));
Path.Add(new Vector3(2800.859 , 215.9572 , 62.85165 , "None"));
Path.Add(new Vector3(2813.353 , 194.2972 , 73.80777 , "None"));
Path.Add(new Vector3(2803.491 , 194.2972 , 70.33537 , "None"));
Path.Add(new Vector3(2829.376 , 213.072 , 73.93604 , "None"));
Path.Add(new Vector3(2861.765 , 212.4285 , 83.69655 , "None"));
Path.Add(new Vector3(2891.705 , 196.5089 , 89.88523 , "None"));
Path.Add(new Vector3(2897.463 , 193.4738 , 89.96696 , "None"));
Path.Add(new Vector3(2922.962 , 187.8334 , 87.89246 , "None"));
Path.Add(new Vector3(2957.827 , 185.0627 , 75.57465 , "None"));
Path.Add(new Vector3(2993.858 , 183.8818 , 72.54947 , "None"));
Path.Add(new Vector3(3027.79 , 182.7696 , 65.02242 , "None"));
Path.Add(new Vector3(3058.429 , 180.9622 , 53.50051 , "None"));
Path.Add(new Vector3(3029.402 , 169.6283 , 57.82786 , "None"));
Path.Add(new Vector3(3021.901 , 140.4342 , 63.09246 , "None"));
Path.Add(new Vector3(2994.861 , 149.2863 , 68.81667 , "None"));
Path.Add(new Vector3(2988.49 , 155.208 , 70.84396 , "None"));
Path.Add(new Vector3(2957.746 , 166.4602 , 78.779 , "None"));
Path.Add(new Vector3(2925.871 , 178.1262 , 87.17477 , "None"));
Path.Add(new Vector3(2892.997 , 190.139 , 89.95703 , "None"));
Path.Add(new Vector3(2859.529 , 184.1624 , 95.87486 , "None"));
Path.Add(new Vector3(2832.163 , 163.5504 , 101.4659 , "None"));
Path.Add(new Vector3(2824.28 , 129.5204 , 102.2538 , "None"));
Path.Add(new Vector3(2823.377 , 94.79935 , 100.5845 , "None"));
Path.Add(new Vector3(2832.543 , 61.05072 , 98.56893 , "None"));
Path.Add(new Vector3(2837.792 , 26.44842 , 97.16349 , "None"));
Path.Add(new Vector3(2843.492 , -8.084339 , 97.8232 , "None"));
Path.Add(new Vector3(2847.958 , -42.75763 , 99.93034 , "None"));
Path.Add(new Vector3(2851.593 , -77.56826 , 103.5157 , "None"));
Path.Add(new Vector3(2855.219 , -113.4354 , 102.9506 , "None"));
Path.Add(new Vector3(2858.634 , -147.2133 , 104.7646 , "None"));
Path.Add(new Vector3(2857.532 , -181.2643 , 104.059 , "None"));
Path.Add(new Vector3(2842.084 , -212.6685 , 106.2744 , "None"));
Path.Add(new Vector3(2831.162 , -244.6828 , 106.5002 , "None"));
Path.Add(new Vector3(2811.402 , -270.2593 , 106.8582 , "None"));
Path.Add(new Vector3(2804.893 , -285.344 , 107.2464 , "None"));
Path.Add(new Vector3(2810.136 , -281.8213 , 107.3495 , "None"));
Path.Add(new Vector3(2815.106 , -283.4219 , 107.3551 , "None"));
Path.Add(new Vector3(2819.244 , -284.7549 , 107.2372 , "None"));
Path.Add(new Vector3(2824.631 , -284.5815 , 107.1548 , "None"));
Path.Add(new Vector3(6581.05 , 767.5 , 5.78428 , "None"));
Path.Add(new Vector3(6575.905 , 769.5278 , 5.539532 , "None"));
Path.Add(new Vector3(6557.391 , 776.0868 , 6.835382 , "None"));
Path.Add(new Vector3(6523.251 , 783.7965 , 6.494433 , "None"));
Path.Add(new Vector3(6506.095 , 787.2428 , 8.176541 , "None"));
Path.Add(new Vector3(6490.516 , 757.6313 , 8.9004 , "None"));
Path.Add(new Vector3(6477.948 , 723.8577 , 9.212008 , "None"));
Path.Add(new Vector3(6465.699 , 692.1944 , 8.375978 , "None"));
Path.Add(new Vector3(6453.248 , 659.4844 , 9.717059 , "None"));
Path.Add(new Vector3(6440.5 , 626.8956 , 9.928504 , "None"));
Path.Add(new Vector3(6421.696 , 597.963 , 7.278483 , "None"));
Path.Add(new Vector3(6400.028 , 570.4766 , 4.712765 , "None"));
Path.Add(new Vector3(6380.801 , 553.1683 , 2.580787 , "None"));
Path.Add(new Vector3(6366.928 , 547.0384 , 6.516819 , "None"));
Path.Add(new Vector3(6367.276 , 541.1776 , 8.03397 , "None"));
Path.Add(new Vector3(6374.479 , 540.3362 , 8.522429 , "None"));
Path.Add(new Vector3(6370.046 , 535.1496 , 9.34322 , "None"));
Path.Add(new Vector3(6364.909 , 539.0109 , 10.88562 , "None"));
Path.Add(new Vector3(6352.66 , 543.7487 , 15.63387 , "None"));
Path.Add(new Vector3(6345.994 , 555.0887 , 15.86685 , "None"));
Path.Add(new Vector3(6342.775 , 560.7832 , 15.82043 , "None"));
Path.Add(new Vector3(6351.201 , 574.1722 , 20.55596 , "None"));
Path.Add(new Vector3(6357.316 , 586.6044 , 24.12866 , "None"));
Path.Add(new Vector3(6364.464 , 606.2904 , 29.96162 , "None"));
Path.Add(new Vector3(6366.318 , 618.3159 , 33.45285 , "None"));
Path.Add(new Vector3(6366.73 , 633.8436 , 37.86877 , "None"));
Path.Add(new Vector3(6366.844 , 651.2034 , 42.8074 , "None"));
Path.Add(new Vector3(6367.804 , 668.7246 , 47.86679 , "None"));
Path.Add(new Vector3(6370.756 , 684.7369 , 52.64501 , "None"));
Path.Add(new Vector3(6377.084 , 697.8884 , 56.84819 , "None"));
Path.Add(new Vector3(6387.207 , 705.5534 , 59.7501 , "None"));
Path.Add(new Vector3(6397.553 , 707.7068 , 61.04293 , "None"));
Path.Add(new Vector3(6409.14 , 707.9505 , 61.75238 , "None"));
Path.Add(new Vector3(6422.616 , 706.816 , 62.11443 , "None"));
Path.Add(new Vector3(6437.604 , 704.4486 , 62.18612 , "None"));
Path.Add(new Vector3(6453.727 , 700.994 , 62.0245 , "None"));
Path.Add(new Vector3(6470.611 , 696.5975 , 61.68662 , "None"));
Path.Add(new Vector3(6487.88 , 691.4049 , 61.22952 , "None"));
Path.Add(new Vector3(6505.158 , 685.5615 , 60.71023 , "None"));
Path.Add(new Vector3(6522.068 , 679.2126 , 60.18582 , "None"));
Path.Add(new Vector3(6538.236 , 672.504 , 59.71332 , "None"));
Path.Add(new Vector3(6553.714 , 665.3716 , 59.34115 , "None"));
Path.Add(new Vector3(6566.889 , 658.5568 , 59.15115 , "None"));
Path.Add(new Vector3(6579.59 , 649.9995 , 58.96063 , "None"));
Path.Add(new Vector3(6590.829 , 639.7826 , 58.66477 , "None"));
Path.Add(new Vector3(6601.004 , 628.3238 , 58.30248 , "None"));
Path.Add(new Vector3(6610.509 , 616.041 , 57.9127 , "None"));
Path.Add(new Vector3(6619.742 , 603.3518 , 57.53434 , "None"));
Path.Add(new Vector3(6629.096 , 590.6741 , 57.20635 , "None"));
Path.Add(new Vector3(6638.968 , 578.4255 , 56.96764 , "None"));
Path.Add(new Vector3(6649.753 , 567.0239 , 56.85715 , "None"));
Path.Add(new Vector3(6661.848 , 556.887 , 56.91378 , "None"));
Path.Add(new Vector3(6675.646 , 548.4326 , 57.17649 , "None"));
Path.Add(new Vector3(6691.14 , 542.2 , 57.66912 , "None"));
Path.Add(new Vector3(6703.507 , 538.742 , 58.20224 , "None"));
Path.Add(new Vector3(6717.361 , 535.64 , 58.92052 , "None"));
Path.Add(new Vector3(6731.31 , 533.1495 , 59.73188 , "None"));
Path.Add(new Vector3(6746.468 , 531.0239 , 60.68292 , "None"));
Path.Add(new Vector3(6762.282 , 529.3513 , 61.72782 , "None"));
Path.Add(new Vector3(6778.611 , 528.1362 , 62.84383 , "None"));
Path.Add(new Vector3(6795.32 , 527.3829 , 64.00824 , "None"));
Path.Add(new Vector3(6812.269 , 527.0962 , 65.1983 , "None"));
Path.Add(new Vector3(6829.32 , 527.2803 , 66.39128 , "None"));
Path.Add(new Vector3(6846.335 , 527.9398 , 67.56447 , "None"));
Path.Add(new Vector3(6863.177 , 529.079 , 68.69514 , "None"));
Path.Add(new Vector3(6879.708 , 530.7026 , 69.76053 , "None"));
Path.Add(new Vector3(6895.789 , 532.8148 , 70.73794 , "None"));
Path.Add(new Vector3(6911.282 , 535.4202 , 71.60463 , "None"));
Path.Add(new Vector3(6926.049 , 538.5234 , 72.33787 , "None"));
Path.Add(new Vector3(6940.311 , 542.2501 , 72.92895 , "None"));
Path.Add(new Vector3(6955 , 547.4959 , 73.40862 , "None"));
Path.Add(new Vector3(6968.941 , 554.0403 , 73.74599 , "None"));
Path.Add(new Vector3(6982.264 , 561.6858 , 73.9624 , "None"));
Path.Add(new Vector3(6995.093 , 570.2341 , 74.07913 , "None"));
Path.Add(new Vector3(7007.554 , 579.4876 , 74.11751 , "None"));
Path.Add(new Vector3(7019.774 , 589.2482 , 74.09883 , "None"));
Path.Add(new Vector3(7031.878 , 599.3183 , 74.04443 , "None"));
Path.Add(new Vector3(7043.992 , 609.4997 , 73.97559 , "None"));
Path.Add(new Vector3(7056.244 , 619.5948 , 73.91364 , "None"));
Path.Add(new Vector3(7068.757 , 629.4055 , 73.87988 , "None"));
Path.Add(new Vector3(7081.66 , 638.734 , 73.89562 , "None"));
Path.Add(new Vector3(7095.077 , 647.3824 , 73.98217 , "None"));
Path.Add(new Vector3(7109.134 , 655.153 , 74.16084 , "None"));
Path.Add(new Vector3(7124.243 , 661.9655 , 74.4595 , "None"));
Path.Add(new Vector3(7137.306 , 667.0579 , 74.79275 , "None"));
Path.Add(new Vector3(7150.763 , 671.9252 , 75.19128 , "None"));
Path.Add(new Vector3(7164.266 , 676.4346 , 75.6386 , "None"));
Path.Add(new Vector3(7177.872 , 680.6171 , 76.12763 , "None"));
Path.Add(new Vector3(7191.637 , 684.5032 , 76.65131 , "None"));
Path.Add(new Vector3(7206.041 , 688.2286 , 77.21943 , "None"));
Path.Add(new Vector3(7219.87 , 691.5099 , 77.77426 , "None"));
Path.Add(new Vector3(7234.45 , 694.6923 , 78.35938 , "None"));
Path.Add(new Vector3(7249.414 , 697.7017 , 78.95082 , "None"));
Path.Add(new Vector3(7264.819 , 700.569 , 79.54152 , "None"));
Path.Add(new Vector3(7280.722 , 703.3251 , 80.12438 , "None"));
Path.Add(new Vector3(7297.177 , 706.0009 , 80.69233 , "None"));
Path.Add(new Vector3(7314.242 , 708.6269 , 81.2383 , "None"));
Path.Add(new Vector3(7331.973 , 711.2342 , 81.7552 , "None"));
Path.Add(new Vector3(7350.426 , 713.8536 , 82.23597 , "None"));
Path.Add(new Vector3(7368.67 , 716.379 , 82.65265 , "None"));
Path.Add(new Vector3(7381.944 , 718.1119 , 82.92117 , "None"));
Path.Add(new Vector3(7395.738 , 719.7809 , 83.17522 , "None"));
Path.Add(new Vector3(7410.011 , 721.3896 , 83.41618 , "None"));
Path.Add(new Vector3(7424.72 , 722.9412 , 83.64536 , "None"));
Path.Add(new Vector3(7439.823 , 724.4388 , 83.86418 , "None"));
Path.Add(new Vector3(7455.279 , 725.8858 , 84.07397 , "None"));
Path.Add(new Vector3(7471.044 , 727.2853 , 84.27609 , "None"));
Path.Add(new Vector3(7487.078 , 728.6407 , 84.47191 , "None"));
Path.Add(new Vector3(7503.336 , 729.955 , 84.6628 , "None"));
Path.Add(new Vector3(7519.778 , 731.2317 , 84.85011 , "None"));
Path.Add(new Vector3(7536.362 , 732.4739 , 85.0352 , "None"));
Path.Add(new Vector3(7553.546 , 733.7208 , 85.22498 , "None"));
Path.Add(new Vector3(7569.784 , 734.8679 , 85.40419 , "None"));
Path.Add(new Vector3(7586.538 , 736.0261 , 85.59082 , "None"));
Path.Add(new Vector3(7603.265 , 737.1628 , 85.78068 , "None"));
Path.Add(new Vector3(7619.921 , 738.2814 , 85.97513 , "None"));
Path.Add(new Vector3(7636.467 , 739.3849 , 86.17554 , "None"));
Path.Add(new Vector3(7652.858 , 740.4767 , 86.38327 , "None"));
Path.Add(new Vector3(7669.053 , 741.5598 , 86.59967 , "None"));
Path.Add(new Vector3(7685.01 , 742.6378 , 86.82613 , "None"));
Path.Add(new Vector3(7700.686 , 743.7137 , 87.06398 , "None"));
Path.Add(new Vector3(7716.04 , 744.7908 , 87.31461 , "None"));
Path.Add(new Vector3(7731.028 , 745.8724 , 87.57936 , "None"));
Path.Add(new Vector3(7745.87 , 746.9807 , 87.86496 , "None"));
Path.Add(new Vector3(7763.082 , 748.2177 , 88.24592 , "None"));
Path.Add(new Vector3(7780.74 , 749.3769 , 88.69796 , "None"));
Path.Add(new Vector3(7797.292 , 750.3774 , 89.17058 , "None"));
Path.Add(new Vector3(7814.259 , 751.3317 , 89.69685 , "None"));
Path.Add(new Vector3(7831.113 , 752.223 , 90.25417 , "None"));
Path.Add(new Vector3(7847.84 , 753.0671 , 90.8338 , "None"));
Path.Add(new Vector3(7864.422 , 753.8796 , 91.42705 , "None"));
Path.Add(new Vector3(7880.845 , 754.6763 , 92.02522 , "None"));
Path.Add(new Vector3(7897.091 , 755.4727 , 92.61959 , "None"));
Path.Add(new Vector3(7913.148 , 756.2847 , 93.20145 , "None"));
Path.Add(new Vector3(7928.998 , 757.1277 , 93.76212 , "None"));
Path.Add(new Vector3(7944.625 , 758.0176 , 94.29286 , "None"));
Path.Add(new Vector3(7960.015 , 758.97 , 94.78499 , "None"));
Path.Add(new Vector3(7975.15 , 760.0006 , 95.2298 , "None"));
Path.Add(new Vector3(7990.017 , 761.125 , 95.61858 , "None"));
Path.Add(new Vector3(8004.6 , 762.3589 , 95.94263 , "None"));
Path.Add(new Vector3(8018.881 , 763.7181 , 96.19323 , "None"));
Path.Add(new Vector3(8033.261 , 765.2654 , 96.36537 , "None"));
Path.Add(new Vector3(8046.482 , 766.8747 , 96.43929 , "None"));
Path.Add(new Vector3(8059.769 , 768.7036 , 96.41734 , "None"));
Path.Add(new Vector3(8078.124 , 771.7492 , 96.24422 , "None"));
Path.Add(new Vector3(8095.501 , 775.2986 , 95.94428 , "None"));
Path.Add(new Vector3(8111.994 , 779.2571 , 95.52384 , "None"));
Path.Add(new Vector3(8127.733 , 783.5353 , 94.98898 , "None"));
Path.Add(new Vector3(8142.848 , 788.0442 , 94.34583 , "None"));
Path.Add(new Vector3(8157.472 , 792.6945 , 93.60047 , "None"));
Path.Add(new Vector3(8171.733 , 797.3969 , 92.75902 , "None"));
Path.Add(new Vector3(8185.763 , 802.0623 , 91.82756 , "None"));
Path.Add(new Vector3(8199.693 , 806.6016 , 90.81222 , "None"));
Path.Add(new Vector3(8213.652 , 810.9254 , 89.71908 , "None"));
Path.Add(new Vector3(8227.772 , 814.9446 , 88.55424 , "None"));
Path.Add(new Vector3(8242.184 , 818.5699 , 87.32384 , "None"));
Path.Add(new Vector3(8257.018 , 821.7123 , 86.03392 , "None"));
Path.Add(new Vector3(8272.363 , 824.2773 , 84.69384 , "None"));
Path.Add(new Vector3(8287.927 , 826.2693 , 83.29405 , "None"));
Path.Add(new Vector3(8304.067 , 827.8713 , 81.77122 , "None"));
Path.Add(new Vector3(8320.645 , 829.1274 , 80.1393 , "None"));
Path.Add(new Vector3(8337.521 , 830.0822 , 78.41222 , "None"));
Path.Add(new Vector3(8354.558 , 830.7802 , 76.60389 , "None"));
Path.Add(new Vector3(8372.125 , 831.2775 , 74.67111 , "None"));
Path.Add(new Vector3(8388.553 , 831.5833 , 72.79929 , "None"));
Path.Add(new Vector3(8405.234 , 831.7772 , 70.83091 , "None"));
Path.Add(new Vector3(8421.519 , 831.8922 , 68.83704 , "None"));
Path.Add(new Vector3(8437.269 , 831.9725 , 66.83162 , "None"));
Path.Add(new Vector3(8452.343 , 832.0625 , 64.82858 , "None"));
Path.Add(new Vector3(8466.605 , 832.2067 , 62.84187 , "None"));
Path.Add(new Vector3(8479.915 , 832.4497 , 60.88541 , "None"));
Path.Add(new Vector3(8492.132 , 832.8357 , 58.97315 , "None"));
Path.Add(new Vector3(8512.026 , 833.7968 , 55.3528 , "None"));
Path.Add(new Vector3(8531.606 , 834.8945 , 50.77867 , "None"));
Path.Add(new Vector3(8547.99 , 835.9388 , 46.06335 , "None"));
Path.Add(new Vector3(8561.933 , 836.9105 , 41.45998 , "None"));
Path.Add(new Vector3(8574.19 , 837.7905 , 37.22169 , "None"));
Path.Add(new Vector3(8585.519 , 838.5595 , 33.60162 , "None"));
Path.Add(new Vector3(8598.252 , 839.2782 , 30.53609 , "None"));
Path.Add(new Vector3(8618.721 , 840.1054 , 27.80908 , "None"));
Path.Add(new Vector3(8633.877 , 840.4869 , 27.32088 , "None"));
Path.Add(new Vector3(8643.821 , 840.7147 , 27.14734 , "None"));
Path.Add(new Vector3(8643.821 , 840.7147 , 23.26179 , "None"));
Path.Add(new Vector3(8633.654 , 839.4408 , 28.17652 , "None"));
Path.Add(new Vector3(8621.198 , 837.0157 , 32.36911 , "None"));
Path.Add(new Vector3(8603.952 , 834.3062 , 38.29982 , "None"));
Path.Add(new Vector3(8591.834 , 832.5456 , 42.96483 , "None"));
Path.Add(new Vector3(8579.838 , 830.4418 , 48.30561 , "None"));
Path.Add(new Vector3(8567.856 , 828.7866 , 53.21921 , "None"));
Path.Add(new Vector3(8550.693 , 827.4874 , 58.96111 , "None"));
Path.Add(new Vector3(8529.923 , 827.1431 , 64.3405 , "None"));
Path.Add(new Vector3(8518.996 , 827.226 , 67.05186 , "None"));
Path.Add(new Vector3(8507.788 , 827.3832 , 70.0039 , "None"));
Path.Add(new Vector3(8496.083 , 827.6318 , 73.12361 , "None"));
Path.Add(new Vector3(8483.667 , 827.9887 , 76.33799 , "None"));
Path.Add(new Vector3(8470.327 , 828.4706 , 79.57402 , "None"));
Path.Add(new Vector3(8455.848 , 829.0945 , 82.75871 , "None"));
Path.Add(new Vector3(8440.013 , 829.8773 , 85.81906 , "None"));
Path.Add(new Vector3(8422.062 , 830.8674 , 88.76411 , "None"));
Path.Add(new Vector3(8403.424 , 831.9868 , 91.27466 , "None"));
Path.Add(new Vector3(8382.24 , 833.3472 , 93.52393 , "None"));
Path.Add(new Vector3(8359.246 , 834.9061 , 95.33054 , "None"));
Path.Add(new Vector3(8346.969 , 835.8004 , 96.05377 , "None"));
Path.Add(new Vector3(8334.658 , 836.7635 , 96.64237 , "None"));
Path.Add(new Vector3(8320.855 , 837.9019 , 97.17641 , "None"));
Path.Add(new Vector3(8307.227 , 839.0709 , 97.60033 , "None"));
Path.Add(new Vector3(8292.596 , 840.3622 , 97.96402 , "None"));
Path.Add(new Vector3(8277.435 , 841.7288 , 98.26012 , "None"));
Path.Add(new Vector3(8261.803 , 843.1582 , 98.49561 , "None"));
Path.Add(new Vector3(8245.763 , 844.6382 , 98.67743 , "None"));
Path.Add(new Vector3(8228.875 , 846.2023 , 98.81597 , "None"));
Path.Add(new Vector3(8212.691 , 847.7003 , 98.90797 , "None"));
Path.Add(new Vector3(8195.781 , 849.2574 , 98.9706 , "None"));
Path.Add(new Vector3(8178.703 , 850.8156 , 99.00743 , "None"));
Path.Add(new Vector3(8161.514 , 852.3623 , 99.02541 , "None"));
Path.Add(new Vector3(8144.277 , 853.8853 , 99.03151 , "None"));
Path.Add(new Vector3(8126.535 , 855.4158 , 99.03272 , "None"));
Path.Add(new Vector3(8109.896 , 856.8101 , 99.03592 , "None"));
Path.Add(new Vector3(8092.873 , 858.1872 , 99.04815 , "None"));
Path.Add(new Vector3(8076.042 , 859.491 , 99.07636 , "None"));
Path.Add(new Vector3(8058.969 , 860.7441 , 99.12945 , "None"));
Path.Add(new Vector3(8043.194 , 861.8289 , 99.20852 , "None"));
Path.Add(new Vector3(8026.828 , 862.8667 , 99.33058 , "None"));
Path.Add(new Vector3(8011.835 , 863.7247 , 99.48811 , "None"));
Path.Add(new Vector3(7996.423 , 864.4962 , 99.70783 , "None"));
Path.Add(new Vector3(7981.553 , 865.1218 , 99.98756 , "None"));
Path.Add(new Vector3(7963.985 , 865.8513 , 100.3761 , "None"));
Path.Add(new Vector3(7947.904 , 866.5389 , 100.7756 , "None"));
Path.Add(new Vector3(7931.263 , 867.2518 , 101.2306 , "None"));
Path.Add(new Vector3(7915.943 , 867.8907 , 101.6841 , "None"));
Path.Add(new Vector3(7899.99 , 868.5169 , 102.1873 , "None"));
Path.Add(new Vector3(7885.207 , 869.0413 , 102.6774 , "None"));
Path.Add(new Vector3(7869.704 , 869.511 , 103.2105 , "None"));
Path.Add(new Vector3(7855.232 , 869.8549 , 103.72 , "None"));
Path.Add(new Vector3(7840.385 , 870.093 , 104.2485 , "None"));
Path.Add(new Vector3(7825.554 , 870.1958 , 104.776 , "None"));
Path.Add(new Vector3(7810.234 , 870.1425 , 105.3134 , "None"));
Path.Add(new Vector3(7795.709 , 869.928 , 105.8098 , "None"));
Path.Add(new Vector3(7780.123 , 869.5083 , 106.3218 , "None"));
Path.Add(new Vector3(7765.235 , 868.9158 , 106.7857 , "None"));
Path.Add(new Vector3(7749.144 , 868.0598 , 107.254 , "None"));
Path.Add(new Vector3(7733.667 , 867.0234 , 107.668 , "None"));
Path.Add(new Vector3(7716.831 , 865.6611 , 108.0742 , "None"));
Path.Add(new Vector3(7700.541 , 864.1151 , 108.421 , "None"));
Path.Add(new Vector3(7682.722 , 862.1765 , 108.7467 , "None"));
Path.Add(new Vector3(7668.652 , 860.4463 , 108.9799 , "None"));
Path.Add(new Vector3(7653.788 , 858.4009 , 109.2326 , "None"));
Path.Add(new Vector3(7639.474 , 856.247 , 109.4795 , "None"));
Path.Add(new Vector3(7624.431 , 853.8125 , 109.7401 , "None"));
Path.Add(new Vector3(7609.125 , 851.1783 , 110.0035 , "None"));
Path.Add(new Vector3(7593.592 , 848.3621 , 110.2667 , "None"));
Path.Add(new Vector3(7577.861 , 845.3815 , 110.5264 , "None"));
Path.Add(new Vector3(7561.966 , 842.2539 , 110.7795 , "None"));
Path.Add(new Vector3(7545.936 , 838.9972 , 111.0228 , "None"));
Path.Add(new Vector3(7529.32 , 835.5266 , 111.2597 , "None"));
Path.Add(new Vector3(7513.605 , 832.1671 , 111.4672 , "None"));
Path.Add(new Vector3(7496.88 , 828.5215 , 111.6675 , "None"));
Path.Add(new Vector3(7481.125 , 825.0319 , 111.8342 , "None"));
Path.Add(new Vector3(7464.907 , 821.394 , 111.9807 , "None"));
Path.Add(new Vector3(7448.748 , 817.7328 , 112.0984 , "None"));
Path.Add(new Vector3(7432.68 , 814.066 , 112.184 , "None"));
Path.Add(new Vector3(7416.732 , 810.411 , 112.2343 , "None"));
Path.Add(new Vector3(7400.468 , 806.6777 , 112.246 , "None"));
Path.Add(new Vector3(7385.332 , 803.2076 , 112.2165 , "None"));
Path.Add(new Vector3(7369.942 , 799.6945 , 112.1421 , "None"));
Path.Add(new Vector3(7354.802 , 796.2638 , 112.0196 , "None"));
Path.Add(new Vector3(7339.502 , 792.835 , 111.84 , "None"));
Path.Add(new Vector3(7325.398 , 789.7206 , 111.6181 , "None"));
Path.Add(new Vector3(7311.198 , 786.6432 , 111.3327 , "None"));
Path.Add(new Vector3(7296.383 , 783.4916 , 110.9572 , "None"));
Path.Add(new Vector3(7279.333 , 779.582 , 110.3836 , "None"));
Path.Add(new Vector3(7262.799 , 775.413 , 109.673 , "None"));
Path.Add(new Vector3(7246.248 , 770.9075 , 108.8134 , "None"));
Path.Add(new Vector3(7231.052 , 766.5236 , 107.9 , "None"));
Path.Add(new Vector3(7215.271 , 761.7781 , 106.8354 , "None"));
Path.Add(new Vector3(7200.691 , 757.2785 , 105.7578 , "None"));
Path.Add(new Vector3(7185.451 , 752.5273 , 104.5496 , "None"));
Path.Add(new Vector3(7171.272 , 748.1329 , 103.3658 , "None"));
Path.Add(new Vector3(7156.34 , 743.6105 , 102.0755 , "None"));
Path.Add(new Vector3(7142.344 , 739.5418 , 100.8433 , "None"));
Path.Add(new Vector3(7127.492 , 735.4827 , 99.53247 , "None"));
Path.Add(new Vector3(7113.461 , 731.9605 , 98.30994 , "None"));
Path.Add(new Vector3(7098.457 , 728.5988 , 97.04004 , "None"));
Path.Add(new Vector3(7084.175 , 725.8438 , 95.88503 , "None"));
Path.Add(new Vector3(7068.789 , 723.414 , 94.71758 , "None"));
Path.Add(new Vector3(7054.039 , 721.647 , 93.68805 , "None"));
Path.Add(new Vector3(7038.511 , 720.4106 , 92.71236 , "None"));
Path.Add(new Vector3(7022.604 , 719.8251 , 91.83842 , "None"));
Path.Add(new Vector3(7006.26 , 719.947 , 91.0812 , "None"));
Path.Add(new Vector3(6991.844 , 720.9308 , 90.53534 , "None"));
Path.Add(new Vector3(6977.039 , 723.0101 , 90.07922 , "None"));
Path.Add(new Vector3(6961.775 , 726.0682 , 89.69845 , "None"));
Path.Add(new Vector3(6946.115 , 729.9828 , 89.38435 , "None"));
Path.Add(new Vector3(6930.123 , 734.632 , 89.12818 , "None"));
Path.Add(new Vector3(6913.373 , 740.0598 , 88.9157 , "None"));
Path.Add(new Vector3(6897.401 , 745.646 , 88.75476 , "None"));
Path.Add(new Vector3(6880.799 , 751.7669 , 88.62006 , "None"));
Path.Add(new Vector3(6864.121 , 758.1343 , 88.50842 , "None"));
Path.Add(new Vector3(6847.431 , 764.6263 , 88.4111 , "None"));
Path.Add(new Vector3(6830.794 , 771.1208 , 88.31939 , "None"));
Path.Add(new Vector3(6813.781 , 777.6841 , 88.22158 , "None"));
Path.Add(new Vector3(6797.934 , 783.6296 , 88.1179 , "None"));
Path.Add(new Vector3(6781.838 , 789.3998 , 87.99069 , "None"));
Path.Add(new Vector3(6766.051 , 794.6846 , 87.83421 , "None"));
Path.Add(new Vector3(6750.637 , 799.3619 , 87.63972 , "None"));
Path.Add(new Vector3(6735.659 , 803.3098 , 87.3985 , "None"));
Path.Add(new Vector3(6720.756 , 806.4846 , 87.09201 , "None"));
Path.Add(new Vector3(6707.27 , 808.5291 , 86.74104 , "None"));
Path.Add(new Vector3(6693.985 , 809.5566 , 86.30736 , "None"));
Path.Add(new Vector3(6681.395 , 809.3665 , 85.79207 , "None"));
Path.Add(new Vector3(6669.56 , 807.8371 , 85.18645 , "None"));
Path.Add(new Vector3(6658.366 , 804.782 , 84.46904 , "None"));
Path.Add(new Vector3(6646.005 , 799.0132 , 83.48098 , "None"));
Path.Add(new Vector3(6634.594 , 791.0809 , 82.36631 , "None"));
Path.Add(new Vector3(6623.759 , 780.8949 , 81.09938 , "None"));
Path.Add(new Vector3(6614.336 , 769.659 , 79.80848 , "None"));
Path.Add(new Vector3(6605.345 , 756.6367 , 78.39098 , "None"));
Path.Add(new Vector3(6597.019 , 742.3848 , 76.89822 , "None"));
Path.Add(new Vector3(6589.061 , 726.6665 , 75.29552 , "None"));
Path.Add(new Vector3(6582.07 , 711.1263 , 73.73822 , "None"));
Path.Add(new Vector3(6575.304 , 694.5872 , 72.09666 , "None"));
Path.Add(new Vector3(6568.917 , 677.7524 , 70.43117 , "None"));
Path.Add(new Vector3(6562.833 , 660.8557 , 68.75459 , "None"));
Path.Add(new Vector3(6556.986 , 644.1307 , 67.07975 , "None"));
Path.Add(new Vector3(6551.3 , 627.8108 , 65.41947 , "None"));
Path.Add(new Vector3(6545.707 , 612.1296 , 63.78662 , "None"));
Path.Add(new Vector3(6540.132 , 597.3209 , 62.19403 , "None"));
Path.Add(new Vector3(6534.505 , 583.6176 , 60.6545 , "None"));
Path.Add(new Vector3(6528.755 , 571.2539 , 59.1809 , "None"));
Path.Add(new Vector3(6522.81 , 560.463 , 57.78605 , "None"));
Path.Add(new Vector3(6514.377 , 548.4841 , 56.02047 , "None"));
Path.Add(new Vector3(6499.928 , 531.0009 , 52.97987 , "None"));
Path.Add(new Vector3(6486.394 , 517.2327 , 50.03099 , "None"));
Path.Add(new Vector3(6473.657 , 506.6588 , 47.19555 , "None"));
Path.Add(new Vector3(6461.595 , 498.7589 , 44.49529 , "None"));
Path.Add(new Vector3(6450.092 , 493.0125 , 41.95203 , "None"));
Path.Add(new Vector3(6439.027 , 488.8993 , 39.58746 , "None"));
Path.Add(new Vector3(6428.28 , 485.8988 , 37.42342 , "None"));
Path.Add(new Vector3(6414.969 , 483.6692 , 35.03617 , "None"));
Path.Add(new Vector3(6398.947 , 486.3288 , 32.71199 , "None"));
Path.Add(new Vector3(6383.869 , 493.4286 , 30.86029 , "None"));
Path.Add(new Vector3(6370.39 , 502.7851 , 29.24467 , "None"));
Path.Add(new Vector3(6359.167 , 512.2139 , 27.62876 , "None"));
Path.Add(new Vector3(6348.815 , 523.0685 , 25.10223 , "None"));
Path.Add(new Vector3(6342.973 , 539.4871 , 21.51428 , "None"));
Path.Add(new Vector3(6341.161 , 553.8071 , 18.54125 , "None"));
Path.Add(new Vector3(6341.042 , 562.5869 , 18.50261 , "None"));
Path.Add(new Vector3(6344.4 , 577.4798 , 20.9231 , "None"));
Path.Add(new Vector3(6347.058 , 595.4285 , 23.74375 , "None"));
Path.Add(new Vector3(6344.909 , 612.2452 , 26.04201 , "None"));
Path.Add(new Vector3(6337.281 , 623.1735 , 26.9626 , "None"));
Path.Add(new Vector3(6329.468 , 631.3976 , 27.118 , "None"));
Path.Add(new Vector3(6319.243 , 639.2767 , 26.93591 , "None"));
Path.Add(new Vector3(6305.674 , 646.0027 , 26.57384 , "None"));
Path.Add(new Vector3(6287.613 , 651.0259 , 26.20103 , "None"));
Path.Add(new Vector3(6263.911 , 653.7963 , 25.98671 , "None"));
Path.Add(new Vector3(6252.661 , 654.264 , 25.9612 , "None"));
Path.Add(new Vector3(6243.089 , 654.4355 , 25.94146 , "None"));
Path.Add(new Vector3(6235.422 , 654.3594 , 25.92768 , "None"));
Path.Add(new Vector3(6223.906 , 653.835 , 25.91189 , "None"));
Path.Add(new Vector3(6218.409 , 653.4262 , 25.90657 , "None"));
Path.Add(new Vector3(6190.579 , 650.4852 , 25.89562 , "None"));
Path.Add(new Vector3(6175.799 , 648.7015 , 25.89574 , "None"));
Path.Add(new Vector3(6170.425 , 648.0469 , 25.89628 , "None"));
Path.Add(new Vector3(6153.486 , 645.9933 , 25.89895 , "None"));
Path.Add(new Vector3(6132.912 , 643.5472 , 25.90336 , "None"));
Path.Add(new Vector3(6108.713 , 640.7561 , 25.90921 , "None"));
Path.Add(new Vector3(6080.421 , 637.6095 , 25.91629 , "None"));
Path.Add(new Vector3(6047.567 , 634.0968 , 25.92436 , "None"));
Path.Add(new Vector3(6027.735 , 632.0212 , 25.92887 , "None"));
Path.Add(new Vector3(6016.99 , 630.8152 , 25.93027 , "None"));
Path.Add(new Vector3(6005.724 , 629.4755 , 25.93086 , "None"));
Path.Add(new Vector3(5993.955 , 628.0088 , 25.93071 , "None"));
Path.Add(new Vector3(5981.703 , 626.4221 , 25.92986 , "None"));
Path.Add(new Vector3(5968.987 , 624.7222 , 25.92838 , "None"));
Path.Add(new Vector3(5955.825 , 622.916 , 25.92633 , "None"));
Path.Add(new Vector3(5942.236 , 621.0103 , 25.92377 , "None"));
Path.Add(new Vector3(5927.814 , 618.9509 , 25.92065 , "None"));
Path.Add(new Vector3(5913.854 , 616.9284 , 25.91734 , "None"));
Path.Add(new Vector3(5899.1 , 614.7658 , 25.91359 , "None"));
Path.Add(new Vector3(5883.995 , 612.5315 , 25.90956 , "None"));
Path.Add(new Vector3(5868.558 , 610.2321 , 25.90532 , "None"));
Path.Add(new Vector3(5852.808 , 607.8747 , 25.90092 , "None"));
Path.Add(new Vector3(5836.764 , 605.4661 , 25.89643 , "None"));
Path.Add(new Vector3(5820.445 , 603.0131 , 25.89189 , "None"));
Path.Add(new Vector3(5803.872 , 600.5228 , 25.88738 , "None"));
Path.Add(new Vector3(5787.06 , 598.002 , 25.88294 , "None"));
Path.Add(new Vector3(5770.03 , 595.4573 , 25.87864 , "None"));
Path.Add(new Vector3(5752.802 , 592.8961 , 25.87454 , "None"));
Path.Add(new Vector3(5735.394 , 590.3249 , 25.8707 , "None"));
Path.Add(new Vector3(5717.824 , 587.7508 , 25.86717 , "None"));
Path.Add(new Vector3(5700.113 , 585.1807 , 25.86402 , "None"));
Path.Add(new Vector3(5677.802 , 581.9838 , 25.8607 , "None"));
Path.Add(new Vector3(5664.339 , 580.0795 , 25.85909 , "None"));
Path.Add(new Vector3(5646.315 , 577.5623 , 25.85742 , "None"));
Path.Add(new Vector3(5627.682 , 575.0026 , 25.85634 , "None"));
Path.Add(new Vector3(5610.087 , 572.6292 , 25.85598 , "None"));
Path.Add(new Vector3(5591.922 , 570.227 , 25.85632 , "None"));
Path.Add(new Vector3(5573.747 , 567.877 , 25.85746 , "None"));
Path.Add(new Vector3(5555.582 , 565.5859 , 25.85945 , "None"));
Path.Add(new Vector3(5537.444 , 563.3608 , 25.86234 , "None"));
Path.Add(new Vector3(5519.355 , 561.2084 , 25.86621 , "None"));
Path.Add(new Vector3(5501.333 , 559.1358 , 25.8711 , "None"));
Path.Add(new Vector3(5483.396 , 557.1497 , 25.87708 , "None"));
Path.Add(new Vector3(5465.563 , 555.257 , 25.8842 , "None"));
Path.Add(new Vector3(5447.324 , 553.4125 , 25.8928 , "None"));
Path.Add(new Vector3(5430.287 , 551.7795 , 25.90212 , "None"));
Path.Add(new Vector3(5412.361 , 550.1632 , 25.91339 , "None"));
Path.Add(new Vector3(5395.656 , 548.7585 , 25.92534 , "None"));
Path.Add(new Vector3(5378.63 , 547.4363 , 25.93908 , "None"));
Path.Add(new Vector3(5361.822 , 546.249 , 25.95432 , "None"));
Path.Add(new Vector3(5345.252 , 545.2032 , 25.97113 , "None"));
Path.Add(new Vector3(5328.938 , 544.306 , 25.98955 , "None"));
Path.Add(new Vector3(5312.899 , 543.5643 , 26.00965 , "None"));
Path.Add(new Vector3(5297.154 , 542.9849 , 26.03149 , "None"));
Path.Add(new Vector3(5281.265 , 542.5651 , 26.05587 , "None"));
Path.Add(new Vector3(5266.624 , 542.3405 , 26.08063 , "None"));
Path.Add(new Vector3(5251.438 , 542.2908 , 26.10889 , "None"));
Path.Add(new Vector3(5237.496 , 542.4282 , 26.13742 , "None"));
Path.Add(new Vector3(5223.093 , 542.7769 , 26.16982 , "None"));
Path.Add(new Vector3(5209.925 , 543.3028 , 26.20236 , "None"));
Path.Add(new Vector3(5196.056 , 544.0997 , 26.24006 , "None"));
Path.Add(new Vector3(5176.685 , 545.6317 , 26.29831 , "None"));
Path.Add(new Vector3(5156.962 , 547.6725 , 26.36391 , "None"));
Path.Add(new Vector3(5138.605 , 550.0034 , 26.43064 , "None"));
Path.Add(new Vector3(5119.905 , 552.8005 , 26.5042 , "None"));
Path.Add(new Vector3(5101.434 , 555.9764 , 26.58235 , "None"));
Path.Add(new Vector3(5083.195 , 559.5096 , 26.66483 , "None"));
Path.Add(new Vector3(5065.192 , 563.3787 , 26.75138 , "None"));
Path.Add(new Vector3(5046.898 , 567.6924 , 26.8445 , "None"));
Path.Add(new Vector3(5029.904 , 572.0388 , 26.93565 , "None"));
Path.Add(new Vector3(5012.112 , 576.933 , 27.03583 , "None"));
Path.Add(new Vector3(4995.596 , 581.7845 , 27.13311 , "None"));
Path.Add(new Vector3(4978.815 , 587.011 , 27.23613 , "None"));
Path.Add(new Vector3(4962.289 , 592.4446 , 27.34167 , "None"));
Path.Add(new Vector3(4946.019 , 598.0638 , 27.44948 , "None"));
Path.Add(new Vector3(4930.008 , 603.847 , 27.55928 , "None"));
Path.Add(new Vector3(4914.26 , 609.7729 , 27.67084 , "None"));
Path.Add(new Vector3(4898.777 , 615.8201 , 27.78387 , "None"));
Path.Add(new Vector3(4883.111 , 622.1527 , 27.90158 , "None"));
Path.Add(new Vector3(4868.621 , 628.1921 , 28.01337 , "None"));
Path.Add(new Vector3(4853.517 , 634.6631 , 28.1328 , "None"));
Path.Add(new Vector3(4839.563 , 640.7913 , 28.24571 , "None"));
Path.Add(new Vector3(4825.033 , 647.3124 , 28.36579 , "None"));
Path.Add(new Vector3(4811.625 , 653.4459 , 28.47882 , "None"));
Path.Add(new Vector3(4797.683 , 659.9285 , 28.5985 , "None"));
Path.Add(new Vector3(4784.834 , 665.9843 , 28.71064 , "None"));
Path.Add(new Vector3(4771.875 , 672.1561 , 28.82542 , "None"));
Path.Add(new Vector3(4759.213 , 678.2346 , 28.9391 , "None"));
Path.Add(new Vector3(4746.482 , 684.3749 , 29.05477 , "None"));
Path.Add(new Vector3(4734.785 , 690.0251 , 29.16213 , "None"));
Path.Add(new Vector3(4723.026 , 695.6942 , 29.27096 , "None"));
Path.Add(new Vector3(4711.575 , 701.1841 , 29.37766 , "None"));
Path.Add(new Vector3(4700.434 , 706.4731 , 29.48197 , "None"));
Path.Add(new Vector3(4689.606 , 711.5397 , 29.58363 , "None"));
Path.Add(new Vector3(4678.784 , 716.5034 , 29.6853 , "None"));
Path.Add(new Vector3(4666.75 , 721.8796 , 29.79836 , "None"));
Path.Add(new Vector3(4643.873 , 732.319 , 30.02611 , "None"));
Path.Add(new Vector3(4623.902 , 741.9753 , 30.24622 , "None"));
Path.Add(new Vector3(4606.516 , 751.0108 , 30.46019 , "None"));
Path.Add(new Vector3(4591.389 , 759.5881 , 30.66952 , "None"));
Path.Add(new Vector3(4577.831 , 768.1151 , 30.88187 , "None"));
Path.Add(new Vector3(4566.626 , 776.0175 , 31.08027 , "None"));
Path.Add(new Vector3(4556.343 , 784.1945 , 31.28468 , "None"));
Path.Add(new Vector3(4547.028 , 792.563 , 31.49045 , "None"));
Path.Add(new Vector3(4538.357 , 801.2854 , 31.69906 , "None"));
Path.Add(new Vector3(4530.01 , 810.524 , 31.91204 , "None"));
Path.Add(new Vector3(4521.406 , 820.7512 , 32.13754 , "None"));
Path.Add(new Vector3(4512.987 , 831.2002 , 32.35705 , "None"));
Path.Add(new Vector3(4503.373 , 843.3325 , 32.59928 , "None"));
Path.Add(new Vector3(4493.386 , 855.8766 , 32.83719 , "None"));
Path.Add(new Vector3(4484.558 , 867.8091 , 33.00527 , "None"));
Path.Add(new Vector3(4476.58 , 880.1722 , 33.10001 , "None"));
Path.Add(new Vector3(4468.419 , 894.324 , 33.14788 , "None"));
Path.Add(new Vector3(4460.992 , 908.4578 , 33.15694 , "None"));
Path.Add(new Vector3(4453.335 , 924.151 , 33.14308 , "None"));
Path.Add(new Vector3(4446.302 , 939.4172 , 33.12152 , "None"));
Path.Add(new Vector3(4439.193 , 955.4882 , 33.10466 , "None"));
Path.Add(new Vector3(4432.188 , 971.7339 , 33.10727 , "None"));
Path.Add(new Vector3(4425.246 , 987.9902 , 33.14355 , "None"));
Path.Add(new Vector3(4418.327 , 1004.092 , 33.22769 , "None"));
Path.Add(new Vector3(4411.182 , 1020.342 , 33.37938 , "None"));
Path.Add(new Vector3(4404.397 , 1035.174 , 33.59631 , "None"));
Path.Add(new Vector3(4397.307 , 1049.826 , 33.90916 , "None"));
Path.Add(new Vector3(4390.078 , 1063.665 , 34.32663 , "None"));
Path.Add(new Vector3(4382.671 , 1076.527 , 34.86291 , "None"));
Path.Add(new Vector3(4375.046 , 1088.248 , 35.53218 , "None"));
Path.Add(new Vector3(4366.922 , 1098.953 , 36.37556 , "None"));
Path.Add(new Vector3(4357.023 , 1109.793 , 37.62328 , "None"));
Path.Add(new Vector3(4343.977 , 1122.672 , 39.83669 , "None"));
Path.Add(new Vector3(4330.416 , 1134.718 , 42.64868 , "None"));
Path.Add(new Vector3(4316.473 , 1145.705 , 45.89264 , "None"));
Path.Add(new Vector3(4302.279 , 1155.405 , 49.40202 , "None"));
Path.Add(new Vector3(4287.539 , 1163.812 , 53.11829 , "None"));
Path.Add(new Vector3(4273.673 , 1170.041 , 56.55081 , "None"));
Path.Add(new Vector3(4259.103 , 1174.625 , 59.95089 , "None"));
Path.Add(new Vector3(4245.654 , 1176.814 , 62.76247 , "None"));
Path.Add(new Vector3(4231.802 , 1176.643 , 65.16012 , "None"));
Path.Add(new Vector3(4219.284 , 1173.914 , 66.70454 , "None"));
Path.Add(new Vector3(4206.692 , 1168.054 , 67.41349 , "None"));
Path.Add(new Vector3(4198.738 , 1161.781 , 67.29676 , "None"));
Path.Add(new Vector3(4191.383 , 1153.036 , 66.76367 , "None"));
Path.Add(new Vector3(4184.485 , 1142.084 , 65.8588 , "None"));
Path.Add(new Vector3(4177.963 , 1129.231 , 64.62542 , "None"));
Path.Add(new Vector3(4171.733 , 1114.783 , 63.10686 , "None"));
Path.Add(new Vector3(4165.531 , 1098.56 , 61.29036 , "None"));
Path.Add(new Vector3(4159.81 , 1082.334 , 59.38749 , "None"));
Path.Add(new Vector3(4153.775 , 1064.418 , 57.20797 , "None"));
Path.Add(new Vector3(4148.049 , 1047.194 , 55.04729 , "None"));
Path.Add(new Vector3(4141.837 , 1028.85 , 52.68323 , "None"));
Path.Add(new Vector3(4135.782 , 1011.818 , 50.43279 , "None"));
Path.Add(new Vector3(4129.249 , 994.8101 , 48.13099 , "None"));
Path.Add(new Vector3(4122.339 , 978.664 , 45.89057 , "None"));
Path.Add(new Vector3(4114.739 , 963.2593 , 43.6929 , "None"));
Path.Add(new Vector3(4107.052 , 950.187 , 41.76722 , "None"));
Path.Add(new Vector3(4098.508 , 938.4702 , 39.97092 , "None"));
Path.Add(new Vector3(4088.912 , 928.5391 , 38.35469 , "None"));
Path.Add(new Vector3(4075.786 , 919.0252 , 36.46495 , "None"));
Path.Add(new Vector3(4062.196 , 912.2612 , 34.67588 , "None"));
Path.Add(new Vector3(4046.704 , 907.0116 , 32.78339 , "None"));
Path.Add(new Vector3(4031.338 , 903.52 , 31.02386 , "None"));
Path.Add(new Vector3(4014.938 , 901.0174 , 29.24931 , "None"));
Path.Add(new Vector3(3998.202 , 899.2494 , 27.53118 , "None"));
Path.Add(new Vector3(3981.363 , 897.8326 , 25.88604 , "None"));
Path.Add(new Vector3(3964.654 , 896.384 , 24.33045 , "None"));
Path.Add(new Vector3(3947.825 , 894.4539 , 22.83932 , "None"));
Path.Add(new Vector3(3932.556 , 891.8581 , 21.55423 , "None"));
Path.Add(new Vector3(3917.635 , 888.0143 , 20.36678 , "None"));
Path.Add(new Vector3(3903.775 , 882.606 , 19.33518 , "None"));
Path.Add(new Vector3(3891.211 , 875.2497 , 18.47602 , "None"));
Path.Add(new Vector3(3880.355 , 865.8065 , 17.82052 , "None"));
Path.Add(new Vector3(3871.149 , 854.4891 , 17.37636 , "None"));
Path.Add(new Vector3(3863.24 , 841.533 , 17.11589 , "None"));
Path.Add(new Vector3(3856.183 , 826.8013 , 17.01526 , "None"));
Path.Add(new Vector3(3850.301 , 811.9409 , 17.05368 , "None"));
Path.Add(new Vector3(3844.764 , 795.9238 , 17.20582 , "None"));
Path.Add(new Vector3(3839.512 , 779.5048 , 17.44935 , "None"));
Path.Add(new Vector3(3834.291 , 762.993 , 17.76122 , "None"));
Path.Add(new Vector3(3828.847 , 746.6979 , 18.11833 , "None"));
Path.Add(new Vector3(3822.928 , 730.9285 , 18.49764 , "None"));
Path.Add(new Vector3(3816.28 , 715.994 , 18.87607 , "None"));
Path.Add(new Vector3(3808.404 , 701.8108 , 19.24057 , "None"));
Path.Add(new Vector3(3799.785 , 689.8666 , 19.538 , "None"));
Path.Add(new Vector3(3789.094 , 679.0057 , 19.78115 , "None"));
Path.Add(new Vector3(3777.675 , 670.8228 , 19.95585 , "None"));
Path.Add(new Vector3(3764.303 , 663.7657 , 20.17141 , "None"));
Path.Add(new Vector3(3749.471 , 657.8491 , 20.42021 , "None"));
Path.Add(new Vector3(3733.463 , 652.9186 , 20.69374 , "None"));
Path.Add(new Vector3(3716.562 , 648.8196 , 20.98349 , "None"));
Path.Add(new Vector3(3699.053 , 645.3978 , 21.28092 , "None"));
Path.Add(new Vector3(3681.219 , 642.4985 , 21.57753 , "None"));
Path.Add(new Vector3(3662.81 , 639.8956 , 21.87318 , "None"));
Path.Add(new Vector3(3645.711 , 637.6501 , 22.13422 , "None"));
Path.Add(new Vector3(3628.605 , 635.3918 , 22.37726 , "None"));
Path.Add(new Vector3(3612.31 , 633.0383 , 22.58542 , "None"));
Path.Add(new Vector3(3597.109 , 630.435 , 22.75018 , "None"));
Path.Add(new Vector3(3583.286 , 627.4275 , 22.86301 , "None"));
Path.Add(new Vector3(3570.788 , 623.744 , 22.91596 , "None"));
Path.Add(new Vector3(3557.357 , 617.7816 , 22.87197 , "None"));
Path.Add(new Vector3(3539.772 , 605.0803 , 22.46917 , "None"));
Path.Add(new Vector3(3529.146 , 591.9468 , 21.81079 , "None"));
Path.Add(new Vector3(3522.011 , 578.2404 , 20.97406 , "None"));
Path.Add(new Vector3(3516.532 , 565.3926 , 20.10293 , "None"));
Path.Add(new Vector3(3510.255 , 554.1537 , 19.30405 , "None"));
Path.Add(new Vector3(3500.469 , 545.4694 , 18.69045 , "None"));
Path.Add(new Vector3(3486.296 , 537.3323 , 17.966 , "None"));
Path.Add(new Vector3(3472.206 , 532.9837 , 17.37287 , "None"));
Path.Add(new Vector3(3456.429 , 532.5277 , 17.02878 , "None"));
Path.Add(new Vector3(3441.297 , 535.4891 , 17.04933 , "None"));
Path.Add(new Vector3(3428.887 , 541.8312 , 17.3329 , "None"));
Path.Add(new Vector3(3415.739 , 551.1421 , 17.80204 , "None"));
Path.Add(new Vector3(3401.489 , 561.8801 , 18.3913 , "None"));
Path.Add(new Vector3(3387.474 , 571.2608 , 18.96384 , "None"));
Path.Add(new Vector3(3372.023 , 578.5175 , 19.50384 , "None"));
Path.Add(new Vector3(3357.347 , 581.061 , 19.85234 , "None"));
Path.Add(new Vector3(3343.082 , 580.5155 , 19.60633 , "None"));
Path.Add(new Vector3(3327.82 , 578.1971 , 18.86754 , "None"));
Path.Add(new Vector3(3312.033 , 574.2392 , 18.00689 , "None"));
Path.Add(new Vector3(3296.193 , 568.7753 , 17.39531 , "None"));
Path.Add(new Vector3(3280.319 , 561.7142 , 17.41747 , "None"));
Path.Add(new Vector3(3266.235 , 553.8638 , 18.40316 , "None"));
Path.Add(new Vector3(3253.061 , 544.6833 , 20.76443 , "None"));
Path.Add(new Vector3(3243.744 , 534.7347 , 24.13193 , "None"));
Path.Add(new Vector3(3236.345 , 521.892 , 28.65338 , "None"));
Path.Add(new Vector3(3230.084 , 507.1897 , 34.04388 , "None"));
Path.Add(new Vector3(3224.24 , 491.7094 , 40.00365 , "None"));
Path.Add(new Vector3(3218.091 , 476.5322 , 46.23298 , "None"));
Path.Add(new Vector3(3210.918 , 462.7401 , 52.43184 , "None"));
Path.Add(new Vector3(3201.998 , 451.4142 , 58.30053 , "None"));
Path.Add(new Vector3(3190.611 , 443.636 , 63.53925 , "None"));
Path.Add(new Vector3(3178.086 , 440.6255 , 67.39094 , "None"));
Path.Add(new Vector3(3165.728 , 441.22 , 70.22817 , "None"));
Path.Add(new Vector3(3151.644 , 444.1569 , 72.90395 , "None"));
Path.Add(new Vector3(3136.204 , 448.9475 , 75.4334 , "None"));
Path.Add(new Vector3(3119.777 , 455.103 , 77.83174 , "None"));
Path.Add(new Vector3(3102.216 , 462.3537 , 80.18087 , "None"));
Path.Add(new Vector3(3085.441 , 469.5531 , 82.29552 , "None"));
Path.Add(new Vector3(3068.272 , 476.8704 , 84.39133 , "None"));
Path.Add(new Vector3(3051.595 , 483.5972 , 86.41663 , "None"));
Path.Add(new Vector3(3035.779 , 489.2451 , 88.3866 , "None"));
Path.Add(new Vector3(3021.194 , 493.3251 , 90.31637 , "None"));
Path.Add(new Vector3(3008.21 , 495.3484 , 92.22115 , "None"));
Path.Add(new Vector3(2994.693 , 494.4221 , 94.58265 , "None"));
Path.Add(new Vector3(2979.604 , 488.3128 , 97.8426 , "None"));
Path.Add(new Vector3(2967.467 , 478.1339 , 101.0429 , "None"));
Path.Add(new Vector3(2957.44 , 465.3322 , 104.0684 , "None"));
Path.Add(new Vector3(2948.681 , 451.3542 , 106.8041 , "None"));
Path.Add(new Vector3(2940.349 , 437.6471 , 109.1348 , "None"));
Path.Add(new Vector3(2931.602 , 425.6574 , 110.9454 , "None"));
Path.Add(new Vector3(2920.667 , 415.9478 , 112.1862 , "None"));
Path.Add(new Vector3(2906.837 , 405.66 , 112.3712 , "None"));
Path.Add(new Vector3(2893.502 , 396.7694 , 111.4095 , "None"));
Path.Add(new Vector3(2879.991 , 389.8083 , 109.8958 , "None"));
Path.Add(new Vector3(2865.631 , 385.3093 , 108.4244 , "None"));
Path.Add(new Vector3(2850.34 , 383.8418 , 107.5948 , "None"));
Path.Add(new Vector3(2836.121 , 386.3612 , 107.3475 , "None"));
Path.Add(new Vector3(2820.855 , 391.9294 , 107.2784 , "None"));
Path.Add(new Vector3(2805.021 , 399.011 , 107.2784 , "None"));
Path.Add(new Vector3(2789.099 , 406.0712 , 107.2385 , "None"));
Path.Add(new Vector3(2773.566 , 411.575 , 107.0497 , "None"));
Path.Add(new Vector3(2758.902 , 413.9874 , 106.603 , "None"));
Path.Add(new Vector3(2743.111 , 412.9677 , 105.4913 , "None"));
Path.Add(new Vector3(2728.703 , 410.0436 , 103.8545 , "None"));
Path.Add(new Vector3(2713.927 , 404.8048 , 101.9408 , "None"));
Path.Add(new Vector3(2700.321 , 397.795 , 100.3832 , "None"));
Path.Add(new Vector3(2686.003 , 388.0754 , 99.43294 , "None"));
Path.Add(new Vector3(2673.876 , 378.0144 , 99.51806 , "None"));
Path.Add(new Vector3(2662.26 , 367.2219 , 100.2366 , "None"));
Path.Add(new Vector3(2650.344 , 355.2482 , 101.3313 , "None"));
Path.Add(new Vector3(2637.546 , 341.2699 , 102.8179 , "None"));
Path.Add(new Vector3(2626.18 , 327.5231 , 104.4128 , "None"));
Path.Add(new Vector3(2615.731 , 312.9644 , 106.1937 , "None"));
Path.Add(new Vector3(2608.238 , 299.8974 , 107.8428 , "None"));
Path.Add(new Vector3(2603.74 , 287.7028 , 109.401 , "None"));
Path.Add(new Vector3(2603.471 , 276.1615 , 110.9029 , "None"));
Path.Add(new Vector3(2608.757 , 264.4411 , 112.7115 , "None"));
Path.Add(new Vector3(2618.111 , 254.6163 , 114.4461 , "None"));
Path.Add(new Vector3(2631.521 , 245.034 , 116.2171 , "None"));
Path.Add(new Vector3(2646.344 , 236.4065 , 117.722 , "None"));
Path.Add(new Vector3(2662.746 , 227.4998 , 119.0095 , "None"));
Path.Add(new Vector3(2678.198 , 218.8228 , 119.8866 , "None"));
Path.Add(new Vector3(2691.732 , 212.6184 , 120.4085 , "None"));
Path.Add(new Vector3(2706.337 , 207.3488 , 120.8177 , "None"));
Path.Add(new Vector3(2723.107 , 202.0436 , 121.1464 , "None"));
Path.Add(new Vector3(2739.428 , 197.0271 , 121.3395 , "None"));
Path.Add(new Vector3(2756.115 , 191.533 , 121.403 , "None"));
Path.Add(new Vector3(2771.981 , 185.4084 , 121.3114 , "None"));
Path.Add(new Vector3(2786.342 , 178.3474 , 121.0472 , "None"));
Path.Add(new Vector3(2798.509 , 170.0436 , 120.5928 , "None"));
Path.Add(new Vector3(2808.051 , 159.8788 , 119.8916 , "None"));
Path.Add(new Vector3(2815.075 , 147.0312 , 118.6339 , "None"));
Path.Add(new Vector3(2819.54 , 132.513 , 116.9192 , "None"));
Path.Add(new Vector3(2822.12 , 116.7717 , 114.9265 , "None"));
Path.Add(new Vector3(2823.486 , 100.2549 , 112.8348 , "None"));
Path.Add(new Vector3(2824.312 , 83.40972 , 110.8231 , "None"));
Path.Add(new Vector3(2825.271 , 66.68443 , 109.0707 , "None"));
Path.Add(new Vector3(2827.035 , 50.52623 , 107.7565 , "None"));
Path.Add(new Vector3(2830.316 , 35.15253 , 107.0508 , "None"));
Path.Add(new Vector3(2835.136 , 19.27303 , 106.9473 , "None"));
Path.Add(new Vector3(2840.677 , 3.506355 , 107.338 , "None"));
Path.Add(new Vector3(2846.583 , -12.08025 , 108.0971 , "None"));
Path.Add(new Vector3(2852.672 , -27.87541 , 109.1314 , "None"));
Path.Add(new Vector3(2858.065 , -42.44467 , 110.2177 , "None"));
Path.Add(new Vector3(2862.927 , -57.08772 , 111.3276 , "None"));
Path.Add(new Vector3(2866.727 , -71.28181 , 112.3031 , "None"));
Path.Add(new Vector3(2869.716 , -87.48176 , 113.3063 , "None"));
Path.Add(new Vector3(2871.801 , -104.1328 , 114.577 , "None"));
Path.Add(new Vector3(2872.809 , -120.1151 , 115.9147 , "None"));
Path.Add(new Vector3(2872.797 , -135.6357 , 117.1558 , "None"));
Path.Add(new Vector3(2871.825 , -150.9025 , 118.1371 , "None"));
Path.Add(new Vector3(2869.952 , -166.1219 , 118.6951 , "None"));
Path.Add(new Vector3(2866.67 , -182.0752 , 118.6956 , "None"));
Path.Add(new Vector3(2861.511 , -198.6963 , 118.2038 , "None"));
Path.Add(new Vector3(2855.29 , -215.1633 , 117.3862 , "None"));
Path.Add(new Vector3(2848.842 , -230.7036 , 116.4106 , "None"));
Path.Add(new Vector3(2842.844 , -244.9257 , 115.4176 , "None"));
Path.Add(new Vector3(2837.893 , -257.8715 , 114.5126 , "None"));
Path.Add(new Vector3(2831.107 , -276.6639 , 112.4324 , "None"));
Path.Add(new Vector3(2827.785 , -285.7462 , 110.9506 , "None"));
Path.Add(new Vector3(2827.785 , -285.7462 , 106.9533 , "None"));
Path.Add(new Vector3(2818.994 , -288.0818 , 107.4035 , "None"));
Path.Add(new Vector3(2800.665 , -306.0541 , 108.3658 , "None"));
Path.Add(new Vector3(2777.442 , -332.0202 , 107.2082 , "None"));
Path.Add(new Vector3(2759.986 , -362.0425 , 108.8088 , "None"));
Path.Add(new Vector3(2734.487 , -385.9953 , 107.693 , "None"));
Path.Add(new Vector3(2705.743 , -405.6846 , 107.1473 , "None"));
Path.Add(new Vector3(2675.765 , -423.6221 , 107.127 , "None"));
Path.Add(new Vector3(2645.116 , -440.52 , 108.3949 , "None"));
Path.Add(new Vector3(2613.723 , -455.8615 , 109.1471 , "None"));
Path.Add(new Vector3(2579.927 , -468.4102 , 110.219 , "None"));
Path.Add(new Vector3(2548.034 , -480.045 , 111.1303 , "None"));
Path.Add(new Vector3(2522.822 , -500.7819 , 114.2853 , "None"));
Path.Add(new Vector3(2519.567 , -535.3584 , 108.9311 , "None"));
Path.Add(new Vector3(2525.84 , -570.8585 , 110.4699 , "None"));
Path.Add(new Vector3(2529.177 , -604.198 , 108.4864 , "None"));
Path.Add(new Vector3(2513.397 , -635.3079 , 110.3936 , "None"));
Path.Add(new Vector3(2497.314 , -664.3492 , 122.7805 , "None"));
Path.Add(new Vector3(2484.386 , -696.8765 , 124.8941 , "None"));
Path.Add(new Vector3(2475.951 , -730.541 , 127.3577 , "None"));
Path.Add(new Vector3(2476.131 , -766.542 , 132.5606 , "None"));
Path.Add(new Vector3(2476.564 , -800.489 , 137.0742 , "None"));
Path.Add(new Vector3(2481.637 , -835.0128 , 137.0769 , "None"));
Path.Add(new Vector3(2488.803 , -869.2566 , 137.0548 , "None"));
Path.Add(new Vector3(2495.901 , -903.5292 , 133.2047 , "None"));
Path.Add(new Vector3(2501.907 , -937.9994 , 130.9986 , "None"));
Path.Add(new Vector3(2506.97 , -972.6261 , 130.8493 , "None"));
Path.Add(new Vector3(2511.353 , -1007.318 , 128.9046 , "None"));
Path.Add(new Vector3(2505.237 , -1042.749 , 128.2465 , "None"));
Path.Add(new Vector3(2495.044 , -1075.131 , 127.7428 , "None"));
Path.Add(new Vector3(2484.111 , -1109.484 , 126.9117 , "None"));
Path.Add(new Vector3(2475.152 , -1137.632 , 125.4918 , "None"));
Path.Add(new Vector3(2467.509 , -1161.645 , 125.4315 , "None"));
Path.Add(new Vector3(2459.261 , -1195.631 , 124.8701 , "None"));
Path.Add(new Vector3(2452.243 , -1229.882 , 125.2147 , "None"));
Path.Add(new Vector3(2445.18 , -1264.162 , 124.938 , "None"));
Path.Add(new Vector3(2437.805 , -1299.449 , 125.2476 , "None"));
Path.Add(new Vector3(2430.86 , -1332.681 , 125.2491 , "None"));
Path.Add(new Vector3(2423.699 , -1366.941 , 125.2856 , "None"));
Path.Add(new Vector3(2411.721 , -1399.775 , 125.2136 , "None"));
Path.Add(new Vector3(2400.239 , -1432.837 , 125.2853 , "None"));
Path.Add(new Vector3(2388.842 , -1465.929 , 125.2882 , "None"));
Path.Add(new Vector3(2377.452 , -1498.997 , 125.286 , "None"));
Path.Add(new Vector3(2366.054 , -1532.089 , 125.286 , "None"));
Path.Add(new Vector3(2354.657 , -1565.182 , 125.2863 , "None"));
Path.Add(new Vector3(2345.413 , -1598.903 , 125.7211 , "None"));
Path.Add(new Vector3(2337.318 , -1632.95 , 125.3059 , "None"));
Path.Add(new Vector3(2324.587 , -1665.496 , 124.9439 , "None"));
Path.Add(new Vector3(2306.083 , -1695.049 , 120.6567 , "None"));
Path.Add(new Vector3(2278.202 , -1715.969 , 116.1232 , "None"));
Path.Add(new Vector3(2248.852 , -1732.325 , 117.5349 , "None"));
Path.Add(new Vector3(2218.695 , -1747.92 , 114.4464 , "None"));
Path.Add(new Vector3(2186.674 , -1764.48 , 106.1994 , "None"));
Path.Add(new Vector3(2160.461 , -1785.917 , 100.7864 , "None"));
Path.Add(new Vector3(2134.212 , -1809.064 , 99.39176 , "None"));
Path.Add(new Vector3(2107.136 , -1831.227 , 98.79871 , "None"));
Path.Add(new Vector3(2078.438 , -1853.046 , 98.51453 , "None"));
Path.Add(new Vector3(2051.413 , -1873.594 , 98.50476 , "None"));
Path.Add(new Vector3(2022.922 , -1895.675 , 98.50476 , "None"));
Path.Add(new Vector3(2002.555 , -1922.421 , 98.48787 , "None"));
Path.Add(new Vector3(1987.284 , -1953.135 , 96.52307 , "None"));
Path.Add(new Vector3(1973.388 , -1983.848 , 97.17662 , "None"));
Path.Add(new Vector3(1962.382 , -2017.072 , 97.68199 , "None"));
Path.Add(new Vector3(1954.912 , -2051.002 , 95.35399 , "None"));
Path.Add(new Vector3(1953.422 , -2085.926 , 94.22878 , "None"));
Path.Add(new Vector3(1948.485 , -2120.389 , 95.65601 , "None"));
Path.Add(new Vector3(1939.986 , -2154.341 , 97.2224 , "None"));
Path.Add(new Vector3(1931.486 , -2185.348 , 93.96601 , "None"));
Path.Add(new Vector3(1936.1 , -2220.978 , 94.31839 , "None"));
Path.Add(new Vector3(1945.337 , -2253.59 , 92.61182 , "None"));
Path.Add(new Vector3(1956.951 , -2287.718 , 91.28773 , "None"));
Path.Add(new Vector3(1970.286 , -2318.86 , 90.1467 , "None"));
Path.Add(new Vector3(1987.221 , -2350.684 , 88.48 , "None"));
Path.Add(new Vector3(2003.17 , -2380.655 , 89.54388 , "None"));
Path.Add(new Vector3(2019.657 , -2411.528 , 88.86886 , "None"));
Path.Add(new Vector3(2028.594 , -2444.327 , 91.83536 , "None"));
Path.Add(new Vector3(2045.286 , -2476.165 , 93.55705 , "None"));
Path.Add(new Vector3(2061.82 , -2505.816 , 95.40628 , "None"));
Path.Add(new Vector3(2082.714 , -2533.473 , 96.53671 , "None"));
Path.Add(new Vector3(2106.878 , -2558.698 , 99.129 , "None"));
Path.Add(new Vector3(2131.032 , -2583.912 , 103.5266 , "None"));
Path.Add(new Vector3(2155.201 , -2609.142 , 106.2381 , "None"));
Path.Add(new Vector3(2179.412 , -2634.417 , 108.1281 , "None"));
Path.Add(new Vector3(2204.738 , -2658.446 , 110.7067 , "None"));
Path.Add(new Vector3(2236.776 , -2671.861 , 113.5951 , "None"));
Path.Add(new Vector3(2270.792 , -2679.931 , 118.0384 , "None"));
Path.Add(new Vector3(2305.375 , -2689.754 , 123.4936 , "None"));
Path.Add(new Vector3(2337.972 , -2699.013 , 128.3536 , "None"));
Path.Add(new Vector3(2371.58 , -2708.558 , 133.3105 , "None"));
Path.Add(new Vector3(2405.203 , -2718.108 , 138.5724 , "None"));
Path.Add(new Vector3(2436.525 , -2733.101 , 143.0723 , "None"));
Path.Add(new Vector3(2465.347 , -2752.88 , 146.8003 , "None"));
Path.Add(new Vector3(2493.24 , -2773.896 , 151.9352 , "None"));
Path.Add(new Vector3(2515.989 , -2800.395 , 156.5083 , "None"));
Path.Add(new Vector3(2535.476 , -2829.399 , 158.8815 , "None"));
Path.Add(new Vector3(2545.785 , -2862.388 , 160.7028 , "None"));
Path.Add(new Vector3(2555.033 , -2896.119 , 162.3824 , "None"));
Path.Add(new Vector3(2566.282 , -2929.246 , 162.7447 , "None"));
Path.Add(new Vector3(2580.791 , -2960.994 , 161.699 , "None"));
Path.Add(new Vector3(2595.436 , -2988.814 , 160.9424 , "None"));
Path.Add(new Vector3(2618.408 , -3013.689 , 160.9642 , "None"));
Path.Add(new Vector3(2637.158 , -3043.243 , 161.048 , "None"));
Path.Add(new Vector3(2656.657 , -3073.564 , 161.1915 , "None"));
Path.Add(new Vector3(2675.021 , -3102.119 , 160.2261 , "None"));
Path.Add(new Vector3(2694.028 , -3131.509 , 157.5908 , "None"));
Path.Add(new Vector3(2710.851 , -3162.113 , 155.4973 , "None"));
Path.Add(new Vector3(2719.353 , -3195.877 , 150.2807 , "None"));
Path.Add(new Vector3(2725.537 , -3230.318 , 144.3912 , "None"));
Path.Add(new Vector3(2732.167 , -3264.684 , 138.478 , "None"));
Path.Add(new Vector3(2734.859 , -3298.631 , 132.6532 , "None"));
Path.Add(new Vector3(2731.491 , -3331.455 , 129.405 , "None"));
Path.Add(new Vector3(2749.663 , -3360.308 , 127.219 , "None"));
Path.Add(new Vector3(2766.505 , -3390.89 , 123.0685 , "None"));
Path.Add(new Vector3(2771.639 , -3425.299 , 116.8772 , "None"));
Path.Add(new Vector3(2794.114 , -3446.556 , 113.584 , "None"));
Path.Add(new Vector3(2822.418 , -3467.061 , 112.2437 , "None"));
Path.Add(new Vector3(2847.963 , -3490.963 , 108.4826 , "None"));
Path.Add(new Vector3(2870.688 , -3517.555 , 104.8664 , "None"));
Path.Add(new Vector3(2892.431 , -3546.288 , 101.9019 , "None"));
Path.Add(new Vector3(2908.576 , -3575.996 , 100.1085 , "None"));
Path.Add(new Vector3(2904.322 , -3589.064 , 99.40205 , "None"));
Path.Add(new Vector3(2895.669 , -3622.815 , 96.26645 , "None"));
Path.Add(new Vector3(2886.035 , -3656.404 , 94.32687 , "None"));
Path.Add(new Vector3(2874.473 , -3689.354 , 92.67799 , "None"));
Path.Add(new Vector3(2859.165 , -3720.825 , 86.26603 , "None"));
Path.Add(new Vector3(2842.482 , -3751.555 , 82.02109 , "None"));
Path.Add(new Vector3(2824.446 , -3781.548 , 87.81532 , "None"));
Path.Add(new Vector3(2804.175 , -3810.044 , 85.1177 , "None"));
Path.Add(new Vector3(2783.942 , -3839.712 , 86.0694 , "None"));
Path.Add(new Vector3(2767.823 , -3869.57 , 91.08894 , "None"));
Path.Add(new Vector3(2760.087 , -3881.434 , 93.05582 , "None"));
Path.Add(new Vector3(2752.878 , -3878.728 , 96.12908 , "None"));
Path.Add(new Vector3(2732.463 , -3874.795 , 99.03218 , "None"));
Path.Add(new Vector3(2722.886 , -3872.951 , 100.757 , "None"));
Path.Add(new Vector3(2720.401 , -3876.594 , 101.0287 , "None"));
Path.Add(new Vector3(2717.872 , -3880.12 , 101.4499 , "None"));
IsCompleteWhenAtLastPath = true;
ForceToStartFirstPosition = true;
IsHotSpots = false;
IsLoop = false;

    }

	public override bool CanConditions()
	{
        return true;
	}








}
