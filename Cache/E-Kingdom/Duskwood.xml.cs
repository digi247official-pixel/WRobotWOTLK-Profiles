
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



public sealed class ADaughtersLove : QuestClass
{
    public ADaughtersLove()
    {
        Name = "A Daughter's Love";

        QuestId.AddRange(new[] { 231 });

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


public sealed class AWeatheredGrave : QuestClass
{
    public AWeatheredGrave()
    {
        Name = "A Weathered Grave";

        QuestId.AddRange(new[] { 225 });

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


public sealed class AnOldHistoryBook : QuestClass
{
    public AnOldHistoryBook()
    {
        Name = "An Old History Book";

        QuestId.AddRange(new[] { 337 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = true;
        PickUpQuestOnItemID = 2794;

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


public sealed class ArmedandReady : QuestClass
{
    public ArmedandReady()
    {
        Name = "Armed and Ready";

        QuestId.AddRange(new[] { 325 });

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


public sealed class BlessedArm : QuestClass
{
    public BlessedArm()
    {
        Name = "Blessed Arm";

        QuestId.AddRange(new[] { 322 });

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


public sealed class BrideoftheEmbalmer : QuestGrinderClass
{
    public BrideoftheEmbalmer()
    {
        Name = "Bride of the Embalmer";

        QuestId.AddRange(new[] { 253 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(314);
HotSpots.Add(new Vector3(-10271.63 , 52.00196 , 42.86352 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return wManager.Wow.Helpers.ItemsManager.GetItemCountByIdLUA(2382) >= 1;
}






}


public sealed class BrideoftheEmbalmer1 : QuestFollowPathClass
{
    public BrideoftheEmbalmer1()
    {
        Name = "Bride of the Embalmer1";

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

        Path.Add(new Vector3(-10273.44 , 53.42505 , 42.63371 , "None"));
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


public sealed class DeeprunTram : QuestFollowPathClass
{
    public DeeprunTram()
    {
        Name = "Deeprun Tram";

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

        Path.Add(new Vector3(-8390.217 , 569.2944 , 91.79703 , "None"));
Path.Add(new Vector3(-8388.262 , 566.4499 , 91.79703 , "None"));
Path.Add(new Vector3(-8383.918 , 561.379 , 91.79703 , "None"));
Path.Add(new Vector3(-8379.715 , 556.483 , 91.79703 , "None"));
Path.Add(new Vector3(-8375.508 , 551.2894 , 91.79703 , "None"));
Path.Add(new Vector3(-8371.518 , 546.2175 , 91.79703 , "None"));
Path.Add(new Vector3(-8367.521 , 541.1355 , 91.79703 , "None"));
Path.Add(new Vector3(-8363.516 , 536.0434 , 91.79703 , "None"));
Path.Add(new Vector3(-8359.398 , 530.8096 , 91.79703 , "None"));
Path.Add(new Vector3(-8355.393 , 525.7174 , 91.79703 , "None"));
Path.Add(new Vector3(-8351.269 , 520.4734 , 91.79703 , "None"));
Path.Add(new Vector3(68.3006 , 2490.91 , -4.29647 , "None"));
Path.Add(new Vector3(62.47997 , 2491.024 , -4.29647 , "None"));
Path.Add(new Vector3(56.67221 , 2491.139 , -4.29647 , "None"));
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


public sealed class DeeprunTram1 : QuestFollowPathClass
{
    public DeeprunTram1()
    {
        Name = "Deeprun Tram1";

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

        Path.Add(new Vector3(11.54893 , 2490.996 , -3.950159 , "None"));
Path.Add(new Vector3(13.41012 , 2494.537 , -4.295677 , "None"));
Path.Add(new Vector3(13.32629 , 2498.324 , -4.297139 , "None"));
Path.Add(new Vector3(7.80999 , 2498.069 , -7.011927 , "None"));
Path.Add(new Vector3(4.025637 , 2497.641 , -13.86277 , "None"));
Path.Add(new Vector3(4.114383 , 2493.601 , -13.86277 , "None"));
Path.Add(new Vector3(4.214475 , 2489.698 , -13.86277 , "None"));
Path.Add(new Vector3(4.307756 , 2486.061 , -13.86277 , "None"));
Path.Add(new Vector3(4.414865 , 2481.884 , -13.86277 , "None"));
Path.Add(new Vector3(4.518466 , 2477.844 , -13.86277 , "None"));
Path.Add(new Vector3(4.621861 , 2473.813 , -13.86277 , "None"));
Path.Add(new Vector3(4.643 , 2469.771 , -13.86277 , "None"));
Path.Add(new Vector3(5.046773 , 2466.85 , -13.86277 , "None"));
Path.Add(new Vector3(4.70155 , 2461.202 , -13.86277 , "None"));
Path.Add(new Vector3(4.447176 , 2457.04 , -13.86277 , "None"));
Path.Add(new Vector3(4.200659 , 2453.006 , -13.86277 , "None"));
Path.Add(new Vector3(4.14574 , 2448.838 , -13.86277 , "None"));
Path.Add(new Vector3(4.201082 , 2444.797 , -13.86277 , "None"));
Path.Add(new Vector3(4.271785 , 2440.756 , -13.86277 , "None"));
Path.Add(new Vector3(4.344743 , 2436.587 , -13.86277 , "None"));
Path.Add(new Vector3(4.415447 , 2432.547 , -13.86277 , "None"));
Path.Add(new Vector3(4.48615 , 2428.506 , -13.86277 , "None"));
Path.Add(new Vector3(4.559108 , 2424.337 , -13.86277 , "None"));
Path.Add(new Vector3(4.629812 , 2420.296 , -13.86277 , "None"));
Path.Add(new Vector3(4.700375 , 2416.264 , -13.86277 , "None"));
Path.Add(new Vector3(4.773473 , 2412.087 , -13.86277 , "None"));
Path.Add(new Vector3(4.844177 , 2408.046 , -13.86277 , "None"));
Path.Add(new Vector3(4.917275 , 2403.869 , -13.86277 , "None"));
Path.Add(new Vector3(4.987838 , 2399.836 , -13.86277 , "None"));
Path.Add(new Vector3(5.058542 , 2395.796 , -13.86277 , "None"));
Path.Add(new Vector3(5.131499 , 2391.627 , -13.86277 , "None"));
Path.Add(new Vector3(5.202203 , 2387.586 , -13.86277 , "None"));
Path.Add(new Vector3(5.272906 , 2383.546 , -13.86277 , "None"));
Path.Add(new Vector3(5.345864 , 2379.376 , -13.86277 , "None"));
Path.Add(new Vector3(5.416568 , 2375.336 , -13.86277 , "None"));
Path.Add(new Vector3(5.487272 , 2371.295 , -13.86277 , "None"));
Path.Add(new Vector3(5.560229 , 2367.126 , -13.86277 , "None"));
Path.Add(new Vector3(5.630932 , 2363.086 , -13.86277 , "None"));
Path.Add(new Vector3(5.701637 , 2359.045 , -13.86277 , "None"));
Path.Add(new Vector3(5.774594 , 2354.876 , -13.86277 , "None"));
Path.Add(new Vector3(5.843185 , 2350.956 , -13.86277 , "None"));
Path.Add(new Vector3(5.916001 , 2346.795 , -13.86277 , "None"));
Path.Add(new Vector3(5.986705 , 2342.754 , -13.86277 , "None"));
Path.Add(new Vector3(6.059662 , 2338.585 , -13.86277 , "None"));
Path.Add(new Vector3(6.130366 , 2334.545 , -13.86277 , "None"));
Path.Add(new Vector3(6.200929 , 2330.512 , -13.86277 , "None"));
Path.Add(new Vector3(6.271633 , 2326.472 , -13.86277 , "None"));
Path.Add(new Vector3(6.344731 , 2322.294 , -13.86277 , "None"));
Path.Add(new Vector3(6.415294 , 2318.262 , -13.86277 , "None"));
Path.Add(new Vector3(6.488393 , 2314.085 , -13.86277 , "None"));
Path.Add(new Vector3(6.559096 , 2310.044 , -13.86277 , "None"));
Path.Add(new Vector3(6.6298 , 2306.004 , -13.86277 , "None"));
Path.Add(new Vector3(6.700363 , 2301.971 , -13.86277 , "None"));
Path.Add(new Vector3(6.773461 , 2297.794 , -13.86277 , "None"));
Path.Add(new Vector3(6.846419 , 2293.625 , -14.65357 , "None"));
Path.Add(new Vector3(6.871335 , 2289.576 , -16.40299 , "None"));
Path.Add(new Vector3(6.715303 , 2285.683 , -18.08572 , "None"));
Path.Add(new Vector3(6.526338 , 2281.518 , -19.88617 , "None"));
Path.Add(new Vector3(6.34321 , 2277.481 , -20.63007 , "None"));
Path.Add(new Vector3(6.15388 , 2273.307 , -20.76896 , "None"));
Path.Add(new Vector3(5.970752 , 2269.27 , -22.5123 , "None"));
Path.Add(new Vector3(5.787989 , 2265.241 , -24.25226 , "None"));
Path.Add(new Vector3(5.613325 , 2261.204 , -25.99556 , "None"));
Path.Add(new Vector3(5.563163 , 2257.035 , -27.39697 , "None"));
Path.Add(new Vector3(5.586263 , 2252.994 , -27.39697 , "None"));
Path.Add(new Vector3(5.610145 , 2248.816 , -28.68373 , "None"));
Path.Add(new Vector3(5.633199 , 2244.783 , -30.42607 , "None"));
Path.Add(new Vector3(5.6563 , 2240.742 , -32.17218 , "None"));
Path.Add(new Vector3(5.680136 , 2236.572 , -33.97374 , "None"));
Path.Add(new Vector3(5.703236 , 2232.531 , -34.16386 , "None"));
Path.Add(new Vector3(5.726336 , 2228.49 , -34.16386 , "None"));
Path.Add(new Vector3(5.750219 , 2224.312 , -34.16386 , "None"));
Path.Add(new Vector3(5.772491 , 2220.416 , -35.6837 , "None"));
Path.Add(new Vector3(5.796373 , 2216.238 , -37.48939 , "None"));
Path.Add(new Vector3(5.819427 , 2212.205 , -39.2324 , "None"));
Path.Add(new Vector3(5.843309 , 2208.027 , -40.93081 , "None"));
Path.Add(new Vector3(5.86641 , 2203.986 , -40.93081 , "None"));
Path.Add(new Vector3(5.88951 , 2199.945 , -41.86475 , "None"));
Path.Add(new Vector3(5.912564 , 2195.912 , -43.60659 , "None"));
Path.Add(new Vector3(5.936447 , 2191.734 , -45.41064 , "None"));
Path.Add(new Vector3(5.959501 , 2187.701 , -47.15215 , "None"));
Path.Add(new Vector3(5.983429 , 2183.515 , -47.69772 , "None"));
Path.Add(new Vector3(6.006483 , 2179.482 , -48.03922 , "None"));
Path.Add(new Vector3(6.029583 , 2175.441 , -49.78525 , "None"));
Path.Add(new Vector3(6.052638 , 2171.408 , -51.52781 , "None"));
Path.Add(new Vector3(6.07652 , 2167.23 , -53.33318 , "None"));
Path.Add(new Vector3(6.099574 , 2163.197 , -54.46458 , "None"));
Path.Add(new Vector3(6.123456 , 2159.02 , -54.46458 , "None"));
Path.Add(new Vector3(6.146603 , 2154.97 , -54.46458 , "None"));
Path.Add(new Vector3(6.169611 , 2150.945 , -54.46458 , "None"));
Path.Add(new Vector3(6.193493 , 2146.768 , -54.46458 , "None"));
Path.Add(new Vector3(6.21733 , 2142.598 , -54.46458 , "None"));
Path.Add(new Vector3(6.241212 , 2138.42 , -54.46458 , "None"));
Path.Add(new Vector3(6.264266 , 2134.387 , -54.46458 , "None"));
Path.Add(new Vector3(6.288149 , 2130.209 , -54.46458 , "None"));
Path.Add(new Vector3(6.312031 , 2126.031 , -54.46458 , "None"));
Path.Add(new Vector3(6.335085 , 2121.998 , -54.46458 , "None"));
Path.Add(new Vector3(6.358968 , 2117.82 , -54.46458 , "None"));
Path.Add(new Vector3(6.382068 , 2113.779 , -54.46458 , "None"));
Path.Add(new Vector3(6.405122 , 2109.746 , -54.46458 , "None"));
Path.Add(new Vector3(6.428222 , 2105.705 , -54.46458 , "None"));
Path.Add(new Vector3(6.452059 , 2101.535 , -54.46458 , "None"));
Path.Add(new Vector3(6.475159 , 2097.494 , -54.46458 , "None"));
Path.Add(new Vector3(6.498259 , 2093.453 , -54.46458 , "None"));
Path.Add(new Vector3(6.522095 , 2089.283 , -54.46458 , "None"));
Path.Add(new Vector3(6.545196 , 2085.242 , -54.46458 , "None"));
Path.Add(new Vector3(6.568296 , 2081.201 , -54.46458 , "None"));
Path.Add(new Vector3(6.592132 , 2077.031 , -54.46458 , "None"));
Path.Add(new Vector3(6.615232 , 2072.99 , -54.46458 , "None"));
Path.Add(new Vector3(6.638332 , 2068.949 , -54.46458 , "None"));
Path.Add(new Vector3(6.662169 , 2064.78 , -54.46458 , "None"));
Path.Add(new Vector3(6.685269 , 2060.739 , -54.46458 , "None"));
Path.Add(new Vector3(6.709152 , 2056.561 , -54.46458 , "None"));
Path.Add(new Vector3(6.732206 , 2052.528 , -54.46458 , "None"));
Path.Add(new Vector3(6.755306 , 2048.487 , -54.46458 , "None"));
Path.Add(new Vector3(6.778406 , 2044.446 , -54.46458 , "None"));
Path.Add(new Vector3(6.801506 , 2040.405 , -54.46458 , "None"));
Path.Add(new Vector3(6.825343 , 2036.235 , -54.46458 , "None"));
Path.Add(new Vector3(6.848443 , 2032.194 , -54.46458 , "None"));
Path.Add(new Vector3(6.872279 , 2028.024 , -54.46458 , "None"));
Path.Add(new Vector3(6.894597 , 2024.12 , -54.46458 , "None"));
Path.Add(new Vector3(6.918479 , 2019.942 , -54.46458 , "None"));
Path.Add(new Vector3(6.94158 , 2015.901 , -54.46458 , "None"));
Path.Add(new Vector3(6.965416 , 2011.731 , -54.46458 , "None"));
Path.Add(new Vector3(6.988516 , 2007.69 , -54.46458 , "None"));
Path.Add(new Vector3(7.01157 , 2003.657 , -54.46458 , "None"));
Path.Add(new Vector3(7.035453 , 1999.479 , -54.46458 , "None"));
Path.Add(new Vector3(7.058553 , 1995.438 , -54.46458 , "None"));
Path.Add(new Vector3(7.081607 , 1991.405 , -54.46458 , "None"));
Path.Add(new Vector3(7.10549 , 1987.227 , -54.46458 , "None"));
Path.Add(new Vector3(7.12859 , 1983.186 , -54.46458 , "None"));
Path.Add(new Vector3(7.151644 , 1979.153 , -54.46458 , "None"));
Path.Add(new Vector3(7.175527 , 1974.975 , -54.46458 , "None"));
Path.Add(new Vector3(7.198627 , 1970.934 , -54.46458 , "None"));
Path.Add(new Vector3(7.222463 , 1966.764 , -54.46458 , "None"));
Path.Add(new Vector3(7.244781 , 1962.86 , -54.46458 , "None"));
Path.Add(new Vector3(7.267881 , 1958.819 , -54.46458 , "None"));
Path.Add(new Vector3(7.291717 , 1954.649 , -54.46458 , "None"));
Path.Add(new Vector3(7.314817 , 1950.608 , -54.46458 , "None"));
Path.Add(new Vector3(7.338654 , 1946.438 , -54.46458 , "None"));
Path.Add(new Vector3(7.361754 , 1942.397 , -54.46458 , "None"));
Path.Add(new Vector3(7.384854 , 1938.356 , -54.46458 , "None"));
Path.Add(new Vector3(7.407954 , 1934.315 , -54.46458 , "None"));
Path.Add(new Vector3(7.431791 , 1930.146 , -54.46458 , "None"));
Path.Add(new Vector3(7.454891 , 1926.104 , -54.46458 , "None"));
Path.Add(new Vector3(7.478727 , 1921.935 , -54.46458 , "None"));
Path.Add(new Vector3(7.501828 , 1917.894 , -55.66164 , "None"));
Path.Add(new Vector3(7.524928 , 1913.853 , -57.40812 , "None"));
Path.Add(new Vector3(7.548028 , 1909.812 , -59.15458 , "None"));
Path.Add(new Vector3(7.571864 , 1905.642 , -60.95708 , "None"));
Path.Add(new Vector3(7.595747 , 1901.464 , -61.23128 , "None"));
Path.Add(new Vector3(7.618847 , 1897.423 , -61.84317 , "None"));
Path.Add(new Vector3(7.641901 , 1893.39 , -63.58469 , "None"));
Path.Add(new Vector3(7.665047 , 1889.341 , -65.33334 , "None"));
Path.Add(new Vector3(7.688838 , 1885.179 , -67.13053 , "None"));
Path.Add(new Vector3(7.71272 , 1881.001 , -67.99829 , "None"));
Path.Add(new Vector3(7.735774 , 1876.968 , -68.0137 , "None"));
Path.Add(new Vector3(7.758874 , 1872.927 , -69.70394 , "None"));
Path.Add(new Vector3(7.781975 , 1868.886 , -71.50571 , "None"));
Path.Add(new Vector3(7.805121 , 1864.837 , -73.2552 , "None"));
Path.Add(new Vector3(7.828911 , 1860.675 , -74.76479 , "None"));
Path.Add(new Vector3(7.852011 , 1856.634 , -74.76479 , "None"));
Path.Add(new Vector3(7.874182 , 1852.754 , -74.76546 , "None"));
Path.Add(new Vector3(7.897236 , 1848.721 , -74.9473 , "None"));
Path.Add(new Vector3(7.898847 , 1827.25 , -81.43716 , "None"));
Path.Add(new Vector3(7.898847 , 1806.781 , -87.58905 , "None"));
Path.Add(new Vector3(7.898847 , 1785.538 , -91.50821 , "None"));
Path.Add(new Vector3(7.898847 , 1763.633 , -91.53044 , "None"));
Path.Add(new Vector3(7.898847 , 1742.446 , -91.55194 , "None"));
Path.Add(new Vector3(7.898847 , 1720.499 , -91.57422 , "None"));
Path.Add(new Vector3(7.898847 , 1699.27 , -91.59576 , "None"));
Path.Add(new Vector3(7.898847 , 1678.083 , -91.61727 , "None"));
Path.Add(new Vector3(7.898847 , 1656.855 , -91.63882 , "None"));
Path.Add(new Vector3(7.898847 , 1635.626 , -91.66036 , "None"));
Path.Add(new Vector3(7.898847 , 1613.72 , -91.68259 , "None"));
Path.Add(new Vector3(7.898847 , 1592.449 , -91.70418 , "None"));
Path.Add(new Vector3(7.898847 , 1570.544 , -91.72642 , "None"));
Path.Add(new Vector3(7.898847 , 1550.003 , -92.53382 , "None"));
Path.Add(new Vector3(7.898847 , 1528.776 , -98.94746 , "None"));
Path.Add(new Vector3(7.898848 , 1506.873 , -105.5655 , "None"));
Path.Add(new Vector3(7.898848 , 1484.927 , -112.1964 , "None"));
Path.Add(new Vector3(7.907974 , 1472.837 , -116.0216 , "None"));
Path.Add(new Vector3(7.922744 , 1462.853 , -119.3743 , "None"));
Path.Add(new Vector3(7.934911 , 1451.591 , -122.5382 , "None"));
Path.Add(new Vector3(7.957965 , 1447.558 , -124.2797 , "None"));
Path.Add(new Vector3(7.981295 , 1443.477 , -126.0421 , "None"));
Path.Add(new Vector3(8.004902 , 1439.347 , -127.8255 , "None"));
Path.Add(new Vector3(8.028048 , 1435.298 , -128.9008 , "None"));
Path.Add(new Vector3(8.051884 , 1431.129 , -128.9008 , "None"));
Path.Add(new Vector3(8.074985 , 1427.088 , -130.4581 , "None"));
Path.Add(new Vector3(8.098039 , 1423.054 , -132.2008 , "None"));
Path.Add(new Vector3(8.121139 , 1419.013 , -133.947 , "None"));
Path.Add(new Vector3(8.144975 , 1414.844 , -135.6677 , "None"));
Path.Add(new Vector3(8.168075 , 1410.803 , -135.6677 , "None"));
Path.Add(new Vector3(8.191957 , 1406.625 , -135.6677 , "None"));
Path.Add(new Vector3(8.214275 , 1402.72 , -135.6677 , "None"));
Path.Add(new Vector3(8.238111 , 1398.551 , -135.6677 , "None"));
Path.Add(new Vector3(8.261212 , 1394.51 , -135.6677 , "None"));
Path.Add(new Vector3(8.285048 , 1390.34 , -135.6677 , "None"));
Path.Add(new Vector3(8.308148 , 1386.299 , -135.6677 , "None"));
Path.Add(new Vector3(8.331248 , 1382.258 , -135.6677 , "None"));
Path.Add(new Vector3(8.354349 , 1378.217 , -135.6677 , "None"));
Path.Add(new Vector3(8.378185 , 1374.047 , -135.6677 , "None"));
Path.Add(new Vector3(8.401285 , 1370.006 , -135.6677 , "None"));
Path.Add(new Vector3(8.425122 , 1365.836 , -135.6677 , "None"));
Path.Add(new Vector3(8.448222 , 1361.795 , -135.6677 , "None"));
Path.Add(new Vector3(8.471322 , 1357.754 , -135.6677 , "None"));
Path.Add(new Vector3(8.494376 , 1353.721 , -135.6677 , "None"));
Path.Add(new Vector3(8.518259 , 1349.543 , -135.6677 , "None"));
Path.Add(new Vector3(8.541359 , 1345.502 , -135.6677 , "None"));
Path.Add(new Vector3(8.565195 , 1341.332 , -135.6677 , "None"));
Path.Add(new Vector3(8.588296 , 1337.291 , -135.6677 , "None"));
Path.Add(new Vector3(8.612132 , 1333.121 , -135.6677 , "None"));
Path.Add(new Vector3(8.635232 , 1329.08 , -135.6677 , "None"));
Path.Add(new Vector3(8.658332 , 1325.039 , -135.6677 , "None"));
Path.Add(new Vector3(8.682169 , 1320.87 , -135.6677 , "None"));
Path.Add(new Vector3(8.704487 , 1316.965 , -135.6677 , "None"));
Path.Add(new Vector3(8.728369 , 1312.787 , -135.6677 , "None"));
Path.Add(new Vector3(8.751423 , 1308.754 , -135.6677 , "None"));
Path.Add(new Vector3(8.775306 , 1304.577 , -135.6677 , "None"));
Path.Add(new Vector3(8.798406 , 1300.536 , -135.6677 , "None"));
Path.Add(new Vector3(8.821506 , 1296.494 , -135.6677 , "None"));
Path.Add(new Vector3(8.845343 , 1292.325 , -135.6677 , "None"));
Path.Add(new Vector3(8.868443 , 1288.284 , -135.6677 , "None"));
Path.Add(new Vector3(8.891542 , 1284.243 , -135.6677 , "None"));
Path.Add(new Vector3(8.770522 , 1280.076 , -135.6677 , "None"));
Path.Add(new Vector3(8.196379 , 1276.078 , -135.6677 , "None"));
Path.Add(new Vector3(7.494509 , 1272.107 , -135.6677 , "None"));
Path.Add(new Vector3(6.767423 , 1267.992 , -135.6677 , "None"));
Path.Add(new Vector3(6.041738 , 1263.886 , -135.6677 , "None"));
Path.Add(new Vector3(5.314651 , 1259.772 , -135.6677 , "None"));
Path.Add(new Vector3(4.934007 , 1255.628 , -135.6677 , "None"));
Path.Add(new Vector3(4.875655 , 1251.587 , -135.6677 , "None"));
Path.Add(new Vector3(4.834751 , 1247.546 , -135.6677 , "None"));
Path.Add(new Vector3(4.793098 , 1243.376 , -135.6677 , "None"));
Path.Add(new Vector3(4.752731 , 1239.335 , -135.6677 , "None"));
Path.Add(new Vector3(4.712364 , 1235.295 , -135.6677 , "None"));
Path.Add(new Vector3(4.671997 , 1231.254 , -135.6677 , "None"));
Path.Add(new Vector3(4.630746 , 1227.124 , -135.6677 , "None"));
Path.Add(new Vector3(4.589575 , 1223.003 , -135.6677 , "None"));
Path.Add(new Vector3(4.548162 , 1218.857 , -135.6677 , "None"));
Path.Add(new Vector3(4.507072 , 1214.744 , -135.6677 , "None"));
Path.Add(new Vector3(4.467509 , 1210.783 , -135.6677 , "None"));
Path.Add(new Vector3(4.42674 , 1206.702 , -135.6677 , "None"));
Path.Add(new Vector3(4.38565 , 1202.589 , -135.6677 , "None"));
Path.Add(new Vector3(4.345122 , 1198.532 , -135.6677 , "None"));
Path.Add(new Vector3(4.304111 , 1194.427 , -135.6677 , "None"));
Path.Add(new Vector3(4.263182 , 1190.329 , -135.6677 , "None"));
Path.Add(new Vector3(4.222574 , 1186.264 , -135.6677 , "None"));
Path.Add(new Vector3(4.182127 , 1182.215 , -135.6677 , "None"));
Path.Add(new Vector3(4.140553 , 1178.054 , -135.6677 , "None"));
Path.Add(new Vector3(4.100267 , 1174.021 , -135.6677 , "None"));
Path.Add(new Vector3(4.060061 , 1169.996 , -135.6677 , "None"));
Path.Add(new Vector3(4.017764 , 1165.762 , -135.6677 , "None"));
Path.Add(new Vector3(3.97804 , 1161.786 , -135.6677 , "None"));
Path.Add(new Vector3(3.937513 , 1157.729 , -135.6677 , "None"));
Path.Add(new Vector3(3.895779 , 1153.551 , -135.6677 , "None"));
Path.Add(new Vector3(3.855734 , 1149.542 , -135.6677 , "None"));
Path.Add(new Vector3(3.814321 , 1145.397 , -135.6677 , "None"));
Path.Add(new Vector3(3.774196 , 1141.38 , -135.6677 , "None"));
Path.Add(new Vector3(3.732542 , 1137.21 , -135.6677 , "None"));
Path.Add(new Vector3(3.692819 , 1133.234 , -135.6677 , "None"));
Path.Add(new Vector3(3.651809 , 1129.128 , -135.6677 , "None"));
Path.Add(new Vector3(3.611683 , 1125.112 , -135.6677 , "None"));
Path.Add(new Vector3(3.569869 , 1120.926 , -135.6677 , "None"));
Path.Add(new Vector3(3.529663 , 1116.901 , -135.6677 , "None"));
Path.Add(new Vector3(3.487928 , 1112.723 , -135.6677 , "None"));
Path.Add(new Vector3(3.447883 , 1108.715 , -135.6677 , "None"));
Path.Add(new Vector3(3.406793 , 1104.601 , -135.6677 , "None"));
Path.Add(new Vector3(3.367391 , 1100.657 , -135.6677 , "None"));
Path.Add(new Vector3(3.32622 , 1096.536 , -135.6677 , "None"));
Path.Add(new Vector3(3.285451 , 1092.454 , -135.6677 , "None"));
Path.Add(new Vector3(3.244843 , 1088.389 , -135.6677 , "None"));
Path.Add(new Vector3(3.202144 , 1084.115 , -134.982 , "None"));
Path.Add(new Vector3(3.16242 , 1080.139 , -133.2638 , "None"));
Path.Add(new Vector3(3.120687 , 1075.961 , -131.4587 , "None"));
Path.Add(new Vector3(3.080802 , 1071.968 , -129.7335 , "None"));
Path.Add(new Vector3(3.039792 , 1067.863 , -128.9008 , "None"));
Path.Add(new Vector3(2.999184 , 1063.798 , -128.8675 , "None"));
Path.Add(new Vector3(2.957932 , 1059.668 , -127.0844 , "None"));
Path.Add(new Vector3(2.918369 , 1055.708 , -125.3739 , "None"));
Path.Add(new Vector3(2.876796 , 1051.546 , -123.5766 , "None"));
Path.Add(new Vector3(2.837394 , 1047.602 , -122.1338 , "None"));
Path.Add(new Vector3(2.795419 , 1043.4 , -122.1338 , "None"));
Path.Add(new Vector3(2.75457 , 1039.311 , -120.9555 , "None"));
Path.Add(new Vector3(2.714203 , 1035.27 , -119.2089 , "None"));
Path.Add(new Vector3(2.671665 , 1031.012 , -117.3688 , "None"));
Path.Add(new Vector3(2.631137 , 1026.955 , -115.6156 , "None"));
Path.Add(new Vector3(2.590851 , 1022.922 , -115.367 , "None"));
Path.Add(new Vector3(2.550725 , 1018.905 , -115.367 , "None"));
Path.Add(new Vector3(2.510439 , 1014.872 , -115.367 , "None"));
Path.Add(new Vector3(2.468785 , 1010.703 , -113.8642 , "None"));
Path.Add(new Vector3(2.428579 , 1006.678 , -112.1252 , "None"));
Path.Add(new Vector3(2.387006 , 1002.516 , -110.3271 , "None"));
Path.Add(new Vector3(2.3468 , 998.4914 , -108.6 , "None"));
Path.Add(new Vector3(2.305468 , 994.3539 , -108.6 , "None"));
Path.Add(new Vector3(2.265463 , 990.3492 , -107.7345 , "None"));
Path.Add(new Vector3(2.223809 , 986.1795 , -105.9338 , "None"));
Path.Add(new Vector3(2.183603 , 982.1547 , -104.1956 , "None"));
Path.Add(new Vector3(2.143477 , 978.138 , -102.4608 , "None"));
Path.Add(new Vector3(2.100859 , 973.8717 , -101.8332 , "None"));
Path.Add(new Vector3(2.512776 , 970.073 , -101.6416 , "None"));
Path.Add(new Vector3(2.472731 , 966.0643 , -99.90893 , "None"));
Path.Add(new Vector3(2.432123 , 961.9992 , -98.15221 , "None"));
Path.Add(new Vector3(2.392158 , 957.9986 , -96.42336 , "None"));
Path.Add(new Vector3(2.349379 , 953.7162 , -95.06618 , "None"));
Path.Add(new Vector3(2.309655 , 949.7397 , -95.06618 , "None"));
Path.Add(new Vector3(2.268082 , 945.5781 , -95.06618 , "None"));
Path.Add(new Vector3(2.227072 , 941.4728 , -95.06618 , "None"));
Path.Add(new Vector3(2.187509 , 937.5123 , -95.06618 , "None"));
Path.Add(new Vector3(2.146499 , 933.407 , -95.06618 , "None"));
Path.Add(new Vector3(2.105569 , 929.3098 , -95.06618 , "None"));
Path.Add(new Vector3(2.064237 , 925.1723 , -95.06618 , "None"));
Path.Add(new Vector3(2.023629 , 921.1072 , -95.06618 , "None"));
Path.Add(new Vector3(1.984629 , 917.2032 , -95.06618 , "None"));
Path.Add(new Vector3(1.942413 , 912.9772 , -95.06618 , "None"));
Path.Add(new Vector3(1.901564 , 908.888 , -95.06618 , "None"));
Path.Add(new Vector3(1.861277 , 904.8551 , -95.06618 , "None"));
Path.Add(new Vector3(1.822065 , 900.8223 , -95.06624 , "None"));
Path.Add(new Vector3(1.953511 , 896.6549 , -95.06624 , "None"));
Path.Add(new Vector3(2.135246 , 892.6179 , -95.06624 , "None"));
Path.Add(new Vector3(2.322773 , 888.4522 , -95.06624 , "None"));
Path.Add(new Vector3(2.504869 , 884.4072 , -95.06624 , "None"));
Path.Add(new Vector3(2.686242 , 880.3782 , -95.06624 , "None"));
Path.Add(new Vector3(2.867976 , 876.3412 , -95.06624 , "None"));
Path.Add(new Vector3(3.055503 , 872.1755 , -95.06624 , "None"));
Path.Add(new Vector3(3.236876 , 868.1465 , -95.06624 , "None"));
Path.Add(new Vector3(3.425127 , 863.9648 , -95.06624 , "None"));
Path.Add(new Vector3(3.606499 , 859.9358 , -95.06624 , "None"));
Path.Add(new Vector3(3.788234 , 855.8988 , -95.06624 , "None"));
Path.Add(new Vector3(3.969969 , 851.8618 , -95.06624 , "None"));
Path.Add(new Vector3(4.157495 , 847.6961 , -95.06624 , "None"));
Path.Add(new Vector3(4.33923 , 843.6591 , -95.06624 , "None"));
Path.Add(new Vector3(4.430038 , 839.4906 , -95.06624 , "None"));
Path.Add(new Vector3(4.437276 , 835.4495 , -95.06624 , "None"));
Path.Add(new Vector3(4.451942 , 831.4084 , -95.06624 , "None"));
Path.Add(new Vector3(4.491621 , 827.2388 , -95.06624 , "None"));
Path.Add(new Vector3(4.53075 , 823.1818 , -95.06624 , "None"));
Path.Add(new Vector3(4.569646 , 819.1489 , -95.06624 , "None"));
Path.Add(new Vector3(4.608542 , 815.116 , -95.06624 , "None"));
Path.Add(new Vector3(4.648758 , 810.9463 , -95.06624 , "None"));
Path.Add(new Vector3(4.687732 , 806.9054 , -95.06624 , "None"));
Path.Add(new Vector3(4.727948 , 802.7357 , -95.06624 , "None"));
Path.Add(new Vector3(4.76731 , 798.6545 , -95.06624 , "None"));
Path.Add(new Vector3(4.805896 , 794.6539 , -95.06624 , "None"));
Path.Add(new Vector3(4.846112 , 790.4841 , -95.06624 , "None"));
Path.Add(new Vector3(4.885086 , 786.4432 , -95.06624 , "None"));
Path.Add(new Vector3(4.92406 , 782.4023 , -95.06624 , "None"));
Path.Add(new Vector3(4.964276 , 778.2326 , -95.06624 , "None"));
Path.Add(new Vector3(5.00325 , 774.1917 , -95.06624 , "None"));
Path.Add(new Vector3(5.043543 , 770.014 , -95.06624 , "None"));
Path.Add(new Vector3(5.081197 , 766.1099 , -95.06624 , "None"));
Path.Add(new Vector3(5.121414 , 761.9402 , -95.06624 , "None"));
Path.Add(new Vector3(5.16031 , 757.9073 , -95.06624 , "None"));
Path.Add(new Vector3(5.200603 , 753.7296 , -95.06624 , "None"));
Path.Add(new Vector3(5.239577 , 749.6887 , -95.06624 , "None"));
Path.Add(new Vector3(5.278551 , 745.6477 , -95.06624 , "None"));
Path.Add(new Vector3(5.318845 , 741.47 , -95.06624 , "None"));
Path.Add(new Vector3(5.364806 , 736.7046 , -95.06624 , "None"));
Path.Add(new Vector3(5.396094 , 733.4606 , -95.06624 , "None"));
Path.Add(new Vector3(5.436077 , 729.3151 , -95.06624 , "None"));
Path.Add(new Vector3(5.475439 , 725.2339 , -95.06624 , "None"));
Path.Add(new Vector3(5.514568 , 721.1769 , -95.06624 , "None"));
Path.Add(new Vector3(5.552921 , 717.2004 , -95.06624 , "None"));
Path.Add(new Vector3(5.593448 , 712.9985 , -95.06624 , "None"));
Path.Add(new Vector3(5.63281 , 708.9173 , -94.20473 , "None"));
Path.Add(new Vector3(5.671939 , 704.8603 , -92.45161 , "None"));
Path.Add(new Vector3(5.712233 , 700.6825 , -90.64639 , "None"));
Path.Add(new Vector3(5.751129 , 696.6497 , -88.90391 , "None"));
Path.Add(new Vector3(5.791422 , 692.4719 , -88.29935 , "None"));
Path.Add(new Vector3(5.830397 , 688.431 , -88.01702 , "None"));
Path.Add(new Vector3(5.870612 , 684.2613 , -86.21645 , "None"));
Path.Add(new Vector3(5.910906 , 680.0836 , -84.41231 , "None"));
Path.Add(new Vector3(5.951122 , 675.9138 , -82.61156 , "None"));
Path.Add(new Vector3(5.990096 , 671.8729 , -81.53247 , "None"));
Path.Add(new Vector3(6.028992 , 667.84 , -81.53247 , "None"));
Path.Add(new Vector3(6.069286 , 663.6623 , -79.98299 , "None"));
Path.Add(new Vector3(6.109502 , 659.4926 , -78.18061 , "None"));
Path.Add(new Vector3(6.149796 , 655.3148 , -76.37505 , "None"));
Path.Add(new Vector3(6.190012 , 651.1451 , -74.76548 , "None"));
Path.Add(new Vector3(6.228986 , 647.1042 , -74.76548 , "None"));
Path.Add(new Vector3(6.26796 , 643.0633 , -74.76548 , "None"));
Path.Add(new Vector3(6.308176 , 638.8936 , -74.55064 , "None"));
Path.Add(new Vector3(6.348469 , 634.7158 , -72.74561 , "None"));
Path.Add(new Vector3(6.387365 , 630.683 , -71.00307 , "None"));
Path.Add(new Vector3(6.426339 , 626.6421 , -69.25705 , "None"));
Path.Add(new Vector3(6.465313 , 622.6011 , -67.9986 , "None"));
Path.Add(new Vector3(6.505529 , 618.4314 , -67.9986 , "None"));
Path.Add(new Vector3(6.544503 , 614.3905 , -66.62843 , "None"));
Path.Add(new Vector3(6.583477 , 610.3496 , -64.88354 , "None"));
Path.Add(new Vector3(6.623383 , 606.2121 , -63.09684 , "None"));
Path.Add(new Vector3(6.662667 , 602.139 , -61.3376 , "None"));
Path.Add(new Vector3(6.701641 , 598.0981 , -61.23172 , "None"));
Path.Add(new Vector3(6.741935 , 593.9203 , -60.45125 , "None"));
Path.Add(new Vector3(6.780908 , 589.8794 , -58.70476 , "None"));
Path.Add(new Vector3(6.819805 , 585.8466 , -56.96176 , "None"));
Path.Add(new Vector3(6.858778 , 581.8057 , -55.21548 , "None"));
Path.Add(new Vector3(6.898995 , 577.6359 , -54.46476 , "None"));
Path.Add(new Vector3(6.939288 , 573.4582 , -54.46476 , "None"));
Path.Add(new Vector3(6.978185 , 569.4253 , -54.46476 , "None"));
Path.Add(new Vector3(7.017159 , 565.3844 , -54.46476 , "None"));
Path.Add(new Vector3(7.056132 , 561.3435 , -54.46476 , "None"));
Path.Add(new Vector3(7.096348 , 557.1738 , -54.46476 , "None"));
Path.Add(new Vector3(7.135322 , 553.1329 , -54.46476 , "None"));
Path.Add(new Vector3(7.174296 , 549.092 , -54.46476 , "None"));
Path.Add(new Vector3(7.214512 , 544.9222 , -54.46476 , "None"));
Path.Add(new Vector3(7.253486 , 540.8813 , -54.46476 , "None"));
Path.Add(new Vector3(7.292382 , 536.8484 , -54.46476 , "None"));
Path.Add(new Vector3(7.331356 , 532.8076 , -54.46476 , "None"));
Path.Add(new Vector3(7.37165 , 528.6298 , -54.46476 , "None"));
Path.Add(new Vector3(7.411866 , 524.4601 , -54.46476 , "None"));
Path.Add(new Vector3(7.338855 , 520.2839 , -54.46476 , "None"));
Path.Add(new Vector3(7.158949 , 516.2468 , -54.46476 , "None"));
Path.Add(new Vector3(7.018562 , 512.0793 , -54.46476 , "None"));
Path.Add(new Vector3(6.878412 , 507.9037 , -54.46476 , "None"));
Path.Add(new Vector3(6.743122 , 503.8729 , -54.46476 , "None"));
Path.Add(new Vector3(6.607561 , 499.8341 , -54.46476 , "None"));
Path.Add(new Vector3(6.472001 , 495.7953 , -54.46476 , "None"));
Path.Add(new Vector3(6.33185 , 491.6197 , -54.46476 , "None"));
Path.Add(new Vector3(6.196559 , 487.5889 , -54.46476 , "None"));
Path.Add(new Vector3(6.056679 , 483.4213 , -54.46476 , "None"));
Path.Add(new Vector3(5.921119 , 479.3825 , -54.46476 , "None"));
Path.Add(new Vector3(5.785558 , 475.3437 , -54.46476 , "None"));
Path.Add(new Vector3(5.649998 , 471.3048 , -54.46476 , "None"));
Path.Add(new Vector3(5.509847 , 467.1292 , -54.46476 , "None"));
Path.Add(new Vector3(5.374287 , 463.0904 , -54.46476 , "None"));
Path.Add(new Vector3(5.234676 , 458.9309 , -54.46476 , "None"));
Path.Add(new Vector3(5.099115 , 454.8921 , -54.46476 , "None"));
Path.Add(new Vector3(4.963555 , 450.8532 , -54.46476 , "None"));
Path.Add(new Vector3(4.909029 , 446.8129 , -54.46476 , "None"));
Path.Add(new Vector3(4.916495 , 442.643 , -54.46476 , "None"));
Path.Add(new Vector3(4.923746 , 438.5939 , -54.46476 , "None"));
Path.Add(new Vector3(4.931212 , 434.424 , -54.46476 , "None"));
Path.Add(new Vector3(4.938447 , 430.3829 , -54.46476 , "None"));
Path.Add(new Vector3(4.945669 , 426.3499 , -54.46476 , "None"));
Path.Add(new Vector3(4.95315 , 422.1719 , -54.46476 , "None"));
Path.Add(new Vector3(4.960371 , 418.1389 , -54.46476 , "None"));
Path.Add(new Vector3(4.967607 , 414.0978 , -54.46476 , "None"));
Path.Add(new Vector3(4.974828 , 410.0647 , -54.46476 , "None"));
Path.Add(new Vector3(4.982309 , 405.8868 , -54.46476 , "None"));
Path.Add(new Vector3(4.989544 , 401.8457 , -54.46476 , "None"));
Path.Add(new Vector3(4.997011 , 397.6758 , -54.46476 , "None"));
Path.Add(new Vector3(5.004261 , 393.6266 , -54.46476 , "None"));
Path.Add(new Vector3(5.011482 , 389.5936 , -54.46476 , "None"));
Path.Add(new Vector3(5.018718 , 385.5525 , -54.46476 , "None"));
Path.Add(new Vector3(5.025939 , 381.5195 , -54.46476 , "None"));
Path.Add(new Vector3(5.033406 , 377.3496 , -54.46476 , "None"));
Path.Add(new Vector3(5.040656 , 373.3004 , -54.46476 , "None"));
Path.Add(new Vector3(5.048122 , 369.1305 , -54.46476 , "None"));
Path.Add(new Vector3(5.055344 , 365.0975 , -54.46476 , "None"));
Path.Add(new Vector3(5.062579 , 361.0564 , -54.46476 , "None"));
Path.Add(new Vector3(5.07006 , 356.8784 , -54.46476 , "None"));
Path.Add(new Vector3(5.077281 , 352.8454 , -54.46476 , "None"));
Path.Add(new Vector3(5.084517 , 348.8043 , -54.46476 , "None"));
Path.Add(new Vector3(5.091753 , 344.7632 , -54.46476 , "None"));
Path.Add(new Vector3(5.098989 , 340.7221 , -54.46476 , "None"));
Path.Add(new Vector3(5.106455 , 336.5522 , -54.46476 , "None"));
Path.Add(new Vector3(5.113935 , 332.3743 , -52.84582 , "None"));
Path.Add(new Vector3(5.121402 , 328.2044 , -51.04399 , "None"));
Path.Add(new Vector3(5.128638 , 324.1633 , -49.29791 , "None"));
Path.Add(new Vector3(5.135628 , 320.2591 , -47.69794 , "None"));
Path.Add(new Vector3(5.143095 , 316.0892 , -47.69794 , "None"));
Path.Add(new Vector3(5.150331 , 312.0481 , -46.72762 , "None"));
Path.Add(new Vector3(5.157811 , 307.8701 , -44.92345 , "None"));
Path.Add(new Vector3(5.165032 , 303.8371 , -43.18177 , "None"));
Path.Add(new Vector3(5.172268 , 299.796 , -41.43642 , "None"));
Path.Add(new Vector3(5.179504 , 295.7549 , -40.93097 , "None"));
Path.Add(new Vector3(5.18697 , 291.585 , -40.55396 , "None"));
Path.Add(new Vector3(5.194206 , 287.5439 , -38.8073 , "None"));
Path.Add(new Vector3(5.201687 , 283.366 , -37.00156 , "None"));
Path.Add(new Vector3(5.208677 , 279.4617 , -35.31426 , "None"));
Path.Add(new Vector3(5.216144 , 275.2918 , -34.16413 , "None"));
Path.Add(new Vector3(5.22338 , 271.2507 , -34.16413 , "None"));
Path.Add(new Vector3(5.23086 , 267.0728 , -34.16413 , "None"));
Path.Add(new Vector3(5.238081 , 263.0398 , -33.4895 , "None"));
Path.Add(new Vector3(5.245548 , 258.8699 , -31.68777 , "None"));
Path.Add(new Vector3(5.252553 , 254.9576 , -29.99733 , "None"));
Path.Add(new Vector3(5.260034 , 250.7796 , -28.19217 , "None"));
Path.Add(new Vector3(5.267342 , 246.6983 , -27.3972 , "None"));
Path.Add(new Vector3(5.274693 , 242.5928 , -27.31903 , "None"));
Path.Add(new Vector3(5.28213 , 238.439 , -25.52533 , "None"));
Path.Add(new Vector3(5.289222 , 234.4784 , -23.81505 , "None"));
Path.Add(new Vector3(5.296486 , 230.4212 , -22.06284 , "None"));
Path.Add(new Vector3(5.303809 , 226.3318 , -20.63031 , "None"));
Path.Add(new Vector3(5.311073 , 222.2746 , -20.63031 , "None"));
Path.Add(new Vector3(5.318612 , 218.0645 , -19.3891 , "None"));
Path.Add(new Vector3(5.325833 , 214.0314 , -17.64592 , "None"));
Path.Add(new Vector3(5.333068 , 209.9903 , -15.89944 , "None"));
Path.Add(new Vector3(5.340535 , 205.8204 , -14.09745 , "None"));
Path.Add(new Vector3(5.347771 , 201.7793 , -13.86338 , "None"));
Path.Add(new Vector3(5.355006 , 197.7383 , -13.86338 , "None"));
Path.Add(new Vector3(5.362487 , 193.5603 , -13.86338 , "None"));
Path.Add(new Vector3(5.369709 , 189.5273 , -13.86338 , "None"));
Path.Add(new Vector3(5.376944 , 185.4862 , -13.86338 , "None"));
Path.Add(new Vector3(5.38441 , 181.3163 , -13.86338 , "None"));
Path.Add(new Vector3(5.391646 , 177.2752 , -13.86338 , "None"));
Path.Add(new Vector3(5.398868 , 173.2422 , -13.86338 , "None"));
Path.Add(new Vector3(5.406118 , 169.193 , -13.86338 , "None"));
Path.Add(new Vector3(5.413339 , 165.1599 , -13.86338 , "None"));
Path.Add(new Vector3(5.42082 , 160.982 , -13.86338 , "None"));
Path.Add(new Vector3(5.42807 , 156.9329 , -13.86338 , "None"));
Path.Add(new Vector3(5.435522 , 152.771 , -13.86338 , "None"));
Path.Add(new Vector3(5.442527 , 148.8587 , -13.86338 , "None"));
Path.Add(new Vector3(5.449979 , 144.6969 , -13.86338 , "None"));
Path.Add(new Vector3(5.457215 , 140.6558 , -13.86338 , "None"));
Path.Add(new Vector3(5.464681 , 136.4859 , -13.86338 , "None"));
Path.Add(new Vector3(5.471917 , 132.4448 , -13.86338 , "None"));
Path.Add(new Vector3(5.479398 , 128.2668 , -13.86338 , "None"));
Path.Add(new Vector3(5.486633 , 124.2258 , -13.86338 , "None"));
Path.Add(new Vector3(5.493984 , 120.1203 , -13.86338 , "None"));
Path.Add(new Vector3(5.501091 , 116.1516 , -13.86338 , "None"));
Path.Add(new Vector3(5.508571 , 111.9737 , -13.86338 , "None"));
Path.Add(new Vector3(5.515807 , 107.9326 , -13.86338 , "None"));
Path.Add(new Vector3(5.523028 , 103.8995 , -13.86338 , "None"));
Path.Add(new Vector3(5.530523 , 99.71356 , -13.86338 , "None"));
Path.Add(new Vector3(5.53773 , 95.68857 , -13.86338 , "None"));
Path.Add(new Vector3(5.544981 , 91.6394 , -13.86338 , "None"));
Path.Add(new Vector3(5.552432 , 87.4776 , -13.86338 , "None"));
Path.Add(new Vector3(5.559668 , 83.43646 , -13.86338 , "None"));
Path.Add(new Vector3(5.566904 , 79.39539 , -13.86338 , "None"));
Path.Add(new Vector3(5.574385 , 75.21744 , -13.86338 , "None"));
Path.Add(new Vector3(5.581851 , 71.04755 , -13.86338 , "None"));
Path.Add(new Vector3(5.589087 , 67.00644 , -13.86338 , "None"));
Path.Add(new Vector3(5.596308 , 62.97342 , -13.86338 , "None"));
Path.Add(new Vector3(5.603544 , 58.93231 , -13.86338 , "None"));
Path.Add(new Vector3(5.610779 , 54.89124 , -13.86338 , "None"));
Path.Add(new Vector3(5.618246 , 50.72134 , -13.86338 , "None"));
Path.Add(new Vector3(5.768416 , 46.72084 , -13.86338 , "None"));
Path.Add(new Vector3(8.0237 , 43.21617 , -13.86338 , "None"));
Path.Add(new Vector3(11.08088 , 40.66798 , -13.73228 , "None"));
Path.Add(new Vector3(15.00492 , 39.78679 , -11.78325 , "None"));
Path.Add(new Vector3(19.17288 , 39.67642 , -9.71308 , "None"));
Path.Add(new Vector3(23.21334 , 39.60427 , -7.706238 , "None"));
Path.Add(new Vector3(27.25379 , 39.53211 , -5.699401 , "None"));
Path.Add(new Vector3(31.2351 , 38.60181 , -4.297344 , "None"));
Path.Add(new Vector3(33.64272 , 35.43354 , -4.297344 , "None"));
Path.Add(new Vector3(34.39408 , 31.4701 , -4.297344 , "None"));
Path.Add(new Vector3(34.76578 , 27.44613 , -4.297344 , "None"));
Path.Add(new Vector3(35.14931 , 23.2939 , -4.297344 , "None"));
Path.Add(new Vector3(35.52101 , 19.26993 , -4.297344 , "None"));
Path.Add(new Vector3(35.95752 , 15.25254 , -4.297344 , "None"));
Path.Add(new Vector3(36.49623 , 11.25569 , -4.297344 , "None"));
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


public sealed class DeeprunTram2 : QuestFollowPathClass
{
    public DeeprunTram2()
    {
        Name = "Deeprun Tram2";

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

        Path.Add(new Vector3(34.63525 , 9.691954 , -4.297352 , "None"));
Path.Add(new Vector3(36.10656 , 9.860655 , -4.297352 , "None"));
Path.Add(new Vector3(40.27534 , 9.808837 , -4.297352 , "None"));
Path.Add(new Vector3(44.31023 , 10.02646 , -4.297352 , "None"));
Path.Add(new Vector3(48.47841 , 10.14596 , -4.297352 , "None"));
Path.Add(new Vector3(52.5189 , 10.21616 , -4.297352 , "None"));
Path.Add(new Vector3(56.68839 , 10.27489 , -4.297352 , "None"));
Path.Add(new Vector3(60.86596 , 10.33106 , -4.297352 , "None"));
Path.Add(new Vector3(65.03548 , 10.38713 , -4.297352 , "None"));
Path.Add(new Vector3(69.07622 , 10.44147 , -4.297352 , "None"));
Path.Add(new Vector3(72.31202 , 10.48498 , -4.297352 , "None"));
Path.Add(new Vector3(75.31202 , 10.52498 , -4.297352 , "None"));
Path.Add(new Vector3(-4838.95 , -1318.46 , 501.868 , "None"));
Path.Add(new Vector3(-4838.694 , -1316.732 , 501.868 , "None"));
Path.Add(new Vector3(-4838.085 , -1312.623 , 501.868 , "None"));
Path.Add(new Vector3(-4837.493 , -1308.625 , 501.868 , "None"));
Path.Add(new Vector3(-4836.921 , -1304.633 , 501.868 , "None"));
Path.Add(new Vector3(-4836.343 , -1300.504 , 501.868 , "None"));
Path.Add(new Vector3(-4835.765 , -1296.366 , 501.868 , "None"));
Path.Add(new Vector3(-4835.207 , -1292.372 , 501.868 , "None"));
Path.Add(new Vector3(-4834.665 , -1288.497 , 501.868 , "None"));
Path.Add(new Vector3(-4834.087 , -1284.367 , 501.868 , "None"));
Path.Add(new Vector3(-4833.901 , -1283.036 , 501.868 , "None"));
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


public sealed class DelivertheThread : QuestClass
{
    public DelivertheThread()
    {
        Name = "Deliver the Thread";

        QuestId.AddRange(new[] { 157 });

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


public sealed class DeliveriestoSven : QuestInteractWithClass
{
    public DeliveriestoSven()
    {
        Name = "Deliveries to Sven";

        QuestId.AddRange(new[] { 164 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

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


public sealed class DiggingThroughtheDirt : QuestClass
{
    public DiggingThroughtheDirt()
    {
        Name = "Digging Through the Dirt";

        QuestId.AddRange(new[] { 254 });

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


public sealed class DuskyCrabCakes : QuestGrinderClass
{
    public DuskyCrabCakes()
    {
        Name = "Dusky Crab Cakes";

        QuestId.AddRange(new[] { 93 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(217);
HotSpots.Add(new Vector3(-10063.35 , -736.4445 , 36.39679 , "None"));
HotSpots.Add(new Vector3(-10047.83 , -852.6973 , 33.19742 , "None"));
HotSpots.Add(new Vector3(-10026.81 , -804.707 , 34.29848 , "None"));
HotSpots.Add(new Vector3(-10015.71 , -628.8203 , 40.0485 , "None"));
HotSpots.Add(new Vector3(-9971.918 , -637.2176 , 33.57904 , "None"));
HotSpots.Add(new Vector3(-9949.773 , -616.3613 , 32.48023 , "None"));
HotSpots.Add(new Vector3(-10023.46 , -569.291 , 43.81518 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class EightLeggedMenaces : QuestGrinderClass
{
    public EightLeggedMenaces()
    {
        Name = "Eight-Legged Menaces";

        QuestId.AddRange(new[] { 245 });

        Step = new List<int> { 15, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(539);
HotSpots.Add(new Vector3(-10904.21 , 560.459 , 33.15455 , "None"));
HotSpots.Add(new Vector3(-10950.76 , 518.6113 , 37.26107 , "None"));
HotSpots.Add(new Vector3(-10490.55 , 576.1536 , 28.19838 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class FindingtheShadowyFigure : QuestClass
{
    public FindingtheShadowyFigure()
    {
        Name = "Finding the Shadowy Figure";

        QuestId.AddRange(new[] { 453 });

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


public sealed class GatherRotBlossoms : QuestGrinderClass
{
    public GatherRotBlossoms()
    {
        Name = "Gather Rot Blossoms";

        QuestId.AddRange(new[] { 156 });

        Step = new List<int> { 8, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(202);
HotSpots.Add(new Vector3(-10828.59 , -1316.34 , 48.24376 , "None"));
HotSpots.Add(new Vector3(-10825.98 , -1355.438 , 44.70178 , "None"));
HotSpots.Add(new Vector3(-10740.01 , -1361.243 , 36.88887 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class GhostHairThread : QuestClass
{
    public GhostHairThread()
    {
        Name = "Ghost Hair Thread";

        QuestId.AddRange(new[] { 149 });

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


public sealed class GhoulishEffigy : QuestGrinderClass
{
    public GhoulishEffigy()
    {
        Name = "Ghoulish Effigy";

        QuestId.AddRange(new[] { 133 });

        Step = new List<int> { 7, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(948);
EntryTarget.Add(210);
EntryTarget.Add(3);
HotSpots.Add(new Vector3(-10320.2 , 141.062 , 39.60136 , "None"));
HotSpots.Add(new Vector3(-10341.6 , 141.7676 , 34.58727 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class InquireattheInn : QuestClass
{
    public InquireattheInn()
    {
        Name = "Inquire at the Inn";

        QuestId.AddRange(new[] { 266 });

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


public sealed class JittersGrowlingGut : QuestClass
{
    public JittersGrowlingGut()
    {
        Name = "Jitters' Growling Gut";

        QuestId.AddRange(new[] { 5 });

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


public sealed class JuiceDelivery : QuestClass
{
    public JuiceDelivery()
    {
        Name = "Juice Delivery";

        QuestId.AddRange(new[] { 159 });

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


public sealed class LightforgeIron : QuestClass
{
    public LightforgeIron()
    {
        Name = "Lightforge Iron";

        QuestId.AddRange(new[] { 321 });

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


public sealed class LookToTheStars : QuestClass
{
    public LookToTheStars()
    {
        Name = "Look To The Stars";

        QuestId.AddRange(new[] { 174 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

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


public sealed class LookToTheStars1 : QuestClass
{
    public LookToTheStars1()
    {
        Name = "Look To The Stars1";

        QuestId.AddRange(new[] { 175 });

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


public sealed class LookToTheStars2 : QuestGrinderClass
{
    public LookToTheStars2()
    {
        Name = "Look To The Stars2";

        QuestId.AddRange(new[] { 177 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(511);
HotSpots.Add(new Vector3(-10995 , -1290.2 , 53.00969 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class LookToTheStars3 : QuestGrinderClass
{
    public LookToTheStars3()
    {
        Name = "Look To The Stars3";

        QuestId.AddRange(new[] { 181 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(300);
HotSpots.Add(new Vector3(-11224.8 , -160.547 , 5.91524 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MorbentFel : QuestUseItemOnClass
{
    public MorbentFel()
    {
        Name = "Morbent Fel";

        QuestId.AddRange(new[] { 55 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdTarget.Add(1200);
HotSpots.Add(new Vector3(-10317.9 , 376.991 , 65.26977 , "None"));
ItemId = 7297;
Range = 4.5f;

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class MorbentFel1 : QuestFollowPathClass
{
    public MorbentFel1()
    {
        Name = "Morbent Fel1";

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

        Path.Add(new Vector3(-10326.68 , 360.8847 , 63.71902 , "None"));
Path.Add(new Vector3(-10326.14 , 360.8632 , 64.09078 , "None"));
Path.Add(new Vector3(-10325.46 , 360.8362 , 64.55855 , "None"));
Path.Add(new Vector3(-10324.52 , 360.7985 , 65.21003 , "None"));
Path.Add(new Vector3(-10323.98 , 360.777 , 65.26823 , "None"));
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


public sealed class MorbentFel2 : QuestFollowPathClass
{
    public MorbentFel2()
    {
        Name = "Morbent Fel2";

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

        Path.Add(new Vector3(-10317.6 , 359.7822 , 65.24774 , "None"));
Path.Add(new Vector3(-10317.96 , 363.6693 , 65.24233 , "None"));
Path.Add(new Vector3(-10318.09 , 367.5712 , 65.26397 , "None"));
Path.Add(new Vector3(-10318.16 , 371.7485 , 65.26945 , "None"));
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


public sealed class MorganLadimore : QuestClass
{
    public MorganLadimore()
    {
        Name = "Morgan Ladimore";

        QuestId.AddRange(new[] { 227 });

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


public sealed class MorLadim : QuestGrinderClass
{
    public MorLadim()
    {
        Name = "Mor'Ladim";

        QuestId.AddRange(new[] { 228 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(522);
HotSpots.Add(new Vector3(-10389.96 , 280.0606 , 37.84521 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class NotetotheMayor : QuestClass
{
    public NotetotheMayor()
    {
        Name = "Note to the Mayor";

        QuestId.AddRange(new[] { 160 });

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


public sealed class OgreThieves : QuestGathererClass
{
    public OgreThieves()
    {
        Name = "Ogre Thieves";

        QuestId.AddRange(new[] { 134 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(119);
HotSpots.Add(new Vector3(-11090.03 , -66.19122 , 14.64334 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








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

        Path.Add(new Vector3(-10273.45 , 54.5305 , 42.42644 , "None"));
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


public sealed class ProvingYourWorth : QuestGrinderClass
{
    public ProvingYourWorth()
    {
        Name = "Proving Your Worth";

        QuestId.AddRange(new[] { 323 });

        Step = new List<int> { 15, 3, 3, 0, 0 };

        StepAutoDetect = new[] { false, false, true, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(1110);
EntryTarget.Add(787);
EntryTarget.Add(785);
HotSpots.Add(new Vector3(-10435.31 , 296.5224 , 37.49435 , "None"));
HotSpots.Add(new Vector3(-10421.96 , 371.91 , 44.5458 , "None"));
HotSpots.Add(new Vector3(-10423.07 , 373.4629 , 44.27502 , "None"));
HotSpots.Add(new Vector3(-10396.56 , 380.7344 , 46.85349 , "None"));
HotSpots.Add(new Vector3(-10428.53 , 398.2563 , 45.62436 , "None"));
HotSpots.Add(new Vector3(-10444.28 , 376.2461 , 44.0629 , "None"));
HotSpots.Add(new Vector3(-10394.85 , 416.971 , 30.32969 , "None"));
HotSpots.Add(new Vector3(-10390.45 , 365.4492 , 24.3923 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class RavenHill : QuestInteractWithClass
{
    public RavenHill()
    {
        Name = "Raven Hill";

        QuestId.AddRange(new[] { 163 });

        Step = new List<int> { 0, 0, 0, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

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


public sealed class ReturntheComb : QuestClass
{
    public ReturntheComb()
    {
        Name = "Return the Comb";

        QuestId.AddRange(new[] { 154 });

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


public sealed class ReturntoJitters : QuestClass
{
    public ReturntoJitters()
    {
        Name = "Return to Jitters";

        QuestId.AddRange(new[] { 240 });

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


public sealed class ReturntoSven : QuestClass
{
    public ReturntoSven()
    {
        Name = "Return to Sven";

        QuestId.AddRange(new[] { 268 });

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


public sealed class SeasonedWolfKabobs : QuestGrinderClass
{
    public SeasonedWolfKabobs()
    {
        Name = "Seasoned Wolf Kabobs";

        QuestId.AddRange(new[] { 90 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(565);
EntryTarget.Add(213);
EntryTarget.Add(1258);
EntryTarget.Add(628);
EntryTarget.Add(923);
HotSpots.Add(new Vector3(-10303.24 , -953.0685 , 40.33836 , "None"));
HotSpots.Add(new Vector3(-10279.14 , -937.1979 , 42.47367 , "None"));
HotSpots.Add(new Vector3(-10234.89 , -950.4298 , 37.86169 , "None"));
HotSpots.Add(new Vector3(-10230.25 , -954.8867 , 37.22288 , "None"));
HotSpots.Add(new Vector3(-10259.79 , -981.2693 , 43.0318 , "None"));
HotSpots.Add(new Vector3(-10268.19 , -1039.846 , 43.33458 , "None"));
HotSpots.Add(new Vector3(-10313.56 , -1015.086 , 44.28835 , "None"));
HotSpots.Add(new Vector3(-10349.31 , -982.8145 , 48.6403 , "None"));
HotSpots.Add(new Vector3(-10352.46 , -1042.321 , 48.69558 , "None"));
HotSpots.Add(new Vector3(-10402.4 , -1044.701 , 49.17926 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class SeekingWisdom : QuestClass
{
    public SeekingWisdom()
    {
        Name = "Seeking Wisdom";

        QuestId.AddRange(new[] { 269 });

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


public sealed class SuppliesfromDarkshire : QuestClass
{
    public SuppliesfromDarkshire()
    {
        Name = "Supplies from Darkshire";

        QuestId.AddRange(new[] { 148 });

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


public sealed class SvensCamp : QuestClass
{
    public SvensCamp()
    {
        Name = "Sven's Camp";

        QuestId.AddRange(new[] { 230 });

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


public sealed class SvensRevenge : QuestClass
{
    public SvensRevenge()
    {
        Name = "Sven's Revenge";

        QuestId.AddRange(new[] { 95 });

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


public sealed class TheDaughterWhoLived : QuestClass
{
    public TheDaughterWhoLived()
    {
        Name = "The Daughter Who Lived";

        QuestId.AddRange(new[] { 229 });

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


public sealed class TheDoomedFleet : QuestClass
{
    public TheDoomedFleet()
    {
        Name = "The Doomed Fleet";

        QuestId.AddRange(new[] { 270 });

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


public sealed class TheHermit : QuestClass
{
    public TheHermit()
    {
        Name = "The Hermit";

        QuestId.AddRange(new[] { 165 });

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


public sealed class TheLegendofStalvan1 : QuestClass
{
    public TheLegendofStalvan1()
    {
        Name = "The Legend of Stalvan1";

        QuestId.AddRange(new[] { 66 });

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


public sealed class TheLegendofStalvan10 : QuestClass
{
    public TheLegendofStalvan10()
    {
        Name = "The Legend of Stalvan10";

        QuestId.AddRange(new[] { 79 });

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


public sealed class TheLegendofStalvan11 : QuestClass
{
    public TheLegendofStalvan11()
    {
        Name = "The Legend of Stalvan11";

        QuestId.AddRange(new[] { 80 });

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


public sealed class TheLegendofStalvan12 : QuestClass
{
    public TheLegendofStalvan12()
    {
        Name = "The Legend of Stalvan12";

        QuestId.AddRange(new[] { 97 });

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


public sealed class TheLegendofStalvan13 : QuestGrinderClass
{
    public TheLegendofStalvan13()
    {
        Name = "The Legend of Stalvan13";

        QuestId.AddRange(new[] { 98 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(315);
HotSpots.Add(new Vector3(-10368 , -1254.99 , 35.90934 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheLegendofStalvan2 : QuestClass
{
    public TheLegendofStalvan2()
    {
        Name = "The Legend of Stalvan2";

        QuestId.AddRange(new[] { 67 });

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


public sealed class TheLegendofStalvan3 : QuestClass
{
    public TheLegendofStalvan3()
    {
        Name = "The Legend of Stalvan3";

        QuestId.AddRange(new[] { 68 });

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


public sealed class TheLegendofStalvan4 : QuestClass
{
    public TheLegendofStalvan4()
    {
        Name = "The Legend of Stalvan4";

        QuestId.AddRange(new[] { 69 });

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


public sealed class TheLegendofStalvan5 : QuestGathererClass
{
    public TheLegendofStalvan5()
    {
        Name = "The Legend of Stalvan5";

        QuestId.AddRange(new[] { 70 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(1560);
HotSpots.Add(new Vector3(-9463.261 , -1.144135 , 63.82084 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheLegendofStalvan6 : QuestClass
{
    public TheLegendofStalvan6()
    {
        Name = "The Legend of Stalvan6";

        QuestId.AddRange(new[] { 72 });

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


public sealed class TheLegendofStalvan7 : QuestClass
{
    public TheLegendofStalvan7()
    {
        Name = "The Legend of Stalvan7";

        QuestId.AddRange(new[] { 74 });

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


public sealed class TheLegendofStalvan8 : QuestGathererClass
{
    public TheLegendofStalvan8()
    {
        Name = "The Legend of Stalvan8";

        QuestId.AddRange(new[] { 75 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(1562);
HotSpots.Add(new Vector3(-9550.332 , -1437.491 , 62.29562 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheLegendofStalvan9 : QuestClass
{
    public TheLegendofStalvan9()
    {
        Name = "The Legend of Stalvan9";

        QuestId.AddRange(new[] { 78 });

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


public sealed class TheLostIngots : QuestGrinderClass
{
    public TheLostIngots()
    {
        Name = "The Lost Ingots";

        QuestId.AddRange(new[] { 324 });

        Step = new List<int> { 5, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(1418);
HotSpots.Add(new Vector3(-3947.66 , -900.5996 , 0.4634691 , "None"));
HotSpots.Add(new Vector3(-3945.18 , -900.9121 , -0.2400485 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheMissingDiplomat1 : QuestClass
{
    public TheMissingDiplomat1()
    {
        Name = "The Missing Diplomat1";

        QuestId.AddRange(new[] { 1274 });

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


public sealed class TheMissingDiplomat10 : QuestClass
{
    public TheMissingDiplomat10()
    {
        Name = "The Missing Diplomat10";

        QuestId.AddRange(new[] { 1248 });

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


public sealed class TheMissingDiplomat11 : QuestClass
{
    public TheMissingDiplomat11()
    {
        Name = "The Missing Diplomat11";

        QuestId.AddRange(new[] { 1249 });

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


public sealed class TheMissingDiplomat12 : QuestClass
{
    public TheMissingDiplomat12()
    {
        Name = "The Missing Diplomat12";

        QuestId.AddRange(new[] { 1264 });

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


public sealed class TheMissingDiplomat2 : QuestClass
{
    public TheMissingDiplomat2()
    {
        Name = "The Missing Diplomat2";

        QuestId.AddRange(new[] { 1241 });

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


public sealed class TheMissingDiplomat3 : QuestClass
{
    public TheMissingDiplomat3()
    {
        Name = "The Missing Diplomat3";

        QuestId.AddRange(new[] { 1242 });

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


public sealed class TheMissingDiplomat4 : QuestClass
{
    public TheMissingDiplomat4()
    {
        Name = "The Missing Diplomat4";

        QuestId.AddRange(new[] { 1243 });

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


public sealed class TheMissingDiplomat5 : QuestGathererClass
{
    public TheMissingDiplomat5()
    {
        Name = "The Missing Diplomat5";

        QuestId.AddRange(new[] { 1244 });

        Step = new List<int> { 1, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryIdObjects.Add(21052);
HotSpots.Add(new Vector3(-11014.84 , 186.1146 , 28.79178 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheMissingDiplomat6 : QuestClass
{
    public TheMissingDiplomat6()
    {
        Name = "The Missing Diplomat6";

        QuestId.AddRange(new[] { 1245 });

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


public sealed class TheMissingDiplomat7 : QuestClass
{
    public TheMissingDiplomat7()
    {
        Name = "The Missing Diplomat7";

        QuestId.AddRange(new[] { 1246 });

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


public sealed class TheMissingDiplomat8 : QuestClass
{
    public TheMissingDiplomat8()
    {
        Name = "The Missing Diplomat8";

        QuestId.AddRange(new[] { 1447 });

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


public sealed class TheMissingDiplomat9 : QuestClass
{
    public TheMissingDiplomat9()
    {
        Name = "The Missing Diplomat9";

        QuestId.AddRange(new[] { 1247 });

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


public sealed class TheNightWatch : QuestGrinderClass
{
    public TheNightWatch()
    {
        Name = "The Night Watch";

        QuestId.AddRange(new[] { 56 });

        Step = new List<int> { 8, 6, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(203);
EntryTarget.Add(48);
HotSpots.Add(new Vector3(-10980.9 , -1381.33 , 60.95174 , "None"));
HotSpots.Add(new Vector3(-10998.43 , -1314.285 , 52.68778 , "None"));
HotSpots.Add(new Vector3(-10979.17 , -1342.75 , 51.73606 , "None"));
HotSpots.Add(new Vector3(-10961.65 , -1321.43 , 52.6362 , "None"));
HotSpots.Add(new Vector3(-10922.63 , -1274.892 , 52.85566 , "None"));
HotSpots.Add(new Vector3(-10999.78 , -1318.299 , 52.49065 , "None"));
HotSpots.Add(new Vector3(-11010.55 , -1381.035 , 53.89775 , "None"));
HotSpots.Add(new Vector3(-10953.88 , -1384.551 , 65.07394 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheNightWatch1 : QuestGrinderClass
{
    public TheNightWatch1()
    {
        Name = "The Night Watch1";

        QuestId.AddRange(new[] { 57 });

        Step = new List<int> { 15, 15, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(202);
EntryTarget.Add(531);
HotSpots.Add(new Vector3(-10557.13 , 217.9818 , 29.96107 , "None"));
HotSpots.Add(new Vector3(-10581.26 , 244.6377 , 30.98368 , "None"));
HotSpots.Add(new Vector3(-10577.92 , 269.0825 , 33.05276 , "None"));
HotSpots.Add(new Vector3(-10561.16 , 271.2627 , 28.8046 , "None"));
HotSpots.Add(new Vector3(-10578.44 , 352.7402 , 28.47007 , "None"));
HotSpots.Add(new Vector3(-10585.5 , 393.5234 , 31.81904 , "None"));
HotSpots.Add(new Vector3(-10486.05 , 235.5748 , 31.87921 , "None"));
HotSpots.Add(new Vector3(-10502.54 , 205.5616 , 32.81958 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheNightWatch2 : QuestGrinderClass
{
    public TheNightWatch2()
    {
        Name = "The Night Watch2";

        QuestId.AddRange(new[] { 58 });

        Step = new List<int> { 20, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 3;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(604);
HotSpots.Add(new Vector3(-10389.08 , 169.771 , 35.15225 , "None"));
HotSpots.Add(new Vector3(-10355.79 , 201.5957 , 34.49996 , "None"));
HotSpots.Add(new Vector3(-10347.1 , 201.353 , 32.579 , "None"));
HotSpots.Add(new Vector3(-10341.7 , 172.724 , 15.80442 , "None"));
HotSpots.Add(new Vector3(-10334.9 , 137.397 , 4.07517 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class TheShadowyFigure : QuestClass
{
    public TheShadowyFigure()
    {
        Name = "The Shadowy Figure";

        QuestId.AddRange(new[] { 262 });

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


public sealed class TheShadowySearchContinues : QuestClass
{
    public TheShadowySearchContinues()
    {
        Name = "The Shadowy Search Continues";

        QuestId.AddRange(new[] { 265 });

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


public sealed class TheTotemofInfliction : QuestClass
{
    public TheTotemofInfliction()
    {
        Name = "The Totem of Infliction";

        QuestId.AddRange(new[] { 101 });

        Step = new List<int> { 10, 5, 10, 0, 0 };

        StepAutoDetect = new[] { false, false, true, false, false };

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


public sealed class TheTotemofInfliction1 : QuestGrinderClass
{
    public TheTotemofInfliction1()
    {
        Name = "The Totem of Infliction1";

        QuestId.AddRange(new[] { 101 });

        Step = new List<int> { 10, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(948);
EntryTarget.Add(3);
HotSpots.Add(new Vector3(-10401.39 , 153.3164 , 35.29732 , "None"));
HotSpots.Add(new Vector3(-10414.99 , 147.8691 , 35.51954 , "None"));
HotSpots.Add(new Vector3(-10361.96 , 246.2916 , 35.51508 , "None"));
HotSpots.Add(new Vector3(-10328.61 , 196.4316 , 34.15562 , "None"));
HotSpots.Add(new Vector3(-10329.81 , 242.2813 , 34.04996 , "None"));
HotSpots.Add(new Vector3(-10351.91 , 199.4484 , 33.48401 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(1129) >=10;
}



public override bool HasQuest() { return true; }


}


public sealed class TheTotemofInfliction2 : QuestGrinderClass
{
    public TheTotemofInfliction2()
    {
        Name = "The Totem of Infliction2";

        QuestId.AddRange(new[] { 101 });

        Step = new List<int> { 0, 5, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(930);
HotSpots.Add(new Vector3(-10842.34 , -1344.13 , 48.67524 , "None"));
HotSpots.Add(new Vector3(-10679.5 , -1387.177 , 46.445 , "None"));
HotSpots.Add(new Vector3(-10685.65 , -1338.035 , 47.93646 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(1130) >=5;
}



public override bool HasQuest() { return true; }


}


public sealed class TheTotemofInfliction3 : QuestGrinderClass
{
    public TheTotemofInfliction3()
    {
        Name = "The Totem of Infliction3";

        QuestId.AddRange(new[] { 101 });

        Step = new List<int> { 0, 0, 10, 0, 0 };

        StepAutoDetect = new[] { false, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(202);
EntryTarget.Add(48);
EntryTarget.Add(203);
HotSpots.Add(new Vector3(-10827.99 , -1353.307 , 45.16023 , "None"));
HotSpots.Add(new Vector3(-10802.95 , -1369.965 , 40.29245 , "None"));
HotSpots.Add(new Vector3(-10919.42 , -1338.064 , 53.10578 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}

public override bool IsComplete() { 
return ItemsManager.GetItemCountById(2378) >=10;
}



public override bool HasQuest() { return true; }


}


public sealed class TranslateAbercrombiesNote : QuestClass
{
    public TranslateAbercrombiesNote()
    {
        Name = "Translate Abercrombie's Note";

        QuestId.AddRange(new[] { 251 });

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


public sealed class TranslationtoEllo : QuestClass
{
    public TranslationtoEllo()
    {
        Name = "Translation to Ello";

        QuestId.AddRange(new[] { 252 });

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


public sealed class WaitforSirratoFinish : QuestClass
{
    public WaitforSirratoFinish()
    {
        Name = "Wait for Sirra to Finish";

        QuestId.AddRange(new[] { 401 });

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


public sealed class WolvesatOurHeels : QuestGrinderClass
{
    public WolvesatOurHeels()
    {
        Name = "Wolves at Our Heels";

        QuestId.AddRange(new[] { 226 });

        Step = new List<int> { 12, 8, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(213);
EntryTarget.Add(565);
HotSpots.Add(new Vector3(-10249.07 , 539.1191 , 28.9451 , "None"));
HotSpots.Add(new Vector3(-10226 , 492.2584 , 26.44434 , "None"));
HotSpots.Add(new Vector3(-10213.32 , 470.2718 , 29.71223 , "None"));
HotSpots.Add(new Vector3(-10209.08 , 447.6035 , 36.55344 , "None"));
HotSpots.Add(new Vector3(-10190.92 , 416.3337 , 36.04617 , "None"));
HotSpots.Add(new Vector3(-10182.11 , 281.2285 , 23.73979 , "None"));
HotSpots.Add(new Vector3(-10177.13 , 6.875317 , 26.37732 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WorgenintheWoods : QuestGrinderClass
{
    public WorgenintheWoods()
    {
        Name = "Worgen in the Woods";

        QuestId.AddRange(new[] { 173 });

        Step = new List<int> { 6, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(533);
HotSpots.Add(new Vector3(-10667.13 , -778.3105 , 66.02763 , "None"));
HotSpots.Add(new Vector3(-10488.14 , -844.9749 , 52.07412 , "None"));
HotSpots.Add(new Vector3(-10513.07 , -876.5881 , 47.35188 , "None"));
HotSpots.Add(new Vector3(-10537.92 , -923.7199 , 46.59419 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WorgenintheWoods1 : QuestGrinderClass
{
    public WorgenintheWoods1()
    {
        Name = "Worgen in the Woods1";

        QuestId.AddRange(new[] { 221 });

        Step = new List<int> { 12, 0, 0, 0, 0 };

        StepAutoDetect = new[] { true, false, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(205);
HotSpots.Add(new Vector3(-10458.02 , -821.5695 , 50.93819 , "None"));
HotSpots.Add(new Vector3(-10451.97 , -891.5625 , 44.09809 , "None"));
HotSpots.Add(new Vector3(-10532.3 , -953.3418 , 45.24125 , "None"));
HotSpots.Add(new Vector3(-10575.34 , -952.0024 , 48.24911 , "None"));
HotSpots.Add(new Vector3(-10636.75 , -925.8878 , 53.72087 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WorgenintheWoods2 : QuestGrinderClass
{
    public WorgenintheWoods2()
    {
        Name = "Worgen in the Woods2";

        QuestId.AddRange(new[] { 222 });

        Step = new List<int> { 8, 8, 0, 0, 0 };

        StepAutoDetect = new[] { false, true, false, false, false };

        PickUpQuestOnItem = false;
        PickUpQuestOnItemID = 0;

        GossipOptionItem = 1;

        WoWClass = wManager.Wow.Enums.WoWClass.None;
        MinLevel = 0;
        MaxLevel = 100;
        RequiredQuest = 0;

        EntryTarget.Add(206);
EntryTarget.Add(920);
HotSpots.Add(new Vector3(-11005.91 , -1066.092 , 52.79255 , "None"));
HotSpots.Add(new Vector3(-11031.48 , -1106.755 , 40.97078 , "None"));
HotSpots.Add(new Vector3(-11018.27 , -1089.613 , 42.65503 , "None"));
HotSpots.Add(new Vector3(-11077.47 , -1140.987 , 42.85264 , "None"));

    }

	public override bool CanConditions()
	{
        return true;
	}








}


public sealed class WorgenintheWoods3 : QuestClass
{
    public WorgenintheWoods3()
    {
        Name = "Worgen in the Woods3";

        QuestId.AddRange(new[] { 223 });

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


public sealed class ZombieJuice : QuestClass
{
    public ZombieJuice()
    {
        Name = "Zombie Juice";

        QuestId.AddRange(new[] { 158 });

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
