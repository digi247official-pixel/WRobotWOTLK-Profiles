
using System.Linq;
using robotManager.Helpful;
using wManager.Wow.Class;
using wManager.Wow.Enums;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;
using System.Collections.Generic;
using System.Threading;
using wManager.Wow.Bot.Tasks;


public class SwallowFix
{
    public static void Run()
    {
        if (!wManager.Wow.Helpers.Quest.HasQuest(12049) ||
            wManager.Wow.Helpers.Quest.IsObjectiveComplete(1, 12049)) return;
        var settings = wManager.wManagerSetting.CurrentSetting;
        bool elite = settings.AttackElite;
        bool assist = settings.CanAttackUnitsAlreadyInFight;
        var deadline = System.DateTime.Now.AddMinutes(10);
        var cancel = new System.Threading.ManualResetEvent(false);
        var patrol = new robotManager.Helpful.Vector3[] {
            new robotManager.Helpful.Vector3(4655.861f, 364.1464f, 108.3749f),
            new robotManager.Helpful.Vector3(4686.585f, 337.9527f, 117.1035f),
            new robotManager.Helpful.Vector3(4781.179f, 296.599f, 137.815f),
            new robotManager.Helpful.Vector3(4745.618f, 228.0944f, 123.6437f),
            new robotManager.Helpful.Vector3(4832.627f, 263.703f, 156.3384f)
        };
        int waypoint = 0;
        bool workerFailed = false;
        var bomber = new System.Threading.Thread(() =>
        {
            try
            {
                var next = System.DateTime.MinValue;
                while (!cancel.WaitOne(200) && robotManager.Products.Products.IsStarted &&
                    System.DateTime.Now < deadline && wManager.Wow.Helpers.Quest.HasQuest(12049) &&
                    !wManager.Wow.Helpers.Quest.IsObjectiveComplete(1, 12049))
                {
                    if (!wManager.Wow.Helpers.Conditions.InGameAndConnectedAndAliveAndProductStartedNotInPause) continue;
                    var target = wManager.Wow.ObjectManager.ObjectManager.Target;
                    if (target.IsValid && target.Entry == 26293 && target.IsAlive &&
                        target.HealthPercent <= 80 && target.GetDistance < 20f && System.DateTime.Now >= next)
                    {
                        next = System.DateTime.Now.AddMilliseconds(700);
                        wManager.Wow.Helpers.ItemsManager.UseItem(36732);
                        robotManager.Helpful.Logging.WriteDebug("[Swallow] Explosive used on weakened Hulking Jormungar; health=" + target.HealthPercent);
                    }
                }
            }
            catch (System.Exception ex)
            {
                workerFailed = true;
                robotManager.Helpful.Logging.WriteDebug("[Swallow] Explosive worker failed: " + ex);
                wManager.Wow.Helpers.Fight.StopFight();
            }
        });
        bomber.IsBackground = true;
        try
        {
            settings.AttackElite = true;
            settings.CanAttackUnitsAlreadyInFight = true;
            bomber.Start();
            while (robotManager.Products.Products.IsStarted && !workerFailed &&
                System.DateTime.Now < deadline && wManager.Wow.Helpers.Quest.HasQuest(12049) &&
                !wManager.Wow.Helpers.Quest.IsObjectiveComplete(1, 12049))
            {
                if (wManager.Wow.ObjectManager.ObjectManager.Me.IsDead)
                {
                    robotManager.Helpful.Logging.WriteDebug("[Swallow] Player died; stopping for recovery.");
                    break;
                }
                wManager.Wow.ObjectManager.WoWGameObject meat = null;
                float nearest = float.MaxValue;
                foreach (var obj in wManager.Wow.ObjectManager.ObjectManager.GetObjectWoWGameObject())
                    if (obj.Entry == 188434 && obj.GetDistance < nearest && obj.GetDistance < 100f)
                    { meat = obj; nearest = obj.GetDistance; }
                if (meat != null)
                {
                    if (nearest > 4f)
                        wManager.Wow.Bot.Tasks.GoToTask.ToPosition(meat.Position);
                    else
                    {
                        wManager.Wow.Helpers.MovementManager.StopMove();
                        wManager.Wow.Helpers.Interact.InteractGameObject(meat.GetBaseAddress);
                        System.Threading.Thread.Sleep(900);
                        wManager.Wow.Helpers.Lua.LuaDoString("if LootFrame and LootFrame:IsVisible() then for i=GetNumLootItems(),1,-1 do LootSlot(i) end end");
                        System.Threading.Thread.Sleep(700);
                        robotManager.Helpful.Logging.WriteDebug("[Swallow] Collected meat; count=" +
                            wManager.Wow.Helpers.Lua.LuaDoString<int>("return GetItemCount(36731)"));
                    }
                }
                else
                {
                    if (wManager.Wow.Helpers.Lua.LuaDoString<int>("return GetItemCount(36732)") < 1)
                    {
                        robotManager.Helpful.Logging.WriteDebug("[Swallow] Missing Potent Explosive Charge (36732); stopping.");
                        break;
                    }
                    wManager.Wow.ObjectManager.WoWUnit worm = null;
                    float distance = float.MaxValue;
                    foreach (var unit in wManager.Wow.ObjectManager.ObjectManager.GetObjectWoWUnit())
                        if (unit.Entry == 26293 && !unit.IsDead && unit.GetDistance < distance && unit.GetDistance < 100f)
                        { worm = unit; distance = unit.GetDistance; }
                    if (worm != null)
                    {
                        robotManager.Helpful.Logging.WriteDebug("[Swallow] Fighting Hulking Jormungar; explosive ready at 80% health.");
                        wManager.Wow.Helpers.Fight.StartFight(worm.Guid);
                        System.Threading.Thread.Sleep(1000);
                    }
                    else
                    {
                        if (wManager.Wow.ObjectManager.ObjectManager.Me.Position.DistanceTo(patrol[waypoint]) < 6f)
                            waypoint = (waypoint + 1) % patrol.Length;
                        wManager.Wow.Bot.Tasks.GoToTask.ToPosition(patrol[waypoint]);
                    }
                }
                System.Threading.Thread.Sleep(300);
            }
        }
        finally
        {
            cancel.Set();
            if (bomber.IsAlive && !bomber.Join(5000))
                robotManager.Helpful.Logging.WriteDebug("[Swallow] Explosive worker is still exiting.");
            else
                cancel.Close();
            settings.AttackElite = elite;
            settings.CanAttackUnitsAlreadyInFight = assist;
            wManager.Wow.Helpers.MovementManager.StopMove();
        }
        bool complete = wManager.Wow.Helpers.Quest.IsObjectiveComplete(1, 12049);
        robotManager.Helpful.Logging.WriteDebug("[Swallow] Finished; complete=" + complete);
        if (robotManager.Products.Products.IsStarted && !complete)
            robotManager.Products.Products.ProductStop();
    }
}
public class MyCustomScript
{
    static MyCustomScript()
    {
        // You can put here code to run when bot start, you can also add methods and classes.
    }
}



