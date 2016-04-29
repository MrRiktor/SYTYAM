#region File Header

/*******************************************************************************
 * Author: Matthew "Riktor" Baker
 * Filename: Player.cs
 * Date Created: 4/11/2015 8:28PM EST
 * 
 * Description: Player Data Class
 * 
 * Changelog:   - Modified: Matthew "Riktor" Baker - 4/16/2015 9:01 PM - Added Comments
 *******************************************************************************/

#endregion

#region Using Directives

using System;

#endregion

public class Player
{
    #region Private Constants

    public static class PropertyNames
    {
        public static readonly String MatchHistoryUrl = "matchHistoryUrl";
        public static readonly String ProfileIcon = "profileIcon";
        public static readonly String SummonerId = "summonerId";
        public static readonly String SummonerName = "summonerName";
    };

    #endregion

    #region Private Member Variables
    
    /// <summary>
    /// Match history URI
    /// </summary>
    private String matchHistoryUrl;
    
    /// <summary>
    /// Profile icon ID
    /// </summary>
    private int profileIcon;
    
    /// <summary>
    /// Summoner ID
    /// </summary>
    private long summonerId;
    
    /// <summary>
    /// Summoner name
    /// </summary>
    private String summonerName;

    #endregion

    #region Accessors/Modifiers

        /// <summary>
    /// Match history URL
    /// </summary>
    public String MatchHistoryUrl
    {
        get
        {
            return matchHistoryUrl;
        }
        set
        {
            this.matchHistoryUrl = value;
        }
    }
    
    /// <summary>
    /// Profile icon ID
    /// </summary>
    public int ProfileIcon
    {
        get
        {
            return profileIcon;
        }
        set
        {
            this.profileIcon = value;
        }
    }
    
    /// <summary>
    /// Summoner ID
    /// </summary>
    public long SummonerId
    {
        get
        {
            return summonerId;
        }
        set
        {
            this.summonerId = value;
        }
    }
    
    /// <summary>
    /// Summoner name
    /// </summary>
    public String SummonerName
    {
        get
        {
            return summonerName;
        }
        set
        {
            this.summonerName = value;
        }
    }

    #endregion

    public Player fromJSON(object obj)
    {
        return this;
    }
}
