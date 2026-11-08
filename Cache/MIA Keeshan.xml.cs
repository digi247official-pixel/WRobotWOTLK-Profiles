
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



public sealed class MissingInAction : QuestFollowNpcClass
{
    public MissingInAction()
    {
        Name = "MissingInAction";

        QuestId.AddRange(new[] { 219 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        StartPosition = new Vector3(-8756.77 , -2187.12 , 139.7935 , "None");
NpcEntry = 349;
Assist = true;
FollowDistance = 10f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}
