
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



public sealed class ATentativePact : QuestClass
{
    public ATentativePact()
    {
        Name = "A Tentative Pact";

        QuestId.AddRange(new[] { 12294 });

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


public sealed class ClosetheDeal : QuestClass
{
    public ClosetheDeal()
    {
        Name = "Close the Deal";

        QuestId.AddRange(new[] { 12293 });

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


public sealed class DoingYourDuty : QuestGathererClass
{
    public DoingYourDuty()
    {
        Name = "Doing Your Duty";

        QuestId.AddRange(new[] { 12227 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188666);
HotSpots.Add(new Vector3(3454.267 , -2799.295 , 202.3581 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class EagleEyes : QuestGrinderClass
{
    public EagleEyes()
    {
        Name = "Eagle Eyes";

        QuestId.AddRange(new[] { 12217 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26369);
HotSpots.Add(new Vector3(3682.8 , -2978.21 , 252.732 , "None"));
HotSpots.Add(new Vector3(3654.24 , -3074.07 , 260.452 , "None"));
HotSpots.Add(new Vector3(3684 , -3092.43 , 271.195 , "None"));
HotSpots.Add(new Vector3(3663.63 , -3118.29 , 281.32 , "None"));
HotSpots.Add(new Vector3(3675.468 , -3185.065 , 292.036 , "None"));
HotSpots.Add(new Vector3(3637 , -3385.53 , 248.683 , "None"));
HotSpots.Add(new Vector3(3663.25 , -3379.44 , 252.523 , "None"));
HotSpots.Add(new Vector3(3664.86 , -3421.6 , 247.564 , "None"));
HotSpots.Add(new Vector3(3675.55 , -3423.17 , 251.596 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Flamer : QuestFollowPathClass
{
    public Flamer()
    {
        Name = "Flamer";

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

        Path.Add(new Vector3(2799.598 , -2496.123 , 47.61654 , "None"));
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


public sealed class FlyTo : QuestFollowPathClass
{
    public FlyTo()
    {
        Name = "Fly To";

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

        Path.Add(new Vector3(2796.158 , -2500.56 , 47.61654 , "None"));
Path.Add(new Vector3(2796.158 , -2500.56 , 58.81653 , "None"));
Path.Add(new Vector3(2796.158 , -2500.56 , 73.29252 , "None"));
Path.Add(new Vector3(2803.57 , -2497.83 , 83.57233 , "None"));
Path.Add(new Vector3(2808.802 , -2499.292 , 85.37719 , "None"));
Path.Add(new Vector3(2821.603 , -2501.733 , 90.40265 , "None"));
Path.Add(new Vector3(2834.243 , -2503.652 , 96.24273 , "None"));
Path.Add(new Vector3(2846.808 , -2505.56 , 102.0479 , "None"));
Path.Add(new Vector3(2859.398 , -2507.471 , 107.8647 , "None"));
Path.Add(new Vector3(2871.799 , -2510.249 , 113.5886 , "None"));
Path.Add(new Vector3(2883.86 , -2514.762 , 119.1519 , "None"));
Path.Add(new Vector3(2895.87 , -2519.267 , 124.6897 , "None"));
Path.Add(new Vector3(2907.905 , -2523.78 , 130.2385 , "None"));
Path.Add(new Vector3(2920.116 , -2530.136 , 132.5783 , "None"));
Path.Add(new Vector3(2930.64 , -2537.571 , 134.5602 , "None"));
Path.Add(new Vector3(2944.181 , -2540.797 , 136.0449 , "None"));
Path.Add(new Vector3(2957.99 , -2542.897 , 136.3922 , "None"));
Path.Add(new Vector3(2958.46 , -2542.969 , 132.646 , "None"));
Path.Add(new Vector3(2958.46 , -2542.969 , 129.398 , "None"));
Path.Add(new Vector3(2959.847 , -2541.706 , 129.421 , "None"));
Path.Add(new Vector3(2958.585 , -2540.319 , 127.125 , "None"));
Path.Add(new Vector3(2959.972 , -2539.056 , 127.1479 , "None"));
Path.Add(new Vector3(2957.664 , -2537.835 , 138.1811 , "None"));
Path.Add(new Vector3(2946.011 , -2544.018 , 137.3987 , "None"));
Path.Add(new Vector3(2932.623 , -2542.865 , 134.577 , "None"));
Path.Add(new Vector3(2920.284 , -2537.914 , 132.1008 , "None"));
Path.Add(new Vector3(2907.076 , -2532.615 , 129.4504 , "None"));
Path.Add(new Vector3(2894.828 , -2526.963 , 128.2897 , "None"));
Path.Add(new Vector3(2882.214 , -2521.017 , 127.4368 , "None"));
Path.Add(new Vector3(2868.857 , -2517.69 , 126.5821 , "None"));
Path.Add(new Vector3(2854.49 , -2518.114 , 125.6983 , "None"));
Path.Add(new Vector3(2846.848 , -2520.04 , 125.2146 , "None"));
Path.Add(new Vector3(2846.848 , -2520.04 , 120.0626 , "None"));
Path.Add(new Vector3(2846.848 , -2520.04 , 106.5386 , "None"));
Path.Add(new Vector3(2852.644 , -2526.865 , 98.81599 , "None"));
Path.Add(new Vector3(2863.943 , -2531.827 , 94.97179 , "None"));
Path.Add(new Vector3(2863.943 , -2531.827 , 92.37081 , "None"));
Path.Add(new Vector3(2863.943 , -2531.827 , 88.91914 , "None"));
Path.Add(new Vector3(2863.943 , -2531.827 , 85.46813 , "None"));
Path.Add(new Vector3(2864.878 , -2531.195 , 83.98359 , "None"));
Path.Add(new Vector3(2871.221 , -2533.765 , 84.06535 , "None"));
Path.Add(new Vector3(2877.388 , -2539.141 , 84.42841 , "None"));
Path.Add(new Vector3(2884.058 , -2544.548 , 84.64828 , "None"));
Path.Add(new Vector3(2890.399 , -2549.637 , 84.65371 , "None"));
Path.Add(new Vector3(2897.108 , -2555.02 , 84.65371 , "None"));
Path.Add(new Vector3(2900.821 , -2562.033 , 84.65371 , "None"));
Path.Add(new Vector3(2902.908 , -2570.048 , 84.65371 , "None"));
Path.Add(new Vector3(2904.989 , -2578.048 , 84.65371 , "None"));
Path.Add(new Vector3(2906.286 , -2586.208 , 84.65371 , "None"));
Path.Add(new Vector3(2906.836 , -2594.759 , 84.65371 , "None"));
Path.Add(new Vector3(2907.365 , -2602.991 , 84.65371 , "None"));
Path.Add(new Vector3(2907.91 , -2611.457 , 84.85902 , "None"));
Path.Add(new Vector3(2908.442 , -2619.739 , 84.65533 , "None"));
Path.Add(new Vector3(2908.993 , -2628.306 , 85.02231 , "None"));
Path.Add(new Vector3(2909.546 , -2636.907 , 84.65729 , "None"));
Path.Add(new Vector3(2910.072 , -2645.071 , 84.67716 , "None"));
Path.Add(new Vector3(2910.71 , -2653.327 , 84.98478 , "None"));
Path.Add(new Vector3(2911.704 , -2661.822 , 86.1747 , "None"));
Path.Add(new Vector3(2912.671 , -2670.014 , 88.46967 , "None"));
Path.Add(new Vector3(2913.338 , -2678.53 , 93.68285 , "None"));
Path.Add(new Vector3(2913.536 , -2686.827 , 94.18826 , "None"));
Path.Add(new Vector3(2913.649 , -2695.444 , 93.62906 , "None"));
Path.Add(new Vector3(2913.344 , -2703.646 , 94.20238 , "None"));
Path.Add(new Vector3(2912.551 , -2712.194 , 94.37634 , "None"));
Path.Add(new Vector3(2911.854 , -2720.459 , 94.38232 , "None"));
Path.Add(new Vector3(2913.329 , -2726.616 , 94.36691 , "None"));
Path.Add(new Vector3(2913.795 , -2728.346 , 94.35018 , "None"));
Path.Add(new Vector3(2914.25 , -2730.011 , 94.34922 , "None"));
Path.Add(new Vector3(2914.703 , -2731.676 , 94.34615 , "None"));
Path.Add(new Vector3(2917.24 , -2736.809 , 94.26765 , "None"));
Path.Add(new Vector3(2918.856 , -2745.189 , 90.58889 , "None"));
Path.Add(new Vector3(2921.642 , -2752.839 , 83.8439 , "None"));
Path.Add(new Vector3(2926.775 , -2759.252 , 77.90799 , "None"));
Path.Add(new Vector3(2931.905 , -2766.156 , 72.68974 , "None"));
Path.Add(new Vector3(2939.563 , -2767.53 , 70.1129 , "None"));
Path.Add(new Vector3(2948.179 , -2767.369 , 70.93227 , "None"));
Path.Add(new Vector3(2956.393 , -2767.216 , 69.7842 , "None"));
Path.Add(new Vector3(2964.96 , -2767.056 , 70.31004 , "None"));
Path.Add(new Vector3(2973.174 , -2766.903 , 72.55585 , "None"));
Path.Add(new Vector3(2981.424 , -2766.497 , 73.4193 , "None"));
Path.Add(new Vector3(2989.96 , -2765.755 , 72.91447 , "None"));
Path.Add(new Vector3(2998.537 , -2765.01 , 72.39456 , "None"));
Path.Add(new Vector3(3006.705 , -2764.3 , 72.39954 , "None"));
Path.Add(new Vector3(3014.86 , -2763.591 , 74.55815 , "None"));
Path.Add(new Vector3(3023.446 , -2762.845 , 79.08565 , "None"));
Path.Add(new Vector3(3031.68 , -2762.129 , 82.52848 , "None"));
Path.Add(new Vector3(3040.317 , -2761.379 , 84.83995 , "None"));
Path.Add(new Vector3(3048.579 , -2760.661 , 89.43373 , "None"));
Path.Add(new Vector3(3056.746 , -2759.951 , 93.75767 , "None"));
Path.Add(new Vector3(3065.315 , -2759.206 , 98.49584 , "None"));
Path.Add(new Vector3(3073.55 , -2758.49 , 102.8773 , "None"));
Path.Add(new Vector3(3081.848 , -2758.003 , 106.3239 , "None"));
Path.Add(new Vector3(3090.447 , -2757.759 , 109.212 , "None"));
Path.Add(new Vector3(3098.692 , -2757.526 , 112.5174 , "None"));
Path.Add(new Vector3(3106.988 , -2757.291 , 117.5742 , "None"));
Path.Add(new Vector3(3115.552 , -2757.049 , 121.59 , "None"));
Path.Add(new Vector3(3123.865 , -2756.813 , 125.3629 , "None"));
Path.Add(new Vector3(3132.463 , -2756.57 , 129.6674 , "None"));
Path.Add(new Vector3(3140.665 , -2756.338 , 133.5767 , "None"));
Path.Add(new Vector3(3149.247 , -2756.095 , 136.285 , "None"));
Path.Add(new Vector3(3157.493 , -2755.862 , 138.0504 , "None"));
Path.Add(new Vector3(3165.89 , -2755.624 , 139.9965 , "None"));
Path.Add(new Vector3(3174.454 , -2755.382 , 141.634 , "None"));
Path.Add(new Vector3(3182.733 , -2755.147 , 142.4457 , "None"));
Path.Add(new Vector3(3190.996 , -2754.914 , 142.2019 , "None"));
Path.Add(new Vector3(3199.577 , -2754.671 , 141.3546 , "None"));
Path.Add(new Vector3(3207.738 , -2754.439 , 141.1211 , "None"));
Path.Add(new Vector3(3215.804 , -2755.561 , 141.648 , "None"));
Path.Add(new Vector3(3222.867 , -2759.756 , 143.0102 , "None"));
Path.Add(new Vector3(3230.291 , -2764.165 , 144.0939 , "None"));
Path.Add(new Vector3(3237.354 , -2768.36 , 144.6891 , "None"));
Path.Add(new Vector3(3244.445 , -2772.574 , 147.0105 , "None"));
Path.Add(new Vector3(3252.316 , -2775.739 , 148.513 , "None"));
Path.Add(new Vector3(3260.31 , -2778.63 , 148.7673 , "None"));
Path.Add(new Vector3(3267.966 , -2781.572 , 148.9723 , "None"));
Path.Add(new Vector3(3275.247 , -2786.056 , 154.0097 , "None"));
Path.Add(new Vector3(3282.541 , -2790.55 , 156.7249 , "None"));
Path.Add(new Vector3(3289.607 , -2794.903 , 160.4349 , "None"));
Path.Add(new Vector3(3296.602 , -2799.212 , 165.3018 , "None"));
Path.Add(new Vector3(3304.033 , -2803.365 , 171.0214 , "None"));
Path.Add(new Vector3(3311.365 , -2807.218 , 176.4273 , "None"));
Path.Add(new Vector3(3318.919 , -2811.189 , 180.9821 , "None"));
Path.Add(new Vector3(3326.585 , -2813.784 , 184.9405 , "None"));
Path.Add(new Vector3(3335.185 , -2813.959 , 189.4399 , "None"));
Path.Add(new Vector3(3343.448 , -2814.128 , 193.4557 , "None"));
Path.Add(new Vector3(3351.275 , -2814.287 , 196.0754 , "None"));
Path.Add(new Vector3(3359.843 , -2814.269 , 197.8817 , "None"));
Path.Add(new Vector3(3368.092 , -2814.244 , 198.5962 , "None"));
Path.Add(new Vector3(3376.475 , -2814.219 , 199.0877 , "None"));
Path.Add(new Vector3(3384.875 , -2814.193 , 200.0707 , "None"));
Path.Add(new Vector3(3393.275 , -2814.168 , 200.45 , "None"));
Path.Add(new Vector3(3401.662 , -2814.143 , 200.5113 , "None"));
Path.Add(new Vector3(3410.062 , -2814.117 , 200.499 , "None"));
Path.Add(new Vector3(3415.047 , -2813.716 , 200.4932 , "None"));
Path.Add(new Vector3(3406.811 , -2814.145 , 200.5049 , "None"));
Path.Add(new Vector3(3407.033 , -2806.369 , 201.539 , "None"));
Path.Add(new Vector3(3409.558 , -2798.687 , 201.521 , "None"));
Path.Add(new Vector3(3410.84 , -2795.498 , 201.521 , "None"));
Path.Add(new Vector3(3412.917 , -2792.964 , 201.521 , "None"));
Path.Add(new Vector3(3415.84 , -2791.21 , 201.5153 , "None"));
Path.Add(new Vector3(3416.739 , -2793.581 , 201.5218 , "None"));
Path.Add(new Vector3(3415.977 , -2791.378 , 201.5154 , "None"));
Path.Add(new Vector3(3416.979 , -2788.226 , 201.5049 , "None"));
Path.Add(new Vector3(3419.604 , -2786.54 , 201.5017 , "None"));
Path.Add(new Vector3(3419.72 , -2788.171 , 201.4937 , "None"));
Path.Add(new Vector3(3418.682 , -2791.47 , 201.5041 , "None"));
Path.Add(new Vector3(3416.346 , -2793.58 , 201.5206 , "None"));
Path.Add(new Vector3(3417.62 , -2791.247 , 201.5094 , "None"));
Path.Add(new Vector3(3418.072 , -2788.084 , 201.5013 , "None"));
Path.Add(new Vector3(3419.69 , -2785.362 , 201.5049 , "None"));
Path.Add(new Vector3(3422.586 , -2783.397 , 202.6151 , "None"));
Path.Add(new Vector3(3425.626 , -2781.434 , 202.6389 , "None"));
Path.Add(new Vector3(3428.446 , -2779.568 , 202.6444 , "None"));
Path.Add(new Vector3(3430.791 , -2777.278 , 202.6625 , "None"));
Path.Add(new Vector3(3432.86 , -2774.47 , 202.3688 , "None"));
Path.Add(new Vector3(3434.924 , -2771.488 , 200.7115 , "None"));
Path.Add(new Vector3(3434.931 , -2768.152 , 200.4469 , "None"));
Path.Add(new Vector3(3435.065 , -2764.799 , 200.1214 , "None"));
Path.Add(new Vector3(3437.33 , -2762.121 , 199.3693 , "None"));
Path.Add(new Vector3(3436.806 , -2758.746 , 199.3693 , "None"));
Path.Add(new Vector3(3436.025 , -2755.335 , 199.3693 , "None"));
Path.Add(new Vector3(3435.773 , -2754.072 , 201.0083 , "None"));
Path.Add(new Vector3(3435.566 , -2753.03 , 199.3693 , "None"));
Path.Add(new Vector3(3435.009 , -2751.431 , 199.3693 , "None"));
Path.Add(new Vector3(3434.467 , -2749.501 , 199.3693 , "None"));
Path.Add(new Vector3(3431.084 , -2737.315 , 215.0313 , "Flying"));
Path.Add(new Vector3(3410.952 , -2707.518 , 159.6709 , "Flying"));
Path.Add(new Vector3(3410.952 , -2707.518 , 124.8109 , "Flying"));
Path.Add(new Vector3(3412.283 , -2698.157 , 110.1681 , "Flying"));
Path.Add(new Vector3(3421.748 , -2691.221 , 96.99741 , "Flying"));
Path.Add(new Vector3(3439.289 , -2678.022 , 76.06759 , "Flying"));
Path.Add(new Vector3(3439.289 , -2678.022 , 104.2076 , "Flying"));
Path.Add(new Vector3(3491.084 , -2669.214 , 112.2836 , "Flying"));
Path.Add(new Vector3(3494.488 , -2668.311 , 111.6975 , "Flying"));
Path.Add(new Vector3(3501.974 , -2679.416 , 107.3847 , "Flying"));
Path.Add(new Vector3(3502.596 , -2688.049 , 102.5938 , "None"));
Path.Add(new Vector3(3503.9 , -2688.391 , 104.549 , "None"));
Path.Add(new Vector3(3503.9 , -2688.391 , 102.9696 , "None"));
Path.Add(new Vector3(3503.9 , -2688.391 , 123.9696 , "Flying"));
Path.Add(new Vector3(3509.667 , -2677.871 , 116.618 , "Flying"));
Path.Add(new Vector3(3526.548 , -2667.791 , 109.2465 , "Flying"));
Path.Add(new Vector3(3527.916 , -2666.516 , 108.5589 , "None"));
Path.Add(new Vector3(3530.387 , -2664.213 , 105.5772 , "None"));
Path.Add(new Vector3(3532.619 , -2661.51 , 106.0891 , "None"));
Path.Add(new Vector3(3532.762 , -2661.337 , 141.1051 , "Flying"));
Path.Add(new Vector3(3552.509 , -2660.958 , 134.2311 , "Flying"));
Path.Add(new Vector3(3575.896 , -2658.085 , 128.0495 , "Flying"));
Path.Add(new Vector3(3576.5 , -2659.608 , 127.5214 , "None"));
Path.Add(new Vector3(3577.79 , -2662.861 , 122.8529 , "None"));
Path.Add(new Vector3(3578.667 , -2661.875 , 147.2112 , "Flying"));
Path.Add(new Vector3(3578.667 , -2661.875 , 154.1412 , "Flying"));
Path.Add(new Vector3(3574.465 , -2645.651 , 136.463 , "Flying"));
Path.Add(new Vector3(3581.751 , -2634.244 , 120.4072 , "Flying"));
Path.Add(new Vector3(3583.008 , -2633.228 , 119.7449 , "None"));
Path.Add(new Vector3(3579.74 , -2632.159 , 118.7151 , "None"));
Path.Add(new Vector3(3579.74 , -2632.159 , 136.1451 , "Flying"));
Path.Add(new Vector3(3579.74 , -2632.159 , 146.8551 , "Flying"));
Path.Add(new Vector3(3581.699 , -2656.17 , 142.0261 , "Flying"));
Path.Add(new Vector3(3582.612 , -2666.428 , 139.9831 , "Flying"));
Path.Add(new Vector3(3591.67 , -2701.24 , 129.37 , "None"));
Path.Add(new Vector3(3591.326 , -2700.598 , 164.0273 , "Flying"));
Path.Add(new Vector3(3526.623 , -2708.749 , 225.3104 , "Flying"));
Path.Add(new Vector3(3441.469 , -2735.463 , 241.9584 , "Flying"));
Path.Add(new Vector3(3420.355 , -2733.67 , 237.8204 , "Flying"));
Path.Add(new Vector3(3429.892 , -2752.528 , 219.5734 , "Flying"));
Path.Add(new Vector3(3435.207 , -2765.507 , 209.269 , "Flying"));
Path.Add(new Vector3(3436.176 , -2776.723 , 201.7553 , "None"));
Path.Add(new Vector3(3437.346 , -2775.259 , 200.9115 , "None"));
Path.Add(new Vector3(3440.411 , -2774.957 , 200.5139 , "None"));
Path.Add(new Vector3(3442.218 , -2777.432 , 200.5017 , "None"));
Path.Add(new Vector3(3443.522 , -2780.403 , 200.7619 , "None"));
Path.Add(new Vector3(3444.514 , -2783.543 , 201.1478 , "None"));
Path.Add(new Vector3(3445.344 , -2786.842 , 201.5166 , "None"));
Path.Add(new Vector3(3446.08 , -2788.809 , 201.7402 , "None"));
Path.Add(new Vector3(3444.837 , -2785.914 , 201.3986 , "None"));
Path.Add(new Vector3(3443.304 , -2782.81 , 200.9791 , "None"));
Path.Add(new Vector3(3443.344 , -2779.492 , 200.6537 , "None"));
Path.Add(new Vector3(3441.439 , -2776.698 , 200.5163 , "None"));
Path.Add(new Vector3(3438.52 , -2775.053 , 200.5182 , "None"));
Path.Add(new Vector3(3435.382 , -2774.846 , 201.4006 , "None"));
Path.Add(new Vector3(3432.862 , -2777.131 , 202.6652 , "None"));
Path.Add(new Vector3(3429.787 , -2778.142 , 202.6578 , "None"));
Path.Add(new Vector3(3426.649 , -2779.693 , 202.6389 , "None"));
Path.Add(new Vector3(3423.69 , -2781.74 , 202.6389 , "None"));
Path.Add(new Vector3(3421.005 , -2783.986 , 201.6468 , "None"));
Path.Add(new Vector3(3419.071 , -2786.768 , 201.5056 , "None"));
Path.Add(new Vector3(3417.429 , -2789.699 , 201.5055 , "None"));
Path.Add(new Vector3(3416.052 , -2792.494 , 201.5214 , "None"));
Path.Add(new Vector3(3414.954 , -2790.973 , 201.5183 , "None"));
Path.Add(new Vector3(3416.206 , -2793.424 , 201.5207 , "None"));
Path.Add(new Vector3(3414.076 , -2795.63 , 201.5144 , "None"));
Path.Add(new Vector3(3412.219 , -2798.59 , 201.5182 , "None"));
Path.Add(new Vector3(3409.509 , -2800.149 , 201.5196 , "None"));
Path.Add(new Vector3(3408.261 , -2803.27 , 201.5411 , "None"));
Path.Add(new Vector3(3409.427 , -2806.562 , 202.4011 , "None"));
Path.Add(new Vector3(3410.838 , -2809.764 , 201.8993 , "None"));
Path.Add(new Vector3(3411.864 , -2810.65 , 200.4099 , "None"));
Path.Add(new Vector3(3414.99 , -2811.679 , 200.9293 , "None"));
Path.Add(new Vector3(3418.313 , -2812.246 , 200.4801 , "None"));
Path.Add(new Vector3(3419.806 , -2812.045 , 200.5096 , "None"));
Path.Add(new Vector3(3423.399 , -2812.355 , 200.6331 , "None"));
Path.Add(new Vector3(3426.719 , -2811.676 , 200.8237 , "None"));
Path.Add(new Vector3(3430.146 , -2810.966 , 201.0344 , "None"));
Path.Add(new Vector3(3433.573 , -2810.255 , 200.9923 , "None"));
Path.Add(new Vector3(3436.308 , -2808.343 , 201.0881 , "None"));
Path.Add(new Vector3(3438.164 , -2805.517 , 201.2788 , "None"));
Path.Add(new Vector3(3438.506 , -2802.29 , 201.4726 , "None"));
Path.Add(new Vector3(3439.501 , -2799.054 , 201.5954 , "None"));
Path.Add(new Vector3(3440.174 , -2795.97 , 201.4621 , "None"));
Path.Add(new Vector3(3441.531 , -2792.911 , 201.7348 , "None"));
Path.Add(new Vector3(3441.492 , -2790.461 , 201.6789 , "None"));
Path.Add(new Vector3(3444.167 , -2787.683 , 201.4991 , "None"));
Path.Add(new Vector3(3445.144 , -2784.604 , 201.3024 , "None"));
Path.Add(new Vector3(3445.009 , -2781.114 , 200.9291 , "None"));
Path.Add(new Vector3(3444.873 , -2777.61 , 200.5631 , "None"));
Path.Add(new Vector3(3444.412 , -2774.064 , 200.4221 , "None"));
Path.Add(new Vector3(3442.344 , -2771.383 , 200.453 , "None"));
Path.Add(new Vector3(3439.755 , -2769.048 , 200.3483 , "None"));
Path.Add(new Vector3(3437.542 , -2766.588 , 200.2596 , "None"));
Path.Add(new Vector3(3435.188 , -2764.365 , 200.0204 , "None"));
Path.Add(new Vector3(3431.842 , -2763.341 , 199.7339 , "None"));
Path.Add(new Vector3(3428.28 , -2762.7 , 199.4444 , "None"));
Path.Add(new Vector3(3424.837 , -2762.959 , 199.478 , "None"));
Path.Add(new Vector3(3422.489 , -2765.265 , 200.0536 , "None"));
Path.Add(new Vector3(3424.886 , -2764.76 , 199.8786 , "None"));
Path.Add(new Vector3(3427.057 , -2764.303 , 199.8301 , "None"));
Path.Add(new Vector3(3430.362 , -2763.27 , 199.652 , "None"));
Path.Add(new Vector3(3433.203 , -2761.424 , 199.3689 , "None"));
Path.Add(new Vector3(3436.604 , -2762.058 , 199.3689 , "None"));
Path.Add(new Vector3(3440.112 , -2762.634 , 199.3689 , "None"));
Path.Add(new Vector3(3442.806 , -2763.486 , 199.3689 , "None"));
Path.Add(new Vector3(3443.775 , -2766.98 , 199.8892 , "None"));
Path.Add(new Vector3(3444.411 , -2770.395 , 200.3192 , "None"));
Path.Add(new Vector3(3443.394 , -2773.478 , 200.4491 , "None"));
Path.Add(new Vector3(3442.402 , -2776.568 , 200.4912 , "None"));
Path.Add(new Vector3(3441.522 , -2779.864 , 200.578 , "None"));
Path.Add(new Vector3(3441.616 , -2783.2 , 200.8781 , "None"));
Path.Add(new Vector3(3441.348 , -2786.333 , 201.153 , "None"));
Path.Add(new Vector3(3441.254 , -2789.673 , 201.5507 , "None"));
Path.Add(new Vector3(3440.003 , -2792.814 , 201.5721 , "None"));
Path.Add(new Vector3(3441.286 , -2796.009 , 201.4902 , "None"));
Path.Add(new Vector3(3444.531 , -2797.203 , 203.0187 , "None"));
Path.Add(new Vector3(3447.666 , -2798.452 , 201.8589 , "None"));
Path.Add(new Vector3(3450.691 , -2799.677 , 202.0067 , "None"));
Path.Add(new Vector3(3452.417 , -2800.804 , 202.1816 , "None"));
Path.Add(new Vector3(3454.848 , -2797.879 , 202.2867 , "None"));
Path.Add(new Vector3(3453.532 , -2799.663 , 202.3183 , "None"));
Path.Add(new Vector3(3453.427 , -2797.622 , 202.1762 , "None"));
Path.Add(new Vector3(3452.383 , -2795.542 , 202.0092 , "None"));
Path.Add(new Vector3(3452.952 , -2797.985 , 202.1602 , "None"));
Path.Add(new Vector3(3453.954 , -2799.355 , 202.3402 , "None"));
Path.Add(new Vector3(3451.887 , -2798.437 , 202.0828 , "None"));
Path.Add(new Vector3(3449.805 , -2797.57 , 201.883 , "None"));
Path.Add(new Vector3(3451.406 , -2798.545 , 202.0356 , "None"));
Path.Add(new Vector3(3447.826 , -2798.111 , 201.8725 , "None"));
Path.Add(new Vector3(3444.231 , -2798.494 , 201.7675 , "None"));
Path.Add(new Vector3(3443.27 , -2800.04 , 201.7899 , "None"));
Path.Add(new Vector3(3446.652 , -2799.872 , 201.7909 , "None"));
Path.Add(new Vector3(3450.237 , -2799.558 , 201.9543 , "None"));
Path.Add(new Vector3(3452.013 , -2800.671 , 202.142 , "None"));
Path.Add(new Vector3(3453.464 , -2800.018 , 202.3256 , "None"));
Path.Add(new Vector3(3457.028 , -2800.359 , 202.4409 , "None"));
Path.Add(new Vector3(3455.267 , -2800.537 , 202.3799 , "None"));
Path.Add(new Vector3(3452.147 , -2801.824 , 202.1157 , "None"));
Path.Add(new Vector3(3449.425 , -2802.879 , 201.8969 , "None"));
Path.Add(new Vector3(3445.998 , -2803.466 , 201.8306 , "None"));
Path.Add(new Vector3(3442.536 , -2803.962 , 201.6223 , "None"));
Path.Add(new Vector3(3439.194 , -2804.999 , 201.3692 , "None"));
Path.Add(new Vector3(3435.853 , -2806.044 , 201.1153 , "None"));
Path.Add(new Vector3(3433.254 , -2807.976 , 200.9713 , "None"));
Path.Add(new Vector3(3429.907 , -2809.023 , 200.9752 , "None"));
Path.Add(new Vector3(3427.648 , -2811.363 , 200.9013 , "None"));
Path.Add(new Vector3(3425.344 , -2813.639 , 200.8118 , "None"));
Path.Add(new Vector3(3421.997 , -2814.685 , 200.8061 , "None"));
Path.Add(new Vector3(3418.746 , -2815.347 , 200.6638 , "None"));
Path.Add(new Vector3(3415.229 , -2815.722 , 200.5481 , "None"));
Path.Add(new Vector3(3412.403 , -2814.374 , 200.5011 , "None"));
Path.Add(new Vector3(3409.663 , -2812.372 , 200.4778 , "None"));
Path.Add(new Vector3(3407.82 , -2809.45 , 201.4893 , "None"));
Path.Add(new Vector3(3406.435 , -2806.228 , 201.5389 , "None"));
Path.Add(new Vector3(3406.983 , -2803.503 , 201.5389 , "None"));
Path.Add(new Vector3(3408.306 , -2800.431 , 201.535 , "None"));
Path.Add(new Vector3(3411.13 , -2798.681 , 201.521 , "None"));
Path.Add(new Vector3(3414.369 , -2797.556 , 201.5126 , "None"));
Path.Add(new Vector3(3414.879 , -2796.075 , 201.5118 , "None"));
Path.Add(new Vector3(3413.731 , -2799.129 , 201.513 , "None"));
Path.Add(new Vector3(3411.075 , -2801.195 , 201.5194 , "None"));
Path.Add(new Vector3(3407.877 , -2802.845 , 201.5403 , "None"));
Path.Add(new Vector3(3407.039 , -2805.943 , 201.5403 , "None"));
Path.Add(new Vector3(3406.946 , -2809.44 , 201.3637 , "None"));
Path.Add(new Vector3(3407.096 , -2812.004 , 200.7802 , "None"));
Path.Add(new Vector3(3406.558 , -2815.261 , 200.5206 , "None"));
Path.Add(new Vector3(3405.839 , -2818.511 , 200.6255 , "None"));
Path.Add(new Vector3(3407.024 , -2821.419 , 200.7603 , "None"));
Path.Add(new Vector3(3409.637 , -2821.218 , 200.7338 , "None"));
Path.Add(new Vector3(3435.778 , -2803.163 , 230.3729 , "Flying"));
Path.Add(new Vector3(3491.342 , -2758.279 , 302.1063 , "Flying"));
Path.Add(new Vector3(3552.65 , -2682.504 , 315.1188 , "Flying"));
Path.Add(new Vector3(3611.599 , -2597.212 , 308.274 , "Flying"));
Path.Add(new Vector3(3667.914 , -2504.643 , 302.7573 , "Flying"));
Path.Add(new Vector3(3714.219 , -2410.782 , 298.436 , "Flying"));
Path.Add(new Vector3(3720.354 , -2310.344 , 300.5874 , "Flying"));
Path.Add(new Vector3(3713.644 , -2202.076 , 305.0887 , "Flying"));
Path.Add(new Vector3(3710.434 , -2100.73 , 309.2011 , "Flying"));
Path.Add(new Vector3(3763.847 , -2009.973 , 304.9218 , "Flying"));
Path.Add(new Vector3(3815.965 , -1976.935 , 292.5822 , "Flying"));
Path.Add(new Vector3(3821.132 , -1974.777 , 279.9034 , "Flying"));
Path.Add(new Vector3(3833.477 , -1970.286 , 243.8454 , "Flying"));
Path.Add(new Vector3(3842.349 , -1967.272 , 213.7719 , "None"));
Path.Add(new Vector3(3844.469 , -1965.631 , 212.357 , "None"));
Path.Add(new Vector3(3847.026 , -1963.602 , 208.4875 , "None"));
Path.Add(new Vector3(3847.488 , -1961.893 , 208.4825 , "None"));
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


public sealed class JustPassingThrough : QuestGathererClass
{
    public JustPassingThrough()
    {
        Name = "Just Passing Through";

        QuestId.AddRange(new[] { 12226 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(188670);
HotSpots.Add(new Vector3(3502.237 , -2687.584 , 102.3656 , "None"));
HotSpots.Add(new Vector3(3532.762 , -2661.337 , 106.0351 , "None"));
HotSpots.Add(new Vector3(3578.667 , -2661.875 , 122.6412 , "None"));
HotSpots.Add(new Vector3(3579.74 , -2632.159 , 118.7151 , "None"));
HotSpots.Add(new Vector3(3591.326 , -2700.598 , 128.9573 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LocalSupport : QuestGathererClass
{
    public LocalSupport()
    {
        Name = "Local Support";

        QuestId.AddRange(new[] { 12292 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 4;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(189298);
HotSpots.Add(new Vector3(3231.263 , -1944.495 , 94.04923 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MmmAmberseeds : QuestClass
{
    public MmmAmberseeds()
    {
        Name = "Mmm... Amberseeds!";

        QuestId.AddRange(new[] { 12225 });

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


public sealed class Outhouse : QuestFollowPathClass
{
    public Outhouse()
    {
        Name = "Outhouse";

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

        Path.Add(new Vector3(3457.028 , -2800.359 , 202.4409 , "None"));
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


public sealed class ReplenishingtheStorehouse : QuestGrinderClass
{
    public ReplenishingtheStorehouse()
    {
        Name = "Replenishing the Storehouse";

        QuestId.AddRange(new[] { 12212 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26363);
HotSpots.Add(new Vector3(3495.67 , -2837.09 , 202.3903 , "None"));
HotSpots.Add(new Vector3(3683.87 , -2891.003 , 229.8241 , "None"));
HotSpots.Add(new Vector3(3710.196 , -2815.007 , 213.2087 , "None"));
HotSpots.Add(new Vector3(3724.717 , -2785.921 , 204.2131 , "None"));
HotSpots.Add(new Vector3(3749.78 , -2754.475 , 195.9463 , "None"));
HotSpots.Add(new Vector3(3826.25 , -2788.59 , 230.3358 , "None"));
HotSpots.Add(new Vector3(3661.968 , -2546.212 , 152.9821 , "None"));
HotSpots.Add(new Vector3(3502.033 , -2454.694 , 130.7445 , "None"));
HotSpots.Add(new Vector3(3783.067 , -2449.41 , 184.0913 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SecretsoftheFlamebinders : QuestGrinderClass
{
    public SecretsoftheFlamebinders()
    {
        Name = "Secrets of the Flamebinders";

        QuestId.AddRange(new[] { 12222 });

        Step = new List<int> { 3, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27259);
HotSpots.Add(new Vector3(2735.421 , -2797.629 , 80.51566 , "None"));
HotSpots.Add(new Vector3(2690.837 , -2819.406 , 75.82592 , "None"));
HotSpots.Add(new Vector3(2748.496 , -2726.224 , 88.21004 , "None"));
HotSpots.Add(new Vector3(2796.66 , -2754.17 , 89.229 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TakeTheirRear : QuestGrinderClass
{
    public TakeTheirRear()
    {
        Name = "Take Their Rear!";

        QuestId.AddRange(new[] { 12216 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27131);
HotSpots.Add(new Vector3(3625.674 , -3483.868 , 239.4205 , "None"));
HotSpots.Add(new Vector3(3646.503 , -3541.079 , 228.684 , "None"));
HotSpots.Add(new Vector3(3545.949 , -3475.044 , 247.377 , "None"));
HotSpots.Add(new Vector3(3548.203 , -3444.033 , 249.5611 , "None"));
HotSpots.Add(new Vector3(3319.442 , -3317.604 , 251.345 , "None"));
HotSpots.Add(new Vector3(3353.573 , -3254.865 , 221.1441 , "None"));
HotSpots.Add(new Vector3(3379.825 , -3219.74 , 210.8991 , "None"));
HotSpots.Add(new Vector3(3301.993 , -3223.358 , 208.9692 , "None"));
HotSpots.Add(new Vector3(3245.718 , -3221.536 , 201.0252 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheHillsHaveUs : QuestClass
{
    public TheHillsHaveUs()
    {
        Name = "The Hills Have Us";

        QuestId.AddRange(new[] { 12511 });

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


public sealed class TheThaneofVoldrune : QuestClass
{
    public TheThaneofVoldrune()
    {
        Name = "The Thane of Voldrune";

        QuestId.AddRange(new[] { 12255 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 5;

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


public sealed class ThemorUs : QuestGrinderClass
{
    public ThemorUs()
    {
        Name = "Them or Us!";

        QuestId.AddRange(new[] { 12215 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(26592);
HotSpots.Add(new Vector3(3823.889 , -2410.608 , 184.8549 , "None"));
HotSpots.Add(new Vector3(3788.987 , -2384.761 , 173.8315 , "None"));
HotSpots.Add(new Vector3(3760.598 , -2343.121 , 164.8193 , "None"));
HotSpots.Add(new Vector3(3707.328 , -2338.745 , 160.0386 , "None"));
HotSpots.Add(new Vector3(3740.992 , -2385.842 , 165.3077 , "None"));
HotSpots.Add(new Vector3(3586.686 , -2458.802 , 142.168 , "None"));
HotSpots.Add(new Vector3(3589.338 , -2482.633 , 142.457 , "None"));
HotSpots.Add(new Vector3(3556.938 , -2426.85 , 139.9255 , "None"));
HotSpots.Add(new Vector3(3519.071 , -2421.376 , 136.3936 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class ThinningtheRanks : QuestGrinderClass
{
    public ThinningtheRanks()
    {
        Name = "Thinning the Ranks";

        QuestId.AddRange(new[] { 12223 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(27260);
EntryTarget.Add(27259);
HotSpots.Add(new Vector3(2744.561 , -2860.204 , 71.97203 , "None"));
HotSpots.Add(new Vector3(2700.975 , -2851.857 , 73.34637 , "None"));
HotSpots.Add(new Vector3(2687.985 , -2820.682 , 75.62615 , "None"));
HotSpots.Add(new Vector3(2730.859 , -2797.836 , 78.46181 , "None"));
HotSpots.Add(new Vector3(2703.14 , -2765.9 , 83.73869 , "None"));
HotSpots.Add(new Vector3(2749.97 , -2776.68 , 96.33704 , "None"));
HotSpots.Add(new Vector3(2794.2 , -2702.35 , 85.4539 , "None"));
HotSpots.Add(new Vector3(2772.13 , -2771.28 , 96.35476 , "None"));
HotSpots.Add(new Vector3(2910.33 , -2717.12 , 94.41151 , "None"));
HotSpots.Add(new Vector3(2989.24 , -2586.43 , 97.14703 , "None"));
HotSpots.Add(new Vector3(2915.68 , -2535.573 , 79.72011 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TrollSeason : QuestClass
{
    public TrollSeason()
    {
        Name = "Troll Season!";

        QuestId.AddRange(new[] { 12210 });

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


public sealed class AnExerciseinDiplomacy : QuestClass
{
    public AnExerciseinDiplomacy()
    {
        Name = "An Exercise in Diplomacy";

        QuestId.AddRange(new[] { 12295 });

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
