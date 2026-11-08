
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


public sealed class TheMechagnomes : QuestClass
{
    public TheMechagnomes()
    {
        Name = "The Mechagnomes";

        QuestId.AddRange(new[] { 11708 });

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


public sealed class DirtyStinkinSnobolds : QuestGathererClass
{
    public DirtyStinkinSnobolds()
    {
        Name = "Dirty, Stinkin' Snobolds!";

        QuestId.AddRange(new[] { 11645 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(187899);
HotSpots.Add(new Vector3(4046.098 , 5158.081 , 14.64482 , "None"));
HotSpots.Add(new Vector3(4116.266 , 5181.066 , 13.11844 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class KingMrglMrgl : QuestClass
{
    public KingMrglMrgl()
    {
        Name = "King Mrgl-Mrgl";

        QuestId.AddRange(new[] { 11704 });

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


public sealed class WhatstheMatterwiththeTransmatter : QuestClass
{
    public WhatstheMatterwiththeTransmatter()
    {
        Name = "What's the Matter with the Transmatter?";

        QuestId.AddRange(new[] { 11710 });

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


public sealed class TheUltrasonicScrewdriver : QuestClass
{
    public TheUltrasonicScrewdriver()
    {
        Name = "The Ultrasonic Screwdriver";

        QuestId.AddRange(new[] { 11729 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 34984;

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


public sealed class ReCursive : QuestInteractWithClass
{
    public ReCursive()
    {
        Name = "Re-Cursive";

        QuestId.AddRange(new[] { 11712 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(25814);
HotSpots.Add(new Vector3(3766.834 , 4820.604 , -12.70124 , "None"));
HotSpots.Add(new Vector3(3792.117 , 4810.954 , -13.07219 , "None"));
HotSpots.Add(new Vector3(4043.338 , 4967.68 , -13.00827 , "None"));
HotSpots.Add(new Vector3(4163.68 , 4886.2 , -12.99139 , "None"));
HotSpots.Add(new Vector3(4153.802 , 4849.955 , -12.99566 , "None"));
HotSpots.Add(new Vector3(4242.065 , 4787.916 , -12.99564 , "None"));
HotSpots.Add(new Vector3(4244.962 , 4851.304 , -12.75908 , "None"));
HotSpots.Add(new Vector3(4172.596 , 4893.426 , -12.99448 , "None"));
HotSpots.Add(new Vector3(4118.59 , 5097.23 , -1.509624 , "None"));
HotSpots.Add(new Vector3(4117.145 , 5124.015 , -1.510137 , "None"));
HotSpots.Add(new Vector3(4018.095 , 5187.55 , 17.43386 , "None"));
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
