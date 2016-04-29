#region File Header

/*******************************************************************************
 * Author: Matthew "Riktor" Baker
 * Filename: RiotAPIConstants.cs
 * Date Created: 4/11/2015 7:28PM EST
 * 
 * Description: A static class that stores Riot's API call strings and provides functionality for getting the json request links.
 * 
 * Changelog:   - Modified: Matthew "Riktor" Baker - 4/16/2015 9:01 PM - Added Comments
 *******************************************************************************/

#endregion

#region Using Directives

using System;
using System.Collections.Generic;

#endregion

#region Public Enumerator

/// <summary>
/// A region enumerator list.
/// </summary>
public class Region
{
    public enum RegionEnum
    {
        na = 0, // NorthAmerica
        br,     // Brazil
        eune,   // EUNordicAndEast
        euw,    // EuropeWest
        jp,
        kr,     // Korea
        lan,    // LatinAmericaNorth
        las,    // LatinAmericaSouth
        oce,    // Oceania
        ru,     // Russia
        tr,     // Turkey
    }

    public enum PlatformID
    {
        NA1 = 0, // NorthAmerica
        BR1,     // Brazil
        EUN1,    // EUNordicAndEast
        EUW1,    // EuropeWest
        JP1,     // JaPan
        KR,     // Korea
        LA1,    // LatinAmericaNorth
        LA2,    // LatinAmericaSouth
        OC1,    // Oceania
        RU,     // Russia
        TR1,     // Turkey
    }

    private static PlatformID[] regionToPlatformArray = {   PlatformID.NA1, // NorthAmerica
                                                            PlatformID.BR1,     // Brazil
                                                            PlatformID.EUN1,    // EUNordicAndEast
                                                            PlatformID.EUW1,    // EuropeWest
                                                            PlatformID.JP1,     // JaPan
                                                            PlatformID.KR,     // Korea
                                                            PlatformID.LA1,    // LatinAmericaNorth
                                                            PlatformID.LA2,    // LatinAmericaSouth
                                                            PlatformID.OC1,    // Oceania
                                                            PlatformID.RU,     // Russia
                                                            PlatformID.TR1 };

    public static PlatformID GetPlatformID( Region.RegionEnum region )
    {
        int regionInt = (int)region;

        return regionToPlatformArray[regionInt];
    }
}

#endregion

public static class RiotAPIConstants
{
    #region Private Variables
    
    /// <summary>
    /// The API Key you are using.
    /// </summary>
    private static String API_KEY_SUFFIX = "2068601a-b030-462c-a5ff-3d81fede0471";
    
    /// <summary>
    /// The API prefix for the majority of the API calls.
    /// </summary>
    private static String API_Prefix(Region.RegionEnum region, bool isChampionMastery=false)
    {
        string url = "https://" + region.ToString() + ".api.pvp.net/";

        if (!isChampionMastery)
        {
            url += "api/lol/";
        }

        return url;
    }

    /// <summary>
    /// DataDragons API prefix.
    /// </summary>
    private static String DD_API_Prefix = "http://ddragon.leagueoflegends.com/cdn/";

    /// <summary>
    /// Riot's Global API prefix
    /// </summary>
    private static String Global_API_Prefix = "https://global.api.pvp.net/api/lol/";

    /// <summary>
    /// The version of DD we are wanting to use.
    /// </summary>
    private static String DD_Version = "5.5.2/";

    /// <summary>
    /// Riot's Observer API prefix
    /// </summary>
    //private static String Observer_Prefix = "https://na.api.pvp.net/observer-mode/rest/";

    /// <summary>
    /// Riot's Shard API prefix
    /// </summary>
    //private static String Shard_Prefix = "http://status.leagueoflegends.com/shards/";

    #endregion

    #region Public Methods
            
    public static bool READ_FROM_FILES = true;

    #region Champion Mastery

