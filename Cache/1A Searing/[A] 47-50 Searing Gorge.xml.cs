
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



public sealed class LunksTask : QuestGrinderClass
{
    public LunksTask()
    {
        Name = "Lunk's Task";

        QuestId.AddRange(new[] { 27956 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 999;
        RequiredQuest = 0;

        EntryTarget.Add(5853);
HotSpots.Add(new Vector3(-6937.997 , -1739.295 , 240.7435 , "None"));
HotSpots.Add(new Vector3(-6957.813 , -1755.045 , 242.6946 , "None"));
HotSpots.Add(new Vector3(-6939.639 , -1706.37 , 241.6662 , "None"));
HotSpots.Add(new Vector3(-6980.193 , -1695.224 , 241.6673 , "None"));
HotSpots.Add(new Vector3(-6974.749 , -1690.58 , 241.3703 , "None"));
HotSpots.Add(new Vector3(-7008.221 , -1685.133 , 241.2184 , "None"));
HotSpots.Add(new Vector3(-7063.131 , -1718.839 , 241.6736 , "None"));
HotSpots.Add(new Vector3(-7093.001 , -1740.505 , 244.2549 , "None"));
HotSpots.Add(new Vector3(-7119.97 , -1772.667 , 255.7812 , "None"));
HotSpots.Add(new Vector3(-7098.005 , -1773.986 , 263.7748 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ANewMasterButWho : QuestGrinderClass
{
    public ANewMasterButWho()
    {
        Name = "A New Master... But Who?";

        QuestId.AddRange(new[] { 27963 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 999;
        RequiredQuest = 0;

        EntryTarget.Add(47270);
HotSpots.Add(new Vector3(-6996.992 , -1714.877 , 241.7015 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheFewertheBetter : QuestGrinderClass
{
    public TheFewertheBetter()
    {
        Name = "The Fewer, the Better";

        QuestId.AddRange(new[] { 27960 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 999;
        RequiredQuest = 0;

        EntryTarget.Add(5839);
HotSpots.Add(new Vector3(-6961.51 , -1719.15 , 242.4718 , "None"));
HotSpots.Add(new Vector3(-6967.924 , -1738.194 , 241.8537 , "None"));
HotSpots.Add(new Vector3(-6980.691 , -1743.984 , 242.8981 , "None"));
HotSpots.Add(new Vector3(-7081.522 , -1790.158 , 267.7245 , "None"));
HotSpots.Add(new Vector3(-7062.27 , -1774.12 , 262.1615 , "None"));
HotSpots.Add(new Vector3(-7056.97 , -1757.42 , 255.1273 , "None"));
HotSpots.Add(new Vector3(-7047.164 , -1734.786 , 245.104 , "None"));
HotSpots.Add(new Vector3(-7010.433 , -1713.387 , 241.7519 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}

public sealed class OutofPlace : QuestInteractWithClass
{
    public OutofPlace()
    {
        QuestId.Add (27961); // Add quest id

        Step.AddRange(new[] { 8, 0, 0, 0 });// Objective required count

        EntryIdTarget.Add(47278); // Entry id of creature/npc at interact with
        GossipOptionNpcInteractWith = 0; // This options is only if npc has menu
        HotSpots.Add(new Vector3(-6758.731f, -1788.374f, 256.8412f));
        HotSpots.Add(new Vector3(-7049.327f, -1659.954f, 243.3205f));
        HotSpots.Add(new Vector3(-7146.27f, -1684.584f, 240.5157f));
        HotSpots.Add(new Vector3(-7202.707f, -1727.683f, 244.4458f));
        HotSpots.Add(new Vector3(-7191.464f, -1590.197f, 239.9604f));
        HotSpots.Add(new Vector3(-7119.819f, -1562.2f, 243.7762f));

    }
}

public sealed class AProperAntivenom : QuestGrinderClass
{
    public AProperAntivenom()
    {
        Name = "A Proper Antivenom";

        QuestId.AddRange(new[] { 27958 });

        Step = new List<int> { 14, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 999;
        RequiredQuest = 0;

        EntryTarget.Add(5856);
HotSpots.Add(new Vector3(-6890.633 , -1606.705 , 245.5605 , "None"));
HotSpots.Add(new Vector3(-6961.82 , -1648.679 , 240.8869 , "None"));
HotSpots.Add(new Vector3(-6950.446 , -1579.876 , 243.9121 , "None"));
HotSpots.Add(new Vector3(-6981.151 , -1523.064 , 244.851 , "None"));
HotSpots.Add(new Vector3(-7058.617 , -1584.439 , 247.342 , "None"));
HotSpots.Add(new Vector3(-7050.413 , -1515.621 , 242.3808 , "None"));
HotSpots.Add(new Vector3(-7116.325 , -1516.832 , 240.408 , "None"));
HotSpots.Add(new Vector3(-7159.333 , -1585.998 , 244.6231 , "None"));
HotSpots.Add(new Vector3(-7112.938 , -1547.699 , 244.7445 , "None"));
HotSpots.Add(new Vector3(-7202.923 , -1486.832 , 240.3188 , "None"));
HotSpots.Add(new Vector3(-7118.492 , -1525.558 , 241.9889 , "None"));
HotSpots.Add(new Vector3(-7067.176 , -1486.674 , 242.3567 , "None"));
HotSpots.Add(new Vector3(-6973.866 , -1542.472 , 244.122 , "None"));
HotSpots.Add(new Vector3(-6806.569 , -1782.866 , 256.858 , "None"));
HotSpots.Add(new Vector3(-6614.755 , -1875.018 , 244.2337 , "None"));
HotSpots.Add(new Vector3(-6612.058 , -1932.81 , 246.0789 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ALumberingRelic : QuestGrinderClass
{
    public ALumberingRelic()
    {
        Name = "A Lumbering Relic";

        QuestId.AddRange(new[] { 27962 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 999;
        RequiredQuest = 0;

        EntryTarget.Add(5833);
HotSpots.Add(new Vector3(-7193.177 , -1929.22 , 321.0758 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheSpidersHavetoGo : QuestGrinderClass
{
    public TheSpidersHavetoGo()
    {
        Name = "The Spiders Have to Go";

        QuestId.AddRange(new[] { 27980 });

        Step = new List<int> { 9, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 999;
        RequiredQuest = 0;

        EntryTarget.Add(5858);
HotSpots.Add(new Vector3(-6657.494 , -948.8917 , 257.7796 , "None"));
HotSpots.Add(new Vector3(-6731.239 , -931.1874 , 251.9521 , "None"));
HotSpots.Add(new Vector3(-6788.233 , -953.7289 , 240.837 , "None"));
HotSpots.Add(new Vector3(-6802.95 , -920.9029 , 246.4545 , "None"));
HotSpots.Add(new Vector3(-6872.344 , -920.6956 , 243.7111 , "None"));
HotSpots.Add(new Vector3(-6924.184 , -953.8221 , 240.7446 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class toLevel50 : QuestGrinderClass
{
    public toLevel50()
    {
        Name = "to Level 50";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 45;
        MaxLevel = 49;
        RequiredQuest = 0;

        EntryTarget.Add(5854);
EntryTarget.Add(5852);
EntryTarget.Add(5840);
EntryTarget.Add(5850);
HotSpots.Add(new Vector3(-6713.869 , -1046.75 , 240.1576 , "None"));
HotSpots.Add(new Vector3(-6745.985 , -1084.811 , 244.2137 , "None"));
HotSpots.Add(new Vector3(-6714.964 , -1110.31 , 246.3789 , "None"));
HotSpots.Add(new Vector3(-6710.331 , -1181.836 , 240.4052 , "None"));
HotSpots.Add(new Vector3(-6671.214 , -1153.084 , 241.9056 , "None"));
HotSpots.Add(new Vector3(-6785.879 , -1111.18 , 243.2465 , "None"));
HotSpots.Add(new Vector3(-6799.014 , -1092.398 , 243.8798 , "None"));
HotSpots.Add(new Vector3(-6757.869 , -1153.823 , 241.0845 , "None"));
HotSpots.Add(new Vector3(-6824.204 , -1150.675 , 240.3484 , "None"));
HotSpots.Add(new Vector3(-6836.132 , -1226.955 , 240.1509 , "None"));
HotSpots.Add(new Vector3(-6861.027 , -1204.33 , 240.4443 , "None"));
HotSpots.Add(new Vector3(-6859.342 , -1278.173 , 242.9094 , "None"));
HotSpots.Add(new Vector3(-6810.577 , -1278.006 , 240.0715 , "None"));
HotSpots.Add(new Vector3(-6750.611 , -1328.408 , 241.1215 , "None"));
HotSpots.Add(new Vector3(-6758.99 , -1380.76 , 241.0723 , "None"));
HotSpots.Add(new Vector3(-6703.706 , -1285.878 , 240.7319 , "None"));
HotSpots.Add(new Vector3(-6662.51 , -1283.533 , 239.4018 , "None"));
HotSpots.Add(new Vector3(-6684.647 , -1309.93 , 241.8922 , "None"));
HotSpots.Add(new Vector3(-6649.256 , -1355.617 , 248.904 , "None"));
HotSpots.Add(new Vector3(-6620.419 , -1273.798 , 262.1392 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}
