
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



public sealed class Road : QuestFollowPathClass
{
    public Road()
    {
        Name = "Road";

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

        Path.Add(new Vector3(4167.551 , 5281.24 , 26.69355 , "None"));
Path.Add(new Vector3(4168.228 , 5281.228 , 26.69355 , "None"));
Path.Add(new Vector3(4172.131 , 5281.157 , 26.69355 , "None"));
Path.Add(new Vector3(4176.171 , 5281.084 , 26.69355 , "None"));
Path.Add(new Vector3(4180.485 , 5281.009 , 26.69355 , "None"));
Path.Add(new Vector3(4181.419 , 5280.996 , 26.69355 , "None"));
Path.Add(new Vector3(4181.95 , 5281.005 , 26.66542 , "None"));
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


public sealed class Point : QuestFollowPathClass
{
    public Point()
    {
        Name = "Point";

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

        Path.Add(new Vector3(4172.141 , 5280.684 , 26.69301 , "None"));
Path.Add(new Vector3(4175.249 , 5280.906 , 26.69301 , "None"));
Path.Add(new Vector3(4179.395 , 5281.079 , 26.69301 , "None"));
Path.Add(new Vector3(4180.2 , 5281.09 , 26.69301 , "None"));
Path.Add(new Vector3(4181.286 , 5281.063 , 26.69301 , "None"));
Path.Add(new Vector3(4181.354 , 5280.924 , 26.69306 , "None"));
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


public sealed class FindingPilotTailspin : QuestClass
{
    public FindingPilotTailspin()
    {
        Name = "Finding Pilot Tailspin";

        QuestId.AddRange(new[] { 11725 });

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


public sealed class RoadDown : QuestFollowPathClass
{
    public RoadDown()
    {
        Name = "Road Down";

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

        Path.Add(new Vector3(4178.945 , 5283.635 , 39.56923 , "None"));
Path.Add(new Vector3(4179 , 5282.131 , 39.56923 , "None"));
Path.Add(new Vector3(4179.639 , 5281.783 , 39.56923 , "None"));
Path.Add(new Vector3(4180.474 , 5281.766 , 39.56923 , "None"));
Path.Add(new Vector3(4181.136 , 5281.752 , 39.56923 , "None"));
Path.Add(new Vector3(4181.681 , 5281.741 , 39.56923 , "None"));
Path.Add(new Vector3(4182.188 , 5281.73 , 39.56923 , "None"));
Path.Add(new Vector3(4182.481 , 5281.725 , 39.37236 , "None"));
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
return (ObjectManager.Me.Position.DistanceTo2D(new Vector3(4182.412, 5281.727, 39.46781)) < 1);
}

public override bool IsCompleted() { return false; }

public override bool HasQuest() { return true; }


}


public sealed class TheGearmaster : QuestGathererClass
{
    public TheGearmaster()
    {
        Name = "The Gearmaster";

        QuestId.AddRange(new[] { 11798 });

        Step = new List<int> { 1, 1, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(190334);
EntryIdObjects.Add(190335);
HotSpots.Add(new Vector3(4000.347 , 4854.095 , 25.97182 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}
