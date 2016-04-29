#region File Header

/*******************************************************************************
 * Author: Matthew "Riktor" Baker
 * Filename: Summoner.cs
 * Date Created: 4/26/2015 10:42PM EST
 * 
 * Description: Summoner Data Class
 * 
 * Changelog:   - N/A
 *******************************************************************************/

#endregion

#region Using Directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#endregion

#region ChampData Public Enumerator

public enum SummonerData
{
    id,
    name,
    revisionDate,
    profileIconId,
    summonerLevel,
};

#endregion

public class Summoner
{
    #region Constant Property Names

    public static class PropertyNames
    {
        public static readonly String ID = "id";
        public static readonly String Name = "name";
        public static readonly String RevisionDate = "revisionDate";
        public static readonly String ProfileIconID = "profileIconId";
        public static readonly String SummonerLevel = "summonerLevel";
    }

    #endregion

    #region Private Member Variables

    /// <summary>
    /// ID of the summoner icon associated with the summoner.
    /// </summary>
    private long id;

    /// <summary>
    /// Summoner Name
    /// </summary>
    private string name;

    /// <summary>
    /// Date summoner was last modified specified as epoch milliseconds. The following events will update this timestamp: profile icon change, playing the tutorial or advanced tutorial, finishing a game, summoner name change
    /// </summary>
    private long revisionDate;
    /// <summary>
    /// ID of the summoner icon associated with the summoner.
    /// </summary>
    private int profileIconId;

    /// <summary>
    /// Summoner level associated with the summoner.
    /// </summary>
    private long summonerLevel;

    #endregion

    #region Accessors/Modifiers

    /// <summary>
    /// ID of the summoner icon associated with the summoner.
    /// </summary>
    public long ID
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }

    /// <summary>
    /// Summoner Name
    /// </summary>
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    /// <summary>
    /// Date summoner was last modified specified as epoch milliseconds. The following events will update this timestamp: profile icon change, playing the tutorial or advanced tutorial, finishing a game, summoner name change
    /// </summary>
    public long RevisionDate
    {
        get
        {
            return revisionDate;
        }
        set
        {
            revisionDate = value;
        }
    }
    /// <summary>
    /// ID of the summoner icon associated with the summoner.
    /// </summary>
    public int ProfileIconID
    {
        get
        {
            return profileIconId;
        }
        set
        {
            profileIconId = value;
        }
    }

    /// <summary>
    /// Summoner level associated with the summoner.
    /// </summary>
    public long SummonerLevel
    {
        get
        {
            return summonerLevel;
        }
        set
        {
            summonerLevel = value;
        }
    }

    #endregion

    public static Summoner fromJSON(object rawResponse)
    {
        if (rawResponse is String)
        {
            String json = (String)rawResponse;
            JsonFx.Json.JsonReader reader = JSONUtils.getJsonReader(json);

            Summoner summoner = new Summoner();
            summoner = reader.Deserialize<Summoner>();

            return summoner;
        }

        return new Summoner();
    }
}

