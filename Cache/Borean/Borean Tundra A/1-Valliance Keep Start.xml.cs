
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



public sealed class ADeserter : QuestClass
{
    public ADeserter()
    {
        Name = "A Deserter";

        QuestId.AddRange(new[] { 11604 });

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


public sealed class ADiplomaticMission : QuestClass
{
    public ADiplomaticMission()
    {
        Name = "A Diplomatic Mission";

        QuestId.AddRange(new[] { 12141 });

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


public sealed class AFathersWords : QuestClass
{
    public AFathersWords()
    {
        Name = "A Father's Words";

        QuestId.AddRange(new[] { 11620 });

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


public sealed class ASoldierinNeed : QuestGathererClass
{
    public ASoldierinNeed()
    {
        Name = "A Soldier in Need";

        QuestId.AddRange(new[] { 11789 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(187980);
HotSpots.Add(new Vector3(2236.739 , 5257.126 , 3.527331 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ATimeforHeroes : QuestClass
{
    public ATimeforHeroes()
    {
        Name = "A Time for Heroes";

        QuestId.AddRange(new[] { 11727 });

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

        Path.Add(new Vector3(1503.531 , 5554.28 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1511.083 , 5560.863 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1522.095 , 5570.281 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1533.433 , 5580.144 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1544.502 , 5590.96 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1553.747 , 5602.148 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1562.548 , 5614.257 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1571.567 , 5626.236 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1581.353 , 5637.604 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1591.176 , 5648.94 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1601.333 , 5660.662 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1611.355 , 5671.148 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1622.943 , 5680.609 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1635.224 , 5689.216 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1648.319 , 5697.525 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1661.128 , 5705.388 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1673.452 , 5712.952 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1686.671 , 5721.065 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1699.455 , 5728.911 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1712.239 , 5736.758 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1724.583 , 5744.403 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1736.649 , 5753.257 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1748.709 , 5762.997 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1759.722 , 5773.18 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1770.724 , 5782.643 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1783.091 , 5791.178 , -1.524222 , "Swimming"));
Path.Add(new Vector3(1793.281 , 5797.232 , -1.223004 , "None"));
Path.Add(new Vector3(1796.34 , 5798.933 , -0.6381187 , "None"));
Path.Add(new Vector3(1799.401 , 5800.62 , -0.2259784 , "None"));
Path.Add(new Vector3(1802.467 , 5802.309 , 0.05923475 , "None"));
Path.Add(new Vector3(1805.533 , 5803.997 , 0.211557 , "None"));
Path.Add(new Vector3(1808.556 , 5805.761 , 0.2742236 , "None"));
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


public sealed class BellRope : QuestFollowPathClass
{
    public BellRope()
    {
        Name = "Bell Rope";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2619.734 , 5258.268 , 38.27182 , "None"));
Path.Add(new Vector3(2618.319 , 5260.401 , 39.38754 , "None"));
Path.Add(new Vector3(2617.753 , 5263.554 , 39.40965 , "None"));
Path.Add(new Vector3(2619.335 , 5264.76 , 40.09038 , "None"));
Path.Add(new Vector3(2620.349 , 5266.644 , 40.71351 , "None"));
Path.Add(new Vector3(2618.695 , 5267.742 , 42.11678 , "None"));
Path.Add(new Vector3(2615.568 , 5269.373 , 43.14205 , "None"));
Path.Add(new Vector3(2612.968 , 5267.254 , 45.33358 , "None"));
Path.Add(new Vector3(2611.338 , 5264.271 , 46.05455 , "None"));
Path.Add(new Vector3(2612.82 , 5261.199 , 48.18074 , "None"));
Path.Add(new Vector3(2615.838 , 5259.995 , 48.2433 , "None"));
Path.Add(new Vector3(2616.314 , 5261.304 , 48.28043 , "None"));
Path.Add(new Vector3(2618.344 , 5263.402 , 48.25826 , "None"));
Path.Add(new Vector3(2620.242 , 5265.357 , 48.17087 , "None"));
Path.Add(new Vector3(2619.16 , 5266.413 , 48.23115 , "None"));
Path.Add(new Vector3(2617.15 , 5268.372 , 48.34468 , "None"));
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


public sealed class CalltoArms : QuestGathererClass
{
    public CalltoArms()
    {
        Name = "Call to Arms!";

        QuestId.AddRange(new[] { 11965 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188163);
HotSpots.Add(new Vector3(2618.824 , 5263.502 , 48.24162 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CowardsandFools : QuestClass
{
    public CowardsandFools()
    {
        Name = "Cowards and Fools";

        QuestId.AddRange(new[] { 11932 });

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


public sealed class CrueltyoftheKvaldir : QuestClass
{
    public CrueltyoftheKvaldir()
    {
        Name = "Cruelty of the Kvaldir";

        QuestId.AddRange(new[] { 12471 });

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


public sealed class CultistsAmongUs : QuestClass
{
    public CultistsAmongUs()
    {
        Name = "Cultists Among Us";

        QuestId.AddRange(new[] { 11920 });

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


public sealed class DeathFromAbove : QuestGrinderClass
{
    public DeathFromAbove()
    {
        Name = "Death From Above";

        QuestId.AddRange(new[] { 11889 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25582);
HotSpots.Add(new Vector3(2198.595 , 5403.959 , 0.519819 , "None"));

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


public sealed class Dive : QuestFollowPathClass
{
    public Dive()
    {
        Name = "Dive";

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

        Path.Add(new Vector3(1511.728 , 5576.541 , -1.67652 , "Swimming"));
Path.Add(new Vector3(1510.4 , 5573.904 , -3.580729 , "Swimming"));
Path.Add(new Vector3(1509.783 , 5571.188 , -7.394147 , "Swimming"));
Path.Add(new Vector3(1509.758 , 5571.11 , -12.11565 , "Swimming"));
Path.Add(new Vector3(1509.724 , 5570.999 , -16.83297 , "Swimming"));
Path.Add(new Vector3(1511.643 , 5569.26 , -20.42788 , "Swimming"));
Path.Add(new Vector3(1511.473 , 5568.887 , -24.81452 , "Swimming"));
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


public sealed class EnemiesoftheLight : QuestGrinderClass
{
    public EnemiesoftheLight()
    {
        Name = "Enemies of the Light";

        QuestId.AddRange(new[] { 11792 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25651);
HotSpots.Add(new Vector3(2450.581 , 5405.107 , 22.25046 , "None"));
HotSpots.Add(new Vector3(2492.73 , 5451.12 , 29.72239 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class EnlistmentDay : QuestClass
{
    public EnlistmentDay()
    {
        Name = "Enlistment Day";

        QuestId.AddRange(new[] { 11672 });

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


public sealed class Evac : QuestFollowPathClass
{
    public Evac()
    {
        Name = "Evac";

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

        Path.Add(new Vector3(1453.448 , 5521.38 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1464.395 , 5525.156 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1478.327 , 5531.678 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1491.268 , 5539.262 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1504.209 , 5546.847 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1517.177 , 5554.446 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1529.784 , 5562.454 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1541.005 , 5572.408 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1550.673 , 5583.809 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1559.718 , 5595.775 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1568.762 , 5607.742 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1577.807 , 5619.708 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1586.682 , 5631.79 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1594.257 , 5644.736 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1601.833 , 5657.683 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1609.576 , 5670.522 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1618.163 , 5682.821 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1626.75 , 5695.12 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1635.355 , 5707.443 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1643.807 , 5719.826 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1649.818 , 5733.569 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1655.807 , 5747.289 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1661.82 , 5761.063 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1667.821 , 5774.811 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1673.822 , 5788.558 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1679.824 , 5802.305 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1685.825 , 5816.052 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1691.826 , 5829.799 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1697.815 , 5843.519 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1703.828 , 5857.294 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1709.817 , 5871.014 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1713.195 , 5885.467 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1714.067 , 5900.442 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1718.109 , 5914.706 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1724.583 , 5928.198 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1733.141 , 5940.517 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1741.699 , 5952.836 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1750.257 , 5965.155 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1758.815 , 5977.474 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1765.967 , 5990.62 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1773.298 , 6002.524 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1781.362 , 6015.064 , -1.674675 , "Swimming"));
Path.Add(new Vector3(1784.05 , 6020.595 , -0.08183531 , "None"));
Path.Add(new Vector3(1785.858 , 6024.321 , 0.2393317 , "None"));
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


public sealed class Exit : QuestFollowPathClass
{
    public Exit()
    {
        Name = "Exit";

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

        Path.Add(new Vector3(1472.352 , 5415.507 , 38.13309 , "None"));
Path.Add(new Vector3(1467.099 , 5419.465 , 37.45865 , "None"));
Path.Add(new Vector3(1464.008 , 5422.032 , 35.76917 , "None"));
Path.Add(new Vector3(1461.366 , 5425.237 , 33.99091 , "None"));
Path.Add(new Vector3(1458.892 , 5428.237 , 32.20029 , "None"));
Path.Add(new Vector3(1456.332 , 5431.343 , 30.37152 , "None"));
Path.Add(new Vector3(1454.042 , 5434.613 , 28.9521 , "None"));
Path.Add(new Vector3(1453.2 , 5438.517 , 28.37322 , "None"));
Path.Add(new Vector3(1454.277 , 5442.382 , 28.37322 , "None"));
Path.Add(new Vector3(1455.727 , 5446.146 , 28.37322 , "None"));
Path.Add(new Vector3(1457.137 , 5449.914 , 28.37322 , "None"));
Path.Add(new Vector3(1457.531 , 5453.855 , 29.10636 , "None"));
Path.Add(new Vector3(1457.118 , 5457.858 , 26.8956 , "None"));
Path.Add(new Vector3(1456.743 , 5461.875 , 22.4228 , "None"));
Path.Add(new Vector3(1456.51 , 5466.016 , 22.4228 , "None"));
Path.Add(new Vector3(1457.414 , 5469.643 , 22.4228 , "None"));
Path.Add(new Vector3(1455.809 , 5473.267 , 22.4228 , "None"));
Path.Add(new Vector3(1452.463 , 5475.504 , 22.4228 , "None"));
Path.Add(new Vector3(1448.677 , 5476.764 , 22.4228 , "None"));
Path.Add(new Vector3(1445.135 , 5478.629 , 22.4228 , "None"));
Path.Add(new Vector3(1442.258 , 5481.419 , 21.39568 , "None"));
Path.Add(new Vector3(1439.512 , 5484.363 , 18.8921 , "None"));
Path.Add(new Vector3(1436.766 , 5487.306 , 11.82191 , "None"));
Path.Add(new Vector3(1433.043 , 5489.073 , 10.51209 , "None"));
Path.Add(new Vector3(1432.026 , 5492.831 , 10.632 , "None"));
Path.Add(new Vector3(1432.479 , 5496.361 , 10.74825 , "None"));
Path.Add(new Vector3(1434.396 , 5499.744 , 8.900367 , "None"));
Path.Add(new Vector3(1436.45 , 5503.364 , 2.00369 , "None"));
Path.Add(new Vector3(1438.173 , 5505.534 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1446.79 , 5513.225 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1454.656 , 5520.696 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1462.47 , 5527.009 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1472.021 , 5532.17 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1480.945 , 5536.993 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1490.182 , 5541.984 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1498.825 , 5547.866 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1506.901 , 5554.577 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1514.976 , 5561.288 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1523.052 , 5567.999 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1530.452 , 5575.438 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1537.358 , 5583.319 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1544.278 , 5591.215 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1551.114 , 5599.179 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1556.343 , 5608.308 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1561.543 , 5617.406 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1566.765 , 5626.54 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1572.966 , 5634.936 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1580.143 , 5642.601 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1586.532 , 5650.871 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1592.427 , 5659.585 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1598.31 , 5668.283 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1604.181 , 5676.962 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1610.075 , 5685.677 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1615.958 , 5694.375 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1621.841 , 5703.072 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1628.674 , 5711.015 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1635.851 , 5718.679 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1641.396 , 5727.56 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1646.607 , 5736.676 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1651.817 , 5745.792 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1657.039 , 5754.925 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1660.88 , 5764.611 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1663.819 , 5774.691 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1666.758 , 5784.771 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1669.696 , 5794.852 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1672.635 , 5804.932 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1675.574 , 5815.013 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1678.171 , 5825.172 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1679.905 , 5835.528 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1681.639 , 5845.884 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1682.56 , 5856.29 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1681.853 , 5866.766 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1681.146 , 5877.242 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1680.439 , 5887.718 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1679.732 , 5898.194 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1679.025 , 5908.67 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1678.316 , 5919.167 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1677.988 , 5929.616 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1679.355 , 5940.027 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1680.724 , 5950.458 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1684.822 , 5960.086 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1689.347 , 5969.537 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1695.869 , 5977.786 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1702.467 , 5985.954 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1710.321 , 5992.819 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1717.738 , 6000.195 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1725.601 , 6007.06 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1734.758 , 6012.188 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1743.298 , 6018.152 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1751.098 , 6025.181 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1758.899 , 6032.21 , -1.690822 , "Swimming"));
Path.Add(new Vector3(1764.415 , 6036.998 , -1.361788 , "Swimming"));
Path.Add(new Vector3(1762.553 , 6040.214 , -0.1932529 , "None"));
Path.Add(new Vector3(1764.227 , 6044.898 , 0.00905678 , "None"));
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


public sealed class Farshire : QuestClass
{
    public Farshire()
    {
        Name = "Farshire";

        QuestId.AddRange(new[] { 11928 });

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


public sealed class FindingthePhylactery : QuestGrinderClass
{
    public FindingthePhylactery()
    {
        Name = "Finding the Phylactery";

        QuestId.AddRange(new[] { 11956 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(3615.445 , 3647.833 , 24.67899 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class FruitsofOurLabor : QuestGathererClass
{
    public FruitsofOurLabor()
    {
        Name = "Fruits of Our Labor";

        QuestId.AddRange(new[] { 11904 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188104);
HotSpots.Add(new Vector3(2796.238 , 5274.197 , 21.61637 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class FruitsofOurLabor1 : QuestGrinderClass
{
    public FruitsofOurLabor1()
    {
        Name = "Fruits of Our Labor1";

        QuestId.AddRange(new[] { 11904 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26252);
HotSpots.Add(new Vector3(2849.36 , 5229.06 , 12.93524 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(35705) >= 1;
}



public override bool HasQuest() { return true; }


}


public sealed class FurtherInvestigation : QuestClass
{
    public FurtherInvestigation()
    {
        Name = "Further Investigation";

        QuestId.AddRange(new[] { 11793 });

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


public sealed class GameltheCruel : QuestGrinderClass
{
    public GameltheCruel()
    {
        Name = "Gamel the Cruel";

        QuestId.AddRange(new[] { 11619 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26449);
HotSpots.Add(new Vector3(1887.32 , 5894.818 , -5.571503 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Ice : QuestFollowPathClass
{
    public Ice()
    {
        Name = "Ice";

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

        Path.Add(new Vector3(2977.473 , 4872.911 , 0.3964267 , "None"));
Path.Add(new Vector3(2970.595 , 4868.059 , 0.3964267 , "None"));
Path.Add(new Vector3(2963.585 , 4863.162 , 0.3964267 , "None"));
Path.Add(new Vector3(2956.762 , 4858.408 , 0.3964267 , "None"));
Path.Add(new Vector3(2949.622 , 4853.433 , 0.3964267 , "None"));
Path.Add(new Vector3(2942.714 , 4848.596 , 0.3964267 , "None"));
Path.Add(new Vector3(2935.914 , 4843.166 , 0.3964267 , "None"));
Path.Add(new Vector3(2928.892 , 4839.453 , 0.3964267 , "None"));
Path.Add(new Vector3(2922.083 , 4835.467 , 0.3964267 , "None"));
Path.Add(new Vector3(2916.225 , 4829.404 , 0.3964267 , "None"));
Path.Add(new Vector3(2909.342 , 4824.052 , -2.127867 , "None"));
Path.Add(new Vector3(2905.458 , 4821.017 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2901.663 , 4818.051 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2897.868 , 4815.084 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2894.133 , 4812.165 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2890.338 , 4809.198 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2887.143 , 4805.6 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2884.047 , 4802.01 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2880.953 , 4798.423 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2877.807 , 4794.776 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2874.658 , 4791.125 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2871.848 , 4787.231 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2869.323 , 4783.229 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2866.05 , 4779.695 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2863.352 , 4775.718 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2859.191 , 4769.216 , 0.08358613 , "None"));
Path.Add(new Vector3(2854.053 , 4762.479 , 0.08358613 , "None"));
Path.Add(new Vector3(2847.566 , 4757.143 , 0.08358613 , "None"));
Path.Add(new Vector3(2841.043 , 4751.357 , 0.3918849 , "None"));
Path.Add(new Vector3(2835.314 , 4745.217 , 1.836967 , "None"));
Path.Add(new Vector3(2830.222 , 4738.515 , 1.997785 , "None"));
Path.Add(new Vector3(2824.794 , 4732.081 , 2.496341 , "None"));
Path.Add(new Vector3(2818.299 , 4726.268 , 2.560774 , "None"));
Path.Add(new Vector3(2811.834 , 4720.853 , 1.977373 , "None"));
Path.Add(new Vector3(2807.107 , 4716.894 , 1.937664 , "None"));
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


public sealed class Ice0 : QuestFollowPathClass
{
    public Ice0()
    {
        Name = "Ice0";

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

        Path.Add(new Vector3(2798.036 , 4684.858 , 2.426673 , "None"));
Path.Add(new Vector3(2799.107 , 4680.501 , 2.615377 , "None"));
Path.Add(new Vector3(2802.258 , 4672.69 , 2.667718 , "None"));
Path.Add(new Vector3(2806.44 , 4665.057 , 1.788986 , "None"));
Path.Add(new Vector3(2811.358 , 4658.232 , 2.562727 , "None"));
Path.Add(new Vector3(2817.065 , 4652.026 , 2.437693 , "None"));
Path.Add(new Vector3(2823.167 , 4646.205 , 2.430194 , "None"));
Path.Add(new Vector3(2829.471 , 4640.206 , 2.111064 , "None"));
Path.Add(new Vector3(2835.581 , 4634.392 , 1.99758 , "None"));
Path.Add(new Vector3(2841.882 , 4628.396 , 2.199652 , "None"));
Path.Add(new Vector3(2847.989 , 4622.584 , 2.143067 , "None"));
Path.Add(new Vector3(2854.099 , 4616.771 , 0.7726434 , "None"));
Path.Add(new Vector3(2860.302 , 4611.086 , 0.08372796 , "None"));
Path.Add(new Vector3(2864.23 , 4603.667 , 0.08372796 , "None"));
Path.Add(new Vector3(2863.387 , 4595.934 , 0.08372796 , "None"));
Path.Add(new Vector3(2866.16 , 4587.67 , 0.6775902 , "None"));
Path.Add(new Vector3(2869.058 , 4579.75 , 1.436774 , "None"));
Path.Add(new Vector3(2871.82 , 4572.223 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2873.792 , 4567.824 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2875.78 , 4563.436 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2877.736 , 4559.118 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2879.739 , 4554.696 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2881.69 , 4550.39 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2883.51 , 4546.373 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2885.655 , 4541.636 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2887.621 , 4537.296 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2889.47 , 4533.214 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2891.587 , 4528.543 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2893.524 , 4524.267 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2895.531 , 4519.837 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2897.501 , 4515.488 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2899.434 , 4511.221 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2901.46 , 4506.748 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2903.419 , 4502.425 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2905.381 , 4498.093 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2907.394 , 4493.65 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2906.025 , 4489.831 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2904.485 , 4485.344 , -2.323642 , "Swimming"));
Path.Add(new Vector3(2903.994 , 4481.236 , -2.450402 , "Swimming"));
Path.Add(new Vector3(2904.154 , 4477.139 , -2.521089 , "Swimming"));
Path.Add(new Vector3(2905.945 , 4472.708 , -2.521089 , "Swimming"));
Path.Add(new Vector3(2904.302 , 4468.375 , -2.529458 , "Swimming"));
Path.Add(new Vector3(2904.459 , 4464.052 , -2.588113 , "Swimming"));
Path.Add(new Vector3(2906.438 , 4459.682 , -2.588113 , "Swimming"));
Path.Add(new Vector3(2907.047 , 4455.639 , -2.588113 , "Swimming"));
Path.Add(new Vector3(2906.34 , 4451.712 , -2.595897 , "Swimming"));
Path.Add(new Vector3(2907.028 , 4447.145 , -2.652132 , "Swimming"));
Path.Add(new Vector3(2908.134 , 4442.707 , -2.688849 , "Swimming"));
Path.Add(new Vector3(2909.98 , 4438.751 , -2.81838 , "Swimming"));
Path.Add(new Vector3(2912.047 , 4435.393 , -3.001595 , "Swimming"));
Path.Add(new Vector3(2915.76 , 4433.451 , -2.572078 , "Swimming"));
Path.Add(new Vector3(2917.659 , 4429.912 , -2.400576 , "Swimming"));
Path.Add(new Vector3(2918.452 , 4426.223 , -2.400576 , "Swimming"));
Path.Add(new Vector3(2916.414 , 4421.821 , -1.795465 , "None"));
Path.Add(new Vector3(2916.13 , 4412.265 , 0.372513 , "None"));
Path.Add(new Vector3(2915.941 , 4403.833 , 0.372513 , "None"));
Path.Add(new Vector3(2918.159 , 4396.149 , 1.639827 , "None"));
Path.Add(new Vector3(2923.264 , 4389.12 , 1.936391 , "None"));
Path.Add(new Vector3(2929.662 , 4383.221 , 1.074424 , "None"));
Path.Add(new Vector3(2935.85 , 4377.515 , 3.368072 , "None"));
Path.Add(new Vector3(2943.309 , 4375.226 , 5.564216 , "None"));
Path.Add(new Vector3(2949.719 , 4369.315 , 8.089249 , "None"));
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


public sealed class InWineTruth : QuestGathererClass
{
    public InWineTruth()
    {
        Name = "In Wine, Truth";

        QuestId.AddRange(new[] { 11603 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188131);
HotSpots.Add(new Vector3(2374.555 , 5003.371 , -37.47969 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ItsTimeforAction : QuestGrinderClass
{
    public ItsTimeforAction()
    {
        Name = "It's Time for Action";

        QuestId.AddRange(new[] { 11903 });

        Step = new List<int> { 14, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25650);
HotSpots.Add(new Vector3(2527.612 , 5325.849 , 33.11892 , "None"));
HotSpots.Add(new Vector3(2572.224 , 5408.434 , 35.00418 , "None"));
HotSpots.Add(new Vector3(2575.847 , 5285.804 , 35.79844 , "None"));
HotSpots.Add(new Vector3(2606.135 , 5369.609 , 32.8636 , "None"));
HotSpots.Add(new Vector3(2570.441 , 5337.986 , 31.01925 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KaruksOath : QuestGrinderClass
{
    public KaruksOath()
    {
        Name = "Karuk's Oath";

        QuestId.AddRange(new[] { 11613 });

        Step = new List<int> { 6, 5, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25521);
EntryTarget.Add(25522);
HotSpots.Add(new Vector3(1920.53 , 5770.22 , 6.306328 , "None"));
HotSpots.Add(new Vector3(1868.55 , 5694.1 , 0.3161544 , "None"));
HotSpots.Add(new Vector3(1896.16 , 5667.92 , 5.842059 , "None"));
HotSpots.Add(new Vector3(1856.79 , 5734.71 , -0.09322493 , "None"));
HotSpots.Add(new Vector3(1802.26 , 5846.73 , 0.3417568 , "None"));
HotSpots.Add(new Vector3(1820.845 , 5878.247 , 2.296255 , "None"));
HotSpots.Add(new Vector3(1962.77 , 5996.6 , 12.81664 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LostandFound : QuestClass
{
    public LostandFound()
    {
        Name = "Lost and Found";

        QuestId.AddRange(new[] { 11601 });

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


public sealed class MilitaryWhatMilitary : QuestClass
{
    public MilitaryWhatMilitary()
    {
        Name = "Military? What Military?";

        QuestId.AddRange(new[] { 11901 });

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


public sealed class MuahitsWisdom : QuestClass
{
    public MuahitsWisdom()
    {
        Name = "Muahit's Wisdom";

        QuestId.AddRange(new[] { 11950 });

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


public sealed class NotWithoutaFight : QuestGrinderClass
{
    public NotWithoutaFight()
    {
        Name = "Not Without a Fight!";

        QuestId.AddRange(new[] { 11949 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25760);
HotSpots.Add(new Vector3(3084.78 , 4855.13 , 2.73526 , "None"));
HotSpots.Add(new Vector3(3093.192 , 4879.544 , 0.3963848 , "None"));
HotSpots.Add(new Vector3(3145.12 , 4822.77 , 3.037878 , "None"));
HotSpots.Add(new Vector3(3060 , 4836.07 , 3.824364 , "None"));
HotSpots.Add(new Vector3(3057.03 , 4810.47 , 1.413691 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class NotifyArlos : QuestClass
{
    public NotifyArlos()
    {
        Name = "Notify Arlos";

        QuestId.AddRange(new[] { 11791 });

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


public sealed class OneLastDelivery : QuestClass
{
    public OneLastDelivery()
    {
        Name = "One Last Delivery";

        QuestId.AddRange(new[] { 11962 });

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


public sealed class PerniciousEvidence : QuestClass
{
    public PerniciousEvidence()
    {
        Name = "Pernicious Evidence";

        QuestId.AddRange(new[] { 11902 });

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


public sealed class PlugtheSinkholes : QuestClass
{
    public PlugtheSinkholes()
    {
        Name = "Plug the Sinkholes";

        QuestId.AddRange(new[] { 11897 });

        Step = new List<int> { 1, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

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


public sealed class PlugtheSinkholes1 : QuestFollowPathClass
{
    public PlugtheSinkholes1()
    {
        Name = "Plug the Sinkholes1";

        QuestId.AddRange(new[] { 11897 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2118.224 , 5637.938 , 30.01103 , "None"));
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


public sealed class PlugtheSinkholes2 : QuestFollowPathClass
{
    public PlugtheSinkholes2()
    {
        Name = "Plug the Sinkholes2";

        QuestId.AddRange(new[] { 11897 });

        Step = new List<int> { 0, 1, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(2473.383 , 5412.945 , 20.61485 , "None"));
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


public sealed class PreparingfortheWorst : QuestGathererClass
{
    public PreparingfortheWorst()
    {
        Name = "Preparing for the Worst";

        QuestId.AddRange(new[] { 11945 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188164);
HotSpots.Add(new Vector3(3083.601 , 4851.105 , 3.148941 , "None"));
HotSpots.Add(new Vector3(3091.854 , 4834.037 , 1.773981 , "None"));
HotSpots.Add(new Vector3(3102.001 , 4805.632 , 1.417725 , "None"));
HotSpots.Add(new Vector3(3133.035 , 4754.496 , 8.122057 , "None"));
HotSpots.Add(new Vector3(3058.724 , 4768.604 , 1.458647 , "None"));
HotSpots.Add(new Vector3(3029.759 , 4724.772 , 0.3974703 , "None"));
HotSpots.Add(new Vector3(3053.167 , 4808.016 , 1.752067 , "None"));
HotSpots.Add(new Vector3(3001.287 , 4848.395 , 0.3965523 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReferenceMaterial : QuestGathererClass
{
    public ReferenceMaterial()
    {
        Name = "Reference Material";

        QuestId.AddRange(new[] { 11908 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188120);
HotSpots.Add(new Vector3(2653.966 , 5354.908 , 34.75713 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RepurposedTechnology : QuestInteractWithClass
{
    public RepurposedTechnology()
    {
        Name = "Repurposed Technology";

        QuestId.AddRange(new[] { 12035 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(25623);
HotSpots.Add(new Vector3(2526.693 , 5206.712 , 37.40726 , "None"));
HotSpots.Add(new Vector3(2557.631 , 5192.839 , 37.40726 , "None"));
HotSpots.Add(new Vector3(2564.573 , 5241.665 , 37.4073 , "None"));
HotSpots.Add(new Vector3(2504.383 , 5300.175 , 33.07204 , "None"));
HotSpots.Add(new Vector3(2506.72 , 5328.279 , 33.07402 , "None"));
HotSpots.Add(new Vector3(2520.552 , 5312.382 , 33.07429 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "Lua.RunMacroText(\"/TargetLastEnemy\"); Lua.RunMacroText(\"/use Jeremiah's Tools\"); ";
IgnoreIfDead = true;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SpiritsWatchOverUs : QuestInteractWithClass
{
    public SpiritsWatchOverUs()
    {
        Name = "Spirits Watch Over Us";

        QuestId.AddRange(new[] { 11961 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26219);
HotSpots.Add(new Vector3(2960.39 , 4671.32 , -32.5808 , "None"));
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


public sealed class Surrounded : QuestGrinderClass
{
    public Surrounded()
    {
        Name = "Surrounded!";

        QuestId.AddRange(new[] { 11944 });

        Step = new List<int> { 7, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26202);
HotSpots.Add(new Vector3(3207.332 , 3797.734 , 26.99665 , "None"));
HotSpots.Add(new Vector3(3280.131 , 3828.775 , 27.05548 , "None"));
HotSpots.Add(new Vector3(3322.728 , 3810.442 , 28.99711 , "None"));
HotSpots.Add(new Vector3(3285.409 , 3760.736 , 24.4973 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Swim1 : QuestFollowPathClass
{
    public Swim1()
    {
        Name = "Swim 1";

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

        Path.Add(new Vector3(1692.214 , 5914.662 , -1.662 , "Swimming"));
Path.Add(new Vector3(1688.114 , 5910.997 , -1.662 , "Swimming"));
Path.Add(new Vector3(1685.163 , 5907.311 , -1.662 , "Swimming"));
Path.Add(new Vector3(1682.211 , 5903.625 , -1.662 , "Swimming"));
Path.Add(new Vector3(1679.262 , 5899.942 , -1.662 , "Swimming"));
Path.Add(new Vector3(1676.308 , 5896.252 , -1.662 , "Swimming"));
Path.Add(new Vector3(1673.356 , 5892.566 , -1.662 , "Swimming"));
Path.Add(new Vector3(1670.355 , 5888.817 , -1.662 , "Swimming"));
Path.Add(new Vector3(1667.406 , 5885.135 , -1.662 , "Swimming"));
Path.Add(new Vector3(1664.502 , 5881.508 , -1.662 , "Swimming"));
Path.Add(new Vector3(1662.871 , 5877.094 , -1.662 , "Swimming"));
Path.Add(new Vector3(1661.378 , 5872.615 , -1.662 , "Swimming"));
Path.Add(new Vector3(1659.884 , 5868.135 , -1.662 , "Swimming"));
Path.Add(new Vector3(1658.391 , 5863.655 , -1.662 , "Swimming"));
Path.Add(new Vector3(1656.898 , 5859.175 , -1.662 , "Swimming"));
Path.Add(new Vector3(1655.379 , 5854.619 , -1.662 , "Swimming"));
Path.Add(new Vector3(1653.911 , 5850.215 , -1.662 , "Swimming"));
Path.Add(new Vector3(1652.417 , 5845.73 , -1.662 , "Swimming"));
Path.Add(new Vector3(1650.925 , 5841.255 , -1.662 , "Swimming"));
Path.Add(new Vector3(1649.405 , 5836.695 , -1.662 , "Swimming"));
Path.Add(new Vector3(1647.937 , 5832.291 , -1.662 , "Swimming"));
Path.Add(new Vector3(1646.42 , 5827.739 , -1.662 , "Swimming"));
Path.Add(new Vector3(1644.95 , 5823.331 , -1.662 , "Swimming"));
Path.Add(new Vector3(1643.458 , 5818.855 , -1.662 , "Swimming"));
Path.Add(new Vector3(1641.94 , 5814.3 , -1.662 , "Swimming"));
Path.Add(new Vector3(1640.47 , 5809.892 , -1.662 , "Swimming"));
Path.Add(new Vector3(1638.977 , 5805.412 , -1.662 , "Swimming"));
Path.Add(new Vector3(1637.46 , 5800.86 , -1.662 , "Swimming"));
Path.Add(new Vector3(1636.653 , 5796.287 , -1.662 , "Swimming"));
Path.Add(new Vector3(1635.87 , 5791.554 , -1.662 , "Swimming"));
Path.Add(new Vector3(1635.112 , 5786.969 , -1.662 , "Swimming"));
Path.Add(new Vector3(1634.329 , 5782.236 , -1.662 , "Swimming"));
Path.Add(new Vector3(1633.571 , 5777.651 , -1.662 , "Swimming"));
Path.Add(new Vector3(1632.801 , 5772.992 , -1.662 , "Swimming"));
Path.Add(new Vector3(1632.031 , 5768.333 , -1.662 , "Swimming"));
Path.Add(new Vector3(1631.247 , 5763.595 , -1.662 , "Swimming"));
Path.Add(new Vector3(1630.489 , 5759.011 , -1.662 , "Swimming"));
Path.Add(new Vector3(1629.719 , 5754.356 , -1.662 , "Swimming"));
Path.Add(new Vector3(1628.948 , 5749.693 , -1.662 , "Swimming"));
Path.Add(new Vector3(1628.178 , 5745.039 , -1.662 , "Swimming"));
Path.Add(new Vector3(1625.655 , 5741.038 , -1.662 , "Swimming"));
Path.Add(new Vector3(1622.157 , 5737.896 , -1.662 , "Swimming"));
Path.Add(new Vector3(1618.845 , 5734.639 , -1.662 , "Swimming"));
Path.Add(new Vector3(1616.128 , 5730.856 , -1.662 , "Swimming"));
Path.Add(new Vector3(1614.515 , 5726.448 , -1.662 , "Swimming"));
Path.Add(new Vector3(1612.857 , 5722.041 , -1.662 , "Swimming"));
Path.Add(new Vector3(1610.796 , 5717.82 , -1.662 , "Swimming"));
Path.Add(new Vector3(1608.449 , 5713.755 , -1.662 , "Swimming"));
Path.Add(new Vector3(1606.054 , 5709.609 , -1.662 , "Swimming"));
Path.Add(new Vector3(1603.458 , 5705.755 , -1.662 , "Swimming"));
Path.Add(new Vector3(1600.823 , 5701.842 , -1.662 , "Swimming"));
Path.Add(new Vector3(1598.185 , 5697.925 , -1.662 , "Swimming"));
Path.Add(new Vector3(1595.547 , 5694.009 , -1.662 , "Swimming"));
Path.Add(new Vector3(1592.909 , 5690.092 , -1.662 , "Swimming"));
Path.Add(new Vector3(1590.271 , 5686.175 , -1.662 , "Swimming"));
Path.Add(new Vector3(1587.631 , 5682.254 , -1.662 , "Swimming"));
Path.Add(new Vector3(1585.291 , 5678.188 , -1.662 , "Swimming"));
Path.Add(new Vector3(1583.638 , 5673.759 , -1.662 , "Swimming"));
Path.Add(new Vector3(1581.989 , 5669.339 , -1.662 , "Swimming"));
Path.Add(new Vector3(1579.611 , 5665.264 , -1.662 , "Swimming"));
Path.Add(new Vector3(1577.133 , 5661.245 , -1.662 , "Swimming"));
Path.Add(new Vector3(1574.654 , 5657.225 , -1.662 , "Swimming"));
Path.Add(new Vector3(1572.175 , 5653.206 , -1.662 , "Swimming"));
Path.Add(new Vector3(1569.696 , 5649.187 , -1.662 , "Swimming"));
Path.Add(new Vector3(1567.217 , 5645.167 , -1.662 , "Swimming"));
Path.Add(new Vector3(1564.698 , 5641.084 , -1.662 , "Swimming"));
Path.Add(new Vector3(1562.219 , 5637.064 , -1.662 , "Swimming"));
Path.Add(new Vector3(1559.738 , 5633.042 , -1.662 , "Swimming"));
Path.Add(new Vector3(1557.239 , 5629.037 , -1.662 , "Swimming"));
Path.Add(new Vector3(1553.886 , 5625.813 , -1.662 , "Swimming"));
Path.Add(new Vector3(1551.383 , 5621.832 , -1.662 , "Swimming"));
Path.Add(new Vector3(1549.402 , 5617.54 , -1.662 , "Swimming"));
Path.Add(new Vector3(1547.391 , 5613.184 , -1.662 , "Swimming"));
Path.Add(new Vector3(1545.411 , 5608.897 , -1.662 , "Swimming"));
Path.Add(new Vector3(1543.432 , 5604.609 , -1.662 , "Swimming"));
Path.Add(new Vector3(1541.453 , 5600.322 , -1.662 , "Swimming"));
Path.Add(new Vector3(1539.474 , 5596.035 , -1.662 , "Swimming"));
Path.Add(new Vector3(1537.493 , 5591.743 , -1.662 , "Swimming"));
Path.Add(new Vector3(1535.516 , 5587.459 , -1.662 , "Swimming"));
Path.Add(new Vector3(1533.536 , 5583.172 , -1.662 , "Swimming"));
Path.Add(new Vector3(1531.557 , 5578.885 , -1.662 , "Swimming"));
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


public sealed class TakeNoChances : QuestUseItemOnClass
{
    public TakeNoChances()
    {
        Name = "Take No Chances";

        QuestId.AddRange(new[] { 11913 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(188112);
HotSpots.Add(new Vector3(2521.222 , 5325.342 , 33.11782 , "None"));
HotSpots.Add(new Vector3(2508.367 , 5339.759 , 33.09827 , "None"));
HotSpots.Add(new Vector3(2526.861 , 5346.562 , 32.86219 , "None"));
HotSpots.Add(new Vector3(2544.242 , 5372.901 , 32.86326 , "None"));
HotSpots.Add(new Vector3(2530.463 , 5390.584 , 32.86326 , "None"));
HotSpots.Add(new Vector3(2568.515 , 5382.079 , 32.86353 , "None"));
HotSpots.Add(new Vector3(2596.591 , 5397.789 , 32.86353 , "None"));
HotSpots.Add(new Vector3(2610.628 , 5382.713 , 32.86353 , "None"));
HotSpots.Add(new Vector3(2665.094 , 5354.542 , 32.86348 , "None"));
HotSpots.Add(new Vector3(2596.311 , 5398.194 , 32.86348 , "None"));
HotSpots.Add(new Vector3(2563.79 , 5424.499 , 32.86362 , "None"));
HotSpots.Add(new Vector3(2515.986 , 5365.082 , 32.86412 , "None"));
HotSpots.Add(new Vector3(2589.658 , 5306.646 , 36.51677 , "None"));
ItemId = 35491;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThassarianMyBrother : QuestClass
{
    public ThassarianMyBrother()
    {
        Name = "Thassarian, My Brother";

        QuestId.AddRange(new[] { 11599 });

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


public sealed class ThassariantheDeathKnight : QuestClass
{
    public ThassariantheDeathKnight()
    {
        Name = "Thassarian, the Death Knight";

        QuestId.AddRange(new[] { 12088 });

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


public sealed class TheEmissary : QuestUseItemOnClass
{
    public TheEmissary()
    {
        Name = "The Emissary";

        QuestId.AddRange(new[] { 11626 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26452);
HotSpots.Add(new Vector3(1493.8 , 5585.208 , -51.50211 , "Swimming"));
ItemId = 35850;
Range = 13.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 11626);
}






}


public sealed class TheEmissaryPoint1 : QuestFollowPathClass
{
    public TheEmissaryPoint1()
    {
        Name = "The Emissary Point1";

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

        Path.Add(new Vector3(1799.04 , 6054.566 , 2.832308 , "None"));
Path.Add(new Vector3(1793.202 , 6053.789 , 2.638897 , "None"));
Path.Add(new Vector3(1795.681 , 6048.237 , 3.450365 , "None"));
Path.Add(new Vector3(1791.683 , 6040.551 , 1.60171 , "None"));
Path.Add(new Vector3(1786.729 , 6033.726 , 0.969445 , "None"));
Path.Add(new Vector3(1781.489 , 6027.156 , 0.3579106 , "None"));
Path.Add(new Vector3(1773.83 , 6023.656 , -0.2480406 , "None"));
Path.Add(new Vector3(1766.809 , 6020.6 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1763.2 , 6017.534 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1759.657 , 6014.505 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1755.874 , 6011.27 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1752.274 , 6008.192 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1748.646 , 6005.089 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1745.014 , 6001.984 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1741.385 , 5998.881 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1737.746 , 5995.77 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1734.049 , 5992.609 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1730.424 , 5989.509 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1726.745 , 5986.364 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1723.102 , 5983.249 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1719.527 , 5980.192 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1715.83 , 5977.031 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1712.249 , 5973.969 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1708.595 , 5970.845 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1708.451 , 5970.722 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1704.959 , 5967.736 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1704.79 , 5967.592 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1701.273 , 5964.584 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1701.208 , 5964.529 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1697.63 , 5961.47 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1697.486 , 5961.347 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1694.016 , 5958.379 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1693.922 , 5958.299 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1690.416 , 5955.301 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1690.315 , 5955.215 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1686.887 , 5951.981 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1686.785 , 5951.857 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1683.906 , 5948.361 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1683.819 , 5948.256 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1680.792 , 5944.582 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1680.678 , 5944.443 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1677.748 , 5940.886 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1677.688 , 5940.813 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1674.715 , 5937.204 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1674.652 , 5937.128 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1671.671 , 5933.508 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1671.599 , 5933.421 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1668.645 , 5929.834 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1668.531 , 5929.696 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1665.558 , 5926.087 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1665.558 , 5926.087 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1662.505 , 5922.38 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1662.232 , 5922.049 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1659.521 , 5918.757 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1659.422 , 5918.637 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1656.458 , 5915.04 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1656.356 , 5914.916 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1653.444 , 5911.38 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1653.342 , 5911.256 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1650.381 , 5907.662 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1650.231 , 5907.48 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1647.316 , 5903.941 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1647.217 , 5903.821 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1644.257 , 5900.227 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1644.155 , 5900.103 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1641.242 , 5896.567 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1641.092 , 5896.385 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1639.298 , 5892.285 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1639.263 , 5892.128 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1638.257 , 5887.582 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1638.223 , 5887.425 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1637.95 , 5882.893 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1637.89 , 5882.665 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1636.733 , 5878.233 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1636.693 , 5878.082 , -2.261926 , "Swimming"));
Path.Add(new Vector3(1634.25 , 5871.489 , 1.343171 , "None"));
Path.Add(new Vector3(1634.106 , 5870.936 , 1.478005 , "None"));
Path.Add(new Vector3(1631.152 , 5866.221 , 3.189931 , "None"));
Path.Add(new Vector3(1630.657 , 5865.542 , 3.354286 , "None"));
Path.Add(new Vector3(1626.025 , 5859.189 , 2.554335 , "None"));
Path.Add(new Vector3(1625.688 , 5858.728 , 2.331588 , "None"));
Path.Add(new Vector3(1621.457 , 5852.931 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1621.312 , 5852.738 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1618.555 , 5849.081 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1618.413 , 5848.892 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1615.656 , 5845.234 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1615.563 , 5845.109 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1612.806 , 5841.451 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1612.661 , 5841.259 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1610.283 , 5837.368 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1610.181 , 5837.155 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1608.197 , 5833.027 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1608.13 , 5832.886 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1606.146 , 5828.757 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1606.032 , 5828.519 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1604.06 , 5824.416 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1603.954 , 5824.195 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1601.974 , 5820.074 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1601.905 , 5819.93 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1599.919 , 5815.797 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1599.817 , 5815.584 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1597.835 , 5811.459 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1597.798 , 5811.383 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1595.747 , 5807.114 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1595.679 , 5806.973 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1593.696 , 5802.845 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1593.593 , 5802.632 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1591.609 , 5798.503 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1591.54 , 5798.358 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1589.556 , 5794.229 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1589.454 , 5794.017 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1587.47 , 5789.888 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1587.368 , 5789.675 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1585.418 , 5785.533 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1585.372 , 5785.379 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1583.69 , 5781.218 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1583.553 , 5780.933 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1581.57 , 5776.805 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1581.467 , 5776.592 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1579.84 , 5772.316 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1579.788 , 5772.165 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1578.302 , 5767.827 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1578.227 , 5767.608 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1576.742 , 5763.275 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1576.692 , 5763.127 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1575.181 , 5758.718 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1575.131 , 5758.571 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1573.645 , 5754.233 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1573.568 , 5754.01 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1572.083 , 5749.676 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1572.033 , 5749.529 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1570.548 , 5745.196 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1570.471 , 5744.972 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1568.961 , 5740.563 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1568.935 , 5740.487 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1567.424 , 5736.078 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1567.373 , 5735.931 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1565.863 , 5731.521 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1565.812 , 5731.374 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1564.941 , 5726.8 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1564.914 , 5726.646 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1564.128 , 5722.129 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1564.102 , 5721.976 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1563.303 , 5717.384 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1563.289 , 5717.305 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1562.491 , 5712.717 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1562.464 , 5712.559 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1561.665 , 5707.967 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1561.638 , 5707.814 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1560.839 , 5703.222 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1560.813 , 5703.068 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1560.027 , 5698.556 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1560 , 5698.397 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1559.201 , 5693.806 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1559.174 , 5693.647 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1558.376 , 5689.06 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1558.349 , 5688.907 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1557.564 , 5684.394 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1557.536 , 5684.236 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1556.738 , 5679.644 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1556.711 , 5679.49 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1555.497 , 5675.096 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1555.411 , 5674.875 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1553.221 , 5671.002 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1553.243 , 5670.843 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1551.421 , 5666.943 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1551.278 , 5666.755 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1548.522 , 5663.097 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1548.38 , 5662.908 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1545.623 , 5659.25 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1545.526 , 5659.122 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1542.724 , 5655.404 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1542.622 , 5655.28 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1538.419 , 5653.704 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1538.266 , 5653.676 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1533.677 , 5652.862 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1533.598 , 5652.848 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1528.934 , 5652.02 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1528.851 , 5652.005 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1524.266 , 5651.191 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1524.034 , 5651.15 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1519.603 , 5650.363 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1519.445 , 5650.335 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1514.856 , 5649.521 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1514.777 , 5649.505 , -2.244107 , "Swimming"));
Path.Add(new Vector3(1517.767 , 5644.979 , -2.43608 , "Swimming"));
Path.Add(new Vector3(1517.864 , 5644.851 , -2.43608 , "Swimming"));
Path.Add(new Vector3(1520.703 , 5641.154 , -2.43608 , "Swimming"));
Path.Add(new Vector3(1520.752 , 5641.091 , -2.43608 , "Swimming"));
Path.Add(new Vector3(1523.587 , 5637.397 , -2.43608 , "Swimming"));
Path.Add(new Vector3(1523.731 , 5637.21 , -2.43608 , "Swimming"));
Path.Add(new Vector3(1526.437 , 5633.526 , -2.43608 , "Swimming"));
Path.Add(new Vector3(1526.484 , 5633.373 , -2.43608 , "Swimming"));
Path.Add(new Vector3(1525.774 , 5628.862 , -2.43608 , "Swimming"));
Path.Add(new Vector3(1525.712 , 5628.699 , -2.43608 , "Swimming"));
Path.Add(new Vector3(1524.071 , 5624.442 , -2.43608 , "Swimming"));
Path.Add(new Vector3(1523.987 , 5624.222 , -2.43608 , "Swimming"));
Path.Add(new Vector3(1524.977 , 5621.336 , -4.55977 , "Swimming"));
Path.Add(new Vector3(1524.223 , 5620.794 , -9.063878 , "Swimming"));
Path.Add(new Vector3(1522.382 , 5618.109 , -12.60075 , "Swimming"));
Path.Add(new Vector3(1519.864 , 5616.26 , -15.32925 , "Swimming"));
Path.Add(new Vector3(1519.864 , 5616.26 , -10.51258 , "Swimming"));
Path.Add(new Vector3(1519.864 , 5616.26 , -5.691195 , "Swimming"));
Path.Add(new Vector3(1519.864 , 5616.26 , -0.5558525 , "None"));
Path.Add(new Vector3(1518.184 , 5614.139 , -5.455351 , "Swimming"));
Path.Add(new Vector3(1516.544 , 5612.068 , -9.483212 , "Swimming"));
Path.Add(new Vector3(1515.109 , 5610.258 , -13.00561 , "Swimming"));
Path.Add(new Vector3(1513.291 , 5607.962 , -17.4718 , "Swimming"));
Path.Add(new Vector3(1511.676 , 5605.924 , -21.43648 , "Swimming"));
Path.Add(new Vector3(1510.035 , 5603.852 , -25.46829 , "Swimming"));
Path.Add(new Vector3(1508.395 , 5601.781 , -29.49615 , "Swimming"));
Path.Add(new Vector3(1506.835 , 5599.813 , -33.32656 , "Swimming"));
Path.Add(new Vector3(1505.141 , 5597.675 , -37.48474 , "Swimming"));
Path.Add(new Vector3(1503.527 , 5595.637 , -41.44941 , "Swimming"));
Path.Add(new Vector3(1501.94 , 5593.634 , -45.34696 , "Swimming"));
Path.Add(new Vector3(1500.375 , 5591.659 , -49.18922 , "Swimming"));
Path.Add(new Vector3(1498.835 , 5589.714 , -52.97225 , "Swimming"));
Path.Add(new Vector3(1497.121 , 5587.55 , -57.18176 , "Swimming"));
Path.Add(new Vector3(2007.962 , 5936.552 , 37.40332 , "Swimming"));
Path.Add(new Vector3(2004.148 , 5931.738 , 38.09801 , "None"));
Path.Add(new Vector3(2001.414 , 5927.579 , 38.12194 , "None"));
Path.Add(new Vector3(1996.288 , 5921.583 , 39.42794 , "None"));
Path.Add(new Vector3(1992.357 , 5917.854 , 36.33968 , "None"));
Path.Add(new Vector3(1988.436 , 5914.875 , 34.54071 , "None"));
Path.Add(new Vector3(1983.962 , 5911.477 , 28.36374 , "None"));
Path.Add(new Vector3(1979.631 , 5908.189 , 17.14346 , "None"));
Path.Add(new Vector3(1975.119 , 5905.464 , 16.40348 , "None"));
Path.Add(new Vector3(1970.599 , 5902.732 , 16.188 , "None"));
Path.Add(new Vector3(1966.06 , 5899.991 , 15.91569 , "None"));
Path.Add(new Vector3(1961.594 , 5897.292 , 15.61614 , "None"));
Path.Add(new Vector3(1956.938 , 5894.479 , 15.19679 , "None"));
Path.Add(new Vector3(1952.418 , 5891.748 , 14.72012 , "None"));
Path.Add(new Vector3(1947.915 , 5889.028 , 14.20016 , "None"));
Path.Add(new Vector3(1943.251 , 5886.21 , 13.76513 , "None"));
Path.Add(new Vector3(1938.892 , 5883.577 , 13.31871 , "None"));
Path.Add(new Vector3(1934.237 , 5880.764 , 12.8598 , "None"));
Path.Add(new Vector3(1929.573 , 5877.946 , 12.69317 , "None"));
Path.Add(new Vector3(1925.078 , 5875.23 , 12.99696 , "None"));
Path.Add(new Vector3(1920.414 , 5872.413 , 13.10144 , "None"));
Path.Add(new Vector3(1915.902 , 5869.687 , 13.09948 , "None"));
Path.Add(new Vector3(1911.4 , 5866.966 , 13.09994 , "None"));
Path.Add(new Vector3(1906.888 , 5864.241 , 13.09994 , "None"));
Path.Add(new Vector3(1902.481 , 5861.046 , 13.04781 , "None"));
Path.Add(new Vector3(1898.308 , 5857.825 , 12.33336 , "None"));
Path.Add(new Vector3(1894.144 , 5854.611 , 10.86751 , "None"));
Path.Add(new Vector3(1889.83 , 5851.281 , 9.245838 , "None"));
Path.Add(new Vector3(1885.666 , 5848.067 , 7.985001 , "None"));
Path.Add(new Vector3(1881.493 , 5844.846 , 6.872501 , "None"));
Path.Add(new Vector3(1877.179 , 5841.516 , 4.675723 , "None"));
Path.Add(new Vector3(1873.007 , 5838.295 , 4.448458 , "None"));
Path.Add(new Vector3(1869.25 , 5835.396 , 4.465896 , "None"));
Path.Add(new Vector3(1864.528 , 5831.751 , 4.421713 , "None"));
Path.Add(new Vector3(1860.301 , 5828.488 , 5.168958 , "None"));
Path.Add(new Vector3(1856.053 , 5825.209 , 5.364829 , "None"));
Path.Add(new Vector3(1851.881 , 5821.989 , 4.356876 , "None"));
Path.Add(new Vector3(1847.766 , 5818.813 , 3.185524 , "None"));
Path.Add(new Vector3(1843.403 , 5815.445 , 1.928031 , "None"));
Path.Add(new Vector3(1839.23 , 5812.224 , 1.00457 , "None"));
Path.Add(new Vector3(1835.066 , 5809.01 , 0.6566891 , "None"));
Path.Add(new Vector3(1830.893 , 5805.789 , 0.4739281 , "None"));
Path.Add(new Vector3(1826.721 , 5802.568 , 0.4019614 , "None"));
Path.Add(new Vector3(1822.415 , 5799.245 , 0.3592907 , "None"));
Path.Add(new Vector3(1818.242 , 5796.024 , 0.285655 , "None"));
Path.Add(new Vector3(1813.929 , 5792.694 , 0.2645706 , "None"));
Path.Add(new Vector3(1809.756 , 5789.474 , 0.1368568 , "None"));
Path.Add(new Vector3(1805.45 , 5786.15 , 0.0008210149 , "None"));
Path.Add(new Vector3(1801.419 , 5783.039 , 0.0008210149 , "None"));
Path.Add(new Vector3(1797.114 , 5779.715 , 0.0008210149 , "None"));
Path.Add(new Vector3(1793.461 , 5775.918 , 0.0008210149 , "None"));
Path.Add(new Vector3(1789.724 , 5771.952 , 0.0008210149 , "None"));
Path.Add(new Vector3(1786.117 , 5768.123 , 0.0008210149 , "None"));
Path.Add(new Vector3(1782.503 , 5764.286 , 0.0008210149 , "None"));
Path.Add(new Vector3(1778.888 , 5760.45 , 0.0008210149 , "None"));
Path.Add(new Vector3(1775.159 , 5756.491 , 0.0008210149 , "None"));
Path.Add(new Vector3(1771.544 , 5752.654 , 0.0008210149 , "None"));
Path.Add(new Vector3(1767.93 , 5748.817 , 0.0008210149 , "None"));
Path.Add(new Vector3(1764.2 , 5744.858 , 0.0008210149 , "None"));
Path.Add(new Vector3(1760.586 , 5741.022 , 0.0008210149 , "None"));
Path.Add(new Vector3(1757.094 , 5737.315 , 0.0008210149 , "None"));
Path.Add(new Vector3(1753.242 , 5733.226 , 0.0008210149 , "None"));
Path.Add(new Vector3(1749.75 , 5729.52 , 0.0008210149 , "None"));
Path.Add(new Vector3(1746.021 , 5725.561 , 0.0008210149 , "None"));
Path.Add(new Vector3(1742.284 , 5721.594 , 0.0008210149 , "None"));
Path.Add(new Vector3(1738.67 , 5717.757 , 0.0008210149 , "None"));
Path.Add(new Vector3(1735.178 , 5714.051 , 0.0008210149 , "None"));
Path.Add(new Vector3(1731.326 , 5709.962 , 0.0008210149 , "None"));
Path.Add(new Vector3(1727.711 , 5706.125 , 0.0008210149 , "None"));
Path.Add(new Vector3(1724.104 , 5702.296 , 0.0008210149 , "None"));
Path.Add(new Vector3(1720.49 , 5698.459 , 0.0008210149 , "None"));
Path.Add(new Vector3(1716.875 , 5694.623 , 0.0008210149 , "None"));
Path.Add(new Vector3(1713.139 , 5690.656 , 0.0008210149 , "None"));
Path.Add(new Vector3(1708.738 , 5687.526 , 0.0008210149 , "None"));
Path.Add(new Vector3(1704.035 , 5685.191 , 0.0008210149 , "None"));
Path.Add(new Vector3(1699.062 , 5683.476 , 0.0008210149 , "None"));
Path.Add(new Vector3(1693.911 , 5681.699 , 0.0008210149 , "None"));
Path.Add(new Vector3(1689.097 , 5680.038 , 0.0008210149 , "None"));
Path.Add(new Vector3(1683.945 , 5678.261 , 0.0008210149 , "None"));
Path.Add(new Vector3(1678.803 , 5676.487 , 0.0008210149 , "None"));
Path.Add(new Vector3(1673.989 , 5674.826 , 0.0008210149 , "None"));
Path.Add(new Vector3(1668.838 , 5673.049 , 0.0008210149 , "None"));
Path.Add(new Vector3(1664.024 , 5671.388 , 0.0008210149 , "None"));
Path.Add(new Vector3(1658.713 , 5669.556 , 0.0008210149 , "None"));
Path.Add(new Vector3(1653.74 , 5667.84 , 0.0008210149 , "None"));
Path.Add(new Vector3(1648.758 , 5666.122 , 0.0008210149 , "None"));
Path.Add(new Vector3(1643.775 , 5664.402 , 0.0008210149 , "None"));
Path.Add(new Vector3(1638.623 , 5662.625 , 0.0008210149 , "None"));
Path.Add(new Vector3(1634.048 , 5660.484 , 0.0008210149 , "None"));
Path.Add(new Vector3(1629.453 , 5657.553 , 0.0008210149 , "None"));
Path.Add(new Vector3(1624.861 , 5654.64 , 0.0008210149 , "None"));
Path.Add(new Vector3(1620.068 , 5652.928 , 0.0008210149 , "None"));
Path.Add(new Vector3(1614.971 , 5650.644 , 0.0008210149 , "None"));
Path.Add(new Vector3(1610.516 , 5647.787 , 0.0008210149 , "None"));
Path.Add(new Vector3(1605.946 , 5644.857 , 0.0008210149 , "None"));
Path.Add(new Vector3(1601.509 , 5642.012 , 0.0008210149 , "None"));
Path.Add(new Vector3(1597.081 , 5639.172 , 0.0008210149 , "None"));
Path.Add(new Vector3(1592.794 , 5636.423 , 0.0008210149 , "None"));
Path.Add(new Vector3(1588.938 , 5632.584 , 0.0008210149 , "None"));
Path.Add(new Vector3(1584.819 , 5629.399 , 0.0008210149 , "None"));
Path.Add(new Vector3(1579.957 , 5626.591 , 0.0008210149 , "None"));
Path.Add(new Vector3(1576.015 , 5623.366 , 0.0008210149 , "None"));
Path.Add(new Vector3(1571.805 , 5619.922 , 0.0008210149 , "None"));
Path.Add(new Vector3(1567.855 , 5616.691 , 0.0008210149 , "None"));
Path.Add(new Vector3(1563.645 , 5613.248 , 0.0008210149 , "None"));
Path.Add(new Vector3(1559.435 , 5609.804 , 0.0008210149 , "None"));
Path.Add(new Vector3(1555.355 , 5606.466 , 0.0008210149 , "None"));
Path.Add(new Vector3(1551.516 , 5603 , 0.0008210149 , "None"));
Path.Add(new Vector3(1548.73 , 5598.792 , 0.0008210149 , "None"));
Path.Add(new Vector3(1544.114 , 5596.302 , -1.187521 , "None"));
Path.Add(new Vector3(1540.788 , 5596.327 , -3.114692 , "Swimming"));
Path.Add(new Vector3(1538.14 , 5596.923 , -5.337215 , "Swimming"));
Path.Add(new Vector3(1534.424 , 5596.57 , -11.34741 , "Swimming"));
Path.Add(new Vector3(1532.709 , 5595.569 , -14.43909 , "Swimming"));
Path.Add(new Vector3(1530.698 , 5594.025 , -16.93167 , "Swimming"));
Path.Add(new Vector3(1528.614 , 5592.417 , -19.48739 , "Swimming"));
Path.Add(new Vector3(1526.595 , 5590.858 , -21.96417 , "Swimming"));
Path.Add(new Vector3(1524.575 , 5589.299 , -24.44094 , "Swimming"));
Path.Add(new Vector3(1522.559 , 5587.743 , -26.91279 , "Swimming"));
Path.Add(new Vector3(1520.471 , 5586.131 , -29.47344 , "Swimming"));
Path.Add(new Vector3(1518.474 , 5584.59 , -31.92226 , "Swimming"));
Path.Add(new Vector3(1515.918 , 5582.617 , -35.05688 , "Swimming"));
Path.Add(new Vector3(1515.111 , 5581.994 , -38.88971 , "Swimming"));
Path.Add(new Vector3(1515.111 , 5581.994 , -33.5961 , "Swimming"));
Path.Add(new Vector3(1515.111 , 5581.994 , -28.77943 , "Swimming"));
Path.Add(new Vector3(1515.111 , 5581.994 , -24.1186 , "Swimming"));
Path.Add(new Vector3(1515.111 , 5581.994 , -19.32082 , "Swimming"));
Path.Add(new Vector3(1515.111 , 5581.994 , -14.48054 , "Swimming"));
Path.Add(new Vector3(1515.111 , 5581.994 , -9.668598 , "Swimming"));
Path.Add(new Vector3(1515.111 , 5581.994 , -4.927486 , "Swimming"));
Path.Add(new Vector3(1515.111 , 5581.994 , 0.1927657 , "None"));
Path.Add(new Vector3(1519.318 , 5581.685 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1523.887 , 5582.309 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1528.19 , 5584.288 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1532.565 , 5586.301 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1536.882 , 5588.425 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1540.927 , 5590.899 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1545.036 , 5593.412 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1549.112 , 5595.906 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1553.189 , 5598.4 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1557.229 , 5600.871 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1561.407 , 5603.426 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1565.512 , 5605.938 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1569.56 , 5608.414 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1573.669 , 5610.927 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1577.778 , 5613.44 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1581.823 , 5615.915 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1585.931 , 5618.428 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1589.976 , 5620.902 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1594.093 , 5623.42 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1598.129 , 5625.889 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1602.274 , 5628.425 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1606.303 , 5630.889 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1610.456 , 5633.429 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1614.496 , 5635.901 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1618.565 , 5638.39 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1622.65 , 5640.888 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1626.763 , 5643.404 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1630.872 , 5645.917 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1634.912 , 5648.389 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1639.021 , 5650.902 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1643.13 , 5653.416 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1647.174 , 5655.89 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1651.283 , 5658.403 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1655.328 , 5660.877 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1659.437 , 5663.391 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1663.477 , 5665.862 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1667.521 , 5668.336 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1671.695 , 5670.889 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1675.808 , 5673.405 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1679.848 , 5675.876 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1683.961 , 5678.392 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1688.002 , 5680.863 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1692.111 , 5683.377 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1696.224 , 5685.893 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1700.195 , 5688.322 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1704.304 , 5690.836 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1708.482 , 5693.391 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1712.526 , 5695.865 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1716.635 , 5698.378 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1720.744 , 5700.892 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1724.788 , 5703.366 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1728.897 , 5705.879 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1732.986 , 5708.38 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1737.051 , 5710.867 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1741.164 , 5713.382 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1745.269 , 5715.893 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1749.313 , 5718.367 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1753.408 , 5720.901 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1756.885 , 5724.117 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1760.422 , 5727.393 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1763.754 , 5730.752 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1766.78 , 5734.493 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1769.715 , 5738.121 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1772.627 , 5742.135 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1775.697 , 5745.678 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1778.937 , 5749.212 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1781.131 , 5753.494 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1783.346 , 5757.672 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1785.924 , 5761.741 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1788.467 , 5765.739 , -1.561329 , "Swimming"));
Path.Add(new Vector3(1791.064 , 5769.795 , -1.524016 , "Swimming"));
Path.Add(new Vector3(1793.666 , 5773.86 , -1.524016 , "Swimming"));
Path.Add(new Vector3(1796.174 , 5777.777 , -1.524016 , "Swimming"));
Path.Add(new Vector3(1798.857 , 5781.969 , -1.524016 , "Swimming"));
Path.Add(new Vector3(1802.986 , 5788.42 , -0.2753184 , "None"));
Path.Add(new Vector3(1805.151 , 5791.803 , 0.01322098 , "None"));
Path.Add(new Vector3(1807.187 , 5794.983 , 0.1712098 , "None"));
Path.Add(new Vector3(1813.649 , 5798.391 , 0.2694836 , "None"));
Path.Add(new Vector3(1818.877 , 5804.979 , 0.3579882 , "None"));
Path.Add(new Vector3(1824.991 , 5810.767 , 0.4493268 , "None"));
Path.Add(new Vector3(1831.729 , 5816.256 , 0.7259951 , "None"));
Path.Add(new Vector3(1838.592 , 5821.158 , 1.070939 , "None"));
Path.Add(new Vector3(1846.241 , 5825.289 , 2.710908 , "None"));
Path.Add(new Vector3(1853.503 , 5828.984 , 4.58561 , "None"));
Path.Add(new Vector3(1861.274 , 5832.938 , 4.630566 , "None"));
Path.Add(new Vector3(1869.044 , 5836.893 , 4.445511 , "None"));
Path.Add(new Vector3(1876.546 , 5840.71 , 4.54886 , "None"));
Path.Add(new Vector3(1883.807 , 5844.406 , 7.181 , "None"));
Path.Add(new Vector3(1891.833 , 5848.49 , 9.497116 , "None"));
Path.Add(new Vector3(1899.095 , 5852.185 , 11.60474 , "None"));
Path.Add(new Vector3(1906.851 , 5856.132 , 13.04708 , "None"));
Path.Add(new Vector3(1915.12 , 5857.302 , 13.08128 , "None"));
Path.Add(new Vector3(1923.833 , 5857.909 , 12.78058 , "None"));
Path.Add(new Vector3(1932.167 , 5859.035 , 11.63511 , "None"));
Path.Add(new Vector3(1940.363 , 5860.946 , 12.29405 , "None"));
Path.Add(new Vector3(1948.306 , 5863.778 , 15.8539 , "None"));
Path.Add(new Vector3(1956.495 , 5866.752 , 21.05861 , "None"));
Path.Add(new Vector3(1963.999 , 5868.899 , 25.8732 , "None"));
Path.Add(new Vector3(1971.948 , 5865.718 , 30.74572 , "None"));
Path.Add(new Vector3(1977.53 , 5860.436 , 34.15228 , "None"));
Path.Add(new Vector3(1986.673 , 5858.39 , 38.14379 , "None"));
Path.Add(new Vector3(1995.365 , 5857.702 , 36.66095 , "None"));
Path.Add(new Vector3(1997.656 , 5853.661 , 35.96073 , "None"));
Path.Add(new Vector3(2005.663 , 5846.731 , 36.35734 , "None"));
Path.Add(new Vector3(2012.833 , 5841.625 , 37.35705 , "None"));
Path.Add(new Vector3(2018.95 , 5837.269 , 38.68709 , "None"));
Path.Add(new Vector3(2026.956 , 5831.567 , 38.57943 , "None"));
Path.Add(new Vector3(2033.798 , 5826.694 , 38.29092 , "None"));
Path.Add(new Vector3(2039.641 , 5822.533 , 39.23468 , "None"));
Path.Add(new Vector3(2047.514 , 5816.925 , 42.5161 , "None"));
Path.Add(new Vector3(2054.617 , 5811.867 , 45.07552 , "None"));
Path.Add(new Vector3(2061.486 , 5806.975 , 45.4231 , "None"));
Path.Add(new Vector3(2068.123 , 5802.248 , 46.67216 , "None"));
Path.Add(new Vector3(2075.458 , 5797.024 , 49.83245 , "None"));
Path.Add(new Vector3(2082.314 , 5792.142 , 52.17475 , "None"));
Path.Add(new Vector3(2088.944 , 5787.419 , 53.93855 , "None"));
Path.Add(new Vector3(2096.265 , 5782.206 , 55.239 , "None"));
Path.Add(new Vector3(2103.134 , 5777.313 , 56.9597 , "None"));
Path.Add(new Vector3(2110.114 , 5772.343 , 57.54383 , "None"));
Path.Add(new Vector3(2116.668 , 5767.675 , 58.38997 , "None"));
Path.Add(new Vector3(2123.948 , 5762.49 , 58.9447 , "None"));
Path.Add(new Vector3(2131.051 , 5757.432 , 58.79157 , "None"));
Path.Add(new Vector3(2137.92 , 5752.54 , 58.32701 , "None"));
Path.Add(new Vector3(2144.776 , 5747.657 , 57.9195 , "None"));
Path.Add(new Vector3(2152.705 , 5744.302 , 57.45252 , "None"));
Path.Add(new Vector3(2160.713 , 5741.5 , 56.55963 , "None"));
Path.Add(new Vector3(2168.658 , 5738.721 , 55.60809 , "None"));
Path.Add(new Vector3(2176.888 , 5735.842 , 55.00963 , "None"));
Path.Add(new Vector3(2184.849 , 5733.057 , 54.56612 , "None"));
Path.Add(new Vector3(2192.92 , 5730.234 , 54.45063 , "None"));
Path.Add(new Vector3(2200.928 , 5727.432 , 54.44544 , "None"));
Path.Add(new Vector3(2208.175 , 5724.897 , 54.51974 , "None"));
Path.Add(new Vector3(2216.929 , 5721.835 , 55.23436 , "None"));
Path.Add(new Vector3(2225.159 , 5718.956 , 56.32219 , "None"));
Path.Add(new Vector3(2233.104 , 5716.176 , 56.6021 , "None"));
Path.Add(new Vector3(2241.032 , 5713.403 , 55.86693 , "None"));
Path.Add(new Vector3(2249.025 , 5710.607 , 55.23166 , "None"));
Path.Add(new Vector3(2257.239 , 5707.733 , 55.33472 , "None"));
Path.Add(new Vector3(2264.93 , 5705.043 , 56.03504 , "None"));
Path.Add(new Vector3(2273.414 , 5702.075 , 55.95158 , "None"));
Path.Add(new Vector3(2281.121 , 5699.379 , 55.11699 , "None"));
Path.Add(new Vector3(2289.065 , 5696.6 , 53.7157 , "None"));
Path.Add(new Vector3(2297.295 , 5693.721 , 53.21038 , "None"));
Path.Add(new Vector3(2305.51 , 5690.847 , 53.56651 , "None"));
Path.Add(new Vector3(2312.592 , 5687.772 , 53.31748 , "None"));
Path.Add(new Vector3(2317.349 , 5680.465 , 50.28092 , "None"));
Path.Add(new Vector3(2321.949 , 5673.396 , 47.00905 , "None"));
Path.Add(new Vector3(2326.697 , 5666.103 , 44.36958 , "None"));
Path.Add(new Vector3(2331.298 , 5659.035 , 43.37841 , "None"));
Path.Add(new Vector3(2335.898 , 5651.967 , 43.17915 , "None"));
Path.Add(new Vector3(2340.646 , 5644.674 , 42.62157 , "None"));
Path.Add(new Vector3(2345.247 , 5637.605 , 41.59707 , "None"));
Path.Add(new Vector3(2349.261 , 5631.438 , 40.27032 , "None"));
Path.Add(new Vector3(2354.311 , 5623.681 , 38.52982 , "None"));
Path.Add(new Vector3(2359.068 , 5616.373 , 36.37753 , "None"));
Path.Add(new Vector3(2363.815 , 5609.08 , 34.66537 , "None"));
Path.Add(new Vector3(2368.224 , 5602.307 , 34.82563 , "None"));
Path.Add(new Vector3(2373.035 , 5594.915 , 35.65823 , "None"));
Path.Add(new Vector3(2377.609 , 5587.889 , 35.53384 , "None"));
Path.Add(new Vector3(2382.356 , 5580.596 , 34.80553 , "None"));
Path.Add(new Vector3(2386.739 , 5573.708 , 34.00492 , "None"));
Path.Add(new Vector3(2390.887 , 5567.028 , 33.45907 , "None"));
Path.Add(new Vector3(2395.622 , 5559.402 , 33.3666 , "None"));
Path.Add(new Vector3(2400.071 , 5552.238 , 33.30184 , "None"));
Path.Add(new Vector3(2404.343 , 5545.358 , 33.37784 , "None"));
Path.Add(new Vector3(2409.27 , 5537.423 , 33.28039 , "None"));
Path.Add(new Vector3(2413.71 , 5530.273 , 32.18895 , "None"));
Path.Add(new Vector3(2418.15 , 5523.123 , 29.89098 , "None"));
Path.Add(new Vector3(2422.599 , 5515.958 , 27.72005 , "None"));
Path.Add(new Vector3(2427.199 , 5508.55 , 26.23026 , "None"));
Path.Add(new Vector3(2434.6 , 5496.631 , 27.6776 , "None"));
Path.Add(new Vector3(2439.412 , 5488.882 , 29.01875 , "None"));
Path.Add(new Vector3(2443.915 , 5481.631 , 29.66361 , "None"));
Path.Add(new Vector3(2448.16 , 5474.795 , 28.20321 , "None"));
Path.Add(new Vector3(2452.901 , 5467.159 , 23.62657 , "None"));
Path.Add(new Vector3(2456.393 , 5461.536 , 20.04219 , "None"));
Path.Add(new Vector3(2461.737 , 5452.812 , 20.61169 , "None"));
Path.Add(new Vector3(2465.345 , 5446.787 , 23.87725 , "None"));
Path.Add(new Vector3(2470.542 , 5438.11 , 27.12247 , "None"));
Path.Add(new Vector3(2474.875 , 5430.876 , 26.95555 , "None"));
Path.Add(new Vector3(2478.086 , 5425.515 , 24.6661 , "None"));
Path.Add(new Vector3(2482.419 , 5418.28 , 21.31334 , "None"));
Path.Add(new Vector3(2485.671 , 5411.248 , 21.35159 , "None"));
Path.Add(new Vector3(2485.931 , 5406.803 , 23.19345 , "None"));
Path.Add(new Vector3(2486.418 , 5400.336 , 26.58236 , "None"));
Path.Add(new Vector3(2487.316 , 5388.425 , 29.441 , "None"));
Path.Add(new Vector3(2487.938 , 5380.183 , 30.84875 , "None"));
Path.Add(new Vector3(2488.527 , 5372.36 , 31.67446 , "None"));
Path.Add(new Vector3(2489.139 , 5364.235 , 31.69051 , "None"));
Path.Add(new Vector3(2490.975 , 5357.446 , 32.11777 , "None"));
Path.Add(new Vector3(2492.687 , 5351.558 , 32.53978 , "None"));
Path.Add(new Vector3(2495.95 , 5340.33 , 32.97221 , "None"));
Path.Add(new Vector3(2497.55 , 5334.829 , 33.1071 , "None"));
Path.Add(new Vector3(2500.29 , 5330.264 , 33.07589 , "None"));
Path.Add(new Vector3(2506.432 , 5325.688 , 33.07589 , "None"));
Path.Add(new Vector3(2511.806 , 5320.348 , 33.05789 , "None"));
Path.Add(new Vector3(2518.587 , 5313.61 , 33.06879 , "None"));
Path.Add(new Vector3(2523.378 , 5308.849 , 33.08555 , "None"));
Path.Add(new Vector3(2530.642 , 5305.502 , 33.119 , "None"));
Path.Add(new Vector3(2538.614 , 5301.97 , 33.58402 , "None"));
Path.Add(new Vector3(2544.374 , 5299.418 , 33.06046 , "None"));
Path.Add(new Vector3(2554.128 , 5295.098 , 31.0194 , "None"));
Path.Add(new Vector3(2558.751 , 5293.049 , 31.019 , "None"));
Path.Add(new Vector3(2569.749 , 5288.177 , 34.92915 , "None"));
Path.Add(new Vector3(2576.999 , 5284.965 , 35.97321 , "None"));
Path.Add(new Vector3(2584.971 , 5281.433 , 36.67964 , "None"));
Path.Add(new Vector3(2591.392 , 5278.589 , 36.81469 , "None"));
Path.Add(new Vector3(2600.626 , 5274.498 , 36.90009 , "None"));
Path.Add(new Vector3(2606.259 , 5271.991 , 37.32277 , "None"));
Path.Add(new Vector3(2613.519 , 5265.353 , 39.42057 , "None"));
Path.Add(new Vector3(2618.558 , 5260.898 , 39.39099 , "None"));
Path.Add(new Vector3(2624.108 , 5257.035 , 38.26888 , "None"));
Path.Add(new Vector3(2627.92 , 5255.048 , 38.28458 , "None"));
Path.Add(new Vector3(2631.497 , 5253.184 , 38.28759 , "None"));
Path.Add(new Vector3(2635.144 , 5251.283 , 38.29156 , "None"));
Path.Add(new Vector3(2638.778 , 5249.389 , 38.30261 , "None"));
Path.Add(new Vector3(2644.43 , 5247.563 , 38.31051 , "None"));
Path.Add(new Vector3(2647.951 , 5245.963 , 37.91736 , "None"));
Path.Add(new Vector3(2651.295 , 5243.458 , 36.79864 , "None"));
Path.Add(new Vector3(2657.75 , 5238.622 , 33.41024 , "None"));
Path.Add(new Vector3(2660.72 , 5236.397 , 32.23064 , "None"));
Path.Add(new Vector3(2663.813 , 5234.08 , 31.32946 , "None"));
Path.Add(new Vector3(2666.938 , 5231.739 , 31.0585 , "None"));
Path.Add(new Vector3(2671.324 , 5228.016 , 28.68921 , "None"));
Path.Add(new Vector3(2677.398 , 5222.166 , 28.17398 , "None"));
Path.Add(new Vector3(2683.473 , 5216.316 , 28.00958 , "None"));
Path.Add(new Vector3(2688.93 , 5211.06 , 27.16365 , "None"));
Path.Add(new Vector3(2695.816 , 5204.429 , 26.03087 , "None"));
Path.Add(new Vector3(2701.806 , 5198.661 , 25.2527 , "None"));
Path.Add(new Vector3(2708.171 , 5192.531 , 25.04605 , "None"));
Path.Add(new Vector3(2714.33 , 5186.599 , 25.55088 , "None"));
Path.Add(new Vector3(2719.098 , 5182.007 , 26.32043 , "None"));
Path.Add(new Vector3(2726.588 , 5174.793 , 27.62468 , "None"));
Path.Add(new Vector3(2730.025 , 5171.484 , 28.04855 , "None"));
Path.Add(new Vector3(2737.842 , 5163.956 , 28.27189 , "None"));
Path.Add(new Vector3(2743.372 , 5158.629 , 28.48767 , "None"));
Path.Add(new Vector3(2748.545 , 5153.489 , 28.61322 , "None"));
Path.Add(new Vector3(2751.778 , 5147.579 , 28.75737 , "None"));
Path.Add(new Vector3(2755.468 , 5140.836 , 29.53723 , "None"));
Path.Add(new Vector3(2759.88 , 5132.771 , 31.31228 , "None"));
Path.Add(new Vector3(2763.904 , 5125.416 , 32.51363 , "None"));
Path.Add(new Vector3(2766.924 , 5119.898 , 33.83295 , "None"));
Path.Add(new Vector3(2772.203 , 5111.659 , 34.16306 , "None"));
Path.Add(new Vector3(2778.211 , 5104.529 , 32.17365 , "None"));
Path.Add(new Vector3(2783.246 , 5098.555 , 30.58161 , "None"));
Path.Add(new Vector3(2789.222 , 5091.464 , 28.24271 , "None"));
Path.Add(new Vector3(2794.656 , 5085.015 , 27.01964 , "None"));
Path.Add(new Vector3(2799.714 , 5079.013 , 26.84876 , "None"));
Path.Add(new Vector3(2802.949 , 5075.174 , 27.47627 , "None"));
Path.Add(new Vector3(2806.21 , 5071.305 , 28.11487 , "None"));
Path.Add(new Vector3(2809.471 , 5067.435 , 28.54229 , "None"));
Path.Add(new Vector3(2815.395 , 5060.406 , 28.71074 , "None"));
Path.Add(new Vector3(2818.324 , 5056.93 , 28.47799 , "None"));
Path.Add(new Vector3(2821.995 , 5052.575 , 28.16931 , "None"));
Path.Add(new Vector3(2824.84 , 5049.199 , 27.76644 , "None"));
Path.Add(new Vector3(2828.516 , 5044.836 , 27.79889 , "None"));
Path.Add(new Vector3(2831.686 , 5041.074 , 28.25688 , "None"));
Path.Add(new Vector3(2834.297 , 5037.976 , 28.88952 , "None"));
Path.Add(new Vector3(2839.819 , 5031.424 , 28.98279 , "None"));
Path.Add(new Vector3(2843.326 , 5027.262 , 28.89469 , "None"));
Path.Add(new Vector3(2846.769 , 5023.176 , 28.73229 , "None"));
Path.Add(new Vector3(2850.877 , 5020.373 , 28.10507 , "None"));
Path.Add(new Vector3(2855.794 , 5019.467 , 27.31955 , "None"));
Path.Add(new Vector3(2859.829 , 5018.724 , 27.27448 , "None"));
Path.Add(new Vector3(2865.797 , 5017.625 , 28.18176 , "None"));
Path.Add(new Vector3(2871.365 , 5016.599 , 30.24531 , "None"));
Path.Add(new Vector3(2881.096 , 5014.807 , 31.09417 , "None"));
Path.Add(new Vector3(2889.671 , 5013.228 , 30.9242 , "None"));
Path.Add(new Vector3(2897.668 , 5011.754 , 30.73597 , "None"));
Path.Add(new Vector3(2906.243 , 5010.175 , 29.29308 , "None"));
Path.Add(new Vector3(2913.992 , 5008.748 , 29.94187 , "None"));
Path.Add(new Vector3(2922.551 , 5007.171 , 30.60703 , "None"));
Path.Add(new Vector3(2931.076 , 5005.601 , 30.74331 , "None"));
Path.Add(new Vector3(2939.948 , 5003.967 , 31.1374 , "None"));
Path.Add(new Vector3(2947.135 , 5002.643 , 30.6629 , "None"));
Path.Add(new Vector3(2954.604 , 5001.268 , 27.50592 , "None"));
Path.Add(new Vector3(2956.654 , 4998.409 , 24.51541 , "None"));
Path.Add(new Vector3(2956.179 , 4988.29 , 19.14072 , "None"));
Path.Add(new Vector3(2954.545 , 4980.287 , 14.64936 , "None"));
Path.Add(new Vector3(2952.398 , 4971.906 , 12.02554 , "None"));
Path.Add(new Vector3(2952.037 , 4964.026 , 13.27049 , "None"));
Path.Add(new Vector3(2952.102 , 4955.593 , 12.26433 , "None"));
Path.Add(new Vector3(2952.168 , 4947.16 , 9.721239 , "None"));
Path.Add(new Vector3(2957.163 , 4941.734 , 8.637506 , "None"));
Path.Add(new Vector3(2965.069 , 4939.138 , 7.614582 , "None"));
Path.Add(new Vector3(2971.716 , 4938.042 , 6.082615 , "None"));
Path.Add(new Vector3(2981.712 , 4936.394 , 3.762135 , "None"));
Path.Add(new Vector3(2989.983 , 4935.03 , 1.221734 , "None"));
Path.Add(new Vector3(2995.328 , 4933.177 , 0.3972232 , "None"));
Path.Add(new Vector3(3002.619 , 4930.566 , 0.3972232 , "None"));
Path.Add(new Vector3(3010.022 , 4927.916 , 0.3972232 , "None"));
Path.Add(new Vector3(3017.424 , 4925.265 , 0.3972232 , "None"));
Path.Add(new Vector3(3025.743 , 4922.286 , 2.345558 , "None"));
Path.Add(new Vector3(3033.73 , 4919.425 , 2.42732 , "None"));
Path.Add(new Vector3(3038.476 , 4917.727 , 1.781163 , "None"));
Path.Add(new Vector3(3047.633 , 4914.447 , 1.827382 , "None"));
Path.Add(new Vector3(3053.924 , 4912.195 , 1.83365 , "None"));
Path.Add(new Vector3(3064.457 , 4908.423 , 2.039097 , "None"));
Path.Add(new Vector3(3068.727 , 4906.894 , 2.063931 , "None"));
Path.Add(new Vector3(3076.24 , 4904.204 , 2.280283 , "None"));
Path.Add(new Vector3(3086.869 , 4900.398 , 1.798501 , "None"));
Path.Add(new Vector3(3093.132 , 4898.155 , 1.334688 , "None"));
Path.Add(new Vector3(3102.4 , 4894.835 , 1.009532 , "None"));
Path.Add(new Vector3(3110.396 , 4893.704 , 0.5552543 , "None"));
Path.Add(new Vector3(3119.104 , 4893.28 , 1.912183 , "None"));
Path.Add(new Vector3(3126.945 , 4891.034 , 1.422093 , "None"));
Path.Add(new Vector3(3136.281 , 4886.529 , 1.982214 , "None"));
Path.Add(new Vector3(3134.028 , 4880.785 , 1.357911 , "None"));
Path.Add(new Vector3(3126.961 , 4876.275 , 1.233544 , "None"));
Path.Add(new Vector3(3119.852 , 4871.738 , 1.20611 , "None"));
Path.Add(new Vector3(3112.502 , 4867.047 , 1.858215 , "None"));
Path.Add(new Vector3(3106.073 , 4862.944 , 2.319332 , "None"));
Path.Add(new Vector3(3099.488 , 4858.741 , 3.007495 , "None"));
Path.Add(new Vector3(3092.86 , 4854.511 , 2.868401 , "None"));
Path.Add(new Vector3(3085.782 , 4849.997 , 3.139658 , "None"));
Path.Add(new Vector3(3081.993 , 4845.805 , 3.218551 , "None"));
Path.Add(new Vector3(3080.475 , 4839.994 , 2.865495 , "None"));
Path.Add(new Vector3(3079.44 , 4835.375 , 2.340756 , "None"));
Path.Add(new Vector3(3081.636 , 4828.948 , 2.112875 , "None"));
Path.Add(new Vector3(3082.512 , 4825.458 , 1.918632 , "None"));
Path.Add(new Vector3(3085.254 , 4823.325 , 1.160857 , "None"));
Path.Add(new Vector3(3089.589 , 4825.424 , 1.03869 , "None"));
Path.Add(new Vector3(3090.741 , 4830.158 , 1.272866 , "None"));
Path.Add(new Vector3(3091.224 , 4825.899 , 1.018875 , "None"));
Path.Add(new Vector3(3091.586 , 4822.248 , 1.029521 , "None"));
Path.Add(new Vector3(3093.531 , 4817.95 , 1.239889 , "None"));
Path.Add(new Vector3(3095.194 , 4814.276 , 1.267098 , "None"));
Path.Add(new Vector3(3096.916 , 4810.47 , 1.229148 , "None"));
Path.Add(new Vector3(3098.36 , 4807.279 , 1.221907 , "None"));
Path.Add(new Vector3(3094.955 , 4806.215 , 1.221524 , "None"));
Path.Add(new Vector3(3089.115 , 4805.623 , 1.220731 , "None"));
Path.Add(new Vector3(3085.088 , 4805.948 , 1.220731 , "None"));
Path.Add(new Vector3(3080.931 , 4806.283 , 1.212108 , "None"));
Path.Add(new Vector3(3077.04 , 4806.598 , 1.137885 , "None"));
Path.Add(new Vector3(3072.875 , 4806.934 , 1.036562 , "None"));
Path.Add(new Vector3(3068.855 , 4807.258 , 1.018567 , "None"));
Path.Add(new Vector3(3064.827 , 4807.584 , 1.018567 , "None"));
Path.Add(new Vector3(3060.663 , 4807.92 , 1.126257 , "None"));
Path.Add(new Vector3(3056.771 , 4808.234 , 1.433112 , "None"));
Path.Add(new Vector3(3055.52 , 4804.782 , 1.375877 , "None"));
Path.Add(new Vector3(3056.683 , 4800.912 , 1.294361 , "None"));
Path.Add(new Vector3(3057.653 , 4797.035 , 0.8244491 , "None"));
Path.Add(new Vector3(3056.14 , 4793.782 , 0.3964663 , "None"));
Path.Add(new Vector3(3052.552 , 4790.961 , 0.3964663 , "None"));
Path.Add(new Vector3(3049.383 , 4788.454 , 0.3964663 , "None"));
Path.Add(new Vector3(3046.213 , 4785.947 , 0.3964663 , "None"));
Path.Add(new Vector3(3042.942 , 4783.36 , 0.3964663 , "None"));
Path.Add(new Vector3(3039.773 , 4780.854 , 0.3964663 , "None"));
Path.Add(new Vector3(3043.659 , 4781.444 , 0.3964663 , "None"));
Path.Add(new Vector3(3051.175 , 4783.026 , 0.3964663 , "None"));
Path.Add(new Vector3(3055.475 , 4783.271 , 0.3964663 , "None"));
Path.Add(new Vector3(3060.98 , 4779.887 , 1.192504 , "None"));
Path.Add(new Vector3(3062.702 , 4776.103 , 1.147373 , "None"));
Path.Add(new Vector3(3061.796 , 4772.327 , 1.535427 , "None"));
Path.Add(new Vector3(3058.755 , 4768.771 , 1.484105 , "None"));
Path.Add(new Vector3(3057.096 , 4765.094 , 1.144691 , "None"));
Path.Add(new Vector3(3055.435 , 4761.411 , 1.084663 , "None"));
Path.Add(new Vector3(3053.72 , 4757.609 , 0.9804285 , "None"));
Path.Add(new Vector3(3052.059 , 4753.926 , 1.408457 , "None"));
Path.Add(new Vector3(3049.964 , 4750.488 , 1.825544 , "None"));
Path.Add(new Vector3(3047.579 , 4747.067 , 1.855264 , "None"));
Path.Add(new Vector3(3045.281 , 4743.772 , 1.855937 , "None"));
Path.Add(new Vector3(3042.961 , 4740.444 , 1.605271 , "None"));
Path.Add(new Vector3(3040.751 , 4737.275 , 1.015159 , "None"));
Path.Add(new Vector3(3037.966 , 4733.988 , 0.3964379 , "None"));
Path.Add(new Vector3(3034.999 , 4731.212 , 0.3964379 , "None"));
Path.Add(new Vector3(3031.99 , 4728.514 , 0.3964379 , "None"));
Path.Add(new Vector3(3033.644 , 4732.072 , 0.3964379 , "None"));
Path.Add(new Vector3(3040.162 , 4737.863 , 0.3964379 , "None"));
Path.Add(new Vector3(3045.637 , 4742.729 , 1.856857 , "None"));
Path.Add(new Vector3(3052.859 , 4749.146 , 1.846689 , "None"));
Path.Add(new Vector3(3059.025 , 4754.625 , 1.8003 , "None"));
Path.Add(new Vector3(3064.306 , 4759.604 , 1.50783 , "None"));
Path.Add(new Vector3(3064.997 , 4766.785 , 1.127804 , "None"));
Path.Add(new Vector3(3065.266 , 4775.483 , 1.125064 , "None"));
Path.Add(new Vector3(3065.535 , 4784.181 , 1.13731 , "None"));
Path.Add(new Vector3(3065.796 , 4792.61 , 1.474615 , "None"));
Path.Add(new Vector3(3066.056 , 4801.04 , 1.386358 , "None"));
Path.Add(new Vector3(3066.281 , 4808.328 , 1.018379 , "None"));
Path.Add(new Vector3(3066.586 , 4818.168 , 1.407556 , "None"));
Path.Add(new Vector3(3070.586 , 4821.282 , 1.289259 , "None"));
Path.Add(new Vector3(3079.819 , 4822.151 , 1.691222 , "None"));
Path.Add(new Vector3(3087.467 , 4822.25 , 1.084389 , "None"));
Path.Add(new Vector3(3095.776 , 4821.557 , 1.347861 , "None"));
Path.Add(new Vector3(3101.648 , 4822.445 , 1.129125 , "None"));
Path.Add(new Vector3(3111.285 , 4824.8 , 1.579019 , "None"));
Path.Add(new Vector3(3119.494 , 4826.806 , 1.278345 , "None"));
Path.Add(new Vector3(3127.195 , 4826.511 , 2.437325 , "None"));
Path.Add(new Vector3(3131.454 , 4826.89 , 3.533576 , "None"));
Path.Add(new Vector3(3133.69 , 4829.449 , 2.622137 , "None"));
Path.Add(new Vector3(3140.369 , 4824.367 , 2.316286 , "None"));
Path.Add(new Vector3(3138.979 , 4816.375 , 2.482525 , "None"));
Path.Add(new Vector3(3135.928 , 4813.528 , 2.08694 , "None"));
Path.Add(new Vector3(3125.429 , 4809.452 , 1.141197 , "None"));
Path.Add(new Vector3(3116.823 , 4808.048 , 1.751393 , "None"));
Path.Add(new Vector3(3108.518 , 4806.694 , 2.083376 , "None"));
Path.Add(new Vector3(3102.206 , 4805.663 , 1.442963 , "None"));
Path.Add(new Vector3(3096.885 , 4804.347 , 1.220873 , "None"));
Path.Add(new Vector3(3100.089 , 4798.255 , 1.631884 , "None"));
Path.Add(new Vector3(3104.726 , 4803.14 , 1.869271 , "None"));
Path.Add(new Vector3(3105.696 , 4812.092 , 1.249392 , "None"));
Path.Add(new Vector3(3106.604 , 4820.46 , 1.219372 , "None"));
Path.Add(new Vector3(3107.536 , 4829.062 , 1.21928 , "None"));
Path.Add(new Vector3(3108.453 , 4837.513 , 1.21928 , "None"));
Path.Add(new Vector3(3109.301 , 4845.329 , 1.381832 , "None"));
Path.Add(new Vector3(3110.299 , 4854.532 , 1.909898 , "None"));
Path.Add(new Vector3(3107.725 , 4859.852 , 2.673857 , "None"));
Path.Add(new Vector3(3101.094 , 4858.487 , 3.07918 , "None"));
Path.Add(new Vector3(3090.414 , 4856.29 , 2.724833 , "None"));
Path.Add(new Vector3(3082.555 , 4853.612 , 2.870671 , "None"));
Path.Add(new Vector3(3075.671 , 4848.26 , 3.509631 , "None"));
Path.Add(new Vector3(3069.251 , 4843.27 , 3.889827 , "None"));
Path.Add(new Vector3(3062.37 , 4837.916 , 3.914011 , "None"));
Path.Add(new Vector3(3060.154 , 4831.957 , 3.449083 , "None"));
Path.Add(new Vector3(3065.628 , 4825.229 , 2.178838 , "None"));
Path.Add(new Vector3(3064.191 , 4817.642 , 1.20786 , "None"));
Path.Add(new Vector3(3059.631 , 4810.21 , 1.312884 , "None"));
Path.Add(new Vector3(3062.541 , 4806.299 , 1.018458 , "None"));
Path.Add(new Vector3(3071.242 , 4806.152 , 1.018458 , "None"));
Path.Add(new Vector3(3079.96 , 4806.004 , 1.179518 , "None"));
Path.Add(new Vector3(3088.376 , 4805.862 , 1.220678 , "None"));
Path.Add(new Vector3(3092.575 , 4805.791 , 1.22086 , "None"));
Path.Add(new Vector3(3099.394 , 4805.902 , 1.221099 , "None"));
Path.Add(new Vector3(3097 , 4802.896 , 1.220954 , "None"));
Path.Add(new Vector3(3100.614 , 4800.235 , 1.279681 , "None"));
Path.Add(new Vector3(3095.917 , 4795.784 , 1.787483 , "None"));
Path.Add(new Vector3(3086.887 , 4800.462 , 1.153485 , "None"));
Path.Add(new Vector3(3078.891 , 4803.143 , 1.134463 , "None"));
Path.Add(new Vector3(3072.03 , 4805.442 , 1.018323 , "None"));
Path.Add(new Vector3(3064.05 , 4808.117 , 1.018323 , "None"));
Path.Add(new Vector3(3059.398 , 4809.676 , 1.317357 , "None"));
Path.Add(new Vector3(3068.365 , 4809.125 , 1.018262 , "None"));
Path.Add(new Vector3(3077.723 , 4808.153 , 1.164882 , "None"));
Path.Add(new Vector3(3086.563 , 4807.235 , 1.220756 , "None"));
Path.Add(new Vector3(3094.04 , 4806.487 , 1.457987 , "None"));
Path.Add(new Vector3(3100.516 , 4804.321 , 1.305545 , "None"));
Path.Add(new Vector3(3096.948 , 4803.556 , 1.221104 , "None"));
Path.Add(new Vector3(3102.984 , 4805.284 , 1.558335 , "None"));
Path.Add(new Vector3(3111.563 , 4803.726 , 3.567543 , "None"));
Path.Add(new Vector3(3119.844 , 4802.22 , 6.078836 , "None"));
Path.Add(new Vector3(3125.915 , 4803.458 , 2.439489 , "None"));
Path.Add(new Vector3(3130.707 , 4805.495 , 2.096478 , "None"));
Path.Add(new Vector3(3138.165 , 4802.7 , 3.464355 , "None"));
Path.Add(new Vector3(3144.722 , 4799.239 , 5.699807 , "None"));
Path.Add(new Vector3(3152.548 , 4795.395 , 6.382734 , "None"));
Path.Add(new Vector3(3156.983 , 4793.217 , 6.739904 , "None"));
Path.Add(new Vector3(3148.75 , 4795.69 , 6.339026 , "None"));
Path.Add(new Vector3(3139.082 , 4798.418 , 5.839738 , "None"));
Path.Add(new Vector3(3129.817 , 4801.032 , 5.956699 , "None"));
Path.Add(new Vector3(3126.836 , 4803.182 , 2.742364 , "None"));
Path.Add(new Vector3(3132.077 , 4805.559 , 2.121282 , "None"));
Path.Add(new Vector3(3123.791 , 4810.656 , 1.313106 , "None"));
Path.Add(new Vector3(3117.891 , 4814.101 , 1.220951 , "None"));
Path.Add(new Vector3(3115.668 , 4822.133 , 1.449942 , "None"));
Path.Add(new Vector3(3113.342 , 4830.536 , 1.220617 , "None"));
Path.Add(new Vector3(3112.293 , 4834.325 , 1.221492 , "None"));
Path.Add(new Vector3(3109.895 , 4842.987 , 1.221492 , "None"));
Path.Add(new Vector3(3105.97 , 4850.172 , 1.807709 , "None"));
Path.Add(new Vector3(3098.749 , 4851.698 , 3.049148 , "None"));
Path.Add(new Vector3(3090.296 , 4853.765 , 2.856261 , "None"));
Path.Add(new Vector3(3095.629 , 4855.815 , 3.065693 , "None"));
Path.Add(new Vector3(3101.695 , 4857.686 , 3.169287 , "None"));
Path.Add(new Vector3(3095.124 , 4854.048 , 3.123373 , "None"));
Path.Add(new Vector3(3091.985 , 4852.441 , 2.802094 , "None"));
Path.Add(new Vector3(3087.635 , 4850.215 , 3.056484 , "None"));
Path.Add(new Vector3(3082.285 , 4847.477 , 3.200463 , "None"));
Path.Add(new Vector3(3077.613 , 4845.085 , 3.866042 , "None"));
Path.Add(new Vector3(3070.698 , 4841.546 , 4.180185 , "None"));
Path.Add(new Vector3(3067.777 , 4838.733 , 4.028806 , "None"));
Path.Add(new Vector3(3060.641 , 4836.29 , 3.868534 , "None"));
Path.Add(new Vector3(3061.92 , 4831.211 , 3.481824 , "None"));
Path.Add(new Vector3(3066.126 , 4824.526 , 2.120188 , "None"));
Path.Add(new Vector3(3064.089 , 4816.53 , 1.219098 , "None"));
Path.Add(new Vector3(3059.5 , 4809.797 , 1.31602 , "None"));
Path.Add(new Vector3(3067.87 , 4807.444 , 1.018424 , "None"));
Path.Add(new Vector3(3075.385 , 4807.045 , 1.133767 , "None"));
Path.Add(new Vector3(3084.663 , 4806.552 , 1.220092 , "None"));
Path.Add(new Vector3(3091.407 , 4806.194 , 1.886912 , "None"));
Path.Add(new Vector3(3100.94 , 4805.688 , 1.302979 , "None"));
Path.Add(new Vector3(3096.801 , 4804.377 , 1.466775 , "None"));
Path.Add(new Vector3(3101.653 , 4801.222 , 2.182219 , "None"));
Path.Add(new Vector3(3105.511 , 4809.375 , 1.529727 , "None"));
Path.Add(new Vector3(3106.429 , 4818.012 , 1.220279 , "None"));
Path.Add(new Vector3(3107.319 , 4826.382 , 1.220427 , "None"));
Path.Add(new Vector3(3108.182 , 4834.501 , 1.220427 , "None"));
Path.Add(new Vector3(3108.99 , 4842.102 , 1.220427 , "None"));
Path.Add(new Vector3(3110.006 , 4851.658 , 1.802384 , "None"));
Path.Add(new Vector3(3110.744 , 4860.192 , 1.873781 , "None"));
Path.Add(new Vector3(3102.395 , 4859.317 , 2.916757 , "None"));
Path.Add(new Vector3(3094.125 , 4857.351 , 2.858214 , "None"));
Path.Add(new Vector3(3085.985 , 4855.417 , 2.738605 , "None"));
Path.Add(new Vector3(3081.375 , 4852.691 , 2.953345 , "None"));
Path.Add(new Vector3(3073.851 , 4846.841 , 3.614647 , "None"));
Path.Add(new Vector3(3066.981 , 4841.499 , 4.130397 , "None"));
Path.Add(new Vector3(3060.542 , 4836.479 , 3.838194 , "None"));
Path.Add(new Vector3(3063.513 , 4829.338 , 3.158661 , "None"));
Path.Add(new Vector3(3066.92 , 4821.763 , 1.867553 , "None"));
Path.Add(new Vector3(3062.255 , 4814.136 , 1.172276 , "None"));
Path.Add(new Vector3(3058.26 , 4807.977 , 1.328495 , "None"));
Path.Add(new Vector3(3062.148 , 4805.838 , 1.018569 , "None"));
Path.Add(new Vector3(3071.287 , 4805.791 , 1.018569 , "None"));
Path.Add(new Vector3(3078.729 , 4805.752 , 1.148768 , "None"));
Path.Add(new Vector3(3088.154 , 4805.704 , 1.22104 , "None"));
Path.Add(new Vector3(3095.293 , 4806.309 , 1.467371 , "None"));
Path.Add(new Vector3(3102.038 , 4805.628 , 1.421888 , "None"));
Path.Add(new Vector3(3096.868 , 4804.56 , 1.220456 , "None"));
Path.Add(new Vector3(3100.917 , 4804.387 , 1.330075 , "None"));
Path.Add(new Vector3(3103.15 , 4815.942 , 1.221757 , "None"));
Path.Add(new Vector3(3104.603 , 4824.25 , 1.203488 , "None"));
Path.Add(new Vector3(3105.908 , 4831.713 , 1.220919 , "None"));
Path.Add(new Vector3(3107.553 , 4841.118 , 1.226342 , "None"));
Path.Add(new Vector3(3109.009 , 4849.442 , 1.559105 , "None"));
Path.Add(new Vector3(3110.456 , 4857.716 , 1.873855 , "None"));
Path.Add(new Vector3(3107.76 , 4861.116 , 2.71931 , "None"));
Path.Add(new Vector3(3099.612 , 4858.993 , 2.95705 , "None"));
Path.Add(new Vector3(3091.174 , 4856.795 , 2.697448 , "None"));
Path.Add(new Vector3(3083.452 , 4853.771 , 2.870349 , "None"));
Path.Add(new Vector3(3076.734 , 4848.7 , 3.453772 , "None"));
Path.Add(new Vector3(3069.775 , 4843.448 , 3.890563 , "None"));
Path.Add(new Vector3(3063.043 , 4838.367 , 4.004353 , "None"));
Path.Add(new Vector3(3062.857 , 4831.536 , 3.529299 , "None"));
Path.Add(new Vector3(3066.336 , 4823.653 , 2.061105 , "None"));
Path.Add(new Vector3(3063.796 , 4816.185 , 1.221268 , "None"));
Path.Add(new Vector3(3059.081 , 4809.192 , 1.323437 , "None"));
Path.Add(new Vector3(3065.471 , 4805.982 , 1.018802 , "None"));
Path.Add(new Vector3(3069.272 , 4798.733 , 1.16938 , "None"));
Path.Add(new Vector3(3072.695 , 4791.025 , 1.134265 , "None"));
Path.Add(new Vector3(3076.219 , 4783.087 , 1.045496 , "None"));
Path.Add(new Vector3(3079.642 , 4775.379 , 1.163291 , "None"));
Path.Add(new Vector3(3083.099 , 4774.219 , 1.011168 , "None"));
Path.Add(new Vector3(3083.338 , 4769.713 , 1.393584 , "None"));
Path.Add(new Vector3(3082.858 , 4764.851 , 1.535627 , "None"));
Path.Add(new Vector3(3081.75 , 4761.081 , 1.070662 , "None"));
Path.Add(new Vector3(3080.497 , 4757.134 , 1.447219 , "None"));
Path.Add(new Vector3(3079.243 , 4753.157 , 1.030739 , "None"));
Path.Add(new Vector3(3078.07 , 4749.433 , 1.018616 , "None"));
Path.Add(new Vector3(3076.81 , 4745.433 , 1.018616 , "None"));
Path.Add(new Vector3(3075.603 , 4741.602 , 1.018616 , "None"));
Path.Add(new Vector3(3074.347 , 4737.617 , 1.132878 , "None"));
Path.Add(new Vector3(3073.178 , 4733.908 , 1.663161 , "None"));
Path.Add(new Vector3(3071.921 , 4729.916 , 2.065371 , "None"));
Path.Add(new Vector3(3069.951 , 4723.666 , 2.797765 , "None"));
Path.Add(new Vector3(3066.67 , 4722.105 , 2.505333 , "None"));
Path.Add(new Vector3(3063.038 , 4723.525 , 1.301608 , "None"));
Path.Add(new Vector3(3058.921 , 4724.789 , 1.156975 , "None"));
Path.Add(new Vector3(3061.29 , 4730.49 , 0.9706575 , "None"));
Path.Add(new Vector3(3063.597 , 4734.212 , 2.18332 , "None"));
Path.Add(new Vector3(3065.79 , 4737.749 , 2.237831 , "None"));
Path.Add(new Vector3(3070.116 , 4744.728 , 1.09211 , "None"));
Path.Add(new Vector3(3072.131 , 4747.978 , 1.0184 , "None"));
Path.Add(new Vector3(3074.303 , 4751.48 , 1.0184 , "None"));
Path.Add(new Vector3(3076.288 , 4754.683 , 1.0184 , "None"));
Path.Add(new Vector3(3078.629 , 4758.459 , 1.0184 , "None"));
Path.Add(new Vector3(3080.984 , 4762.299 , 1.090222 , "None"));
Path.Add(new Vector3(3083.004 , 4765.78 , 1.763422 , "None"));
Path.Add(new Vector3(3082.337 , 4769.896 , 1.093107 , "None"));
Path.Add(new Vector3(3081.48 , 4773.845 , 1.0882 , "None"));
Path.Add(new Vector3(3080.624 , 4777.794 , 1.21648 , "None"));
Path.Add(new Vector3(3079.773 , 4781.72 , 1.105804 , "None"));
Path.Add(new Vector3(3078.884 , 4785.819 , 1.134903 , "None"));
Path.Add(new Vector3(3078.081 , 4789.524 , 1.134903 , "None"));
Path.Add(new Vector3(3077.171 , 4793.718 , 1.134903 , "None"));
Path.Add(new Vector3(3076.288 , 4797.793 , 1.134903 , "None"));
Path.Add(new Vector3(3075.431 , 4801.742 , 1.134903 , "None"));
Path.Add(new Vector3(3074.575 , 4805.691 , 1.112013 , "None"));
Path.Add(new Vector3(3073.719 , 4809.641 , 1.062705 , "None"));
Path.Add(new Vector3(3072.835 , 4813.716 , 1.160372 , "None"));
Path.Add(new Vector3(3071.965 , 4817.728 , 1.217112 , "None"));
Path.Add(new Vector3(3071.095 , 4821.741 , 1.220965 , "None"));
Path.Add(new Vector3(3070.353 , 4825.163 , 1.332567 , "None"));
Path.Add(new Vector3(3069.281 , 4830.9 , 2.515157 , "None"));
Path.Add(new Vector3(3068.931 , 4835.056 , 3.739033 , "None"));
Path.Add(new Vector3(3068.592 , 4839.083 , 4.025973 , "None"));
Path.Add(new Vector3(3067.902 , 4847.265 , 2.657886 , "None"));
Path.Add(new Vector3(3067.563 , 4851.292 , 2.026592 , "None"));
Path.Add(new Vector3(3067.235 , 4855.182 , 1.617667 , "None"));
Path.Add(new Vector3(3066.874 , 4859.474 , 0.7451267 , "None"));
Path.Add(new Vector3(3066.546 , 4863.372 , 0.3965245 , "None"));
Path.Add(new Vector3(3066.207 , 4867.391 , 0.3965245 , "None"));
Path.Add(new Vector3(3065.644 , 4874.073 , 0.3965245 , "None"));
Path.Add(new Vector3(3065.321 , 4877.907 , 0.3965245 , "None"));
Path.Add(new Vector3(3064.955 , 4882.255 , 0.3965245 , "None"));
Path.Add(new Vector3(3064.616 , 4886.282 , 0.3965245 , "None"));
Path.Add(new Vector3(3064.292 , 4890.124 , 0.3965245 , "None"));
Path.Add(new Vector3(3063.927 , 4894.463 , 0.3965245 , "None"));
Path.Add(new Vector3(3063.576 , 4898.627 , 0.3965245 , "None"));
Path.Add(new Vector3(3063.249 , 4902.517 , 0.3965245 , "None"));
Path.Add(new Vector3(3055.28 , 4906.168 , 0.9121153 , "None"));
Path.Add(new Vector3(3048.879 , 4908.473 , 1.531837 , "None"));
Path.Add(new Vector3(3039.537 , 4911.836 , 1.903122 , "None"));
Path.Add(new Vector3(3034.273 , 4913.731 , 1.76571 , "None"));
Path.Add(new Vector3(3023.43 , 4917.635 , 0.3966337 , "None"));
Path.Add(new Vector3(3017.415 , 4918.539 , 0.3966337 , "None"));
Path.Add(new Vector3(3007.557 , 4918.28 , 0.3966337 , "None"));
Path.Add(new Vector3(3001.387 , 4919.353 , 0.3966337 , "None"));
Path.Add(new Vector3(2992.131 , 4920.941 , 0.3966337 , "None"));
Path.Add(new Vector3(2986.832 , 4921.85 , 0.3966337 , "None"));
Path.Add(new Vector3(2975.026 , 4923.875 , 2.043489 , "None"));
Path.Add(new Vector3(2966.813 , 4925.284 , 4.203908 , "None"));
Path.Add(new Vector3(2958.435 , 4926.722 , 4.925925 , "None"));
Path.Add(new Vector3(2951.497 , 4927.912 , 4.561458 , "None"));
Path.Add(new Vector3(2941.347 , 4929.654 , 2.073937 , "None"));
Path.Add(new Vector3(2934.144 , 4930.889 , 2.201324 , "None"));
Path.Add(new Vector3(2925.882 , 4932.307 , 1.891637 , "None"));
Path.Add(new Vector3(2918.684 , 4933.542 , 2.561965 , "None"));
Path.Add(new Vector3(2914.542 , 4934.252 , 2.561965 , "None"));
Path.Add(new Vector3(2918.535 , 4932.01 , 2.561965 , "None"));
Path.Add(new Vector3(2917.733 , 4926.461 , 2.561889 , "None"));
Path.Add(new Vector3(2913.804 , 4923.457 , 2.561889 , "None"));
Path.Add(new Vector3(2905.29 , 4923.795 , 1.993964 , "None"));
Path.Add(new Vector3(2901.653 , 4922.806 , 1.978058 , "None"));
Path.Add(new Vector3(2896.973 , 4924.639 , 3.188423 , "None"));
Path.Add(new Vector3(2893.041 , 4922.586 , 3.229393 , "None"));
Path.Add(new Vector3(2887.162 , 4917.089 , 2.416449 , "None"));
Path.Add(new Vector3(2881.918 , 4911.029 , 2.539067 , "None"));
Path.Add(new Vector3(2879.335 , 4904.778 , 2.684373 , "None"));
Path.Add(new Vector3(2879.889 , 4897.845 , 2.535054 , "None"));
Path.Add(new Vector3(2882.278 , 4891.871 , 2.070513 , "None"));
Path.Add(new Vector3(2885.556 , 4883.719 , 2.177663 , "None"));
Path.Add(new Vector3(2888.67 , 4877.276 , 2.092902 , "None"));
Path.Add(new Vector3(2892.176 , 4870.107 , 1.06357 , "None"));
Path.Add(new Vector3(2896.021 , 4862.245 , 0.3964618 , "None"));
Path.Add(new Vector3(2899.601 , 4854.925 , 0.3964618 , "None"));
Path.Add(new Vector3(2903.299 , 4847.364 , 0.3964618 , "None"));
Path.Add(new Vector3(2906.402 , 4841.02 , 0.3964618 , "None"));
Path.Add(new Vector3(2902.524 , 4839.141 , 0.3964618 , "None"));
Path.Add(new Vector3(2897.391 , 4837.934 , 0.3964618 , "None"));
Path.Add(new Vector3(2893.45 , 4837.006 , 0.3964618 , "None"));
Path.Add(new Vector3(2889.743 , 4836.134 , 0.3964618 , "None"));
Path.Add(new Vector3(2884.575 , 4834.918 , -1.596111 , "Swimming"));
Path.Add(new Vector3(2885.256 , 4838.99 , -1.5223 , "Swimming"));
Path.Add(new Vector3(2884.219 , 4842.943 , 0.396394 , "None"));
Path.Add(new Vector3(2884.665 , 4847.494 , 0.396394 , "None"));
Path.Add(new Vector3(2885.098 , 4851.925 , 0.396394 , "None"));
Path.Add(new Vector3(2885.459 , 4855.659 , 0.396394 , "None"));
Path.Add(new Vector3(2886.138 , 4862.67 , 0.396394 , "None"));
Path.Add(new Vector3(2886.543 , 4866.86 , 0.396394 , "None"));
Path.Add(new Vector3(2886.894 , 4870.482 , 0.9662597 , "None"));
Path.Add(new Vector3(2883.37 , 4875.078 , 1.839249 , "None"));
Path.Add(new Vector3(2878.087 , 4880.673 , 1.862823 , "None"));
Path.Add(new Vector3(2870.115 , 4889.112 , 2.431779 , "None"));
Path.Add(new Vector3(2869.115 , 4894.362 , 2.538153 , "None"));
Path.Add(new Vector3(2862.123 , 4900.117 , 2.538583 , "None"));
Path.Add(new Vector3(2858.644 , 4900.878 , 2.538583 , "None"));
Path.Add(new Vector3(2849.743 , 4899.877 , 2.486298 , "None"));
Path.Add(new Vector3(2841.621 , 4899.229 , 1.944631 , "None"));
Path.Add(new Vector3(2833.214 , 4898.557 , 2.050985 , "None"));
Path.Add(new Vector3(2824.807 , 4897.886 , 2.481232 , "None"));
Path.Add(new Vector3(2815.295 , 4897.127 , 2.566348 , "None"));
Path.Add(new Vector3(2807.729 , 4896.523 , 2.606651 , "None"));
Path.Add(new Vector3(2799.891 , 4895.898 , 2.644306 , "None"));
Path.Add(new Vector3(2791.752 , 4895.248 , 2.644038 , "None"));
Path.Add(new Vector3(2782.24 , 4894.489 , 2.045375 , "None"));
Path.Add(new Vector3(2773.85 , 4893.819 , 1.060076 , "None"));
Path.Add(new Vector3(2765.175 , 4893.127 , 0.3972854 , "None"));
Path.Add(new Vector3(2757.589 , 4892.521 , 0.3972854 , "None"));
Path.Add(new Vector3(2748.362 , 4891.785 , 0.3972854 , "None"));
Path.Add(new Vector3(2739.67 , 4891.091 , 0.3972854 , "None"));
Path.Add(new Vector3(2730.443 , 4890.354 , 0.3972854 , "None"));
Path.Add(new Vector3(2722.036 , 4889.684 , 0.3972854 , "None"));
Path.Add(new Vector3(2715.957 , 4889.198 , 0.3972854 , "None"));
Path.Add(new Vector3(2708.889 , 4888.635 , 1.66074 , "None"));
Path.Add(new Vector3(2698.681 , 4885.355 , 3.180922 , "None"));
Path.Add(new Vector3(2690.573 , 4884.553 , 3.638272 , "None"));
Path.Add(new Vector3(2685.557 , 4884.056 , 4.301365 , "None"));
Path.Add(new Vector3(2673.236 , 4882.836 , 4.321811 , "None"));
Path.Add(new Vector3(2664.86 , 4882.007 , 3.387953 , "None"));
Path.Add(new Vector3(2659.409 , 4880.012 , 2.087251 , "None"));
Path.Add(new Vector3(2654.264 , 4879.648 , 1.805294 , "None"));
Path.Add(new Vector3(2642.802 , 4878.84 , 1.953935 , "None"));
Path.Add(new Vector3(2634.674 , 4878.267 , 1.925429 , "None"));
Path.Add(new Vector3(2625.976 , 4877.653 , -1.170026 , "None"));
Path.Add(new Vector3(2621.462 , 4877.334 , -2.417785 , "Swimming"));
Path.Add(new Vector3(2616.733 , 4877.001 , -2.389872 , "Swimming"));
Path.Add(new Vector3(2612.169 , 4876.679 , -2.362931 , "Swimming"));
Path.Add(new Vector3(2607.195 , 4875.941 , -2.337613 , "Swimming"));
Path.Add(new Vector3(2612.775 , 4876.252 , -2.161222 , "Swimming"));
Path.Add(new Vector3(2617.318 , 4876.832 , -2.161222 , "Swimming"));
Path.Add(new Vector3(2622.331 , 4877.471 , -2.161222 , "Swimming"));
Path.Add(new Vector3(2629.56 , 4878.385 , 0.7349055 , "None"));
Path.Add(new Vector3(2624.045 , 4876.613 , -2.509252 , "Swimming"));
Path.Add(new Vector3(2619.386 , 4876.535 , -2.737939 , "Swimming"));
Path.Add(new Vector3(2614.587 , 4876.454 , -2.593458 , "Swimming"));
Path.Add(new Vector3(2609.754 , 4876.377 , -2.447983 , "Swimming"));
Path.Add(new Vector3(2605.18 , 4875.232 , -2.418566 , "Swimming"));
Path.Add(new Vector3(2601.18 , 4874.021 , -2.4058 , "Swimming"));
Path.Add(new Vector3(2595.96 , 4872.439 , -2.389139 , "Swimming"));
Path.Add(new Vector3(2591.477 , 4871.082 , -2.37483 , "Swimming"));
Path.Add(new Vector3(2586.817 , 4869.67 , -2.359958 , "Swimming"));
Path.Add(new Vector3(2583.319 , 4868.61 , -2.348793 , "Swimming"));
Path.Add(new Vector3(2579.734 , 4865.531 , -2.298365 , "Swimming"));
Path.Add(new Vector3(2577.143 , 4861.482 , -2.242549 , "Swimming"));
Path.Add(new Vector3(2575.552 , 4857.064 , -2.186492 , "Swimming"));
Path.Add(new Vector3(2577.857 , 4853.034 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2581.671 , 4850.648 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2585.79 , 4848.302 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2589.976 , 4845.918 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2594.416 , 4846.991 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2597.648 , 4850.544 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2599.864 , 4846.488 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2601.896 , 4842.215 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2603.85 , 4838.104 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2605.941 , 4833.707 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2607.99 , 4829.399 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2609.991 , 4825.19 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2612.161 , 4820.627 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2614.231 , 4816.273 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2616.3 , 4811.923 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2618.332 , 4807.65 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2620.404 , 4803.292 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2622.471 , 4798.946 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2624.507 , 4794.664 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2626.575 , 4790.314 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2628.644 , 4785.964 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2630.373 , 4782.327 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2632.592 , 4777.661 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2634.695 , 4773.239 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2636.702 , 4769.017 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2639.938 , 4766.03 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2643.826 , 4763.14 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2647.692 , 4760.266 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2651.47 , 4757.457 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2654.893 , 4754.913 , -1.548189 , "Swimming"));
Path.Add(new Vector3(2652.373 , 4752.342 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2648.114 , 4753.375 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2644.667 , 4756.74 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2641.248 , 4760.436 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2638.394 , 4764.489 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2635.696 , 4768.388 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2632.959 , 4772.345 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2630.707 , 4775.6 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2627.604 , 4780.085 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2624.993 , 4783.86 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2622.261 , 4787.81 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2619.475 , 4791.837 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2616.735 , 4795.798 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2614.532 , 4798.982 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2612.369 , 4802.109 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2609.672 , 4806.008 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2606.601 , 4810.447 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2603.63 , 4814.742 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2601.04 , 4818.486 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2598.238 , 4822.536 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2595.597 , 4826.354 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2592.865 , 4830.303 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2589.809 , 4832.151 , 0.5158998 , "None"));
Path.Add(new Vector3(2588.109 , 4834.898 , -1.602662 , "Swimming"));
Path.Add(new Vector3(2585.76 , 4838.693 , -1.571237 , "Swimming"));
Path.Add(new Vector3(2583.273 , 4842.712 , -1.53795 , "Swimming"));
Path.Add(new Vector3(2580.748 , 4846.792 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2578.735 , 4850.044 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2575.922 , 4854.59 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2576.32 , 4859.707 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2578.857 , 4864.151 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2582.098 , 4867.637 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2586.621 , 4869.202 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2591.208 , 4870.718 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2595.687 , 4872.199 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2600.269 , 4873.713 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2604.466 , 4875.101 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2608.928 , 4876.38 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2613.714 , 4876.961 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2618.416 , 4877.532 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2623.202 , 4878.114 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2629.798 , 4878.91 , 0.8705376 , "None"));
Path.Add(new Vector3(2624.056 , 4876.844 , -2.372409 , "Swimming"));
Path.Add(new Vector3(2619.269 , 4876.689 , -2.354576 , "Swimming"));
Path.Add(new Vector3(2614.455 , 4876.534 , -2.288821 , "Swimming"));
Path.Add(new Vector3(2609.802 , 4876.383 , -2.225257 , "Swimming"));
Path.Add(new Vector3(2605.794 , 4875.367 , -2.204479 , "Swimming"));
Path.Add(new Vector3(2610.474 , 4875.525 , -2.161551 , "Swimming"));
Path.Add(new Vector3(2615.324 , 4876.164 , -2.161551 , "Swimming"));
Path.Add(new Vector3(2620.086 , 4876.791 , -2.161551 , "Swimming"));
Path.Add(new Vector3(2625.341 , 4877.476 , -1.587451 , "None"));
Path.Add(new Vector3(2632.494 , 4878.419 , 1.653501 , "None"));
Path.Add(new Vector3(2624.982 , 4876.713 , -1.980845 , "None"));
Path.Add(new Vector3(2620.273 , 4876.618 , -2.161807 , "Swimming"));
Path.Add(new Vector3(2615.486 , 4876.521 , -2.161807 , "Swimming"));
Path.Add(new Vector3(2610.642 , 4876.423 , -2.161807 , "Swimming"));
Path.Add(new Vector3(2606.03 , 4875.512 , -2.161807 , "Swimming"));
Path.Add(new Vector3(2611.218 , 4875.642 , -2.161807 , "Swimming"));
Path.Add(new Vector3(2615.994 , 4876.271 , -2.161807 , "Swimming"));
Path.Add(new Vector3(2620.694 , 4876.889 , -2.161807 , "Swimming"));
Path.Add(new Vector3(2627.501 , 4877.775 , -0.3395523 , "None"));
Path.Add(new Vector3(2632.788 , 4878.471 , 1.738352 , "None"));
Path.Add(new Vector3(2625.942 , 4876.948 , -1.357457 , "None"));
Path.Add(new Vector3(2620.967 , 4876.79 , -2.539014 , "Swimming"));
Path.Add(new Vector3(2615.607 , 4876.62 , -2.410396 , "Swimming"));
Path.Add(new Vector3(2610.869 , 4876.469 , -2.296724 , "Swimming"));
Path.Add(new Vector3(2615.426 , 4877.64 , -2.160987 , "Swimming"));
Path.Add(new Vector3(2619.319 , 4878.094 , -2.160987 , "Swimming"));
Path.Add(new Vector3(2623.644 , 4878.599 , -2.160987 , "Swimming"));
Path.Add(new Vector3(2629.746 , 4879.258 , 0.8959872 , "None"));
Path.Add(new Vector3(2637.289 , 4880.138 , 2.636208 , "None"));
Path.Add(new Vector3(2646.767 , 4881.244 , 2.588303 , "None"));
Path.Add(new Vector3(2655.477 , 4882.26 , 2.460858 , "None"));
Path.Add(new Vector3(2661.635 , 4882.979 , 3.290643 , "None"));
Path.Add(new Vector3(2669.877 , 4882.635 , 4.037912 , "None"));
Path.Add(new Vector3(2676.065 , 4878.17 , 2.591562 , "None"));
Path.Add(new Vector3(2667.79 , 4877.907 , 2.303253 , "None"));
Path.Add(new Vector3(2660.351 , 4877.712 , 2.031462 , "None"));
Path.Add(new Vector3(2651.382 , 4877.478 , 0.7326329 , "None"));
Path.Add(new Vector3(2642.935 , 4877.257 , 1.025068 , "None"));
Path.Add(new Vector3(2633.732 , 4877.016 , 1.616203 , "None"));
Path.Add(new Vector3(2625.234 , 4876.794 , -1.81234 , "None"));
Path.Add(new Vector3(2621.451 , 4876.695 , -4.069509 , "Swimming"));
Path.Add(new Vector3(2616.679 , 4876.57 , -4.036553 , "Swimming"));
Path.Add(new Vector3(2611.864 , 4876.444 , -4.003304 , "Swimming"));
Path.Add(new Vector3(2616.039 , 4877.636 , -3.684004 , "Swimming"));
Path.Add(new Vector3(2620.744 , 4878.189 , -3.489593 , "Swimming"));
Path.Add(new Vector3(2624.029 , 4878.296 , -2.201251 , "Swimming"));
Path.Add(new Vector3(2619.699 , 4877.783 , -2.307456 , "Swimming"));
Path.Add(new Vector3(2614.996 , 4877.224 , -2.230579 , "Swimming"));
Path.Add(new Vector3(2610.214 , 4876.657 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2606.277 , 4875.889 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2601.229 , 4874.294 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2597.325 , 4873.06 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2592.881 , 4871.655 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2588.257 , 4870.194 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2584.484 , 4869.001 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2580.129 , 4866.064 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2577.544 , 4862.828 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2575.657 , 4857.867 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2577.175 , 4853.892 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2581.085 , 4851.059 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2585.843 , 4848.335 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2590.204 , 4845.84 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2594.385 , 4843.447 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2598.295 , 4844.314 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2600.818 , 4846.773 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2602.68 , 4842.75 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2604.518 , 4838.777 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2606.301 , 4834.924 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2608.423 , 4830.338 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2610.497 , 4825.855 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2612.456 , 4821.621 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2614.667 , 4816.843 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2616.492 , 4812.9 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2618.403 , 4808.769 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2620.063 , 4805.181 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2621.953 , 4801.097 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2623.871 , 4796.953 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2626.06 , 4792.222 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2627.718 , 4788.639 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2629.249 , 4785.33 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2631.077 , 4781.379 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2632.558 , 4778.177 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2634.714 , 4773.519 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2636.724 , 4769.425 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2640.26 , 4766.635 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2644.29 , 4763.455 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2648.071 , 4760.471 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2651.682 , 4757.622 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2655.193 , 4754.851 , -2.104395 , "Swimming"));
Path.Add(new Vector3(2657.834 , 4754.845 , 0.3200568 , "None"));
Path.Add(new Vector3(2654.255 , 4753.677 , -2.166256 , "Swimming"));
Path.Add(new Vector3(2649.678 , 4752.498 , -2.100555 , "Swimming"));
Path.Add(new Vector3(2647.868 , 4757.441 , -2.004835 , "Swimming"));
Path.Add(new Vector3(2643.924 , 4759.011 , -1.921492 , "Swimming"));
Path.Add(new Vector3(2639.928 , 4761.635 , -1.832458 , "Swimming"));
Path.Add(new Vector3(2637.145 , 4765.687 , -1.828592 , "Swimming"));
Path.Add(new Vector3(2634.462 , 4769.59 , -1.824868 , "Swimming"));
Path.Add(new Vector3(2631.804 , 4773.458 , -1.821177 , "Swimming"));
Path.Add(new Vector3(2628.159 , 4778.763 , -1.816116 , "Swimming"));
Path.Add(new Vector3(2625.725 , 4782.305 , -1.812737 , "Swimming"));
Path.Add(new Vector3(2623.153 , 4786.049 , -1.809166 , "Swimming"));
Path.Add(new Vector3(2620.409 , 4790.042 , -1.805356 , "Swimming"));
Path.Add(new Vector3(2617.678 , 4794.016 , -1.801565 , "Swimming"));
Path.Add(new Vector3(2615.263 , 4797.531 , -1.798212 , "Swimming"));
Path.Add(new Vector3(2612.314 , 4801.823 , -1.794117 , "Swimming"));
Path.Add(new Vector3(2609.586 , 4805.793 , -1.790329 , "Swimming"));
Path.Add(new Vector3(2606.946 , 4809.635 , -1.786664 , "Swimming"));
Path.Add(new Vector3(2604.128 , 4813.737 , -1.782751 , "Swimming"));
Path.Add(new Vector3(2601.111 , 4818.127 , -1.778563 , "Swimming"));
Path.Add(new Vector3(2598.653 , 4821.704 , -1.77515 , "Swimming"));
Path.Add(new Vector3(2596.648 , 4824.623 , -1.772365 , "Swimming"));
Path.Add(new Vector3(2593.468 , 4829.25 , -1.767951 , "Swimming"));
Path.Add(new Vector3(2590.973 , 4832.881 , -1.764486 , "Swimming"));
Path.Add(new Vector3(2588.724 , 4836.155 , -1.761364 , "Swimming"));
Path.Add(new Vector3(2585.432 , 4840.946 , -1.756793 , "Swimming"));
Path.Add(new Vector3(2582.865 , 4844.682 , -1.753228 , "Swimming"));
Path.Add(new Vector3(2580.137 , 4848.652 , -1.749441 , "Swimming"));
Path.Add(new Vector3(2577.54 , 4852.431 , -1.745836 , "Swimming"));
Path.Add(new Vector3(2575.889 , 4856.002 , -1.716236 , "Swimming"));
Path.Add(new Vector3(2576.839 , 4860.656 , -1.641846 , "Swimming"));
Path.Add(new Vector3(2579.359 , 4864.647 , -1.587493 , "Swimming"));
Path.Add(new Vector3(2582.712 , 4867.913 , -1.542197 , "Swimming"));
Path.Add(new Vector3(2587.285 , 4869.424 , -1.526121 , "Swimming"));
Path.Add(new Vector3(2591.729 , 4870.893 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2595.239 , 4872.052 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2599.445 , 4873.442 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2604.471 , 4875.103 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2608.955 , 4876.585 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2613.253 , 4877.108 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2617.239 , 4877.584 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2621.566 , 4878.101 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2617.641 , 4877.282 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2613.358 , 4876.874 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2609.094 , 4876.467 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2613.136 , 4875.875 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2618.441 , 4876.574 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2623.137 , 4877.192 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2629.311 , 4877.996 , 0.6033928 , "None"));
Path.Add(new Vector3(2632.906 , 4878.47 , 1.764905 , "None"));
Path.Add(new Vector3(2628.715 , 4876.791 , 0.1686118 , "None"));
Path.Add(new Vector3(2624.069 , 4876.695 , -2.362402 , "Swimming"));
Path.Add(new Vector3(2618.517 , 4876.581 , -2.55708 , "Swimming"));
Path.Add(new Vector3(2613.543 , 4876.478 , -2.412455 , "Swimming"));
Path.Add(new Vector3(2608.998 , 4876.387 , -2.280316 , "Swimming"));
Path.Add(new Vector3(2604.114 , 4875.013 , -2.264288 , "Swimming"));
Path.Add(new Vector3(2599.551 , 4873.61 , -2.249242 , "Swimming"));
Path.Add(new Vector3(2595.462 , 4872.352 , -2.235759 , "Swimming"));
Path.Add(new Vector3(2590.488 , 4870.823 , -2.21936 , "Swimming"));
Path.Add(new Vector3(2585.807 , 4869.383 , -2.203927 , "Swimming"));
Path.Add(new Vector3(2581.583 , 4867.481 , -2.175016 , "Swimming"));
Path.Add(new Vector3(2578.244 , 4864 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2576.273 , 4859.687 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2576.177 , 4855.159 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2579.658 , 4851.952 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2583.764 , 4849.591 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2587.121 , 4847.661 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2592.05 , 4844.827 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2595.301 , 4842.958 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2598.258 , 4845.544 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2602.267 , 4843.527 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2604.058 , 4839.662 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2606.283 , 4834.859 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2608.209 , 4830.703 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2610.236 , 4826.328 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2612.326 , 4821.816 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2614.234 , 4817.699 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2616.422 , 4812.978 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2618.3 , 4808.924 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2620.228 , 4804.764 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2622.253 , 4800.394 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2624.339 , 4795.89 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2626.305 , 4791.648 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2628.024 , 4787.938 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2630.357 , 4782.904 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2632.376 , 4778.546 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2634.173 , 4774.668 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2636.053 , 4770.611 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2638.763 , 4767.137 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2642.573 , 4764.26 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2646.458 , 4761.326 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2650.2 , 4758.5 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2654.035 , 4755.604 , -2.032698 , "Swimming"));
Path.Add(new Vector3(2657.638 , 4752.882 , -1.524413 , "Swimming"));
Path.Add(new Vector3(2654.182 , 4751.989 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2649.81 , 4752.239 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2645.82 , 4755.822 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2642.596 , 4758.854 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2639.505 , 4762.943 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2637.078 , 4766.449 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2634.055 , 4770.817 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2631.907 , 4773.919 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2628.725 , 4778.517 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2625.97 , 4782.497 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2623.229 , 4786.457 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2620.621 , 4790.223 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2617.789 , 4794.315 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2615.378 , 4797.798 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2612.349 , 4802.174 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2609.591 , 4806.158 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2606.865 , 4810.095 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2604.662 , 4813.279 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2601.517 , 4817.821 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2599.203 , 4821.165 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2596.456 , 4825.132 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2593.717 , 4829.089 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2591.29 , 4832.595 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2588.896 , 4836.055 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2586.063 , 4840.147 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2583.413 , 4843.976 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2580.598 , 4848.041 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2577.881 , 4851.966 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2576.034 , 4854.962 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2576.613 , 4859.587 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2578.633 , 4863.943 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2581.872 , 4867.405 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2586.2 , 4869.163 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2590.676 , 4870.624 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2595.304 , 4872.134 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2599.829 , 4873.61 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2604.135 , 4875.016 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2608.085 , 4876.305 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2612.709 , 4876.879 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2617.022 , 4877.401 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2622.535 , 4878.069 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2626.154 , 4878.499 , -0.9076478 , "None"));
Path.Add(new Vector3(2621.962 , 4876.838 , -3.644435 , "Swimming"));
Path.Add(new Vector3(2617.302 , 4876.667 , -3.503344 , "Swimming"));
Path.Add(new Vector3(2612.41 , 4876.488 , -3.355254 , "Swimming"));
Path.Add(new Vector3(2607.657 , 4875.987 , -3.245633 , "Swimming"));
Path.Add(new Vector3(2603.119 , 4874.612 , -3.23237 , "Swimming"));
Path.Add(new Vector3(2598.505 , 4873.214 , -3.218881 , "Swimming"));
Path.Add(new Vector3(2593.973 , 4871.84 , -3.205631 , "Swimming"));
Path.Add(new Vector3(2589.363 , 4870.443 , -3.192156 , "Swimming"));
Path.Add(new Vector3(2584.753 , 4869.046 , -3.178681 , "Swimming"));
Path.Add(new Vector3(2580.789 , 4866.564 , -3.140455 , "Swimming"));
Path.Add(new Vector3(2577.767 , 4862.893 , -3.084621 , "Swimming"));
Path.Add(new Vector3(2575.975 , 4858.504 , -3.033854 , "Swimming"));
Path.Add(new Vector3(2576.455 , 4854.681 , -2.959163 , "Swimming"));
Path.Add(new Vector3(2580.615 , 4851.305 , -2.900999 , "Swimming"));
Path.Add(new Vector3(2584.796 , 4848.915 , -2.888972 , "Swimming"));
Path.Add(new Vector3(2588.982 , 4846.522 , -2.876934 , "Swimming"));
Path.Add(new Vector3(2593.094 , 4844.172 , -2.865108 , "Swimming"));
Path.Add(new Vector3(2597.276 , 4841.782 , -2.853081 , "Swimming"));
Path.Add(new Vector3(2601.458 , 4839.392 , -2.841055 , "Swimming"));
Path.Add(new Vector3(2605.505 , 4837.079 , -2.829417 , "Swimming"));
Path.Add(new Vector3(2609.997 , 4835.366 , -2.819284 , "Swimming"));
Path.Add(new Vector3(2613.95 , 4834.864 , -2.813622 , "Swimming"));
Path.Add(new Vector3(2610.55 , 4838.024 , -2.742108 , "Swimming"));
Path.Add(new Vector3(2607.685 , 4835.239 , -2.627463 , "Swimming"));
Path.Add(new Vector3(2609.604 , 4830.898 , -2.622548 , "Swimming"));
Path.Add(new Vector3(2611.429 , 4826.77 , -2.617873 , "Swimming"));
Path.Add(new Vector3(2613.475 , 4822.144 , -2.612635 , "Swimming"));
Path.Add(new Vector3(2615.262 , 4818.102 , -2.608057 , "Swimming"));
Path.Add(new Vector3(2617.338 , 4813.407 , -2.602741 , "Swimming"));
Path.Add(new Vector3(2619.292 , 4808.989 , -2.597738 , "Swimming"));
Path.Add(new Vector3(2621.203 , 4804.666 , -2.592843 , "Swimming"));
Path.Add(new Vector3(2623.151 , 4800.26 , -2.587854 , "Swimming"));
Path.Add(new Vector3(2625.051 , 4795.963 , -2.582988 , "Swimming"));
Path.Add(new Vector3(2627.049 , 4791.445 , -2.577873 , "Swimming"));
Path.Add(new Vector3(2628.964 , 4787.114 , -2.572967 , "Swimming"));
Path.Add(new Vector3(2630.912 , 4782.708 , -2.567979 , "Swimming"));
Path.Add(new Vector3(2632.827 , 4778.376 , -2.563074 , "Swimming"));
Path.Add(new Vector3(2634.718 , 4774.101 , -2.558232 , "Swimming"));
Path.Add(new Vector3(2636.633 , 4769.769 , -2.553327 , "Swimming"));
Path.Add(new Vector3(2640.128 , 4766.673 , -2.257161 , "Swimming"));
Path.Add(new Vector3(2643.906 , 4763.706 , -2.161929 , "Swimming"));
Path.Add(new Vector3(2647.619 , 4760.79 , -2.161971 , "Swimming"));
Path.Add(new Vector3(2651.188 , 4757.983 , -2.161914 , "Swimming"));
Path.Add(new Vector3(2655.002 , 4754.986 , -2.089343 , "Swimming"));
Path.Add(new Vector3(2651.4 , 4752.283 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2647.537 , 4754.359 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2644.014 , 4757.545 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2640.757 , 4761.183 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2638.048 , 4765.068 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2635.303 , 4769.032 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2632.562 , 4772.992 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2629.841 , 4776.921 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2627.124 , 4780.846 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2624.425 , 4784.744 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2621.683 , 4788.704 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2618.941 , 4792.665 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2616.199 , 4796.625 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2613.5 , 4800.522 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2610.756 , 4804.486 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2608.017 , 4808.443 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2605.318 , 4812.341 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2602.576 , 4816.301 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2599.834 , 4820.261 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2597.181 , 4824.093 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2594.482 , 4827.991 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2591.662 , 4832.063 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2588.953 , 4835.977 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2586.211 , 4839.937 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2583.514 , 4843.832 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2580.773 , 4847.792 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2578.074 , 4851.689 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2575.959 , 4854.75 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2576.619 , 4859.788 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2578.741 , 4863.915 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2581.984 , 4867.477 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2586.351 , 4869.206 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2590.93 , 4870.701 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2595.584 , 4872.221 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2600.091 , 4873.693 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2604.67 , 4875.188 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2608.942 , 4876.338 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2613.713 , 4876.919 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2618.504 , 4877.503 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2623.206 , 4878.077 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2629.94 , 4878.893 , 0.9124877 , "None"));
Path.Add(new Vector3(2633.832 , 4879.367 , 2.095155 , "None"));
Path.Add(new Vector3(2637.44 , 4878.402 , 2.183965 , "None"));
Path.Add(new Vector3(2628.017 , 4876.973 , -0.1749008 , "None"));
Path.Add(new Vector3(2624.078 , 4876.845 , -2.488152 , "Swimming"));
Path.Add(new Vector3(2619.043 , 4876.682 , -2.937968 , "Swimming"));
Path.Add(new Vector3(2614.31 , 4876.528 , -2.720604 , "Swimming"));
Path.Add(new Vector3(2609.972 , 4876.387 , -2.521426 , "Swimming"));
Path.Add(new Vector3(2614.269 , 4876.753 , -2.19983 , "Swimming"));
Path.Add(new Vector3(2619.071 , 4877.35 , -2.161079 , "Swimming"));
Path.Add(new Vector3(2623.771 , 4877.934 , -2.161079 , "Swimming"));
Path.Add(new Vector3(2630.937 , 4878.82 , 1.213199 , "None"));
Path.Add(new Vector3(2637.263 , 4879.606 , 2.544891 , "None"));
Path.Add(new Vector3(2624.272 , 4877.28 , -2.261083 , "Swimming"));
Path.Add(new Vector3(2620.687 , 4877.077 , -2.465223 , "Swimming"));
Path.Add(new Vector3(2615.629 , 4876.789 , -2.352228 , "Swimming"));
Path.Add(new Vector3(2611.1 , 4876.532 , -2.251027 , "Swimming"));
Path.Add(new Vector3(2606.876 , 4876.03 , -2.17646 , "Swimming"));
Path.Add(new Vector3(2602.308 , 4874.595 , -2.163191 , "Swimming"));
Path.Add(new Vector3(2597.821 , 4873.185 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2593.302 , 4871.766 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2588.63 , 4870.298 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2584.386 , 4868.965 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2580.288 , 4866.194 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2577.498 , 4862.354 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2575.943 , 4858.474 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2576.093 , 4854.167 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2579.549 , 4851.701 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2582.785 , 4849.875 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2586.429 , 4847.818 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2591.314 , 4845.062 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2594.683 , 4843.161 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2598.837 , 4842.848 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2600.255 , 4845.578 , -0.06759983 , "None"));
Path.Add(new Vector3(2602.215 , 4842.214 , -2.161922 , "Swimming"));
Path.Add(new Vector3(2603.61 , 4838.19 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2605.584 , 4834.062 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2607.669 , 4829.7 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2609.381 , 4826.121 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2611.254 , 4822.202 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2613.379 , 4817.758 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2615.461 , 4813.404 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2617.671 , 4808.782 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2619.457 , 4805.045 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2621.843 , 4800.057 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2623.914 , 4795.724 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2625.625 , 4792.145 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2627.585 , 4788.046 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2629.799 , 4783.416 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2631.575 , 4779.701 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2633.404 , 4775.875 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2635.04 , 4772.454 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2637.093 , 4768.16 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2640.311 , 4765.696 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2644.076 , 4762.909 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2647.993 , 4760.009 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2651.868 , 4757.14 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2655.717 , 4754.29 , -2.012758 , "Swimming"));
Path.Add(new Vector3(2658.698 , 4752.083 , -1.527346 , "Swimming"));
Path.Add(new Vector3(2655.303 , 4749.253 , -1.52325 , "Swimming"));
Path.Add(new Vector3(2651.822 , 4750.224 , -1.52325 , "Swimming"));
Path.Add(new Vector3(2648.12 , 4751.994 , -1.581187 , "Swimming"));
Path.Add(new Vector3(2645.28 , 4755.693 , -1.524154 , "Swimming"));
Path.Add(new Vector3(2642.502 , 4758.732 , -1.524154 , "Swimming"));
Path.Add(new Vector3(2640.162 , 4761.905 , -1.524154 , "Swimming"));
Path.Add(new Vector3(2636.451 , 4763.576 , -1.524154 , "Swimming"));
Path.Add(new Vector3(2633.984 , 4767.292 , -1.721497 , "Swimming"));
Path.Add(new Vector3(2631.776 , 4770.616 , -1.710422 , "Swimming"));
Path.Add(new Vector3(2629.498 , 4774.046 , -1.698993 , "Swimming"));
Path.Add(new Vector3(2627.103 , 4777.653 , -1.686975 , "Swimming"));
Path.Add(new Vector3(2624.676 , 4781.308 , -1.674799 , "Swimming"));
Path.Add(new Vector3(2621.87 , 4785.532 , -1.660722 , "Swimming"));
Path.Add(new Vector3(2618.081 , 4786.859 , -1.647114 , "Swimming"));
Path.Add(new Vector3(2614.962 , 4791.871 , -1.627463 , "Swimming"));
Path.Add(new Vector3(2612.354 , 4796.061 , -1.614291 , "Swimming"));
Path.Add(new Vector3(2609.912 , 4799.986 , -1.601951 , "Swimming"));
Path.Add(new Vector3(2607.489 , 4803.878 , -1.589711 , "Swimming"));
Path.Add(new Vector3(2605.131 , 4807.667 , -1.5778 , "Swimming"));
Path.Add(new Vector3(2602.566 , 4811.789 , -1.564842 , "Swimming"));
Path.Add(new Vector3(2606.417 , 4814.136 , -1.524256 , "Swimming"));
Path.Add(new Vector3(2605.075 , 4818.367 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2602.233 , 4822.256 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2599.617 , 4825.835 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2597.153 , 4829.008 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2594.105 , 4832.72 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2591.039 , 4836.453 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2588.087 , 4840.048 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2585.087 , 4843.701 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2581.977 , 4847.489 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2579.642 , 4850.332 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2576.193 , 4854.533 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2576.411 , 4858.925 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2578.086 , 4863.128 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2581.42 , 4866.83 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2585.295 , 4868.712 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2589.964 , 4870.266 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2594.741 , 4871.854 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2599.226 , 4873.347 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2603.384 , 4874.729 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2607.955 , 4876.25 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2612.331 , 4876.784 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2617.112 , 4877.365 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2621.898 , 4877.947 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2626.782 , 4878.534 , -0.5875586 , "None"));
Path.Add(new Vector3(2631.745 , 4879.138 , 1.495629 , "None"));
Path.Add(new Vector3(2637.586 , 4879.848 , 2.604823 , "None"));
Path.Add(new Vector3(2632.911 , 4878.073 , 1.692602 , "None"));
Path.Add(new Vector3(2625.838 , 4877.584 , -1.267553 , "None"));
Path.Add(new Vector3(2622.434 , 4877.349 , -3.411243 , "Swimming"));
Path.Add(new Vector3(2616.891 , 4876.965 , -3.294558 , "Swimming"));
Path.Add(new Vector3(2610.324 , 4876.512 , -3.047649 , "Swimming"));
Path.Add(new Vector3(2605.652 , 4875.463 , -2.982445 , "Swimming"));
Path.Add(new Vector3(2601.349 , 4874.144 , -2.970336 , "Swimming"));
Path.Add(new Vector3(2597.254 , 4872.889 , -2.958812 , "Swimming"));
Path.Add(new Vector3(2592.275 , 4871.362 , -2.944797 , "Swimming"));
Path.Add(new Vector3(2587.706 , 4869.961 , -2.931939 , "Swimming"));
Path.Add(new Vector3(2583.064 , 4868.539 , -2.918877 , "Swimming"));
Path.Add(new Vector3(2579.589 , 4865.438 , -2.868648 , "Swimming"));
Path.Add(new Vector3(2577.148 , 4861.469 , -2.814594 , "Swimming"));
Path.Add(new Vector3(2575.353 , 4857 , -2.762342 , "Swimming"));
Path.Add(new Vector3(2577.688 , 4853.156 , -2.670032 , "Swimming"));
Path.Add(new Vector3(2581.461 , 4850.706 , -2.641259 , "Swimming"));
Path.Add(new Vector3(2585.86 , 4848.21 , -2.628443 , "Swimming"));
Path.Add(new Vector3(2589.564 , 4846.108 , -2.61765 , "Swimming"));
Path.Add(new Vector3(2593.828 , 4843.689 , -2.605229 , "Swimming"));
Path.Add(new Vector3(2597.301 , 4841.719 , -2.594819 , "Swimming"));
Path.Add(new Vector3(2600.601 , 4843.432 , -2.534368 , "Swimming"));
Path.Add(new Vector3(2602.769 , 4838.957 , -2.530844 , "Swimming"));
Path.Add(new Vector3(2604.871 , 4834.618 , -2.527427 , "Swimming"));
Path.Add(new Vector3(2606.936 , 4830.355 , -2.524071 , "Swimming"));
Path.Add(new Vector3(2608.838 , 4826.429 , -2.520979 , "Swimming"));
Path.Add(new Vector3(2611.136 , 4821.686 , -2.517245 , "Swimming"));
Path.Add(new Vector3(2613.186 , 4817.453 , -2.513912 , "Swimming"));
Path.Add(new Vector3(2615.218 , 4813.258 , -2.510609 , "Swimming"));
Path.Add(new Vector3(2617.357 , 4808.843 , -2.507133 , "Swimming"));
Path.Add(new Vector3(2619.453 , 4804.517 , -2.503726 , "Swimming"));
Path.Add(new Vector3(2621.553 , 4800.182 , -2.500313 , "Swimming"));
Path.Add(new Vector3(2623.62 , 4795.915 , -2.496953 , "Swimming"));
Path.Add(new Vector3(2625.719 , 4791.58 , -2.49354 , "Swimming"));
Path.Add(new Vector3(2627.42 , 4788.07 , -2.490776 , "Swimming"));
Path.Add(new Vector3(2629.555 , 4783.663 , -2.487306 , "Swimming"));
Path.Add(new Vector3(2631.476 , 4779.698 , -2.484184 , "Swimming"));
Path.Add(new Vector3(2633.744 , 4775.014 , -2.480497 , "Swimming"));
Path.Add(new Vector3(2635.599 , 4771.185 , -2.477482 , "Swimming"));
Path.Add(new Vector3(2637.578 , 4767.427 , -2.446704 , "Swimming"));
Path.Add(new Vector3(2641.406 , 4764.646 , -2.161282 , "Swimming"));
Path.Add(new Vector3(2645.302 , 4761.815 , -2.161282 , "Swimming"));
Path.Add(new Vector3(2649.195 , 4758.987 , -2.161282 , "Swimming"));
Path.Add(new Vector3(2653.027 , 4756.203 , -2.161282 , "Swimming"));
Path.Add(new Vector3(2656.444 , 4755.393 , -0.2590102 , "None"));
Path.Add(new Vector3(2659.859 , 4756.706 , -1.694531 , "Swimming"));
Path.Add(new Vector3(2663.571 , 4759.125 , -1.524312 , "Swimming"));
Path.Add(new Vector3(2664.217 , 4763.765 , -1.524312 , "Swimming"));
Path.Add(new Vector3(2665.336 , 4767.97 , -1.974763 , "Swimming"));
Path.Add(new Vector3(2667.16 , 4772.169 , 0.2986914 , "None"));
Path.Add(new Vector3(2668.405 , 4774.893 , -1.581412 , "Swimming"));
Path.Add(new Vector3(2671.135 , 4776.582 , 1.431005 , "None"));
Path.Add(new Vector3(2675.146 , 4777.723 , 1.454933 , "None"));
Path.Add(new Vector3(2676.691 , 4783.36 , 2.042507 , "None"));
Path.Add(new Vector3(2677.925 , 4787.063 , 0.6043782 , "None"));
Path.Add(new Vector3(2677.221 , 4790.915 , -0.8785121 , "None"));
Path.Add(new Vector3(2677.326 , 4795.074 , -0.214615 , "None"));
Path.Add(new Vector3(2679.674 , 4801.132 , 1.434737 , "None"));
Path.Add(new Vector3(2680.836 , 4804.995 , 1.056789 , "None"));
Path.Add(new Vector3(2681.865 , 4808.339 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2682.788 , 4812.973 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2682.902 , 4817.621 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2683.716 , 4822.235 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2685.846 , 4826.327 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2688.653 , 4830.165 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2691.477 , 4834.026 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2694.303 , 4837.891 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2697.177 , 4841.821 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2699.928 , 4845.583 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2702.724 , 4849.407 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2705.612 , 4853.356 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2708.455 , 4857.244 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2711.301 , 4861.136 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2714.097 , 4864.959 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2715.88 , 4869.105 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2718.166 , 4873.132 , -1.131942 , "None"));
Path.Add(new Vector3(2721.3 , 4878.364 , 0.3963732 , "None"));
Path.Add(new Vector3(2724.082 , 4880.983 , 0.3963732 , "None"));
Path.Add(new Vector3(2727.11 , 4883.154 , 0.3963732 , "None"));
Path.Add(new Vector3(2731.044 , 4884.076 , 0.3963732 , "None"));
Path.Add(new Vector3(2734.995 , 4885.001 , 0.3963732 , "None"));
Path.Add(new Vector3(2739.124 , 4884.967 , 0.3963732 , "None"));
Path.Add(new Vector3(2747.399 , 4884.617 , 0.3963732 , "None"));
Path.Add(new Vector3(2756.099 , 4884.419 , 0.3963732 , "None"));
Path.Add(new Vector3(2764.495 , 4884.754 , 0.3963732 , "None"));
Path.Add(new Vector3(2772.799 , 4886.224 , 0.3963732 , "None"));
Path.Add(new Vector3(2781.391 , 4887.609 , 0.8997151 , "None"));
Path.Add(new Vector3(2789.734 , 4888.829 , 2.566212 , "None"));
Path.Add(new Vector3(2798.122 , 4889.709 , 2.885935 , "None"));
Path.Add(new Vector3(2806.777 , 4890.617 , 2.842169 , "None"));
Path.Add(new Vector3(2815.164 , 4891.499 , 2.630473 , "None"));
Path.Add(new Vector3(2823.482 , 4892.872 , 2.407877 , "None"));
Path.Add(new Vector3(2831.822 , 4895.28 , 2.219816 , "None"));
Path.Add(new Vector3(2839.867 , 4897.865 , 1.984661 , "None"));
Path.Add(new Vector3(2848.189 , 4900.411 , 2.329258 , "None"));
Path.Add(new Vector3(2856.481 , 4901.828 , 2.538525 , "None"));
Path.Add(new Vector3(2864.866 , 4902.732 , 2.538525 , "None"));
Path.Add(new Vector3(2872.968 , 4901.352 , 2.538525 , "None"));
Path.Add(new Vector3(2879.386 , 4895.479 , 2.538525 , "None"));
Path.Add(new Vector3(2886.125 , 4890.966 , 2.323324 , "None"));
Path.Add(new Vector3(2894.565 , 4891.067 , 3.176926 , "None"));
Path.Add(new Vector3(2902.094 , 4889.117 , 3.620623 , "None"));
Path.Add(new Vector3(2910.338 , 4885.535 , 2.558925 , "None"));
Path.Add(new Vector3(2918.304 , 4881.99 , 2.199398 , "None"));
Path.Add(new Vector3(2926.137 , 4881.928 , 2.021142 , "None"));
Path.Add(new Vector3(2934.611 , 4883.982 , 2.142937 , "None"));
Path.Add(new Vector3(2943.068 , 4886.034 , 2.483254 , "None"));
Path.Add(new Vector3(2950.987 , 4887.956 , 1.815411 , "None"));
Path.Add(new Vector3(2959.444 , 4890.007 , 0.3963848 , "None"));
Path.Add(new Vector3(2967.385 , 4889.954 , 0.3963848 , "None"));
Path.Add(new Vector3(2975.882 , 4888.076 , 0.3963848 , "None"));
Path.Add(new Vector3(2984.117 , 4886.256 , 0.3963848 , "None"));
Path.Add(new Vector3(2990.044 , 4880.676 , 0.3963848 , "None"));
Path.Add(new Vector3(2998.263 , 4878.859 , 0.3963848 , "None"));
Path.Add(new Vector3(3006.842 , 4876.963 , 0.3963848 , "None"));
Path.Add(new Vector3(3015.053 , 4875.446 , 0.3963848 , "None"));
Path.Add(new Vector3(3023.744 , 4875.009 , 0.3963848 , "None"));
Path.Add(new Vector3(3032.167 , 4874.585 , 0.3963848 , "None"));
Path.Add(new Vector3(3040.517 , 4873.725 , 0.3963848 , "None"));
Path.Add(new Vector3(3048.256 , 4875.224 , 0.3963848 , "None"));
Path.Add(new Vector3(3056.296 , 4875.337 , 0.3963848 , "None"));
Path.Add(new Vector3(3064.628 , 4874.534 , 0.3963848 , "None"));
Path.Add(new Vector3(3073.345 , 4874.363 , 0.3963848 , "None"));
Path.Add(new Vector3(3081.518 , 4873.655 , 0.3963848 , "None"));
Path.Add(new Vector3(3088.456 , 4877.399 , 0.3963848 , "None"));
Path.Add(new Vector3(3093.192 , 4879.544 , 0.3963848 , "None"));
Path.Add(new Vector3(3100.005 , 4874.923 , 0.3963848 , "None"));
Path.Add(new Vector3(3108.248 , 4873.845 , 0.6110947 , "None"));
Path.Add(new Vector3(3115.818 , 4875.824 , 1.607096 , "None"));
Path.Add(new Vector3(3123.229 , 4876.558 , 1.22151 , "None"));
Path.Add(new Vector3(3129.022 , 4872.339 , 1.369536 , "None"));
Path.Add(new Vector3(3125.014 , 4875.205 , 1.222369 , "None"));
Path.Add(new Vector3(3124.641 , 4871.451 , 1.220951 , "None"));
Path.Add(new Vector3(3126.287 , 4868.085 , 1.220951 , "None"));
Path.Add(new Vector3(3128.302 , 4864.735 , 1.82873 , "None"));
Path.Add(new Vector3(3128.213 , 4860.695 , 1.913947 , "None"));
Path.Add(new Vector3(3128.003 , 4856.595 , 1.620796 , "None"));
Path.Add(new Vector3(3127.123 , 4852.8 , 1.612107 , "None"));
Path.Add(new Vector3(3126.983 , 4849.026 , 2.380877 , "None"));
Path.Add(new Vector3(3129.708 , 4846.042 , 2.89105 , "None"));
Path.Add(new Vector3(3132.911 , 4843.798 , 2.772309 , "None"));
Path.Add(new Vector3(3136.948 , 4843.613 , 2.483184 , "None"));
Path.Add(new Vector3(3132.397 , 4844.195 , 2.790556 , "None"));
Path.Add(new Vector3(3128.366 , 4846.065 , 2.835217 , "None"));
Path.Add(new Vector3(3124.701 , 4847.766 , 2.028071 , "None"));
Path.Add(new Vector3(3120.706 , 4848.708 , 1.251807 , "None"));
Path.Add(new Vector3(3117.226 , 4850.042 , 1.221127 , "None"));
Path.Add(new Vector3(3113.456 , 4850.718 , 1.221127 , "None"));
Path.Add(new Vector3(3110.121 , 4852.713 , 1.9232 , "None"));
Path.Add(new Vector3(3106.634 , 4854.481 , 2.772887 , "None"));
Path.Add(new Vector3(3102.99 , 4855.702 , 3.249063 , "None"));
Path.Add(new Vector3(3098.873 , 4859.181 , 2.896097 , "None"));
Path.Add(new Vector3(3093.954 , 4858.699 , 2.72911 , "None"));
Path.Add(new Vector3(3090.358 , 4859.816 , 2.22511 , "None"));
Path.Add(new Vector3(3087.429 , 4857.135 , 2.562912 , "None"));
Path.Add(new Vector3(3085.332 , 4853.671 , 2.950316 , "None"));
Path.Add(new Vector3(3082.296 , 4851.753 , 3.071981 , "None"));
Path.Add(new Vector3(3084.665 , 4856.442 , 2.471149 , "None"));
Path.Add(new Vector3(3086.676 , 4860.205 , 1.628798 , "None"));
Path.Add(new Vector3(3088.536 , 4863.684 , 0.6126627 , "None"));
Path.Add(new Vector3(3091.12 , 4868.519 , 0.3965788 , "None"));
Path.Add(new Vector3(3092.889 , 4871.827 , 0.3965788 , "None"));
Path.Add(new Vector3(3094.676 , 4875.17 , 0.3965788 , "None"));
Path.Add(new Vector3(3098.471 , 4882.27 , 0.3965788 , "None"));
Path.Add(new Vector3(3101.361 , 4885.146 , 0.3965788 , "None"));
Path.Add(new Vector3(3104.871 , 4886.715 , 1.403511 , "None"));
Path.Add(new Vector3(3112.085 , 4889 , 0.6755825 , "None"));
Path.Add(new Vector3(3115.561 , 4890.102 , 1.114412 , "None"));
Path.Add(new Vector3(3122.273 , 4892.229 , 1.915127 , "None"));
Path.Add(new Vector3(3126.749 , 4890.494 , 1.37883 , "None"));
Path.Add(new Vector3(3130.165 , 4889.002 , 1.247583 , "None"));
Path.Add(new Vector3(3134.273 , 4887.207 , 1.557291 , "None"));
Path.Add(new Vector3(3137.656 , 4885.729 , 2.284554 , "None"));
Path.Add(new Vector3(3131.351 , 4886.828 , 1.279003 , "None"));
Path.Add(new Vector3(3123.734 , 4889.227 , 1.590201 , "None"));
Path.Add(new Vector3(3120.271 , 4890.317 , 1.851076 , "None"));
Path.Add(new Vector3(3116.647 , 4891.458 , 1.366695 , "None"));
Path.Add(new Vector3(3112.8 , 4892.67 , 0.9395016 , "None"));
Path.Add(new Vector3(3108.93 , 4893.889 , 0.6826085 , "None"));
Path.Add(new Vector3(3101.981 , 4896.077 , 1.209702 , "None"));
Path.Add(new Vector3(3094.319 , 4898.491 , 1.629161 , "None"));
Path.Add(new Vector3(3090.349 , 4899.741 , 1.709002 , "None"));
Path.Add(new Vector3(3083.508 , 4901.896 , 2.126009 , "None"));
Path.Add(new Vector3(3079.039 , 4903.303 , 2.292455 , "None"));
Path.Add(new Vector3(3072.144 , 4905.475 , 2.122083 , "None"));
Path.Add(new Vector3(3068.305 , 4906.684 , 2.002084 , "None"));
Path.Add(new Vector3(3064.543 , 4907.869 , 1.927282 , "None"));
Path.Add(new Vector3(3060.473 , 4909.15 , 1.864463 , "None"));
Path.Add(new Vector3(3056.941 , 4910.263 , 1.795621 , "None"));
Path.Add(new Vector3(3052.58 , 4911.636 , 1.829837 , "None"));
Path.Add(new Vector3(3048.941 , 4912.782 , 1.887519 , "None"));
Path.Add(new Vector3(3040.948 , 4915.299 , 1.163032 , "None"));
Path.Add(new Vector3(3037.147 , 4916.497 , 1.516365 , "None"));
Path.Add(new Vector3(3033.2 , 4917.74 , 2.196286 , "None"));
Path.Add(new Vector3(3029.361 , 4918.949 , 2.54078 , "None"));
Path.Add(new Vector3(3025.43 , 4920.187 , 1.874681 , "None"));
Path.Add(new Vector3(3022.122 , 4921.232 , 0.5265571 , "None"));
Path.Add(new Vector3(3017.089 , 4918.619 , 0.3962821 , "None"));
Path.Add(new Vector3(3011.664 , 4918.471 , 0.3962821 , "None"));
Path.Add(new Vector3(3002.814 , 4918.229 , 0.3962821 , "None"));
Path.Add(new Vector3(2994.216 , 4917.994 , 0.3962821 , "None"));
Path.Add(new Vector3(2986.255 , 4917.776 , 0.3962821 , "None"));
Path.Add(new Vector3(2982.527 , 4917.675 , 2.062686 , "None"));
Path.Add(new Vector3(2972.25 , 4917.394 , 2.180861 , "None"));
Path.Add(new Vector3(2967.967 , 4917.276 , 2.647364 , "None"));
Path.Add(new Vector3(2956.799 , 4916.971 , 2.923525 , "None"));
Path.Add(new Vector3(2948.503 , 4916.745 , 1.868098 , "None"));
Path.Add(new Vector3(2939.72 , 4916.504 , 2.576187 , "None"));
Path.Add(new Vector3(2931.177 , 4916.271 , 2.160453 , "None"));
Path.Add(new Vector3(2922.444 , 4916.032 , 2.562019 , "None"));
Path.Add(new Vector3(2914.316 , 4915.81 , 2.562019 , "None"));
Path.Add(new Vector3(2909.589 , 4915.681 , 2.43209 , "None"));
Path.Add(new Vector3(2907.954 , 4912.182 , 2.843246 , "None"));
Path.Add(new Vector3(2906.787 , 4915.854 , 1.945642 , "None"));
Path.Add(new Vector3(2898.886 , 4915.195 , 2.417969 , "None"));
Path.Add(new Vector3(2894.081 , 4920.908 , 2.749953 , "None"));
Path.Add(new Vector3(2882.989 , 4920.104 , 1.86761 , "None"));
Path.Add(new Vector3(2874.395 , 4918.737 , 2.733311 , "None"));
Path.Add(new Vector3(2866.049 , 4917.41 , 3.206594 , "None"));
Path.Add(new Vector3(2858.583 , 4916.223 , 2.913549 , "None"));
Path.Add(new Vector3(2849.375 , 4914.759 , 1.861996 , "None"));
Path.Add(new Vector3(2841.095 , 4913.442 , 1.848166 , "None"));
Path.Add(new Vector3(2834.177 , 4912.342 , 2.773519 , "None"));
Path.Add(new Vector3(2825.383 , 4910.944 , 2.511091 , "None"));
Path.Add(new Vector3(2812.79 , 4908.942 , 2.038323 , "None"));
Path.Add(new Vector3(2805.017 , 4907.706 , 2.227401 , "None"));
Path.Add(new Vector3(2796.124 , 4906.292 , 2.23597 , "None"));
Path.Add(new Vector3(2787.795 , 4904.967 , 1.800726 , "None"));
Path.Add(new Vector3(2780.113 , 4903.746 , 2.117197 , "None"));
Path.Add(new Vector3(2772.083 , 4902.469 , 1.891969 , "None"));
Path.Add(new Vector3(2762.526 , 4900.949 , 1.447165 , "None"));
Path.Add(new Vector3(2755.207 , 4899.786 , 0.4898151 , "None"));
Path.Add(new Vector3(2759.914 , 4900.141 , 1.188936 , "None"));
Path.Add(new Vector3(2768.346 , 4902.292 , 1.951398 , "None"));
Path.Add(new Vector3(2776.726 , 4902.483 , 1.878221 , "None"));
Path.Add(new Vector3(2785.104 , 4901.882 , 1.870226 , "None"));
Path.Add(new Vector3(2793.458 , 4902.68 , 2.395445 , "None"));
Path.Add(new Vector3(2802.04 , 4904.12 , 2.217952 , "None"));
Path.Add(new Vector3(2810.391 , 4905.522 , 1.882845 , "None"));
Path.Add(new Vector3(2818.719 , 4907.789 , 2.537171 , "None"));
Path.Add(new Vector3(2826.724 , 4910.308 , 2.650145 , "None"));
Path.Add(new Vector3(2835.051 , 4911.446 , 2.313786 , "None"));
Path.Add(new Vector3(2843.229 , 4913.504 , 1.865642 , "None"));
Path.Add(new Vector3(2851.669 , 4915.627 , 2.00851 , "None"));
Path.Add(new Vector3(2859.571 , 4917.614 , 3.240571 , "None"));
Path.Add(new Vector3(2868.027 , 4919.742 , 3.387058 , "None"));
Path.Add(new Vector3(2876.141 , 4921.918 , 3.498611 , "None"));
Path.Add(new Vector3(2884.157 , 4925.348 , 1.924518 , "None"));
Path.Add(new Vector3(2891.89 , 4928.657 , 2.539602 , "None"));
Path.Add(new Vector3(2899.829 , 4931.422 , 1.926026 , "None"));
Path.Add(new Vector3(2907.638 , 4934.882 , 2.194961 , "None"));
Path.Add(new Vector3(2915.84 , 4934.508 , 2.561589 , "None"));
Path.Add(new Vector3(2923.699 , 4932.423 , 2.236021 , "None"));
Path.Add(new Vector3(2932.111 , 4930.191 , 1.900456 , "None"));
Path.Add(new Vector3(2940.279 , 4928.024 , 1.943457 , "None"));
Path.Add(new Vector3(2948.414 , 4925.865 , 3.807752 , "None"));
Path.Add(new Vector3(2956.685 , 4923.437 , 4.287056 , "None"));
Path.Add(new Vector3(2962.785 , 4917.742 , 3.456934 , "None"));
Path.Add(new Vector3(2969.154 , 4912.213 , 2.703155 , "None"));
Path.Add(new Vector3(2975.726 , 4906.508 , 1.556661 , "None"));
Path.Add(new Vector3(2982.082 , 4900.991 , 0.3964267 , "None"));
Path.Add(new Vector3(2985.635 , 4894.183 , 0.3964267 , "None"));
Path.Add(new Vector3(2986.04 , 4885.507 , 0.3964267 , "None"));
Path.Add(new Vector3(2981.45 , 4879.121 , 0.3964267 , "None"));
Path.Add(new Vector3(2976.038 , 4874.646 , 0.3964267 , "None"));
Path.Add(new Vector3(2968.52 , 4866.601 , 0.3964267 , "None"));
Path.Add(new Vector3(2961.38 , 4861.625 , 0.3964267 , "None"));
Path.Add(new Vector3(2954.46 , 4856.804 , 0.3964267 , "None"));
Path.Add(new Vector3(2947.541 , 4851.983 , 0.3964267 , "None"));
Path.Add(new Vector3(2940.708 , 4847.042 , 0.3964267 , "None"));
Path.Add(new Vector3(2933.948 , 4841.563 , 0.3964267 , "None"));
Path.Add(new Vector3(2926.432 , 4839.449 , 0.3964267 , "None"));
Path.Add(new Vector3(2920.296 , 4833.667 , 0.3964267 , "None"));
Path.Add(new Vector3(2914.201 , 4827.82 , -0.4615785 , "None"));
Path.Add(new Vector3(2908.631 , 4823.498 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2904.837 , 4820.532 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2901.105 , 4817.615 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2897.307 , 4814.645 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2893.512 , 4811.679 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2889.827 , 4808.711 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2886.677 , 4805.06 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2883.584 , 4801.474 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2880.438 , 4797.826 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2877.289 , 4794.175 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2874.195 , 4790.589 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2871.475 , 4786.624 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2868.787 , 4782.65 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2865.565 , 4779.172 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2862.982 , 4775.114 , -2.116585 , "None"));
Path.Add(new Vector3(2857.727 , 4766.823 , 0.08358613 , "None"));
Path.Add(new Vector3(2851.998 , 4761.033 , 0.08358613 , "None"));
Path.Add(new Vector3(2845.568 , 4755.37 , 0.08358613 , "None"));
Path.Add(new Vector3(2839.145 , 4749.674 , 1.150026 , "None"));
Path.Add(new Vector3(2833.79 , 4743.21 , 1.964832 , "None"));
Path.Add(new Vector3(2828.515 , 4736.268 , 1.955411 , "None"));
Path.Add(new Vector3(2822.759 , 4730.125 , 2.560774 , "None"));
Path.Add(new Vector3(2817.23 , 4725.373 , 2.560774 , "None"));
Path.Add(new Vector3(2809.902 , 4719.235 , 2.028229 , "None"));
Path.Add(new Vector3(2807.107 , 4716.894 , 1.937664 , "None"));
Path.Add(new Vector3(2800.781 , 4708.477 , 1.86191 , "None"));
Path.Add(new Vector3(2795.819 , 4701.803 , 1.86191 , "None"));
Path.Add(new Vector3(2791.475 , 4695.969 , 1.861052 , "None"));
Path.Add(new Vector3(2797.187 , 4693.755 , 1.861105 , "None"));
Path.Add(new Vector3(2806.122 , 4694.728 , 1.861105 , "None"));
Path.Add(new Vector3(2814.507 , 4695.641 , 1.861105 , "None"));
Path.Add(new Vector3(2823.158 , 4696.583 , 1.861105 , "None"));
Path.Add(new Vector3(2831.709 , 4697.514 , 2.01511 , "None"));
Path.Add(new Vector3(2840.193 , 4698.438 , 2.411835 , "None"));
Path.Add(new Vector3(2848.577 , 4699.35 , 2.160959 , "None"));
Path.Add(new Vector3(2857.195 , 4700.289 , 2.09496 , "None"));
Path.Add(new Vector3(2865.46 , 4701.188 , 2.183152 , "None"));
Path.Add(new Vector3(2870.011 , 4701.677 , 1.989251 , "None"));
Path.Add(new Vector3(2872.834 , 4693.574 , 2.404903 , "None"));
Path.Add(new Vector3(2881.98 , 4691.846 , 1.359629 , "None"));
Path.Add(new Vector3(2890.805 , 4689.536 , 0.08385982 , "None"));
Path.Add(new Vector3(2898.898 , 4687.417 , 0.08385982 , "None"));
Path.Add(new Vector3(2907.317 , 4685.213 , 0.08385982 , "None"));
Path.Add(new Vector3(2915.476 , 4683.077 , -1.94887 , "None"));
Path.Add(new Vector3(2918.609 , 4682.257 , -3.468171 , "Swimming"));
Path.Add(new Vector3(2922.154 , 4681.329 , -5.93869 , "Swimming"));
Path.Add(new Vector3(2926.336 , 4680.234 , -8.852637 , "Swimming"));
Path.Add(new Vector3(2930.158 , 4679.233 , -11.51584 , "Swimming"));
Path.Add(new Vector3(2934.003 , 4678.227 , -14.19487 , "Swimming"));
Path.Add(new Vector3(2937.644 , 4677.274 , -16.73138 , "Swimming"));
Path.Add(new Vector3(2941.352 , 4676.303 , -19.31539 , "Swimming"));
Path.Add(new Vector3(2945.273 , 4675.277 , -22.04722 , "Swimming"));
Path.Add(new Vector3(2949.091 , 4674.277 , -24.70778 , "Swimming"));
Path.Add(new Vector3(2952.936 , 4673.271 , -27.38681 , "Swimming"));
Path.Add(new Vector3(2956.8 , 4672.26 , -30.07904 , "Swimming"));
Path.Add(new Vector3(2955.374 , 4676.167 , -31.45443 , "Swimming"));
Path.Add(new Vector3(2952.391 , 4679.949 , -31.44727 , "Swimming"));
Path.Add(new Vector3(2949.355 , 4683.797 , -31.43998 , "Swimming"));
Path.Add(new Vector3(2946.422 , 4687.516 , -31.43293 , "Swimming"));
Path.Add(new Vector3(2943.439 , 4691.298 , -31.42577 , "Swimming"));
Path.Add(new Vector3(2940.948 , 4694.457 , -31.41978 , "Swimming"));
Path.Add(new Vector3(2937.52 , 4698.802 , -31.41155 , "Swimming"));
Path.Add(new Vector3(2934.543 , 4702.576 , -31.4044 , "Swimming"));
Path.Add(new Vector3(2931.554 , 4706.365 , -31.39722 , "Swimming"));
Path.Add(new Vector3(2928.618 , 4710.088 , -31.39017 , "Swimming"));
Path.Add(new Vector3(2925.635 , 4713.87 , -31.383 , "Swimming"));
Path.Add(new Vector3(2922.701 , 4717.588 , -31.37596 , "Swimming"));
Path.Add(new Vector3(2919.718 , 4721.37 , -31.36879 , "Swimming"));
Path.Add(new Vector3(2917.133 , 4724.648 , -31.36259 , "Swimming"));
Path.Add(new Vector3(2913.764 , 4728.919 , -31.35449 , "Swimming"));
Path.Add(new Vector3(2911.176 , 4732.2 , -31.34828 , "Swimming"));
Path.Add(new Vector3(2907.859 , 4736.405 , -31.34031 , "Swimming"));
Path.Add(new Vector3(2904.906 , 4740.149 , -31.33322 , "Swimming"));
Path.Add(new Vector3(2901.943 , 4743.905 , -31.3261 , "Swimming"));
Path.Add(new Vector3(2898.957 , 4747.69 , -31.31893 , "Swimming"));
Path.Add(new Vector3(2896.106 , 4751.306 , -31.31208 , "Swimming"));
Path.Add(new Vector3(2893.041 , 4755.191 , -31.30472 , "Swimming"));
Path.Add(new Vector3(2890.096 , 4758.925 , -31.29765 , "Swimming"));
Path.Add(new Vector3(2887.069 , 4762.762 , -31.29037 , "Swimming"));
Path.Add(new Vector3(2884.22 , 4766.374 , -31.28353 , "Swimming"));
Path.Add(new Vector3(2881.594 , 4769.703 , -31.27723 , "Swimming"));
Path.Add(new Vector3(2878.237 , 4773.959 , -31.26916 , "Swimming"));
Path.Add(new Vector3(2875.06 , 4777.638 , -31.24093 , "Swimming"));
Path.Add(new Vector3(2871.469 , 4780.563 , -31.18783 , "Swimming"));
Path.Add(new Vector3(2867.701 , 4781.606 , -31.16889 , "Swimming"));
Path.Add(new Vector3(2862.308 , 4783.101 , -31.14179 , "Swimming"));
Path.Add(new Vector3(2857.58 , 4784.411 , -31.11803 , "Swimming"));
Path.Add(new Vector3(2852.938 , 4785.246 , -31.09215 , "Swimming"));
Path.Add(new Vector3(2848.127 , 4785.345 , -31.06125 , "Swimming"));
Path.Add(new Vector3(2843.482 , 4785.441 , -31.03142 , "Swimming"));
Path.Add(new Vector3(2839.327 , 4785.015 , -31.0042 , "Swimming"));
Path.Add(new Vector3(2835.276 , 4783.526 , -30.97649 , "Swimming"));
Path.Add(new Vector3(2830.99 , 4781.95 , -30.94717 , "Swimming"));
Path.Add(new Vector3(2827.456 , 4779.99 , -30.70009 , "Swimming"));
Path.Add(new Vector3(2825.677 , 4775.819 , -29.07598 , "Swimming"));
Path.Add(new Vector3(2823.925 , 4771.713 , -27.47736 , "Swimming"));
Path.Add(new Vector3(2822.2 , 4768.652 , -26.16517 , "Swimming"));
Path.Add(new Vector3(2818.702 , 4769.154 , -24.15562 , "Swimming"));
Path.Add(new Vector3(2815.817 , 4770.752 , -22.23735 , "Swimming"));
Path.Add(new Vector3(2816.022 , 4775.041 , -22.24828 , "Swimming"));
Path.Add(new Vector3(2818.45 , 4774.354 , -18.42068 , "Swimming"));
Path.Add(new Vector3(2817.898 , 4773.735 , -14.18026 , "Swimming"));
Path.Add(new Vector3(2817.312 , 4773.079 , -9.684955 , "Swimming"));
Path.Add(new Vector3(2816.72 , 4773.206 , -5.272249 , "Swimming"));
Path.Add(new Vector3(2816.07 , 4772.808 , -1.539505 , "Swimming"));
Path.Add(new Vector3(2816.678 , 4766.16 , 0.08448467 , "None"));
Path.Add(new Vector3(2815.811 , 4759.18 , 0.08448467 , "None"));
Path.Add(new Vector3(2815.027 , 4752.885 , 0.08448467 , "None"));
Path.Add(new Vector3(2814.44 , 4748.172 , 0.08448467 , "None"));
Path.Add(new Vector3(2813.99 , 4744.561 , 0.08448467 , "None"));
Path.Add(new Vector3(2813.491 , 4740.559 , 1.260172 , "None"));
Path.Add(new Vector3(2812.686 , 4734.121 , 1.87986 , "None"));
Path.Add(new Vector3(2810.402 , 4731.304 , 2.542387 , "None"));
Path.Add(new Vector3(2808.439 , 4724.21 , 2.561902 , "None"));
Path.Add(new Vector3(2806.232 , 4720.521 , 2.561902 , "None"));
Path.Add(new Vector3(2804.227 , 4717.171 , 1.95783 , "None"));
Path.Add(new Vector3(2802.078 , 4713.579 , 1.862063 , "None"));
Path.Add(new Vector3(2800.069 , 4710.223 , 1.926151 , "None"));
Path.Add(new Vector3(2797.927 , 4706.643 , 1.861029 , "None"));
Path.Add(new Vector3(2796.129 , 4703.638 , 1.861029 , "None"));
Path.Add(new Vector3(2793.814 , 4699.77 , 1.861489 , "None"));
Path.Add(new Vector3(2790.154 , 4700.573 , 1.846016 , "None"));
Path.Add(new Vector3(2782.974 , 4702.443 , 2.42394 , "None"));
Path.Add(new Vector3(2773.61 , 4704.882 , 2.708653 , "None"));
Path.Add(new Vector3(2766.053 , 4706.472 , 2.683223 , "None"));
Path.Add(new Vector3(2759.925 , 4702.099 , 2.90311 , "None"));
Path.Add(new Vector3(2751.995 , 4699.278 , 3.189422 , "None"));
Path.Add(new Vector3(2744.841 , 4696.733 , 2.806735 , "None"));
Path.Add(new Vector3(2735.581 , 4693.44 , 2.466633 , "None"));
Path.Add(new Vector3(2728.189 , 4690.811 , 2.005288 , "None"));
Path.Add(new Vector3(2720.512 , 4688.081 , 2.391749 , "None"));
Path.Add(new Vector3(2730.682 , 4692.055 , 1.806716 , "None"));
Path.Add(new Vector3(2735.92 , 4694.065 , 2.493652 , "None"));
Path.Add(new Vector3(2743.841 , 4697.105 , 2.741074 , "None"));
Path.Add(new Vector3(2751.197 , 4699.929 , 3.156299 , "None"));
Path.Add(new Vector3(2759.839 , 4703.246 , 2.885861 , "None"));
Path.Add(new Vector3(2766.929 , 4705.966 , 2.610083 , "None"));
Path.Add(new Vector3(2773.374 , 4706.63 , 2.88816 , "None"));
Path.Add(new Vector3(2780.422 , 4703.805 , 2.686843 , "None"));
Path.Add(new Vector3(2786.944 , 4700.907 , 1.978535 , "None"));
Path.Add(new Vector3(2790.948 , 4696.857 , 1.861322 , "None"));
Path.Add(new Vector3(2792.309 , 4693.088 , 1.859586 , "None"));
Path.Add(new Vector3(2792.465 , 4684.286 , 1.788988 , "None"));
Path.Add(new Vector3(2792.613 , 4675.955 , 1.834766 , "None"));
Path.Add(new Vector3(2792.768 , 4667.254 , 2.248478 , "None"));
Path.Add(new Vector3(2792.919 , 4658.754 , 2.412814 , "None"));
Path.Add(new Vector3(2793.068 , 4650.389 , 2.533992 , "None"));
Path.Add(new Vector3(2793.221 , 4641.755 , 2.545015 , "None"));
Path.Add(new Vector3(2793.353 , 4634.297 , 1.959343 , "None"));
Path.Add(new Vector3(2793.523 , 4624.74 , 0.08404141 , "None"));
Path.Add(new Vector3(2793.663 , 4616.845 , 0.08404141 , "None"));
Path.Add(new Vector3(2793.775 , 4610.549 , 0.08404141 , "None"));
Path.Add(new Vector3(2795.021 , 4614.871 , 0.08404141 , "None"));
Path.Add(new Vector3(2795.218 , 4623.287 , 0.08404141 , "None"));
Path.Add(new Vector3(2794.937 , 4631.961 , 1.501249 , "None"));
Path.Add(new Vector3(2794.664 , 4640.122 , 2.543535 , "None"));
Path.Add(new Vector3(2794.372 , 4648.819 , 2.538997 , "None"));
Path.Add(new Vector3(2794.09 , 4657.248 , 2.426193 , "None"));
Path.Add(new Vector3(2793.799 , 4665.937 , 2.301618 , "None"));
Path.Add(new Vector3(2793.517 , 4674.366 , 2.204782 , "None"));
Path.Add(new Vector3(2795.102 , 4682.041 , 2.139091 , "None"));
Path.Add(new Vector3(2794.523 , 4690.438 , 1.818505 , "None"));
Path.Add(new Vector3(2798.328 , 4693.768 , 1.860089 , "None"));
Path.Add(new Vector3(2804.847 , 4695.146 , 1.860089 , "None"));
Path.Add(new Vector3(2800.001 , 4690.863 , 1.974757 , "None"));
Path.Add(new Vector3(2796.841 , 4688.07 , 2.336566 , "None"));
Path.Add(new Vector3(2800.419 , 4676.8 , 2.717543 , "None"));
Path.Add(new Vector3(2804.107 , 4668.9 , 2.192173 , "None"));
Path.Add(new Vector3(2808.707 , 4661.866 , 1.836926 , "None"));
Path.Add(new Vector3(2813.959 , 4655.285 , 2.551646 , "None"));
Path.Add(new Vector3(2819.905 , 4649.308 , 2.436279 , "None"));
Path.Add(new Vector3(2826.015 , 4643.495 , 2.308349 , "None"));
Path.Add(new Vector3(2832.319 , 4637.496 , 2.006593 , "None"));
Path.Add(new Vector3(2838.428 , 4631.682 , 2.074792 , "None"));
Path.Add(new Vector3(2844.776 , 4625.642 , 2.251569 , "None"));
Path.Add(new Vector3(2850.837 , 4619.875 , 1.774535 , "None"));
Path.Add(new Vector3(2856.947 , 4614.061 , 0.08372796 , "None"));
Path.Add(new Vector3(2863.012 , 4608.262 , 0.08372796 , "None"));
Path.Add(new Vector3(2864.375 , 4599.981 , 0.08372796 , "None"));
Path.Add(new Vector3(2864.555 , 4592.164 , 0.08372796 , "None"));
Path.Add(new Vector3(2867.51 , 4583.979 , 1.636365 , "None"));
Path.Add(new Vector3(2870.408 , 4576.059 , 0.1294602 , "None"));
Path.Add(new Vector3(2872.26 , 4571.205 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2874.248 , 4566.817 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2876.236 , 4562.43 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2878.211 , 4558.068 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2880.185 , 4553.71 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2882.146 , 4549.383 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2884.102 , 4545.064 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2886.082 , 4540.694 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2888.085 , 4536.272 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2890.036 , 4531.967 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2892.017 , 4527.592 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2894.001 , 4523.213 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2895.975 , 4518.856 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2897.933 , 4514.533 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2899.87 , 4510.257 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2901.905 , 4505.767 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2903.873 , 4501.422 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2905.866 , 4497.022 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2907.802 , 4492.697 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2905.693 , 4489.299 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2904.372 , 4484.389 , -2.352631 , "Swimming"));
Path.Add(new Vector3(2903.88 , 4480.283 , -2.474994 , "Swimming"));
Path.Add(new Vector3(2904.569 , 4476.111 , -2.521089 , "Swimming"));
Path.Add(new Vector3(2905.943 , 4471.926 , -2.521089 , "Swimming"));
Path.Add(new Vector3(2904.307 , 4467.367 , -2.54554 , "Swimming"));
Path.Add(new Vector3(2904.895 , 4463.089 , -2.588113 , "Swimming"));
Path.Add(new Vector3(2906.898 , 4458.667 , -2.588113 , "Swimming"));
Path.Add(new Vector3(2906.875 , 4454.764 , -2.588113 , "Swimming"));
Path.Add(new Vector3(2906.478 , 4450.656 , -2.607831 , "Swimming"));
Path.Add(new Vector3(2907.19 , 4446.104 , -2.665235 , "Swimming"));
Path.Add(new Vector3(2908.586 , 4441.708 , -2.688849 , "Swimming"));
Path.Add(new Vector3(2910.162 , 4438.422 , -2.967922 , "Swimming"));
Path.Add(new Vector3(2912.625 , 4434.84 , -2.981427 , "Swimming"));
Path.Add(new Vector3(2916.749 , 4432.96 , -2.488873 , "Swimming"));
Path.Add(new Vector3(2917.823 , 4428.908 , -2.400576 , "Swimming"));
Path.Add(new Vector3(2918.004 , 4424.747 , -2.612064 , "Swimming"));
Path.Add(new Vector3(2916.389 , 4420.707 , -0.5637258 , "None"));
Path.Add(new Vector3(2916.236 , 4417.035 , 0.372513 , "None"));
Path.Add(new Vector3(2916.042 , 4408.334 , 0.372513 , "None"));
Path.Add(new Vector3(2916.278 , 4400.212 , 0.8211019 , "None"));
Path.Add(new Vector3(2920.312 , 4392.525 , 1.937812 , "None"));
Path.Add(new Vector3(2926.142 , 4386.466 , 1.403112 , "None"));
Path.Add(new Vector3(2932.552 , 4380.556 , 2.355246 , "None"));
Path.Add(new Vector3(2939.551 , 4377.059 , 4.149458 , "None"));
Path.Add(new Vector3(2946.199 , 4372.561 , 6.870637 , "None"));
Path.Add(new Vector3(2951.362 , 4367.8 , 8.560319 , "None"));
Path.Add(new Vector3(2958.53 , 4362.516 , 10.08619 , "None"));
Path.Add(new Vector3(2961.828 , 4360.557 , 10.87377 , "None"));
Path.Add(new Vector3(2968.226 , 4354.658 , 14.33241 , "None"));
Path.Add(new Vector3(2970.673 , 4351.991 , 16.03087 , "None"));
Path.Add(new Vector3(2974.391 , 4344.454 , 20.05301 , "None"));
Path.Add(new Vector3(2978.123 , 4336.891 , 23.18381 , "None"));
Path.Add(new Vector3(2979.726 , 4329.092 , 24.22914 , "None"));
Path.Add(new Vector3(2979.265 , 4320.391 , 25.62417 , "None"));
Path.Add(new Vector3(2981.249 , 4310.998 , 26.41271 , "None"));
Path.Add(new Vector3(2983.123 , 4302.5 , 26.66992 , "None"));
Path.Add(new Vector3(2984.892 , 4294.477 , 26.24666 , "None"));
Path.Add(new Vector3(2986.741 , 4286.094 , 25.28621 , "None"));
Path.Add(new Vector3(2988.558 , 4277.858 , 24.42081 , "None"));
Path.Add(new Vector3(2990.435 , 4269.344 , 23.72466 , "None"));
Path.Add(new Vector3(2992.248 , 4261.125 , 23.21571 , "None"));
Path.Add(new Vector3(2994.122 , 4252.626 , 23.58225 , "None"));
Path.Add(new Vector3(2995.794 , 4245.046 , 23.45894 , "None"));
Path.Add(new Vector3(2996.073 , 4238.709 , 24.38337 , "None"));
Path.Add(new Vector3(2995.048 , 4230.897 , 26.7586 , "None"));
Path.Add(new Vector3(2994.081 , 4223.518 , 27.93331 , "None"));
Path.Add(new Vector3(2992.768 , 4213.507 , 28.57279 , "None"));
Path.Add(new Vector3(2991.64 , 4204.912 , 28.8369 , "None"));
Path.Add(new Vector3(2990.537 , 4196.5 , 28.57874 , "None"));
Path.Add(new Vector3(2989.44 , 4188.138 , 27.94133 , "None"));
Path.Add(new Vector3(2988.345 , 4179.792 , 27.39822 , "None"));
Path.Add(new Vector3(2988.536 , 4173.014 , 27.14367 , "None"));
Path.Add(new Vector3(2989.191 , 4164.034 , 27.80458 , "None"));
Path.Add(new Vector3(2989.848 , 4155.032 , 26.35005 , "None"));
Path.Add(new Vector3(2991.36 , 4147.039 , 25.24944 , "None"));
Path.Add(new Vector3(2993.22 , 4138.52 , 23.22252 , "None"));
Path.Add(new Vector3(2993.359 , 4132.466 , 23.21894 , "None"));
Path.Add(new Vector3(2989.577 , 4124.032 , 23.2504 , "None"));
Path.Add(new Vector3(2984.29 , 4117.375 , 24.81979 , "None"));
Path.Add(new Vector3(2979.045 , 4110.77 , 26.39129 , "None"));
Path.Add(new Vector3(2973.769 , 4104.126 , 25.71647 , "None"));
Path.Add(new Vector3(2965.062 , 4096.519 , 21.92437 , "None"));
Path.Add(new Vector3(2957.836 , 4092.203 , 17.76571 , "None"));
Path.Add(new Vector3(2950.84 , 4088.025 , 12.39273 , "None"));
Path.Add(new Vector3(2943.354 , 4083.554 , 6.526886 , "None"));
Path.Add(new Vector3(2936.363 , 4078.384 , 3.00729 , "None"));
Path.Add(new Vector3(2929.721 , 4073.187 , 1.366656 , "None"));
Path.Add(new Vector3(2925.236 , 4065.796 , 1.458469 , "None"));
Path.Add(new Vector3(2922.978 , 4058.201 , 1.734396 , "None"));
Path.Add(new Vector3(2919.322 , 4050.977 , 1.992238 , "None"));
Path.Add(new Vector3(2919.571 , 4047.193 , 1.882537 , "None"));
Path.Add(new Vector3(2925.527 , 4041.797 , 1.984491 , "None"));
Path.Add(new Vector3(2932.166 , 4035.738 , 2.05346 , "None"));
Path.Add(new Vector3(2937.925 , 4029.975 , 1.830241 , "None"));
Path.Add(new Vector3(2944.034 , 4023.754 , 1.766666 , "None"));
Path.Add(new Vector3(2949.943 , 4017.736 , 1.928048 , "None"));
Path.Add(new Vector3(2956.04 , 4011.527 , 1.979438 , "None"));
Path.Add(new Vector3(2961.949 , 4005.51 , 2.109485 , "None"));
Path.Add(new Vector3(2967.471 , 3999.889 , 1.906143 , "None"));
Path.Add(new Vector3(2974.181 , 3993.514 , 1.541166 , "None"));
Path.Add(new Vector3(2980.401 , 3987.819 , 2.476072 , "None"));
Path.Add(new Vector3(2987.09 , 3982.685 , 3.833587 , "None"));
Path.Add(new Vector3(2994.063 , 3977.479 , 8.340951 , "None"));
Path.Add(new Vector3(3000.363 , 3972.775 , 12.71775 , "None"));
Path.Add(new Vector3(3007.568 , 3967.396 , 18.79574 , "None"));
Path.Add(new Vector3(3014.312 , 3962.361 , 24.03755 , "None"));
Path.Add(new Vector3(3020.238 , 3956.038 , 26.92844 , "None"));
Path.Add(new Vector3(3024.804 , 3949.016 , 27.23448 , "None"));
Path.Add(new Vector3(3030.396 , 3942.331 , 28.22581 , "None"));
Path.Add(new Vector3(3035.916 , 3935.955 , 29.05914 , "None"));
Path.Add(new Vector3(3041.435 , 3929.578 , 27.38591 , "None"));
Path.Add(new Vector3(3047.131 , 3922.998 , 25.73274 , "None"));
Path.Add(new Vector3(3052.65 , 3916.622 , 25.56104 , "None"));
Path.Add(new Vector3(3058.335 , 3910.054 , 25.8364 , "None"));
Path.Add(new Vector3(3063.855 , 3903.677 , 25.98904 , "None"));
Path.Add(new Vector3(3069.375 , 3897.301 , 25.1664 , "None"));
Path.Add(new Vector3(3074.894 , 3890.924 , 23.08488 , "None"));
Path.Add(new Vector3(3080.59 , 3884.344 , 20.50705 , "None"));
Path.Add(new Vector3(3086.109 , 3877.968 , 18.41693 , "None"));
Path.Add(new Vector3(3091.618 , 3871.604 , 17.65694 , "None"));
Path.Add(new Vector3(3096.983 , 3865.406 , 17.75761 , "None"));
Path.Add(new Vector3(3102.776 , 3858.582 , 18.63094 , "None"));
Path.Add(new Vector3(3107.04 , 3851.325 , 20.71973 , "None"));
Path.Add(new Vector3(3110.708 , 3845.33 , 22.33278 , "None"));
Path.Add(new Vector3(3115.434 , 3839.698 , 22.78596 , "None"));
Path.Add(new Vector3(3112.527 , 3843.163 , 22.52762 , "None"));
Path.Add(new Vector3(3119.264 , 3841.167 , 23.21207 , "None"));
Path.Add(new Vector3(3126.725 , 3837.978 , 23.73779 , "None"));
Path.Add(new Vector3(3134.681 , 3834.577 , 23.19395 , "None"));
Path.Add(new Vector3(3143.069 , 3830.991 , 23.0515 , "None"));
Path.Add(new Vector3(3150.237 , 3827.927 , 23.1765 , "None"));
Path.Add(new Vector3(3158.501 , 3824.394 , 23.74227 , "None"));
Path.Add(new Vector3(3166.349 , 3821.04 , 24.71233 , "None"));
Path.Add(new Vector3(3173.967 , 3817.595 , 27.21269 , "None"));
Path.Add(new Vector3(3182.124 , 3814.153 , 27.32951 , "None"));
Path.Add(new Vector3(3188.833 , 3811.321 , 26.42894 , "None"));
Path.Add(new Vector3(3195.394 , 3806.101 , 25.72687 , "None"));
Path.Add(new Vector3(3201.004 , 3801.187 , 26.15125 , "None"));
Path.Add(new Vector3(3204.489 , 3804.895 , 26.94041 , "None"));
Path.Add(new Vector3(3206.622 , 3808.193 , 26.69959 , "None"));
Path.Add(new Vector3(3210.585 , 3814.274 , 25.15103 , "None"));
Path.Add(new Vector3(3212.889 , 3817.445 , 24.98346 , "None"));
Path.Add(new Vector3(3218.765 , 3814.925 , 25.11426 , "None"));
Path.Add(new Vector3(3221.292 , 3812.106 , 25.08419 , "None"));
Path.Add(new Vector3(3224 , 3809.095 , 25.11798 , "None"));
Path.Add(new Vector3(3226.781 , 3806.108 , 25.30546 , "None"));
Path.Add(new Vector3(3231.75 , 3800.981 , 26.04696 , "None"));
Path.Add(new Vector3(3236.755 , 3800.133 , 26.5512 , "None"));
Path.Add(new Vector3(3240.242 , 3802.222 , 26.6193 , "None"));
Path.Add(new Vector3(3243.521 , 3804.191 , 26.74389 , "None"));
Path.Add(new Vector3(3247.292 , 3806.449 , 27.01621 , "None"));
Path.Add(new Vector3(3250.576 , 3808.415 , 27.24948 , "None"));
Path.Add(new Vector3(3254.258 , 3810.619 , 27.54635 , "None"));
Path.Add(new Vector3(3260.138 , 3814.165 , 27.74025 , "None"));
Path.Add(new Vector3(3263.348 , 3816.059 , 27.18223 , "None"));
Path.Add(new Vector3(3266.778 , 3817.986 , 26.92251 , "None"));
Path.Add(new Vector3(3269.962 , 3819.63 , 27.01172 , "None"));
Path.Add(new Vector3(3276.389 , 3817.452 , 25.75666 , "None"));
Path.Add(new Vector3(3280.212 , 3816.144 , 25.59952 , "None"));
Path.Add(new Vector3(3283.658 , 3814.964 , 25.77416 , "None"));
Path.Add(new Vector3(3287.306 , 3813.716 , 26.20124 , "None"));
Path.Add(new Vector3(3294.642 , 3812.036 , 27.24645 , "None"));
Path.Add(new Vector3(3298.35 , 3811.195 , 27.79554 , "None"));
Path.Add(new Vector3(3305.345 , 3814.201 , 28.46762 , "None"));
Path.Add(new Vector3(3310.061 , 3816.317 , 28.76376 , "None"));
Path.Add(new Vector3(3306.902 , 3814.218 , 28.58867 , "None"));
Path.Add(new Vector3(3308.266 , 3810.771 , 28.89879 , "None"));
Path.Add(new Vector3(3307.638 , 3806.81 , 29.26229 , "None"));
Path.Add(new Vector3(3309.233 , 3803.639 , 29.65791 , "None"));
Path.Add(new Vector3(3311.078 , 3799.971 , 29.69348 , "None"));
Path.Add(new Vector3(3313.236 , 3796.349 , 29.47454 , "None"));
Path.Add(new Vector3(3316.004 , 3792.754 , 28.94767 , "None"));
Path.Add(new Vector3(3311.668 , 3787.101 , 28.38927 , "None"));
Path.Add(new Vector3(3309.478 , 3784.246 , 28.05764 , "None"));
Path.Add(new Vector3(3306.734 , 3780.669 , 27.60238 , "None"));
Path.Add(new Vector3(3302.797 , 3775.659 , 26.91128 , "None"));
Path.Add(new Vector3(3297.468 , 3769.455 , 26.0232 , "None"));
Path.Add(new Vector3(3294.322 , 3766.194 , 25.51734 , "None"));
Path.Add(new Vector3(3282.518 , 3765.584 , 25.34492 , "None"));
Path.Add(new Vector3(3273.548 , 3765 , 25.01495 , "None"));
Path.Add(new Vector3(3265.233 , 3764.459 , 24.82065 , "None"));
Path.Add(new Vector3(3256.767 , 3763.907 , 24.78584 , "None"));
Path.Add(new Vector3(3248.737 , 3763.385 , 24.88653 , "None"));
Path.Add(new Vector3(3240.958 , 3762.878 , 25.10748 , "None"));
Path.Add(new Vector3(3233.572 , 3765.207 , 25.64138 , "None"));
Path.Add(new Vector3(3226.14 , 3769.604 , 26.03468 , "None"));
Path.Add(new Vector3(3219.113 , 3773.76 , 26.02704 , "None"));
Path.Add(new Vector3(3211.507 , 3778.26 , 26.23675 , "None"));
Path.Add(new Vector3(3204.494 , 3782.408 , 26.92056 , "None"));
Path.Add(new Vector3(3196.845 , 3786.933 , 27.49035 , "None"));
Path.Add(new Vector3(3189.731 , 3791.141 , 28.54813 , "None"));
Path.Add(new Vector3(3182.299 , 3795.538 , 27.6953 , "None"));
Path.Add(new Vector3(3174.866 , 3799.934 , 27.15961 , "None"));
Path.Add(new Vector3(3169.329 , 3803.038 , 25.21448 , "None"));
Path.Add(new Vector3(3165.674 , 3804.891 , 24.26569 , "None"));
Path.Add(new Vector3(3162.736 , 3807.015 , 23.03967 , "None"));
Path.Add(new Vector3(3155.844 , 3812.135 , 20.33186 , "None"));
Path.Add(new Vector3(3149.115 , 3817.133 , 19.48088 , "None"));
Path.Add(new Vector3(3142.21 , 3822.262 , 19.91951 , "None"));
Path.Add(new Vector3(3135.278 , 3827.411 , 21.18319 , "None"));
Path.Add(new Vector3(3128.75 , 3832.26 , 22.954 , "None"));
Path.Add(new Vector3(3121.629 , 3837.549 , 23.43952 , "None"));
Path.Add(new Vector3(3116.182 , 3841.595 , 22.87942 , "None"));
Path.Add(new Vector3(3126.854 , 3836.526 , 23.67742 , "None"));
Path.Add(new Vector3(3134.038 , 3831.794 , 22.47543 , "None"));
Path.Add(new Vector3(3141.095 , 3827.146 , 21.60962 , "None"));
Path.Add(new Vector3(3148.419 , 3822.323 , 21.12578 , "None"));
Path.Add(new Vector3(3155.462 , 3817.684 , 21.59508 , "None"));
Path.Add(new Vector3(3162.66 , 3812.943 , 22.9974 , "None"));
Path.Add(new Vector3(3169.745 , 3808.277 , 25.41392 , "None"));
Path.Add(new Vector3(3176.999 , 3803.499 , 26.6019 , "None"));
Path.Add(new Vector3(3183.916 , 3798.944 , 26.82034 , "None"));
Path.Add(new Vector3(3191.099 , 3794.212 , 27.82232 , "None"));
Path.Add(new Vector3(3198.058 , 3789.629 , 27.19728 , "None"));
Path.Add(new Vector3(3205.284 , 3784.87 , 26.7705 , "None"));
Path.Add(new Vector3(3212.257 , 3780.277 , 26.1898 , "None"));
Path.Add(new Vector3(3219.524 , 3775.491 , 26.06307 , "None"));
Path.Add(new Vector3(3226.273 , 3771.046 , 26.09178 , "None"));
Path.Add(new Vector3(3233.765 , 3766.111 , 25.69859 , "None"));
Path.Add(new Vector3(3240.413 , 3762.062 , 25.05039 , "None"));
Path.Add(new Vector3(3248.873 , 3760.815 , 24.5551 , "None"));
Path.Add(new Vector3(3257.366 , 3759.563 , 24.13436 , "None"));
Path.Add(new Vector3(3265.942 , 3758.299 , 23.78246 , "None"));
Path.Add(new Vector3(3272.706 , 3757.302 , 23.59698 , "None"));
Path.Add(new Vector3(3282.512 , 3755.856 , 23.60011 , "None"));
Path.Add(new Vector3(3287.409 , 3755.134 , 23.68173 , "None"));
Path.Add(new Vector3(3295.238 , 3753.98 , 23.58264 , "None"));
Path.Add(new Vector3(3300.855 , 3753.152 , 23.38329 , "None"));
Path.Add(new Vector3(3310.611 , 3751.714 , 22.90287 , "None"));
Path.Add(new Vector3(3317.859 , 3750.65 , 22.62863 , "None"));
Path.Add(new Vector3(3325.535 , 3749.508 , 22.33052 , "None"));
Path.Add(new Vector3(3331.998 , 3746.78 , 22.08238 , "None"));
Path.Add(new Vector3(3336.341 , 3742.995 , 22.04108 , "None"));
Path.Add(new Vector3(3342.884 , 3741.194 , 22.32106 , "None"));
Path.Add(new Vector3(3349.17 , 3735.226 , 22.17368 , "None"));
Path.Add(new Vector3(3351.207 , 3729.747 , 21.9352 , "None"));
Path.Add(new Vector3(3357.014 , 3724.724 , 21.81787 , "None"));
Path.Add(new Vector3(3358.162 , 3718.657 , 21.64235 , "None"));
Path.Add(new Vector3(3351.881 , 3713.428 , 22.65129 , "None"));
Path.Add(new Vector3(3345.166 , 3707.84 , 29.72732 , "None"));
Path.Add(new Vector3(3338.839 , 3702.573 , 32.41534 , "None"));
Path.Add(new Vector3(3332.344 , 3697.168 , 32.40595 , "None"));
Path.Add(new Vector3(3326.959 , 3692.686 , 32.4329 , "None"));
Path.Add(new Vector3(3319.257 , 3691.553 , 32.45134 , "None"));
Path.Add(new Vector3(3311.275 , 3688.533 , 32.46737 , "None"));
Path.Add(new Vector3(3307.841 , 3687.234 , 32.46737 , "None"));
Path.Add(new Vector3(3303.604 , 3685.627 , 32.46737 , "None"));
Path.Add(new Vector3(3298.317 , 3683.621 , 32.46737 , "None"));
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


public sealed class TheEmissaryPoint2 : QuestFollowPathClass
{
    public TheEmissaryPoint2()
    {
        Name = "The Emissary Point2";

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

        Path.Add(new Vector3(1519.318 , 5581.685 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1524.886 , 5582.769 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1529.193 , 5584.75 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1533.569 , 5586.763 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1537.825 , 5589.001 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1541.885 , 5591.485 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1545.978 , 5593.989 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1550.019 , 5596.46 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1554.063 , 5598.935 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1558.249 , 5601.495 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1562.349 , 5604.003 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1566.462 , 5606.519 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1570.503 , 5608.99 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1574.273 , 5611.297 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1578.721 , 5614.017 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1582.765 , 5616.491 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1586.874 , 5619.004 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1590.935 , 5621.488 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1595.027 , 5623.992 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1599.136 , 5626.505 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1603.157 , 5628.964 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1607.29 , 5631.493 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1611.399 , 5634.006 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1615.467 , 5636.495 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1619.56 , 5638.999 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1623.625 , 5641.484 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1627.806 , 5644.042 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1631.81 , 5646.492 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1635.855 , 5648.966 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1639.964 , 5651.479 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1644.077 , 5653.995 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1648.117 , 5656.466 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1652.23 , 5658.982 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1656.27 , 5661.454 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1660.311 , 5663.925 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1664.492 , 5666.483 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1668.533 , 5668.955 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1672.642 , 5671.468 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1676.75 , 5673.981 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1680.795 , 5676.455 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1684.904 , 5678.969 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1688.948 , 5681.442 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1693.057 , 5683.956 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1697.166 , 5686.469 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1701.215 , 5688.946 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1705.315 , 5691.454 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1709.424 , 5693.968 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1713.469 , 5696.441 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1717.578 , 5698.955 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1721.687 , 5701.468 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1725.743 , 5703.95 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1729.84 , 5706.456 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1733.949 , 5708.969 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1737.993 , 5711.443 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1742.102 , 5713.957 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1746.147 , 5716.43 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1750.256 , 5718.944 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1754.22 , 5721.65 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1757.695 , 5724.868 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1761.233 , 5728.144 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1764.497 , 5731.67 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1767.478 , 5735.356 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1770.505 , 5739.097 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1773.02 , 5742.818 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1776.513 , 5746.423 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1779.537 , 5750.148 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1781.606 , 5754.492 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1783.938 , 5758.605 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1786.475 , 5762.61 , -1.643586 , "Swimming"));
Path.Add(new Vector3(1789.106 , 5766.737 , -1.524016 , "Swimming"));
Path.Add(new Vector3(1791.659 , 5770.726 , -1.524016 , "Swimming"));
Path.Add(new Vector3(1794.216 , 5774.719 , -1.524016 , "Swimming"));
Path.Add(new Vector3(1796.856 , 5778.843 , -1.524016 , "Swimming"));
Path.Add(new Vector3(1799.57 , 5783.084 , -1.267954 , "None"));
Path.Add(new Vector3(1801.827 , 5786.61 , -0.5328762 , "None"));
Path.Add(new Vector3(1804.032 , 5790.054 , -0.1223076 , "None"));
Path.Add(new Vector3(1805.976 , 5793.091 , 0.08762971 , "None"));
Path.Add(new Vector3(1808.951 , 5795.889 , 0.2305932 , "None"));
Path.Add(new Vector3(1815.83 , 5800.946 , 0.2699305 , "None"));
Path.Add(new Vector3(1821.25 , 5807.365 , 0.40279 , "None"));
Path.Add(new Vector3(1827.561 , 5812.958 , 0.5184137 , "None"));
Path.Add(new Vector3(1835.123 , 5818.702 , 0.9158356 , "None"));
Path.Add(new Vector3(1841.494 , 5822.874 , 1.349466 , "None"));
Path.Add(new Vector3(1848.996 , 5826.69 , 3.2627 , "None"));
Path.Add(new Vector3(1856.767 , 5830.645 , 5.182377 , "None"));
Path.Add(new Vector3(1864.029 , 5834.34 , 4.428536 , "None"));
Path.Add(new Vector3(1871.784 , 5838.287 , 4.439301 , "None"));
Path.Add(new Vector3(1878.807 , 5841.861 , 4.941601 , "None"));
Path.Add(new Vector3(1887.072 , 5846.067 , 8.10423 , "None"));
Path.Add(new Vector3(1894.573 , 5849.884 , 10.335 , "None"));
Path.Add(new Vector3(1902.089 , 5853.709 , 12.3559 , "None"));
Path.Add(new Vector3(1909.811 , 5856.934 , 13.07989 , "None"));
Path.Add(new Vector3(1918.494 , 5857.444 , 13.03102 , "None"));
Path.Add(new Vector3(1926.891 , 5858.218 , 12.297 , "None"));
Path.Add(new Vector3(1935.441 , 5859.788 , 11.71283 , "None"));
Path.Add(new Vector3(1943.558 , 5862.039 , 12.87899 , "None"));
Path.Add(new Vector3(1951.461 , 5864.982 , 18.32158 , "None"));
Path.Add(new Vector3(1959.373 , 5867.572 , 22.5596 , "None"));
Path.Add(new Vector3(1967.307 , 5868.228 , 28.57762 , "None"));
Path.Add(new Vector3(1974.29 , 5863.7 , 32.01176 , "None"));
Path.Add(new Vector3(1978.214 , 5859.244 , 35.20042 , "None"));
Path.Add(new Vector3(1981.632 , 5858.79 , 36.62307 , "None"));
Path.Add(new Vector3(1990.039 , 5858.124 , 38.18604 , "None"));
Path.Add(new Vector3(1998.159 , 5856.633 , 35.89761 , "None"));
Path.Add(new Vector3(2001.776 , 5849.499 , 35.99733 , "None"));
Path.Add(new Vector3(2008.728 , 5844.548 , 36.76302 , "None"));
Path.Add(new Vector3(2015.584 , 5839.666 , 37.91935 , "None"));
Path.Add(new Vector3(2021.906 , 5835.163 , 38.93916 , "None"));
Path.Add(new Vector3(2029.446 , 5829.793 , 38.35324 , "None"));
Path.Add(new Vector3(2036.548 , 5824.735 , 38.62461 , "None"));
Path.Add(new Vector3(2043.395 , 5819.859 , 40.33905 , "None"));
Path.Add(new Vector3(2050.279 , 5814.957 , 44.01622 , "None"));
Path.Add(new Vector3(2056.683 , 5810.396 , 45.18977 , "None"));
Path.Add(new Vector3(2064.004 , 5805.182 , 45.72774 , "None"));
Path.Add(new Vector3(2071.093 , 5800.134 , 47.84128 , "None"));
Path.Add(new Vector3(2078.099 , 5795.144 , 50.92841 , "None"));
Path.Add(new Vector3(2085.044 , 5790.197 , 52.90113 , "None"));
Path.Add(new Vector3(2091.913 , 5785.305 , 54.56825 , "None"));
Path.Add(new Vector3(2097.866 , 5781.065 , 55.60402 , "None"));
Path.Add(new Vector3(2105.871 , 5775.364 , 57.22791 , "None"));
Path.Add(new Vector3(2112.741 , 5770.472 , 57.63606 , "None"));
Path.Add(new Vector3(2119.61 , 5765.58 , 58.92654 , "None"));
Path.Add(new Vector3(2126.466 , 5760.697 , 58.89523 , "None"));
Path.Add(new Vector3(2132.419 , 5756.458 , 58.71985 , "None"));
Path.Add(new Vector3(2140.671 , 5750.581 , 58.16208 , "None"));
Path.Add(new Vector3(2147.71 , 5746.049 , 57.75997 , "None"));
Path.Add(new Vector3(2155.67 , 5743.265 , 57.16287 , "None"));
Path.Add(new Vector3(2163.631 , 5740.48 , 56.21087 , "None"));
Path.Add(new Vector3(2171.861 , 5737.601 , 55.28944 , "None"));
Path.Add(new Vector3(2179.806 , 5734.821 , 54.89026 , "None"));
Path.Add(new Vector3(2184.849 , 5733.057 , 54.56612 , "None"));
Path.Add(new Vector3(2192.92 , 5730.234 , 54.45063 , "None"));
Path.Add(new Vector3(2203.941 , 5726.378 , 54.47226 , "None"));
Path.Add(new Vector3(2211.886 , 5723.599 , 54.7708 , "None"));
Path.Add(new Vector3(2220.116 , 5720.72 , 55.69852 , "None"));
Path.Add(new Vector3(2228.077 , 5717.935 , 56.55189 , "None"));
Path.Add(new Vector3(2236.291 , 5715.062 , 56.36527 , "None"));
Path.Add(new Vector3(2244.267 , 5712.271 , 55.57441 , "None"));
Path.Add(new Vector3(2252.212 , 5709.492 , 55.15962 , "None"));
Path.Add(new Vector3(2260.157 , 5706.712 , 55.58757 , "None"));
Path.Add(new Vector3(2268.387 , 5703.833 , 56.13755 , "None"));
Path.Add(new Vector3(2276.347 , 5701.049 , 55.7221 , "None"));
Path.Add(new Vector3(2284.292 , 5698.27 , 54.57956 , "None"));
Path.Add(new Vector3(2292.522 , 5695.39 , 53.2938 , "None"));
Path.Add(new Vector3(2300.467 , 5692.611 , 53.37932 , "None"));
Path.Add(new Vector3(2308.174 , 5689.915 , 53.62089 , "None"));
Path.Add(new Vector3(2314.563 , 5684.745 , 52.2107 , "None"));
Path.Add(new Vector3(2319.191 , 5677.635 , 48.887 , "None"));
Path.Add(new Vector3(2323.792 , 5670.566 , 45.85761 , "None"));
Path.Add(new Vector3(2328.383 , 5663.513 , 43.8168 , "None"));
Path.Add(new Vector3(2333.305 , 5655.952 , 43.23912 , "None"));
Path.Add(new Vector3(2337.731 , 5649.151 , 43.13029 , "None"));
Path.Add(new Vector3(2342.488 , 5641.844 , 42.11355 , "None"));
Path.Add(new Vector3(2345.247 , 5637.605 , 41.59707 , "None"));
Path.Add(new Vector3(2351.552 , 5627.918 , 39.41703 , "None"));
Path.Add(new Vector3(2356.153 , 5620.851 , 37.81904 , "None"));
Path.Add(new Vector3(2360.91 , 5613.543 , 35.53064 , "None"));
Path.Add(new Vector3(2365.345 , 5606.729 , 34.59244 , "None"));
Path.Add(new Vector3(2369.378 , 5600.533 , 34.97321 , "None"));
Path.Add(new Vector3(2374.85 , 5592.127 , 35.71601 , "None"));
Path.Add(new Vector3(2379.451 , 5585.059 , 35.27081 , "None"));
Path.Add(new Vector3(2384.042 , 5578.005 , 34.51358 , "None"));
Path.Add(new Vector3(2388.37 , 5571.082 , 33.69561 , "None"));
Path.Add(new Vector3(2392.961 , 5563.688 , 33.36606 , "None"));
Path.Add(new Vector3(2397.386 , 5556.562 , 33.36207 , "None"));
Path.Add(new Vector3(2402.003 , 5549.126 , 33.31983 , "None"));
Path.Add(new Vector3(2406.328 , 5542.162 , 33.39815 , "None"));
Path.Add(new Vector3(2409.997 , 5536.253 , 33.16321 , "None"));
Path.Add(new Vector3(2415.483 , 5527.418 , 31.27604 , "None"));
Path.Add(new Vector3(2419.196 , 5521.438 , 29.35984 , "None"));
Path.Add(new Vector3(2424.425 , 5513.018 , 27.13758 , "None"));
Path.Add(new Vector3(2428.528 , 5506.41 , 26.01484 , "None"));
Path.Add(new Vector3(2432.162 , 5500.558 , 26.76165 , "None"));
Path.Add(new Vector3(2436.594 , 5493.42 , 28.29067 , "None"));
Path.Add(new Vector3(2441.185 , 5486.027 , 29.39162 , "None"));
Path.Add(new Vector3(2445.634 , 5478.862 , 29.34909 , "None"));
Path.Add(new Vector3(2450.083 , 5471.698 , 26.49861 , "None"));
Path.Add(new Vector3(2454.532 , 5464.533 , 21.78203 , "None"));
Path.Add(new Vector3(2458.679 , 5457.854 , 19.78676 , "None"));
Path.Add(new Vector3(2463.471 , 5449.915 , 21.9357 , "None"));
Path.Add(new Vector3(2467.874 , 5442.564 , 26.15752 , "None"));
Path.Add(new Vector3(2472.13 , 5435.458 , 27.14111 , "None"));
Path.Add(new Vector3(2475.306 , 5430.155 , 26.87885 , "None"));
Path.Add(new Vector3(2479.674 , 5422.863 , 23.23496 , "None"));
Path.Add(new Vector3(2484.172 , 5415.354 , 20.78781 , "None"));
Path.Add(new Vector3(2485.849 , 5408.027 , 22.53855 , "None"));
Path.Add(new Vector3(2486.253 , 5402.531 , 25.50276 , "None"));
Path.Add(new Vector3(2486.924 , 5393.636 , 28.76854 , "None"));
Path.Add(new Vector3(2487.557 , 5385.226 , 29.97699 , "None"));
Path.Add(new Vector3(2487.938 , 5380.183 , 30.84875 , "None"));
Path.Add(new Vector3(2488.781 , 5368.993 , 31.79374 , "None"));
Path.Add(new Vector3(2490.06 , 5360.592 , 31.72192 , "None"));
Path.Add(new Vector3(2494.487 , 5345.363 , 32.72209 , "None"));
Path.Add(new Vector3(2496.842 , 5337.265 , 33.07712 , "None"));
Path.Add(new Vector3(2498.498 , 5331.57 , 33.07589 , "None"));
Path.Add(new Vector3(2502.845 , 5329.252 , 33.07589 , "None"));
Path.Add(new Vector3(2508.839 , 5323.296 , 33.07589 , "None"));
Path.Add(new Vector3(2514.225 , 5317.944 , 33.05035 , "None"));
Path.Add(new Vector3(2520.78 , 5311.431 , 33.07529 , "None"));
Path.Add(new Vector3(2525.819 , 5307.639 , 33.10513 , "None"));
Path.Add(new Vector3(2533.576 , 5304.202 , 33.12385 , "None"));
Path.Add(new Vector3(2540.78 , 5301.011 , 33.8716 , "None"));
Path.Add(new Vector3(2549.243 , 5297.262 , 31.29074 , "None"));
Path.Add(new Vector3(2556.969 , 5293.839 , 31.0194 , "None"));
Path.Add(new Vector3(2564.158 , 5290.654 , 32.61443 , "None"));
Path.Add(new Vector3(2571.469 , 5287.415 , 35.06322 , "None"));
Path.Add(new Vector3(2579.564 , 5283.829 , 36.26355 , "None"));
Path.Add(new Vector3(2587.506 , 5280.311 , 36.79116 , "None"));
Path.Add(new Vector3(2595.954 , 5276.568 , 36.8272 , "None"));
Path.Add(new Vector3(2601.671 , 5274.035 , 36.9313 , "None"));
Path.Add(new Vector3(2609.771 , 5268.746 , 39.39669 , "None"));
Path.Add(new Vector3(2615.684 , 5263.438 , 39.41121 , "None"));
Path.Add(new Vector3(2618.558 , 5260.898 , 39.39099 , "None"));
Path.Add(new Vector3(2622.017 , 5258.125 , 38.27493 , "None"));
Path.Add(new Vector3(2625.593 , 5256.261 , 38.27458 , "None"));
Path.Add(new Vector3(2629.269 , 5254.345 , 38.29255 , "None"));
Path.Add(new Vector3(2632.874 , 5252.466 , 38.28909 , "None"));
Path.Add(new Vector3(2636.572 , 5250.539 , 38.29156 , "None"));
Path.Add(new Vector3(2640.17 , 5248.664 , 38.31213 , "None"));
Path.Add(new Vector3(2646.012 , 5247.416 , 38.31051 , "None"));
Path.Add(new Vector3(2649.246 , 5244.993 , 37.56488 , "None"));
Path.Add(new Vector3(2652.551 , 5242.517 , 36.19095 , "None"));
Path.Add(new Vector3(2655.495 , 5240.311 , 34.51134 , "None"));
Path.Add(new Vector3(2658.614 , 5237.975 , 33.07499 , "None"));
Path.Add(new Vector3(2664.65 , 5233.453 , 31.17567 , "None"));
Path.Add(new Vector3(2668.86 , 5230.298 , 30.06061 , "None"));
Path.Add(new Vector3(2673.756 , 5225.674 , 28.35074 , "None"));
Path.Add(new Vector3(2679.831 , 5219.824 , 28.174 , "None"));
Path.Add(new Vector3(2686.014 , 5213.869 , 27.62845 , "None"));
Path.Add(new Vector3(2691.411 , 5208.671 , 26.75878 , "None"));
Path.Add(new Vector3(2697.994 , 5202.332 , 25.69999 , "None"));
Path.Add(new Vector3(2703.718 , 5196.819 , 25.10933 , "None"));
Path.Add(new Vector3(2709.986 , 5190.783 , 25.12812 , "None"));
Path.Add(new Vector3(2716.666 , 5184.35 , 25.91233 , "None"));
Path.Add(new Vector3(2722.776 , 5178.464 , 26.99612 , "None"));
Path.Add(new Vector3(2729.021 , 5172.451 , 27.9438 , "None"));
Path.Add(new Vector3(2733.05 , 5168.57 , 28.23927 , "None"));
Path.Add(new Vector3(2740.129 , 5161.753 , 28.39251 , "None"));
Path.Add(new Vector3(2746.204 , 5155.903 , 28.5761 , "None"));
Path.Add(new Vector3(2750.165 , 5150.526 , 28.67424 , "None"));
Path.Add(new Vector3(2757.292 , 5137.501 , 30.14939 , "None"));
Path.Add(new Vector3(2760.985 , 5130.751 , 31.72688 , "None"));
Path.Add(new Vector3(2765.44 , 5122.61 , 33.15055 , "None"));
Path.Add(new Vector3(2769.214 , 5115.712 , 34.51588 , "None"));
Path.Add(new Vector3(2774.92 , 5108.434 , 33.5752 , "None"));
Path.Add(new Vector3(2780.355 , 5101.985 , 31.32083 , "None"));
Path.Add(new Vector3(2785.963 , 5095.331 , 29.57435 , "None"));
Path.Add(new Vector3(2791.257 , 5089.048 , 27.792 , "None"));
Path.Add(new Vector3(2795.847 , 5083.602 , 26.83599 , "None"));
Path.Add(new Vector3(2800.871 , 5077.641 , 27.07184 , "None"));
Path.Add(new Vector3(2804.255 , 5073.625 , 27.7332 , "None"));
Path.Add(new Vector3(2807.561 , 5069.702 , 28.31942 , "None"));
Path.Add(new Vector3(2809.906 , 5066.919 , 28.56541 , "None"));
Path.Add(new Vector3(2813.329 , 5062.857 , 28.7845 , "None"));
Path.Add(new Vector3(2816.59 , 5058.988 , 28.60101 , "None"));
Path.Add(new Vector3(2819.909 , 5055.049 , 28.3828 , "None"));
Path.Add(new Vector3(2823.326 , 5050.995 , 27.98435 , "None"));
Path.Add(new Vector3(2826.47 , 5047.264 , 27.6969 , "None"));
Path.Add(new Vector3(2829.854 , 5043.248 , 27.89784 , "None"));
Path.Add(new Vector3(2833.102 , 5039.394 , 28.72276 , "None"));
Path.Add(new Vector3(2835.921 , 5036.049 , 28.98099 , "None"));
Path.Add(new Vector3(2841.43 , 5029.512 , 28.92001 , "None"));
Path.Add(new Vector3(2843.976 , 5026.491 , 28.87593 , "None"));
Path.Add(new Vector3(2848.105 , 5021.833 , 28.57693 , "None"));
Path.Add(new Vector3(2852.702 , 5020.037 , 27.71603 , "None"));
Path.Add(new Vector3(2857.837 , 5019.091 , 27.26128 , "None"));
Path.Add(new Vector3(2862.198 , 5018.288 , 27.42529 , "None"));
Path.Add(new Vector3(2867.938 , 5017.23 , 28.89461 , "None"));
Path.Add(new Vector3(2875.892 , 5015.766 , 31.2061 , "None"));
Path.Add(new Vector3(2884.417 , 5014.195 , 30.92826 , "None"));
Path.Add(new Vector3(2892.711 , 5012.667 , 31.10218 , "None"));
Path.Add(new Vector3(2900.46 , 5011.24 , 30.2618 , "None"));
Path.Add(new Vector3(2909.597 , 5009.557 , 29.25132 , "None"));
Path.Add(new Vector3(2915.991 , 5008.379 , 30.30975 , "None"));
Path.Add(new Vector3(2926.417 , 5006.459 , 30.48534 , "None"));
Path.Add(new Vector3(2934.711 , 5004.932 , 30.94715 , "None"));
Path.Add(new Vector3(2942.724 , 5003.456 , 31.1252 , "None"));
Path.Add(new Vector3(2951.563 , 5001.828 , 29.35978 , "None"));
Path.Add(new Vector3(2954.604 , 5001.268 , 27.50592 , "None"));
Path.Add(new Vector3(2956.449 , 4994.029 , 21.62803 , "None"));
Path.Add(new Vector3(2955.871 , 4985.462 , 17.61544 , "None"));
Path.Add(new Vector3(2953.708 , 4977.016 , 13.41105 , "None"));
Path.Add(new Vector3(2951.994 , 4969.62 , 11.4904 , "None"));
Path.Add(new Vector3(2952.063 , 4960.649 , 12.7127 , "None"));
Path.Add(new Vector3(2952.109 , 4954.753 , 12.22554 , "None"));
Path.Add(new Vector3(2952.267 , 4944.346 , 8.696232 , "None"));
Path.Add(new Vector3(2959.959 , 4940.497 , 8.427141 , "None"));
Path.Add(new Vector3(2968.401 , 4938.588 , 6.868454 , "None"));
Path.Add(new Vector3(2976.722 , 4937.216 , 4.963187 , "None"));
Path.Add(new Vector3(2985.027 , 4935.847 , 3.110237 , "None"));
Path.Add(new Vector3(2992.149 , 4934.315 , 0.3972232 , "None"));
Path.Add(new Vector3(3004.723 , 4929.813 , 0.3972232 , "None"));
Path.Add(new Vector3(3012.948 , 4926.868 , 0.3972232 , "None"));
Path.Add(new Vector3(3021.647 , 4923.752 , 1.340048 , "None"));
Path.Add(new Vector3(3028.179 , 4921.414 , 2.629747 , "None"));
Path.Add(new Vector3(3034 , 4919.329 , 2.435213 , "None"));
Path.Add(new Vector3(3042.525 , 4916.276 , 0.7659675 , "None"));
Path.Add(new Vector3(3050.56 , 4913.399 , 2.005779 , "None"));
Path.Add(new Vector3(3053.924 , 4912.195 , 1.83365 , "None"));
Path.Add(new Vector3(3059.459 , 4910.213 , 1.892365 , "None"));
Path.Add(new Vector3(3066.813 , 4907.579 , 2.028015 , "None"));
Path.Add(new Vector3(3074.184 , 4904.94 , 2.246624 , "None"));
Path.Add(new Vector3(3081.76 , 4902.227 , 2.203783 , "None"));
Path.Add(new Vector3(3087.407 , 4900.205 , 1.740252 , "None"));
Path.Add(new Vector3(3097.387 , 4896.631 , 1.181374 , "None"));
Path.Add(new Vector3(3105.344 , 4893.949 , 1.037795 , "None"));
Path.Add(new Vector3(3113.751 , 4893.54 , 0.961742 , "None"));
Path.Add(new Vector3(3122.175 , 4893.132 , 1.941608 , "None"));
Path.Add(new Vector3(3131.423 , 4888.873 , 1.299682 , "None"));
Path.Add(new Vector3(3138.815 , 4885.306 , 2.692957 , "None"));
Path.Add(new Vector3(3131.691 , 4879.294 , 1.253255 , "None"));
Path.Add(new Vector3(3125.758 , 4875.507 , 1.22828 , "None"));
Path.Add(new Vector3(3118.195 , 4870.68 , 1.53362 , "None"));
Path.Add(new Vector3(3110.605 , 4865.836 , 1.992802 , "None"));
Path.Add(new Vector3(3106.073 , 4862.944 , 2.319332 , "None"));
Path.Add(new Vector3(3096.882 , 4857.078 , 3.08378 , "None"));
Path.Add(new Vector3(3090.014 , 4852.694 , 2.946986 , "None"));
Path.Add(new Vector3(3084.833 , 4849.393 , 3.173984 , "None"));
Path.Add(new Vector3(3081.654 , 4844.943 , 3.198478 , "None"));
Path.Add(new Vector3(3080.572 , 4840.401 , 2.912769 , "None"));
Path.Add(new Vector3(3079.908 , 4834.321 , 2.103184 , "None"));
Path.Add(new Vector3(3081.918 , 4827.791 , 1.989443 , "None"));
Path.Add(new Vector3(3083.054 , 4824.092 , 1.521477 , "None"));
Path.Add(new Vector3(3087.536 , 4822.136 , 1.083887 , "None"));
Path.Add(new Vector3(3091.091 , 4826.029 , 1.011792 , "None"));
Path.Add(new Vector3(3091.151 , 4832.721 , 1.773901 , "None"));
Path.Add(new Vector3(3091.437 , 4828.03 , 0.9105996 , "None"));
Path.Add(new Vector3(3091.075 , 4824.409 , 1.064445 , "None"));
Path.Add(new Vector3(3092.475 , 4820.282 , 1.090762 , "None"));
Path.Add(new Vector3(3095.861 , 4812.802 , 1.258065 , "None"));
Path.Add(new Vector3(3097.527 , 4809.12 , 1.221907 , "None"));
Path.Add(new Vector3(3095.802 , 4805.14 , 2.887169 , "None"));
Path.Add(new Vector3(3091.598 , 4805.731 , 1.887273 , "None"));
Path.Add(new Vector3(3087.639 , 4805.742 , 1.220731 , "None"));
Path.Add(new Vector3(3083.483 , 4806.077 , 1.220731 , "None"));
Path.Add(new Vector3(3079.447 , 4806.403 , 1.170763 , "None"));
Path.Add(new Vector3(3075.291 , 4806.739 , 1.13506 , "None"));
Path.Add(new Vector3(3071.262 , 4807.064 , 1.018567 , "None"));
Path.Add(new Vector3(3067.242 , 4807.389 , 1.018567 , "None"));
Path.Add(new Vector3(3063.215 , 4807.714 , 1.018567 , "None"));
Path.Add(new Vector3(3059.066 , 4808.049 , 1.257542 , "None"));
Path.Add(new Vector3(3055.158 , 4808.365 , 1.537361 , "None"));
Path.Add(new Vector3(3055.948 , 4803.356 , 1.322431 , "None"));
Path.Add(new Vector3(3057.109 , 4799.493 , 1.201343 , "None"));
Path.Add(new Vector3(3057.144 , 4795.652 , 0.3964663 , "None"));
Path.Add(new Vector3(3054.56 , 4792.549 , 0.3964663 , "None"));
Path.Add(new Vector3(3051.39 , 4790.042 , 0.3964663 , "None"));
Path.Add(new Vector3(3048.113 , 4787.45 , 0.3964663 , "None"));
Path.Add(new Vector3(3045.247 , 4785.183 , 0.3964663 , "None"));
Path.Add(new Vector3(3041.673 , 4782.356 , 0.3964663 , "None"));
Path.Add(new Vector3(3038.611 , 4779.935 , 0.3964663 , "None"));
Path.Add(new Vector3(3045.002 , 4782.068 , 0.3964663 , "None"));
Path.Add(new Vector3(3049.021 , 4782.903 , 0.3964663 , "None"));
Path.Add(new Vector3(3056.559 , 4783.298 , 0.3964663 , "None"));
Path.Add(new Vector3(3060.402 , 4782.24 , 1.243744 , "None"));
Path.Add(new Vector3(3061.622 , 4778.272 , 1.142578 , "None"));
Path.Add(new Vector3(3060.565 , 4771.277 , 1.651057 , "None"));
Path.Add(new Vector3(3058.132 , 4767.391 , 1.276586 , "None"));
Path.Add(new Vector3(3054.773 , 4759.943 , 1.039557 , "None"));
Path.Add(new Vector3(3053.108 , 4756.252 , 0.9690647 , "None"));
Path.Add(new Vector3(3051.35 , 4752.475 , 1.771747 , "None"));
Path.Add(new Vector3(3049.122 , 4749.279 , 1.843707 , "None"));
Path.Add(new Vector3(3046.732 , 4745.853 , 1.855264 , "None"));
Path.Add(new Vector3(3042.026 , 4739.104 , 1.605692 , "None"));
Path.Add(new Vector3(3039.724 , 4735.802 , 0.8154979 , "None"));
Path.Add(new Vector3(3036.82 , 4732.846 , 0.3964379 , "None"));
Path.Add(new Vector3(3033.896 , 4730.223 , 0.3964379 , "None"));
Path.Add(new Vector3(3030.887 , 4727.525 , 0.3964379 , "None"));
Path.Add(new Vector3(3036.168 , 4734.315 , 0.3964379 , "None"));
Path.Add(new Vector3(3042.46 , 4739.906 , 1.588181 , "None"));
Path.Add(new Vector3(3048.978 , 4745.697 , 1.856857 , "None"));
Path.Add(new Vector3(3055.282 , 4751.299 , 1.583426 , "None"));
Path.Add(new Vector3(3061.591 , 4756.698 , 1.744994 , "None"));
Path.Add(new Vector3(3064.823 , 4761.159 , 1.336314 , "None"));
Path.Add(new Vector3(3065.11 , 4770.445 , 1.213644 , "None"));
Path.Add(new Vector3(3065.37 , 4778.858 , 1.127793 , "None"));
Path.Add(new Vector3(3065.638 , 4787.506 , 1.084532 , "None"));
Path.Add(new Vector3(3065.9 , 4795.986 , 1.155532 , "None"));
Path.Add(new Vector3(3066.161 , 4804.415 , 1.018379 , "None"));
Path.Add(new Vector3(3066.421 , 4812.828 , 1.047365 , "None"));
Path.Add(new Vector3(3066.671 , 4820.929 , 1.784833 , "None"));
Path.Add(new Vector3(3074.784 , 4821.677 , 1.220461 , "None"));
Path.Add(new Vector3(3082.896 , 4822.44 , 2.346552 , "None"));
Path.Add(new Vector3(3091.301 , 4821.93 , 1.027218 , "None"));
Path.Add(new Vector3(3098.286 , 4821.623 , 1.295819 , "None"));
Path.Add(new Vector3(3106.406 , 4823.607 , 1.215101 , "None"));
Path.Add(new Vector3(3114.859 , 4825.673 , 1.433693 , "None"));
Path.Add(new Vector3(3122.789 , 4827.286 , 1.747508 , "None"));
Path.Add(new Vector3(3129.053 , 4826.124 , 2.881665 , "None"));
Path.Add(new Vector3(3131.021 , 4831.009 , 2.80031 , "None"));
Path.Add(new Vector3(3136.993 , 4827.353 , 2.409689 , "None"));
Path.Add(new Vector3(3140.573 , 4824.168 , 2.310546 , "None"));
Path.Add(new Vector3(3137.766 , 4814.226 , 2.282704 , "None"));
Path.Add(new Vector3(3130.42 , 4810.265 , 1.493562 , "None"));
Path.Add(new Vector3(3122.096 , 4808.908 , 1.191108 , "None"));
Path.Add(new Vector3(3113.791 , 4807.554 , 2.404155 , "None"));
Path.Add(new Vector3(3105.484 , 4806.199 , 1.913011 , "None"));
Path.Add(new Vector3(3099.438 , 4805.203 , 1.220937 , "None"));
Path.Add(new Vector3(3096.579 , 4801.976 , 2.592935 , "None"));
Path.Add(new Vector3(3101.231 , 4797.121 , 2.01687 , "None"));
Path.Add(new Vector3(3105.12 , 4806.781 , 1.805391 , "None"));
Path.Add(new Vector3(3105.756 , 4812.644 , 1.199074 , "None"));
Path.Add(new Vector3(3106.969 , 4823.833 , 1.219372 , "None"));
Path.Add(new Vector3(3107.877 , 4832.202 , 1.21928 , "None"));
Path.Add(new Vector3(3108.786 , 4840.586 , 1.21928 , "None"));
Path.Add(new Vector3(3109.724 , 4849.238 , 1.452866 , "None"));
Path.Add(new Vector3(3110.632 , 4857.605 , 1.819782 , "None"));
Path.Add(new Vector3(3104.681 , 4859.225 , 2.962825 , "None"));
Path.Add(new Vector3(3096.157 , 4857.471 , 2.994054 , "None"));
Path.Add(new Vector3(3088.456 , 4855.886 , 2.763198 , "None"));
Path.Add(new Vector3(3080.34 , 4851.89 , 3.057966 , "None"));
Path.Add(new Vector3(3073.681 , 4846.714 , 3.631352 , "None"));
Path.Add(new Vector3(3067.142 , 4841.631 , 4.140018 , "None"));
Path.Add(new Vector3(3061.071 , 4836.904 , 3.848178 , "None"));
Path.Add(new Vector3(3060.706 , 4831.324 , 3.463876 , "None"));
Path.Add(new Vector3(3066.454 , 4822.849 , 1.985724 , "None"));
Path.Add(new Vector3(3063.014 , 4815.723 , 1.212223 , "None"));
Path.Add(new Vector3(3058.327 , 4808.055 , 1.324698 , "None"));
Path.Add(new Vector3(3065.229 , 4806.253 , 1.018458 , "None"));
Path.Add(new Vector3(3073.779 , 4806.109 , 1.066199 , "None"));
Path.Add(new Vector3(3082.48 , 4805.962 , 1.220678 , "None"));
Path.Add(new Vector3(3088.376 , 4805.862 , 1.220678 , "None"));
Path.Add(new Vector3(3093.684 , 4806.477 , 1.559991 , "None"));
Path.Add(new Vector3(3100.885 , 4804.432 , 1.323516 , "None"));
Path.Add(new Vector3(3096.999 , 4802.892 , 1.220954 , "None"));
Path.Add(new Vector3(3100.614 , 4800.235 , 1.279681 , "None"));
Path.Add(new Vector3(3096.19 , 4795.813 , 1.806363 , "None"));
Path.Add(new Vector3(3092.744 , 4798.5 , 1.887733 , "None"));
Path.Add(new Vector3(3084.482 , 4801.269 , 1.184324 , "None"));
Path.Add(new Vector3(3077.637 , 4803.563 , 1.134463 , "None"));
Path.Add(new Vector3(3069.641 , 4806.243 , 1.018323 , "None"));
Path.Add(new Vector3(3062.215 , 4808.732 , 1.060961 , "None"));
Path.Add(new Vector3(3058.246 , 4810.063 , 1.331176 , "None"));
Path.Add(new Vector3(3063.904 , 4809.588 , 1.018262 , "None"));
Path.Add(new Vector3(3070.638 , 4808.889 , 1.018262 , "None"));
Path.Add(new Vector3(3081.032 , 4807.81 , 1.205973 , "None"));
Path.Add(new Vector3(3089.354 , 4806.945 , 1.220756 , "None"));
Path.Add(new Vector3(3096.832 , 4806.192 , 1.815002 , "None"));
Path.Add(new Vector3(3103.265 , 4805.233 , 1.594444 , "None"));
Path.Add(new Vector3(3114.191 , 4803.248 , 5.488616 , "None"));
Path.Add(new Vector3(3122.339 , 4801.778 , 5.126077 , "None"));
Path.Add(new Vector3(3128.429 , 4806.133 , 1.849072 , "None"));
Path.Add(new Vector3(3132.917 , 4804.365 , 2.412695 , "None"));
Path.Add(new Vector3(3139.686 , 4801.713 , 3.932018 , "None"));
Path.Add(new Vector3(3147.24 , 4798.002 , 5.797364 , "None"));
Path.Add(new Vector3(3154.81 , 4794.283 , 6.668575 , "None"));
Path.Add(new Vector3(3144.143 , 4796.99 , 6.198071 , "None"));
Path.Add(new Vector3(3135.508 , 4799.426 , 6.337538 , "None"));
Path.Add(new Vector3(3127.667 , 4801.638 , 5.27037 , "None"));
Path.Add(new Vector3(3129.292 , 4803.815 , 2.694403 , "None"));
Path.Add(new Vector3(3129.408 , 4808.032 , 1.578676 , "None"));
Path.Add(new Vector3(3122.01 , 4811.487 , 1.316203 , "None"));
Path.Add(new Vector3(3117.667 , 4814.91 , 1.220951 , "None"));
Path.Add(new Vector3(3114.991 , 4824.578 , 1.341522 , "None"));
Path.Add(new Vector3(3112.741 , 4832.706 , 1.220617 , "None"));
Path.Add(new Vector3(3111.042 , 4838.842 , 1.221492 , "None"));
Path.Add(new Vector3(3108.85 , 4846.759 , 1.432193 , "None"));
Path.Add(new Vector3(3104.231 , 4850.351 , 1.923653 , "None"));
Path.Add(new Vector3(3096.025 , 4852.367 , 3.04805 , "None"));
Path.Add(new Vector3(3089.092 , 4854.057 , 2.899906 , "None"));
Path.Add(new Vector3(3092.814 , 4854.947 , 2.847538 , "None"));
Path.Add(new Vector3(3096.783 , 4856.171 , 3.137678 , "None"));
Path.Add(new Vector3(3102.857 , 4858.044 , 3.139696 , "None"));
Path.Add(new Vector3(3097.166 , 4855.093 , 3.244998 , "None"));
Path.Add(new Vector3(3093.655 , 4853.296 , 2.987481 , "None"));
Path.Add(new Vector3(3090.143 , 4851.499 , 2.948317 , "None"));
Path.Add(new Vector3(3086.84 , 4849.808 , 3.08823 , "None"));
Path.Add(new Vector3(3082.285 , 4847.477 , 3.200463 , "None"));
Path.Add(new Vector3(3076.495 , 4844.513 , 3.942559 , "None"));
Path.Add(new Vector3(3072.74 , 4842.591 , 4.195656 , "None"));
Path.Add(new Vector3(3069.304 , 4840.832 , 4.120044 , "None"));
Path.Add(new Vector3(3065.155 , 4837.835 , 4.022637 , "None"));
Path.Add(new Vector3(3060.374 , 4836.188 , 3.850832 , "None"));
Path.Add(new Vector3(3063.445 , 4829.017 , 3.126978 , "None"));
Path.Add(new Vector3(3066.943 , 4821.563 , 1.838158 , "None"));
Path.Add(new Vector3(3063.285 , 4815.35 , 1.210755 , "None"));
Path.Add(new Vector3(3059.5 , 4809.797 , 1.31602 , "None"));
Path.Add(new Vector3(3070.353 , 4807.313 , 1.018424 , "None"));
Path.Add(new Vector3(3078.489 , 4806.88 , 1.158744 , "None"));
Path.Add(new Vector3(3087.464 , 4806.404 , 1.220092 , "None"));
Path.Add(new Vector3(3095.886 , 4805.957 , 1.966992 , "None"));
Path.Add(new Vector3(3100.844 , 4804.23 , 1.32707 , "None"));
Path.Add(new Vector3(3096.933 , 4803.75 , 1.221024 , "None"));
Path.Add(new Vector3(3103.001 , 4801.33 , 1.499745 , "None"));
Path.Add(new Vector3(3105.804 , 4812.132 , 1.242379 , "None"));
Path.Add(new Vector3(3106.695 , 4820.518 , 1.218161 , "None"));
Path.Add(new Vector3(3107.587 , 4828.904 , 1.220427 , "None"));
Path.Add(new Vector3(3108.491 , 4837.408 , 1.220427 , "None"));
Path.Add(new Vector3(3109.26 , 4844.642 , 1.343829 , "None"));
Path.Add(new Vector3(3110.292 , 4854.348 , 1.903118 , "None"));
Path.Add(new Vector3(3109.827 , 4860.749 , 2.196889 , "None"));
Path.Add(new Vector3(3100.483 , 4858.862 , 3.003653 , "None"));
Path.Add(new Vector3(3092.67 , 4857.005 , 2.778721 , "None"));
Path.Add(new Vector3(3085.707 , 4855.35 , 2.736754 , "None"));
Path.Add(new Vector3(3080.182 , 4851.763 , 3.077956 , "None"));
Path.Add(new Vector3(3072.299 , 4845.634 , 3.76391 , "None"));
Path.Add(new Vector3(3065.641 , 4840.458 , 4.168707 , "None"));
Path.Add(new Vector3(3060.24 , 4834.543 , 3.759685 , "None"));
Path.Add(new Vector3(3064.712 , 4827.433 , 2.966 , "None"));
Path.Add(new Vector3(3065.929 , 4819.802 , 1.52944 , "None"));
Path.Add(new Vector3(3061.331 , 4812.712 , 1.184035 , "None"));
Path.Add(new Vector3(3058.26 , 4807.977 , 1.328495 , "None"));
Path.Add(new Vector3(3064.55 , 4805.826 , 1.018569 , "None"));
Path.Add(new Vector3(3073.252 , 4805.78 , 1.040344 , "None"));
Path.Add(new Vector3(3081.686 , 4805.737 , 1.219001 , "None"));
Path.Add(new Vector3(3090.119 , 4805.693 , 1.22104 , "None"));
Path.Add(new Vector3(3096.541 , 4806.209 , 1.617662 , "None"));
Path.Add(new Vector3(3101.123 , 4805.659 , 1.318834 , "None"));
Path.Add(new Vector3(3096.974 , 4803.217 , 1.220456 , "None"));
Path.Add(new Vector3(3100.917 , 4804.387 , 1.330075 , "None"));
Path.Add(new Vector3(3102.036 , 4809.571 , 1.278586 , "None"));
Path.Add(new Vector3(3103.498 , 4817.928 , 1.21746 , "None"));
Path.Add(new Vector3(3104.939 , 4826.169 , 1.207057 , "None"));
Path.Add(new Vector3(3106.441 , 4834.758 , 1.220919 , "None"));
Path.Add(new Vector3(3107.892 , 4843.054 , 1.28972 , "None"));
Path.Add(new Vector3(3109.345 , 4851.361 , 1.827359 , "None"));
Path.Add(new Vector3(3110.749 , 4859.388 , 1.818296 , "None"));
Path.Add(new Vector3(3105.842 , 4860.616 , 2.74788 , "None"));
Path.Add(new Vector3(3097.694 , 4858.494 , 2.966513 , "None"));
Path.Add(new Vector3(3089.549 , 4856.372 , 2.727063 , "None"));
Path.Add(new Vector3(3081.897 , 4852.597 , 2.985213 , "None"));
Path.Add(new Vector3(3075.796 , 4847.992 , 3.56177 , "None"));
Path.Add(new Vector3(3068.206 , 4842.263 , 4.051879 , "None"));
Path.Add(new Vector3(3061.475 , 4837.183 , 3.861376 , "None"));
Path.Add(new Vector3(3063.755 , 4829.807 , 3.207861 , "None"));
Path.Add(new Vector3(3066.585 , 4822.798 , 2.016757 , "None"));
Path.Add(new Vector3(3062.698 , 4814.555 , 1.183698 , "None"));
Path.Add(new Vector3(3059.087 , 4807.638 , 1.225085 , "None"));
Path.Add(new Vector3(3066.235 , 4805.975 , 1.018802 , "None"));
Path.Add(new Vector3(3069.947 , 4797.213 , 1.134265 , "None"));
Path.Add(new Vector3(3073.486 , 4789.245 , 1.134265 , "None"));
Path.Add(new Vector3(3077.024 , 4781.275 , 1.022051 , "None"));
Path.Add(new Vector3(3079.983 , 4774.612 , 1.117173 , "None"));
Path.Add(new Vector3(3085.325 , 4775.208 , 1.123385 , "None"));
Path.Add(new Vector3(3083.674 , 4771.833 , 1.129968 , "None"));
Path.Add(new Vector3(3083.037 , 4767.945 , 1.68312 , "None"));
Path.Add(new Vector3(3082.618 , 4763.837 , 1.265075 , "None"));
Path.Add(new Vector3(3081.477 , 4760.213 , 1.095258 , "None"));
Path.Add(new Vector3(3078.999 , 4752.381 , 1.018616 , "None"));
Path.Add(new Vector3(3077.746 , 4748.404 , 1.018616 , "None"));
Path.Add(new Vector3(3076.531 , 4744.55 , 1.018616 , "None"));
Path.Add(new Vector3(3075.32 , 4740.703 , 1.018616 , "None"));
Path.Add(new Vector3(3074.144 , 4736.972 , 1.236061 , "None"));
Path.Add(new Vector3(3072.849 , 4732.864 , 1.786917 , "None"));
Path.Add(new Vector3(3070.622 , 4725.793 , 2.573242 , "None"));
Path.Add(new Vector3(3069.188 , 4721.244 , 3.054201 , "None"));
Path.Add(new Vector3(3065.839 , 4722.476 , 2.317573 , "None"));
Path.Add(new Vector3(3062.014 , 4723.839 , 0.9744586 , "None"));
Path.Add(new Vector3(3058.597 , 4724.888 , 1.190086 , "None"));
Path.Add(new Vector3(3061.29 , 4730.49 , 0.9706575 , "None"));
Path.Add(new Vector3(3063.597 , 4734.212 , 2.18332 , "None"));
Path.Add(new Vector3(3066.218 , 4738.44 , 2.217127 , "None"));
Path.Add(new Vector3(3068.322 , 4741.833 , 1.788901 , "None"));
Path.Add(new Vector3(3070.545 , 4745.419 , 1.045123 , "None"));
Path.Add(new Vector3(3072.598 , 4748.73 , 1.0184 , "None"));
Path.Add(new Vector3(3074.447 , 4751.713 , 1.0184 , "None"));
Path.Add(new Vector3(3076.644 , 4755.257 , 1.0184 , "None"));
Path.Add(new Vector3(3079.198 , 4759.376 , 1.0184 , "None"));
Path.Add(new Vector3(3081.338 , 4762.884 , 1.098213 , "None"));
Path.Add(new Vector3(3082.856 , 4766.71 , 1.908036 , "None"));
Path.Add(new Vector3(3082.151 , 4770.753 , 1.143915 , "None"));
Path.Add(new Vector3(3081.283 , 4774.758 , 1.059481 , "None"));
Path.Add(new Vector3(3080.423 , 4778.723 , 1.104071 , "None"));
Path.Add(new Vector3(3079.556 , 4782.719 , 1.127553 , "None"));
Path.Add(new Vector3(3078.69 , 4786.716 , 1.134903 , "None"));
Path.Add(new Vector3(3077.828 , 4790.689 , 1.134903 , "None"));
Path.Add(new Vector3(3076.972 , 4794.638 , 1.134903 , "None"));
Path.Add(new Vector3(3076.115 , 4798.587 , 1.134903 , "None"));
Path.Add(new Vector3(3075.232 , 4802.663 , 1.134903 , "None"));
Path.Add(new Vector3(3074.375 , 4806.612 , 1.099222 , "None"));
Path.Add(new Vector3(3073.49 , 4810.695 , 1.052842 , "None"));
Path.Add(new Vector3(3072.635 , 4814.636 , 1.209452 , "None"));
Path.Add(new Vector3(3071.893 , 4818.059 , 1.220965 , "None"));
Path.Add(new Vector3(3070.895 , 4822.661 , 1.220965 , "None"));
Path.Add(new Vector3(3069.56 , 4827.547 , 1.424818 , "None"));
Path.Add(new Vector3(3069.222 , 4831.59 , 2.80772 , "None"));
Path.Add(new Vector3(3068.859 , 4835.906 , 3.91895 , "None"));
Path.Add(new Vector3(3068.512 , 4840.021 , 4.061753 , "None"));
Path.Add(new Vector3(3068.173 , 4844.048 , 3.645803 , "None"));
Path.Add(new Vector3(3067.823 , 4848.211 , 2.473532 , "None"));
Path.Add(new Vector3(3067.529 , 4851.692 , 1.989743 , "None"));
Path.Add(new Vector3(3067.168 , 4855.984 , 1.505793 , "None"));
Path.Add(new Vector3(3066.852 , 4859.73 , 0.6568025 , "None"));
Path.Add(new Vector3(3066.479 , 4864.166 , 0.3965245 , "None"));
Path.Add(new Vector3(3066.116 , 4868.466 , 0.3965245 , "None"));
Path.Add(new Vector3(3065.565 , 4875.011 , 0.3965245 , "None"));
Path.Add(new Vector3(3064.876 , 4883.193 , 0.3965245 , "None"));
Path.Add(new Vector3(3064.525 , 4887.356 , 0.3965245 , "None"));
Path.Add(new Vector3(3064.22 , 4890.982 , 0.3965245 , "None"));
Path.Add(new Vector3(3063.846 , 4895.418 , 0.3965245 , "None"));
Path.Add(new Vector3(3063.524 , 4899.245 , 0.3965245 , "None"));
Path.Add(new Vector3(3061.1 , 4904.07 , 0.6148939 , "None"));
Path.Add(new Vector3(3053.652 , 4906.754 , 1.029517 , "None"));
Path.Add(new Vector3(3048.879 , 4908.473 , 1.531837 , "None"));
Path.Add(new Vector3(3037.988 , 4912.394 , 2.07317 , "None"));
Path.Add(new Vector3(3029.5 , 4915.45 , 2.203858 , "None"));
Path.Add(new Vector3(3021.833 , 4918.21 , 0.3966337 , "None"));
Path.Add(new Vector3(3017.415 , 4918.539 , 0.3966337 , "None"));
Path.Add(new Vector3(3007.629 , 4918.282 , 0.3966337 , "None"));
Path.Add(new Vector3(3001.387 , 4919.353 , 0.3966337 , "None"));
Path.Add(new Vector3(2992.131 , 4920.941 , 0.3966337 , "None"));
Path.Add(new Vector3(2982.063 , 4922.668 , 2.417296 , "None"));
Path.Add(new Vector3(2973.056 , 4924.213 , 2.184944 , "None"));
Path.Add(new Vector3(2964.512 , 4925.679 , 4.510164 , "None"));
Path.Add(new Vector3(2956.465 , 4927.06 , 4.91437 , "None"));
Path.Add(new Vector3(2951.497 , 4927.912 , 4.561458 , "None"));
Path.Add(new Vector3(2939.956 , 4929.892 , 1.948376 , "None"));
Path.Add(new Vector3(2932.207 , 4931.222 , 2.207783 , "None"));
Path.Add(new Vector3(2923.895 , 4932.647 , 2.165711 , "None"));
Path.Add(new Vector3(2917.747 , 4933.703 , 2.561965 , "None"));
Path.Add(new Vector3(2913.788 , 4934.382 , 2.561965 , "None"));
Path.Add(new Vector3(2918.809 , 4931.833 , 2.561965 , "None"));
Path.Add(new Vector3(2918.021 , 4925.46 , 2.561889 , "None"));
Path.Add(new Vector3(2911.874 , 4923.534 , 2.561889 , "None"));
Path.Add(new Vector3(2904.581 , 4923.824 , 2.044171 , "None"));
Path.Add(new Vector3(2899.732 , 4923.223 , 2.380215 , "None"));
Path.Add(new Vector3(2896.905 , 4925.292 , 2.6543 , "None"));
Path.Add(new Vector3(2893.041 , 4922.586 , 3.229393 , "None"));
Path.Add(new Vector3(2887.162 , 4917.089 , 2.416449 , "None"));
Path.Add(new Vector3(2881.918 , 4911.029 , 2.539067 , "None"));
Path.Add(new Vector3(2879.335 , 4904.778 , 2.684373 , "None"));
Path.Add(new Vector3(2880.61 , 4896.017 , 2.335306 , "None"));
Path.Add(new Vector3(2883.149 , 4889.704 , 1.886064 , "None"));
Path.Add(new Vector3(2885.799 , 4883.146 , 2.2486 , "None"));
Path.Add(new Vector3(2889.482 , 4875.616 , 1.907773 , "None"));
Path.Add(new Vector3(2892.176 , 4870.107 , 1.06357 , "None"));
Path.Add(new Vector3(2897.025 , 4860.192 , 0.3964618 , "None"));
Path.Add(new Vector3(2900.457 , 4853.174 , 0.3964618 , "None"));
Path.Add(new Vector3(2904.288 , 4845.342 , 0.3964618 , "None"));
Path.Add(new Vector3(2906.568 , 4840.679 , 0.3964618 , "None"));
Path.Add(new Vector3(2900.408 , 4838.643 , 0.3964618 , "None"));
Path.Add(new Vector3(2896.608 , 4837.749 , 0.3964618 , "None"));
Path.Add(new Vector3(2893.066 , 4836.916 , 0.3964618 , "None"));
Path.Add(new Vector3(2888.826 , 4835.919 , 0.3604467 , "None"));
Path.Add(new Vector3(2885.448 , 4835.124 , -1.842562 , "Swimming"));
Path.Add(new Vector3(2884.983 , 4839.24 , -1.5223 , "Swimming"));
Path.Add(new Vector3(2884.364 , 4844.417 , 0.396394 , "None"));
Path.Add(new Vector3(2884.744 , 4848.303 , 0.396394 , "None"));
Path.Add(new Vector3(2885.155 , 4852.51 , 0.396394 , "None"));
Path.Add(new Vector3(2885.817 , 4859.36 , 0.396394 , "None"));
Path.Add(new Vector3(2886.203 , 4863.343 , 0.396394 , "None"));
Path.Add(new Vector3(2886.63 , 4867.757 , 0.4051757 , "None"));
Path.Add(new Vector3(2884.516 , 4873.864 , 1.511904 , "None"));
Path.Add(new Vector3(2880.486 , 4878.132 , 1.802846 , "None"));
Path.Add(new Vector3(2874.72 , 4884.24 , 2.095973 , "None"));
Path.Add(new Vector3(2869.678 , 4890.135 , 2.466361 , "None"));
Path.Add(new Vector3(2869.115 , 4894.362 , 2.538153 , "None"));
Path.Add(new Vector3(2866.492 , 4897.359 , 2.538572 , "None"));
Path.Add(new Vector3(2862.02 , 4900.678 , 2.538583 , "None"));
Path.Add(new Vector3(2856.743 , 4900.436 , 2.538583 , "None"));
Path.Add(new Vector3(2848.906 , 4899.81 , 2.354852 , "None"));
Path.Add(new Vector3(2840.114 , 4899.108 , 1.952292 , "None"));
Path.Add(new Vector3(2831.255 , 4898.401 , 2.153693 , "None"));
Path.Add(new Vector3(2822.58 , 4897.708 , 2.552332 , "None"));
Path.Add(new Vector3(2814.843 , 4897.091 , 2.569009 , "None"));
Path.Add(new Vector3(2805.786 , 4896.368 , 2.617121 , "None"));
Path.Add(new Vector3(2797.647 , 4895.719 , 2.649781 , "None"));
Path.Add(new Vector3(2788.738 , 4895.008 , 2.605613 , "None"));
Path.Add(new Vector3(2780.365 , 4894.339 , 2.065584 , "None"));
Path.Add(new Vector3(2771.606 , 4893.64 , 0.3972854 , "None"));
Path.Add(new Vector3(2763.199 , 4892.969 , 0.3972854 , "None"));
Path.Add(new Vector3(2754.792 , 4892.298 , 0.3972854 , "None"));
Path.Add(new Vector3(2746.218 , 4891.614 , 0.3972854 , "None"));
Path.Add(new Vector3(2737.711 , 4890.935 , 0.3972854 , "None"));
Path.Add(new Vector3(2729.287 , 4890.262 , 0.3972854 , "None"));
Path.Add(new Vector3(2721.751 , 4889.661 , 0.3972854 , "None"));
Path.Add(new Vector3(2712.507 , 4888.923 , 0.3972854 , "None"));
Path.Add(new Vector3(2708.889 , 4888.635 , 1.66074 , "None"));
Path.Add(new Vector3(2705.953 , 4886.075 , 1.939316 , "None"));
Path.Add(new Vector3(2697.578 , 4885.246 , 3.359526 , "None"));
Path.Add(new Vector3(2689.937 , 4884.49 , 3.700922 , "None"));
Path.Add(new Vector3(2680.508 , 4883.556 , 4.685395 , "None"));
Path.Add(new Vector3(2672.55 , 4882.768 , 4.258877 , "None"));
Path.Add(new Vector3(2663.456 , 4881.868 , 3.199493 , "None"));
Path.Add(new Vector3(2659.409 , 4880.012 , 2.087251 , "None"));
Path.Add(new Vector3(2652.589 , 4879.53 , 1.670022 , "None"));
Path.Add(new Vector3(2642.802 , 4878.84 , 1.953935 , "None"));
Path.Add(new Vector3(2633.266 , 4878.167 , 1.790635 , "None"));
Path.Add(new Vector3(2624.703 , 4877.563 , -1.964936 , "None"));
Path.Add(new Vector3(2621.072 , 4877.307 , -2.415478 , "Swimming"));
Path.Add(new Vector3(2616.342 , 4876.973 , -2.387564 , "Swimming"));
Path.Add(new Vector3(2611.538 , 4876.634 , -2.359206 , "Swimming"));
Path.Add(new Vector3(2606.892 , 4875.848 , -2.336539 , "Swimming"));
Path.Add(new Vector3(2610.737 , 4875.992 , -2.184078 , "Swimming"));
Path.Add(new Vector3(2615.515 , 4876.602 , -2.161222 , "Swimming"));
Path.Add(new Vector3(2620.293 , 4877.211 , -2.161222 , "Swimming"));
Path.Add(new Vector3(2626.326 , 4877.972 , -0.8992518 , "None"));
Path.Add(new Vector3(2629.56 , 4878.385 , 0.7349055 , "None"));
Path.Add(new Vector3(2623.9 , 4876.611 , -2.564666 , "Swimming"));
Path.Add(new Vector3(2618.981 , 4876.528 , -2.725721 , "Swimming"));
Path.Add(new Vector3(2614.332 , 4876.45 , -2.585786 , "Swimming"));
Path.Add(new Vector3(2609.438 , 4876.372 , -2.438464 , "Swimming"));
Path.Add(new Vector3(2604.795 , 4875.116 , -2.41734 , "Swimming"));
Path.Add(new Vector3(2600.439 , 4873.796 , -2.403434 , "Swimming"));
Path.Add(new Vector3(2595.607 , 4872.333 , -2.388014 , "Swimming"));
Path.Add(new Vector3(2591.047 , 4870.951 , -2.373459 , "Swimming"));
Path.Add(new Vector3(2586.51 , 4869.577 , -2.358977 , "Swimming"));
Path.Add(new Vector3(2583.016 , 4868.519 , -2.347826 , "Swimming"));
Path.Add(new Vector3(2579.402 , 4865.188 , -2.292674 , "Swimming"));
Path.Add(new Vector3(2577.024 , 4861.185 , -2.23904 , "Swimming"));
Path.Add(new Vector3(2575.663 , 4856.688 , -2.178011 , "Swimming"));
Path.Add(new Vector3(2578.032 , 4852.875 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2581.954 , 4850.487 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2586.131 , 4848.108 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2590.32 , 4845.722 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2594.677 , 4847.284 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2597.943 , 4850.465 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2600.046 , 4846.104 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2602.054 , 4841.882 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2604.075 , 4837.63 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2606.124 , 4833.323 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2608.227 , 4828.9 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2609.991 , 4825.19 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2612.331 , 4820.269 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2614.4 , 4815.919 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2616.436 , 4811.637 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2618.368 , 4807.573 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2620.404 , 4803.292 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2622.606 , 4798.66 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2624.541 , 4794.592 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2626.705 , 4790.041 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2628.78 , 4785.679 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2630.373 , 4782.327 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2632.795 , 4777.234 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2634.867 , 4772.876 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2636.871 , 4768.663 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2640.275 , 4765.78 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2644.141 , 4762.906 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2647.946 , 4760.077 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2651.811 , 4757.204 , -2.160917 , "Swimming"));
Path.Add(new Vector3(2654.893 , 4754.913 , -1.548189 , "Swimming"));
Path.Add(new Vector3(2657.761 , 4752.556 , -1.524262 , "Swimming"));
Path.Add(new Vector3(2652.373 , 4752.342 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2647.816 , 4753.666 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2644.606 , 4756.799 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2640.927 , 4760.861 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2638.213 , 4764.749 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2635.564 , 4768.578 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2632.733 , 4772.671 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2630.479 , 4775.93 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2627.518 , 4780.209 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2624.802 , 4784.136 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2622.124 , 4788.008 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2619.206 , 4792.225 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2616.509 , 4796.124 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2613.535 , 4800.423 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2611.262 , 4803.709 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2608.106 , 4808.272 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2604.817 , 4813.025 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2602.08 , 4816.983 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2599.42 , 4820.828 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2596.575 , 4824.94 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2593.996 , 4828.668 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2590.414 , 4831.622 , -1.523457 , "Swimming"));
Path.Add(new Vector3(2588.109 , 4834.898 , -1.602662 , "Swimming"));
Path.Add(new Vector3(2585.567 , 4839.006 , -1.568643 , "Swimming"));
Path.Add(new Vector3(2583.059 , 4843.058 , -1.53509 , "Swimming"));
Path.Add(new Vector3(2580.522 , 4847.157 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2578.03 , 4851.185 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2575.838 , 4854.727 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2576.603 , 4860.434 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2579.073 , 4864.383 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2582.344 , 4867.789 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2586.921 , 4869.302 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2591.495 , 4870.813 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2595.992 , 4872.3 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2600.637 , 4873.835 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2605.125 , 4875.318 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2609.322 , 4876.428 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2613.869 , 4876.98 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2618.81 , 4877.58 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2623.591 , 4878.161 , -1.523752 , "Swimming"));
Path.Add(new Vector3(2629.798 , 4878.91 , 0.8705376 , "None"));
Path.Add(new Vector3(2623.771 , 4876.834 , -2.413204 , "Swimming"));
Path.Add(new Vector3(2618.877 , 4876.676 , -2.349226 , "Swimming"));
Path.Add(new Vector3(2614.139 , 4876.523 , -2.284502 , "Swimming"));
Path.Add(new Vector3(2609.325 , 4876.368 , -2.218746 , "Swimming"));
Path.Add(new Vector3(2605.794 , 4875.367 , -2.204479 , "Swimming"));
Path.Add(new Vector3(2610.657 , 4875.549 , -2.161551 , "Swimming"));
Path.Add(new Vector3(2615.718 , 4876.215 , -2.161551 , "Swimming"));
Path.Add(new Vector3(2620.418 , 4876.835 , -2.161551 , "Swimming"));
Path.Add(new Vector3(2626.723 , 4877.659 , -0.7462809 , "None"));
Path.Add(new Vector3(2632.494 , 4878.419 , 1.653501 , "None"));
Path.Add(new Vector3(2624.616 , 4876.706 , -2.172579 , "Swimming"));
Path.Add(new Vector3(2619.877 , 4876.61 , -2.161807 , "Swimming"));
Path.Add(new Vector3(2615.061 , 4876.513 , -2.161807 , "Swimming"));
Path.Add(new Vector3(2610.406 , 4876.418 , -2.161807 , "Swimming"));
Path.Add(new Vector3(2605.655 , 4875.398 , -2.161807 , "Swimming"));
Path.Add(new Vector3(2611.607 , 4875.693 , -2.161807 , "Swimming"));
Path.Add(new Vector3(2616.382 , 4876.322 , -2.161807 , "Swimming"));
Path.Add(new Vector3(2620.854 , 4876.91 , -2.161807 , "Swimming"));
Path.Add(new Vector3(2628.966 , 4877.968 , 0.4467734 , "None"));
Path.Add(new Vector3(2632.788 , 4878.471 , 1.738352 , "None"));
Path.Add(new Vector3(2624.833 , 4876.913 , -2.032689 , "None"));
Path.Add(new Vector3(2620.023 , 4876.76 , -2.51637 , "Swimming"));
Path.Add(new Vector3(2615.21 , 4876.607 , -2.400886 , "Swimming"));
Path.Add(new Vector3(2610.473 , 4876.457 , -2.287213 , "Swimming"));
Path.Add(new Vector3(2615.426 , 4877.64 , -2.160987 , "Swimming"));
Path.Add(new Vector3(2619.319 , 4878.094 , -2.160987 , "Swimming"));
Path.Add(new Vector3(2624.003 , 4878.634 , -2.134517 , "Swimming"));
Path.Add(new Vector3(2631.131 , 4879.419 , 1.352316 , "None"));
Path.Add(new Vector3(2639.792 , 4880.43 , 2.71837 , "None"));
Path.Add(new Vector3(2646.767 , 4881.244 , 2.588303 , "None"));
Path.Add(new Vector3(2656.529 , 4882.382 , 2.619787 , "None"));
Path.Add(new Vector3(2663.587 , 4883.209 , 3.666122 , "None"));
Path.Add(new Vector3(2670.958 , 4882.057 , 3.894611 , "None"));
Path.Add(new Vector3(2675.23 , 4878.102 , 2.66857 , "None"));
Path.Add(new Vector3(2667.79 , 4877.907 , 2.303253 , "None"));
Path.Add(new Vector3(2657.764 , 4877.645 , 1.447204 , "None"));
Path.Add(new Vector3(2651.382 , 4877.478 , 0.7326329 , "None"));
Path.Add(new Vector3(2642.935 , 4877.257 , 1.025068 , "None"));
Path.Add(new Vector3(2632.539 , 4876.985 , 1.407955 , "None"));
Path.Add(new Vector3(2624.948 , 4876.787 , -1.98587 , "None"));
Path.Add(new Vector3(2621.022 , 4876.684 , -4.066543 , "Swimming"));
Path.Add(new Vector3(2616.287 , 4876.56 , -4.033848 , "Swimming"));
Path.Add(new Vector3(2611.784 , 4876.442 , -4.00275 , "Swimming"));
Path.Add(new Vector3(2616.273 , 4877.664 , -3.674322 , "Swimming"));
Path.Add(new Vector3(2621.058 , 4878.226 , -3.47662 , "Swimming"));
Path.Add(new Vector3(2616.956 , 4877.457 , -2.262618 , "Swimming"));
Path.Add(new Vector3(2612.249 , 4876.898 , -2.185665 , "Swimming"));
Path.Add(new Vector3(2607.479 , 4876.269 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2602.859 , 4874.809 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2599.464 , 4873.736 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2594.817 , 4872.267 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2590.094 , 4870.774 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2585.614 , 4869.358 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2582.119 , 4868.199 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2578.242 , 4864.04 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2576.365 , 4859.729 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2576.17 , 4855.144 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2578.962 , 4852.274 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2582.155 , 4850.447 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2585.843 , 4848.335 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2590.548 , 4845.643 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2594.487 , 4843.388 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2598.434 , 4844.505 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2602.118 , 4843.962 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2603.842 , 4840.238 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2605.504 , 4836.646 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2607.469 , 4832.399 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2609.501 , 4828.007 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2611.492 , 4823.704 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2613.503 , 4819.358 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2615.544 , 4814.948 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2617.541 , 4810.633 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2619.145 , 4807.166 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2620.844 , 4803.493 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2623.075 , 4798.671 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2625.144 , 4794.202 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2627.087 , 4790.001 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2629.249 , 4785.33 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2631.077 , 4781.379 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2632.558 , 4778.177 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2634.714 , 4773.519 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2636.898 , 4769.288 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2640.69 , 4766.295 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2644.29 , 4763.455 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2648.071 , 4760.471 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2651.982 , 4757.385 , -2.161674 , "Swimming"));
Path.Add(new Vector3(2655.193 , 4754.851 , -2.104395 , "Swimming"));
Path.Add(new Vector3(2657.834 , 4754.845 , 0.3200568 , "None"));
Path.Add(new Vector3(2654.255 , 4753.677 , -2.166256 , "Swimming"));
Path.Add(new Vector3(2649.678 , 4752.498 , -2.100555 , "Swimming"));
Path.Add(new Vector3(2647.868 , 4757.441 , -2.004835 , "Swimming"));
Path.Add(new Vector3(2643.924 , 4759.011 , -1.921492 , "Swimming"));
Path.Add(new Vector3(2639.928 , 4761.635 , -1.832458 , "Swimming"));
Path.Add(new Vector3(2637.145 , 4765.687 , -1.828592 , "Swimming"));
Path.Add(new Vector3(2634.462 , 4769.59 , -1.824868 , "Swimming"));
Path.Add(new Vector3(2631.804 , 4773.458 , -1.821177 , "Swimming"));
Path.Add(new Vector3(2629.424 , 4776.922 , -1.817873 , "Swimming"));
Path.Add(new Vector3(2627.036 , 4780.398 , -1.814557 , "Swimming"));
Path.Add(new Vector3(2624.271 , 4784.422 , -1.810718 , "Swimming"));
Path.Add(new Vector3(2621.66 , 4788.221 , -1.807094 , "Swimming"));
Path.Add(new Vector3(2618.933 , 4792.191 , -1.803306 , "Swimming"));
Path.Add(new Vector3(2616.248 , 4796.098 , -1.799578 , "Swimming"));
Path.Add(new Vector3(2613.514 , 4800.076 , -1.795784 , "Swimming"));
Path.Add(new Vector3(2610.837 , 4803.972 , -1.792067 , "Swimming"));
Path.Add(new Vector3(2608.112 , 4807.938 , -1.788283 , "Swimming"));
Path.Add(new Vector3(2605.425 , 4811.849 , -1.784552 , "Swimming"));
Path.Add(new Vector3(2602.697 , 4815.819 , -1.780764 , "Swimming"));
Path.Add(new Vector3(2599.678 , 4820.213 , -1.776572 , "Swimming"));
Path.Add(new Vector3(2596.95 , 4824.183 , -1.772785 , "Swimming"));
Path.Add(new Vector3(2594.719 , 4827.429 , -1.769688 , "Swimming"));
Path.Add(new Vector3(2592.23 , 4831.052 , -1.766232 , "Swimming"));
Path.Add(new Vector3(2589.486 , 4835.045 , -1.762422 , "Swimming"));
Path.Add(new Vector3(2587.05 , 4838.591 , -1.759039 , "Swimming"));
Path.Add(new Vector3(2584.161 , 4842.794 , -1.755029 , "Swimming"));
Path.Add(new Vector3(2581.549 , 4846.597 , -1.751402 , "Swimming"));
Path.Add(new Vector3(2578.658 , 4850.804 , -1.747388 , "Swimming"));
Path.Add(new Vector3(2575.975 , 4854.708 , -1.743664 , "Swimming"));
Path.Add(new Vector3(2576.093 , 4858.525 , -1.669661 , "Swimming"));
Path.Add(new Vector3(2577.791 , 4862.945 , -1.611824 , "Swimming"));
Path.Add(new Vector3(2581.073 , 4866.509 , -1.560878 , "Swimming"));
Path.Add(new Vector3(2585.187 , 4868.73 , -1.533497 , "Swimming"));
Path.Add(new Vector3(2589.76 , 4870.242 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2594.123 , 4871.684 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2600.122 , 4873.666 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2604.696 , 4875.177 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2608.955 , 4876.585 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2613.412 , 4877.127 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2617.239 , 4877.584 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2621.566 , 4878.101 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2617.641 , 4877.282 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2612.907 , 4876.831 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2609.094 , 4876.467 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2613.885 , 4875.974 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2618.6 , 4876.595 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2623.296 , 4877.213 , -1.524009 , "Swimming"));
Path.Add(new Vector3(2629.311 , 4877.996 , 0.6033928 , "None"));
Path.Add(new Vector3(2632.906 , 4878.47 , 1.764905 , "None"));
Path.Add(new Vector3(2628.715 , 4876.791 , 0.1686118 , "None"));
Path.Add(new Vector3(2623.019 , 4876.674 , -2.687984 , "Swimming"));
Path.Add(new Vector3(2618.361 , 4876.578 , -2.552552 , "Swimming"));
Path.Add(new Vector3(2613.543 , 4876.478 , -2.412455 , "Swimming"));
Path.Add(new Vector3(2608.998 , 4876.387 , -2.280316 , "Swimming"));
Path.Add(new Vector3(2604.038 , 4874.989 , -2.264035 , "Swimming"));
Path.Add(new Vector3(2599.551 , 4873.61 , -2.249242 , "Swimming"));
Path.Add(new Vector3(2595.462 , 4872.352 , -2.235759 , "Swimming"));
Path.Add(new Vector3(2590.488 , 4870.823 , -2.21936 , "Swimming"));
Path.Add(new Vector3(2585.807 , 4869.383 , -2.203927 , "Swimming"));
Path.Add(new Vector3(2581.495 , 4867.39 , -2.173543 , "Swimming"));
Path.Add(new Vector3(2578.199 , 4863.952 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2576.246 , 4859.611 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2576.198 , 4855.082 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2579.728 , 4851.912 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2583.764 , 4849.591 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2587.121 , 4847.661 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2592.05 , 4844.827 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2595.301 , 4842.958 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2598.31 , 4845.592 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2602.267 , 4843.527 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2604.058 , 4839.662 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2606.317 , 4834.786 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2608.209 , 4830.703 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2610.236 , 4826.328 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2612.36 , 4821.744 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2614.234 , 4817.699 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2616.422 , 4812.978 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2618.33 , 4808.86 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2620.228 , 4804.764 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2622.253 , 4800.394 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2624.383 , 4795.796 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2626.305 , 4791.648 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2628.024 , 4787.938 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2630.391 , 4782.831 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2632.376 , 4778.546 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2634.173 , 4774.668 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2636.053 , 4770.611 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2638.857 , 4767.066 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2642.701 , 4764.163 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2646.48 , 4761.309 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2650.2 , 4758.5 , -2.160932 , "Swimming"));
Path.Add(new Vector3(2654.035 , 4755.604 , -2.032698 , "Swimming"));
Path.Add(new Vector3(2657.638 , 4752.882 , -1.524413 , "Swimming"));
Path.Add(new Vector3(2654.182 , 4751.989 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2649.276 , 4752.578 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2645.761 , 4755.877 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2642.596 , 4758.854 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2639.46 , 4763.009 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2636.554 , 4767.206 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2634.02 , 4770.868 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2631.907 , 4773.919 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2628.666 , 4778.602 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2625.924 , 4782.563 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2623.229 , 4786.457 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2620.621 , 4790.223 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2617.743 , 4794.381 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2615.378 , 4797.798 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2612.3 , 4802.244 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2609.561 , 4806.2 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2606.865 , 4810.095 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2604.662 , 4813.279 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2601.517 , 4817.821 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2599.157 , 4821.23 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2596.416 , 4825.191 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2593.672 , 4829.155 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2591.29 , 4832.595 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2588.896 , 4836.055 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2586.017 , 4840.213 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2583.413 , 4843.976 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2580.598 , 4848.041 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2577.835 , 4852.032 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2576.029 , 4855.042 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2576.613 , 4859.587 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2578.691 , 4864.005 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2581.93 , 4867.467 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2586.348 , 4869.211 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2590.676 , 4870.624 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2595.304 , 4872.134 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2599.829 , 4873.61 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2604.211 , 4875.041 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2608.085 , 4876.305 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2612.789 , 4876.889 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2617.022 , 4877.401 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2622.615 , 4878.079 , -1.524078 , "Swimming"));
Path.Add(new Vector3(2626.154 , 4878.499 , -0.9076478 , "None"));
Path.Add(new Vector3(2621.882 , 4876.835 , -3.642008 , "Swimming"));
Path.Add(new Vector3(2617.127 , 4876.661 , -3.49806 , "Swimming"));
Path.Add(new Vector3(2612.335 , 4876.485 , -3.35297 , "Swimming"));
Path.Add(new Vector3(2607.657 , 4875.987 , -3.245633 , "Swimming"));
Path.Add(new Vector3(2603.025 , 4874.583 , -3.232092 , "Swimming"));
Path.Add(new Vector3(2598.433 , 4873.192 , -3.21867 , "Swimming"));
Path.Add(new Vector3(2593.973 , 4871.84 , -3.205631 , "Swimming"));
Path.Add(new Vector3(2589.286 , 4870.42 , -3.191931 , "Swimming"));
Path.Add(new Vector3(2584.667 , 4869.02 , -3.17843 , "Swimming"));
Path.Add(new Vector3(2580.73 , 4866.503 , -3.139469 , "Swimming"));
Path.Add(new Vector3(2577.735 , 4862.814 , -3.083636 , "Swimming"));
Path.Add(new Vector3(2575.945 , 4858.43 , -3.033003 , "Swimming"));
Path.Add(new Vector3(2576.455 , 4854.681 , -2.959163 , "Swimming"));
Path.Add(new Vector3(2580.684 , 4851.265 , -2.900798 , "Swimming"));
Path.Add(new Vector3(2584.866 , 4848.875 , -2.888772 , "Swimming"));
Path.Add(new Vector3(2589.052 , 4846.482 , -2.876734 , "Swimming"));
Path.Add(new Vector3(2593.164 , 4844.132 , -2.864908 , "Swimming"));
Path.Add(new Vector3(2597.276 , 4841.782 , -2.853081 , "Swimming"));
Path.Add(new Vector3(2601.458 , 4839.392 , -2.841055 , "Swimming"));
Path.Add(new Vector3(2605.505 , 4837.079 , -2.829417 , "Swimming"));
Path.Add(new Vector3(2609.997 , 4835.366 , -2.819284 , "Swimming"));
Path.Add(new Vector3(2613.95 , 4834.864 , -2.813622 , "Swimming"));
Path.Add(new Vector3(2610.484 , 4838.084 , -2.740485 , "Swimming"));
Path.Add(new Vector3(2607.685 , 4835.239 , -2.627463 , "Swimming"));
Path.Add(new Vector3(2609.64 , 4830.816 , -2.622455 , "Swimming"));
Path.Add(new Vector3(2611.429 , 4826.77 , -2.617873 , "Swimming"));
Path.Add(new Vector3(2613.505 , 4822.075 , -2.612556 , "Swimming"));
Path.Add(new Vector3(2615.262 , 4818.102 , -2.608057 , "Swimming"));
Path.Add(new Vector3(2617.371 , 4813.333 , -2.602658 , "Swimming"));
Path.Add(new Vector3(2619.318 , 4808.928 , -2.59767 , "Swimming"));
Path.Add(new Vector3(2621.236 , 4804.592 , -2.592759 , "Swimming"));
Path.Add(new Vector3(2623.186 , 4800.183 , -2.587766 , "Swimming"));
Path.Add(new Vector3(2625.135 , 4795.773 , -2.582773 , "Swimming"));
Path.Add(new Vector3(2627.079 , 4791.376 , -2.577794 , "Swimming"));
Path.Add(new Vector3(2628.999 , 4787.036 , -2.572879 , "Swimming"));
Path.Add(new Vector3(2630.945 , 4782.635 , -2.567896 , "Swimming"));
Path.Add(new Vector3(2632.86 , 4778.303 , -2.56299 , "Swimming"));
Path.Add(new Vector3(2634.783 , 4773.954 , -2.558066 , "Swimming"));
Path.Add(new Vector3(2636.733 , 4769.544 , -2.553072 , "Swimming"));
Path.Add(new Vector3(2640.194 , 4766.621 , -2.251185 , "Swimming"));
Path.Add(new Vector3(2643.968 , 4763.657 , -2.161913 , "Swimming"));
Path.Add(new Vector3(2647.682 , 4760.741 , -2.161941 , "Swimming"));
Path.Add(new Vector3(2651.188 , 4757.983 , -2.161914 , "Swimming"));
Path.Add(new Vector3(2655.119 , 4754.895 , -2.042339 , "Swimming"));
Path.Add(new Vector3(2651.321 , 4752.267 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2647.467 , 4754.422 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2643.898 , 4757.65 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2640.71 , 4761.242 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2638.002 , 4765.134 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2635.258 , 4769.098 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2632.562 , 4772.992 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2629.841 , 4776.921 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2627.078 , 4780.912 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2624.425 , 4784.744 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2621.637 , 4788.77 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2618.85 , 4792.796 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2616.153 , 4796.69 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2613.5 , 4800.522 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2610.756 , 4804.486 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2607.971 , 4808.509 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2605.272 , 4812.407 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2602.53 , 4816.367 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2599.834 , 4820.261 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2597.181 , 4824.093 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2594.358 , 4828.169 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2591.662 , 4832.063 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2588.909 , 4836.039 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2586.162 , 4840.007 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2583.469 , 4843.897 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2580.724 , 4847.861 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2578.028 , 4851.755 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2575.959 , 4854.75 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2576.643 , 4859.859 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2578.795 , 4863.975 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2582.042 , 4867.54 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2586.427 , 4869.23 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2591.006 , 4870.726 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2595.661 , 4872.246 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2600.168 , 4873.718 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2604.67 , 4875.188 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2609.012 , 4876.347 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2613.713 , 4876.919 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2618.574 , 4877.512 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2623.281 , 4878.086 , -1.524039 , "Swimming"));
Path.Add(new Vector3(2629.94 , 4878.893 , 0.9124877 , "None"));
Path.Add(new Vector3(2634.167 , 4879.408 , 2.144387 , "None"));
Path.Add(new Vector3(2627.749 , 4876.964 , -0.31727 , "None"));
Path.Add(new Vector3(2624.078 , 4876.845 , -2.488152 , "Swimming"));
Path.Add(new Vector3(2618.963 , 4876.679 , -2.934287 , "Swimming"));
Path.Add(new Vector3(2614.23 , 4876.525 , -2.716923 , "Swimming"));
Path.Add(new Vector3(2609.972 , 4876.387 , -2.521426 , "Swimming"));
Path.Add(new Vector3(2614.447 , 4876.776 , -2.195297 , "Swimming"));
Path.Add(new Vector3(2619.151 , 4877.36 , -2.161079 , "Swimming"));
Path.Add(new Vector3(2623.851 , 4877.944 , -2.161079 , "Swimming"));
Path.Add(new Vector3(2631.22 , 4878.855 , 1.30447 , "None"));
Path.Add(new Vector3(2637.263 , 4879.606 , 2.544891 , "None"));
Path.Add(new Vector3(2624.272 , 4877.28 , -2.261083 , "Swimming"));
Path.Add(new Vector3(2620.687 , 4877.077 , -2.465223 , "Swimming"));
Path.Add(new Vector3(2615.563 , 4876.786 , -2.350754 , "Swimming"));
Path.Add(new Vector3(2610.539 , 4876.5 , -2.238495 , "Swimming"));
Path.Add(new Vector3(2606.556 , 4875.929 , -2.175531 , "Swimming"));
Path.Add(new Vector3(2602.267 , 4874.582 , -2.163073 , "Swimming"));
Path.Add(new Vector3(2597.821 , 4873.185 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2593.149 , 4871.718 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2588.554 , 4870.274 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2584.012 , 4868.848 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2580.288 , 4866.194 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2577.469 , 4862.283 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2575.943 , 4858.474 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2576.168 , 4854.053 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2579.549 , 4851.701 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2582.785 , 4849.875 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2586.429 , 4847.818 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2591.405 , 4845.01 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2594.683 , 4843.161 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2598.837 , 4842.848 , -2.161765 , "Swimming"));
Path.Add(new Vector3(2600.255 , 4845.578 , -0.06759983 , "None"));
Path.Add(new Vector3(2602.215 , 4842.214 , -2.161922 , "Swimming"));
Path.Add(new Vector3(2603.61 , 4838.19 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2605.584 , 4834.062 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2607.669 , 4829.7 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2609.381 , 4826.121 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2611.254 , 4822.202 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2613.379 , 4817.758 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2615.491 , 4813.34 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2617.671 , 4808.782 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2619.838 , 4804.249 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2621.877 , 4799.984 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2623.949 , 4795.651 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2625.625 , 4792.145 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2627.585 , 4788.046 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2629.799 , 4783.416 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2631.64 , 4779.564 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2633.431 , 4775.819 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2635.04 , 4772.454 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2637.093 , 4768.16 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2640.375 , 4765.648 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2644.258 , 4762.773 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2647.993 , 4760.009 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2651.928 , 4757.095 , -2.161732 , "Swimming"));
Path.Add(new Vector3(2655.777 , 4754.246 , -1.984302 , "Swimming"));
Path.Add(new Vector3(2658.701 , 4752.082 , -1.524255 , "Swimming"));
Path.Add(new Vector3(2655.303 , 4749.253 , -1.52325 , "Swimming"));
Path.Add(new Vector3(2651.822 , 4750.224 , -1.52325 , "Swimming"));
Path.Add(new Vector3(2648.12 , 4751.994 , -1.581187 , "Swimming"));
Path.Add(new Vector3(2645.219 , 4755.759 , -1.524154 , "Swimming"));
Path.Add(new Vector3(2642.784 , 4758.424 , -1.524154 , "Swimming"));
Path.Add(new Vector3(2640.162 , 4761.905 , -1.524154 , "Swimming"));
Path.Add(new Vector3(2636.451 , 4763.576 , -1.524154 , "Swimming"));
Path.Add(new Vector3(2633.942 , 4767.354 , -1.721287 , "Swimming"));
Path.Add(new Vector3(2631.729 , 4770.687 , -1.710186 , "Swimming"));
Path.Add(new Vector3(2628.795 , 4775.104 , -1.695468 , "Swimming"));
Path.Add(new Vector3(2625.747 , 4779.695 , -1.680172 , "Swimming"));
Path.Add(new Vector3(2623.119 , 4783.652 , -1.666987 , "Swimming"));
Path.Add(new Vector3(2620.752 , 4787.216 , -1.655113 , "Swimming"));
Path.Add(new Vector3(2617.771 , 4787.358 , 0.1832447 , "None"));
Path.Add(new Vector3(2614.962 , 4791.871 , -1.627463 , "Swimming"));
Path.Add(new Vector3(2612.354 , 4796.061 , -1.614291 , "Swimming"));
Path.Add(new Vector3(2609.912 , 4799.986 , -1.601951 , "Swimming"));
Path.Add(new Vector3(2607.489 , 4803.878 , -1.589711 , "Swimming"));
Path.Add(new Vector3(2604.839 , 4808.136 , -1.576325 , "Swimming"));
Path.Add(new Vector3(2602.566 , 4811.789 , -1.564842 , "Swimming"));
Path.Add(new Vector3(2606.417 , 4814.136 , -1.524256 , "Swimming"));
Path.Add(new Vector3(2605.075 , 4818.367 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2602.233 , 4822.256 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2599.617 , 4825.835 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2597.153 , 4829.008 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2594.042 , 4832.796 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2590.988 , 4836.515 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2588.087 , 4840.048 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2584.995 , 4843.814 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2581.878 , 4847.609 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2579.642 , 4850.332 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2576.142 , 4854.595 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2576.435 , 4859.001 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2578.276 , 4863.338 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2581.42 , 4866.83 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2585.295 , 4868.712 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2589.964 , 4870.266 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2594.817 , 4871.88 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2599.226 , 4873.347 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2603.456 , 4874.753 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2607.952 , 4876.249 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2612.41 , 4876.793 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2617.426 , 4877.403 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2621.898 , 4877.947 , -1.523956 , "Swimming"));
Path.Add(new Vector3(2627.725 , 4878.649 , -0.09789126 , "None"));
Path.Add(new Vector3(2631.865 , 4879.152 , 1.53418 , "None"));
Path.Add(new Vector3(2637.586 , 4879.848 , 2.604823 , "None"));
Path.Add(new Vector3(2632.911 , 4878.073 , 1.692602 , "None"));
Path.Add(new Vector3(2623.157 , 4877.398 , -3.024045 , "Swimming"));
Path.Add(new Vector3(2616.811 , 4876.96 , -3.291549 , "Swimming"));
Path.Add(new Vector3(2610.244 , 4876.506 , -3.04464 , "Swimming"));
Path.Add(new Vector3(2605.575 , 4875.439 , -2.982229 , "Swimming"));
Path.Add(new Vector3(2601.349 , 4874.144 , -2.970336 , "Swimming"));
Path.Add(new Vector3(2597.254 , 4872.889 , -2.958812 , "Swimming"));
Path.Add(new Vector3(2592.198 , 4871.338 , -2.944581 , "Swimming"));
Path.Add(new Vector3(2587.588 , 4869.925 , -2.931608 , "Swimming"));
Path.Add(new Vector3(2582.988 , 4868.515 , -2.918661 , "Swimming"));
Path.Add(new Vector3(2579.479 , 4865.321 , -2.866706 , "Swimming"));
Path.Add(new Vector3(2577.148 , 4861.469 , -2.814594 , "Swimming"));
Path.Add(new Vector3(2575.353 , 4857 , -2.762342 , "Swimming"));
Path.Add(new Vector3(2577.688 , 4853.156 , -2.670032 , "Swimming"));
Path.Add(new Vector3(2581.461 , 4850.706 , -2.641259 , "Swimming"));
Path.Add(new Vector3(2585.929 , 4848.17 , -2.62824 , "Swimming"));
Path.Add(new Vector3(2589.564 , 4846.108 , -2.61765 , "Swimming"));
Path.Add(new Vector3(2593.828 , 4843.689 , -2.605229 , "Swimming"));
Path.Add(new Vector3(2597.301 , 4841.719 , -2.594819 , "Swimming"));
Path.Add(new Vector3(2600.601 , 4843.432 , -2.534368 , "Swimming"));
Path.Add(new Vector3(2602.804 , 4838.885 , -2.530787 , "Swimming"));
Path.Add(new Vector3(2604.871 , 4834.618 , -2.527427 , "Swimming"));
Path.Add(new Vector3(2606.971 , 4830.283 , -2.524014 , "Swimming"));
Path.Add(new Vector3(2608.838 , 4826.429 , -2.520979 , "Swimming"));
Path.Add(new Vector3(2611.136 , 4821.686 , -2.517245 , "Swimming"));
Path.Add(new Vector3(2613.221 , 4817.381 , -2.513855 , "Swimming"));
Path.Add(new Vector3(2615.218 , 4813.258 , -2.510609 , "Swimming"));
Path.Add(new Vector3(2617.421 , 4808.711 , -2.507029 , "Swimming"));
Path.Add(new Vector3(2619.488 , 4804.444 , -2.503669 , "Swimming"));
Path.Add(new Vector3(2621.553 , 4800.182 , -2.500313 , "Swimming"));
Path.Add(new Vector3(2623.655 , 4795.843 , -2.496897 , "Swimming"));
Path.Add(new Vector3(2625.755 , 4791.508 , -2.493483 , "Swimming"));
Path.Add(new Vector3(2627.42 , 4788.07 , -2.490776 , "Swimming"));
Path.Add(new Vector3(2629.555 , 4783.663 , -2.487306 , "Swimming"));
Path.Add(new Vector3(2631.476 , 4779.698 , -2.484184 , "Swimming"));
Path.Add(new Vector3(2633.744 , 4775.014 , -2.480497 , "Swimming"));
Path.Add(new Vector3(2635.599 , 4771.185 , -2.477482 , "Swimming"));
Path.Add(new Vector3(2637.643 , 4767.38 , -2.441016 , "Swimming"));
Path.Add(new Vector3(2641.467 , 4764.602 , -2.161282 , "Swimming"));
Path.Add(new Vector3(2645.364 , 4761.771 , -2.161282 , "Swimming"));
Path.Add(new Vector3(2649.26 , 4758.94 , -2.161282 , "Swimming"));
Path.Add(new Vector3(2653.1 , 4756.15 , -2.161282 , "Swimming"));
Path.Add(new Vector3(2656.444 , 4755.393 , -0.2590102 , "None"));
Path.Add(new Vector3(2659.859 , 4756.706 , -1.694531 , "Swimming"));
Path.Add(new Vector3(2663.586 , 4759.204 , -1.524312 , "Swimming"));
Path.Add(new Vector3(2664.254 , 4763.836 , -1.524312 , "Swimming"));
Path.Add(new Vector3(2665.3 , 4768.042 , -1.98176 , "Swimming"));
Path.Add(new Vector3(2667.239 , 4772.304 , 0.2688036 , "None"));
Path.Add(new Vector3(2669.579 , 4776.139 , 0.4496453 , "None"));
Path.Add(new Vector3(2675.277 , 4777.761 , 1.367992 , "None"));
Path.Add(new Vector3(2676.706 , 4783.601 , 1.992385 , "None"));
Path.Add(new Vector3(2677.914 , 4787.328 , 0.6043782 , "None"));
Path.Add(new Vector3(2677.152 , 4790.948 , -1.007232 , "None"));
Path.Add(new Vector3(2677.347 , 4795.132 , -0.1574233 , "None"));
Path.Add(new Vector3(2679.711 , 4801.256 , 1.497517 , "None"));
Path.Add(new Vector3(2680.915 , 4805.257 , 0.8556873 , "None"));
Path.Add(new Vector3(2681.89 , 4808.416 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2682.807 , 4813.128 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2682.911 , 4817.701 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2683.685 , 4822.309 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2685.894 , 4826.391 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2688.712 , 4830.245 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2691.761 , 4834.415 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2694.303 , 4837.891 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2697.239 , 4841.905 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2700.001 , 4845.683 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2702.894 , 4849.639 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2705.662 , 4853.424 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2708.503 , 4857.309 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2711.349 , 4861.2 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2714.145 , 4865.023 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2715.867 , 4869.185 , -1.701464 , "Swimming"));
Path.Add(new Vector3(2718.211 , 4873.193 , -1.009543 , "None"));
Path.Add(new Vector3(2721.311 , 4878.5 , 0.3963732 , "None"));
Path.Add(new Vector3(2724.154 , 4881.099 , 0.3963732 , "None"));
Path.Add(new Vector3(2727.243 , 4883.185 , 0.3963732 , "None"));
Path.Add(new Vector3(2731.177 , 4884.107 , 0.3963732 , "None"));
Path.Add(new Vector3(2735.112 , 4885.029 , 0.3963732 , "None"));
Path.Add(new Vector3(2739.26 , 4884.957 , 0.3963732 , "None"));
Path.Add(new Vector3(2747.685 , 4884.61 , 0.3963732 , "None"));
Path.Add(new Vector3(2756.385 , 4884.412 , 0.3963732 , "None"));
Path.Add(new Vector3(2764.776 , 4884.804 , 0.3963732 , "None"));
Path.Add(new Vector3(2773.362 , 4886.323 , 0.3963732 , "None"));
Path.Add(new Vector3(2781.391 , 4887.609 , 0.8997151 , "None"));
Path.Add(new Vector3(2790.018 , 4888.859 , 2.593446 , "None"));
Path.Add(new Vector3(2798.422 , 4889.741 , 2.88771 , "None"));
Path.Add(new Vector3(2807.061 , 4890.647 , 2.836385 , "None"));
Path.Add(new Vector3(2815.448 , 4891.53 , 2.625047 , "None"));
Path.Add(new Vector3(2823.744 , 4892.931 , 2.393073 , "None"));
Path.Add(new Vector3(2832.093 , 4895.369 , 2.211112 , "None"));
Path.Add(new Vector3(2840.14 , 4897.948 , 1.981342 , "None"));
Path.Add(new Vector3(2848.189 , 4900.411 , 2.329258 , "None"));
Path.Add(new Vector3(2856.765 , 4901.859 , 2.538525 , "None"));
Path.Add(new Vector3(2865.151 , 4902.756 , 2.538525 , "None"));
Path.Add(new Vector3(2873.18 , 4901.187 , 2.538525 , "None"));
Path.Add(new Vector3(2879.595 , 4895.284 , 2.538525 , "None"));
Path.Add(new Vector3(2886.842 , 4891.06 , 2.378416 , "None"));
Path.Add(new Vector3(2894.565 , 4891.067 , 3.176926 , "None"));
Path.Add(new Vector3(2902.094 , 4889.117 , 3.620623 , "None"));
Path.Add(new Vector3(2910.6 , 4885.421 , 2.558925 , "None"));
Path.Add(new Vector3(2918.564 , 4881.873 , 2.151679 , "None"));
Path.Add(new Vector3(2926.693 , 4882.061 , 2.011559 , "None"));
Path.Add(new Vector3(2934.889 , 4884.05 , 2.187018 , "None"));
Path.Add(new Vector3(2943.362 , 4886.105 , 2.47506 , "None"));
Path.Add(new Vector3(2950.987 , 4887.956 , 1.815411 , "None"));
Path.Add(new Vector3(2959.721 , 4890.075 , 0.3963848 , "None"));
Path.Add(new Vector3(2967.942 , 4889.83 , 0.3963848 , "None"));
Path.Add(new Vector3(2976.439 , 4887.953 , 0.3963848 , "None"));
Path.Add(new Vector3(2984.675 , 4886.133 , 0.3963848 , "None"));
Path.Add(new Vector3(2990.569 , 4880.56 , 0.3963848 , "None"));
Path.Add(new Vector3(2998.542 , 4878.798 , 0.3963848 , "None"));
Path.Add(new Vector3(3007.039 , 4876.92 , 0.3963848 , "None"));
Path.Add(new Vector3(3015.321 , 4875.432 , 0.3963848 , "None"));
Path.Add(new Vector3(3024.03 , 4874.995 , 0.3963848 , "None"));
Path.Add(new Vector3(3032.436 , 4874.572 , 0.3963848 , "None"));
Path.Add(new Vector3(3041.035 , 4873.526 , 0.3963848 , "None"));
Path.Add(new Vector3(3048.532 , 4875.348 , 0.3963848 , "None"));
Path.Add(new Vector3(3056.562 , 4875.235 , 0.3963848 , "None"));
Path.Add(new Vector3(3065.182 , 4874.522 , 0.3963848 , "None"));
Path.Add(new Vector3(3073.614 , 4874.357 , 0.3963848 , "None"));
Path.Add(new Vector3(3081.804 , 4873.658 , 0.3963848 , "None"));
Path.Add(new Vector3(3088.681 , 4877.547 , 0.3963848 , "None"));
Path.Add(new Vector3(3093.192 , 4879.544 , 0.3963848 , "None"));
Path.Add(new Vector3(3100.271 , 4874.962 , 0.3963848 , "None"));
Path.Add(new Vector3(3108.508 , 4873.779 , 0.6340918 , "None"));
Path.Add(new Vector3(3116.308 , 4876.116 , 1.635751 , "None"));
Path.Add(new Vector3(3123.658 , 4876.182 , 1.22151 , "None"));
Path.Add(new Vector3(3129.022 , 4872.339 , 1.369536 , "None"));
Path.Add(new Vector3(3125.014 , 4875.205 , 1.222369 , "None"));
Path.Add(new Vector3(3124.635 , 4871.186 , 1.220951 , "None"));
Path.Add(new Vector3(3126.375 , 4867.992 , 1.227386 , "None"));
Path.Add(new Vector3(3128.299 , 4864.599 , 1.844364 , "None"));
Path.Add(new Vector3(3128.21 , 4860.559 , 1.901133 , "None"));
Path.Add(new Vector3(3127.958 , 4856.474 , 1.610091 , "None"));
Path.Add(new Vector3(3127.07 , 4852.674 , 1.589223 , "None"));
Path.Add(new Vector3(3126.983 , 4849.026 , 2.380877 , "None"));
Path.Add(new Vector3(3129.794 , 4845.946 , 2.88715 , "None"));
Path.Add(new Vector3(3133.047 , 4843.792 , 2.766044 , "None"));
Path.Add(new Vector3(3137.076 , 4843.607 , 2.4748 , "None"));
Path.Add(new Vector3(3131.857 , 4844.445 , 2.812268 , "None"));
Path.Add(new Vector3(3128.242 , 4846.123 , 2.823699 , "None"));
Path.Add(new Vector3(3124.569 , 4847.827 , 2.009869 , "None"));
Path.Add(new Vector3(3120.706 , 4848.708 , 1.251807 , "None"));
Path.Add(new Vector3(3117.129 , 4850.14 , 1.221127 , "None"));
Path.Add(new Vector3(3113.274 , 4850.9 , 1.222451 , "None"));
Path.Add(new Vector3(3109.984 , 4852.713 , 1.962315 , "None"));
Path.Add(new Vector3(3106.513 , 4854.546 , 2.796846 , "None"));
Path.Add(new Vector3(3102.859 , 4855.659 , 3.258663 , "None"));
Path.Add(new Vector3(3098.873 , 4859.181 , 2.896097 , "None"));
Path.Add(new Vector3(3093.864 , 4858.803 , 2.706576 , "None"));
Path.Add(new Vector3(3090.221 , 4859.826 , 2.210576 , "None"));
Path.Add(new Vector3(3087.429 , 4857.135 , 2.562912 , "None"));
Path.Add(new Vector3(3085.257 , 4853.548 , 2.960757 , "None"));
Path.Add(new Vector3(3086.676 , 4860.205 , 1.628798 , "None"));
Path.Add(new Vector3(3088.536 , 4863.684 , 0.6126627 , "None"));
Path.Add(new Vector3(3091.12 , 4868.519 , 0.3965788 , "None"));
Path.Add(new Vector3(3093.276 , 4872.551 , 0.3965788 , "None"));
Path.Add(new Vector3(3095.739 , 4877.158 , 0.3965788 , "None"));
Path.Add(new Vector3(3098.471 , 4882.27 , 0.3965788 , "None"));
Path.Add(new Vector3(3101.361 , 4885.146 , 0.3965788 , "None"));
Path.Add(new Vector3(3105.186 , 4886.814 , 1.404766 , "None"));
Path.Add(new Vector3(3112.085 , 4889 , 0.6755825 , "None"));
Path.Add(new Vector3(3115.561 , 4890.102 , 1.114412 , "None"));
Path.Add(new Vector3(3122.273 , 4892.229 , 1.915127 , "None"));
Path.Add(new Vector3(3126.875 , 4890.439 , 1.355524 , "None"));
Path.Add(new Vector3(3130.165 , 4889.002 , 1.247583 , "None"));
Path.Add(new Vector3(3134.399 , 4887.152 , 1.584704 , "None"));
Path.Add(new Vector3(3137.656 , 4885.729 , 2.284554 , "None"));
Path.Add(new Vector3(3131.113 , 4886.902 , 1.269283 , "None"));
Path.Add(new Vector3(3123.603 , 4889.268 , 1.625089 , "None"));
Path.Add(new Vector3(3120.271 , 4890.317 , 1.851076 , "None"));
Path.Add(new Vector3(3116.647 , 4891.458 , 1.366695 , "None"));
Path.Add(new Vector3(3112.669 , 4892.711 , 0.9450207 , "None"));
Path.Add(new Vector3(3108.93 , 4893.889 , 0.6826085 , "None"));
Path.Add(new Vector3(3101.981 , 4896.077 , 1.209702 , "None"));
Path.Add(new Vector3(3094.319 , 4898.491 , 1.629161 , "None"));
Path.Add(new Vector3(3090.349 , 4899.741 , 1.709002 , "None"));
Path.Add(new Vector3(3083.508 , 4901.896 , 2.126009 , "None"));
Path.Add(new Vector3(3078.878 , 4903.354 , 2.292455 , "None"));
Path.Add(new Vector3(3071.891 , 4905.554 , 2.11378 , "None"));
Path.Add(new Vector3(3068.159 , 4906.729 , 1.995267 , "None"));
Path.Add(new Vector3(3064.543 , 4907.869 , 1.927282 , "None"));
Path.Add(new Vector3(3060.312 , 4909.201 , 1.860161 , "None"));
Path.Add(new Vector3(3056.289 , 4910.468 , 1.810549 , "None"));
Path.Add(new Vector3(3052.411 , 4911.689 , 1.835095 , "None"));
Path.Add(new Vector3(3048.503 , 4912.92 , 1.877313 , "None"));
Path.Add(new Vector3(3040.948 , 4915.299 , 1.163032 , "None"));
Path.Add(new Vector3(3036.763 , 4916.618 , 1.599926 , "None"));
Path.Add(new Vector3(3033.039 , 4917.791 , 2.213048 , "None"));
Path.Add(new Vector3(3029.062 , 4919.043 , 2.53506 , "None"));
Path.Add(new Vector3(3025.246 , 4920.245 , 1.805449 , "None"));
Path.Add(new Vector3(3022.122 , 4921.232 , 0.5265571 , "None"));
Path.Add(new Vector3(3017.089 , 4918.619 , 0.3962821 , "None"));
Path.Add(new Vector3(3009.347 , 4918.408 , 0.3962821 , "None"));
Path.Add(new Vector3(3002.814 , 4918.229 , 0.3962821 , "None"));
Path.Add(new Vector3(2993.897 , 4917.985 , 0.3962821 , "None"));
Path.Add(new Vector3(2986.255 , 4917.776 , 0.3962821 , "None"));
Path.Add(new Vector3(2982.527 , 4917.675 , 2.062686 , "None"));
Path.Add(new Vector3(2971.93 , 4917.385 , 2.100169 , "None"));
Path.Add(new Vector3(2967.967 , 4917.276 , 2.647364 , "None"));
Path.Add(new Vector3(2956.48 , 4916.962 , 2.808741 , "None"));
Path.Add(new Vector3(2948.503 , 4916.745 , 1.868098 , "None"));
Path.Add(new Vector3(2939.418 , 4916.496 , 2.578147 , "None"));
Path.Add(new Vector3(2931.177 , 4916.271 , 2.160453 , "None"));
Path.Add(new Vector3(2922.444 , 4916.032 , 2.562019 , "None"));
Path.Add(new Vector3(2914.316 , 4915.81 , 2.562019 , "None"));
Path.Add(new Vector3(2909.589 , 4915.681 , 2.43209 , "None"));
Path.Add(new Vector3(2907.954 , 4912.182 , 2.843246 , "None"));
Path.Add(new Vector3(2906.787 , 4915.854 , 1.945642 , "None"));
Path.Add(new Vector3(2898.886 , 4915.195 , 2.417969 , "None"));
Path.Add(new Vector3(2894.081 , 4920.908 , 2.749953 , "None"));
Path.Add(new Vector3(2882.707 , 4920.059 , 1.86761 , "None"));
Path.Add(new Vector3(2874.395 , 4918.737 , 2.733311 , "None"));
Path.Add(new Vector3(2865.783 , 4917.368 , 3.240783 , "None"));
Path.Add(new Vector3(2858.583 , 4916.223 , 2.913549 , "None"));
Path.Add(new Vector3(2848.877 , 4914.68 , 1.863613 , "None"));
Path.Add(new Vector3(2841.095 , 4913.442 , 1.848166 , "None"));
Path.Add(new Vector3(2834.177 , 4912.342 , 2.773519 , "None"));
Path.Add(new Vector3(2825.383 , 4910.944 , 2.511091 , "None"));
Path.Add(new Vector3(2812.5 , 4908.896 , 2.054521 , "None"));
Path.Add(new Vector3(2805.017 , 4907.706 , 2.227401 , "None"));
Path.Add(new Vector3(2795.825 , 4906.244 , 2.203329 , "None"));
Path.Add(new Vector3(2787.198 , 4904.873 , 1.908353 , "None"));
Path.Add(new Vector3(2780.113 , 4903.746 , 2.117197 , "None"));
Path.Add(new Vector3(2770.722 , 4902.253 , 1.913783 , "None"));
Path.Add(new Vector3(2762.244 , 4900.905 , 1.43875 , "None"));
Path.Add(new Vector3(2755.207 , 4899.786 , 0.4898151 , "None"));
Path.Add(new Vector3(2760.192 , 4900.207 , 1.217218 , "None"));
Path.Add(new Vector3(2768.623 , 4902.361 , 1.95397 , "None"));
Path.Add(new Vector3(2777.279 , 4902.444 , 1.850636 , "None"));
Path.Add(new Vector3(2785.657 , 4901.843 , 1.868601 , "None"));
Path.Add(new Vector3(2793.74 , 4902.727 , 2.433218 , "None"));
Path.Add(new Vector3(2802.322 , 4904.167 , 2.165012 , "None"));
Path.Add(new Vector3(2810.639 , 4905.564 , 1.887367 , "None"));
Path.Add(new Vector3(2818.986 , 4907.89 , 2.537171 , "None"));
Path.Add(new Vector3(2826.999 , 4910.332 , 2.712369 , "None"));
Path.Add(new Vector3(2835.328 , 4911.516 , 2.251467 , "None"));
Path.Add(new Vector3(2843.507 , 4913.573 , 1.865642 , "None"));
Path.Add(new Vector3(2851.962 , 4915.701 , 2.094571 , "None"));
Path.Add(new Vector3(2860.239 , 4917.783 , 3.302907 , "None"));
Path.Add(new Vector3(2868.581 , 4919.881 , 3.299818 , "None"));
Path.Add(new Vector3(2876.666 , 4922.143 , 3.498611 , "None"));
Path.Add(new Vector3(2884.404 , 4925.454 , 1.919583 , "None"));
Path.Add(new Vector3(2892.168 , 4928.776 , 2.539602 , "None"));
Path.Add(new Vector3(2900.457 , 4931.536 , 1.881034 , "None"));
Path.Add(new Vector3(2907.906 , 4934.983 , 2.222134 , "None"));
Path.Add(new Vector3(2915.84 , 4934.508 , 2.561589 , "None"));
Path.Add(new Vector3(2924.252 , 4932.276 , 2.168273 , "None"));
Path.Add(new Vector3(2932.419 , 4930.109 , 1.878368 , "None"));
Path.Add(new Vector3(2940.539 , 4927.955 , 1.952334 , "None"));
Path.Add(new Vector3(2948.966 , 4925.719 , 3.879473 , "None"));
Path.Add(new Vector3(2956.977 , 4923.358 , 4.288458 , "None"));
Path.Add(new Vector3(2962.988 , 4917.565 , 3.429528 , "None"));
Path.Add(new Vector3(2969.357 , 4912.037 , 2.808651 , "None"));
Path.Add(new Vector3(2975.941 , 4906.321 , 1.424075 , "None"));
Path.Add(new Vector3(2982.297 , 4900.804 , 0.3964267 , "None"));
Path.Add(new Vector3(2985.732 , 4893.62 , 0.3964267 , "None"));
Path.Add(new Vector3(2986.01 , 4885.189 , 0.3964267 , "None"));
Path.Add(new Vector3(2981.23 , 4878.939 , 0.3964267 , "None"));
Path.Add(new Vector3(2976.038 , 4874.646 , 0.3964267 , "None"));
Path.Add(new Vector3(2968.286 , 4866.437 , 0.3964267 , "None"));
Path.Add(new Vector3(2961.146 , 4861.462 , 0.3964267 , "None"));
Path.Add(new Vector3(2954.226 , 4856.641 , 0.3964267 , "None"));
Path.Add(new Vector3(2947.306 , 4851.82 , 0.3964267 , "None"));
Path.Add(new Vector3(2940.275 , 4846.697 , 0.3964267 , "None"));
Path.Add(new Vector3(2933.519 , 4841.211 , 0.3964267 , "None"));
Path.Add(new Vector3(2926.205 , 4839.25 , 0.3964267 , "None"));
Path.Add(new Vector3(2919.917 , 4833.262 , 0.3964267 , "None"));
Path.Add(new Vector3(2913.79 , 4827.501 , -0.5025432 , "None"));
Path.Add(new Vector3(2908.568 , 4823.449 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2904.773 , 4820.482 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2900.979 , 4817.516 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2897.243 , 4814.596 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2893.448 , 4811.629 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2889.774 , 4808.65 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2886.625 , 4805 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2883.479 , 4801.352 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2880.385 , 4797.766 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2877.24 , 4794.118 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2874.094 , 4790.471 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2871.432 , 4786.555 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2868.732 , 4782.591 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2865.456 , 4779.054 , -2.259664 , "Swimming"));
Path.Add(new Vector3(2862.94 , 4775.045 , -1.969975 , "None"));
Path.Add(new Vector3(2857.569 , 4766.565 , 0.08358613 , "None"));
Path.Add(new Vector3(2851.562 , 4760.664 , 0.08358613 , "None"));
Path.Add(new Vector3(2845.254 , 4755.091 , 0.08358613 , "None"));
Path.Add(new Vector3(2838.932 , 4749.484 , 1.187635 , "None"));
Path.Add(new Vector3(2833.617 , 4742.983 , 1.980718 , "None"));
Path.Add(new Vector3(2828.342 , 4736.04 , 1.957863 , "None"));
Path.Add(new Vector3(2821.943 , 4729.374 , 2.560774 , "None"));
Path.Add(new Vector3(2814.86 , 4723.388 , 2.560774 , "None"));
Path.Add(new Vector3(2809.477 , 4718.879 , 2.039781 , "None"));
Path.Add(new Vector3(2805.993 , 4715.488 , 1.861595 , "None"));
Path.Add(new Vector3(2800.781 , 4708.477 , 1.86191 , "None"));
Path.Add(new Vector3(2795.479 , 4701.345 , 1.862231 , "None"));
Path.Add(new Vector3(2791.475 , 4695.969 , 1.861052 , "None"));
Path.Add(new Vector3(2798.056 , 4693.85 , 1.861105 , "None"));
Path.Add(new Vector3(2806.406 , 4694.759 , 1.861105 , "None"));
Path.Add(new Vector3(2814.507 , 4695.641 , 1.861105 , "None"));
Path.Add(new Vector3(2823.158 , 4696.583 , 1.861105 , "None"));
Path.Add(new Vector3(2832.01 , 4697.546 , 2.057703 , "None"));
Path.Add(new Vector3(2840.494 , 4698.47 , 2.401276 , "None"));
Path.Add(new Vector3(2848.577 , 4699.35 , 2.160959 , "None"));
Path.Add(new Vector3(2857.529 , 4700.325 , 2.097124 , "None"));
Path.Add(new Vector3(2865.894 , 4701.236 , 2.206056 , "None"));
Path.Add(new Vector3(2872.082 , 4701.331 , 1.980799 , "None"));
Path.Add(new Vector3(2872.834 , 4693.574 , 2.404903 , "None"));
Path.Add(new Vector3(2881.98 , 4691.846 , 1.359629 , "None"));
Path.Add(new Vector3(2891.276 , 4689.412 , 0.08385982 , "None"));
Path.Add(new Vector3(2900.8 , 4686.919 , 0.08385982 , "None"));
Path.Add(new Vector3(2907.594 , 4685.141 , 0.08385982 , "None"));
Path.Add(new Vector3(2915.817 , 4682.988 , -2.046299 , "None"));
Path.Add(new Vector3(2920.063 , 4681.876 , -4.481717 , "Swimming"));
Path.Add(new Vector3(2924.37 , 4680.749 , -7.482765 , "Swimming"));
Path.Add(new Vector3(2928.238 , 4679.736 , -10.17764 , "Swimming"));
Path.Add(new Vector3(2931.852 , 4678.791 , -12.69567 , "Swimming"));
Path.Add(new Vector3(2935.901 , 4677.73 , -15.51723 , "Swimming"));
Path.Add(new Vector3(2939.769 , 4676.718 , -18.2121 , "Swimming"));
Path.Add(new Vector3(2943.117 , 4675.841 , -20.54537 , "Swimming"));
Path.Add(new Vector3(2947.171 , 4674.78 , -23.36958 , "Swimming"));
Path.Add(new Vector3(2950.974 , 4673.785 , -26.01958 , "Swimming"));
Path.Add(new Vector3(2954.732 , 4672.801 , -28.63791 , "Swimming"));
Path.Add(new Vector3(2958.641 , 4671.778 , -31.36181 , "Swimming"));
Path.Add(new Vector3(2955.228 , 4676.352 , -31.45408 , "Swimming"));
Path.Add(new Vector3(2952.391 , 4679.949 , -31.44727 , "Swimming"));
Path.Add(new Vector3(2949.309 , 4683.856 , -31.43987 , "Swimming"));
Path.Add(new Vector3(2946.258 , 4687.724 , -31.43254 , "Swimming"));
Path.Add(new Vector3(2943.363 , 4691.394 , -31.42558 , "Swimming"));
Path.Add(new Vector3(2940.948 , 4694.457 , -31.41978 , "Swimming"));
Path.Add(new Vector3(2937.435 , 4698.91 , -31.41135 , "Swimming"));
Path.Add(new Vector3(2934.543 , 4702.576 , -31.4044 , "Swimming"));
Path.Add(new Vector3(2931.504 , 4706.429 , -31.3971 , "Swimming"));
Path.Add(new Vector3(2928.436 , 4710.318 , -31.38973 , "Swimming"));
Path.Add(new Vector3(2925.538 , 4713.992 , -31.38277 , "Swimming"));
Path.Add(new Vector3(2922.602 , 4717.714 , -31.37572 , "Swimming"));
Path.Add(new Vector3(2919.669 , 4721.433 , -31.36867 , "Swimming"));
Path.Add(new Vector3(2916.671 , 4725.233 , -31.36147 , "Swimming"));
Path.Add(new Vector3(2913.697 , 4729.004 , -31.35433 , "Swimming"));
Path.Add(new Vector3(2911.176 , 4732.2 , -31.34828 , "Swimming"));
Path.Add(new Vector3(2907.81 , 4736.468 , -31.34019 , "Swimming"));
Path.Add(new Vector3(2904.844 , 4740.227 , -31.33307 , "Swimming"));
Path.Add(new Vector3(2901.943 , 4743.905 , -31.3261 , "Swimming"));
Path.Add(new Vector3(2898.899 , 4747.765 , -31.31879 , "Swimming"));
Path.Add(new Vector3(2896.106 , 4751.306 , -31.31208 , "Swimming"));
Path.Add(new Vector3(2892.985 , 4755.262 , -31.30458 , "Swimming"));
Path.Add(new Vector3(2890.096 , 4758.925 , -31.29765 , "Swimming"));
Path.Add(new Vector3(2887.013 , 4762.833 , -31.29024 , "Swimming"));
Path.Add(new Vector3(2884.086 , 4766.544 , -31.28321 , "Swimming"));
Path.Add(new Vector3(2881.123 , 4770.3 , -31.27609 , "Swimming"));
Path.Add(new Vector3(2878.137 , 4774.085 , -31.26892 , "Swimming"));
Path.Add(new Vector3(2875.06 , 4777.638 , -31.24093 , "Swimming"));
Path.Add(new Vector3(2871.291 , 4780.612 , -31.18694 , "Swimming"));
Path.Add(new Vector3(2866.731 , 4781.875 , -31.16402 , "Swimming"));
Path.Add(new Vector3(2862.126 , 4783.151 , -31.14088 , "Swimming"));
Path.Add(new Vector3(2857.58 , 4784.411 , -31.11803 , "Swimming"));
Path.Add(new Vector3(2852.782 , 4785.249 , -31.09114 , "Swimming"));
Path.Add(new Vector3(2848.028 , 4785.347 , -31.06062 , "Swimming"));
Path.Add(new Vector3(2843.08 , 4785.45 , -31.02884 , "Swimming"));
Path.Add(new Vector3(2839.034 , 4784.908 , -31.0022 , "Swimming"));
Path.Add(new Vector3(2835.276 , 4783.526 , -30.97649 , "Swimming"));
Path.Add(new Vector3(2830.578 , 4781.799 , -30.94435 , "Swimming"));
Path.Add(new Vector3(2827.425 , 4779.916 , -30.67143 , "Swimming"));
Path.Add(new Vector3(2825.677 , 4775.819 , -29.07598 , "Swimming"));
Path.Add(new Vector3(2823.925 , 4771.713 , -27.47736 , "Swimming"));
Path.Add(new Vector3(2822.2 , 4768.652 , -26.16517 , "Swimming"));
Path.Add(new Vector3(2818.702 , 4769.154 , -24.15562 , "Swimming"));
Path.Add(new Vector3(2815.817 , 4770.752 , -22.23735 , "Swimming"));
Path.Add(new Vector3(2816.022 , 4775.041 , -22.24828 , "Swimming"));
Path.Add(new Vector3(2818.44 , 4774.344 , -18.34653 , "Swimming"));
Path.Add(new Vector3(2817.878 , 4773.713 , -14.02733 , "Swimming"));
Path.Add(new Vector3(2817.312 , 4773.079 , -9.684955 , "Swimming"));
Path.Add(new Vector3(2816.72 , 4773.206 , -5.272249 , "Swimming"));
Path.Add(new Vector3(2816.07 , 4772.808 , -1.539505 , "Swimming"));
Path.Add(new Vector3(2816.658 , 4766 , 0.08448467 , "None"));
Path.Add(new Vector3(2815.811 , 4759.18 , 0.08448467 , "None"));
Path.Add(new Vector3(2815.027 , 4752.885 , 0.08448467 , "None"));
Path.Add(new Vector3(2814.423 , 4748.036 , 0.08448467 , "None"));
Path.Add(new Vector3(2813.99 , 4744.561 , 0.08448467 , "None"));
Path.Add(new Vector3(2813.491 , 4740.559 , 1.260172 , "None"));
Path.Add(new Vector3(2812.634 , 4733.994 , 1.873174 , "None"));
Path.Add(new Vector3(2810.402 , 4731.304 , 2.542387 , "None"));
Path.Add(new Vector3(2808.026 , 4723.52 , 2.561902 , "None"));
Path.Add(new Vector3(2806.162 , 4720.404 , 2.561902 , "None"));
Path.Add(new Vector3(2804.066 , 4716.902 , 1.881801 , "None"));
Path.Add(new Vector3(2802.004 , 4713.456 , 2.283892 , "None"));
Path.Add(new Vector3(2800.069 , 4710.223 , 1.926151 , "None"));
Path.Add(new Vector3(2797.856 , 4706.525 , 1.861029 , "None"));
Path.Add(new Vector3(2793.814 , 4699.77 , 1.861489 , "None"));
Path.Add(new Vector3(2789.889 , 4700.642 , 1.843739 , "None"));
Path.Add(new Vector3(2782.974 , 4702.443 , 2.42394 , "None"));
Path.Add(new Vector3(2773.334 , 4704.954 , 2.703791 , "None"));
Path.Add(new Vector3(2766.053 , 4706.472 , 2.683223 , "None"));
Path.Add(new Vector3(2759.925 , 4702.099 , 2.90311 , "None"));
Path.Add(new Vector3(2750.776 , 4698.845 , 3.147521 , "None"));
Path.Add(new Vector3(2744.841 , 4696.733 , 2.806735 , "None"));
Path.Add(new Vector3(2735.312 , 4693.345 , 2.402918 , "None"));
Path.Add(new Vector3(2727.904 , 4690.709 , 2.023179 , "None"));
Path.Add(new Vector3(2719.831 , 4687.839 , 2.411606 , "None"));
Path.Add(new Vector3(2731.309 , 4692.296 , 1.794604 , "None"));
Path.Add(new Vector3(2735.92 , 4694.065 , 2.493652 , "None"));
Path.Add(new Vector3(2744.641 , 4697.413 , 2.789399 , "None"));
Path.Add(new Vector3(2751.197 , 4699.929 , 3.156299 , "None"));
Path.Add(new Vector3(2760.373 , 4703.45 , 2.846769 , "None"));
Path.Add(new Vector3(2766.929 , 4705.966 , 2.610083 , "None"));
Path.Add(new Vector3(2773.374 , 4706.63 , 2.88816 , "None"));
Path.Add(new Vector3(2780.689 , 4703.704 , 2.648492 , "None"));
Path.Add(new Vector3(2786.944 , 4700.907 , 1.978535 , "None"));
Path.Add(new Vector3(2790.948 , 4696.857 , 1.861322 , "None"));
Path.Add(new Vector3(2792.319 , 4692.534 , 1.857043 , "None"));
Path.Add(new Vector3(2792.465 , 4684.286 , 1.788988 , "None"));
Path.Add(new Vector3(2792.623 , 4675.4 , 1.89622 , "None"));
Path.Add(new Vector3(2792.773 , 4666.968 , 2.300229 , "None"));
Path.Add(new Vector3(2792.938 , 4657.679 , 2.373978 , "None"));
Path.Add(new Vector3(2793.077 , 4649.835 , 2.54329 , "None"));
Path.Add(new Vector3(2793.233 , 4641.066 , 2.543314 , "None"));
Path.Add(new Vector3(2793.383 , 4632.618 , 1.614221 , "None"));
Path.Add(new Vector3(2793.527 , 4624.521 , 0.08404141 , "None"));
Path.Add(new Vector3(2793.679 , 4615.955 , 0.08404141 , "None"));
Path.Add(new Vector3(2793.775 , 4610.549 , 0.08404141 , "None"));
Path.Add(new Vector3(2795.074 , 4615.151 , 0.08404141 , "None"));
Path.Add(new Vector3(2795.211 , 4623.555 , 0.08404141 , "None"));
Path.Add(new Vector3(2794.927 , 4632.247 , 1.574649 , "None"));
Path.Add(new Vector3(2794.645 , 4640.676 , 2.55147 , "None"));
Path.Add(new Vector3(2794.354 , 4649.374 , 2.53124 , "None"));
Path.Add(new Vector3(2794.072 , 4657.802 , 2.442181 , "None"));
Path.Add(new Vector3(2793.79 , 4666.223 , 2.250316 , "None"));
Path.Add(new Vector3(2793.508 , 4674.635 , 2.142797 , "None"));
Path.Add(new Vector3(2795.063 , 4682.594 , 2.117488 , "None"));
Path.Add(new Vector3(2794.484 , 4691.007 , 1.836847 , "None"));
Path.Add(new Vector3(2798.591 , 4693.917 , 1.860089 , "None"));
Path.Add(new Vector3(2804.847 , 4695.146 , 1.860089 , "None"));
Path.Add(new Vector3(2800.001 , 4690.863 , 1.974757 , "None"));
Path.Add(new Vector3(2796.627 , 4687.881 , 2.334968 , "None"));
Path.Add(new Vector3(2800.64 , 4676.273 , 2.724883 , "None"));
Path.Add(new Vector3(2804.107 , 4668.9 , 2.192173 , "None"));
Path.Add(new Vector3(2808.873 , 4661.633 , 1.849412 , "None"));
Path.Add(new Vector3(2814.151 , 4655.074 , 2.537558 , "None"));
Path.Add(new Vector3(2820.319 , 4648.915 , 2.441689 , "None"));
Path.Add(new Vector3(2826.416 , 4643.112 , 2.266296 , "None"));
Path.Add(new Vector3(2832.733 , 4637.102 , 1.995588 , "None"));
Path.Add(new Vector3(2838.842 , 4631.288 , 2.078089 , "None"));
Path.Add(new Vector3(2844.776 , 4625.642 , 2.251569 , "None"));
Path.Add(new Vector3(2851.044 , 4619.678 , 1.722219 , "None"));
Path.Add(new Vector3(2857.349 , 4613.679 , 0.08372796 , "None"));
Path.Add(new Vector3(2863.086 , 4608.021 , 0.08372796 , "None"));
Path.Add(new Vector3(2864.23 , 4599.734 , 0.08372796 , "None"));
Path.Add(new Vector3(2864.733 , 4591.638 , 0.08372796 , "None"));
Path.Add(new Vector3(2867.609 , 4583.71 , 1.664862 , "None"));
Path.Add(new Vector3(2870.507 , 4575.791 , -0.006672835 , "None"));
Path.Add(new Vector3(2872.293 , 4571.131 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2874.281 , 4566.744 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2876.269 , 4562.356 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2878.211 , 4558.068 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2880.185 , 4553.71 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2882.187 , 4549.293 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2884.168 , 4544.918 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2886.598 , 4539.555 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2888.122 , 4536.191 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2890.086 , 4531.855 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2892.058 , 4527.502 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2894.001 , 4523.213 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2896.012 , 4518.774 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2897.974 , 4514.443 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2900.077 , 4509.802 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2901.905 , 4505.767 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2903.917 , 4501.323 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2905.905 , 4496.936 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2907.772 , 4492.651 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2905.693 , 4489.299 , -2.234157 , "Swimming"));
Path.Add(new Vector3(2904.321 , 4483.968 , -2.36519 , "Swimming"));
Path.Add(new Vector3(2903.869 , 4480.199 , -2.478877 , "Swimming"));
Path.Add(new Vector3(2904.605 , 4476.023 , -2.521089 , "Swimming"));
Path.Add(new Vector3(2905.837 , 4471.723 , -2.521089 , "Swimming"));
Path.Add(new Vector3(2904.307 , 4467.367 , -2.54554 , "Swimming"));
Path.Add(new Vector3(2905.217 , 4462.379 , -2.588113 , "Swimming"));
Path.Add(new Vector3(2906.935 , 4458.585 , -2.588113 , "Swimming"));
Path.Add(new Vector3(2906.859 , 4454.681 , -2.588113 , "Swimming"));
Path.Add(new Vector3(2906.492 , 4450.566 , -2.608984 , "Swimming"));
Path.Add(new Vector3(2907.206 , 4446.01 , -2.666417 , "Swimming"));
Path.Add(new Vector3(2908.629 , 4441.614 , -2.688849 , "Swimming"));
Path.Add(new Vector3(2910.21 , 4438.314 , -2.967922 , "Swimming"));
Path.Add(new Vector3(2912.659 , 4434.82 , -2.972061 , "Swimming"));
Path.Add(new Vector3(2916.871 , 4432.865 , -2.477189 , "Swimming"));
Path.Add(new Vector3(2917.808 , 4428.834 , -2.400576 , "Swimming"));
Path.Add(new Vector3(2917.923 , 4424.618 , -2.663296 , "Swimming"));
Path.Add(new Vector3(2916.387 , 4420.631 , -0.5191088 , "None"));
Path.Add(new Vector3(2916.23 , 4416.766 , 0.372513 , "None"));
Path.Add(new Vector3(2916.036 , 4408.049 , 0.372513 , "None"));
Path.Add(new Vector3(2916.445 , 4399.666 , 0.9652377 , "None"));
Path.Add(new Vector3(2920.632 , 4392.051 , 1.946035 , "None"));
Path.Add(new Vector3(2926.562 , 4386.079 , 1.213638 , "None"));
Path.Add(new Vector3(2932.762 , 4380.362 , 2.429771 , "None"));
Path.Add(new Vector3(2939.837 , 4377.07 , 4.20466 , "None"));
Path.Add(new Vector3(2946.619 , 4372.173 , 7.05351 , "None"));
Path.Add(new Vector3(2951.362 , 4367.8 , 8.560319 , "None"));
Path.Add(new Vector3(2959.084 , 4362.538 , 10.08748 , "None"));
Path.Add(new Vector3(2962.446 , 4359.987 , 11.16169 , "None"));
Path.Add(new Vector3(2968.436 , 4354.464 , 14.47753 , "None"));
Path.Add(new Vector3(2970.799 , 4351.735 , 16.15401 , "None"));
Path.Add(new Vector3(2974.525 , 4344.183 , 20.16533 , "None"));
Path.Add(new Vector3(2978.375 , 4336.379 , 23.28315 , "None"));
Path.Add(new Vector3(2979.68 , 4328.236 , 24.3501 , "None"));
Path.Add(new Vector3(2979.265 , 4320.391 , 25.62417 , "None"));
Path.Add(new Vector3(2981.329 , 4310.637 , 26.44885 , "None"));
Path.Add(new Vector3(2983.123 , 4302.5 , 26.66992 , "None"));
Path.Add(new Vector3(2984.983 , 4294.067 , 26.21754 , "None"));
Path.Add(new Vector3(2986.806 , 4285.798 , 25.25265 , "None"));
Path.Add(new Vector3(2988.681 , 4277.3 , 24.36798 , "None"));
Path.Add(new Vector3(2990.504 , 4269.032 , 23.69627 , "None"));
Path.Add(new Vector3(2992.367 , 4260.583 , 23.21571 , "None"));
Path.Add(new Vector3(2994.184 , 4252.347 , 23.5726 , "None"));
Path.Add(new Vector3(2995.794 , 4245.046 , 23.45894 , "None"));
Path.Add(new Vector3(2996.027 , 4238.36 , 24.51476 , "None"));
Path.Add(new Vector3(2995.048 , 4230.897 , 26.7586 , "None"));
Path.Add(new Vector3(2994.081 , 4223.518 , 27.93331 , "None"));
Path.Add(new Vector3(2992.722 , 4213.157 , 28.58129 , "None"));
Path.Add(new Vector3(2991.596 , 4204.579 , 28.84216 , "None"));
Path.Add(new Vector3(2990.463 , 4195.934 , 28.5442 , "None"));
Path.Add(new Vector3(2989.366 , 4187.571 , 27.89044 , "None"));
Path.Add(new Vector3(2988.271 , 4179.226 , 27.36389 , "None"));
Path.Add(new Vector3(2988.536 , 4173.014 , 27.14367 , "None"));
Path.Add(new Vector3(2989.191 , 4164.034 , 27.80458 , "None"));
Path.Add(new Vector3(2989.869 , 4154.747 , 26.26167 , "None"));
Path.Add(new Vector3(2991.482 , 4146.48 , 25.14372 , "None"));
Path.Add(new Vector3(2993.338 , 4137.979 , 23.22252 , "None"));
Path.Add(new Vector3(2993.359 , 4132.466 , 23.21894 , "None"));
Path.Add(new Vector3(2989.399 , 4123.808 , 23.2504 , "None"));
Path.Add(new Vector3(2984.071 , 4117.098 , 24.92704 , "None"));
Path.Add(new Vector3(2978.794 , 4110.455 , 26.39923 , "None"));
Path.Add(new Vector3(2973.56 , 4103.863 , 25.68259 , "None"));
Path.Add(new Vector3(2964.831 , 4096.38 , 21.79018 , "None"));
Path.Add(new Vector3(2957.591 , 4092.056 , 17.59175 , "None"));
Path.Add(new Vector3(2950.119 , 4087.594 , 11.64015 , "None"));
Path.Add(new Vector3(2942.865 , 4083.261 , 6.258559 , "None"));
Path.Add(new Vector3(2935.913 , 4078.032 , 2.803258 , "None"));
Path.Add(new Vector3(2929.5 , 4073.006 , 1.374 , "None"));
Path.Add(new Vector3(2925.138 , 4065.546 , 1.469608 , "None"));
Path.Add(new Vector3(2922.49 , 4057.874 , 1.769885 , "None"));
Path.Add(new Vector3(2919.211 , 4050.416 , 1.976586 , "None"));
Path.Add(new Vector3(2920.652 , 4046.714 , 1.904199 , "None"));
Path.Add(new Vector3(2925.947 , 4041.41 , 1.997734 , "None"));
Path.Add(new Vector3(2932.376 , 4035.545 , 2.055535 , "None"));
Path.Add(new Vector3(2938.325 , 4029.567 , 1.844889 , "None"));
Path.Add(new Vector3(2944.422 , 4023.358 , 1.766512 , "None"));
Path.Add(new Vector3(2950.343 , 4017.329 , 1.94268 , "None"));
Path.Add(new Vector3(2956.24 , 4011.323 , 1.976876 , "None"));
Path.Add(new Vector3(2962.338 , 4005.115 , 2.10803 , "None"));
Path.Add(new Vector3(2967.471 , 3999.889 , 1.906143 , "None"));
Path.Add(new Vector3(2974.391 , 3993.32 , 1.535104 , "None"));
Path.Add(new Vector3(2980.823 , 3987.459 , 2.570909 , "None"));
Path.Add(new Vector3(2987.534 , 3982.353 , 3.926452 , "None"));
Path.Add(new Vector3(2994.063 , 3977.479 , 8.340951 , "None"));
Path.Add(new Vector3(3000.996 , 3972.302 , 13.10457 , "None"));
Path.Add(new Vector3(3008.012 , 3967.064 , 19.22598 , "None"));
Path.Add(new Vector3(3014.77 , 3962.019 , 24.30766 , "None"));
Path.Add(new Vector3(3020.439 , 3955.812 , 26.98635 , "None"));
Path.Add(new Vector3(3024.968 , 3948.782 , 27.24493 , "None"));
Path.Add(new Vector3(3030.583 , 3942.115 , 28.27202 , "None"));
Path.Add(new Vector3(3036.103 , 3935.739 , 29.03953 , "None"));
Path.Add(new Vector3(3041.798 , 3929.159 , 27.23877 , "None"));
Path.Add(new Vector3(3047.318 , 3922.782 , 25.71602 , "None"));
Path.Add(new Vector3(3052.837 , 3916.406 , 25.5645 , "None"));
Path.Add(new Vector3(3058.522 , 3909.838 , 25.84796 , "None"));
Path.Add(new Vector3(3064.042 , 3903.461 , 25.97997 , "None"));
Path.Add(new Vector3(3069.76 , 3896.856 , 25.05799 , "None"));
Path.Add(new Vector3(3075.257 , 3890.505 , 22.92361 , "None"));
Path.Add(new Vector3(3080.777 , 3884.128 , 20.42967 , "None"));
Path.Add(new Vector3(3086.307 , 3877.739 , 18.35555 , "None"));
Path.Add(new Vector3(3091.992 , 3871.172 , 17.62333 , "None"));
Path.Add(new Vector3(3097.511 , 3864.796 , 17.70505 , "None"));
Path.Add(new Vector3(3103.071 , 3858.112 , 18.74054 , "None"));
Path.Add(new Vector3(3107.328 , 3850.832 , 20.8931 , "None"));
Path.Add(new Vector3(3110.913 , 3845.085 , 22.36758 , "None"));
Path.Add(new Vector3(3115.382 , 3839.76 , 22.78057 , "None"));
Path.Add(new Vector3(3112.432 , 3843.276 , 22.51866 , "None"));
Path.Add(new Vector3(3119.851 , 3840.916 , 23.27612 , "None"));
Path.Add(new Vector3(3126.725 , 3837.978 , 23.73779 , "None"));
Path.Add(new Vector3(3135.638 , 3834.167 , 23.1741 , "None"));
Path.Add(new Vector3(3143.393 , 3830.852 , 23.0544 , "None"));
Path.Add(new Vector3(3150.963 , 3827.617 , 23.21181 , "None"));
Path.Add(new Vector3(3159.088 , 3824.143 , 23.80233 , "None"));
Path.Add(new Vector3(3166.673 , 3820.901 , 24.76459 , "None"));
Path.Add(new Vector3(3174.277 , 3817.465 , 27.30326 , "None"));
Path.Add(new Vector3(3182.48 , 3814.002 , 27.27105 , "None"));
Path.Add(new Vector3(3189.078 , 3811.211 , 26.41104 , "None"));
Path.Add(new Vector3(3195.802 , 3805.751 , 25.67493 , "None"));
Path.Add(new Vector3(3201.256 , 3800.961 , 26.19798 , "None"));
Path.Add(new Vector3(3204.659 , 3805.158 , 26.94041 , "None"));
Path.Add(new Vector3(3206.622 , 3808.193 , 26.69959 , "None"));
Path.Add(new Vector3(3210.585 , 3814.274 , 25.15103 , "None"));
Path.Add(new Vector3(3212.889 , 3817.445 , 24.98346 , "None"));
Path.Add(new Vector3(3219.007 , 3814.655 , 25.11209 , "None"));
Path.Add(new Vector3(3224.103 , 3808.982 , 25.11891 , "None"));
Path.Add(new Vector3(3226.903 , 3805.979 , 25.31647 , "None"));
Path.Add(new Vector3(3231.75 , 3800.981 , 26.04696 , "None"));
Path.Add(new Vector3(3236.755 , 3800.133 , 26.5512 , "None"));
Path.Add(new Vector3(3240.373 , 3802.302 , 26.62447 , "None"));
Path.Add(new Vector3(3243.88 , 3804.406 , 26.77024 , "None"));
Path.Add(new Vector3(3247.458 , 3806.548 , 27.02654 , "None"));
Path.Add(new Vector3(3250.576 , 3808.415 , 27.24948 , "None"));
Path.Add(new Vector3(3254.396 , 3810.701 , 27.55185 , "None"));
Path.Add(new Vector3(3260.283 , 3814.253 , 27.74132 , "None"));
Path.Add(new Vector3(3263.348 , 3816.059 , 27.18223 , "None"));
Path.Add(new Vector3(3266.778 , 3817.986 , 26.92251 , "None"));
Path.Add(new Vector3(3269.962 , 3819.63 , 27.01172 , "None"));
Path.Add(new Vector3(3276.564 , 3817.392 , 25.74415 , "None"));
Path.Add(new Vector3(3280.212 , 3816.144 , 25.59952 , "None"));
Path.Add(new Vector3(3283.658 , 3814.964 , 25.77416 , "None"));
Path.Add(new Vector3(3287.306 , 3813.716 , 26.20124 , "None"));
Path.Add(new Vector3(3294.642 , 3812.036 , 27.24645 , "None"));
Path.Add(new Vector3(3298.35 , 3811.195 , 27.79554 , "None"));
Path.Add(new Vector3(3305.507 , 3814.273 , 28.48129 , "None"));
Path.Add(new Vector3(3310.061 , 3816.317 , 28.76376 , "None"));
Path.Add(new Vector3(3306.965 , 3814.145 , 28.59044 , "None"));
Path.Add(new Vector3(3308.266 , 3810.771 , 28.89879 , "None"));
Path.Add(new Vector3(3307.638 , 3806.81 , 29.26229 , "None"));
Path.Add(new Vector3(3309.233 , 3803.639 , 29.65791 , "None"));
Path.Add(new Vector3(3311.201 , 3799.727 , 29.68899 , "None"));
Path.Add(new Vector3(3313.325 , 3796.206 , 29.45398 , "None"));
Path.Add(new Vector3(3316.004 , 3792.754 , 28.94767 , "None"));
Path.Add(new Vector3(3311.555 , 3786.954 , 28.37222 , "None"));
Path.Add(new Vector3(3309.115 , 3783.773 , 28.00225 , "None"));
Path.Add(new Vector3(3306.734 , 3780.669 , 27.60238 , "None"));
Path.Add(new Vector3(3302.698 , 3775.541 , 26.89426 , "None"));
Path.Add(new Vector3(3297.357 , 3769.328 , 26.00564 , "None"));
Path.Add(new Vector3(3294.322 , 3766.194 , 25.51734 , "None"));
Path.Add(new Vector3(3281.864 , 3765.542 , 25.32229 , "None"));
Path.Add(new Vector3(3273.196 , 3764.977 , 25.00364 , "None"));
Path.Add(new Vector3(3264.865 , 3764.435 , 24.81598 , "None"));
Path.Add(new Vector3(3256.382 , 3763.882 , 24.78929 , "None"));
Path.Add(new Vector3(3248.737 , 3763.385 , 24.88653 , "None"));
Path.Add(new Vector3(3239.131 , 3762.759 , 25.18204 , "None"));
Path.Add(new Vector3(3233.572 , 3765.207 , 25.64138 , "None"));
Path.Add(new Vector3(3226.14 , 3769.604 , 26.03468 , "None"));
Path.Add(new Vector3(3218.52 , 3774.111 , 26.02517 , "None"));
Path.Add(new Vector3(3211.218 , 3778.431 , 26.2674 , "None"));
Path.Add(new Vector3(3203.988 , 3782.707 , 26.96789 , "None"));
Path.Add(new Vector3(3196.498 , 3787.138 , 27.51853 , "None"));
Path.Add(new Vector3(3189.731 , 3791.141 , 28.54813 , "None"));
Path.Add(new Vector3(3181.908 , 3795.769 , 27.61497 , "None"));
Path.Add(new Vector3(3174.866 , 3799.934 , 27.15961 , "None"));
Path.Add(new Vector3(3169.329 , 3803.038 , 25.21448 , "None"));
Path.Add(new Vector3(3165.674 , 3804.891 , 24.26569 , "None"));
Path.Add(new Vector3(3162.736 , 3807.015 , 23.03967 , "None"));
Path.Add(new Vector3(3155.844 , 3812.135 , 20.33186 , "None"));
Path.Add(new Vector3(3148.656 , 3817.474 , 19.47614 , "None"));
Path.Add(new Vector3(3141.953 , 3822.453 , 19.95279 , "None"));
Path.Add(new Vector3(3134.967 , 3827.642 , 21.24704 , "None"));
Path.Add(new Vector3(3128.413 , 3832.51 , 23.06996 , "None"));
Path.Add(new Vector3(3121.359 , 3837.75 , 23.41351 , "None"));
Path.Add(new Vector3(3116.182 , 3841.595 , 22.87942 , "None"));
Path.Add(new Vector3(3127.121 , 3836.35 , 23.65869 , "None"));
Path.Add(new Vector3(3134.585 , 3831.434 , 22.4033 , "None"));
Path.Add(new Vector3(3141.446 , 3826.915 , 21.56615 , "None"));
Path.Add(new Vector3(3148.671 , 3822.156 , 21.12578 , "None"));
Path.Add(new Vector3(3155.925 , 3817.379 , 21.68625 , "None"));
Path.Add(new Vector3(3162.66 , 3812.943 , 22.9974 , "None"));
Path.Add(new Vector3(3170.068 , 3808.064 , 25.53227 , "None"));
Path.Add(new Vector3(3177.307 , 3803.296 , 26.6174 , "None"));
Path.Add(new Vector3(3184.196 , 3798.759 , 26.863 , "None"));
Path.Add(new Vector3(3191.394 , 3794.018 , 27.79099 , "None"));
Path.Add(new Vector3(3198.423 , 3789.389 , 27.17702 , "None"));
Path.Add(new Vector3(3205.606 , 3784.657 , 26.74534 , "None"));
Path.Add(new Vector3(3212.804 , 3779.917 , 26.16816 , "None"));
Path.Add(new Vector3(3219.805 , 3775.306 , 26.06064 , "None"));
Path.Add(new Vector3(3226.862 , 3770.658 , 26.07911 , "None"));
Path.Add(new Vector3(3234.032 , 3765.936 , 25.67473 , "None"));
Path.Add(new Vector3(3240.745 , 3762.013 , 25.03018 , "None"));
Path.Add(new Vector3(3249.637 , 3760.702 , 24.51287 , "None"));
Path.Add(new Vector3(3257.366 , 3759.563 , 24.13436 , "None"));
Path.Add(new Vector3(3267.006 , 3758.142 , 23.745 , "None"));
Path.Add(new Vector3(3272.706 , 3757.302 , 23.59698 , "None"));
Path.Add(new Vector3(3282.911 , 3755.797 , 23.60754 , "None"));
Path.Add(new Vector3(3287.409 , 3755.134 , 23.68173 , "None"));
Path.Add(new Vector3(3295.238 , 3753.98 , 23.58264 , "None"));
Path.Add(new Vector3(3302.733 , 3752.875 , 23.29566 , "None"));
Path.Add(new Vector3(3310.944 , 3751.665 , 22.89391 , "None"));
Path.Add(new Vector3(3319.504 , 3750.409 , 22.55674 , "None"));
Path.Add(new Vector3(3325.535 , 3749.508 , 22.33052 , "None"));
Path.Add(new Vector3(3332.294 , 3746.659 , 22.08026 , "None"));
Path.Add(new Vector3(3336.726 , 3743.027 , 22.06813 , "None"));
Path.Add(new Vector3(3343.444 , 3740.662 , 22.30306 , "None"));
Path.Add(new Vector3(3349.17 , 3735.226 , 22.17368 , "None"));
Path.Add(new Vector3(3351.437 , 3729.578 , 21.92503 , "None"));
Path.Add(new Vector3(3357.014 , 3724.724 , 21.81787 , "None"));
Path.Add(new Vector3(3358.162 , 3718.657 , 21.64235 , "None"));
Path.Add(new Vector3(3351.352 , 3712.987 , 23.20885 , "None"));
Path.Add(new Vector3(3344.805 , 3707.539 , 30.10847 , "None"));
Path.Add(new Vector3(3338.245 , 3702.079 , 32.40448 , "None"));
Path.Add(new Vector3(3331.789 , 3696.706 , 32.411 , "None"));
Path.Add(new Vector3(3325.125 , 3691.16 , 32.43638 , "None"));
Path.Add(new Vector3(3318.66 , 3691.327 , 32.45408 , "None"));
Path.Add(new Vector3(3311.139 , 3688.482 , 32.46737 , "None"));
Path.Add(new Vector3(3307.194 , 3686.989 , 32.46737 , "None"));
Path.Add(new Vector3(3303.468 , 3685.576 , 32.46737 , "None"));
Path.Add(new Vector3(3298.317 , 3683.621 , 32.46737 , "None"));
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


public sealed class TheHuntisOn : QuestClass
{
    public TheHuntisOn()
    {
        Name = "The Hunt is On";

        QuestId.AddRange(new[] { 11794 });

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


public sealed class TheLateWilliamAllerton : QuestClass
{
    public TheLateWilliamAllerton()
    {
        Name = "The Late William Allerton";

        QuestId.AddRange(new[] { 11600 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

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


public sealed class TheSiege : QuestGrinderClass
{
    public TheSiege()
    {
        Name = "The Siege";

        QuestId.AddRange(new[] { 11797 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25227);
HotSpots.Add(new Vector3(2300.195 , 5468.83 , 2.470866 , "None"));
HotSpots.Add(new Vector3(2396.566 , 5447.697 , 3.69127 , "None"));
HotSpots.Add(new Vector3(2412.043 , 5338.485 , 0.7287627 , "None"));
HotSpots.Add(new Vector3(2209.732 , 5530.231 , 6.853307 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheSonofKarkut : QuestClass
{
    public TheSonofKarkut()
    {
        Name = "The Son of Karkut";

        QuestId.AddRange(new[] { 12086 });

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


public sealed class TheTidesTurn : QuestGrinderClass
{
    public TheTidesTurn()
    {
        Name = "The Tides Turn";

        QuestId.AddRange(new[] { 11968 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26266);
HotSpots.Add(new Vector3(2748.042 , 4720.607 , 2.33676 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheTridentofNazjan : QuestGrinderClass
{
    public TheTridentofNazjan()
    {
        Name = "The Trident of Naz'jan";

        QuestId.AddRange(new[] { 11625 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26451);
HotSpots.Add(new Vector3(1490.605 , 5401.563 , 38.1349 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TraveltoMoakiHarbor : QuestClass
{
    public TraveltoMoakiHarbor()
    {
        Name = "Travel to Moa'ki Harbor";

        QuestId.AddRange(new[] { 12117 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

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


public sealed class TridentPath : QuestFollowPathClass
{
    public TridentPath()
    {
        Name = "Trident Path";

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

        Path.Add(new Vector3(1758.821 , 6052.06 , 0.4698489 , "None"));
Path.Add(new Vector3(1755.451 , 6050.487 , 0.2860293 , "None"));
Path.Add(new Vector3(1752.874 , 6048.442 , -1.99374 , "Swimming"));
Path.Add(new Vector3(1748.976 , 6044.139 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1745.937 , 6040.59 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1739.11 , 6032.612 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1732.284 , 6024.634 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1725.457 , 6016.656 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1718.399 , 6008.406 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1711.804 , 6000.7 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1704.978 , 5992.722 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1697.919 , 5984.472 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1691.325 , 5976.766 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1684.253 , 5968.5 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1677.385 , 5960.474 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1670.614 , 5952.56 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1664.019 , 5944.853 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1656.961 , 5936.604 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1650.366 , 5928.897 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1643.54 , 5920.919 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1636.714 , 5912.941 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1628.921 , 5905.472 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1620.266 , 5900.317 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1610.401 , 5896.725 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1599.629 , 5897.333 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1589.558 , 5898.542 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1578.779 , 5899.836 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1568.667 , 5901.051 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1558.312 , 5902.547 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1547.87 , 5905.024 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1538.883 , 5901.286 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1530.504 , 5895.055 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1521.556 , 5889.714 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1514.624 , 5881.888 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1506.722 , 5875.171 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1497.094 , 5871.134 , -1.807447 , "Swimming"));
Path.Add(new Vector3(1489.937 , 5867.132 , -0.9503298 , "None"));
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


public sealed class TridentPoint : QuestFollowPathClass
{
    public TridentPoint()
    {
        Name = "Trident Point";

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

        Path.Add(new Vector3(1759.662 , 6051.608 , 0.4517506 , "None"));
Path.Add(new Vector3(1755.868 , 6049.41 , 0.1116059 , "None"));
Path.Add(new Vector3(1752.084 , 6047.207 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1748.323 , 6044.208 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1744.73 , 6041.123 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1741.16 , 6037.899 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1738.319 , 6034.014 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1735.403 , 6030.281 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1732.429 , 6026.475 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1729.282 , 6022.845 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1726.085 , 6019.351 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1722.868 , 6015.835 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1719.608 , 6012.271 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1716.417 , 6008.783 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1713.121 , 6005.18 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1709.914 , 6001.675 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1706.679 , 5998.139 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1703.453 , 5994.613 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1700.237 , 5991.098 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1696.957 , 5987.512 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1693.818 , 5984.081 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1690.525 , 5980.481 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1687.274 , 5976.927 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1684.073 , 5973.429 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1680.813 , 5969.865 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1677.596 , 5966.35 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1674.371 , 5962.824 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1671.119 , 5959.27 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1667.868 , 5955.716 , -2.263691 , "Swimming"));
Path.Add(new Vector3(1664.671 , 5952.221 , -0.877535 , "None"));
Path.Add(new Vector3(1661.15 , 5948.96 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1657.263 , 5946.115 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1653.441 , 5943.317 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1649.555 , 5940.472 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1645.668 , 5937.626 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1641.843 , 5934.826 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1637.956 , 5931.981 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1634.066 , 5929.133 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1630.24 , 5926.333 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1626.354 , 5923.487 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1622.532 , 5920.689 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1618.641 , 5917.842 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1614.755 , 5914.997 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1610.933 , 5912.199 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1607.047 , 5909.354 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1603.221 , 5906.553 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1599.334 , 5903.708 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1595.448 , 5900.863 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1591.561 , 5898.018 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1587.739 , 5895.22 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1583.914 , 5892.419 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1580.088 , 5889.619 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1576.141 , 5886.729 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1572.376 , 5883.973 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1568.364 , 5881.036 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1564.557 , 5878.25 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1560.644 , 5875.385 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1556.765 , 5872.545 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1552.943 , 5869.747 , -2.199565 , "Swimming"));
Path.Add(new Vector3(1549.123 , 5866.802 , -2.219013 , "Swimming"));
Path.Add(new Vector3(1545.264 , 5863.977 , -2.219013 , "Swimming"));
Path.Add(new Vector3(1541.442 , 5861.179 , -2.219013 , "Swimming"));
Path.Add(new Vector3(1537.669 , 5858.417 , -2.219013 , "Swimming"));
Path.Add(new Vector3(1533.669 , 5855.489 , -2.219013 , "Swimming"));
Path.Add(new Vector3(1529.843 , 5852.688 , -2.219013 , "Swimming"));
Path.Add(new Vector3(1525.987 , 5849.865 , -2.219013 , "Swimming"));
Path.Add(new Vector3(1522.131 , 5847.042 , -2.219013 , "Swimming"));
Path.Add(new Vector3(1518.244 , 5844.197 , -2.219013 , "Swimming"));
Path.Add(new Vector3(1514.804 , 5841.678 , -2.219013 , "Swimming"));
Path.Add(new Vector3(1510.532 , 5838.552 , -2.219013 , "Swimming"));
Path.Add(new Vector3(1506.665 , 5835.72 , -2.219013 , "Swimming"));
Path.Add(new Vector3(1501.564 , 5831.967 , -1.060904 , "None"));
Path.Add(new Vector3(1494.632 , 5826.708 , 1.172223 , "None"));
Path.Add(new Vector3(1488.309 , 5821.134 , 2.596041 , "None"));
Path.Add(new Vector3(1482.585 , 5814.965 , 4.474312 , "None"));
Path.Add(new Vector3(1476.665 , 5808.564 , 4.373412 , "None"));
Path.Add(new Vector3(1470.95 , 5802.384 , 3.89835 , "None"));
Path.Add(new Vector3(1469.782 , 5794.604 , 3.705112 , "None"));
Path.Add(new Vector3(1473.148 , 5787.136 , 3.722785 , "None"));
Path.Add(new Vector3(1477.49 , 5779.834 , 6.156709 , "None"));
Path.Add(new Vector3(1480.304 , 5771.859 , 11.16199 , "None"));
Path.Add(new Vector3(1484.271 , 5764.156 , 15.83321 , "None"));
Path.Add(new Vector3(1484.158 , 5755.889 , 19.45157 , "None"));
Path.Add(new Vector3(1481.702 , 5747.914 , 22.97997 , "None"));
Path.Add(new Vector3(1476.642 , 5741.392 , 23.60105 , "None"));
Path.Add(new Vector3(1471.377 , 5737.758 , 23.60105 , "None"));
Path.Add(new Vector3(1473.751 , 5734.896 , 23.60105 , "None"));
Path.Add(new Vector3(1473.834 , 5734.622 , 29.00538 , "None"));
Path.Add(new Vector3(1474.134 , 5734.008 , 23.60128 , "None"));
Path.Add(new Vector3(1473.947 , 5736.587 , 26.52188 , "None"));
Path.Add(new Vector3(1471.769 , 5734.046 , 23.60189 , "None"));
Path.Add(new Vector3(1470.887 , 5730.348 , 23.60189 , "None"));
Path.Add(new Vector3(1468.289 , 5727.902 , 23.60189 , "None"));
Path.Add(new Vector3(1462.127 , 5721.889 , 23.60189 , "None"));
Path.Add(new Vector3(1455.847 , 5716.966 , 23.60189 , "None"));
Path.Add(new Vector3(1447.408 , 5716.828 , 23.60189 , "None"));
Path.Add(new Vector3(1439.013 , 5717.427 , 23.60189 , "None"));
Path.Add(new Vector3(1430.617 , 5718.025 , 23.60189 , "None"));
Path.Add(new Vector3(1421.92 , 5718.646 , 23.60189 , "None"));
Path.Add(new Vector3(1414.134 , 5721.568 , 23.61295 , "None"));
Path.Add(new Vector3(1406.993 , 5719.171 , 23.59998 , "None"));
Path.Add(new Vector3(1401.588 , 5712.727 , 23.54915 , "None"));
Path.Add(new Vector3(1395.101 , 5707.568 , 23.58763 , "None"));
Path.Add(new Vector3(1393.552 , 5701.271 , 22.31126 , "None"));
Path.Add(new Vector3(1388.358 , 5694.268 , 18.06829 , "None"));
Path.Add(new Vector3(1383.337 , 5687.851 , 13.94365 , "None"));
Path.Add(new Vector3(1377.973 , 5680.999 , 9.819808 , "None"));
Path.Add(new Vector3(1372.774 , 5674.358 , 6.467693 , "None"));
Path.Add(new Vector3(1367.41 , 5667.505 , 5.927843 , "None"));
Path.Add(new Vector3(1362.211 , 5660.865 , 5.910384 , "None"));
Path.Add(new Vector3(1356.867 , 5653.996 , 5.931009 , "None"));
Path.Add(new Vector3(1352.14 , 5647.016 , 5.489844 , "None"));
Path.Add(new Vector3(1347.423 , 5640.024 , 5.448194 , "None"));
Path.Add(new Vector3(1342.706 , 5633.033 , 5.357997 , "None"));
Path.Add(new Vector3(1337.83 , 5625.805 , 5.353284 , "None"));
Path.Add(new Vector3(1333.282 , 5619.064 , 5.403394 , "None"));
Path.Add(new Vector3(1328.406 , 5611.836 , 5.324417 , "None"));
Path.Add(new Vector3(1327.046 , 5603.802 , 5.324417 , "None"));
Path.Add(new Vector3(1329.542 , 5595.467 , 6.314213 , "None"));
Path.Add(new Vector3(1332.044 , 5587.43 , 8.808871 , "None"));
Path.Add(new Vector3(1334.402 , 5579.052 , 12.01444 , "None"));
Path.Add(new Vector3(1335.975 , 5570.778 , 12.08538 , "None"));
Path.Add(new Vector3(1336.676 , 5562.374 , 12.08213 , "None"));
Path.Add(new Vector3(1336.795 , 5553.672 , 10.84664 , "None"));
Path.Add(new Vector3(1336.89 , 5545.244 , 8.202047 , "None"));
Path.Add(new Vector3(1337.072 , 5536.819 , 5.12211 , "None"));
Path.Add(new Vector3(1338.742 , 5528.315 , 5.328824 , "None"));
Path.Add(new Vector3(1342.302 , 5520.995 , 5.325575 , "None"));
Path.Add(new Vector3(1347.035 , 5513.728 , 5.35075 , "None"));
Path.Add(new Vector3(1352.417 , 5507.256 , 5.378976 , "None"));
Path.Add(new Vector3(1358.438 , 5500.965 , 5.359473 , "None"));
Path.Add(new Vector3(1364.391 , 5495.402 , 5.293609 , "None"));
Path.Add(new Vector3(1371.063 , 5489.381 , 5.276812 , "None"));
Path.Add(new Vector3(1377.36 , 5484.211 , 5.756896 , "None"));
Path.Add(new Vector3(1384.369 , 5479.058 , 9.618204 , "None"));
Path.Add(new Vector3(1391.301 , 5474.254 , 13.35662 , "None"));
Path.Add(new Vector3(1398.467 , 5469.287 , 17.22222 , "None"));
Path.Add(new Vector3(1405.385 , 5464.493 , 20.95396 , "None"));
Path.Add(new Vector3(1412.316 , 5459.688 , 22.3839 , "None"));
Path.Add(new Vector3(1419.013 , 5455.047 , 22.42082 , "None"));
Path.Add(new Vector3(1426.414 , 5449.917 , 25.04751 , "None"));
Path.Add(new Vector3(1433.331 , 5445.122 , 27.53142 , "None"));
Path.Add(new Vector3(1440.497 , 5440.155 , 28.37374 , "None"));
Path.Add(new Vector3(1447.415 , 5435.361 , 28.37374 , "None"));
Path.Add(new Vector3(1454.215 , 5430.373 , 30.01452 , "None"));
Path.Add(new Vector3(1460.944 , 5425.289 , 33.8016 , "None"));
Path.Add(new Vector3(1467.876 , 5420.027 , 37.58703 , "None"));
Path.Add(new Vector3(1472.586 , 5416.452 , 38.13278 , "None"));
Path.Add(new Vector3(1476.478 , 5414.353 , 38.1328 , "None"));
Path.Add(new Vector3(1481.124 , 5415.532 , 38.11705 , "None"));
Path.Add(new Vector3(1482.544 , 5418.896 , 38.13297 , "None"));
Path.Add(new Vector3(1481.46 , 5415.095 , 38.10818 , "None"));
Path.Add(new Vector3(1474.957 , 5416.549 , 38.12616 , "None"));
Path.Add(new Vector3(1467.644 , 5423.558 , 36.56738 , "None"));
Path.Add(new Vector3(1463.192 , 5430.696 , 32.72129 , "None"));
Path.Add(new Vector3(1459.121 , 5437.757 , 29.30769 , "None"));
Path.Add(new Vector3(1457.233 , 5448.103 , 28.37344 , "None"));
Path.Add(new Vector3(1461.546 , 5453.231 , 28.42234 , "None"));
Path.Add(new Vector3(1458.759 , 5448.858 , 28.54209 , "None"));
Path.Add(new Vector3(1458.305 , 5440.849 , 28.44604 , "None"));
Path.Add(new Vector3(1461.626 , 5433.172 , 31.32479 , "None"));
Path.Add(new Vector3(1464.763 , 5425.921 , 34.95479 , "None"));
Path.Add(new Vector3(1468.805 , 5420.267 , 37.83792 , "None"));
Path.Add(new Vector3(1473.829 , 5415.716 , 38.13168 , "None"));
Path.Add(new Vector3(1474.113 , 5416.345 , 41.74901 , "None"));
Path.Add(new Vector3(1474.335 , 5416.839 , 38.12827 , "None"));
Path.Add(new Vector3(1471.326 , 5424.038 , 37.61427 , "None"));
Path.Add(new Vector3(1466.663 , 5431.406 , 33.62147 , "None"));
Path.Add(new Vector3(1462.379 , 5438.664 , 29.75404 , "None"));
Path.Add(new Vector3(1459.446 , 5446.828 , 28.37327 , "None"));
Path.Add(new Vector3(1458.041 , 5454.836 , 28.87801 , "None"));
Path.Add(new Vector3(1456.553 , 5463.428 , 25.76184 , "None"));
Path.Add(new Vector3(1453.137 , 5470.833 , 22.4228 , "None"));
Path.Add(new Vector3(1447.198 , 5476.725 , 22.4228 , "None"));
Path.Add(new Vector3(1441.124 , 5482.957 , 20.91344 , "None"));
Path.Add(new Vector3(1435.238 , 5488.998 , 17.51431 , "None"));
Path.Add(new Vector3(1430.168 , 5495.354 , 10.74295 , "None"));
Path.Add(new Vector3(1434.149 , 5503.082 , 9.722665 , "None"));
Path.Add(new Vector3(1438.055 , 5510.232 , 4.478522 , "None"));
Path.Add(new Vector3(1441.602 , 5516.188 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1444.958 , 5519.531 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1448.372 , 5522.936 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1451.243 , 5526.799 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1454.029 , 5530.63 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1456.865 , 5534.529 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1459.65 , 5538.359 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1462.494 , 5542.145 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1465.673 , 5545.87 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1468.803 , 5549.537 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1471.878 , 5553.139 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1475.008 , 5556.806 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1478.083 , 5560.409 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1481.21 , 5564.073 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1484.337 , 5567.736 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1487.415 , 5571.342 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1491.503 , 5573.407 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1496.262 , 5574.151 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1500.942 , 5574.882 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1505.705 , 5575.627 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1510.464 , 5576.371 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1515.074 , 5577.395 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1519.602 , 5579.05 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1524.122 , 5580.703 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1528.443 , 5582.605 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1532.489 , 5585.078 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1536.663 , 5587.628 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1540.42 , 5590.517 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1544.143 , 5593.445 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1547.929 , 5596.422 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1551.062 , 5600.058 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1553.444 , 5604.082 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1554.906 , 5608.672 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1556.845 , 5613.046 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1559.311 , 5617.101 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1561.813 , 5621.216 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1564.321 , 5625.34 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1566.865 , 5629.524 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1569.37 , 5633.644 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1571.846 , 5637.715 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1574.343 , 5641.822 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1576.816 , 5645.89 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1579.287 , 5649.953 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1581.807 , 5654.097 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1584.289 , 5658.18 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1586.765 , 5662.251 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1589.255 , 5666.346 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1591.76 , 5670.466 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1594.527 , 5674.287 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1597.64 , 5677.969 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1600.75 , 5681.647 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1603.811 , 5685.268 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1606.917 , 5688.942 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1609.978 , 5692.563 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1613.088 , 5696.242 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1616.201 , 5699.923 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1619.213 , 5703.486 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1622.374 , 5707.226 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1625.478 , 5710.897 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1628.551 , 5714.532 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1631.615 , 5718.156 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1634.746 , 5721.86 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1637.783 , 5725.452 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1640.984 , 5729.238 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1643.972 , 5732.772 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1647.082 , 5736.45 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1650.213 , 5740.154 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1653.283 , 5743.785 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1656.38 , 5747.449 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1659.189 , 5751.233 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1661.346 , 5755.545 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1663.501 , 5759.853 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1665.656 , 5764.161 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1667.775 , 5768.396 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1669.932 , 5772.708 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1672.051 , 5776.944 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1674.467 , 5781.094 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1677.378 , 5784.831 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1680.387 , 5788.694 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1683.3 , 5792.435 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1686.211 , 5796.171 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1689.09 , 5799.867 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1692.116 , 5803.752 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1695.03 , 5807.492 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1698.007 , 5811.314 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1700.967 , 5815.114 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1703.875 , 5818.847 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1706.838 , 5822.651 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1709.801 , 5826.455 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1712.708 , 5830.188 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1715.671 , 5833.991 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1718.631 , 5837.791 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1721.1 , 5841.803 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1722.404 , 5846.423 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1723.897 , 5850.895 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1725.888 , 5855.281 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1727.881 , 5859.671 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1729.839 , 5863.984 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1731.863 , 5868.443 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1733.821 , 5872.755 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1735.814 , 5877.146 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1737.805 , 5881.532 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1739.763 , 5885.844 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1741.754 , 5890.23 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1743.714 , 5894.547 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1745.707 , 5898.938 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1747.698 , 5903.323 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1749.656 , 5907.636 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1751.649 , 5912.026 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1753.64 , 5916.412 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1756.155 , 5920.378 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1759.259 , 5924.067 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1762.609 , 5927.385 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1766.5 , 5930.489 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1771.464 , 5933.142 , -1.689159 , "None"));
Path.Add(new Vector3(1779.491 , 5935.781 , -0.2238654 , "None"));
Path.Add(new Vector3(1786.413 , 5939.911 , 0.2773124 , "None"));
Path.Add(new Vector3(1790.943 , 5946.993 , 0.3944734 , "None"));
Path.Add(new Vector3(1794.887 , 5954.769 , 0.3953531 , "None"));
Path.Add(new Vector3(1799.524 , 5961.308 , 0.3968221 , "None"));
Path.Add(new Vector3(1803.481 , 5969.039 , 0.3968221 , "None"));
Path.Add(new Vector3(1807.609 , 5977.023 , 0.4101722 , "None"));
Path.Add(new Vector3(1811.197 , 5983.962 , 0.4240672 , "None"));
Path.Add(new Vector3(1814.917 , 5991.155 , 0.430061 , "None"));
Path.Add(new Vector3(1818.604 , 5998.287 , 0.4373402 , "None"));
Path.Add(new Vector3(1820.699 , 6005.519 , 0.4531819 , "None"));
Path.Add(new Vector3(1817.332 , 6013.495 , 0.4779586 , "None"));
Path.Add(new Vector3(1813.139 , 6020.813 , 0.4939583 , "None"));
Path.Add(new Vector3(1808.954 , 6028.115 , 0.4919583 , "None"));
Path.Add(new Vector3(1803.432 , 6034.436 , 1.022362 , "None"));
Path.Add(new Vector3(1796.411 , 6038.633 , 1.566022 , "None"));
Path.Add(new Vector3(1793.194 , 6045.098 , 1.979952 , "None"));
Path.Add(new Vector3(1795.87 , 6053.058 , 2.644636 , "None"));
Path.Add(new Vector3(1799.514 , 6055.668 , 2.927264 , "None"));
Path.Add(new Vector3(1803.692 , 6058.616 , 3.24832 , "None"));
Path.Add(new Vector3(1806.281 , 6052 , 2.808176 , "None"));
Path.Add(new Vector3(1812.006 , 6046.061 , 1.244674 , "None"));
Path.Add(new Vector3(1818.01 , 6039.831 , 1.004863 , "None"));
Path.Add(new Vector3(1821.631 , 6036.073 , 0.6420072 , "None"));
Path.Add(new Vector3(1815.979 , 6037.485 , 0.7537256 , "None"));
Path.Add(new Vector3(1808.227 , 6040.519 , 0.7222142 , "None"));
Path.Add(new Vector3(1801.496 , 6045.6 , 2.210902 , "None"));
Path.Add(new Vector3(1795.167 , 6050.397 , 2.426872 , "None"));
Path.Add(new Vector3(1797.211 , 6055.177 , 2.8363 , "None"));
Path.Add(new Vector3(1793.172 , 6053.301 , 3.640843 , "None"));
Path.Add(new Vector3(1795.036 , 6057.487 , 2.960744 , "None"));
Path.Add(new Vector3(1797.445 , 6054.908 , 2.823109 , "None"));
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


public sealed class TridentPoint1 : QuestFollowPathClass
{
    public TridentPoint1()
    {
        Name = "Trident Point 1";

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

        Path.Add(new Vector3(1474.335 , 5416.839 , 38.12827 , "None"));
Path.Add(new Vector3(1472.181 , 5422.593 , 38.13262 , "None"));
Path.Add(new Vector3(1467.714 , 5429.745 , 34.60147 , "None"));
Path.Add(new Vector3(1463.281 , 5436.917 , 30.45128 , "None"));
Path.Add(new Vector3(1459.885 , 5444.62 , 28.37327 , "None"));
Path.Add(new Vector3(1458.321 , 5453.18 , 29.10956 , "None"));
Path.Add(new Vector3(1456.889 , 5461.491 , 26.72447 , "None"));
Path.Add(new Vector3(1454.565 , 5469.386 , 22.4228 , "None"));
Path.Add(new Vector3(1448.588 , 5475.311 , 22.4228 , "None"));
Path.Add(new Vector3(1442.495 , 5481.549 , 21.53816 , "None"));
Path.Add(new Vector3(1436.61 , 5487.589 , 18.74102 , "None"));
Path.Add(new Vector3(1430.537 , 5493.823 , 11.30638 , "None"));
Path.Add(new Vector3(1433.207 , 5501.356 , 10.30837 , "None"));
Path.Add(new Vector3(1437.25 , 5508.758 , 5.931143 , "None"));
Path.Add(new Vector3(1441.197 , 5515.813 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1444.567 , 5519.141 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1447.981 , 5522.545 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1450.871 , 5526.288 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1453.704 , 5530.183 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1456.492 , 5534.017 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1459.325 , 5537.913 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1462.188 , 5541.786 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1465.265 , 5545.392 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1468.442 , 5549.113 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1471.52 , 5552.719 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1474.65 , 5556.386 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1477.78 , 5560.053 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1480.852 , 5563.652 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1483.982 , 5567.319 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1487.106 , 5570.979 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1490.957 , 5573.322 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1495.716 , 5574.066 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1500.396 , 5574.797 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1505.159 , 5575.542 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1509.918 , 5576.286 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1514.555 , 5577.205 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1519.079 , 5578.859 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1523.603 , 5580.513 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1527.972 , 5582.317 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1532.082 , 5584.829 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1536.123 , 5587.299 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1539.982 , 5590.173 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1543.772 , 5593.153 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1547.495 , 5596.081 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1550.722 , 5599.628 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1553.301 , 5603.632 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1554.738 , 5608.145 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1556.558 , 5612.574 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1559.021 , 5616.625 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1561.524 , 5620.74 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1564.029 , 5624.86 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1566.581 , 5629.056 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1569.068 , 5633.147 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1571.657 , 5637.404 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1574.13 , 5641.471 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1576.622 , 5645.571 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1579.132 , 5649.698 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1581.588 , 5653.737 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1584.098 , 5657.865 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1586.573 , 5661.936 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1589.01 , 5665.943 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1591.554 , 5670.127 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1594.326 , 5674.049 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1597.332 , 5677.605 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1600.497 , 5681.348 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1603.554 , 5684.965 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1606.664 , 5688.643 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1609.774 , 5692.322 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1612.835 , 5695.942 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1615.945 , 5699.621 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1619.054 , 5703.299 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1622.115 , 5706.919 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1625.222 , 5710.594 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1628.326 , 5714.265 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1631.402 , 5717.904 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1634.454 , 5721.514 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1637.588 , 5725.221 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1640.984 , 5729.238 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1643.789 , 5732.556 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1646.841 , 5736.166 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1649.956 , 5739.851 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1652.975 , 5743.421 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1656.176 , 5747.208 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1659.047 , 5750.95 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1661.204 , 5755.262 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1663.323 , 5759.498 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1665.481 , 5763.81 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1667.634 , 5768.114 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1669.755 , 5772.354 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1671.91 , 5776.662 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1674.223 , 5780.782 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1677.186 , 5784.585 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1680.097 , 5788.322 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1683.057 , 5792.122 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1686.017 , 5795.921 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1688.956 , 5799.695 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1691.873 , 5803.439 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1694.792 , 5807.187 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1697.714 , 5810.938 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1700.68 , 5814.746 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1703.683 , 5818.602 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1706.594 , 5822.338 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1709.557 , 5826.142 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1712.517 , 5829.941 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1715.43 , 5833.682 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1718.39 , 5837.481 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1720.936 , 5841.441 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1722.315 , 5846.037 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1723.766 , 5850.607 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1725.726 , 5854.924 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1727.75 , 5859.383 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1729.71 , 5863.7 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1731.701 , 5868.086 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1733.53 , 5872.115 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1735.65 , 5876.785 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1737.641 , 5881.17 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1739.632 , 5885.556 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1741.592 , 5889.873 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1743.583 , 5894.259 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1745.543 , 5898.576 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1747.534 , 5902.962 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1749.494 , 5907.279 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1751.485 , 5911.665 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1753.476 , 5916.051 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1755.903 , 5920.078 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1759.004 , 5923.764 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1762.362 , 5927.188 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1766.068 , 5930.144 , -2.528315 , "Swimming"));
Path.Add(new Vector3(1770.139 , 5932.706 , -2.053981 , "None"));
Path.Add(new Vector3(1778.135 , 5935.335 , -0.3984609 , "None"));
Path.Add(new Vector3(1785.737 , 5939.011 , 0.238212 , "None"));
Path.Add(new Vector3(1790.401 , 5946.007 , 0.386194 , "None"));
Path.Add(new Vector3(1794.25 , 5953.509 , 0.3973069 , "None"));
Path.Add(new Vector3(1798.895 , 5960.063 , 0.3968221 , "None"));
Path.Add(new Vector3(1802.833 , 5967.786 , 0.3968221 , "None"));
Path.Add(new Vector3(1806.706 , 5975.277 , 0.4087238 , "None"));
Path.Add(new Vector3(1810.572 , 5982.753 , 0.4228632 , "None"));
Path.Add(new Vector3(1814.469 , 5990.29 , 0.4296273 , "None"));
Path.Add(new Vector3(1818.45 , 5997.988 , 0.4367484 , "None"));
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


public sealed class VeehjasRevenge : QuestGrinderClass
{
    public VeehjasRevenge()
    {
        Name = "Veehja's Revenge";

        QuestId.AddRange(new[] { 12490 });

        Step = new List<int> { 6, 3, 2, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25523);
EntryTarget.Add(25613);
EntryTarget.Add(25520);
HotSpots.Add(new Vector3(1496.75 , 5818.3 , 2.29096 , "None"));
HotSpots.Add(new Vector3(1480.81 , 5831.38 , 3.20737 , "None"));
HotSpots.Add(new Vector3(1462.79 , 5775.25 , 0.445026 , "None"));
HotSpots.Add(new Vector3(1443.62 , 5787.06 , 0.310595 , "None"));
HotSpots.Add(new Vector3(1467.471 , 5791.733 , 2.994138 , "None"));
HotSpots.Add(new Vector3(1461.456 , 5720.426 , 23.60094 , "None"));
HotSpots.Add(new Vector3(1327.388 , 5614.232 , 5.325336 , "None"));
HotSpots.Add(new Vector3(1339.98 , 5570.77 , 12.1186 , "None"));
HotSpots.Add(new Vector3(1363.75 , 5568.55 , 14.0011 , "None"));
HotSpots.Add(new Vector3(1368.64 , 5597.19 , 12.2564 , "None"));
HotSpots.Add(new Vector3(1367.503 , 5497.933 , 5.2754 , "None"));
HotSpots.Add(new Vector3(1428.55 , 5476.22 , 22.4155 , "None"));
HotSpots.Add(new Vector3(1405.99 , 5440.78 , 22.4214 , "None"));
HotSpots.Add(new Vector3(1472.05 , 5404.8 , 38.13516 , "None"));
HotSpots.Add(new Vector3(1484.92 , 5419.27 , 38.13418 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WeaponsforFarshire : QuestClass
{
    public WeaponsforFarshire()
    {
        Name = "Weapons for Farshire";

        QuestId.AddRange(new[] { 11963 });

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


public sealed class Wino : QuestFollowPathClass
{
    public Wino()
    {
        Name = "Wino";

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

        Path.Add(new Vector3(2247.595 , 5171.939 , 11.7705 , "None"));
Path.Add(new Vector3(2252.008 , 5169.387 , 11.7705 , "None"));
Path.Add(new Vector3(2258.906 , 5167.203 , 8.361546 , "None"));
Path.Add(new Vector3(2265.154 , 5164.591 , 4.418731 , "None"));
Path.Add(new Vector3(2271.362 , 5161.394 , 1.282963 , "None"));
Path.Add(new Vector3(2276.798 , 5156.998 , 1.282963 , "None"));
Path.Add(new Vector3(2282.139 , 5152.477 , 1.281494 , "None"));
Path.Add(new Vector3(2287.453 , 5147.591 , 1.51283 , "None"));
Path.Add(new Vector3(2291.402 , 5141.828 , 1.087155 , "None"));
Path.Add(new Vector3(2294.456 , 5135.781 , -0.5411156 , "None"));
Path.Add(new Vector3(2296.71 , 5131.042 , -2.775831 , "Swimming"));
Path.Add(new Vector3(2298.914 , 5127.027 , -2.86683 , "Swimming"));
Path.Add(new Vector3(2300.989 , 5122.805 , -2.722826 , "Swimming"));
Path.Add(new Vector3(2303.175 , 5118.64 , -2.722826 , "Swimming"));
Path.Add(new Vector3(2305.633 , 5114.603 , -2.722826 , "Swimming"));
Path.Add(new Vector3(2308.008 , 5110.521 , -2.722826 , "Swimming"));
Path.Add(new Vector3(2310.176 , 5106.321 , -2.722826 , "Swimming"));
Path.Add(new Vector3(2312.339 , 5102.128 , -2.722826 , "Swimming"));
Path.Add(new Vector3(2314.504 , 5097.932 , -2.722826 , "Swimming"));
Path.Add(new Vector3(2316.668 , 5093.735 , -2.722826 , "Swimming"));
Path.Add(new Vector3(2318.836 , 5089.534 , -2.722826 , "Swimming"));
Path.Add(new Vector3(2321 , 5085.337 , -2.722826 , "Swimming"));
Path.Add(new Vector3(2323.166 , 5081.141 , -2.722826 , "Swimming"));
Path.Add(new Vector3(2325.331 , 5076.944 , -2.722826 , "Swimming"));
Path.Add(new Vector3(2328.335 , 5073.337 , -2.722826 , "Swimming"));
Path.Add(new Vector3(2331.124 , 5069.527 , -2.722826 , "Swimming"));
Path.Add(new Vector3(2333.916 , 5065.712 , -2.722826 , "Swimming"));
Path.Add(new Vector3(2336.704 , 5061.901 , -2.722826 , "Swimming"));
Path.Add(new Vector3(2339.49 , 5058.094 , -2.722826 , "Swimming"));
Path.Add(new Vector3(2342.237 , 5054.352 , -3.276588 , "Swimming"));
Path.Add(new Vector3(2344.168 , 5051.219 , -6.162292 , "Swimming"));
Path.Add(new Vector3(2345.868 , 5048.198 , -9.372867 , "Swimming"));
Path.Add(new Vector3(2348.014 , 5045.301 , -12.40076 , "Swimming"));
Path.Add(new Vector3(2350.445 , 5042.452 , -15.27754 , "Swimming"));
Path.Add(new Vector3(2353.43 , 5038.925 , -18.05633 , "Swimming"));
Path.Add(new Vector3(2356.272 , 5035.876 , -20.26668 , "Swimming"));
Path.Add(new Vector3(2357.346 , 5032.961 , -23.7938 , "Swimming"));
Path.Add(new Vector3(2358.565 , 5030.308 , -27.48303 , "Swimming"));
Path.Add(new Vector3(2357.794 , 5025.716 , -28.0439 , "Swimming"));
Path.Add(new Vector3(2358.389 , 5021.08 , -28.65389 , "Swimming"));
Path.Add(new Vector3(2361.051 , 5017.394 , -29.51199 , "Swimming"));
Path.Add(new Vector3(2362.257 , 5012.913 , -30.38727 , "Swimming"));
Path.Add(new Vector3(2364.522 , 5009.587 , -32.99029 , "Swimming"));
Path.Add(new Vector3(2367.985 , 5007.663 , -35.50641 , "Swimming"));
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


public sealed class WordontheStreet : QuestClass
{
    public WordontheStreet()
    {
        Name = "Word on the Street";

        QuestId.AddRange(new[] { 11927 });

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