    /// <summary>
    /// Returns a single champions mastery for a given summoner.
    /// </summary>
    /// <param name="summonerId"> ID of the summoner we are looking up for. </param>
    /// <param name="championId"> Champion we are looking up </param>
    /// <param name="region"> the region the summoner is in. </param>
    /// <returns></returns>
    public static String CHAMPIONMASTERY_SINGLE_CHAMPION( long summonerId, long championId, Region.RegionEnum region = Region.RegionEnum.na)
    {
        return API_Prefix(region, true) + "championmastery/location/" + Region.GetPlatformID(region) + "/player/" + summonerId + "/champion/" + championId + "?api_key=" + API_KEY_SUFFIX;
    }

    /// <summary>
    /// Returns all champions masteries for a given summoner.
    /// </summary>    
    /// <param name="summonerId"> ID of the summoner we are looking up for. </param>
    /// <param name="region"> the region the summoner is in. </param>
    /// <returns></returns>
    public static String CHAMPIONMASTERY_ALL_CHAMPIONS(long summonerId, Region.RegionEnum region = Region.RegionEnum.na)
    {
        return API_Prefix(region, true) + "championmastery/location/" + Region.GetPlatformID(region) + "/player/" + summonerId + "/champions?api_key=" + API_KEY_SUFFIX;
    }

    /// <summary>
    /// Returns a list of top champions masteries for a given summoner.
    /// </summary>    
    /// <param name="summonerId"> ID of the summoner we are looking up for. </param>
    /// <param name="region"> the region the summoner is in. </param>
    /// <param name="count"> number of champions to return. </param>
    /// <returns></returns>
    public static String CHAMPIONMASTERY_TOP_CHAMPIONS(long summonerId, Region.RegionEnum region = Region.RegionEnum.na, int count=3 )
    {
        return API_Prefix(region, true) + "championmastery/location/" + Region.GetPlatformID(region) + "/player/" + summonerId + "/topchampions?count=" + count + "&api_key=" + API_KEY_SUFFIX;
    }

    /// <summary>
    /// Returns the total mastery score for a summoner.
    /// </summary>    
    /// <param name="summonerId"> ID of the summoner we are looking up for. </param>
    /// <param name="region"> the region the summoner is in. </param>
    /// <returns></returns>
    public static String CHAMPIONMASTERY_TOTAL_MASTERY_SCORE(long summonerId, Region.RegionEnum region = Region.RegionEnum.na)
    {
        return API_Prefix(region, true) + "championmastery/location/" + Region.GetPlatformID(region) + "/player/" + summonerId + "/score?api_key=" + API_KEY_SUFFIX;
    }

    #endregion

    #region Summoner-v1.4

    /// <summary>
    /// 
    /// </summary>
    /// <param name="summonerNames"></param>
    /// <param name="region"></param>
    /// <returns></returns>
    public static String SUMMONERIDS_FROM_SUMMONER_NAME( string [] summonerNames, Region.RegionEnum region = Region.RegionEnum.na, string version = "1.4" )
    {
        String urlString = API_Prefix(region) + region.ToString() + "/v" + version + "/summoner/by-name/";


        for( int i = 0; i < summonerNames.Length; ++i )
        {
            urlString += summonerNames[i];

            if( !i.Equals( summonerNames.Length-1 ) )
            {
                urlString += ",";
            }
        }

        return urlString + "?api_key=" + API_KEY_SUFFIX;
    }

    #endregion

    /// <summary>
    /// Gets a Champion Portrait hyperlink from datadragon.
    /// </summary>
    /// <param name="ChampionName">The name of the champion we want. </param>
    /// <param name="skinIndex">The skin index of the champion (0 is normal skin)</param>
    /// <returns> hyperlink to the portrait </returns>
    public static String CHAMPION_PORTRAIT_HYPERLINK(String ChampionName="Aatrox", byte skinIndex = 0)
    {
        // Example:  http//ddragon.leagueoflegends.com/cdn/img/champion/loading/Aatrox_0.jpg
        return DD_API_Prefix + "img/champion/loading/" + ChampionName + "_" + skinIndex.ToString() + ".jpg";
    }

