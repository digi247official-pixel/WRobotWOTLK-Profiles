
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



public sealed class AMissionStatement : QuestGrinderClass
{
    public AMissionStatement()
    {
        Name = "A Mission Statement";

        QuestId.AddRange(new[] { 11864 });

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





public override bool HasQuest() { return true; }


}


public sealed class HelpThoseThatCannotHelpThemselves : QuestUseItemOnClass
{
    public HelpThoseThatCannotHelpThemselves()
    {
        Name = "Help Those That Cannot Help Themselves";

        QuestId.AddRange(new[] { 11876 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(25850);
HotSpots.Add(new Vector3(3249.78 , 5392.41 , 48.84383 , "None"));
HotSpots.Add(new Vector3(3326.09 , 5376.9 , 42.99329 , "None"));
HotSpots.Add(new Vector3(3340.77 , 5470.43 , 59.88654 , "None"));
HotSpots.Add(new Vector3(3418.56 , 5462.99 , 64.10538 , "None"));
HotSpots.Add(new Vector3(3419.93 , 5385.92 , 48.1776 , "None"));
HotSpots.Add(new Vector3(3443.23 , 5312.54 , 40.57342 , "None"));
HotSpots.Add(new Vector3(3426.66 , 5249.49 , 35.08178 , "None"));
HotSpots.Add(new Vector3(3553.19 , 5324.67 , 31.29932 , "None"));
ItemId = 35228;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class EarsofOurEnemies : QuestGrinderClass
{
    public EarsofOurEnemies()
    {
        Name = "Ears of Our Enemies";

        QuestId.AddRange(new[] { 11866 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25836);
HotSpots.Add(new Vector3(3240.15 , 5532.58 , 40.91942 , "Swimming"));
HotSpots.Add(new Vector3(3224.094 , 5555.18 , 38.266 , "Swimming"));
HotSpots.Add(new Vector3(3219.63 , 5590.627 , 35.47684 , "Swimming"));
HotSpots.Add(new Vector3(3141.767 , 5610.748 , 36.23897 , "Swimming"));
HotSpots.Add(new Vector3(3064.019 , 5556.374 , 42.36401 , "Swimming"));
HotSpots.Add(new Vector3(3096.001 , 5673.117 , 49.37878 , "None"));
HotSpots.Add(new Vector3(3193.715 , 5770.001 , 50.41688 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class NedLordofRhinos : QuestGrinderClass
{
    public NedLordofRhinos()
    {
        Name = "Ned, Lord of Rhinos...";

        QuestId.AddRange(new[] { 11884 });

        Step = new List<int> { 1, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25968);
EntryTarget.Add(25801);
HotSpots.Add(new Vector3(3323.87 , 5856.404 , 79.92429 , "None"));
HotSpots.Add(new Vector3(3300.982 , 5850.269 , 77.91865 , "None"));
HotSpots.Add(new Vector3(3275.216 , 5847.146 , 82.37307 , "None"));
HotSpots.Add(new Vector3(3233.249 , 5857.513 , 92.91602 , "None"));
HotSpots.Add(new Vector3(3215.412 , 5868.289 , 93.93764 , "None"));
HotSpots.Add(new Vector3(3196.379 , 5884.417 , 98.58659 , "None"));
HotSpots.Add(new Vector3(3181.332 , 5901.43 , 98.4527 , "None"));
HotSpots.Add(new Vector3(3165.569 , 5910.545 , 95.96181 , "None"));
HotSpots.Add(new Vector3(3164.231 , 5939.188 , 95.76735 , "None"));
HotSpots.Add(new Vector3(3178.011 , 5969.029 , 95.5125 , "None"));
HotSpots.Add(new Vector3(3194.552 , 5985.267 , 91.56465 , "None"));
HotSpots.Add(new Vector3(3217.468 , 5991.208 , 89.89307 , "None"));
HotSpots.Add(new Vector3(3249.089 , 5996.037 , 85.85278 , "None"));
HotSpots.Add(new Vector3(3273.452 , 5999.757 , 82.42666 , "None"));
HotSpots.Add(new Vector3(3289.677 , 6002.235 , 80.97064 , "None"));
HotSpots.Add(new Vector3(3310.868 , 5992.808 , 78.39372 , "None"));
HotSpots.Add(new Vector3(3324.014 , 5977.193 , 78.73382 , "None"));
HotSpots.Add(new Vector3(3337.661 , 5956.206 , 79.2075 , "None"));
HotSpots.Add(new Vector3(3345.271 , 5935.887 , 81.06977 , "None"));
HotSpots.Add(new Vector3(3347.363 , 5909.881 , 79.49648 , "None"));
HotSpots.Add(new Vector3(3346.135 , 5883.853 , 79.62039 , "None"));
HotSpots.Add(new Vector3(3344.215 , 5860.715 , 77.8571 , "None"));
HotSpots.Add(new Vector3(3335.642 , 5845.841 , 76.62215 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HappyasaClam : QuestGrinderClass
{
    public HappyasaClam()
    {
        Name = "Happy as a Clam";

        QuestId.AddRange(new[] { 11869 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25836);
HotSpots.Add(new Vector3(3241.867 , 5524.448 , 43.53674 , "Swimming"));
HotSpots.Add(new Vector3(3219.084 , 5554.306 , 38.4458 , "Swimming"));
HotSpots.Add(new Vector3(3182.76 , 5580.354 , 38.13383 , "Swimming"));
HotSpots.Add(new Vector3(3176.512 , 5617.751 , 35.1278 , "Swimming"));
HotSpots.Add(new Vector3(3208.271 , 5625.059 , 38.5207 , "Swimming"));
HotSpots.Add(new Vector3(3197.305 , 5651.623 , 43.05434 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class UnfitforDeath : QuestUseItemOnClass
{
    public UnfitforDeath()
    {
        Name = "Unfit for Death";

        QuestId.AddRange(new[] { 11865 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(187982);
HotSpots.Add(new Vector3(3126.28 , 5316.175 , 53.62225 , "None"));
HotSpots.Add(new Vector3(3115.744 , 5251.316 , 60.59959 , "None"));
HotSpots.Add(new Vector3(3064.789 , 5236.71 , 64.6889 , "None"));
HotSpots.Add(new Vector3(3031.797 , 5271.146 , 61.39884 , "None"));
HotSpots.Add(new Vector3(3043.975 , 5315.725 , 59.80193 , "None"));
HotSpots.Add(new Vector3(3043.31 , 5317.912 , 59.81796 , "None"));
HotSpots.Add(new Vector3(3030.025 , 5271.767 , 61.34235 , "None"));
HotSpots.Add(new Vector3(2997.502 , 5229.762 , 62.95183 , "None"));
HotSpots.Add(new Vector3(3029.957 , 5268.611 , 61.47076 , "None"));
HotSpots.Add(new Vector3(2976.573 , 5288.34 , 61.62946 , "None"));
HotSpots.Add(new Vector3(2951.651 , 5247.151 , 60.72592 , "None"));
HotSpots.Add(new Vector3(2895.07 , 5260.393 , 60.16481 , "None"));
HotSpots.Add(new Vector3(2922.863 , 5294.162 , 60.82711 , "None"));
HotSpots.Add(new Vector3(3030.195 , 5270.345 , 61.52745 , "None"));
HotSpots.Add(new Vector3(3062.974 , 5237.396 , 64.95847 , "None"));
ItemId = 35127;
Range = 0.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KhunokWillKnow : QuestClass
{
    public KhunokWillKnow()
    {
        Name = "Khu'nok Will Know";

        QuestId.AddRange(new[] { 11878 });

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


public sealed class TheAbandonedReach : QuestClass
{
    public TheAbandonedReach()
    {
        Name = "The Abandoned Reach";

        QuestId.AddRange(new[] { 11870 });

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


public sealed class TheCullerCometh : QuestGrinderClass
{
    public TheCullerCometh()
    {
        Name = "The Culler Cometh";

        QuestId.AddRange(new[] { 11868 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25803);
HotSpots.Add(new Vector3(2722.843 , 5265.726 , 71.6504 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KawtheMammothDestroyer : QuestGrinderClass
{
    public KawtheMammothDestroyer()
    {
        Name = "Kaw the Mammoth Destroyer";

        QuestId.AddRange(new[] { 11879 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25881);
HotSpots.Add(new Vector3(3942.914 , 5464.194 , 26.63824 , "None"));
HotSpots.Add(new Vector3(3945.771 , 5481.005 , 28.3444 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KawtheMammothDestroyer1 : QuestFollowPathClass
{
    public KawtheMammothDestroyer1()
    {
        Name = "Kaw the Mammoth Destroyer1";

        QuestId.AddRange(new[] { 11879 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(4112.54 , 5533.19 , 27.69124 , "None"));
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


public sealed class NotOnOurWatch : QuestGathererClass
{
    public NotOnOurWatch()
    {
        Name = "Not On Our Watch";

        QuestId.AddRange(new[] { 11871 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188015);
HotSpots.Add(new Vector3(2726.07 , 5217.674 , 29.39567 , "None"));
HotSpots.Add(new Vector3(2669.952 , 5179.325 , 21.82195 , "None"));
HotSpots.Add(new Vector3(2660.236 , 5198.247 , 26.28893 , "None"));
HotSpots.Add(new Vector3(2709.642 , 5220.386 , 29.2992 , "None"));
HotSpots.Add(new Vector3(2642.661 , 5167.398 , 8.633203 , "None"));
HotSpots.Add(new Vector3(2570.221 , 5117.938 , 8.916415 , "None"));
HotSpots.Add(new Vector3(2516.497 , 5119.103 , 8.725814 , "None"));
HotSpots.Add(new Vector3(2414.805 , 5040.324 , 0.4783444 , "None"));
HotSpots.Add(new Vector3(2639.802 , 5117.383 , 14.38567 , "None"));
HotSpots.Add(new Vector3(2657.741 , 5094.549 , 21.9052 , "None"));
HotSpots.Add(new Vector3(2678.106 , 5099.425 , 24.47324 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheNefariousClamMaster : QuestGrinderClass
{
    public TheNefariousClamMaster()
    {
        Name = "The Nefarious Clam Master...";

        QuestId.AddRange(new[] { 11872 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25800);
HotSpots.Add(new Vector3(2360.028 , 4980.951 , -27.99376 , "Swimming"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheAssassinationofHaroldLane : QuestGrinderClass
{
    public TheAssassinationofHaroldLane()
    {
        Name = "The Assassination of Harold Lane";

        QuestId.AddRange(new[] { 11892 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(25804);
HotSpots.Add(new Vector3(3296.292 , 5691.104 , 59.0966 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 11892);
}






}


public sealed class TheAssassinationofHaroldLane1 : QuestFollowPathClass
{
    public TheAssassinationofHaroldLane1()
    {
        Name = "The Assassination of Harold Lane 1";

        QuestId.AddRange(new[] { 11892 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 2;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        Path.Add(new Vector3(3297.683 , 5689.31 , 59.08832 , "None"));
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


public sealed class Tolunch : QuestFollowPathClass
{
    public Tolunch()
    {
        Name = "To lunch";

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

        Path.Add(new Vector3(3356.222 , 5851.417 , 73.3046 , "None"));
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

        Path.Add(new Vector3(3345.47 , 5831.635 , 73.25101 , "None"));
Path.Add(new Vector3(3339.675 , 5826.822 , 70.26576 , "None"));
Path.Add(new Vector3(3337.198 , 5819.157 , 67.41708 , "None"));
Path.Add(new Vector3(3334.163 , 5811.424 , 64.98216 , "None"));
Path.Add(new Vector3(3329.399 , 5804.162 , 63.10897 , "None"));
Path.Add(new Vector3(3324.791 , 5797.139 , 61.45973 , "None"));
Path.Add(new Vector3(3320.34 , 5790.354 , 59.61394 , "None"));
Path.Add(new Vector3(3315.05 , 5783.843 , 56.87233 , "None"));
Path.Add(new Vector3(3309.128 , 5777.895 , 55.27692 , "None"));
Path.Add(new Vector3(3303.04 , 5772.083 , 50.55802 , "None"));
Path.Add(new Vector3(3296.897 , 5765.967 , 50.76646 , "None"));
Path.Add(new Vector3(3291.015 , 5760.375 , 50.14433 , "None"));
Path.Add(new Vector3(3283.363 , 5757.046 , 48.66015 , "None"));
Path.Add(new Vector3(3275.682 , 5753.726 , 46.68189 , "None"));
Path.Add(new Vector3(3271.38 , 5750.824 , 46.45668 , "Swimming"));
Path.Add(new Vector3(3267.279 , 5747.816 , 46.45668 , "Swimming"));
Path.Add(new Vector3(3263.007 , 5745.439 , 46.45668 , "Swimming"));
Path.Add(new Vector3(3258.369 , 5743.578 , 46.45668 , "Swimming"));
Path.Add(new Vector3(3253.628 , 5741.989 , 46.45668 , "Swimming"));
Path.Add(new Vector3(3246.241 , 5739.506 , 47.48393 , "None"));
Path.Add(new Vector3(3238.533 , 5736.918 , 49.14075 , "None"));
Path.Add(new Vector3(3231.555 , 5732.419 , 49.1172 , "None"));
Path.Add(new Vector3(3225.88 , 5726.247 , 47.35815 , "None"));
Path.Add(new Vector3(3224.08 , 5723.055 , 46.58767 , "Swimming"));
Path.Add(new Vector3(3221.438 , 5719.255 , 46.58767 , "Swimming"));
Path.Add(new Vector3(3219.705 , 5714.749 , 46.58767 , "Swimming"));
Path.Add(new Vector3(3218.38 , 5709.954 , 46.58767 , "Swimming"));
Path.Add(new Vector3(3217.042 , 5705.11 , 46.58767 , "Swimming"));
Path.Add(new Vector3(3216.471 , 5700.612 , 46.58767 , "Swimming"));
Path.Add(new Vector3(3216.701 , 5695.638 , 46.58767 , "Swimming"));
Path.Add(new Vector3(3216.68 , 5680.911 , 46.58767 , "Swimming"));
Path.Add(new Vector3(3215.949 , 5665.94 , 46.58767 , "Swimming"));
Path.Add(new Vector3(3214.459 , 5652.216 , 46.58767 , "Swimming"));
Path.Add(new Vector3(3215.398 , 5637.259 , 46.58767 , "Swimming"));
Path.Add(new Vector3(3218.989 , 5622.695 , 46.58767 , "Swimming"));
Path.Add(new Vector3(3225.679 , 5609.373 , 46.58767 , "Swimming"));
Path.Add(new Vector3(3233.068 , 5596.319 , 46.58767 , "Swimming"));
Path.Add(new Vector3(3239.058 , 5583.253 , 46.63818 , "Swimming"));
Path.Add(new Vector3(3249.024 , 5572.142 , 46.63818 , "Swimming"));
Path.Add(new Vector3(3259.748 , 5562.384 , 46.63818 , "Swimming"));
Path.Add(new Vector3(3271.201 , 5554.71 , 47.04615 , "None"));
Path.Add(new Vector3(3278.541 , 5550.613 , 48.34993 , "None"));
Path.Add(new Vector3(3285.858 , 5546.607 , 49.18645 , "None"));
Path.Add(new Vector3(3292.84 , 5542.838 , 49.29553 , "None"));
Path.Add(new Vector3(3296.156 , 5534.847 , 49.29409 , "None"));
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
