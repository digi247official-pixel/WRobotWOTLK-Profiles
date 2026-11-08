
using System.Linq;
using robotManager.Helpful;
using wManager.Wow.Class;
using wManager.Wow.Enums;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;
using System.Collections.Generic;
using System.Threading;
using wManager.Wow.Bot.Tasks;


public sealed class DarkHeart : QuestUseItemOnClass
{
    public DarkHeart()
    {
        Name = "Dark Heart";

        QuestId.AddRange(new[] { 3062 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(-2758.946 , 2615.54 , 67.96283 , "None"));
ItemId = 9530;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GadgetzanWaterSurvey : QuestUseItemOnClass
{
    public GadgetzanWaterSurvey()
    {
        Name = "Gadgetzan Water Survey";

        QuestId.AddRange(new[] { 992 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(-7215.553 , -2908.959 , 6.397548 , "None"));
ItemId = 8584;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ImprovedQuality2 : QuestGrinderClass
{
    public ImprovedQuality2()
    {
        Name = "Improved Quality2";

        QuestId.AddRange(new[] { 7734 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryTarget.Add(5299);
EntryTarget.Add(5296);
HotSpots.Add(new Vector3(-3805.995 , 1811.034 , 136.1059 , "None"));
HotSpots.Add(new Vector3(-3838.214 , 1807.089 , 129.9196 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class InGoodTaste : QuestClass
{
    public InGoodTaste()
    {
        Name = "In Good Taste";

        QuestId.AddRange(new[] { 2606 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class InsectPartsAnalysis : QuestClass
{
    public InsectPartsAnalysis()
    {
        Name = "Insect Parts Analysis";

        QuestId.AddRange(new[] { 110 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class InsectPartsAnalysis2 : QuestClass
{
    public InsectPartsAnalysis2()
    {
        Name = "Insect Parts Analysis 2";

        QuestId.AddRange(new[] { 113 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MarchofSilith : QuestClass
{
    public MarchofSilith()
    {
        Name = "March of Silith";

        QuestId.AddRange(new[] { 4494 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MoreWastewanderJustice : QuestGrinderClass
{
    public MoreWastewanderJustice()
    {
        Name = "More Wastewander Justice";

        QuestId.AddRange(new[] { 1691 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryTarget.Add(5615);
EntryTarget.Add(5623);
EntryTarget.Add(5617);
HotSpots.Add(new Vector3(-7645.634 , -4273.989 , 9.329895 , "None"));
HotSpots.Add(new Vector3(-7549.67 , -4272.18 , 8.888618 , "None"));
HotSpots.Add(new Vector3(-7582.771 , -4247.768 , 8.966777 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class NaxiousLairInvestigation : QuestGrinderClass
{
    public NaxiousLairInvestigation()
    {
        Name = "Naxious Lair Investigation";

        QuestId.AddRange(new[] { 82 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryTarget.Add(5456);
EntryTarget.Add(5458);
HotSpots.Add(new Vector3(-7752.295 , -2751.364 , 8.807765 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PerfectYetiHide : QuestClass
{
    public PerfectYetiHide()
    {
        Name = "Perfect Yeti Hide";

        QuestId.AddRange(new[] { 7738 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 18972;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PirateHatsAhoy : QuestGrinderClass
{
    public PirateHatsAhoy()
    {
        Name = "Pirate Hats Ahoy";

        QuestId.AddRange(new[] { 8365 });

        Step = new List<int> { 20, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryTarget.Add(7855);
HotSpots.Add(new Vector3(-7858.309 , -5133.009 , 6.731069 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RiseoftheSilith : QuestClass
{
    public RiseoftheSilith()
    {
        Name = "Rise of the Silith";

        QuestId.AddRange(new[] { 32 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SouthseaShakedown : QuestGrinderClass
{
    public SouthseaShakedown()
    {
        Name = "Southsea Shakedown";

        QuestId.AddRange(new[] { 8366 });

        Step = new List<int> { 10, 10, 10, 10, 0 };

        StepAutoDetect = new[] { true, true, true, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryTarget.Add(7855);
EntryTarget.Add(7856);
EntryTarget.Add(7857);
EntryTarget.Add(7858);
HotSpots.Add(new Vector3(-8018.117 , -5244.596 , 0.5970336 , "None"));
HotSpots.Add(new Vector3(-8081.369 , -5269.872 , 0.60649 , "None"));
HotSpots.Add(new Vector3(-8012.207 , -5326.259 , 0.6394626 , "None"));
HotSpots.Add(new Vector3(-7981.995 , -5414.593 , 1.121128 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheDunemaulCompound : QuestGrinderClass
{
    public TheDunemaulCompound()
    {
        Name = "The Dunemaul Compound";

        QuestId.AddRange(new[] { 5863 });

        Step = new List<int> { 10, 10, 1, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryTarget.Add(5472);
EntryTarget.Add(5474);
EntryTarget.Add(12046);
HotSpots.Add(new Vector3(-8529.95 , -3076.275 , 7.62313 , "None"));
HotSpots.Add(new Vector3(-8443.113 , -2831.988 , 9.335649 , "None"));
HotSpots.Add(new Vector3(-8358.841 , -3022.334 , 8.759758 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheScrimshankRedemption : QuestGathererClass
{
    public TheScrimshankRedemption()
    {
        Name = "The Scrimshank Redemption";

        QuestId.AddRange(new[] { 10 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryIdObjects.Add(144053);
HotSpots.Add(new Vector3(-9153.966 , -4084.513 , -46.03967 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheThirstyGoblin : QuestGrinderClass
{
    public TheThirstyGoblin()
    {
        Name = "The Thirsty Goblin";

        QuestId.AddRange(new[] { 2605 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryTarget.Add(5481);
HotSpots.Add(new Vector3(-8846.327 , -2313.038 , 8.877632 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThistleshrubValley : QuestGrinderClass
{
    public ThistleshrubValley()
    {
        Name = "Thistleshrub Valley";

        QuestId.AddRange(new[] { 3362 });

        Step = new List<int> { 8, 8, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryTarget.Add(5485);
EntryTarget.Add(5490);
HotSpots.Add(new Vector3(-8902.981 , -2330.671 , 8.952435 , "None"));
HotSpots.Add(new Vector3(-8924.422 , -2243.074 , 8.877171 , "None"));
HotSpots.Add(new Vector3(-8778.302 , -2289.281 , 9.050189 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class VengeaneontheNorthspring : QuestGrinderClass
{
    public VengeaneontheNorthspring()
    {
        Name = "Vengeane on the Northspring";

        QuestId.AddRange(new[] { 3063 });

        Step = new List<int> { 4, 4, 4, 4, 0 };

        StepAutoDetect = new[] { true, true, true, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryTarget.Add(5363);
EntryTarget.Add(5362);
EntryTarget.Add(5364);
HotSpots.Add(new Vector3(-3000.351 , 2714.069 , 51.17549 , "None"));
HotSpots.Add(new Vector3(-3012.761 , 2643.754 , 58.67773 , "None"));
HotSpots.Add(new Vector3(-2921.037 , 2566.754 , 51.93961 , "None"));
HotSpots.Add(new Vector3(-3012.987 , 2778.479 , 52.82464 , "None"));
HotSpots.Add(new Vector3(-3032.2 , 2773.524 , 57.06255 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WANTEDAndi : QuestGrinderClass
{
    public WANTEDAndi()
    {
        Name = "WANTED Andi";

        QuestId.AddRange(new[] { 2875 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryTarget.Add(7883);
HotSpots.Add(new Vector3(-8043.38 , -5281.05 , 0.5796056 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WANTEDCaliphy : QuestGrinderClass
{
    public WANTEDCaliphy()
    {
        Name = "WANTED Caliphy ";

        QuestId.AddRange(new[] { 2781 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryTarget.Add(7847);
HotSpots.Add(new Vector3(-7598.692 , -4554.336 , 9.381311 , "None"));
HotSpots.Add(new Vector3(-7618.781 , -4453.218 , 10.20724 , "None"));
HotSpots.Add(new Vector3(-7683.497 , -4314.566 , 10.2403 , "None"));
HotSpots.Add(new Vector3(-7688.49 , -4596.52 , 9.178119 , "None"));
HotSpots.Add(new Vector3(-7644.739 , -4674.394 , 10.23149 , "None"));
HotSpots.Add(new Vector3(-7577.023 , -4618.705 , 10.52284 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WastewanderJustice : QuestGrinderClass
{
    public WastewanderJustice()
    {
        Name = "Wastewander Justice";

        QuestId.AddRange(new[] { 1690 });

        Step = new List<int> { 10, 10, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryTarget.Add(5616);
EntryTarget.Add(5618);
HotSpots.Add(new Vector3(-6952.188 , -4289.836 , 9.46369 , "None"));
HotSpots.Add(new Vector3(-7009.478 , -4357.931 , 9.802135 , "None"));
HotSpots.Add(new Vector3(-7215.89 , -4617.47 , 8.874468 , "None"));
HotSpots.Add(new Vector3(-7276.185 , -4543.197 , 8.883413 , "None"));
HotSpots.Add(new Vector3(-7289.749 , -4553.587 , 9.530898 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WaterPouchBounty : QuestGrinderClass
{
    public WaterPouchBounty()
    {
        Name = "Water Pouch Bounty";

        QuestId.AddRange(new[] { 1707 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryTarget.Add(5616);
EntryTarget.Add(5618);
HotSpots.Add(new Vector3(-6955.972 , -4287.694 , 9.16424 , "None"));
HotSpots.Add(new Vector3(-7279.017 , -4548.211 , 9.098099 , "None"));
HotSpots.Add(new Vector3(-7215.89 , -4617.47 , 8.874468 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Feralas4551 : QuestGrinderClass
{
    public Feralas4551()
    {
        Name = "Feralas 45 - 51";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 45;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryTarget.Add(5236);
EntryTarget.Add(5239);
EntryTarget.Add(5238);
EntryTarget.Add(5241);
EntryTarget.Add(5240);
EntryTarget.Add(5232);
EntryTarget.Add(5234);
HotSpots.Add(new Vector3(-5288.296 , 1321.478 , 47.58487 , "None"));
HotSpots.Add(new Vector3(-5398.188 , 1408.418 , 31.05895 , "None"));
HotSpots.Add(new Vector3(-5604.375 , 1371.429 , 54.12991 , "None"));
HotSpots.Add(new Vector3(-5454.27 , 1283.525 , 19.19164 , "None"));
HotSpots.Add(new Vector3(-5553.835 , 1235.692 , 19.33608 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}
