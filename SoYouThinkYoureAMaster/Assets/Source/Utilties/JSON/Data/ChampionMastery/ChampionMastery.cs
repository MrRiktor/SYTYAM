#region File Header

/*******************************************************************************
 * Author: Matthew "Riktor" Baker
 * Filename: ChampionMastery.cs
 * Date Created: 4/26/2015 10:42PM EST
 * 
 * Description: ChampionMastery Data Class
 * 
 * Changelog:   - N/A
 *******************************************************************************/

#endregion

#region Using Directives

using System;

#endregion

#region ChampData Public Enumerator

public enum ChampionMasteryData
{
    championId,
    championLevel,
    championPoints,
    championPointsSinceLastLevel,
    championPointsUntilNextLevel,
    chestGranted,
    highestGrade,
    lastPlayTime,
    playerId
};

#endregion

public class ChampionMastery
{
    #region Constant Property Names

    public static class PropertyNames
    {
        public static readonly String ChampionId = "championId";
        public static readonly String ChampionLevel = "championLevel";
        public static readonly String ChampionPoints = "championPoints";
        public static readonly String ChampionPointsSinceLastLevel = "championPointsSinceLastLevel";
        public static readonly String ChampionPointsUntilNextLevel = "championPointsUntilNextLevel";
        public static readonly String ChestGranted = "chestGranted";
        public static readonly String HighestGrade = "highestGrade";
        public static readonly String LastPlayTime = "lastPlayTime";
        public static readonly String PlayerId = "playerId";
    }

    #endregion

    #region Private Member Variables

    /// <summary>
    /// Champion ID for this entry.
    /// </summary>
    private long championId;

    /// <summary>
    /// Champion level for specified player and champion combination.
    /// </summary>
    private int championLevel;

    /// <summary>
    /// Total number of champion points for this player and champion combination - they are used to determine championLevel.
    /// </summary>
    private int championPoints;
    
    /// <summary>
    /// Number of points earned since current level has been achieved.Zero if player reached maximum champion level for this champion.
    /// </summary>
    private long championPointsSinceLastLevel;

    /// <summary>
    /// Number of points needed to achieve next level.Zero if player reached maximum champion level for this champion.
    /// </summary>
    private long championPointsUntilNextLevel;

    /// <summary>
    /// Is chest granted for this champion or not in current season.
    /// </summary>
    private bool chestGranted;

    /// <summary>
    /// The highest grade of this champion of current season.
    /// </summary>
    private string highestGrade;

    /// <summary>
    /// Last time this champion was played by this player - in Unix milliseconds time format.
    /// </summary>
    private long lastPlayTime;

    /// <summary>
    /// Player ID for this entry.
    /// </summary>
    private long playerId;

    #endregion

    #region Accessors/Modifiers

    /// <summary>
    /// Champion ID for this entry.
    /// </summary>
    public long ChampionId
    {
        get
        {
            return championId;
        }
        set
        {
            championId = value;
        }
    }

    /// <summary>
    /// Champion level for specified player and champion combination.
    /// </summary>
    public int ChampionLevel
    {
        get
        {
            return championLevel;
        }
        set
        {
            championLevel = value;
        }
    }

    /// <summary>
    /// Total number of champion points for this player and champion combination - they are used to determine championLevel.
    /// </summary>
    public int ChampionPoints
    {
        get
        {
            return championPoints;
        }
        set
        {
            championPoints = value;
        }
    }

    /// <summary>
    /// Number of points earned since current level has been achieved.Zero if player reached maximum champion level for this champion.
    /// </summary>
    public long ChampionPointsSinceLastLevel
    {
        get
        {
            return championPointsSinceLastLevel;
        }
        set
        {
            championPointsSinceLastLevel = value;
        }
    }

    /// <summary>
    /// Number of points needed to achieve next level.Zero if player reached maximum champion level for this champion.
    /// </summary>
    public long ChampionPointsUntilNextLevel
    {
        get
        {
            return championPointsUntilNextLevel;
        }
        set
        {
            championPointsUntilNextLevel = value;
        }
    }

    /// <summary>
    /// Is chest granted for this champion or not in current season.
    /// </summary>
    public bool ChestGranted
    {
        get
        {
            return chestGranted;
        }
        set
        {
            chestGranted = value;
        }
    }

    /// <summary>
    /// The highest grade of this champion of current season.
    /// </summary>
    public string HighestGrade
    {
        get
        {
            return highestGrade;
        }
        set
        {
            highestGrade = value;
        }
    }

    /// <summary>
    /// Last time this champion was played by this player - in Unix milliseconds time format.
    /// </summary>
    public long LastPlayTime
    {
        get
        {
            return lastPlayTime;
        }
        set
        {
            lastPlayTime = value;
        }
    }

    /// <summary>
    /// Player ID for this entry.
    /// </summary>
    public long PlayerId
    {
        get
        {
            return playerId;
        }
        set
        {
            playerId = value;
        }
    }

    #endregion

    public static ChampionMastery fromJSON(object rawResponse)
    {
        if (rawResponse is String)
        {
            String json = (String)rawResponse;
            JsonFx.Json.JsonReader reader = JSONUtils.getJsonReader(json);

            ChampionMastery championMastery = new ChampionMastery();
            championMastery = reader.Deserialize<ChampionMastery>();

            return championMastery;
        }

        return new ChampionMastery();
    }

    public static ChampionMastery[] fromJSONArray(object rawResponse)
    {
        if (rawResponse is String)
        {
            String json = (String)rawResponse;
            JsonFx.Json.JsonReader reader = JSONUtils.getJsonReader(json);

            ChampionMastery[] championMasteryList = reader.Deserialize<ChampionMastery[]>();

            return championMasteryList;
        }

        return null;
    }
}

