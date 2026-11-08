
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



public sealed class FlightoftheWintergardeDefender : QuestGrinderClass
{
    public FlightoftheWintergardeDefender()
    {
        Name = "Flight of the Wintergarde Defender";

        QuestId.AddRange(new[] { 12237 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

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


public sealed class Start : QuestFollowPathClass
{
    public Start()
    {
        Name = "Start";

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

        Path.Add(new Vector3(3687.06 , -722.6155 , 212.5549 , "None"));
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


public sealed class P1 : QuestFollowPathClass
{
    public P1()
    {
        Name = "P1";

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

        Path.Add(new Vector3(3682.29 , -729.6492 , 213.0567 , "None"));
Path.Add(new Vector3(3679.771 , -734.421 , 213.7506 , "None"));
Path.Add(new Vector3(3679.599 , -734.7502 , 218.8469 , "None"));
Path.Add(new Vector3(3677.933 , -738.067 , 222.5592 , "None"));
Path.Add(new Vector3(3675.978 , -742.0407 , 224.5224 , "None"));
Path.Add(new Vector3(3673.653 , -746.7711 , 224.481 , "None"));
Path.Add(new Vector3(3671.347 , -751.4638 , 224.4399 , "None"));
Path.Add(new Vector3(3668.517 , -757.2213 , 224.3895 , "None"));
Path.Add(new Vector3(3657.93 , -778.7625 , 224.201 , "None"));
Path.Add(new Vector3(3647.406 , -800.1765 , 224.0136 , "None"));
Path.Add(new Vector3(3637.068 , -821.2089 , 223.8295 , "None"));
Path.Add(new Vector3(3633.609 , -828.2479 , 223.7679 , "None"));
Path.Add(new Vector3(3634.81 , -832.0275 , 223.7367 , "None"));
Path.Add(new Vector3(3643.4 , -853.9271 , 223.5515 , "None"));
Path.Add(new Vector3(3656.313 , -873.7093 , 223.366 , "None"));
Path.Add(new Vector3(3669.253 , -893.531 , 223.1801 , "None"));
Path.Add(new Vector3(3682.167 , -913.3132 , 222.9945 , "None"));
Path.Add(new Vector3(3695.081 , -933.0954 , 222.809 , "None"));
Path.Add(new Vector3(3707.995 , -952.8776 , 222.6234 , "None"));
Path.Add(new Vector3(3717.448 , -967.3582 , 222.4876 , "None"));
Path.Add(new Vector3(3718.507 , -969.5783 , 219.7572 , "None"));
Path.Add(new Vector3(3719.942 , -972.6495 , 215.7575 , "None"));
Path.Add(new Vector3(3721.236 , -975.4207 , 211.4775 , "None"));
Path.Add(new Vector3(3722.528 , -978.1863 , 207.2061 , "None"));
Path.Add(new Vector3(3723.82 , -980.9519 , 202.9346 , "None"));
Path.Add(new Vector3(3725.112 , -983.7175 , 198.6632 , "None"));
Path.Add(new Vector3(3726.403 , -986.4831 , 194.3917 , "None"));
Path.Add(new Vector3(3727.39 , -988.596 , 191.1284 , "None"));
Path.Add(new Vector3(3727.869 , -988.541 , 184.6737 , "None"));
Path.Add(new Vector3(3728.682 , -987.8538 , 179.5338 , "None"));
Path.Add(new Vector3(3728.211 , -986.2178 , 175.0051 , "None"));
Path.Add(new Vector3(3728.33 , -986.1978 , 169.7571 , "None"));
Path.Add(new Vector3(3728.42 , -986.2145 , 164.4975 , "None"));
Path.Add(new Vector3(3728.504 , -986.2521 , 159.2589 , "None"));
Path.Add(new Vector3(3728.586 , -986.2926 , 154.0097 , "None"));
Path.Add(new Vector3(3728.748 , -986.376 , 148.7527 , "None"));
Path.Add(new Vector3(3728.963 , -986.4876 , 143.5083 , "None"));
Path.Add(new Vector3(3729.179 , -986.5992 , 138.2639 , "None"));
Path.Add(new Vector3(3729.394 , -986.7109 , 133.0196 , "None"));
Path.Add(new Vector3(3729.61 , -986.8226 , 127.7752 , "None"));
Path.Add(new Vector3(3732.211 , -988.3418 , 130.2721 , "None"));
Path.Add(new Vector3(3732.211 , -988.3418 , 135.5221 , "None"));
Path.Add(new Vector3(3730.961 , -989.3589 , 140.1048 , "None"));
Path.Add(new Vector3(3727.467 , -992.1182 , 141.5747 , "None"));
Path.Add(new Vector3(3723.407 , -995.4017 , 141.0286 , "None"));
Path.Add(new Vector3(3719.486 , -998.5755 , 140.5073 , "None"));
Path.Add(new Vector3(3715.281 , -1001.979 , 139.9482 , "None"));
Path.Add(new Vector3(3711.351 , -1005.16 , 139.4258 , "None"));
Path.Add(new Vector3(3707.801 , -1009.187 , 138.8699 , "None"));
Path.Add(new Vector3(3704.457 , -1013.199 , 138.3303 , "None"));
Path.Add(new Vector3(3701.136 , -1017.166 , 137.6194 , "None"));
Path.Add(new Vector3(3698.121 , -1020.577 , 135.3618 , "None"));
Path.Add(new Vector3(3695.227 , -1023.88 , 132.1276 , "None"));
Path.Add(new Vector3(3694.042 , -1027.217 , 130.2814 , "None"));
Path.Add(new Vector3(3699.208 , -1026.184 , 129.4326 , "None"));
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


public sealed class P1Back : QuestFollowPathClass
{
    public P1Back()
    {
        Name = "P1 Back";

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

        Path.Add(new Vector3(3695.169 , -1023.951 , 130.6048 , "None"));
Path.Add(new Vector3(3695.169 , -1023.951 , 134.4688 , "None"));
Path.Add(new Vector3(3695.169 , -1023.951 , 139.8868 , "None"));
Path.Add(new Vector3(3695.169 , -1023.951 , 145.1368 , "None"));
Path.Add(new Vector3(3695.169 , -1023.951 , 150.2083 , "None"));
Path.Add(new Vector3(3695.076 , -1023.584 , 155.4799 , "None"));
Path.Add(new Vector3(3694.278 , -1019.96 , 159.1922 , "None"));
Path.Add(new Vector3(3693.872 , -1016.4 , 162.7783 , "None"));
Path.Add(new Vector3(3692.84 , -1012.298 , 165.8627 , "None"));
Path.Add(new Vector3(3691.571 , -1007.283 , 166.7608 , "None"));
Path.Add(new Vector3(3690.303 , -1002.269 , 167.6589 , "None"));
Path.Add(new Vector3(3689.035 , -997.254 , 168.557 , "None"));
Path.Add(new Vector3(3687.767 , -992.2393 , 169.4551 , "None"));
Path.Add(new Vector3(3686.499 , -987.2245 , 170.3532 , "None"));
Path.Add(new Vector3(3685.223 , -982.1797 , 171.2567 , "None"));
Path.Add(new Vector3(3683.962 , -977.1951 , 172.1494 , "None"));
Path.Add(new Vector3(3682.694 , -972.1804 , 173.0476 , "None"));
Path.Add(new Vector3(3681.426 , -967.1656 , 173.9457 , "None"));
Path.Add(new Vector3(3680.157 , -962.1509 , 174.8438 , "None"));
Path.Add(new Vector3(3678.889 , -957.1362 , 175.7419 , "None"));
Path.Add(new Vector3(3677.621 , -952.1214 , 176.64 , "None"));
Path.Add(new Vector3(3676.534 , -947.0557 , 177.5417 , "None"));
Path.Add(new Vector3(3676.266 , -941.9108 , 178.4362 , "None"));
Path.Add(new Vector3(3675.996 , -936.7452 , 179.3344 , "None"));
Path.Add(new Vector3(3675.348 , -931.6047 , 180.2343 , "None"));
Path.Add(new Vector3(3674.475 , -926.5168 , 181.1306 , "None"));
Path.Add(new Vector3(3673.628 , -921.5818 , 182 , "None"));
Path.Add(new Vector3(3672.725 , -916.3206 , 182.9268 , "None"));
Path.Add(new Vector3(3671.602 , -911.4317 , 182.6158 , "None"));
Path.Add(new Vector3(3669.896 , -906.4544 , 183.9241 , "None"));
Path.Add(new Vector3(3668.646 , -901.7783 , 185.8974 , "None"));
Path.Add(new Vector3(3667.96 , -897.2505 , 188.0767 , "None"));
Path.Add(new Vector3(3667.224 , -892.3947 , 190.414 , "None"));
Path.Add(new Vector3(3666.539 , -887.867 , 192.5933 , "None"));
Path.Add(new Vector3(3665.804 , -883.0206 , 194.9261 , "None"));
Path.Add(new Vector3(3665.095 , -878.3335 , 197.1821 , "None"));
Path.Add(new Vector3(3664.398 , -873.6448 , 199.4382 , "None"));
Path.Add(new Vector3(3664.585 , -868.9089 , 201.6942 , "None"));
Path.Add(new Vector3(3664.792 , -864.3342 , 203.8736 , "None"));
Path.Add(new Vector3(3665.014 , -859.4375 , 206.2063 , "None"));
Path.Add(new Vector3(3665.563 , -847.3094 , 211.984 , "None"));
Path.Add(new Vector3(3666.683 , -826.0784 , 219.8972 , "None"));
Path.Add(new Vector3(3670.082 , -802.1935 , 223.0444 , "None"));
Path.Add(new Vector3(3673.594 , -779.7439 , 226.0157 , "None"));
Path.Add(new Vector3(3677.201 , -756.6924 , 229.0667 , "None"));
Path.Add(new Vector3(3683.584 , -734.8471 , 223.9583 , "None"));
Path.Add(new Vector3(3685.769 , -729.5458 , 221.2725 , "None"));
Path.Add(new Vector3(3689.626 , -721.1378 , 216.8503 , "None"));
Path.Add(new Vector3(3689.626 , -721.1378 , 212.8148 , "None"));
Path.Add(new Vector3(3692.034 , -715.8887 , 212.5472 , "None"));
Path.Add(new Vector3(3694.641 , -711.5759 , 213.1966 , "None"));
Path.Add(new Vector3(3697.888 , -707.4413 , 214.4621 , "None"));
Path.Add(new Vector3(3702.256 , -705.2934 , 215.5493 , "None"));
Path.Add(new Vector3(3705.492 , -701.1727 , 215.5006 , "None"));
Path.Add(new Vector3(3706.782 , -699.5293 , 215.3255 , "None"));
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


public sealed class P2 : QuestFollowPathClass
{
    public P2()
    {
        Name = "P2";

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

        Path.Add(new Vector3(3706.383 , -700.5001 , 215.3927 , "None"));
Path.Add(new Vector3(3705.785 , -704.5605 , 215.5629 , "None"));
Path.Add(new Vector3(3703.627 , -707.5836 , 219.2827 , "None"));
Path.Add(new Vector3(3701.834 , -710.8342 , 222.995 , "None"));
Path.Add(new Vector3(3698.009 , -717.7715 , 230.9171 , "None"));
Path.Add(new Vector3(3689.278 , -735.6594 , 239.4068 , "None"));
Path.Add(new Vector3(3682.064 , -758.121 , 239.965 , "None"));
Path.Add(new Vector3(3675.628 , -780.8309 , 240.9543 , "None"));
Path.Add(new Vector3(3669.193 , -803.5408 , 241.9436 , "None"));
Path.Add(new Vector3(3663.4 , -823.9797 , 242.834 , "None"));
Path.Add(new Vector3(3657.376 , -845.2361 , 243.76 , "None"));
Path.Add(new Vector3(3650.734 , -868.6728 , 244.781 , "None"));
Path.Add(new Vector3(3649.228 , -873.9869 , 245.0125 , "None"));
Path.Add(new Vector3(3646.278 , -879.5916 , 241.8638 , "None"));
Path.Add(new Vector3(3644.195 , -883.1542 , 238.6182 , "None"));
Path.Add(new Vector3(3642.196 , -886.6177 , 235.4825 , "None"));
Path.Add(new Vector3(3640.068 , -890.303 , 232.1458 , "None"));
Path.Add(new Vector3(3637.999 , -893.8881 , 228.8999 , "None"));
Path.Add(new Vector3(3636.543 , -897.7354 , 225.667 , "None"));
Path.Add(new Vector3(3635.219 , -901.6575 , 222.4211 , "None"));
Path.Add(new Vector3(3633.897 , -905.5718 , 219.1816 , "None"));
Path.Add(new Vector3(3634.336 , -909.9603 , 217.1006 , "None"));
Path.Add(new Vector3(3633.286 , -914.929 , 217.1006 , "None"));
Path.Add(new Vector3(3632.73 , -920.2214 , 216.8503 , "None"));
Path.Add(new Vector3(3634.907 , -924.1755 , 214.6797 , "None"));
Path.Add(new Vector3(3637.266 , -928.4611 , 212.327 , "None"));
Path.Add(new Vector3(3638.689 , -932.5869 , 210.1839 , "None"));
Path.Add(new Vector3(3642.052 , -935.9811 , 207.6199 , "None"));
Path.Add(new Vector3(3645.024 , -939.3634 , 205.2772 , "None"));
Path.Add(new Vector3(3647.048 , -943.7242 , 202.7797 , "None"));
Path.Add(new Vector3(3649 , -947.9547 , 200.3595 , "None"));
Path.Add(new Vector3(3650.951 , -952.1851 , 197.9394 , "None"));
Path.Add(new Vector3(3652.768 , -956.3078 , 195.5968 , "None"));
Path.Add(new Vector3(3653.505 , -960.8984 , 193.1815 , "None"));
Path.Add(new Vector3(3654.233 , -965.5095 , 190.7565 , "None"));
Path.Add(new Vector3(3654.983 , -970.2587 , 188.259 , "None"));
Path.Add(new Vector3(3655.709 , -974.8606 , 185.8389 , "None"));
Path.Add(new Vector3(3656.436 , -979.4625 , 183.4188 , "None"));
Path.Add(new Vector3(3657.72 , -983.5935 , 181.1952 , "None"));
Path.Add(new Vector3(3662.034 , -986.3543 , 179.4292 , "None"));
Path.Add(new Vector3(3665.712 , -989.2222 , 177.6087 , "None"));
Path.Add(new Vector3(3670.174 , -991.5652 , 177.6087 , "None"));
Path.Add(new Vector3(3674.813 , -994.0011 , 177.6087 , "None"));
Path.Add(new Vector3(3678.467 , -997.1001 , 176.0749 , "None"));
Path.Add(new Vector3(3679.205 , -1001.328 , 173.0528 , "None"));
Path.Add(new Vector3(3679.76 , -1005.473 , 170.1464 , "None"));
Path.Add(new Vector3(3680.277 , -1009.701 , 167.1039 , "None"));
Path.Add(new Vector3(3680.186 , -1013.525 , 163.5256 , "None"));
Path.Add(new Vector3(3679.997 , -1017.18 , 159.7324 , "None"));
Path.Add(new Vector3(3679.804 , -1020.928 , 155.8393 , "None"));
Path.Add(new Vector3(3679.616 , -1024.567 , 152.0596 , "None"));
Path.Add(new Vector3(3679.428 , -1028.205 , 148.2799 , "None"));
Path.Add(new Vector3(3679.074 , -1031.644 , 144.569 , "None"));
Path.Add(new Vector3(3678.082 , -1035.031 , 140.4583 , "None"));
Path.Add(new Vector3(3677.113 , -1038.312 , 136.4752 , "None"));
Path.Add(new Vector3(3676.176 , -1041.487 , 132.6194 , "None"));
Path.Add(new Vector3(3675.142 , -1044.988 , 131.285 , "None"));
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


public sealed class P2Back : QuestFollowPathClass
{
    public P2Back()
    {
        Name = "P2 Back";

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

        Path.Add(new Vector3(3674.895 , -1045.824 , 131.2547 , "None"));
Path.Add(new Vector3(3674.895 , -1045.824 , 139.3082 , "None"));
Path.Add(new Vector3(3674.895 , -1045.824 , 144.5582 , "None"));
Path.Add(new Vector3(3674.679 , -1043.853 , 148.987 , "None"));
Path.Add(new Vector3(3674.174 , -1040.048 , 152.8256 , "None"));
Path.Add(new Vector3(3673.629 , -1036.504 , 156.4117 , "None"));
Path.Add(new Vector3(3673.075 , -1031.882 , 158.666 , "None"));
Path.Add(new Vector3(3672.498 , -1026.985 , 160.4702 , "None"));
Path.Add(new Vector3(3670.729 , -1011.978 , 166.0001 , "None"));
Path.Add(new Vector3(3668.133 , -989.9445 , 174.1191 , "None"));
Path.Add(new Vector3(3665.536 , -967.9109 , 182.2381 , "None"));
Path.Add(new Vector3(3662.939 , -945.8773 , 190.357 , "None"));
Path.Add(new Vector3(3660.259 , -923.1387 , 198.7358 , "None"));
Path.Add(new Vector3(3658.816 , -901.0586 , 203.5874 , "None"));
Path.Add(new Vector3(3659.994 , -878.4467 , 210.2984 , "None"));
Path.Add(new Vector3(3662.563 , -855.9995 , 217.1998 , "None"));
Path.Add(new Vector3(3665.235 , -833.5139 , 224.1011 , "None"));
Path.Add(new Vector3(3667.988 , -810.355 , 231.2091 , "None"));
Path.Add(new Vector3(3671.225 , -787.8596 , 230.6893 , "None"));
Path.Add(new Vector3(3675.175 , -764.5772 , 230.0197 , "None"));
Path.Add(new Vector3(3680.218 , -741.5193 , 229.0605 , "None"));
Path.Add(new Vector3(3690.311 , -720.2471 , 224.3641 , "None"));
Path.Add(new Vector3(3702.933 , -703.7928 , 215.6105 , "None"));
Path.Add(new Vector3(3705.513 , -700.6349 , 215.4663 , "None"));
Path.Add(new Vector3(3711.69 , -697.7836 , 215.1741 , "None"));
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


public sealed class P3 : QuestFollowPathClass
{
    public P3()
    {
        Name = "P3";

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

        Path.Add(new Vector3(3713.371 , -696.3419 , 215.3567 , "None"));
Path.Add(new Vector3(3708.885 , -700.2536 , 220.6256 , "None"));
Path.Add(new Vector3(3706.917 , -703.4011 , 224.3379 , "None"));
Path.Add(new Vector3(3704.575 , -707.219 , 226.2981 , "None"));
Path.Add(new Vector3(3702.013 , -711.3953 , 226.4926 , "None"));
Path.Add(new Vector3(3690.047 , -731.8804 , 227.9943 , "None"));
Path.Add(new Vector3(3679.277 , -752.7889 , 230.2269 , "None"));
Path.Add(new Vector3(3668.507 , -773.6973 , 232.4594 , "None"));
Path.Add(new Vector3(3657.737 , -794.6058 , 234.692 , "None"));
Path.Add(new Vector3(3646.967 , -815.5142 , 236.9245 , "None"));
Path.Add(new Vector3(3636.197 , -836.4227 , 239.157 , "None"));
Path.Add(new Vector3(3631.889 , -844.7861 , 240.05 , "None"));
Path.Add(new Vector3(3628.658 , -851.0586 , 240.7198 , "None"));
Path.Add(new Vector3(3617.888 , -871.967 , 242.9523 , "None"));
Path.Add(new Vector3(3611.647 , -894.492 , 245.1938 , "None"));
Path.Add(new Vector3(3616.291 , -917.3966 , 247.4174 , "None"));
Path.Add(new Vector3(3621.68 , -940.2901 , 249.6499 , "None"));
Path.Add(new Vector3(3626.243 , -958.1102 , 240.5406 , "None"));
Path.Add(new Vector3(3630.154 , -969.7025 , 220.277 , "None"));
Path.Add(new Vector3(3633.994 , -981.082 , 199.9873 , "None"));
Path.Add(new Vector3(3635.918 , -986.7832 , 189.8222 , "None"));
Path.Add(new Vector3(3642.335 , -990.2354 , 186.4205 , "None"));
Path.Add(new Vector3(3646.516 , -992.5366 , 184.2075 , "None"));
Path.Add(new Vector3(3650.901 , -994.5123 , 182.1281 , "None"));
Path.Add(new Vector3(3655.455 , -996.2151 , 180.1464 , "None"));
Path.Add(new Vector3(3659.999 , -997.9146 , 178.1686 , "None"));
Path.Add(new Vector3(3664.553 , -999.6174 , 176.1868 , "None"));
Path.Add(new Vector3(3668.961 , -1001.266 , 174.2685 , "None"));
Path.Add(new Vector3(3673.514 , -1002.969 , 172.2867 , "None"));
Path.Add(new Vector3(3678.104 , -1004.685 , 170.2891 , "None"));
Path.Add(new Vector3(3682.767 , -1006.429 , 168.2598 , "None"));
Path.Add(new Vector3(3686.197 , -1008.134 , 166.1912 , "None"));
Path.Add(new Vector3(3690.169 , -1009.738 , 163.4642 , "None"));
Path.Add(new Vector3(3694.36 , -1011.214 , 160.3449 , "None"));
Path.Add(new Vector3(3698.405 , -1012.638 , 157.3165 , "None"));
Path.Add(new Vector3(3702.313 , -1014.014 , 154.3912 , "None"));
Path.Add(new Vector3(3706.484 , -1015.45 , 151.2298 , "None"));
Path.Add(new Vector3(3710.274 , -1016.476 , 147.7476 , "None"));
Path.Add(new Vector3(3713.657 , -1017.582 , 143.9036 , "None"));
Path.Add(new Vector3(3717.007 , -1018.702 , 140.0049 , "None"));
Path.Add(new Vector3(3720.349 , -1019.82 , 136.114 , "None"));
Path.Add(new Vector3(3723.692 , -1020.939 , 132.2231 , "None"));
Path.Add(new Vector3(3727.024 , -1021.906 , 128.2867 , "None"));
Path.Add(new Vector3(3730.404 , -1022.839 , 124.629 , "None"));
Path.Add(new Vector3(3734.457 , -1024.376 , 121.4723 , "None"));
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


public sealed class P3Back : QuestFollowPathClass
{
    public P3Back()
    {
        Name = "P3 Back";

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

        Path.Add(new Vector3(3737.392 , -1025.514 , 121.0281 , "None"));
Path.Add(new Vector3(3737.392 , -1025.514 , 128.2101 , "None"));
Path.Add(new Vector3(3737.392 , -1025.514 , 133.4601 , "None"));
Path.Add(new Vector3(3736.18 , -1023.955 , 137.8921 , "None"));
Path.Add(new Vector3(3732.967 , -1020.136 , 139.36 , "None"));
Path.Add(new Vector3(3729.714 , -1016.461 , 141.2189 , "None"));
Path.Add(new Vector3(3726.502 , -1012.82 , 143.2159 , "None"));
Path.Add(new Vector3(3723.33 , -1009.158 , 145.2396 , "None"));
Path.Add(new Vector3(3711.043 , -994.5867 , 153.8946 , "None"));
Path.Add(new Vector3(3698.279 , -977.9368 , 164.7429 , "None"));
Path.Add(new Vector3(3686.007 , -961.1581 , 175.9695 , "None"));
Path.Add(new Vector3(3674.388 , -943.6827 , 186.2943 , "None"));
Path.Add(new Vector3(3666.979 , -921.7048 , 190.791 , "None"));
Path.Add(new Vector3(3662.202 , -899.4 , 195.332 , "None"));
Path.Add(new Vector3(3663.817 , -876.5948 , 201.0889 , "None"));
Path.Add(new Vector3(3665.364 , -853.7209 , 206.9849 , "None"));
Path.Add(new Vector3(3666.905 , -830.9382 , 212.8575 , "None"));
Path.Add(new Vector3(3668.45 , -808.11 , 218.7417 , "None"));
Path.Add(new Vector3(3669.994 , -785.2817 , 224.626 , "None"));
Path.Add(new Vector3(3671.539 , -762.4534 , 230.5103 , "None"));
Path.Add(new Vector3(3681.678 , -741.4148 , 227.8957 , "None"));
Path.Add(new Vector3(3693.53 , -721.6552 , 222.9476 , "None"));
Path.Add(new Vector3(3702.867 , -706.2676 , 215.5632 , "None"));
Path.Add(new Vector3(3705.721 , -701.8492 , 215.5096 , "None"));
Path.Add(new Vector3(3709.109 , -698.0816 , 215.1259 , "None"));
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


public sealed class P4 : QuestFollowPathClass
{
    public P4()
    {
        Name = "P4";

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

        Path.Add(new Vector3(3709.85 , -698.4535 , 215.045 , "None"));
Path.Add(new Vector3(3703.451 , -702.3752 , 215.5609 , "None"));
Path.Add(new Vector3(3699.6 , -705.9424 , 215.1725 , "None"));
Path.Add(new Vector3(3697.067 , -709.5278 , 217.094 , "None"));
Path.Add(new Vector3(3695.615 , -712.8042 , 220.6801 , "None"));
Path.Add(new Vector3(3693.8 , -717.1597 , 223.0838 , "None"));
Path.Add(new Vector3(3685.686 , -735.7661 , 226.0313 , "None"));
Path.Add(new Vector3(3675.958 , -757.8895 , 229.5903 , "None"));
Path.Add(new Vector3(3668.453 , -779.5262 , 229.5289 , "None"));
Path.Add(new Vector3(3662.508 , -801.7762 , 226.3648 , "None"));
Path.Add(new Vector3(3656.454 , -824.4333 , 223.1429 , "None"));
Path.Add(new Vector3(3650.388 , -847.1356 , 219.9145 , "None"));
Path.Add(new Vector3(3644.177 , -870.3806 , 216.6089 , "None"));
Path.Add(new Vector3(3638.328 , -892.2689 , 213.4962 , "None"));
Path.Add(new Vector3(3632.299 , -914.8355 , 210.2871 , "None"));
Path.Add(new Vector3(3626.244 , -937.4926 , 207.0652 , "None"));
Path.Add(new Vector3(3620.203 , -960.1044 , 203.8497 , "None"));
Path.Add(new Vector3(3619.816 , -984.1993 , 200.5312 , "None"));
Path.Add(new Vector3(3620.146 , -1006.806 , 197.425 , "None"));
Path.Add(new Vector3(3620.374 , -1022.439 , 195.277 , "None"));
Path.Add(new Vector3(3627.034 , -1024.075 , 193.7472 , "None"));
Path.Add(new Vector3(3628.624 , -1028.825 , 192.1753 , "None"));
Path.Add(new Vector3(3630.218 , -1033.585 , 190.6002 , "None"));
Path.Add(new Vector3(3631.804 , -1038.326 , 189.0314 , "None"));
Path.Add(new Vector3(3633.401 , -1043.095 , 187.4532 , "None"));
Path.Add(new Vector3(3634.988 , -1047.835 , 185.8844 , "None"));
Path.Add(new Vector3(3636.575 , -1052.576 , 184.3156 , "None"));
Path.Add(new Vector3(3638.165 , -1057.326 , 182.7436 , "None"));
Path.Add(new Vector3(3640.374 , -1061.801 , 181.1717 , "None"));
Path.Add(new Vector3(3642.369 , -1065.277 , 179.9141 , "None"));
Path.Add(new Vector3(3644.865 , -1069.62 , 178.3422 , "None"));
Path.Add(new Vector3(3648.895 , -1072.576 , 176.7576 , "None"));
Path.Add(new Vector3(3653.146 , -1075.129 , 175.2014 , "None"));
Path.Add(new Vector3(3657.448 , -1077.714 , 173.6263 , "None"));
Path.Add(new Vector3(3661.734 , -1080.288 , 172.0575 , "None"));
Path.Add(new Vector3(3666.028 , -1082.867 , 170.4856 , "None"));
Path.Add(new Vector3(3669.816 , -1088.783 , 166.5874 , "None"));
Path.Add(new Vector3(3671.4 , -1092.963 , 163.8136 , "None"));
Path.Add(new Vector3(3672.984 , -1097.141 , 161.057 , "None"));
Path.Add(new Vector3(3674.568 , -1101.319 , 158.3004 , "None"));
Path.Add(new Vector3(3676.148 , -1105.489 , 155.5493 , "None"));
Path.Add(new Vector3(3677.713 , -1109.651 , 152.7403 , "None"));
Path.Add(new Vector3(3679.136 , -1113.68 , 149.6187 , "None"));
Path.Add(new Vector3(3680.506 , -1117.547 , 146.3439 , "None"));
Path.Add(new Vector3(3681.845 , -1121.3 , 142.9912 , "None"));
Path.Add(new Vector3(3683.195 , -1125.084 , 139.6115 , "None"));
Path.Add(new Vector3(3684.594 , -1128.545 , 135.9337 , "None"));
Path.Add(new Vector3(3686.14 , -1131.274 , 131.7254 , "None"));
Path.Add(new Vector3(3687.765 , -1133.699 , 127.3641 , "None"));
Path.Add(new Vector3(3689.061 , -1135.748 , 122.7085 , "None"));
Path.Add(new Vector3(3690.864 , -1138.488 , 121.1282 , "None"));
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


public sealed class P4Back : QuestFollowPathClass
{
    public P4Back()
    {
        Name = "P4 Back";

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

        Path.Add(new Vector3(3690.864 , -1138.488 , 121.1282 , "None"));
Path.Add(new Vector3(3690.864 , -1138.488 , 126.3887 , "None"));
Path.Add(new Vector3(3691.017 , -1135.641 , 130.4578 , "None"));
Path.Add(new Vector3(3690.896 , -1131.936 , 134.1701 , "None"));
Path.Add(new Vector3(3690.244 , -1128.281 , 137.8824 , "None"));
Path.Add(new Vector3(3689.566 , -1124.511 , 141.7135 , "None"));
Path.Add(new Vector3(3687.202 , -1111.35 , 155.0852 , "None"));
Path.Add(new Vector3(3684.238 , -1094.943 , 171.7572 , "None"));
Path.Add(new Vector3(3681.382 , -1074.184 , 180.6274 , "None"));
Path.Add(new Vector3(3679.552 , -1051.34 , 186.5575 , "None"));
Path.Add(new Vector3(3677.738 , -1028.588 , 192.4718 , "None"));
Path.Add(new Vector3(3675.862 , -1005.061 , 198.5876 , "None"));
Path.Add(new Vector3(3674.103 , -982.9932 , 204.324 , "None"));
Path.Add(new Vector3(3672.285 , -960.1959 , 210.2502 , "None"));
Path.Add(new Vector3(3670.468 , -937.3985 , 216.1763 , "None"));
Path.Add(new Vector3(3668.592 , -913.8716 , 222.292 , "None"));
Path.Add(new Vector3(3666.774 , -891.0743 , 228.2181 , "None"));
Path.Add(new Vector3(3666.035 , -868.27 , 234.1443 , "None"));
Path.Add(new Vector3(3667.767 , -846.2 , 239.8807 , "None"));
Path.Add(new Vector3(3669.556 , -823.4004 , 245.8069 , "None"));
Path.Add(new Vector3(3671.344 , -800.6008 , 251.733 , "None"));
Path.Add(new Vector3(3674.65 , -778.7371 , 247.4755 , "None"));
Path.Add(new Vector3(3679.145 , -758.1835 , 236.7598 , "None"));
Path.Add(new Vector3(3685.246 , -739.0076 , 224.4893 , "None"));
Path.Add(new Vector3(3692.682 , -720.2558 , 213.0745 , "None"));
Path.Add(new Vector3(3696.645 , -712.423 , 213.6176 , "None"));
Path.Add(new Vector3(3700.327 , -708.6826 , 215.0032 , "None"));
Path.Add(new Vector3(3704.176 , -705.113 , 215.5702 , "None"));
Path.Add(new Vector3(3707.713 , -701.2371 , 215.3486 , "None"));
Path.Add(new Vector3(3709.967 , -698.5502 , 215.0559 , "None"));
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


public sealed class P5 : QuestFollowPathClass
{
    public P5()
    {
        Name = "P5";

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

        Path.Add(new Vector3(3709.967 , -698.5502 , 215.0559 , "None"));
Path.Add(new Vector3(3705.851 , -700.1304 , 215.4099 , "None"));
Path.Add(new Vector3(3702.292 , -704.1227 , 215.5369 , "None"));
Path.Add(new Vector3(3700.17 , -707.147 , 218.8834 , "None"));
Path.Add(new Vector3(3698.38 , -710.4031 , 222.6031 , "None"));
Path.Add(new Vector3(3696.77 , -713.8709 , 226.4268 , "None"));
Path.Add(new Vector3(3695.259 , -717.1232 , 230.0129 , "None"));
Path.Add(new Vector3(3693.287 , -721.7559 , 230.781 , "None"));
Path.Add(new Vector3(3690.959 , -727.3912 , 231.1942 , "None"));
Path.Add(new Vector3(3682.159 , -748.6977 , 232.7566 , "None"));
Path.Add(new Vector3(3673.161 , -770.4835 , 234.3541 , "None"));
Path.Add(new Vector3(3664.163 , -792.2693 , 235.9516 , "None"));
Path.Add(new Vector3(3655.165 , -814.0551 , 237.5491 , "None"));
Path.Add(new Vector3(3647.104 , -836.1204 , 239.1466 , "None"));
Path.Add(new Vector3(3644.382 , -859.486 , 240.741 , "None"));
Path.Add(new Vector3(3642.186 , -882.9676 , 242.3416 , "None"));
Path.Add(new Vector3(3644.059 , -906.4639 , 243.9391 , "None"));
Path.Add(new Vector3(3646.664 , -923.2078 , 229.8841 , "None"));
Path.Add(new Vector3(3652.045 , -942.2471 , 217.2525 , "None"));
Path.Add(new Vector3(3659.006 , -962.9505 , 208.2664 , "None"));
Path.Add(new Vector3(3666.213 , -983.7206 , 199.6183 , "None"));
Path.Add(new Vector3(3673.421 , -1004.491 , 190.9701 , "None"));
Path.Add(new Vector3(3678.787 , -1026.791 , 185.7147 , "None"));
Path.Add(new Vector3(3683.703 , -1049.6 , 182.0096 , "None"));
Path.Add(new Vector3(3688.619 , -1072.409 , 178.3046 , "None"));
Path.Add(new Vector3(3693.584 , -1095.446 , 174.5625 , "None"));
Path.Add(new Vector3(3690.996 , -1096.448 , 172.1777 , "None"));
Path.Add(new Vector3(3687.387 , -1097.81 , 168.6217 , "None"));
Path.Add(new Vector3(3683.98 , -1099.223 , 164.8714 , "None"));
Path.Add(new Vector3(3680.585 , -1100.629 , 161.1361 , "None"));
Path.Add(new Vector3(3677.323 , -1102.293 , 157.3933 , "None"));
Path.Add(new Vector3(3674.435 , -1104.405 , 153.5541 , "None"));
Path.Add(new Vector3(3671.624 , -1106.311 , 149.5542 , "None"));
Path.Add(new Vector3(3668.802 , -1108.136 , 145.5268 , "None"));
Path.Add(new Vector3(3666.458 , -1109.724 , 141.1056 , "None"));
Path.Add(new Vector3(3664.122 , -1111.308 , 136.6792 , "None"));
Path.Add(new Vector3(3661.785 , -1112.891 , 132.2527 , "None"));
Path.Add(new Vector3(3659.434 , -1114.484 , 127.7997 , "None"));
Path.Add(new Vector3(3657.111 , -1116.058 , 123.3998 , "None"));
Path.Add(new Vector3(3654.432 , -1117.874 , 119.64 , "None"));
Path.Add(new Vector3(3650.092 , -1120.815 , 119.0968 , "None"));
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


public sealed class P5Back : QuestFollowPathClass
{
    public P5Back()
    {
        Name = "P5 Back";

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

        Path.Add(new Vector3(3649.796 , -1121.015 , 119.0892 , "None"));
Path.Add(new Vector3(3650.405 , -1119.277 , 126.5419 , "None"));
Path.Add(new Vector3(3651.508 , -1115.818 , 130.1725 , "None"));
Path.Add(new Vector3(3652.608 , -1111.91 , 133.2136 , "None"));
Path.Add(new Vector3(3653.611 , -1107.17 , 135.208 , "None"));
Path.Add(new Vector3(3655.491 , -1097.844 , 139.144 , "None"));
Path.Add(new Vector3(3659.135 , -1076.404 , 148.3685 , "None"));
Path.Add(new Vector3(3660.446 , -1054.585 , 157.2779 , "None"));
Path.Add(new Vector3(3659.507 , -1032.558 , 165.7544 , "None"));
Path.Add(new Vector3(3658.06 , -1010.458 , 173.9806 , "None"));
Path.Add(new Vector3(3656.566 , -987.652 , 182.47 , "None"));
Path.Add(new Vector3(3655.613 , -965.3342 , 187.3289 , "None"));
Path.Add(new Vector3(3654.615 , -941.5048 , 192.3885 , "None"));
Path.Add(new Vector3(3653.649 , -918.4144 , 197.2912 , "None"));
Path.Add(new Vector3(3652.68 , -895.2777 , 202.2038 , "None"));
Path.Add(new Vector3(3651.746 , -872.9724 , 206.9398 , "None"));
Path.Add(new Vector3(3655.217 , -850.0832 , 211.5757 , "None"));
Path.Add(new Vector3(3659.617 , -826.5427 , 216.3946 , "None"));
Path.Add(new Vector3(3663.89 , -803.8267 , 221.0457 , "None"));
Path.Add(new Vector3(3668.818 , -781.9188 , 224.8209 , "None"));
Path.Add(new Vector3(3677.056 , -759.7971 , 225.7699 , "None"));
Path.Add(new Vector3(3686.165 , -738.2548 , 223.5453 , "None"));
Path.Add(new Vector3(3697.635 , -718.0814 , 215.9212 , "None"));
Path.Add(new Vector3(3702.667 , -709.3051 , 215.2651 , "None"));
Path.Add(new Vector3(3705.561 , -704.7128 , 215.566 , "None"));
Path.Add(new Vector3(3708.668 , -700.4814 , 215.2553 , "None"));
Path.Add(new Vector3(3711.039 , -697.2332 , 215.085 , "None"));
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


public sealed class P6 : QuestFollowPathClass
{
    public P6()
    {
        Name = "P6";

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

        Path.Add(new Vector3(3711.039 , -697.2332 , 215.085 , "None"));
Path.Add(new Vector3(3705.33 , -702.0522 , 215.5211 , "None"));
Path.Add(new Vector3(3702.837 , -706.6964 , 215.5638 , "None"));
Path.Add(new Vector3(3701.183 , -710.2079 , 218.7091 , "None"));
Path.Add(new Vector3(3699.249 , -713.3765 , 222.4214 , "None"));
Path.Add(new Vector3(3697.112 , -716.9642 , 224.9891 , "None"));
Path.Add(new Vector3(3694.673 , -721.5883 , 225.3201 , "None"));
Path.Add(new Vector3(3691.621 , -728.2841 , 225.9616 , "None"));
Path.Add(new Vector3(3683.848 , -750.4738 , 227.4939 , "None"));
Path.Add(new Vector3(3676.84 , -773.0834 , 227.7324 , "None"));
Path.Add(new Vector3(3669.859 , -795.6028 , 227.9699 , "None"));
Path.Add(new Vector3(3662.85 , -818.2125 , 228.2084 , "None"));
Path.Add(new Vector3(3655.855 , -840.777 , 228.4464 , "None"));
Path.Add(new Vector3(3650.556 , -863.7305 , 228.6844 , "None"));
Path.Add(new Vector3(3647.196 , -887.114 , 228.9224 , "None"));
Path.Add(new Vector3(3643.836 , -910.4976 , 229.1604 , "None"));
Path.Add(new Vector3(3640.368 , -934.6295 , 229.4061 , "None"));
Path.Add(new Vector3(3641.99 , -957.3236 , 229.6365 , "None"));
Path.Add(new Vector3(3642.562 , -977.9573 , 220.0685 , "None"));
Path.Add(new Vector3(3643.63 , -998.5579 , 208.5592 , "None"));
Path.Add(new Vector3(3648.057 , -1017.889 , 197.9323 , "None"));
Path.Add(new Vector3(3665.824 , -1031.774 , 189.8437 , "None"));
Path.Add(new Vector3(3667.328 , -1052.066 , 178.7866 , "None"));
Path.Add(new Vector3(3671.287 , -1072.284 , 171.6225 , "None"));
Path.Add(new Vector3(3670.998 , -1093.814 , 166.0862 , "None"));
Path.Add(new Vector3(3668.364 , -1115.723 , 160.3177 , "None"));
Path.Add(new Vector3(3667.191 , -1120.939 , 158.9128 , "None"));
Path.Add(new Vector3(3668.561 , -1128.722 , 158.2222 , "None"));
Path.Add(new Vector3(3671.494 , -1132.973 , 157.2787 , "None"));
Path.Add(new Vector3(3676.29 , -1134.139 , 155.9855 , "None"));
Path.Add(new Vector3(3680.64 , -1136.086 , 154.7408 , "None"));
Path.Add(new Vector3(3685.01 , -1138.856 , 153.6375 , "None"));
Path.Add(new Vector3(3687.615 , -1143.135 , 153.5032 , "None"));
Path.Add(new Vector3(3690.664 , -1147.403 , 153.5032 , "None"));
Path.Add(new Vector3(3693.902 , -1151.535 , 153.5032 , "None"));
Path.Add(new Vector3(3688.365 , -1157.055 , 149.9776 , "None"));
Path.Add(new Vector3(3686.437 , -1161.797 , 149.2253 , "None"));
Path.Add(new Vector3(3684.784 , -1166.742 , 148.6061 , "None"));
Path.Add(new Vector3(3683.132 , -1171.686 , 147.987 , "None"));
Path.Add(new Vector3(3681.492 , -1176.634 , 147.3679 , "None"));
Path.Add(new Vector3(3681.159 , -1181.665 , 146.7685 , "None"));
Path.Add(new Vector3(3681.39 , -1187.003 , 146.1296 , "None"));
Path.Add(new Vector3(3682.551 , -1192.096 , 145.5092 , "None"));
Path.Add(new Vector3(3684.553 , -1196.901 , 144.89 , "None"));
Path.Add(new Vector3(3685.193 , -1201.698 , 144.3385 , "None"));
Path.Add(new Vector3(3685.304 , -1206.528 , 143.8088 , "None"));
Path.Add(new Vector3(3687.412 , -1211.284 , 143.1909 , "None"));
Path.Add(new Vector3(3689.525 , -1216.05 , 142.5718 , "None"));
Path.Add(new Vector3(3691.642 , -1220.826 , 141.9514 , "None"));
Path.Add(new Vector3(3692.301 , -1222.314 , 137.6332 , "None"));
Path.Add(new Vector3(3692.301 , -1222.314 , 132.3832 , "None"));
Path.Add(new Vector3(3693.159 , -1224.818 , 128.1924 , "None"));
Path.Add(new Vector3(3694.29 , -1228.108 , 124.2608 , "None"));
Path.Add(new Vector3(3695.58 , -1231.195 , 120.2173 , "None"));
Path.Add(new Vector3(3696.932 , -1234.361 , 116.2564 , "None"));
Path.Add(new Vector3(3698.412 , -1238.118 , 115.2022 , "None"));
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


public sealed class P6Back : QuestFollowPathClass
{
    public P6Back()
    {
        Name = "P6 Back";

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

        Path.Add(new Vector3(3698.709 , -1240.487 , 115.2242 , "None"));
Path.Add(new Vector3(3695.955 , -1237.667 , 121.4496 , "None"));
Path.Add(new Vector3(3692.956 , -1234.459 , 123.8513 , "None"));
Path.Add(new Vector3(3689.41 , -1230.508 , 124.9827 , "None"));
Path.Add(new Vector3(3679.106 , -1218.731 , 128.8878 , "None"));
Path.Add(new Vector3(3669.11 , -1198.457 , 135.4155 , "None"));
Path.Add(new Vector3(3665.578 , -1175.979 , 142.0747 , "None"));
Path.Add(new Vector3(3664.996 , -1152.633 , 148.7408 , "None"));
Path.Add(new Vector3(3664.458 , -1130.691 , 154.9931 , "None"));
Path.Add(new Vector3(3663.9 , -1107.977 , 161.4653 , "None"));
Path.Add(new Vector3(3663.323 , -1084.49 , 168.1577 , "None"));
Path.Add(new Vector3(3662.765 , -1061.776 , 174.63 , "None"));
Path.Add(new Vector3(3662.225 , -1039.788 , 180.8952 , "None"));
Path.Add(new Vector3(3661.668 , -1017.119 , 187.3545 , "None"));
Path.Add(new Vector3(3661.091 , -993.6328 , 194.0469 , "None"));
Path.Add(new Vector3(3660.533 , -970.9186 , 200.5191 , "None"));
Path.Add(new Vector3(3659.995 , -948.9766 , 206.7714 , "None"));
Path.Add(new Vector3(3659.418 , -925.49 , 213.4637 , "None"));
Path.Add(new Vector3(3658.869 , -903.1392 , 219.8325 , "None"));
Path.Add(new Vector3(3658.321 , -880.8337 , 226.1882 , "None"));
Path.Add(new Vector3(3657.822 , -858.1194 , 232.6605 , "None"));
Path.Add(new Vector3(3663.108 , -835.9976 , 239.1458 , "None"));
Path.Add(new Vector3(3668.935 , -813.2848 , 245.8251 , "None"));
Path.Add(new Vector3(3674.11 , -791.7026 , 249.171 , "None"));
Path.Add(new Vector3(3675.832 , -781.4459 , 245.7699 , "None"));
Path.Add(new Vector3(3676.517 , -776.6317 , 243.7904 , "None"));
Path.Add(new Vector3(3677.2 , -771.8193 , 241.8067 , "None"));
Path.Add(new Vector3(3677.884 , -767.011 , 239.8129 , "None"));
Path.Add(new Vector3(3678.627 , -762.2303 , 237.775 , "None"));
Path.Add(new Vector3(3681.797 , -744.9273 , 228.946 , "None"));
Path.Add(new Vector3(3687.753 , -725.2616 , 217.3807 , "None"));
Path.Add(new Vector3(3694.177 , -711.6449 , 213.1227 , "None"));
Path.Add(new Vector3(3697.815 , -707.8685 , 214.3626 , "None"));
Path.Add(new Vector3(3702.235 , -705.3649 , 215.5499 , "None"));
Path.Add(new Vector3(3705.903 , -701.8636 , 215.505 , "None"));
Path.Add(new Vector3(3708.805 , -699.0944 , 215.1617 , "None"));
Path.Add(new Vector3(3708.805 , -699.0944 , 215.1617 , "None"));
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


public sealed class P7 : QuestFollowPathClass
{
    public P7()
    {
        Name = "P7";

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

        Path.Add(new Vector3(3693.206 , -715.571 , 212.6972 , "None"));
Path.Add(new Vector3(3690.838 , -718.1481 , 215.3686 , "None"));
Path.Add(new Vector3(3678.082 , -740.2915 , 217.799 , "None"));
Path.Add(new Vector3(3669.631 , -760.879 , 223.0006 , "None"));
Path.Add(new Vector3(3661.094 , -782.4827 , 227.5581 , "None"));
Path.Add(new Vector3(3652.583 , -804.1389 , 231.2376 , "None"));
Path.Add(new Vector3(3647.577 , -825.9308 , 224.2568 , "None"));
Path.Add(new Vector3(3645.419 , -848.8329 , 218.9952 , "None"));
Path.Add(new Vector3(3643.798 , -871.9351 , 214.3256 , "None"));
Path.Add(new Vector3(3642.178 , -895.0372 , 209.6559 , "None"));
Path.Add(new Vector3(3637.37 , -917.5586 , 204.9863 , "None"));
Path.Add(new Vector3(3630.232 , -940.3677 , 200.1672 , "None"));
Path.Add(new Vector3(3623.537 , -961.7623 , 195.6469 , "None"));
Path.Add(new Vector3(3616.62 , -983.8641 , 190.9773 , "None"));
Path.Add(new Vector3(3609.703 , -1005.966 , 186.3076 , "None"));
Path.Add(new Vector3(3602.565 , -1028.775 , 181.4885 , "None"));
Path.Add(new Vector3(3600.711 , -1034.698 , 180.2371 , "None"));
Path.Add(new Vector3(3595.164 , -1052.424 , 176.492 , "None"));
Path.Add(new Vector3(3588.614 , -1073.81 , 171.9811 , "None"));
Path.Add(new Vector3(3587.878 , -1090.422 , 168.6262 , "None"));
Path.Add(new Vector3(3587.723 , -1095.576 , 167.5864 , "None"));
Path.Add(new Vector3(3587.569 , -1100.72 , 166.5487 , "None"));
Path.Add(new Vector3(3587.414 , -1105.895 , 165.5048 , "None"));
Path.Add(new Vector3(3587.261 , -1110.998 , 164.4754 , "None"));
Path.Add(new Vector3(3587.105 , -1116.183 , 163.4294 , "None"));
Path.Add(new Vector3(3587.722 , -1121.221 , 162.3979 , "None"));
Path.Add(new Vector3(3588.963 , -1126.216 , 161.3602 , "None"));
Path.Add(new Vector3(3590.203 , -1131.211 , 160.3225 , "None"));
Path.Add(new Vector3(3591.44 , -1136.196 , 159.2869 , "None"));
Path.Add(new Vector3(3592.683 , -1141.201 , 158.2471 , "None"));
Path.Add(new Vector3(3593.965 , -1146.365 , 157.1741 , "None"));
Path.Add(new Vector3(3596.196 , -1150.172 , 156.2755 , "None"));
Path.Add(new Vector3(3600.258 , -1154.731 , 155.0323 , "None"));
Path.Add(new Vector3(3604.555 , -1157.564 , 153.9946 , "None"));
Path.Add(new Vector3(3608.843 , -1160.391 , 152.959 , "None"));
Path.Add(new Vector3(3613.148 , -1163.229 , 151.9192 , "None"));
Path.Add(new Vector3(3617.591 , -1166.159 , 150.8462 , "None"));
Path.Add(new Vector3(3621.741 , -1168.895 , 149.8438 , "None"));
Path.Add(new Vector3(3626.015 , -1171.714 , 148.7418 , "None"));
Path.Add(new Vector3(3630.142 , -1174.437 , 147.0839 , "None"));
Path.Add(new Vector3(3634.257 , -1177.79 , 145.9973 , "None"));
Path.Add(new Vector3(3638.113 , -1180.94 , 144.9798 , "None"));
Path.Add(new Vector3(3642.091 , -1184.189 , 143.9047 , "None"));
Path.Add(new Vector3(3646.185 , -1187.37 , 143.0537 , "None"));
Path.Add(new Vector3(3650.273 , -1190.578 , 142.3834 , "None"));
Path.Add(new Vector3(3654.369 , -1193.792 , 141.7118 , "None"));
Path.Add(new Vector3(3658.465 , -1197.006 , 141.0401 , "None"));
Path.Add(new Vector3(3662.561 , -1200.221 , 140.3685 , "None"));
Path.Add(new Vector3(3666.657 , -1203.435 , 139.6969 , "None"));
Path.Add(new Vector3(3670.786 , -1206.675 , 139.0199 , "None"));
Path.Add(new Vector3(3674.85 , -1209.864 , 138.3536 , "None"));
Path.Add(new Vector3(3679.413 , -1212.403 , 138.2355 , "None"));
Path.Add(new Vector3(3684.206 , -1214.543 , 138.3042 , "None"));
Path.Add(new Vector3(3689.004 , -1216.674 , 138.373 , "None"));
Path.Add(new Vector3(3693.811 , -1218.809 , 138.4418 , "None"));
Path.Add(new Vector3(3698.599 , -1220.935 , 138.5104 , "None"));
Path.Add(new Vector3(3703.407 , -1223.068 , 138.5793 , "None"));
Path.Add(new Vector3(3708.458 , -1224.456 , 138.6478 , "None"));
Path.Add(new Vector3(3713.58 , -1225.827 , 138.7173 , "None"));
Path.Add(new Vector3(3718.767 , -1226.066 , 138.7853 , "None"));
Path.Add(new Vector3(3724.025 , -1226.232 , 138.8542 , "None"));
Path.Add(new Vector3(3729.261 , -1226.397 , 138.9227 , "None"));
Path.Add(new Vector3(3734.529 , -1226.564 , 138.9917 , "None"));
Path.Add(new Vector3(3739.611 , -1227.789 , 139.0603 , "None"));
Path.Add(new Vector3(3744.664 , -1229.172 , 139.1289 , "None"));
Path.Add(new Vector3(3749.394 , -1231.418 , 139.1978 , "None"));
Path.Add(new Vector3(3753.981 , -1233.969 , 139.2665 , "None"));
Path.Add(new Vector3(3758.359 , -1236.811 , 139.3351 , "None"));
Path.Add(new Vector3(3762.372 , -1240.212 , 139.4039 , "None"));
Path.Add(new Vector3(3766.504 , -1243.715 , 139.4749 , "None"));
Path.Add(new Vector3(3770.079 , -1246.735 , 138.0281 , "None"));
Path.Add(new Vector3(3773.296 , -1249.582 , 134.7245 , "None"));
Path.Add(new Vector3(3776.965 , -1252.948 , 134.273 , "None"));
Path.Add(new Vector3(3780.821 , -1256.511 , 134.4096 , "None"));
Path.Add(new Vector3(3784.683 , -1260.083 , 134.4202 , "None"));
Path.Add(new Vector3(3785.192 , -1260.553 , 134.4157 , "None"));
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


public sealed class P7Back : QuestFollowPathClass
{
    public P7Back()
    {
        Name = "P7 Back";

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

        Path.Add(new Vector3(3785.192 , -1260.553 , 134.4157 , "None"));
Path.Add(new Vector3(3782.455 , -1255.895 , 137.2685 , "None"));
Path.Add(new Vector3(3780.033 , -1253.083 , 140.9808 , "None"));
Path.Add(new Vector3(3777.696 , -1250.199 , 144.6931 , "None"));
Path.Add(new Vector3(3774.673 , -1246.118 , 145.7362 , "None"));
Path.Add(new Vector3(3771.851 , -1241.736 , 146.7025 , "None"));
Path.Add(new Vector3(3765.387 , -1229.525 , 149.2637 , "None"));
Path.Add(new Vector3(3755.396 , -1208.542 , 153.4718 , "None"));
Path.Add(new Vector3(3747.308 , -1186.73 , 157.5377 , "None"));
Path.Add(new Vector3(3740.905 , -1164.309 , 161.319 , "None"));
Path.Add(new Vector3(3735.234 , -1141.669 , 164.9762 , "None"));
Path.Add(new Vector3(3729.687 , -1118.946 , 168.6181 , "None"));
Path.Add(new Vector3(3724.151 , -1096.268 , 172.2528 , "None"));
Path.Add(new Vector3(3718.627 , -1073.635 , 175.8802 , "None"));
Path.Add(new Vector3(3713.08 , -1050.912 , 179.5222 , "None"));
Path.Add(new Vector3(3707.557 , -1028.231 , 183.1568 , "None"));
Path.Add(new Vector3(3702.623 , -1005.459 , 187.0443 , "None"));
Path.Add(new Vector3(3698.015 , -982.7435 , 191.6092 , "None"));
Path.Add(new Vector3(3693.747 , -960.1489 , 196.8167 , "None"));
Path.Add(new Vector3(3691.105 , -937.2838 , 202.3306 , "None"));
Path.Add(new Vector3(3689.588 , -914.3619 , 207.8457 , "None"));
Path.Add(new Vector3(3689.695 , -891.3606 , 213.176 , "None"));
Path.Add(new Vector3(3691.796 , -868.3585 , 218.1137 , "None"));
Path.Add(new Vector3(3694.715 , -845.3802 , 222.7505 , "None"));
Path.Add(new Vector3(3698.603 , -822.2318 , 227.0232 , "None"));
Path.Add(new Vector3(3702.917 , -799.5872 , 230.978 , "None"));
Path.Add(new Vector3(3704.776 , -789.607 , 232.4933 , "None"));
Path.Add(new Vector3(3705.832 , -784.4933 , 232.4674 , "None"));
Path.Add(new Vector3(3709.478 , -764.8433 , 229.513 , "None"));
Path.Add(new Vector3(3710.499 , -742.0609 , 223.4662 , "None"));
Path.Add(new Vector3(3706.063 , -720.1333 , 215.8251 , "None"));
Path.Add(new Vector3(3703.03 , -710.3348 , 215.1657 , "None"));
Path.Add(new Vector3(3704.79 , -705.4222 , 215.5711 , "None"));
Path.Add(new Vector3(3707.375 , -700.8546 , 215.3403 , "None"));
Path.Add(new Vector3(3709.844 , -697.4579 , 215.0426 , "None"));
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