public sealed class ApplyThisTwiceADay : QuestClass
{
    public ApplyThisTwiceADay()
    {
        Name = "Apply This Twice A Day";

        QuestId.AddRange(new[] { 12077 });

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


public sealed class Coldwing : QuestGrinderClass
{
    public Coldwing()
    {
        Name = "Coldwing";

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

        EntryTarget.Add(26578);
HotSpots.Add(new Vector3(5099.621 , 1045.433 , 223.9082 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return Quest.IsObjectiveComplete(1, 12052);
}



public override bool HasQuest() { return true; }


}


public sealed class HardtoSwallow : QuestUseItemOnClass
{
    public HardtoSwallow()
    {
        Name = "Hard to Swallow";

        QuestId.AddRange(new[] { 12049 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26293);
HotSpots.Add(new Vector3(4655.861 , 364.1464 , 108.3749 , "None"));
HotSpots.Add(new Vector3(4686.585 , 337.9527 , 117.1035 , "None"));
HotSpots.Add(new Vector3(4781.179 , 296.599 , 137.815 , "None"));
HotSpots.Add(new Vector3(4745.618 , 228.0944 , 123.6437 , "None"));
HotSpots.Add(new Vector3(4832.627 , 263.703 , 156.3384 , "None"));
ItemId = 36732;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class HarponThis : QuestGrinderClass
{
    public HarponThis()
    {
        Name = "Harp on This!";

        QuestId.AddRange(new[] { 12052 });

        Step = new List<int> { 1, 15, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26577);
EntryTarget.Add(26575);
EntryTarget.Add(26578);
HotSpots.Add(new Vector3(4842.601 , 659.4176 , 168.101 , "None"));
HotSpots.Add(new Vector3(4852.129 , 668.3644 , 169.214 , "None"));
HotSpots.Add(new Vector3(4870.325 , 727.6409 , 166.788 , "None"));
HotSpots.Add(new Vector3(4876.302 , 798.9584 , 167.632 , "None"));
HotSpots.Add(new Vector3(4836.318 , 807.3979 , 165.046 , "None"));
HotSpots.Add(new Vector3(4935.641 , 833.0884 , 183.855 , "None"));
HotSpots.Add(new Vector3(4944.007 , 828.9244 , 205.73 , "None"));
HotSpots.Add(new Vector3(5123.431 , 1067.462 , 237.181 , "None"));
HotSpots.Add(new Vector3(5084.053 , 1077.622 , 226.113 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LumberHack : QuestClass
{
    public LumberHack()
    {
        Name = "Lumber Hack";

        QuestId.AddRange(new[] { 12050 });

        Step = new List<int> { 50, 0, 0, 0, 0 };

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


public sealed class MessyBusiness : QuestUseItemOnClass
{
    public MessyBusiness()
    {
        Name = "Messy Business";

        QuestId.AddRange(new[] { 12076 });

        Step = new List<int> { 2, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26359);
EntryIdTarget.Add(26358);
HotSpots.Add(new Vector3(4919.186 , 665.1209 , 134.2445 , "None"));
HotSpots.Add(new Vector3(4937.583 , 630.6489 , 140.0977 , "None"));
HotSpots.Add(new Vector3(4946.549 , 690.292 , 136.0772 , "None"));
HotSpots.Add(new Vector3(4989.915 , 740.2913 , 130.8773 , "None"));
HotSpots.Add(new Vector3(5009.076 , 734.2066 , 134.9959 , "None"));
HotSpots.Add(new Vector3(4949.007 , 767.973 , 126.8496 , "None"));
ItemId = 36775;
Range = 18.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class NozzlerustDefense : QuestGrinderClass
{
    public NozzlerustDefense()
    {
        Name = "Nozzlerust Defense";

        QuestId.AddRange(new[] { 12043 });

        Step = new List<int> { 1, 12, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26493);
EntryTarget.Add(26492);
HotSpots.Add(new Vector3(4428.892 , 679.9654 , 62.74667 , "None"));
HotSpots.Add(new Vector3(4427.81 , 694.4011 , 56.65425 , "None"));
HotSpots.Add(new Vector3(4425.957 , 700.62 , 54.56572 , "None"));
HotSpots.Add(new Vector3(4424.358 , 705.9835 , 53.94568 , "None"));
HotSpots.Add(new Vector3(4423.183 , 709.9281 , 53.89002 , "None"));
HotSpots.Add(new Vector3(4418.653 , 716.4464 , 53.89002 , "None"));
HotSpots.Add(new Vector3(4408.8 , 724.9397 , 53.89002 , "None"));
HotSpots.Add(new Vector3(4405.827 , 728.6116 , 53.89002 , "None"));
HotSpots.Add(new Vector3(4402.714 , 732.4549 , 53.89002 , "None"));
HotSpots.Add(new Vector3(4399.324 , 736.6409 , 53.89002 , "None"));
HotSpots.Add(new Vector3(4395.908 , 740.8596 , 53.90294 , "None"));
HotSpots.Add(new Vector3(4393.046 , 744.3928 , 54.08767 , "None"));
HotSpots.Add(new Vector3(4387.755 , 749.4509 , 54.83338 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReallyBigWorm : QuestGrinderClass
{
    public ReallyBigWorm()
    {
        Name = "Really Big Worm";

        QuestId.AddRange(new[] { 12080 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26360);
HotSpots.Add(new Vector3(4903.3 , 789.584 , 124.6566 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ReturntoSender : QuestClass
{
    public ReturntoSender()
    {
        Name = "Return to Sender";

        QuestId.AddRange(new[] { 12469 });

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


public sealed class ShavedIce : QuestGrinderClass
{
    public ShavedIce()
    {
        Name = "Shaved Ice";

        QuestId.AddRange(new[] { 12045 });

        Step = new List<int> { 4, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26316);
HotSpots.Add(new Vector3(4863.998 , 655.7282 , 160.3022 , "None"));
HotSpots.Add(new Vector3(4876.665 , 617.1315 , 162.4803 , "None"));
HotSpots.Add(new Vector3(4788.002 , 648.7952 , 166.4653 , "None"));
HotSpots.Add(new Vector3(4921.123 , 728.1947 , 170.635 , "None"));
HotSpots.Add(new Vector3(4914.384 , 748.0699 , 165.3853 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SlimPickings : QuestInteractWithClass
{
    public SlimPickings()
    {
        Name = "Slim Pickings";

        QuestId.AddRange(new[] { 12075 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26809);
HotSpots.Add(new Vector3(5128.87 , 477.696 , 190.169 , "None"));
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


public sealed class SoftPackaging : QuestGrinderClass
{
    public SoftPackaging()
    {
        Name = "Soft Packaging";

        QuestId.AddRange(new[] { 12046 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26467);
HotSpots.Add(new Vector3(4650.61 , 608.644 , 109.9202 , "None"));
HotSpots.Add(new Vector3(4708.94 , 605.969 , 119.738 , "None"));
HotSpots.Add(new Vector3(4684.053 , 643.9118 , 114.2367 , "None"));
HotSpots.Add(new Vector3(4681.521 , 727.4243 , 114.6158 , "None"));
HotSpots.Add(new Vector3(4724.539 , 653.2339 , 126.5416 , "None"));
HotSpots.Add(new Vector3(4761.081 , 648.9753 , 122.1821 , "None"));
HotSpots.Add(new Vector3(4736.97 , 727.25 , 132.202 , "None"));
HotSpots.Add(new Vector3(4715.845 , 772.3002 , 122.1147 , "None"));
HotSpots.Add(new Vector3(4716.378 , 871.2312 , 133.4071 , "None"));
HotSpots.Add(new Vector3(4734.26 , 901.5344 , 128.2544 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SomethingThatDoesntMelt : QuestGathererClass
{
    public SomethingThatDoesntMelt()
    {
        Name = "Something That Doesn't Melt";

        QuestId.AddRange(new[] { 12047 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188441);
HotSpots.Add(new Vector3(4617.016 , 646.8599 , 100.1604 , "None"));
HotSpots.Add(new Vector3(4604.559 , 648.1139 , 99.35284 , "None"));
HotSpots.Add(new Vector3(4593.493 , 741.5685 , 95.81713 , "None"));
HotSpots.Add(new Vector3(4598.026 , 757.6239 , 94.22377 , "None"));
HotSpots.Add(new Vector3(4680.983 , 402.0377 , 112.6948 , "None"));
HotSpots.Add(new Vector3(4600.243 , 285.3007 , 95.11115 , "None"));
HotSpots.Add(new Vector3(4579.67 , 273.7923 , 94.75117 , "None"));
HotSpots.Add(new Vector3(4570.929 , 247.2554 , 91.11049 , "None"));
HotSpots.Add(new Vector3(4582.927 , 233.856 , 95.50751 , "None"));
HotSpots.Add(new Vector3(4557.158 , 228.9248 , 96.31884 , "None"));
HotSpots.Add(new Vector3(4533.715 , 219.1487 , 93.26919 , "None"));
HotSpots.Add(new Vector3(4516.78 , 214.7293 , 90.20309 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class StiffNegotiations : QuestClass
{
    public StiffNegotiations()
    {
        Name = "Stiff Negotiations";

        QuestId.AddRange(new[] { 12112 });

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


public sealed class StockingUp : QuestGathererClass
{
    public StockingUp()
    {
        Name = "Stocking Up";

        QuestId.AddRange(new[] { 12044 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188442);
HotSpots.Add(new Vector3(4364.342 , 317.5128 , 46.89969 , "None"));
HotSpots.Add(new Vector3(4377.772 , 298.4379 , 45.64304 , "None"));
HotSpots.Add(new Vector3(4437.581 , 687.4135 , 60.26706 , "None"));
HotSpots.Add(new Vector3(4433.34 , 706.3326 , 54.55682 , "None"));
HotSpots.Add(new Vector3(4412.294 , 702.6486 , 54.21722 , "None"));
HotSpots.Add(new Vector3(4414.487 , 722.8221 , 53.89098 , "None"));
HotSpots.Add(new Vector3(4389.273 , 732.3618 , 54.06955 , "None"));
HotSpots.Add(new Vector3(4393.648 , 752.3038 , 54.01992 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class StompingGrounds : QuestGrinderClass
{
    public StompingGrounds()
    {
        Name = "Stomping Grounds";

        QuestId.AddRange(new[] { 12079 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26358);
HotSpots.Add(new Vector3(4951.21 , 252.56 , 132.9496 , "None"));
HotSpots.Add(new Vector3(4880.058 , 223.4883 , 118.8081 , "None"));
HotSpots.Add(new Vector3(4853.085 , 143.8111 , 92.92053 , "None"));
HotSpots.Add(new Vector3(4813.038 , 127.184 , 80.87508 , "None"));
HotSpots.Add(new Vector3(4951.418 , 700.1558 , 134.8933 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WormWrangler : QuestUseItemOnClass
{
    public WormWrangler()
    {
        Name = "Worm Wrangler";

        QuestId.AddRange(new[] { 12078 });

        Step = new List<int> { 3, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(26359);
HotSpots.Add(new Vector3(4917.539 , 649.2606 , 134.976 , "None"));
HotSpots.Add(new Vector3(4910.929 , 674.93 , 132.5718 , "None"));
HotSpots.Add(new Vector3(5009.717 , 732.6533 , 135.7621 , "None"));
HotSpots.Add(new Vector3(4958.263 , 822.6763 , 131.2567 , "None"));
ItemId = 36771;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}