    /// <summary>
    /// Get a champion icon hyperlink from datadragon
    /// </summary>
    /// <param name="ChampionName"> the name of the champion we want. </param>
    /// <returns> hyperlink to the icon </returns>
    public static String CHAMPION_ICON_HYPERLINK( String ChampionName="Aatrox" )
    {
        // Example: http//ddragon.leagueoflegends.com/cdn/5.2.1/img/champion/Aatrox.png
        return DD_API_Prefix + DD_Version + "img/champion/" + ChampionName + ".png";
    }

    /// <summary>
    /// Returns a champions details JSON string.
    /// </summary>
    /// <param name="id"> The champion ID. </param>
    /// <param name="region"> The region we are looking to grab from. </param>
    /// <returns>cahmpion details json string</returns>
    public static String CHAMPION_STATIC_DATA( int id=17, ChampData champData=ChampData.minimal, Region.RegionEnum region = Region.RegionEnum.na )
    {
        // EXAMPLE: https;//global.api.pvp.net/api/lol/static-data/na/v1.2/champion/30?api_key=1069372c-3d2d-4734-964c-53434511b8f8
        if (champData == ChampData.minimal)
        {
            return API_Prefix(region) + "static-data/" + region.ToString() + "/" + "v1.2/champion/" + id.ToString() + "&api_key=" + API_KEY_SUFFIX;
        }
        else 
        {
            return API_Prefix(region) + "static-data/" + region.ToString() + "/" + "v1.2/champion/" + id.ToString() + "?champData=" + champData.ToString() + "&api_key=" + API_KEY_SUFFIX;
        }
    }

    /// <summary>
    /// Returns the API Challenge match list Json String
    /// </summary>
    /// <param name="region">the region we want the matches from</param>
    /// <param name="beginDate"> the begin date we want to look at. Has to be either 0 or 5 minute intervals with no seconds.</param>
    /// <returns> API Challenge match list Json string</returns>
    public static String API_CHALLENGE_MATCH_LIST(Region.RegionEnum region, long beginDate )
    {
        long remainder = (beginDate % 100);
        
        if ( remainder != 0 )
        {
            beginDate -= remainder;
        }
        
        UnityEngine.Debug.Log(beginDate);

        // https;//na.api.pvp.net//api/lol/{region}/v4.1/game/ids?beginDate={beginDate}&api_key=API_KEY_SUFFIX
        return API_Prefix(region) + region.ToString() + "/" + "v4.1/game/ids?beginDate=" + beginDate + "&api_key=" + API_KEY_SUFFIX;
    }
    
    /// <summary>
    /// Returns a Champions data Json string. The results depend upon what type of data you are requesting about the champion (See: ChampData)
    /// </summary>
    /// <param name="region"> the region you are looking to retrieve from </param>
    /// <param name="champData">the information about the champion you wish to retrieve. (See: ChampData)</param>
    /// <returns>Champion data Json string</returns>
    public static String CHAMPIONv1_2(Region.RegionEnum region, ChampData champData)
    {
        // https;//global.api.pvp.net/api/lol/static-data/na/v1.2/champion?champData=stats&api_key=API_KEY_SUFFIX
        return Global_API_Prefix + "static-data/" + region.ToString() + "/" + "v1.2/champion?champData=" + champData.ToString() + "&api_key=" + API_KEY_SUFFIX;
    }

    /// <summary>
    /// Return a match with a specified ID in a specified region.
    /// </summary>
    /// <param name="region">the region you wish to retrieve from. </param>
    /// <param name="matchID">the match id of the match you wish to retrieve. </param>
    /// <returns>a matches Json string</returns>
    public static String MATCHv2_2(Region.RegionEnum region, long matchID)
    {
        // "/api/lol/{region}/v2.2/match/{matchID}?api_key=API_KEY_SUFFIX"
        return API_Prefix(region) + region.ToString() + "/" + "v2.2/match/" + matchID + "?api_key=" + API_KEY_SUFFIX;
    }

    #endregion
}

