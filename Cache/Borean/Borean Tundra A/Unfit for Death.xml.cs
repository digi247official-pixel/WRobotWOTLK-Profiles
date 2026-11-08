
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



public sealed class UnfitforDeath : QuestClass
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


    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class Trap1 : QuestFollowPathClass
{
    public Trap1()
    {
        Name = "Trap1";

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

        Path.Add(new Vector3(3119.385 , 5313.13 , 55.71227 , "None"));
Path.Add(new Vector3(3120.644 , 5313.37 , 55.44313 , "None"));
Path.Add(new Vector3(3121.773 , 5313.642 , 55.12444 , "None"));
Path.Add(new Vector3(3122.896 , 5313.94 , 54.7605 , "None"));
Path.Add(new Vector3(3124.135 , 5314.269 , 54.3912 , "None"));
Path.Add(new Vector3(3124.943 , 5314.397 , 54.18066 , "None"));
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


public sealed class Trap2 : QuestFollowPathClass
{
    public Trap2()
    {
        Name = "Trap2";

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

        Path.Add(new Vector3(3118.02 , 5257.455 , 59.15042 , "None"));
Path.Add(new Vector3(3117.711 , 5255.491 , 59.60838 , "None"));
Path.Add(new Vector3(3117.574 , 5254.691 , 59.80392 , "None"));
Path.Add(new Vector3(3117.476 , 5254.118 , 59.94433 , "None"));
Path.Add(new Vector3(3117.339 , 5253.318 , 60.08924 , "None"));
Path.Add(new Vector3(3117.249 , 5252.509 , 60.20845 , "None"));
Path.Add(new Vector3(3117.139 , 5251.226 , 60.39499 , "None"));
Path.Add(new Vector3(3117.061 , 5250.181 , 60.55074 , "None"));
Path.Add(new Vector3(3117.043 , 5249.951 , 60.5842 , "None"));
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


public sealed class Trap3 : QuestFollowPathClass
{
    public Trap3()
    {
        Name = "Trap3";

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

        Path.Add(new Vector3(3069.299 , 5244.502 , 63.94885 , "None"));
Path.Add(new Vector3(3067.521 , 5242.487 , 64.26875 , "None"));
Path.Add(new Vector3(3065.17 , 5239.894 , 64.5931 , "None"));
Path.Add(new Vector3(3063.237 , 5237.561 , 64.91715 , "None"));
Path.Add(new Vector3(3062.93 , 5237.069 , 64.96405 , "None"));
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


public sealed class Trap4 : QuestFollowPathClass
{
    public Trap4()
    {
        Name = "Trap4";

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

        Path.Add(new Vector3(3044.617 , 5306.964 , 59.28161 , "None"));
Path.Add(new Vector3(3044.376 , 5309.753 , 59.42115 , "None"));
Path.Add(new Vector3(3044.177 , 5313.128 , 59.67043 , "None"));
Path.Add(new Vector3(3043.994 , 5316.625 , 59.84587 , "None"));
Path.Add(new Vector3(3043.886 , 5318.834 , 59.85632 , "None"));
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


public sealed class Trap5 : QuestFollowPathClass
{
    public Trap5()
    {
        Name = "Trap5";

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

        Path.Add(new Vector3(3031.35 , 5280.84 , 58.64895 , "None"));
Path.Add(new Vector3(3031.286 , 5279.673 , 58.90916 , "None"));
Path.Add(new Vector3(3031.073 , 5276.18 , 60.10286 , "None"));
Path.Add(new Vector3(3030.9 , 5272.683 , 61.11214 , "None"));
Path.Add(new Vector3(3030.826 , 5270.465 , 61.50179 , "None"));
Path.Add(new Vector3(3029.191 , 5268.225 , 61.46293 , "None"));
Path.Add(new Vector3(3027.003 , 5265.494 , 61.47418 , "None"));
Path.Add(new Vector3(3024.815 , 5262.762 , 61.48682 , "None"));
Path.Add(new Vector3(3022.556 , 5259.943 , 61.67661 , "None"));
Path.Add(new Vector3(3020.438 , 5257.299 , 61.87527 , "None"));
Path.Add(new Vector3(3018.25 , 5254.567 , 62.07811 , "None"));
Path.Add(new Vector3(3016.062 , 5251.835 , 62.53505 , "None"));
Path.Add(new Vector3(3013.874 , 5249.104 , 63.11129 , "None"));
Path.Add(new Vector3(3014.739 , 5250.846 , 62.74416 , "None"));
Path.Add(new Vector3(3016.437 , 5253.907 , 62.00489 , "None"));
Path.Add(new Vector3(3017.344 , 5255.541 , 61.8992 , "None"));
Path.Add(new Vector3(3016.478 , 5254.165 , 61.94609 , "None"));
Path.Add(new Vector3(3015.304 , 5252.424 , 62.32734 , "None"));
Path.Add(new Vector3(3014.445 , 5251.18 , 62.6342 , "None"));
Path.Add(new Vector3(3012.282 , 5248.428 , 63.23195 , "None"));
Path.Add(new Vector3(3010.035 , 5245.6 , 63.64644 , "None"));
Path.Add(new Vector3(3008.071 , 5243.128 , 63.58528 , "None"));
Path.Add(new Vector3(3006.549 , 5241.209 , 63.47773 , "None"));
Path.Add(new Vector3(3004.423 , 5238.289 , 63.38667 , "None"));
Path.Add(new Vector3(3002.497 , 5235.501 , 63.25634 , "None"));
Path.Add(new Vector3(3000.496 , 5232.629 , 63.15384 , "None"));
Path.Add(new Vector3(2998.37 , 5229.7 , 63.0581 , "None"));
Path.Add(new Vector3(2997.893 , 5229.043 , 63.03718 , "None"));
Path.Add(new Vector3(2997.412 , 5228.38 , 62.98184 , "None"));
Path.Add(new Vector3(2996.913 , 5228.148 , 62.9234 , "None"));
Path.Add(new Vector3(2993.823 , 5229.786 , 62.6868 , "None"));
Path.Add(new Vector3(2990.744 , 5231.45 , 62.13643 , "None"));
Path.Add(new Vector3(2987.665 , 5233.114 , 61.41845 , "None"));
Path.Add(new Vector3(2984.586 , 5234.778 , 61.25984 , "None"));
Path.Add(new Vector3(2981.507 , 5236.442 , 61.80694 , "None"));
Path.Add(new Vector3(2978.427 , 5238.105 , 61.67397 , "None"));
Path.Add(new Vector3(2975.348 , 5239.77 , 60.85493 , "None"));
Path.Add(new Vector3(2972.269 , 5241.434 , 60.00045 , "None"));
Path.Add(new Vector3(2968.923 , 5242.371 , 59.98519 , "None"));
Path.Add(new Vector3(2965.491 , 5243.091 , 60.7559 , "None"));
Path.Add(new Vector3(2962.058 , 5243.812 , 61.40342 , "None"));
Path.Add(new Vector3(2961.271 , 5243.977 , 61.40513 , "None"));
Path.Add(new Vector3(2958.417 , 5244.593 , 61.28019 , "None"));
Path.Add(new Vector3(2955.017 , 5245.421 , 60.67373 , "None"));
Path.Add(new Vector3(2951.601 , 5246.169 , 60.82786 , "None"));
Path.Add(new Vector3(2950.687 , 5246.35 , 60.93155 , "None"));
Path.Add(new Vector3(2948.863 , 5247.118 , 60.7887 , "None"));
Path.Add(new Vector3(2945.542 , 5248.556 , 60.35215 , "None"));
Path.Add(new Vector3(2942.323 , 5249.95 , 60.4198 , "None"));
Path.Add(new Vector3(2939.112 , 5251.341 , 60.75863 , "None"));
Path.Add(new Vector3(2935.906 , 5252.729 , 60.80697 , "None"));
Path.Add(new Vector3(2932.695 , 5254.12 , 60.50441 , "None"));
Path.Add(new Vector3(2929.483 , 5255.511 , 60.31489 , "None"));
Path.Add(new Vector3(2926.271 , 5256.901 , 60.45589 , "None"));
Path.Add(new Vector3(2922.828 , 5257.427 , 60.71715 , "None"));
Path.Add(new Vector3(2919.35 , 5257.823 , 61.08569 , "None"));
Path.Add(new Vector3(2915.872 , 5258.218 , 61.382 , "None"));
Path.Add(new Vector3(2912.4 , 5258.613 , 61.45237 , "None"));
Path.Add(new Vector3(2910.195 , 5258.859 , 61.44955 , "None"));
Path.Add(new Vector3(2907.402 , 5259.058 , 61.27569 , "None"));
Path.Add(new Vector3(2903.922 , 5259.43 , 60.75426 , "None"));
Path.Add(new Vector3(2900.562 , 5259.863 , 60.33062 , "None"));
Path.Add(new Vector3(2898.59 , 5260.113 , 60.19812 , "None"));
Path.Add(new Vector3(2895.115 , 5260.526 , 60.1664 , "None"));
Path.Add(new Vector3(2893.958 , 5260.643 , 60.18563 , "None"));
Path.Add(new Vector3(2893.38 , 5260.701 , 60.21606 , "None"));
Path.Add(new Vector3(2892.802 , 5260.76 , 60.24746 , "None"));
Path.Add(new Vector3(2893.451 , 5260.259 , 60.1927 , "None"));
Path.Add(new Vector3(2896.221 , 5258.121 , 60.11971 , "None"));
Path.Add(new Vector3(2897.241 , 5257.334 , 60.14683 , "None"));
Path.Add(new Vector3(2897.89 , 5256.833 , 60.16407 , "None"));
Path.Add(new Vector3(2900.666 , 5254.691 , 60.2719 , "None"));
Path.Add(new Vector3(2903.249 , 5252.698 , 60.44409 , "None"));
Path.Add(new Vector3(2902.999 , 5253.228 , 60.41176 , "None"));
Path.Add(new Vector3(2900.278 , 5255.297 , 60.25002 , "None"));
Path.Add(new Vector3(2898.282 , 5257.846 , 60.1831 , "None"));
Path.Add(new Vector3(2898.357 , 5254.911 , 60.19823 , "None"));
Path.Add(new Vector3(2899.24 , 5251.523 , 60.38267 , "None"));
Path.Add(new Vector3(2900.122 , 5248.137 , 60.82709 , "None"));
Path.Add(new Vector3(2901.033 , 5244.642 , 61.62905 , "None"));
Path.Add(new Vector3(2901.887 , 5241.363 , 62.56255 , "None"));
Path.Add(new Vector3(2902.773 , 5237.962 , 63.06524 , "None"));
Path.Add(new Vector3(2903.652 , 5234.589 , 62.94379 , "None"));
Path.Add(new Vector3(2904.534 , 5231.202 , 62.53125 , "None"));
Path.Add(new Vector3(2905.417 , 5227.815 , 62.53152 , "None"));
Path.Add(new Vector3(2906.093 , 5225.221 , 63.03883 , "None"));
Path.Add(new Vector3(2906.393 , 5223.968 , 63.28485 , "None"));
Path.Add(new Vector3(2906.845 , 5222.161 , 63.54432 , "None"));
Path.Add(new Vector3(2907.712 , 5218.762 , 63.73997 , "None"));
Path.Add(new Vector3(2908.194 , 5216.848 , 63.7079 , "None"));
Path.Add(new Vector3(2908.336 , 5216.285 , 63.65159 , "None"));
Path.Add(new Vector3(2906.629 , 5217.434 , 63.69865 , "None"));
Path.Add(new Vector3(2904.679 , 5220.34 , 63.60423 , "None"));
Path.Add(new Vector3(2902.725 , 5223.252 , 63.33927 , "None"));
Path.Add(new Vector3(2900.775 , 5226.159 , 63.08337 , "None"));
Path.Add(new Vector3(2898.824 , 5229.065 , 62.70932 , "None"));
Path.Add(new Vector3(2896.874 , 5231.972 , 62.82103 , "None"));
Path.Add(new Vector3(2894.924 , 5234.878 , 62.77143 , "None"));
Path.Add(new Vector3(2892.974 , 5237.784 , 62.54323 , "None"));
Path.Add(new Vector3(2891.024 , 5240.691 , 62.27851 , "None"));
Path.Add(new Vector3(2889.074 , 5243.597 , 61.93568 , "None"));
Path.Add(new Vector3(2887.124 , 5246.503 , 61.35136 , "None"));
Path.Add(new Vector3(2885.174 , 5249.41 , 60.78093 , "None"));
Path.Add(new Vector3(2883.223 , 5252.316 , 60.63063 , "None"));
Path.Add(new Vector3(2881.273 , 5255.223 , 60.69902 , "None"));
Path.Add(new Vector3(2879.62 , 5258.282 , 60.81437 , "None"));
Path.Add(new Vector3(2878.401 , 5261.563 , 60.96978 , "None"));
Path.Add(new Vector3(2877.182 , 5264.843 , 61.29085 , "None"));
Path.Add(new Vector3(2875.962 , 5268.124 , 61.38549 , "None"));
Path.Add(new Vector3(2874.743 , 5271.405 , 61.1185 , "None"));
Path.Add(new Vector3(2873.524 , 5274.686 , 60.46352 , "None"));
Path.Add(new Vector3(2872.305 , 5277.966 , 59.90731 , "None"));
Path.Add(new Vector3(2871.086 , 5281.247 , 59.80998 , "None"));
Path.Add(new Vector3(2869.867 , 5284.528 , 60.32932 , "None"));
Path.Add(new Vector3(2870.97 , 5285.496 , 60.4116 , "None"));
Path.Add(new Vector3(2874.47 , 5285.492 , 60.09591 , "None"));
Path.Add(new Vector3(2877.97 , 5285.489 , 59.81207 , "None"));
Path.Add(new Vector3(2881.47 , 5285.485 , 59.55317 , "None"));
Path.Add(new Vector3(2883.794 , 5285.488 , 59.42493 , "None"));
Path.Add(new Vector3(2883.361 , 5287.421 , 59.44299 , "None"));
Path.Add(new Vector3(2883.079 , 5288.671 , 59.44135 , "None"));
Path.Add(new Vector3(2885.982 , 5288.979 , 59.54792 , "None"));
Path.Add(new Vector3(2889.448 , 5288.49 , 59.52992 , "None"));
Path.Add(new Vector3(2892.914 , 5288.001 , 59.229 , "None"));
Path.Add(new Vector3(2896.391 , 5287.666 , 58.871 , "None"));
Path.Add(new Vector3(2899.887 , 5287.622 , 59.37798 , "None"));
Path.Add(new Vector3(2903.387 , 5287.578 , 59.79107 , "None"));
Path.Add(new Vector3(2906.887 , 5287.533 , 59.9362 , "None"));
Path.Add(new Vector3(2910.387 , 5287.489 , 59.97489 , "None"));
Path.Add(new Vector3(2913.886 , 5287.445 , 60.06927 , "None"));
Path.Add(new Vector3(2917.386 , 5287.401 , 60.32258 , "None"));
Path.Add(new Vector3(2920.886 , 5287.356 , 60.72051 , "None"));
Path.Add(new Vector3(2924.393 , 5287.313 , 60.51728 , "None"));
Path.Add(new Vector3(2927.885 , 5287.268 , 60.07497 , "None"));
Path.Add(new Vector3(2931.392 , 5287.224 , 60.20966 , "None"));
Path.Add(new Vector3(2934.885 , 5287.18 , 60.91501 , "None"));
Path.Add(new Vector3(2938.385 , 5287.136 , 61.66198 , "None"));
Path.Add(new Vector3(2941.884 , 5287.091 , 61.87272 , "None"));
Path.Add(new Vector3(2945.384 , 5287.047 , 61.54287 , "None"));
Path.Add(new Vector3(2948.884 , 5287.003 , 61.16004 , "None"));
Path.Add(new Vector3(2952.383 , 5286.959 , 61.04474 , "None"));
Path.Add(new Vector3(2955.89 , 5286.915 , 61.33841 , "None"));
Path.Add(new Vector3(2959.509 , 5286.869 , 61.72812 , "None"));
Path.Add(new Vector3(2963.009 , 5286.825 , 61.83383 , "None"));
Path.Add(new Vector3(2966.508 , 5286.781 , 61.66542 , "None"));
Path.Add(new Vector3(2970.008 , 5286.736 , 61.5215 , "None"));
Path.Add(new Vector3(2973.508 , 5286.692 , 61.42868 , "None"));
Path.Add(new Vector3(2976.998 , 5286.648 , 61.53339 , "None"));
Path.Add(new Vector3(2980.498 , 5286.604 , 61.91401 , "None"));
Path.Add(new Vector3(2984.005 , 5286.56 , 62.2809 , "None"));
Path.Add(new Vector3(2987.497 , 5286.516 , 62.36137 , "None"));
Path.Add(new Vector3(2990.997 , 5286.472 , 61.89386 , "None"));
Path.Add(new Vector3(2994.497 , 5286.428 , 61.14683 , "None"));
Path.Add(new Vector3(2998.003 , 5286.383 , 60.71389 , "None"));
Path.Add(new Vector3(3001.503 , 5286.339 , 60.3404 , "None"));
Path.Add(new Vector3(3005.003 , 5286.295 , 59.95704 , "None"));
Path.Add(new Vector3(3008.615 , 5286.25 , 59.57035 , "None"));
Path.Add(new Vector3(3012.114 , 5286.205 , 59.21415 , "None"));
Path.Add(new Vector3(3015.502 , 5286.163 , 58.85138 , "None"));
Path.Add(new Vector3(3019.114 , 5286.117 , 58.56087 , "None"));
Path.Add(new Vector3(3022.614 , 5286.073 , 58.36159 , "None"));
Path.Add(new Vector3(3026.001 , 5286.03 , 58.21515 , "None"));
Path.Add(new Vector3(3029.62 , 5285.984 , 58.10091 , "None"));
Path.Add(new Vector3(3033.12 , 5285.94 , 58.02104 , "None"));
Path.Add(new Vector3(3036.5 , 5285.897 , 57.97939 , "None"));
Path.Add(new Vector3(3040.111 , 5285.852 , 57.98815 , "None"));
Path.Add(new Vector3(3043.61 , 5285.808 , 58.09952 , "None"));
Path.Add(new Vector3(3047.11 , 5285.764 , 58.28844 , "None"));
Path.Add(new Vector3(3050.61 , 5285.719 , 58.53674 , "None"));
Path.Add(new Vector3(3054.109 , 5285.675 , 58.79394 , "None"));
Path.Add(new Vector3(3057.609 , 5285.631 , 58.79682 , "None"));
Path.Add(new Vector3(3061.109 , 5285.587 , 58.57539 , "None"));
Path.Add(new Vector3(3064.49 , 5285.544 , 58.37724 , "None"));
Path.Add(new Vector3(3067.989 , 5285.5 , 58.28186 , "None"));
Path.Add(new Vector3(3071.608 , 5285.454 , 58.26929 , "None"));
Path.Add(new Vector3(3075.108 , 5285.41 , 58.47992 , "None"));
Path.Add(new Vector3(3078.607 , 5285.366 , 59.14354 , "None"));
Path.Add(new Vector3(3081.288 , 5285.332 , 59.48993 , "None"));
Path.Add(new Vector3(3079.115 , 5285.359 , 59.22112 , "None"));
Path.Add(new Vector3(3076.941 , 5285.387 , 58.88416 , "None"));
Path.Add(new Vector3(3075.888 , 5285.4 , 58.65276 , "None"));
Path.Add(new Vector3(3078.099 , 5285.333 , 59.06105 , "None"));
Path.Add(new Vector3(3081.474 , 5285.132 , 59.46723 , "None"));
Path.Add(new Vector3(3082.292 , 5285.081 , 59.49702 , "None"));
Path.Add(new Vector3(3083.453 , 5285.061 , 59.54882 , "None"));
Path.Add(new Vector3(3084.16 , 5285.055 , 59.60409 , "None"));
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


public sealed class Trap6 : QuestFollowPathClass
{
    public Trap6()
    {
        Name = "Trap6";

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

        Path.Add(new Vector3(3007.636 , 5242.581 , 63.55894 , "None"));
Path.Add(new Vector3(3005.507 , 5239.803 , 63.42431 , "None"));
Path.Add(new Vector3(3003.492 , 5236.941 , 63.32731 , "None"));
Path.Add(new Vector3(3001.43 , 5233.967 , 63.1963 , "None"));
Path.Add(new Vector3(2999.469 , 5231.212 , 63.10719 , "None"));
Path.Add(new Vector3(2997.893 , 5229.043 , 63.03718 , "None"));
Path.Add(new Vector3(2997.412 , 5228.38 , 62.98184 , "None"));
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


public sealed class Trap7 : QuestFollowPathClass
{
    public Trap7()
    {
        Name = "Trap7";

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

        Path.Add(new Vector3(2960.359 , 5244.168 , 61.39107 , "None"));
Path.Add(new Vector3(2957.055 , 5244.917 , 61.0312 , "None"));
Path.Add(new Vector3(2953.654 , 5245.744 , 60.59021 , "None"));
Path.Add(new Vector3(2951.147 , 5246.259 , 60.87928 , "None"));
Path.Add(new Vector3(2950.687 , 5246.35 , 60.93155 , "None"));
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


public sealed class Trap8 : QuestFollowPathClass
{
    public Trap8()
    {
        Name = "Trap8";

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

        Path.Add(new Vector3(2900.562 , 5259.863 , 60.33062 , "None"));
Path.Add(new Vector3(2896.854 , 5260.33 , 60.1614 , "None"));
Path.Add(new Vector3(2893.958 , 5260.643 , 60.18563 , "None"));
Path.Add(new Vector3(2893.38 , 5260.701 , 60.21606 , "None"));
Path.Add(new Vector3(2892.802 , 5260.76 , 60.24746 , "None"));
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


public sealed class Trap9 : QuestFollowPathClass
{
    public Trap9()
    {
        Name = "Trap9";

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

        Path.Add(new Vector3(2906.393 , 5223.968 , 63.28485 , "None"));
Path.Add(new Vector3(2906.642 , 5222.946 , 63.45078 , "None"));
Path.Add(new Vector3(2907.51 , 5219.563 , 63.75374 , "None"));
Path.Add(new Vector3(2908.194 , 5216.848 , 63.7079 , "None"));
Path.Add(new Vector3(2908.336 , 5216.285 , 63.65159 , "None"));
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


public sealed class Trap10 : QuestFollowPathClass
{
    public Trap10()
    {
        Name = "Trap10";

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

        Path.Add(new Vector3(3075.888 , 5285.4 , 58.65276 , "None"));
Path.Add(new Vector3(3079.036 , 5285.284 , 59.19869 , "None"));
Path.Add(new Vector3(3081.474 , 5285.132 , 59.46723 , "None"));
Path.Add(new Vector3(3082.872 , 5285.066 , 59.52017 , "None"));
Path.Add(new Vector3(3083.453 , 5285.061 , 59.54882 , "None"));
Path.Add(new Vector3(3084.391 , 5285.053 , 59.62218 , "None"));
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


public sealed class Run : QuestFollowPathClass
{
    public Run()
    {
        Name = "Run";

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

        Path.Add(new Vector3(2868.683 , 5287.713 , 60.98252 , "None"));
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
