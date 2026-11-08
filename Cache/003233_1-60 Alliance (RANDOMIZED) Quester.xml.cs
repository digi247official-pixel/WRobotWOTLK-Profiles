
using System.Linq;
using robotManager.Helpful;
using wManager.Wow.Class;
using wManager.Wow.Enums;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;
using System.Collections.Generic;
using System.Threading;
using wManager.Wow.Bot.Tasks;


public sealed class DwarvenOutfitters : QuestGrinderClass
{
    public DwarvenOutfitters()
    {
        Name = "Dwarven Outfitters";

        QuestId.AddRange(new[] { 179 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryTarget.Add(705);
HotSpots.Add(new Vector3(-6170.202 , 490.8981 , 387.7774 , "None"));
HotSpots.Add(new Vector3(-6339.805 , 398.2919 , 378.1773 , "None"));
HotSpots.Add(new Vector3(-6310.728 , 269.6763 , 380.2408 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(750) >= 8;
}






}


public sealed class ColdridgeValleyMailDelivery : QuestClass
{
    public ColdridgeValleyMailDelivery()
    {
        Name = "Coldridge Valley Mail Delivery";

        QuestId.AddRange(new[] { 233 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Beginnings : QuestGrinderClass
{
    public Beginnings()
    {
        Name = "Beginnings";

        QuestId.AddRange(new[] { 1599 });

        Step = new List<int> { 3, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Warlock;
        MinLevel = 1;
        MaxLevel = 6;
        RequiredQuest = 0;

        EntryTarget.Add(946);
HotSpots.Add(new Vector3(-6486.355 , 305.0603 , 371.9654 , "None"));
HotSpots.Add(new Vector3(-6536.962 , 350.4892 , 372.5955 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(6753) >= 3;
}






}


public sealed class TheTrollMenace : QuestGrinderClass
{
    public TheTrollMenace()
    {
        Name = "The Troll Menace";

        QuestId.AddRange(new[] { 182 });

        Step = new List<int> { 14, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 6;
        RequiredQuest = 0;

        EntryTarget.Add(706);
HotSpots.Add(new Vector3(-6349.896 , 766.0801 , 386.3487 , "None"));
HotSpots.Add(new Vector3(-6472.47 , 711.9031 , 394.3537 , "None"));
HotSpots.Add(new Vector3(-6467.964 , 509.1766 , 386.1749 , "None"));
HotSpots.Add(new Vector3(-6532.801 , 452.294 , 387.3121 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheBoarHunter : QuestGrinderClass
{
    public TheBoarHunter()
    {
        Name = "The Boar Hunter";

        QuestId.AddRange(new[] { 183 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryTarget.Add(708);
HotSpots.Add(new Vector3(-6181.81 , 684.008 , 386.3373 , "None"));
HotSpots.Add(new Vector3(-6215.158 , 750.1682 , 389.5025 , "None"));
HotSpots.Add(new Vector3(-6158.87 , 476.3914 , 390.4038 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ColdridgeValleyMailDeliveryP2 : QuestClass
{
    public ColdridgeValleyMailDeliveryP2()
    {
        Name = "Coldridge Valley Mail Delivery P2";

        QuestId.AddRange(new[] { 234 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 233;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TaintedRune : QuestClass
{
    public TaintedRune()
    {
        Name = "Tainted Rune";

        QuestId.AddRange(new[] { 3115 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Warlock;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 179;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ANewThreat : QuestGrinderClass
{
    public ANewThreat()
    {
        Name = "A New Threat";

        QuestId.AddRange(new[] { 170 });

        Step = new List<int> { 6, 6, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryTarget.Add(724);
EntryTarget.Add(707);
HotSpots.Add(new Vector3(-6348.621 , 624.9909 , 386.2731 , "None"));
HotSpots.Add(new Vector3(-6249.329 , 724.5648 , 387.5521 , "None"));
HotSpots.Add(new Vector3(-6261.735 , 536.6486 , 386.1125 , "None"));
HotSpots.Add(new Vector3(-6419.827 , 360.4237 , 389.119 , "None"));
HotSpots.Add(new Vector3(-6354.713 , 232.3719 , 391.9523 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ARefugeesQuandaryBucketofBolts : QuestGathererClass
{
    public ARefugeesQuandaryBucketofBolts()
    {
        Name = "A Refugee's Quandary - Bucket of Bolts";

        QuestId.AddRange(new[] { 3361 });

        Step = new List<int> { 0, 0, 1, 0, 0 };

        StepAutoDetect = new[] { false, false, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryIdObjects.Add(178085);
EntryIdObjects.Add(2843);
HotSpots.Add(new Vector3(-6479.468 , 505.956 , 385.9422 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(16314) >= 1;
}






}


public sealed class ARefugeesQuandaryChest : QuestGathererClass
{
    public ARefugeesQuandaryChest()
    {
        Name = "A Refugee's Quandary - Chest";

        QuestId.AddRange(new[] { 3361 });

        Step = new List<int> { 0, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryIdObjects.Add(178084);
EntryIdObjects.Add(2843);
HotSpots.Add(new Vector3(-6503.045 , 679.7099 , 387.2744 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(16313) >= 1;
}






}


public sealed class ARefugeesQuandary : QuestGathererClass
{
    public ARefugeesQuandary()
    {
        Name = "A Refugee's Quandary";

        QuestId.AddRange(new[] { 3361 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryIdObjects.Add(148499);
EntryIdObjects.Add(2843);
HotSpots.Add(new Vector3(-6374.364 , 773.208 , 386.4087 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(10438) >= 1;
}






}


public sealed class IceandFire : QuestGrinderClass
{
    public IceandFire()
    {
        Name = "Ice and Fire";

        QuestId.AddRange(new[] { 218 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 6;
        RequiredQuest = 182;

        EntryTarget.Add(808);
HotSpots.Add(new Vector3(-6508.82 , 300.758 , 370.346 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(2004) >= 1;
}






}


public sealed class ScaldingMornbrewDelivery : QuestClass
{
    public ScaldingMornbrewDelivery()
    {
        Name = "Scalding Mornbrew Delivery";

        QuestId.AddRange(new[] { 3364 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BringBacktheMug : QuestClass
{
    public BringBacktheMug()
    {
        Name = "Bring Back the Mug";

        QuestId.AddRange(new[] { 3365 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 3364;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GRIND16GnomeStart : QuestGrinderClass
{
    public GRIND16GnomeStart()
    {
        Name = "GRIND: 1-6 Gnome Start";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryTarget.Add(708);
HotSpots.Add(new Vector3(-6150.488 , 651.1423 , 387.6255 , "None"));
HotSpots.Add(new Vector3(-6278.551 , 786.6161 , 387.9316 , "None"));
HotSpots.Add(new Vector3(-6471.239 , 540.5012 , 386.6378 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class SenirsObservations : QuestClass
{
    public SenirsObservations()
    {
        Name = "Senir's Observations";

        QuestId.AddRange(new[] { 282 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 5;
        MaxLevel = 6;
        RequiredQuest = 218;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SenirsObservationsPart2 : QuestClass
{
    public SenirsObservationsPart2()
    {
        Name = "Senir's Observations Part 2";

        QuestId.AddRange(new[] { 420 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 6;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PATHColdridgetoKharonos : QuestFollowPathClass
{
    public PATHColdridgetoKharonos()
    {
        Name = "PATH: Coldridge to Kharonos";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 7;
        RequiredQuest = 0;

        Path.Add(new Vector3(-6239.365 , 130.785 , 430.7789 , "None"));
Path.Add(new Vector3(-6227.408 , 123.2681 , 430.8588 , "None"));
Path.Add(new Vector3(-6211.376 , 114.3924 , 431.6623 , "None"));
Path.Add(new Vector3(-6195.745 , 120.6391 , 429.8152 , "None"));
Path.Add(new Vector3(-6175.499 , 128.5198 , 424.415 , "None"));
Path.Add(new Vector3(-6160.262 , 121.1739 , 421.8129 , "None"));
Path.Add(new Vector3(-6157.575 , 104.307 , 419.6579 , "None"));
Path.Add(new Vector3(-6155.758 , 83.72008 , 415.511 , "None"));
Path.Add(new Vector3(-6148.383 , 74.61458 , 415.735 , "None"));
Path.Add(new Vector3(-6138.664 , 74.54447 , 416.474 , "None"));
Path.Add(new Vector3(-6129.022 , 75.85378 , 417.3483 , "None"));
Path.Add(new Vector3(-6116.019 , 75.18823 , 416.1726 , "None"));
Path.Add(new Vector3(-6108.977 , 57.02472 , 414.1533 , "None"));
Path.Add(new Vector3(-6098.735 , 51.82668 , 414.3681 , "None"));
Path.Add(new Vector3(-6089.153 , 50.40832 , 412.4496 , "None"));
Path.Add(new Vector3(-6080.747 , 52.83506 , 410.966 , "None"));
Path.Add(new Vector3(-6070.785 , 46.29332 , 409.5909 , "None"));
Path.Add(new Vector3(-6057.478 , 42.16577 , 407.8438 , "None"));
Path.Add(new Vector3(-6044.738 , 45.06883 , 407.8438 , "None"));
Path.Add(new Vector3(-6018.534 , 52.39767 , 405.2986 , "None"));
Path.Add(new Vector3(-6009.216 , 55.43441 , 403.6792 , "None"));
Path.Add(new Vector3(-5977.906 , 60.45419 , 397.6335 , "None"));
Path.Add(new Vector3(-5953.902 , 62.12777 , 388.4927 , "None"));
Path.Add(new Vector3(-5932.386 , 60.36877 , 379.635 , "None"));
Path.Add(new Vector3(-5912.464 , 44.21241 , 370.2617 , "None"));
Path.Add(new Vector3(-5913.229 , 18.66872 , 367.1703 , "None"));
Path.Add(new Vector3(-5918.232 , -4.777706 , 369.0058 , "None"));
Path.Add(new Vector3(-5926.433 , -53.26708 , 378.4942 , "None"));
Path.Add(new Vector3(-5940.724 , -84.90691 , 388.0807 , "None"));
Path.Add(new Vector3(-5958.83 , -116.0805 , 395.3665 , "None"));
Path.Add(new Vector3(-5970.702 , -148.7013 , 398.514 , "None"));
Path.Add(new Vector3(-5983.291 , -181.2501 , 402.9789 , "None"));
Path.Add(new Vector3(-5996.823 , -214.6593 , 407.5647 , "None"));
Path.Add(new Vector3(-6008.806 , -247.4353 , 413.6228 , "None"));
Path.Add(new Vector3(-6008.39 , -283.2509 , 417.8877 , "None"));
Path.Add(new Vector3(-6004.03 , -317.8743 , 419.3268 , "None"));
Path.Add(new Vector3(-5997.035 , -353.2233 , 418.0935 , "None"));
Path.Add(new Vector3(-5980.294 , -383.8169 , 414.0949 , "None"));
Path.Add(new Vector3(-5960.945 , -414.2247 , 412.8083 , "None"));
Path.Add(new Vector3(-5937.34 , -439.8916 , 413.0741 , "None"));
Path.Add(new Vector3(-5907.567 , -459.7164 , 412.9535 , "None"));
Path.Add(new Vector3(-5869.846 , -481.5519 , 410.853 , "None"));
Path.Add(new Vector3(-5840.119 , -501.9959 , 406.9134 , "None"));
Path.Add(new Vector3(-5807.312 , -513.4399 , 403.7851 , "None"));
Path.Add(new Vector3(-5771.436 , -511.453 , 399.9303 , "None"));
Path.Add(new Vector3(-5736.796 , -507.5633 , 396.1819 , "None"));
Path.Add(new Vector3(-5702.489 , -496.5278 , 396.3602 , "None"));
Path.Add(new Vector3(-5668.626 , -488.4146 , 396.2973 , "None"));
Path.Add(new Vector3(-5637.029 , -488.2547 , 396.669 , "None"));
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


public sealed class SuppliestoTannok : QuestClass
{
    public SuppliestoTannok()
    {
        Name = "Supplies to Tannok";

        QuestId.AddRange(new[] { 2160 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 5;
        MaxLevel = 6;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ToolsforSteelgrill : QuestClass
{
    public ToolsforSteelgrill()
    {
        Name = "Tools for Steelgrill";

        QuestId.AddRange(new[] { 400 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 5;
        MaxLevel = 7;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GRIND67forWeaponMoney : QuestGrinderClass
{
    public GRIND67forWeaponMoney()
    {
        Name = "GRIND: 6-7 for Weapon Money";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 6;
        RequiredQuest = 0;

        EntryTarget.Add(1125);
EntryTarget.Add(1199);
EntryTarget.Add(1128);
HotSpots.Add(new Vector3(-5794.487 , 90.20465 , 363.5355 , "None"));
HotSpots.Add(new Vector3(-5870.031 , -10.56308 , 360.4299 , "None"));
HotSpots.Add(new Vector3(-5862.621 , -79.46187 , 363.1753 , "None"));
HotSpots.Add(new Vector3(-6030.882 , -276.9286 , 418.0666 , "None"));
HotSpots.Add(new Vector3(-6033.355 , -410.8427 , 415.7807 , "None"));
HotSpots.Add(new Vector3(-5885.388 , -230.171 , 362.5665 , "None"));
HotSpots.Add(new Vector3(-5786.984 , -396.8704 , 365.0191 , "None"));
HotSpots.Add(new Vector3(-5715.932 , -404.7949 , 367.2731 , "None"));
HotSpots.Add(new Vector3(-5587.83 , -358.5018 , 405.9116 , "None"));
HotSpots.Add(new Vector3(-5517.034 , -446.055 , 406.4688 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class BeerBastedBoarRibs : QuestGrinderClass
{
    public BeerBastedBoarRibs()
    {
        Name = "Beer Basted Boar Ribs";

        QuestId.AddRange(new[] { 384 });

        Step = new List<int> { 0, 6, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 8;
        RequiredQuest = 0;

        EntryTarget.Add(1126);
EntryTarget.Add(1125);
HotSpots.Add(new Vector3(-5738.903 , -562.0074 , 398.4099 , "None"));
HotSpots.Add(new Vector3(-5938.627 , -565.5263 , 406.0105 , "None"));
HotSpots.Add(new Vector3(-5983.914 , -405.3014 , 412.0795 , "None"));
HotSpots.Add(new Vector3(-6043.058 , -310.924 , 424.5702 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AmmoforRumbleshot : QuestGathererClass
{
    public AmmoforRumbleshot()
    {
        Name = "Ammo for Rumbleshot";

        QuestId.AddRange(new[] { 5541 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 8;
        RequiredQuest = 0;

        EntryIdObjects.Add(176785);
HotSpots.Add(new Vector3(-5746.289 , -372.6346 , 365.7878 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(13850) >= 1;
}






}


public sealed class StockingJetsteam : QuestGrinderClass
{
    public StockingJetsteam()
    {
        Name = "Stocking Jetsteam";

        QuestId.AddRange(new[] { 317 });

        Step = new List<int> { 4, 2, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 9;
        RequiredQuest = 0;

        EntryTarget.Add(1128);
EntryTarget.Add(1125);
HotSpots.Add(new Vector3(-5689.632 , -412.88 , 365.0346 , "None"));
HotSpots.Add(new Vector3(-5787.29 , -403.1113 , 365.0179 , "None"));
HotSpots.Add(new Vector3(-5835.175 , -226.4943 , 354.5208 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(769) >= 4 && ItemsManager.GetItemCountById(6952) >= 2;
}






}


public sealed class ForcedtoWatchfromAfar : QuestGrinderClass
{
    public ForcedtoWatchfromAfar()
    {
        Name = "Forced to Watch from Afar";

        QuestId.AddRange(new[] { 313 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 9;
        RequiredQuest = 0;

        EntryTarget.Add(1134);
EntryTarget.Add(1135);
HotSpots.Add(new Vector3(-5699.27 , -269.8811 , 361.3963 , "None"));
HotSpots.Add(new Vector3(-5650.249 , -291.3008 , 372.0799 , "None"));
HotSpots.Add(new Vector3(-5632.227 , -287.4204 , 370.2255 , "None"));
HotSpots.Add(new Vector3(-5627.401 , -272.8976 , 367.6857 , "None"));
HotSpots.Add(new Vector3(-5617.145 , -263.7933 , 366.0691 , "None"));
HotSpots.Add(new Vector3(-5603.742 , -265.2137 , 368.0408 , "None"));
HotSpots.Add(new Vector3(-5598.885 , -276.96 , 370.2953 , "None"));
HotSpots.Add(new Vector3(-5583.772 , -282.6548 , 367.495 , "None"));
HotSpots.Add(new Vector3(-5572.288 , -282.2844 , 366.978 , "None"));
HotSpots.Add(new Vector3(-5561.367 , -243.9843 , 365.4144 , "None"));
HotSpots.Add(new Vector3(-5530.615 , -223.864 , 355.6782 , "None"));
HotSpots.Add(new Vector3(-5520.959 , -222.3606 , 353.9612 , "None"));
HotSpots.Add(new Vector3(-5513.354 , -222.9891 , 353.3586 , "None"));
HotSpots.Add(new Vector3(-5505.669 , -232.4401 , 354.4298 , "None"));
HotSpots.Add(new Vector3(-5499.597 , -238.6717 , 354.0672 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(2671) >= 8;
}






}


public sealed class Evershine : QuestClass
{
    public Evershine()
    {
        Name = "Evershine";

        QuestId.AddRange(new[] { 318 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 9;
        RequiredQuest = 317;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AFavorforEvershine : QuestGrinderClass
{
    public AFavorforEvershine()
    {
        Name = "A Favor for Evershine";

        QuestId.AddRange(new[] { 319 });

        Step = new List<int> { 6, 8, 8, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 9;
        RequiredQuest = 318;

        EntryTarget.Add(1201);
EntryTarget.Add(1127);
EntryTarget.Add(1196);
HotSpots.Add(new Vector3(-5436.19 , 116.1261 , 397.1294 , "None"));
HotSpots.Add(new Vector3(-5441.881 , 209.1713 , 397.326 , "None"));
HotSpots.Add(new Vector3(-5590.803 , 309.8845 , 394.1916 , "None"));
HotSpots.Add(new Vector3(-5467.229 , 429.4709 , 385.8899 , "None"));
HotSpots.Add(new Vector3(-5379.62 , 484.7612 , 385.0934 , "None"));
HotSpots.Add(new Vector3(-5288.941 , 362.2829 , 394.8185 , "None"));
HotSpots.Add(new Vector3(-5158.771 , 297.1149 , 397.502 , "None"));
HotSpots.Add(new Vector3(-5036.997 , 97.42707 , 392.6914 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThePerfectStout : QuestGathererClass
{
    public ThePerfectStout()
    {
        Name = "The Perfect Stout";

        QuestId.AddRange(new[] { 315 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 9;
        RequiredQuest = 0;

        EntryIdObjects.Add(276);
HotSpots.Add(new Vector3(-5315.129 , -230.928 , 441.125 , "None"));
HotSpots.Add(new Vector3(-5313.839 , -238.0699 , 441.2377 , "None"));
HotSpots.Add(new Vector3(-5327.611 , -252.4222 , 441.7086 , "None"));
HotSpots.Add(new Vector3(-5342.68 , -215.1802 , 441.3275 , "None"));
HotSpots.Add(new Vector3(-5350.134 , -228.6571 , 441.8498 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(2676) >= 6;
}






}


public sealed class RejoldsNewBrew : QuestClass
{
    public RejoldsNewBrew()
    {
        Name = "Rejold's New Brew";

        QuestId.AddRange(new[] { 415 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 9;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ShimmerStout : QuestClass
{
    public ShimmerStout()
    {
        Name = "Shimmer Stout";

        QuestId.AddRange(new[] { 413 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 8;
        MaxLevel = 9;
        RequiredQuest = 415;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class OperationRecombobulation : QuestGrinderClass
{
    public OperationRecombobulation()
    {
        Name = "Operation Recombobulation";

        QuestId.AddRange(new[] { 412 });

        Step = new List<int> { 8, 8, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 9;
        RequiredQuest = 0;

        EntryTarget.Add(1211);
HotSpots.Add(new Vector3(-5107.93 , 450.3466 , 400.7926 , "None"));
HotSpots.Add(new Vector3(-5124.977 , 533.0161 , 408.9895 , "None"));
HotSpots.Add(new Vector3(-5162.076 , 586.6285 , 409.0345 , "None"));
HotSpots.Add(new Vector3(-5210.099 , 519.3009 , 387.2141 , "None"));
HotSpots.Add(new Vector3(-5264.268 , 535.3615 , 387.4512 , "None"));
HotSpots.Add(new Vector3(-5282.029 , 581.3547 , 386.8112 , "None"));
HotSpots.Add(new Vector3(-5316.541 , 487.703 , 384.761 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(3083) >= 8 && ItemsManager.GetItemCountById(3084) >= 8;
}






}


public sealed class GRIND710DunMoroghv1 : QuestGrinderClass
{
    public GRIND710DunMoroghv1()
    {
        Name = "GRIND: 7-10 - Dun Morogh v1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 7;
        MaxLevel = 9;
        RequiredQuest = 0;

        EntryTarget.Add(1127);
EntryTarget.Add(1201);
EntryTarget.Add(1196);
HotSpots.Add(new Vector3(-5447.362 , 147.8112 , 399.6476 , "None"));
HotSpots.Add(new Vector3(-5593.093 , 312.0367 , 393.5439 , "None"));
HotSpots.Add(new Vector3(-5678.485 , 430.1013 , 386.1692 , "None"));
HotSpots.Add(new Vector3(-5664.874 , 543.8436 , 392.8624 , "None"));
HotSpots.Add(new Vector3(-5592.246 , 485.2399 , 385.1118 , "None"));
HotSpots.Add(new Vector3(-5389.786 , 465.5742 , 384.4296 , "None"));
HotSpots.Add(new Vector3(-5386.387 , 366.3347 , 394.3481 , "None"));
HotSpots.Add(new Vector3(-5266.494 , 361.4204 , 395.8963 , "None"));
HotSpots.Add(new Vector3(-5158.732 , 444.8104 , 395.0871 , "None"));
HotSpots.Add(new Vector3(-5076.356 , 152.8766 , 396.6574 , "None"));
HotSpots.Add(new Vector3(-4876.186 , 95.65768 , 388.9876 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 10;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND710DunMoroghv2 : QuestGrinderClass
{
    public GRIND710DunMoroghv2()
    {
        Name = "GRIND: 7-10 - Dun Morogh v2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 7;
        MaxLevel = 9;
        RequiredQuest = 0;

        EntryTarget.Add(1201);
EntryTarget.Add(1126);
EntryTarget.Add(1127);
EntryTarget.Add(1196);
HotSpots.Add(new Vector3(-5591.271 , -981.0371 , 393.4789 , "None"));
HotSpots.Add(new Vector3(-5867.805 , -985.8956 , 397.9776 , "None"));
HotSpots.Add(new Vector3(-5909.558 , -1114.951 , 385.8983 , "None"));
HotSpots.Add(new Vector3(-5730.669 , -1131.346 , 383.0373 , "None"));
HotSpots.Add(new Vector3(-5722.717 , -1287.93 , 389.1571 , "None"));
HotSpots.Add(new Vector3(-5853.196 , -1324.093 , 390.226 , "None"));
HotSpots.Add(new Vector3(-5558.739 , -1470.916 , 403.1422 , "None"));
HotSpots.Add(new Vector3(-5528.881 , -1642.013 , 392.955 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 10;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND1014LochModanV2Rats : QuestGrinderClass
{
    public GRIND1014LochModanV2Rats()
    {
        Name = "GRIND: 10-14 Loch Modan - V2 (+Rats)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 13;
        RequiredQuest = 0;

        EntryTarget.Add(1190);
EntryTarget.Add(1195);
EntryTarget.Add(1186);
EntryTarget.Add(1172);
EntryTarget.Add(1173);
HotSpots.Add(new Vector3(-5349.908 , -2817.679 , 346.1825 , "None"));
HotSpots.Add(new Vector3(-5210.605 , -2741.359 , 341.2879 , "None"));
HotSpots.Add(new Vector3(-5223.053 , -2922.246 , 338.4444 , "None"));
HotSpots.Add(new Vector3(-5185.512 , -3043.348 , 330.4878 , "None"));
HotSpots.Add(new Vector3(-5026.64 , -3097.869 , 317.0734 , "None"));
HotSpots.Add(new Vector3(-4882.817 , -3117.837 , 322.4016 , "None"));
HotSpots.Add(new Vector3(-4936.376 , -2816.195 , 320.7966 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 14;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND1014LockModanNoRatsV2 : QuestGrinderClass
{
    public GRIND1014LockModanNoRatsV2()
    {
        Name = "GRIND: 10-14 Lock Modan (No Rats)- V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 13;
        RequiredQuest = 0;

        EntryTarget.Add(1190);
EntryTarget.Add(1186);
EntryTarget.Add(1195);
HotSpots.Add(new Vector3(-4739.379 , -2683.725 , 328.0184 , "None"));
HotSpots.Add(new Vector3(-4683.33 , -2816.534 , 325.8185 , "None"));
HotSpots.Add(new Vector3(-4818.643 , -2829.6 , 326.9955 , "None"));
HotSpots.Add(new Vector3(-4925.331 , -2857.321 , 332.0484 , "None"));
HotSpots.Add(new Vector3(-5218.617 , -2742.691 , 340.2343 , "None"));
HotSpots.Add(new Vector3(-5033.249 , -2880.027 , 334.4118 , "None"));
HotSpots.Add(new Vector3(-5005.21 , -2931.196 , 338.8351 , "None"));
HotSpots.Add(new Vector3(-5048.696 , -2987.442 , 332.5162 , "None"));
HotSpots.Add(new Vector3(-5100.719 , -3097.217 , 312.8542 , "None"));
HotSpots.Add(new Vector3(-5174.579 , -3008.836 , 335.6174 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 14;
}



public override bool HasQuest() { return true; }


}


public sealed class ReturntoBellowfiz : QuestClass
{
    public ReturntoBellowfiz()
    {
        Name = "Return to Bellowfiz";

        QuestId.AddRange(new[] { 320 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 8;
        MaxLevel = 10;
        RequiredQuest = 319;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TundraMacGrannsStolenStash : QuestGathererClass
{
    public TundraMacGrannsStolenStash()
    {
        Name = "Tundra MacGrann's Stolen Stash";

        QuestId.AddRange(new[] { 312 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 13;
        RequiredQuest = 0;

        EntryIdObjects.Add(272);
HotSpots.Add(new Vector3(-5647.035 , -95.23785 , 418.1095 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(2667) >= 1;
}






}


public sealed class PATHGolearnSkinning : QuestFollowPathClass
{
    public PATHGolearnSkinning()
    {
        Name = "PATH: Go learn Skinning";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 10;
        RequiredQuest = 0;

        Path.Add(new Vector3(-5364.787 , -521.2941 , 391.4934 , "None"));
Path.Add(new Vector3(-5335.735 , -516.4785 , 391.4934 , "None"));
Path.Add(new Vector3(-5317.486 , -505.4957 , 388.3327 , "None"));
Path.Add(new Vector3(-5289.432 , -501.4649 , 390.9575 , "None"));
Path.Add(new Vector3(-5265.658 , -505.2566 , 386.4636 , "None"));
Path.Add(new Vector3(-5245.944 , -518.781 , 386.7507 , "None"));
Path.Add(new Vector3(-5241.936 , -553.2838 , 398.4951 , "None"));
Path.Add(new Vector3(-5236.822 , -587.7689 , 410.9186 , "None"));
Path.Add(new Vector3(-5230.021 , -623.1515 , 419.6802 , "None"));
Path.Add(new Vector3(-5221.12 , -656.8896 , 427.5556 , "None"));
Path.Add(new Vector3(-5209.968 , -691.0952 , 436.0553 , "None"));
Path.Add(new Vector3(-5193.006 , -721.6027 , 444.2545 , "None"));
Path.Add(new Vector3(-5166.722 , -744.5146 , 450.7628 , "None"));
Path.Add(new Vector3(-5132.022 , -744.9148 , 459.6586 , "None"));
Path.Add(new Vector3(-5096.138 , -743.7819 , 468.9524 , "None"));
Path.Add(new Vector3(-5062.638 , -752.8675 , 481.5251 , "None"));
Path.Add(new Vector3(-5040.828 , -779.7026 , 494.6921 , "None"));
Path.Add(new Vector3(-5031.27 , -813.2416 , 495.1563 , "None"));
Path.Add(new Vector3(-5013.548 , -844.0596 , 497.0558 , "None"));
Path.Add(new Vector3(-4990.665 , -870.3276 , 496.9846 , "None"));
Path.Add(new Vector3(-4973.164 , -886.2769 , 501.6181 , "None"));
Path.Add(new Vector3(-4940.505 , -864.5727 , 501.6618 , "None"));
Path.Add(new Vector3(-4918.346 , -850.9569 , 501.6618 , "None"));
Path.Add(new Vector3(-4904.548 , -878.2428 , 501.6601 , "None"));
Path.Add(new Vector3(-4897.611 , -898.9513 , 501.6601 , "None"));
Path.Add(new Vector3(-4884.535 , -933.6258 , 501.4562 , "None"));
Path.Add(new Vector3(-4874.072 , -941.4918 , 501.453 , "None"));
Path.Add(new Vector3(-4852.654 , -943.7938 , 501.4541 , "None"));
Path.Add(new Vector3(-4839.605 , -967.8433 , 501.7529 , "None"));
Path.Add(new Vector3(-4830.793 , -1000.502 , 502.0627 , "None"));
Path.Add(new Vector3(-4824.455 , -1023.637 , 502.1857 , "None"));
Path.Add(new Vector3(-4809.442 , -1028.002 , 502.2076 , "None"));
Path.Add(new Vector3(-4779.316 , -1032.146 , 502.2124 , "None"));
Path.Add(new Vector3(-4764.756 , -1041.758 , 502.2124 , "None"));
Path.Add(new Vector3(-4748.478 , -1052.785 , 502.2124 , "None"));
Path.Add(new Vector3(-4742.085 , -1047.75 , 502.2124 , "None"));
Path.Add(new Vector3(-4752.479 , -1039.842 , 508.9717 , "None"));
Path.Add(new Vector3(-4756.504 , -1036.559 , 511.0996 , "None"));
Path.Add(new Vector3(-4755.641 , -1031.173 , 511.0996 , "None"));
Path.Add(new Vector3(-4750.479 , -1027.557 , 511.0996 , "None"));
Path.Add(new Vector3(-4744.417 , -1031.416 , 511.0979 , "None"));
Path.Add(new Vector3(-4739.471 , -1034.172 , 511.0979 , "None"));
Path.Add(new Vector3(-4736.07 , -1030.515 , 509.0802 , "None"));
Path.Add(new Vector3(-4734.92 , -1025 , 506.9217 , "None"));
Path.Add(new Vector3(-4739.626 , -1022.782 , 504.4307 , "None"));
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


public sealed class StouttoKadrell : QuestClass
{
    public StouttoKadrell()
    {
        Name = "Stout to Kadrell";

        QuestId.AddRange(new[] { 414 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 13;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RatCatching : QuestGrinderClass
{
    public RatCatching()
    {
        Name = "Rat Catching";

        QuestId.AddRange(new[] { 416 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 13;
        RequiredQuest = 0;

        EntryTarget.Add(1172);
HotSpots.Add(new Vector3(-5004.589 , -3042.318 , 324.5283 , "None"));
HotSpots.Add(new Vector3(-4963.726 , -3096.766 , 314.0093 , "None"));
HotSpots.Add(new Vector3(-4869.831 , -3082.392 , 318.5105 , "None"));
HotSpots.Add(new Vector3(-4791.477 , -3106.856 , 308.4736 , "None"));
HotSpots.Add(new Vector3(-4748.007 , -3097.51 , 312.5771 , "None"));
HotSpots.Add(new Vector3(-4674.857 , -3080.971 , 311.0205 , "None"));
HotSpots.Add(new Vector3(-4683.117 , -2960.847 , 319.2054 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(3110) >= 12;
}






}


public sealed class ThelsamarBloodSausages : QuestGrinderClass
{
    public ThelsamarBloodSausages()
    {
        Name = "Thelsamar Blood Sausages";

        QuestId.AddRange(new[] { 418 });

        Step = new List<int> { 3, 3, 3, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 13;
        RequiredQuest = 0;

        EntryTarget.Add(1195);
EntryTarget.Add(1190);
EntryTarget.Add(1186);
HotSpots.Add(new Vector3(-5236.377 , -2917 , 338.9114 , "None"));
HotSpots.Add(new Vector3(-4993.886 , -3043.316 , 325.3083 , "None"));
HotSpots.Add(new Vector3(-5004.195 , -2913.467 , 336.6963 , "None"));
HotSpots.Add(new Vector3(-4890.255 , -2811.813 , 324.2932 , "None"));
HotSpots.Add(new Vector3(-4743.191 , -2804.592 , 322.2895 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PATHIFtoDeeprunTram : QuestFollowPathClass
{
    public PATHIFtoDeeprunTram()
    {
        Name = "PATH: IF to Deeprun Tram";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 59;
        RequiredQuest = 0;

        Path.Add(new Vector3(-4806.892 , -1168.032 , 502.2076 , "None"));
Path.Add(new Vector3(-4788.473 , -1165.841 , 502.2125 , "None"));
Path.Add(new Vector3(-4771.007 , -1160.18 , 502.201 , "None"));
Path.Add(new Vector3(-4753.116 , -1159.45 , 502.2129 , "None"));
Path.Add(new Vector3(-4734.711 , -1173.042 , 501.6986 , "None"));
Path.Add(new Vector3(-4719.198 , -1196.438 , 501.6986 , "None"));
Path.Add(new Vector3(-4715.358 , -1212.124 , 501.6596 , "None"));
Path.Add(new Vector3(-4731.928 , -1242.899 , 501.6592 , "None"));
Path.Add(new Vector3(-4745.432 , -1266.625 , 501.6592 , "None"));
Path.Add(new Vector3(-4775.917 , -1279.518 , 501.8685 , "None"));
Path.Add(new Vector3(-4793.315 , -1278.645 , 501.8685 , "None"));
Path.Add(new Vector3(-4815.016 , -1276.182 , 501.8685 , "None"));
Path.Add(new Vector3(-4833.824 , -1281.195 , 501.8685 , "None"));
Path.Add(new Vector3(-4836.611 , -1301.883 , 501.8685 , "None"));
Path.Add(new Vector3(-4838.744 , -1316.786 , 501.8685 , "None"));
Path.Add(new Vector3(-4838.826 , -1317.432 , 501.8685 , "None"));
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


public sealed class PATHExitTramtoSW : QuestFollowPathClass
{
    public PATHExitTramtoSW()
    {
        Name = "PATH: Exit Tram to SW";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 59;
        RequiredQuest = 0;

        Path.Add(new Vector3(13.81097 , 2490.611 , -4.227672 , "None"));
Path.Add(new Vector3(26.91371 , 2490.558 , -4.293973 , "None"));
Path.Add(new Vector3(37.0566 , 2490.603 , -4.295444 , "None"));
Path.Add(new Vector3(47.53305 , 2490.815 , -4.296864 , "None"));
Path.Add(new Vector3(57.04309 , 2490.999 , -4.296864 , "None"));
Path.Add(new Vector3(65.88384 , 2490.94 , -4.296864 , "None"));
Path.Add(new Vector3(68.17284 , 2490.934 , -4.296864 , "None"));
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


public sealed class PATHDeeprunIFToBoardTram : QuestFollowPathClass
{
    public PATHDeeprunIFToBoardTram()
    {
        Name = "PATH: Deeprun (IF) - To Board Tram";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 13;
        RequiredQuest = 0;

        Path.Add(new Vector3(63.52124 , 9.895586 , -4.29735 , "None"));
Path.Add(new Vector3(53.0459 , 10.15907 , -4.29735 , "None"));
Path.Add(new Vector3(42.56874 , 9.989677 , -4.29735 , "None"));
Path.Add(new Vector3(31.76337 , 9.540862 , -4.29735 , "None"));
Path.Add(new Vector3(21.6409 , 8.898905 , -4.29735 , "None"));
Path.Add(new Vector3(10.85812 , 8.065068 , -4.04483 , "None"));
Path.Add(new Vector3(10.09368 , 8.153173 , -4.143053 , "None"));
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


public sealed class PATHSWTramtoWeaponsMaster : QuestFollowPathClass
{
    public PATHSWTramtoWeaponsMaster()
    {
        Name = "PATH: SW Tram to Weapons Master";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 13;
        RequiredQuest = 0;

        Path.Add(new Vector3(-8361.089 , 531.7615 , 91.79719 , "None"));
Path.Add(new Vector3(-8370.806 , 544.1302 , 91.79719 , "None"));
Path.Add(new Vector3(-8383.992 , 560.8498 , 91.79719 , "None"));
Path.Add(new Vector3(-8395.13 , 573.2456 , 91.30815 , "None"));
Path.Add(new Vector3(-8414.446 , 569.5285 , 92.46098 , "None"));
Path.Add(new Vector3(-8434.982 , 574.8571 , 94.40068 , "None"));
Path.Add(new Vector3(-8449.131 , 589.8815 , 93.82166 , "None"));
Path.Add(new Vector3(-8460.483 , 579.6774 , 94.69202 , "None"));
Path.Add(new Vector3(-8475.613 , 564.8021 , 96.8855 , "None"));
Path.Add(new Vector3(-8501.188 , 539.3975 , 97.16497 , "None"));
Path.Add(new Vector3(-8513.72 , 527.3215 , 98.2975 , "None"));
Path.Add(new Vector3(-8534.979 , 510.1928 , 98.3659 , "None"));
Path.Add(new Vector3(-8552.708 , 510.6999 , 98.57105 , "None"));
Path.Add(new Vector3(-8559.184 , 522.096 , 100.3449 , "None"));
Path.Add(new Vector3(-8573.041 , 538.6005 , 101.6907 , "None"));
Path.Add(new Vector3(-8592.4 , 532.062 , 105.4436 , "None"));
Path.Add(new Vector3(-8606.044 , 519.5043 , 105.4024 , "None"));
Path.Add(new Vector3(-8619.267 , 517.7607 , 103.129 , "None"));
Path.Add(new Vector3(-8639.292 , 537.5282 , 99.38914 , "None"));
Path.Add(new Vector3(-8650.258 , 546.4648 , 97.34962 , "None"));
Path.Add(new Vector3(-8661.792 , 555.7569 , 97.09833 , "None"));
Path.Add(new Vector3(-8678.87 , 548.5667 , 97.48759 , "None"));
Path.Add(new Vector3(-8690.082 , 538.303 , 97.84762 , "None"));
Path.Add(new Vector3(-8700.185 , 530.0195 , 97.69738 , "None"));
Path.Add(new Vector3(-8712.528 , 521.0499 , 97.28046 , "None"));
Path.Add(new Vector3(-8728.324 , 539.1467 , 100.9928 , "None"));
Path.Add(new Vector3(-8739.497 , 552.6155 , 99.63203 , "None"));
Path.Add(new Vector3(-8750.53 , 565.5477 , 98.21172 , "None"));
Path.Add(new Vector3(-8740.874 , 574.717 , 97.49972 , "None"));
Path.Add(new Vector3(-8750.798 , 590.1993 , 97.35579 , "None"));
Path.Add(new Vector3(-8767.069 , 603.9329 , 96.88157 , "None"));
Path.Add(new Vector3(-8780.731 , 603.5362 , 97.49487 , "None"));
Path.Add(new Vector3(-8794.917 , 588.4796 , 97.44164 , "None"));
Path.Add(new Vector3(-8807.995 , 597.639 , 96.89741 , "None"));
Path.Add(new Vector3(-8816.78 , 616.9697 , 94.84342 , "None"));
Path.Add(new Vector3(-8809.428 , 630.9258 , 94.22911 , "None"));
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


public sealed class GakinsSummons : QuestClass
{
    public GakinsSummons()
    {
        Name = "Gakin's Summons ";

        QuestId.AddRange(new[] { 1685 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Warlock;
        MinLevel = 10;
        MaxLevel = 14;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SurenaCaledon : QuestGrinderClass
{
    public SurenaCaledon()
    {
        Name = "Surena Caledon";

        QuestId.AddRange(new[] { 1688 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Warlock;
        MinLevel = 10;
        MaxLevel = 14;
        RequiredQuest = 1685;

        EntryTarget.Add(473);
EntryTarget.Add(880);
EntryTarget.Add(881);
HotSpots.Add(new Vector3(-9809.18 , -929.385 , 39.85811 , "None"));
HotSpots.Add(new Vector3(-9793.671 , -922.4045 , 39.45121 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(6810) >= 1;
}






}


public sealed class PATHQuestHubIN : QuestFollowPathClass
{
    public PATHQuestHubIN()
    {
        Name = "PATH: Quest Hub IN";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 14;
        RequiredQuest = 0;

        Path.Add(new Vector3(-8918.53 , 974.1088 , 120.1371 , "None"));
Path.Add(new Vector3(-8913.7 , 981.9094 , 120.9988 , "None"));
Path.Add(new Vector3(-8913.446 , 985.55 , 120.9988 , "None"));
Path.Add(new Vector3(-8919.479 , 989.2645 , 120.9988 , "None"));
Path.Add(new Vector3(-8927.519 , 990.3775 , 120.9988 , "None"));
Path.Add(new Vector3(-8937.811 , 988.4849 , 121.5786 , "None"));
Path.Add(new Vector3(-8941.633 , 987.5816 , 121.6883 , "None"));
Path.Add(new Vector3(-8945.781 , 992.2793 , 122.0236 , "None"));
Path.Add(new Vector3(-8949.986 , 997.9977 , 122.0566 , "None"));
Path.Add(new Vector3(-8959.128 , 1010.406 , 122.0443 , "None"));
Path.Add(new Vector3(-8963.992 , 1012.209 , 122.0265 , "None"));
Path.Add(new Vector3(-8967.297 , 1015.693 , 122.0265 , "None"));
Path.Add(new Vector3(-8968.866 , 1017.359 , 122.0265 , "None"));
Path.Add(new Vector3(-8972.896 , 1019.486 , 119.2101 , "None"));
Path.Add(new Vector3(-8975.342 , 1019.132 , 117.8572 , "None"));
Path.Add(new Vector3(-8977.526 , 1017.759 , 116.6143 , "None"));
Path.Add(new Vector3(-8977.842 , 1015.131 , 115.1891 , "None"));
Path.Add(new Vector3(-8977.186 , 1012.259 , 113.4439 , "None"));
Path.Add(new Vector3(-8975.183 , 1010.098 , 111.5221 , "None"));
Path.Add(new Vector3(-8972.013 , 1009.506 , 109.625 , "None"));
Path.Add(new Vector3(-8968.678 , 1010.748 , 107.5358 , "None"));
Path.Add(new Vector3(-8967.746 , 1013.088 , 106.0863 , "None"));
Path.Add(new Vector3(-8968.48 , 1016.486 , 104.2543 , "None"));
Path.Add(new Vector3(-8970.04 , 1019.708 , 103.5899 , "None"));
Path.Add(new Vector3(-8971.669 , 1022.788 , 101.9839 , "None"));
Path.Add(new Vector3(-8972.662 , 1026.252 , 101.4041 , "None"));
Path.Add(new Vector3(-8973.527 , 1029.295 , 101.4041 , "None"));
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


public sealed class PATHQuestHubOUTToSurenaCuldon : QuestFollowPathClass
{
    public PATHQuestHubOUTToSurenaCuldon()
    {
        Name = "PATH: Quest Hub OUT (To Surena Culdon)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 14;
        RequiredQuest = 0;

        Path.Add(new Vector3(-8974.632 , 1031.958 , 101.4037 , "None"));
Path.Add(new Vector3(-8973.253 , 1026.545 , 101.4037 , "None"));
Path.Add(new Vector3(-8968.351 , 1016.66 , 104.2353 , "None"));
Path.Add(new Vector3(-8972.311 , 1010.145 , 109.739 , "None"));
Path.Add(new Vector3(-8976.924 , 1013.549 , 114.2082 , "None"));
Path.Add(new Vector3(-8974.652 , 1018.663 , 118.1946 , "None"));
Path.Add(new Vector3(-8969.749 , 1018.074 , 121.34 , "None"));
Path.Add(new Vector3(-8963.978 , 1011.802 , 122.026 , "None"));
Path.Add(new Vector3(-8957.018 , 1003.969 , 122.026 , "None"));
Path.Add(new Vector3(-8950.018 , 995.7466 , 122.0568 , "None"));
Path.Add(new Vector3(-8942.835 , 988.1196 , 122.0198 , "None"));
Path.Add(new Vector3(-8932.723 , 988.0195 , 120.9991 , "None"));
Path.Add(new Vector3(-8922.352 , 986.9315 , 120.9991 , "None"));
Path.Add(new Vector3(-8914.822 , 982.3079 , 120.9991 , "None"));
Path.Add(new Vector3(-8921.846 , 970.1641 , 117.3376 , "None"));
Path.Add(new Vector3(-8925.663 , 963.7922 , 117.1618 , "None"));
Path.Add(new Vector3(-8926.351 , 957.374 , 117.1014 , "None"));
Path.Add(new Vector3(-8922.479 , 951.301 , 117.2823 , "None"));
Path.Add(new Vector3(-8898.162 , 914.0421 , 111.3983 , "None"));
Path.Add(new Vector3(-8892.064 , 903.6631 , 108.0625 , "None"));
Path.Add(new Vector3(-8890.598 , 879.6113 , 100.5862 , "None"));
Path.Add(new Vector3(-8898.639 , 860.5936 , 96.21621 , "None"));
Path.Add(new Vector3(-8906.436 , 846.1884 , 95.94376 , "None"));
Path.Add(new Vector3(-8899.688 , 829.3338 , 93.11716 , "None"));
Path.Add(new Vector3(-8899.748 , 814.2169 , 89.19767 , "None"));
Path.Add(new Vector3(-8901.113 , 797.8915 , 87.47925 , "None"));
Path.Add(new Vector3(-8906.43 , 782.6613 , 88.59973 , "None"));
Path.Add(new Vector3(-8897.409 , 773.1759 , 90.78226 , "None"));
Path.Add(new Vector3(-8882.521 , 757.1976 , 95.78754 , "None"));
Path.Add(new Vector3(-8869.578 , 757.4426 , 97.0481 , "None"));
Path.Add(new Vector3(-8852.472 , 738.1359 , 100.7319 , "None"));
Path.Add(new Vector3(-8836.479 , 705.8279 , 97.63437 , "None"));
Path.Add(new Vector3(-8826.546 , 678.1915 , 97.5043 , "None"));
Path.Add(new Vector3(-8846.902 , 663.4561 , 97.49658 , "None"));
Path.Add(new Vector3(-8837.968 , 638.4711 , 94.93134 , "None"));
Path.Add(new Vector3(-8836.412 , 623.0682 , 93.48341 , "None"));
Path.Add(new Vector3(-8836.005 , 616.5709 , 93.22019 , "None"));
Path.Add(new Vector3(-8866.406 , 595.3607 , 92.25591 , "None"));
Path.Add(new Vector3(-8893.226 , 571.2958 , 92.51421 , "None"));
Path.Add(new Vector3(-8913.1 , 551.0864 , 93.90291 , "None"));
Path.Add(new Vector3(-8921.955 , 525.007 , 94.52707 , "None"));
Path.Add(new Vector3(-8914.39 , 503.0017 , 93.87393 , "None"));
Path.Add(new Vector3(-8934.915 , 494.565 , 93.83128 , "None"));
Path.Add(new Vector3(-8946.978 , 510.1013 , 96.36298 , "None"));
Path.Add(new Vector3(-8973.621 , 507.1261 , 96.3649 , "None"));
Path.Add(new Vector3(-9001.477 , 486.0629 , 96.62282 , "None"));
Path.Add(new Vector3(-9029.097 , 462.8971 , 93.73169 , "None"));
Path.Add(new Vector3(-9056.197 , 440.8619 , 93.05699 , "None"));
Path.Add(new Vector3(-9084.097 , 418.0329 , 92.50345 , "None"));
Path.Add(new Vector3(-9109.644 , 394.2424 , 92.50392 , "None"));
Path.Add(new Vector3(-9127.827 , 373.9031 , 91.11042 , "None"));
Path.Add(new Vector3(-9152.38 , 347.5684 , 88.7276 , "None"));
Path.Add(new Vector3(-9173.243 , 319.6615 , 80.68667 , "None"));
Path.Add(new Vector3(-9182.131 , 285.002 , 76.24747 , "None"));
Path.Add(new Vector3(-9185.734 , 250.2745 , 73.35657 , "None"));
Path.Add(new Vector3(-9203.847 , 219.4665 , 71.03975 , "None"));
Path.Add(new Vector3(-9226.355 , 192.7557 , 68.17944 , "None"));
Path.Add(new Vector3(-9247.468 , 167.7061 , 67.8773 , "None"));
Path.Add(new Vector3(-9300.738 , 142.4115 , 65.75328 , "None"));
Path.Add(new Vector3(-9330.661 , 129.1264 , 63.97855 , "None"));
Path.Add(new Vector3(-9363.562 , 111.8304 , 61.33879 , "None"));
Path.Add(new Vector3(-9396.951 , 95.71441 , 58.75269 , "None"));
Path.Add(new Vector3(-9429.159 , 79.53135 , 56.48046 , "None"));
Path.Add(new Vector3(-9460.742 , 64.66945 , 55.93537 , "None"));
Path.Add(new Vector3(-9498.153 , 49.82646 , 55.99076 , "None"));
Path.Add(new Vector3(-9522.974 , -5.753819 , 55.87553 , "None"));
Path.Add(new Vector3(-9538.057 , -38.43719 , 56.47612 , "None"));
Path.Add(new Vector3(-9546.573 , -72.18629 , 57.40129 , "None"));
Path.Add(new Vector3(-9551.935 , -107.678 , 57.52954 , "None"));
Path.Add(new Vector3(-9561.072 , -141.2801 , 57.56755 , "None"));
Path.Add(new Vector3(-9576.981 , -173.5471 , 57.50922 , "None"));
Path.Add(new Vector3(-9592.285 , -204.8972 , 57.80738 , "None"));
Path.Add(new Vector3(-9603.469 , -239.1348 , 57.32788 , "None"));
Path.Add(new Vector3(-9611.698 , -272.9667 , 57.37113 , "None"));
Path.Add(new Vector3(-9617.43 , -308.5451 , 57.54576 , "None"));
Path.Add(new Vector3(-9618.165 , -343.4371 , 57.51627 , "None"));
Path.Add(new Vector3(-9616.722 , -378.3366 , 57.72635 , "None"));
Path.Add(new Vector3(-9611.7 , -413.9878 , 57.67291 , "None"));
Path.Add(new Vector3(-9601.891 , -448.6337 , 57.69151 , "None"));
Path.Add(new Vector3(-9592.288 , -482.1939 , 57.7146 , "None"));
Path.Add(new Vector3(-9600.771 , -516.8093 , 56.97266 , "None"));
Path.Add(new Vector3(-9612.474 , -549.7133 , 54.55659 , "None"));
Path.Add(new Vector3(-9619.854 , -584.9968 , 54.01591 , "None"));
Path.Add(new Vector3(-9627.081 , -619.1709 , 52.02102 , "None"));
Path.Add(new Vector3(-9636.043 , -655.165 , 49.69999 , "None"));
Path.Add(new Vector3(-9644.691 , -687.9211 , 47.49296 , "None"));
Path.Add(new Vector3(-9650.728 , -723.428 , 44.67102 , "None"));
Path.Add(new Vector3(-9652.999 , -758.2838 , 44.41936 , "None"));
Path.Add(new Vector3(-9648.53 , -793.8165 , 43.58518 , "None"));
Path.Add(new Vector3(-9642.577 , -829.3176 , 44.40097 , "None"));
Path.Add(new Vector3(-9634.797 , -863.2597 , 48.36385 , "None"));
Path.Add(new Vector3(-9664.078 , -887.3993 , 45.16174 , "None"));
Path.Add(new Vector3(-9695.493 , -893.8234 , 42.69725 , "None"));
Path.Add(new Vector3(-9727.123 , -898.6013 , 39.47514 , "None"));
Path.Add(new Vector3(-9735.313 , -898.7367 , 39.47195 , "None"));
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


public sealed class PathSurenatoSWQHub : QuestFollowPathClass
{
    public PathSurenatoSWQHub()
    {
        Name = "Path: Surena to SW Q Hub";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 14;
        RequiredQuest = 0;

        Path.Add(new Vector3(-8926.36 , 966.063 , 117.199 , "None"));
Path.Add(new Vector3(-8922.682 , 971.3444 , 117.2909 , "None"));
Path.Add(new Vector3(-8920.602 , 974.289 , 119.7011 , "None"));
Path.Add(new Vector3(-8918.159 , 976.7811 , 120.8133 , "None"));
Path.Add(new Vector3(-8916.284 , 979.8596 , 120.9989 , "None"));
Path.Add(new Vector3(-8918.236 , 985.3849 , 120.9989 , "None"));
Path.Add(new Vector3(-8925.078 , 987.1385 , 120.9989 , "None"));
Path.Add(new Vector3(-8932.057 , 988.434 , 120.9989 , "None"));
Path.Add(new Vector3(-8939.14 , 988.4457 , 121.6928 , "None"));
Path.Add(new Vector3(-8942.631 , 988.3439 , 122.0214 , "None"));
Path.Add(new Vector3(-8946.884 , 991.6464 , 122.0238 , "None"));
Path.Add(new Vector3(-8948.876 , 994.6496 , 122.0251 , "None"));
Path.Add(new Vector3(-8953.471 , 1000.058 , 122.0265 , "None"));
Path.Add(new Vector3(-8958.021 , 1005.358 , 122.0265 , "None"));
Path.Add(new Vector3(-8960.369 , 1008.094 , 122.0265 , "None"));
Path.Add(new Vector3(-8962.686 , 1010.856 , 122.0265 , "None"));
Path.Add(new Vector3(-8965.002 , 1013.618 , 122.0265 , "None"));
Path.Add(new Vector3(-8970.076 , 1018.374 , 121.0774 , "None"));
Path.Add(new Vector3(-8973.458 , 1019.449 , 118.9925 , "None"));
Path.Add(new Vector3(-8975.565 , 1018.91 , 117.6804 , "None"));
Path.Add(new Vector3(-8976.728 , 1017.96 , 116.8693 , "None"));
Path.Add(new Vector3(-8978.276 , 1014.991 , 115.1164 , "None"));
Path.Add(new Vector3(-8977.592 , 1011.458 , 113.0678 , "None"));
Path.Add(new Vector3(-8974.859 , 1009.159 , 111.2425 , "None"));
Path.Add(new Vector3(-8971.48 , 1008.975 , 109.2726 , "None"));
Path.Add(new Vector3(-8968.764 , 1011.096 , 107.4472 , "None"));
Path.Add(new Vector3(-8967.879 , 1014.53 , 105.266 , "None"));
Path.Add(new Vector3(-8969.035 , 1017.776 , 103.907 , "None"));
Path.Add(new Vector3(-8970.508 , 1020.074 , 103.3472 , "None"));
Path.Add(new Vector3(-8971.875 , 1022.928 , 101.7865 , "None"));
Path.Add(new Vector3(-8973.193 , 1026.278 , 101.4038 , "None"));
Path.Add(new Vector3(-8973.742 , 1028.167 , 101.4038 , "None"));
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


public sealed class TheBinding : QuestUseItemOnClass
{
    public TheBinding()
    {
        Name = "The Binding";

        QuestId.AddRange(new[] { 1689 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 14;
        RequiredQuest = 1688;

        EntryIdTarget.Add(92015);
EntryIdTarget.Add(5676);
HotSpots.Add(new Vector3(-8972.866 , 1043.316 , 52.86243 , "None"));
ItemId = 6928;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PathBindinggo : QuestFollowPathClass
{
    public PathBindinggo()
    {
        Name = "Path: Binding go";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 14;
        RequiredQuest = 0;

        Path.Add(new Vector3(-8985.545 , 1039.863 , 101.4039 , "None"));
Path.Add(new Vector3(-8988.628 , 1043.554 , 103.0944 , "None"));
Path.Add(new Vector3(-8991.016 , 1046.097 , 103.8728 , "None"));
Path.Add(new Vector3(-8994.495 , 1047.536 , 101.7318 , "None"));
Path.Add(new Vector3(-8997.731 , 1046.706 , 99.63195 , "None"));
Path.Add(new Vector3(-8999.753 , 1043.938 , 97.47906 , "None"));
Path.Add(new Vector3(-8999.441 , 1040.521 , 95.25447 , "None"));
Path.Add(new Vector3(-8996.725 , 1038.395 , 92.95528 , "None"));
Path.Add(new Vector3(-8993.241 , 1038.751 , 90.52464 , "None"));
Path.Add(new Vector3(-8990.516 , 1040.813 , 88.43355 , "None"));
Path.Add(new Vector3(-8990.11 , 1044.285 , 86.41753 , "None"));
Path.Add(new Vector3(-8991.842 , 1047.288 , 85.95347 , "None"));
Path.Add(new Vector3(-8994.135 , 1049.922 , 83.8488 , "None"));
Path.Add(new Vector3(-8996.429 , 1052.557 , 81.39894 , "None"));
Path.Add(new Vector3(-8998.666 , 1055.38 , 78.87017 , "None"));
Path.Add(new Vector3(-9000.638 , 1058.126 , 76.48661 , "None"));
Path.Add(new Vector3(-9001.89 , 1059.914 , 76.48661 , "None"));
Path.Add(new Vector3(-9001.172 , 1061.94 , 76.48661 , "None"));
Path.Add(new Vector3(-8998.67 , 1064.481 , 75.18195 , "None"));
Path.Add(new Vector3(-8995.721 , 1066.352 , 72.87923 , "None"));
Path.Add(new Vector3(-8992.616 , 1068.169 , 70.79328 , "None"));
Path.Add(new Vector3(-8991.259 , 1069.434 , 70.79328 , "None"));
Path.Add(new Vector3(-8989.295 , 1066.815 , 70.79328 , "None"));
Path.Add(new Vector3(-8987.116 , 1063.944 , 70.79181 , "None"));
Path.Add(new Vector3(-8984.966 , 1061.191 , 70.79041 , "None"));
Path.Add(new Vector3(-8982.854 , 1058.275 , 70.79041 , "None"));
Path.Add(new Vector3(-8983.419 , 1055.431 , 70.78892 , "None"));
Path.Add(new Vector3(-8986.285 , 1053.246 , 70.79052 , "None"));
Path.Add(new Vector3(-8988.924 , 1050.964 , 70.02418 , "None"));
Path.Add(new Vector3(-8991.792 , 1048.782 , 67.61739 , "None"));
Path.Add(new Vector3(-8994.654 , 1046.779 , 65.28857 , "None"));
Path.Add(new Vector3(-8997.521 , 1044.786 , 62.96304 , "None"));
Path.Add(new Vector3(-8998.905 , 1044.187 , 62.45228 , "None"));
Path.Add(new Vector3(-8999.916 , 1043.199 , 61.89043 , "None"));
Path.Add(new Vector3(-8998.415 , 1038.754 , 61.89043 , "None"));
Path.Add(new Vector3(-8997.11 , 1035.514 , 61.89031 , "None"));
Path.Add(new Vector3(-8995.53 , 1032.407 , 62.45242 , "None"));
Path.Add(new Vector3(-8993.118 , 1029.735 , 62.17419 , "None"));
Path.Add(new Vector3(-8990.6 , 1027.648 , 62.17419 , "None"));
Path.Add(new Vector3(-8987.241 , 1030.249 , 60.6581 , "None"));
Path.Add(new Vector3(-8984.576 , 1032.677 , 58.2556 , "None"));
Path.Add(new Vector3(-8982.024 , 1035.223 , 55.86375 , "None"));
Path.Add(new Vector3(-8979.52 , 1037.657 , 54.07288 , "None"));
Path.Add(new Vector3(-8977.491 , 1039.485 , 53.548 , "None"));
Path.Add(new Vector3(-8974.692 , 1042.088 , 52.86258 , "None"));
Path.Add(new Vector3(-8973.263 , 1043.439 , 52.86258 , "None"));
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


public sealed class PATHVoidwalkerroomrunupspiral : QuestFollowPathClass
{
    public PATHVoidwalkerroomrunupspiral()
    {
        Name = "PATH: Voidwalker room, run up spiral";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 14;
        RequiredQuest = 0;

        Path.Add(new Vector3(-8973.263 , 1043.439 , 52.86258 , "None"));
Path.Add(new Vector3(-8975.425 , 1041.437 , 52.86258 , "None"));
Path.Add(new Vector3(-8977.851 , 1039.236 , 53.54826 , "None"));
Path.Add(new Vector3(-8981.998 , 1035.998 , 55.5274 , "None"));
Path.Add(new Vector3(-8984.724 , 1033.997 , 57.78378 , "None"));
Path.Add(new Vector3(-8989.124 , 1030.765 , 61.42699 , "None"));
Path.Add(new Vector3(-8991.938 , 1028.697 , 62.17439 , "None"));
Path.Add(new Vector3(-8995.275 , 1031.491 , 62.17523 , "None"));
Path.Add(new Vector3(-8997.11 , 1034.587 , 61.89035 , "None"));
Path.Add(new Vector3(-8999.573 , 1037.031 , 61.40344 , "None"));
Path.Add(new Vector3(-8997.797 , 1043.279 , 62.45195 , "None"));
Path.Add(new Vector3(-8995.016 , 1045.561 , 64.59299 , "None"));
Path.Add(new Vector3(-8992.162 , 1047.374 , 66.8387 , "None"));
Path.Add(new Vector3(-8989.229 , 1049.467 , 69.24216 , "None"));
Path.Add(new Vector3(-8986.462 , 1051.777 , 70.79195 , "None"));
Path.Add(new Vector3(-8983.711 , 1054.106 , 70.79052 , "None"));
Path.Add(new Vector3(-8980.38 , 1060.033 , 70.78928 , "None"));
Path.Add(new Vector3(-8984.675 , 1065.394 , 70.78928 , "None"));
Path.Add(new Vector3(-8990.55 , 1069.361 , 70.79111 , "None"));
Path.Add(new Vector3(-8996.782 , 1067.003 , 73.16011 , "None"));
Path.Add(new Vector3(-8999.147 , 1064.438 , 75.4476 , "None"));
Path.Add(new Vector3(-9001.349 , 1061.584 , 76.48648 , "None"));
Path.Add(new Vector3(-9001.049 , 1056.526 , 77.19971 , "None"));
Path.Add(new Vector3(-8998.715 , 1053.93 , 79.64513 , "None"));
Path.Add(new Vector3(-8996.284 , 1051.422 , 82.08517 , "None"));
Path.Add(new Vector3(-8993.767 , 1048.842 , 84.60235 , "None"));
Path.Add(new Vector3(-8992.428 , 1047.26 , 86.09997 , "None"));
Path.Add(new Vector3(-8991.365 , 1045.871 , 85.86792 , "None"));
Path.Add(new Vector3(-8989.749 , 1042.799 , 87.22278 , "None"));
Path.Add(new Vector3(-8989.559 , 1041.085 , 88.07927 , "None"));
Path.Add(new Vector3(-8992.079 , 1038.793 , 89.91871 , "None"));
Path.Add(new Vector3(-8995.484 , 1038.221 , 92.10272 , "None"));
Path.Add(new Vector3(-8999.104 , 1039.425 , 94.58807 , "None"));
Path.Add(new Vector3(-9000.309 , 1041.83 , 96.22223 , "None"));
Path.Add(new Vector3(-9000.16 , 1044.507 , 97.78032 , "None"));
Path.Add(new Vector3(-8998.03 , 1047.231 , 99.61549 , "None"));
Path.Add(new Vector3(-8994.544 , 1047.554 , 101.7121 , "None"));
Path.Add(new Vector3(-8991.417 , 1046.109 , 103.6672 , "None"));
Path.Add(new Vector3(-8988.863 , 1043.576 , 103.0945 , "None"));
Path.Add(new Vector3(-8986.608 , 1040.909 , 101.4554 , "None"));
Path.Add(new Vector3(-8984.47 , 1038.884 , 101.404 , "None"));
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


public sealed class TheBalanceofNature : QuestGrinderClass
{
    public TheBalanceofNature()
    {
        Name = "The Balance of Nature";

        QuestId.AddRange(new[] { 456 });

        Step = new List<int> { 7, 4, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryTarget.Add(2031);
EntryTarget.Add(1984);
HotSpots.Add(new Vector3(10377.58 , 657.131 , 1326.921 , "None"));
HotSpots.Add(new Vector3(10291.84 , 664.0695 , 1339.874 , "None"));
HotSpots.Add(new Vector3(10282.21 , 819.0846 , 1338.471 , "None"));
HotSpots.Add(new Vector3(10357.03 , 976.9835 , 1330.894 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheWoodlandProtector : QuestClass
{
    public TheWoodlandProtector()
    {
        Name = "The Woodland Protector";

        QuestId.AddRange(new[] { 458 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DemonicThieves : QuestGrinderClass
{
    public DemonicThieves()
    {
        Name = "Demonic Thieves";

        QuestId.AddRange(new[] { 459 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 458;

        EntryTarget.Add(1988);
HotSpots.Add(new Vector3(10291.7 , 956.861 , 1335.65 , "None"));
HotSpots.Add(new Vector3(10338.1 , 1026.081 , 1338.18 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(3297) >= 8;
}






}


public sealed class VerdantSigil : QuestGrinderClass
{
    public VerdantSigil()
    {
        Name = "Verdant Sigil";

        QuestId.AddRange(new[] { 3120 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Druid;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class EtchedSigil : QuestGrinderClass
{
    public EtchedSigil()
    {
        Name = "Etched Sigil";

        QuestId.AddRange(new[] { 3117 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Hunter;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SimpleSigil : QuestGrinderClass
{
    public SimpleSigil()
    {
        Name = "Simple Sigil";

        QuestId.AddRange(new[] { 3116 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Warrior;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class EncryptedSigil : QuestGrinderClass
{
    public EncryptedSigil()
    {
        Name = "Encrypted Sigil";

        QuestId.AddRange(new[] { 3118 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Rogue;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HallowedSigil : QuestGrinderClass
{
    public HallowedSigil()
    {
        Name = "Hallowed Sigil";

        QuestId.AddRange(new[] { 3119 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Priest;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class NaturesDuesBalanceofNatrure2 : QuestGrinderClass
{
    public NaturesDuesBalanceofNatrure2()
    {
        Name = "Nature's Dues (Balance of Natrure 2)";

        QuestId.AddRange(new[] { 457 });

        Step = new List<int> { 7, 7, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 456;

        EntryTarget.Add(2032);
EntryTarget.Add(1985);
HotSpots.Add(new Vector3(10546.64 , 617.248 , 1331.727 , "None"));
HotSpots.Add(new Vector3(10634.84 , 716.6038 , 1324.052 , "None"));
HotSpots.Add(new Vector3(10712.64 , 791.8245 , 1325.104 , "None"));
HotSpots.Add(new Vector3(10509.02 , 758.8206 , 1315.62 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WebwoodCorruption : QuestGrinderClass
{
    public WebwoodCorruption()
    {
        Name = "Webwood Corruption";

        QuestId.AddRange(new[] { 916 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryTarget.Add(1986);
HotSpots.Add(new Vector3(10704.61 , 818.2979 , 1324.426 , "None"));
HotSpots.Add(new Vector3(10661.33 , 925.4412 , 1320.286 , "None"));
HotSpots.Add(new Vector3(10864.11 , 975.9593 , 1336.475 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(5166) >= 10;
}






}


public sealed class AGoodFriend : QuestClass
{
    public AGoodFriend()
    {
        Name = "A Good Friend";

        QuestId.AddRange(new[] { 4495 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class AFriendinNeed : QuestClass
{
    public AFriendinNeed()
    {
        Name = "A Friend in Need";

        QuestId.AddRange(new[] { 3519 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 4495;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class IverronsAntidote : QuestGathererClass
{
    public IverronsAntidote()
    {
        Name = "Iverron's Antidote";

        QuestId.AddRange(new[] { 3521 });

        Step = new List<int> { 7, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryIdObjects.Add(152094);
EntryIdObjects.Add(2843);
HotSpots.Add(new Vector3(10330.85 , 740.3021 , 1330.155 , "None"));
HotSpots.Add(new Vector3(10414.97 , 1038.449 , 1335.373 , "None"));
HotSpots.Add(new Vector3(10422.87 , 830.5562 , 1319.072 , "None"));
HotSpots.Add(new Vector3(10356.38 , 704.2383 , 1328.146 , "None"));
HotSpots.Add(new Vector3(10337.44 , 632.2571 , 1329.132 , "None"));
HotSpots.Add(new Vector3(10355.08 , 618.8475 , 1328.545 , "None"));
HotSpots.Add(new Vector3(10457.08 , 636.8618 , 1323.833 , "None"));
HotSpots.Add(new Vector3(10804.74 , 714.1309 , 1335.662 , "None"));
HotSpots.Add(new Vector3(10677.57 , 815.2651 , 1324.276 , "None"));
HotSpots.Add(new Vector3(10640.11 , 905.0707 , 1318.458 , "None"));
HotSpots.Add(new Vector3(10591.71 , 880.5239 , 1312.773 , "None"));
HotSpots.Add(new Vector3(10498.76 , 944.4309 , 1318.891 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(10639) >= 7;
}






}


public sealed class IverronsAntidoteMoonPetals : QuestGathererClass
{
    public IverronsAntidoteMoonPetals()
    {
        Name = "Iverron's Antidote Moon Petals";

        QuestId.AddRange(new[] { 3521 });

        Step = new List<int> { 0, 4, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryIdObjects.Add(2843);
EntryIdObjects.Add(152095);
HotSpots.Add(new Vector3(10485.35 , 895.7067 , 1311.107 , "None"));
HotSpots.Add(new Vector3(10505.92 , 914.2531 , 1310.768 , "None"));
HotSpots.Add(new Vector3(10555.59 , 924.3873 , 1314.795 , "None"));
HotSpots.Add(new Vector3(10536.14 , 922.7986 , 1311.229 , "None"));
HotSpots.Add(new Vector3(10574.63 , 870.6118 , 1307.813 , "None"));
HotSpots.Add(new Vector3(10586.34 , 860.6192 , 1308.989 , "None"));
HotSpots.Add(new Vector3(10603.48 , 850.1608 , 1316.376 , "None"));
HotSpots.Add(new Vector3(10622.73 , 858.1069 , 1313.132 , "None"));
HotSpots.Add(new Vector3(10563.04 , 813.4777 , 1309.692 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(10641) >= 4;
}






}


public sealed class IverronsAntidoteIchor : QuestGrinderClass
{
    public IverronsAntidoteIchor()
    {
        Name = "Iverron's Antidote Ichor";

        QuestId.AddRange(new[] { 3521 });

        Step = new List<int> { 0, 0, 1, 0, 0 };

        StepAutoDetect = new[] { false, false, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryTarget.Add(1986);
HotSpots.Add(new Vector3(10709.14 , 873.8783 , 1324.835 , "None"));
HotSpots.Add(new Vector3(10804.8 , 944.245 , 1335.939 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(10640) >= 1;
}






}


public sealed class WebwoodEgg : QuestGathererClass
{
    public WebwoodEgg()
    {
        Name = "Webwood Egg";

        QuestId.AddRange(new[] { 917 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 916;

        EntryIdObjects.Add(4406);
HotSpots.Add(new Vector3(10931.72 , 922.2396 , 1339.967 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(5167) >= 1;
}






}


public sealed class IverronsAntidotePart2 : QuestGathererClass
{
    public IverronsAntidotePart2()
    {
        Name = "Iverron's Antidote Part 2";

        QuestId.AddRange(new[] { 3522 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 3521;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TenaronsSummons : QuestClass
{
    public TenaronsSummons()
    {
        Name = "Tenaron's Summons";

        QuestId.AddRange(new[] { 920 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 917;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TeldrassilCrownofAzeroth : QuestUseItemOnClass
{
    public TeldrassilCrownofAzeroth()
    {
        Name = "Teldrassil: Crown of Azeroth";

        QuestId.AddRange(new[] { 921 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 920;

        EntryIdTarget.Add(177278);
HotSpots.Add(new Vector3(10709.23 , 762.6685 , 1321.208 , "None"));
ItemId = 5185;
Range = 3.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(5184) >= 1;
}






}


public sealed class TeldrassilPassingAwareness : QuestGrinderClass
{
    public TeldrassilPassingAwareness()
    {
        Name = "Teldrassil: Passing Awareness";

        QuestId.AddRange(new[] { 928 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 921;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GRINDTeldrasil16GreklinsV1 : QuestGrinderClass
{
    public GRINDTeldrasil16GreklinsV1()
    {
        Name = "GRIND: Teldrasil 1-6 - Greklins V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryTarget.Add(1989);
EntryTarget.Add(1985);
HotSpots.Add(new Vector3(10339.17 , 1028.618 , 1338.611 , "None"));
HotSpots.Add(new Vector3(10419.2 , 979.5048 , 1323.136 , "None"));
HotSpots.Add(new Vector3(10513.09 , 1043.734 , 1322.877 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 6;
}



public override bool HasQuest() { return true; }


}


public sealed class GRINDTeldrasil16GreklinsSpiderV1 : QuestGrinderClass
{
    public GRINDTeldrasil16GreklinsSpiderV1()
    {
        Name = "GRIND: Teldrasil 1-6 - Greklins + Spider V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryTarget.Add(1986);
EntryTarget.Add(1989);
HotSpots.Add(new Vector3(10673.49 , 920.1844 , 1323.066 , "None"));
HotSpots.Add(new Vector3(10809.72 , 937.8434 , 1336.791 , "None"));
HotSpots.Add(new Vector3(10504.1 , 1042.153 , 1324.577 , "None"));
HotSpots.Add(new Vector3(10347.15 , 1021.692 , 1337.138 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 6;
}



public override bool HasQuest() { return true; }


}


public sealed class Gettobowyer : QuestFollowPathClass
{
    public Gettobowyer()
    {
        Name = "Get to bowyer";

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

        Path.Add(new Vector3(10436.14 , 791.5803 , 1322.696 , "None"));
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


public sealed class DolanaarDelivery : QuestGrinderClass
{
    public DolanaarDelivery()
    {
        Name = "Dolanaar Delivery";

        QuestId.AddRange(new[] { 2159 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 6;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TeldrassilTheRefusaloftheAspects : QuestUseItemOnClass
{
    public TeldrassilTheRefusaloftheAspects()
    {
        Name = "Teldrassil: The Refusal of the Aspects";

        QuestId.AddRange(new[] { 929 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 5;
        MaxLevel = 7;
        RequiredQuest = 928;

        EntryIdTarget.Add(177278);
HotSpots.Add(new Vector3(9860.404 , 588.779 , 1300.712 , "None"));
ItemId = 5619;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(5639) >= 1;
}






}


public sealed class DenalansEarth : QuestClass
{
    public DenalansEarth()
    {
        Name = "Denalan's Earth";

        QuestId.AddRange(new[] { 997 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 7;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheEmeraldDreamcatcher : QuestGathererClass
{
    public TheEmeraldDreamcatcher()
    {
        Name = "The Emerald Dreamcatcher";

        QuestId.AddRange(new[] { 2438 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 7;
        RequiredQuest = 0;

        EntryIdObjects.Add(126158);
HotSpots.Add(new Vector3(9807.752 , 352.0181 , 1308.459 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(8048) >= 1;
}






}


public sealed class TimberlingSprouts : QuestGathererClass
{
    public TimberlingSprouts()
    {
        Name = "Timberling Sprouts";

        QuestId.AddRange(new[] { 919 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 7;
        RequiredQuest = 0;

        EntryIdObjects.Add(4608);
HotSpots.Add(new Vector3(9459.046 , 699.4516 , 1264.715 , "None"));
HotSpots.Add(new Vector3(9493.699 , 677.3049 , 1264.89 , "None"));
HotSpots.Add(new Vector3(9508.89 , 650.2458 , 1271.696 , "None"));
HotSpots.Add(new Vector3(9593.858 , 701.9321 , 1267.57 , "None"));
HotSpots.Add(new Vector3(9638.476 , 735.6743 , 1270.784 , "None"));
HotSpots.Add(new Vector3(9669.583 , 765.9998 , 1281.005 , "None"));
HotSpots.Add(new Vector3(9641.492 , 855.7684 , 1265.724 , "None"));
HotSpots.Add(new Vector3(9615.679 , 864.6424 , 1260.871 , "None"));
HotSpots.Add(new Vector3(9607.261 , 894.631 , 1261.75 , "None"));
HotSpots.Add(new Vector3(9560.334 , 971.2897 , 1266.703 , "None"));
HotSpots.Add(new Vector3(9589.868 , 1007.009 , 1270.91 , "None"));
HotSpots.Add(new Vector3(9376.897 , 785.0818 , 1261.951 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(5169) >= 12;
}






}


public sealed class TimberlingSeeds : QuestGrinderClass
{
    public TimberlingSeeds()
    {
        Name = "Timberling Seeds";

        QuestId.AddRange(new[] { 918 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 7;
        RequiredQuest = 0;

        EntryTarget.Add(2022);
HotSpots.Add(new Vector3(9503.977 , 649.2397 , 1270.45 , "None"));
HotSpots.Add(new Vector3(9395.959 , 858.3682 , 1259.895 , "None"));
HotSpots.Add(new Vector3(9544.679 , 990.4258 , 1263.269 , "None"));
HotSpots.Add(new Vector3(9638.04 , 774.0825 , 1269.762 , "None"));
HotSpots.Add(new Vector3(9527.646 , 1003.503 , 1257.078 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(5168) >= 8;
}






}


public sealed class TeldrassilTheComingDawn : QuestUseItemOnClass
{
    public TeldrassilTheComingDawn()
    {
        Name = "Teldrassil: The Coming Dawn";

        QuestId.AddRange(new[] { 933 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 7;
        RequiredQuest = 929;

        EntryIdTarget.Add(19551);
HotSpots.Add(new Vector3(9554.778 , 1655.498 , 1299.402 , "None"));
ItemId = 5621;
Range = 3.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(5645) >= 1;
}






}


public sealed class GRIND68TeldrasilV1 : QuestGrinderClass
{
    public GRIND68TeldrasilV1()
    {
        Name = "GRIND: 6-8 Teldrasil V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 7;
        RequiredQuest = 0;

        EntryTarget.Add(2022);
EntryTarget.Add(1995);
EntryTarget.Add(2042);
EntryTarget.Add(1998);
EntryTarget.Add(2152);
EntryTarget.Add(2025);
HotSpots.Add(new Vector3(9641.948 , 853.4612 , 1265.746 , "None"));
HotSpots.Add(new Vector3(9593.931 , 1000.513 , 1274.39 , "None"));
HotSpots.Add(new Vector3(9758.404 , 1095.687 , 1289.089 , "None"));
HotSpots.Add(new Vector3(9980.347 , 1101.829 , 1324.707 , "None"));
HotSpots.Add(new Vector3(9943.113 , 1289.933 , 1294.577 , "None"));
HotSpots.Add(new Vector3(10029.86 , 1411.207 , 1275.32 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 8;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND68TeldrasilV2Timberlings : QuestGrinderClass
{
    public GRIND68TeldrasilV2Timberlings()
    {
        Name = "GRIND: 6-8 Teldrasil V2 - Timberlings";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 7;
        RequiredQuest = 0;

        EntryTarget.Add(1998);
EntryTarget.Add(2022);
EntryTarget.Add(2042);
EntryTarget.Add(1995);
EntryTarget.Add(2008);
EntryTarget.Add(2025);
EntryTarget.Add(1999);
EntryTarget.Add(1996);
EntryTarget.Add(2043);
HotSpots.Add(new Vector3(9600.51 , 1227.181 , 1275.856 , "None"));
HotSpots.Add(new Vector3(9514.087 , 1111.682 , 1257.844 , "None"));
HotSpots.Add(new Vector3(9435.051 , 1087.792 , 1251.923 , "None"));
HotSpots.Add(new Vector3(9413.52 , 1247.597 , 1253.022 , "None"));
HotSpots.Add(new Vector3(9364.983 , 1370.189 , 1267.508 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 8;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND811TeldrasilV1 : QuestGrinderClass
{
    public GRIND811TeldrasilV1()
    {
        Name = "GRIND: 8-11 Teldrasil V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 8;
        MaxLevel = 10;
        RequiredQuest = 0;

        EntryTarget.Add(2043);
EntryTarget.Add(1999);
EntryTarget.Add(2025);
EntryTarget.Add(1996);
EntryTarget.Add(2033);
EntryTarget.Add(1997);
HotSpots.Add(new Vector3(9423.442 , 1417.014 , 1293.5 , "None"));
HotSpots.Add(new Vector3(9302.915 , 1372.143 , 1288.914 , "None"));
HotSpots.Add(new Vector3(9218.418 , 1220.295 , 1315.641 , "None"));
HotSpots.Add(new Vector3(9209.428 , 1090.527 , 1317.99 , "None"));
HotSpots.Add(new Vector3(9226.57 , 1535.403 , 1299.691 , "None"));
HotSpots.Add(new Vector3(9279.458 , 1651.851 , 1302.702 , "None"));
HotSpots.Add(new Vector3(9407.012 , 1637.24 , 1292.652 , "None"));
HotSpots.Add(new Vector3(9805.115 , 1742.25 , 1315.661 , "None"));
HotSpots.Add(new Vector3(9698.799 , 1845.756 , 1300.228 , "None"));
HotSpots.Add(new Vector3(10078 , 1826.093 , 1328.123 , "None"));
HotSpots.Add(new Vector3(10315.91 , 1751.167 , 1316.484 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 11;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND811TeldrasilV2 : QuestGrinderClass
{
    public GRIND811TeldrasilV2()
    {
        Name = "GRIND: 8-11 Teldrasil V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 8;
        MaxLevel = 10;
        RequiredQuest = 0;

        EntryTarget.Add(1997);
EntryTarget.Add(2017);
EntryTarget.Add(2015);
EntryTarget.Add(2033);
EntryTarget.Add(2029);
EntryTarget.Add(2030);
EntryTarget.Add(2000);
HotSpots.Add(new Vector3(10532.54 , 1883.445 , 1315.881 , "None"));
HotSpots.Add(new Vector3(10599.05 , 1797.909 , 1319.029 , "None"));
HotSpots.Add(new Vector3(10673.11 , 1694.891 , 1294.593 , "None"));
HotSpots.Add(new Vector3(10715.41 , 1663.566 , 1277.034 , "None"));
HotSpots.Add(new Vector3(10774.65 , 1623.867 , 1272.169 , "None"));
HotSpots.Add(new Vector3(10814.84 , 1628.339 , 1272.934 , "None"));
HotSpots.Add(new Vector3(10545.05 , 1487.195 , 1322.163 , "None"));
HotSpots.Add(new Vector3(10444.84 , 1470.847 , 1321.972 , "None"));
HotSpots.Add(new Vector3(10302.74 , 1407.118 , 1341.293 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 11;
}



public override bool HasQuest() { return true; }


}


public sealed class TheEnchantedGlade : QuestGrinderClass
{
    public TheEnchantedGlade()
    {
        Name = "The Enchanted Glade";

        QuestId.AddRange(new[] { 937 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 14;
        RequiredQuest = 0;

        EntryTarget.Add(2017);
EntryTarget.Add(2015);
EntryTarget.Add(2018);
HotSpots.Add(new Vector3(10551.2 , 1913.894 , 1319.133 , "None"));
HotSpots.Add(new Vector3(10507 , 1950.268 , 1321.872 , "None"));
HotSpots.Add(new Vector3(10436.96 , 1933.972 , 1317.531 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PATHTeldrassilTeldrassilPortal : QuestFollowPathClass
{
    public PATHTeldrassilTeldrassilPortal()
    {
        Name = "PATH: Teldrassil - Teldrassil Portal";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 52;
        RequiredQuest = 0;

        Path.Add(new Vector3(9983.987 , 1953.987 , 1325.744 , "None"));
Path.Add(new Vector3(9983.313 , 2000.647 , 1328.116 , "None"));
Path.Add(new Vector3(9979.373 , 2036.431 , 1328.103 , "None"));
Path.Add(new Vector3(9971.867 , 2070.545 , 1329.558 , "None"));
Path.Add(new Vector3(9962.569 , 2104.214 , 1328.155 , "None"));
Path.Add(new Vector3(9954.871 , 2139.419 , 1327.644 , "None"));
Path.Add(new Vector3(9950.775 , 2174.099 , 1327.463 , "None"));
Path.Add(new Vector3(9950.983 , 2210.032 , 1329.248 , "None"));
Path.Add(new Vector3(9951.901 , 2239.475 , 1333.168 , "None"));
Path.Add(new Vector3(9952.378 , 2253.62 , 1335.337 , "None"));
Path.Add(new Vector3(9952.552 , 2288.547 , 1341.395 , "None"));
Path.Add(new Vector3(9951.932 , 2311.495 , 1336.552 , "None"));
Path.Add(new Vector3(9950.671 , 2338.765 , 1330.921 , "None"));
Path.Add(new Vector3(9949.335 , 2374.79 , 1329.979 , "None"));
Path.Add(new Vector3(9948.133 , 2409.7 , 1327.721 , "None"));
Path.Add(new Vector3(9946.893 , 2445.728 , 1322.661 , "None"));
Path.Add(new Vector3(9940.418 , 2479.805 , 1315.974 , "None"));
Path.Add(new Vector3(9925.186 , 2502.393 , 1318.111 , "None"));
Path.Add(new Vector3(9912.887 , 2528.797 , 1316.504 , "None"));
Path.Add(new Vector3(9924.6 , 2544.747 , 1317.176 , "None"));
Path.Add(new Vector3(9940.824 , 2553.736 , 1316.642 , "None"));
Path.Add(new Vector3(9948.565 , 2571.326 , 1318.296 , "None"));
Path.Add(new Vector3(9947.868 , 2595.36 , 1316.229 , "None"));
Path.Add(new Vector3(9947.17 , 2610.604 , 1316.266 , "None"));
Path.Add(new Vector3(9946.869 , 2617.177 , 1316.569 , "None"));
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


public sealed class Teldrassil : QuestClass
{
    public Teldrassil()
    {
        Name = "Teldrassil";

        QuestId.AddRange(new[] { 940 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 14;
        RequiredQuest = 937;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GroveoftheAncients : QuestClass
{
    public GroveoftheAncients()
    {
        Name = "Grove of the Ancients";

        QuestId.AddRange(new[] { 952 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 13;
        RequiredQuest = 940;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Buzzbox827 : QuestGrinderClass
{
    public Buzzbox827()
    {
        Name = "Buzzbox 827";

        QuestId.AddRange(new[] { 983 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 13;
        RequiredQuest = 0;

        EntryTarget.Add(2231);
EntryTarget.Add(2234);
HotSpots.Add(new Vector3(6361.343 , 605.6059 , -0.7631472 , "Swimming"));
HotSpots.Add(new Vector3(6296.808 , 629.4449 , -1.780561 , "Swimming"));
HotSpots.Add(new Vector3(6196.199 , 543.2054 , 7.075305 , "None"));
HotSpots.Add(new Vector3(6153.966 , 617.0645 , -2.122027 , "Swimming"));
HotSpots.Add(new Vector3(5945.121 , 632.2867 , 0.3863332 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(5385) >= 6;
}






}


public sealed class WashedAshore : QuestGathererClass
{
    public WashedAshore()
    {
        Name = "Washed Ashore";

        QuestId.AddRange(new[] { 3524 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 13;
        RequiredQuest = 0;

        EntryIdObjects.Add(175207);
EntryIdObjects.Add(2202);
HotSpots.Add(new Vector3(6138.75 , 550.2246 , 5.410436 , "None"));
HotSpots.Add(new Vector3(6105.833 , 535.0008 , 3.999639 , "None"));
HotSpots.Add(new Vector3(6109.23 , 555.6361 , 1.365296 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(12242) >= 1;
}






}


public sealed class BashalAran : QuestClass
{
    public BashalAran()
    {
        Name = "Bashal'Aran";

        QuestId.AddRange(new[] { 954 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 13;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ToolsoftheHighborne : QuestGrinderClass
{
    public ToolsoftheHighborne()
    {
        Name = "Tools of the Highborne";

        QuestId.AddRange(new[] { 958 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 13;
        RequiredQuest = 0;

        EntryTarget.Add(2177);
EntryTarget.Add(2176);
HotSpots.Add(new Vector3(5761.677 , 222.7866 , 30.88739 , "None"));
HotSpots.Add(new Vector3(5838.039 , 208.0733 , 32.77435 , "None"));
HotSpots.Add(new Vector3(5842.72 , 152.1976 , 33.81515 , "None"));
HotSpots.Add(new Vector3(5822.755 , 96.9474 , 33.32022 , "None"));
HotSpots.Add(new Vector3(5802.618 , 75.34971 , 35.43002 , "None"));
HotSpots.Add(new Vector3(5761.106 , 60.40435 , 36.07519 , "None"));
HotSpots.Add(new Vector3(5718.397 , 50.8391 , 32.79959 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(5360) >= 7;
}






}


public sealed class WashedAshorePart2TurtleRemain : QuestGathererClass
{
    public WashedAshorePart2TurtleRemain()
    {
        Name = "Washed Ashore Part 2 TurtleRemain";

        QuestId.AddRange(new[] { 4681 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 13;
        RequiredQuest = 3524;

        EntryIdObjects.Add(176189);
HotSpots.Add(new Vector3(6312.643 , 854.2552 , -13.45618 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(12289) >= 1;
}






}


public sealed class Buzzbox411 : QuestGrinderClass
{
    public Buzzbox411()
    {
        Name = "Buzzbox 411";

        QuestId.AddRange(new[] { 1001 });

        Step = new List<int> { 3, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 13;
        RequiredQuest = 983;

        EntryTarget.Add(2185);
HotSpots.Add(new Vector3(6719.262 , 659.5329 , -0.8629201 , "Swimming"));
HotSpots.Add(new Vector3(6774.48 , 732.4684 , -25.1131 , "Swimming"));
HotSpots.Add(new Vector3(6759.171 , 810.0518 , -9.871448 , "Swimming"));
HotSpots.Add(new Vector3(6863.208 , 791.2855 , -1.965398 , "Swimming"));
HotSpots.Add(new Vector3(6983.202 , 730.312 , -1.952527 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(5412) >= 3;
}






}


public sealed class PATHBashalAranQ : QuestFollowPathClass
{
    public PATHBashalAranQ()
    {
        Name = "PATH: Bashal Aran Q";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 13;
        RequiredQuest = 0;

        Path.Add(new Vector3(6419.28 , 398.7195 , 11.40753 , "None"));
Path.Add(new Vector3(6392.188 , 363.4117 , 18.07686 , "None"));
Path.Add(new Vector3(6367.179 , 355.9812 , 21.88863 , "None"));
Path.Add(new Vector3(6338.767 , 336.3629 , 24.87836 , "None"));
Path.Add(new Vector3(6307.166 , 308.5944 , 24.17366 , "None"));
Path.Add(new Vector3(6331.918 , 269.7433 , 27.99752 , "None"));
Path.Add(new Vector3(6361.718 , 256.4639 , 29.19903 , "None"));
Path.Add(new Vector3(6394.208 , 244.1472 , 28.7879 , "None"));
Path.Add(new Vector3(6424.371 , 224.679 , 30.28197 , "None"));
Path.Add(new Vector3(6444.75 , 208.3536 , 31.66907 , "None"));
Path.Add(new Vector3(6462.544 , 192.1902 , 30.94928 , "None"));
Path.Add(new Vector3(6492.498 , 174.8006 , 31.41298 , "None"));
Path.Add(new Vector3(6527.255 , 174.1611 , 31.79276 , "None"));
Path.Add(new Vector3(6562.654 , 180.5895 , 32.72719 , "None"));
Path.Add(new Vector3(6597.686 , 186.0458 , 32.18543 , "None"));
Path.Add(new Vector3(6632.343 , 182.0138 , 30.12685 , "None"));
Path.Add(new Vector3(6667.237 , 182.2626 , 28.08179 , "None"));
Path.Add(new Vector3(6691.029 , 179.6728 , 24.3625 , "None"));
Path.Add(new Vector3(6748.845 , 135.9759 , 21.06984 , "None"));
Path.Add(new Vector3(6759.674 , 123.6902 , 22.11753 , "None"));
Path.Add(new Vector3(6771.423 , 112.3464 , 21.78997 , "None"));
Path.Add(new Vector3(6782.051 , 101.2987 , 20.84793 , "None"));
Path.Add(new Vector3(6796.364 , 81.72796 , 19.42281 , "None"));
Path.Add(new Vector3(6806.481 , 54.51833 , 17.50594 , "None"));
Path.Add(new Vector3(6780.376 , 28.54142 , 25.48794 , "None"));
Path.Add(new Vector3(6762.614 , 20.45016 , 33.53133 , "None"));
Path.Add(new Vector3(6749.785 , 25.94797 , 41.21204 , "None"));
Path.Add(new Vector3(6746.622 , 40.69117 , 47.87332 , "None"));
Path.Add(new Vector3(6746.041 , 42.1822 , 47.95876 , "None"));
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


public sealed class BashalAranP2Grells : QuestGrinderClass
{
    public BashalAranP2Grells()
    {
        Name = "Bashal'Aran P2 Grells";

        QuestId.AddRange(new[] { 955 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 13;
        RequiredQuest = 954;

        EntryTarget.Add(2189);
EntryTarget.Add(2190);
HotSpots.Add(new Vector3(6735.76 , 22.7679 , 43.88197 , "None"));
HotSpots.Add(new Vector3(6698.379 , 31.27081 , 43.27796 , "None"));
HotSpots.Add(new Vector3(6655.135 , 55.92473 , 30.83523 , "None"));
HotSpots.Add(new Vector3(6611.557 , 30.43073 , 33.90327 , "None"));
HotSpots.Add(new Vector3(6571.15 , -34.35767 , 36.33712 , "None"));
HotSpots.Add(new Vector3(6727.182 , -99.1485 , 42.94209 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(5336) >= 8;
}






}


public sealed class BashalAranPart3Moonstone : QuestGrinderClass
{
    public BashalAranPart3Moonstone()
    {
        Name = "Bashal'Aran Part 3 Moonstone";

        QuestId.AddRange(new[] { 956 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 13;
        RequiredQuest = 955;

        EntryTarget.Add(2212);
HotSpots.Add(new Vector3(6726.8 , -17.2349 , 42.40748 , "None"));
HotSpots.Add(new Vector3(6715.154 , -188.6839 , 33.77113 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(5338) >= 1;
}






}


public sealed class BashalAranP4Destroy : QuestUseItemOnClass
{
    public BashalAranP4Destroy()
    {
        Name = "Bashal'Aran P4 - Destroy";

        QuestId.AddRange(new[] { 957 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 13;
        RequiredQuest = 956;

        EntryIdTarget.Add(16393);
EntryIdTarget.Add(16394);
HotSpots.Add(new Vector3(5635.256 , 166.8669 , 32.22519 , "None"));
ItemId = 5338;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(5338) < 1;
}






}


public sealed class pathFromAsterionToDESTROY : QuestFollowPathClass
{
    public pathFromAsterionToDESTROY()
    {
        Name = "path: From Asterion To DESTROY";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 13;
        RequiredQuest = 0;

        Path.Add(new Vector3(6796.112 , 87.64467 , 19.75619 , "None"));
Path.Add(new Vector3(6773.11 , 110.9148 , 21.74887 , "None"));
Path.Add(new Vector3(6754.779 , 129.6992 , 21.83889 , "None"));
Path.Add(new Vector3(6752.426 , 131.8976 , 21.61232 , "None"));
Path.Add(new Vector3(6733.324 , 148.222 , 19.99668 , "None"));
Path.Add(new Vector3(6705.786 , 171.4112 , 22.43802 , "None"));
Path.Add(new Vector3(6678.422 , 184.238 , 26.32943 , "None"));
Path.Add(new Vector3(6648.993 , 185.0625 , 29.45578 , "None"));
Path.Add(new Vector3(6613.145 , 187.1187 , 31.34908 , "None"));
Path.Add(new Vector3(6578.406 , 184.8573 , 33.22041 , "None"));
Path.Add(new Vector3(6542.59 , 180.7532 , 31.68622 , "None"));
Path.Add(new Vector3(6506.779 , 176.6124 , 31.8721 , "None"));
Path.Add(new Vector3(6473.463 , 185.9631 , 30.52645 , "None"));
Path.Add(new Vector3(6442.951 , 204.9261 , 31.7634 , "None"));
Path.Add(new Vector3(6416.271 , 227.4384 , 29.74101 , "None"));
Path.Add(new Vector3(6387.707 , 247.043 , 29.40774 , "None"));
Path.Add(new Vector3(6353.972 , 259.5862 , 28.90032 , "None"));
Path.Add(new Vector3(6323.401 , 275.6046 , 27.13417 , "None"));
Path.Add(new Vector3(6302.573 , 304.913 , 24.20283 , "None"));
Path.Add(new Vector3(6271.18 , 320.8535 , 24.10585 , "None"));
Path.Add(new Vector3(6236.617 , 325.0252 , 27.29297 , "None"));
Path.Add(new Vector3(6202.277 , 319.3394 , 27.32173 , "None"));
Path.Add(new Vector3(6169.449 , 304.5367 , 26.40432 , "None"));
Path.Add(new Vector3(6137.381 , 288.07 , 23.76979 , "None"));
Path.Add(new Vector3(6104.51 , 276.6143 , 19.67377 , "None"));
Path.Add(new Vector3(6071.152 , 263.1102 , 21.4819 , "None"));
Path.Add(new Vector3(6038.574 , 250.7984 , 21.31131 , "None"));
Path.Add(new Vector3(6002.995 , 245.3204 , 20.72574 , "None"));
Path.Add(new Vector3(5968.598 , 239.244 , 21.04 , "None"));
Path.Add(new Vector3(5934.02 , 238.1874 , 24.00872 , "None"));
Path.Add(new Vector3(5900.034 , 250.0904 , 24.30365 , "None"));
Path.Add(new Vector3(5866.173 , 262.4376 , 24.73833 , "None"));
Path.Add(new Vector3(5842.729 , 271.4775 , 25.00956 , "None"));
Path.Add(new Vector3(5813.001 , 278.2342 , 24.34896 , "None"));
Path.Add(new Vector3(5812.499 , 251.5975 , 32.7163 , "None"));
Path.Add(new Vector3(5735.393 , 304.1441 , 20.57866 , "None"));
Path.Add(new Vector3(5707.316 , 289.0941 , 20.88237 , "None"));
Path.Add(new Vector3(5702.275 , 260.0607 , 25.09966 , "None"));
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


public sealed class TheFallofAmethAran : QuestGathererClass
{
    public TheFallofAmethAran()
    {
        Name = "The Fall of Ameth'Aran";

        QuestId.AddRange(new[] { 953 });

        Step = new List<int> { 1, 1, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 13;
        RequiredQuest = 0;

        EntryIdObjects.Add(17189);
EntryIdObjects.Add(17188);
EntryIdObjects.Add(106319);
HotSpots.Add(new Vector3(5575.86 , 148.9225 , 28.93298 , "None"));
HotSpots.Add(new Vector3(5769.328 , 106.3681 , 35.16092 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PathGroveofAncienttoBashalTurnIn : QuestFollowPathClass
{
    public PathGroveofAncienttoBashalTurnIn()
    {
        Name = "Path: Grove of Ancient to Bashal TurnIn";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 13;
        RequiredQuest = 0;

        Path.Add(new Vector3(4993.154 , 216.6721 , 37.577 , "None"));
Path.Add(new Vector3(5012.168 , 221.7041 , 33.83817 , "None"));
Path.Add(new Vector3(5045.672 , 231.3508 , 30.41057 , "None"));
Path.Add(new Vector3(5080.757 , 239.2052 , 28.28047 , "None"));
Path.Add(new Vector3(5115.535 , 242.42 , 30.01495 , "None"));
Path.Add(new Vector3(5151.53 , 243.8015 , 31.48083 , "None"));
Path.Add(new Vector3(5186.386 , 244.4804 , 34.53234 , "None"));
Path.Add(new Vector3(5222.375 , 246.5539 , 33.24432 , "None"));
Path.Add(new Vector3(5257.231 , 248.8248 , 30.17727 , "None"));
Path.Add(new Vector3(5292.801 , 254.289 , 28.08228 , "None"));
Path.Add(new Vector3(5325.528 , 266.3074 , 27.4285 , "None"));
Path.Add(new Vector3(5359.249 , 279.0555 , 26.74569 , "None"));
Path.Add(new Vector3(5393.482 , 285.4007 , 28.45887 , "None"));
Path.Add(new Vector3(5426.1 , 278.4929 , 31.31775 , "None"));
Path.Add(new Vector3(5461.534 , 278.4194 , 30.61046 , "None"));
Path.Add(new Vector3(5494.233 , 290.5581 , 29.23112 , "None"));
Path.Add(new Vector3(5526.935 , 305.7316 , 27.99436 , "None"));
Path.Add(new Vector3(5560.463 , 314.9175 , 27.40469 , "None"));
Path.Add(new Vector3(5586.529 , 316.6316 , 25.64865 , "None"));
Path.Add(new Vector3(5621.455 , 316.0579 , 21.33108 , "None"));
Path.Add(new Vector3(5657.494 , 315.2706 , 18.81683 , "None"));
Path.Add(new Vector3(5693.361 , 312.4373 , 19.04061 , "None"));
Path.Add(new Vector3(5728.004 , 308.2663 , 20.40511 , "None"));
Path.Add(new Vector3(5759.328 , 295.4919 , 20.61524 , "None"));
Path.Add(new Vector3(5792.764 , 282.3828 , 22.5517 , "None"));
Path.Add(new Vector3(5827.677 , 273.7053 , 25.25772 , "None"));
Path.Add(new Vector3(5860.353 , 261.3648 , 24.66095 , "None"));
Path.Add(new Vector3(5893.51 , 250.3809 , 24.05168 , "None"));
Path.Add(new Vector3(5927.886 , 239.5676 , 24.06854 , "None"));
Path.Add(new Vector3(5963.364 , 234.4135 , 21.07736 , "None"));
Path.Add(new Vector3(5997.323 , 242.0861 , 20.34052 , "None"));
Path.Add(new Vector3(6031.064 , 254.7581 , 22.16651 , "None"));
Path.Add(new Vector3(6063.184 , 268.4775 , 21.17756 , "None"));
Path.Add(new Vector3(6097.674 , 273.0385 , 19.39709 , "None"));
Path.Add(new Vector3(6133.236 , 277.4264 , 21.72228 , "None"));
Path.Add(new Vector3(6164.222 , 295.8146 , 25.91952 , "None"));
Path.Add(new Vector3(6193.7 , 314.4324 , 27.29197 , "None"));
Path.Add(new Vector3(6227.594 , 321.4473 , 27.78952 , "None"));
Path.Add(new Vector3(6263.525 , 319.1169 , 24.59106 , "None"));
Path.Add(new Vector3(6295.158 , 319.3896 , 22.70651 , "None"));
Path.Add(new Vector3(6315.708 , 290.0653 , 26.10355 , "None"));
Path.Add(new Vector3(6340.409 , 264.6834 , 28.53634 , "None"));
Path.Add(new Vector3(6372.352 , 250.6515 , 29.8499 , "None"));
Path.Add(new Vector3(6404.811 , 237.8208 , 28.88274 , "None"));
Path.Add(new Vector3(6434.075 , 216.9256 , 30.83155 , "None"));
Path.Add(new Vector3(6462.103 , 194.2528 , 31.13784 , "None"));
Path.Add(new Vector3(6490.24 , 173.6601 , 31.41517 , "None"));
Path.Add(new Vector3(6542.062 , 175.0863 , 31.67823 , "None"));
Path.Add(new Vector3(6576.242 , 182.284 , 33.2197 , "None"));
Path.Add(new Vector3(6612.04 , 184.3149 , 31.29792 , "None"));
Path.Add(new Vector3(6646.87 , 181.6633 , 29.41485 , "None"));
Path.Add(new Vector3(6683.88 , 179.0938 , 25.75403 , "None"));
Path.Add(new Vector3(6712.234 , 164.5565 , 21.98664 , "None"));
Path.Add(new Vector3(6736.228 , 143.0654 , 20.24933 , "None"));
Path.Add(new Vector3(6743.794 , 124.9382 , 22.61057 , "None"));
Path.Add(new Vector3(6739.606 , 103.5069 , 25.18121 , "None"));
Path.Add(new Vector3(6773.375 , 81.51282 , 27.65013 , "None"));
Path.Add(new Vector3(6795.054 , 55.9223 , 21.86473 , "None"));
Path.Add(new Vector3(6789.575 , 29.93573 , 22.943 , "None"));
Path.Add(new Vector3(6773.153 , 18.91866 , 29.62387 , "None"));
Path.Add(new Vector3(6756.324 , 15.35146 , 36.7617 , "None"));
Path.Add(new Vector3(6737.463 , 25.30795 , 44.18531 , "None"));
Path.Add(new Vector3(6743.165 , 40.03177 , 47.10559 , "None"));
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


public sealed class GRIND1114DarkshoreV1 : QuestGrinderClass
{
    public GRIND1114DarkshoreV1()
    {
        Name = "GRIND: 11-14 - Darkshore V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 13;
        RequiredQuest = 0;

        EntryTarget.Add(2070);
EntryTarget.Add(2321);
EntryTarget.Add(2163);
EntryTarget.Add(10160);
EntryTarget.Add(10158);
EntryTarget.Add(2189);
EntryTarget.Add(2190);
HotSpots.Add(new Vector3(5779.803 , 25.87772 , 37.97767 , "None"));
HotSpots.Add(new Vector3(5925.449 , -22.60924 , 37.37793 , "None"));
HotSpots.Add(new Vector3(5916.054 , 172.3524 , 28.01443 , "None"));
HotSpots.Add(new Vector3(6282.159 , 265.0521 , 32.08386 , "None"));
HotSpots.Add(new Vector3(6447.921 , 148.7314 , 38.53989 , "None"));
HotSpots.Add(new Vector3(6469.168 , -153.4067 , 40.70543 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 14;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND1114DarkshoreV2 : QuestGrinderClass
{
    public GRIND1114DarkshoreV2()
    {
        Name = "GRIND: 11-14 - Darkshore V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 13;
        RequiredQuest = 0;

        EntryTarget.Add(2070);
EntryTarget.Add(2321);
EntryTarget.Add(2234);
EntryTarget.Add(2163);
HotSpots.Add(new Vector3(6820.972 , 371.1812 , 19.68954 , "None"));
HotSpots.Add(new Vector3(6976.517 , 274.9249 , 2.149661 , "None"));
HotSpots.Add(new Vector3(6774.175 , 198.632 , 24.05879 , "None"));
HotSpots.Add(new Vector3(7026.343 , 69.84252 , 16.0583 , "None"));
HotSpots.Add(new Vector3(7001.826 , -18.87892 , 17.88157 , "None"));
HotSpots.Add(new Vector3(6675.041 , 258.6496 , 29.73154 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 14;
}



public override bool HasQuest() { return true; }


}


public sealed class HeedingtheCall : QuestClass
{
    public HeedingtheCall()
    {
        Name = "Heeding the Call";

        QuestId.AddRange(new[] { 5923 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 14;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Moonglade : QuestClass
{
    public Moonglade()
    {
        Name = "Moonglade";

        QuestId.AddRange(new[] { 5921 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 14;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GreatBearSpirit : QuestInteractWithClass
{
    public GreatBearSpirit()
    {
        Name = "Great Bear Spirit";

        QuestId.AddRange(new[] { 5929 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 14;
        RequiredQuest = 0;

        EntryIdTarget.Add(11956);
HotSpots.Add(new Vector3(8068.29 , -2284.12 , 496.9193 , "None"));
GossipOptionNpcInteractWith = 1;
Macro = "GossipTitleButton1:Click(); GossipTitleButton1:Click(); GossipTitleButton1:Click(); GossipTitleButton1:Click(); GossipTitleButton1:Click(); GossipTitleButton1:Click(); GossipTitleButton1:Click(); GossipTitleButton1:Click();";
IgnoreIfDead = false;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BacktoDarnassus : QuestClass
{
    public BacktoDarnassus()
    {
        Name = "Back to Darnassus";

        QuestId.AddRange(new[] { 5931 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 14;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BodyandHeart : QuestUseItemOnClass
{
    public BodyandHeart()
    {
        Name = "Body and Heart";

        QuestId.AddRange(new[] { 6001 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 14;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(6326.053 , 93.90051 , 21.7731 , "None"));
ItemId = 15208;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WalkintotreeDarn : QuestFollowPathClass
{
    public WalkintotreeDarn()
    {
        Name = "Walk into tree Darn";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 14;
        RequiredQuest = 0;

        Path.Add(new Vector3(9947.171 , 2607.866 , 1316.217 , "None"));
Path.Add(new Vector3(9947.152 , 2612.24 , 1316.244 , "None"));
Path.Add(new Vector3(9947.188 , 2615.74 , 1316.335 , "None"));
Path.Add(new Vector3(9947.223 , 2619.239 , 1317.051 , "None"));
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


public sealed class WalkintotreeVillage : QuestFollowPathClass
{
    public WalkintotreeVillage()
    {
        Name = "Walk into tree Village";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 14;
        RequiredQuest = 0;

        Path.Add(new Vector3(8778.538 , 962.623 , 30.27643 , "None"));
Path.Add(new Vector3(8784.773 , 964.681 , 30.20182 , "None"));
Path.Add(new Vector3(8788.822 , 966.0152 , 30.19524 , "None"));
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


public sealed class gettoauberdineFP : QuestFollowPathClass
{
    public gettoauberdineFP()
    {
        Name = "get to auberdine FP";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 14;
        RequiredQuest = 0;

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


public sealed class Buzzbox323 : QuestGrinderClass
{
    public Buzzbox323()
    {
        Name = "Buzzbox 323";

        QuestId.AddRange(new[] { 1002 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 14;
        RequiredQuest = 1001;

        EntryTarget.Add(2070);
EntryTarget.Add(2069);
HotSpots.Add(new Vector3(7075.245 , 85.10886 , 14.51986 , "None"));
HotSpots.Add(new Vector3(7123.361 , -263.2318 , 35.93752 , "None"));
HotSpots.Add(new Vector3(7224.215 , -256.4141 , 25.82979 , "None"));
HotSpots.Add(new Vector3(7155.282 , -372.396 , 41.6231 , "None"));
HotSpots.Add(new Vector3(7048.668 , -510.269 , 39.83772 , "None"));
HotSpots.Add(new Vector3(7311.48 , -694.5192 , 21.3628 , "None"));
HotSpots.Add(new Vector3(7370.375 , -636.5992 , 23.36298 , "None"));
HotSpots.Add(new Vector3(7423.556 , -700.9252 , 17.34473 , "None"));
HotSpots.Add(new Vector3(6943.983 , -50.1394 , 20.41602 , "None"));
HotSpots.Add(new Vector3(6644.45 , 367.7658 , 28.53595 , "None"));
HotSpots.Add(new Vector3(6508.897 , 273.9893 , 33.4034 , "None"));
HotSpots.Add(new Vector3(6433.405 , 243.892 , 33.34706 , "None"));
HotSpots.Add(new Vector3(6201.006 , 387.5252 , 30.66536 , "None"));
HotSpots.Add(new Vector3(6113.409 , 410.4259 , 28.9857 , "None"));
HotSpots.Add(new Vector3(6140.162 , 315.9728 , 26.90894 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(5413) >= 6;
}






}


public sealed class Buzzbox525 : QuestGrinderClass
{
    public Buzzbox525()
    {
        Name = "Buzzbox 525";

        QuestId.AddRange(new[] { 1003 });

        Step = new List<int> { 4, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 16;
        RequiredQuest = 1002;

        EntryTarget.Add(2165);
HotSpots.Add(new Vector3(4905.45 , 463.3205 , 31.27254 , "None"));
HotSpots.Add(new Vector3(4784.292 , 368.8882 , 43.3909 , "None"));
HotSpots.Add(new Vector3(4799.032 , 283.4822 , 50.76973 , "None"));
HotSpots.Add(new Vector3(4710.552 , 138.4729 , 52.83562 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(5414) >= 4;
}






}


public sealed class TheRedCrystal : QuestClass
{
    public TheRedCrystal()
    {
        Name = "The Red Crystal";

        QuestId.AddRange(new[] { 4811 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 16;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheTowerofAlthalaxx : QuestClass
{
    public TheTowerofAlthalaxx()
    {
        Name = "The Tower of Althalaxx";

        QuestId.AddRange(new[] { 965 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 16;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PathLargeRedCrystalQ : QuestFollowPathClass
{
    public PathLargeRedCrystalQ()
    {
        Name = "Path: Large Red Crystal Q";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 16;
        RequiredQuest = 0;

        Path.Add(new Vector3(6306.365 , 293.3788 , 25.16737 , "None"));
Path.Add(new Vector3(6298.621 , 274.1464 , 31.09458 , "None"));
Path.Add(new Vector3(6286.824 , 264.4664 , 32.22322 , "None"));
Path.Add(new Vector3(6278.319 , 248.8391 , 32.87572 , "None"));
Path.Add(new Vector3(6264.374 , 237.8787 , 36.00902 , "None"));
Path.Add(new Vector3(6250.464 , 217.7057 , 40.9906 , "None"));
Path.Add(new Vector3(6237.763 , 201.8472 , 42.83592 , "None"));
Path.Add(new Vector3(6229.345 , 189.1436 , 43.42746 , "None"));
Path.Add(new Vector3(6226.414 , 165.603 , 40.36136 , "None"));
Path.Add(new Vector3(6226.06 , 138.3053 , 42.84225 , "None"));
Path.Add(new Vector3(6230.583 , 113.6726 , 43.60362 , "None"));
Path.Add(new Vector3(6231.373 , 95.13948 , 43.34258 , "None"));
Path.Add(new Vector3(6228.375 , 73.55963 , 43.03523 , "None"));
Path.Add(new Vector3(6217.264 , 63.09967 , 41.51064 , "None"));
Path.Add(new Vector3(6209.032 , 47.65737 , 37.27299 , "None"));
Path.Add(new Vector3(6203.168 , 24.48895 , 37.95915 , "None"));
Path.Add(new Vector3(6190.079 , 1.817389 , 44.77488 , "None"));
Path.Add(new Vector3(6182.905 , -22.05207 , 44.758 , "None"));
Path.Add(new Vector3(6182.112 , -53.56152 , 46.06265 , "None"));
Path.Add(new Vector3(6183.838 , -75.31518 , 47.97473 , "None"));
Path.Add(new Vector3(6187.038 , -97.98264 , 47.50263 , "None"));
Path.Add(new Vector3(6187.54 , -117.6458 , 53.28976 , "None"));
Path.Add(new Vector3(6187.843 , -121.9751 , 55.19762 , "None"));
Path.Add(new Vector3(6193.669 , -144.111 , 69.76516 , "None"));
Path.Add(new Vector3(6197.059 , -149.7492 , 73.46381 , "None"));
Path.Add(new Vector3(6200.829 , -155.1418 , 79.06792 , "None"));
Path.Add(new Vector3(6204.706 , -157.0929 , 80.75621 , "None"));
Path.Add(new Vector3(6206.723 , -159.4937 , 80.87687 , "None"));
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


public sealed class AsWaterCascades : QuestUseItemOnClass
{
    public AsWaterCascades()
    {
        Name = "As Water Cascades";

        QuestId.AddRange(new[] { 4812 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 16;
        RequiredQuest = 4811;

        EntryIdTarget.Add(177274);
HotSpots.Add(new Vector3(6410.235 , 466.4604 , 8.121204 , "None"));
ItemId = 14338;
Range = 3.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(14339) >= 1;
}






}


public sealed class TheFragmentsWithin : QuestClass
{
    public TheFragmentsWithin()
    {
        Name = "The Fragments Within";

        QuestId.AddRange(new[] { 4813 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 17;
        RequiredQuest = 4812;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GRIND1418DarkshoreV1North : QuestGrinderClass
{
    public GRIND1418DarkshoreV1North()
    {
        Name = "GRIND: 14-18 - Darkshore V1 (North)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 17;
        RequiredQuest = 0;

        EntryTarget.Add(2164);
EntryTarget.Add(2322);
EntryTarget.Add(2069);
EntryTarget.Add(2235);
HotSpots.Add(new Vector3(6828.352 , -120.7508 , 34.25135 , "None"));
HotSpots.Add(new Vector3(6913.54 , -231.0265 , 35.7238 , "None"));
HotSpots.Add(new Vector3(7039.206 , -420.9353 , 42.87774 , "None"));
HotSpots.Add(new Vector3(7221.22 , -324.5325 , 30.14876 , "None"));
HotSpots.Add(new Vector3(7346.149 , -354.98 , 1.60907 , "None"));
HotSpots.Add(new Vector3(7187.711 , -538.6837 , 39.44965 , "None"));
HotSpots.Add(new Vector3(6981.8 , -602.5591 , 46.80236 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 18;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND1418DarkshoreV2north : QuestGrinderClass
{
    public GRIND1418DarkshoreV2north()
    {
        Name = "GRIND: 14-18 - Darkshore V2 (north)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 17;
        RequiredQuest = 0;

        EntryTarget.Add(2069);
EntryTarget.Add(2164);
EntryTarget.Add(2322);
HotSpots.Add(new Vector3(7423.463 , -687.539 , 18.20129 , "None"));
HotSpots.Add(new Vector3(7210.07 , -494.9305 , 35.32719 , "None"));
HotSpots.Add(new Vector3(7015.216 , -618.7751 , 52.46294 , "None"));
HotSpots.Add(new Vector3(6955.798 , -557.3401 , 44.9749 , "None"));
HotSpots.Add(new Vector3(7043.834 , -413.7768 , 41.66659 , "None"));
HotSpots.Add(new Vector3(7029.669 , -223.3514 , 37.01635 , "None"));
HotSpots.Add(new Vector3(6854.755 , -199.5277 , 44.9288 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 18;
}






}


public sealed class GRIND1820DarkshoreV1FarSouth : QuestGrinderClass
{
    public GRIND1820DarkshoreV1FarSouth()
    {
        Name = "GRIND: 18-20 - Darkshore V1 (Far South)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 19;
        RequiredQuest = 0;

        EntryTarget.Add(2323);
EntryTarget.Add(2237);
EntryTarget.Add(2165);
HotSpots.Add(new Vector3(4812.656 , 503.0224 , 31.87457 , "None"));
HotSpots.Add(new Vector3(4718.298 , 649.656 , 20.37243 , "None"));
HotSpots.Add(new Vector3(4670.353 , 482.9923 , 33.59878 , "None"));
HotSpots.Add(new Vector3(4783.534 , 374.3064 , 42.76361 , "None"));
HotSpots.Add(new Vector3(4830.316 , 274.3555 , 52.91641 , "None"));
HotSpots.Add(new Vector3(4813.912 , 147.119 , 49.17381 , "None"));
HotSpots.Add(new Vector3(4700.491 , 317.8453 , 51.5561 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class BeachedSeaCreature : QuestGrinderClass
{
    public BeachedSeaCreature()
    {
        Name = "Beached Sea Creature";

        QuestId.AddRange(new[] { 4728 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 19;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class FruitoftheSea : QuestGrinderClass
{
    public FruitoftheSea()
    {
        Name = "Fruit of the Sea";

        QuestId.AddRange(new[] { 1138 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 19;
        RequiredQuest = 0;

        EntryTarget.Add(2235);
EntryTarget.Add(2233);
HotSpots.Add(new Vector3(7432.926 , -42.92203 , 2.572581 , "None"));
HotSpots.Add(new Vector3(7452.543 , -115.5162 , -0.03790054 , "None"));
HotSpots.Add(new Vector3(7448.336 , -217.2957 , 0.2951112 , "None"));
HotSpots.Add(new Vector3(7358.966 , -372.9532 , 0.4672624 , "None"));
HotSpots.Add(new Vector3(7354.942 , -425.7787 , 1.683973 , "None"));
HotSpots.Add(new Vector3(7526.587 , -548.4094 , 1.434878 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheAbsentMindedProspector : QuestClass
{
    public TheAbsentMindedProspector()
    {
        Name = "The Absent Minded Prospector";

        QuestId.AddRange(new[] { 729 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 19;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PATHGetBeachedTurtleQ : QuestFollowPathClass
{
    public PATHGetBeachedTurtleQ()
    {
        Name = "PATH: Get Beached Turtle Q";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 19;
        RequiredQuest = 0;

        Path.Add(new Vector3(6449.761 , 206.0457 , 31.75579 , "None"));
Path.Add(new Vector3(6489.162 , 176.0538 , 31.26294 , "None"));
Path.Add(new Vector3(6523.484 , 173.9161 , 31.81442 , "None"));
Path.Add(new Vector3(6558.067 , 178.7825 , 32.45495 , "None"));
Path.Add(new Vector3(6593.061 , 187.4031 , 32.55182 , "None"));
Path.Add(new Vector3(6626.893 , 189.3645 , 30.7099 , "None"));
Path.Add(new Vector3(6662.142 , 181.9755 , 28.56198 , "None"));
Path.Add(new Vector3(6696.897 , 178.7142 , 23.55191 , "None"));
Path.Add(new Vector3(6721.261 , 158.1727 , 20.81867 , "None"));
Path.Add(new Vector3(6747.79 , 135.4789 , 21.03176 , "None"));
Path.Add(new Vector3(6774.802 , 111.6371 , 21.60316 , "None"));
Path.Add(new Vector3(6795.037 , 83.33159 , 19.58318 , "None"));
Path.Add(new Vector3(6809.519 , 49.2177 , 16.76618 , "None"));
Path.Add(new Vector3(6818.54 , 15.49112 , 15.44683 , "None"));
Path.Add(new Vector3(6819.582 , -19.34571 , 17.09072 , "None"));
Path.Add(new Vector3(6832.869 , -51.0326 , 20.13576 , "None"));
Path.Add(new Vector3(6861.016 , -71.71676 , 20.40162 , "None"));
Path.Add(new Vector3(6893.167 , -84.34826 , 19.84041 , "None"));
Path.Add(new Vector3(6928.839 , -88.35255 , 19.72251 , "None"));
Path.Add(new Vector3(6946.215 , -86.97995 , 18.39725 , "None"));
Path.Add(new Vector3(6965.501 , -83.48937 , 17.40842 , "None"));
Path.Add(new Vector3(6990.062 , -86.31623 , 16.4281 , "None"));
Path.Add(new Vector3(7026.034 , -86.14239 , 16.53301 , "None"));
Path.Add(new Vector3(7062.074 , -85.41576 , 15.87721 , "None"));
Path.Add(new Vector3(7095.269 , -83.02897 , 13.1512 , "None"));
Path.Add(new Vector3(7110.707 , -64.56091 , 13.71706 , "None"));
Path.Add(new Vector3(7107.341 , -32.03837 , 9.176576 , "None"));
Path.Add(new Vector3(7108.124 , 3.946337 , 13.55602 , "None"));
Path.Add(new Vector3(7109.896 , 39.94933 , 9.594269 , "None"));
Path.Add(new Vector3(7114.418 , 76.75244 , 15.24474 , "None"));
Path.Add(new Vector3(7123.177 , 108.0381 , 13.88213 , "None"));
Path.Add(new Vector3(7141.865 , 124.8229 , 12.75642 , "None"));
Path.Add(new Vector3(7170.548 , 144.4863 , 11.54084 , "None"));
Path.Add(new Vector3(7203.167 , 159.2613 , 10.45267 , "None"));
Path.Add(new Vector3(7238.246 , 167.5737 , 5.930799 , "None"));
Path.Add(new Vector3(7272.171 , 175.6511 , 4.351905 , "None"));
Path.Add(new Vector3(7300.563 , 176.3497 , 4.460998 , "None"));
Path.Add(new Vector3(7342.908 , 159.5723 , 9.639911 , "None"));
Path.Add(new Vector3(7369.863 , 135.8731 , 11.49187 , "None"));
Path.Add(new Vector3(7393.608 , 108.7641 , 6.617095 , "None"));
Path.Add(new Vector3(7415.338 , 105.062 , 1.232287 , "None"));
Path.Add(new Vector3(7422.124 , 88.33765 , 1.72952 , "None"));
Path.Add(new Vector3(7416.667 , 76.48523 , 2.757651 , "None"));
Path.Add(new Vector3(7410.63 , 71.96878 , 3.055063 , "None"));
Path.Add(new Vector3(7407.637 , 66.5579 , 2.822959 , "None"));
Path.Add(new Vector3(7406.685 , 53.22112 , 2.685642 , "None"));
Path.Add(new Vector3(7408.382 , 45.56141 , 2.680831 , "None"));
Path.Add(new Vector3(7412.319 , 40.04173 , 2.442197 , "None"));
Path.Add(new Vector3(7419.167 , 37.80742 , 2.381062 , "None"));
Path.Add(new Vector3(7429.438 , 33.14394 , 1.732547 , "None"));
Path.Add(new Vector3(7436.649 , 37.35988 , 1.520133 , "None"));
Path.Add(new Vector3(7440.182 , 43.52346 , 1.774948 , "None"));
Path.Add(new Vector3(7434.821 , 44.49807 , 2.217284 , "None"));
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


public sealed class BeachedSeaTurtle : QuestGrinderClass
{
    public BeachedSeaTurtle()
    {
        Name = "Beached Sea Turtle";

        QuestId.AddRange(new[] { 4725 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 19;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BeachedSeaTurtle2 : QuestGrinderClass
{
    public BeachedSeaTurtle2()
    {
        Name = "Beached Sea Turtle 2";

        QuestId.AddRange(new[] { 4727 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 19;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheTowerofAlthalaxxP2 : QuestGrinderClass
{
    public TheTowerofAlthalaxxP2()
    {
        Name = "The Tower of Althalaxx P2";

        QuestId.AddRange(new[] { 966 });

        Step = new List<int> { 4, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 19;
        RequiredQuest = 965;

        EntryTarget.Add(2336);
HotSpots.Add(new Vector3(7197.16 , -666.5508 , 40.65574 , "None"));
HotSpots.Add(new Vector3(7120.342 , -651.9053 , 45.8392 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(5348) >= 4;
}






}


public sealed class PATHBuzzbox523Q : QuestFollowPathClass
{
    public PATHBuzzbox523Q()
    {
        Name = "PATH: Buzzbox 523 Q";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 19;
        RequiredQuest = 0;

        Path.Add(new Vector3(6288.344 , 316.9197 , 22.76594 , "None"));
Path.Add(new Vector3(6263.227 , 317.7215 , 24.53104 , "None"));
Path.Add(new Vector3(6213.048 , 319.1371 , 27.92683 , "None"));
Path.Add(new Vector3(6178.579 , 310.0793 , 27.09216 , "None"));
Path.Add(new Vector3(6148.188 , 292.8608 , 23.95927 , "None"));
Path.Add(new Vector3(6145.325 , 291.239 , 23.90553 , "None"));
Path.Add(new Vector3(6085.223 , 273.8271 , 20.12582 , "None"));
Path.Add(new Vector3(6051.04 , 262.3966 , 21.11045 , "None"));
Path.Add(new Vector3(6018.382 , 250.0044 , 21.74647 , "None"));
Path.Add(new Vector3(5984.771 , 237.1548 , 20.15302 , "None"));
Path.Add(new Vector3(5950.911 , 231.4247 , 22.28968 , "None"));
Path.Add(new Vector3(5916.458 , 241.4758 , 23.85969 , "None"));
Path.Add(new Vector3(5855.451 , 265.2859 , 24.78004 , "None"));
Path.Add(new Vector3(5822.375 , 276.2965 , 24.97899 , "None"));
Path.Add(new Vector3(5787.86 , 286.703 , 22.04165 , "None"));
Path.Add(new Vector3(5755.383 , 299.4889 , 20.60232 , "None"));
Path.Add(new Vector3(5722.186 , 313.5447 , 20.20698 , "None"));
Path.Add(new Vector3(5688.069 , 318.9153 , 18.53148 , "None"));
Path.Add(new Vector3(5652.063 , 318.1334 , 18.99 , "None"));
Path.Add(new Vector3(5617.148 , 319.1116 , 21.86182 , "None"));
Path.Add(new Vector3(5581.177 , 318.9806 , 26.48804 , "None"));
Path.Add(new Vector3(5546.55 , 314.9911 , 27.55663 , "None"));
Path.Add(new Vector3(5513.763 , 300.7204 , 28.58568 , "None"));
Path.Add(new Vector3(5482.303 , 285.8797 , 29.27564 , "None"));
Path.Add(new Vector3(5448.602 , 273.4121 , 31.37366 , "None"));
Path.Add(new Vector3(5414.357 , 275.2034 , 31.41364 , "None"));
Path.Add(new Vector3(5380.382 , 281.7335 , 27.54929 , "None"));
Path.Add(new Vector3(5347.504 , 270.0562 , 27.46608 , "None"));
Path.Add(new Vector3(5312.616 , 261.0015 , 27.82123 , "None"));
Path.Add(new Vector3(5278.371 , 254.1978 , 28.75635 , "None"));
Path.Add(new Vector3(5242.452 , 252.0377 , 31.78761 , "None"));
Path.Add(new Vector3(5207.523 , 251.8365 , 33.9257 , "None"));
Path.Add(new Vector3(5171.521 , 250.0504 , 33.32951 , "None"));
Path.Add(new Vector3(5136.69 , 247.4271 , 29.20969 , "None"));
Path.Add(new Vector3(5100.832 , 243.8248 , 28.11069 , "None"));
Path.Add(new Vector3(5065.515 , 236.7958 , 27.93129 , "None"));
Path.Add(new Vector3(5031.742 , 228.0563 , 30.64575 , "None"));
Path.Add(new Vector3(4997.465 , 217.1034 , 36.91386 , "None"));
Path.Add(new Vector3(4962.794 , 215.0104 , 40.78302 , "None"));
Path.Add(new Vector3(4927.911 , 216.8176 , 43.60904 , "None"));
Path.Add(new Vector3(4891.91 , 218.6829 , 47.11623 , "None"));
Path.Add(new Vector3(4855.917 , 220.5476 , 50.45105 , "None"));
Path.Add(new Vector3(4800.413 , 224.4374 , 48.95907 , "None"));
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


public sealed class GRIND2023DarkshoreCrabsnorth : QuestGrinderClass
{
    public GRIND2023DarkshoreCrabsnorth()
    {
        Name = "GRIND: 20-23 Darkshore Crabs (north)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 22;
        RequiredQuest = 0;

        EntryTarget.Add(2236);
EntryTarget.Add(2233);
HotSpots.Add(new Vector3(7791.927 , -749.5527 , -0.8371854 , "Swimming"));
HotSpots.Add(new Vector3(7685.31 , -773.9679 , 10.14094 , "None"));
HotSpots.Add(new Vector3(7540.187 , -714.1708 , 4.5171 , "None"));
HotSpots.Add(new Vector3(7424.201 , -488.4678 , 0.8269741 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 23;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND2023DarkshoreCrabssouthashenvale : QuestGrinderClass
{
    public GRIND2023DarkshoreCrabssouthashenvale()
    {
        Name = "GRIND: 20-23 Darkshore Crabs (south (ashenvale))";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 22;
        RequiredQuest = 0;

        EntryTarget.Add(2236);
EntryTarget.Add(3814);
EntryTarget.Add(3721);
HotSpots.Add(new Vector3(4425.502 , 881.0614 , 0.1765373 , "None"));
HotSpots.Add(new Vector3(4388.884 , 1012.29 , 2.413846 , "None"));
HotSpots.Add(new Vector3(4225.967 , 1163.33 , 7.047832 , "None"));
HotSpots.Add(new Vector3(4144.116 , 1120.681 , 8.170551 , "None"));
HotSpots.Add(new Vector3(4056.255 , 1126.156 , 0.7715487 , "None"));
HotSpots.Add(new Vector3(4069.147 , 1003.666 , 1.668961 , "None"));
HotSpots.Add(new Vector3(3978.408 , 989.6076 , 0.4697483 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 23;
}



public override bool HasQuest() { return true; }


}


public sealed class RunToSHIPDarkshore : QuestFollowPathClass
{
    public RunToSHIPDarkshore()
    {
        Name = "Run To SHIP (Darkshore)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 59;
        RequiredQuest = 0;

        Path.Add(new Vector3(6497.648 , 788.9208 , 8.120871 , "None"));
Path.Add(new Vector3(6483.669 , 797.2177 , 6.074321 , "None"));
Path.Add(new Vector3(6456.106 , 807.618 , 6.344383 , "None"));
Path.Add(new Vector3(6439.657 , 813.165 , 6.385126 , "None"));
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


public sealed class CatchShipFromDarkshore : QuestClass
{
    public CatchShipFromDarkshore()
    {
        Name = "Catch Ship (From Darkshore)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 59;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return Usefuls.ContinentId == (int) ContinentId.Kalimdor;
	}

public override bool IsComplete() { 
return Usefuls.ContinentId == (int) ContinentId.Azeroth && !ObjectManager.Me.InTransport;
}



public override bool HasQuest() { return true; }

public override bool Pulse() {
// Sample of how to use Zeppelin/Ship
// In this sample, WRobot catch Zeppelin from Kalimdor (Ogrimmard) to Northrend (Borean Tundra (Warsong Hold))

/* Quest settings:
    * Can condition: "return Usefuls.ContinentId == (int) ContinentId.Kalimdor;"
    * Is complete condition: "return Usefuls.ContinentId == (int) ContinentId.Northrend && !ObjectManager.Me.InTransport;"
    * Not required in quest log: "True"
    * Quest type: "OverridePulseCSharpCode"
*/

// You can get zeppelin/ship/player positions and entry ID in tab "Tools" > "Development Tools" > "Dump all informations" (or "Memory information").

// Settings:
var zeppelinEntryId = 176310; // Zeppelin/Ship EntryId
// From
var fromZeppelinWaitPosition = new Vector3(6406.216, 823.0809, 0);// Position where Zeppelin/Ship waits players (from)
var fromPlayerWaitPosition = new Vector3(6420.22f, 818.0134f, 5.75068f, "None"); // Position where the player waits Zeppelin/Ship (from)
var fromPlayerInZeppelinPosition = new Vector3(6418.496f, 819.467f, 5.993618f, "None");// Position where the player waits in the Zeppelin/Ship (from)
// To
var toZeppelinWaitPosition = new Vector3(-3709.475, -575.0988, 0, "None"); // Position where Zeppelin/Ship waits players (to)
var toPlayerLeavePosition =  new Vector3(-3722.223f, -579.9567f, 6.189785f, "None"); // Position to go out the Zeppelin/Ship (to)
// var toPlayerLeaveBoat = new Vector3(-3698.511f, -568.4908f, 5.993618f, "None"); // put player at end of boat (to)


// Change WRobot settings:
wManager.wManagerSetting.CurrentSetting.CloseIfPlayerTeleported = false;

// Code:
if (!Conditions.InGameAndConnectedAndProductStartedNotInPause)
    return true;

if (Usefuls.ContinentId == (int)ContinentId.Kalimdor)
{
    if (!ObjectManager.Me.InTransport)
    {
        if (GoToTask.ToPosition(fromPlayerWaitPosition))
        {
            var zeppelin = ObjectManager.GetWoWGameObjectByEntry(zeppelinEntryId).OrderBy(o => o.GetDistance).FirstOrDefault();
            if (zeppelin != null && zeppelin.Position.DistanceTo(fromZeppelinWaitPosition) < 1)
            {
                wManager.Wow.Helpers.Move.Forward(Move.MoveAction.PressKey,2500);
            }
        }
    }
}
else if (Usefuls.ContinentId == (int)ContinentId.Azeroth)
{
    if (ObjectManager.Me.InTransport)
    {
        var zeppelin = ObjectManager.GetWoWGameObjectByEntry(zeppelinEntryId).OrderBy(o => o.GetDistance).FirstOrDefault();
        if (zeppelin != null && zeppelin.Position.DistanceTo(toZeppelinWaitPosition) < 1)
        {
            wManager.Wow.Helpers.Move.Backward(Move.MoveAction.PressKey,2650);
        }
    }
}
return true;
}
}


public sealed class RunFromShipDarkshoretoWetlandsP1 : QuestFollowPathClass
{
    public RunFromShipDarkshoretoWetlandsP1()
    {
        Name = "Run From Ship (Darkshore to Wetlands) P1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 59;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3863.766 , -638.2919 , -1.435408 , "Swimming"));
Path.Add(new Vector3(-3856.931 , -649.6102 , -1.435408 , "Swimming"));
Path.Add(new Vector3(-3848.948 , -662.8284 , -1.435408 , "Swimming"));
Path.Add(new Vector3(-3836.766 , -682.9993 , -1.435408 , "Swimming"));
Path.Add(new Vector3(-3824.951 , -702.5638 , -1.435408 , "Swimming"));
Path.Add(new Vector3(-3813.222 , -722.1243 , -1.435408 , "Swimming"));
Path.Add(new Vector3(-3817.008 , -735.5267 , -1.435408 , "Swimming"));
Path.Add(new Vector3(-3824.957 , -758.4717 , -1.355459 , "Swimming"));
Path.Add(new Vector3(-3832.026 , -769.3631 , 2.565465 , "None"));
Path.Add(new Vector3(-3836.249 , -780.5992 , 6.536473 , "None"));
Path.Add(new Vector3(-3820.12 , -787.8148 , 10.46432 , "None"));
Path.Add(new Vector3(-3808.851 , -783.6911 , 9.058112 , "None"));
Path.Add(new Vector3(-3792.402 , -780.8466 , 8.990443 , "None"));
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


public sealed class PATHWeaponMasterDarnasus : QuestFollowPathClass
{
    public PATHWeaponMasterDarnasus()
    {
        Name = "PATH: Weapon Master Darnasus";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 13;
        RequiredQuest = 0;

        Path.Add(new Vector3(9981.992 , 1955.216 , 1325.858 , "None"));
Path.Add(new Vector3(9984.146 , 1982.431 , 1327.186 , "None"));
Path.Add(new Vector3(9983.021 , 2018.417 , 1328.093 , "None"));
Path.Add(new Vector3(9973.039 , 2053.009 , 1328.456 , "None"));
Path.Add(new Vector3(9968.296 , 2087.594 , 1329.432 , "None"));
Path.Add(new Vector3(9962.343 , 2123.087 , 1328.449 , "None"));
Path.Add(new Vector3(9957.582 , 2177.4 , 1327.482 , "None"));
Path.Add(new Vector3(9956.6 , 2212.207 , 1329.453 , "None"));
Path.Add(new Vector3(9955.584 , 2248.206 , 1334.631 , "None"));
Path.Add(new Vector3(9952.176 , 2290.592 , 1341.395 , "None"));
Path.Add(new Vector3(9948.063 , 2333.023 , 1332.594 , "None"));
Path.Add(new Vector3(9943.17 , 2344.075 , 1330.765 , "None"));
Path.Add(new Vector3(9921.421 , 2344.662 , 1330.786 , "None"));
Path.Add(new Vector3(9914.996 , 2332.063 , 1330.789 , "None"));
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


public sealed class PATHDruidQuestDarnassus : QuestFollowPathClass
{
    public PATHDruidQuestDarnassus()
    {
        Name = "PATH: Druid Quest Darnassus";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 11;
        MaxLevel = 14;
        RequiredQuest = 0;

        Path.Add(new Vector3(10153.14 , 2553.266 , 1321.853 , "None"));
Path.Add(new Vector3(10157.63 , 2557.563 , 1324.541 , "None"));
Path.Add(new Vector3(10164.31 , 2563.362 , 1326.023 , "None"));
Path.Add(new Vector3(10173.05 , 2565.754 , 1325.965 , "None"));
Path.Add(new Vector3(10182.64 , 2570.618 , 1325.965 , "None"));
Path.Add(new Vector3(10187.25 , 2575.683 , 1326.103 , "None"));
Path.Add(new Vector3(10189.31 , 2578.648 , 1327.942 , "None"));
Path.Add(new Vector3(10187.44 , 2581.194 , 1329.127 , "None"));
Path.Add(new Vector3(10184.94 , 2581.476 , 1330.204 , "None"));
Path.Add(new Vector3(10183.15 , 2580.692 , 1331.221 , "None"));
Path.Add(new Vector3(10182.12 , 2578.651 , 1332.459 , "None"));
Path.Add(new Vector3(10184.15 , 2575.366 , 1334.415 , "None"));
Path.Add(new Vector3(10187.39 , 2575.701 , 1336.305 , "None"));
Path.Add(new Vector3(10187.96 , 2578.38 , 1337.488 , "None"));
Path.Add(new Vector3(10185.81 , 2581.26 , 1339.71 , "None"));
Path.Add(new Vector3(10183.4 , 2580.302 , 1340.342 , "None"));
Path.Add(new Vector3(10181.74 , 2577.551 , 1340.675 , "None"));
Path.Add(new Vector3(10183.31 , 2573.311 , 1340.673 , "None"));
Path.Add(new Vector3(10185.23 , 2570.655 , 1340.547 , "None"));
Path.Add(new Vector3(10186.87 , 2567.164 , 1340.442 , "None"));
Path.Add(new Vector3(10183.29 , 2564.549 , 1340.435 , "None"));
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


public sealed class DEPRECATEDAThreatWithin : QuestClass
{
    public DEPRECATEDAThreatWithin()
    {
        Name = "[DEPRECATED] A Threat Within";

        QuestId.AddRange(new[] { 783 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 4;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DEPRECATEDKoboldCampCleanup : QuestGrinderClass
{
    public DEPRECATEDKoboldCampCleanup()
    {
        Name = "[DEPRECATED] Kobold Camp Cleanup";

        QuestId.AddRange(new[] { 7 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 4;
        RequiredQuest = 0;

        EntryTarget.Add(6);
HotSpots.Add(new Vector3(-8780.05 , -108.379 , 83.48225 , "None"));
HotSpots.Add(new Vector3(-8753.58 , -192.765 , 85.61536 , "None"));
HotSpots.Add(new Vector3(-8798.803 , -250.7897 , 82.59034 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DEPRECATEDEaganPeltskinner : QuestClass
{
    public DEPRECATEDEaganPeltskinner()
    {
        Name = "[DEPRECATED] Eagan Peltskinner";

        QuestId.AddRange(new[] { 5261 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 4;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DEPRECATEDWolvesAcrosstheBorder : QuestGrinderClass
{
    public DEPRECATEDWolvesAcrosstheBorder()
    {
        Name = "[DEPRECATED] Wolves Across the Border";

        QuestId.AddRange(new[] { 33 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 4;
        RequiredQuest = 0;

        EntryTarget.Add(299);
HotSpots.Add(new Vector3(-8856.076 , -130.948 , 81.25712 , "None"));
HotSpots.Add(new Vector3(-8870.927 , -45.57772 , 88.73737 , "None"));
HotSpots.Add(new Vector3(-8752.893 , -28.84787 , 92.26635 , "None"));
HotSpots.Add(new Vector3(-8915.827 , -287.8713 , 77.20118 , "None"));
HotSpots.Add(new Vector3(-9017.813 , -196.2066 , 75.0859 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DEPRECATEDInvestigateEchoRidge : QuestGrinderClass
{
    public DEPRECATEDInvestigateEchoRidge()
    {
        Name = "[DEPRECATED] Investigate Echo Ridge";

        QuestId.AddRange(new[] { 15 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 3;
        MaxLevel = 5;
        RequiredQuest = 7;

        EntryTarget.Add(257);
HotSpots.Add(new Vector3(-8786.151 , -103.5144 , 83.53876 , "None"));
HotSpots.Add(new Vector3(-8682.052 , -71.93667 , 91.48838 , "None"));
HotSpots.Add(new Vector3(-8722.114 , -155.3123 , 85.21372 , "None"));
HotSpots.Add(new Vector3(-8763.662 , -235.5718 , 85.01897 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GlyphicLetter : QuestGrinderClass
{
    public GlyphicLetter()
    {
        Name = "Glyphic Letter";

        QuestId.AddRange(new[] { 3104 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.Mage;
        MinLevel = 3;
        MaxLevel = 5;
        RequiredQuest = 7;

        
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

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 5;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 3;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryTarget.Add(38);
HotSpots.Add(new Vector3(-8869.74 , -371.571 , 71.97399 , "None"));
HotSpots.Add(new Vector3(-8886.638 , -444.3364 , 65.10004 , "None"));
HotSpots.Add(new Vector3(-8921.247 , -446.8445 , 69.06374 , "None"));
HotSpots.Add(new Vector3(-8935.242 , -337.7271 , 70.56311 , "None"));
HotSpots.Add(new Vector3(-9002.39 , -306.7581 , 72.31674 , "None"));
HotSpots.Add(new Vector3(-9033.282 , -253.167 , 72.26591 , "None"));
HotSpots.Add(new Vector3(-9079.034 , -215.7169 , 70.99204 , "None"));
HotSpots.Add(new Vector3(-9110.202 , -215.1893 , 73.48441 , "None"));
HotSpots.Add(new Vector3(-9120.867 , -245.8174 , 74.33694 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DEPRECATEDSkirmishatEchoRidge : QuestGrinderClass
{
    public DEPRECATEDSkirmishatEchoRidge()
    {
        Name = "[DEPRECATED] Skirmish at Echo Ridge";

        QuestId.AddRange(new[] { 21 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 15;

        EntryTarget.Add(80);
HotSpots.Add(new Vector3(-8654.91 , -127.006 , 89.5479 , "None"));
HotSpots.Add(new Vector3(-8550.953 , -156.6262 , 87.49316 , "None"));
HotSpots.Add(new Vector3(-8554.303 , -202.6297 , 85.7654 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReporttoGoldshire : QuestGrinderClass
{
    public ReporttoGoldshire()
    {
        Name = "Report to Goldshire";

        QuestId.AddRange(new[] { 54 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 21;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GRINDToLevel6 : QuestGrinderClass
{
    public GRINDToLevel6()
    {
        Name = "GRIND To Level 6";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 5;
        RequiredQuest = 0;

        EntryTarget.Add(257);
EntryTarget.Add(80);
HotSpots.Add(new Vector3(-8697.341 , -67.0701 , 90.6379 , "None"));
HotSpots.Add(new Vector3(-8625.504 , -147.634 , 86.47317 , "None"));
HotSpots.Add(new Vector3(-8600.345 , -170.8879 , 86.848 , "None"));
HotSpots.Add(new Vector3(-8720.057 , -147.6119 , 86.14907 , "None"));
HotSpots.Add(new Vector3(-8731.145 , -206.7194 , 89.20464 , "None"));
HotSpots.Add(new Vector3(-8777.144 , -253.2705 , 82.15295 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


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
        MinLevel = 4;
        MaxLevel = 5;
        RequiredQuest = 0;


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

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 5;
        MaxLevel = 7;
        RequiredQuest = 0;

        EntryTarget.Add(475);
HotSpots.Add(new Vector3(-9783.304 , 86.06296 , 42.75506 , "None"));
HotSpots.Add(new Vector3(-9886.831 , 152.7722 , 31.97806 , "None"));
HotSpots.Add(new Vector3(-9949.228 , 223.5642 , 24.5376 , "None"));
HotSpots.Add(new Vector3(-9868.52 , 269.5554 , 36.313 , "None"));
HotSpots.Add(new Vector3(-9763.752 , 230.7117 , 46.52645 , "None"));
HotSpots.Add(new Vector3(-9913.989 , 222.4518 , 17.89726 , "None"));

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

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 5;
        MaxLevel = 7;
        RequiredQuest = 0;

        EntryTarget.Add(475);
HotSpots.Add(new Vector3(-9784.262 , 86.95246 , 42.84388 , "None"));
HotSpots.Add(new Vector3(-9886.831 , 152.7722 , 31.97806 , "None"));
HotSpots.Add(new Vector3(-9949.228 , 223.5642 , 24.5376 , "None"));
HotSpots.Add(new Vector3(-9868.52 , 269.5554 , 36.313 , "None"));
HotSpots.Add(new Vector3(-9763.752 , 230.7117 , 46.52645 , "None"));
HotSpots.Add(new Vector3(-9913.989 , 222.4518 , 17.89726 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GRIND68V1 : QuestGrinderClass
{
    public GRIND68V1()
    {
        Name = "GRIND 6-8 V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 7;
        RequiredQuest = 0;

        EntryTarget.Add(30);
EntryTarget.Add(525);
EntryTarget.Add(94);
EntryTarget.Add(113);
HotSpots.Add(new Vector3(-9383.878 , 199.5822 , 61.37768 , "None"));
HotSpots.Add(new Vector3(-9217.152 , 420.3572 , 88.34444 , "None"));
HotSpots.Add(new Vector3(-9443.216 , 230.8144 , 59.91852 , "None"));
HotSpots.Add(new Vector3(-9579.193 , 223.4055 , 50.25326 , "None"));
HotSpots.Add(new Vector3(-9910.394 , 396.556 , 35.26595 , "None"));
HotSpots.Add(new Vector3(-9654.122 , 583.5081 , 43.37423 , "None"));
HotSpots.Add(new Vector3(-9596.835 , 57.26015 , 60.6193 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 8;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND68V2 : QuestGrinderClass
{
    public GRIND68V2()
    {
        Name = "GRIND 6-8 V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 6;
        MaxLevel = 7;
        RequiredQuest = 0;

        EntryTarget.Add(113);
EntryTarget.Add(30);
EntryTarget.Add(525);
HotSpots.Add(new Vector3(-9906.971 , 114.2935 , 32.33813 , "None"));
HotSpots.Add(new Vector3(-10055.45 , 140.6311 , 27.16061 , "None"));
HotSpots.Add(new Vector3(-9931.727 , 379.0829 , 35.17334 , "None"));
HotSpots.Add(new Vector3(-9701.633 , 400.7068 , 41.172 , "None"));
HotSpots.Add(new Vector3(-9253.466 , 422.2762 , 85.38291 , "None"));
HotSpots.Add(new Vector3(-9391.539 , 193.6392 , 60.77333 , "None"));
HotSpots.Add(new Vector3(-9347.663 , 47.0806 , 61.06447 , "None"));
HotSpots.Add(new Vector3(-9272.422 , -4.719313 , 71.79562 , "None"));
HotSpots.Add(new Vector3(-9393.267 , 49.80746 , 59.81141 , "None"));
HotSpots.Add(new Vector3(-9556.532 , 84.70698 , 58.88227 , "None"));
HotSpots.Add(new Vector3(-9724.37 , 134.3726 , 48.07129 , "None"));
HotSpots.Add(new Vector3(-9757.906 , 192.2721 , 50.90237 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 8;
}



public override bool HasQuest() { return true; }


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
        MinLevel = 8;
        MaxLevel = 9;
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
        MinLevel = 8;
        MaxLevel = 9;
        RequiredQuest = 40;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GRIND810V1 : QuestGrinderClass
{
    public GRIND810V1()
    {
        Name = "GRIND 8-10 V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 8;
        MaxLevel = 9;
        RequiredQuest = 0;

        EntryTarget.Add(524);
EntryTarget.Add(822);
EntryTarget.Add(116);
EntryTarget.Add(1922);
EntryTarget.Add(118);
HotSpots.Add(new Vector3(-9774.743 , 4.831068 , 31.55041 , "None"));
HotSpots.Add(new Vector3(-9759.97 , -137.1484 , 32.68861 , "None"));
HotSpots.Add(new Vector3(-9686.843 , -295.4912 , 57.58538 , "None"));
HotSpots.Add(new Vector3(-9689.443 , -441.1578 , 51.58475 , "None"));
HotSpots.Add(new Vector3(-9623.744 , -502.0356 , 57.95051 , "None"));
HotSpots.Add(new Vector3(-9590.8 , -562.219 , 57.43264 , "None"));
HotSpots.Add(new Vector3(-9292.307 , -829.0873 , 69.47823 , "None"));
HotSpots.Add(new Vector3(-9386.221 , -1006.876 , 64.45267 , "None"));
HotSpots.Add(new Vector3(-9529.382 , -1058.141 , 48.48678 , "None"));
HotSpots.Add(new Vector3(-9722.089 , -1142.827 , 39.91159 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 10;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND810V2 : QuestGrinderClass
{
    public GRIND810V2()
    {
        Name = "GRIND 8-10 V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 8;
        MaxLevel = 9;
        RequiredQuest = 0;

        EntryTarget.Add(524);
EntryTarget.Add(822);
EntryTarget.Add(1922);
EntryTarget.Add(118);
HotSpots.Add(new Vector3(-9793.748 , -1050.133 , 37.06183 , "None"));
HotSpots.Add(new Vector3(-9706.322 , -979.6792 , 41.87506 , "None"));
HotSpots.Add(new Vector3(-9420.722 , -1027.325 , 60.6394 , "None"));
HotSpots.Add(new Vector3(-9420.353 , -802.8393 , 65.39204 , "None"));
HotSpots.Add(new Vector3(-9692.671 , -688.154 , 47.0021 , "None"));
HotSpots.Add(new Vector3(-9740.509 , -558.5665 , 39.39697 , "None"));
HotSpots.Add(new Vector3(-9817.367 , -612.9163 , 30.1977 , "None"));
HotSpots.Add(new Vector3(-9901.625 , -353.0069 , 33.18415 , "None"));
HotSpots.Add(new Vector3(-9704.736 , -367.6411 , 54.52901 , "None"));
HotSpots.Add(new Vector3(-9676.974 , -183.6215 , 47.29385 , "None"));
HotSpots.Add(new Vector3(-9744.966 , -374.8324 , 54.17799 , "None"));
HotSpots.Add(new Vector3(-9371.464 , -883.4949 , 65.39654 , "None"));
HotSpots.Add(new Vector3(-9568.04 , -1488.697 , 62.17626 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 10;
}



public override bool HasQuest() { return true; }


}


public sealed class ProtecttheFrontier : QuestGrinderClass
{
    public ProtecttheFrontier()
    {
        Name = "Protect the Frontier";

        QuestId.AddRange(new[] { 52 });

        Step = new List<int> { 8, 5, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 8;
        MaxLevel = 11;
        RequiredQuest = 0;

        EntryTarget.Add(118);
EntryTarget.Add(822);
HotSpots.Add(new Vector3(-9655.568 , -1156.988 , 41.57038 , "None"));
HotSpots.Add(new Vector3(-9723.287 , -1296.344 , 50.04577 , "None"));
HotSpots.Add(new Vector3(-9538.216 , -1533.793 , 60.88775 , "None"));
HotSpots.Add(new Vector3(-9369.504 , -1436.549 , 64.14223 , "None"));
HotSpots.Add(new Vector3(-9295.171 , -1295.011 , 69.6858 , "None"));

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

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 8;
        MaxLevel = 11;
        RequiredQuest = 0;

        EntryTarget.Add(46);
EntryTarget.Add(732);
HotSpots.Add(new Vector3(-9238.054 , -1269.679 , 75.43517 , "None"));
HotSpots.Add(new Vector3(-9315.905 , -1176.005 , 68.09615 , "None"));
HotSpots.Add(new Vector3(-9307.583 , -1125.99 , 69.92548 , "None"));
HotSpots.Add(new Vector3(-9077.312 , -1257.608 , 73.36956 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class FineLinenGoods : QuestGrinderClass
{
    public FineLinenGoods()
    {
        Name = "Fine Linen Goods";

        QuestId.AddRange(new[] { 83 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 8;
        MaxLevel = 11;
        RequiredQuest = 0;

        EntryTarget.Add(474);
HotSpots.Add(new Vector3(-9227.32 , -1031.4 , 69.57605 , "None"));
HotSpots.Add(new Vector3(-9169.731 , -1009.436 , 70.06977 , "None"));
HotSpots.Add(new Vector3(-9081.633 , -997.7944 , 71.83599 , "None"));
HotSpots.Add(new Vector3(-9036.921 , -1106.524 , 70.59567 , "None"));
HotSpots.Add(new Vector3(-9167.478 , -1133.144 , 69.8327 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ABundleofTrouble : QuestGathererClass
{
    public ABundleofTrouble()
    {
        Name = "A Bundle of Trouble";

        QuestId.AddRange(new[] { 5545 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 8;
        MaxLevel = 11;
        RequiredQuest = 0;

        EntryIdObjects.Add(176793);
HotSpots.Add(new Vector3(-9309.2 , -1303.552 , 68.15755 , "None"));
HotSpots.Add(new Vector3(-9329.287 , -1245.847 , 66.44571 , "None"));
HotSpots.Add(new Vector3(-9361.636 , -1250.07 , 63.12425 , "None"));
HotSpots.Add(new Vector3(-9405.569 , -1216.703 , 56.7762 , "None"));
HotSpots.Add(new Vector3(-9425.384 , -1126.747 , 58.72069 , "None"));
HotSpots.Add(new Vector3(-9383.276 , -1101.14 , 62.83673 , "None"));
HotSpots.Add(new Vector3(-9340.706 , -1142.768 , 68.13524 , "None"));
HotSpots.Add(new Vector3(-9387.853 , -1294.557 , 55.44461 , "None"));
HotSpots.Add(new Vector3(-9309.114 , -1361.93 , 70.2304 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GRIND10to12V1 : QuestGrinderClass
{
    public GRIND10to12V1()
    {
        Name = "GRIND : 10 to 12 V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 11;
        RequiredQuest = 0;

        EntryTarget.Add(118);
EntryTarget.Add(822);
EntryTarget.Add(1922);
HotSpots.Add(new Vector3(-9583.407 , -1532.765 , 59.21423 , "None"));
HotSpots.Add(new Vector3(-9384.747 , -1503.352 , 68.81696 , "None"));
HotSpots.Add(new Vector3(-9372.29 , -1215.881 , 63.90198 , "None"));
HotSpots.Add(new Vector3(-9429.338 , -1049.848 , 60.4436 , "None"));
HotSpots.Add(new Vector3(-9354.61 , -1376.491 , 61.13121 , "None"));
HotSpots.Add(new Vector3(-9727.149 , -1342.79 , 51.98854 , "None"));
HotSpots.Add(new Vector3(-9925.639 , -1338.706 , 30.55524 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 12;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND10to12V2 : QuestGrinderClass
{
    public GRIND10to12V2()
    {
        Name = "GRIND : 10 to 12 V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 11;
        RequiredQuest = 0;

        EntryTarget.Add(118);
EntryTarget.Add(822);
EntryTarget.Add(732);
EntryTarget.Add(474);
HotSpots.Add(new Vector3(-9689.864 , -1083.791 , 43.27961 , "None"));
HotSpots.Add(new Vector3(-9773.686 , -1220.155 , 42.03665 , "None"));
HotSpots.Add(new Vector3(-9886.018 , -1236.071 , 29.56223 , "None"));
HotSpots.Add(new Vector3(-9946.657 , -1331.822 , 27.968 , "None"));
HotSpots.Add(new Vector3(-9897.169 , -1414.713 , 31.21698 , "None"));
HotSpots.Add(new Vector3(-9711.809 , -1458.35 , 52.59753 , "None"));
HotSpots.Add(new Vector3(-9589.548 , -1505.266 , 61.71253 , "None"));
HotSpots.Add(new Vector3(-9485.707 , -1503.809 , 62.46264 , "None"));
HotSpots.Add(new Vector3(-9245.632 , -974.8995 , 68.89542 , "None"));
HotSpots.Add(new Vector3(-9032.007 , -1011.179 , 71.23479 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 12;
}



public override bool HasQuest() { return true; }


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
        MinLevel = 10;
        MaxLevel = 12;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PATHGoldshiretoWestfall : QuestFollowPathClass
{
    public PATHGoldshiretoWestfall()
    {
        Name = "PATH : Goldshire to Westfall";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 11;
        RequiredQuest = 0;

        Path.Add(new Vector3(-9486.99 , 67.21294 , 56.13491 , "None"));
Path.Add(new Vector3(-9483.271 , 115.1584 , 56.48688 , "None"));
Path.Add(new Vector3(-9482.688 , 135.867 , 56.66403 , "None"));
Path.Add(new Vector3(-9482.97 , 167.489 , 55.92112 , "None"));
Path.Add(new Vector3(-9492.22 , 190.8444 , 54.74015 , "None"));
Path.Add(new Vector3(-9502.543 , 211.1616 , 53.43055 , "None"));
Path.Add(new Vector3(-9528.135 , 234.9351 , 51.41689 , "None"));
Path.Add(new Vector3(-9547.136 , 247.5563 , 50.2512 , "None"));
Path.Add(new Vector3(-9574.42 , 248.4993 , 48.86584 , "None"));
Path.Add(new Vector3(-9609.302 , 250.1503 , 47.30734 , "None"));
Path.Add(new Vector3(-9643.217 , 258.0894 , 46.62281 , "None"));
Path.Add(new Vector3(-9675.932 , 273.0218 , 46.52711 , "None"));
Path.Add(new Vector3(-9699.882 , 298.183 , 45.94682 , "None"));
Path.Add(new Vector3(-9717.916 , 322.89 , 44.49125 , "None"));
Path.Add(new Vector3(-9731.287 , 346.6764 , 42.93603 , "None"));
Path.Add(new Vector3(-9741.135 , 369.6849 , 41.50161 , "None"));
Path.Add(new Vector3(-9745.112 , 382.2288 , 40.60421 , "None"));
Path.Add(new Vector3(-9755.789 , 421.1548 , 37.61469 , "None"));
Path.Add(new Vector3(-9756.267 , 433.5028 , 36.73373 , "None"));
Path.Add(new Vector3(-9754.813 , 447.5183 , 35.57779 , "None"));
Path.Add(new Vector3(-9752.616 , 468.3609 , 33.91025 , "None"));
Path.Add(new Vector3(-9750.385 , 489.5376 , 33.22714 , "None"));
Path.Add(new Vector3(-9746.917 , 510.6836 , 35.17188 , "None"));
Path.Add(new Vector3(-9744.505 , 532.1729 , 35.58467 , "None"));
Path.Add(new Vector3(-9742.43 , 553.3655 , 35.34346 , "None"));
Path.Add(new Vector3(-9740.388 , 574.2239 , 33.66938 , "None"));
Path.Add(new Vector3(-9740.713 , 596.061 , 31.15377 , "None"));
Path.Add(new Vector3(-9743.303 , 616.8583 , 30.31317 , "None"));
Path.Add(new Vector3(-9747.104 , 637.7659 , 29.19132 , "None"));
Path.Add(new Vector3(-9750.454 , 649.4323 , 28.64691 , "None"));
Path.Add(new Vector3(-9754.616 , 663.9244 , 27.87958 , "None"));
Path.Add(new Vector3(-9761.58 , 685.7118 , 26.37936 , "None"));
Path.Add(new Vector3(-9758.789 , 702.4951 , 25.53033 , "None"));
Path.Add(new Vector3(-9756.075 , 722.9589 , 25.25681 , "None"));
Path.Add(new Vector3(-9753.378 , 744.0782 , 24.8669 , "None"));
Path.Add(new Vector3(-9757.257 , 764.9372 , 25.03541 , "None"));
Path.Add(new Vector3(-9764.412 , 784.9103 , 25.04974 , "None"));
Path.Add(new Vector3(-9776.35 , 802.0929 , 25.0657 , "None"));
Path.Add(new Vector3(-9790.198 , 818.7057 , 26.74944 , "None"));
Path.Add(new Vector3(-9803.703 , 835.1641 , 29.15347 , "None"));
Path.Add(new Vector3(-9816.317 , 852.319 , 27.23475 , "None"));
Path.Add(new Vector3(-9829.081 , 868.9306 , 25.83167 , "None"));
Path.Add(new Vector3(-9839.875 , 887.662 , 27.66907 , "None"));
Path.Add(new Vector3(-9850.312 , 905.4461 , 29.71034 , "None"));
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


public sealed class GRIND12to14V1 : QuestGrinderClass
{
    public GRIND12to14V1()
    {
        Name = "GRIND : 12 to 14 V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 13;
        RequiredQuest = 0;

        EntryTarget.Add(834);
EntryTarget.Add(454);
EntryTarget.Add(199);
EntryTarget.Add(833);
EntryTarget.Add(504);
EntryTarget.Add(1109);
EntryTarget.Add(500);
EntryTarget.Add(123);
EntryTarget.Add(36);
HotSpots.Add(new Vector3(-9653.301 , 946.8278 , 39.73911 , "None"));
HotSpots.Add(new Vector3(-9751.706 , 923.4467 , 27.45472 , "None"));
HotSpots.Add(new Vector3(-9925.538 , 850.3112 , 33.64567 , "None"));
HotSpots.Add(new Vector3(-10043.79 , 835.1212 , 33.93302 , "None"));
HotSpots.Add(new Vector3(-10076.44 , 945.7664 , 36.6316 , "None"));
HotSpots.Add(new Vector3(-10196.15 , 847.7713 , 35.93604 , "None"));
HotSpots.Add(new Vector3(-10310.1 , 818.953 , 49.39904 , "None"));
HotSpots.Add(new Vector3(-10394.51 , 859.6968 , 39.56123 , "None"));
HotSpots.Add(new Vector3(-10483.39 , 897.6691 , 38.47064 , "None"));
HotSpots.Add(new Vector3(-10416.08 , 1064.179 , 49.24555 , "None"));
HotSpots.Add(new Vector3(-10328.23 , 1163.694 , 38.73572 , "None"));
HotSpots.Add(new Vector3(-10089.75 , 1257.3 , 38.82921 , "None"));
HotSpots.Add(new Vector3(-10038.89 , 1397.1 , 42.65111 , "None"));
HotSpots.Add(new Vector3(-10073.38 , 1533.017 , 43.75159 , "None"));
HotSpots.Add(new Vector3(-10057.71 , 1635.893 , 41.43319 , "None"));
HotSpots.Add(new Vector3(-10005.59 , 1732.726 , 33.79819 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 14;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND12to14V2 : QuestGrinderClass
{
    public GRIND12to14V2()
    {
        Name = "GRIND : 12 to 14 V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 13;
        RequiredQuest = 0;

        EntryTarget.Add(126);
EntryTarget.Add(515);
EntryTarget.Add(454);
EntryTarget.Add(834);
EntryTarget.Add(199);
EntryTarget.Add(833);
EntryTarget.Add(1109);
HotSpots.Add(new Vector3(-9666.45 , 1143.488 , 6.013816 , "None"));
HotSpots.Add(new Vector3(-9846.408 , 1086.356 , 31.94615 , "None"));
HotSpots.Add(new Vector3(-9939.65 , 1055.976 , 37.88351 , "None"));
HotSpots.Add(new Vector3(-10049.22 , 947.3484 , 36.32646 , "None"));
HotSpots.Add(new Vector3(-9934.869 , 845.3479 , 32.50898 , "None"));
HotSpots.Add(new Vector3(-10040.31 , 838.7068 , 33.7627 , "None"));
HotSpots.Add(new Vector3(-10191.15 , 908.5529 , 40.76637 , "None"));
HotSpots.Add(new Vector3(-10260.91 , 870.633 , 37.7884 , "None"));
HotSpots.Add(new Vector3(-10271.62 , 954.4698 , 34.8367 , "None"));
HotSpots.Add(new Vector3(-10390.16 , 913.2825 , 43.49926 , "None"));
HotSpots.Add(new Vector3(-10461 , 901.1353 , 39.03125 , "None"));
HotSpots.Add(new Vector3(-10404.87 , 1065.034 , 44.78775 , "None"));
HotSpots.Add(new Vector3(-10476.09 , 1170.699 , 49.94983 , "None"));
HotSpots.Add(new Vector3(-10241.9 , 1213.922 , 42.27497 , "None"));
HotSpots.Add(new Vector3(-10296.96 , 1302.548 , 47.69078 , "None"));
HotSpots.Add(new Vector3(-10405.05 , 1442.291 , 43.17989 , "None"));
HotSpots.Add(new Vector3(-10518.28 , 1503.729 , 61.59003 , "None"));
HotSpots.Add(new Vector3(-10392.71 , 1641.287 , 36.27986 , "None"));
HotSpots.Add(new Vector3(-10378.41 , 1775.181 , 35.36389 , "None"));
HotSpots.Add(new Vector3(-10288.14 , 1969.431 , 35.85371 , "None"));
HotSpots.Add(new Vector3(-10322.83 , 1781.945 , 36.12035 , "None"));
HotSpots.Add(new Vector3(-10148.37 , 1794.083 , 35.52441 , "None"));
HotSpots.Add(new Vector3(-10233.13 , 1558.592 , 43.64209 , "None"));
HotSpots.Add(new Vector3(-10106.15 , 1472.05 , 42.2917 , "None"));
HotSpots.Add(new Vector3(-9954.221 , 1621.646 , 40.60892 , "None"));
HotSpots.Add(new Vector3(-10011.4 , 1753.544 , 35.47696 , "None"));
HotSpots.Add(new Vector3(-10220.87 , 1772.995 , 38.74661 , "None"));
HotSpots.Add(new Vector3(-10096.39 , 1407.326 , 42.69985 , "None"));
HotSpots.Add(new Vector3(-10098.66 , 1259.495 , 38.57121 , "None"));
HotSpots.Add(new Vector3(-10014.07 , 1229.04 , 42.65679 , "None"));
HotSpots.Add(new Vector3(-9851.9 , 1172.301 , 39.00946 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 14;
}



public override bool HasQuest() { return true; }


}


public sealed class TheDefiasBrotherhood : QuestClass
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
        MinLevel = 1;
        MaxLevel = 15;
        RequiredQuest = 0;


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

        Step = new List<int> { 20, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 15;
        RequiredQuest = 0;

        EntryTarget.Add(114);
HotSpots.Add(new Vector3(-10123 , 1124.847 , 36.80747 , "None"));
HotSpots.Add(new Vector3(-10233.02 , 1116.586 , 36.28438 , "None"));
HotSpots.Add(new Vector3(-10166.54 , 1050.937 , 36.29941 , "None"));
HotSpots.Add(new Vector3(-10223.03 , 1404.117 , 40.74776 , "None"));
HotSpots.Add(new Vector3(-10229.96 , 1506.331 , 40.59315 , "None"));
HotSpots.Add(new Vector3(-9928.986 , 1268.158 , 41.98697 , "None"));
HotSpots.Add(new Vector3(-9917.484 , 1183.58 , 42.1567 , "None"));

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
        Name = "The People's Militia";

        QuestId.AddRange(new[] { 12 });

        Step = new List<int> { 15, 15, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 15;
        RequiredQuest = 0;

        EntryTarget.Add(504);
EntryTarget.Add(95);
HotSpots.Add(new Vector3(-10514.96 , 1316.437 , 46.66956 , "None"));
HotSpots.Add(new Vector3(-10491.04 , 1217.732 , 67.2305 , "None"));
HotSpots.Add(new Vector3(-10316.28 , 1195.929 , 38.04779 , "None"));
HotSpots.Add(new Vector3(-10261.61 , 1370.497 , 41.71641 , "None"));
HotSpots.Add(new Vector3(-10451.64 , 1367.229 , 59.17966 , "None"));
HotSpots.Add(new Vector3(-10033.74 , 1451.285 , 43.38997 , "None"));

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

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 15;
        RequiredQuest = 0;

        EntryTarget.Add(504);
EntryTarget.Add(95);
HotSpots.Add(new Vector3(-10514.96 , 1316.437 , 46.66956 , "None"));
HotSpots.Add(new Vector3(-10491.04 , 1217.732 , 67.2305 , "None"));
HotSpots.Add(new Vector3(-10316.28 , 1195.929 , 38.04779 , "None"));
HotSpots.Add(new Vector3(-10261.61 , 1370.497 , 41.71641 , "None"));
HotSpots.Add(new Vector3(-10451.64 , 1367.229 , 59.17966 , "None"));
HotSpots.Add(new Vector3(-10033.74 , 1451.285 , 43.38997 , "None"));

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

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 15;
        RequiredQuest = 0;

        EntryTarget.Add(500);
EntryTarget.Add(123);
HotSpots.Add(new Vector3(-10144.58 , 1624.624 , 39.93893 , "None"));
HotSpots.Add(new Vector3(-9779.446 , 1472.957 , 44.37862 , "None"));
HotSpots.Add(new Vector3(-9920.034 , 1633.045 , 36.13575 , "None"));
HotSpots.Add(new Vector3(-10089.92 , 1846.034 , 36.15413 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GRIND14to18V1 : QuestGrinderClass
{
    public GRIND14to18V1()
    {
        Name = "GRIND : 14 to 18 V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 17;
        RequiredQuest = 0;

        EntryTarget.Add(157);
EntryTarget.Add(1109);
EntryTarget.Add(547);
EntryTarget.Add(154);
EntryTarget.Add(832);
HotSpots.Add(new Vector3(-10449.03 , 871.8428 , 39.77003 , "None"));
HotSpots.Add(new Vector3(-10554.39 , 935.2991 , 42.90061 , "None"));
HotSpots.Add(new Vector3(-10613.52 , 765.6519 , 46.98649 , "None"));
HotSpots.Add(new Vector3(-10624.96 , 927.0762 , 40.70779 , "None"));
HotSpots.Add(new Vector3(-10695.35 , 759.3477 , 44.10469 , "None"));
HotSpots.Add(new Vector3(-10743.01 , 970.0726 , 46.67477 , "None"));
HotSpots.Add(new Vector3(-10891.66 , 971.0453 , 37.23095 , "None"));
HotSpots.Add(new Vector3(-10974.75 , 985.2643 , 36.01127 , "None"));
HotSpots.Add(new Vector3(-10999 , 1190.262 , 42.69398 , "None"));
HotSpots.Add(new Vector3(-10858.77 , 1464.657 , 42.91013 , "None"));
HotSpots.Add(new Vector3(-10906.64 , 1627.813 , 41.8196 , "None"));
HotSpots.Add(new Vector3(-11057.47 , 1790.69 , 40.12119 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 18;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND14to18V2 : QuestGrinderClass
{
    public GRIND14to18V2()
    {
        Name = "GRIND : 14 to 18 V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 17;
        RequiredQuest = 0;

        EntryTarget.Add(1109);
EntryTarget.Add(157);
EntryTarget.Add(832);
EntryTarget.Add(114);
EntryTarget.Add(154);
EntryTarget.Add(547);
HotSpots.Add(new Vector3(-11289.46 , 1783.032 , 38.45491 , "None"));
HotSpots.Add(new Vector3(-10976.13 , 1755.534 , 48.90011 , "None"));
HotSpots.Add(new Vector3(-10926.14 , 1627.914 , 43.02543 , "None"));
HotSpots.Add(new Vector3(-10758.39 , 1757.34 , 38.73985 , "None"));
HotSpots.Add(new Vector3(-10619.36 , 1709.364 , 41.0609 , "None"));
HotSpots.Add(new Vector3(-10562.14 , 1836.699 , 40.63207 , "None"));
HotSpots.Add(new Vector3(-10554.69 , 1514.7 , 60.29864 , "None"));
HotSpots.Add(new Vector3(-10726.28 , 1434.233 , 39.13427 , "None"));
HotSpots.Add(new Vector3(-10762.77 , 1239.66 , 40.84752 , "None"));
HotSpots.Add(new Vector3(-10799.47 , 1064.404 , 37.86192 , "None"));
HotSpots.Add(new Vector3(-10724.53 , 956.8298 , 46.78152 , "None"));
HotSpots.Add(new Vector3(-10681.35 , 773.7297 , 48.25943 , "None"));
HotSpots.Add(new Vector3(-10536.39 , 838.2052 , 47.21738 , "None"));
HotSpots.Add(new Vector3(-10395.13 , 930.7985 , 41.26416 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 18;
}



public override bool HasQuest() { return true; }


}


public sealed class ThePeoplesMilitiaPart2 : QuestGrinderClass
{
    public ThePeoplesMilitiaPart2()
    {
        Name = "The People's Militia Part 2";

        QuestId.AddRange(new[] { 13 });

        Step = new List<int> { 15, 15, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 17;
        RequiredQuest = 0;

        EntryTarget.Add(590);
EntryTarget.Add(589);
HotSpots.Add(new Vector3(-10931.05 , 1456.984 , 48.74998 , "None"));
HotSpots.Add(new Vector3(-10965.25 , 1518.199 , 43.23034 , "None"));
HotSpots.Add(new Vector3(-11071.92 , 1405.176 , 48.79167 , "None"));
HotSpots.Add(new Vector3(-10686.31 , 1769.858 , 39.39756 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThePeoplesMilitiaPart3 : QuestGrinderClass
{
    public ThePeoplesMilitiaPart3()
    {
        Name = "The People's Militia Part 3";

        QuestId.AddRange(new[] { 14 });

        Step = new List<int> { 15, 5, 5, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 17;
        RequiredQuest = 13;

        EntryTarget.Add(449);
EntryTarget.Add(121);
EntryTarget.Add(122);
HotSpots.Add(new Vector3(-11110.09 , 1665.302 , 49.20585 , "None"));
HotSpots.Add(new Vector3(-11095.34 , 1791.412 , 36.91011 , "None"));
HotSpots.Add(new Vector3(-11263.99 , 1758.533 , 35.9284 , "None"));
HotSpots.Add(new Vector3(-11271.8 , 1567.148 , 70.77296 , "None"));
HotSpots.Add(new Vector3(-11263.2 , 1384.833 , 89.86964 , "None"));
HotSpots.Add(new Vector3(-11214.69 , 1316.471 , 89.77941 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PATHWestfalltoDuskwood1822grind : QuestFollowPathClass
{
    public PATHWestfalltoDuskwood1822grind()
    {
        Name = "PATH : Westfall to Duskwood (18-22 grind)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 22;
        RequiredQuest = 0;

        Path.Add(new Vector3(-10671.5 , 1032.402 , 32.61212 , "None"));
Path.Add(new Vector3(-10686.48 , 1033.678 , 32.52004 , "None"));
Path.Add(new Vector3(-10701.8 , 1032.961 , 32.9342 , "None"));
Path.Add(new Vector3(-10723.37 , 1026.229 , 33.23176 , "None"));
Path.Add(new Vector3(-10743.87 , 1016.046 , 33.50885 , "None"));
Path.Add(new Vector3(-10786.91 , 1015.268 , 32.87817 , "None"));
Path.Add(new Vector3(-10821.72 , 1012.951 , 32.80649 , "None"));
Path.Add(new Vector3(-10857.42 , 1008.255 , 31.58332 , "None"));
Path.Add(new Vector3(-10892.87 , 1001.73 , 34.49648 , "None"));
Path.Add(new Vector3(-10924.87 , 988.2601 , 35.24393 , "None"));
Path.Add(new Vector3(-10936.49 , 973.8282 , 33.46607 , "None"));
Path.Add(new Vector3(-10942.61 , 956.7561 , 31.98857 , "None"));
Path.Add(new Vector3(-10941.65 , 944.7846 , 32.42117 , "None"));
Path.Add(new Vector3(-10940.76 , 924.0978 , 31.53084 , "None"));
Path.Add(new Vector3(-10940.79 , 896.8308 , 35.32477 , "None"));
Path.Add(new Vector3(-10944.01 , 863.1752 , 35.90178 , "None"));
Path.Add(new Vector3(-10945.06 , 826.0445 , 35.32817 , "None"));
Path.Add(new Vector3(-10940.74 , 806.9216 , 33.89054 , "None"));
Path.Add(new Vector3(-10924.33 , 776.1807 , 34.03141 , "None"));
Path.Add(new Vector3(-10906.51 , 746.1397 , 35.9945 , "None"));
Path.Add(new Vector3(-10888.26 , 713.7675 , 34.46066 , "None"));
Path.Add(new Vector3(-10879.49 , 697.4258 , 32.31129 , "None"));
Path.Add(new Vector3(-10872.82 , 685.0358 , 31.06767 , "None"));
Path.Add(new Vector3(-10867.74 , 664.877 , 30.93604 , "None"));
Path.Add(new Vector3(-10864.52 , 636.697 , 31.34634 , "None"));
Path.Add(new Vector3(-10862.63 , 601.8246 , 31.34634 , "None"));
Path.Add(new Vector3(-10860.4 , 583.3693 , 30.59163 , "None"));
Path.Add(new Vector3(-10855.2 , 554.3658 , 30.4881 , "None"));
Path.Add(new Vector3(-10851.52 , 537.3476 , 30.41234 , "None"));
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


public sealed class GRIND18to23DuskwoodV1 : QuestGrinderClass
{
    public GRIND18to23DuskwoodV1()
    {
        Name = "GRIND : 18 to 23 Duskwood V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 22;
        RequiredQuest = 0;

        EntryTarget.Add(217);
EntryTarget.Add(569);
EntryTarget.Add(565);
EntryTarget.Add(539);
EntryTarget.Add(213);
HotSpots.Add(new Vector3(-10984.91 , 430.8799 , 40.05012 , "None"));
HotSpots.Add(new Vector3(-10875.55 , 522.1568 , 35.11746 , "None"));
HotSpots.Add(new Vector3(-10705.77 , 557.1893 , 31.16661 , "None"));
HotSpots.Add(new Vector3(-10622.43 , 542.6891 , 30.06092 , "None"));
HotSpots.Add(new Vector3(-10526.79 , 598.4308 , 29.07333 , "None"));
HotSpots.Add(new Vector3(-10425.68 , 580.3824 , 31.42693 , "None"));
HotSpots.Add(new Vector3(-10243.37 , 539.5844 , 27.00812 , "None"));
HotSpots.Add(new Vector3(-10149.38 , 310.1641 , 25.35665 , "None"));
HotSpots.Add(new Vector3(-10205.13 , 138.8122 , 30.45784 , "None"));
HotSpots.Add(new Vector3(-10076.95 , -139.2549 , 23.98359 , "None"));
HotSpots.Add(new Vector3(-10084.18 , -268.4343 , 31.1534 , "None"));
HotSpots.Add(new Vector3(-10012.45 , -548.8516 , 43.12981 , "None"));
HotSpots.Add(new Vector3(-10074.09 , -858.7899 , 36.61026 , "None"));
HotSpots.Add(new Vector3(-10052.39 , -1247.962 , 29.10644 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 23;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND18to23DuskwoodV2 : QuestGrinderClass
{
    public GRIND18to23DuskwoodV2()
    {
        Name = "GRIND : 18 to 23 Duskwood V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 22;
        RequiredQuest = 0;

        EntryTarget.Add(213);
EntryTarget.Add(539);
EntryTarget.Add(217);
EntryTarget.Add(569);
EntryTarget.Add(565);
HotSpots.Add(new Vector3(-10036.51 , -1321.661 , 30.42473 , "None"));
HotSpots.Add(new Vector3(-10135.75 , -1118.368 , 33.32857 , "None"));
HotSpots.Add(new Vector3(-9991.37 , -967.7439 , 24.65038 , "None"));
HotSpots.Add(new Vector3(-10066.57 , -841.3062 , 36.20472 , "None"));
HotSpots.Add(new Vector3(-10063.88 , -689.0601 , 35.07976 , "None"));
HotSpots.Add(new Vector3(-9938.815 , -621.6637 , 30.2859 , "None"));
HotSpots.Add(new Vector3(-10039.71 , -470.5291 , 44.8713 , "None"));
HotSpots.Add(new Vector3(-10105.81 , -291.4585 , 32.55859 , "None"));
HotSpots.Add(new Vector3(-10105.61 , -85.77955 , 25.07869 , "None"));
HotSpots.Add(new Vector3(-10243.78 , -30.59382 , 37.57431 , "None"));
HotSpots.Add(new Vector3(-10195.03 , 147.7848 , 28.94652 , "None"));
HotSpots.Add(new Vector3(-10197.12 , 279.644 , 24.55976 , "None"));
HotSpots.Add(new Vector3(-10163.88 , 418.3729 , 29.57917 , "None"));
HotSpots.Add(new Vector3(-10288.31 , 523.6703 , 36.67896 , "None"));
HotSpots.Add(new Vector3(-10491 , 599.1807 , 25.57383 , "None"));
HotSpots.Add(new Vector3(-10715.74 , 570.0684 , 29.85709 , "None"));
HotSpots.Add(new Vector3(-10852.92 , 552.3079 , 30.4877 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 23;
}



public override bool HasQuest() { return true; }


}


public sealed class DEPRECATEDEightLeggedMenaces : QuestGrinderClass
{
    public DEPRECATEDEightLeggedMenaces()
    {
        Name = "[DEPRECATED]Eight-Legged Menaces";

        QuestId.AddRange(new[] { 245 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 23;
        RequiredQuest = 0;

        EntryTarget.Add(539);
HotSpots.Add(new Vector3(-10844.06 , 518.7682 , 30.23348 , "None"));
HotSpots.Add(new Vector3(-10685.43 , 575.2509 , 27.6647 , "None"));
HotSpots.Add(new Vector3(-10550.82 , 508.3459 , 31.18528 , "None"));
HotSpots.Add(new Vector3(-10463.93 , 617.9656 , 22.70967 , "None"));
HotSpots.Add(new Vector3(-10233.03 , 509.0926 , 25.65329 , "None"));
HotSpots.Add(new Vector3(-10452.34 , 622.075 , 23.97245 , "None"));
HotSpots.Add(new Vector3(-10585.97 , 498.5308 , 30.00872 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WolvesatOurHeels : QuestGrinderClass
{
    public WolvesatOurHeels()
    {
        Name = "Wolves at Our Heels";

        QuestId.AddRange(new[] { 226 });

        Step = new List<int> { 12, 8, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 23;
        RequiredQuest = 0;

        EntryTarget.Add(565);
EntryTarget.Add(213);
HotSpots.Add(new Vector3(-10549.81 , 564.3986 , 28.95555 , "None"));
HotSpots.Add(new Vector3(-10817.05 , 548.5065 , 32.16007 , "None"));
HotSpots.Add(new Vector3(-10320.61 , 519.71 , 38.92366 , "None"));
HotSpots.Add(new Vector3(-10214.41 , 464.3714 , 32.20516 , "None"));
HotSpots.Add(new Vector3(-10151.81 , 340.5721 , 29.54629 , "None"));
HotSpots.Add(new Vector3(-10222.17 , 191.6404 , 26.99674 , "None"));
HotSpots.Add(new Vector3(-10200.43 , 40.10595 , 30.15487 , "None"));
HotSpots.Add(new Vector3(-10152.77 , -64.40138 , 29.0639 , "None"));
HotSpots.Add(new Vector3(-10092.67 , -288.4298 , 32.16275 , "None"));
HotSpots.Add(new Vector3(-10026.34 , -759.9225 , 34.21077 , "None"));
HotSpots.Add(new Vector3(-10151.05 , -977.6287 , 30.24915 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RuntoMenethil : QuestFollowPathClass
{
    public RuntoMenethil()
    {
        Name = "Run to Menethil";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 24;
        RequiredQuest = 0;

        Path.Add(new Vector3(-4086.589 , -2623.014 , 43.48487 , "None"));
Path.Add(new Vector3(-4086.836 , -2634.211 , 41.78074 , "None"));
Path.Add(new Vector3(-4087.749 , -2652.388 , 37.81042 , "None"));
Path.Add(new Vector3(-4089.264 , -2669.82 , 33.5039 , "None"));
Path.Add(new Vector3(-4089.582 , -2687.286 , 29.46224 , "None"));
Path.Add(new Vector3(-4086.893 , -2705.263 , 25.08231 , "None"));
Path.Add(new Vector3(-4082.805 , -2722.27 , 21.16076 , "None"));
Path.Add(new Vector3(-4076.479 , -2738.664 , 18.98953 , "None"));
Path.Add(new Vector3(-4068.492 , -2754.662 , 17.97065 , "None"));
Path.Add(new Vector3(-4059.502 , -2769.674 , 17.849 , "None"));
Path.Add(new Vector3(-4048.55 , -2784.177 , 17.81255 , "None"));
Path.Add(new Vector3(-4035.529 , -2795.832 , 17.8137 , "None"));
Path.Add(new Vector3(-4021.044 , -2805.813 , 17.83225 , "None"));
Path.Add(new Vector3(-4005.344 , -2813.469 , 17.86934 , "None"));
Path.Add(new Vector3(-3987.473 , -2816.938 , 17.89553 , "None"));
Path.Add(new Vector3(-3970.136 , -2819.012 , 17.921 , "None"));
Path.Add(new Vector3(-3952 , -2820.52 , 17.96919 , "None"));
Path.Add(new Vector3(-3934.595 , -2821.968 , 17.99276 , "None"));
Path.Add(new Vector3(-3917.15 , -2821.759 , 18.01084 , "None"));
Path.Add(new Vector3(-3901.16 , -2814.814 , 18.01126 , "None"));
Path.Add(new Vector3(-3885.003 , -2806.502 , 17.99019 , "None"));
Path.Add(new Vector3(-3869.435 , -2798.434 , 17.97373 , "None"));
Path.Add(new Vector3(-3852.96 , -2792.229 , 17.78545 , "None"));
Path.Add(new Vector3(-3834.855 , -2790.416 , 17.81271 , "None"));
Path.Add(new Vector3(-3817.446 , -2789.579 , 17.81271 , "None"));
Path.Add(new Vector3(-3799.962 , -2788.832 , 17.81271 , "None"));
Path.Add(new Vector3(-3781.744 , -2788.053 , 17.81271 , "None"));
Path.Add(new Vector3(-3764.306 , -2787.121 , 17.81271 , "None"));
Path.Add(new Vector3(-3746.753 , -2782.48 , 17.81271 , "None"));
Path.Add(new Vector3(-3730.182 , -2776.858 , 17.88911 , "None"));
Path.Add(new Vector3(-3713.805 , -2770.693 , 17.6648 , "None"));
Path.Add(new Vector3(-3697.03 , -2763.725 , 18.80906 , "None"));
Path.Add(new Vector3(-3681.475 , -2755.657 , 19.1112 , "None"));
Path.Add(new Vector3(-3666.167 , -2747.252 , 19.20248 , "None"));
Path.Add(new Vector3(-3650.337 , -2738.274 , 18.83847 , "None"));
Path.Add(new Vector3(-3635.555 , -2728.777 , 18.68349 , "None"));
Path.Add(new Vector3(-3620.828 , -2719.454 , 18.78895 , "None"));
Path.Add(new Vector3(-3605.946 , -2710.18 , 19.0592 , "None"));
Path.Add(new Vector3(-3590.528 , -2700.575 , 19.0592 , "None"));
Path.Add(new Vector3(-3575.081 , -2690.951 , 18.376 , "None"));
Path.Add(new Vector3(-3560.159 , -2681.808 , 16.10058 , "None"));
Path.Add(new Vector3(-3545.184 , -2672.686 , 15.74494 , "None"));
Path.Add(new Vector3(-3529.326 , -2663.845 , 15.2948 , "None"));
Path.Add(new Vector3(-3513.489 , -2656.4 , 15.7328 , "None"));
Path.Add(new Vector3(-3497.68 , -2648.894 , 15.95161 , "None"));
Path.Add(new Vector3(-3482.066 , -2640.994 , 15.95161 , "None"));
Path.Add(new Vector3(-3466.031 , -2632.395 , 15.95161 , "None"));
Path.Add(new Vector3(-3451.162 , -2623.167 , 15.95941 , "None"));
Path.Add(new Vector3(-3435.723 , -2613.465 , 15.96135 , "None"));
Path.Add(new Vector3(-3420.766 , -2604.382 , 15.5348 , "None"));
Path.Add(new Vector3(-3405.63 , -2595.669 , 15.98464 , "None"));
Path.Add(new Vector3(-3389.852 , -2586.598 , 16.33821 , "None"));
Path.Add(new Vector3(-3374.68 , -2577.875 , 15.96197 , "None"));
Path.Add(new Vector3(-3360.086 , -2569.484 , 15.96197 , "None"));
Path.Add(new Vector3(-3343.831 , -2559.91 , 16.70466 , "None"));
Path.Add(new Vector3(-3329.367 , -2550.076 , 17.68358 , "None"));
Path.Add(new Vector3(-3316.183 , -2538.57 , 16.87478 , "None"));
Path.Add(new Vector3(-3302.879 , -2526.853 , 18.43036 , "None"));
Path.Add(new Vector3(-3289.229 , -2514.816 , 18.06615 , "None"));
Path.Add(new Vector3(-3275.932 , -2502.391 , 18.3073 , "None"));
Path.Add(new Vector3(-3264.632 , -2489.136 , 18.55952 , "None"));
Path.Add(new Vector3(-3257.369 , -2473.219 , 16.99981 , "None"));
Path.Add(new Vector3(-3250.936 , -2456.95 , 16.2986 , "None"));
Path.Add(new Vector3(-3245.204 , -2439.677 , 17.00907 , "None"));
Path.Add(new Vector3(-3240.921 , -2422.719 , 17.09199 , "None"));
Path.Add(new Vector3(-3238.015 , -2404.785 , 17.05799 , "None"));
Path.Add(new Vector3(-3235.259 , -2387.504 , 16.06983 , "None"));
Path.Add(new Vector3(-3232.312 , -2370.254 , 15.86452 , "None"));
Path.Add(new Vector3(-3229.362 , -2353.004 , 15.80549 , "None"));
Path.Add(new Vector3(-3226.295 , -2335.064 , 15.80549 , "None"));
Path.Add(new Vector3(-3223.349 , -2317.835 , 15.80127 , "None"));
Path.Add(new Vector3(-3220.455 , -2299.869 , 15.79587 , "None"));
Path.Add(new Vector3(-3218.592 , -2282.469 , 15.80517 , "None"));
Path.Add(new Vector3(-3216.28 , -2264.418 , 15.75358 , "None"));
Path.Add(new Vector3(-3213.295 , -2247.891 , 15.80519 , "None"));
Path.Add(new Vector3(-3209.126 , -2230.176 , 15.80519 , "None"));
Path.Add(new Vector3(-3204.966 , -2213.178 , 15.78106 , "None"));
Path.Add(new Vector3(-3202.282 , -2195.205 , 15.80372 , "None"));
Path.Add(new Vector3(-3201.138 , -2177.769 , 15.91837 , "None"));
Path.Add(new Vector3(-3200.057 , -2159.601 , 16.40357 , "None"));
Path.Add(new Vector3(-3199.019 , -2142.132 , 16.83554 , "None"));
Path.Add(new Vector3(-3197.914 , -2124.667 , 16.56693 , "None"));
Path.Add(new Vector3(-3196.806 , -2107.202 , 16.27407 , "None"));
Path.Add(new Vector3(-3195.625 , -2089.041 , 15.99198 , "None"));
Path.Add(new Vector3(-3194.246 , -2071.595 , 15.48455 , "None"));
Path.Add(new Vector3(-3192.344 , -2053.528 , 16.02641 , "None"));
Path.Add(new Vector3(-3190.21 , -2036.158 , 15.66037 , "None"));
Path.Add(new Vector3(-3187.875 , -2018.835 , 15.67166 , "None"));
Path.Add(new Vector3(-3184.809 , -2001.607 , 16.53678 , "None"));
Path.Add(new Vector3(-3181.604 , -1983.693 , 15.54518 , "None"));
Path.Add(new Vector3(-3179.552 , -1966.322 , 14.06725 , "None"));
Path.Add(new Vector3(-3179.834 , -1948.148 , 13.75243 , "None"));
Path.Add(new Vector3(-3181.943 , -1930.776 , 13.49766 , "None"));
Path.Add(new Vector3(-3184.196 , -1913.422 , 14.24441 , "None"));
Path.Add(new Vector3(-3185.921 , -1896.012 , 14.22162 , "None"));
Path.Add(new Vector3(-3187.058 , -1877.848 , 11.77501 , "None"));
Path.Add(new Vector3(-3188.542 , -1860.417 , 9.189047 , "None"));
Path.Add(new Vector3(-3192.885 , -1842.792 , 9.147863 , "None"));
Path.Add(new Vector3(-3199.182 , -1826.468 , 9.241767 , "None"));
Path.Add(new Vector3(-3205.105 , -1809.259 , 9.146294 , "None"));
Path.Add(new Vector3(-3211.492 , -1792.971 , 9.146502 , "None"));
Path.Add(new Vector3(-3218.071 , -1776.757 , 9.875428 , "None"));
Path.Add(new Vector3(-3224.042 , -1760.332 , 9.773492 , "None"));
Path.Add(new Vector3(-3230.67 , -1743.419 , 8.808271 , "None"));
Path.Add(new Vector3(-3237.271 , -1727.237 , 9.23364 , "None"));
Path.Add(new Vector3(-3243.922 , -1710.296 , 9.502438 , "None"));
Path.Add(new Vector3(-3250.089 , -1693.919 , 9.184623 , "None"));
Path.Add(new Vector3(-3255.85 , -1677.397 , 9.664923 , "None"));
Path.Add(new Vector3(-3258.715 , -1659.496 , 11.26035 , "None"));
Path.Add(new Vector3(-3260.496 , -1642.087 , 9.146132 , "None"));
Path.Add(new Vector3(-3262.699 , -1624.744 , 9.146132 , "None"));
Path.Add(new Vector3(-3266.897 , -1607.055 , 9.231087 , "None"));
Path.Add(new Vector3(-3271.094 , -1590.067 , 9.333776 , "None"));
Path.Add(new Vector3(-3276.007 , -1572.544 , 9.1462 , "None"));
Path.Add(new Vector3(-3280.781 , -1556.437 , 9.1462 , "None"));
Path.Add(new Vector3(-3286.258 , -1539.08 , 9.1462 , "None"));
Path.Add(new Vector3(-3291.508 , -1522.387 , 9.1462 , "None"));
Path.Add(new Vector3(-3296.933 , -1505.014 , 9.1462 , "None"));
Path.Add(new Vector3(-3302.044 , -1488.279 , 9.575612 , "None"));
Path.Add(new Vector3(-3306.888 , -1470.736 , 9.146162 , "None"));
Path.Add(new Vector3(-3310.756 , -1453.669 , 9.146015 , "None"));
Path.Add(new Vector3(-3314.603 , -1436.597 , 9.146015 , "None"));
Path.Add(new Vector3(-3318.66 , -1418.855 , 9.146015 , "None"));
Path.Add(new Vector3(-3323.307 , -1401.994 , 9.146015 , "None"));
Path.Add(new Vector3(-3330.479 , -1385.161 , 9.146015 , "None"));
Path.Add(new Vector3(-3337.621 , -1369.3 , 9.146015 , "None"));
Path.Add(new Vector3(-3343.321 , -1352.777 , 9.146015 , "None"));
Path.Add(new Vector3(-3347.134 , -1334.985 , 9.146015 , "None"));
Path.Add(new Vector3(-3348.16 , -1317.564 , 8.073789 , "None"));
Path.Add(new Vector3(-3345.15 , -1300.029 , 8.850145 , "None"));
Path.Add(new Vector3(-3342.063 , -1282.839 , 8.2852 , "None"));
Path.Add(new Vector3(-3342.02 , -1265.339 , 9.146953 , "None"));
Path.Add(new Vector3(-3343.669 , -1247.251 , 9.146953 , "None"));
Path.Add(new Vector3(-3345.376 , -1229.834 , 9.146953 , "None"));
Path.Add(new Vector3(-3347.587 , -1211.775 , 9.146479 , "None"));
Path.Add(new Vector3(-3350.482 , -1194.482 , 9.146479 , "None"));
Path.Add(new Vector3(-3353.818 , -1177.302 , 9.146283 , "None"));
Path.Add(new Vector3(-3356.864 , -1159.395 , 10.54012 , "None"));
Path.Add(new Vector3(-3360.023 , -1141.496 , 10.77487 , "None"));
Path.Add(new Vector3(-3363.474 , -1125.058 , 10.31712 , "None"));
Path.Add(new Vector3(-3368.236 , -1107.494 , 9.295201 , "None"));
Path.Add(new Vector3(-3373.112 , -1090.939 , 11.07447 , "None"));
Path.Add(new Vector3(-3378.336 , -1073.688 , 9.838372 , "None"));
Path.Add(new Vector3(-3383.207 , -1056.88 , 9.146412 , "None"));
Path.Add(new Vector3(-3388.377 , -1039.454 , 9.183526 , "None"));
Path.Add(new Vector3(-3396.131 , -1023.819 , 8.734912 , "None"));
Path.Add(new Vector3(-3406.635 , -1009.173 , 9.57627 , "None"));
Path.Add(new Vector3(-3416.804 , -995.2763 , 8.698691 , "None"));
Path.Add(new Vector3(-3427.593 , -980.6628 , 8.86585 , "None"));
Path.Add(new Vector3(-3439.357 , -967.6967 , 8.86585 , "None"));
Path.Add(new Vector3(-3452.834 , -955.481 , 8.86585 , "None"));
Path.Add(new Vector3(-3466.711 , -944.8209 , 8.86585 , "None"));
Path.Add(new Vector3(-3480.695 , -934.3071 , 8.865746 , "None"));
Path.Add(new Vector3(-3494.727 , -923.8503 , 8.865746 , "None"));
Path.Add(new Vector3(-3509.785 , -913.6558 , 8.865746 , "None"));
Path.Add(new Vector3(-3525.151 , -905.2827 , 9.158161 , "None"));
Path.Add(new Vector3(-3541.164 , -896.6325 , 9.339037 , "None"));
Path.Add(new Vector3(-3556.696 , -888.5705 , 11.70152 , "None"));
Path.Add(new Vector3(-3572.311 , -880.6694 , 12.76382 , "None"));
Path.Add(new Vector3(-3588.444 , -872.3101 , 12.98574 , "None"));
Path.Add(new Vector3(-3603.954 , -864.2062 , 12.80699 , "None"));
Path.Add(new Vector3(-3619.628 , -856.4356 , 11.79902 , "None"));
Path.Add(new Vector3(-3636.55 , -849.7354 , 9.45738 , "None"));
Path.Add(new Vector3(-3652.384 , -842.3117 , 9.795886 , "None"));
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


public sealed class ClawsfromtheDeepHead : QuestGrinderClass
{
    public ClawsfromtheDeepHead()
    {
        Name = "Claws from the Deep - Head";

        QuestId.AddRange(new[] { 279 });

        Step = new List<int> { 0, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 25;
        RequiredQuest = 0;

        EntryTarget.Add(1259);
HotSpots.Add(new Vector3(-3245.94 , -1136.65 , 9.015098 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(3618) >= 1;
}






}


public sealed class ClawsfromtheDeep : QuestGrinderClass
{
    public ClawsfromtheDeep()
    {
        Name = "Claws from the Deep";

        QuestId.AddRange(new[] { 279 });

        Step = new List<int> { 12, 1, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 25;
        RequiredQuest = 0;

        EntryTarget.Add(1259);
EntryTarget.Add(1024);
HotSpots.Add(new Vector3(-3288.209 , -1149.265 , 7.774212 , "None"));
HotSpots.Add(new Vector3(-3283.59 , -1004.226 , 10.38788 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReporttoCaptainStoutfist : QuestClass
{
    public ReporttoCaptainStoutfist()
    {
        Name = "Report to Captain Stoutfist";

        QuestId.AddRange(new[] { 473 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 25;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class InSearchofTheExcavationTeam : QuestClass
{
    public InSearchofTheExcavationTeam()
    {
        Name = "In Search of The Excavation Team";

        QuestId.AddRange(new[] { 305 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 25;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheThirdFleet : QuestGrinderClass
{
    public TheThirdFleet()
    {
        Name = "The Third Fleet";

        QuestId.AddRange(new[] { 288 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 25;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheGreenwarden : QuestClass
{
    public TheGreenwarden()
    {
        Name = "The Greenwarden";

        QuestId.AddRange(new[] { 463 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 25;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class InSearchofTheExcavationTeamPart2 : QuestClass
{
    public InSearchofTheExcavationTeamPart2()
    {
        Name = "In Search of The Excavation Team Part 2";

        QuestId.AddRange(new[] { 306 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 25;
        RequiredQuest = 305;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class OrmersRevenge : QuestGrinderClass
{
    public OrmersRevenge()
    {
        Name = "Ormer's Revenge";

        QuestId.AddRange(new[] { 294 });

        Step = new List<int> { 10, 10, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 25;
        RequiredQuest = 0;

        EntryTarget.Add(1020);
EntryTarget.Add(1021);
HotSpots.Add(new Vector3(-3303.723 , -1697.676 , 10.1573 , "None"));
HotSpots.Add(new Vector3(-3368.579 , -1587.62 , 10.36562 , "None"));
HotSpots.Add(new Vector3(-3427.164 , -1424.757 , 9.154663 , "None"));
HotSpots.Add(new Vector3(-3528.229 , -1415.274 , 10.64661 , "None"));
HotSpots.Add(new Vector3(-3564.75 , -1395.55 , 9.451763 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class OmarsRevengeDownRamp : QuestFollowPathClass
{
    public OmarsRevengeDownRamp()
    {
        Name = "Omars Revenge (Down Ramp)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 25;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3537.374 , -1972.468 , 116.5747 , "None"));
Path.Add(new Vector3(-3524.22 , -1962.717 , 115.2287 , "None"));
Path.Add(new Vector3(-3495.731 , -1942.522 , 113.3441 , "None"));
Path.Add(new Vector3(-3465.877 , -1922.34 , 112.251 , "None"));
Path.Add(new Vector3(-3452.132 , -1919.205 , 105.4874 , "None"));
Path.Add(new Vector3(-3432.807 , -1921.297 , 96.03092 , "None"));
Path.Add(new Vector3(-3398.504 , -1927.119 , 77.1814 , "None"));
Path.Add(new Vector3(-3380.068 , -1927.153 , 66.94745 , "None"));
Path.Add(new Vector3(-3364.732 , -1928.472 , 59.6883 , "None"));
Path.Add(new Vector3(-3343.447 , -1928.768 , 48.11951 , "None"));
Path.Add(new Vector3(-3322.272 , -1930.805 , 39.47906 , "None"));
Path.Add(new Vector3(-3315.414 , -1930.541 , 37.1835 , "None"));
Path.Add(new Vector3(-3311.909 , -1928.769 , 35.91917 , "None"));
Path.Add(new Vector3(-3305.208 , -1924.678 , 35.46276 , "None"));
Path.Add(new Vector3(-3303.22 , -1921.688 , 36.11619 , "None"));
Path.Add(new Vector3(-3303.107 , -1909.263 , 35.07241 , "None"));
Path.Add(new Vector3(-3300.892 , -1905.234 , 36.19244 , "None"));
Path.Add(new Vector3(-3299.772 , -1901.159 , 37.46849 , "None"));
Path.Add(new Vector3(-3298.829 , -1896.005 , 39.37302 , "None"));
Path.Add(new Vector3(-3297.106 , -1890.011 , 41.21265 , "None"));
Path.Add(new Vector3(-3293.505 , -1879.819 , 36.03828 , "None"));
Path.Add(new Vector3(-3290.109 , -1871.294 , 28.65845 , "None"));
Path.Add(new Vector3(-3288.007 , -1865.78 , 26.33885 , "None"));
Path.Add(new Vector3(-3286.691 , -1858.377 , 26.90247 , "None"));
Path.Add(new Vector3(-3285.583 , -1855.296 , 27.81246 , "None"));
Path.Add(new Vector3(-3282.803 , -1849.375 , 28.55786 , "None"));
Path.Add(new Vector3(-3279.433 , -1843.757 , 29.29254 , "None"));
Path.Add(new Vector3(-3277.247 , -1840.469 , 28.23696 , "None"));
Path.Add(new Vector3(-3275.036 , -1837.153 , 26.62899 , "None"));
Path.Add(new Vector3(-3273.022 , -1833.102 , 23.95725 , "None"));
Path.Add(new Vector3(-3270.609 , -1829.239 , 20.7608 , "None"));
Path.Add(new Vector3(-3269.062 , -1825.036 , 20.69572 , "None"));
Path.Add(new Vector3(-3270.003 , -1820.602 , 19.38774 , "None"));
Path.Add(new Vector3(-3270.93 , -1818.478 , 17.14778 , "None"));
Path.Add(new Vector3(-3270.123 , -1814.353 , 14.30637 , "None"));
Path.Add(new Vector3(-3267.731 , -1811.263 , 11.91594 , "None"));
Path.Add(new Vector3(-3260.94 , -1800.832 , 9.277416 , "None"));
Path.Add(new Vector3(-3254.762 , -1791.956 , 10.24109 , "None"));
Path.Add(new Vector3(-3252.434 , -1788.025 , 10.73693 , "None"));
Path.Add(new Vector3(-3247.389 , -1783.356 , 11.32065 , "None"));
Path.Add(new Vector3(-3243.992 , -1775.096 , 10.82346 , "None"));
Path.Add(new Vector3(-3243.506 , -1770.861 , 10.05157 , "None"));
Path.Add(new Vector3(-3250.062 , -1766.078 , 7.988216 , "None"));
Path.Add(new Vector3(-3258.909 , -1761.196 , 7.463472 , "None"));
Path.Add(new Vector3(-3265.221 , -1752.441 , 8.386491 , "None"));
Path.Add(new Vector3(-3270.835 , -1743.21 , 9.654995 , "None"));
Path.Add(new Vector3(-3275.762 , -1733.961 , 8.582634 , "None"));
Path.Add(new Vector3(-3280.884 , -1724.44 , 8.790211 , "None"));
Path.Add(new Vector3(-3286.896 , -1715.455 , 9.531281 , "None"));
Path.Add(new Vector3(-3288.983 , -1712.532 , 11.22461 , "None"));
Path.Add(new Vector3(-3288.213 , -1707.678 , 10.04285 , "None"));
Path.Add(new Vector3(-3287.969 , -1699.385 , 9.399241 , "None"));
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


public sealed class OmarsRevengeUpRamp : QuestFollowPathClass
{
    public OmarsRevengeUpRamp()
    {
        Name = "Omars Revenge (Up Ramp)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 25;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3259.916 , -1790.228 , 9.794197 , "None"));
Path.Add(new Vector3(-3264.142 , -1802.297 , 9.267549 , "None"));
Path.Add(new Vector3(-3265.884 , -1806.892 , 9.793453 , "None"));
Path.Add(new Vector3(-3269.165 , -1812.562 , 13.34418 , "None"));
Path.Add(new Vector3(-3273.016 , -1817.44 , 17.27354 , "None"));
Path.Add(new Vector3(-3271.006 , -1820.034 , 18.83452 , "None"));
Path.Add(new Vector3(-3269.709 , -1823.042 , 20.42793 , "None"));
Path.Add(new Vector3(-3270.04 , -1828.933 , 20.62003 , "None"));
Path.Add(new Vector3(-3273.413 , -1839.098 , 27.48804 , "None"));
Path.Add(new Vector3(-3280.259 , -1846.961 , 29.27276 , "None"));
Path.Add(new Vector3(-3282.806 , -1849.516 , 28.50981 , "None"));
Path.Add(new Vector3(-3289.728 , -1857.795 , 26.1774 , "None"));
Path.Add(new Vector3(-3292.786 , -1860.258 , 25.04929 , "None"));
Path.Add(new Vector3(-3293.472 , -1866.119 , 25.37744 , "None"));
Path.Add(new Vector3(-3291.468 , -1871.555 , 28.92529 , "None"));
Path.Add(new Vector3(-3292.595 , -1876.261 , 32.95078 , "None"));
Path.Add(new Vector3(-3295.232 , -1883.319 , 38.45706 , "None"));
Path.Add(new Vector3(-3297.477 , -1888.773 , 40.67109 , "None"));
Path.Add(new Vector3(-3299.612 , -1892.845 , 39.71748 , "None"));
Path.Add(new Vector3(-3305.124 , -1901.742 , 33.62371 , "None"));
Path.Add(new Vector3(-3312.229 , -1909.443 , 32.59729 , "None"));
Path.Add(new Vector3(-3320.197 , -1916.745 , 34.35993 , "None"));
Path.Add(new Vector3(-3325.561 , -1925.538 , 38.252 , "None"));
Path.Add(new Vector3(-3334.585 , -1931.353 , 44.29834 , "None"));
Path.Add(new Vector3(-3345.152 , -1932.225 , 49.4972 , "None"));
Path.Add(new Vector3(-3354.906 , -1928.408 , 54.29411 , "None"));
Path.Add(new Vector3(-3364.779 , -1927.489 , 59.24333 , "None"));
Path.Add(new Vector3(-3375.842 , -1928.338 , 64.89981 , "None"));
Path.Add(new Vector3(-3389.292 , -1927.086 , 72.0657 , "None"));
Path.Add(new Vector3(-3424.994 , -1922.371 , 91.73751 , "None"));
Path.Add(new Vector3(-3452.14 , -1921.455 , 106.2068 , "None"));
Path.Add(new Vector3(-3470.145 , -1926.2 , 113.8982 , "None"));
Path.Add(new Vector3(-3497.154 , -1944.394 , 113.3442 , "None"));
Path.Add(new Vector3(-3525.48 , -1964.716 , 115.7365 , "None"));
Path.Add(new Vector3(-3544.073 , -1976.174 , 117.0226 , "None"));
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


public sealed class OrmersRevengePart2 : QuestGrinderClass
{
    public OrmersRevengePart2()
    {
        Name = "Ormer's Revenge Part 2";

        QuestId.AddRange(new[] { 295 });

        Step = new List<int> { 10, 10, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 28;
        RequiredQuest = 294;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DailyDelivery : QuestGrinderClass
{
    public DailyDelivery()
    {
        Name = "Daily Delivery";

        QuestId.AddRange(new[] { 469 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 25;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class YoungCrocoliskSkins : QuestGrinderClass
{
    public YoungCrocoliskSkins()
    {
        Name = "Young Crocolisk Skins";

        QuestId.AddRange(new[] { 484 });

        Step = new List<int> { 4, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 25;
        RequiredQuest = 0;

        EntryTarget.Add(1417);
HotSpots.Add(new Vector3(-3481.044 , -1003.423 , 9.457491 , "None"));
HotSpots.Add(new Vector3(-3392.14 , -1225.053 , 7.798468 , "None"));
HotSpots.Add(new Vector3(-3261.449 , -1525.604 , 9.540904 , "None"));
HotSpots.Add(new Vector3(-3180.035 , -1730.406 , 8.19993 , "None"));
HotSpots.Add(new Vector3(-3144.128 , -1817.33 , 8.365879 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(3397) >= 4;
}






}


public sealed class ReclaimingGoods : QuestClass
{
    public ReclaimingGoods()
    {
        Name = "Reclaiming Goods";

        QuestId.AddRange(new[] { 281 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 25;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheSearchContinues : QuestClass
{
    public TheSearchContinues()
    {
        Name = "The Search Continues";

        QuestId.AddRange(new[] { 284 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 25;
        RequiredQuest = 281;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SearchMoreHovels : QuestClass
{
    public SearchMoreHovels()
    {
        Name = "Search More Hovels";

        QuestId.AddRange(new[] { 285 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 25;
        RequiredQuest = 284;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReturntheStatuette : QuestClass
{
    public ReturntheStatuette()
    {
        Name = "Return the Statuette";

        QuestId.AddRange(new[] { 286 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 25;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ApprenticesDutiesCrocsP2 : QuestGrinderClass
{
    public ApprenticesDutiesCrocsP2()
    {
        Name = "Apprentice's Duties (Crocs P2)";

        QuestId.AddRange(new[] { 471 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 27;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PATHWetlandstoHillsbrad : QuestFollowPathClass
{
    public PATHWetlandstoHillsbrad()
    {
        Name = "PATH: Wetlands to Hillsbrad";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 29;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3765.463 , -743.1922 , 8.004486 , "None"));
Path.Add(new Vector3(-3741.195 , -724.7379 , 8.349409 , "None"));
Path.Add(new Vector3(-3719.98 , -721.6085 , 9.517419 , "None"));
Path.Add(new Vector3(-3703.957 , -707.4171 , 8.153061 , "None"));
Path.Add(new Vector3(-3691.422 , -696.9352 , 5.6057 , "None"));
Path.Add(new Vector3(-3666.826 , -698.593 , 6.349479 , "None"));
Path.Add(new Vector3(-3649.745 , -705.6873 , 8.286094 , "None"));
Path.Add(new Vector3(-3625.995 , -702.1723 , 7.819995 , "None"));
Path.Add(new Vector3(-3605.506 , -704.9483 , 5.46506 , "None"));
Path.Add(new Vector3(-3587.042 , -716.2458 , 3.760346 , "None"));
Path.Add(new Vector3(-3572.346 , -717.1475 , -0.7500572 , "Swimming"));
Path.Add(new Vector3(-3557.354 , -718.1476 , -0.8317559 , "Swimming"));
Path.Add(new Vector3(-3541.4 , -719.2118 , -0.76763 , "Swimming"));
Path.Add(new Vector3(-3526.415 , -720.2114 , -0.76763 , "Swimming"));
Path.Add(new Vector3(-3510.536 , -721.2706 , -0.76763 , "Swimming"));
Path.Add(new Vector3(-3482.534 , -723.139 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-3438.913 , -719.5164 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-3384.156 , -713.3711 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-3337.122 , -716.3475 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-3288.627 , -717.4655 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-3242.59 , -711.8995 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-3195.287 , -718.0793 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-3148.708 , -728.7742 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-3105.179 , -746.8367 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-3060.952 , -765.1888 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-3016.028 , -783.8306 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2969.625 , -794.2701 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2922.022 , -797.2653 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2874.864 , -805.5647 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2827.705 , -813.8641 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2781.052 , -824.0559 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2737.923 , -845.4274 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2702.406 , -876.2673 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2674.323 , -915.9199 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2647.046 , -955.2186 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2620.117 , -994.6473 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2594.868 , -1035.333 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2566.698 , -1072.32 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2526.509 , -1098.35 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2495.083 , -1133.919 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2484.266 , -1180.249 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2474.443 , -1226.656 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2449.193 , -1267.342 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2422.825 , -1307.151 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2391.347 , -1342.796 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2365.569 , -1383.086 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2330.813 , -1416.024 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2290.424 , -1440.415 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2243.469 , -1444.161 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2201.41 , -1423.934 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2162.96 , -1394.418 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2133.335 , -1358.039 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2103.191 , -1321.259 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2065.779 , -1291.373 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-2025.154 , -1266.176 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1984.387 , -1242.531 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1949.15 , -1209.48 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1911.361 , -1180.722 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1866.895 , -1163.662 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1835.904 , -1127.839 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1823.484 , -1082.648 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1794.333 , -1045.66 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1763.838 , -1007.768 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1729.122 , -974.0876 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1692.3 , -944.6734 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1650.593 , -924.2148 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1603.451 , -917.6277 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1558.45 , -902.4528 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1513.566 , -884.6064 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1473.111 , -860.5267 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1437.826 , -828.1564 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1402.542 , -795.786 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1367.258 , -763.4156 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1331.417 , -730.5345 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1296.133 , -698.1641 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1260.849 , -665.7938 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1226.121 , -633.9343 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1190.837 , -601.5639 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1153.095 , -571.7061 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1108.064 , -557.8063 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1060.886 , -550.8999 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-1013.188 , -542.3068 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-967.5709 , -531.2401 , -0.9065509 , "Swimming"));
Path.Add(new Vector3(-939.2825 , -514.8047 , -0.05877715 , "None"));
Path.Add(new Vector3(-906.7455 , -507.598 , 5.918599 , "None"));
Path.Add(new Vector3(-872.4912 , -515.6268 , 12.19237 , "None"));
Path.Add(new Vector3(-842.0294 , -522.7704 , 11.21996 , "None"));
Path.Add(new Vector3(-813.0368 , -535.3475 , 15.40004 , "None"));
Path.Add(new Vector3(-777.7642 , -545.5792 , 17.99379 , "None"));
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


public sealed class GRIND2324HillsbradV1 : QuestGrinderClass
{
    public GRIND2324HillsbradV1()
    {
        Name = "GRIND: 23-24 Hillsbrad V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 23;
        RequiredQuest = 0;

        EntryTarget.Add(2354);
EntryTarget.Add(2384);
HotSpots.Add(new Vector3(-639.1982 , -365.8979 , 40.60787 , "None"));
HotSpots.Add(new Vector3(-624.548 , -647.6762 , 35.13615 , "None"));
HotSpots.Add(new Vector3(-489.2898 , -776.5279 , 53.78126 , "None"));
HotSpots.Add(new Vector3(-536.2526 , -397.4765 , 43.65266 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 24;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND2324HillsbradV2 : QuestGrinderClass
{
    public GRIND2324HillsbradV2()
    {
        Name = "GRIND: 23-24 Hillsbrad V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 23;
        RequiredQuest = 0;

        EntryTarget.Add(2384);
EntryTarget.Add(2354);
EntryTarget.Add(2349);
HotSpots.Add(new Vector3(-578.8989 , -373.455 , 43.09676 , "None"));
HotSpots.Add(new Vector3(-499.7192 , -235.7387 , 52.57654 , "None"));
HotSpots.Add(new Vector3(-543.3846 , -712.5922 , 48.16106 , "None"));
HotSpots.Add(new Vector3(-463.3939 , -692.5662 , 50.89663 , "None"));
HotSpots.Add(new Vector3(-371.2898 , -575.2602 , 51.90675 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 24;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND2428HillsbradFoothillsAzurelodeMineV1 : QuestGrinderClass
{
    public GRIND2428HillsbradFoothillsAzurelodeMineV1()
    {
        Name = "GRIND: 24-28 - Hillsbrad Foothills (Azurelode Mine) V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 27;
        RequiredQuest = 0;

        EntryTarget.Add(2356);
EntryTarget.Add(2349);
HotSpots.Add(new Vector3(-876.7749 , -367.3726 , 28.30352 , "None"));
HotSpots.Add(new Vector3(-958.4809 , -197.6843 , 50.12261 , "None"));
HotSpots.Add(new Vector3(-825.8467 , -154.3058 , 33.24129 , "None"));
HotSpots.Add(new Vector3(-709.1626 , -188.9459 , 40.7486 , "None"));
HotSpots.Add(new Vector3(-727.8467 , -0.4528603 , 30.74815 , "None"));
HotSpots.Add(new Vector3(-858.6749 , 108.2832 , 38.23252 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class GRIND2428HillsbradFoothillsAzurelodeMineV2 : QuestGrinderClass
{
    public GRIND2428HillsbradFoothillsAzurelodeMineV2()
    {
        Name = "GRIND: 24-28 - Hillsbrad Foothills (Azurelode Mine) V2";

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

        EntryTarget.Add(2356);
EntryTarget.Add(2349);
HotSpots.Add(new Vector3(-327.6949 , 216.4435 , 90.91404 , "None"));
HotSpots.Add(new Vector3(-682.0241 , 309.6931 , 50.31113 , "None"));
HotSpots.Add(new Vector3(-745.2847 , -20.80421 , 28.77604 , "None"));
HotSpots.Add(new Vector3(-988.1617 , 152.465 , 55.19749 , "None"));
HotSpots.Add(new Vector3(-1007.116 , 24.13704 , 41.03675 , "None"));
HotSpots.Add(new Vector3(-850.3521 , -163.0954 , 33.55207 , "None"));
HotSpots.Add(new Vector3(-624.7208 , -260.9483 , 41.55711 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GRIND2830Hillsbradv1 : QuestGrinderClass
{
    public GRIND2830Hillsbradv1()
    {
        Name = "GRIND 28-30 Hillsbrad v1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 29;
        RequiredQuest = 0;

        EntryTarget.Add(2408);
EntryTarget.Add(2385);
EntryTarget.Add(2348);
HotSpots.Add(new Vector3(-630.9916 , -789.0062 , 10.14428 , "None"));
HotSpots.Add(new Vector3(-784.3398 , -756.0316 , 13.13763 , "None"));
HotSpots.Add(new Vector3(-753.4514 , -904.1884 , 29.12702 , "None"));
HotSpots.Add(new Vector3(-893.8482 , -776.3663 , 19.36034 , "None"));
HotSpots.Add(new Vector3(-1018.146 , -898.3817 , 36.7473 , "None"));
HotSpots.Add(new Vector3(-1152.246 , -967.7283 , 63.16959 , "None"));
HotSpots.Add(new Vector3(-1166.288 , -1077.715 , 43.67828 , "None"));
HotSpots.Add(new Vector3(-947.1127 , -1113.155 , 49.28486 , "None"));
HotSpots.Add(new Vector3(-1085.884 , -1347.455 , 57.00641 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class NorthfoldManor : QuestGrinderClass
{
    public NorthfoldManor()
    {
        Name = "Northfold Manor";

        QuestId.AddRange(new[] { 681 });

        Step = new List<int> { 10, 6, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, true, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 35;
        RequiredQuest = 0;

        EntryTarget.Add(2586);
EntryTarget.Add(2589);
EntryTarget.Add(2587);
HotSpots.Add(new Vector3(-843.5392 , -2117.162 , 40.45832 , "None"));
HotSpots.Add(new Vector3(-770.1275 , -2043.235 , 34.12923 , "None"));
HotSpots.Add(new Vector3(-814.9609 , -2010.731 , 34.14077 , "None"));
HotSpots.Add(new Vector3(-848.6926 , -2028.709 , 34.25595 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GRIND3133ArathiV1 : QuestGrinderClass
{
    public GRIND3133ArathiV1()
    {
        Name = "GRIND : 31-33 Arathi V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 32;
        RequiredQuest = 0;

        EntryTarget.Add(2563);
EntryTarget.Add(2559);
EntryTarget.Add(2578);
HotSpots.Add(new Vector3(-1912.632 , -2398.524 , 61.35408 , "None"));
HotSpots.Add(new Vector3(-1754.906 , -2500.869 , 59.14675 , "None"));
HotSpots.Add(new Vector3(-1636.291 , -2406.533 , 80.65359 , "None"));
HotSpots.Add(new Vector3(-1513.108 , -2360.65 , 66.61217 , "None"));
HotSpots.Add(new Vector3(-1452.582 , -2490.066 , 62.63983 , "None"));
HotSpots.Add(new Vector3(-1500.437 , -2577.799 , 66.31362 , "None"));
HotSpots.Add(new Vector3(-1342.806 , -2552.122 , 68.99655 , "None"));
HotSpots.Add(new Vector3(-1193.338 , -2683.572 , 47.56104 , "None"));
HotSpots.Add(new Vector3(-1251.814 , -2873.886 , 44.46815 , "None"));
HotSpots.Add(new Vector3(-1094.885 , -2725.67 , 41.88897 , "None"));
HotSpots.Add(new Vector3(-1130.409 , -2544.631 , 55.70894 , "None"));
HotSpots.Add(new Vector3(-1052.888 , -2394.924 , 54.46884 , "None"));
HotSpots.Add(new Vector3(-1021.753 , -2264.099 , 52.20604 , "None"));
HotSpots.Add(new Vector3(-1181.85 , -2298.896 , 52.54607 , "None"));
HotSpots.Add(new Vector3(-1375.7 , -2232.185 , 59.15821 , "None"));
HotSpots.Add(new Vector3(-1412.104 , -2402.011 , 61.68131 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 33;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND3133ArathiV2 : QuestGrinderClass
{
    public GRIND3133ArathiV2()
    {
        Name = "GRIND : 31-33 Arathi V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 32;
        RequiredQuest = 0;

        EntryTarget.Add(2563);
EntryTarget.Add(2559);
EntryTarget.Add(2578);
EntryTarget.Add(2553);
EntryTarget.Add(2562);
EntryTarget.Add(12922);
EntryTarget.Add(2560);
EntryTarget.Add(2552);
HotSpots.Add(new Vector3(-1209.54 , -1689.265 , 50.71412 , "None"));
HotSpots.Add(new Vector3(-1212.599 , -1458.53 , 59.82572 , "None"));
HotSpots.Add(new Vector3(-1100.833 , -1466.237 , 53.43116 , "None"));
HotSpots.Add(new Vector3(-963.5294 , -1546.082 , 51.80452 , "None"));
HotSpots.Add(new Vector3(-1141.098 , -1661.892 , 42.34006 , "None"));
HotSpots.Add(new Vector3(-1104.374 , -1794.521 , 59.6453 , "None"));
HotSpots.Add(new Vector3(-1081.448 , -2084.2 , 53.77262 , "None"));
HotSpots.Add(new Vector3(-961.7352 , -2068.719 , 53.30645 , "None"));
HotSpots.Add(new Vector3(-852.8947 , -2123.582 , 40.87874 , "None"));
HotSpots.Add(new Vector3(-1300.651 , -2294.199 , 63.2796 , "None"));
HotSpots.Add(new Vector3(-1351.446 , -2154.339 , 63.22835 , "None"));
HotSpots.Add(new Vector3(-1587.557 , -2407.347 , 90.33994 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 33;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND3133ArathiV3 : QuestGrinderClass
{
    public GRIND3133ArathiV3()
    {
        Name = "GRIND : 31-33 Arathi V3";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 32;
        RequiredQuest = 0;

        EntryTarget.Add(2563);
EntryTarget.Add(2559);
EntryTarget.Add(2578);
HotSpots.Add(new Vector3(-1729.678 , -2478.021 , 58.54324 , "None"));
HotSpots.Add(new Vector3(-1478.83 , -2581.239 , 64.36403 , "None"));
HotSpots.Add(new Vector3(-1304.138 , -2628.32 , 62.00502 , "None"));
HotSpots.Add(new Vector3(-1143.747 , -2821.092 , 50.8138 , "None"));
HotSpots.Add(new Vector3(-1204.326 , -2973.315 , 48.2123 , "None"));
HotSpots.Add(new Vector3(-1037.585 , -3106.039 , 52.71673 , "None"));
HotSpots.Add(new Vector3(-942.9376 , -3395.077 , 67.29234 , "None"));
HotSpots.Add(new Vector3(-1358.149 , -3326.867 , 45.95639 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 3;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 33;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND33to35V1 : QuestGrinderClass
{
    public GRIND33to35V1()
    {
        Name = "GRIND : 33 to 35 - V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 34;
        RequiredQuest = 0;

        EntryTarget.Add(2560);
EntryTarget.Add(2563);
EntryTarget.Add(2579);
EntryTarget.Add(2565);
EntryTarget.Add(2572);
HotSpots.Add(new Vector3(-1487.078 , -1960.536 , 51.50857 , "None"));
HotSpots.Add(new Vector3(-1548.485 , -2024.309 , 31.11258 , "None"));
HotSpots.Add(new Vector3(-1667.215 , -2028.117 , 40.88035 , "None"));
HotSpots.Add(new Vector3(-1673.797 , -2174.327 , 27.7646 , "None"));
HotSpots.Add(new Vector3(-1691.859 , -2273.59 , 36.686 , "None"));
HotSpots.Add(new Vector3(-1811.126 , -2239.099 , 51.21793 , "None"));
HotSpots.Add(new Vector3(-1729.733 , -2340.785 , 31.01372 , "None"));
HotSpots.Add(new Vector3(-1896.638 , -2334.908 , 54.17576 , "None"));
HotSpots.Add(new Vector3(-1605.019 , -2589.002 , 44.53505 , "None"));
HotSpots.Add(new Vector3(-1548.914 , -2779.98 , 40.91605 , "None"));
HotSpots.Add(new Vector3(-1358.295 , -2983.245 , 45.22419 , "None"));
HotSpots.Add(new Vector3(-1403.462 , -3341.758 , 39.46966 , "None"));
HotSpots.Add(new Vector3(-1228.917 , -3513.375 , 42.07735 , "None"));
HotSpots.Add(new Vector3(-1194.778 , -3608.164 , 53.27309 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 35;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND33to35V2 : QuestGrinderClass
{
    public GRIND33to35V2()
    {
        Name = "GRIND : 33 to 35 - V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 34;
        RequiredQuest = 0;

        EntryTarget.Add(2572);
EntryTarget.Add(2563);
EntryTarget.Add(2554);
EntryTarget.Add(2555);
EntryTarget.Add(2556);
EntryTarget.Add(2565);
HotSpots.Add(new Vector3(-957.2764 , -3680.225 , 88.27587 , "None"));
HotSpots.Add(new Vector3(-1046.619 , -3670.314 , 80.28917 , "None"));
HotSpots.Add(new Vector3(-1108.861 , -3713.41 , 82.44979 , "None"));
HotSpots.Add(new Vector3(-1184.505 , -3592.651 , 49.85711 , "None"));
HotSpots.Add(new Vector3(-1589.973 , -3420.504 , 44.77542 , "None"));
HotSpots.Add(new Vector3(-1767.74 , -3347.247 , 25.47706 , "None"));
HotSpots.Add(new Vector3(-1683.426 , -3041.797 , 27.26808 , "None"));
HotSpots.Add(new Vector3(-1452.649 , -2826.239 , 44.29375 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 35;
}



public override bool HasQuest() { return true; }


}


public sealed class PATHArathitoIronforge : QuestFollowPathClass
{
    public PATHArathitoIronforge()
    {
        Name = "PATH : Arathi to Ironforge";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 36;
        RequiredQuest = 0;

        Path.Add(new Vector3(-1727.579 , -2435.927 , 62.51546 , "None"));
Path.Add(new Vector3(-1754.346 , -2426.378 , 60.8121 , "None"));
Path.Add(new Vector3(-1786.853 , -2413.599 , 57.48662 , "None"));
Path.Add(new Vector3(-1820.525 , -2404.629 , 55.78791 , "None"));
Path.Add(new Vector3(-1854.009 , -2415.889 , 59.46884 , "None"));
Path.Add(new Vector3(-1886.275 , -2426.019 , 61.29538 , "None"));
Path.Add(new Vector3(-1918.203 , -2442.613 , 66.38402 , "None"));
Path.Add(new Vector3(-1950.37 , -2456.183 , 74.21095 , "None"));
Path.Add(new Vector3(-1983.832 , -2466.181 , 78.35722 , "None"));
Path.Add(new Vector3(-2020.747 , -2467.138 , 78.05994 , "None"));
Path.Add(new Vector3(-2054.7 , -2458.964 , 75.73743 , "None"));
Path.Add(new Vector3(-2088.764 , -2451.445 , 74.22427 , "None"));
Path.Add(new Vector3(-2124.779 , -2450.668 , 77.87724 , "None"));
Path.Add(new Vector3(-2160.825 , -2451.191 , 80.96684 , "None"));
Path.Add(new Vector3(-2194.983 , -2457.423 , 81.19327 , "None"));
Path.Add(new Vector3(-2229.498 , -2464.944 , 81.36497 , "None"));
Path.Add(new Vector3(-2254.738 , -2489.09 , 80.22355 , "None"));
Path.Add(new Vector3(-2287.764 , -2502.268 , 78.50725 , "None"));
Path.Add(new Vector3(-2322.578 , -2505.063 , 82.55893 , "None"));
Path.Add(new Vector3(-2358.548 , -2505.428 , 88.34414 , "None"));
Path.Add(new Vector3(-2393.468 , -2504.883 , 87.56165 , "None"));
Path.Add(new Vector3(-2429.517 , -2505.025 , 80.79729 , "None"));
Path.Add(new Vector3(-2465.331 , -2501.455 , 78.50769 , "None"));
Path.Add(new Vector3(-2499.648 , -2495.041 , 81.36726 , "None"));
Path.Add(new Vector3(-2535.6 , -2492.766 , 84.35887 , "None"));
Path.Add(new Vector3(-2570.523 , -2492.107 , 81.34399 , "None"));
Path.Add(new Vector3(-2605.397 , -2493.809 , 80.55066 , "None"));
Path.Add(new Vector3(-2641.365 , -2496.235 , 79.96883 , "None"));
Path.Add(new Vector3(-2676.257 , -2497.838 , 79.12791 , "None"));
Path.Add(new Vector3(-2712.213 , -2500.429 , 69.35229 , "None"));
Path.Add(new Vector3(-2748.134 , -2503.477 , 63.95582 , "None"));
Path.Add(new Vector3(-2782.938 , -2506.442 , 60.55876 , "None"));
Path.Add(new Vector3(-2816.716 , -2500.295 , 56.29289 , "None"));
Path.Add(new Vector3(-2850.211 , -2489.156 , 52.11456 , "None"));
Path.Add(new Vector3(-2882.871 , -2477.313 , 41.40479 , "None"));
Path.Add(new Vector3(-2915.903 , -2462.873 , 34.40836 , "None"));
Path.Add(new Vector3(-2947.51 , -2448.005 , 24.66227 , "None"));
Path.Add(new Vector3(-2980.043 , -2432.474 , 19.77926 , "None"));
Path.Add(new Vector3(-3012.816 , -2417.742 , 10.74902 , "None"));
Path.Add(new Vector3(-3046.312 , -2426.701 , 10.99498 , "None"));
Path.Add(new Vector3(-3078.062 , -2441.151 , 10.37923 , "None"));
Path.Add(new Vector3(-3112.277 , -2451.085 , 9.396815 , "None"));
Path.Add(new Vector3(-3146.628 , -2444.987 , 9.162281 , "None"));
Path.Add(new Vector3(-3181.497 , -2451.471 , 8.925815 , "None"));
Path.Add(new Vector3(-3215.297 , -2460.002 , 11.42426 , "None"));
Path.Add(new Vector3(-3244.754 , -2480.464 , 15.96232 , "None"));
Path.Add(new Vector3(-3269.388 , -2506.706 , 17.10204 , "None"));
Path.Add(new Vector3(-3293.286 , -2532.18 , 16.35924 , "None"));
Path.Add(new Vector3(-3321.543 , -2552.534 , 17.29728 , "None"));
Path.Add(new Vector3(-3354.935 , -2566.12 , 15.94336 , "None"));
Path.Add(new Vector3(-3386.199 , -2581.645 , 16.33534 , "None"));
Path.Add(new Vector3(-3417.7 , -2599.174 , 16.06594 , "None"));
Path.Add(new Vector3(-3449.56 , -2615.963 , 16.10981 , "None"));
Path.Add(new Vector3(-3482.549 , -2627.152 , 17.56576 , "None"));
Path.Add(new Vector3(-3515.339 , -2639.192 , 16.2958 , "None"));
Path.Add(new Vector3(-3549.142 , -2651.717 , 16.11212 , "None"));
Path.Add(new Vector3(-3581.632 , -2664.202 , 20.27103 , "None"));
Path.Add(new Vector3(-3614.365 , -2676.364 , 21.79046 , "None"));
Path.Add(new Vector3(-3648.159 , -2688.919 , 25.99212 , "None"));
Path.Add(new Vector3(-3681.952 , -2701.474 , 24.71248 , "None"));
Path.Add(new Vector3(-3715.745 , -2714.03 , 26.3294 , "None"));
Path.Add(new Vector3(-3748.533 , -2725.874 , 27.63073 , "None"));
Path.Add(new Vector3(-3782.846 , -2736.915 , 23.73111 , "None"));
Path.Add(new Vector3(-3816.403 , -2746.613 , 21.17496 , "None"));
Path.Add(new Vector3(-3849.973 , -2756.264 , 20.67592 , "None"));
Path.Add(new Vector3(-3881.525 , -2773.564 , 20.89637 , "None"));
Path.Add(new Vector3(-3914.916 , -2780.237 , 20.91688 , "None"));
Path.Add(new Vector3(-3950.184 , -2785.964 , 21.82428 , "None"));
Path.Add(new Vector3(-3982.848 , -2798.338 , 20.56621 , "None"));
Path.Add(new Vector3(-4017.625 , -2802.208 , 17.88095 , "None"));
Path.Add(new Vector3(-4046.076 , -2782.979 , 17.81311 , "None"));
Path.Add(new Vector3(-4067.082 , -2753.79 , 18.00683 , "None"));
Path.Add(new Vector3(-4080.073 , -2720.3 , 21.35452 , "None"));
Path.Add(new Vector3(-4089.06 , -2686.834 , 29.56312 , "None"));
Path.Add(new Vector3(-4089.583 , -2650.915 , 38.17116 , "None"));
Path.Add(new Vector3(-4086.636 , -2614.988 , 44.69085 , "None"));
Path.Add(new Vector3(-4087.254 , -2580.076 , 47.77877 , "None"));
Path.Add(new Vector3(-4088.162 , -2545.161 , 62.34533 , "None"));
Path.Add(new Vector3(-4088.857 , -2521.168 , 69.23602 , "None"));
Path.Add(new Vector3(-4090.99 , -2486.304 , 86.07018 , "None"));
Path.Add(new Vector3(-4091.997 , -2450.269 , 97.40803 , "None"));
Path.Add(new Vector3(-4092.797 , -2426.272 , 97.60056 , "None"));
Path.Add(new Vector3(-4089.133 , -2413.833 , 98.91212 , "None"));
Path.Add(new Vector3(-4080.892 , -2406.668 , 100.5471 , "None"));
Path.Add(new Vector3(-4059.126 , -2392.399 , 106.8332 , "None"));
Path.Add(new Vector3(-4030.841 , -2380.829 , 114.4357 , "None"));
Path.Add(new Vector3(-4012.929 , -2376.482 , 117.5905 , "None"));
Path.Add(new Vector3(-4003.743 , -2400.343 , 121.3643 , "None"));
Path.Add(new Vector3(-4030.536 , -2427.007 , 136.2229 , "None"));
Path.Add(new Vector3(-4056.601 , -2450 , 149.6778 , "None"));
Path.Add(new Vector3(-4078.025 , -2466.882 , 156.7105 , "None"));
Path.Add(new Vector3(-4090.641 , -2469.007 , 157.5409 , "None"));
Path.Add(new Vector3(-4112.246 , -2465.951 , 158.189 , "None"));
Path.Add(new Vector3(-4135.732 , -2461.456 , 159.7633 , "None"));
Path.Add(new Vector3(-4180.44 , -2463.238 , 171.5828 , "None"));
Path.Add(new Vector3(-4202.201 , -2464.246 , 180.592 , "None"));
Path.Add(new Vector3(-4238.197 , -2465.216 , 193.1034 , "None"));
Path.Add(new Vector3(-4273.094 , -2463.799 , 209.8177 , "None"));
Path.Add(new Vector3(-4300.298 , -2464.274 , 213.1903 , "None"));
Path.Add(new Vector3(-4335.212 , -2464.196 , 212.2027 , "None"));
Path.Add(new Vector3(-4349.388 , -2463.201 , 212.3035 , "None"));
Path.Add(new Vector3(-4370.032 , -2462.015 , 212.4187 , "None"));
Path.Add(new Vector3(-4404.591 , -2463.628 , 212.203 , "None"));
Path.Add(new Vector3(-4424.04 , -2479.16 , 212.203 , "None"));
Path.Add(new Vector3(-4426.076 , -2494.544 , 213.3996 , "None"));
Path.Add(new Vector3(-4430.072 , -2530.354 , 219.8479 , "None"));
Path.Add(new Vector3(-4432.691 , -2548.716 , 228.1617 , "None"));
Path.Add(new Vector3(-4437.148 , -2583.36 , 239.5465 , "None"));
Path.Add(new Vector3(-4443.074 , -2618.913 , 257.6586 , "None"));
Path.Add(new Vector3(-4449.16 , -2654.428 , 266.7318 , "None"));
Path.Add(new Vector3(-4451.891 , -2687.064 , 266.6448 , "None"));
Path.Add(new Vector3(-4484.792 , -2690.562 , 266.0443 , "None"));
Path.Add(new Vector3(-4511.565 , -2692.336 , 267.9193 , "None"));
Path.Add(new Vector3(-4539.843 , -2694.319 , 275.2933 , "None"));
Path.Add(new Vector3(-4567.126 , -2694.852 , 287.3843 , "None"));
Path.Add(new Vector3(-4603.076 , -2696.337 , 298.6338 , "None"));
Path.Add(new Vector3(-4639.111 , -2697.406 , 316.9895 , "None"));
Path.Add(new Vector3(-4674.027 , -2698.369 , 320.7374 , "None"));
Path.Add(new Vector3(-4708.929 , -2699.497 , 319.0421 , "None"));
Path.Add(new Vector3(-4751.15 , -2704.57 , 325.1776 , "None"));
Path.Add(new Vector3(-4786.792 , -2709.895 , 326.3277 , "None"));
Path.Add(new Vector3(-4812.857 , -2712.34 , 327.8334 , "None"));
Path.Add(new Vector3(-4840.106 , -2713.971 , 328.8264 , "None"));
Path.Add(new Vector3(-4856.208 , -2716.967 , 329.1658 , "None"));
Path.Add(new Vector3(-4880.415 , -2723.714 , 328.8778 , "None"));
Path.Add(new Vector3(-4902.678 , -2732.827 , 328.3675 , "None"));
Path.Add(new Vector3(-4923.452 , -2739.568 , 328.0675 , "None"));
Path.Add(new Vector3(-4946.84 , -2759.277 , 326.2711 , "None"));
Path.Add(new Vector3(-4977.064 , -2778.85 , 325.6459 , "None"));
Path.Add(new Vector3(-4997.039 , -2787.156 , 325.9806 , "None"));
Path.Add(new Vector3(-5030.162 , -2801.201 , 326.7838 , "None"));
Path.Add(new Vector3(-5062.272 , -2817.552 , 327.4177 , "None"));
Path.Add(new Vector3(-5095.147 , -2829.311 , 327.2261 , "None"));
Path.Add(new Vector3(-5129.172 , -2836.848 , 330.3254 , "None"));
Path.Add(new Vector3(-5164.585 , -2843.453 , 334.2341 , "None"));
Path.Add(new Vector3(-5198.107 , -2852.687 , 335.9156 , "None"));
Path.Add(new Vector3(-5223.15 , -2865.854 , 337.5436 , "None"));
Path.Add(new Vector3(-5246.008 , -2876.258 , 338.7654 , "None"));
Path.Add(new Vector3(-5268.604 , -2883.579 , 338.9851 , "None"));
Path.Add(new Vector3(-5287.858 , -2875.748 , 338.7601 , "None"));
Path.Add(new Vector3(-5314.091 , -2876.673 , 340.4084 , "None"));
Path.Add(new Vector3(-5328.48 , -2884.339 , 341.7389 , "None"));
Path.Add(new Vector3(-5337.94 , -2864.577 , 339.1513 , "None"));
Path.Add(new Vector3(-5367.238 , -2867.454 , 340.2005 , "None"));
Path.Add(new Vector3(-5394.684 , -2883.175 , 341.9867 , "None"));
Path.Add(new Vector3(-5441.202 , -2884.455 , 346.3176 , "None"));
Path.Add(new Vector3(-5470.376 , -2875.261 , 350.8087 , "None"));
Path.Add(new Vector3(-5505.782 , -2868.502 , 356.373 , "None"));
Path.Add(new Vector3(-5538.876 , -2858.229 , 361.0154 , "None"));
Path.Add(new Vector3(-5563.247 , -2831.831 , 364.991 , "None"));
Path.Add(new Vector3(-5582.623 , -2814.665 , 366.2908 , "None"));
Path.Add(new Vector3(-5613.409 , -2798.246 , 365.9335 , "None"));
Path.Add(new Vector3(-5638.899 , -2785.839 , 364.7226 , "None"));
Path.Add(new Vector3(-5663.77 , -2774.61 , 363.3713 , "None"));
Path.Add(new Vector3(-5690.5 , -2765.003 , 362.3434 , "None"));
Path.Add(new Vector3(-5706.966 , -2738.172 , 357.248 , "None"));
Path.Add(new Vector3(-5723.41 , -2707.355 , 349.1017 , "None"));
Path.Add(new Vector3(-5737.12 , -2682.551 , 341.2954 , "None"));
Path.Add(new Vector3(-5768.002 , -2648.744 , 329.2345 , "None"));
Path.Add(new Vector3(-5792.934 , -2622.734 , 319.8813 , "None"));
Path.Add(new Vector3(-5816.078 , -2596.579 , 313.7882 , "None"));
Path.Add(new Vector3(-5842.992 , -2572.859 , 309.8934 , "None"));
Path.Add(new Vector3(-5872.632 , -2554.415 , 307.1797 , "None"));
Path.Add(new Vector3(-5902.861 , -2534.958 , 307.1097 , "None"));
Path.Add(new Vector3(-5800.449 , -2612.352 , 317.4247 , "None"));
Path.Add(new Vector3(-5782.053 , -2612.244 , 320.2697 , "None"));
Path.Add(new Vector3(-5760.633 , -2599.238 , 325.4447 , "None"));
Path.Add(new Vector3(-5745.863 , -2584.784 , 330.5866 , "None"));
Path.Add(new Vector3(-5721.22 , -2584 , 338.3162 , "None"));
Path.Add(new Vector3(-5696.382 , -2587.315 , 343.9069 , "None"));
Path.Add(new Vector3(-5668.281 , -2566.808 , 357.4394 , "None"));
Path.Add(new Vector3(-5657.539 , -2555.875 , 362.9099 , "None"));
Path.Add(new Vector3(-5643.439 , -2542.217 , 373.1445 , "None"));
Path.Add(new Vector3(-5636.225 , -2527.789 , 376.9726 , "None"));
Path.Add(new Vector3(-5618.979 , -2509.672 , 379.3511 , "None"));
Path.Add(new Vector3(-5594.645 , -2483.082 , 393.0592 , "None"));
Path.Add(new Vector3(-5574.171 , -2460.356 , 400.5268 , "None"));
Path.Add(new Vector3(-5554.418 , -2435.69 , 400.4929 , "None"));
Path.Add(new Vector3(-5549.509 , -2418.993 , 400.4926 , "None"));
Path.Add(new Vector3(-5544.842 , -2394.301 , 400.4926 , "None"));
Path.Add(new Vector3(-5550.423 , -2356.903 , 400.4923 , "None"));
Path.Add(new Vector3(-5577.292 , -2322.758 , 403.0558 , "None"));
Path.Add(new Vector3(-5584.898 , -2312.108 , 405.1363 , "None"));
Path.Add(new Vector3(-5598.134 , -2293.352 , 415.0664 , "None"));
Path.Add(new Vector3(-5619.162 , -2265.547 , 424.9648 , "None"));
Path.Add(new Vector3(-5640.951 , -2238.252 , 425.0594 , "None"));
Path.Add(new Vector3(-5638.305 , -2214.353 , 424.7543 , "None"));
Path.Add(new Vector3(-5617.359 , -2185.111 , 417.176 , "None"));
Path.Add(new Vector3(-5607.537 , -2150.509 , 407.5616 , "None"));
Path.Add(new Vector3(-5593.315 , -2118.688 , 399.8631 , "None"));
Path.Add(new Vector3(-5569.068 , -2092.363 , 400.1856 , "None"));
Path.Add(new Vector3(-5542.151 , -2070.381 , 399.746 , "None"));
Path.Add(new Vector3(-5521.332 , -2042.509 , 400.2502 , "None"));
Path.Add(new Vector3(-5510.987 , -2008.53 , 399.3756 , "None"));
Path.Add(new Vector3(-5508.08 , -1973.745 , 399.3756 , "None"));
Path.Add(new Vector3(-5511.345 , -1937.868 , 400.2876 , "None"));
Path.Add(new Vector3(-5513.902 , -1903.046 , 399.2279 , "None"));
Path.Add(new Vector3(-5514.275 , -1867.02 , 397.1642 , "None"));
Path.Add(new Vector3(-5512.352 , -1832.143 , 397.1025 , "None"));
Path.Add(new Vector3(-5511.136 , -1797.245 , 397.1856 , "None"));
Path.Add(new Vector3(-5508.73 , -1761.352 , 397.223 , "None"));
Path.Add(new Vector3(-5515.887 , -1726.39 , 397.1229 , "None"));
Path.Add(new Vector3(-5526.472 , -1692.035 , 395.3173 , "None"));
Path.Add(new Vector3(-5540.781 , -1660.17 , 391.7756 , "None"));
Path.Add(new Vector3(-5554.041 , -1626.696 , 391.7754 , "None"));
Path.Add(new Vector3(-5558.134 , -1592.277 , 394.9508 , "None"));
Path.Add(new Vector3(-5561.152 , -1557.824 , 398.7774 , "None"));
Path.Add(new Vector3(-5565.349 , -1541.997 , 400.1658 , "None"));
Path.Add(new Vector3(-5578.211 , -1523.012 , 399.3755 , "None"));
Path.Add(new Vector3(-5585.388 , -1510.748 , 401.9178 , "None"));
Path.Add(new Vector3(-5586.187 , -1483.459 , 401.928 , "None"));
Path.Add(new Vector3(-5596.487 , -1451.079 , 400.4286 , "None"));
Path.Add(new Vector3(-5622.578 , -1428.32 , 398.0315 , "None"));
Path.Add(new Vector3(-5648.701 , -1404.741 , 397.8315 , "None"));
Path.Add(new Vector3(-5649.559 , -1369.099 , 396.7798 , "None"));
Path.Add(new Vector3(-5667.575 , -1339.457 , 394.6895 , "None"));
Path.Add(new Vector3(-5674.353 , -1304.451 , 391.9298 , "None"));
Path.Add(new Vector3(-5678.292 , -1269.744 , 390.0173 , "None"));
Path.Add(new Vector3(-5681.714 , -1234.983 , 388.7803 , "None"));
Path.Add(new Vector3(-5683.881 , -1199.004 , 386.605 , "None"));
Path.Add(new Vector3(-5677.021 , -1165.355 , 385.3847 , "None"));
Path.Add(new Vector3(-5652.711 , -1139.13 , 387.1591 , "None"));
Path.Add(new Vector3(-5632.969 , -1110.698 , 390.5987 , "None"));
Path.Add(new Vector3(-5619.209 , -1077.74 , 393.159 , "None"));
Path.Add(new Vector3(-5614.737 , -1043.25 , 393.0884 , "None"));
Path.Add(new Vector3(-5595.083 , -1022.38 , 393.3133 , "None"));
Path.Add(new Vector3(-5570.384 , -1018.138 , 393.3643 , "None"));
Path.Add(new Vector3(-5539.821 , -1016.855 , 392.6761 , "None"));
Path.Add(new Vector3(-5504.176 , -1012.778 , 393.0912 , "None"));
Path.Add(new Vector3(-5472.13 , -999.6086 , 392.242 , "None"));
Path.Add(new Vector3(-5444.931 , -977.7005 , 392.2136 , "None"));
Path.Add(new Vector3(-5420.189 , -953.2113 , 392.2136 , "None"));
Path.Add(new Vector3(-5400.967 , -921.4184 , 392.1936 , "None"));
Path.Add(new Vector3(-5386.253 , -889.772 , 392.1953 , "None"));
Path.Add(new Vector3(-5388.318 , -854.4445 , 391.9949 , "None"));
Path.Add(new Vector3(-5402.683 , -821.5402 , 392.3912 , "None"));
Path.Add(new Vector3(-5423.307 , -793.3582 , 392.7775 , "None"));
Path.Add(new Vector3(-5436.043 , -761.1489 , 394.1675 , "None"));
Path.Add(new Vector3(-5435.013 , -725.6592 , 393.6902 , "None"));
Path.Add(new Vector3(-5419.743 , -694.2865 , 393.4761 , "None"));
Path.Add(new Vector3(-5403.023 , -662.3522 , 392.6936 , "None"));
Path.Add(new Vector3(-5388.624 , -630.5312 , 391.7502 , "None"));
Path.Add(new Vector3(-5375.825 , -596.874 , 391.4503 , "None"));
Path.Add(new Vector3(-5358.59 , -565.2687 , 391.4937 , "None"));
Path.Add(new Vector3(-5342.984 , -534.0994 , 392.5616 , "None"));
Path.Add(new Vector3(-5334.57 , -518.9087 , 391.4937 , "None"));
Path.Add(new Vector3(-5318.568 , -503.1606 , 388.3587 , "None"));
Path.Add(new Vector3(-5290.957 , -498.1934 , 391.2328 , "None"));
Path.Add(new Vector3(-5276.853 , -497.2115 , 388.592 , "None"));
Path.Add(new Vector3(-5262.696 , -504.5405 , 386.2198 , "None"));
Path.Add(new Vector3(-5247.48 , -518.5673 , 386.6531 , "None"));
Path.Add(new Vector3(-5243.604 , -538.8639 , 393.2827 , "None"));
Path.Add(new Vector3(-5241.636 , -573.6573 , 405.8595 , "None"));
Path.Add(new Vector3(-5235.458 , -609.0159 , 416.3018 , "None"));
Path.Add(new Vector3(-5225.784 , -642.5792 , 424.076 , "None"));
Path.Add(new Vector3(-5215.116 , -675.834 , 432.3226 , "None"));
Path.Add(new Vector3(-5201.707 , -709.2562 , 440.5353 , "None"));
Path.Add(new Vector3(-5177.613 , -735.3854 , 448.1102 , "None"));
Path.Add(new Vector3(-5143.208 , -736.8205 , 456.803 , "None"));
Path.Add(new Vector3(-5107.344 , -740.3472 , 465.992 , "None"));
Path.Add(new Vector3(-5072.639 , -744.2352 , 475.9798 , "None"));
Path.Add(new Vector3(-5047.553 , -766.2704 , 490.5826 , "None"));
Path.Add(new Vector3(-5046.175 , -785.702 , 495.0931 , "None"));
Path.Add(new Vector3(-5039.204 , -804.5174 , 495.1312 , "None"));
Path.Add(new Vector3(-5020.663 , -833.2606 , 496.9855 , "None"));
Path.Add(new Vector3(-5005.488 , -853.0358 , 497.0719 , "None"));
Path.Add(new Vector3(-4990.407 , -870.2549 , 496.9845 , "None"));
Path.Add(new Vector3(-4974 , -892.0536 , 501.5964 , "None"));
Path.Add(new Vector3(-4965.155 , -878.3148 , 501.6534 , "None"));
Path.Add(new Vector3(-4942.528 , -870.4431 , 501.6619 , "None"));
Path.Add(new Vector3(-4927.354 , -859.8141 , 501.6619 , "None"));
Path.Add(new Vector3(-4911.991 , -872.0648 , 501.6605 , "None"));
Path.Add(new Vector3(-4904.163 , -885.2436 , 501.6605 , "None"));
Path.Add(new Vector3(-4896.039 , -904.3789 , 502.8313 , "None"));
Path.Add(new Vector3(-4887.604 , -925.7335 , 501.6051 , "None"));
Path.Add(new Vector3(-4882.723 , -935.5018 , 501.4553 , "None"));
Path.Add(new Vector3(-4869.652 , -940.8344 , 501.4413 , "None"));
Path.Add(new Vector3(-4852.579 , -944.0259 , 501.4543 , "None"));
Path.Add(new Vector3(-4842.354 , -956.5652 , 501.6445 , "None"));
Path.Add(new Vector3(-4840.622 , -965.8951 , 501.7318 , "None"));
Path.Add(new Vector3(-4837.553 , -976.2645 , 501.8296 , "None"));
Path.Add(new Vector3(-4834.837 , -986.3851 , 501.9247 , "None"));
Path.Add(new Vector3(-4832.063 , -996.8381 , 502.0272 , "None"));
Path.Add(new Vector3(-4829.375 , -1006.966 , 502.1227 , "None"));
Path.Add(new Vector3(-4826.45 , -1017.366 , 502.2077 , "None"));
Path.Add(new Vector3(-4822.456 , -1027.045 , 502.1869 , "None"));
Path.Add(new Vector3(-4817.254 , -1036.136 , 502.1921 , "None"));
Path.Add(new Vector3(-4812.254 , -1045.672 , 502.1907 , "None"));
Path.Add(new Vector3(-4810.859 , -1056.345 , 502.1999 , "None"));
Path.Add(new Vector3(-4812.464 , -1066.628 , 502.2005 , "None"));
Path.Add(new Vector3(-4817.91 , -1075.429 , 502.2077 , "None"));
Path.Add(new Vector3(-4826.777 , -1081.612 , 502.2063 , "None"));
Path.Add(new Vector3(-4835.837 , -1086.853 , 502.196 , "None"));
Path.Add(new Vector3(-4846.127 , -1090.181 , 502.2014 , "None"));
Path.Add(new Vector3(-4856.141 , -1093.266 , 502.2063 , "None"));
Path.Add(new Vector3(-4866.527 , -1096.28 , 502.2113 , "None"));
Path.Add(new Vector3(-4873.762 , -1103.552 , 502.2116 , "None"));
Path.Add(new Vector3(-4873.03 , -1113.78 , 502.2116 , "None"));
Path.Add(new Vector3(-4867.595 , -1123.12 , 502.2116 , "None"));
Path.Add(new Vector3(-4861.929 , -1131.931 , 502.1824 , "None"));
Path.Add(new Vector3(-4855.008 , -1139.787 , 502.1911 , "None"));
Path.Add(new Vector3(-4847.28 , -1147.352 , 502.2072 , "None"));
Path.Add(new Vector3(-4839.493 , -1154.345 , 502.2058 , "None"));
Path.Add(new Vector3(-4830.382 , -1160.164 , 502.2073 , "None"));
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


public sealed class PARHDarkshiretoSTVNORTHCamp : QuestFollowPathClass
{
    public PARHDarkshiretoSTVNORTHCamp()
    {
        Name = "PARH : Darkshire to STV (NORTH Camp)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 35;
        RequiredQuest = 0;

        Path.Add(new Vector3(-10583.91 , -1178.143 , 28.44839 , "None"));
Path.Add(new Vector3(-10601.18 , -1180.946 , 27.96066 , "None"));
Path.Add(new Vector3(-10635.4 , -1187.923 , 28.83606 , "None"));
Path.Add(new Vector3(-10649.42 , -1190.231 , 28.57633 , "None"));
Path.Add(new Vector3(-10682.89 , -1187.526 , 27.42173 , "None"));
Path.Add(new Vector3(-10715.8 , -1172.993 , 26.54035 , "None"));
Path.Add(new Vector3(-10744.41 , -1153.012 , 26.38534 , "None"));
Path.Add(new Vector3(-10769.84 , -1127.588 , 28.08004 , "None"));
Path.Add(new Vector3(-10784.81 , -1096.385 , 33.51551 , "None"));
Path.Add(new Vector3(-10792.41 , -1061.163 , 40.68903 , "None"));
Path.Add(new Vector3(-10802.05 , -1027.592 , 47.4211 , "None"));
Path.Add(new Vector3(-10805.31 , -991.8127 , 53.80577 , "None"));
Path.Add(new Vector3(-10802.43 , -956.0872 , 56.45813 , "None"));
Path.Add(new Vector3(-10795.64 , -922.0419 , 55.73671 , "None"));
Path.Add(new Vector3(-10802.56 , -888.0428 , 55.71462 , "None"));
Path.Add(new Vector3(-10816.35 , -854.738 , 55.82371 , "None"));
Path.Add(new Vector3(-10826.33 , -836.6232 , 55.84351 , "None"));
Path.Add(new Vector3(-10837.05 , -815.1409 , 56.18527 , "None"));
Path.Add(new Vector3(-10854.47 , -785.0334 , 56.33673 , "None"));
Path.Add(new Vector3(-10878.07 , -757.7935 , 55.55941 , "None"));
Path.Add(new Vector3(-10901.72 , -732.1036 , 55.07052 , "None"));
Path.Add(new Vector3(-10920.09 , -701.2106 , 55.73846 , "None"));
Path.Add(new Vector3(-10938.16 , -671.371 , 55.6455 , "None"));
Path.Add(new Vector3(-10957.79 , -641.2305 , 55.19657 , "None"));
Path.Add(new Vector3(-10957.96 , -620.0659 , 55.08871 , "None"));
Path.Add(new Vector3(-10947.55 , -595.0386 , 55.09362 , "None"));
Path.Add(new Vector3(-10928.89 , -565.524 , 54.11486 , "None"));
Path.Add(new Vector3(-10915.97 , -531.934 , 53.85493 , "None"));
Path.Add(new Vector3(-10908.71 , -497.8805 , 51.05385 , "None"));
Path.Add(new Vector3(-10908.49 , -461.8352 , 46.70074 , "None"));
Path.Add(new Vector3(-10908.4 , -426.9068 , 42.35398 , "None"));
Path.Add(new Vector3(-10906.91 , -390.8934 , 40.89841 , "None"));
Path.Add(new Vector3(-10923.01 , -361.8365 , 39.45936 , "None"));
Path.Add(new Vector3(-10933.39 , -355.7783 , 39.47956 , "None"));
Path.Add(new Vector3(-10966.99 , -359.249 , 40.67241 , "None"));
Path.Add(new Vector3(-10998.57 , -360.2279 , 42.71162 , "None"));
Path.Add(new Vector3(-11019.3 , -359.6453 , 43.89106 , "None"));
Path.Add(new Vector3(-11045.74 , -365.1671 , 45.02704 , "None"));
Path.Add(new Vector3(-11079.73 , -371.9431 , 44.47141 , "None"));
Path.Add(new Vector3(-11115.67 , -374.6551 , 45.24316 , "None"));
Path.Add(new Vector3(-11150.42 , -377.6255 , 46.64082 , "None"));
Path.Add(new Vector3(-11186.26 , -381.398 , 47.7578 , "None"));
Path.Add(new Vector3(-11220.94 , -377.9439 , 51.79958 , "None"));
Path.Add(new Vector3(-11256.48 , -372.2685 , 58.85833 , "None"));
Path.Add(new Vector3(-11291.22 , -370.3721 , 64.14296 , "None"));
Path.Add(new Vector3(-11314.72 , -371.2103 , 65.40316 , "None"));
Path.Add(new Vector3(-11347.52 , -382.7592 , 65.47609 , "None"));
Path.Add(new Vector3(-11358.46 , -378.3468 , 65.05756 , "None"));
Path.Add(new Vector3(-11368.88 , -356.7979 , 65.60137 , "None"));
Path.Add(new Vector3(-11375.25 , -334.8135 , 65.3727 , "None"));
Path.Add(new Vector3(-11382.54 , -318.9486 , 65.1599 , "None"));
Path.Add(new Vector3(-11386.91 , -293.0677 , 60.7322 , "None"));
Path.Add(new Vector3(-11387.47 , -277.8088 , 59.87703 , "None"));
Path.Add(new Vector3(-11386.61 , -266.2881 , 60.85256 , "None"));
Path.Add(new Vector3(-11385.58 , -255.523 , 63.07967 , "None"));
Path.Add(new Vector3(-11384.94 , -246.3928 , 66.15117 , "None"));
Path.Add(new Vector3(-11382.81 , -235.791 , 69.4306 , "None"));
Path.Add(new Vector3(-11380.42 , -225.6044 , 73.81086 , "None"));
Path.Add(new Vector3(-11375.85 , -215.9406 , 75.2726 , "None"));
Path.Add(new Vector3(-11367.6 , -210.0111 , 75.32149 , "None"));
Path.Add(new Vector3(-11356.88 , -209.3912 , 75.27731 , "None"));
Path.Add(new Vector3(-11346.44 , -210.3413 , 75.22614 , "None"));
Path.Add(new Vector3(-11335.91 , -208.5699 , 75.26112 , "None"));
Path.Add(new Vector3(-11325.73 , -203.3495 , 75.48285 , "None"));
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


public sealed class KrazeksCookery : QuestGrinderClass
{
    public KrazeksCookery()
    {
        Name = "Krazek's Cookery";

        QuestId.AddRange(new[] { 210 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 35;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PATHNorthSTVtoBootyBay : QuestFollowPathClass
{
    public PATHNorthSTVtoBootyBay()
    {
        Name = "PATH : North STV to Booty Bay";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 35;
        RequiredQuest = 0;

        Path.Add(new Vector3(-11405.58 , -286.0447 , 56.44155 , "None"));
Path.Add(new Vector3(-11430.73 , -287.4585 , 49.23116 , "None"));
Path.Add(new Vector3(-11452.52 , -288.6901 , 42.35538 , "None"));
Path.Add(new Vector3(-11475.24 , -292.0025 , 36.4169 , "None"));
Path.Add(new Vector3(-11485.46 , -300.2741 , 35.95323 , "None"));
Path.Add(new Vector3(-11497.12 , -308.4038 , 35.73363 , "None"));
Path.Add(new Vector3(-11509.89 , -314.6237 , 35.92599 , "None"));
Path.Add(new Vector3(-11545.37 , -315.8641 , 36.30771 , "None"));
Path.Add(new Vector3(-11574.68 , -299.013 , 35.66576 , "None"));
Path.Add(new Vector3(-11603.61 , -279.4609 , 37.19513 , "None"));
Path.Add(new Vector3(-11635.02 , -260.023 , 32.43098 , "None"));
Path.Add(new Vector3(-11666.09 , -241.7561 , 32.76022 , "None"));
Path.Add(new Vector3(-11694.82 , -223.941 , 39.55522 , "None"));
Path.Add(new Vector3(-11721.44 , -201.3955 , 39.55522 , "None"));
Path.Add(new Vector3(-11731.48 , -182.2362 , 39.55522 , "None"));
Path.Add(new Vector3(-11740.98 , -167.8978 , 42.2953 , "None"));
Path.Add(new Vector3(-11756.79 , -139.2051 , 31.74349 , "None"));
Path.Add(new Vector3(-11774.53 , -106.543 , 41.9614 , "None"));
Path.Add(new Vector3(-11792.63 , -75.37236 , 39.77594 , "None"));
Path.Add(new Vector3(-11816.86 , -53.43437 , 39.71347 , "None"));
Path.Add(new Vector3(-11839.44 , -49.52605 , 39.72821 , "None"));
Path.Add(new Vector3(-11873.56 , -46.04403 , 39.72647 , "None"));
Path.Add(new Vector3(-11907.38 , -54.64234 , 39.72678 , "None"));
Path.Add(new Vector3(-11923.97 , -62.47486 , 39.72692 , "None"));
Path.Add(new Vector3(-11950.24 , -80.61731 , 33.91223 , "None"));
Path.Add(new Vector3(-11980.84 , -99.65994 , 34.12906 , "None"));
Path.Add(new Vector3(-12004.27 , -115.7304 , 40.58519 , "None"));
Path.Add(new Vector3(-12026.87 , -126.4681 , 39.63014 , "None"));
Path.Add(new Vector3(-12064.73 , -123.3532 , 39.18105 , "None"));
Path.Add(new Vector3(-12086.26 , -137.8135 , 35.89199 , "None"));
Path.Add(new Vector3(-12100.12 , -154.6867 , 33.01411 , "None"));
Path.Add(new Vector3(-12122.57 , -184.103 , 30.34782 , "None"));
Path.Add(new Vector3(-12141.19 , -213.6496 , 30.3484 , "None"));
Path.Add(new Vector3(-12158.15 , -244.1358 , 30.3484 , "None"));
Path.Add(new Vector3(-12169.01 , -267.9677 , 30.3484 , "None"));
Path.Add(new Vector3(-12175.61 , -292.1866 , 30.34828 , "None"));
Path.Add(new Vector3(-12174.76 , -312.6523 , 32.3591 , "None"));
Path.Add(new Vector3(-12172.79 , -324.494 , 26.62617 , "None"));
Path.Add(new Vector3(-12166.86 , -354.5027 , 21.75858 , "None"));
Path.Add(new Vector3(-12159.15 , -389.6919 , 32.01754 , "None"));
Path.Add(new Vector3(-12158.23 , -425.2362 , 30.34776 , "None"));
Path.Add(new Vector3(-12173.33 , -455.3905 , 29.50211 , "None"));
Path.Add(new Vector3(-12192.76 , -487.0773 , 29.32205 , "None"));
Path.Add(new Vector3(-12210.65 , -517.0809 , 28.78081 , "None"));
Path.Add(new Vector3(-12221.79 , -535.8641 , 28.89303 , "None"));
Path.Add(new Vector3(-12246.56 , -559.4028 , 28.74767 , "None"));
Path.Add(new Vector3(-12277.75 , -577.4331 , 28.74052 , "None"));
Path.Add(new Vector3(-12313.18 , -583.4028 , 26.56348 , "None"));
Path.Add(new Vector3(-12349.04 , -585.8102 , 20.70183 , "None"));
Path.Add(new Vector3(-12383.21 , -578.7807 , 14.87836 , "None"));
Path.Add(new Vector3(-12417.12 , -570.6064 , 10.46535 , "None"));
Path.Add(new Vector3(-12432.33 , -550.5564 , 10.12339 , "None"));
Path.Add(new Vector3(-12440.71 , -515.5265 , 10.11317 , "None"));
Path.Add(new Vector3(-12447.01 , -482.3086 , 10.14026 , "None"));
Path.Add(new Vector3(-12458.24 , -447.0249 , 10.31272 , "None"));
Path.Add(new Vector3(-12475.27 , -417.8437 , 10.59151 , "None"));
Path.Add(new Vector3(-12504.33 , -397.6844 , 10.91083 , "None"));
Path.Add(new Vector3(-12539.73 , -390.883 , 11.50626 , "None"));
Path.Add(new Vector3(-12575.39 , -385.8311 , 11.08263 , "None"));
Path.Add(new Vector3(-12609.57 , -378.6081 , 10.09911 , "None"));
Path.Add(new Vector3(-12645.41 , -375.2804 , 10.12251 , "None"));
Path.Add(new Vector3(-12680.32 , -376.4019 , 10.11227 , "None"));
Path.Add(new Vector3(-12715.24 , -376.4788 , 10.0999 , "None"));
Path.Add(new Vector3(-12751.27 , -375.4518 , 10.10948 , "None"));
Path.Add(new Vector3(-12782.45 , -362.19 , 10.10743 , "None"));
Path.Add(new Vector3(-12804.79 , -333.9119 , 10.18069 , "None"));
Path.Add(new Vector3(-12826.63 , -305.2612 , 10.21763 , "None"));
Path.Add(new Vector3(-12854.21 , -284.063 , 6.684861 , "None"));
Path.Add(new Vector3(-12882.65 , -265.7332 , 3.513474 , "None"));
Path.Add(new Vector3(-12916.49 , -251.0697 , -3.548242 , "None"));
Path.Add(new Vector3(-12949.31 , -239.1105 , -9.063102 , "None"));
Path.Add(new Vector3(-12982.51 , -228.2768 , -10.44953 , "None"));
Path.Add(new Vector3(-13014.48 , -217.0694 , -12.04076 , "None"));
Path.Add(new Vector3(-13050.21 , -207.0834 , -9.334959 , "None"));
Path.Add(new Vector3(-13086.08 , -197.4364 , -9.251365 , "None"));
Path.Add(new Vector3(-13118.86 , -188.8846 , -5.671909 , "None"));
Path.Add(new Vector3(-13154.04 , -181.3794 , 0.009002852 , "None"));
Path.Add(new Vector3(-13188.64 , -171.4858 , 8.77348 , "None"));
Path.Add(new Vector3(-13210.56 , -160.1136 , 13.40844 , "None"));
Path.Add(new Vector3(-13225.07 , -146.8331 , 15.57248 , "None"));
Path.Add(new Vector3(-13246.05 , -120.1105 , 18.90591 , "None"));
Path.Add(new Vector3(-13244.39 , -85.73689 , 19.75394 , "None"));
Path.Add(new Vector3(-13247.13 , -49.99249 , 19.81256 , "None"));
Path.Add(new Vector3(-13248.57 , -15.10324 , 19.81151 , "None"));
Path.Add(new Vector3(-13265.86 , 15.36642 , 19.6223 , "None"));
Path.Add(new Vector3(-13292.64 , 37.54462 , 19.69418 , "None"));
Path.Add(new Vector3(-13316.84 , 62.72914 , 22.10623 , "None"));
Path.Add(new Vector3(-13346.31 , 80.14632 , 23.60481 , "None"));
Path.Add(new Vector3(-13381 , 84.78609 , 24.0155 , "None"));
Path.Add(new Vector3(-13417.78 , 89.44743 , 25.43212 , "None"));
Path.Add(new Vector3(-13452.7 , 88.87333 , 26.62782 , "None"));
Path.Add(new Vector3(-13486.56 , 87.86066 , 28.74238 , "None"));
Path.Add(new Vector3(-13524.77 , 86.82681 , 28.59021 , "None"));
Path.Add(new Vector3(-13559.7 , 87.00944 , 28.6876 , "None"));
Path.Add(new Vector3(-13594.63 , 87.34549 , 27.58329 , "None"));
Path.Add(new Vector3(-13628.98 , 91.77986 , 25.38865 , "None"));
Path.Add(new Vector3(-13660.67 , 108.8937 , 22.83544 , "None"));
Path.Add(new Vector3(-13692.54 , 123.1185 , 22.54068 , "None"));
Path.Add(new Vector3(-13726.06 , 136.1345 , 23.15956 , "None"));
Path.Add(new Vector3(-13749.91 , 159.2455 , 22.90955 , "None"));
Path.Add(new Vector3(-13773.51 , 189.244 , 22.47262 , "None"));
Path.Add(new Vector3(-13798.91 , 213.1914 , 19.83727 , "None"));
Path.Add(new Vector3(-13825.4 , 234.2254 , 18.78116 , "None"));
Path.Add(new Vector3(-13859.54 , 248.5435 , 18.30417 , "None"));
Path.Add(new Vector3(-13892.72 , 259.4731 , 17.25645 , "None"));
Path.Add(new Vector3(-13923.76 , 272.8096 , 18.09803 , "None"));
Path.Add(new Vector3(-13955.82 , 282.7595 , 18.60742 , "None"));
Path.Add(new Vector3(-13991.64 , 279.4357 , 18.56291 , "None"));
Path.Add(new Vector3(-14028.25 , 273.0187 , 18.63123 , "None"));
Path.Add(new Vector3(-14062.58 , 266.5584 , 18.26858 , "None"));
Path.Add(new Vector3(-14098.01 , 259.8989 , 16.611 , "None"));
Path.Add(new Vector3(-14132.36 , 253.566 , 14.89552 , "None"));
Path.Add(new Vector3(-14167.81 , 247.03 , 15.52295 , "None"));
Path.Add(new Vector3(-14202.34 , 246.1488 , 17.31528 , "None"));
Path.Add(new Vector3(-14233.99 , 259.524 , 24.26434 , "None"));
Path.Add(new Vector3(-14240.49 , 279.964 , 26.83305 , "None"));
Path.Add(new Vector3(-14247.08 , 313.8762 , 26.06094 , "None"));
Path.Add(new Vector3(-14248.18 , 325.7951 , 24.78919 , "None"));
Path.Add(new Vector3(-14254.57 , 336.116 , 26.76029 , "None"));
Path.Add(new Vector3(-14267.86 , 348.2647 , 31.65461 , "None"));
Path.Add(new Vector3(-14279.73 , 365.3688 , 33.54664 , "None"));
Path.Add(new Vector3(-14279.94 , 375.5083 , 34.71657 , "None"));
Path.Add(new Vector3(-14277.97 , 392.7283 , 36.6201 , "None"));
Path.Add(new Vector3(-14275.33 , 403.2073 , 37.06929 , "None"));
Path.Add(new Vector3(-14274.18 , 413.7663 , 37.15857 , "None"));
Path.Add(new Vector3(-14277.67 , 423.1518 , 35.83433 , "None"));
Path.Add(new Vector3(-14285.6 , 429.4463 , 33.91955 , "None"));
Path.Add(new Vector3(-14295.71 , 434.8187 , 32.00638 , "None"));
Path.Add(new Vector3(-14305.46 , 438.6521 , 27.84095 , "None"));
Path.Add(new Vector3(-14315.36 , 442.9004 , 23.1871 , "None"));
Path.Add(new Vector3(-14322.31 , 450.4095 , 23.19904 , "None"));
Path.Add(new Vector3(-14320.46 , 460.8154 , 21.48784 , "None"));
Path.Add(new Vector3(-14316.3 , 470.4127 , 18.4257 , "None"));
Path.Add(new Vector3(-14312.83 , 480.6485 , 15.9088 , "None"));
Path.Add(new Vector3(-14308.93 , 490.3779 , 12.72093 , "None"));
Path.Add(new Vector3(-14304.92 , 500.0569 , 10.33076 , "None"));
Path.Add(new Vector3(-14302.04 , 510.2995 , 8.704273 , "None"));
Path.Add(new Vector3(-14311.81 , 499.5075 , 8.603376 , "None"));
Path.Add(new Vector3(-14315.37 , 489.6568 , 8.583343 , "None"));
Path.Add(new Vector3(-14319.97 , 479.8859 , 8.563999 , "None"));
Path.Add(new Vector3(-14324.75 , 470.5598 , 8.342305 , "None"));
Path.Add(new Vector3(-14329.94 , 461.1235 , 7.991492 , "None"));
Path.Add(new Vector3(-14336.21 , 453.1506 , 7.722091 , "None"));
Path.Add(new Vector3(-14343.02 , 445.1819 , 7.485332 , "None"));
Path.Add(new Vector3(-14351.81 , 438.3897 , 7.400746 , "None"));
Path.Add(new Vector3(-14361.14 , 433.636 , 7.356438 , "None"));
Path.Add(new Vector3(-14371.26 , 429.8333 , 7.350917 , "None"));
Path.Add(new Vector3(-14381.2 , 426.5254 , 7.363855 , "None"));
Path.Add(new Vector3(-14391.21 , 423.4257 , 7.449101 , "None"));
Path.Add(new Vector3(-14402.19 , 422.0927 , 8.258654 , "None"));
Path.Add(new Vector3(-14411.26 , 426.9557 , 8.848573 , "None"));
Path.Add(new Vector3(-14417.62 , 435.2551 , 9.149284 , "None"));
Path.Add(new Vector3(-14423.83 , 444.095 , 12.56431 , "None"));
Path.Add(new Vector3(-14431.6 , 451.039 , 15.40186 , "None"));
Path.Add(new Vector3(-14440.71 , 456.8449 , 15.37231 , "None"));
Path.Add(new Vector3(-14444.05 , 465.6989 , 15.36042 , "None"));
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


public sealed class SingingBlueShards : QuestGrinderClass
{
    public SingingBlueShards()
    {
        Name = "Singing Blue Shards";

        QuestId.AddRange(new[] { 605 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 35;
        RequiredQuest = 0;

        EntryTarget.Add(689);
HotSpots.Add(new Vector3(-11515.91 , -854.8694 , 68.7329 , "None"));
HotSpots.Add(new Vector3(-11594.04 , -887.9078 , 68.47533 , "None"));
HotSpots.Add(new Vector3(-11417.13 , -799.7109 , 90.73179 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SuppliestoPrivateThorsen : QuestGrinderClass
{
    public SuppliestoPrivateThorsen()
    {
        Name = "Supplies to Private Thorsen";

        QuestId.AddRange(new[] { 198 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 35;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class InvestigatetheCamp : QuestGrinderClass
{
    public InvestigatetheCamp()
    {
        Name = "Investigate the Camp";

        QuestId.AddRange(new[] { 201 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 35;
        RequiredQuest = 0;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheHauntedIsle : QuestClass
{
    public TheHauntedIsle()
    {
        Name = "The Haunted Isle";

        QuestId.AddRange(new[] { 616 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 35;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HostileTakeover : QuestGrinderClass
{
    public HostileTakeover()
    {
        Name = "Hostile Takeover";

        QuestId.AddRange(new[] { 213 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 35;
        RequiredQuest = 0;

        EntryTarget.Add(1096);
HotSpots.Add(new Vector3(-12175.96 , -656.4312 , 14.43121 , "None"));
HotSpots.Add(new Vector3(-12118.36 , -555.2866 , 12.31605 , "None"));
HotSpots.Add(new Vector3(-11970.54 , -725.3891 , 17.0553 , "None"));
HotSpots.Add(new Vector3(-11839.23 , -608.4252 , 14.22067 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BloodscalpEars : QuestGrinderClass
{
    public BloodscalpEars()
    {
        Name = "Bloodscalp Ears";

        QuestId.AddRange(new[] { 189 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 35;
        RequiredQuest = 0;

        EntryTarget.Add(660);
EntryTarget.Add(671);
EntryTarget.Add(597);
HotSpots.Add(new Vector3(-11823.76 , 889.2025 , 4.063289 , "None"));
HotSpots.Add(new Vector3(-11710.36 , 984.4187 , 2.752979 , "None"));
HotSpots.Add(new Vector3(-11737.52 , 862.2922 , 1.33911 , "None"));
HotSpots.Add(new Vector3(-11647.1 , 857.8299 , 0.3198345 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheStoneoftheTides : QuestGrinderClass
{
    public TheStoneoftheTides()
    {
        Name = "The Stone of the Tides";

        QuestId.AddRange(new[] { 578 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 35;
        RequiredQuest = 616;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PATHInvestigatetheCamp : QuestFollowPathClass
{
    public PATHInvestigatetheCamp()
    {
        Name = "PATH : Investigate the Camp";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 36;
        RequiredQuest = 0;

        Path.Add(new Vector3(-11670.13 , -124.4607 , 16.57803 , "None"));
Path.Add(new Vector3(-11656.13 , -102.2703 , 15.7682 , "None"));
Path.Add(new Vector3(-11634.77 , -74.64166 , 12.65326 , "None"));
Path.Add(new Vector3(-11625.21 , -61.69814 , 10.94197 , "None"));
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


public sealed class PATHStoneofTides : QuestFollowPathClass
{
    public PATHStoneofTides()
    {
        Name = "PATH : Stone of Tides";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 36;
        RequiredQuest = 0;

        Path.Add(new Vector3(-11622.81 , -20.4604 , 11.04418 , "None"));
Path.Add(new Vector3(-11623.56 , -2.331146 , 12.70014 , "None"));
Path.Add(new Vector3(-11631.93 , 7.729546 , 15.72329 , "None"));
Path.Add(new Vector3(-11650.92 , 25.66391 , 18.17809 , "None"));
Path.Add(new Vector3(-11676.76 , 47.20117 , 16.57911 , "None"));
Path.Add(new Vector3(-11685.64 , 70.65342 , 17.92032 , "None"));
Path.Add(new Vector3(-11700.95 , 100.7047 , 16.82911 , "None"));
Path.Add(new Vector3(-11719.38 , 130.4532 , 16.04193 , "None"));
Path.Add(new Vector3(-11739.65 , 162.8531 , 17.73689 , "None"));
Path.Add(new Vector3(-11751.04 , 177.285 , 17.23874 , "None"));
Path.Add(new Vector3(-11771.27 , 206.4183 , 17.75988 , "None"));
Path.Add(new Vector3(-11787.79 , 234.5459 , 16.7625 , "None"));
Path.Add(new Vector3(-11808.58 , 253.83 , 14.28897 , "None"));
Path.Add(new Vector3(-11835.81 , 279.0827 , 13.21492 , "None"));
Path.Add(new Vector3(-11865.02 , 297.9545 , 15.75315 , "None"));
Path.Add(new Vector3(-11884.2 , 305.7461 , 15.85 , "None"));
Path.Add(new Vector3(-11900.94 , 310.8437 , 10.91149 , "None"));
Path.Add(new Vector3(-11924.13 , 341.24 , 3.983667 , "None"));
Path.Add(new Vector3(-11950.31 , 367.4269 , 2.638546 , "None"));
Path.Add(new Vector3(-11961.21 , 376.5392 , 3.465927 , "None"));
Path.Add(new Vector3(-11971.04 , 385.1786 , 2.960268 , "None"));
Path.Add(new Vector3(-11981.45 , 412.4415 , 1.981169 , "None"));
Path.Add(new Vector3(-11989.06 , 438.6552 , 2.735099 , "None"));
Path.Add(new Vector3(-11998.7 , 464.1569 , 7.043727 , "None"));
Path.Add(new Vector3(-12010.61 , 468.1781 , 10.11179 , "None"));
Path.Add(new Vector3(-12015.83 , 484.1984 , 4.805674 , "None"));
Path.Add(new Vector3(-12015.85 , 497.1826 , 1.210333 , "None"));
Path.Add(new Vector3(-12010.01 , 507.7996 , 0.3126495 , "None"));
Path.Add(new Vector3(-12003.46 , 519.1033 , 0.04252882 , "None"));
Path.Add(new Vector3(-12004.3 , 545.3385 , -0.03639886 , "None"));
Path.Add(new Vector3(-12010.65 , 577.0907 , 0.6945769 , "None"));
Path.Add(new Vector3(-12016.08 , 592.5244 , 0.2579954 , "None"));
Path.Add(new Vector3(-12022.66 , 617.1675 , -0.8932042 , "Swimming"));
Path.Add(new Vector3(-12029.09 , 630.0361 , -0.8932042 , "Swimming"));
Path.Add(new Vector3(-12035.3 , 642.8008 , -0.8932042 , "Swimming"));
Path.Add(new Vector3(-12040.32 , 653.7927 , -0.8932042 , "Swimming"));
Path.Add(new Vector3(-12046.29 , 666.8591 , -0.8932042 , "Swimming"));
Path.Add(new Vector3(-12052.23 , 679.8568 , -0.8932042 , "Swimming"));
Path.Add(new Vector3(-12057.25 , 690.8485 , -0.8932042 , "Swimming"));
Path.Add(new Vector3(-12063.18 , 703.8463 , -0.8932042 , "Swimming"));
Path.Add(new Vector3(-12069.15 , 716.9127 , -0.8932042 , "Swimming"));
Path.Add(new Vector3(-12075.12 , 729.9791 , -0.8932042 , "Swimming"));
Path.Add(new Vector3(-12080.11 , 740.9021 , -0.8932042 , "Swimming"));
Path.Add(new Vector3(-12086.11 , 754.0373 , -0.8932042 , "Swimming"));
Path.Add(new Vector3(-12092.05 , 767.035 , -0.8932042 , "Swimming"));
Path.Add(new Vector3(-12097.04 , 777.958 , -0.8932042 , "Swimming"));
Path.Add(new Vector3(-12101.34 , 789.347 , -0.96656 , "Swimming"));
Path.Add(new Vector3(-12094.86 , 802.8762 , -0.404615 , "None"));
Path.Add(new Vector3(-12087.27 , 823.0422 , 0.4795276 , "None"));
Path.Add(new Vector3(-12082.61 , 843.7703 , -0.04861607 , "None"));
Path.Add(new Vector3(-12083.99 , 864.9598 , -0.04140184 , "None"));
Path.Add(new Vector3(-12079.7 , 885.3569 , -0.03757869 , "None"));
Path.Add(new Vector3(-12070.73 , 896.0437 , 0.08985163 , "None"));
Path.Add(new Vector3(-12085.78 , 889.2579 , 1.341734 , "None"));
Path.Add(new Vector3(-12087.91 , 895.5045 , 2.098463 , "None"));
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


public sealed class PATHScalpstoBooty : QuestFollowPathClass
{
    public PATHScalpstoBooty()
    {
        Name = "PATH : Scalps to Booty";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 35;
        RequiredQuest = 0;

        Path.Add(new Vector3(-11942.94 , 726.8757 , 0.5002409 , "None"));
Path.Add(new Vector3(-11957.26 , 705.2679 , 0.1677088 , "None"));
Path.Add(new Vector3(-11963.15 , 694.7682 , 0.323526 , "None"));
Path.Add(new Vector3(-11967.95 , 669.0333 , -0.03620297 , "None"));
Path.Add(new Vector3(-11971.56 , 649.768 , -0.07365437 , "None"));
Path.Add(new Vector3(-11982.78 , 630.7801 , 0.5268404 , "None"));
Path.Add(new Vector3(-12006.95 , 629.2612 , -0.002422184 , "None"));
Path.Add(new Vector3(-12015.09 , 617.636 , 0.4103203 , "None"));
Path.Add(new Vector3(-12015.83 , 605.6204 , 1.280512 , "None"));
Path.Add(new Vector3(-12016.98 , 581.5678 , -0.05131327 , "None"));
Path.Add(new Vector3(-12022.29 , 569.6177 , -0.9193179 , "Swimming"));
Path.Add(new Vector3(-12027.54 , 548.4409 , -0.8441155 , "Swimming"));
Path.Add(new Vector3(-12031.9 , 537.1931 , -0.8441155 , "Swimming"));
Path.Add(new Vector3(-12035.86 , 525.7461 , -0.8441155 , "Swimming"));
Path.Add(new Vector3(-12054.17 , 510.6066 , -0.8441155 , "Swimming"));
Path.Add(new Vector3(-12071.92 , 495.1544 , -0.8441155 , "Swimming"));
Path.Add(new Vector3(-12079.63 , 485.4148 , -0.8441155 , "Swimming"));
Path.Add(new Vector3(-12087.66 , 476.465 , -0.8441155 , "Swimming"));
Path.Add(new Vector3(-12096 , 454.3135 , -0.8441155 , "Swimming"));
Path.Add(new Vector3(-12102.91 , 430.998 , -0.8441155 , "Swimming"));
Path.Add(new Vector3(-12109.61 , 408.4068 , -0.8441155 , "Swimming"));
Path.Add(new Vector3(-12111.57 , 396.5332 , -0.8441155 , "Swimming"));
Path.Add(new Vector3(-12110.66 , 374.4612 , -0.8247253 , "Swimming"));
Path.Add(new Vector3(-12099.27 , 384.1859 , 0.008299068 , "None"));
Path.Add(new Vector3(-12080.7 , 393.1667 , 5.241175 , "None"));
Path.Add(new Vector3(-12091.58 , 382.5091 , 3.517485 , "None"));
Path.Add(new Vector3(-12083.5 , 353.9795 , 2.025811 , "None"));
Path.Add(new Vector3(-12076.31 , 334.5083 , 3.604648 , "None"));
Path.Add(new Vector3(-12088.13 , 306.6583 , 1.858307 , "None"));
Path.Add(new Vector3(-12081 , 269.5774 , 3.817849 , "None"));
Path.Add(new Vector3(-12072 , 247.3493 , 5.677167 , "None"));
Path.Add(new Vector3(-12062.88 , 236.663 , 7.611036 , "None"));
Path.Add(new Vector3(-12031.62 , 238.5449 , 10.65096 , "None"));
Path.Add(new Vector3(-12007.87 , 235.1167 , 15.37387 , "None"));
Path.Add(new Vector3(-11996.17 , 227.5483 , 17.54419 , "None"));
Path.Add(new Vector3(-11994.04 , 203.9359 , 12.96069 , "None"));
Path.Add(new Vector3(-12000.58 , 175.6381 , 13.34608 , "None"));
Path.Add(new Vector3(-11994.14 , 151.6255 , 15.74735 , "None"));
Path.Add(new Vector3(-11978.06 , 142.7911 , 14.93658 , "None"));
Path.Add(new Vector3(-11971.24 , 125.9276 , 12.41303 , "None"));
Path.Add(new Vector3(-11970.24 , 95.46455 , 9.627894 , "None"));
Path.Add(new Vector3(-11967.26 , 73.86652 , 13.72777 , "None"));
Path.Add(new Vector3(-11958.04 , 59.17987 , 15.09643 , "None"));
Path.Add(new Vector3(-11971.23 , 49.99321 , 13.42675 , "None"));
Path.Add(new Vector3(-11974.82 , 31.79538 , 14.86587 , "None"));
Path.Add(new Vector3(-11979.64 , 16.13985 , 15.64288 , "None"));
Path.Add(new Vector3(-11989.01 , 0.0462209 , 16.58005 , "None"));
Path.Add(new Vector3(-11996.06 , -15.80689 , 16.82497 , "None"));
Path.Add(new Vector3(-12003.54 , -26.32182 , 16.18038 , "None"));
Path.Add(new Vector3(-12015.33 , -42.83394 , 15.96105 , "None"));
Path.Add(new Vector3(-12018.04 , -58.89358 , 22.60995 , "None"));
Path.Add(new Vector3(-12019.96 , -81.74557 , 30.13094 , "None"));
Path.Add(new Vector3(-12020.28 , -101.4091 , 39.08876 , "None"));
Path.Add(new Vector3(-12022.63 , -127.3853 , 39.62966 , "None"));
Path.Add(new Vector3(-12053.22 , -127.0344 , 39.62966 , "None"));
Path.Add(new Vector3(-12071.73 , -127.8734 , 38.23981 , "None"));
Path.Add(new Vector3(-12101.63 , -146.3762 , 33.75494 , "None"));
Path.Add(new Vector3(-12121 , -176.7476 , 30.34819 , "None"));
Path.Add(new Vector3(-12138 , -208.5322 , 30.34956 , "None"));
Path.Add(new Vector3(-12153.26 , -237.5224 , 30.3476 , "None"));
Path.Add(new Vector3(-12169.53 , -268.433 , 30.3476 , "None"));
Path.Add(new Vector3(-12176.85 , -291.2064 , 30.3476 , "None"));
Path.Add(new Vector3(-12176.34 , -308.6971 , 32.26495 , "None"));
Path.Add(new Vector3(-12168.91 , -342.4497 , 21.79092 , "None"));
Path.Add(new Vector3(-12162.93 , -377.9849 , 28.23184 , "None"));
Path.Add(new Vector3(-12157.1 , -411.2155 , 30.3476 , "None"));
Path.Add(new Vector3(-12161.64 , -435.8226 , 30.34912 , "None"));
Path.Add(new Vector3(-12168.99 , -452.8352 , 30.15914 , "None"));
Path.Add(new Vector3(-12192.26 , -480.325 , 29.18862 , "None"));
Path.Add(new Vector3(-12209.87 , -507.8417 , 28.76153 , "None"));
Path.Add(new Vector3(-12228.49 , -539.9323 , 28.98934 , "None"));
Path.Add(new Vector3(-12252.6 , -566.5234 , 28.74094 , "None"));
Path.Add(new Vector3(-12283.42 , -582.0681 , 28.75381 , "None"));
Path.Add(new Vector3(-12319.14 , -584.65 , 25.62604 , "None"));
Path.Add(new Vector3(-12353.87 , -580.9613 , 19.87034 , "None"));
Path.Add(new Vector3(-12389.81 , -578.1439 , 13.80108 , "None"));
Path.Add(new Vector3(-12422.97 , -565.9127 , 10.10764 , "None"));
Path.Add(new Vector3(-12438.49 , -535.4991 , 10.11842 , "None"));
Path.Add(new Vector3(-12443.62 , -499.8186 , 10.11386 , "None"));
Path.Add(new Vector3(-12449.4 , -467.575 , 10.10052 , "None"));
Path.Add(new Vector3(-12464.03 , -433.6818 , 10.6137 , "None"));
Path.Add(new Vector3(-12487.81 , -406.7773 , 10.9616 , "None"));
Path.Add(new Vector3(-12520.46 , -391.7662 , 10.52074 , "None"));
Path.Add(new Vector3(-12551.99 , -383.4742 , 10.1006 , "None"));
Path.Add(new Vector3(-12588.84 , -379.5028 , 10.10012 , "None"));
Path.Add(new Vector3(-12623.75 , -378.1955 , 10.09985 , "None"));
Path.Add(new Vector3(-12660.89 , -376.8045 , 10.09961 , "None"));
Path.Add(new Vector3(-12695.74 , -377.2162 , 10.11862 , "None"));
Path.Add(new Vector3(-12730.56 , -379.7488 , 10.09941 , "None"));
Path.Add(new Vector3(-12765.34 , -378.8705 , 10.81503 , "None"));
Path.Add(new Vector3(-12798.07 , -366.3222 , 11.40311 , "None"));
Path.Add(new Vector3(-12812.14 , -334.4634 , 11.27121 , "None"));
Path.Add(new Vector3(-12829.7 , -303.4714 , 10.1555 , "None"));
Path.Add(new Vector3(-12854.78 , -277.5852 , 6.179119 , "None"));
Path.Add(new Vector3(-12886.3 , -260.8911 , 2.851022 , "None"));
Path.Add(new Vector3(-12918.99 , -248.5829 , -3.934148 , "None"));
Path.Add(new Vector3(-12952.01 , -237.2368 , -9.20976 , "None"));
Path.Add(new Vector3(-12985.55 , -227.5013 , -11.15572 , "None"));
Path.Add(new Vector3(-13019.79 , -216.3201 , -11.03798 , "None"));
Path.Add(new Vector3(-13054.09 , -205.2159 , -10.17837 , "None"));
Path.Add(new Vector3(-13088.92 , -195.9601 , -8.615181 , "None"));
Path.Add(new Vector3(-13122.79 , -187.4441 , -5.029914 , "None"));
Path.Add(new Vector3(-13157.88 , -179.1908 , 1.033889 , "None"));
Path.Add(new Vector3(-13191.04 , -172.5929 , 9.305995 , "None"));
Path.Add(new Vector3(-13209.38 , -161.0833 , 13.25565 , "None"));
Path.Add(new Vector3(-13235.71 , -136.5018 , 16.88032 , "None"));
Path.Add(new Vector3(-13244.02 , -105.6624 , 19.53902 , "None"));
Path.Add(new Vector3(-13243.17 , -69.7261 , 19.73224 , "None"));
Path.Add(new Vector3(-13246.71 , -36.13432 , 19.81186 , "None"));
Path.Add(new Vector3(-13259.55 , -1.741583 , 19.81107 , "None"));
Path.Add(new Vector3(-13282.52 , 24.43576 , 19.79683 , "None"));
Path.Add(new Vector3(-13307.27 , 50.59693 , 20.70274 , "None"));
Path.Add(new Vector3(-13329.16 , 76.15851 , 22.58865 , "None"));
Path.Add(new Vector3(-13365.33 , 80.29024 , 23.70454 , "None"));
Path.Add(new Vector3(-13397.97 , 81.939 , 24.6071 , "None"));
Path.Add(new Vector3(-13435.91 , 86.53383 , 25.72111 , "None"));
Path.Add(new Vector3(-13470.58 , 86.34599 , 28.16305 , "None"));
Path.Add(new Vector3(-13506.49 , 84.169 , 28.7643 , "None"));
Path.Add(new Vector3(-13539.25 , 83.99801 , 28.76393 , "None"));
Path.Add(new Vector3(-13577.45 , 85.01141 , 28.25708 , "None"));
Path.Add(new Vector3(-13609.96 , 88.58887 , 26.4481 , "None"));
Path.Add(new Vector3(-13644.9 , 100.8276 , 24.33038 , "None"));
Path.Add(new Vector3(-13677.02 , 117.1774 , 21.51575 , "None"));
Path.Add(new Vector3(-13709.63 , 129.6715 , 23.69121 , "None"));
Path.Add(new Vector3(-13738.33 , 148.6817 , 22.06939 , "None"));
Path.Add(new Vector3(-13761.23 , 177.8417 , 23.88989 , "None"));
Path.Add(new Vector3(-13783.57 , 203.1678 , 21.12531 , "None"));
Path.Add(new Vector3(-13812.24 , 226.8098 , 18.86853 , "None"));
Path.Add(new Vector3(-13840.4 , 245.4137 , 18.60123 , "None"));
Path.Add(new Vector3(-13875.19 , 254.6465 , 17.94619 , "None"));
Path.Add(new Vector3(-13909.27 , 265.0436 , 18.29659 , "None"));
Path.Add(new Vector3(-13937.87 , 285.3481 , 18.54699 , "None"));
Path.Add(new Vector3(-13971.46 , 284.5753 , 18.62524 , "None"));
Path.Add(new Vector3(-14007.92 , 277.3647 , 18.63083 , "None"));
Path.Add(new Vector3(-14042.26 , 270.9677 , 18.63816 , "None"));
Path.Add(new Vector3(-14075.99 , 261.961 , 17.52317 , "None"));
Path.Add(new Vector3(-14112.49 , 255.0979 , 15.87217 , "None"));
Path.Add(new Vector3(-14146.88 , 248.9598 , 14.78636 , "None"));
Path.Add(new Vector3(-14180.38 , 244.6125 , 15.30316 , "None"));
Path.Add(new Vector3(-14216.21 , 246.6936 , 20.34702 , "None"));
Path.Add(new Vector3(-14243.04 , 266.0424 , 25.71038 , "None"));
Path.Add(new Vector3(-14246.79 , 289.496 , 26.9665 , "None"));
Path.Add(new Vector3(-14246.18 , 314.5486 , 25.9826 , "None"));
Path.Add(new Vector3(-14251.32 , 330.6795 , 24.26631 , "None"));
Path.Add(new Vector3(-14264.2 , 344.9693 , 29.92853 , "None"));
Path.Add(new Vector3(-14274.12 , 356.1979 , 32.93965 , "None"));
Path.Add(new Vector3(-14277.68 , 370.9481 , 34.02097 , "None"));
Path.Add(new Vector3(-14274.12 , 396.6597 , 37.15107 , "None"));
Path.Add(new Vector3(-14275.29 , 418.8781 , 36.69961 , "None"));
Path.Add(new Vector3(-14285.45 , 429.9268 , 33.89313 , "None"));
Path.Add(new Vector3(-14300.81 , 435.5275 , 30.83612 , "None"));
Path.Add(new Vector3(-14312.98 , 442.8319 , 23.31425 , "None"));
Path.Add(new Vector3(-14323.31 , 450.9712 , 23.17186 , "None"));
Path.Add(new Vector3(-14313.36 , 476.3943 , 17.79399 , "None"));
Path.Add(new Vector3(-14300.74 , 508.9639 , 8.965549 , "None"));
Path.Add(new Vector3(-14324.96 , 472.033 , 8.380314 , "None"));
Path.Add(new Vector3(-14346.57 , 443.8535 , 7.464341 , "None"));
Path.Add(new Vector3(-14377.41 , 427.6174 , 7.360469 , "None"));
Path.Add(new Vector3(-14405.25 , 422.9465 , 8.39375 , "None"));
Path.Add(new Vector3(-14416.45 , 433.4 , 8.966042 , "None"));
Path.Add(new Vector3(-14429.71 , 450.0382 , 15.43616 , "None"));
Path.Add(new Vector3(-14443.45 , 464.7533 , 15.38058 , "None"));
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


public sealed class PATHDuskwoodtoSwampofSarrows : QuestFollowPathClass
{
    public PATHDuskwoodtoSwampofSarrows()
    {
        Name = "PATH : Duskwood to Swamp of Sarrows";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 38;
        RequiredQuest = 0;

        Path.Add(new Vector3(-10537.62 , -1306.908 , 41.86842 , "None"));
Path.Add(new Vector3(-10542.34 , -1337.13 , 47.94617 , "None"));
Path.Add(new Vector3(-10541.28 , -1355.453 , 51.69125 , "None"));
Path.Add(new Vector3(-10536.38 , -1385.626 , 57.53248 , "None"));
Path.Add(new Vector3(-10524.41 , -1393.296 , 60.93666 , "None"));
Path.Add(new Vector3(-10512.08 , -1402.386 , 63.13135 , "None"));
Path.Add(new Vector3(-10482.96 , -1423.623 , 64.94456 , "None"));
Path.Add(new Vector3(-10461.17 , -1449.27 , 68.72997 , "None"));
Path.Add(new Vector3(-10447.47 , -1482.282 , 73.56454 , "None"));
Path.Add(new Vector3(-10447.73 , -1508.318 , 74.59616 , "None"));
Path.Add(new Vector3(-10451.31 , -1542.005 , 74.66296 , "None"));
Path.Add(new Vector3(-10457.89 , -1578.507 , 73.55363 , "None"));
Path.Add(new Vector3(-10462.08 , -1614.284 , 73.36001 , "None"));
Path.Add(new Vector3(-10463.76 , -1642.584 , 75.51633 , "None"));
Path.Add(new Vector3(-10465.51 , -1676.415 , 79.61191 , "None"));
Path.Add(new Vector3(-10462.1 , -1711.17 , 82.88032 , "None"));
Path.Add(new Vector3(-10460.52 , -1730.776 , 86.11111 , "None"));
Path.Add(new Vector3(-10459.55 , -1748.249 , 88.50661 , "None"));
Path.Add(new Vector3(-10439.09 , -1780.422 , 95.55398 , "None"));
Path.Add(new Vector3(-10433.53 , -1793.422 , 97.24115 , "None"));
Path.Add(new Vector3(-10431.92 , -1816.326 , 99.7181 , "None"));
Path.Add(new Vector3(-10436.12 , -1839.773 , 102.1032 , "None"));
Path.Add(new Vector3(-10444.3 , -1871.495 , 104.8232 , "None"));
Path.Add(new Vector3(-10441.15 , -1898.327 , 103.0076 , "None"));
Path.Add(new Vector3(-10439.69 , -1934.333 , 104.5628 , "None"));
Path.Add(new Vector3(-10438.1 , -1970.332 , 102.5131 , "None"));
Path.Add(new Vector3(-10431.08 , -2005.638 , 98.30672 , "None"));
Path.Add(new Vector3(-10433.46 , -2026.65 , 95.76122 , "None"));
Path.Add(new Vector3(-10446.53 , -2046.228 , 93.87154 , "None"));
Path.Add(new Vector3(-10493.21 , -2044.332 , 92.94147 , "None"));
Path.Add(new Vector3(-10512.73 , -2056.345 , 91.99472 , "None"));
Path.Add(new Vector3(-10526.94 , -2075.613 , 91.55067 , "None"));
Path.Add(new Vector3(-10550.49 , -2104.176 , 92.02052 , "None"));
Path.Add(new Vector3(-10570.16 , -2113.544 , 91.02542 , "None"));
Path.Add(new Vector3(-10589.52 , -2125.422 , 90.92444 , "None"));
Path.Add(new Vector3(-10592.98 , -2154.751 , 92.76711 , "None"));
Path.Add(new Vector3(-10588.17 , -2186.024 , 89.9927 , "None"));
Path.Add(new Vector3(-10580.09 , -2221.122 , 92.5256 , "None"));
Path.Add(new Vector3(-10570.38 , -2254.677 , 93.92899 , "None"));
Path.Add(new Vector3(-10562.78 , -2282.057 , 93.17821 , "None"));
Path.Add(new Vector3(-10556.38 , -2314.186 , 90.10948 , "None"));
Path.Add(new Vector3(-10548.5 , -2350.438 , 86.72491 , "None"));
Path.Add(new Vector3(-10540.92 , -2369.545 , 83.21603 , "None"));
Path.Add(new Vector3(-10525.61 , -2377.013 , 81.82748 , "None"));
Path.Add(new Vector3(-10499.91 , -2386.203 , 77.70204 , "None"));
Path.Add(new Vector3(-10483.33 , -2394.381 , 75.75094 , "None"));
Path.Add(new Vector3(-10459.88 , -2405.721 , 70.67464 , "None"));
Path.Add(new Vector3(-10426.55 , -2410.683 , 65.77669 , "None"));
Path.Add(new Vector3(-10392.68 , -2423.591 , 53.46966 , "None"));
Path.Add(new Vector3(-10383.09 , -2456.04 , 44.36351 , "None"));
Path.Add(new Vector3(-10395.75 , -2477.371 , 36.79328 , "None"));
Path.Add(new Vector3(-10408.77 , -2509.598 , 29.64352 , "None"));
Path.Add(new Vector3(-10418.96 , -2544.074 , 24.49632 , "None"));
Path.Add(new Vector3(-10409.87 , -2571.175 , 23.03571 , "None"));
Path.Add(new Vector3(-10390.62 , -2593.487 , 21.8215 , "None"));
Path.Add(new Vector3(-10378.03 , -2612.29 , 21.68181 , "None"));
Path.Add(new Vector3(-10375.38 , -2634.03 , 21.87324 , "None"));
Path.Add(new Vector3(-10369.13 , -2649.162 , 22.60652 , "None"));
Path.Add(new Vector3(-10357.73 , -2665.195 , 23.00959 , "None"));
Path.Add(new Vector3(-10346.91 , -2680.26 , 23.53379 , "None"));
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


public sealed class DEPRECATEDEncroachingWildlife : QuestGrinderClass
{
    public DEPRECATEDEncroachingWildlife()
    {
        Name = "[DEPRECATED]Encroaching Wildlife";

        QuestId.AddRange(new[] { 1396 });

        Step = new List<int> { 8, 10, 10, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 36;
        RequiredQuest = 0;

        EntryTarget.Add(858);
EntryTarget.Add(767);
EntryTarget.Add(1084);
HotSpots.Add(new Vector3(-10111.66 , -3083.364 , 21.81131 , "None"));
HotSpots.Add(new Vector3(-10465.34 , -3024.105 , 23.18656 , "None"));
HotSpots.Add(new Vector3(-10548.13 , -2738.947 , 25.30317 , "None"));
HotSpots.Add(new Vector3(-10222.04 , -2753.708 , 23.09678 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DEPRECATEDDraenethystCrystals : QuestGathererClass
{
    public DEPRECATEDDraenethystCrystals()
    {
        Name = "[DEPRECATED]Draenethyst Crystals";

        QuestId.AddRange(new[] { 1389 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 35;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(-10080.15 , -3485.194 , 23.52092 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GRIND3538SwampofSarrow : QuestGrinderClass
{
    public GRIND3538SwampofSarrow()
    {
        Name = "GRIND : 35-38 Swamp of Sarrow";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 37;
        RequiredQuest = 0;

        EntryTarget.Add(767);
EntryTarget.Add(858);
EntryTarget.Add(1084);
EntryTarget.Add(1082);
HotSpots.Add(new Vector3(-10275.88 , -2686.418 , 24.29143 , "None"));
HotSpots.Add(new Vector3(-10091.1 , -3033.871 , 22.34631 , "None"));
HotSpots.Add(new Vector3(-10312.96 , -3226.864 , 23.46367 , "None"));
HotSpots.Add(new Vector3(-10420.46 , -2931.751 , 22.80373 , "None"));
HotSpots.Add(new Vector3(-10574 , -2824.203 , 25.14295 , "None"));
HotSpots.Add(new Vector3(-10457.03 , -2723.843 , 22.9149 , "None"));
HotSpots.Add(new Vector3(-10249.95 , -2715.752 , 23.05693 , "None"));
HotSpots.Add(new Vector3(-10152 , -2878.597 , 22.29686 , "None"));
HotSpots.Add(new Vector3(-10302.08 , -3069.842 , 23.43548 , "None"));
HotSpots.Add(new Vector3(-10356.04 , -3509.515 , 23.16571 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class ADwarfandHisTools : QuestGrinderClass
{
    public ADwarfandHisTools()
    {
        Name = "A Dwarf and His Tools";

        QuestId.AddRange(new[] { 719 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 39;
        RequiredQuest = 0;

        EntryTarget.Add(2740);
HotSpots.Add(new Vector3(-6448.33 , -3387.3 , 241.5714 , "None"));
HotSpots.Add(new Vector3(-6467.381 , -3402.425 , 241.6199 , "None"));
HotSpots.Add(new Vector3(-6405.26 , -3411.88 , 241.5813 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Mirages : QuestGathererClass
{
    public Mirages()
    {
        Name = "Mirages";

        QuestId.AddRange(new[] { 718 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 39;
        RequiredQuest = 0;

        EntryIdObjects.Add(2867);
HotSpots.Add(new Vector3(-6279.338 , -3744.2 , 243.8171 , "None"));

    }

	public override bool CanConditions()
	{
        return ItemsManager.GetItemCountById(4629) >= 1;
	}








}


public sealed class BarbecuedBuzzardWings : QuestGrinderClass
{
    public BarbecuedBuzzardWings()
    {
        Name = "Barbecued Buzzard Wings";

        QuestId.AddRange(new[] { 703 });

        Step = new List<int> { 4, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 39;
        RequiredQuest = 0;

        EntryTarget.Add(2829);
EntryTarget.Add(2831);
HotSpots.Add(new Vector3(-6358.727 , -3492.028 , 243.4735 , "None"));
HotSpots.Add(new Vector3(-6291.124 , -3422.529 , 238.9784 , "None"));
HotSpots.Add(new Vector3(-6907.192 , -2722.02 , 242.0268 , "None"));
HotSpots.Add(new Vector3(-6882.108 , -2536.299 , 240.7452 , "None"));
HotSpots.Add(new Vector3(-6946.094 , -2453.068 , 240.7438 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class StudyoftheElementsRock : QuestGrinderClass
{
    public StudyoftheElementsRock()
    {
        Name = "Study of the Elements: Rock";

        QuestId.AddRange(new[] { 710 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 39;
        RequiredQuest = 0;

        EntryTarget.Add(2735);
HotSpots.Add(new Vector3(-6641.226 , -2664.242 , 254.6124 , "None"));
HotSpots.Add(new Vector3(-6674.571 , -2568.994 , 241.6715 , "None"));
HotSpots.Add(new Vector3(-6571.904 , -2527.32 , 292.1622 , "None"));
HotSpots.Add(new Vector3(-6474.738 , -2402.4 , 295.9264 , "None"));
HotSpots.Add(new Vector3(-6489.924 , -2491.445 , 324.2923 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class StudyoftheElementsRockPart2 : QuestGrinderClass
{
    public StudyoftheElementsRockPart2()
    {
        Name = "Study of the Elements: Rock Part 2";

        QuestId.AddRange(new[] { 711 });

        Step = new List<int> { 3, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 39;
        RequiredQuest = 710;

        EntryTarget.Add(92);
HotSpots.Add(new Vector3(-7111.671 , -2992.802 , 251.2968 , "None"));
HotSpots.Add(new Vector3(-7215.478 , -3168.42 , 296.0487 , "None"));
HotSpots.Add(new Vector3(-7316.135 , -3152.595 , 313.5117 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class StudyoftheElementsRockPart3 : QuestGrinderClass
{
    public StudyoftheElementsRockPart3()
    {
        Name = "Study of the Elements: Rock Part 3";

        QuestId.AddRange(new[] { 712 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 40;
        RequiredQuest = 711;

        
    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Scrounging : QuestGrinderClass
{
    public Scrounging()
    {
        Name = "Scrounging";

        QuestId.AddRange(new[] { 733 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 39;
        RequiredQuest = 0;

        EntryTarget.Add(2906);
EntryTarget.Add(2907);
EntryTarget.Add(2701);
EntryTarget.Add(2715);
HotSpots.Add(new Vector3(-6287.89 , -3671.41 , 244.6245 , "None"));
HotSpots.Add(new Vector3(-6295.816 , -3712.754 , 249.1531 , "None"));
HotSpots.Add(new Vector3(-6306.364 , -3770.636 , 243.7603 , "None"));
HotSpots.Add(new Vector3(-6256.47 , -3769.243 , 243.4766 , "None"));
HotSpots.Add(new Vector3(-7024.766 , -3633.647 , 241.6672 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GRIND38to41BadlandsV1 : QuestGrinderClass
{
    public GRIND38to41BadlandsV1()
    {
        Name = "GRIND : 38 to 41 Badlands V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 40;
        RequiredQuest = 0;

        EntryTarget.Add(2830);
EntryTarget.Add(2728);
EntryTarget.Add(2732);
EntryTarget.Add(2701);
EntryTarget.Add(2715);
EntryTarget.Add(2831);
EntryTarget.Add(2734);
HotSpots.Add(new Vector3(-6723.383 , -3385.716 , 241.6728 , "None"));
HotSpots.Add(new Vector3(-6757.858 , -3551.511 , 245.6319 , "None"));
HotSpots.Add(new Vector3(-6987.398 , -3631.465 , 241.669 , "None"));
HotSpots.Add(new Vector3(-7096.244 , -3575.418 , 242.0867 , "None"));
HotSpots.Add(new Vector3(-7113.246 , -3216.965 , 241.6671 , "None"));
HotSpots.Add(new Vector3(-7073.471 , -2816.873 , 242.2086 , "None"));
HotSpots.Add(new Vector3(-6655.11 , -2883.852 , 241.668 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 41;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND38to41BadlandsV2 : QuestGrinderClass
{
    public GRIND38to41BadlandsV2()
    {
        Name = "GRIND : 38 to 41 Badlands V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 40;
        RequiredQuest = 0;

        EntryTarget.Add(2728);
EntryTarget.Add(2732);
EntryTarget.Add(2701);
EntryTarget.Add(2715);
EntryTarget.Add(2831);
EntryTarget.Add(2734);
HotSpots.Add(new Vector3(-6887.303 , -3382.465 , 241.7151 , "None"));
HotSpots.Add(new Vector3(-6656.234 , -3195.895 , 262.7285 , "None"));
HotSpots.Add(new Vector3(-6669.254 , -2875.373 , 241.7075 , "None"));
HotSpots.Add(new Vector3(-7066.792 , -3111.243 , 242.1888 , "None"));
HotSpots.Add(new Vector3(-7122.883 , -3221.749 , 242.2337 , "None"));
HotSpots.Add(new Vector3(-7069.054 , -2757.884 , 242.5465 , "None"));
HotSpots.Add(new Vector3(-6831.85 , -2595.57 , 240.7783 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 41;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND41to42Badlands : QuestGrinderClass
{
    public GRIND41to42Badlands()
    {
        Name = "GRIND : 41 to 42 Badlands";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 41;
        RequiredQuest = 0;

        EntryTarget.Add(2831);
EntryTarget.Add(2734);
EntryTarget.Add(2729);
EntryTarget.Add(2716);
EntryTarget.Add(2717);
EntryTarget.Add(2718);
HotSpots.Add(new Vector3(-6706.162 , -2516.549 , 243.5943 , "None"));
HotSpots.Add(new Vector3(-6860.469 , -2638.284 , 241.6675 , "None"));
HotSpots.Add(new Vector3(-7046.722 , -2577.591 , 252.3182 , "None"));
HotSpots.Add(new Vector3(-6950.051 , -2399.208 , 242.1197 , "None"));
HotSpots.Add(new Vector3(-6822.467 , -2440.83 , 253.7309 , "None"));
HotSpots.Add(new Vector3(-7063.177 , -2335.475 , 244.7446 , "None"));
HotSpots.Add(new Vector3(-7071.617 , -2288.586 , 264.0775 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class CatchShipinWetlandstoRatchet : QuestClass
{
    public CatchShipinWetlandstoRatchet()
    {
        Name = "Catch Ship in Wetlands to Ratchet";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 53;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return Usefuls.ContinentId == (int) ContinentId.Azeroth;
	}

public override bool IsComplete() { 
return Usefuls.ContinentId == (int) ContinentId.Kalimdor && !ObjectManager.Me.InTransport;
}



public override bool HasQuest() { return true; }

public override bool Pulse() {
// Sample of how to use Zeppelin/Ship
// In this sample, WRobot catch Zeppelin from Kalimdor (Ogrimmard) to Northrend (Borean Tundra (Warsong Hold))

/* Quest settings:
    * Can condition: "return Usefuls.ContinentId == (int) ContinentId.Kalimdor;"
    * Is complete condition: "return Usefuls.ContinentId == (int) ContinentId.Northrend && !ObjectManager.Me.InTransport;"
    * Not required in quest log: "True"
    * Quest type: "OverridePulseCSharpCode"
*/

// You can get zeppelin/ship/player positions and entry ID in tab "Tools" > "Development Tools" > "Dump all informations" (or "Memory information").

// Settings:
var zeppelinEntryId = 176231; // Zeppelin/Ship EntryId
// From
var fromZeppelinWaitPosition = new Vector3(-3905.225, -585.8085, 0);// Position where Zeppelin/Ship waits FOR Players (From)
var fromPlayerWaitPosition = new Vector3(-3896.616, -597.6113, 5.437047, "None"); // Position where the SHIP/ZEP Waits for Players (FROM)
var fromPlayerInZeppelinPosition = new Vector3(-3898.228, -595.0126, 6.079672, "None");// Position where the player waits ON The ship (from)
// To
var toZeppelinWaitPosition = new Vector3(-4016.39, -4740.588, 0, "None"); // Position where the Zeppelin/Ship waits for players (to)
var toPlayerLeavePosition =  new Vector3(-4004.009, -4731.586, 5.278412, "None"); // Position where you GET OFF the ship (to)
// var toPlayerLeaveBoat = new Vector3(-4005.372, -4733.763, 5.872578, "None"); // Positoion where player waits on the ship (to)


// Change WRobot settings:
wManager.wManagerSetting.CurrentSetting.CloseIfPlayerTeleported = false;

// Code:
if (!Conditions.InGameAndConnectedAndProductStartedNotInPause)
    return true;

if (Usefuls.ContinentId == (int)ContinentId.Azeroth)
{
    if (!ObjectManager.Me.InTransport)
    {
        if (GoToTask.ToPosition(fromPlayerWaitPosition))
        {
            var zeppelin = ObjectManager.GetWoWGameObjectByEntry(zeppelinEntryId).OrderBy(o => o.GetDistance).FirstOrDefault();
            if (zeppelin != null && zeppelin.Position.DistanceTo(fromZeppelinWaitPosition) < 1)
            {
                wManager.Wow.Helpers.Move.Forward(Move.MoveAction.PressKey,2500);
            }
        }
    }
}
else if (Usefuls.ContinentId == (int)ContinentId.Kalimdor)
{
    if (ObjectManager.Me.InTransport)
    {
        var zeppelin = ObjectManager.GetWoWGameObjectByEntry(zeppelinEntryId).OrderBy(o => o.GetDistance).FirstOrDefault();
        if (zeppelin != null && zeppelin.Position.DistanceTo(toZeppelinWaitPosition) < 1)
        {
            wManager.Wow.Helpers.Move.Backward(Move.MoveAction.PressKey,2650);
        }
    }
}
return true;
}
}


public sealed class RuntoShip : QuestFollowPathClass
{
    public RuntoShip()
    {
        Name = "Run to Ship";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 53;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3817.515 , -771.1463 , 8.041287 , "None"));
Path.Add(new Vector3(-3831.209 , -751.4354 , 8.352912 , "None"));
Path.Add(new Vector3(-3850.195 , -720.7896 , 8.396587 , "None"));
Path.Add(new Vector3(-3867.598 , -692.2693 , 7.825092 , "None"));
Path.Add(new Vector3(-3878.515 , -674.0076 , 7.88914 , "None"));
Path.Add(new Vector3(-3890.357 , -653.3641 , 8.249937 , "None"));
Path.Add(new Vector3(-3903.639 , -627.9399 , 4.609906 , "None"));
Path.Add(new Vector3(-3900.386 , -617.179 , 4.867525 , "None"));
Path.Add(new Vector3(-3893.29 , -599.0101 , 5.519112 , "None"));
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


public sealed class RunfromSHIPtoFPTheramore : QuestFollowPathClass
{
    public RunfromSHIPtoFPTheramore()
    {
        Name = "Run from SHIP to FP Theramore";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 53;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3860.024 , -4633.61 , 8.954811 , "None"));
Path.Add(new Vector3(-3851.563 , -4628.616 , 9.256601 , "None"));
Path.Add(new Vector3(-3847.472 , -4619.587 , 9.223373 , "None"));
Path.Add(new Vector3(-3852.996 , -4610.745 , 9.187727 , "None"));
Path.Add(new Vector3(-3859.563 , -4602.151 , 9.156542 , "None"));
Path.Add(new Vector3(-3863.155 , -4592.563 , 9.313004 , "None"));
Path.Add(new Vector3(-3861.639 , -4581.912 , 9.066072 , "None"));
Path.Add(new Vector3(-3858.984 , -4571.774 , 7.993365 , "None"));
Path.Add(new Vector3(-3856.244 , -4561.312 , 8.187731 , "None"));
Path.Add(new Vector3(-3853.062 , -4551.35 , 8.491039 , "None"));
Path.Add(new Vector3(-3847.569 , -4542.054 , 9.024908 , "None"));
Path.Add(new Vector3(-3840.576 , -4533.814 , 9.733313 , "None"));
Path.Add(new Vector3(-3833.615 , -4525.985 , 10.63251 , "None"));
Path.Add(new Vector3(-3829.778 , -4519.92 , 10.84177 , "None"));
Path.Add(new Vector3(-3829.427 , -4518.998 , 10.78166 , "None"));
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


public sealed class PATHTheramoretoTanaris : QuestFollowPathClass
{
    public PATHTheramoretoTanaris()
    {
        Name = "PATH : Theramore to Tanaris";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 53;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3656.821 , -4370.882 , 9.355819 , "None"));
Path.Add(new Vector3(-3638.381 , -4357.205 , 7.786882 , "None"));
Path.Add(new Vector3(-3609.724 , -4335.335 , 9.442204 , "None"));
Path.Add(new Vector3(-3585.647 , -4316.579 , 6.030541 , "None"));
Path.Add(new Vector3(-3558.979 , -4297.573 , 6.101216 , "None"));
Path.Add(new Vector3(-3541.403 , -4286.6 , 5.802964 , "None"));
Path.Add(new Vector3(-3515.588 , -4266.591 , 6.328804 , "None"));
Path.Add(new Vector3(-3496.013 , -4249.214 , 7.473617 , "None"));
Path.Add(new Vector3(-3471.369 , -4223 , 9.41952 , "None"));
Path.Add(new Vector3(-3454.808 , -4202.729 , 11.0693 , "None"));
Path.Add(new Vector3(-3441.661 , -4186.75 , 10.73087 , "None"));
Path.Add(new Vector3(-3425.696 , -4171.902 , 10.04555 , "None"));
Path.Add(new Vector3(-3400.529 , -4147.897 , 15.11665 , "None"));
Path.Add(new Vector3(-3387.333 , -4127.915 , 17.81426 , "None"));
Path.Add(new Vector3(-3383.377 , -4109.874 , 18.18956 , "None"));
Path.Add(new Vector3(-3368.56 , -4090.146 , 19.40771 , "None"));
Path.Add(new Vector3(-3345.915 , -4090.194 , 22.61454 , "None"));
Path.Add(new Vector3(-3330.405 , -4095.33 , 23.1717 , "None"));
Path.Add(new Vector3(-3302.149 , -4093.715 , 23.17454 , "None"));
Path.Add(new Vector3(-3269.937 , -4067.783 , 23.9448 , "None"));
Path.Add(new Vector3(-3252.704 , -4048.019 , 24.21782 , "None"));
Path.Add(new Vector3(-3218.932 , -4019.114 , 24.79902 , "None"));
Path.Add(new Vector3(-3187.299 , -4002.001 , 26.69617 , "None"));
Path.Add(new Vector3(-3159.981 , -3980.489 , 28.26456 , "None"));
Path.Add(new Vector3(-3141.658 , -3949.969 , 31.71656 , "None"));
Path.Add(new Vector3(-3131.981 , -3917.504 , 34.10851 , "None"));
Path.Add(new Vector3(-3121.53 , -3894.749 , 34.33331 , "None"));
Path.Add(new Vector3(-3109.018 , -3876.848 , 34.33636 , "None"));
Path.Add(new Vector3(-3096.903 , -3864.238 , 34.4008 , "None"));
Path.Add(new Vector3(-3083.489 , -3853.023 , 34.38615 , "None"));
Path.Add(new Vector3(-3061.676 , -3843.94 , 32.57486 , "None"));
Path.Add(new Vector3(-3029.983 , -3835.957 , 34.21738 , "None"));
Path.Add(new Vector3(-3015.01 , -3829.314 , 34.4485 , "None"));
Path.Add(new Vector3(-2986.589 , -3815.503 , 34.65554 , "None"));
Path.Add(new Vector3(-2960.369 , -3791.211 , 34.65925 , "None"));
Path.Add(new Vector3(-2940.633 , -3762.415 , 34.4432 , "None"));
Path.Add(new Vector3(-2924.149 , -3731.77 , 34.26222 , "None"));
Path.Add(new Vector3(-2914.683 , -3697.093 , 33.74245 , "None"));
Path.Add(new Vector3(-2909.649 , -3669.208 , 32.84489 , "None"));
Path.Add(new Vector3(-2905.69 , -3627.222 , 32.25277 , "None"));
Path.Add(new Vector3(-2908.424 , -3601.237 , 34.26161 , "None"));
Path.Add(new Vector3(-2906.144 , -3567.502 , 34.25655 , "None"));
Path.Add(new Vector3(-2893.089 , -3541.063 , 34.27837 , "None"));
Path.Add(new Vector3(-2880.764 , -3508.62 , 34.51005 , "None"));
Path.Add(new Vector3(-2868.854 , -3475.866 , 34.49712 , "None"));
Path.Add(new Vector3(-2849.399 , -3445.652 , 34.1118 , "None"));
Path.Add(new Vector3(-2829.61 , -3417.039 , 34.01087 , "None"));
Path.Add(new Vector3(-2821.569 , -3400.345 , 32.25465 , "None"));
Path.Add(new Vector3(-2829.854 , -3361.373 , 31.34236 , "None"));
Path.Add(new Vector3(-2836.458 , -3344.049 , 31.68865 , "None"));
Path.Add(new Vector3(-2848.814 , -3331.912 , 31.3873 , "None"));
Path.Add(new Vector3(-2867.576 , -3320.906 , 31.79317 , "None"));
Path.Add(new Vector3(-2884.531 , -3313.626 , 31.39714 , "None"));
Path.Add(new Vector3(-2912.329 , -3290.857 , 31.95384 , "None"));
Path.Add(new Vector3(-2926.119 , -3275.393 , 31.68186 , "None"));
Path.Add(new Vector3(-2940.703 , -3259.14 , 31.22723 , "None"));
Path.Add(new Vector3(-2968.32 , -3244.832 , 32.21477 , "None"));
Path.Add(new Vector3(-3002.584 , -3233.631 , 33.90587 , "None"));
Path.Add(new Vector3(-3034.864 , -3220.326 , 33.88377 , "None"));
Path.Add(new Vector3(-3069.323 , -3209.958 , 33.41697 , "None"));
Path.Add(new Vector3(-3103.128 , -3201.429 , 33.08666 , "None"));
Path.Add(new Vector3(-3135.573 , -3185.75 , 32.58147 , "None"));
Path.Add(new Vector3(-3168.984 , -3176.12 , 32.66646 , "None"));
Path.Add(new Vector3(-3185.113 , -3178.304 , 32.71134 , "None"));
Path.Add(new Vector3(-3214.723 , -3194.764 , 32.35747 , "None"));
Path.Add(new Vector3(-3248.968 , -3204.621 , 32.98708 , "None"));
Path.Add(new Vector3(-3265.036 , -3198.363 , 32.82368 , "None"));
Path.Add(new Vector3(-3283.077 , -3179.519 , 32.63886 , "None"));
Path.Add(new Vector3(-3292.053 , -3152.702 , 32.30623 , "None"));
Path.Add(new Vector3(-3298.051 , -3121.777 , 32.85149 , "None"));
Path.Add(new Vector3(-3314.04 , -3095.701 , 32.55677 , "None"));
Path.Add(new Vector3(-3333.726 , -3059.926 , 30.97322 , "None"));
Path.Add(new Vector3(-3353.202 , -3041.281 , 33.06598 , "None"));
Path.Add(new Vector3(-3365.219 , -3025.712 , 32.02758 , "None"));
Path.Add(new Vector3(-3392.273 , -3000.814 , 31.85726 , "None"));
Path.Add(new Vector3(-3419.677 , -2979.212 , 30.98421 , "None"));
Path.Add(new Vector3(-3431.024 , -2932.085 , 31.85662 , "None"));
Path.Add(new Vector3(-3435.031 , -2914.055 , 31.01085 , "None"));
Path.Add(new Vector3(-3453.561 , -2892.819 , 32.31406 , "None"));
Path.Add(new Vector3(-3486.186 , -2869.2 , 31.01986 , "None"));
Path.Add(new Vector3(-3504.502 , -2850.836 , 31.56291 , "None"));
Path.Add(new Vector3(-3514.837 , -2834.222 , 32.16788 , "None"));
Path.Add(new Vector3(-3531.44 , -2819.994 , 32.0441 , "None"));
Path.Add(new Vector3(-3554.611 , -2803.538 , 31.60079 , "None"));
Path.Add(new Vector3(-3571.804 , -2779.918 , 31.92802 , "None"));
Path.Add(new Vector3(-3579.058 , -2765.238 , 31.25795 , "None"));
Path.Add(new Vector3(-3594.288 , -2749.739 , 32.95504 , "None"));
Path.Add(new Vector3(-3619.827 , -2734.948 , 32.83406 , "None"));
Path.Add(new Vector3(-3644.662 , -2719.093 , 33.24094 , "None"));
Path.Add(new Vector3(-3659.462 , -2706.405 , 36.03246 , "None"));
Path.Add(new Vector3(-3665.336 , -2668.122 , 40.76013 , "None"));
Path.Add(new Vector3(-3666.889 , -2647.499 , 42.60331 , "None"));
Path.Add(new Vector3(-3683.994 , -2618.335 , 47.94757 , "None"));
Path.Add(new Vector3(-3697.485 , -2593.408 , 53.14342 , "None"));
Path.Add(new Vector3(-3691.764 , -2575.72 , 55.86943 , "None"));
Path.Add(new Vector3(-3685.512 , -2552.59 , 59.87073 , "None"));
Path.Add(new Vector3(-3684.374 , -2516.595 , 68.2028 , "None"));
Path.Add(new Vector3(-3684.69 , -2481.696 , 76.66238 , "None"));
Path.Add(new Vector3(-3685.829 , -2446.784 , 82.37129 , "None"));
Path.Add(new Vector3(-3686.824 , -2426.019 , 85.64137 , "None"));
Path.Add(new Vector3(-3688.545 , -2407.584 , 88.54346 , "None"));
Path.Add(new Vector3(-3695.734 , -2389.429 , 91.2963 , "None"));
Path.Add(new Vector3(-3704.39 , -2370.605 , 93.02824 , "None"));
Path.Add(new Vector3(-3720.288 , -2349.88 , 95.25468 , "None"));
Path.Add(new Vector3(-3744.703 , -2333.41 , 94.74944 , "None"));
Path.Add(new Vector3(-3774.9 , -2313.722 , 91.66679 , "None"));
Path.Add(new Vector3(-3781.5 , -2293.265 , 92.1202 , "None"));
Path.Add(new Vector3(-3779.377 , -2257.674 , 94.31819 , "None"));
Path.Add(new Vector3(-3769.143 , -2223.108 , 94.82158 , "None"));
Path.Add(new Vector3(-3759.665 , -2189.498 , 92.23366 , "None"));
Path.Add(new Vector3(-3756.91 , -2153.666 , 94.01998 , "None"));
Path.Add(new Vector3(-3757.971 , -2118.852 , 93.25802 , "None"));
Path.Add(new Vector3(-3759.157 , -2084.318 , 92.10916 , "None"));
Path.Add(new Vector3(-3780.998 , -2057.696 , 91.81103 , "None"));
Path.Add(new Vector3(-3815.663 , -2049.168 , 91.68471 , "None"));
Path.Add(new Vector3(-3850.59 , -2048.943 , 92.10256 , "None"));
Path.Add(new Vector3(-3886.545 , -2049.046 , 95.89804 , "None"));
Path.Add(new Vector3(-3921.453 , -2050.299 , 95.93024 , "None"));
Path.Add(new Vector3(-3957.482 , -2051.512 , 93.50058 , "None"));
Path.Add(new Vector3(-3992.402 , -2051.077 , 91.6704 , "None"));
Path.Add(new Vector3(-4027.235 , -2048.489 , 91.66692 , "None"));
Path.Add(new Vector3(-4062.564 , -2041.976 , 91.66692 , "None"));
Path.Add(new Vector3(-4095.51 , -2027.561 , 91.66692 , "None"));
Path.Add(new Vector3(-4124.687 , -2008.482 , 91.66692 , "None"));
Path.Add(new Vector3(-4149.982 , -1982.849 , 91.66692 , "None"));
Path.Add(new Vector3(-4173.578 , -1957.094 , 91.66677 , "None"));
Path.Add(new Vector3(-4197.572 , -1931.71 , 91.72604 , "None"));
Path.Add(new Vector3(-4223.468 , -1906.7 , 92.2263 , "None"));
Path.Add(new Vector3(-4253.91 , -1887.667 , 91.77071 , "None"));
Path.Add(new Vector3(-4287.671 , -1879.243 , 91.76357 , "None"));
Path.Add(new Vector3(-4322.445 , -1876.573 , 91.24619 , "None"));
Path.Add(new Vector3(-4358.453 , -1876.198 , 89.74464 , "None"));
Path.Add(new Vector3(-4393.342 , -1877.717 , 86.6786 , "None"));
Path.Add(new Vector3(-4429.226 , -1874.658 , 86.1292 , "None"));
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


public sealed class RuntoLift : QuestFollowPathClass
{
    public RuntoLift()
    {
        Name = "Run to Lift";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 27;
        RequiredQuest = 0;

        Path.Add(new Vector3(-4580.955 , -1859.831 , 86.16222 , "None"));
Path.Add(new Vector3(-4584.921 , -1858.407 , 86.11321 , "None"));
Path.Add(new Vector3(-4591.551 , -1856.141 , 86.11167 , "None"));
Path.Add(new Vector3(-4598.402 , -1853.828 , 86.11167 , "None"));
Path.Add(new Vector3(-4605.054 , -1851.671 , 86.10526 , "None"));
Path.Add(new Vector3(-4608.39 , -1850.589 , 86.10217 , "None"));
Path.Add(new Vector3(-4615.269 , -1848.359 , 86.0873 , "None"));
Path.Add(new Vector3(-4618.598 , -1847.28 , 86.0601 , "None"));
Path.Add(new Vector3(-4621.967 , -1846.188 , 85.96131 , "None"));
Path.Add(new Vector3(-4625.297 , -1845.108 , 85.65796 , "None"));
Path.Add(new Vector3(-4628.713 , -1844.001 , 85.32047 , "None"));
Path.Add(new Vector3(-4632.076 , -1842.89 , 85.32047 , "None"));
Path.Add(new Vector3(-4635.452 , -1841.665 , 85.32047 , "None"));
Path.Add(new Vector3(-4638.813 , -1840.273 , 85.32047 , "None"));
Path.Add(new Vector3(-4644.882 , -1836.795 , 85.32047 , "None"));
Path.Add(new Vector3(-4647.96 , -1834.944 , 85.32047 , "None"));
Path.Add(new Vector3(-4650.88 , -1832.79 , 85.32047 , "None"));
Path.Add(new Vector3(-4652.092 , -1829.323 , 85.32047 , "None"));
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


public sealed class RuntoFree : QuestFollowPathClass
{
    public RuntoFree()
    {
        Name = "RuntoFree";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 27;
        RequiredQuest = 0;

        Path.Add(new Vector3(-4751.789 , -1796.136 , -45.13585 , "None"));
Path.Add(new Vector3(-4769.674 , -1795.776 , -46.69309 , "None"));
Path.Add(new Vector3(-4785.279 , -1792.058 , -49.78605 , "None"));
Path.Add(new Vector3(-4820.132 , -1799.53 , -53.64928 , "None"));
Path.Add(new Vector3(-4851.304 , -1815.204 , -51.46403 , "None"));
Path.Add(new Vector3(-4885.284 , -1808.837 , -37.87386 , "None"));
Path.Add(new Vector3(-4898.378 , -1801.01 , -33.05138 , "None"));
Path.Add(new Vector3(-4913.198 , -1783.477 , -39.26551 , "None"));
Path.Add(new Vector3(-4937.306 , -1758.233 , -55.18812 , "None"));
Path.Add(new Vector3(-4953.915 , -1727.946 , -60.6612 , "None"));
Path.Add(new Vector3(-4954.017 , -1692.74 , -58.02442 , "None"));
Path.Add(new Vector3(-4953.328 , -1658.261 , -49.92979 , "None"));
Path.Add(new Vector3(-4962.3 , -1623.347 , -44.50023 , "None"));
Path.Add(new Vector3(-4970.992 , -1588.382 , -43.68928 , "None"));
Path.Add(new Vector3(-4972.61 , -1560.523 , -46.94108 , "None"));
Path.Add(new Vector3(-4959.918 , -1533.013 , -46.87558 , "None"));
Path.Add(new Vector3(-4936.181 , -1507.5 , -49.01413 , "None"));
Path.Add(new Vector3(-4911.941 , -1480.982 , -48.52166 , "None"));
Path.Add(new Vector3(-4893.009 , -1450.33 , -50.87166 , "None"));
Path.Add(new Vector3(-4875.204 , -1420.319 , -50.68805 , "None"));
Path.Add(new Vector3(-4850.026 , -1394.554 , -52.99816 , "None"));
Path.Add(new Vector3(-4823.068 , -1372.362 , -54.09451 , "None"));
Path.Add(new Vector3(-4795.904 , -1350.436 , -53.4955 , "None"));
Path.Add(new Vector3(-4775.587 , -1320.809 , -49.98666 , "None"));
Path.Add(new Vector3(-4757.729 , -1290.879 , -48.67317 , "None"));
Path.Add(new Vector3(-4748.908 , -1269.695 , -52.28302 , "None"));
Path.Add(new Vector3(-4747.438 , -1253.387 , -53.80455 , "None"));
Path.Add(new Vector3(-4756.805 , -1204.045 , -52.66729 , "None"));
Path.Add(new Vector3(-4750.504 , -1170.206 , -42.39683 , "None"));
Path.Add(new Vector3(-4735.384 , -1138.794 , -40.28019 , "None"));
Path.Add(new Vector3(-4729.356 , -1125.927 , -46.66673 , "None"));
Path.Add(new Vector3(-4725.436 , -1111.108 , -51.46104 , "None"));
Path.Add(new Vector3(-4711.847 , -1100.84 , -55.0728 , "None"));
Path.Add(new Vector3(-4689.178 , -1100.89 , -51.86592 , "None"));
Path.Add(new Vector3(-4653.435 , -1103.735 , -53.10867 , "None"));
Path.Add(new Vector3(-4620.963 , -1091.666 , -52.26963 , "None"));
Path.Add(new Vector3(-4591.686 , -1070.759 , -48.42406 , "None"));
Path.Add(new Vector3(-4564.738 , -1046.837 , -54.51067 , "None"));
Path.Add(new Vector3(-4540.261 , -1021.92 , -56.46606 , "None"));
Path.Add(new Vector3(-4514.411 , -996.8472 , -56.49443 , "None"));
Path.Add(new Vector3(-4484.656 , -978.6502 , -56.95635 , "None"));
Path.Add(new Vector3(-4453.911 , -962.1 , -57.5989 , "None"));
Path.Add(new Vector3(-4428.886 , -937.0081 , -57.62248 , "None"));
Path.Add(new Vector3(-4410.874 , -905.7828 , -57.66464 , "None"));
Path.Add(new Vector3(-4396.948 , -877.4084 , -57.6273 , "None"));
Path.Add(new Vector3(-4376.364 , -843.0721 , -57.65441 , "None"));
Path.Add(new Vector3(-4354.596 , -815.0264 , -55.88895 , "None"));
Path.Add(new Vector3(-4358.769 , -780.2239 , -48.50655 , "None"));
Path.Add(new Vector3(-4384.678 , -762.6171 , -40.7973 , "None"));
Path.Add(new Vector3(-4401.054 , -761.1583 , -42.70915 , "None"));
Path.Add(new Vector3(-4435.924 , -759.1899 , -41.23262 , "None"));
Path.Add(new Vector3(-4461.514 , -764.7383 , -38.92414 , "None"));
Path.Add(new Vector3(-4484.273 , -772.3808 , -38.38906 , "None"));
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


public sealed class PATHFeralasFPTanaris : QuestFollowPathClass
{
    public PATHFeralasFPTanaris()
    {
        Name = "PATH: Feralas FP - Tanaris";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 52;
        RequiredQuest = 0;

        Path.Add(new Vector3(-4480.444 , -772.3167 , -38.69633 , "None"));
Path.Add(new Vector3(-4468.052 , -791.623 , -48.19213 , "None"));
Path.Add(new Vector3(-4445.811 , -819.9942 , -54.10936 , "None"));
Path.Add(new Vector3(-4421.738 , -842.6849 , -55.77565 , "None"));
Path.Add(new Vector3(-4406.819 , -874.8796 , -56.10344 , "None"));
Path.Add(new Vector3(-4412.856 , -908.6455 , -57.68678 , "None"));
Path.Add(new Vector3(-4429.55 , -938.0793 , -57.63913 , "None"));
Path.Add(new Vector3(-4452.674 , -965.3889 , -57.7476 , "None"));
Path.Add(new Vector3(-4483.037 , -982.2925 , -56.86901 , "None"));
Path.Add(new Vector3(-4515.798 , -997.3314 , -56.54964 , "None"));
Path.Add(new Vector3(-4544.617 , -1016.857 , -56.92142 , "None"));
Path.Add(new Vector3(-4566.715 , -1045.171 , -53.50305 , "None"));
Path.Add(new Vector3(-4592.654 , -1069.817 , -48.03305 , "None"));
Path.Add(new Vector3(-4621.499 , -1089.517 , -52.04369 , "None"));
Path.Add(new Vector3(-4653.283 , -1103.66 , -53.10566 , "None"));
Path.Add(new Vector3(-4694.618 , -1104.386 , -52.10435 , "None"));
Path.Add(new Vector3(-4727.873 , -1111.794 , -50.76226 , "None"));
Path.Add(new Vector3(-4733.228 , -1134.874 , -42.81226 , "None"));
Path.Add(new Vector3(-4745.056 , -1157.046 , -40.30198 , "None"));
Path.Add(new Vector3(-4753.054 , -1191.909 , -49.36698 , "None"));
Path.Add(new Vector3(-4753.349 , -1226.832 , -54.8462 , "None"));
Path.Add(new Vector3(-4753.945 , -1261.661 , -52.96088 , "None"));
Path.Add(new Vector3(-4763.028 , -1296.396 , -48.6329 , "None"));
Path.Add(new Vector3(-4780.776 , -1326.481 , -50.65145 , "None"));
Path.Add(new Vector3(-4803.322 , -1354.351 , -53.51711 , "None"));
Path.Add(new Vector3(-4830.921 , -1377.528 , -53.8675 , "None"));
Path.Add(new Vector3(-4858.255 , -1399.189 , -53.22861 , "None"));
Path.Add(new Vector3(-4882.174 , -1424.438 , -50.41372 , "None"));
Path.Add(new Vector3(-4900.3 , -1455.58 , -49.41915 , "None"));
Path.Add(new Vector3(-4917.943 , -1485.711 , -47.88818 , "None"));
Path.Add(new Vector3(-4942.306 , -1512.161 , -48.98508 , "None"));
Path.Add(new Vector3(-4964.346 , -1540.249 , -45.9842 , "None"));
Path.Add(new Vector3(-4970.05 , -1574.591 , -45.35319 , "None"));
Path.Add(new Vector3(-4967.496 , -1609.412 , -43.28692 , "None"));
Path.Add(new Vector3(-4964.988 , -1645.375 , -47.24912 , "None"));
Path.Add(new Vector3(-4962.493 , -1681.339 , -50.47475 , "None"));
Path.Add(new Vector3(-4969.041 , -1714.852 , -61.20569 , "None"));
Path.Add(new Vector3(-4986.015 , -1739.42 , -63.63374 , "None"));
Path.Add(new Vector3(-5013.851 , -1761.113 , -65.55794 , "None"));
Path.Add(new Vector3(-5037.482 , -1764.651 , -65.71107 , "None"));
Path.Add(new Vector3(-5072.375 , -1763.186 , -66.60696 , "None"));
Path.Add(new Vector3(-5107.194 , -1760.755 , -65.52985 , "None"));
Path.Add(new Vector3(-5143.096 , -1757.762 , -65.8211 , "None"));
Path.Add(new Vector3(-5177.116 , -1751.272 , -63.45318 , "None"));
Path.Add(new Vector3(-5211.563 , -1761.104 , -61.73381 , "None"));
Path.Add(new Vector3(-5235.923 , -1785.071 , -59.91113 , "None"));
Path.Add(new Vector3(-5241.343 , -1819.409 , -62.00968 , "None"));
Path.Add(new Vector3(-5237.199 , -1854.035 , -63.05991 , "None"));
Path.Add(new Vector3(-5229.346 , -1889.22 , -64.19005 , "None"));
Path.Add(new Vector3(-5226.738 , -1925.086 , -63.76311 , "None"));
Path.Add(new Vector3(-5233.307 , -1960.416 , -60.98254 , "None"));
Path.Add(new Vector3(-5243.515 , -1993.821 , -60.13396 , "None"));
Path.Add(new Vector3(-5253.774 , -2027.21 , -62.54717 , "None"));
Path.Add(new Vector3(-5265.394 , -2061.297 , -61.55755 , "None"));
Path.Add(new Vector3(-5273.819 , -2095.032 , -59.54992 , "None"));
Path.Add(new Vector3(-5281.668 , -2130.217 , -53.76827 , "None"));
Path.Add(new Vector3(-5284.877 , -2154.613 , -51.13249 , "None"));
Path.Add(new Vector3(-5284.509 , -2178.941 , -52.98036 , "None"));
Path.Add(new Vector3(-5301.787 , -2209.292 , -54.96357 , "None"));
Path.Add(new Vector3(-5319.816 , -2240.504 , -53.94541 , "None"));
Path.Add(new Vector3(-5333.529 , -2272.621 , -54.36849 , "None"));
Path.Add(new Vector3(-5344.894 , -2306.768 , -53.6619 , "None"));
Path.Add(new Vector3(-5345.875 , -2342.574 , -46.94588 , "None"));
Path.Add(new Vector3(-5335.66 , -2375.9 , -43.57255 , "None"));
Path.Add(new Vector3(-5325.495 , -2410.482 , -44.11214 , "None"));
Path.Add(new Vector3(-5319.744 , -2428.118 , -44.26625 , "None"));
Path.Add(new Vector3(-5337.221 , -2383.679 , -43.16683 , "None"));
Path.Add(new Vector3(-5350.117 , -2351.262 , -44.88035 , "None"));
Path.Add(new Vector3(-5373.558 , -2341.112 , -45.17862 , "None"));
Path.Add(new Vector3(-5408.633 , -2349.458 , -33.8261 , "None"));
Path.Add(new Vector3(-5433.78 , -2342.187 , -37.98062 , "None"));
Path.Add(new Vector3(-5468.292 , -2338.715 , -43.99468 , "None"));
Path.Add(new Vector3(-5501.014 , -2350.606 , -45.44055 , "None"));
Path.Add(new Vector3(-5532.9 , -2367.198 , -49.87969 , "None"));
Path.Add(new Vector3(-5556.798 , -2393.936 , -51.45043 , "None"));
Path.Add(new Vector3(-5574.259 , -2424.103 , -51.42744 , "None"));
Path.Add(new Vector3(-5576.481 , -2456.886 , -49.08747 , "None"));
Path.Add(new Vector3(-5573.722 , -2476.344 , -49.29136 , "None"));
Path.Add(new Vector3(-5565.35 , -2519.211 , -52.81756 , "None"));
Path.Add(new Vector3(-5560.121 , -2543.719 , -57.03243 , "None"));
Path.Add(new Vector3(-5550.808 , -2564.284 , -57.57396 , "None"));
Path.Add(new Vector3(-5529.209 , -2579.075 , -56.97486 , "None"));
Path.Add(new Vector3(-5512.602 , -2622.356 , -52.9491 , "None"));
Path.Add(new Vector3(-5511.988 , -2657.113 , -50.16556 , "None"));
Path.Add(new Vector3(-5523.574 , -2691.115 , -49.62566 , "None"));
Path.Add(new Vector3(-5531.843 , -2708.885 , -50.95048 , "None"));
Path.Add(new Vector3(-5543.995 , -2741.379 , -49.5887 , "None"));
Path.Add(new Vector3(-5546.267 , -2777.234 , -52.82338 , "None"));
Path.Add(new Vector3(-5551.208 , -2812.928 , -53.35423 , "None"));
Path.Add(new Vector3(-5562.63 , -2845.757 , -54.56334 , "None"));
Path.Add(new Vector3(-5582.228 , -2875.924 , -50.16028 , "None"));
Path.Add(new Vector3(-5599.391 , -2906.326 , -47.99686 , "None"));
Path.Add(new Vector3(-5612.274 , -2939.85 , -50.1033 , "None"));
Path.Add(new Vector3(-5616.249 , -2975.601 , -51.51339 , "None"));
Path.Add(new Vector3(-5616.246 , -3010.471 , -50.69268 , "None"));
Path.Add(new Vector3(-5613.021 , -3046.35 , -51.58935 , "None"));
Path.Add(new Vector3(-5605.271 , -3080.32 , -51.37992 , "None"));
Path.Add(new Vector3(-5595.252 , -3113.777 , -46.87477 , "None"));
Path.Add(new Vector3(-5585.344 , -3148.36 , -41.65366 , "None"));
Path.Add(new Vector3(-5580.682 , -3182.95 , -39.35365 , "None"));
Path.Add(new Vector3(-5574.338 , -3218.418 , -44.09201 , "None"));
Path.Add(new Vector3(-5567.286 , -3252.628 , -46.21144 , "None"));
Path.Add(new Vector3(-5566.651 , -3288.209 , -43.78279 , "None"));
Path.Add(new Vector3(-5581.688 , -3319.633 , -40.20626 , "None"));
Path.Add(new Vector3(-5598.652 , -3351.436 , -38.61559 , "None"));
Path.Add(new Vector3(-5609.089 , -3380.149 , -39.99517 , "None"));
Path.Add(new Vector3(-5618.752 , -3411.452 , -46.59837 , "None"));
Path.Add(new Vector3(-5629.055 , -3444.828 , -49.70108 , "None"));
Path.Add(new Vector3(-5643.836 , -3477.465 , -54.72326 , "None"));
Path.Add(new Vector3(-5668.188 , -3502.463 , -58.1516 , "None"));
Path.Add(new Vector3(-5693.961 , -3527.669 , -59.43098 , "None"));
Path.Add(new Vector3(-5720.1 , -3552.495 , -60.09698 , "None"));
Path.Add(new Vector3(-5747.023 , -3574.713 , -60.0565 , "None"));
Path.Add(new Vector3(-5775.617 , -3594.766 , -59.97518 , "None"));
Path.Add(new Vector3(-5805.455 , -3614.897 , -59.83809 , "None"));
Path.Add(new Vector3(-5834.306 , -3634.363 , -59.93147 , "None"));
Path.Add(new Vector3(-5864.19 , -3654.525 , -60.028 , "None"));
Path.Add(new Vector3(-5893.146 , -3674.062 , -59.34742 , "None"));
Path.Add(new Vector3(-5926.089 , -3688.339 , -59.38253 , "None"));
Path.Add(new Vector3(-5959.402 , -3698.841 , -59.70604 , "None"));
Path.Add(new Vector3(-5993.827 , -3709.543 , -59.87636 , "None"));
Path.Add(new Vector3(-6028.104 , -3715.659 , -60.04228 , "None"));
Path.Add(new Vector3(-6063.907 , -3711.613 , -60.24188 , "None"));
Path.Add(new Vector3(-6099.819 , -3708.464 , -60.31849 , "None"));
Path.Add(new Vector3(-6134.566 , -3705.807 , -60.02983 , "None"));
Path.Add(new Vector3(-6169.42 , -3703.508 , -59.91038 , "None"));
Path.Add(new Vector3(-6205.435 , -3701.984 , -60.00119 , "None"));
Path.Add(new Vector3(-6240.358 , -3701.47 , -59.93843 , "None"));
Path.Add(new Vector3(-6276.388 , -3702.521 , -60.00883 , "None"));
Path.Add(new Vector3(-6311.254 , -3704.627 , -60.0551 , "None"));
Path.Add(new Vector3(-6347.239 , -3706.801 , -60.07463 , "None"));
Path.Add(new Vector3(-6383.192 , -3708.973 , -60.03059 , "None"));
Path.Add(new Vector3(-6418.059 , -3711.08 , -59.98247 , "None"));
Path.Add(new Vector3(-6452.925 , -3713.186 , -60.28263 , "None"));
Path.Add(new Vector3(-6488.91 , -3715.36 , -60.34583 , "None"));
Path.Add(new Vector3(-6524.894 , -3717.534 , -60.34518 , "None"));
Path.Add(new Vector3(-6559.76 , -3719.64 , -60.32835 , "None"));
Path.Add(new Vector3(-6595.539 , -3723.921 , -60.13741 , "None"));
Path.Add(new Vector3(-6630.207 , -3727.667 , -59.94438 , "None"));
Path.Add(new Vector3(-6661.791 , -3714.13 , -58.77805 , "None"));
Path.Add(new Vector3(-6692.463 , -3695.908 , -52.59752 , "None"));
Path.Add(new Vector3(-6737.82 , -3701.157 , -28.40192 , "None"));
Path.Add(new Vector3(-6762.905 , -3701.814 , -17.80228 , "None"));
Path.Add(new Vector3(-6777.424 , -3717.997 , -8.757334 , "None"));
Path.Add(new Vector3(-6795.223 , -3741.426 , 6.045944 , "None"));
Path.Add(new Vector3(-6820.826 , -3753.336 , 20.66388 , "None"));
Path.Add(new Vector3(-6844.579 , -3753.991 , 32.27228 , "None"));
Path.Add(new Vector3(-6876.721 , -3770.11 , 47.10707 , "None"));
Path.Add(new Vector3(-6897.403 , -3770.307 , 55.11233 , "None"));
Path.Add(new Vector3(-6922.473 , -3737.356 , 55.06774 , "None"));
Path.Add(new Vector3(-6942.911 , -3719.823 , 46.70367 , "None"));
Path.Add(new Vector3(-6961.313 , -3711.734 , 37.9999 , "None"));
Path.Add(new Vector3(-6982.095 , -3717.989 , 31.47733 , "None"));
Path.Add(new Vector3(-7014.184 , -3694.082 , 22.05343 , "None"));
Path.Add(new Vector3(-7036.518 , -3680.624 , 16.70323 , "None"));
Path.Add(new Vector3(-7057.253 , -3673.776 , 13.58501 , "None"));
Path.Add(new Vector3(-7073.357 , -3697.883 , 9.65417 , "None"));
Path.Add(new Vector3(-7080.263 , -3733.265 , 8.686476 , "None"));
Path.Add(new Vector3(-7085.423 , -3751.994 , 8.797802 , "None"));
Path.Add(new Vector3(-7100.209 , -3757.163 , 8.371643 , "None"));
Path.Add(new Vector3(-7124.181 , -3756.538 , 8.738297 , "None"));
Path.Add(new Vector3(-7148.517 , -3759.86 , 8.734884 , "None"));
Path.Add(new Vector3(-7167.474 , -3768.26 , 8.370224 , "None"));
Path.Add(new Vector3(-7191.89 , -3773.954 , 8.730886 , "None"));
Path.Add(new Vector3(-7216.963 , -3775.556 , 8.373591 , "None"));
Path.Add(new Vector3(-7237.273 , -3772.349 , 8.630737 , "None"));
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


public sealed class GRND4244TanarisV1 : QuestGrinderClass
{
    public GRND4244TanarisV1()
    {
        Name = "GRND : 42-44 - Tanaris V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 43;
        RequiredQuest = 0;

        EntryTarget.Add(5423);
EntryTarget.Add(5425);
EntryTarget.Add(5419);
EntryTarget.Add(5429);
HotSpots.Add(new Vector3(-7057.467 , -3474.948 , 10.2241 , "None"));
HotSpots.Add(new Vector3(-7197.958 , -3209.711 , 11.19763 , "None"));
HotSpots.Add(new Vector3(-7488.294 , -3078.209 , 12.7916 , "None"));
HotSpots.Add(new Vector3(-7347.006 , -3497.688 , 12.43266 , "None"));
HotSpots.Add(new Vector3(-7455.444 , -3754.311 , 9.543866 , "None"));
HotSpots.Add(new Vector3(-7385.08 , -4106.746 , 8.878154 , "None"));
HotSpots.Add(new Vector3(-7790.631 , -4007.686 , 12.98522 , "None"));
HotSpots.Add(new Vector3(-7705.964 , -4054.691 , 8.877201 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 44;
}



public override bool HasQuest() { return true; }


}


public sealed class GRND4244TanarisV2 : QuestGrinderClass
{
    public GRND4244TanarisV2()
    {
        Name = "GRND : 42-44 - Tanaris V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 43;
        RequiredQuest = 0;

        EntryTarget.Add(8208);
EntryTarget.Add(5422);
EntryTarget.Add(5419);
EntryTarget.Add(5425);
EntryTarget.Add(5428);
HotSpots.Add(new Vector3(-7408.688 , -3826.5 , 9.396318 , "None"));
HotSpots.Add(new Vector3(-7443.349 , -3642.128 , 9.077949 , "None"));
HotSpots.Add(new Vector3(-7322.496 , -3489.282 , 9.338612 , "None"));
HotSpots.Add(new Vector3(-7108.857 , -3551.378 , 11.24076 , "None"));
HotSpots.Add(new Vector3(-7043.303 , -3390.114 , 9.897961 , "None"));
HotSpots.Add(new Vector3(-6996.893 , -3262.266 , 9.718349 , "None"));
HotSpots.Add(new Vector3(-7171.079 , -3173.701 , 10.11136 , "None"));
HotSpots.Add(new Vector3(-7332.303 , -3244.528 , 10.75039 , "None"));
HotSpots.Add(new Vector3(-7386.406 , -3021.089 , 11.41237 , "None"));
HotSpots.Add(new Vector3(-7493.78 , -3206.401 , 17.81244 , "None"));
HotSpots.Add(new Vector3(-7432.745 , -3392.507 , 10.8836 , "None"));
HotSpots.Add(new Vector3(-7533.783 , -3525.252 , 13.21381 , "None"));
HotSpots.Add(new Vector3(-7660.822 , -3554.46 , 21.37522 , "None"));
HotSpots.Add(new Vector3(-7582.394 , -3833.721 , 10.28431 , "None"));
HotSpots.Add(new Vector3(-7758.004 , -3934.067 , 10.01427 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 44;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND4445Tanaris : QuestGrinderClass
{
    public GRIND4445Tanaris()
    {
        Name = "GRIND :  44-45 - Tanaris";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 44;
        RequiredQuest = 0;

        EntryTarget.Add(5419);
EntryTarget.Add(5428);
EntryTarget.Add(5425);
EntryTarget.Add(5423);
EntryTarget.Add(5420);
EntryTarget.Add(5429);
EntryTarget.Add(5426);
HotSpots.Add(new Vector3(-7354.026 , -3027.428 , 12.69763 , "None"));
HotSpots.Add(new Vector3(-7593.972 , -2952.727 , 12.02827 , "None"));
HotSpots.Add(new Vector3(-7727.32 , -3159.763 , 68.81554 , "None"));
HotSpots.Add(new Vector3(-7553.71 , -3387.391 , 32.87475 , "None"));
HotSpots.Add(new Vector3(-7644.676 , -3473.711 , 25.77739 , "None"));
HotSpots.Add(new Vector3(-7834.059 , -3561.614 , 56.89992 , "None"));
HotSpots.Add(new Vector3(-8048.086 , -3440.178 , 44.48518 , "None"));
HotSpots.Add(new Vector3(-8130.59 , -3485.452 , 47.35089 , "None"));
HotSpots.Add(new Vector3(-8000.415 , -3589.408 , 54.9279 , "None"));
HotSpots.Add(new Vector3(-7846.682 , -3653.679 , 51.51742 , "None"));
HotSpots.Add(new Vector3(-7847.491 , -3817.056 , 39.22218 , "None"));
HotSpots.Add(new Vector3(-7957.38 , -4020.475 , 10.13322 , "None"));
HotSpots.Add(new Vector3(-8141.599 , -4151.685 , 10.85548 , "None"));
HotSpots.Add(new Vector3(-8229.434 , -4368.063 , 9.469662 , "None"));
HotSpots.Add(new Vector3(-8310.303 , -4432.082 , 11.94008 , "None"));
HotSpots.Add(new Vector3(-8366.834 , -4443.813 , 9.56837 , "None"));
HotSpots.Add(new Vector3(-8566.454 , -4484.506 , 10.39525 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return true;
	}





public override bool HasQuest() { return true; }


}


public sealed class GRIND4548TanarisV1 : QuestGrinderClass
{
    public GRIND4548TanarisV1()
    {
        Name = "GRIND : 45 - 48 - Tanaris V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 47;
        RequiredQuest = 0;

        EntryTarget.Add(5420);
EntryTarget.Add(5424);
EntryTarget.Add(5426);
EntryTarget.Add(5465);
HotSpots.Add(new Vector3(-8647.336 , -4122.816 , 29.88823 , "None"));
HotSpots.Add(new Vector3(-8489.856 , -4277.645 , 9.385013 , "None"));
HotSpots.Add(new Vector3(-8433.413 , -4117.42 , 13.49351 , "None"));
HotSpots.Add(new Vector3(-8377.358 , -4038.335 , 11.73144 , "None"));
HotSpots.Add(new Vector3(-8589.702 , -3951.474 , 40.6259 , "None"));
HotSpots.Add(new Vector3(-8648.381 , -3802.482 , 23.07888 , "None"));
HotSpots.Add(new Vector3(-8520.259 , -3689.335 , 19.25694 , "None"));
HotSpots.Add(new Vector3(-8564.917 , -3518.775 , 10.14025 , "None"));
HotSpots.Add(new Vector3(-8518.335 , -3226.212 , 8.624897 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 48;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND4548TanarisV2 : QuestGrinderClass
{
    public GRIND4548TanarisV2()
    {
        Name = "GRIND : 45 - 48 - Tanaris V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 47;
        RequiredQuest = 0;

        EntryTarget.Add(5420);
EntryTarget.Add(5424);
EntryTarget.Add(5427);
EntryTarget.Add(8667);
EntryTarget.Add(5465);
EntryTarget.Add(5426);
HotSpots.Add(new Vector3(-8308.169 , -2630.412 , 31.77203 , "None"));
HotSpots.Add(new Vector3(-8311.083 , -2730.118 , 22.58449 , "None"));
HotSpots.Add(new Vector3(-8592.489 , -2660.365 , 22.03576 , "None"));
HotSpots.Add(new Vector3(-8787.538 , -2644.527 , 22.63885 , "None"));
HotSpots.Add(new Vector3(-8825.89 , -2757.073 , 27.05281 , "None"));
HotSpots.Add(new Vector3(-8622.032 , -3012.744 , 13.60993 , "None"));
HotSpots.Add(new Vector3(-8574.423 , -3151.339 , 11.25581 , "None"));
HotSpots.Add(new Vector3(-8524.913 , -3277.455 , 8.882183 , "None"));
HotSpots.Add(new Vector3(-8699.543 , -3349.016 , 8.786687 , "None"));
HotSpots.Add(new Vector3(-8538.542 , -3478.901 , 8.671853 , "None"));
HotSpots.Add(new Vector3(-8434.416 , -3557.319 , 13.0111 , "None"));
HotSpots.Add(new Vector3(-8489.143 , -3704.001 , 17.91449 , "None"));
HotSpots.Add(new Vector3(-8685.608 , -3841.217 , 37.78758 , "None"));
HotSpots.Add(new Vector3(-8560.85 , -3927.345 , 40.89297 , "None"));
HotSpots.Add(new Vector3(-8665.754 , -4089.854 , 36.30266 , "None"));
HotSpots.Add(new Vector3(-8648.519 , -4236.276 , 18.61778 , "None"));
HotSpots.Add(new Vector3(-8711.407 , -4310.06 , 14.26739 , "None"));
HotSpots.Add(new Vector3(-8631.297 , -4437.879 , 12.51321 , "None"));
HotSpots.Add(new Vector3(-8620.816 , -4486.334 , 9.188789 , "None"));
HotSpots.Add(new Vector3(-8453.514 , -4474.245 , 9.109317 , "None"));
HotSpots.Add(new Vector3(-8247.487 , -4416.158 , 11.89495 , "None"));
HotSpots.Add(new Vector3(-8233.052 , -3965.9 , 9.31631 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 48;
}



public override bool HasQuest() { return true; }


}


public sealed class TheThirstyGoblin : QuestGrinderClass
{
    public TheThirstyGoblin()
    {
        Name = "The Thirsty Goblin";

        QuestId.AddRange(new[] { 2605 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 49;
        RequiredQuest = 0;

        EntryTarget.Add(5481);
HotSpots.Add(new Vector3(-8967.512 , -2340.508 , 11.71942 , "None"));
HotSpots.Add(new Vector3(-9078.561 , -2216.938 , 10.95496 , "None"));
HotSpots.Add(new Vector3(-9026.935 , -2168.838 , 11.71272 , "None"));
HotSpots.Add(new Vector3(-8955.168 , -2280.195 , 9.155125 , "None"));
HotSpots.Add(new Vector3(-8818.408 , -2339.709 , 17.20818 , "None"));
HotSpots.Add(new Vector3(-8810.715 , -2163.772 , 10.43487 , "None"));

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
        MinLevel = 1;
        MaxLevel = 46;
        RequiredQuest = 0;

        EntryTarget.Add(5616);
EntryTarget.Add(5618);
HotSpots.Add(new Vector3(-6983.255 , -4344.634 , 10.18904 , "None"));
HotSpots.Add(new Vector3(-6960.65 , -4415.506 , 10.67225 , "None"));
HotSpots.Add(new Vector3(-6905.17 , -4359.041 , 13.55677 , "None"));
HotSpots.Add(new Vector3(-7260.616 , -4554.98 , 9.184292 , "None"));
HotSpots.Add(new Vector3(-7371.221 , -4545.25 , 11.42158 , "None"));
HotSpots.Add(new Vector3(-7346.482 , -4696.003 , 12.86586 , "None"));
HotSpots.Add(new Vector3(-7262.576 , -4654.909 , 12.43498 , "None"));

    }

	public override bool CanConditions()
	{
        return ItemsManager.GetItemCountById(8483) >= 5;
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
        MinLevel = 1;
        MaxLevel = 46;
        RequiredQuest = 0;

        EntryTarget.Add(5616);
EntryTarget.Add(5618);
HotSpots.Add(new Vector3(-6983.255 , -4344.634 , 10.18904 , "None"));
HotSpots.Add(new Vector3(-6960.65 , -4415.506 , 10.67225 , "None"));
HotSpots.Add(new Vector3(-6905.17 , -4359.041 , 13.55677 , "None"));
HotSpots.Add(new Vector3(-7260.781 , -4555.559 , 9.208517 , "None"));
HotSpots.Add(new Vector3(-7371.221 , -4545.25 , 11.42158 , "None"));
HotSpots.Add(new Vector3(-7346.482 , -4696.003 , 12.86586 , "None"));
HotSpots.Add(new Vector3(-7262.576 , -4654.909 , 12.43498 , "None"));

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

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 47;
        RequiredQuest = 0;

        EntryTarget.Add(5474);
EntryTarget.Add(5472);
HotSpots.Add(new Vector3(-8395.78 , -3179.31 , 8.762014 , "None"));
HotSpots.Add(new Vector3(-8248.183 , -3125.531 , 9.753552 , "None"));
HotSpots.Add(new Vector3(-8191.086 , -3052.781 , 13.50843 , "None"));
HotSpots.Add(new Vector3(-8198.624 , -2958.578 , 18.17596 , "None"));
HotSpots.Add(new Vector3(-8223.945 , -2884.817 , 20.91442 , "None"));
HotSpots.Add(new Vector3(-8269.708 , -2832.844 , 16.29895 , "None"));
HotSpots.Add(new Vector3(-8313.801 , -2839.682 , 12.61753 , "None"));
HotSpots.Add(new Vector3(-8391.729 , -2838.289 , 8.787032 , "None"));
HotSpots.Add(new Vector3(-8476.584 , -2799.564 , 10.94863 , "None"));
HotSpots.Add(new Vector3(-8545.696 , -2801.666 , 11.26326 , "None"));
HotSpots.Add(new Vector3(-8577.2 , -2859.894 , 8.913218 , "None"));
HotSpots.Add(new Vector3(-8578.933 , -2952.944 , 9.754522 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WANTEDCaliphScorpidsting : QuestGrinderClass
{
    public WANTEDCaliphScorpidsting()
    {
        Name = "WANTED: Caliph Scorpidsting";

        QuestId.AddRange(new[] { 2781 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 47;
        RequiredQuest = 0;

        EntryTarget.Add(7847);
HotSpots.Add(new Vector3(-7618.719 , -4520.39 , 9.352122 , "None"));
HotSpots.Add(new Vector3(-7596.066 , -4434.955 , 9.57349 , "None"));
HotSpots.Add(new Vector3(-7473.871 , -4579.496 , 9.136621 , "None"));

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
        MinLevel = 1;
        MaxLevel = 47;
        RequiredQuest = 0;

        EntryTarget.Add(5485);
EntryTarget.Add(5490);
HotSpots.Add(new Vector3(-8719.718 , -2210.501 , 10.96793 , "None"));
HotSpots.Add(new Vector3(-8902.368 , -2367.657 , 14.83236 , "None"));
HotSpots.Add(new Vector3(-8981.976 , -2277.741 , 9.778836 , "None"));
HotSpots.Add(new Vector3(-9082.694 , -2162.634 , 12.16793 , "None"));
HotSpots.Add(new Vector3(-8902.029 , -2114.62 , 10.77708 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GRIND4851Tanaris : QuestGrinderClass
{
    public GRIND4851Tanaris()
    {
        Name = "GRIND : 48 - 51 - Tanaris";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryTarget.Add(5424);
EntryTarget.Add(5421);
EntryTarget.Add(5430);
EntryTarget.Add(5427);
EntryTarget.Add(9397);
EntryTarget.Add(5475);
EntryTarget.Add(5472);
EntryTarget.Add(5471);
HotSpots.Add(new Vector3(-8304.325 , -2244.921 , 9.905934 , "None"));
HotSpots.Add(new Vector3(-8501.867 , -2171.697 , 15.17482 , "None"));
HotSpots.Add(new Vector3(-8469.21 , -1998.223 , 12.11607 , "None"));
HotSpots.Add(new Vector3(-8650.6 , -2371.67 , 26.17634 , "None"));
HotSpots.Add(new Vector3(-8535.37 , -2517.849 , 45.87543 , "None"));
HotSpots.Add(new Vector3(-8811.019 , -2530.586 , 10.42275 , "None"));
HotSpots.Add(new Vector3(-8922.103 , -2477.931 , 11.96368 , "None"));
HotSpots.Add(new Vector3(-9130.489 , -2294.875 , 10.31527 , "None"));
HotSpots.Add(new Vector3(-9268.446 , -2221.969 , 10.7776 , "None"));
HotSpots.Add(new Vector3(-9437.507 , -2309.027 , 12.07781 , "None"));
HotSpots.Add(new Vector3(-9355.995 , -2553.235 , 13.87007 , "None"));
HotSpots.Add(new Vector3(-9240.305 , -2692.722 , 15.90615 , "None"));
HotSpots.Add(new Vector3(-9144.072 , -2783.932 , 26.15303 , "None"));
HotSpots.Add(new Vector3(-8901.59 , -3064.66 , 44.46363 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 51;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND4851TanarisV2 : QuestGrinderClass
{
    public GRIND4851TanarisV2()
    {
        Name = "GRIND : 48 - 51 - Tanaris V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryTarget.Add(5441);
EntryTarget.Add(5427);
EntryTarget.Add(5421);
EntryTarget.Add(5471);
EntryTarget.Add(5475);
EntryTarget.Add(5474);
EntryTarget.Add(5430);
HotSpots.Add(new Vector3(-8823.112 , -3184.275 , 22.15799 , "None"));
HotSpots.Add(new Vector3(-8876.335 , -3044.849 , 40.25322 , "None"));
HotSpots.Add(new Vector3(-8852.577 , -2928.354 , 39.08033 , "None"));
HotSpots.Add(new Vector3(-9004.479 , -2847.031 , 46.79795 , "None"));
HotSpots.Add(new Vector3(-9045.68 , -2808.555 , 42.05167 , "None"));
HotSpots.Add(new Vector3(-9127.813 , -2772.783 , 31.11283 , "None"));
HotSpots.Add(new Vector3(-9258.612 , -2760.679 , 12.72721 , "None"));
HotSpots.Add(new Vector3(-9356.231 , -2614.341 , 10.43934 , "None"));
HotSpots.Add(new Vector3(-9439.135 , -2475 , 12.73062 , "None"));
HotSpots.Add(new Vector3(-9286.506 , -2366.016 , 8.830372 , "None"));
HotSpots.Add(new Vector3(-9196.697 , -2277.442 , 12.04052 , "None"));
HotSpots.Add(new Vector3(-9057.378 , -2492.621 , 14.10002 , "None"));
HotSpots.Add(new Vector3(-9041.19 , -2550.453 , 21.19054 , "None"));
HotSpots.Add(new Vector3(-8983.867 , -2735.937 , 40.56859 , "None"));
HotSpots.Add(new Vector3(-8724.529 , -2436.933 , 24.14123 , "None"));
HotSpots.Add(new Vector3(-8603.816 , -2436.338 , 40.26291 , "None"));
HotSpots.Add(new Vector3(-8582.584 , -2062.589 , 8.920472 , "None"));
HotSpots.Add(new Vector3(-8482.087 , -2016.855 , 11.18516 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 51;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND4851UngoroV3 : QuestGrinderClass
{
    public GRIND4851UngoroV3()
    {
        Name = "GRIND : 48 - 51 - Ungoro V3";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 1;
        MaxLevel = 50;
        RequiredQuest = 0;

        EntryTarget.Add(6511);
EntryTarget.Add(6509);
EntryTarget.Add(6505);
EntryTarget.Add(9683);
EntryTarget.Add(6506);
HotSpots.Add(new Vector3(-7550.989 , -2111.6 , -271.9986 , "None"));
HotSpots.Add(new Vector3(-7591.31 , -1957.7 , -269.6481 , "None"));
HotSpots.Add(new Vector3(-7694.051 , -1831.341 , -271.2398 , "None"));
HotSpots.Add(new Vector3(-7681.33 , -1734.302 , -271.6068 , "None"));
HotSpots.Add(new Vector3(-7785.053 , -1851.934 , -272.5993 , "None"));
HotSpots.Add(new Vector3(-7930.68 , -1847.178 , -270.3175 , "None"));
HotSpots.Add(new Vector3(-7938.622 , -1721.946 , -274.766 , "None"));
HotSpots.Add(new Vector3(-7491.284 , -1970.001 , -272.1248 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 3;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 51;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND5154UngoroInsects : QuestGrinderClass
{
    public GRIND5154UngoroInsects()
    {
        Name = "GRIND : 51 - 54 - Ungoro Insects";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 51;
        MaxLevel = 53;
        RequiredQuest = 0;

        EntryTarget.Add(6553);
EntryTarget.Add(6552);
EntryTarget.Add(6551);
EntryTarget.Add(9166);
EntryTarget.Add(9163);
EntryTarget.Add(6557);
EntryTarget.Add(6510);
HotSpots.Add(new Vector3(-8069.573 , -1499.484 , -270.386 , "None"));
HotSpots.Add(new Vector3(-8100.848 , -1449.285 , -268.9731 , "None"));
HotSpots.Add(new Vector3(-8018.66 , -1378.194 , -271.8242 , "None"));
HotSpots.Add(new Vector3(-8101.449 , -1193.131 , -268.9734 , "None"));
HotSpots.Add(new Vector3(-7998.814 , -1049.488 , -271.6991 , "None"));
HotSpots.Add(new Vector3(-7809.266 , -1228.581 , -264.7943 , "None"));
HotSpots.Add(new Vector3(-7865.479 , -1398.913 , -269.2011 , "None"));
HotSpots.Add(new Vector3(-7681.031 , -1588.438 , -271.9373 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 54;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND5154UngoroInsectsV2 : QuestGrinderClass
{
    public GRIND5154UngoroInsectsV2()
    {
        Name = "GRIND : 51 - 54 - Ungoro Insects V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 51;
        MaxLevel = 53;
        RequiredQuest = 0;

        EntryTarget.Add(6551);
EntryTarget.Add(6552);
EntryTarget.Add(6553);
EntryTarget.Add(9163);
EntryTarget.Add(6557);
EntryTarget.Add(6510);
EntryTarget.Add(9166);
HotSpots.Add(new Vector3(-8078.095 , -1391.759 , -266.9421 , "None"));
HotSpots.Add(new Vector3(-8008.367 , -1067.171 , -270.9101 , "None"));
HotSpots.Add(new Vector3(-7830.519 , -1266.26 , -267.8676 , "None"));
HotSpots.Add(new Vector3(-7701.867 , -1181.955 , -270.5261 , "None"));
HotSpots.Add(new Vector3(-7608.346 , -1280.357 , -263.8904 , "None"));
HotSpots.Add(new Vector3(-7593.831 , -1183.201 , -267.7432 , "None"));
HotSpots.Add(new Vector3(-7655.194 , -1373.408 , -270.2356 , "None"));
HotSpots.Add(new Vector3(-7652.537 , -1576.225 , -272.2141 , "None"));
HotSpots.Add(new Vector3(-7397.427 , -1698.144 , -276.3729 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 54;
}



public override bool HasQuest() { return true; }


}


public sealed class BungleintheJungle : QuestGrinderClass
{
    public BungleintheJungle()
    {
        Name = "Bungle in the Jungle";

        QuestId.AddRange(new[] { 4496 });

        Step = new List<int> { 1, 5, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 51;
        MaxLevel = 53;
        RequiredQuest = 0;

        EntryTarget.Add(6552);
EntryTarget.Add(6551);
EntryTarget.Add(6553);
HotSpots.Add(new Vector3(-7867.336 , -1392.333 , -269.9445 , "None"));

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

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 51;
        MaxLevel = 53;
        RequiredQuest = 0;

        EntryTarget.Add(6518);
EntryTarget.Add(6519);
EntryTarget.Add(6527);
EntryTarget.Add(6517);
HotSpots.Add(new Vector3(-6544.146 , -1361.296 , -272.2212 , "None"));
HotSpots.Add(new Vector3(-6648.098 , -1319.165 , -273.8878 , "None"));
HotSpots.Add(new Vector3(-6554.257 , -1482.634 , -274.9018 , "None"));
HotSpots.Add(new Vector3(-6595.104 , -1450.966 , -281.8582 , "None"));
HotSpots.Add(new Vector3(-6686.389 , -1279.953 , -269.5498 , "None"));
HotSpots.Add(new Vector3(-6746.958 , -1289.79 , -270.0183 , "None"));

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
        Name = "The Fare of Larkorwi";

        QuestId.AddRange(new[] { 4290 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 51;
        MaxLevel = 53;
        RequiredQuest = 0;

        EntryIdObjects.Add(166863);
HotSpots.Add(new Vector3(-7368.505 , -2013.21 , -269.8246 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheApesofUngoro : QuestGrinderClass
{
    public TheApesofUngoro()
    {
        Name = "The Apes of Ungoro";

        QuestId.AddRange(new[] { 4289 });

        Step = new List<int> { 2, 2, 2, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 51;
        MaxLevel = 53;
        RequiredQuest = 0;

        EntryTarget.Add(6514);
EntryTarget.Add(6513);
EntryTarget.Add(6516);
HotSpots.Add(new Vector3(-6371.714 , -1827.563 , -260.4356 , "None"));
HotSpots.Add(new Vector3(-6368.517 , -1896.71 , -255.3425 , "None"));
HotSpots.Add(new Vector3(-6381.251 , -1751.781 , -271.6903 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheScentofLarKorwi : QuestGrinderClass
{
    public TheScentofLarKorwi()
    {
        Name = "The Scent of Lar'Korwi";

        QuestId.AddRange(new[] { 4291 });

        Step = new List<int> { 2, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 51;
        MaxLevel = 53;
        RequiredQuest = 0;

        EntryTarget.Add(9683);
HotSpots.Add(new Vector3(-7768.216 , -1957.564 , -271.7155 , "None"));
HotSpots.Add(new Vector3(-7875.791 , -1805.506 , -271.613 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ChasingAmie : QuestClass
{
    public ChasingAmie()
    {
        Name = "Chasing Amie";

        QuestId.AddRange(new[] { 4243 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 51;
        MaxLevel = 53;
        RequiredQuest = 0;


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

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 51;
        MaxLevel = 53;
        RequiredQuest = 0;

        HotSpots.Add(new Vector3(-8070.051 , -1269.12 , -330.1115 , "None"));
ItemId = 11132;
Range = 4.5f;

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

        Step = new List<int> { 1, 1, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 51;
        MaxLevel = 53;
        RequiredQuest = 0;

        EntryIdObjects.Add(161521);
EntryIdObjects.Add(161526);
HotSpots.Add(new Vector3(-7596.942 , -887.3661 , -271.5937 , "None"));
HotSpots.Add(new Vector3(-6867.972 , -2001.665 , -272.2096 , "None"));

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

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 51;
        MaxLevel = 53;
        RequiredQuest = 0;

        EntryTarget.Add(9167);
HotSpots.Add(new Vector3(-6982.541 , -259.2038 , -219.2229 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BewareofPterrodax : QuestGrinderClass
{
    public BewareofPterrodax()
    {
        Name = "Beware of Pterrodax";

        QuestId.AddRange(new[] { 4501 });

        Step = new List<int> { 10, 15, 0, 0, 0 };

        StepAutoDetect = new[] { true, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 51;
        MaxLevel = 53;
        RequiredQuest = 0;

        EntryTarget.Add(9166);
EntryTarget.Add(9167);
HotSpots.Add(new Vector3(-6218.485 , -1556.637 , -220.0038 , "None"));
HotSpots.Add(new Vector3(-6874.737 , -781.0146 , -271.606 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CrystalsofPower : QuestGathererClass
{
    public CrystalsofPower()
    {
        Name = "Crystals of Power";

        QuestId.AddRange(new[] { 4284 });

        Step = new List<int> { 7, 7, 7, 7, 0 };

        StepAutoDetect = new[] { true, true, true, true, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 51;
        MaxLevel = 53;
        RequiredQuest = 0;

        EntryIdObjects.Add(164659);
EntryIdObjects.Add(164658);
EntryIdObjects.Add(164661);
EntryIdObjects.Add(164660);
HotSpots.Add(new Vector3(-6300.813 , -1372.917 , -267.1987 , "None"));
HotSpots.Add(new Vector3(-6382.697 , -1087.407 , -271.8662 , "None"));
HotSpots.Add(new Vector3(-6495.277 , -1091.638 , -274.4866 , "None"));
HotSpots.Add(new Vector3(-6950.006 , -410.8103 , -268.1345 , "None"));
HotSpots.Add(new Vector3(-7023.187 , -353.5064 , -254.0507 , "None"));
HotSpots.Add(new Vector3(-7292.764 , -421.0921 , -269.7759 , "None"));
HotSpots.Add(new Vector3(-7421.544 , -341.3525 , -230.9511 , "None"));
HotSpots.Add(new Vector3(-7529.699 , -606.0833 , -265.7256 , "None"));
HotSpots.Add(new Vector3(-7603.152 , -866.3227 , -261.1454 , "None"));
HotSpots.Add(new Vector3(-7935.729 , -963.4507 , -275.5598 , "None"));
HotSpots.Add(new Vector3(-6830.457 , -1380.48 , -267.8502 , "None"));
HotSpots.Add(new Vector3(-6966.641 , -1764.536 , -266.9345 , "None"));
HotSpots.Add(new Vector3(-6964.069 , -1973.631 , -267.0486 , "None"));
HotSpots.Add(new Vector3(-7589.814 , -1621.701 , -271.2129 , "None"));
HotSpots.Add(new Vector3(-7826.5 , -1803.044 , -271.4449 , "None"));
HotSpots.Add(new Vector3(-7880.792 , -1700.625 , -272.0095 , "None"));
HotSpots.Add(new Vector3(-7825.229 , -1802.079 , -271.3149 , "None"));
HotSpots.Add(new Vector3(-7773.375 , -1937.607 , -272.3215 , "None"));
HotSpots.Add(new Vector3(-7784.102 , -2117.209 , -266.9697 , "None"));
HotSpots.Add(new Vector3(-7680.362 , -2038.953 , -271.705 , "None"));
HotSpots.Add(new Vector3(-7530.668 , -2119.565 , -270.6854 , "None"));
HotSpots.Add(new Vector3(-7121.618 , -2163.677 , -265.9183 , "None"));
HotSpots.Add(new Vector3(-7044.83 , -2296.889 , -269.2522 , "None"));
HotSpots.Add(new Vector3(-7197.113 , -2319.342 , -226.9137 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class NorthPylon : QuestInteractWithClass
{
    public NorthPylon()
    {
        Name = "North Pylon";

        QuestId.AddRange(new[] { 4285 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 51;
        MaxLevel = 53;
        RequiredQuest = 0;

        EntryIdTarget.Add(164955);
HotSpots.Add(new Vector3(-6273.256 , -1554.18 , -230.7433 , "None"));
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


public sealed class WestPylon : QuestInteractWithClass
{
    public WestPylon()
    {
        Name = "West Pylon";

        QuestId.AddRange(new[] { 4288 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 51;
        MaxLevel = 53;
        RequiredQuest = 0;

        EntryIdTarget.Add(164956);
HotSpots.Add(new Vector3(-7423.404 , -347.5974 , -232.0519 , "None"));
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


public sealed class EastPylon : QuestInteractWithClass
{
    public EastPylon()
    {
        Name = "East Pylon";

        QuestId.AddRange(new[] { 4287 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 51;
        MaxLevel = 53;
        RequiredQuest = 0;

        EntryIdTarget.Add(164957);
HotSpots.Add(new Vector3(-7197.113 , -2319.342 , -226.9137 , "None"));
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


public sealed class FindingtheSource : QuestUseItemOnClass
{
    public FindingtheSource()
    {
        Name = "Finding the Source";

        QuestId.AddRange(new[] { 974 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 51;
        MaxLevel = 53;
        RequiredQuest = 0;

        EntryIdTarget.Add(148503);
HotSpots.Add(new Vector3(-7162.563 , -1147.287 , -265.96 , "None"));
ItemId = 12472;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class PATHUngorotoTheramore : QuestFollowPathClass
{
    public PATHUngorotoTheramore()
    {
        Name = "PATH : Ungoro to Theramore";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 53;
        MaxLevel = 54;
        RequiredQuest = 0;

        Path.Add(new Vector3(-7904.715 , -2137.12 , -246.0282 , "None"));
Path.Add(new Vector3(-7918.767 , -2139.237 , -237.076 , "None"));
Path.Add(new Vector3(-7943.543 , -2136.803 , -226.4823 , "None"));
Path.Add(new Vector3(-7970.4 , -2125.207 , -215.4518 , "None"));
Path.Add(new Vector3(-7993.306 , -2116.016 , -207.278 , "None"));
Path.Add(new Vector3(-8017.255 , -2117.716 , -196.8278 , "None"));
Path.Add(new Vector3(-8052.144 , -2119.305 , -180.3831 , "None"));
Path.Add(new Vector3(-8064.181 , -2119.127 , -173.2643 , "None"));
Path.Add(new Vector3(-8086.728 , -2115.191 , -160.9971 , "None"));
Path.Add(new Vector3(-8105.845 , -2107.22 , -147.3275 , "None"));
Path.Add(new Vector3(-8128.21 , -2091.711 , -133.9435 , "None"));
Path.Add(new Vector3(-8150.533 , -2083.226 , -124.8402 , "None"));
Path.Add(new Vector3(-8186.22 , -2078.34 , -114.2546 , "None"));
Path.Add(new Vector3(-8220.951 , -2075.358 , -102.509 , "None"));
Path.Add(new Vector3(-8256.923 , -2073.006 , -89.73338 , "None"));
Path.Add(new Vector3(-8291.799 , -2074.855 , -73.1299 , "None"));
Path.Add(new Vector3(-8327.774 , -2077.16 , -59.13226 , "None"));
Path.Add(new Vector3(-8362.649 , -2079.121 , -46.93826 , "None"));
Path.Add(new Vector3(-8397.542 , -2080.715 , -35.35265 , "None"));
Path.Add(new Vector3(-8434.677 , -2082.338 , -23.62724 , "None"));
Path.Add(new Vector3(-8469.55 , -2084.195 , -12.8594 , "None"));
Path.Add(new Vector3(-8503.693 , -2091.094 , -2.044673 , "None"));
Path.Add(new Vector3(-8522.271 , -2109.695 , 4.669729 , "None"));
Path.Add(new Vector3(-8527.75 , -2125.049 , 8.891258 , "None"));
Path.Add(new Vector3(-8536.368 , -2158.899 , 10.07245 , "None"));
Path.Add(new Vector3(-8543.104 , -2185.355 , 16.1655 , "None"));
Path.Add(new Vector3(-8553.747 , -2206.877 , 18.57228 , "None"));
Path.Add(new Vector3(-8566.604 , -2232.175 , 21.78137 , "None"));
Path.Add(new Vector3(-8573.633 , -2258.53 , 22.31229 , "None"));
Path.Add(new Vector3(-8602.78 , -2280.895 , 21.46421 , "None"));
Path.Add(new Vector3(-8618.007 , -2310.679 , 23.89283 , "None"));
Path.Add(new Vector3(-8606.595 , -2343.618 , 31.32578 , "None"));
Path.Add(new Vector3(-8597.098 , -2378.332 , 35.13609 , "None"));
Path.Add(new Vector3(-8586.544 , -2411.62 , 38.41371 , "None"));
Path.Add(new Vector3(-8565.888 , -2440.598 , 39.63572 , "None"));
Path.Add(new Vector3(-8546.259 , -2469.194 , 41.11547 , "None"));
Path.Add(new Vector3(-8545.085 , -2503.757 , 45.48352 , "None"));
Path.Add(new Vector3(-8550.843 , -2538.863 , 47.89001 , "None"));
Path.Add(new Vector3(-8535.731 , -2569.848 , 45.43295 , "None"));
Path.Add(new Vector3(-8514.997 , -2597.953 , 41.78229 , "None"));
Path.Add(new Vector3(-8493.784 , -2627.081 , 36.44139 , "None"));
Path.Add(new Vector3(-8490.691 , -2659.759 , 33.32299 , "None"));
Path.Add(new Vector3(-8492.634 , -2682.633 , 30.13578 , "None"));
Path.Add(new Vector3(-8506.555 , -2714.394 , 21.97294 , "None"));
Path.Add(new Vector3(-8532.741 , -2738.908 , 15.68182 , "None"));
Path.Add(new Vector3(-8557.906 , -2762.548 , 12.37837 , "None"));
Path.Add(new Vector3(-8580.011 , -2790.704 , 16.20408 , "None"));
Path.Add(new Vector3(-8607.98 , -2811.525 , 14.50242 , "None"));
Path.Add(new Vector3(-8639.86 , -2821.68 , 14.70915 , "None"));
Path.Add(new Vector3(-8657.102 , -2851.831 , 15.10166 , "None"));
Path.Add(new Vector3(-8673.315 , -2882.828 , 15.04833 , "None"));
Path.Add(new Vector3(-8668.388 , -2918.356 , 13.49115 , "None"));
Path.Add(new Vector3(-8657.535 , -2951.523 , 10.825 , "None"));
Path.Add(new Vector3(-8648.571 , -2985.277 , 12.34432 , "None"));
Path.Add(new Vector3(-8639.615 , -3020.136 , 14.43711 , "None"));
Path.Add(new Vector3(-8622.978 , -3050.772 , 13.31201 , "None"));
Path.Add(new Vector3(-8620.484 , -3086.7 , 12.52015 , "None"));
Path.Add(new Vector3(-8615.979 , -3121.217 , 14.2671 , "None"));
Path.Add(new Vector3(-8607.481 , -3156.226 , 14.33124 , "None"));
Path.Add(new Vector3(-8599.315 , -3189.034 , 12.02802 , "None"));
Path.Add(new Vector3(-8605.937 , -3229.909 , 14.59414 , "None"));
Path.Add(new Vector3(-8610.477 , -3264.212 , 15.03989 , "None"));
Path.Add(new Vector3(-8613.374 , -3300.987 , 8.958838 , "None"));
Path.Add(new Vector3(-8612.681 , -3335.209 , 8.951775 , "None"));
Path.Add(new Vector3(-8609.831 , -3369.271 , 13.42552 , "None"));
Path.Add(new Vector3(-8601.56 , -3404.339 , 11.24813 , "None"));
Path.Add(new Vector3(-8588.895 , -3427.741 , 8.785977 , "None"));
Path.Add(new Vector3(-8568.261 , -3437.497 , 8.625757 , "None"));
Path.Add(new Vector3(-8552.275 , -3467.059 , 9.234433 , "None"));
Path.Add(new Vector3(-8544.728 , -3503.255 , 8.761404 , "None"));
Path.Add(new Vector3(-8537.859 , -3551.622 , 12.68332 , "None"));
Path.Add(new Vector3(-8528.342 , -3586.322 , 15.53788 , "None"));
Path.Add(new Vector3(-8508.132 , -3591.597 , 15.12763 , "None"));
Path.Add(new Vector3(-8486.835 , -3601.966 , 14.51311 , "None"));
Path.Add(new Vector3(-8485.107 , -3637.469 , 16.14027 , "None"));
Path.Add(new Vector3(-8489.248 , -3672.152 , 16.38686 , "None"));
Path.Add(new Vector3(-8485.491 , -3707.252 , 17.76895 , "None"));
Path.Add(new Vector3(-8461.799 , -3732.462 , 14.61498 , "None"));
Path.Add(new Vector3(-8431.963 , -3751.651 , 11.25838 , "None"));
Path.Add(new Vector3(-8406.271 , -3775.204 , 9.827917 , "None"));
Path.Add(new Vector3(-8373.179 , -3788.643 , 11.186 , "None"));
Path.Add(new Vector3(-8338.429 , -3787.61 , 12.85041 , "None"));
Path.Add(new Vector3(-8303.666 , -3795.043 , 12.51863 , "None"));
Path.Add(new Vector3(-8274.994 , -3813.958 , 12.72747 , "None"));
Path.Add(new Vector3(-8247.404 , -3836.868 , 12.82156 , "None"));
Path.Add(new Vector3(-8216.497 , -3853.143 , 12.19569 , "None"));
Path.Add(new Vector3(-8182.781 , -3865.006 , 8.89712 , "None"));
Path.Add(new Vector3(-8147.249 , -3862.62 , 12.22535 , "None"));
Path.Add(new Vector3(-8114.19 , -3873.774 , 15.18558 , "None"));
Path.Add(new Vector3(-8089.547 , -3899.966 , 12.88773 , "None"));
Path.Add(new Vector3(-8069.863 , -3928.817 , 9.311066 , "None"));
Path.Add(new Vector3(-8040.393 , -3945.605 , 9.042356 , "None"));
Path.Add(new Vector3(-8006.018 , -3939.592 , 10.64145 , "None"));
Path.Add(new Vector3(-7970.341 , -3934.472 , 12.752 , "None"));
Path.Add(new Vector3(-7936.303 , -3940.045 , 9.771088 , "None"));
Path.Add(new Vector3(-7902.213 , -3947.021 , 9.189109 , "None"));
Path.Add(new Vector3(-7864.157 , -3948.66 , 11.18493 , "None"));
Path.Add(new Vector3(-7830.32 , -3948.73 , 10.61133 , "None"));
Path.Add(new Vector3(-7798.599 , -3959.375 , 10.18748 , "None"));
Path.Add(new Vector3(-7779.695 , -3989.272 , 12.24272 , "None"));
Path.Add(new Vector3(-7762.493 , -4019.118 , 9.876778 , "None"));
Path.Add(new Vector3(-7746.244 , -4051.051 , 9.541529 , "None"));
Path.Add(new Vector3(-7713.57 , -4041.855 , 8.883557 , "None"));
Path.Add(new Vector3(-7682.54 , -4025.281 , 10.69745 , "None"));
Path.Add(new Vector3(-7648.005 , -4020.6 , 9.860865 , "None"));
Path.Add(new Vector3(-7612.022 , -4020.833 , 9.602015 , "None"));
Path.Add(new Vector3(-7579.143 , -4031.53 , 11.42951 , "None"));
Path.Add(new Vector3(-7547.416 , -4048.454 , 11.14855 , "None"));
Path.Add(new Vector3(-7518.722 , -4068.368 , 9.860619 , "None"));
Path.Add(new Vector3(-7489.29 , -4089.178 , 9.040721 , "None"));
Path.Add(new Vector3(-7459.535 , -4109.364 , 10.81767 , "None"));
Path.Add(new Vector3(-7426.58 , -4120.875 , 8.877693 , "None"));
Path.Add(new Vector3(-7393.313 , -4116.345 , 8.924571 , "None"));
Path.Add(new Vector3(-7357.999 , -4110.059 , 10.36952 , "None"));
Path.Add(new Vector3(-7323.322 , -4107.404 , 10.65091 , "None"));
Path.Add(new Vector3(-7292.478 , -4125.198 , 9.02574 , "None"));
Path.Add(new Vector3(-7267.931 , -4149.959 , 9.502574 , "None"));
Path.Add(new Vector3(-7246.549 , -4178.975 , 9.078402 , "None"));
Path.Add(new Vector3(-7226.654 , -4207.682 , 9.027353 , "None"));
Path.Add(new Vector3(-7206.517 , -4237.523 , 8.839687 , "None"));
Path.Add(new Vector3(-7186.393 , -4267.429 , 10.27825 , "None"));
Path.Add(new Vector3(-7165.51 , -4295.43 , 10.2651 , "None"));
Path.Add(new Vector3(-7143.373 , -4323.871 , 8.661539 , "None"));
Path.Add(new Vector3(-7119.916 , -4348.931 , 8.622696 , "None"));
Path.Add(new Vector3(-7094.434 , -4372.717 , 8.852946 , "None"));
Path.Add(new Vector3(-7077.311 , -4404.255 , 8.539589 , "None"));
Path.Add(new Vector3(-7066.661 , -4437.375 , 8.649686 , "None"));
Path.Add(new Vector3(-7057.424 , -4472.188 , 11.33606 , "None"));
Path.Add(new Vector3(-7048.63 , -4505.992 , 11.97878 , "None"));
Path.Add(new Vector3(-7039.406 , -4540.835 , 12.1841 , "None"));
Path.Add(new Vector3(-7026.854 , -4573.361 , 11.6374 , "None"));
Path.Add(new Vector3(-7011.255 , -4605.727 , 11.52753 , "None"));
Path.Add(new Vector3(-6991.854 , -4634.773 , 9.675485 , "None"));
Path.Add(new Vector3(-6975.496 , -4666.829 , 8.437538 , "None"));
Path.Add(new Vector3(-6960.92 , -4698.572 , 8.437538 , "None"));
Path.Add(new Vector3(-6939.211 , -4726.558 , 11.9427 , "None"));
Path.Add(new Vector3(-6909.45 , -4744.1 , 11.415 , "None"));
Path.Add(new Vector3(-6875.789 , -4756.96 , 9.880892 , "None"));
Path.Add(new Vector3(-6844.222 , -4771.91 , 10.05383 , "None"));
Path.Add(new Vector3(-6811.928 , -4787.927 , 9.099894 , "None"));
Path.Add(new Vector3(-6790.63 , -4799.012 , 5.948844 , "None"));
Path.Add(new Vector3(-6763.515 , -4813.17 , 0.6687613 , "None"));
Path.Add(new Vector3(-6740.306 , -4825.284 , 0.6687613 , "None"));
Path.Add(new Vector3(-6719.517 , -4831.474 , 0.6454162 , "None"));
Path.Add(new Vector3(-6704.009 , -4834.25 , -0.8290337 , "Swimming"));
Path.Add(new Vector3(-6686.898 , -4837.312 , -0.8290337 , "Swimming"));
Path.Add(new Vector3(-6668.044 , -4840.686 , -0.8290337 , "Swimming"));
Path.Add(new Vector3(-6649.19 , -4844.061 , -0.8290337 , "Swimming"));
Path.Add(new Vector3(-6630.337 , -4847.435 , -0.8290337 , "Swimming"));
Path.Add(new Vector3(-6611.483 , -4850.809 , -0.8290337 , "Swimming"));
Path.Add(new Vector3(-6592.452 , -4852.487 , -0.8290337 , "Swimming"));
Path.Add(new Vector3(-6573.527 , -4855.22 , -0.8290337 , "Swimming"));
Path.Add(new Vector3(-6554.665 , -4858.549 , -0.8290337 , "Swimming"));
Path.Add(new Vector3(-6535.804 , -4861.879 , -0.8290337 , "Swimming"));
Path.Add(new Vector3(-6516.942 , -4865.209 , -0.8290337 , "Swimming"));
Path.Add(new Vector3(-6498.08 , -4868.539 , -0.8290337 , "Swimming"));
Path.Add(new Vector3(-6480.062 , -4874.779 , -0.8290337 , "Swimming"));
Path.Add(new Vector3(-6462.375 , -4882.129 , -0.8290337 , "Swimming"));
Path.Add(new Vector3(-6445.091 , -4890.317 , -0.8290337 , "Swimming"));
Path.Add(new Vector3(-6421.996 , -4898.26 , 0.9025914 , "None"));
Path.Add(new Vector3(-6397.152 , -4903.439 , -4.249764 , "Swimming"));
Path.Add(new Vector3(-6384.163 , -4905.637 , -12.30652 , "Swimming"));
Path.Add(new Vector3(-6374.009 , -4908.046 , -0.75 , "Swimming"));
Path.Add(new Vector3(-6355.168 , -4903.895 , -0.7498693 , "Swimming"));
Path.Add(new Vector3(-6337.218 , -4899.777 , -0.7498693 , "Swimming"));
Path.Add(new Vector3(-6318.999 , -4897.242 , -0.7498693 , "Swimming"));
Path.Add(new Vector3(-6302.08 , -4898.323 , -0.7498693 , "Swimming"));
Path.Add(new Vector3(-6283.052 , -4900.169 , -0.7498693 , "Swimming"));
Path.Add(new Vector3(-6263.899 , -4899.992 , -0.7498693 , "Swimming"));
Path.Add(new Vector3(-6245.035 , -4896.934 , -0.7498693 , "Swimming"));
Path.Add(new Vector3(-6226.211 , -4893.495 , -0.7652279 , "Swimming"));
Path.Add(new Vector3(-6210.033 , -4884.162 , -0.7652279 , "Swimming"));
Path.Add(new Vector3(-6197.906 , -4869.068 , -0.7652279 , "Swimming"));
Path.Add(new Vector3(-6184.353 , -4859.962 , -0.7504687 , "Swimming"));
Path.Add(new Vector3(-6166.229 , -4856.005 , -0.7572071 , "Swimming"));
Path.Add(new Vector3(-6147.65 , -4850.229 , -0.7572071 , "Swimming"));
Path.Add(new Vector3(-6130.026 , -4849.438 , -0.7673935 , "Swimming"));
Path.Add(new Vector3(-6111.635 , -4844.549 , -0.7545255 , "Swimming"));
Path.Add(new Vector3(-6095.434 , -4834.543 , -0.7545255 , "Swimming"));
Path.Add(new Vector3(-6079.483 , -4824.148 , -0.7353964 , "Swimming"));
Path.Add(new Vector3(-6062.333 , -4815.791 , -0.7353964 , "Swimming"));
Path.Add(new Vector3(-6045.853 , -4807.269 , -0.7919753 , "Swimming"));
Path.Add(new Vector3(-6028.712 , -4797.442 , -0.7919753 , "Swimming"));
Path.Add(new Vector3(-5996.162 , -4790.827 , -0.7286838 , "Swimming"));
Path.Add(new Vector3(-5977.04 , -4790.224 , -0.7449898 , "Swimming"));
Path.Add(new Vector3(-5957.904 , -4789.415 , -0.7449898 , "Swimming"));
Path.Add(new Vector3(-5939.441 , -4784.587 , -0.7449898 , "Swimming"));
Path.Add(new Vector3(-5924.583 , -4776.838 , -0.7635043 , "Swimming"));
Path.Add(new Vector3(-5915.799 , -4768.398 , -1.471279 , "Swimming"));
Path.Add(new Vector3(-5906.137 , -4758.296 , -0.7644789 , "Swimming"));
Path.Add(new Vector3(-5896.896 , -4745.874 , -0.7697709 , "Swimming"));
Path.Add(new Vector3(-5884.876 , -4731.192 , -0.7697709 , "Swimming"));
Path.Add(new Vector3(-5868.501 , -4724.764 , -0.8299342 , "Swimming"));
Path.Add(new Vector3(-5855.739 , -4715.826 , -0.7711759 , "Swimming"));
Path.Add(new Vector3(-5845.407 , -4706.988 , -0.7603889 , "Swimming"));
Path.Add(new Vector3(-5835.739 , -4695.816 , -0.7525095 , "Swimming"));
Path.Add(new Vector3(-5820.862 , -4687.468 , -0.1495532 , "None"));
Path.Add(new Vector3(-5801.22 , -4682.288 , 0.3520049 , "None"));
Path.Add(new Vector3(-5780.778 , -4676.232 , 0.2658707 , "None"));
Path.Add(new Vector3(-5767.399 , -4687.135 , 0.1807798 , "None"));
Path.Add(new Vector3(-5758.477 , -4705.764 , -0.8037697 , "Swimming"));
Path.Add(new Vector3(-5744.271 , -4716.681 , -0.7583889 , "Swimming"));
Path.Add(new Vector3(-5727.79 , -4726.087 , -0.7583889 , "Swimming"));
Path.Add(new Vector3(-5708.92 , -4733.101 , 1.442379 , "None"));
Path.Add(new Vector3(-5694.557 , -4748.62 , 3.009304 , "None"));
Path.Add(new Vector3(-5683.331 , -4765.387 , -0.8898829 , "Swimming"));
Path.Add(new Vector3(-5670.805 , -4779.618 , -0.8898829 , "Swimming"));
Path.Add(new Vector3(-5654.02 , -4786.25 , -0.7403936 , "None"));
Path.Add(new Vector3(-5636.18 , -4789.132 , -0.7569323 , "Swimming"));
Path.Add(new Vector3(-5616.804 , -4788.984 , -0.7417687 , "Swimming"));
Path.Add(new Vector3(-5598.064 , -4790.452 , -0.7678852 , "Swimming"));
Path.Add(new Vector3(-5580.864 , -4794.047 , -0.711251 , "Swimming"));
Path.Add(new Vector3(-5569.171 , -4803.967 , -0.7960221 , "Swimming"));
Path.Add(new Vector3(-5552.269 , -4811.924 , -0.7960221 , "Swimming"));
Path.Add(new Vector3(-5533.772 , -4816.596 , -0.7627423 , "Swimming"));
Path.Add(new Vector3(-5518.107 , -4825.357 , -0.767818 , "Swimming"));
Path.Add(new Vector3(-5501.254 , -4835.08 , -0.767818 , "Swimming"));
Path.Add(new Vector3(-5484.664 , -4844.651 , -0.767818 , "Swimming"));
Path.Add(new Vector3(-5466.896 , -4851.059 , -0.767818 , "Swimming"));
Path.Add(new Vector3(-5449.043 , -4852.241 , -0.7363465 , "Swimming"));
Path.Add(new Vector3(-5430.99 , -4858.364 , -0.7363465 , "Swimming"));
Path.Add(new Vector3(-5413.183 , -4865.418 , -0.7363465 , "Swimming"));
Path.Add(new Vector3(-5398.077 , -4876.389 , -0.729069 , "Swimming"));
Path.Add(new Vector3(-5385.234 , -4890.361 , -0.7525454 , "Swimming"));
Path.Add(new Vector3(-5368.867 , -4895.179 , -0.7509807 , "Swimming"));
Path.Add(new Vector3(-5350.081 , -4898.848 , -0.7361763 , "Swimming"));
Path.Add(new Vector3(-5332.484 , -4903.076 , -0.7533699 , "Swimming"));
Path.Add(new Vector3(-5315.451 , -4901.404 , -0.6876623 , "Swimming"));
Path.Add(new Vector3(-5297.116 , -4896.795 , -0.7710867 , "Swimming"));
Path.Add(new Vector3(-5277.133 , -4892.56 , -0.01835421 , "None"));
Path.Add(new Vector3(-5258.592 , -4886.517 , -0.9351448 , "Swimming"));
Path.Add(new Vector3(-5240.697 , -4882.567 , -0.7600316 , "None"));
Path.Add(new Vector3(-5222.238 , -4877.532 , -0.7585061 , "Swimming"));
Path.Add(new Vector3(-5204.17 , -4871.312 , -0.7348931 , "Swimming"));
Path.Add(new Vector3(-5187.062 , -4863.396 , -0.7348931 , "Swimming"));
Path.Add(new Vector3(-5170.293 , -4858.317 , -0.7281154 , "Swimming"));
Path.Add(new Vector3(-5152.613 , -4856.453 , -0.7433437 , "Swimming"));
Path.Add(new Vector3(-5133.589 , -4855.1 , -0.7548734 , "Swimming"));
Path.Add(new Vector3(-5114.442 , -4854.602 , -0.7548734 , "Swimming"));
Path.Add(new Vector3(-5096.851 , -4847.93 , -0.7548734 , "Swimming"));
Path.Add(new Vector3(-5081.665 , -4836.486 , -0.7655064 , "Swimming"));
Path.Add(new Vector3(-5067.967 , -4823.159 , -0.7655064 , "Swimming"));
Path.Add(new Vector3(-5058.02 , -4808.198 , -0.76033 , "Swimming"));
Path.Add(new Vector3(-5044.684 , -4797.325 , -0.8005396 , "Swimming"));
Path.Add(new Vector3(-5029.437 , -4785.732 , -0.8005396 , "Swimming"));
Path.Add(new Vector3(-5014.474 , -4774.389 , -0.7585837 , "Swimming"));
Path.Add(new Vector3(-5001.603 , -4760.205 , -0.7585837 , "Swimming"));
Path.Add(new Vector3(-4987.465 , -4752.933 , -0.754481 , "Swimming"));
Path.Add(new Vector3(-4974.476 , -4750.664 , -0.7166908 , "None"));
Path.Add(new Vector3(-4956.17 , -4745.532 , -0.7525048 , "Swimming"));
Path.Add(new Vector3(-4939.973 , -4754.405 , -0.7525048 , "Swimming"));
Path.Add(new Vector3(-4927.452 , -4768.938 , -0.7504109 , "Swimming"));
Path.Add(new Vector3(-4913.906 , -4781.376 , -0.7504109 , "Swimming"));
Path.Add(new Vector3(-4896.337 , -4788.929 , -0.6991454 , "None"));
Path.Add(new Vector3(-4882.325 , -4800.615 , -0.7553596 , "Swimming"));
Path.Add(new Vector3(-4869.138 , -4814.088 , -0.7662695 , "Swimming"));
Path.Add(new Vector3(-4859.206 , -4829.136 , -0.7795333 , "Swimming"));
Path.Add(new Vector3(-4845.088 , -4841.271 , -0.7673435 , "Swimming"));
Path.Add(new Vector3(-4829.279 , -4851.923 , -0.7271774 , "Swimming"));
Path.Add(new Vector3(-4810.865 , -4855.15 , -0.7271774 , "Swimming"));
Path.Add(new Vector3(-4791.748 , -4855.674 , -0.7271774 , "Swimming"));
Path.Add(new Vector3(-4772.66 , -4857.255 , -0.7271774 , "Swimming"));
Path.Add(new Vector3(-4753.704 , -4859.609 , -0.7271774 , "Swimming"));
Path.Add(new Vector3(-4735.393 , -4858.943 , -0.7271774 , "Swimming"));
Path.Add(new Vector3(-4718.539 , -4851.649 , -0.7253548 , "None"));
Path.Add(new Vector3(-4699.499 , -4851.917 , -0.7578403 , "Swimming"));
Path.Add(new Vector3(-4681.904 , -4850.964 , -0.7576051 , "Swimming"));
Path.Add(new Vector3(-4663.463 , -4846.693 , -0.7576051 , "Swimming"));
Path.Add(new Vector3(-4650.649 , -4832.629 , -0.7080208 , "Swimming"));
Path.Add(new Vector3(-4636.921 , -4819.156 , -0.2592957 , "None"));
Path.Add(new Vector3(-4621.737 , -4805.317 , -0.754945 , "Swimming"));
Path.Add(new Vector3(-4605.963 , -4794.995 , -0.754945 , "Swimming"));
Path.Add(new Vector3(-4590.172 , -4783.268 , -0.754945 , "Swimming"));
Path.Add(new Vector3(-4576.493 , -4771.586 , -0.7678623 , "Swimming"));
Path.Add(new Vector3(-4565.193 , -4756.489 , -0.6737554 , "None"));
Path.Add(new Vector3(-4550.085 , -4745.472 , -0.7749245 , "Swimming"));
Path.Add(new Vector3(-4531.332 , -4748.701 , -0.7749245 , "Swimming"));
Path.Add(new Vector3(-4512.39 , -4751.537 , -0.7749245 , "Swimming"));
Path.Add(new Vector3(-4494.896 , -4759.807 , 1.124744 , "None"));
Path.Add(new Vector3(-4491.575 , -4772.937 , -0.8867239 , "Swimming"));
Path.Add(new Vector3(-4476.031 , -4781.66 , 0.8511733 , "None"));
Path.Add(new Vector3(-4458.46 , -4792.953 , 0.3208838 , "None"));
Path.Add(new Vector3(-4440.773 , -4805.239 , -0.03679423 , "None"));
Path.Add(new Vector3(-4428.944 , -4820.865 , -0.7874699 , "Swimming"));
Path.Add(new Vector3(-4413.526 , -4831.958 , -0.7874699 , "Swimming"));
Path.Add(new Vector3(-4395.069 , -4835.593 , -0.7874699 , "Swimming"));
Path.Add(new Vector3(-4376.005 , -4834.569 , -0.7874699 , "Swimming"));
Path.Add(new Vector3(-4357.774 , -4831.485 , -0.7874699 , "Swimming"));
Path.Add(new Vector3(-4340.16 , -4823.392 , -0.7874699 , "Swimming"));
Path.Add(new Vector3(-4322.786 , -4814.532 , 0.1616674 , "None"));
Path.Add(new Vector3(-4310.643 , -4804.565 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4297.623 , -4790.532 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4284.421 , -4776.655 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4271.792 , -4762.345 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4260.752 , -4746.825 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4251.458 , -4732.18 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4238.116 , -4727.315 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4219.026 , -4728.776 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4199.668 , -4726.828 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4181.612 , -4721.886 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4163.384 , -4715.084 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4146.257 , -4706.896 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4128.994 , -4698.938 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4113.419 , -4687.897 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4100.012 , -4674.219 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4086.604 , -4660.54 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4076.473 , -4644.373 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4063.571 , -4630.299 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4052.925 , -4614.525 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4045.017 , -4598.465 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4036.983 , -4579.88 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4029.095 , -4562.449 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4020.654 , -4545.279 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-4007.295 , -4531.555 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-3993.737 , -4518.196 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-3981.398 , -4503.546 , -0.7653741 , "Swimming"));
Path.Add(new Vector3(-3971.115 , -4494.231 , 5.232929 , "None"));
Path.Add(new Vector3(-3952.319 , -4496.984 , 7.524157 , "None"));
Path.Add(new Vector3(-3944.184 , -4516.319 , 9.37412 , "None"));
Path.Add(new Vector3(-3935.16 , -4535.291 , 9.347988 , "None"));
Path.Add(new Vector3(-3920.562 , -4550.772 , 9.180187 , "None"));
Path.Add(new Vector3(-3905.18 , -4565.497 , 9.174265 , "None"));
Path.Add(new Vector3(-3890.062 , -4580.49 , 9.17921 , "None"));
Path.Add(new Vector3(-3886.404 , -4597.478 , 9.231953 , "None"));
Path.Add(new Vector3(-3896.932 , -4615.788 , 9.669063 , "None"));
Path.Add(new Vector3(-3911.923 , -4631.364 , 9.664219 , "None"));
Path.Add(new Vector3(-3926.637 , -4646.756 , 9.262695 , "None"));
Path.Add(new Vector3(-3941.043 , -4661.978 , 8.97424 , "None"));
Path.Add(new Vector3(-3955.945 , -4677.654 , 9.049818 , "None"));
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


public sealed class RunToSHIPTheramore : QuestFollowPathClass
{
    public RunToSHIPTheramore()
    {
        Name = "Run To SHIP (Theramore)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 54;
        MaxLevel = 59;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3957.969 , -4678.839 , 8.636125 , "None"));
Path.Add(new Vector3(-3972.212 , -4693.887 , 4.438034 , "None"));
Path.Add(new Vector3(-3991.736 , -4714.54 , 4.492281 , "None"));
Path.Add(new Vector3(-4002.55 , -4726.841 , 4.981695 , "None"));
Path.Add(new Vector3(-4006.29 , -4731.22 , 5.371885 , "None"));
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


public sealed class CatchShipFromTheramore : QuestClass
{
    public CatchShipFromTheramore()
    {
        Name = "Catch Ship (From Theramore)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 54;
        MaxLevel = 59;
        RequiredQuest = 0;


    }

	public override bool CanConditions()
	{
        return Usefuls.ContinentId == (int) ContinentId.Kalimdor;
	}

public override bool IsComplete() { 
return Usefuls.ContinentId == (int) ContinentId.Azeroth && !ObjectManager.Me.InTransport;
}



public override bool HasQuest() { return true; }

public override bool Pulse() {
// Sample of how to use Zeppelin/Ship
// In this sample, WRobot catch Zeppelin from Kalimdor (Ogrimmard) to Northrend (Borean Tundra (Warsong Hold))

/* Quest settings:
    * Can condition: "return Usefuls.ContinentId == (int) ContinentId.Kalimdor;"
    * Is complete condition: "return Usefuls.ContinentId == (int) ContinentId.Northrend && !ObjectManager.Me.InTransport;"
    * Not required in quest log: "True"
    * Quest type: "OverridePulseCSharpCode"
*/

// You can get zeppelin/ship/player positions and entry ID in tab "Tools" > "Development Tools" > "Dump all informations" (or "Memory information").

// Settings:
var zeppelinEntryId = 176231; // Zeppelin/Ship EntryId
// From
var fromZeppelinWaitPosition = new Vector3(-4016.39, -4740.588, 0);// Position where Zeppelin/Ship waits players (from)
var fromPlayerWaitPosition = new Vector3(-4005.235, -4732.517, 5.439033, "None"); // Position where the player waits Zeppelin/Ship (from)
var fromPlayerInZeppelinPosition = new Vector3(-4005.948, -4733.486, 5.894122, "None");// Position where the player waits in the Zeppelin/Ship (from)
// To
var toZeppelinWaitPosition = new Vector3(-3905.225, -585.8085, 0, "None"); // Position where Zeppelin/Ship waits players (to)
var toPlayerLeavePosition =  new Vector3(-3896.342, -596.4409, 5.466796, "None"); // Position to go out the Zeppelin/Ship (to)
// var toPlayerLeaveBoat = new Vector3(-4005.948, -4733.486, 5.894122, "None"); // put player at end of boat (to)


// Change WRobot settings:
wManager.wManagerSetting.CurrentSetting.CloseIfPlayerTeleported = false;

// Code:
if (!Conditions.InGameAndConnectedAndProductStartedNotInPause)
    return true;

if (Usefuls.ContinentId == (int)ContinentId.Kalimdor)
{
    if (!ObjectManager.Me.InTransport)
    {
        if (GoToTask.ToPosition(fromPlayerWaitPosition))
        {
            var zeppelin = ObjectManager.GetWoWGameObjectByEntry(zeppelinEntryId).OrderBy(o => o.GetDistance).FirstOrDefault();
            if (zeppelin != null && zeppelin.Position.DistanceTo(fromZeppelinWaitPosition) < 1)
            {
                wManager.Wow.Helpers.Move.Forward(Move.MoveAction.PressKey,2500);
            }
        }
    }
}
else if (Usefuls.ContinentId == (int)ContinentId.Azeroth)
{
    if (ObjectManager.Me.InTransport)
    {
        var zeppelin = ObjectManager.GetWoWGameObjectByEntry(zeppelinEntryId).OrderBy(o => o.GetDistance).FirstOrDefault();
        if (zeppelin != null && zeppelin.Position.DistanceTo(toZeppelinWaitPosition) < 1)
        {
            wManager.Wow.Helpers.Move.Backward(Move.MoveAction.PressKey,2650);
        }
    }
}
return true;
}
}


public sealed class RunFromShipWetlands : QuestFollowPathClass
{
    public RunFromShipWetlands()
    {
        Name = "Run From Ship (Wetlands)";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 54;
        MaxLevel = 59;
        RequiredQuest = 0;

        Path.Add(new Vector3(-3863.766 , -638.2919 , -1.435408 , "Swimming"));
Path.Add(new Vector3(-3856.931 , -649.6102 , -1.435408 , "Swimming"));
Path.Add(new Vector3(-3848.948 , -662.8284 , -1.435408 , "Swimming"));
Path.Add(new Vector3(-3836.766 , -682.9993 , -1.435408 , "Swimming"));
Path.Add(new Vector3(-3824.951 , -702.5638 , -1.435408 , "Swimming"));
Path.Add(new Vector3(-3813.222 , -722.1243 , -1.435408 , "Swimming"));
Path.Add(new Vector3(-3817.008 , -735.5267 , -1.435408 , "Swimming"));
Path.Add(new Vector3(-3824.957 , -758.4717 , -1.355459 , "Swimming"));
Path.Add(new Vector3(-3832.026 , -769.3631 , 2.565465 , "None"));
Path.Add(new Vector3(-3836.249 , -780.5992 , 6.536473 , "None"));
Path.Add(new Vector3(-3820.12 , -787.8148 , 10.46432 , "None"));
Path.Add(new Vector3(-3808.851 , -783.6911 , 9.058112 , "None"));
Path.Add(new Vector3(-3792.402 , -780.8466 , 8.990443 , "None"));
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


public sealed class PATHArathitoEPL : QuestFollowPathClass
{
    public PATHArathitoEPL()
    {
        Name = "PATH : Arathi to EPL";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 54;
        MaxLevel = 59;
        RequiredQuest = 0;

        Path.Add(new Vector3(-1457.763 , -2403.865 , 60.64244 , "None"));
Path.Add(new Vector3(-1453.223 , -2358.334 , 61.5348 , "None"));
Path.Add(new Vector3(-1448.071 , -2322.656 , 61.7566 , "None"));
Path.Add(new Vector3(-1441.383 , -2288.4 , 62.37661 , "None"));
Path.Add(new Vector3(-1424.473 , -2256.884 , 63.52657 , "None"));
Path.Add(new Vector3(-1408.621 , -2224.674 , 63.80516 , "None"));
Path.Add(new Vector3(-1399.242 , -2191.142 , 63.91076 , "None"));
Path.Add(new Vector3(-1392.266 , -2155.773 , 64.13239 , "None"));
Path.Add(new Vector3(-1387.055 , -2121.264 , 64.37017 , "None"));
Path.Add(new Vector3(-1382.61 , -2085.49 , 63.13212 , "None"));
Path.Add(new Vector3(-1378.534 , -2050.799 , 61.59377 , "None"));
Path.Add(new Vector3(-1374.563 , -2016.095 , 59.87034 , "None"));
Path.Add(new Vector3(-1369.859 , -1980.366 , 58.35727 , "None"));
Path.Add(new Vector3(-1359.157 , -1945.987 , 58.45333 , "None"));
Path.Add(new Vector3(-1347.317 , -1913.129 , 58.44495 , "None"));
Path.Add(new Vector3(-1335.558 , -1879.106 , 60.69549 , "None"));
Path.Add(new Vector3(-1324.15 , -1846.095 , 63.09249 , "None"));
Path.Add(new Vector3(-1301.621 , -1818.673 , 65.64772 , "None"));
Path.Add(new Vector3(-1274.733 , -1796.401 , 67.23482 , "None"));
Path.Add(new Vector3(-1245.623 , -1775.136 , 65.0666 , "None"));
Path.Add(new Vector3(-1217.395 , -1754.563 , 60.75169 , "None"));
Path.Add(new Vector3(-1188.241 , -1733.358 , 55.94558 , "None"));
Path.Add(new Vector3(-1157.814 , -1716.417 , 52.13994 , "None"));
Path.Add(new Vector3(-1123.537 , -1705.407 , 46.24136 , "None"));
Path.Add(new Vector3(-1109.723 , -1702.076 , 44.89463 , "None"));
Path.Add(new Vector3(-1075.766 , -1693.887 , 39.4837 , "None"));
Path.Add(new Vector3(-1040.09 , -1689.099 , 37.10829 , "None"));
Path.Add(new Vector3(-1004.218 , -1685.521 , 37.07315 , "None"));
Path.Add(new Vector3(-969.4603 , -1682.054 , 38.57614 , "None"));
Path.Add(new Vector3(-934.5424 , -1673.569 , 42.41263 , "None"));
Path.Add(new Vector3(-905.4064 , -1654.719 , 46.48501 , "None"));
Path.Add(new Vector3(-879.0079 , -1630.202 , 50.72002 , "None"));
Path.Add(new Vector3(-853.4136 , -1606.431 , 53.30833 , "None"));
Path.Add(new Vector3(-828.7552 , -1578.807 , 54.17164 , "None"));
Path.Add(new Vector3(-808.0031 , -1552.028 , 54.25471 , "None"));
Path.Add(new Vector3(-786.9442 , -1524.178 , 55.67502 , "None"));
Path.Add(new Vector3(-766.7053 , -1494.345 , 59.6073 , "None"));
Path.Add(new Vector3(-752.0075 , -1472.681 , 63.64531 , "None"));
Path.Add(new Vector3(-733.0622 , -1433.725 , 65.62538 , "None"));
Path.Add(new Vector3(-721.8627 , -1400.686 , 67.84004 , "None"));
Path.Add(new Vector3(-706.5028 , -1369.641 , 68.05824 , "None"));
Path.Add(new Vector3(-685.2675 , -1340.519 , 67.4341 , "None"));
Path.Add(new Vector3(-664.0852 , -1312.749 , 66.17971 , "None"));
Path.Add(new Vector3(-643.3409 , -1283.267 , 66.11095 , "None"));
Path.Add(new Vector3(-624.1488 , -1254.089 , 66.1095 , "None"));
Path.Add(new Vector3(-605.7419 , -1221.896 , 65.56715 , "None"));
Path.Add(new Vector3(-596.201 , -1190.589 , 66.03683 , "None"));
Path.Add(new Vector3(-586.0711 , -1154.828 , 66.27 , "None"));
Path.Add(new Vector3(-573.6677 , -1122.381 , 65.13614 , "None"));
Path.Add(new Vector3(-554.7627 , -1091.742 , 59.60242 , "None"));
Path.Add(new Vector3(-533.1308 , -1064.341 , 55.06914 , "None"));
Path.Add(new Vector3(-510.5009 , -1036.372 , 48.09105 , "None"));
Path.Add(new Vector3(-497.4963 , -1004.17 , 41.10534 , "None"));
Path.Add(new Vector3(-490.4425 , -968.8441 , 34.86658 , "None"));
Path.Add(new Vector3(-484.6674 , -934.3995 , 33.9091 , "None"));
Path.Add(new Vector3(-472.7375 , -900.4705 , 36.70403 , "None"));
Path.Add(new Vector3(-456.1397 , -869.8983 , 43.67958 , "None"));
Path.Add(new Vector3(-434.4292 , -841.1197 , 51.10027 , "None"));
Path.Add(new Vector3(-414.1958 , -812.6507 , 54.61541 , "None"));
Path.Add(new Vector3(-403.0895 , -791.3596 , 54.98987 , "None"));
Path.Add(new Vector3(-393.625 , -757.8333 , 55.3816 , "None"));
Path.Add(new Vector3(-393.0962 , -722.9749 , 54.45383 , "None"));
Path.Add(new Vector3(-403.3566 , -688.4798 , 54.5016 , "None"));
Path.Add(new Vector3(-414.6963 , -654.2598 , 54.47853 , "None"));
Path.Add(new Vector3(-425.8605 , -621.162 , 54.501 , "None"));
Path.Add(new Vector3(-437.0378 , -586.8901 , 53.60601 , "None"));
Path.Add(new Vector3(-441.0038 , -573.2449 , 53.11465 , "None"));
Path.Add(new Vector3(-442.3779 , -555.8691 , 52.82826 , "None"));
Path.Add(new Vector3(-475.5034 , -564.4148 , 47.28096 , "None"));
Path.Add(new Vector3(-493.5329 , -568.1793 , 44.53038 , "None"));
Path.Add(new Vector3(-509.8972 , -567.4915 , 42.20572 , "None"));
Path.Add(new Vector3(-552.5097 , -568.5626 , 35.35649 , "None"));
Path.Add(new Vector3(-587.3135 , -566.942 , 32.72549 , "None"));
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


public sealed class PATHHillsbradtoEPL : QuestFollowPathClass
{
    public PATHHillsbradtoEPL()
    {
        Name = "PATH : Hillsbrad to EPL";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 54;
        MaxLevel = 59;
        RequiredQuest = 0;

        Path.Add(new Vector3(-421.9764 , -659.5853 , 53.87774 , "None"));
Path.Add(new Vector3(-419.9307 , -672.4824 , 53.5115 , "None"));
Path.Add(new Vector3(-398.3835 , -699.2676 , 54.50105 , "None"));
Path.Add(new Vector3(-388.8241 , -733.9107 , 54.37111 , "None"));
Path.Add(new Vector3(-367.888 , -759.4585 , 54.84606 , "None"));
Path.Add(new Vector3(-332.6693 , -766.3018 , 54.17617 , "None"));
Path.Add(new Vector3(-301.2719 , -753.2072 , 55.72923 , "None"));
Path.Add(new Vector3(-272.58 , -731.484 , 57.30867 , "None"));
Path.Add(new Vector3(-239.6335 , -720.3643 , 60.09762 , "None"));
Path.Add(new Vector3(-204.0788 , -714.4124 , 62.62762 , "None"));
Path.Add(new Vector3(-169.2847 , -711.4062 , 64.17892 , "None"));
Path.Add(new Vector3(-134.4304 , -710.9532 , 64.73573 , "None"));
Path.Add(new Vector3(-111.5072 , -710.6984 , 65.60776 , "None"));
Path.Add(new Vector3(-76.60159 , -709.4192 , 67.69094 , "None"));
Path.Add(new Vector3(-40.63261 , -710.9811 , 68.99566 , "None"));
Path.Add(new Vector3(-5.770126 , -711.9697 , 71.45835 , "None"));
Path.Add(new Vector3(30.14951 , -708.9069 , 74.71866 , "None"));
Path.Add(new Vector3(64.96125 , -706.0444 , 78.90482 , "None"));
Path.Add(new Vector3(100.9478 , -703.9069 , 85.19406 , "None"));
Path.Add(new Vector3(134.9589 , -696.9454 , 90.30223 , "None"));
Path.Add(new Vector3(168.2605 , -683.3326 , 97.46856 , "None"));
Path.Add(new Vector3(200.3727 , -669.5902 , 107.1572 , "None"));
Path.Add(new Vector3(234.7957 , -659.4128 , 117.164 , "None"));
Path.Add(new Vector3(269.4044 , -649.7923 , 128.446 , "None"));
Path.Add(new Vector3(305.6972 , -621.5745 , 141.3099 , "None"));
Path.Add(new Vector3(339.9842 , -611.3105 , 147.6685 , "None"));
Path.Add(new Vector3(375.7809 , -607.6414 , 156.1114 , "None"));
Path.Add(new Vector3(410.4308 , -611.7008 , 164.185 , "None"));
Path.Add(new Vector3(441.4696 , -620.9982 , 166.658 , "None"));
Path.Add(new Vector3(459.7596 , -639.8083 , 167.3247 , "None"));
Path.Add(new Vector3(480.8841 , -676.4113 , 165.707 , "None"));
Path.Add(new Vector3(499.1888 , -705.9764 , 160.8322 , "None"));
Path.Add(new Vector3(523.4563 , -732.6249 , 162.0087 , "None"));
Path.Add(new Vector3(551.8928 , -752.6533 , 164.0045 , "None"));
Path.Add(new Vector3(582.977 , -770.6718 , 165.5454 , "None"));
Path.Add(new Vector3(598.6963 , -799.9021 , 165.5034 , "None"));
Path.Add(new Vector3(617.3051 , -829.2981 , 164.322 , "None"));
Path.Add(new Vector3(620.799 , -863.9157 , 163.7673 , "None"));
Path.Add(new Vector3(619.1718 , -899.9269 , 164.3353 , "None"));
Path.Add(new Vector3(618.5321 , -934.8002 , 164.5915 , "None"));
Path.Add(new Vector3(622.9143 , -970.5463 , 166.8463 , "None"));
Path.Add(new Vector3(627.9479 , -1005.11 , 164.7974 , "None"));
Path.Add(new Vector3(629.143 , -1041.032 , 163.5339 , "None"));
Path.Add(new Vector3(622.9901 , -1065.391 , 162.7491 , "None"));
Path.Add(new Vector3(619.0057 , -1099.872 , 161.3513 , "None"));
Path.Add(new Vector3(623.4765 , -1125.581 , 160.0583 , "None"));
Path.Add(new Vector3(629.9991 , -1148.605 , 155.6933 , "None"));
Path.Add(new Vector3(632.2399 , -1175.809 , 148.3157 , "None"));
Path.Add(new Vector3(633.3552 , -1211.841 , 141.3898 , "None"));
Path.Add(new Vector3(633.6374 , -1246.769 , 130.7928 , "None"));
Path.Add(new Vector3(631.3952 , -1282.734 , 117.6229 , "None"));
Path.Add(new Vector3(628.0922 , -1317.504 , 107.3615 , "None"));
Path.Add(new Vector3(626.3533 , -1353.502 , 98.60387 , "None"));
Path.Add(new Vector3(637.9941 , -1385.766 , 91.71711 , "None"));
Path.Add(new Vector3(655.6452 , -1417.157 , 86.30827 , "None"));
Path.Add(new Vector3(679.8528 , -1442.136 , 81.64663 , "None"));
Path.Add(new Vector3(712.4478 , -1456.464 , 81.47296 , "None"));
Path.Add(new Vector3(747.2106 , -1459.258 , 80.23126 , "None"));
Path.Add(new Vector3(782.7027 , -1465.575 , 75.68548 , "None"));
Path.Add(new Vector3(817.0661 , -1471.841 , 72.64293 , "None"));
Path.Add(new Vector3(852.6614 , -1477.479 , 67.30525 , "None"));
Path.Add(new Vector3(887.5571 , -1478.567 , 63.66988 , "None"));
Path.Add(new Vector3(921.2535 , -1475.675 , 62.56967 , "None"));
Path.Add(new Vector3(935.1004 , -1472.811 , 62.42901 , "None"));
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


public sealed class PATHWPLTOEPL : QuestFollowPathClass
{
    public PATHWPLTOEPL()
    {
        Name = "PATH : WPL TO EPL";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 54;
        MaxLevel = 59;
        RequiredQuest = 0;

        Path.Add(new Vector3(1037.088 , -1487.996 , 64.82111 , "None"));
Path.Add(new Vector3(1048.096 , -1496.974 , 67.14181 , "None"));
Path.Add(new Vector3(1077.241 , -1518.15 , 69.44389 , "None"));
Path.Add(new Vector3(1095.86 , -1533.262 , 71.46806 , "None"));
Path.Add(new Vector3(1102.325 , -1544.623 , 65.4463 , "None"));
Path.Add(new Vector3(1109.873 , -1557.527 , 66.98447 , "None"));
Path.Add(new Vector3(1120.137 , -1576.182 , 66.2103 , "None"));
Path.Add(new Vector3(1130.086 , -1594.993 , 65.97127 , "None"));
Path.Add(new Vector3(1134.017 , -1615.72 , 65.23036 , "None"));
Path.Add(new Vector3(1144.12 , -1634.347 , 71.09598 , "None"));
Path.Add(new Vector3(1159.081 , -1664.187 , 63.59712 , "None"));
Path.Add(new Vector3(1182.573 , -1672.274 , 76.07102 , "None"));
Path.Add(new Vector3(1193.334 , -1679.717 , 79.94626 , "None"));
Path.Add(new Vector3(1207.685 , -1685.601 , 73.31068 , "None"));
Path.Add(new Vector3(1228.002 , -1691.709 , 70.86639 , "None"));
Path.Add(new Vector3(1247.245 , -1701.582 , 63.72137 , "None"));
Path.Add(new Vector3(1257.147 , -1707.81 , 60.76073 , "None"));
Path.Add(new Vector3(1269.806 , -1720.757 , 66.21455 , "None"));
Path.Add(new Vector3(1277.088 , -1740.662 , 73.82897 , "None"));
Path.Add(new Vector3(1270.483 , -1760.62 , 72.37024 , "None"));
Path.Add(new Vector3(1258.163 , -1778.306 , 72.01826 , "None"));
Path.Add(new Vector3(1250.119 , -1784.997 , 64.57281 , "None"));
Path.Add(new Vector3(1233.936 , -1792.633 , 67.77934 , "None"));
Path.Add(new Vector3(1223.25 , -1810.662 , 64.66773 , "None"));
Path.Add(new Vector3(1216.681 , -1826.743 , 63.57123 , "None"));
Path.Add(new Vector3(1223.316 , -1839.507 , 54.11597 , "None"));
Path.Add(new Vector3(1243.544 , -1835.714 , 50.68067 , "Swimming"));
Path.Add(new Vector3(1259.836 , -1833.097 , 50.50058 , "Swimming"));
Path.Add(new Vector3(1279.741 , -1838.648 , 51.08506 , "Swimming"));
Path.Add(new Vector3(1273.544 , -1851.391 , 51.08506 , "Swimming"));
Path.Add(new Vector3(1263.992 , -1871.32 , 51.08506 , "Swimming"));
Path.Add(new Vector3(1270.275 , -1896.3 , 51.08506 , "Swimming"));
Path.Add(new Vector3(1280.737 , -1916.567 , 51.08506 , "Swimming"));
Path.Add(new Vector3(1293.224 , -1938.295 , 51.08506 , "Swimming"));
Path.Add(new Vector3(1313.329 , -1960.398 , 51.00192 , "Swimming"));
Path.Add(new Vector3(1321.917 , -1975.015 , 51.00192 , "Swimming"));
Path.Add(new Vector3(1335.857 , -1993.636 , 51.00192 , "Swimming"));
Path.Add(new Vector3(1350.667 , -2002.455 , 52.2213 , "None"));
Path.Add(new Vector3(1365.111 , -2016.604 , 51.04689 , "Swimming"));
Path.Add(new Vector3(1386.247 , -2025.056 , 51.07894 , "Swimming"));
Path.Add(new Vector3(1407.998 , -2016.351 , 51.07894 , "Swimming"));
Path.Add(new Vector3(1429.736 , -2016.774 , 51.5458 , "None"));
Path.Add(new Vector3(1450.196 , -2021.239 , 54.18478 , "None"));
Path.Add(new Vector3(1472.649 , -2028.767 , 54.73312 , "None"));
Path.Add(new Vector3(1499.597 , -2050.176 , 58.8025 , "None"));
Path.Add(new Vector3(1524.653 , -2054.744 , 60.67814 , "None"));
Path.Add(new Vector3(1549.658 , -2054.402 , 61.72326 , "None"));
Path.Add(new Vector3(1583.333 , -2051.322 , 60.54967 , "None"));
Path.Add(new Vector3(1616.019 , -2049.145 , 60.4315 , "None"));
Path.Add(new Vector3(1640.576 , -2044.083 , 61.89052 , "None"));
Path.Add(new Vector3(1659.816 , -2042.282 , 62.27135 , "None"));
Path.Add(new Vector3(1673.352 , -2034.819 , 62.37244 , "None"));
Path.Add(new Vector3(1687.257 , -2028.563 , 59.94027 , "None"));
Path.Add(new Vector3(1706.582 , -2042.496 , 61.8662 , "None"));
Path.Add(new Vector3(1738.583 , -2056.379 , 61.89637 , "None"));
Path.Add(new Vector3(1749.455 , -2066.552 , 62.47785 , "None"));
Path.Add(new Vector3(1754.038 , -2107.436 , 65.60941 , "None"));
Path.Add(new Vector3(1756.404 , -2142.127 , 68.00605 , "None"));
Path.Add(new Vector3(1766.072 , -2167.634 , 69.3356 , "None"));
Path.Add(new Vector3(1775.782 , -2195.458 , 68.3605 , "None"));
Path.Add(new Vector3(1790.647 , -2229.471 , 63.86531 , "None"));
Path.Add(new Vector3(1810.19 , -2258.204 , 60.1258 , "None"));
Path.Add(new Vector3(1832.423 , -2285.135 , 59.29916 , "None"));
Path.Add(new Vector3(1853.56 , -2314.307 , 59.45432 , "None"));
Path.Add(new Vector3(1868.511 , -2345.75 , 60.55434 , "None"));
Path.Add(new Vector3(1881.073 , -2379.534 , 65.44475 , "None"));
Path.Add(new Vector3(1894.142 , -2411.927 , 69.93256 , "None"));
Path.Add(new Vector3(1904.233 , -2446.478 , 70.35738 , "None"));
Path.Add(new Vector3(1912.382 , -2480.444 , 67.61401 , "None"));
Path.Add(new Vector3(1920.793 , -2515.499 , 63.59225 , "None"));
Path.Add(new Vector3(1925.878 , -2549.949 , 62.79308 , "None"));
Path.Add(new Vector3(1927.094 , -2585.966 , 59.90284 , "None"));
Path.Add(new Vector3(1926.224 , -2622.002 , 62.31074 , "None"));
Path.Add(new Vector3(1925.122 , -2656.915 , 59.81171 , "None"));
Path.Add(new Vector3(1924.182 , -2691.832 , 61.39771 , "None"));
Path.Add(new Vector3(1924.763 , -2727.869 , 64.1175 , "None"));
Path.Add(new Vector3(1924.268 , -2762.79 , 68.71391 , "None"));
Path.Add(new Vector3(1927.919 , -2786.52 , 70.27334 , "None"));
Path.Add(new Vector3(1931.678 , -2810.176 , 71.86212 , "None"));
Path.Add(new Vector3(1935.604 , -2845.919 , 75.34088 , "None"));
Path.Add(new Vector3(1928.989 , -2880.808 , 75.26318 , "None"));
Path.Add(new Vector3(1914.945 , -2912.665 , 76.04404 , "None"));
Path.Add(new Vector3(1898.84 , -2944.888 , 74.79459 , "None"));
Path.Add(new Vector3(1866.086 , -2982.509 , 74.55318 , "None"));
Path.Add(new Vector3(1842.987 , -3008.583 , 73.64823 , "None"));
Path.Add(new Vector3(1821.464 , -3037.503 , 74.9981 , "None"));
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


public sealed class DemonDogs1 : QuestGrinderClass
{
    public DemonDogs1()
    {
        Name = "Demon Dogs1";

        QuestId.AddRange(new[] { 5542 });

        Step = new List<int> { 20, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 54;
        MaxLevel = 60;
        RequiredQuest = 0;

        EntryTarget.Add(8596);
HotSpots.Add(new Vector3(2085.492 , -3021.4 , 78.92375 , "None"));
HotSpots.Add(new Vector3(1861.425 , -3895.621 , 133.3682 , "None"));
HotSpots.Add(new Vector3(1796.706 , -2893.519 , 69.68342 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class BloodTingedSkies : QuestGrinderClass
{
    public BloodTingedSkies()
    {
        Name = "Blood Tinged Skies";

        QuestId.AddRange(new[] { 5543 });

        Step = new List<int> { 30, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 54;
        MaxLevel = 60;
        RequiredQuest = 0;

        EntryTarget.Add(8600);
HotSpots.Add(new Vector3(2119.455 , -2824.206 , 82.18719 , "None"));
HotSpots.Add(new Vector3(2048.358 , -3043.32 , 75.9411 , "None"));
HotSpots.Add(new Vector3(2019.208 , -3410.203 , 107.2866 , "None"));
HotSpots.Add(new Vector3(2003.294 , -3790.946 , 126.5496 , "None"));
HotSpots.Add(new Vector3(2282.309 , -4324.563 , 74.0183 , "None"));
HotSpots.Add(new Vector3(2803.395 , -4059.993 , 100.5267 , "None"));
HotSpots.Add(new Vector3(3085.946 , -4149.981 , 96.69297 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class CarrionGrubbage : QuestGrinderClass
{
    public CarrionGrubbage()
    {
        Name = "Carrion Grubbage";

        QuestId.AddRange(new[] { 5544 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 54;
        MaxLevel = 60;
        RequiredQuest = 0;

        EntryTarget.Add(8603);
EntryTarget.Add(8605);
HotSpots.Add(new Vector3(2119.455 , -2824.206 , 82.18719 , "None"));
HotSpots.Add(new Vector3(2048.358 , -3043.32 , 75.9411 , "None"));
HotSpots.Add(new Vector3(2019.208 , -3410.203 , 107.2866 , "None"));
HotSpots.Add(new Vector3(2003.294 , -3790.946 , 126.5496 , "None"));
HotSpots.Add(new Vector3(2282.309 , -4324.563 , 74.0183 , "None"));
HotSpots.Add(new Vector3(2803.395 , -4059.993 , 100.5267 , "None"));
HotSpots.Add(new Vector3(3085.946 , -4149.981 , 96.69297 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DemonDogs2 : QuestGrinderClass
{
    public DemonDogs2()
    {
        Name = "Demon Dogs2";

        QuestId.AddRange(new[] { 5542 });

        Step = new List<int> { 0, 5, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 54;
        MaxLevel = 60;
        RequiredQuest = 0;

        EntryTarget.Add(8597);
HotSpots.Add(new Vector3(2378.51 , -4314.858 , 76.95692 , "None"));
HotSpots.Add(new Vector3(2231.156 , -4684.182 , 73.65624 , "None"));
HotSpots.Add(new Vector3(1989.49 , -4710.482 , 99.41259 , "None"));
HotSpots.Add(new Vector3(2065.549 , -4892.85 , 75.44534 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class DemonDogs3 : QuestGrinderClass
{
    public DemonDogs3()
    {
        Name = "Demon Dogs3";

        QuestId.AddRange(new[] { 5542 });

        Step = new List<int> { 0, 0, 5, 0, 0 };

        StepAutoDetect = new[] { true, true, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 54;
        MaxLevel = 60;
        RequiredQuest = 0;

        EntryTarget.Add(8598);
HotSpots.Add(new Vector3(2744.573 , -4137.389 , 94.31395 , "None"));
HotSpots.Add(new Vector3(3008.099 , -4177.925 , 95.99927 , "None"));
HotSpots.Add(new Vector3(3119.923 , -4052.391 , 102.3069 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GRIND5457EPLV1 : QuestGrinderClass
{
    public GRIND5457EPLV1()
    {
        Name = "GRIND : 54-57 EPL V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 54;
        MaxLevel = 56;
        RequiredQuest = 0;

        EntryTarget.Add(8597);
EntryTarget.Add(8603);
EntryTarget.Add(8601);
EntryTarget.Add(8534);
EntryTarget.Add(8605);
EntryTarget.Add(8598);
HotSpots.Add(new Vector3(2402.122 , -5024.978 , 77.66197 , "None"));
HotSpots.Add(new Vector3(2364.285 , -4700.612 , 73.89604 , "None"));
HotSpots.Add(new Vector3(2080.935 , -4744.909 , 75.02423 , "None"));
HotSpots.Add(new Vector3(2146.525 , -4708.476 , 73.61153 , "None"));
HotSpots.Add(new Vector3(2495.98 , -4887.649 , 75.46511 , "None"));
HotSpots.Add(new Vector3(2477.489 , -4340.54 , 77.41343 , "None"));
HotSpots.Add(new Vector3(1903.023 , -4881.032 , 90.94923 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 57;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND5457EPLV2 : QuestGrinderClass
{
    public GRIND5457EPLV2()
    {
        Name = "GRIND : 54-57 EPL V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 54;
        MaxLevel = 56;
        RequiredQuest = 0;

        EntryTarget.Add(8603);
EntryTarget.Add(8597);
EntryTarget.Add(8601);
EntryTarget.Add(8605);
EntryTarget.Add(8598);
EntryTarget.Add(8602);
HotSpots.Add(new Vector3(1878.701 , -4903.825 , 85.40297 , "None"));
HotSpots.Add(new Vector3(2101.063 , -4700.228 , 74.21127 , "None"));
HotSpots.Add(new Vector3(2338.791 , -4667.419 , 76.2017 , "None"));
HotSpots.Add(new Vector3(2338.191 , -4878.148 , 82.23361 , "None"));
HotSpots.Add(new Vector3(2404.286 , -5002.978 , 74.11229 , "None"));
HotSpots.Add(new Vector3(2453.792 , -4898.813 , 77.98374 , "None"));
HotSpots.Add(new Vector3(2374.326 , -4534.355 , 75.44735 , "None"));
HotSpots.Add(new Vector3(2241.849 , -4586.374 , 73.63756 , "None"));
HotSpots.Add(new Vector3(2289.668 , -4297.939 , 77.00195 , "None"));
HotSpots.Add(new Vector3(2347.17 , -4111.5 , 75.20834 , "None"));
HotSpots.Add(new Vector3(2184.731 , -4108.653 , 78.41035 , "None"));
HotSpots.Add(new Vector3(2146.657 , -4243.244 , 74.72325 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 57;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND5457WPLV3 : QuestGrinderClass
{
    public GRIND5457WPLV3()
    {
        Name = "GRIND : 54-57 WPL V3";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 54;
        MaxLevel = 56;
        RequiredQuest = 0;

        EntryTarget.Add(1816);
EntryTarget.Add(1824);
EntryTarget.Add(1817);
HotSpots.Add(new Vector3(1974.694 , -2531.178 , 63.36217 , "None"));
HotSpots.Add(new Vector3(2178.494 , -2424.411 , 58.72668 , "None"));
HotSpots.Add(new Vector3(1814.359 , -2446.875 , 62.60709 , "None"));
HotSpots.Add(new Vector3(1816.258 , -2401.049 , 59.29216 , "None"));
HotSpots.Add(new Vector3(1903.348 , -2299.264 , 59.39813 , "None"));
HotSpots.Add(new Vector3(1917.075 , -2177.794 , 75.82745 , "None"));
HotSpots.Add(new Vector3(1793.979 , -2140.211 , 68.24237 , "None"));
HotSpots.Add(new Vector3(1614.138 , -2118.953 , 57.9001 , "None"));
HotSpots.Add(new Vector3(1583.153 , -1972.5 , 61.31609 , "None"));
HotSpots.Add(new Vector3(1841.823 , -1986.855 , 75.78472 , "None"));
HotSpots.Add(new Vector3(2031.109 , -1916.11 , 69.05028 , "None"));
HotSpots.Add(new Vector3(1929.048 , -1872.027 , 73.75267 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 3;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 57;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND5760V1 : QuestGrinderClass
{
    public GRIND5760V1()
    {
        Name = "GRIND : 57 - 60 V1";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 57;
        MaxLevel = 59;
        RequiredQuest = 0;

        EntryTarget.Add(8605);
EntryTarget.Add(8598);
EntryTarget.Add(8602);
HotSpots.Add(new Vector3(2496.966 , -4900.468 , 77.6456 , "None"));
HotSpots.Add(new Vector3(2737.186 , -4987.498 , 90.76369 , "None"));
HotSpots.Add(new Vector3(2804.503 , -4891.058 , 97.87674 , "None"));
HotSpots.Add(new Vector3(2995.369 , -4799.47 , 99.51502 , "None"));
HotSpots.Add(new Vector3(3093.01 , -4818.067 , 101.6019 , "None"));
HotSpots.Add(new Vector3(3096.207 , -4685.299 , 98.00704 , "None"));
HotSpots.Add(new Vector3(3145.203 , -4601.869 , 105.7126 , "None"));
HotSpots.Add(new Vector3(3190.979 , -4514.76 , 108.8509 , "None"));
HotSpots.Add(new Vector3(3276.389 , -4434.293 , 111.2776 , "None"));
HotSpots.Add(new Vector3(3199.393 , -4253.647 , 98.54981 , "None"));
HotSpots.Add(new Vector3(3101.185 , -4147.763 , 98.62512 , "None"));
HotSpots.Add(new Vector3(2958.768 , -4081.875 , 97.1269 , "None"));
HotSpots.Add(new Vector3(2731.462 , -3938.488 , 97.66456 , "None"));
HotSpots.Add(new Vector3(2678.213 , -4163.545 , 85.33191 , "None"));
HotSpots.Add(new Vector3(2825.184 , -4274.859 , 87.7225 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 1;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 60;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND5760V2 : QuestGrinderClass
{
    public GRIND5760V2()
    {
        Name = "GRIND : 57 - 60 V2";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 57;
        MaxLevel = 59;
        RequiredQuest = 0;

        EntryTarget.Add(8605);
EntryTarget.Add(8602);
EntryTarget.Add(8598);
HotSpots.Add(new Vector3(2656.923 , -4129.325 , 85.50586 , "None"));
HotSpots.Add(new Vector3(2777.616 , -4230.743 , 90.51428 , "None"));
HotSpots.Add(new Vector3(2935.922 , -4312.725 , 91.52512 , "None"));
HotSpots.Add(new Vector3(3063.098 , -4100.42 , 98.96375 , "None"));
HotSpots.Add(new Vector3(2877.784 , -4040.779 , 102.3475 , "None"));
HotSpots.Add(new Vector3(2740.575 , -3944.781 , 96.36927 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 2;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 60;
}



public override bool HasQuest() { return true; }


}


public sealed class GRIND5760V3 : QuestGrinderClass
{
    public GRIND5760V3()
    {
        Name = "GRIND : 57 - 60 V3";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 57;
        MaxLevel = 59;
        RequiredQuest = 0;

        EntryTarget.Add(8598);
EntryTarget.Add(8605);
EntryTarget.Add(8602);
EntryTarget.Add(8543);
HotSpots.Add(new Vector3(2747.725 , -3559.197 , 103.9596 , "None"));
HotSpots.Add(new Vector3(2658.019 , -3443.355 , 119.2792 , "None"));
HotSpots.Add(new Vector3(2732.572 , -3314.417 , 97.81879 , "None"));
HotSpots.Add(new Vector3(2786.446 , -3438.201 , 96.77122 , "None"));
HotSpots.Add(new Vector3(2747.83 , -3951.383 , 96.03124 , "None"));
HotSpots.Add(new Vector3(3146.252 , -4123.429 , 96.2352 , "None"));
HotSpots.Add(new Vector3(3203.586 , -4265.138 , 100.9995 , "None"));
HotSpots.Add(new Vector3(3208.74 , -4519.22 , 111.9676 , "None"));
HotSpots.Add(new Vector3(2863.808 , -4877.293 , 102.9959 , "None"));
HotSpots.Add(new Vector3(2760.944 , -4996.216 , 94.22023 , "None"));
HotSpots.Add(new Vector3(2499.586 , -4905.939 , 77.854 , "None"));
HotSpots.Add(new Vector3(2932.792 , -4554.825 , 89.8607 , "None"));
HotSpots.Add(new Vector3(2945.991 , -4329.353 , 90.19656 , "None"));
HotSpots.Add(new Vector3(2803.85 , -4243.931 , 88.63763 , "None"));
HotSpots.Add(new Vector3(2685.929 , -4143.696 , 87.49806 , "None"));
HotSpots.Add(new Vector3(2802.291 , -3942.731 , 102.5922 , "None"));
IsGrinderNotQuest = true;

    }

	public override bool CanConditions()
	{
        return Var.GetVar<int>("MyVarName_SelectedTask") == 3;
	}

public override bool IsComplete() { 
return !CanConditions() || ObjectManager.Me.Level == 60;
}



public override bool HasQuest() { return true; }


}


public sealed class PATHSWtoDeeprunStram : QuestFollowPathClass
{
    public PATHSWtoDeeprunStram()
    {
        Name = "PATH: SW to Deeprun Stram";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 59;
        RequiredQuest = 0;

        Path.Add(new Vector3(-8452.505 , 583.374 , 94.29171 , "None"));
Path.Add(new Vector3(-8447.281 , 580.6334 , 94.45761 , "None"));
Path.Add(new Vector3(-8440.808 , 577.9631 , 94.4569 , "None"));
Path.Add(new Vector3(-8434.184 , 574.8599 , 94.39172 , "None"));
Path.Add(new Vector3(-8427.852 , 571.8931 , 93.70213 , "None"));
Path.Add(new Vector3(-8421.258 , 569.3616 , 93.0959 , "None"));
Path.Add(new Vector3(-8413.45 , 570.07 , 92.38998 , "None"));
Path.Add(new Vector3(-8406.399 , 570.8886 , 91.56113 , "None"));
Path.Add(new Vector3(-8399.375 , 571.8372 , 91.3941 , "None"));
Path.Add(new Vector3(-8392.747 , 572.8348 , 91.36945 , "None"));
Path.Add(new Vector3(-8388.325 , 567.3363 , 91.79716 , "None"));
Path.Add(new Vector3(-8384.462 , 561.6449 , 91.79716 , "None"));
Path.Add(new Vector3(-8379.938 , 555.8983 , 91.79716 , "None"));
Path.Add(new Vector3(-8375.391 , 550.3125 , 91.79716 , "None"));
Path.Add(new Vector3(-8371.058 , 544.8234 , 91.79716 , "None"));
Path.Add(new Vector3(-8366.66 , 539.252 , 91.79716 , "None"));
Path.Add(new Vector3(-8362.263 , 533.6805 , 91.79716 , "None"));
Path.Add(new Vector3(-8357.867 , 528.1071 , 91.79716 , "None"));
Path.Add(new Vector3(-8353.338 , 522.7927 , 91.79716 , "None"));
Path.Add(new Vector3(-8352.977 , 522.3835 , 91.79716 , "None"));
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


public sealed class PATHExitTramtoIronforge : QuestFollowPathClass
{
    public PATHExitTramtoIronforge()
    {
        Name = "PATH: Exit Tram to Ironforge";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 59;
        RequiredQuest = 0;

        Path.Add(new Vector3(-74.26666 , 6.730288 , -4.29735 , "None"));
Path.Add(new Vector3(-72.52988 , -9.888319 , -4.29735 , "None"));
Path.Add(new Vector3(-70.13771 , -16.22882 , -4.29735 , "None"));
Path.Add(new Vector3(-60.52805 , -21.78855 , -4.29735 , "None"));
Path.Add(new Vector3(-52.80638 , -28.87268 , -4.29735 , "None"));
Path.Add(new Vector3(-43.99636 , -34.88923 , -4.29735 , "None"));
Path.Add(new Vector3(-34.75562 , -30.72346 , -4.29735 , "None"));
Path.Add(new Vector3(-29.46018 , -21.69542 , -4.29735 , "None"));
Path.Add(new Vector3(-25.93352 , -18.66632 , -4.29735 , "None"));
Path.Add(new Vector3(-17.41892 , -18.23738 , -4.29735 , "None"));
Path.Add(new Vector3(-13.10554 , -20.77237 , -4.29735 , "None"));
Path.Add(new Vector3(-6.653353 , -29.019 , -4.29735 , "None"));
Path.Add(new Vector3(1.424403 , -35.6418 , -4.29735 , "None"));
Path.Add(new Vector3(8.41083 , -33.60084 , -4.29735 , "None"));
Path.Add(new Vector3(12.2567 , -30.54197 , -4.29735 , "None"));
Path.Add(new Vector3(14.89782 , -25.98698 , -4.29735 , "None"));
Path.Add(new Vector3(16.62051 , -21.03082 , -4.296054 , "None"));
Path.Add(new Vector3(19.16709 , -13.58151 , -4.296054 , "None"));
Path.Add(new Vector3(19.07397 , -2.785898 , -4.296054 , "None"));
Path.Add(new Vector3(22.87851 , 6.534564 , -4.296054 , "None"));
Path.Add(new Vector3(32.7992 , 9.740255 , -4.296054 , "None"));
Path.Add(new Vector3(43.53796 , 10.97171 , -4.296054 , "None"));
Path.Add(new Vector3(54.35165 , 10.88753 , -4.296054 , "None"));
Path.Add(new Vector3(64.81857 , 10.3889 , -4.296054 , "None"));
Path.Add(new Vector3(68.08987 , 10.21344 , -4.296054 , "None"));
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


public sealed class PATHDeeprunTramSWBoardTram : QuestFollowPathClass
{
    public PATHDeeprunTramSWBoardTram()
    {
        Name = "PATH: Deeprun Tram (SW) - Board Tram";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 13;
        RequiredQuest = 0;

        Path.Add(new Vector3(59.74186 , 2491.007 , -4.295767 , "None"));
Path.Add(new Vector3(48.5934 , 2491.245 , -4.295767 , "None"));
Path.Add(new Vector3(38.11558 , 2491.378 , -4.295767 , "None"));
Path.Add(new Vector3(33.728 , 2490.343 , -4.295696 , "None"));
Path.Add(new Vector3(31.97809 , 2494.06 , -4.295696 , "None"));
Path.Add(new Vector3(31.65152 , 2505.206 , -4.297107 , "None"));
Path.Add(new Vector3(31.32414 , 2515.676 , -4.296387 , "None"));
Path.Add(new Vector3(25.70915 , 2520.401 , -4.296387 , "None"));
Path.Add(new Vector3(18.66544 , 2523.088 , -4.296387 , "None"));
Path.Add(new Vector3(15.95669 , 2525.446 , -4.296387 , "None"));
Path.Add(new Vector3(12.17129 , 2529.083 , -4.296387 , "None"));
Path.Add(new Vector3(7.687648 , 2533.373 , -4.296387 , "None"));
Path.Add(new Vector3(-0.4604442 , 2535.872 , -4.296387 , "None"));
Path.Add(new Vector3(-5.921811 , 2533.579 , -4.296387 , "None"));
Path.Add(new Vector3(-9.290902 , 2527.599 , -4.296387 , "None"));
Path.Add(new Vector3(-11.7984 , 2518.096 , -4.296387 , "None"));
Path.Add(new Vector3(-13.93189 , 2507.496 , -4.296387 , "None"));
Path.Add(new Vector3(-15.9283 , 2497.212 , -4.296387 , "None"));
Path.Add(new Vector3(-18.92509 , 2493.879 , -4.296387 , "None"));
Path.Add(new Vector3(-23.81785 , 2493.831 , -4.296387 , "None"));
Path.Add(new Vector3(-27.82842 , 2493.526 , -4.296387 , "None"));
Path.Add(new Vector3(-33.76641 , 2492.648 , -4.290812 , "None"));
Path.Add(new Vector3(-38.22335 , 2492.576 , -3.928149 , "None"));
Path.Add(new Vector3(-40.13146 , 2492.637 , -4.165924 , "None"));
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


public sealed class PATHIronforgeTramtoWeaponsMaster : QuestFollowPathClass
{
    public PATHIronforgeTramtoWeaponsMaster()
    {
        Name = "PATH: Ironforge Tram to Weapons Master";

        QuestId.AddRange(new[] { 0 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 10;
        MaxLevel = 13;
        RequiredQuest = 0;

        Path.Add(new Vector3(-4837.482 , -1304.549 , 501.8682 , "None"));
Path.Add(new Vector3(-4835.163 , -1287.995 , 501.8682 , "None"));
Path.Add(new Vector3(-4834.802 , -1277.254 , 501.8682 , "None"));
Path.Add(new Vector3(-4844.59 , -1267.1 , 501.8682 , "None"));
Path.Add(new Vector3(-4855.354 , -1266.321 , 501.8682 , "None"));
Path.Add(new Vector3(-4875.822 , -1262.792 , 501.8682 , "None"));
Path.Add(new Vector3(-4894.46 , -1253.937 , 501.8682 , "None"));
Path.Add(new Vector3(-4913.243 , -1244.64 , 501.8682 , "None"));
Path.Add(new Vector3(-4929.667 , -1236.495 , 501.6599 , "None"));
Path.Add(new Vector3(-4940.086 , -1233.965 , 501.6599 , "None"));
Path.Add(new Vector3(-4961.261 , -1232.099 , 501.6684 , "None"));
Path.Add(new Vector3(-4971.264 , -1228.074 , 501.6708 , "None"));
Path.Add(new Vector3(-4988.069 , -1215.632 , 501.674 , "None"));
Path.Add(new Vector3(-4995.791 , -1208.066 , 501.6753 , "None"));
Path.Add(new Vector3(-5009.811 , -1196.243 , 501.6616 , "None"));
Path.Add(new Vector3(-5015.032 , -1196.778 , 501.6576 , "None"));
Path.Add(new Vector3(-5023.094 , -1201.163 , 504.4831 , "None"));
Path.Add(new Vector3(-5027.474 , -1203.39 , 507.4887 , "None"));
Path.Add(new Vector3(-5029.334 , -1202.333 , 507.4887 , "None"));
Path.Add(new Vector3(-5030.672 , -1200.476 , 508.0002 , "None"));
Path.Add(new Vector3(-5032.727 , -1197.531 , 508.8779 , "None"));
Path.Add(new Vector3(-5034.297 , -1197.995 , 508.8779 , "None"));
Path.Add(new Vector3(-5036.344 , -1199.065 , 508.9015 , "None"));
Path.Add(new Vector3(-5039.743 , -1201.032 , 508.9015 , "None"));
Path.Add(new Vector3(-5040.492 , -1202.835 , 508.9015 , "None"));
Path.Add(new Vector3(-5041.497 , -1205.261 , 508.9015 , "None"));
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
